using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class CodeableConcept : ComplexType<CodeableConcept>
    {

        #region Property
        [Element("coding", typeof(Coding), false, true, false, false)]
        public List<Coding>? Coding { get; set; }
        [Element("text", typeof(FhirString), true, false, false, false)]
        public FhirString? Text { get; init; }

        #endregion
        #region Constructor
        public CodeableConcept() { }
        public CodeableConcept(string? value) : base(value) { }
        public CodeableConcept(JsonNode? source) : base(source) { }

        #endregion
        #region From Parent
        protected override string _TypeName => "CodeableConcept";
        #endregion

        #region public Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
