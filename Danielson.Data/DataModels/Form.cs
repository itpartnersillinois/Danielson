using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Danielson.Data.DataModels {

    [Table("Form", Schema = "danielson")]
    public class Form : BaseDataItem {
        public int AssignmentId { get; set; }
        public virtual ICollection<ComponentAnswer> ComponentAnswers { get; set; } = default!;

        public DateTime? DateEvaluated { get; set; } = null;

        public DateTime? DateSubmitted { get; set; } = null;

        public string Email { get; set; } = "";

        public double FinalScore { get; set; }

        public string FinalScoreText { get; set; } = "";

        public string FinalSummary { get; set; } = "";

        public string FormTemplateInternalLookupString { get; set; } = "";

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        public bool IsMidterm { get; set; }

        public string PlacementType { get; set; } = "";

        public string Position { get; set; } = "";

        public int ProgramId { get; set; }

        public string SemesterDate { get; set; } = "";

        public bool ShowNotObserved { get; set; }

        public bool ShowQuantitativeAnswer { get; set; }

        public string Student { get; set; } = "";

        public int StudentEvaluationId { get; set; }

        public int StudentId { get; set; }

        public string Title { get; set; } = "";

        public ComponentAnswer GetComponentAnswer(DomainEnum domain, int componentOrder) => ComponentAnswers == null ? new ComponentAnswer { DomainItem = domain, ComponentOrder = componentOrder } : ComponentAnswers.FirstOrDefault(x => x.DomainItem == domain && x.ComponentOrder == componentOrder) ?? new ComponentAnswer { DomainItem = domain, ComponentOrder = componentOrder };
    }
}