using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Special
{
    public class ValueFilter : ComplexType<ValueFilter>
    {

        #region Property
        [Element("path", typeof(FhirString), true, false, false, false)]
        public FhirString? Path { get; set; }
        [Element("searchParam", typeof(FhirString), true, false, false, false)]
        public FhirString? SearchParam { get; set; }
        [Element("comparator", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Comparator { get; set; }
        [Element("value", typeof(ChoiceBased), false, false, true, false)]
        public ChoiceBased? Value { get; set; }
        #endregion
        #region Constructor
        public ValueFilter() { }
        public ValueFilter(string? value) : base(value) { }
        public ValueFilter(JsonNode? source) : base(source) { }
        #endregion
        #region From Parent
        protected override string _TypeName => "ValueFilter";
        #endregion

        #region Public Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
