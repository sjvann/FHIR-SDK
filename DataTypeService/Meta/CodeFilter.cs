using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Special
{
    public class CodeFilter : ComplexType<CodeFilter>
    {

        #region Property
        [Element("path", typeof(FhirString), true, false, false, false)]
        public FhirString? Path { get; set;}
        [Element("searchParam", typeof(FhirString), true, false, false, false)]
        public FhirString? SearchParam { get; set;}
        [Element("valueSet", typeof(FhirCanonical), true, false, false, false)]
        public FhirCanonical? ValueSet { get; set;}
        [Element("code", typeof(Coding), false, true, false, false)]
        public IEnumerable<Coding>? Code { get; set;}
        #endregion
        #region Constructor
        public CodeFilter() { }
        public CodeFilter(string? value) : base(value) { }
        public CodeFilter(JsonNode? source) : base(source) { }

        #endregion
        #region From Parent
        protected override string _TypeName => "CodeFilter";
        #endregion

        #region Public Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
