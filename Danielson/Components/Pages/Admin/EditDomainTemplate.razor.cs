using Danielson.Data.DataAccess;
using Danielson.Data.DataModels;
using Microsoft.AspNetCore.Components;

namespace Danielson.Components.Pages.Admin {

    public partial class EditDomainTemplate {

        [Parameter]
        public int Id { get; set; }

        [Inject]
        protected DomainHelper DomainHelper { get; set; } = default!;

        protected DomainTemplate DomainTemplate { get; set; } = default!;

        protected override async Task OnInitializedAsync() {
            DomainTemplate = await DomainHelper.GetTemplate(Id);
        }

        protected async Task Save() {
            _ = await DomainHelper.SaveTemplate(DomainTemplate);
        }
    }
}