// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// ContactPoint Type: Details for all kinds of technology mediated contact points for a person or
/// organization, including telephone, email, etc.
/// </summary>
public class ContactPoint : DataType
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
    /// Telecommunications form for contact point - what communications system is required to make use of
    /// the contact.
    /// </summary>
    [FhirElement("system", Order = 12)]
    [Cardinality(0, 1)]
    [JsonPropertyName("system")]
    public FhirCode? System { get; set; }

    /// <summary>
    /// The actual contact point details, in a form that is meaningful to the designated communication
    /// system (i.e. phone number or email address).
    /// </summary>
    [FhirElement("value", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName("value")]
    public FhirString? Value { get; set; }

    /// <summary>
    /// Identifies the purpose for the contact point.
    /// </summary>
    [FhirElement("use", Order = 14)]
    [Cardinality(0, 1)]
    [JsonPropertyName("use")]
    public FhirCode? Use { get; set; }

    /// <summary>
    /// Specifies a preferred order in which to use a set of contacts. ContactPoints with lower rank values
    /// are more preferred than those with higher rank values.
    /// </summary>
    [FhirElement("rank", Order = 15)]
    [Cardinality(0, 1)]
    [JsonPropertyName("rank")]
    public FhirPositiveInt? Rank { get; set; }

    /// <summary>
    /// Time period when the contact point was/is in use.
    /// </summary>
    [FhirElement("period", Order = 16)]
    [Cardinality(0, 1)]
    [JsonPropertyName("period")]
    public Period Period { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate ContactPoint cardinality
        var contactpointCount = ContactPoint?.Count ?? 0;
        if (contactpointCount < 0)
        {
            yield return new ValidationResult("Element 'ContactPoint' cardinality must be 0..*", new[] { nameof(ContactPoint) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ContactPoint.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }

        // ValueSet binding validation
        // Validate System ValueSet binding
        if (System != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/contact-point-system|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Use ValueSet binding
        if (Use != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/contact-point-use|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: cpt-2
        // Expression: value.empty() or system.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("value.empty() or system.exists()"))
        // {
        //     yield return new ValidationResult("A system is required if a value is provided.", new[] { nameof(ContactPoint) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ContactPoint) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(System) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Use) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Rank) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Period) });
        // }
    }

}
