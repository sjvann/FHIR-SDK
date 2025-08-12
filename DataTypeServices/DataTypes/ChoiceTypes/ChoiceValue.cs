using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.ChoiceTypes
{
    public class ChoiceValue : ChoiceType
    {
        public ChoiceValue(string dataType, JsonValue? value) : base(dataType, value) { }
        public ChoiceValue(string prefix, JsonNode? value) : base(prefix, value, _supportType) { }
        public ChoiceValue(string prefix, IComplexType? value) : base(prefix, value) { }
        public ChoiceValue(string prefix, IPrimitiveType? value) : base(prefix, value) { }

        private static readonly List<string> _supportType = [
          "string", "code", "id", "uri", "dateTime", "base64Binary", "boolean", "canonical", "date", "decimal","instant", "integer", "markdown", "oid", "positiveInt", "time", "unsignedInt", "url", "uuid", "Address","Age", "Annotation", "Attachment", "CodeableConcept", "CodeableReference", "Coding", "ContactPoint", "Count", "Distance", "Duration", "HumanName", "Identifier", "Money", "Period", "Quantity", "Range", "Ratio", "RatioRange", "Reference", "SampledData", "Signature", "Timing", "ContactDetail", "DataRequirement", "Expression", "ParameterDefinition", "RelatedArtifact", "TriggerDefinition", "UsageContext", "Availability", "Dosage", "Meta","ExtendedContactDetail"
            ];
        public override string GetPrefixName(bool withCapital = true)
        {
            return withCapital ? "Value" : "value";
        }
        public override List<string> SetSupportDataType()
        {
            return _supportType;
        }
    }
}
