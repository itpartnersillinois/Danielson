using Danielson.Data.DataModels;
using Danielson.Data.Domains;
using Microsoft.AspNetCore.Components;

namespace Danielson.Components.Controls {

    public partial class DomainReview {

        [Parameter]
        public DomainEnum DomainEnum { get; set; } = default!;

        [Parameter]
        public Form Form { get; set; } = default!;

        [Parameter]
        public EventCallback<DomainEnum> OnEdit { get; set; }

        [Parameter]
        public bool ShowErrors { get; set; }

        [Parameter]
        public bool ShowQuantitativeAnswer { get; set; }

        [Parameter]
        public string Title { get; set; } = default!;

        protected bool AreAllCompnentsAnswered => ComponentsNotChosen.Count == 0;
        protected List<ComponentAnswer> ComponentAnswers { get; set; } = default!;

        protected List<string> ComponentsNotChosen { get; set; } = default!;

        protected DomainAnswer DomainAnswer { get; set; } = default!;

        public void Edit(DomainEnum domain) => OnEdit.InvokeAsync(domain);

        protected override void OnInitialized() {
            ComponentAnswers = Form.ComponentAnswers.Where(ca => ca.DomainItem == DomainEnum).OrderBy(ca => ca.ComponentOrder).ToList() ?? [];
            ComponentsNotChosen = DomainList.Domains.First(d => d.DomainEnum == DomainEnum).Components.Where(c => !ComponentAnswers.Select(ca => ca.ComponentOrder).Contains(c.ComponentOrder)).Select(c => c.Title).ToList();
            DomainAnswer = Form.GetDomainAnswer(DomainEnum);
        }
    }
}