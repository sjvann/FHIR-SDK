
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ClaimResponseSub
{
    public class Payment : BackboneElement<Payment>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("adjustment", typeof(Money), false, false, false, false)]
public Money Adjustment {get; set;}
[Element("adjustmentReason", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept AdjustmentReason {get; set;}
[Element("date", typeof(FhirDate), true, false, false, false)]
public FhirDate Date {get; set;}
[Element("amount", typeof(Money), false, false, false, false)]
public Money Amount {get; set;}
[Element("identifier", typeof(Identifier), false, false, false, false)]
public Identifier Identifier {get; set;}

        #endregion
        #region Constructor
        public  Payment() { }
        public  Payment(string value) : base(value) { }
        public  Payment(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Payment";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
