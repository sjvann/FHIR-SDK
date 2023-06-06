
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.SupplyDeliverySub
{
    public class SuppliedItem : BackboneElement<SuppliedItem>
    {

        #region Property
        [Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}
[Element("item", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Item {get; set;}

        #endregion
        #region Constructor
        public  SuppliedItem() { }
        public  SuppliedItem(string value) : base(value) { }
        public  SuppliedItem(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "SuppliedItem";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
