using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// FHIR dateTime primitive type.
/// A date, date-time or partial date (e.g. just year or year + month).
/// </summary>
/// <remarks>
/// FHIR R4 dateTime PrimitiveType
/// If hours and minutes are specified, a time zone SHALL be populated.
/// </remarks>
public class FhirDateTime : Element
{
    private string? _value;

    /// <summary>
    /// The actual dateTime value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value
    {
        get => _value;
        set => _value = value;
    }

    /// <summary>
    /// Initializes a new instance of the FhirDateTime class.
    /// </summary>
    public FhirDateTime() { }

    /// <summary>
    /// Initializes a new instance of the FhirDateTime class with the specified value.
    /// </summary>
    /// <param name="value">The dateTime value.</param>
    public FhirDateTime(string? value)
    {
        Value = value;
    }

    /// <summary>
    /// Implicitly converts a string to a FhirDateTime.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirDateTime instance, or null if the value is null.</returns>
    public static implicit operator FhirDateTime?(string? value)
    {
        return value == null ? null : new FhirDateTime(value);
    }

    /// <summary>
    /// Implicitly converts a FhirDateTime to a string.
    /// </summary>
    /// <param name="fhirDateTime">The FhirDateTime to convert.</param>
    /// <returns>The string value, or null if the FhirDateTime is null.</returns>
    public static implicit operator string?(FhirDateTime? fhirDateTime)
    {
        return fhirDateTime?.Value;
    }

    /// <summary>
    /// Returns a string representation of the FhirDateTime.
    /// </summary>
    /// <returns>The dateTime value.</returns>
    public override string? ToString() => Value;
}
