// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Ratio Type: A relationship of two Quantity values - expressed as a numerator and a denominator.
/// </summary>
public class Ratio : DataType
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
    /// The value of the numerator.
    /// </summary>
    [FhirElement("numerator", Order = 12)]
    [Cardinality(0, 1)]
    [JsonPropertyName("numerator")]
    public Quantity Numerator { get; set; }

    /// <summary>
    /// The value of the denominator.
    /// </summary>
    [FhirElement("denominator", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName("denominator")]
    public Quantity Denominator { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate Ratio cardinality
        var ratioCount = Ratio?.Count ?? 0;
        if (ratioCount < 0)
        {
            yield return new ValidationResult("Element 'Ratio' cardinality must be 0..*", new[] { nameof(Ratio) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Ratio.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }

        // Constraint validation
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Ratio) });
        // }
        // Constraint: rat-1
        // Expression: (numerator.exists() and denominator.exists()) or (numerator.empty() and denominator.empty() and extension.exists())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("(numerator.exists() and denominator.exists()) or (numerator.empty() and denominator.empty() and extension.exists())"))
        // {
        //     yield return new ValidationResult("Numerator and denominator SHALL both be present, or both are absent. If both are absent, there SHALL be some extension present", new[] { nameof(Ratio) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Numerator) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Denominator) });
        // }
    }

}
