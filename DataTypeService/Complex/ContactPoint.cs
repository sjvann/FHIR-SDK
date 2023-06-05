using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;


namespace DataTypeService.Complex
{
    public class ContactPoint : ComplexType<ContactPoint>
    {

        #region Property
        [Element("system", typeof(FhirCode), true, false, false, false)]
        public FhirCode? System { get; set; }
        [Element("value", typeof(FhirString), true, false, false, false)]
        public FhirString? Value { get; set; }
        [Element("use", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Use { get; set; }
        [Element("rank", typeof(FhirPositiveInt), true, false, false, false)]
        public FhirPositiveInt? Rank { get; set; }
        [Element("period", typeof(Period), false, false, false, false)]
        public Period? Period { get; set; }
        #endregion
        #region Constructor
        public ContactPoint() { }
        public ContactPoint(string? value) : base(value) { }
        public ContactPoint(JsonNode? source) : base(source) { }

        #endregion
        #region From Parent
        protected override string _TypeName => "ContactPoint";
        #endregion

        #region public Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion

    }
}
