// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// SampledData Type: A series of measurements taken by a device, with upper and lower limits. There may
/// be more than one dimension in the data.
/// </summary>
public class SampledData : DataType
{
    /// <summary>
    /// Unique id for the element within a resource (for internal references). This may be any string value
    /// that does not contain spaces.
    /// </summary>
    [FhirElement("id", Order = 10)]
    [Cardinality(0, 1)]
    [JsonPropertyName("id")]
    public FhirString? Id { get; set; }

    /// <summary>
    /// May be used to represent additional information that is not part of the basic definition of the
    /// element. To make the use of extensions safe and managable, there is a strict set of governance
    /// applied to the definition and use of extensions. Though any implementer can define an extension,
    /// there is a set of requirements that SHALL be met as part of the definition of the extension.
    /// </summary>
    [FhirElement("extension", Order = 11)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("extension")]
    public List<Extension>? Extension { get; set; }

    /// <summary>
    /// The base quantity that a measured value of zero represents. In addition, this provides the units of
    /// the entire measurement series.
    /// </summary>
    [FhirElement("origin", Order = 12)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("origin")]
    public Quantity Origin { get; set; }

    /// <summary>
    /// Amount of intervalUnits between samples, e.g. milliseconds for time-based sampling.
    /// </summary>
    [FhirElement("interval", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName("interval")]
    public FhirDecimal? Interval { get; set; }

    /// <summary>
    /// The measurement unit in which the sample interval is expressed.
    /// </summary>
    [FhirElement("intervalUnit", Order = 14)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("intervalUnit")]
    public FhirCode IntervalUnit { get; set; }

    /// <summary>
    /// A correction factor that is applied to the sampled data points before they are added to the origin.
    /// </summary>
    [FhirElement("factor", Order = 15)]
    [Cardinality(0, 1)]
    [JsonPropertyName("factor")]
    public FhirDecimal? Factor { get; set; }

    /// <summary>
    /// The lower limit of detection of the measured points. This is needed if any of the data points have
    /// the value &quot;L&quot; (lower than detection limit).
    /// </summary>
    [FhirElement("lowerLimit", Order = 16)]
    [Cardinality(0, 1)]
    [JsonPropertyName("lowerLimit")]
    public FhirDecimal? LowerLimit { get; set; }

    /// <summary>
    /// The upper limit of detection of the measured points. This is needed if any of the data points have
    /// the value &quot;U&quot; (higher than detection limit).
    /// </summary>
    [FhirElement("upperLimit", Order = 17)]
    [Cardinality(0, 1)]
    [JsonPropertyName("upperLimit")]
    public FhirDecimal? UpperLimit { get; set; }

    /// <summary>
    /// The number of sample points at each time point. If this value is greater than one, then the
    /// dimensions will be interlaced - all the sample points for a point in time will be recorded at once.
    /// </summary>
    [FhirElement("dimensions", Order = 18)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("dimensions")]
    public FhirPositiveInt Dimensions { get; set; }

    /// <summary>
    /// Reference to ConceptMap that defines the codes used in the data.
    /// </summary>
    [FhirElement("codeMap", Order = 19)]
    [Cardinality(0, 1)]
    [JsonPropertyName("codeMap")]
    public FhirCanonical? CodeMap { get; set; }

    /// <summary>
    /// A series of data points which are decimal values separated by a single space (character u20). The
    /// units in which the offsets are expressed are found in intervalUnit. The absolute point at which the
    /// measurements begin SHALL be conveyed outside the scope of this datatype, e.g.
    /// Observation.effectiveDateTime for a timing offset.
    /// </summary>
    [FhirElement("offsets", Order = 20)]
    [Cardinality(0, 1)]
    [JsonPropertyName("offsets")]
    public FhirString? Offsets { get; set; }

    /// <summary>
    /// A series of data points which are decimal values or codes separated by a single space (character
    /// u20). The special codes &quot;E&quot; (error), &quot;L&quot; (below detection limit) and
    /// &quot;U&quot; (above detection limit) are also defined for used in place of decimal values.
    /// </summary>
    [FhirElement("data", Order = 21)]
    [Cardinality(0, 1)]
    [JsonPropertyName("data")]
    public FhirString? Data { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate SampledData cardinality
        var sampleddataCount = SampledData?.Count ?? 0;
        if (sampleddataCount < 0)
        {
            yield return new ValidationResult("Element 'SampledData' cardinality must be 0..*", new[] { nameof(SampledData) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'SampledData.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        if (Origin == null)
        {
            yield return new ValidationResult("Element 'SampledData.origin' cardinality must be 1..1", new[] { nameof(Origin) });
        }
        if (IntervalUnit == null)
        {
            yield return new ValidationResult("Element 'SampledData.intervalUnit' cardinality must be 1..1", new[] { nameof(IntervalUnit) });
        }
        if (Dimensions == null)
        {
            yield return new ValidationResult("Element 'SampledData.dimensions' cardinality must be 1..1", new[] { nameof(Dimensions) });
        }

        // ValueSet binding validation
        // Validate IntervalUnit ValueSet binding
        if (IntervalUnit != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/ucum-units|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(SampledData) });
        // }
        // Constraint: sdd-1
        // Expression: interval.exists().not() xor offsets.exists().not()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("interval.exists().not() xor offsets.exists().not()"))
        // {
        //     yield return new ValidationResult("A SampledData SAHLL have either an interval and offsets but not both", new[] { nameof(SampledData) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Extension) });
        // }
        // Constraint: ext-1
        // Expression: extension.exists() != value.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("extension.exists() != value.exists()"))
        // {
        //     yield return new ValidationResult("Must have either extensions or value[x], not both", new[] { nameof(Extension) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Origin) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Interval) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(IntervalUnit) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Factor) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(LowerLimit) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(UpperLimit) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Dimensions) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(CodeMap) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Offsets) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Data) });
        // }
    }

}
