using Core.Attribute;

using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;


namespace DataTypeService.Complex
{
    public class Signature : ComplexType<Signature>
    {
        #region Property
        [Element("type", typeof(Coding), false, true, false, false)]
        public IEnumerable<Coding>? Type { get; set; }
        [Element("when", typeof(FhirInstant), true, false, false, false)]
        public FhirInstant? When { get; set; }
        [Element("who", typeof(Reference), false, false, false, false)]
        public Reference? Who { get; set; }
        [Element("onBehalfOf", typeof(Reference), false, false, false, false)]
        public Reference? OnBehalfOf { get; set; }
        [Element("targetFormat", typeof(FhirCode), true, false, false, false)]
        public FhirCode? TargetFormat { get; set; }
        [Element("sigFormat", typeof(FhirCode), true, false, false, false)]
        public FhirCode? SigFormat { get; set; }
        [Element("data", typeof(FhirBase64Binary), true, false, false, false)]
        public FhirBase64Binary? Data { get; set; }

        #endregion
        #region Constructor
        public Signature() { }

        public Signature(string? value) : base(value) { }
        public Signature(JsonNode? source) : base(source) { }


        #endregion
        #region From Parent
        protected override string _TypeName => "Signature";

        #endregion

        #region public Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
