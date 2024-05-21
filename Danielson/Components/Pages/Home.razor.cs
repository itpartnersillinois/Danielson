using Danielson.Data.DataAccess;
using Danielson.Data.DataModels;
using Microsoft.AspNetCore.Components;

namespace Danielson.Components.Pages {

    public partial class Home {

        [Inject]
        private FormTemplateAccess FormTemplateAccess { get; set; } = default!;

        private List<FormTemplate> FormTemplates { get; set; } = default!;

        protected override async Task OnInitializedAsync() {
            FormTemplates = await FormTemplateAccess.GetAll();
        }
    }
}