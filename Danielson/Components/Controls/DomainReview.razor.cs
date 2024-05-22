using Danielson.Data.DataModels;
using Microsoft.AspNetCore.Components;

namespace Danielson.Components.Controls {

    public partial class DomainReview {

        [Parameter]
        public DomainEnum DomainEnum { get; set; } = default!;

        [Parameter]
        public Form Form { get; set; } = default!;

        [Parameter]
        public string Title { get; set; } = default!;

        protected List<ComponentAnswer> ComponentAnswers { get; set; } = default!;

        protected DomainAnswer DomainAnswer { get; set; } = default!;

        protected override void OnInitialized() {
            ComponentAnswers = Form.ComponentAnswers.Where(ca => ca.DomainItem == DomainEnum).OrderBy(ca => ca.ComponentOrder).ToList() ?? [];
            DomainAnswer = Form.GetDomainAnswer(DomainEnum);
        }
    }
}