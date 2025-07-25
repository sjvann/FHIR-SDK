using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// FHIR base64Binary primitive type.
/// A stream of bytes, base64 encoded.
/// </summary>
/// <remarks>
/// FHIR R4 base64Binary PrimitiveType
/// A stream of bytes, base64 encoded.
/// </remarks>
public class FhirBase64Binary : Element
{
    private string? _value;

    /// <summary>
    /// The actual base64Binary value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value
    {
        get => _value;
        set => _value = value;
    }

    /// <summary>
    /// Initializes a new instance of the FhirBase64Binary class.
    /// </summary>
    public FhirBase64Binary() { }

    /// <summary>
    /// Initializes a new instance of the FhirBase64Binary class with the specified value.
    /// </summary>
    /// <param name="value">The base64Binary value.</param>
    public FhirBase64Binary(string? value)
    {
        Value = value;
    }

    /// <summary>
    /// Initializes a new instance of the FhirBase64Binary class with byte array.
    /// </summary>
    /// <param name="bytes">The byte array to encode as base64.</param>
    public FhirBase64Binary(byte[]? bytes)
    {
        Value = bytes != null ? Convert.ToBase64String(bytes) : null;
    }

    /// <summary>
    /// Implicitly converts a string to a FhirBase64Binary.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirBase64Binary instance, or null if the value is null.</returns>
    public static implicit operator FhirBase64Binary?(string? value)
    {
        return value == null ? null : new FhirBase64Binary(value);
    }

    /// <summary>
    /// Implicitly converts a FhirBase64Binary to a string.
    /// </summary>
    /// <param name="fhirBase64Binary">The FhirBase64Binary to convert.</param>
    /// <returns>The string value, or null if the FhirBase64Binary is null.</returns>
    public static implicit operator string?(FhirBase64Binary? fhirBase64Binary)
    {
        return fhirBase64Binary?.Value;
    }

    /// <summary>
    /// Implicitly converts a byte array to a FhirBase64Binary.
    /// </summary>
    /// <param name="bytes">The byte array to convert.</param>
    /// <returns>A FhirBase64Binary instance, or null if the bytes are null.</returns>
    public static implicit operator FhirBase64Binary?(byte[]? bytes)
    {
        return bytes == null ? null : new FhirBase64Binary(bytes);
    }

    /// <summary>
    /// Converts the base64 string to a byte array.
    /// </summary>
    /// <returns>The decoded byte array, or null if the value is null or invalid.</returns>
    public byte[]? ToByteArray()
    {
        if (string.IsNullOrEmpty(Value))
            return null;

        try
        {
            return Convert.FromBase64String(Value);
        }
        catch
        {
            return null;
        }
    }

    /// <summary>
    /// Validates the FhirBase64Binary according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        if (!string.IsNullOrEmpty(Value))
        {
            if (!IsValidBase64(Value))
            {
                yield return new ValidationResult($"base64Binary value '{Value}' is not valid base64 encoded data");
            }
        }
    }

    /// <summary>
    /// Validates whether the specified string is valid base64 encoded data.
    /// </summary>
    /// <param name="value">The string to validate.</param>
    /// <returns>True if the string is valid base64; otherwise, false.</returns>
    private bool IsValidBase64(string value)
    {
        try
        {
            Convert.FromBase64String(value);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }

    /// <summary>
    /// Returns a string representation of the FhirBase64Binary.
    /// </summary>
    /// <returns>The base64Binary value.</returns>
    public override string? ToString() => Value;
}
