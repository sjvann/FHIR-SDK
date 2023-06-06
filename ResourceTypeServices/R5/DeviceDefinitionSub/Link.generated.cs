
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.DeviceDefinitionSub
{
    public class Link : BackboneElement<Link>
    {

        #region Property
        [Element("relation", typeof(Coding), false, false, false, false)]
public Coding Relation {get; set;}
[Element("relatedDevice", typeof(CodeableReference), false, false, false, false)]
public CodeableReference RelatedDevice {get; set;}

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
