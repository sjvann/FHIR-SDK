
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.EvidenceVariableSub.CharacteristicSub
{
    public class DefinitionByTypeAndValue : BackboneElement<DefinitionByTypeAndValue>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("method", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Method {get; set;}
[Element("device", typeof(Reference), false, false, false, false)]
public Reference Device {get; set;}
[Element("value", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Value {get; set;}
[Element("offset", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Offset {get; set;}

        #endregion
        #region Constructor
        public  DefinitionByTypeAndValue() { }
        public  DefinitionByTypeAndValue(string value) : base(value) { }
        public  DefinitionByTypeAndValue(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "DefinitionByTypeAndValue";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
