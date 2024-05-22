using Danielson.Data.DataModels;
using Microsoft.AspNetCore.Components;

namespace Danielson.Components.Controls {

    public partial class ConsiderationEditor {

        [Parameter]
        public ConsiderationTemplate ConsiderationTemplate { get; set; } = default!;

        public string ConsiderationText {
            get => ConsiderationTemplate.ConsiderationText;
            set => ConsiderationTemplate.ConsiderationText = value;
        }

        [Parameter]
        public EventCallback<ConsiderationTemplate> OnChangeCallback { get; set; }

        [Parameter]
        public string Title { get; set; } = default!;

        public async Task Save() => await OnChangeCallback.InvokeAsync(ConsiderationTemplate);
    }
}