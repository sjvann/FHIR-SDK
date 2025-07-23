// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Duration Type: A length of time.
/// </summary>
public class Duration : Element
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
    /// The value of the measured amount. The value includes an implicit precision in the presentation of
    /// the value.
    /// </summary>
    [FhirElement("value", Order = 12)]
    [Cardinality(0, 1)]
    [JsonPropertyName("value")]
    public FhirDecimal? Value { get; set; }

    /// <summary>
    /// How the value should be understood and represented - whether the actual value is greater or less
    /// than the stated value due to measurement issues; e.g. if the comparator is &quot;&lt;&quot; , then
    /// the real value is &lt; stated value.
    /// </summary>
    [FhirElement("comparator", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName("comparator")]
    public FhirCode? Comparator { get; set; }

    /// <summary>
    /// A human-readable form of the unit.
    /// </summary>
    [FhirElement("unit", Order = 14)]
    [Cardinality(0, 1)]
    [JsonPropertyName("unit")]
    public FhirString? Unit { get; set; }

    /// <summary>
    /// The identification of the system that provides the coded form of the unit.
    /// </summary>
    [FhirElement("system", Order = 15)]
    [Cardinality(0, 1)]
    [JsonPropertyName("system")]
    public FhirUri? System { get; set; }

    /// <summary>
    /// A computer processable form of the unit in some unit representation system.
    /// </summary>
    [FhirElement("code", Order = 16)]
    [Cardinality(0, 1)]
    [JsonPropertyName("code")]
    public FhirCode? Code { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate Duration cardinality
        var durationCount = Duration?.Count ?? 0;
        if (durationCount < 0)
        {
            yield return new ValidationResult("Element 'Duration' cardinality must be 0..*", new[] { nameof(Duration) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Duration.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }

        // ValueSet binding validation
        // Validate Duration ValueSet binding
        if (Duration != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/duration-units
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Comparator ValueSet binding
        if (Comparator != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/quantity-comparator|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: drt-1
        // Expression: code.exists() implies ((system = %ucum) and value.exists())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("code.exists() implies ((system = %ucum) and value.exists())"))
        // {
        //     yield return new ValidationResult("There SHALL be a code if there is a value and it SHALL be an expression of time.  If system is present, it SHALL be UCUM.", new[] { nameof(Duration) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Duration) });
        // }
        // Constraint: qty-3
        // Expression: code.empty() or system.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("code.empty() or system.exists()"))
        // {
        //     yield return new ValidationResult("If a code for the unit is present, the system SHALL also be present", new[] { nameof(Duration) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Value) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Comparator) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Unit) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(System) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Code) });
        // }
    }

}
