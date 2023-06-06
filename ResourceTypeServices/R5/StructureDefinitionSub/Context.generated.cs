
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.StructureDefinitionSub
{
    public class Context : BackboneElement<Context>
    {

        #region Property
        [Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("expression", typeof(FhirString), true, false, false, false)]
public FhirString Expression {get; set;}

        #endregion
        #region Constructor
        public  Context() { }
        public  Context(string value) : base(value) { }
        public  Context(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Context";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
