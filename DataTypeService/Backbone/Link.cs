using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Backbone
{
    public class Link : ComplexType<Link>
    {
        #region Property
        [Element("other", typeof(Reference), false, false, false, false)]
        public Reference? Other { get; set; }
        [Element("type", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Type { get; set; }
        #endregion
        #region Constructor
        public Link() { }
        public Link(string? value) : base(value)
        {

        }
        public Link(JsonNode? source): base(source) { }

        #endregion
        #region From Parent
        protected override string _TypeName => "Link";

        #endregion

        #region public Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
