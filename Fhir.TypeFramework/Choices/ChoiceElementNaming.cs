namespace Fhir.TypeFramework.Choices;

/// <summary>將 ResourceCreator 產生的 choice 屬性名稱（如 <c>DeceasedBoolean</c>）對應至 FHIR 元素 stem（如 <c>deceased</c>）。</summary>
public static class ChoiceElementNaming
{
    public static readonly IReadOnlySet<string> TypeSuffixes = new HashSet<string>(StringComparer.Ordinal)
    {
        "Boolean", "Integer", "String", "Decimal", "DateTime", "Time", "Date", "Instant",
        "Uri", "Url", "Canonical", "Code", "Oid", "Uuid", "Id", "Markdown", "Base64Binary",
        "PositiveInt", "UnsignedInt", "Integer64", "Address", "Age", "Annotation", "Attachment",
        "CodeableConcept", "Coding", "ContactPoint", "Count", "Distance", "Duration", "HumanName",
        "Identifier", "Money", "Period", "Quantity", "Range", "Ratio", "Reference", "SampledData",
        "Signature", "Timing", "Meta", "Dosage", "RatioRange", "DataRequirement",
        "Expression", "ParameterDefinition", "RelatedArtifact", "TriggerDefinition", "UsageContext",
        "Availability", "ExtendedContactDetail", "ContactDetail", "Contributor", "DataType",
        "MonetaryComponent"
    };

    public static bool TryGetChoiceStem(string propertyName, out string stem)
    {
        foreach (var suffix in TypeSuffixes)
        {
            if (!propertyName.EndsWith(suffix, StringComparison.Ordinal) || propertyName.Length <= suffix.Length)
                continue;

            var nameStem = propertyName[..^suffix.Length];
            stem = nameStem.Length == 0
                ? nameStem
                : char.ToLowerInvariant(nameStem[0]) + nameStem[1..];
            return true;
        }

        stem = "";
        return false;
    }

    public static string ToPascalStem(string fhirElementName)
        => string.IsNullOrEmpty(fhirElementName)
            ? fhirElementName
            : char.ToUpperInvariant(fhirElementName[0]) + fhirElementName[1..];
}
