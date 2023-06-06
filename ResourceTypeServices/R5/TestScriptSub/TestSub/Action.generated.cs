
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace ResourceTypeServices.R5.TestScriptSub.TestSub
{
    public class Action : BackboneElement<Action>
    {

        #region Property
        
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
