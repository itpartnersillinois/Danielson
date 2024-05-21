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

        [Parameter]
        public bool ShowNotObserved { get; set; }

        [Parameter]
        public bool ShowQuantitativeAnswer { get; set; }

        [Inject]
        private ComponentAnswerHandler ComponentAnswerHandler { get; set; } = default!;

        [Inject]
        private FormTemplateAccess FormTemplateAccess { get; set; } = default!;

        protected override async Task OnInitializedAsync() {
            ConsiderationValues = (await FormTemplateAccess.Get(FormTemplateCode)).GetConsiderationTemplate(Component.DomainEnum, Component.ComponentOrder).ConsiderationText.Split('\n');
        }

        protected async Task SaveAnswer(int? answer, string answerText) {
            ComponentAnswer ??= new ComponentAnswer();
            ComponentAnswer.ComponentConsiderations = string.Join(". ", ConsiderationValues);
            ComponentAnswer.ComponentOrder = Component.ComponentOrder;
            ComponentAnswer.ComponentTitle = Component.Title;
            ComponentAnswer.DateCompleted = DateTime.Now;
            ComponentAnswer.DomainItem = Component.DomainEnum;
            ComponentAnswer.QualitativeScore = answerText;
            ComponentAnswer.QuantitativeScore = answer;
            ComponentAnswer.FormId = FormId;
            _ = await ComponentAnswerHandler.Save(ComponentAnswer);
        }
    }
}