using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;
namespace DataTypeService.Complex
{
    public class Quantity : ComplexType<Quantity>
    {
        #region Property
        [Element("value", typeof(FhirDecimal), true, false, false, false)]
        public FhirDecimal? Value { get; set; }
        [Element("comparator", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Comparator { get; set; }
        [Element("unit", typeof(FhirString), true, false, false, false)]
        public FhirString? Unit { get; set; }
        [Element("system", typeof(FhirUri), true, false, false, false)]
        public FhirUri? System { get; set; }
        [Element("code", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Code { get; set; }

        #endregion
        #region Constructor
        public Quantity() { }
        public Quantity(string? value) : base(value) { }
        public Quantity(JsonNode? source) : base(source) { }


        #endregion
        #region From Parent
        protected override string _TypeName => "Quantity";


        #endregion

        #region public Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }



        #endregion
    }
}
