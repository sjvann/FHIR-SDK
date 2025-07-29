using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Validation;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR oid primitive type.
/// An OID represented as a URI.
/// </summary>
/// <remarks>
/// FHIR R5 oid PrimitiveType
/// An OID represented as a URI.
/// </remarks>
public class FhirOid : UnifiedPrimitiveTypeBase<string>
{
    [JsonIgnore]
    public string? OidValue { get => Value; set => Value = value; }

    public FhirOid() { }
    public FhirOid(string? value) : base(value) { }

    public static implicit operator FhirOid?(string? value) => CreateFromString<FhirOid>(value);
    public static implicit operator string?(FhirOid? fhirOid) => GetStringValue<FhirOid>(fhirOid);

    protected override string? ParseValueFromString(string value) => value;
    protected override string? ValueToString(string? value) => value;
    protected override bool ValidateValue(string value) => ValidationFramework.ValidateOid(value);
}
