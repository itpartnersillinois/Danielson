using Microsoft.AspNetCore.Components;

namespace Danielson.Data.Domains {

    public class AnswerObject {
        public MarkupString Description { get; set; } = (MarkupString)"";
        public bool NotObserved { get; set; }
        public int NumberColumns { get; set; }
        public string QualitativeAnswer { get; set; } = "";
        public int? QuantitativeAnswer { get; set; }

        public string Answer(bool showQuantitative) => showQuantitative && QuantitativeAnswer.HasValue && QuantitativeAnswer.Value > 0 ? $"{QualitativeAnswer} ({QuantitativeAnswer})" : QualitativeAnswer;
    }
}