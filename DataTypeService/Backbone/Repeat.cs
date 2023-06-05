using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Backbone
{
    public class Repeat : ComplexType<Repeat>
    {
        #region Property
        public ChoiceBased? Bounds { get; init; }
        public FhirPositiveInt? Count { get; init; }
        public FhirPositiveInt? CountMax { get; init; }
        public FhirDecimal? Duration { get; init; }
        public FhirDecimal? DurationMax { get; init; }
        public FhirCode? DurationUnit { get; init; }
        public FhirPositiveInt? Frequency { get; init; }
        public FhirPositiveInt? FrequencyMax { get; init; }
        public FhirDecimal? Period { get; init; }
        public FhirDecimal? PeriodMax { get; init; }
        public FhirCode? PeriodUnit { get; init; }
        public IEnumerable<FhirCode>? DayOfWeek { get; init; }
        public IEnumerable<FhirTime>? TimeOfDay { get; init; }
        public IEnumerable<FhirCode>? When { get; init; }
        public FhirUnsignedInt? Offset { get; init; }
        #endregion
        #region Constructor
        public Repeat() { }
        public Repeat(string? value) : base(value)
        {

        }
        public Repeat(JsonNode? source): base(source) { }

        #endregion
        #region From Parent
        protected override string _TypeName => "Repeat";

        #endregion

        #region public Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
