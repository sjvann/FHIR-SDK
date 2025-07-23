// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// ExtendedContactDetail Type: Specifies contact information for a specific purpose over a period of
/// time, might be handled/monitored by a specific named person or organization.
/// </summary>
public class ExtendedContactDetail : DataType
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
    /// The purpose/type of contact.
    /// </summary>
    [FhirElement("purpose", Order = 12)]
    [Cardinality(0, 1)]
    [JsonPropertyName("purpose")]
    public CodeableConcept Purpose { get; set; }

    /// <summary>
    /// The name of an individual to contact, some types of contact detail are usually blank.
    /// </summary>
    [FhirElement("name", Order = 13)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("name")]
    public List<HumanName>? Name { get; set; }

    /// <summary>
    /// The contact details application for the purpose defined.
    /// </summary>
    [FhirElement("telecom", Order = 14)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("telecom")]
    public List<ContactPoint>? Telecom { get; set; }

    /// <summary>
    /// Address for the contact.
    /// </summary>
    [FhirElement("address", Order = 15)]
    [Cardinality(0, 1)]
    [JsonPropertyName("address")]
    public Address Address { get; set; }

    /// <summary>
    /// This contact detail is handled/monitored by a specific organization. If the name is provided in the
    /// contact, then it is referring to the named individual within this organization.
    /// </summary>
    [FhirElement("organization", Order = 16)]
    [Cardinality(0, 1)]
    [JsonPropertyName("organization")]
    public Reference<Organization> Organization { get; set; }

    /// <summary>
    /// Period that this contact was valid for usage.
    /// </summary>
    [FhirElement("period", Order = 17)]
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
        // Validate ExtendedContactDetail cardinality
        var extendedcontactdetailCount = ExtendedContactDetail?.Count ?? 0;
        if (extendedcontactdetailCount < 0)
        {
            yield return new ValidationResult("Element 'ExtendedContactDetail' cardinality must be 0..*", new[] { nameof(ExtendedContactDetail) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ExtendedContactDetail.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate Name cardinality
        var nameCount = Name?.Count ?? 0;
        if (nameCount < 0)
        {
            yield return new ValidationResult("Element 'ExtendedContactDetail.name' cardinality must be 0..*", new[] { nameof(Name) });
        }
        // Validate Telecom cardinality
        var telecomCount = Telecom?.Count ?? 0;
        if (telecomCount < 0)
        {
            yield return new ValidationResult("Element 'ExtendedContactDetail.telecom' cardinality must be 0..*", new[] { nameof(Telecom) });
        }

        // Constraint validation
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ExtendedContactDetail) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Purpose) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Name) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Telecom) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Address) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Organization) });
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
