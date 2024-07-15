using Danielson.Data.DataAccess;
using Danielson.Data.DataModels;
using Microsoft.AspNetCore.Components;

namespace Danielson.Components.Pages.Admin {

    public partial class EditFormTemplate {
        public FormTemplate FormTemplate { get; set; } = new FormTemplate();

        [Parameter]
        public int? Id { get; set; }

        [Inject]
        private FormTemplateAccess FormTemplateAccess { get; set; } = default!;

        [Inject]
        private NavigationManager NavigationManager { get; set; } = default!;

        protected override async Task OnInitializedAsync() {
            FormTemplate = await FormTemplateAccess.Get(Id) ?? new FormTemplate();
        }

        protected async Task Save() {
            _ = await FormTemplateAccess.Save(FormTemplate);
            NavigationManager.NavigateTo("/");
        }

        protected void SaveConsideration(ConsiderationTemplate c) {
            c.IsActive = true;
            var existing = FormTemplate.GetConsiderationTemplate(c.DomainItem, c.ComponentOrder);
            if (existing != null && existing.Id > 0) {
                existing.ConsiderationText = c.ConsiderationText;
                existing.IsActive = true;
            } else {
                FormTemplate.ConsiderationTemplates.Add(c);
            }
        }
    }
}