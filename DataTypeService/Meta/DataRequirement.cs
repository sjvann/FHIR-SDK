using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Special
{
    public class DataRequirement : ComplexType<DataRequirement>
    {

        #region Property
        [Element("type", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Type { get; set; }
        [Element("profile", typeof(FhirCanonical), true, true, false, false)]
        public IEnumerable<FhirCanonical>? Profile { get; set; }
        [Element("subject", typeof(ChoiceBased), false, false, true, false)]
        public ChoiceBased? Subject { get; set; }
        [Element("mustSupport", typeof(FhirString), true, true, false, false)]
        public IEnumerable<FhirString>? MustSupport { get; set; }
        [Element("codeFilter", typeof(CodeFilter), false, true, false, false)]
        public IEnumerable<CodeFilter>? CodeFilter { get; set; }
        [Element("dateFilter", typeof(DateFilter), false, true, false, false)]
        public IEnumerable<DateFilter>? DateFilter { get; set; }
        [Element("valueFilter", typeof(ValueFilter), false, true, false, false)]
        public IEnumerable<ValueFilter>? ValueFilter { get; set; }
        [Element("limit", typeof(FhirPositiveInt), true, false, false, false)]
        public FhirPositiveInt? Limit { get; set; }
        [Element("sort", typeof(Sort), false, true, false, false)]
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
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
