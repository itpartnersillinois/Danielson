using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Danielson.Data.DataModels {

    [Table("FormTemplate", Schema = "danielson")]
    public class FormTemplate : BaseDataItem {
        public virtual ICollection<DomainTemplate>? CustomDomainTemplates { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        public string Title { get; set; } = "";
    }
}