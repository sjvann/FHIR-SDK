
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SearchParameterSub
{
    public class Component : BackboneElement<Component>
    {

        #region Property
        [Element("definition", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Definition {get; set;}
[Element("expression", typeof(FhirString), true, false, false, false)]
public FhirString Expression {get; set;}

        #endregion
        #region Constructor
        public  Component() { }
        public  Component(string value) : base(value) { }
        public  Component(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Component";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
