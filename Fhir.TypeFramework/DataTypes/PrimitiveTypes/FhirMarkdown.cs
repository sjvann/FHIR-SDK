using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Validation;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR markdown primitive type.
/// A string that may contain markdown syntax for optional processing by a markdown presentation engine.
/// </summary>
/// <remarks>
/// FHIR R5 markdown PrimitiveType
/// A string that may contain markdown syntax for optional processing by a markdown presentation engine.
/// </remarks>
public class FhirMarkdown : UnifiedPrimitiveTypeBase<string>
{
    [JsonIgnore]
    public string? MarkdownValue { get => Value; set => Value = value; }

    public FhirMarkdown() { }
    public FhirMarkdown(string? value) : base(value) { }

    public static implicit operator FhirMarkdown?(string? value) => CreateFromString<FhirMarkdown>(value);
    public static implicit operator string?(FhirMarkdown? fhirMarkdown) => GetStringValue<FhirMarkdown>(fhirMarkdown);

    protected override string? ParseValueFromString(string value) => value;
    protected override string? ValueToString(string? value) => value;
    protected override bool ValidateValue(string value) => ValidationFramework.ValidateStringByteSize(value, 1024 * 1024);
}
