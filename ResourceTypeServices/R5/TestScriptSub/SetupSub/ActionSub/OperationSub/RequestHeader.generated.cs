
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.TestScriptSub.SetupSub.ActionSub.OperationSub
{
    public class RequestHeader : BackboneElement<RequestHeader>
    {

        #region Property
        [Element("field", typeof(FhirString), true, false, false, false)]
public FhirString Field {get; set;}
[Element("value", typeof(FhirString), true, false, false, false)]
public FhirString Value {get; set;}

        #endregion
        #region Constructor
        public  RequestHeader() { }
        public  RequestHeader(string value) : base(value) { }
        public  RequestHeader(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "RequestHeader";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
