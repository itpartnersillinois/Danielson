using Danielson.Data.DataAccess;
using Danielson.Data.DataModels;
using Danielson.Data.Domains;
using Danielson.Data.PortalTranslator;
using Microsoft.AspNetCore.Components;

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
        protected NavigationManager NavigationManager { get; set; } = default!;

        public void ChangeFormType(bool isMidterm) {
            CurrentForm.IsMidterm = isMidterm;
            NavigationManager.NavigateTo(NavigationManager.Uri, true);
        }

        protected void AddComponentAnswerToForm(ComponentAnswer componentAnswer) => CurrentForm.AddComponentAnswerToForm(componentAnswer);

        protected void AddDomainAnswerToForm(DomainAnswer domainAnswer) => CurrentForm.AddDomainAnswerToForm(domainAnswer);

        protected void ChangePage(DomainEnum? domainEnum, bool finish) {
            ShowFinal = finish;
            DomainObject = DomainList.Domains.First(d => d.DomainEnum == (finish ? DomainEnum.Four : domainEnum ?? DomainEnum.One));
            StateHasChanged();
        }

        protected void ChangePageNext() {
            switch (DomainObject.DomainEnum) {
                case DomainEnum.One:
                    ChangePage(DomainEnum.Two, false);
                    break;

                case DomainEnum.Two:
                    ChangePage(DomainEnum.Three, false);
                    break;

                case DomainEnum.Three:
                    ChangePage(DomainEnum.Four, false);
                    break;

                case DomainEnum.Four:
                    ChangePage(DomainEnum.Four, true);
                    break;

                default:
                    break;
            }
        }

        protected void ChangePagePrevious() {
            if (ShowFinal) {
                ChangePage(DomainEnum.Four, false);
            } else {
                switch (DomainObject.DomainEnum) {
                    case DomainEnum.Two:
                        ChangePage(DomainEnum.One, false);
                        break;

                    case DomainEnum.Three:
                        ChangePage(DomainEnum.Two, false);
                        break;

                    case DomainEnum.Four:
                        ChangePage(DomainEnum.Three, false);
                        break;

                    default:
                        break;
                }
            }
        }

        protected void CheckFinal() {
            CurrentForm.DateEvaluated = CurrentForm.DateEvaluated.HasValue ? null : DateTime.Now;
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