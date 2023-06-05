using System.Text.Json.Nodes;


namespace DataTypeService.Complex
{
    public class SimpleQuantity : Quantity
    {
        public SimpleQuantity() { }
        public SimpleQuantity(string? value) : base(value) { }
        public SimpleQuantity(JsonNode? source) : base(source) { }

    }
}
