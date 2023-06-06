

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ConditionSub
{
    public class Condition : DomainResource<Condition>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("clinicalStatus", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ClinicalStatus {get; set;}
[Element("verificationStatus", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept VerificationStatus {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("severity", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Severity {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("bodySite", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> BodySite {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("onset", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Onset {get; set;}
[Element("abatement", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Abatement {get; set;}
[Element("recordedDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime RecordedDate {get; set;}
[Element("participant", typeof(Participant), false, true, false, true)]
public IEnumerable<Participant> Participant {get; set;}
[Element("stage", typeof(Stage), false, true, false, true)]
public IEnumerable<Stage> Stage {get; set;}
[Element("evidence", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Evidence {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}

        #endregion
        #region Constructor
        public  Condition() { }

        public  Condition(string value) : base(value) { }
        public  Condition(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Condition";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
