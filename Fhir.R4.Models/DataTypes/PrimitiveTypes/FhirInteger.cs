using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// FHIR integer primitive type.
/// A signed integer in the range −2,147,483,648..2,147,483,647 (32-bit).
/// </summary>
/// <remarks>
/// FHIR R4 integer PrimitiveType
/// A signed 32-bit integer.
/// </remarks>
public class FhirInteger : Element
{
    private int? _value;
    
    /// <summary>
    /// The actual integer value.
    /// </summary>
    [JsonPropertyName("value")]
    public int? Value 
    { 
        get => _value;
        set => _value = value;
    }
    
    /// <summary>
    /// Initializes a new instance of the FhirInteger class.
    /// </summary>
    public FhirInteger() { }
    
    /// <summary>
    /// Initializes a new instance of the FhirInteger class with the specified value.
    /// </summary>
    /// <param name="value">The integer value.</param>
    public FhirInteger(int? value)
    {
        Value = value;
    }
    
    /// <summary>
    /// Implicitly converts an integer to a FhirInteger.
    /// </summary>
    /// <param name="value">The integer value to convert.</param>
    /// <returns>A FhirInteger instance, or null if the value is null.</returns>
    public static implicit operator FhirInteger?(int? value)
    {
        return value == null ? null : new FhirInteger(value);
    }
    
    /// <summary>
    /// Implicitly converts a FhirInteger to an integer.
    /// </summary>
    /// <param name="fhirInteger">The FhirInteger to convert.</param>
    /// <returns>The integer value, or null if the FhirInteger is null.</returns>
    public static implicit operator int?(FhirInteger? fhirInteger)
    {
        return fhirInteger?.Value;
    }
    
    /// <summary>
    /// Returns a string representation of the FhirInteger.
    /// </summary>
    /// <returns>The string representation of the integer value.</returns>
    public override string? ToString() => Value?.ToString();
}
