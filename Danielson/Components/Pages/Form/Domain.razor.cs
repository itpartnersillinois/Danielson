using Danielson.Data.DataAccess;
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
        protected ComponentAnswerHandler ComponentAnswerHandler { get; set; } = default!;

        [Inject]
        protected FormTemplateAccess FormTemplateAccess { get; set; } = default!;

        protected override async Task OnInitializedAsync() {
            DomainObject = DomainList.Domains.First();
            ShowFinal = false;

            CurrentForm = await ComponentAnswerHandler.GetForm(FormId);
            //TODO Add authentication

            await base.OnInitializedAsync();
        }
    }
}