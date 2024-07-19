using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Danielson.Data.DataModels {

    [Table("FormTemplate", Schema = "danielson")]
    public class FormTemplate : BaseDataItem {
        public virtual ICollection<ConsiderationTemplate> ConsiderationTemplates { get; set; } = default!;

        public string FinalAnswerOptions { get; set; } = "";

        public string FormDescription { get; set; } = "";

        public string FormTitle { get; set; } = "";

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        public string InternalLookupString { get; set; } = "";
        public string Title { get; set; } = "";

        public string[] ConsiderationValues(DomainEnum domain, int componentOrder) => GetConsiderationTemplate(domain, componentOrder).ConsiderationText.Split('\n').Select(c => c.Trim(' ', '\n', '\r')).Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

        public ConsiderationTemplate GetConsiderationTemplate(DomainEnum domain, int componentOrder) => ConsiderationTemplates == null ? new ConsiderationTemplate { DomainItem = domain, ComponentOrder = componentOrder, ConsiderationText = "" } : ConsiderationTemplates.FirstOrDefault(x => x.DomainItem == domain && x.ComponentOrder == componentOrder) ?? new ConsiderationTemplate { DomainItem = domain, ComponentOrder = componentOrder, ConsiderationText = "" };
    }
}