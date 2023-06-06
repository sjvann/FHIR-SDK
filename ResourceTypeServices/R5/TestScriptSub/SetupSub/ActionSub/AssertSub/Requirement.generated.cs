
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace ResourceTypeServices.R5.TestScriptSub.SetupSub.ActionSub.AssertSub
{
    public class Requirement : BackboneElement<Requirement>
    {

        #region Property
        [Element("link", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Link {get; set;}

        #endregion
        #region Constructor
        public  Requirement() { }
        public  Requirement(string value) : base(value) { }
        public  Requirement(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Requirement";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
