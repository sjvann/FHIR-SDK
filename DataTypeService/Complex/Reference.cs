using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;


namespace DataTypeService.Complex
{
    public class Reference : ComplexType<Reference>
    {

        #region Property
        [Element("reference", typeof(FhirString), true, false, false, false)]
        public FhirString? ReferenceName { get; set; }
        [Element("type",typeof(FhirUri), true, false, false, false)]
        public FhirUri? Type { get; set; }
        [Element("identifier", typeof(Identifier), false, false, false, false)]
        public Identifier? Identifier { get; set; }
        [Element("display", typeof(FhirString), true, false, false, false)]
        public FhirString? Display { get; set; }
        #endregion
        #region Constructor
        public Reference() { }
        public Reference(string? value) : base(value) { }
        public Reference(JsonNode? source) : base(source) { }
        #endregion
        #region From Parent
        protected override string _TypeName => "Reference";

        #endregion

        #region public Method

        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
