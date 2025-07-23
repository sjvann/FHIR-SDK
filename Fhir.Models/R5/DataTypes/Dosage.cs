// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Dosage Type: Indicates how the medication is/was taken or should be taken by the patient.
/// </summary>
public class Dosage : Element
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
    /// Indicates the order in which the dosage instructions should be applied or interpreted.
    /// </summary>
    [FhirElement("sequence", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName("sequence")]
    public FhirInteger? Sequence { get; set; }

    /// <summary>
    /// Free text dosage instructions e.g. SIG.
    /// </summary>
    [FhirElement("text", Order = 14)]
    [Cardinality(0, 1)]
    [JsonPropertyName("text")]
    public FhirString? Text { get; set; }

    /// <summary>
    /// Supplemental instructions to the patient on how to take the medication (e.g. &quot;with meals&quot;
    /// or&quot;take half to one hour before food&quot;) or warnings for the patient about the medication
    /// (e.g. &quot;may cause drowsiness&quot; or &quot;avoid exposure of skin to direct sunlight or
    /// sunlamps&quot;).
    /// </summary>
    [FhirElement("additionalInstruction", Order = 15)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("additionalInstruction")]
    public List<CodeableConcept>? AdditionalInstruction { get; set; }

    /// <summary>
    /// Instructions in terms that are understood by the patient or consumer.
    /// </summary>
    [FhirElement("patientInstruction", Order = 16)]
    [Cardinality(0, 1)]
    [JsonPropertyName("patientInstruction")]
    public FhirString? PatientInstruction { get; set; }

    /// <summary>
    /// When medication should be administered.
    /// </summary>
    [FhirElement("timing", Order = 17)]
    [Cardinality(0, 1)]
    [JsonPropertyName("timing")]
    public Timing Timing { get; set; }

    /// <summary>
    /// Indicates whether the Medication is only taken when needed within a specific dosing schedule
    /// (Boolean option).
    /// </summary>
    [FhirElement("asNeeded", Order = 18)]
    [Cardinality(0, 1)]
    [JsonPropertyName("asNeeded")]
    public FhirBoolean? AsNeeded { get; set; }

    /// <summary>
    /// Indicates whether the Medication is only taken based on a precondition for taking the Medication
    /// (CodeableConcept).
    /// </summary>
    [FhirElement("asNeededFor", Order = 19)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("asNeededFor")]
    public List<CodeableConcept>? AsNeededFor { get; set; }

    /// <summary>
    /// Body site to administer to.
    /// </summary>
    [FhirElement("site", Order = 20)]
    [Cardinality(0, 1)]
    [JsonPropertyName("site")]
    public CodeableConcept Site { get; set; }

    /// <summary>
    /// How drug should enter body.
    /// </summary>
    [FhirElement("route", Order = 21)]
    [Cardinality(0, 1)]
    [JsonPropertyName("route")]
    public CodeableConcept Route { get; set; }

    /// <summary>
    /// Technique for administering medication.
    /// </summary>
    [FhirElement("method", Order = 22)]
    [Cardinality(0, 1)]
    [JsonPropertyName("method")]
    public CodeableConcept Method { get; set; }

    /// <summary>
    /// Depending on the resource,this is the amount of medication administered, to be administered or
    /// typical amount to be administered.
    /// </summary>
    [FhirElement("doseAndRate", Order = 23)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("doseAndRate")]
    public List<Element>? DoseAndRate { get; set; }

    /// <summary>
    /// Upper limit on medication per unit of time.
    /// </summary>
    [FhirElement("maxDosePerPeriod", Order = 24)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("maxDosePerPeriod")]
    public List<Ratio>? MaxDosePerPeriod { get; set; }

    /// <summary>
    /// Upper limit on medication per administration.
    /// </summary>
    [FhirElement("maxDosePerAdministration", Order = 25)]
    [Cardinality(0, 1)]
    [JsonPropertyName("maxDosePerAdministration")]
    public Quantity MaxDosePerAdministration { get; set; }

    /// <summary>
    /// Upper limit on medication per lifetime of the patient.
    /// </summary>
    [FhirElement("maxDosePerLifetime", Order = 26)]
    [Cardinality(0, 1)]
    [JsonPropertyName("maxDosePerLifetime")]
    public Quantity MaxDosePerLifetime { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate Dosage cardinality
        var dosageCount = Dosage?.Count ?? 0;
        if (dosageCount < 0)
        {
            yield return new ValidationResult("Element 'Dosage' cardinality must be 0..*", new[] { nameof(Dosage) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Dosage.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Dosage.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate AdditionalInstruction cardinality
        var additionalinstructionCount = AdditionalInstruction?.Count ?? 0;
        if (additionalinstructionCount < 0)
        {
            yield return new ValidationResult("Element 'Dosage.additionalInstruction' cardinality must be 0..*", new[] { nameof(AdditionalInstruction) });
        }
        // Validate AsNeededFor cardinality
        var asneededforCount = AsNeededFor?.Count ?? 0;
        if (asneededforCount < 0)
        {
            yield return new ValidationResult("Element 'Dosage.asNeededFor' cardinality must be 0..*", new[] { nameof(AsNeededFor) });
        }
        // Validate DoseAndRate cardinality
        var doseandrateCount = DoseAndRate?.Count ?? 0;
        if (doseandrateCount < 0)
        {
            yield return new ValidationResult("Element 'Dosage.doseAndRate' cardinality must be 0..*", new[] { nameof(DoseAndRate) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Dosage.doseAndRate.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate MaxDosePerPeriod cardinality
        var maxdoseperperiodCount = MaxDosePerPeriod?.Count ?? 0;
        if (maxdoseperperiodCount < 0)
        {
            yield return new ValidationResult("Element 'Dosage.maxDosePerPeriod' cardinality must be 0..*", new[] { nameof(MaxDosePerPeriod) });
        }

        // Constraint validation
        // Constraint: dos-1
        // Expression: asNeededFor.empty() or asNeeded.empty() or asNeeded
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("asNeededFor.empty() or asNeeded.empty() or asNeeded"))
        // {
        //     yield return new ValidationResult("AsNeededFor can only be set if AsNeeded is empty or true", new[] { nameof(Dosage) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Dosage) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Sequence) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(AdditionalInstruction) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(PatientInstruction) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Timing) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(AsNeeded) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(AsNeededFor) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Site) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Route) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Method) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(DoseAndRate) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Dose) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Rate) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(MaxDosePerPeriod) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(MaxDosePerAdministration) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(MaxDosePerLifetime) });
        // }
    }

}
