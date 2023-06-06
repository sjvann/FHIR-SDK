
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.MedicationKnowledgeSub.StorageGuidelineSub
{
    public class EnvironmentalSetting : BackboneElement<EnvironmentalSetting>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("value", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Value {get; set;}

        #endregion
        #region Constructor
        public  EnvironmentalSetting() { }
        public  EnvironmentalSetting(string value) : base(value) { }
        public  EnvironmentalSetting(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "EnvironmentalSetting";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
