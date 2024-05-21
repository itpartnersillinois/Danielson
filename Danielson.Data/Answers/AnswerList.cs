namespace Danielson.Data.Answers {

    public static class AnswerList {

        public static List<AnswerObject> Answers = [
            new() {
                Description = "The component was not observed.",
                QualitativeAnswer = "Not Observed",
                QuantitativeAnswer = null,
                NumberColumns = 1
            },
            new() {
                Description = "The teacher lacks sufficient knowledge of content and pedagogy to support student learning of the content.",
                QualitativeAnswer = "Needs Improvement",
                QuantitativeAnswer = 1,
                NumberColumns = 1
            },
            new() {
                Description = "The teachers’ understanding of content and pedagogy supports student learning of the content.",
                QualitativeAnswer = "Novice",
                QuantitativeAnswer = 2,
                NumberColumns = 2
            },
            new() {
                QualitativeAnswer = "Intermediate",
                QuantitativeAnswer = 3,
                NumberColumns = 0
            },
            new() {
                Description = "The teachers’ understanding of content and pedagogy supports student learning of the content.",
                QualitativeAnswer = "Advanced",
                QuantitativeAnswer = 4,
                NumberColumns = 2
            },
            new() {
                QualitativeAnswer = "Exceptional",
                QuantitativeAnswer = 5,
                NumberColumns = 0
            }
        ];
    }
}