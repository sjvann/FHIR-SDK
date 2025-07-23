// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// MarketingStatus Type: The marketing status describes the date when a medicinal product is actually
/// put on the market or the date as of which it is no longer available.
/// </summary>
public class MarketingStatus : Element
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
    /// The country in which the marketing authorization has been granted shall be specified It should be
    /// specified using the ISO 3166 ‑ 1 alpha-2 code elements.
    /// </summary>
    [FhirElement("country", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName("country")]
    public CodeableConcept Country { get; set; }

    /// <summary>
    /// Where a Medicines Regulatory Agency has granted a marketing authorization for which specific
    /// provisions within a jurisdiction apply, the jurisdiction can be specified using an appropriate
    /// controlled terminology The controlled term and the controlled term identifier shall be specified.
    /// </summary>
    [FhirElement("jurisdiction", Order = 14)]
    [Cardinality(0, 1)]
    [JsonPropertyName("jurisdiction")]
    public CodeableConcept Jurisdiction { get; set; }

    /// <summary>
    /// This attribute provides information on the status of the marketing of the medicinal product See
    /// ISO/TS 20443 for more information and examples.
    /// </summary>
    [FhirElement("status", Order = 15)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("status")]
    public CodeableConcept Status { get; set; }

    /// <summary>
    /// The date when the Medicinal Product is placed on the market by the Marketing Authorization Holder
    /// (or where applicable, the manufacturer/distributor) in a country and/or jurisdiction shall be
    /// provided A complete date consisting of day, month and year shall be specified using the ISO 8601
    /// date format NOTE “Placed on the market” refers to the release of the Medicinal Product into the
    /// distribution chain.
    /// </summary>
    [FhirElement("dateRange", Order = 16)]
    [Cardinality(0, 1)]
    [JsonPropertyName("dateRange")]
    public Period DateRange { get; set; }

    /// <summary>
    /// The date when the Medicinal Product is placed on the market by the Marketing Authorization Holder
    /// (or where applicable, the manufacturer/distributor) in a country and/or jurisdiction shall be
    /// provided A complete date consisting of day, month and year shall be specified using the ISO 8601
    /// date format NOTE “Placed on the market” refers to the release of the Medicinal Product into the
    /// distribution chain.
    /// </summary>
    [FhirElement("restoreDate", Order = 17)]
    [Cardinality(0, 1)]
    [JsonPropertyName("restoreDate")]
    public FhirDateTime? RestoreDate { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate MarketingStatus cardinality
        var marketingstatusCount = MarketingStatus?.Count ?? 0;
        if (marketingstatusCount < 0)
        {
            yield return new ValidationResult("Element 'MarketingStatus' cardinality must be 0..*", new[] { nameof(MarketingStatus) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'MarketingStatus.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'MarketingStatus.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Status == null)
        {
            yield return new ValidationResult("Element 'MarketingStatus.status' cardinality must be 1..1", new[] { nameof(Status) });
        }

        // Constraint validation
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(MarketingStatus) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Country) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Jurisdiction) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Status) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(DateRange) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(RestoreDate) });
        // }
    }

}
