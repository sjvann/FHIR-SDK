

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MessageHeaderSub
{
    public class MessageHeader : DomainResource<MessageHeader>
    {
        #region Property
        [Element("event", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Event {get; set;}
[Element("destination", typeof(Destination), false, true, false, true)]
public IEnumerable<Destination> Destination {get; set;}
[Element("sender", typeof(Reference), false, false, false, false)]
public Reference Sender {get; set;}
[Element("author", typeof(Reference), false, false, false, false)]
public Reference Author {get; set;}
[Element("source", typeof(Source), false, false, false, true)]
public Source Source {get; set;}
[Element("responsible", typeof(Reference), false, false, false, false)]
public Reference Responsible {get; set;}
[Element("reason", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Reason {get; set;}
[Element("response", typeof(Response), false, false, false, true)]
public Response Response {get; set;}
[Element("focus", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Focus {get; set;}
[Element("definition", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Definition {get; set;}

        #endregion
        #region Constructor
        public  MessageHeader() { }

        public  MessageHeader(string value) : base(value) { }
        public  MessageHeader(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "MessageHeader";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
