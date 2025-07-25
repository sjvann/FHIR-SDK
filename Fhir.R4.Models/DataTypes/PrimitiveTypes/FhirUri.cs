using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// FHIR uri primitive type.
/// String of characters used to identify a name or a resource.
/// </summary>
/// <remarks>
/// FHIR R4 uri PrimitiveType
/// URIs are case sensitive.
/// </remarks>
public class FhirUri : Element
{
    private string? _value;

    /// <summary>
    /// The actual URI value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value
    {
        get => _value;
        set => _value = value;
    }

    /// <summary>
    /// Initializes a new instance of the FhirUri class.
    /// </summary>
    public FhirUri() { }

    /// <summary>
    /// Initializes a new instance of the FhirUri class with the specified value.
    /// </summary>
    /// <param name="value">The URI value.</param>
    public FhirUri(string? value)
    {
        Value = value;
    }

    /// <summary>
    /// Implicitly converts a string to a FhirUri.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirUri instance, or null if the value is null.</returns>
    public static implicit operator FhirUri?(string? value)
    {
        return value == null ? null : new FhirUri(value);
    }

    /// <summary>
    /// Implicitly converts a FhirUri to a string.
    /// </summary>
    /// <param name="fhirUri">The FhirUri to convert.</param>
    /// <returns>The string value, or null if the FhirUri is null.</returns>
    public static implicit operator string?(FhirUri? fhirUri)
    {
        return fhirUri?.Value;
    }

    /// <summary>
    /// Validates the FhirUri according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        if (!string.IsNullOrEmpty(Value) && !Uri.IsWellFormedUriString(Value, UriKind.RelativeOrAbsolute))
        {
            yield return new ValidationResult($"URI value '{Value}' is not well-formed");
        }
    }

    /// <summary>
    /// Returns a string representation of the FhirUri.
    /// </summary>
    /// <returns>The URI value.</returns>
    public override string? ToString() => Value;
}
