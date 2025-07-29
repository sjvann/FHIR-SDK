using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR decimal primitive type.
/// A rational number with implicit precision.
/// </summary>
/// <remarks>
/// FHIR R5 decimal PrimitiveType
/// A rational number with implicit precision.
/// 
/// JSON Representation:
/// - Simple: "value" : 3.14159
/// - Full: "value" : 3.14159, "_value" : { "id" : "a1", "extension" : [...] }
/// </remarks>
public class FhirDecimal : UnifiedPrimitiveTypeBase<decimal>
{
    /// <summary>
    /// Gets or sets the decimal value.
    /// </summary>
    [JsonIgnore]
    public decimal? DecimalValue { get => Value; set => Value = value; }

    /// <summary>
    /// Initializes a new instance of the FhirDecimal class.
    /// </summary>
    public FhirDecimal() { }

    /// <summary>
    /// Initializes a new instance of the FhirDecimal class with the specified value.
    /// </summary>
    /// <param name="value">The decimal value.</param>
    public FhirDecimal(decimal? value) : base(value) { }

    /// <summary>
    /// Implicitly converts a decimal to a FhirDecimal.
    /// </summary>
    /// <param name="value">The decimal value to convert.</param>
    /// <returns>A FhirDecimal instance, or null if the value is null.</returns>
    public static implicit operator FhirDecimal?(decimal? value)
    {
        return CreateFromValue<FhirDecimal>(value);
    }

    /// <summary>
    /// Implicitly converts a FhirDecimal to a decimal.
    /// </summary>
    /// <param name="fhirDecimal">The FhirDecimal to convert.</param>
    /// <returns>The decimal value, or null if the FhirDecimal is null.</returns>
    public static implicit operator decimal?(FhirDecimal? fhirDecimal)
    {
        return GetValue<FhirDecimal>(fhirDecimal);
    }

    /// <summary>
    /// Parses a decimal value from string.
    /// </summary>
    /// <param name="value">The string to parse.</param>
    /// <returns>The parsed decimal value.</returns>
    protected override decimal? ParseValueFromString(string value)
    {
        if (decimal.TryParse(value, out var result))
        {
            return result;
        }
        return null;
    }

    /// <summary>
    /// Converts a decimal value to string.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>The string representation.</returns>
    protected override string? ValueToString(decimal? value)
    {
        return value?.ToString("G29");
    }

    /// <summary>
    /// Validates the decimal value according to FHIR specifications.
    /// </summary>
    /// <param name="value">The decimal value to validate.</param>
    /// <returns>True if the value is valid; otherwise, false.</returns>
    protected override bool ValidateValue(decimal value)
    {
        return true; // decimal 沒有額外驗證規則
    }
}
