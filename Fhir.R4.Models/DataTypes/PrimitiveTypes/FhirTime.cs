using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// FHIR time primitive type.
/// A time during the day, with no date specified.
/// </summary>
/// <remarks>
/// FHIR R4 time PrimitiveType
/// A time during the day, with no date specified.
/// </remarks>
public class FhirTime : Element
{
    private string? _value;

    /// <summary>
    /// The actual time value in HH:MM:SS or HH:MM:SS.fff format.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value
    {
        get => _value;
        set => _value = value;
    }

    /// <summary>
    /// Initializes a new instance of the FhirTime class.
    /// </summary>
    public FhirTime() { }

    /// <summary>
    /// Initializes a new instance of the FhirTime class with the specified value.
    /// </summary>
    /// <param name="value">The time value in HH:MM:SS or HH:MM:SS.fff format.</param>
    public FhirTime(string? value)
    {
        Value = value;
    }

    /// <summary>
    /// Initializes a new instance of the FhirTime class with a TimeSpan.
    /// </summary>
    /// <param name="timeSpan">The TimeSpan to convert to time format.</param>
    public FhirTime(TimeSpan? timeSpan)
    {
        Value = timeSpan?.ToString(@"hh\:mm\:ss");
    }

    /// <summary>
    /// Implicitly converts a string to a FhirTime.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirTime instance, or null if the value is null.</returns>
    public static implicit operator FhirTime?(string? value)
    {
        return value == null ? null : new FhirTime(value);
    }

    /// <summary>
    /// Implicitly converts a FhirTime to a string.
    /// </summary>
    /// <param name="fhirTime">The FhirTime to convert.</param>
    /// <returns>The string value, or null if the FhirTime is null.</returns>
    public static implicit operator string?(FhirTime? fhirTime)
    {
        return fhirTime?.Value;
    }

    /// <summary>
    /// Implicitly converts a TimeSpan to a FhirTime.
    /// </summary>
    /// <param name="timeSpan">The TimeSpan to convert.</param>
    /// <returns>A FhirTime instance, or null if the TimeSpan is null.</returns>
    public static implicit operator FhirTime?(TimeSpan? timeSpan)
    {
        return timeSpan == null ? null : new FhirTime(timeSpan);
    }

    /// <summary>
    /// Converts the time string to a TimeSpan.
    /// </summary>
    /// <returns>The TimeSpan representation, or null if the value is null or invalid.</returns>
    public TimeSpan? ToTimeSpan()
    {
        if (string.IsNullOrEmpty(Value))
            return null;

        if (TimeSpan.TryParse(Value, out var timeSpan))
            return timeSpan;

        return null;
    }

    /// <summary>
    /// Validates the FhirTime according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        if (!string.IsNullOrEmpty(Value) && !IsValidTime(Value))
        {
            yield return new ValidationResult($"Time value '{Value}' is not valid. Must be HH:MM:SS or HH:MM:SS.fff format");
        }
    }

    /// <summary>
    /// Validates the time format according to FHIR time specifications.
    /// </summary>
    /// <param name="value">The time string to validate.</param>
    /// <returns>True if the time format is valid; otherwise, false.</returns>
    private bool IsValidTime(string value)
    {
        // FHIR time format: HH:MM:SS or HH:MM:SS.fff
        var regex = new Regex(@"^([01]\d|2[0-3]):([0-5]\d):([0-5]\d)(\.\d{1,3})?$");
        return regex.IsMatch(value);
    }

    /// <summary>
    /// Returns a string representation of the FhirTime.
    /// </summary>
    /// <returns>The time value.</returns>
    public override string? ToString() => Value;
}
