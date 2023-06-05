
using System.Text.Json.Nodes;


namespace DataTypeService.Complex.Variations
{
    public class SimpleQuantity : Quantity
    {
        public SimpleQuantity() { }
        public SimpleQuantity(string? value) : base(value) { }
        public SimpleQuantity(JsonNode? source) : base(source) { }

    }
}
