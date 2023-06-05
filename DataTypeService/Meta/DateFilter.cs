using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Special
{
    public class DateFilter : ComplexType<DateFilter>
    {

        #region Property
        [Element("path", typeof(FhirString), true, false, false, false)]
        public FhirString? Path { get; init; }
        [Element("searchParam", typeof(FhirString), true, false, false, false)]
        public FhirString? SearchParam { get; init; }
        [Element("value", typeof(ChoiceBased), false, false, true, false)]
        public ChoiceBased? Value { get; init; }
        #endregion
        #region Constructor
        public DateFilter() { }
        public DateFilter(string? value) : base(value) { }
        public DateFilter(JsonNode? source) : base(source) { }
        #endregion
        #region From Parent
        protected override string _TypeName => "DateFilter";
        #endregion

        #region Public Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
