using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.ChoiceTypes
{
    public class AnnotationChoiceAuthor : ChoiceType
    {
        private static readonly List<string> _supportType = [
            "String",
            "Reference"
        ];

        public AnnotationChoiceAuthor(JsonObject value) : base("author", value, _supportType)
        {
        }
        public AnnotationChoiceAuthor(IComplexType? value) : base("author", value)
        {
        }
        public AnnotationChoiceAuthor(IPrimitiveType? value) : base("author", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "Author" : "author";

        public override List<string> SetSupportDataType()
        {
            return _supportType;
        }
    }
}
