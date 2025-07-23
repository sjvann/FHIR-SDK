// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// ParameterDefinition Type: The parameters to the module. This collection specifies both the input and
/// output parameters. Input parameters are provided by the caller as part of the $evaluate operation.
/// Output parameters are included in the GuidanceResponse.
/// </summary>
public class ParameterDefinition : DataType
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
    /// The name of the parameter used to allow access to the value of the parameter in evaluation contexts.
    /// </summary>
    [FhirElement("name", Order = 12)]
    [Cardinality(0, 1)]
    [JsonPropertyName("name")]
    public FhirCode? Name { get; set; }

    /// <summary>
    /// Whether the parameter is input or output for the module.
    /// </summary>
    [FhirElement("use", Order = 13)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("use")]
    public FhirCode Use { get; set; }

    /// <summary>
    /// The minimum number of times this parameter SHALL appear in the request or response.
    /// </summary>
    [FhirElement("min", Order = 14)]
    [Cardinality(0, 1)]
    [JsonPropertyName("min")]
    public FhirInteger? Min { get; set; }

    /// <summary>
    /// The maximum number of times this element is permitted to appear in the request or response.
    /// </summary>
    [FhirElement("max", Order = 15)]
    [Cardinality(0, 1)]
    [JsonPropertyName("max")]
    public FhirString? Max { get; set; }

    /// <summary>
    /// A brief discussion of what the parameter is for and how it is used by the module.
    /// </summary>
    [FhirElement("documentation", Order = 16)]
    [Cardinality(0, 1)]
    [JsonPropertyName("documentation")]
    public FhirString? Documentation { get; set; }

    /// <summary>
    /// The type of the parameter.
    /// </summary>
    [FhirElement("type", Order = 17)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("type")]
    public FhirCode Type { get; set; }

    /// <summary>
    /// If specified, this indicates a profile that the input data must conform to, or that the output data
    /// will conform to.
    /// </summary>
    [FhirElement("profile", Order = 18)]
    [Cardinality(0, 1)]
    [JsonPropertyName("profile")]
    public FhirCanonical? Profile { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate ParameterDefinition cardinality
        var parameterdefinitionCount = ParameterDefinition?.Count ?? 0;
        if (parameterdefinitionCount < 0)
        {
            yield return new ValidationResult("Element 'ParameterDefinition' cardinality must be 0..*", new[] { nameof(ParameterDefinition) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ParameterDefinition.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        if (Use == null)
        {
            yield return new ValidationResult("Element 'ParameterDefinition.use' cardinality must be 1..1", new[] { nameof(Use) });
        }
        if (Type == null)
        {
            yield return new ValidationResult("Element 'ParameterDefinition.type' cardinality must be 1..1", new[] { nameof(Type) });
        }

        // ValueSet binding validation
        // Validate Use ValueSet binding
        if (Use != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/operation-parameter-use|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Type ValueSet binding
        if (Type != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/fhir-types|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ParameterDefinition) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Name) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Min) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Max) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Documentation) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Profile) });
        // }
    }

}
