using System.Text.Json.Nodes;

namespace DataTypeServices.TypeFramework
{
    public class ElementImp:Element
    {
        public ElementImp() { }
        public ElementImp(string value) : base(value) { }
        public ElementImp(JsonObject? value) : base(value) { }
        public override string GetFhirTypeName(bool withCapital = true) => withCapital ? "Element" : "element";
    }
}
