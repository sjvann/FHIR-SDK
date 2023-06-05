using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;


namespace DataTypeService.Complex
{
    public class Coding : ComplexType<Coding>
    {

        #region Property
        [Element("system", typeof(FhirUri), true, false, false, false)]
        public FhirUri? System { get; set; }
        [Element("version", typeof(FhirString), true, false, false, false)]
        public FhirString? Version { get; set; }
        [Element("code",typeof(FhirCode), true, false, false, false)]
        public FhirCode? Code { get; set; }
        [Element("display", typeof(FhirString), true, false, false, false)]
        public FhirString? Display { get; set; }
        [Element("userSelected", typeof(FhirBoolean), true, false, false, false)]
        public FhirBoolean? UserSelected { get; set; }


        #endregion
        #region Constructor
        public Coding() { }
        public Coding(string? value) : base(value) { }
        public Coding(JsonNode? source) : base(source) { }


        #endregion
        #region From Parent
        protected override string _TypeName => "Coding";


        #endregion

        #region public Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
