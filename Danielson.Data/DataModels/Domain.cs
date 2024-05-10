using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Danielson.Data.DataModels {

    [Table("Domain", Schema = "danielson")]
    public class Domain : BaseDataItem {
        public string DomainDescription { get; set; } = "";
        public string DomainTitle { get; set; } = "";
        public DomainEnum DomainType { get; set; }
        public virtual Form? Form { get; set; }

        public int? FormId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
    }
}