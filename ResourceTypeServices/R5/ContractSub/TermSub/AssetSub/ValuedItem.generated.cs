
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ContractSub.TermSub.AssetSub
{
    public class ValuedItem : BackboneElement<ValuedItem>
    {

        #region Property
        [Element("entity", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Entity {get; set;}
[Element("identifier", typeof(Identifier), false, false, false, false)]
public Identifier Identifier {get; set;}
[Element("effectiveTime", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime EffectiveTime {get; set;}
[Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}
[Element("unitPrice", typeof(Money), false, false, false, false)]
public Money UnitPrice {get; set;}
[Element("factor", typeof(FhirDecimal), true, false, false, false)]
public FhirDecimal Factor {get; set;}
[Element("points", typeof(FhirDecimal), true, false, false, false)]
public FhirDecimal Points {get; set;}
[Element("net", typeof(Money), false, false, false, false)]
public Money Net {get; set;}
[Element("payment", typeof(FhirString), true, false, false, false)]
public FhirString Payment {get; set;}
[Element("paymentDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime PaymentDate {get; set;}
[Element("responsible", typeof(Reference), false, false, false, false)]
public Reference Responsible {get; set;}
[Element("recipient", typeof(Reference), false, false, false, false)]
public Reference Recipient {get; set;}
[Element("linkId", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> LinkId {get; set;}
[Element("securityLabelNumber", typeof(FhirUnsignedInt), true, true, false, false)]
public IEnumerable<FhirUnsignedInt> SecurityLabelNumber {get; set;}

        #endregion
        #region Constructor
        public  ValuedItem() { }
        public  ValuedItem(string value) : base(value) { }
        public  ValuedItem(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ValuedItem";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
