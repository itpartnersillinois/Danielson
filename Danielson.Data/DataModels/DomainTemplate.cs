using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Danielson.Data.DataModels {

    [Table("DomainTemplate", Schema = "danielson")]
    public class DomainTemplate : BaseDataItem {
        public virtual ICollection<ComponentTemplate> ComponentTemplates { get; set; } = default!;
        public string DomainDescription { get; set; } = "";
        public string DomainTitle { get; set; } = "";
        public DomainEnum DomainType { get; set; }
        public virtual FormTemplate? FormTemplate { get; set; }

        public int? FormTemplateId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        public bool IsDefault { get; set; }
    }
}