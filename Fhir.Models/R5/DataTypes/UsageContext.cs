// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// UsageContext Type: Specifies clinical/business/etc. metadata that can be used to retrieve, index
/// and/or categorize an artifact. This metadata can either be specific to the applicable population
/// (e.g., age category, DRG) or the specific context of care (e.g., venue, care setting, provider of
/// care).
/// </summary>
public class UsageContext : DataType
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
    /// A code that identifies the type of context being specified by this usage context.
    /// </summary>
    [FhirElement("code", Order = 12)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("code")]
    public Coding Code { get; set; }

    /// <summary>
    /// A value that defines the context specified in this context of use. The interpretation of the value
    /// is defined by the code. (as CodeableConcept)
    /// </summary>
    [FhirElement("valueCodeableConcept", Order = 13)]
    [Cardinality(1, 1)]
    [ChoiceType("value", "codeableConcept")]
    [Required]
    [JsonPropertyName("valueCodeableConcept")]
    public CodeableConcept ValueCodeableConcept { get; set; }

    /// <summary>
    /// A value that defines the context specified in this context of use. The interpretation of the value
    /// is defined by the code. (as Quantity)
    /// </summary>
    [FhirElement("valueQuantity", Order = 14)]
    [Cardinality(1, 1)]
    [ChoiceType("value", "quantity")]
    [Required]
    [JsonPropertyName("valueQuantity")]
    public Quantity ValueQuantity { get; set; }

    /// <summary>
    /// A value that defines the context specified in this context of use. The interpretation of the value
    /// is defined by the code. (as Range)
    /// </summary>
    [FhirElement("valueRange", Order = 15)]
    [Cardinality(1, 1)]
    [ChoiceType("value", "range")]
    [Required]
    [JsonPropertyName("valueRange")]
    public Range ValueRange { get; set; }

    /// <summary>
    /// A value that defines the context specified in this context of use. The interpretation of the value
    /// is defined by the code. (as Reference)
    /// </summary>
    [FhirElement("valueReference", Order = 16)]
    [Cardinality(1, 1)]
    [ChoiceType("value", "reference")]
    [Required]
    [JsonPropertyName("valueReference")]
    public Reference<PlanDefinition> ValueReference { get; set; }

    /// <summary>
    /// Validates choice type constraints
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Choice Type validation for value[x]
        var valueProperties = new[] { nameof(ValueCodeableConcept), nameof(ValueQuantity), nameof(ValueRange), nameof(ValueReference) };
        var valueSetCount = valueProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valueSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueCodeableConcept, ValueQuantity, ValueRange, ValueReference may be specified",
                new[] { nameof(ValueCodeableConcept), nameof(ValueQuantity), nameof(ValueRange), nameof(ValueReference) });
        }

    }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate UsageContext cardinality
        var usagecontextCount = UsageContext?.Count ?? 0;
        if (usagecontextCount < 0)
        {
            yield return new ValidationResult("Element 'UsageContext' cardinality must be 0..*", new[] { nameof(UsageContext) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'UsageContext.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        if (Code == null)
        {
            yield return new ValidationResult("Element 'UsageContext.code' cardinality must be 1..1", new[] { nameof(Code) });
        }
        if (Value == null)
        {
            yield return new ValidationResult("Element 'UsageContext.value[x]' cardinality must be 1..1", new[] { nameof(Value) });
        }

        // ValueSet binding validation
        // Validate Code ValueSet binding
        if (Code != null)
        {
            // TODO: Implement ValueSet validation for http://terminology.hl7.org/ValueSet/usage-context-type
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(UsageContext) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Code) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Value) });
        // }
    }

}
