using Danielson.Data.DataAccess;
using Danielson.Data.DataModels;
using Danielson.Data.Domains;
using Danielson.Data.EditingRules;
using Danielson.Data.FinalAnswers;
using Danielson.Data.Login;
using Danielson.Data.PortalTranslator;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;

namespace Danielson.Components.Pages.Form {

    public partial class Domain {
        private bool _areAllComponentsAnsweredProcessed = false;

        private RoleEnum _currentRole = RoleEnum.None;

        public List<string> ComponentsNotAnswered { get; set; } = default!;
        public Data.DataModels.Form CurrentForm { get; set; } = default!;
        public FormTemplate CurrentFormTemplate { get; set; } = default!;

        public DomainObject DomainObject { get; set; } = default!;

        public List<string> FinalAnswers { get; set; } = default!;

        [Parameter]
        public int FormId { get; set; }

        public FormImportInformation FormImportInformation { get; set; } = default!;
        public bool IsReadOnly { get; set; }
        public bool ShowFinal { get; set; }

        [Inject]
        protected AuthenticationStateProvider AuthenticationStateProvider { get; set; } = default!;

        [Inject]
        protected FormAccess ComponentAnswerHandler { get; set; } = default!;

        [Inject]
        protected FormImport FormImport { get; set; } = default!;

        [Inject]
        protected FormTemplateAccess FormTemplateAccess { get; set; } = default!;

        [Inject]
        protected IJSRuntime JsRuntime { get; set; } = default!;

        [Inject]
        protected NavigationManager NavigationManager { get; set; } = default!;

        [Inject]
        protected UserAccess UserAccess { get; set; } = default!;

        public bool AreAllComponentsAnswered() {
            if (!_areAllComponentsAnsweredProcessed) {
                ComponentsNotAnswered = [];
                if (CurrentForm.ShowComponents) {
                    foreach (var domain in DomainList.Domains) {
                        ComponentsNotAnswered.AddRange(domain.Components.Where(c => !CurrentForm.ComponentAnswers.Where(ca => ca.DomainItem == domain.DomainEnum).Select(ca => ca.ComponentOrder).Contains(c.ComponentOrder)).Select(c => c.Title));
                    }
                } else {
                    foreach (var domain in DomainList.Domains) {
                        if (string.IsNullOrWhiteSpace(CurrentForm.DomainAnswers.FirstOrDefault(da => da.DomainItem == domain.DomainEnum)?.NextSteps)) {
                            ComponentsNotAnswered.Add(domain.Title + " Next Steps");
                        }
                        if (string.IsNullOrWhiteSpace(CurrentForm.DomainAnswers.FirstOrDefault(da => da.DomainItem == domain.DomainEnum)?.Strengths)) {
                            ComponentsNotAnswered.Add(domain.Title + " Strengths");
                        }
                    }
                }
                _areAllComponentsAnsweredProcessed = true;
            }
            return ComponentsNotAnswered.Count == 0;
        }

        public async Task ChangeFormType(bool isMidterm) {
            CurrentForm.IsMidterm = isMidterm;
            var username = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity?.Name ?? "";
            _ = await FormImport.Save(CurrentForm, username);
            NavigationManager.NavigateTo(NavigationManager.Uri, true);
        }

        public bool IsFormSigned() {
            var rolesAbleToUnsign = new List<RoleEnum> { RoleEnum.Admin, RoleEnum.CoteStaff, RoleEnum.ProgramStaff };
            return CurrentForm.IsSigned || rolesAbleToUnsign.Contains(_currentRole);
        }

        protected void AddComponentAnswerToForm(ComponentAnswer componentAnswer) {
            CurrentForm.LastUpdated = DateTime.Now;
            StateHasChanged();
            CurrentForm.AddComponentAnswerToForm(componentAnswer);
        }

        protected void AddDomainAnswerToForm(DomainAnswer domainAnswer) {
            CurrentForm.LastUpdated = DateTime.Now;
            StateHasChanged();
            CurrentForm.AddDomainAnswerToForm(domainAnswer);
        }

        protected async Task ChangePage(DomainEnum? domainEnum, bool finish) {
            CurrentForm.LastUpdated = DateTime.Now;
            ShowFinal = finish;
            var username = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity?.Name ?? "";
            _ = await FormImport.Save(CurrentForm, username);
            _areAllComponentsAnsweredProcessed = false;
            DomainObject = DomainList.Domains.First(d => d.DomainEnum == (finish ? DomainEnum.Four : domainEnum ?? DomainEnum.One));
            StateHasChanged();
            await JsRuntime.InvokeVoidAsync("CollapseAll");
            await JsRuntime.InvokeVoidAsync("OnScrollEvent");
        }

