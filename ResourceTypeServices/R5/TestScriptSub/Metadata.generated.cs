
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using ResourceTypeServices.R5.TestScriptSub.MetadataSub;

namespace ResourceTypeServices.R5.TestScriptSub
{
    public class Metadata : BackboneElement<Metadata>
    {

        #region Property
        [Element("link", typeof(Link), false, true, false, true)]
public IEnumerable<Link> Link {get; set;}
[Element("capability", typeof(Capability), false, true, false, true)]
public IEnumerable<Capability> Capability {get; set;}

        #endregion
        #region Constructor
        public  Metadata() { }
        public  Metadata(string value) : base(value) { }
        public  Metadata(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Metadata";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
