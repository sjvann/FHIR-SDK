using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class Repeat : ComplexType<Repeat>
    {
        #region Property
         [Element("event", typeof(ChoiceBased), true, true, false, false)]
        public ChoiceBased? Bounds { get; init; }
         [Element("event", typeof(FhirPositiveInt), true, true, false, false)]
        public FhirPositiveInt? Count { get; init; }
         [Element("event", typeof(FhirPositiveInt), true, true, false, false)]
        public FhirPositiveInt? CountMax { get; init; }
         [Element("event", typeof(FhirDecimal), true, true, false, false)]
        public FhirDecimal? Duration { get; init; }
         [Element("event", typeof(FhirDecimal), true, true, false, false)]
        public FhirDecimal? DurationMax { get; init; }
         [Element("event", typeof(FhirCode), true, true, false, false)]
        public FhirCode? DurationUnit { get; init; }
         [Element("event", typeof(FhirPositiveInt), true, true, false, false)]
        public FhirPositiveInt? Frequency { get; init; }
         [Element("event", typeof(FhirPositiveInt), true, true, false, false)]
        public FhirPositiveInt? FrequencyMax { get; init; }
         [Element("event", typeof(FhirDecimal), true, true, false, false)]
        public FhirDecimal? Period { get; init; }
         [Element("event", typeof(FhirDecimal), true, true, false, false)]
        public FhirDecimal? PeriodMax { get; init; }
         [Element("event", typeof(FhirCode), true, true, false, false)]
        public FhirCode? PeriodUnit { get; init; }
         [Element("event", typeof(FhirCode), true, true, false, false)]
        public IEnumerable<FhirCode>? DayOfWeek { get; init; } 
        [Element("event", typeof(FhirDateTime), true, true, false, false)]
        public IEnumerable<FhirTime>? TimeOfDay { get; init; }
         [Element("event", typeof(FhirCode), true, true, false, false)]
        public IEnumerable<FhirCode>? When { get; init; }
         [Element("event", typeof(FhirUnsignedInt), true, true, false, false)]
        public FhirUnsignedInt? Offset { get; init; }
        #endregion
        #region Constructor
        public Repeat() { }

        public Repeat(string? value) : base(value)
        {

        }
        public Repeat(JsonNode? source) : base(source) { }

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
