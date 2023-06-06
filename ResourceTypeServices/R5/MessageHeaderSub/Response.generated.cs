
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MessageHeaderSub
{
    public class Response : BackboneElement<Response>
    {

        #region Property
        [Element("identifier", typeof(Identifier), false, false, false, false)]
public Identifier Identifier {get; set;}
[Element("code", typeof(FhirCode), true, false, false, false)]
public FhirCode Code {get; set;}
[Element("details", typeof(Reference), false, false, false, false)]
public Reference Details {get; set;}

        #endregion
        #region Constructor
        public  Response() { }
        public  Response(string value) : base(value) { }
        public  Response(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Response";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
