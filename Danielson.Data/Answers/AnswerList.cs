namespace Danielson.Data.Answers {

    public static class AnswerList {

        public static List<AnswerObject> GenerateAnswers(List<string> items) => [
            new() {
                Description = "The component was not observed.",
                QualitativeAnswer = "Not Observed",
                QuantitativeAnswer = -1,
                NumberColumns = 1,
                NotObserved = true
            },
            new() {
                Description = items[0],
                QualitativeAnswer = "Needs Improvement",
                QuantitativeAnswer = 1,
                NumberColumns = 1,
                NotObserved = false
            },
            new() {
                Description = items[1],
                QualitativeAnswer = "Novice",
                QuantitativeAnswer = 2,
                NumberColumns = 2,
                NotObserved = false
            },
            new() {
                Description = items[1],
                QualitativeAnswer = "Intermediate",
                QuantitativeAnswer = 3,
                NumberColumns = 0,
                NotObserved = false
            },
            new() {
                Description = items[2],
                QualitativeAnswer = "Advanced",
                QuantitativeAnswer = 4,
                NumberColumns = 2,
                NotObserved = false
            },
            new() {
                Description = items[2],
                QualitativeAnswer = "Exceptional",
                QuantitativeAnswer = 5,
                NumberColumns = 0,
                NotObserved = false
            }
        ];
    }
}