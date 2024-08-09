using Danielson.Data.DataAccess;
using Danielson.Data.DataModels;
using Microsoft.AspNetCore.Components;

namespace Danielson.Components.Controls {

    public partial class DomainItem {

        [Parameter]
        public DomainAnswer DomainAnswer { get; set; } = default!;

        [Parameter]
        public bool IsReadOnly { get; set; }

        [Parameter]
        public EventCallback<DomainAnswer> OnChangeCallback { get; set; }

        [Inject]
        private FormAccess FormAccess { get; set; } = default!;

        protected async Task SaveAnswer() {
            _ = await FormAccess.Save(DomainAnswer ?? new());
            await OnChangeCallback.InvokeAsync(DomainAnswer);
        }
    }
}