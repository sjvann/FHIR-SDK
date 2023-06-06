
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.InsurancePlanSub.PlanSub
{
    public class GeneralCost : BackboneElement<GeneralCost>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("groupSize", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt GroupSize {get; set;}
[Element("cost", typeof(Money), false, false, false, false)]
public Money Cost {get; set;}
[Element("comment", typeof(FhirString), true, false, false, false)]
public FhirString Comment {get; set;}

        #endregion
        #region Constructor
        public  GeneralCost() { }
        public  GeneralCost(string value) : base(value) { }
        public  GeneralCost(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "GeneralCost";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
