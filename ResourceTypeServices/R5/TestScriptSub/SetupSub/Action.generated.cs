
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using ResourceTypeServices.R5.TestScriptSub.SetupSub.ActionSub;

namespace ResourceTypeServices.R5.TestScriptSub.SetupSub
{
    public class Action : BackboneElement<Action>
    {

        #region Property
        [Element("operation", typeof(Operation), false, false, false, true)]
public Operation Operation {get; set;}
[Element("assert", typeof(Assert), false, false, false, true)]
public Assert Assert {get; set;}

        #endregion
        #region Constructor
        public  Action() { }
        public  Action(string value) : base(value) { }
        public  Action(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Action";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
