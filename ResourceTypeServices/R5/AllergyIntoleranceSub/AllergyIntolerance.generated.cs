

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.AllergyIntoleranceSub
{
    public class AllergyIntolerance : DomainResource<AllergyIntolerance>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("clinicalStatus", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ClinicalStatus {get; set;}
[Element("verificationStatus", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept VerificationStatus {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("category", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> Category {get; set;}
[Element("criticality", typeof(FhirCode), true, false, false, false)]
public FhirCode Criticality {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("patient", typeof(Reference), false, false, false, false)]
public Reference Patient {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("onset", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Onset {get; set;}
[Element("recordedDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime RecordedDate {get; set;}
[Element("participant", typeof(Participant), false, true, false, true)]
public IEnumerable<Participant> Participant {get; set;}
[Element("lastOccurrence", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime LastOccurrence {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("reaction", typeof(Reaction), false, true, false, true)]
public IEnumerable<Reaction> Reaction {get; set;}

        #endregion
        #region Constructor
        public  AllergyIntolerance() { }

        public  AllergyIntolerance(string value) : base(value) { }
        public  AllergyIntolerance(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "AllergyIntolerance";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
