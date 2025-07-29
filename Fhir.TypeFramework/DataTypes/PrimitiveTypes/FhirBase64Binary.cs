using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Validation;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR base64Binary primitive type.
/// A stream of bytes, base64 encoded.
/// </summary>
/// <remarks>
/// FHIR R5 base64Binary PrimitiveType
/// A stream of bytes, base64 encoded.
/// </remarks>
public class FhirBase64Binary : UnifiedPrimitiveTypeBase<string>
{
    [JsonIgnore]
    public string? Base64BinaryValue { get => Value; set => Value = value; }

    public FhirBase64Binary() { }
    public FhirBase64Binary(string? value) : base(value) { }

    public static implicit operator FhirBase64Binary?(string? value) => CreateFromString<FhirBase64Binary>(value);
    public static implicit operator string?(FhirBase64Binary? fhirBase64Binary) => GetStringValue<FhirBase64Binary>(fhirBase64Binary);

    protected override string? ParseValueFromString(string value) => value;
    protected override string? ValueToString(string? value) => value;
    protected override bool ValidateValue(string value) => ValidationFramework.ValidateBase64Binary(value);
}

