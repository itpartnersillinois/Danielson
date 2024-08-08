using Danielson.Data.Answers;
using Danielson.Data.DataAccess;
using Danielson.Data.DataModels;
using Danielson.Data.Domains;
using Microsoft.AspNetCore.Components;

namespace Danielson.Components.Controls {

    public partial class ComponentItem {

        [Parameter]
        public ComponentObject Component { get; set; } = default!;

        [Parameter]
        public ComponentAnswer? ComponentAnswer { get; set; } = default!;

        [Parameter]
        public string[] ConsiderationValues { get; set; } = default!;

        [Parameter]
        public int FormId { get; set; }

        public int NumberColumns { get; set; }

        [Parameter]
        public EventCallback<ComponentAnswer> OnChangeCallback { get; set; }

        [Parameter]
        public bool ShowNotObserved { get; set; }

        [Parameter]
        public bool ShowQuantitativeAnswer { get; set; }

        [Inject]
        private FormAccess FormAccess { get; set; } = default!;

        protected override async Task OnInitializedAsync() {
            // TODO Need to review for more variations
            NumberColumns = Component.Answers.Count(a => (!a.NotObserved || ShowNotObserved) && a.NumberColumns > 0) * 2;
        }

        protected async Task SaveAnswer(int? answer, string answerText, string answerDescription) {
            ComponentAnswer ??= new ComponentAnswer();
            ComponentAnswer.ComponentConsiderations = string.Join(". ", ConsiderationValues);
            ComponentAnswer.ComponentOrder = Component.ComponentOrder;
            ComponentAnswer.ComponentTitle = Component.Title;
            ComponentAnswer.ComponentDescription = answerDescription;
            ComponentAnswer.DateCompleted = DateTime.Now;
            ComponentAnswer.LastUpdated = DateTime.Now;
            ComponentAnswer.DomainItem = Component.DomainEnum;
            ComponentAnswer.QualitativeScore = answerText;
            ComponentAnswer.QuantitativeScore = answer;
            ComponentAnswer.FormId = FormId;
            _ = await FormAccess.Save(ComponentAnswer);
            await OnChangeCallback.InvokeAsync(ComponentAnswer);
        }
    }
}