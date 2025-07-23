// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Coding Type: A reference to a code defined by a terminology system.
/// </summary>
public class Coding : DataType
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
    /// The identification of the code system that defines the meaning of the symbol in the code.
    /// </summary>
    [FhirElement("system", Order = 12)]
    [Cardinality(0, 1)]
    [JsonPropertyName("system")]
    public FhirUri? System { get; set; }

    /// <summary>
    /// The version of the code system which was used when choosing this code. Note that a well-maintained
    /// code system does not need the version reported, because the meaning of codes is consistent across
    /// versions. However this cannot consistently be assured, and when the meaning is not guaranteed to be
    /// consistent, the version SHOULD be exchanged.
    /// </summary>
    [FhirElement("version", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName("version")]
    public FhirString? Version { get; set; }

    /// <summary>
    /// A symbol in syntax defined by the system. The symbol may be a predefined code or an expression in a
    /// syntax defined by the coding system (e.g. post-coordination).
    /// </summary>
    [FhirElement("code", Order = 14)]
    [Cardinality(0, 1)]
    [JsonPropertyName("code")]
    public FhirCode? Code { get; set; }

    /// <summary>
    /// A representation of the meaning of the code in the system, following the rules of the system.
    /// </summary>
    [FhirElement("display", Order = 15)]
    [Cardinality(0, 1)]
    [JsonPropertyName("display")]
    public FhirString? Display { get; set; }

    /// <summary>
    /// Indicates that this coding was chosen by a user directly - e.g. off a pick list of available items
    /// (codes or displays).
    /// </summary>
    [FhirElement("userSelected", Order = 16)]
    [Cardinality(0, 1)]
    [JsonPropertyName("userSelected")]
    public FhirBoolean? UserSelected { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate Coding cardinality
        var codingCount = Coding?.Count ?? 0;
        if (codingCount < 0)
        {
            yield return new ValidationResult("Element 'Coding' cardinality must be 0..*", new[] { nameof(Coding) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Coding.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }

        // Constraint validation
        // Constraint: cod-1
        // Expression: code.exists().not() implies display.exists().not()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("code.exists().not() implies display.exists().not()"))
        // {
        //     yield return new ValidationResult("A Coding SHOULD NOT have a display unless a code is also present.  Computation on Coding.display alone is generally unsafe.  Consider using CodeableConcept.text", new[] { nameof(Coding) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Coding) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Version) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Display) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(UserSelected) });
        // }
    }

}
