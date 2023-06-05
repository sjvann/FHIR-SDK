using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class Money : ComplexType<Money>
    {
        #region Property
        [Element("value", typeof(FhirDecimal), true, false, false, false)]
        public FhirDecimal? Value { get; set; }
        [Element("currency", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Currency { get; set; }
        #endregion
        #region Constructor
        public Money() { }
        public Money(string? value) : base(value) { }
        public Money(JsonNode? source) : base(source) { }


        #endregion
        #region From Parent
        protected override string _TypeName => "Money";
        #endregion

        #region public Method

        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
