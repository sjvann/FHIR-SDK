
using Core.Attribute;

using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class Extension : ComplexType<Extension>
    {
        #region Property
        [Element("url", typeof(FhirUri), true, false, false, false)]
        public FhirUri? Url { get; set; }
        [Element("value", typeof(ChoiceBased), false, false, true, false)]
        public ChoiceBased? Value { get; set; }
        #endregion
        #region Constructor
        public Extension() { }
        public Extension(string? value) : base(value) { }
        public Extension(JsonNode? source) : base(source) { }

        #endregion
        #region From Parent
        protected override string _TypeName => "Extension";


        #endregion

        #region public Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
