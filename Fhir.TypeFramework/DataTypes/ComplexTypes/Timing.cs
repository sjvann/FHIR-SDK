using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.TypeFramework.Bases;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>FHIR R5 Datatype Timing。</summary>
public class Timing : ComplexTypeBase
{
    [JsonPropertyName("event")] public List<FhirDateTime>? Event { get; set; }
    [JsonPropertyName("repeat")] public TimingRepeatComponent? Repeat { get; set; }
    [JsonPropertyName("code")] public CodeableConcept? Code { get; set; }

    protected override void DeepCopyInternal(ComplexTypeBase copy)
    {
        var c = (Timing)copy;
        c.Event = DeepCopyList(Event);
        c.Repeat = Repeat?.DeepCopy() as TimingRepeatComponent;
        c.Code = Code?.DeepCopy() as CodeableConcept;
    }

    protected override bool IsExactlyInternal(ComplexTypeBase other)
    {
        var o = (Timing)other;
        return AreListsEqual(Event, o.Event)
               && (Repeat == null && o.Repeat == null
                   || Repeat != null && o.Repeat != null && Repeat.IsExactly(o.Repeat))
               && ValueEquals(Code, o.Code);
    }

    protected override IEnumerable<ValidationResult> ValidateInternal(ValidationContext validationContext)
    {
        foreach (var r in ValidateList(Event, validationContext)) yield return r;
        if (Repeat != null)
        {
            foreach (var r in Repeat.Validate(new ValidationContext(Repeat))) yield return r;
        }

        foreach (var r in ValidateItem(Code, validationContext)) yield return r;
    }
}

/// <summary>Timing.repeat 具體 backbone，不得使用抽象 <see cref="BackboneElement"/>。</summary>
public sealed class TimingRepeatComponent : BackboneElement
{
    [JsonPropertyName("boundsDuration")] public Duration? BoundsDuration { get; set; }
    [JsonPropertyName("boundsRange")] public global::Fhir.TypeFramework.DataTypes.Range? BoundsRange { get; set; }
    [JsonPropertyName("boundsPeriod")] public Period? BoundsPeriod { get; set; }
    [JsonPropertyName("count")] public FhirPositiveInt? Count { get; set; }
    [JsonPropertyName("countMax")] public FhirPositiveInt? CountMax { get; set; }
    [JsonPropertyName("duration")] public FhirDecimal? Duration { get; set; }
    [JsonPropertyName("durationMax")] public FhirDecimal? DurationMax { get; set; }
    [JsonPropertyName("durationUnit")] public FhirCode? DurationUnit { get; set; }
    [JsonPropertyName("frequency")] public FhirPositiveInt? Frequency { get; set; }
    [JsonPropertyName("frequencyMax")] public FhirPositiveInt? FrequencyMax { get; set; }
    [JsonPropertyName("period")] public FhirDecimal? Period { get; set; }
    [JsonPropertyName("periodMax")] public FhirDecimal? PeriodMax { get; set; }
    [JsonPropertyName("periodUnit")] public FhirCode? PeriodUnit { get; set; }
    [JsonPropertyName("dayOfWeek")] public List<FhirCode>? DayOfWeek { get; set; }
    [JsonPropertyName("timeOfDay")] public List<FhirTime>? TimeOfDay { get; set; }
    [JsonPropertyName("when")] public List<FhirCode>? When { get; set; }
    [JsonPropertyName("offset")] public FhirUnsignedInt? Offset { get; set; }

    public override Base DeepCopy()
    {
        var copy = (TimingRepeatComponent)base.DeepCopy();
        copy.BoundsDuration = BoundsDuration?.DeepCopy() as Duration;
        copy.BoundsRange = BoundsRange?.DeepCopy() as global::Fhir.TypeFramework.DataTypes.Range;
        copy.BoundsPeriod = BoundsPeriod?.DeepCopy() as Period;
        copy.Count = Count?.DeepCopy() as FhirPositiveInt;
        copy.CountMax = CountMax?.DeepCopy() as FhirPositiveInt;
        copy.Duration = Duration?.DeepCopy() as FhirDecimal;
        copy.DurationMax = DurationMax?.DeepCopy() as FhirDecimal;
        copy.DurationUnit = DurationUnit?.DeepCopy() as FhirCode;
        copy.Frequency = Frequency?.DeepCopy() as FhirPositiveInt;
        copy.FrequencyMax = FrequencyMax?.DeepCopy() as FhirPositiveInt;
        copy.Period = Period?.DeepCopy() as FhirDecimal;
        copy.PeriodMax = PeriodMax?.DeepCopy() as FhirDecimal;
        copy.PeriodUnit = PeriodUnit?.DeepCopy() as FhirCode;
        copy.DayOfWeek = DayOfWeek?.Select(d => (d.DeepCopy() as FhirCode)!).ToList();
        copy.TimeOfDay = TimeOfDay?.Select(t => (t.DeepCopy() as FhirTime)!).ToList();
        copy.When = When?.Select(w => (w.DeepCopy() as FhirCode)!).ToList();
        copy.Offset = Offset?.DeepCopy() as FhirUnsignedInt;
        return copy;
    }
}
