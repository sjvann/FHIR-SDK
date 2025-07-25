using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// FHIR url primitive type.
/// A URI that is a Uniform Resource Locator (URL).
/// </summary>
/// <remarks>
/// FHIR R4 url PrimitiveType
/// A URI that is a Uniform Resource Locator (URL).
/// </remarks>
public class FhirUrl : Element
{
    private string? _value;

    /// <summary>
    /// The actual url value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value
    {
        get => _value;
        set => _value = value;
    }

    /// <summary>
    /// Initializes a new instance of the FhirUrl class.
    /// </summary>
    public FhirUrl() { }

    /// <summary>
    /// Initializes a new instance of the FhirUrl class with the specified value.
    /// </summary>
    /// <param name="value">The url value.</param>
    public FhirUrl(string? value)
    {
        Value = value;
    }

    /// <summary>
    /// Implicitly converts a string to a FhirUrl.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirUrl instance, or null if the value is null.</returns>
    public static implicit operator FhirUrl?(string? value)
    {
        return value == null ? null : new FhirUrl(value);
    }

    /// <summary>
    /// Implicitly converts a FhirUrl to a string.
    /// </summary>
    /// <param name="fhirUrl">The FhirUrl to convert.</param>
    /// <returns>The string value, or null if the FhirUrl is null.</returns>
    public static implicit operator string?(FhirUrl? fhirUrl)
    {
        return fhirUrl?.Value;
    }

    /// <summary>
    /// Validates the FhirUrl according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        if (!string.IsNullOrEmpty(Value))
        {
            // URL must be a valid absolute URI
            if (!Uri.IsWellFormedUriString(Value, UriKind.Absolute))
            {
                yield return new ValidationResult($"URL value '{Value}' is not a well-formed absolute URI");
            }
        }
    }

    /// <summary>
    /// Returns a string representation of the FhirUrl.
    /// </summary>
    /// <returns>The url value.</returns>
    public override string? ToString() => Value;
}
