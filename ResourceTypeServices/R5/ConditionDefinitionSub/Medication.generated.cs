
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ConditionDefinitionSub
{
    public class Medication : BackboneElement<Medication>
    {

        #region Property
        [Element("category", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Category {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}

        #endregion
        #region Constructor
        public  Medication() { }
        public  Medication(string value) : base(value) { }
        public  Medication(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Medication";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
