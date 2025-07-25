using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// A series of measurements taken by a device, with upper and lower limits.
/// </summary>
/// <remarks>
/// FHIR R4 SampledData DataType
/// A series of measurements taken by a device, with upper and lower limits.
/// There is only one dimension in the data; if the data is multi-dimensional, multiple SampledData elements are used.
/// </remarks>
public class SampledData : ComplexType<SampledData>
{
    /// <summary>
    /// Zero value and units.
    /// FHIR Path: SampledData.origin
    /// Cardinality: 1..1
    /// </summary>
    /// <remarks>
    /// The base quantity that a measured value of zero represents. In addition, this provides the units of the entire measurement series.
    /// </remarks>
    [JsonPropertyName("origin")]
    public SimpleQuantity Origin { get; set; } = null!;

    /// <summary>
    /// Number of milliseconds between samples.
    /// FHIR Path: SampledData.period
    /// Cardinality: 1..1
    /// </summary>
    /// <remarks>
    /// The length of time between sampling times, measured in milliseconds.
    /// </remarks>
    [JsonPropertyName("period")]
    public FhirDecimal Period { get; set; } = null!;

    /// <summary>
    /// Multiply data by this before adding to origin.
    /// FHIR Path: SampledData.factor
    /// Cardinality: 0..1
    /// </summary>
    /// <remarks>
    /// A correction factor that is applied to the sampled data points before they are added to the origin.
    /// </remarks>
    [JsonPropertyName("factor")]
    public FhirDecimal? Factor { get; set; }

    /// <summary>
    /// Lower limit of detection.
    /// FHIR Path: SampledData.lowerLimit
    /// Cardinality: 0..1
    /// </summary>
    /// <remarks>
    /// The lower limit of detection of the measured points. This is needed if any of the data points have the value "L" (lower than detection limit).
    /// </remarks>
    [JsonPropertyName("lowerLimit")]
    public FhirDecimal? LowerLimit { get; set; }

    /// <summary>
    /// Upper limit of detection.
    /// FHIR Path: SampledData.upperLimit
    /// Cardinality: 0..1
    /// </summary>
    /// <remarks>
    /// The upper limit of detection of the measured points. This is needed if any of the data points have the value "U" (higher than detection limit).
    /// </remarks>
    [JsonPropertyName("upperLimit")]
    public FhirDecimal? UpperLimit { get; set; }

    /// <summary>
    /// Number of sample points at each time point.
    /// FHIR Path: SampledData.dimensions
    /// Cardinality: 1..1
    /// </summary>
    /// <remarks>
    /// The number of sample points at each time point. If this value is greater than one, then the dimensions will be interlaced - all the sample points for a point in time will be recorded at once.
    /// </remarks>
    [JsonPropertyName("dimensions")]
    public FhirPositiveInt Dimensions { get; set; } = null!;

    /// <summary>
    /// Decimal values with spaces, or "E" | "L" | "U".
    /// FHIR Path: SampledData.data
    /// Cardinality: 0..1
    /// </summary>
    /// <remarks>
    /// A series of data points which are decimal values separated by a single space (character u20). The special values "E" (error), "L" (below detection limit) and "U" (above detection limit) can also be used in place of a decimal value.
    /// </remarks>
    [JsonPropertyName("data")]
    public FhirString? Data { get; set; }

    /// <summary>
    /// Initializes a new instance of the SampledData class.
    /// </summary>
    public SampledData() { }

    /// <summary>
    /// Initializes a new instance of the SampledData class with required parameters.
    /// </summary>
    /// <param name="origin">The zero value and units.</param>
    /// <param name="period">The number of milliseconds between samples.</param>
    /// <param name="dimensions">The number of sample points at each time point.</param>
    public SampledData(SimpleQuantity origin, decimal period, int dimensions)
    {
        Origin = origin ?? throw new ArgumentNullException(nameof(origin));
        Period = new FhirDecimal(period);
        Dimensions = new FhirPositiveInt(dimensions);
    }

