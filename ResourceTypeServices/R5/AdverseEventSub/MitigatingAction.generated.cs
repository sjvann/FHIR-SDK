
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace ResourceTypeServices.R5.AdverseEventSub
{
    public class MitigatingAction : BackboneElement<MitigatingAction>
    {

        #region Property
        [Element("item", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Item {get; set;}

        #endregion
        #region Constructor
        public  MitigatingAction() { }
        public  MitigatingAction(string value) : base(value) { }
        public  MitigatingAction(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "MitigatingAction";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
