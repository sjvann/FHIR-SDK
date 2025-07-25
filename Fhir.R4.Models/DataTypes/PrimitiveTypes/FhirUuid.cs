using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// FHIR uuid primitive type.
/// A UUID, represented as a URI.
/// </summary>
/// <remarks>
/// FHIR R4 uuid PrimitiveType
/// A UUID, represented as a URI.
/// </remarks>
public class FhirUuid : Element
{
    private string? _value;

    /// <summary>
    /// The actual uuid value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value
    {
        get => _value;
        set => _value = value;
    }

    /// <summary>
    /// Initializes a new instance of the FhirUuid class.
    /// </summary>
    public FhirUuid() { }

    /// <summary>
    /// Initializes a new instance of the FhirUuid class with the specified value.
    /// </summary>
    /// <param name="value">The uuid value.</param>
    public FhirUuid(string? value)
    {
        Value = value;
    }

    /// <summary>
    /// Initializes a new instance of the FhirUuid class with a Guid.
    /// </summary>
    /// <param name="guid">The Guid to convert to uuid format.</param>
    public FhirUuid(Guid? guid)
    {
        Value = guid != null ? $"urn:uuid:{guid}" : null;
    }

    /// <summary>
    /// Implicitly converts a string to a FhirUuid.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirUuid instance, or null if the value is null.</returns>
    public static implicit operator FhirUuid?(string? value)
    {
        return value == null ? null : new FhirUuid(value);
    }

    /// <summary>
    /// Implicitly converts a FhirUuid to a string.
    /// </summary>
    /// <param name="fhirUuid">The FhirUuid to convert.</param>
    /// <returns>The string value, or null if the FhirUuid is null.</returns>
    public static implicit operator string?(FhirUuid? fhirUuid)
    {
        return fhirUuid?.Value;
    }

    /// <summary>
    /// Implicitly converts a Guid to a FhirUuid.
    /// </summary>
    /// <param name="guid">The Guid to convert.</param>
    /// <returns>A FhirUuid instance, or null if the Guid is null.</returns>
    public static implicit operator FhirUuid?(Guid? guid)
    {
        return guid == null ? null : new FhirUuid(guid);
    }

    /// <summary>
    /// Converts the uuid string to a Guid.
    /// </summary>
    /// <returns>The Guid representation, or null if the value is null or invalid.</returns>
    public Guid? ToGuid()
    {
        if (string.IsNullOrEmpty(Value))
            return null;

        if (Value.StartsWith("urn:uuid:"))
        {
            var guidPart = Value.Substring(9); // Remove "urn:uuid:" prefix
            if (Guid.TryParse(guidPart, out var guid))
                return guid;
        }

        return null;
    }

    /// <summary>
    /// Validates the FhirUuid according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        if (!string.IsNullOrEmpty(Value))
        {
            // UUID must start with "urn:uuid:" and contain a valid GUID
            if (!Value.StartsWith("urn:uuid:"))
            {
                yield return new ValidationResult($"UUID value '{Value}' must start with 'urn:uuid:'");
            }
            else
            {
                var guidPart = Value.Substring(9); // Remove "urn:uuid:" prefix
                if (!Guid.TryParse(guidPart, out _))
                {
                    yield return new ValidationResult($"UUID value '{Value}' does not contain a valid GUID");
                }
            }
        }
    }

    /// <summary>
    /// Returns a string representation of the FhirUuid.
    /// </summary>
    /// <returns>The uuid value.</returns>
    public override string? ToString() => Value;
}
