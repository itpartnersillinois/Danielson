using Danielson.Data.Domains;
using Microsoft.AspNetCore.Components;

namespace Danielson.Components.Controls {

    public partial class ComponentReadOnly {

        [Parameter]
        public ComponentObject Component { get; set; } = default!;

        [Parameter]
        public string[] ConsiderationValues { get; set; } = default!;
    }
}