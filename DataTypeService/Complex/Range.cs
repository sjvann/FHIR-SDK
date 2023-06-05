using Core.Attribute;

using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class Range : ComplexType<Range>
    {

        #region Property
        [Element("low", typeof(SimpleQuantity), false, false, false, false)]
        public SimpleQuantity? Low { get; set; }
        [Element("high", typeof(SimpleQuantity), false, false, false, false)]
        public SimpleQuantity? High { get; set; }
        #endregion
        #region Constructor
        public Range() { }
        public Range(string? value) : base(value) { }
        public Range(JsonNode? source) : base(source) { }

        #endregion
        #region From Parent
        protected override string _TypeName => "Range";
        #endregion

        #region public Method

        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion

    }

}

