

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ProcedureSub
{
    public class Procedure : DomainResource<Procedure>
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
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("statusReason", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept StatusReason {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("focus", typeof(Reference), false, false, false, false)]
public Reference Focus {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("occurrence", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Occurrence {get; set;}
[Element("recorded", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Recorded {get; set;}
[Element("recorder", typeof(Reference), false, false, false, false)]
public Reference Recorder {get; set;}
[Element("reported", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Reported {get; set;}
[Element("performer", typeof(Performer), false, true, false, true)]
public IEnumerable<Performer> Performer {get; set;}
[Element("location", typeof(Reference), false, false, false, false)]
public Reference Location {get; set;}
[Element("reason", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Reason {get; set;}
[Element("bodySite", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> BodySite {get; set;}
[Element("outcome", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Outcome {get; set;}
[Element("report", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Report {get; set;}
[Element("complication", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Complication {get; set;}
[Element("followUp", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> FollowUp {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("focalDevice", typeof(FocalDevice), false, true, false, true)]
public IEnumerable<FocalDevice> FocalDevice {get; set;}
[Element("used", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Used {get; set;}
[Element("supportingInfo", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> SupportingInfo {get; set;}

        #endregion
        #region Constructor
        public  Procedure() { }

        public  Procedure(string value) : base(value) { }
        public  Procedure(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Procedure";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
