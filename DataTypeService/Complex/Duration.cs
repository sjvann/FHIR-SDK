using System.Text.Json.Nodes;


namespace DataTypeService.Complex
{
    public class Duration : Quantity
    {
        public Duration() { }
        public Duration(string? value) : base(value) { }
        public Duration(JsonNode? source) : base(source) { }

    }
}
