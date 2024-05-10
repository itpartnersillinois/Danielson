using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Danielson.Data.DataModels {

    [Table("ComponentOptionTemplate", Schema = "danielson")]
    public class ComponentOptionTemplate : BaseDataItem {
        public bool CombineWithPrevious { get; set; }

        public virtual ComponentTemplate? ComponentTemplate { get; set; } = default!;

        public int? ComponentTemplateId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        public string OptionDescription { get; set; } = "";
        public string QualitativeScore { get; set; } = "";
        public int QuantitativeScore { get; set; }
    }
}