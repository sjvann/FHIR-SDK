using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// FHIR string primitive type.
/// A sequence of Unicode characters.
/// </summary>
/// <remarks>
/// FHIR R4 string PrimitiveType
/// Note that strings SHALL NOT exceed 1MB in size.
/// </remarks>
public class FhirString : Element
{
    private string? _value;
    
    /// <summary>
    /// The actual string value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value 
    { 
        get => _value;
        set => _value = value;
    }
    
    /// <summary>
    /// Initializes a new instance of the FhirString class.
    /// </summary>
    public FhirString() { }
    
    /// <summary>
    /// Initializes a new instance of the FhirString class with the specified value.
    /// </summary>
    /// <param name="value">The string value.</param>
    public FhirString(string? value)
    {
        Value = value;
    }
    
    /// <summary>
    /// Implicitly converts a string to a FhirString.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirString instance, or null if the value is null.</returns>
    public static implicit operator FhirString?(string? value)
    {
        return value == null ? null : new FhirString(value);
    }
    
    /// <summary>
    /// Implicitly converts a FhirString to a string.
    /// </summary>
    /// <param name="fhirString">The FhirString to convert.</param>
    /// <returns>The string value, or null if the FhirString is null.</returns>
    public static implicit operator string?(FhirString? fhirString)
    {
        return fhirString?.Value;
    }
    
    /// <summary>
    /// Validates the FhirString according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;
            
        // FHIR string cannot exceed 1MB
        if (Value != null && System.Text.Encoding.UTF8.GetByteCount(Value) > 1024 * 1024)
        {
            yield return new ValidationResult("String value cannot exceed 1MB in size");
        }
    }
    
    /// <summary>
    /// Returns a string representation of the FhirString.
    /// </summary>
    /// <returns>The string value.</returns>
    public override string? ToString() => Value;
}
