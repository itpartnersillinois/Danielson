namespace Danielson.Data.Answers {

    public class AnswerObject {
        public string Description { get; set; } = "";
        public bool NotObserved { get; set; }
        public int NumberColumns { get; set; }
        public string QualitativeAnswer { get; set; } = "";
        public int? QuantitativeAnswer { get; set; }

        public string Answer(bool showQuantitative) => showQuantitative && QuantitativeAnswer.HasValue && QuantitativeAnswer.Value > 0 ? $"{QualitativeAnswer} ({QuantitativeAnswer})" : QualitativeAnswer;
    }
}