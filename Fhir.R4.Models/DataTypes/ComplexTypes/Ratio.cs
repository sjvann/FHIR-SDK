using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// A relationship of two Quantity values - expressed as a numerator and a denominator.
/// </summary>
/// <remarks>
/// FHIR R4 Ratio DataType
/// A relationship of two Quantity values - expressed as a numerator and a denominator.
/// </remarks>
public class Ratio : ComplexType<Ratio>
{
    /// <summary>
    /// The value of the numerator.
    /// FHIR Path: Ratio.numerator
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("numerator")]
    public Quantity? Numerator { get; set; }

    /// <summary>
    /// The value of the denominator.
    /// FHIR Path: Ratio.denominator
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("denominator")]
    public Quantity? Denominator { get; set; }

    /// <summary>
    /// Initializes a new instance of the Ratio class.
    /// </summary>
    public Ratio() { }

    /// <summary>
    /// Initializes a new instance of the Ratio class with numerator and denominator.
    /// </summary>
    /// <param name="numerator">The numerator quantity.</param>
    /// <param name="denominator">The denominator quantity.</param>
    public Ratio(Quantity? numerator, Quantity? denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    /// <summary>
    /// Initializes a new instance of the Ratio class with decimal values and units.
    /// </summary>
    /// <param name="numeratorValue">The numerator value.</param>
    /// <param name="numeratorUnit">The numerator unit.</param>
    /// <param name="denominatorValue">The denominator value.</param>
    /// <param name="denominatorUnit">The denominator unit.</param>
    public Ratio(decimal? numeratorValue, string? numeratorUnit, decimal? denominatorValue, string? denominatorUnit)
    {
        Numerator = numeratorValue != null ? new Quantity { Value = numeratorValue, Unit = numeratorUnit } : null;
        Denominator = denominatorValue != null ? new Quantity { Value = denominatorValue, Unit = denominatorUnit } : null;
    }

    /// <summary>
    /// Creates a simple ratio with decimal values (no units).
    /// </summary>
    /// <param name="numerator">The numerator value.</param>
    /// <param name="denominator">The denominator value.</param>
    /// <returns>A new Ratio instance.</returns>
    public static Ratio Create(decimal numerator, decimal denominator)
    {
        return new Ratio(
            new Quantity { Value = numerator },
            new Quantity { Value = denominator }
        );
    }

    /// <summary>
    /// Creates a ratio with values and units.
    /// </summary>
    /// <param name="numeratorValue">The numerator value.</param>
    /// <param name="numeratorUnit">The numerator unit.</param>
    /// <param name="denominatorValue">The denominator value.</param>
    /// <param name="denominatorUnit">The denominator unit.</param>
    /// <returns>A new Ratio instance.</returns>
    public static Ratio Create(decimal numeratorValue, string numeratorUnit, decimal denominatorValue, string denominatorUnit)
    {
        return new Ratio(numeratorValue, numeratorUnit, denominatorValue, denominatorUnit);
    }

    /// <summary>
    /// Converts the ratio to a decimal value (numerator / denominator).
    /// </summary>
    /// <returns>The decimal value of the ratio, or null if conversion is not possible.</returns>
    public decimal? ToDecimal()
    {
        if (Numerator?.Value == null || Denominator?.Value == null || Denominator.Value == 0)
            return null;

        return Numerator.Value / Denominator.Value;
    }

    /// <summary>
    /// Simplifies the ratio by finding the greatest common divisor.
    /// </summary>
    /// <returns>A new simplified Ratio instance, or the original if simplification is not possible.</returns>
    public Ratio Simplify()
    {
        if (Numerator?.Value == null || Denominator?.Value == null)
            return this;

        var num = (int)Math.Round((decimal)Numerator.Value);
        var den = (int)Math.Round((decimal)Denominator.Value);

        var gcd = GreatestCommonDivisor(Math.Abs(num), Math.Abs(den));

        if (gcd > 1)
        {
            return new Ratio(
                new Quantity { Value = num / gcd, Unit = Numerator.Unit },
                new Quantity { Value = den / gcd, Unit = Denominator.Unit }
            );
        }

        return this;
    }

    /// <summary>
    /// Checks if this ratio is equivalent to another ratio.
    /// </summary>
    /// <param name="other">The other ratio to compare.</param>
    /// <returns>True if the ratios are equivalent, false otherwise.</returns>
    public bool IsEquivalentTo(Ratio other)
    {
        if (other == null) return false;

        var thisDecimal = ToDecimal();
        var otherDecimal = other.ToDecimal();

        if (thisDecimal == null || otherDecimal == null)
            return false;

        return Math.Abs(thisDecimal.Value - otherDecimal.Value) < 0.0001m;
    }

    /// <summary>
    /// Calculates the greatest common divisor of two integers.
    /// </summary>
    /// <param name="a">First integer.</param>
    /// <param name="b">Second integer.</param>
    /// <returns>The greatest common divisor.</returns>
    private static int GreatestCommonDivisor(int a, int b)
    {
        while (b != 0)
        {
            var temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    /// <summary>
    /// Validates the Ratio according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    protected override IEnumerable<ValidationResult> ValidateComplexType(ValidationContext validationContext)
    {
        // rat-1: Numerator and denominator SHALL both be present, or both are absent
        if ((Numerator == null) != (Denominator == null))
        {
            yield return new ValidationResult(
                "Ratio numerator and denominator must both be present or both absent",
                new[] { nameof(Numerator), nameof(Denominator) });
        }

        // Additional validation: denominator should not be zero
        if (Denominator?.Value == 0)
        {
            yield return new ValidationResult(
                "Ratio denominator cannot be zero",
                new[] { nameof(Denominator) });
        }
    }

    protected override string? GetComplexTypeString()
    {
        var numStr = Numerator?.Value?.ToString() ?? "?";
        var denStr = Denominator?.Value?.ToString() ?? "?";
        var numUnit = Numerator?.Unit ?? "";
        var denUnit = Denominator?.Unit ?? "";
        
        if (!string.IsNullOrEmpty(numUnit) || !string.IsNullOrEmpty(denUnit))
        {
            return $"Ratio: {numStr}{numUnit} : {denStr}{denUnit}";
        }
        
        return $"Ratio: {numStr} : {denStr}";
    }
}
