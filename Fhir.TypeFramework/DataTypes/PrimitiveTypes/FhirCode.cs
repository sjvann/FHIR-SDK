using Fhir.TypeFramework.Bases;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR code primitive type.
/// A coded value from a code system.
/// </summary>
/// <remarks>
/// FHIR R5 code PrimitiveType
/// A coded value from a code system.
/// </remarks>
public class FhirCode : UnifiedPrimitiveTypeBase<string>
{
    [JsonIgnore]
    public string? CodeValue { get => Value; set => Value = value; }

    public FhirCode() { }
    public FhirCode(string? value) : base(value) { }

    public static implicit operator FhirCode?(string? value) => CreateFromString<FhirCode>(value);
    public static implicit operator string?(FhirCode? fhirCode) => GetStringValue<FhirCode>(fhirCode);

    protected override string? ParseValueFromString(string value) => value;
    protected override string? ValueToString(string? value) => value;
    protected override bool ValidateValue(string value) => true;
}
