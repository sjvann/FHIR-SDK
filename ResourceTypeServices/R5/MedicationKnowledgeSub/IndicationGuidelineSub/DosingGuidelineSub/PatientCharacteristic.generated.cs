
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.MedicationKnowledgeSub.IndicationGuidelineSub.DosingGuidelineSub
{
    public class PatientCharacteristic : BackboneElement<PatientCharacteristic>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("value", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Value {get; set;}

        #endregion
        #region Constructor
        public  PatientCharacteristic() { }
        public  PatientCharacteristic(string value) : base(value) { }
        public  PatientCharacteristic(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "PatientCharacteristic";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
