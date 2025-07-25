using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// FHIR boolean primitive type.
/// Value of "true" or "false".
/// </summary>
/// <remarks>
/// FHIR R4 boolean PrimitiveType
/// Value of "true" or "false".
/// </remarks>
public class FhirBoolean : Element
{
    private bool? _value;
    
    /// <summary>
    /// The actual boolean value.
    /// </summary>
    [JsonPropertyName("value")]
    public bool? Value 
    { 
        get => _value;
        set => _value = value;
    }
    
    /// <summary>
    /// Initializes a new instance of the FhirBoolean class.
    /// </summary>
    public FhirBoolean() { }
    
    /// <summary>
    /// Initializes a new instance of the FhirBoolean class with the specified value.
    /// </summary>
    /// <param name="value">The boolean value.</param>
    public FhirBoolean(bool? value)
    {
        Value = value;
    }
    
    /// <summary>
    /// Implicitly converts a boolean to a FhirBoolean.
    /// </summary>
    /// <param name="value">The boolean value to convert.</param>
    /// <returns>A FhirBoolean instance, or null if the value is null.</returns>
    public static implicit operator FhirBoolean?(bool? value)
    {
        return value == null ? null : new FhirBoolean(value);
    }
    
    /// <summary>
    /// Implicitly converts a FhirBoolean to a boolean.
    /// </summary>
    /// <param name="fhirBoolean">The FhirBoolean to convert.</param>
    /// <returns>The boolean value, or null if the FhirBoolean is null.</returns>
    public static implicit operator bool?(FhirBoolean? fhirBoolean)
    {
        return fhirBoolean?.Value;
    }
    
    /// <summary>
    /// Returns a string representation of the FhirBoolean.
    /// </summary>
    /// <returns>The string representation of the boolean value.</returns>
    public override string? ToString() => Value?.ToString();
}