        protected async Task ChangePageNext() {
            switch (DomainObject.DomainEnum) {
                case DomainEnum.One:
                    await ChangePage(DomainEnum.Two, false);
                    break;

                case DomainEnum.Two:
                    await ChangePage(DomainEnum.Three, false);
                    break;

                case DomainEnum.Three:
                    await ChangePage(DomainEnum.Four, false);
                    break;

                case DomainEnum.Four:
                    await ChangePage(DomainEnum.Four, true);
                    break;

                default:
                    break;
            }
        }

        protected async Task ChangePagePrevious() {
            if (ShowFinal) {
                await ChangePage(DomainEnum.Four, false);
            } else {
                switch (DomainObject.DomainEnum) {
                    case DomainEnum.Two:
                        await ChangePage(DomainEnum.One, false);
                        break;

                    case DomainEnum.Three:
                        await ChangePage(DomainEnum.Two, false);
                        break;

                    case DomainEnum.Four:
                        await ChangePage(DomainEnum.Three, false);
                        break;

                    default:
                        break;
                }
            }
        }

        protected void CheckFinal() {
            CurrentForm.DateEvaluated = CurrentForm.DateEvaluated.HasValue ? null : DateTime.Now;
        }

        protected async Task CollapseAll() {
            await JsRuntime.InvokeVoidAsync("CollapseAll");
        }

        protected async Task ExpandAll() {
            await JsRuntime.InvokeVoidAsync("ExpandAll");
        }

        protected override async Task OnInitializedAsync() {
            DomainObject = DomainList.Domains.First();
            ShowFinal = false;

            var email = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity?.Name;
            FormImportInformation = FormImport.Get(FormId);

            CurrentForm = await ComponentAnswerHandler.GetForm(FormId);
            if (CurrentForm.Id == 0) {
                CurrentForm = new Data.DataModels.Form {
                    AssignmentId = FormId,
                    FormTemplateInternalLookupString = FormImportInformation.FormTemplateInternalLookupString,
                    IsMidterm = FormImportInformation.IsMidterm,
                    Email = email ?? "-------------",
                    PlacementType = FormImportInformation.PlacementType,
                    Position = FormImportInformation.Position,
                    SemesterDate = FormImportInformation.Semester,
                    ShowComponents = FormImportInformation.ShowComponents,
                    ShowNotObserved = FormImportInformation.ShowNotObserved,
                    ShowQuantitativeAnswer = FormImportInformation.ShowQuantitativeAnswer,
                    Student = FormImportInformation.StudentName,
                    StudentId = FormImportInformation.StudentId,
                    StudentEvaluationId = FormImportInformation.StudentEvaluationId,
                    Title = FormImportInformation.Title,
                    FinalSummary = FormImportInformation.FinalScoreText,
                    DateEvaluated = FormImportInformation.DateEvaluated,
                    IsActive = true,
                    LastUpdated = DateTime.Now
                };
                _ = await ComponentAnswerHandler.Create(CurrentForm);
            } else {
                CurrentForm.SemesterDate = FormImportInformation.Semester;
                CurrentForm.FormTemplateInternalLookupString = FormImportInformation.FormTemplateInternalLookupString;
                CurrentForm.Email = email ?? "-------------";
                CurrentForm.PlacementType = FormImportInformation.PlacementType;
                CurrentForm.Position = FormImportInformation.Position;
                CurrentForm.SemesterDate = FormImportInformation.Semester;
                CurrentForm.ShowComponents = FormImportInformation.ShowComponents;
                CurrentForm.ShowNotObserved = FormImportInformation.ShowNotObserved;
                CurrentForm.ShowQuantitativeAnswer = FormImportInformation.ShowQuantitativeAnswer;
                CurrentForm.Student = FormImportInformation.StudentName;
                CurrentForm.StudentId = FormImportInformation.StudentId;
                CurrentForm.Title = FormImportInformation.Title;
                CurrentForm.FinalSummary = FormImportInformation.FinalScoreText;
                CurrentForm.DateEvaluated = FormImportInformation.DateEvaluated;
                CurrentForm.LastUpdated = FormImportInformation.LastUpdated;
            }
            CurrentFormTemplate = await FormTemplateAccess.Get(FormImportInformation.FormTemplateInternalLookupString);
            FinalAnswers = FinalAnswerGenerator.GetFinalAnswers(CurrentForm);
            var roleType = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Claims.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Role)?.Value;
            _ = Enum.TryParse(roleType, out _currentRole);
            IsReadOnly = ReadOnlyGenerator.IsReadOnly(CurrentForm, _currentRole);
            StateHasChanged();
            await base.OnInitializedAsync();
        }

        protected async Task SaveForm() {
            CurrentForm.LastUpdated = DateTime.Now;
            _ = await ComponentAnswerHandler.Save(CurrentForm);
            var username = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity?.Name ?? "";
            _ = await FormImport.Save(CurrentForm, username);
            await JsRuntime.InvokeVoidAsync("AlertOnScreen");
            var roleType = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Claims.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Role)?.Value;
            _ = Enum.TryParse(roleType, out RoleEnum role);
            NavigationManager.NavigateTo(UserAccess.TargetUrl[role], true);
        }
    }
}