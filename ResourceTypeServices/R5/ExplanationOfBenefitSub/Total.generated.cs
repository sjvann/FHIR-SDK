
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ExplanationOfBenefitSub
{
    public class Total : BackboneElement<Total>
    {

        #region Property
        [Element("category", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Category {get; set;}
[Element("amount", typeof(Money), false, false, false, false)]
public Money Amount {get; set;}

        #endregion
        #region Constructor
        public  Total() { }
        public  Total(string value) : base(value) { }
        public  Total(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Total";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
