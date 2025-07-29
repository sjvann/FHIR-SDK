using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR date primitive type.
/// A date or partial date (e.g. just year or year + month).
/// </summary>
/// <remarks>
/// FHIR R5 date PrimitiveType
/// A date or partial date (e.g. just year or year + month).
/// 
/// JSON Representation:
/// - Simple: "date" : "2023-12-25"
/// - Full: "date" : "2023-12-25", "_date" : { "id" : "a1", "extension" : [...] }
/// </remarks>
public class FhirDate : DateTimePrimitiveTypeBase<DateTime>
{
    /// <summary>
    /// Gets or sets the Date value.
    /// </summary>
    [JsonIgnore]
    public DateTime? DateValue { get => Value; set => Value = value; }

    /// <summary>
    /// Initializes a new instance of the FhirDate class.
    /// </summary>
    public FhirDate() { }

    /// <summary>
    /// Initializes a new instance of the FhirDate class with the specified value.
    /// </summary>
    /// <param name="value">The Date value.</param>
    public FhirDate(DateTime? value) : base(value) { }

    /// <summary>
    /// Implicitly converts a DateTime to a FhirDate.
    /// </summary>
    /// <param name="value">The DateTime value to convert.</param>
    /// <returns>A FhirDate instance.</returns>
    public static implicit operator FhirDate?(DateTime? value)
    {
        return CreateFromDateTime<FhirDate>(value);
    }

    /// <summary>
    /// Implicitly converts a FhirDate to a DateTime.
    /// </summary>
    /// <param name="fhirDate">The FhirDate to convert.</param>
    /// <returns>The DateTime value.</returns>
    public static implicit operator DateTime?(FhirDate? fhirDate)
    {
        return GetDateTimeValue<FhirDate>(fhirDate);
    }

    /// <summary>
    /// Parses a string value to a DateTime (date only).
    /// </summary>
    /// <param name="value">The string value to parse.</param>
    /// <returns>The parsed DateTime value, or null if parsing fails.</returns>
    protected override DateTime? ParseDateTimeValue(string value)
    {
        if (DateTime.TryParse(value, out var result))
            return result.Date;
        return null;
    }

    /// <summary>
    /// Validates the Date value according to FHIR specifications.
    /// </summary>
    /// <param name="value">The Date value to validate.</param>
    /// <returns>True if the value is valid; otherwise, false.</returns>
    protected override bool ValidateDateTimeValue(DateTime value)
    {
        // FHIR date has no additional validation rules beyond being a valid DateTime
        return true;
    }
}
