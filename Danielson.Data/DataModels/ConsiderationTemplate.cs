using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Danielson.Data.DataModels {

    [Table("ConsiderationTemplate", Schema = "danielson")]
    public class ConsiderationTemplate : BaseDataItem {
        public int ComponentOrder { get; set; }

        public string ConsiderationText { get; set; } = "";

        public DomainEnum DomainItem { get; set; }

        public virtual FormTemplate FormTemplate { get; set; } = default!;

        public int FormTemplateId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
    }
}