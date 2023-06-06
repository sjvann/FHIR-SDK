
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using ResourceTypeServices.R5.TestScriptSub.SetupSub;

namespace ResourceTypeServices.R5.TestScriptSub
{
    public class Setup : BackboneElement<Setup>
    {

        #region Property
        [Element("action", typeof(ResourceTypeServices.R5.TestScriptSub.SetupSub.Action), false, true, false, true)]
public IEnumerable<ResourceTypeServices.R5.TestScriptSub.SetupSub.Action> Action {get; set;}

        #endregion
        #region Constructor
        public  Setup() { }
        public  Setup(string value) : base(value) { }
        public  Setup(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Setup";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
