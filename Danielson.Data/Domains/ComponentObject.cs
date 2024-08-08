using Danielson.Data.DataModels;
using Microsoft.AspNetCore.Components;

namespace Danielson.Data.Domains {

    public class ComponentObject {
        public string Code { get; set; } = "";
        public int ComponentOrder { get; set; }
        public MarkupString ContinuumOfPracticeHtml { get; set; } = default;
        public MarkupString UnsatisfactoryHtml { get; set; } = default;
        public MarkupString BasicHtml { get; set; } = default;
        public MarkupString ProficientHtml { get; set; } = default;
        public DomainEnum DomainEnum { get; set; }
        public string Title { get; set; } = "";

        private List<AnswerObject> Answers { get; set; } =  [
                          new()  {
                                Description = (MarkupString)"The component was not observed.",
                                QualitativeAnswer = "Not Observed",
                                QuantitativeAnswer = -1,
                                NumberColumns = 1,
                                NotObserved = true
                            },
                                new()
                                {
                                    Description = UnsatisfactoryHtml,
                                    QualitativeAnswer = "Needs Improvement",
                                    QuantitativeAnswer = 1,
                                    NumberColumns = 1,
                                    NotObserved = false
                                },
                                new()
                                {
                                    Description = BasicHtml,
                                    QualitativeAnswer = "Novice",
                                    QuantitativeAnswer = 2,
                                    NumberColumns = 2,
                                    NotObserved = false
                                },
                                new()
                                {
                                    Description = BasicHtml,
                                    QualitativeAnswer = "Intermediate",
                                    QuantitativeAnswer = 3,
                                    NumberColumns = 0,
                                    NotObserved = false
                                },
                                new()
                                {
                                    Description = ProficientHtml,
                                    QualitativeAnswer = "Advanced",
                                    QuantitativeAnswer = 4,
                                    NumberColumns = 2,
                                    NotObserved = false
                                },
                                new()
                                {
                                    Description = ProficientHtml,
                                    QualitativeAnswer = "Exceptional",
                                    QuantitativeAnswer = 5,
                                    NumberColumns = 0,
                                    NotObserved = false
                                }
                   ];
        }
    }
   