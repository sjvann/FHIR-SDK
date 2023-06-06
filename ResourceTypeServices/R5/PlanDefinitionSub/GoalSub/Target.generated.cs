
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.PlanDefinitionSub.GoalSub
{
    public class Target : BackboneElement<Target>
    {

        #region Property
        [Element("measure", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Measure {get; set;}
[Element("detail", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Detail {get; set;}
[Element("due", typeof(Duration), false, false, false, false)]
public Duration Due {get; set;}

        #endregion
        #region Constructor
        public  Target() { }
        public  Target(string value) : base(value) { }
        public  Target(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Target";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
