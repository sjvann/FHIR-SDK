
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.InvoiceSub
{
    public class LineItem : BackboneElement<LineItem>
    {

        #region Property
        [Element("sequence", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt Sequence {get; set;}
[Element("serviced", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Serviced {get; set;}
[Element("chargeItem", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased ChargeItem {get; set;}
[Element("priceComponent", typeof(MonetaryComponent), false, true, false, false)]
public IEnumerable<MonetaryComponent> PriceComponent {get; set;}

        #endregion
        #region Constructor
        public  LineItem() { }
        public  LineItem(string value) : base(value) { }
        public  LineItem(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "LineItem";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
