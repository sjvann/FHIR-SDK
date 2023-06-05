
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using Core.Attribute;
using DataTypeService.Primitive;

namespace DataTypeService.Complex
{
    public class Address : ComplexType<Address>
    {
        #region Property
        [Element("use", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Use { get; set; }
        [Element("type", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Type { get; set; }
        [Element("text", typeof(FhirString), true, false, false, false)]
        public FhirString? Text { get; set; }
        [Element("line", typeof(FhirString), true, true, false, false)]
        public IEnumerable<FhirString>? Line { get; set; }
        [Element("city", typeof(FhirString), true, false, false, false)]
        public FhirString? City { get; set; }
        [Element("district", typeof(FhirString), true, false, false, false)]
        public FhirString? District { get; set; }
        [Element("state", typeof(FhirString), true, false, false, false)]
        public FhirString? State { get; set; }
        [Element("postalCode", typeof(FhirString), true, false, false, false)]
        public FhirString? PostalCode { get; set; }
        [Element("country", typeof(FhirString), true, false, false, false)]
        public FhirString? Country { get; set; }
        [Element("period", typeof(Period), false, false, false, false)]
        public Period? Period { get; set; }

        #endregion
        #region Constructor
        public Address() : base() { }
        public Address(string? value) : base(value) { }
        public Address(JsonNode? source) : base(source) { }

        #endregion
        #region From Parent
        protected override string _TypeName => "Address";

        #endregion

        #region public Method

        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