    /// <summary>
    /// Creates a SampledData with the specified parameters.
    /// </summary>
    /// <param name="origin">The zero value and units.</param>
    /// <param name="period">The number of milliseconds between samples.</param>
    /// <param name="dimensions">The number of sample points at each time point.</param>
    /// <param name="data">The data points as a space-separated string.</param>
    /// <returns>A new SampledData instance.</returns>
    public static SampledData Create(SimpleQuantity origin, decimal period, int dimensions, string? data = null)
    {
        var sampledData = new SampledData(origin, period, dimensions);
        if (!string.IsNullOrEmpty(data))
        {
            sampledData.Data = new FhirString(data);
        }
        return sampledData;
    }

    /// <summary>
    /// Sets the data points from an array of decimal values.
    /// </summary>
    /// <param name="values">The array of decimal values.</param>
    /// <returns>The current SampledData instance for method chaining.</returns>
    public SampledData SetData(decimal[] values)
    {
        if (values == null || values.Length == 0)
        {
            Data = null;
            return this;
        }

        var dataString = string.Join(" ", values.Select(v => v.ToString("G")));
        Data = new FhirString(dataString);
        return this;
    }

    /// <summary>
    /// Sets the data points from an array of strings (allowing special values like "E", "L", "U").
    /// </summary>
    /// <param name="values">The array of string values.</param>
    /// <returns>The current SampledData instance for method chaining.</returns>
    public SampledData SetData(string[] values)
    {
        if (values == null || values.Length == 0)
        {
            Data = null;
            return this;
        }

        var dataString = string.Join(" ", values);
        Data = new FhirString(dataString);
        return this;
    }

    /// <summary>
    /// Gets the data points as an array of strings.
    /// </summary>
    /// <returns>An array of data point strings, or an empty array if no data.</returns>
    public string[] GetDataPoints()
    {
        if (string.IsNullOrEmpty(Data?.Value))
            return Array.Empty<string>();

        return Data.Value.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    }

    /// <summary>
    /// Gets the data points as an array of decimal values (excluding special values).
    /// </summary>
    /// <returns>An array of decimal values, with null for special values.</returns>
    public decimal?[] GetNumericDataPoints()
    {
        var dataPoints = GetDataPoints();
        var result = new decimal?[dataPoints.Length];

        for (int i = 0; i < dataPoints.Length; i++)
        {
            var point = dataPoints[i];
            if (point == "E" || point == "L" || point == "U")
            {
                result[i] = null;
            }
            else if (decimal.TryParse(point, out var value))
            {
                result[i] = value;
            }
            else
            {
                result[i] = null;
            }
        }

        return result;
    }

    /// <summary>
    /// Calculates the actual values by applying the factor and adding to the origin.
    /// </summary>
    /// <returns>An array of actual values, with null for special values or errors.</returns>
    public decimal?[] GetActualValues()
    {
        var dataPoints = GetNumericDataPoints();
        var result = new decimal?[dataPoints.Length];
        var factor = Factor?.Value ?? 1m;
        var origin = Origin?.Value ?? 0m;

        for (int i = 0; i < dataPoints.Length; i++)
        {
            if (dataPoints[i].HasValue)
            {
                result[i] = origin + (dataPoints[i].Value * factor);
            }
            else
            {
                result[i] = null;
            }
        }

        return result;
    }

