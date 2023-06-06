
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.InsurancePlanSub.PlanSub.SpecificCostSub.BenefitSub
{
    public class Cost : BackboneElement<Cost>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("applicability", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Applicability {get; set;}
[Element("qualifiers", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Qualifiers {get; set;}
[Element("value", typeof(Quantity), false, false, false, false)]
public Quantity Value {get; set;}

        #endregion
        #region Constructor
        public  Cost() { }
        public  Cost(string value) : base(value) { }
        public  Cost(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Cost";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
