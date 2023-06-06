
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.InsurancePlanSub.CoverageSub.BenefitSub
{
    public class Limit : BackboneElement<Limit>
    {

        #region Property
        [Element("value", typeof(Quantity), false, false, false, false)]
public Quantity Value {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}

        #endregion
        #region Constructor
        public  Limit() { }
        public  Limit(string value) : base(value) { }
        public  Limit(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Limit";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
