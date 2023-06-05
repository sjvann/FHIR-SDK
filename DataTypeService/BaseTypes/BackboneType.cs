using DataTypeService.Complex;
using System.Text.Json.Nodes;

namespace DataTypeService.BaseTypes
{
    public abstract class BackboneType : DataType
    {
        public IEnumerable<Extension>? ModifierExtension { get; set; }
        protected void SetupBackboneType(JsonNode source)
        {
            if (source != null)
            {
                SetElementProperties(source);
                ModifierExtension = source["modifierExtension"]?.AsArray().Select(x => new Extension(x));
            }
        }
    }
}
