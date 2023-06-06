
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.PersonSub
{
    public class Link : BackboneElement<Link>
    {

        #region Property
        [Element("target", typeof(Reference), false, false, false, false)]
public Reference Target {get; set;}
[Element("assurance", typeof(FhirCode), true, false, false, false)]
public FhirCode Assurance {get; set;}

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
