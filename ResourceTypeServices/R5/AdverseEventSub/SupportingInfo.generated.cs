
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace ResourceTypeServices.R5.AdverseEventSub
{
    public class SupportingInfo : BackboneElement<SupportingInfo>
    {

        #region Property
        [Element("item", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Item {get; set;}

        #endregion
        #region Constructor
        public  SupportingInfo() { }
        public  SupportingInfo(string value) : base(value) { }
        public  SupportingInfo(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "SupportingInfo";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
