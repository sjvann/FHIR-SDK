// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// MonetaryComponent Type: Availability data for an {item}.
/// </summary>
public class MonetaryComponent : DataType
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
    /// base | surcharge | deduction | discount | tax | informational.
    /// </summary>
    [FhirElement("type", Order = 12)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("type")]
    public FhirCode Type { get; set; }

    /// <summary>
    /// Codes may be used to differentiate between kinds of taxes, surcharges, discounts etc.
    /// </summary>
    [FhirElement("code", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName("code")]
    public CodeableConcept Code { get; set; }

    /// <summary>
    /// Factor used for calculating this component.
    /// </summary>
    [FhirElement("factor", Order = 14)]
    [Cardinality(0, 1)]
    [JsonPropertyName("factor")]
    public FhirDecimal? Factor { get; set; }

    /// <summary>
    /// Explicit value amount to be used.
    /// </summary>
    [FhirElement("amount", Order = 15)]
    [Cardinality(0, 1)]
    [JsonPropertyName("amount")]
    public Money Amount { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate MonetaryComponent cardinality
        var monetarycomponentCount = MonetaryComponent?.Count ?? 0;
        if (monetarycomponentCount < 0)
        {
            yield return new ValidationResult("Element 'MonetaryComponent' cardinality must be 0..*", new[] { nameof(MonetaryComponent) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'MonetaryComponent.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        if (Type == null)
        {
            yield return new ValidationResult("Element 'MonetaryComponent.type' cardinality must be 1..1", new[] { nameof(Type) });
        }

        // ValueSet binding validation
        // Validate Type ValueSet binding
        if (Type != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/price-component-type|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(MonetaryComponent) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Type) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Code) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Amount) });
        // }
    }

}
