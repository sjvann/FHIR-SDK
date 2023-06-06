
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace ResourceTypeServices.R5.QuestionnaireSub.ItemSub
{
    public class Initial : BackboneElement<Initial>
    {

        #region Property
        [Element("value", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Value {get; set;}

        #endregion
        #region Constructor
        public  Initial() { }
        public  Initial(string value) : base(value) { }
        public  Initial(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Initial";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
