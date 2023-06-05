using System.Text.Json.Nodes;


namespace DataTypeService.Complex
{
    public class Count : Quantity
    {
        public Count() { }
        public Count(string? value) : base(value) { }
        public Count(JsonNode? source) : base(source) { }

    }
}
