using Core.Attribute;

using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class RatioRange : ComplexType<RatioRange>
    {

        #region Property
        [Element("lowNumerator", typeof(Quantity), false, false, false, false)]
        public Quantity? LowNumerator { get; set; }
        [Element("highNumerator", typeof(Quantity), false, false, false, false)]
        public Quantity? HighNumerator { get; set; }
        [Element("denominator", typeof(Quantity), false, false, false, false)]
        public Quantity? Denominator { get; set; }
        #endregion
        #region Constructor
        public RatioRange() { }
        public RatioRange(string? value) : base(value) { }
        public RatioRange(JsonNode? source) : base(source) { }


        #endregion
        #region From Parent
        protected override string _TypeName => "RatioRange";

        #endregion

        #region public Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
