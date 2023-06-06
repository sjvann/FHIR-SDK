
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.EvidenceSub.StatisticSub.ModelCharacteristicSub;

namespace ResourceTypeServices.R5.EvidenceSub.StatisticSub
{
    public class ModelCharacteristic : BackboneElement<ModelCharacteristic>
    {

        #region Property
        [Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("value", typeof(Quantity), false, false, false, false)]
public Quantity Value {get; set;}
[Element("variable", typeof(Variable), false, true, false, true)]
public IEnumerable<Variable> Variable {get; set;}

        #endregion
        #region Constructor
        public  ModelCharacteristic() { }
        public  ModelCharacteristic(string value) : base(value) { }
        public  ModelCharacteristic(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ModelCharacteristic";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
