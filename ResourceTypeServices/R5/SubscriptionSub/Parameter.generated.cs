
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubscriptionSub
{
    public class Parameter : BackboneElement<Parameter>
    {

        #region Property
        [Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("value", typeof(FhirString), true, false, false, false)]
public FhirString Value {get; set;}

        #endregion
        #region Constructor
        public  Parameter() { }
        public  Parameter(string value) : base(value) { }
        public  Parameter(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Parameter";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
