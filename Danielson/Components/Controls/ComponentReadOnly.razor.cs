using Danielson.Data.Domains;
using Microsoft.AspNetCore.Components;

namespace Danielson.Components.Controls {

    public partial class ComponentReadOnly {

        [Parameter]
        public ComponentObject Component { get; set; } = default!;

        [Parameter]
        public string[] ConsiderationValues { get; set; } = default!;

        public int NumberColumns { get; set; }

        [Parameter]
        public bool ShowNotObserved { get; set; }

        [Parameter]
        public bool ShowQuantitativeAnswer { get; set; }

        protected override async Task OnInitializedAsync() {
            NumberColumns = Component.Answers.Count(a => (!a.NotObserved || ShowNotObserved) && a.NumberColumns > 0) * 2;
        }
    }
}