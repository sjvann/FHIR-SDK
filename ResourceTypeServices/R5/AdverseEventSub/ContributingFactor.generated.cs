
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace ResourceTypeServices.R5.AdverseEventSub
{
    public class ContributingFactor : BackboneElement<ContributingFactor>
    {

        #region Property
        [Element("item", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Item {get; set;}

        #endregion
        #region Constructor
        public  ContributingFactor() { }
        public  ContributingFactor(string value) : base(value) { }
        public  ContributingFactor(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ContributingFactor";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
