
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace ResourceTypeServices.R5.AdverseEventSub
{
    public class PreventiveAction : BackboneElement<PreventiveAction>
    {

        #region Property
        [Element("item", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Item {get; set;}

        #endregion
        #region Constructor
        public  PreventiveAction() { }
        public  PreventiveAction(string value) : base(value) { }
        public  PreventiveAction(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "PreventiveAction";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
