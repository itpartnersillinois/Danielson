namespace Danielson.Data.PortalTranslator {

    public class FormImportInformation {
        public DateTime? DateEvaluated { get; set; }
        public string EvaluatedBy => $"{EvaluatorFirstName} {EvaluatorLastName}";
        public string EvaluatorFirstName { get; set; } = "";
        public string EvaluatorLastName { get; set; } = "";
        public string FinalScoreText { get; set; } = "";
        public string FormTemplateInternalLookupString { get; set; } = "";
        public bool IsMidterm { get; set; }
        public DateTime LastUpdated { get; set; }
        public string PlacementType { get; set; } = "";
        public string Position { get; set; } = "";
        public string Semester { get; set; } = "";
        public bool ShowComponents { get; set; }
        public bool ShowNotObserved { get; set; }
        public bool ShowQuantitativeAnswer { get; set; }
        public int StudentEvaluationId { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; } = "";
        public string Title { get; set; } = "";
    }
}