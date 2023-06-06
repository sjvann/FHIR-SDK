
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.NutritionIntakeSub
{
    public class ConsumedItem : BackboneElement<ConsumedItem>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("nutritionProduct", typeof(CodeableReference), false, false, false, false)]
public CodeableReference NutritionProduct {get; set;}
[Element("schedule", typeof(Timing), false, false, false, false)]
public Timing Schedule {get; set;}
[Element("amount", typeof(Quantity), false, false, false, false)]
public Quantity Amount {get; set;}
[Element("rate", typeof(Quantity), false, false, false, false)]
public Quantity Rate {get; set;}
[Element("notConsumed", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean NotConsumed {get; set;}
[Element("notConsumedReason", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept NotConsumedReason {get; set;}

        #endregion
        #region Constructor
        public  ConsumedItem() { }
        public  ConsumedItem(string value) : base(value) { }
        public  ConsumedItem(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ConsumedItem";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
