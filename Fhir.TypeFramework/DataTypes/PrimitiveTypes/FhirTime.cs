using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR time primitive type.
/// A time during the day, with no date specified.
/// </summary>
/// <remarks>
/// FHIR R5 time PrimitiveType
/// A time during the day, with no date specified.
/// 
/// JSON Representation:
/// - Simple: "time" : "10:30:00"
/// - Full: "time" : "10:30:00", "_time" : { "id" : "a1", "extension" : [...] }
/// </remarks>
public class FhirTime : DateTimePrimitiveTypeBase<TimeSpan>
{
    /// <summary>
    /// Gets or sets the Time value.
    /// </summary>
    [JsonIgnore]
    public TimeSpan? TimeValue { get => Value; set => Value = value; }

    /// <summary>
    /// Initializes a new instance of the FhirTime class.
    /// </summary>
    public FhirTime() { }

    /// <summary>
    /// Initializes a new instance of the FhirTime class with the specified value.
    /// </summary>
    /// <param name="value">The Time value.</param>
    public FhirTime(TimeSpan? value) : base(value) { }

    /// <summary>
    /// Implicitly converts a TimeSpan to a FhirTime.
    /// </summary>
    /// <param name="value">The TimeSpan value to convert.</param>
    /// <returns>A FhirTime instance.</returns>
    public static implicit operator FhirTime?(TimeSpan? value)
    {
        return CreateFromDateTime<FhirTime>(value);
    }

    /// <summary>
    /// Implicitly converts a FhirTime to a TimeSpan.
    /// </summary>
    /// <param name="fhirTime">The FhirTime to convert.</param>
    /// <returns>The TimeSpan value.</returns>
    public static implicit operator TimeSpan?(FhirTime? fhirTime)
    {
        return GetDateTimeValue<FhirTime>(fhirTime);
    }

    /// <summary>
    /// Parses a string value to a TimeSpan.
    /// </summary>
    /// <param name="value">The string value to parse.</param>
    /// <returns>The parsed TimeSpan value, or null if parsing fails.</returns>
    protected override TimeSpan? ParseDateTimeValue(string value)
    {
        if (TimeSpan.TryParse(value, out var result))
            return result;
        return null;
    }

    /// <summary>
    /// Validates the Time value according to FHIR specifications.
    /// </summary>
    /// <param name="value">The Time value to validate.</param>
    /// <returns>True if the value is valid; otherwise, false.</returns>
    protected override bool ValidateDateTimeValue(TimeSpan value)
    {
        // FHIR time has no additional validation rules beyond being a valid TimeSpan
        return true;
    }
}
