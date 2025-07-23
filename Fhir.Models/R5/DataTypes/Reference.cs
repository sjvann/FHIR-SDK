// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Reference Type: A reference from one resource to another.
/// </summary>
public class Reference : DataType
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
    /// A reference to a location at which the other resource is found. The reference may be a relative
    /// reference, in which case it is relative to the service base URL, or an absolute URL that resolves to
    /// the location where the resource is found. The reference may be version specific or not. If the
    /// reference is not to a FHIR RESTful server, then it should be assumed to be version specific.
    /// Internal fragment references (start with &apos;#&apos;) refer to contained resources.
    /// </summary>
    [FhirElement("reference", Order = 12)]
    [Cardinality(0, 1)]
    [JsonPropertyName("reference")]
    public FhirString? Reference { get; set; }

    /// <summary>
    /// The expected type of the target of the reference. If both Reference.type and Reference.reference are
    /// populated and Reference.reference is a FHIR URL, both SHALL be consistent. The type is the Canonical
    /// URL of Resource Definition that is the type this reference refers to. References are URLs that are
    /// relative to http://hl7.org/fhir/StructureDefinition/ e.g. &quot;Patient&quot; is a reference to
    /// http://hl7.org/fhir/StructureDefinition/Patient. Absolute URLs are only allowed for logical models
    /// (and can only be used in references in logical models, not resources).
    /// </summary>
    [FhirElement("type", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName("type")]
    public FhirUri? Type { get; set; }

    /// <summary>
    /// An identifier for the target resource. This is used when there is no way to reference the other
    /// resource directly, either because the entity it represents is not available through a FHIR server,
    /// or because there is no way for the author of the resource to convert a known identifier to an actual
    /// location. There is no requirement that a Reference.identifier point to something that is actually
    /// exposed as a FHIR instance, but it SHALL point to a business concept that would be expected to be
    /// exposed as a FHIR instance, and that instance would need to be of a FHIR resource type allowed by
    /// the reference.
    /// </summary>
    [FhirElement("identifier", Order = 14)]
    [Cardinality(0, 1)]
    [JsonPropertyName("identifier")]
    public Identifier Identifier { get; set; }

    /// <summary>
    /// Plain text narrative that identifies the resource in addition to the resource reference.
    /// </summary>
    [FhirElement("display", Order = 15)]
    [Cardinality(0, 1)]
    [JsonPropertyName("display")]
    public FhirString? Display { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate Reference cardinality
        var referenceCount = Reference?.Count ?? 0;
        if (referenceCount < 0)
        {
            yield return new ValidationResult("Element 'Reference' cardinality must be 0..*", new[] { nameof(Reference) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Reference.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }

        // ValueSet binding validation
        // Validate Type ValueSet binding
        if (Type != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/resource-types
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Reference) });
        // }
        // Constraint: ref-1
        // Expression: reference.exists()  implies (reference.startsWith('#').not() or (reference.substring(1).trace('url') in %rootResource.contained.id.trace('ids')) or (reference='#' and %rootResource!=%resource))
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("reference.exists()  implies (reference.startsWith('#').not() or (reference.substring(1).trace('url') in %rootResource.contained.id.trace('ids')) or (reference='#' and %rootResource!=%resource))"))
        // {
        //     yield return new ValidationResult("SHALL have a contained resource if a local reference is provided", new[] { nameof(Reference) });
        // }
        // Constraint: ref-2
        // Expression: reference.exists() or identifier.exists() or display.exists() or extension.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("reference.exists() or identifier.exists() or display.exists() or extension.exists()"))
        // {
        //     yield return new ValidationResult("At least one of reference, identifier and display SHALL be present (unless an extension is provided).", new[] { nameof(Reference) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Reference) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Identifier) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Display) });
        // }
    }

}
