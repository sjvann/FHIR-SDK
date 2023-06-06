

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.AdverseEventSub
{
    public class AdverseEvent : DomainResource<AdverseEvent>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("actuality", typeof(FhirCode), true, false, false, false)]
public FhirCode Actuality {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("occurrence", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Occurrence {get; set;}
[Element("detected", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Detected {get; set;}
[Element("recordedDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime RecordedDate {get; set;}
[Element("resultingEffect", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> ResultingEffect {get; set;}
[Element("location", typeof(Reference), false, false, false, false)]
public Reference Location {get; set;}
[Element("seriousness", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Seriousness {get; set;}
[Element("outcome", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Outcome {get; set;}
[Element("recorder", typeof(Reference), false, false, false, false)]
public Reference Recorder {get; set;}
[Element("participant", typeof(Participant), false, true, false, true)]
public IEnumerable<Participant> Participant {get; set;}
[Element("study", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Study {get; set;}
[Element("expectedInResearchStudy", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean ExpectedInResearchStudy {get; set;}
[Element("suspectEntity", typeof(SuspectEntity), false, true, false, true)]
public IEnumerable<SuspectEntity> SuspectEntity {get; set;}
[Element("contributingFactor", typeof(ContributingFactor), false, true, false, true)]
public IEnumerable<ContributingFactor> ContributingFactor {get; set;}
[Element("preventiveAction", typeof(PreventiveAction), false, true, false, true)]
public IEnumerable<PreventiveAction> PreventiveAction {get; set;}
[Element("mitigatingAction", typeof(MitigatingAction), false, true, false, true)]
public IEnumerable<MitigatingAction> MitigatingAction {get; set;}
[Element("supportingInfo", typeof(SupportingInfo), false, true, false, true)]
public IEnumerable<SupportingInfo> SupportingInfo {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}

        #endregion
        #region Constructor
        public  AdverseEvent() { }

        public  AdverseEvent(string value) : base(value) { }
        public  AdverseEvent(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "AdverseEvent";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
