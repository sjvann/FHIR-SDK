
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.MedicationKnowledgeSub.DefinitionalSub
{
    public class DrugCharacteristic : BackboneElement<DrugCharacteristic>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("value", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Value {get; set;}

        #endregion
        #region Constructor
        public  DrugCharacteristic() { }
        public  DrugCharacteristic(string value) : base(value) { }
        public  DrugCharacteristic(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "DrugCharacteristic";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
