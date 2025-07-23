// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// TriggerDefinition Type: A description of a triggering event. Triggering events can be named events,
/// data events, or periodic, as determined by the type element.
/// </summary>
public class TriggerDefinition : DataType
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
    /// The type of triggering event.
    /// </summary>
    [FhirElement("type", Order = 12)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("type")]
    public FhirCode Type { get; set; }

    /// <summary>
    /// A formal name for the event. This may be an absolute URI that identifies the event formally (e.g.
    /// from a trigger registry), or a simple relative URI that identifies the event in a local context.
    /// </summary>
    [FhirElement("name", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName("name")]
    public FhirString? Name { get; set; }

    /// <summary>
    /// A code that identifies the event.
    /// </summary>
    [FhirElement("code", Order = 14)]
    [Cardinality(0, 1)]
    [JsonPropertyName("code")]
    public CodeableConcept Code { get; set; }

    /// <summary>
    /// A reference to a SubscriptionTopic resource that defines the event. If this element is provided, no
    /// other information about the trigger definition may be supplied.
    /// </summary>
    [FhirElement("subscriptionTopic", Order = 15)]
    [Cardinality(0, 1)]
    [JsonPropertyName("subscriptionTopic")]
    public FhirCanonical? SubscriptionTopic { get; set; }

    /// <summary>
    /// The timing of the event (if this is a periodic trigger). (as Timing)
    /// </summary>
    [FhirElement("timingTiming", Order = 16)]
    [Cardinality(0, 1)]
    [ChoiceType("timing", "timing")]
    [JsonPropertyName("timingTiming")]
    public Timing TimingTiming { get; set; }

    /// <summary>
    /// The timing of the event (if this is a periodic trigger). (as Reference)
    /// </summary>
    [FhirElement("timingReference", Order = 17)]
    [Cardinality(0, 1)]
    [ChoiceType("timing", "reference")]
    [JsonPropertyName("timingReference")]
    public Reference<Schedule> TimingReference { get; set; }

    /// <summary>
    /// The timing of the event (if this is a periodic trigger). (as date)
    /// </summary>
    [FhirElement("timingdateUnknown", Order = 18)]
    [Cardinality(0, 1)]
    [ChoiceType("timingdate", "unknown")]
    [JsonPropertyName("timingdateUnknown")]
    public FhirDate? TimingDate { get; set; }

    /// <summary>
    /// The timing of the event (if this is a periodic trigger). (as dateTime)
    /// </summary>
    [FhirElement("timingDateTime", Order = 19)]
    [Cardinality(0, 1)]
    [ChoiceType("timing", "dateTime")]
    [JsonPropertyName("timingDateTime")]
    public FhirDateTime? TimingDateTime { get; set; }

    /// <summary>
    /// The triggering data of the event (if this is a data trigger). If more than one data is requirement
    /// is specified, then all the data requirements must be true.
    /// </summary>
    [FhirElement("data", Order = 20)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("data")]
    public List<DataRequirement>? Data { get; set; }

    /// <summary>
    /// A boolean-valued expression that is evaluated in the context of the container of the trigger
    /// definition and returns whether or not the trigger fires.
    /// </summary>
    [FhirElement("condition", Order = 21)]
    [Cardinality(0, 1)]
    [JsonPropertyName("condition")]
    public Expression Condition { get; set; }

    /// <summary>
    /// Validates choice type constraints
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Choice Type validation for timing[x]
        var timingProperties = new[] { nameof(TimingTiming), nameof(TimingReference), nameof(TimingDateTime) };
        var timingSetCount = timingProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (timingSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of TimingTiming, TimingReference, TimingDateTime may be specified",
                new[] { nameof(TimingTiming), nameof(TimingReference), nameof(TimingDateTime) });
        }

        // Choice Type validation for timingdate[x]
        var timingdateProperties = new[] { nameof(TimingDate) };
        var timingdateSetCount = timingdateProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (timingdateSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of TimingDate may be specified",
                new[] { nameof(TimingDate) });
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
        // Validate TriggerDefinition cardinality
        var triggerdefinitionCount = TriggerDefinition?.Count ?? 0;
        if (triggerdefinitionCount < 0)
        {
            yield return new ValidationResult("Element 'TriggerDefinition' cardinality must be 0..*", new[] { nameof(TriggerDefinition) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'TriggerDefinition.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        if (Type == null)
        {
            yield return new ValidationResult("Element 'TriggerDefinition.type' cardinality must be 1..1", new[] { nameof(Type) });
        }
        // Validate Data cardinality
        var dataCount = Data?.Count ?? 0;
        if (dataCount < 0)
        {
            yield return new ValidationResult("Element 'TriggerDefinition.data' cardinality must be 0..*", new[] { nameof(Data) });
        }

        // ValueSet binding validation
        // Validate Type ValueSet binding
        if (Type != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/trigger-type|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(TriggerDefinition) });
        // }
        // Constraint: trd-1
        // Expression: data.empty() or timing.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("data.empty() or timing.empty()"))
        // {
        //     yield return new ValidationResult("Either timing, or a data requirement, but not both", new[] { nameof(TriggerDefinition) });
        // }
        // Constraint: trd-2
        // Expression: condition.exists() implies data.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("condition.exists() implies data.exists()"))
        // {
        //     yield return new ValidationResult("A condition only if there is a data requirement", new[] { nameof(TriggerDefinition) });
        // }
        // Constraint: trd-3
        // Expression: (type = 'named-event' implies name.exists()) and (type = 'periodic' implies timing.exists()) and (type.startsWith('data-') implies data.exists())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("(type = 'named-event' implies name.exists()) and (type = 'periodic' implies timing.exists()) and (type.startsWith('data-') implies data.exists())"))
        // {
        //     yield return new ValidationResult("A named event requires a name, a periodic event requires timing, and a data event requires data", new[] { nameof(TriggerDefinition) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Name) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(SubscriptionTopic) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Data) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Condition) });
        // }
    }

}
