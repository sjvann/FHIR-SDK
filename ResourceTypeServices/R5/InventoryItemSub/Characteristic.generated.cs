
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.InventoryItemSub
{
    public class Characteristic : BackboneElement<Characteristic>
    {

        #region Property
        [Element("characteristicType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept CharacteristicType {get; set;}
[Element("value", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Value {get; set;}

        #endregion
        #region Constructor
        public  Characteristic() { }
        public  Characteristic(string value) : base(value) { }
        public  Characteristic(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Characteristic";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
