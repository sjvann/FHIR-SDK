
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ExplanationOfBenefitSub.ItemSub
{
    public class Adjudication : BackboneElement<Adjudication>
    {

        #region Property
        [Element("category", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Category {get; set;}
[Element("reason", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Reason {get; set;}
[Element("amount", typeof(Money), false, false, false, false)]
public Money Amount {get; set;}
[Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}

        #endregion
        #region Constructor
        public  Adjudication() { }
        public  Adjudication(string value) : base(value) { }
        public  Adjudication(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Adjudication";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
