// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// ProductShelfLife Type: The shelf-life and storage information for a medicinal product item or
/// container can be described using this class.
/// </summary>
public class ProductShelfLife : Element
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
    /// May be used to represent additional information that is not part of the basic definition of the
    /// element and that modifies the understanding of the element in which it is contained and/or the
    /// understanding of the containing element&apos;s descendants. Usually modifier elements provide
    /// negation or qualification. To make the use of extensions safe and managable, there is a strict set
    /// of governance applied to the definition and use of extensions. Though any implementer can define an
    /// extension, there is a set of requirements that SHALL be met as part of the definition of the
    /// extension. Applications processing a resource are required to check for modifier extensions.
    /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource
    /// (including cannot change the meaning of modifierExtension itself).
    /// </summary>
    [FhirElement("modifierExtension", Order = 12)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("modifierExtension")]
    public List<Extension>? ModifierExtension { get; set; }

    /// <summary>
    /// This describes the shelf life, taking into account various scenarios such as shelf life of the
    /// packaged Medicinal Product itself, shelf life after transformation where necessary and shelf life
    /// after the first opening of a bottle, etc. The shelf life type shall be specified using an
    /// appropriate controlled vocabulary The controlled term and the controlled term identifier shall be
    /// specified.
    /// </summary>
    [FhirElement("type", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName("type")]
    public CodeableConcept Type { get; set; }

    /// <summary>
    /// The shelf life time period can be specified using a numerical value for the period of time and its
    /// unit of time measurement The unit of measurement shall be specified in accordance with ISO 11240 and
    /// the resulting terminology The symbol and the symbol identifier shall be used. (as Duration)
    /// </summary>
    [FhirElement("perioddurationUnknown", Order = 14)]
    [Cardinality(0, 1)]
    [ChoiceType("periodduration", "unknown")]
    [JsonPropertyName("perioddurationUnknown")]
    public Duration PeriodDuration { get; set; }

    /// <summary>
    /// The shelf life time period can be specified using a numerical value for the period of time and its
    /// unit of time measurement The unit of measurement shall be specified in accordance with ISO 11240 and
    /// the resulting terminology The symbol and the symbol identifier shall be used. (as string)
    /// </summary>
    [FhirElement("periodString", Order = 15)]
    [Cardinality(0, 1)]
    [ChoiceType("period", "string")]
    [JsonPropertyName("periodString")]
    public FhirString? PeriodString { get; set; }

    /// <summary>
    /// Special precautions for storage, if any, can be specified using an appropriate controlled vocabulary
    /// The controlled term and the controlled term identifier shall be specified.
    /// </summary>
    [FhirElement("specialPrecautionsForStorage", Order = 16)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("specialPrecautionsForStorage")]
    public List<CodeableConcept>? SpecialPrecautionsForStorage { get; set; }

    /// <summary>
    /// Validates choice type constraints
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Choice Type validation for periodduration[x]
        var perioddurationProperties = new[] { nameof(PeriodDuration) };
        var perioddurationSetCount = perioddurationProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (perioddurationSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PeriodDuration may be specified",
                new[] { nameof(PeriodDuration) });
        }

        // Choice Type validation for period[x]
        var periodProperties = new[] { nameof(PeriodString) };
        var periodSetCount = periodProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (periodSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PeriodString may be specified",
                new[] { nameof(PeriodString) });
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
        // Validate ProductShelfLife cardinality
        var productshelflifeCount = ProductShelfLife?.Count ?? 0;
        if (productshelflifeCount < 0)
        {
            yield return new ValidationResult("Element 'ProductShelfLife' cardinality must be 0..*", new[] { nameof(ProductShelfLife) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ProductShelfLife.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'ProductShelfLife.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate SpecialPrecautionsForStorage cardinality
        var specialprecautionsforstorageCount = SpecialPrecautionsForStorage?.Count ?? 0;
        if (specialprecautionsforstorageCount < 0)
        {
            yield return new ValidationResult("Element 'ProductShelfLife.specialPrecautionsForStorage' cardinality must be 0..*", new[] { nameof(SpecialPrecautionsForStorage) });
        }

        // Constraint validation
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ProductShelfLife) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ModifierExtension) });
        // }
        // Constraint: ext-1
        // Expression: extension.exists() != value.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("extension.exists() != value.exists()"))
        // {
        //     yield return new ValidationResult("Must have either extensions or value[x], not both", new[] { nameof(ModifierExtension) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Period) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(SpecialPrecautionsForStorage) });
        // }
    }

}
