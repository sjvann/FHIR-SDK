
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ExplanationOfBenefitSub
{
    public class Diagnosis : BackboneElement<Diagnosis>
    {

        #region Property
        [Element("sequence", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt Sequence {get; set;}
[Element("diagnosis", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased DiagnosisProp {get; set;}
[Element("type", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Type {get; set;}
[Element("onAdmission", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept OnAdmission {get; set;}

        #endregion
        #region Constructor
        public  Diagnosis() { }
        public  Diagnosis(string value) : base(value) { }
        public  Diagnosis(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Diagnosis";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
