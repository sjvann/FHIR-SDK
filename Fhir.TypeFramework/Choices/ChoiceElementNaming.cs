namespace Fhir.TypeFramework.Choices;

/// <summary>將 ResourceCreator 產生的 choice 屬性名稱（如 <c>DeceasedBoolean</c>、<c>MedicationCodeableconcept</c>）對應至 FHIR 元素 stem 與線上 JSON 名。</summary>
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

    private static readonly string[] SuffixesLongestFirst =
        TypeSuffixes.OrderByDescending(s => s.Length).ToArray();

    public static bool TryGetChoiceStem(string propertyName, out string stem)
        => TryGetChoiceStem(propertyName, out stem, out _);

    /// <summary>
    /// 辨識 choice 變體。後綴比對不分大小寫，因此產生器把 <c>CodeableConcept</c> 寫成 <c>Codeableconcept</c> 時仍能對上。
    /// 最長後綴優先，避免 <c>CodeableConcept</c> 被 <c>Code</c> 吃掉。
    /// </summary>
    public static bool TryGetChoiceStem(string propertyName, out string stem, out string typeSuffix)
    {
        stem = "";
        typeSuffix = "";
        if (string.IsNullOrEmpty(propertyName))
            return false;

        foreach (var suffix in SuffixesLongestFirst)
        {
            if (propertyName.Length <= suffix.Length)
                continue;
            if (!propertyName.EndsWith(suffix, StringComparison.OrdinalIgnoreCase))
                continue;

            var nameStem = propertyName[..^suffix.Length];
            stem = nameStem.Length == 0
                ? nameStem
                : char.ToLowerInvariant(nameStem[0]) + nameStem[1..];
            typeSuffix = suffix;
            return true;
        }

        return false;
    }

    /// <summary>FHIR JSON 選擇型欄位名，例如 <c>medicationCodeableConcept</c>、<c>effectiveDateTime</c>。</summary>
    public static string ToFhirJsonName(string clrOrJsonName)
        => TryGetChoiceStem(clrOrJsonName, out var stem, out var suffix)
            ? stem + suffix
            : clrOrJsonName;

    /// <summary>FHIR 型別在 JSON 中的 camelCase 尾碼（如 <c>codeableConcept</c>、<c>dateTime</c>）。</summary>
    public static string ToJsonTypeSuffix(string typeSuffix)
        => string.IsNullOrEmpty(typeSuffix)
            ? typeSuffix
            : char.ToLowerInvariant(typeSuffix[0]) + typeSuffix[1..];

    public static bool IsChoiceVariantJsonName(string jsonName, string stem)
    {
        if (string.IsNullOrEmpty(jsonName) || string.IsNullOrEmpty(stem))
            return false;
        if (!jsonName.StartsWith(stem, StringComparison.OrdinalIgnoreCase))
            return false;
        if (jsonName.Length == stem.Length)
            return true;
        var rest = jsonName[stem.Length..];
        return TypeSuffixes.Contains(rest) ||
               TypeSuffixes.Any(s => string.Equals(s, rest, StringComparison.OrdinalIgnoreCase));
    }

    public static string ToPascalStem(string fhirElementName)
        => string.IsNullOrEmpty(fhirElementName)
            ? fhirElementName
            : char.ToUpperInvariant(fhirElementName[0]) + fhirElementName[1..];
}
