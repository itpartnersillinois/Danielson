using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Danielson.Data.DataModels {

    [Table("DomainAnswer", Schema = "danielson")]
    public class DomainAnswer : BaseDataItem {
        public DateTime? DateCompleted { get; set; }
        public DomainEnum DomainType { get; set; }
        public virtual Form Form { get; set; } = default!;

        public int FormId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        public string NextSteps { get; set; } = "";

        public string Strengths { get; set; } = "";
    }
}