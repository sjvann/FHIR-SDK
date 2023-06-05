using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class HumanName : ComplexType<HumanName>
    {

        #region Property        
        [Element("use", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Use { get; set; }
        [Element("text", typeof(FhirString), true, false, false, false)]
        public FhirString? Text { get; set; }
        [Element("family", typeof(FhirString), true, false, false, false)]
        public FhirString? Family { get; set; }
        [Element("given", typeof(FhirString), true, true, false, false)]
        public List<FhirString>? Given { get; set; }
        [Element("prefix", typeof(FhirString), true, true, false, false)]
        public List<FhirString>? Prefix { get; set; }
        [Element("suffix", typeof(FhirString), true, true, false, false)]
        public List<FhirString>? Suffix { get; set; }
        [Element("period", typeof(Period), false, false, false, false)]
        public Period? Period { get; set; }
        #endregion
        #region Constructor
        public HumanName() { }

        public HumanName(string? value) : base(value) { }
        public HumanName(JsonNode? source) : base(source) { }


        #endregion
        #region From Parent
        protected override string _TypeName => "HumanName";

        #endregion

        #region public Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }


        #endregion
    }
}
