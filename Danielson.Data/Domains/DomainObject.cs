using Danielson.Data.DataModels;
using Microsoft.AspNetCore.Components;

namespace Danielson.Data.Domains {

    public class DomainObject {
        public List<ComponentObject> Components { get; set; } = [];
        public MarkupString DescriptionHtml { get; set; } = default!;
        public DomainEnum DomainEnum { get; set; }

        public string Title { get; set; } = "";
    }
}