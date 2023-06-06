
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.InventoryItemSub
{
    public class Association : BackboneElement<Association>
    {

        #region Property
        [Element("associationType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept AssociationType {get; set;}
[Element("relatedItem", typeof(Reference), false, false, false, false)]
public Reference RelatedItem {get; set;}
[Element("quantity", typeof(Ratio), false, false, false, false)]
public Ratio Quantity {get; set;}

        #endregion
        #region Constructor
        public  Association() { }
        public  Association(string value) : base(value) { }
        public  Association(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Association";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
