// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// HumanName Type: A name, normally of a human, that can be used for other living entities (e.g.
/// animals but not organizations) that have been assigned names by a human and may need the use of name
/// parts or the need for usage information.
/// </summary>
public class HumanName : DataType
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
    /// Identifies the purpose for this name.
    /// </summary>
    [FhirElement("use", Order = 12)]
    [Cardinality(0, 1)]
    [JsonPropertyName("use")]
    public FhirCode? Use { get; set; }

    /// <summary>
    /// Specifies the entire name as it should be displayed e.g. on an application UI. This may be provided
    /// instead of or as well as the specific parts.
    /// </summary>
    [FhirElement("text", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName("text")]
    public FhirString? Text { get; set; }

    /// <summary>
    /// The part of a name that links to the genealogy. In some cultures (e.g. Eritrea) the family name of a
    /// son is the first name of his father.
    /// </summary>
    [FhirElement("family", Order = 14)]
    [Cardinality(0, 1)]
    [JsonPropertyName("family")]
    public FhirString? Family { get; set; }

    /// <summary>
    /// Given name.
    /// </summary>
    [FhirElement("given", Order = 15)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("given")]
    public List<FhirString>? Given { get; set; }

    /// <summary>
    /// Part of the name that is acquired as a title due to academic, legal, employment or nobility status,
    /// etc. and that appears at the start of the name.
    /// </summary>
    [FhirElement("prefix", Order = 16)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("prefix")]
    public List<FhirString>? Prefix { get; set; }

    /// <summary>
    /// Part of the name that is acquired as a title due to academic, legal, employment or nobility status,
    /// etc. and that appears at the end of the name.
    /// </summary>
    [FhirElement("suffix", Order = 17)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("suffix")]
    public List<FhirString>? Suffix { get; set; }

    /// <summary>
    /// Indicates the period of time when this name was valid for the named person.
    /// </summary>
    [FhirElement("period", Order = 18)]
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
        // Validate HumanName cardinality
        var humannameCount = HumanName?.Count ?? 0;
        if (humannameCount < 0)
        {
            yield return new ValidationResult("Element 'HumanName' cardinality must be 0..*", new[] { nameof(HumanName) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'HumanName.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate Given cardinality
        var givenCount = Given?.Count ?? 0;
        if (givenCount < 0)
        {
            yield return new ValidationResult("Element 'HumanName.given' cardinality must be 0..*", new[] { nameof(Given) });
        }
        // Validate Prefix cardinality
        var prefixCount = Prefix?.Count ?? 0;
        if (prefixCount < 0)
        {
            yield return new ValidationResult("Element 'HumanName.prefix' cardinality must be 0..*", new[] { nameof(Prefix) });
        }
        // Validate Suffix cardinality
        var suffixCount = Suffix?.Count ?? 0;
        if (suffixCount < 0)
        {
            yield return new ValidationResult("Element 'HumanName.suffix' cardinality must be 0..*", new[] { nameof(Suffix) });
        }

        // ValueSet binding validation
        // Validate Use ValueSet binding
        if (Use != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/name-use|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(HumanName) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Use) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Text) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Family) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Given) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Prefix) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Suffix) });
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
