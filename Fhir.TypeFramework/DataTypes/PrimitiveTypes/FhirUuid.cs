using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR uuid primitive type.
/// A UUID, following RFC 4122.
/// </summary>
/// <remarks>
/// FHIR R5 uuid PrimitiveType
/// A UUID, following RFC 4122.
/// 
/// JSON Representation:
/// - Simple: "uuid" : "550e8400-e29b-41d4-a716-446655440000"
/// - Full: "uuid" : "550e8400-e29b-41d4-a716-446655440000", "_uuid" : { "id" : "a1", "extension" : [...] }
/// </remarks>
public class FhirUuid : UnifiedPrimitiveTypeBase<string>
{
    /// <summary>
    /// Gets or sets the UUID value.
    /// </summary>
    [JsonIgnore]
    public string? UuidValue { get => Value; set => Value = value; }

    /// <summary>
    /// Initializes a new instance of the FhirUuid class.
    /// </summary>
    public FhirUuid() { }

    /// <summary>
    /// Initializes a new instance of the FhirUuid class with the specified value.
    /// </summary>
    /// <param name="value">The UUID value.</param>
    public FhirUuid(string? value) : base(value) { }

    /// <summary>
    /// Implicitly converts a string to a FhirUuid.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirUuid instance, or null if the value is null.</returns>
    public static implicit operator FhirUuid?(string? value)
    {
        return CreateFromString<FhirUuid>(value);
    }

    /// <summary>
    /// Implicitly converts a FhirUuid to a string.
    /// </summary>
    /// <param name="fhirUuid">The FhirUuid to convert.</param>
    /// <returns>The string value, or null if the FhirUuid is null.</returns>
    public static implicit operator string?(FhirUuid? fhirUuid)
    {
        return GetStringValue<FhirUuid>(fhirUuid);
    }

    protected override string? ParseValueFromString(string value) => value;
    protected override string? ValueToString(string? value) => value;
    protected override bool ValidateValue(string value) => ValidationFramework.ValidateUuid(value);
}


