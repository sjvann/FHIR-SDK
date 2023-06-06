

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ImmunizationEvaluationSub
{
    public class ImmunizationEvaluation : DomainResource<ImmunizationEvaluation>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("patient", typeof(Reference), false, false, false, false)]
public Reference Patient {get; set;}
[Element("date", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Date {get; set;}
[Element("authority", typeof(Reference), false, false, false, false)]
public Reference Authority {get; set;}
[Element("targetDisease", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept TargetDisease {get; set;}
[Element("immunizationEvent", typeof(Reference), false, false, false, false)]
public Reference ImmunizationEvent {get; set;}
[Element("doseStatus", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept DoseStatus {get; set;}
[Element("doseStatusReason", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> DoseStatusReason {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("series", typeof(FhirString), true, false, false, false)]
public FhirString Series {get; set;}
[Element("doseNumber", typeof(FhirString), true, false, false, false)]
public FhirString DoseNumber {get; set;}
[Element("seriesDoses", typeof(FhirString), true, false, false, false)]
public FhirString SeriesDoses {get; set;}

        #endregion
        #region Constructor
        public  ImmunizationEvaluation() { }

        public  ImmunizationEvaluation(string value) : base(value) { }
        public  ImmunizationEvaluation(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "ImmunizationEvaluation";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
