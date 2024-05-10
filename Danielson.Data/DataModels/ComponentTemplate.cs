using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Danielson.Data.DataModels {

    [Table("ComponentTemplate", Schema = "danielson")]
    public class ComponentTemplate : BaseDataItem {
        public string ComponentConsiderations { get; set; } = "";

        public virtual ICollection<ComponentOptionTemplate> ComponentOptionTemplates { get; set; } = default!;

        public string ComponentTitle { get; set; } = "";

        public virtual DomainTemplate DomainTemplate { get; set; } = default!;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        public int Order { get; set; }
        public int SectionTemplateId { get; set; }
    }
}