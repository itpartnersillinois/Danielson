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

        public string[] ConsiderationValues { get; set; } = default!;

        [Parameter]
        public int FormId { get; set; }

        [Parameter]
        public string FormTemplateCode { get; set; } = "";

        public int NumberColumns { get; set; }

        [Parameter]
        public EventCallback<ComponentAnswer> OnChangeCallback { get; set; }

        [Parameter]
        public bool ShowNotObserved { get; set; }

        [Parameter]
        public bool ShowQuantitativeAnswer { get; set; }

        [Inject]
        private FormAccess FormAccess { get; set; } = default!;

        [Inject]
        private FormTemplateAccess FormTemplateAccess { get; set; } = default!;

        protected override async Task OnInitializedAsync() {
            ConsiderationValues = (await FormTemplateAccess.Get(FormTemplateCode)).GetConsiderationTemplate(Component.DomainEnum, Component.ComponentOrder).ConsiderationText.Split('\n').Select(c => c.Trim(' ', '.', '\n', '\r')).Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

            // TODO Need to review for more variations
            NumberColumns = AnswerList.Answers.Count(a => (!a.NotObserved || ShowNotObserved) && a.NumberColumns > 0) * 2;
        }

        protected async Task SaveAnswer(int? answer, string answerText, string answerDescription) {
            ComponentAnswer ??= new ComponentAnswer();
            ComponentAnswer.ComponentConsiderations = string.Join(". ", ConsiderationValues);
            ComponentAnswer.ComponentOrder = Component.ComponentOrder;
            ComponentAnswer.ComponentTitle = Component.Title;
            ComponentAnswer.ComponentDescription = answerDescription;
            ComponentAnswer.DateCompleted = DateTime.Now;
            ComponentAnswer.DomainItem = Component.DomainEnum;
            ComponentAnswer.QualitativeScore = answerText;
            ComponentAnswer.QuantitativeScore = answer;
            ComponentAnswer.FormId = FormId;
            _ = await FormAccess.Save(ComponentAnswer);
            await OnChangeCallback.InvokeAsync(ComponentAnswer);
        }
    }
}