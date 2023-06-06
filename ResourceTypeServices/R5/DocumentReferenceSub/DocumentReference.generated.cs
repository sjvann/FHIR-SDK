

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DocumentReferenceSub
{
    public class DocumentReference : DomainResource<DocumentReference>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("version", typeof(FhirString), true, false, false, false)]
public FhirString Version {get; set;}
[Element("basedOn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> BasedOn {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("docStatus", typeof(FhirCode), true, false, false, false)]
public FhirCode DocStatus {get; set;}
[Element("modality", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Modality {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("context", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Context {get; set;}
[Element("event", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Event {get; set;}
[Element("bodySite", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> BodySite {get; set;}
[Element("facilityType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept FacilityType {get; set;}
[Element("practiceSetting", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept PracticeSetting {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}
[Element("date", typeof(FhirInstant), true, false, false, false)]
public FhirInstant Date {get; set;}
[Element("author", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Author {get; set;}
[Element("attester", typeof(Attester), false, true, false, true)]
public IEnumerable<Attester> Attester {get; set;}
[Element("custodian", typeof(Reference), false, false, false, false)]
public Reference Custodian {get; set;}
[Element("relatesTo", typeof(RelatesTo), false, true, false, true)]
public IEnumerable<RelatesTo> RelatesTo {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("securityLabel", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> SecurityLabel {get; set;}
[Element("content", typeof(Content), false, true, false, true)]
public IEnumerable<Content> Content {get; set;}

        #endregion
        #region Constructor
        public  DocumentReference() { }

        public  DocumentReference(string value) : base(value) { }
        public  DocumentReference(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "DocumentReference";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
