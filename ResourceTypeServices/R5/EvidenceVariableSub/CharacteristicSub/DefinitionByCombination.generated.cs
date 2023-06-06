
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.EvidenceVariableSub.CharacteristicSub
{
    public class DefinitionByCombination : BackboneElement<DefinitionByCombination>
    {

        #region Property
        [Element("code", typeof(FhirCode), true, false, false, false)]
public FhirCode Code {get; set;}
[Element("threshold", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt Threshold {get; set;}

        #endregion
        #region Constructor
        public  DefinitionByCombination() { }
        public  DefinitionByCombination(string value) : base(value) { }
        public  DefinitionByCombination(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "DefinitionByCombination";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
