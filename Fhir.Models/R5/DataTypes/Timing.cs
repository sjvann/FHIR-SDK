// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Timing Type: Specifies an event that may occur multiple times. Timing schedules are used to record
/// when things are planned, expected or requested to occur. The most common usage is in dosage
/// instructions for medications. They are also used when planning care of various kinds, and may be
/// used for reporting the schedule to which past regular activities were carried out.
/// </summary>
public class Timing : Element
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
    /// Identifies specific times when the event occurs.
    /// </summary>
    [FhirElement("event", Order = 13)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("event")]
    public List<FhirDateTime>? Event { get; set; }

    /// <summary>
    /// A set of rules that describe when the event is scheduled.
    /// </summary>
    [FhirElement("repeat", Order = 14)]
    [Cardinality(0, 1)]
    [JsonPropertyName("repeat")]
    public Element Repeat { get; set; }

    /// <summary>
    /// A code for the timing schedule (or just text in code.text). Some codes such as BID are ubiquitous,
    /// but many institutions define their own additional codes. If a code is provided, the code is
    /// understood to be a complete statement of whatever is specified in the structured timing data, and
    /// either the code or the data may be used to interpret the Timing, with the exception that
    /// .repeat.bounds still applies over the code (and is not contained in the code).
    /// </summary>
    [FhirElement("code", Order = 15)]
    [Cardinality(0, 1)]
    [JsonPropertyName("code")]
    public CodeableConcept Code { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate Timing cardinality
        var timingCount = Timing?.Count ?? 0;
        if (timingCount < 0)
        {
            yield return new ValidationResult("Element 'Timing' cardinality must be 0..*", new[] { nameof(Timing) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Timing.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Timing.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Event cardinality
        var eventCount = Event?.Count ?? 0;
        if (eventCount < 0)
        {
            yield return new ValidationResult("Element 'Timing.event' cardinality must be 0..*", new[] { nameof(Event) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Timing.repeat.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate DayOfWeek cardinality
        var dayofweekCount = DayOfWeek?.Count ?? 0;
        if (dayofweekCount < 0)
        {
            yield return new ValidationResult("Element 'Timing.repeat.dayOfWeek' cardinality must be 0..*", new[] { nameof(DayOfWeek) });
        }
        // Validate TimeOfDay cardinality
        var timeofdayCount = TimeOfDay?.Count ?? 0;
        if (timeofdayCount < 0)
        {
            yield return new ValidationResult("Element 'Timing.repeat.timeOfDay' cardinality must be 0..*", new[] { nameof(TimeOfDay) });
        }
        // Validate When cardinality
        var whenCount = When?.Count ?? 0;
        if (whenCount < 0)
        {
            yield return new ValidationResult("Element 'Timing.repeat.when' cardinality must be 0..*", new[] { nameof(When) });
        }

        // ValueSet binding validation
        // Validate DurationUnit ValueSet binding
        if (DurationUnit != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/units-of-time|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate PeriodUnit ValueSet binding
        if (PeriodUnit != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/units-of-time|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate DayOfWeek ValueSet binding
        if (DayOfWeek != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/days-of-week|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate When ValueSet binding
        if (When != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/event-timing|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Event) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Repeat) });
        // }
        // Constraint: tim-1
        // Expression: duration.empty() or durationUnit.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("duration.empty() or durationUnit.exists()"))
        // {
        //     yield return new ValidationResult("if there's a duration, there needs to be duration units", new[] { nameof(Repeat) });
        // }
        // Constraint: tim-2
        // Expression: period.empty() or periodUnit.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("period.empty() or periodUnit.exists()"))
        // {
        //     yield return new ValidationResult("if there's a period, there needs to be period units", new[] { nameof(Repeat) });
        // }
        // Constraint: tim-4
        // Expression: duration.exists() implies duration >= 0
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("duration.exists() implies duration >= 0"))
        // {
        //     yield return new ValidationResult("duration SHALL be a non-negative value", new[] { nameof(Repeat) });
        // }
        // Constraint: tim-5
        // Expression: period.exists() implies period >= 0
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("period.exists() implies period >= 0"))
        // {
        //     yield return new ValidationResult("period SHALL be a non-negative value", new[] { nameof(Repeat) });
        // }
        // Constraint: tim-6
        // Expression: periodMax.empty() or period.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("periodMax.empty() or period.exists()"))
        // {
        //     yield return new ValidationResult("If there's a periodMax, there must be a period", new[] { nameof(Repeat) });
        // }
        // Constraint: tim-7
        // Expression: durationMax.empty() or duration.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("durationMax.empty() or duration.exists()"))
        // {
        //     yield return new ValidationResult("If there's a durationMax, there must be a duration", new[] { nameof(Repeat) });
        // }
        // Constraint: tim-8
        // Expression: countMax.empty() or count.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("countMax.empty() or count.exists()"))
        // {
        //     yield return new ValidationResult("If there's a countMax, there must be a count", new[] { nameof(Repeat) });
        // }
        // Constraint: tim-9
        // Expression: offset.empty() or (when.exists() and when.select($this in ('C' | 'CM' | 'CD' | 'CV')).allFalse())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("offset.empty() or (when.exists() and when.select($this in ('C' | 'CM' | 'CD' | 'CV')).allFalse())"))
        // {
        //     yield return new ValidationResult("If there's an offset, there must be a when (and not C, CM, CD, CV)", new[] { nameof(Repeat) });
        // }
        // Constraint: tim-10
        // Expression: timeOfDay.empty() or when.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("timeOfDay.empty() or when.empty()"))
        // {
        //     yield return new ValidationResult("If there's a timeOfDay, there cannot be a when, or vice versa", new[] { nameof(Repeat) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Bounds) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Count) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(CountMax) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Duration) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(DurationMax) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(DurationUnit) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Frequency) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(FrequencyMax) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(PeriodMax) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(PeriodUnit) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(DayOfWeek) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(TimeOfDay) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(When) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Offset) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Code) });
        // }
    }

}
