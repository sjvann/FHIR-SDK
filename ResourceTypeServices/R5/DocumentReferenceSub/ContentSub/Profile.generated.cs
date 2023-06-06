
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace ResourceTypeServices.R5.DocumentReferenceSub.ContentSub
{
    public class Profile : BackboneElement<Profile>
    {

        #region Property
        [Element("value", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Value {get; set;}

        #endregion
        #region Constructor
        public  Profile() { }
        public  Profile(string value) : base(value) { }
        public  Profile(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Profile";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