    /// <summary>
    /// Validates the SampledData according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    protected override IEnumerable<ValidationResult> ValidateComplexType(ValidationContext validationContext)
    {
        // Required fields validation
        if (Origin == null)
        {
            yield return new ValidationResult(
                "SampledData.origin is required",
                new[] { nameof(Origin) });
        }

        if (Period == null)
        {
            yield return new ValidationResult(
                "SampledData.period is required",
                new[] { nameof(Period) });
        }

        if (Dimensions == null)
        {
            yield return new ValidationResult(
                "SampledData.dimensions is required",
                new[] { nameof(Dimensions) });
        }

        // Validate period is positive
        if (Period?.Value <= 0)
        {
            yield return new ValidationResult(
                "SampledData.period must be positive",
                new[] { nameof(Period) });
        }

        // Validate dimensions is positive
        if (Dimensions?.Value <= 0)
        {
            yield return new ValidationResult(
                "SampledData.dimensions must be positive",
                new[] { nameof(Dimensions) });
        }

        // Validate limits
        if (LowerLimit?.Value != null && UpperLimit?.Value != null && LowerLimit.Value >= UpperLimit.Value)
        {
            yield return new ValidationResult(
                "SampledData.lowerLimit must be less than upperLimit",
                new[] { nameof(LowerLimit), nameof(UpperLimit) });
        }

        // Validate data format
        if (Data?.Value != null)
        {
            var dataPoints = GetDataPoints();
            foreach (var point in dataPoints)
            {
                if (point != "E" && point != "L" && point != "U" && !decimal.TryParse(point, out _))
                {
                    yield return new ValidationResult(
                        $"Invalid data point '{point}' in SampledData.data. Must be a decimal number or 'E', 'L', or 'U'",
                        new[] { nameof(Data) });
                }
            }
        }

        // Validate individual components
        if (Origin != null)
        {
            var originValidationContext = new ValidationContext(Origin);
            foreach (var result in Origin.Validate(originValidationContext))
                yield return result;
        }

        if (Period != null)
        {
            var periodValidationContext = new ValidationContext(Period);
            foreach (var result in Period.Validate(periodValidationContext))
                yield return result;
        }

        if (Factor != null)
        {
            var factorValidationContext = new ValidationContext(Factor);
            foreach (var result in Factor.Validate(factorValidationContext))
                yield return result;
        }

        if (LowerLimit != null)
        {
            var lowerLimitValidationContext = new ValidationContext(LowerLimit);
            foreach (var result in LowerLimit.Validate(lowerLimitValidationContext))
                yield return result;
        }

        if (UpperLimit != null)
        {
            var upperLimitValidationContext = new ValidationContext(UpperLimit);
            foreach (var result in UpperLimit.Validate(upperLimitValidationContext))
                yield return result;
        }

        if (Dimensions != null)
        {
            var dimensionsValidationContext = new ValidationContext(Dimensions);
            foreach (var result in Dimensions.Validate(dimensionsValidationContext))
                yield return result;
        }

        if (Data != null)
        {
            var dataValidationContext = new ValidationContext(Data);
            foreach (var result in Data.Validate(dataValidationContext))
                yield return result;
        }
    }

    /// <summary>
    /// Determines whether the specified SampledData is equal to the current SampledData.
    /// </summary>
    /// <param name="other">The SampledData to compare with the current SampledData.</param>
    /// <returns>True if the specified SampledData is equal to the current SampledData; otherwise, false.</returns>
    protected override bool EqualsComplexType(SampledData other)
    {
        return EqualityComparer<SimpleQuantity?>.Default.Equals(Origin, other.Origin) &&
               EqualityComparer<FhirDecimal?>.Default.Equals(Period, other.Period) &&
               EqualityComparer<FhirDecimal?>.Default.Equals(Factor, other.Factor) &&
               EqualityComparer<FhirDecimal?>.Default.Equals(LowerLimit, other.LowerLimit) &&
               EqualityComparer<FhirDecimal?>.Default.Equals(UpperLimit, other.UpperLimit) &&
               EqualityComparer<FhirPositiveInt?>.Default.Equals(Dimensions, other.Dimensions) &&
               EqualityComparer<FhirString?>.Default.Equals(Data, other.Data);
    }

    /// <summary>
    /// Returns the hash code for this SampledData.
    /// </summary>
    /// <returns>A hash code for the current SampledData.</returns>
    protected override int GetComplexTypeHashCode()
    {
        return HashCode.Combine(Origin, Period, Factor, LowerLimit, UpperLimit, Dimensions, Data);
    }

    /// <summary>
    /// Returns a string representation of the SampledData.
    /// </summary>
    /// <returns>The string representation of the SampledData.</returns>
    protected override string? GetComplexTypeString()
    {
        var dataPointCount = GetDataPoints().Length;
        return $"SampledData: {dataPointCount} points, period={Period?.Value}ms, dimensions={Dimensions?.Value}";
    }
}
