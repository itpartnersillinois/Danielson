using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Danielson.Data.DataModels {

    [Table("ComponentAnswer", Schema = "danielson")]
    public class ComponentAnswer : BaseDataItem {
        public string ComponentConsiderations { get; set; } = "";

        public virtual ComponentTemplate ComponentTemplate { get; set; } = default!;

        public int ComponentTemplateId { get; set; } = default!;

        public string ComponentTitle { get; set; } = "";

        public virtual Domain Domain { get; set; } = default!;

        public int DomainId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        public bool IsNotObserved { get; set; }
        public string NextSteps { get; set; } = "";
        public string OptionDescription { get; set; } = "";
        public int Order { get; set; }
        public string QualitativeScore { get; set; } = "";
        public int QuantitativeScore { get; set; }
        public string Strengths { get; set; } = "";
    }
}