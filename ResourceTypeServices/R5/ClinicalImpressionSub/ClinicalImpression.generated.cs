

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ClinicalImpressionSub
{
    public class ClinicalImpression : DomainResource<ClinicalImpression>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("statusReason", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept StatusReason {get; set;}
[Element("description", typeof(FhirString), true, false, false, false)]
public FhirString Description {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("effective", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Effective {get; set;}
[Element("date", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Date {get; set;}
[Element("performer", typeof(Reference), false, false, false, false)]
public Reference Performer {get; set;}
[Element("previous", typeof(Reference), false, false, false, false)]
public Reference Previous {get; set;}
[Element("problem", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Problem {get; set;}
[Element("changePattern", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ChangePattern {get; set;}
[Element("protocol", typeof(FhirUri), true, true, false, false)]
public IEnumerable<FhirUri> Protocol {get; set;}
[Element("summary", typeof(FhirString), true, false, false, false)]
public FhirString Summary {get; set;}
[Element("finding", typeof(Finding), false, true, false, true)]
public IEnumerable<Finding> Finding {get; set;}
[Element("prognosisCodeableConcept", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> PrognosisCodeableConcept {get; set;}
[Element("prognosisReference", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> PrognosisReference {get; set;}
[Element("supportingInfo", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> SupportingInfo {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}

        #endregion
        #region Constructor
        public  ClinicalImpression() { }

        public  ClinicalImpression(string value) : base(value) { }
        public  ClinicalImpression(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "ClinicalImpression";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
