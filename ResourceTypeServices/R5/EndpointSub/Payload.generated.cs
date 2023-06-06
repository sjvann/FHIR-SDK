
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.EndpointSub
{
    public class Payload : BackboneElement<Payload>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Type {get; set;}
[Element("mimeType", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> MimeType {get; set;}

        #endregion
        #region Constructor
        public  Payload() { }
        public  Payload(string value) : base(value) { }
        public  Payload(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Payload";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
