using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Danielson.Data.DataModels {

    [Table("Form", Schema = "danielson")]
    public class Form : BaseDataItem {
        public int AssignmentId { get; set; }
        public virtual ICollection<DomainTemplate>? CustomDomainTemplates { get; set; }

        public DateTime? DateSubmitted { get; set; } = null;

        public string Email { get; set; } = "";

        public double FinalScore { get; set; }

        public string FinalSummary { get; set; } = "";

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        public bool IsMidterm { get; set; }
        public int ProgramId { get; set; }
        public string SemesterDate { get; set; } = "";
        public string Student { get; set; } = "";
        public int StudentEvaluationId { get; set; }
        public int StudentId { get; set; }
        public string Title { get; set; } = "";
    }
}