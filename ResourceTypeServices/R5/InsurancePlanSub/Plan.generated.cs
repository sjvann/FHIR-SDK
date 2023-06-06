
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.InsurancePlanSub.PlanSub;

namespace ResourceTypeServices.R5.InsurancePlanSub
{
    public class Plan : BackboneElement<Plan>
    {

        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("coverageArea", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> CoverageArea {get; set;}
[Element("network", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Network {get; set;}
[Element("generalCost", typeof(GeneralCost), false, true, false, true)]
public IEnumerable<GeneralCost> GeneralCost {get; set;}
[Element("specificCost", typeof(SpecificCost), false, true, false, true)]
public IEnumerable<SpecificCost> SpecificCost {get; set;}

        #endregion
        #region Constructor
        public  Plan() { }
        public  Plan(string value) : base(value) { }
        public  Plan(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Plan";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
