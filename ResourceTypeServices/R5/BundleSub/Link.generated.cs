
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.BundleSub
{
    public class Link : BackboneElement<Link>
    {

        #region Property
        [Element("relation", typeof(FhirCode), true, false, false, false)]
public FhirCode Relation {get; set;}
[Element("url", typeof(FhirUri), true, false, false, false)]
public FhirUri Url {get; set;}

        #endregion
        #region Constructor
        public  Link() { }
        public  Link(string value) : base(value) { }
        public  Link(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Link";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
