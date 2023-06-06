

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.RiskAssessmentSub
{
    public class RiskAssessment : DomainResource<RiskAssessment>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("basedOn", typeof(Reference), false, false, false, false)]
public Reference BasedOn {get; set;}
[Element("parent", typeof(Reference), false, false, false, false)]
public Reference Parent {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("method", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Method {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("occurrence", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Occurrence {get; set;}
[Element("condition", typeof(Reference), false, false, false, false)]
public Reference Condition {get; set;}
[Element("performer", typeof(Reference), false, false, false, false)]
public Reference Performer {get; set;}
[Element("reason", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Reason {get; set;}
[Element("basis", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Basis {get; set;}
[Element("prediction", typeof(Prediction), false, true, false, true)]
public IEnumerable<Prediction> Prediction {get; set;}
[Element("mitigation", typeof(FhirString), true, false, false, false)]
public FhirString Mitigation {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}

        #endregion
        #region Constructor
        public  RiskAssessment() { }

        public  RiskAssessment(string value) : base(value) { }
        public  RiskAssessment(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "RiskAssessment";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
