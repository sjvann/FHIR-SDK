using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// A set of ordered Quantities defined by a low and high limit.
/// </summary>
/// <remarks>
/// FHIR R4 Range DataType
/// A set of ordered Quantities defined by a low and high limit.
/// </remarks>
public class Range : ComplexType<Range>
{
    /// <summary>
    /// The low limit. The boundary is inclusive.
    /// FHIR Path: Range.low
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("low")]
    public SimpleQuantity? Low { get; set; }

    /// <summary>
    /// The high limit. The boundary is inclusive.
    /// FHIR Path: Range.high
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("high")]
    public SimpleQuantity? High { get; set; }

    /// <summary>
    /// Initializes a new instance of the Range class.
    /// </summary>
    public Range() { }

    /// <summary>
    /// Initializes a new instance of the Range class with low and high values.
    /// </summary>
    /// <param name="low">The low limit.</param>
    /// <param name="high">The high limit.</param>
    public Range(SimpleQuantity? low, SimpleQuantity? high)
    {
        Low = low;
        High = high;
    }

    /// <summary>
    /// Initializes a new instance of the Range class with decimal values and unit.
    /// </summary>
    /// <param name="lowValue">The low value.</param>
    /// <param name="highValue">The high value.</param>
    /// <param name="unit">The unit for both values.</param>
    public Range(decimal? lowValue, decimal? highValue, string unit)
    {
        Low = lowValue != null ? new SimpleQuantity(lowValue, unit) : null;
        High = highValue != null ? new SimpleQuantity(highValue, unit) : null;
    }

    /// <summary>
    /// Creates a Range with only a low limit (at least).
    /// </summary>
    /// <param name="low">The low limit.</param>
    /// <returns>A new Range instance.</returns>
    public static Range AtLeast(SimpleQuantity low)
    {
        return new Range(low, null);
    }

    /// <summary>
    /// Creates a Range with only a high limit (at most).
    /// </summary>
    /// <param name="high">The high limit.</param>
    /// <returns>A new Range instance.</returns>
    public static Range AtMost(SimpleQuantity high)
    {
        return new Range(null, high);
    }

    /// <summary>
    /// Creates a Range between two SimpleQuantity values.
    /// </summary>
    /// <param name="low">The low limit.</param>
    /// <param name="high">The high limit.</param>
    /// <returns>A new Range instance.</returns>
    public static Range Between(SimpleQuantity low, SimpleQuantity high)
    {
        return new Range(low, high);
    }

    /// <summary>
    /// Creates a Range between two decimal values with the same unit.
    /// </summary>
    /// <param name="lowValue">The low value.</param>
    /// <param name="highValue">The high value.</param>
    /// <param name="unit">The unit for both values.</param>
    /// <returns>A new Range instance.</returns>
    public static Range Between(decimal lowValue, decimal highValue, string unit)
    {
        return new Range(lowValue, highValue, unit);
    }

    /// <summary>
    /// Checks if a SimpleQuantity value is within this range.
    /// </summary>
    /// <param name="value">The value to check.</param>
    /// <returns>True if the value is within the range, false otherwise.</returns>
    public bool Contains(SimpleQuantity value)
    {
        if (value?.Value?.Value == null) return false;

        var val = value.Value.Value;

        // Check low boundary
        if (Low?.Value?.Value != null && val < Low.Value.Value)
            return false;

        // Check high boundary
        if (High?.Value?.Value != null && val > High.Value.Value)
            return false;

        return true;
    }

    /// <summary>
    /// Validates the Range according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    protected override IEnumerable<ValidationResult> ValidateComplexType(ValidationContext validationContext)
    {
        // rng-2: If present, low SHALL have a lower value than high
        if (Low?.Value?.Value != null && High?.Value?.Value != null)
        {
            if (Low.Value.Value > High.Value.Value)
            {
                yield return new ValidationResult(
                    "Range low must be less than or equal to high",
                    new[] { nameof(Low), nameof(High) });
            }
        }

        // rng-3: Quantities must have the same units
        if (Low?.Unit?.Value != null && High?.Unit?.Value != null)
        {
            if (Low.Unit.Value != High.Unit.Value)
            {
                yield return new ValidationResult(
                    "Range low and high must have the same units",
                    new[] { nameof(Low), nameof(High) });
            }
        }
    }

    protected override string? GetComplexTypeString()
    {
        var lowStr = Low?.Value?.Value?.ToString() ?? "?";
        var highStr = High?.Value?.Value?.ToString() ?? "?";
        var unit = Low?.Unit?.Value ?? High?.Unit?.Value ?? "";
        return $"Range: {lowStr} - {highStr} {unit}".Trim();
    }
}
