using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// FHIR instant primitive type.
/// An instant in time - known at least to the second.
/// </summary>
/// <remarks>
/// FHIR R4 instant PrimitiveType
/// An instant in time - known at least to the second.
/// </remarks>
public class FhirInstant : Element
{
    private string? _value;
    
    /// <summary>
    /// The actual instant value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value 
    { 
        get => _value;
        set => _value = value;
    }
    
    /// <summary>
    /// Initializes a new instance of the FhirInstant class.
    /// </summary>
    public FhirInstant() { }
    
    /// <summary>
    /// Initializes a new instance of the FhirInstant class with the specified value.
    /// </summary>
    /// <param name="value">The instant value.</param>
    public FhirInstant(string? value)
    {
        Value = value;
    }
    
    /// <summary>
    /// Implicitly converts a string to a FhirInstant.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirInstant instance, or null if the value is null.</returns>
    public static implicit operator FhirInstant?(string? value)
    {
        return value == null ? null : new FhirInstant(value);
    }
    
    /// <summary>
    /// Implicitly converts a FhirInstant to a string.
    /// </summary>
    /// <param name="fhirInstant">The FhirInstant to convert.</param>
    /// <returns>The string value, or null if the FhirInstant is null.</returns>
    public static implicit operator string?(FhirInstant? fhirInstant)
    {
        return fhirInstant?.Value;
    }
    
    /// <summary>
    /// Returns a string representation of the FhirInstant.
    /// </summary>
    /// <returns>The instant value.</returns>
    public override string? ToString() => Value;
}
