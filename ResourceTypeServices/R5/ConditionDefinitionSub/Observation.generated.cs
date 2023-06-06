
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ConditionDefinitionSub
{
    public class Observation : BackboneElement<Observation>
    {

        #region Property
        [Element("category", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Category {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}

        #endregion
        #region Constructor
        public  Observation() { }
        public  Observation(string value) : base(value) { }
        public  Observation(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Observation";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
