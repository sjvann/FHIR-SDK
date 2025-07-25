using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// FHIR date primitive type.
/// A date, or partial date (e.g. just year or year + month).
/// </summary>
/// <remarks>
/// FHIR R4 date PrimitiveType
/// There is no time zone. Dates SHALL be valid dates.
/// </remarks>
public class FhirDate : Element
{
    private string? _value;

    /// <summary>
    /// The actual date value in YYYY, YYYY-MM, or YYYY-MM-DD format.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value
    {
        get => _value;
        set => _value = value;
    }

    /// <summary>
    /// Initializes a new instance of the FhirDate class.
    /// </summary>
    public FhirDate() { }

    /// <summary>
    /// Initializes a new instance of the FhirDate class with the specified value.
    /// </summary>
    /// <param name="value">The date value in YYYY, YYYY-MM, or YYYY-MM-DD format.</param>
    public FhirDate(string? value)
    {
        Value = value;
    }

    /// <summary>
    /// Implicitly converts a string to a FhirDate.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirDate instance, or null if the value is null.</returns>
    public static implicit operator FhirDate?(string? value)
    {
        return value == null ? null : new FhirDate(value);
    }

    /// <summary>
    /// Implicitly converts a FhirDate to a string.
    /// </summary>
    /// <param name="fhirDate">The FhirDate to convert.</param>
    /// <returns>The string value, or null if the FhirDate is null.</returns>
    public static implicit operator string?(FhirDate? fhirDate)
    {
        return fhirDate?.Value;
    }

    /// <summary>
    /// Validates the FhirDate according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        if (!string.IsNullOrEmpty(Value) && !IsValidDate(Value))
        {
            yield return new ValidationResult($"Date value '{Value}' is not valid. Must be YYYY, YYYY-MM, or YYYY-MM-DD format");
        }
    }

    /// <summary>
    /// Validates the date format according to FHIR date specifications.
    /// Supports YYYY, YYYY-MM, and YYYY-MM-DD formats.
    /// </summary>
    /// <param name="value">The date string to validate.</param>
    /// <returns>True if the date format is valid; otherwise, false.</returns>
    private bool IsValidDate(string value)
    {
        // YYYY format
        if (value.Length == 4 && int.TryParse(value, out var year) && year >= 1 && year <= 9999)
            return true;

        // YYYY-MM format
        if (value.Length == 7 && value[4] == '-' &&
            int.TryParse(value.Substring(0, 4), out year) && year >= 1 && year <= 9999 &&
            int.TryParse(value.Substring(5, 2), out var month) && month >= 1 && month <= 12)
            return true;

        // YYYY-MM-DD format
        if (value.Length == 10 && DateTime.TryParseExact(value, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out _))
            return true;

        return false;
    }

    /// <summary>
    /// Returns a string representation of the FhirDate.
    /// </summary>
    /// <returns>The date value.</returns>
    public override string? ToString() => Value;
}
