using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class CodeableReference : ComplexType<CodeableReference>
    {

        #region Property
        [Element("concept", typeof(CodeableConcept), false, false, false, false)]
        public CodeableConcept? Concept { get; set; }
        [Element("reference", typeof(Reference), false, false, false, false)]
        public Reference? Reference { get; set; }

        #endregion
        #region Constructor
        public CodeableReference() { }
        public CodeableReference(string? value) : base(value) { }
        public CodeableReference(JsonNode? source) : base(source) { }


        #endregion
        #region From Parent
        protected override string _TypeName => "CodeableReference";

        #endregion

        #region public Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
