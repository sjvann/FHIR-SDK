
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.InventoryReportSub.InventoryListingSub
{
    public class Item : BackboneElement<Item>
    {

        #region Property
        [Element("category", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Category {get; set;}
[Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}
[Element("item", typeof(CodeableReference), false, false, false, false)]
public CodeableReference ItemProp {get; set;}

        #endregion
        #region Constructor
        public  Item() { }
        public  Item(string value) : base(value) { }
        public  Item(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Item";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
