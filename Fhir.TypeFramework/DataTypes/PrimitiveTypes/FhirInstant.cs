using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR instant primitive type.
/// An instant in time - known at least to the second.
/// </summary>
/// <remarks>
/// FHIR R5 instant PrimitiveType
/// An instant in time - known at least to the second.
/// 
/// JSON Representation:
/// - Simple: "instant" : "2023-12-25T10:30:00Z"
/// - Full: "instant" : "2023-12-25T10:30:00Z", "_instant" : { "id" : "a1", "extension" : [...] }
/// </remarks>
public class FhirInstant : DateTimePrimitiveTypeBase<DateTime>
{
    /// <summary>
    /// Gets or sets the Instant value.
    /// </summary>
    [JsonIgnore]
    public DateTime? InstantValue { get => Value; set => Value = value; }

    /// <summary>
    /// Initializes a new instance of the FhirInstant class.
    /// </summary>
    public FhirInstant() { }

    /// <summary>
    /// Initializes a new instance of the FhirInstant class with the specified value.
    /// </summary>
    /// <param name="value">The Instant value.</param>
    public FhirInstant(DateTime? value) : base(value) { }

    /// <summary>
    /// Implicitly converts a DateTime to a FhirInstant.
    /// </summary>
    /// <param name="value">The DateTime value to convert.</param>
    /// <returns>A FhirInstant instance.</returns>
    public static implicit operator FhirInstant?(DateTime? value)
    {
        return CreateFromDateTime<FhirInstant>(value);
    }

    /// <summary>
    /// Implicitly converts a FhirInstant to a DateTime.
    /// </summary>
    /// <param name="fhirInstant">The FhirInstant to convert.</param>
    /// <returns>The DateTime value.</returns>
    public static implicit operator DateTime?(FhirInstant? fhirInstant)
    {
        return GetDateTimeValue<FhirInstant>(fhirInstant);
    }

    /// <summary>
    /// Parses a string value to a DateTime (instant).
    /// </summary>
    /// <param name="value">The string value to parse.</param>
    /// <returns>The parsed DateTime value, or null if parsing fails.</returns>
    protected override DateTime? ParseDateTimeValue(string value)
    {
        if (DateTime.TryParse(value, out var result))
            return result.ToUniversalTime();
        return null;
    }

    /// <summary>
    /// Validates the Instant value according to FHIR specifications.
    /// </summary>
    /// <param name="value">The Instant value to validate.</param>
    /// <returns>True if the value is valid; otherwise, false.</returns>
    protected override bool ValidateDateTimeValue(DateTime value)
    {
        // FHIR instant has no additional validation rules beyond being a valid DateTime
        return true;
    }
}
