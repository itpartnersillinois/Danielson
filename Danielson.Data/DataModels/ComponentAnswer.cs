using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Danielson.Data.DataModels {

    [Table("ComponentAnswer", Schema = "danielson")]
    public class ComponentAnswer : BaseDataItem {
        public string ComponentConsiderations { get; set; } = "";

        public string ComponentDescription { get; set; } = "";

        public int ComponentOrder { get; set; }
        public string ComponentTitle { get; set; } = "";

        public DateTime? DateCompleted { get; set; }
        public DomainEnum DomainItem { get; set; }
        public virtual Form Form { get; set; } = default!;
        public int FormId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        public string QualitativeScore { get; set; } = "";
        public int? QuantitativeScore { get; set; }
    }
}