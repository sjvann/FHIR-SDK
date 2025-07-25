using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// A length - a value with a unit that is a physical distance.
/// </summary>
/// <remarks>
/// FHIR R4 Distance DataType
/// A length - a value with a unit that is a physical distance.
/// Distance is a specialization of Quantity.
/// </remarks>
public class Distance : ComplexType<Distance>
{
    /// <summary>
    /// Numerical value (with implicit precision).
    /// FHIR Path: Distance.value
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("value")]
    public FhirDecimal? Value { get; set; }

    /// <summary>
    /// How the value should be understood and represented.
    /// FHIR Path: Distance.comparator
    /// Cardinality: 0..1
    /// Allowed values: &lt;, &lt;=, &gt;=, &gt;
    /// </summary>
    [JsonPropertyName("comparator")]
    public FhirCode? Comparator { get; set; }

    /// <summary>
    /// A human-readable form of the unit.
    /// FHIR Path: Distance.unit
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("unit")]
    public FhirString? Unit { get; set; }

    /// <summary>
    /// The identification of the system that provides the coded form of the unit.
    /// FHIR Path: Distance.system
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("system")]
    public FhirUri? System { get; set; }

    /// <summary>
    /// A computer processable form of the unit in some unit representation system.
    /// FHIR Path: Distance.code
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("code")]
    public FhirCode? Code { get; set; }

    /// <summary>
    /// Initializes a new instance of the Distance class.
    /// </summary>
    public Distance() { }

    /// <summary>
    /// Initializes a new instance of the Distance class with a value and unit.
    /// </summary>
    /// <param name="value">The distance value.</param>
    /// <param name="unit">The unit.</param>
    public Distance(decimal? value, string unit)
    {
        Value = value != null ? new FhirDecimal(value) : null;
        Unit = new FhirString(unit);
        System = new FhirUri("http://unitsofmeasure.org");
        Code = new FhirCode(unit);
    }

    /// <summary>
    /// Creates a Distance in meters.
    /// </summary>
    /// <param name="meters">The distance in meters.</param>
    /// <returns>A new Distance instance.</returns>
    public static Distance Meters(decimal meters)
    {
        return new Distance(meters, "m");
    }

    /// <summary>
    /// Creates a Distance in centimeters.
    /// </summary>
    /// <param name="centimeters">The distance in centimeters.</param>
    /// <returns>A new Distance instance.</returns>
    public static Distance Centimeters(decimal centimeters)
    {
        return new Distance(centimeters, "cm");
    }

    /// <summary>
    /// Creates a Distance in millimeters.
    /// </summary>
    /// <param name="millimeters">The distance in millimeters.</param>
    /// <returns>A new Distance instance.</returns>
    public static Distance Millimeters(decimal millimeters)
    {
        return new Distance(millimeters, "mm");
    }

    /// <summary>
    /// Creates a Distance in kilometers.
    /// </summary>
    /// <param name="kilometers">The distance in kilometers.</param>
    /// <returns>A new Distance instance.</returns>
    public static Distance Kilometers(decimal kilometers)
    {
        return new Distance(kilometers, "km");
    }

    /// <summary>
    /// Creates a Distance in inches.
    /// </summary>
    /// <param name="inches">The distance in inches.</param>
    /// <returns>A new Distance instance.</returns>
    public static Distance Inches(decimal inches)
    {
        return new Distance(inches, "[in_i]");
    }

    /// <summary>
    /// Creates a Distance in feet.
    /// </summary>
    /// <param name="feet">The distance in feet.</param>
    /// <returns>A new Distance instance.</returns>
    public static Distance Feet(decimal feet)
    {
        return new Distance(feet, "[ft_i]");
    }

    /// <summary>
    /// Validates the Distance according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    protected override IEnumerable<ValidationResult> ValidateComplexType(ValidationContext validationContext)
    {
        // Distance should not be negative
        if (Value?.Value < 0)
        {
            yield return new ValidationResult(
                "Distance cannot be negative",
                new[] { nameof(Value) });
        }

        // Distance should have appropriate units
        if (Code?.Value != null)
        {
            var validUnits = new[] { "m", "cm", "mm", "km", "[in_i]", "[ft_i]", "[yd_i]", "[mi_i]" };
            if (!validUnits.Contains(Code.Value))
            {
                yield return new ValidationResult(
                    $"Distance unit '{Code.Value}' is not a valid length unit",
                    new[] { nameof(Code) });
            }
        }
    }

    protected override string? GetComplexTypeString()
    {
        return $"Distance: {Value?.Value} {Unit?.Value}";
    }
}
