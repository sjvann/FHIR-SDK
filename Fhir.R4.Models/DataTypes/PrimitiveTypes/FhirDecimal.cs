using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// FHIR decimal primitive type.
/// Rational numbers that have a decimal representation.
/// </summary>
/// <remarks>
/// FHIR R4 decimal PrimitiveType
/// Rational numbers that have a decimal representation.
/// </remarks>
public class FhirDecimal : Element
{
    private decimal? _value;
    
    /// <summary>
    /// The actual decimal value.
    /// </summary>
    [JsonPropertyName("value")]
    public decimal? Value 
    { 
        get => _value;
        set => _value = value;
    }
    
    /// <summary>
    /// Initializes a new instance of the FhirDecimal class.
    /// </summary>
    public FhirDecimal() { }
    
    /// <summary>
    /// Initializes a new instance of the FhirDecimal class with the specified value.
    /// </summary>
    /// <param name="value">The decimal value.</param>
    public FhirDecimal(decimal? value)
    {
        Value = value;
    }
    
    /// <summary>
    /// Implicitly converts a decimal to a FhirDecimal.
    /// </summary>
    /// <param name="value">The decimal value to convert.</param>
    /// <returns>A FhirDecimal instance, or null if the value is null.</returns>
    public static implicit operator FhirDecimal?(decimal? value)
    {
        return value == null ? null : new FhirDecimal(value);
    }
    
    /// <summary>
    /// Implicitly converts a FhirDecimal to a decimal.
    /// </summary>
    /// <param name="fhirDecimal">The FhirDecimal to convert.</param>
    /// <returns>The decimal value, or null if the FhirDecimal is null.</returns>
    public static implicit operator decimal?(FhirDecimal? fhirDecimal)
    {
        return fhirDecimal?.Value;
    }
    
    /// <summary>
    /// Returns a string representation of the FhirDecimal.
    /// </summary>
    /// <returns>The string representation of the decimal value.</returns>
    public override string? ToString() => Value?.ToString();
}
