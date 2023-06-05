using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class DataRequirement : ComplexType<DataRequirement>
    {

        #region Property
        [Element("type", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Type { get; set; }
        [Element("profile", typeof(FhirCanonical), false, true, false, false)]
        public IEnumerable<FhirCanonical>? Profile { get; set; }
        [Element("subject", typeof(ChoiceBased), false, false, true, false)]
        public ChoiceBased? Subject { get; set; }
        [Element("mustSupport", typeof(FhirString), true, true, false, false)]
        public IEnumerable<FhirString>? MustSupport { get; set; }
        [Element("codeFilter", typeof(CodeFilter), false, true, false, true)]
        public IEnumerable<CodeFilter>? CodeFilter { get; set; }
        [Element("dateFilter", typeof(DateFilter), false, true, false, true)]
        public IEnumerable<DateFilter>? DateFilter { get; set; }
        [Element("valueFilter", typeof(ValueFilter), false, true, false, true)]
        public IEnumerable<ValueFilter>? ValueFilter { get; set; }
        [Element("limit", typeof(FhirPositiveInt), true, false, false, false)]
        public FhirPositiveInt? Limit { get; set; }
        [Element("sort", typeof(Sort), false, true, false, true)]
        public IEnumerable<Sort>? Sort { get; set; }

        #endregion
        #region Constructor
        public DataRequirement() { }
        public DataRequirement(string? value) : base(value) { }
        public DataRequirement(JsonNode? source) : base(source) { }

        #endregion
        #region From Parent
        protected override string _TypeName => "DataRequirement";
        #endregion

        #region Public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }

    public class CodeFilter : ComplexType<CodeFilter>
    {

        #region Property
        [Element("path", typeof(FhirString), true, false, false, false)]
        public FhirString? Path { get; set; }
        [Element("searchParam", typeof(FhirString), true, false, false, false)]
        public FhirString? SearchParam { get; set; }
        [Element("valueSet", typeof(FhirCanonical), true, false, false, false)]
        public FhirCanonical? ValueSet { get; set; }
        [Element("code", typeof(Coding), false, true, false, false)]
        public IEnumerable<Coding>? Code { get; set; }
        #endregion
        #region Constructor
        public CodeFilter() { }
        public CodeFilter(string? value) : base(value) { }
        public CodeFilter(JsonNode? source) : base(source) { }
        #endregion
        #region From Parent
        protected override string _TypeName => "CodeFilter";
        #endregion

        #region Public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }

    public class DateFilter : ComplexType<DateFilter>
    {

        #region Property
        [Element("path", typeof(FhirString), true, false, false, false)]
        public FhirString? Path { get; set; }
        [Element("searchParam", typeof(FhirString), true, false, false, false)]
        public FhirString? SearchParam { get; set; }
        [Element("value", typeof(ChoiceBased), false, false, true, false)]
        public ChoiceBased? Value { get; set; }
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
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }

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
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }

    public class Sort : ComplexType<Sort>
    {

        #region Property
        [Element("path", typeof(FhirString), true, false, false, false)]
        public FhirString? Path { get; set; }
        [Element("direction", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Direction { get; set; }
        #endregion
        #region Constructor
        public Sort() { }
        public Sort(string? value) : base(value) { }
        public Sort(JsonNode? source) : base(source) { }
        #endregion
        #region From Parent
        protected override string _TypeName => "Sort";
        #endregion

        #region Public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }

}
