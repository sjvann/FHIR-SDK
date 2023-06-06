
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.DocumentReferenceSub.ContentSub;

namespace ResourceTypeServices.R5.DocumentReferenceSub
{
    public class Content : BackboneElement<Content>
    {

        #region Property
        [Element("attachment", typeof(Attachment), false, false, false, false)]
public Attachment Attachment {get; set;}
[Element("profile", typeof(Profile), false, true, false, true)]
public IEnumerable<Profile> Profile {get; set;}

        #endregion
        #region Constructor
        public  Content() { }
        public  Content(string value) : base(value) { }
        public  Content(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Content";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
