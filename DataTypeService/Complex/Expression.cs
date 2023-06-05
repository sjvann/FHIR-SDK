
using Core.Attribute;
using DataTypeService.BaseTypes;

using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class Expression : ComplexType<Expression>
    {

        #region Property
        [Element("description", typeof(FhirString), true, false, false, false)]
        public FhirString? Description { get; set; }
        [Element("name", typeof(FhirId), true, false, false, false)]
        public FhirId? Name { get; set; }
        [Element("language", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Language { get; set; }
        [Element("expressionValue", typeof(FhirString), true, false, false, false)]
        public FhirString? ExpressionValue { get; set; }
        [Element("reference", typeof(FhirUri), true, false, false, false)]
        public FhirUri? Reference { get; set; }
        #endregion
        #region Constructor
        public Expression() { }
        public Expression(string? value) : base(value) { }
        public Expression(JsonNode? source) : base(source) { }
        #endregion
        #region From Parent
        protected override string _TypeName => "Expression";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
