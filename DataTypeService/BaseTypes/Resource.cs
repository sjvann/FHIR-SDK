using DataTypeService.Primitive;
using DataTypeService.Special;
using System.Text.Json.Nodes;

namespace DataTypeService.BaseTypes
{
    public abstract class Resource : Base
    {
        public FhirId? Id { get; set; }
        public Meta? Meta { get; set; }
        public FhirUri? ImplicitRules { get; set; }
        public FhirCode? Language { get; set; }
        public abstract JsonNode? GetJsonNode();

    }
}
