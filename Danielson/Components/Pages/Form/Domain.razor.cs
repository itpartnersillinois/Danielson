using Danielson.Data.DataAccess;
using Danielson.Data.DataModels;
using Danielson.Data.Domains;
using Microsoft.AspNetCore.Components;

namespace Danielson.Components.Pages.Form {

    public partial class Domain {
        public Data.DataModels.Form CurrentForm { get; set; } = default!;
        public DomainObject DomainObject { get; set; } = default!;

        [Parameter]
        public int FormId { get; set; }

        public bool ShowFinal { get; set; }

        [Inject]
        protected FormAccess ComponentAnswerHandler { get; set; } = default!;

        [Inject]
        protected FormTemplateAccess FormTemplateAccess { get; set; } = default!;

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

        protected override async Task OnInitializedAsync() {
            DomainObject = DomainList.Domains.First();
            ShowFinal = false;

            CurrentForm = await ComponentAnswerHandler.GetForm(FormId);
            //TODO Add authentication

            await base.OnInitializedAsync();
        }
    }
}