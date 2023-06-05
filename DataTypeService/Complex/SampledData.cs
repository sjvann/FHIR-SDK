using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;
namespace DataTypeService.Complex
{
    public class SampledData : ComplexType<SampledData>
    {

        #region Property
        [Element("origin", typeof(Quantity), false, false, false, false)]
        public Quantity? Origin { get; set; }
        [Element("interval", typeof(FhirDecimal), true, false, false, false)]
        public FhirDecimal? Interval { get; set; }
        [Element("intervalUnit", typeof(FhirCode), true, false, false, false)]
        public FhirCode? IntervalUnit { get; set; }
        [Element("factor", typeof(FhirDecimal), true, false, false, false)]
        public FhirDecimal? Factor { get; set; }
        [Element("lowerLimit", typeof(FhirDecimal), true, false, false, false)]
        public FhirDecimal? LowerLimit { get; set; }
        [Element("upperLimit", typeof(FhirDecimal), true, false, false, false)]
        public FhirDecimal? UpperLimit { get; set; }
        [Element("dimensions", typeof(FhirPositiveInt), true, false, false, false)]
        public FhirPositiveInt? Dimensions { get; set; }
        [Element("data", typeof(FhirString), true, false, false, false)]
        public FhirString? Data { get; set; }
        #endregion
        #region Constructor
        public SampledData() { }
        public SampledData(string? value) : base(value) { }
        public SampledData(JsonNode? source) : base(source) { }


        #endregion
        #region From Parent
        protected override string _TypeName => "SampledData";

        #endregion

        #region public Method        
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }


        #endregion
    }
}
