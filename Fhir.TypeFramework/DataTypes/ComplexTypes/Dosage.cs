using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.TypeFramework.Bases;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>FHIR R5 Datatype Dosage。</summary>
public class Dosage : ComplexTypeBase
{
    [JsonPropertyName("sequence")] public FhirInteger? Sequence { get; set; }
    [JsonPropertyName("text")] public FhirString? Text { get; set; }
    [JsonPropertyName("additionalInstruction")] public List<CodeableConcept>? AdditionalInstruction { get; set; }
    [JsonPropertyName("patientInstruction")] public FhirString? PatientInstruction { get; set; }
    [JsonPropertyName("timing")] public Timing? Timing { get; set; }
    [JsonPropertyName("asNeededBoolean")] public FhirBoolean? AsNeededBoolean { get; set; }
    [JsonPropertyName("asNeededCodeableConcept")] public CodeableConcept? AsNeededCodeableConcept { get; set; }
    [JsonPropertyName("site")] public CodeableConcept? Site { get; set; }
    [JsonPropertyName("route")] public CodeableConcept? Route { get; set; }
    [JsonPropertyName("method")] public CodeableConcept? Method { get; set; }
    [JsonPropertyName("doseAndRate")] public List<DoseAndRateComponent>? DoseAndRate { get; set; }
    [JsonPropertyName("maxDosePerPeriod")] public List<Ratio>? MaxDosePerPeriod { get; set; }
    [JsonPropertyName("maxDosePerAdministration")] public Quantity? MaxDosePerAdministration { get; set; }
    [JsonPropertyName("maxDosePerLifetime")] public Quantity? MaxDosePerLifetime { get; set; }

    protected override void DeepCopyInternal(ComplexTypeBase copy)
    {
        var c = (Dosage)copy;
        c.Sequence = Sequence?.DeepCopy() as FhirInteger;
        c.Text = Text?.DeepCopy() as FhirString;
        c.AdditionalInstruction = DeepCopyList(AdditionalInstruction);
        c.PatientInstruction = PatientInstruction?.DeepCopy() as FhirString;
        c.Timing = Timing?.DeepCopy() as Timing;
        c.AsNeededBoolean = AsNeededBoolean?.DeepCopy() as FhirBoolean;
        c.AsNeededCodeableConcept = AsNeededCodeableConcept?.DeepCopy() as CodeableConcept;
        c.Site = Site?.DeepCopy() as CodeableConcept;
        c.Route = Route?.DeepCopy() as CodeableConcept;
        c.Method = Method?.DeepCopy() as CodeableConcept;
        c.DoseAndRate = DeepCopyList(DoseAndRate);
        c.MaxDosePerPeriod = DeepCopyList(MaxDosePerPeriod);
        c.MaxDosePerAdministration = MaxDosePerAdministration?.DeepCopy() as Quantity;
        c.MaxDosePerLifetime = MaxDosePerLifetime?.DeepCopy() as Quantity;
    }

    protected override bool IsExactlyInternal(ComplexTypeBase other)
    {
        var o = (Dosage)other;
        return ValueEquals(Sequence, o.Sequence)
               && ValueEquals(Text, o.Text)
               && AreListsEqual(AdditionalInstruction, o.AdditionalInstruction)
               && ValueEquals(PatientInstruction, o.PatientInstruction)
               && ValueEquals(Timing, o.Timing)
               && ValueEquals(AsNeededBoolean, o.AsNeededBoolean)
               && ValueEquals(AsNeededCodeableConcept, o.AsNeededCodeableConcept)
               && ValueEquals(Site, o.Site)
               && ValueEquals(Route, o.Route)
               && ValueEquals(Method, o.Method)
               && AreListsEqual(DoseAndRate, o.DoseAndRate)
               && AreListsEqual(MaxDosePerPeriod, o.MaxDosePerPeriod)
               && ValueEquals(MaxDosePerAdministration, o.MaxDosePerAdministration)
               && ValueEquals(MaxDosePerLifetime, o.MaxDosePerLifetime);
    }

    protected override IEnumerable<ValidationResult> ValidateInternal(ValidationContext validationContext)
    {
        foreach (var r in ValidateItem(Sequence, validationContext)) yield return r;
        foreach (var r in ValidateItem(Text, validationContext)) yield return r;
        foreach (var r in ValidateList(AdditionalInstruction, validationContext)) yield return r;
        foreach (var r in ValidateItem(PatientInstruction, validationContext)) yield return r;
        foreach (var r in ValidateItem(Timing, validationContext)) yield return r;
        foreach (var r in ValidateItem(AsNeededBoolean, validationContext)) yield return r;
        foreach (var r in ValidateItem(AsNeededCodeableConcept, validationContext)) yield return r;
        foreach (var r in ValidateItem(Site, validationContext)) yield return r;
        foreach (var r in ValidateItem(Route, validationContext)) yield return r;
        foreach (var r in ValidateItem(Method, validationContext)) yield return r;
        foreach (var r in ValidateList(DoseAndRate, validationContext)) yield return r;
        foreach (var r in ValidateList(MaxDosePerPeriod, validationContext)) yield return r;
        foreach (var r in ValidateItem(MaxDosePerAdministration, validationContext)) yield return r;
        foreach (var r in ValidateItem(MaxDosePerLifetime, validationContext)) yield return r;
    }

    /// <summary>Dosage.doseAndRate 具體 backbone，不得使用抽象 <see cref="BackboneElement"/>（STJ 無法反序列化）。</summary>
    public sealed class DoseAndRateComponent : BackboneElement
    {
        [JsonPropertyName("type")] public CodeableConcept? Type { get; set; }
        [JsonPropertyName("doseRange")] public global::Fhir.TypeFramework.DataTypes.Range? DoseRange { get; set; }
        [JsonPropertyName("doseQuantity")] public Quantity? DoseQuantity { get; set; }
        [JsonPropertyName("rateRatio")] public Ratio? RateRatio { get; set; }
        [JsonPropertyName("rateRange")] public global::Fhir.TypeFramework.DataTypes.Range? RateRange { get; set; }
        [JsonPropertyName("rateQuantity")] public Quantity? RateQuantity { get; set; }

        public override Base DeepCopy()
        {
            var copy = (DoseAndRateComponent)base.DeepCopy();
            copy.Type = Type?.DeepCopy() as CodeableConcept;
            copy.DoseRange = DoseRange?.DeepCopy() as global::Fhir.TypeFramework.DataTypes.Range;
            copy.DoseQuantity = DoseQuantity?.DeepCopy() as Quantity;
            copy.RateRatio = RateRatio?.DeepCopy() as Ratio;
            copy.RateRange = RateRange?.DeepCopy() as global::Fhir.TypeFramework.DataTypes.Range;
            copy.RateQuantity = RateQuantity?.DeepCopy() as Quantity;
            return copy;
        }

        public override bool IsExactly(Base other)
        {
            if (other is not DoseAndRateComponent o || !base.IsExactly(other))
                return false;
            return Eq(Type, o.Type)
                   && Eq(DoseRange, o.DoseRange)
                   && Eq(DoseQuantity, o.DoseQuantity)
                   && Eq(RateRatio, o.RateRatio)
                   && Eq(RateRange, o.RateRange)
                   && Eq(RateQuantity, o.RateQuantity);
        }

        private static bool Eq<T>(T? a, T? b) where T : Base =>
            a is null && b is null || a is not null && b is not null && a.IsExactly(b);
    }
}
