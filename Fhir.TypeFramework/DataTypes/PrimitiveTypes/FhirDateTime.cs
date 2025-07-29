using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR dateTime primitive type.
/// A date, date-time or partial date (e.g. just year or year + month).
/// </summary>
/// <remarks>
/// FHIR R5 dateTime PrimitiveType
/// A date, date-time or partial date (e.g. just year or year + month).
/// 
/// JSON Representation:
/// - Simple: "dateTime" : "2013-06-08T10:57:34+01:00"
/// - Full: "dateTime" : "2013-06-08T10:57:34+01:00", "_dateTime" : { "id" : "a1", "extension" : [...] }
/// </remarks>
public class FhirDateTime : UnifiedPrimitiveTypeBase<DateTime>
{
    /// <summary>
    /// Gets or sets the DateTime value.
    /// </summary>
    [JsonIgnore]
    public DateTime? DateTimeValue { get => Value; set => Value = value; }

    /// <summary>
    /// Initializes a new instance of the FhirDateTime class.
    /// </summary>
    public FhirDateTime() { }

    /// <summary>
    /// Initializes a new instance of the FhirDateTime class with the specified value.
    /// </summary>
    /// <param name="value">The DateTime value.</param>
    public FhirDateTime(DateTime? value) : base(value) { }

    /// <summary>
    /// Implicitly converts a DateTime to a FhirDateTime.
    /// </summary>
    /// <param name="value">The DateTime value to convert.</param>
    /// <returns>A FhirDateTime instance, or null if the value is null.</returns>
    public static implicit operator FhirDateTime?(DateTime? value)
    {
        return CreateFromValue<FhirDateTime>(value);
    }

    /// <summary>
    /// Implicitly converts a FhirDateTime to a DateTime.
    /// </summary>
    /// <param name="fhirDateTime">The FhirDateTime to convert.</param>
    /// <returns>The DateTime value, or null if the FhirDateTime is null.</returns>
    public static implicit operator DateTime?(FhirDateTime? fhirDateTime)
    {
        return GetValue<FhirDateTime>(fhirDateTime);
    }

    /// <summary>
    /// Parses a DateTime value from string.
    /// </summary>
    /// <param name="value">The string to parse.</param>
    /// <returns>The parsed DateTime value.</returns>
    protected override DateTime? ParseValueFromString(string value)
    {
        if (string.IsNullOrEmpty(value)) return null;
        
        // 嘗試解析 ISO 8601 格式
        if (DateTime.TryParse(value, out var result))
        {
            return result;
        }
        
        return null;
    }

    /// <summary>
    /// Converts a DateTime value to string.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>The string representation.</returns>
    protected override string? ValueToString(DateTime? value)
    {
        return value?.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");
    }

    /// <summary>
    /// Validates the DateTime value according to FHIR specifications.
    /// </summary>
    /// <param name="value">The DateTime value to validate.</param>
    /// <returns>True if the value is valid; otherwise, false.</returns>
    protected override bool ValidateValue(DateTime value)
    {
        return true; // DateTime 沒有額外驗證規則
    }
}
