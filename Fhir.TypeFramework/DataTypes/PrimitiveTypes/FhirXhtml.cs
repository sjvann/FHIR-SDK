using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Validation;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR xhtml primitive type.
/// XHTML content, restricted to only the body, div, span, br, p, and a elements.
/// </summary>
/// <remarks>
/// FHIR R5 xhtml PrimitiveType
/// XHTML content, restricted to only the body, div, span, br, p, and a elements.
/// </remarks>
public class FhirXhtml : UnifiedPrimitiveTypeBase<string>
{
    [JsonIgnore]
    public string? XhtmlValue { get => Value; set => Value = value; }

    public FhirXhtml() { }
    public FhirXhtml(string? value) : base(value) { }

    public static implicit operator FhirXhtml?(string? value) => CreateFromString<FhirXhtml>(value);
    public static implicit operator string?(FhirXhtml? fhirXhtml) => GetStringValue<FhirXhtml>(fhirXhtml);

    protected override string? ParseValueFromString(string value) => value;
    protected override string? ValueToString(string? value) => value;
    protected override bool ValidateValue(string value) => ValidationFramework.ValidateStringByteSize(value, 1024 * 1024);
}
