using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Danielson.Data.DataModels {

    [Table("User", Schema = "danielson")]
    public class User : BaseDataItem {
        public string Email { get; set; } = "";

        public Guid Guid { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        public RoleEnum Role { get; set; }
        public int StudentEvaluationId { get; set; }
        public string Username { get; set; } = "";
    }
}