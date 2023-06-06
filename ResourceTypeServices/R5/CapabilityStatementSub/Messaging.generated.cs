
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.CapabilityStatementSub.MessagingSub;

namespace ResourceTypeServices.R5.CapabilityStatementSub
{
    public class Messaging : BackboneElement<Messaging>
    {

        #region Property
        [Element("endpoint", typeof(Endpoint), false, true, false, true)]
public IEnumerable<Endpoint> Endpoint {get; set;}
[Element("reliableCache", typeof(FhirUnsignedInt), true, false, false, false)]
public FhirUnsignedInt ReliableCache {get; set;}
[Element("documentation", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Documentation {get; set;}
[Element("supportedMessage", typeof(SupportedMessage), false, true, false, true)]
public IEnumerable<SupportedMessage> SupportedMessage {get; set;}

        #endregion
        #region Constructor
        public  Messaging() { }
        public  Messaging(string value) : base(value) { }
        public  Messaging(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Messaging";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
