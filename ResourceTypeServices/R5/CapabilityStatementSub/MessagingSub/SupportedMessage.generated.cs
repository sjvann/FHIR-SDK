
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CapabilityStatementSub.MessagingSub
{
    public class SupportedMessage : BackboneElement<SupportedMessage>
    {

        #region Property
        [Element("mode", typeof(FhirCode), true, false, false, false)]
public FhirCode Mode {get; set;}
[Element("definition", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Definition {get; set;}

        #endregion
        #region Constructor
        public  SupportedMessage() { }
        public  SupportedMessage(string value) : base(value) { }
        public  SupportedMessage(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "SupportedMessage";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
