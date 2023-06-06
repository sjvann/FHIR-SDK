

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CommunicationSub
{
    public class Communication : DomainResource<Communication>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("instantiatesCanonical", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> InstantiatesCanonical {get; set;}
[Element("instantiatesUri", typeof(FhirUri), true, true, false, false)]
public IEnumerable<FhirUri> InstantiatesUri {get; set;}
[Element("basedOn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> BasedOn {get; set;}
[Element("partOf", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> PartOf {get; set;}
[Element("inResponseTo", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> InResponseTo {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("statusReason", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept StatusReason {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("priority", typeof(FhirCode), true, false, false, false)]
public FhirCode Priority {get; set;}
[Element("medium", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Medium {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("topic", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Topic {get; set;}
[Element("about", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> About {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("sent", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Sent {get; set;}
[Element("received", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Received {get; set;}
[Element("recipient", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Recipient {get; set;}
[Element("sender", typeof(Reference), false, false, false, false)]
public Reference Sender {get; set;}
[Element("reason", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Reason {get; set;}
[Element("payload", typeof(Payload), false, true, false, true)]
public IEnumerable<Payload> Payload {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}

        #endregion
        #region Constructor
        public  Communication() { }

        public  Communication(string value) : base(value) { }
        public  Communication(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Communication";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
