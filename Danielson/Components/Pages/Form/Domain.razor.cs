using Danielson.Data.DataAccess;
using Danielson.Data.DataModels;
using Danielson.Data.Domains;
using Danielson.Data.PortalTranslator;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Danielson.Components.Pages.Form {

    public partial class Domain {
        public Data.DataModels.Form CurrentForm { get; set; } = default!;

        public DomainObject DomainObject { get; set; } = default!;
        public List<string> FinalAnswers { get; set; } = default!;
        public FormExportInformation FormExportInformation { get; set; } = default!;

        [Parameter]
        public int FormId { get; set; }

        public bool ShowFinal { get; set; }

        [Inject]
        protected FormAccess ComponentAnswerHandler { get; set; } = default!;

        [Inject]
        protected FormTemplateAccess FormTemplateAccess { get; set; } = default!;

        [Inject]
        protected IJSRuntime JsRuntime { get; set; } = default!;

        [Inject]
        protected NavigationManager NavigationManager { get; set; } = default!;

        public void ChangeFormType(bool isMidterm) {
            CurrentForm.IsMidterm = isMidterm;
            NavigationManager.NavigateTo(NavigationManager.Uri, true);
        }

        protected void AddComponentAnswerToForm(ComponentAnswer componentAnswer) => CurrentForm.AddComponentAnswerToForm(componentAnswer);

        protected void AddDomainAnswerToForm(DomainAnswer domainAnswer) => CurrentForm.AddDomainAnswerToForm(domainAnswer);

        protected async Task ChangePage(DomainEnum? domainEnum, bool finish) {
            ShowFinal = finish;
            DomainObject = DomainList.Domains.First(d => d.DomainEnum == (finish ? DomainEnum.Four : domainEnum ?? DomainEnum.One));
            StateHasChanged();
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

            CurrentForm = await ComponentAnswerHandler.GetForm(FormId);
            FinalAnswers = await FormTemplateAccess.GetFinalAnswerOptions(CurrentForm.Id);

            //TODO Add export pull
            FormExportInformation = new FormExportInformation {
                EvaluatedBy = "Talbott, Susan",
                Title = "CI-410: Acello, Grace"
            };
            //TODO Add authentication

            await base.OnInitializedAsync();
        }

        protected async Task SaveForm() {
            _ = await ComponentAnswerHandler.Save(CurrentForm);
        }
    }
}