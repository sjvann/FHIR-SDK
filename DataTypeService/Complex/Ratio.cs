using Core.Attribute;

using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class Ratio : ComplexType<Ratio>
    {

        #region Property
        [Element("numerator", typeof(Quantity), false, false, false, false)]
        public Quantity? Numerator { get; set; }
        [Element("denominator", typeof(Quantity), false, false, false, false)]
        public Quantity? Denominator { get; set; }
        #endregion
        #region Constructor
        public Ratio() { }
        public Ratio(string? value) : base(value) { }
        public Ratio(JsonNode? source) : base(source) { }

        #endregion
        #region From Parent
        protected override string _TypeName => "Ratio";

        #endregion

        #region public Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
