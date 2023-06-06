
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.CoverageEligibilityResponseSub.InsuranceSub.ItemSub
{
    public class Benefit : BackboneElement<Benefit>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("allowed", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Allowed {get; set;}
[Element("used", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Used {get; set;}

        #endregion
        #region Constructor
        public  Benefit() { }
        public  Benefit(string value) : base(value) { }
        public  Benefit(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Benefit";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
