using Danielson.Data.DataModels;
using Microsoft.AspNetCore.Components;

namespace Danielson.Data.Domains {

    public class ComponentObject {
        public string Code { get; set; } = "";
        public int ComponentOrder { get; set; }
        public MarkupString ContinuumOfPracticeHtml { get; set; } = default;
        public DomainEnum DomainEnum { get; set; }
        public string Title { get; set; } = "";
    }
}