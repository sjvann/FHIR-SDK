
using Core.Extension;
using DataTypeService.BaseTypes;

using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.MetaType
{
    public class Expression : ComplexType
    {

        #region Property
        public FhirString? Description { get; set; }
        public FhirId? Name { get; set; }
        public FhirCode? Language { get; set; }
        public FhirString? ExpressionValue { get; set; }
        public FhirUri? Reference { get; set; }
        #endregion
        #region Constructor
        public Expression() { }
        public Expression(string? value) : this(value.Parse()) { }
        public Expression(JsonNode? source)
        {
            _JsonNode = source;
            if (source != null)
            {
                var values = source.AsObject().GetEnumerator();
                while (values.MoveNext())
                {
                    var ck = values.Current.Key;
                    var cv = values.Current.Value;
                    switch (ck)
                    {
                        case "description": Description = new(cv); break;
                        case "name": Name = new(cv); break;
                        case "language": Language = new(cv); break;
                        case "expression": ExpressionValue = new(cv); break;
                        case "reference": Reference = new(cv); break;
                        case "_description":
                            if (Description is FhirString _description) SetupExtension(cv, ref _description);
                            break;
                        case "_name":
                            if (Name is FhirId _name) SetupExtension(cv, ref _name);
                            break;
                        case "_language":
                            if (Language is FhirCode _language) SetupExtension(cv, ref _language);
                            break;
                        case "_expression":
                            if (ExpressionValue is FhirString _expression) SetupExtension(cv, ref _expression);
                            break;
                        case "_reference":
                            if (Reference is FhirUri _reference) SetupExtension(cv, ref _reference);
                            break;
                    }
                }
            }

        }

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
