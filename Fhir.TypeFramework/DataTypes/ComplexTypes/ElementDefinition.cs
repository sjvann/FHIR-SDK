using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.TypeFramework.Bases;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// FHIR ElementDefinition（含驗證所需的 cardinality、type、binding、constraint、slicing）。
/// </summary>
public class ElementDefinition : ComplexTypeBase
{
    [JsonPropertyName("path")] public FhirString? Path { get; set; }
    [JsonPropertyName("sliceName")] public FhirString? SliceName { get; set; }
    [JsonPropertyName("short")] public FhirString? Short { get; set; }
    [JsonPropertyName("definition")] public FhirString? Definition { get; set; }
    [JsonPropertyName("comment")] public FhirString? Comment { get; set; }
    [JsonPropertyName("min")] public FhirUnsignedInt? Min { get; set; }
    [JsonPropertyName("max")] public FhirString? Max { get; set; }
    [JsonPropertyName("type")] public List<ElementDefinitionTypeComponent>? Type { get; set; }
    [JsonPropertyName("binding")] public ElementDefinitionBindingComponent? Binding { get; set; }
    [JsonPropertyName("constraint")] public List<ElementDefinitionConstraintComponent>? Constraint { get; set; }
    [JsonPropertyName("slicing")] public ElementDefinitionSlicingComponent? Slicing { get; set; }
    [JsonPropertyName("patternCodeableConcept")] public CodeableConcept? PatternCodeableConcept { get; set; }
    [JsonPropertyName("patternCoding")] public Coding? PatternCoding { get; set; }
    [JsonPropertyName("patternString")] public FhirString? PatternString { get; set; }
    [JsonPropertyName("fixedCode")] public FhirCode? FixedCode { get; set; }
    [JsonPropertyName("fixedUri")] public FhirUri? FixedUri { get; set; }
    [JsonPropertyName("fixedString")] public FhirString? FixedString { get; set; }
    [JsonPropertyName("fixedBoolean")] public FhirBoolean? FixedBoolean { get; set; }
    [JsonPropertyName("fixedInteger")] public FhirInteger? FixedInteger { get; set; }

    protected override void DeepCopyInternal(ComplexTypeBase copy)
    {
        var c = (ElementDefinition)copy;
        c.Path = Path?.DeepCopy() as FhirString;
        c.SliceName = SliceName?.DeepCopy() as FhirString;
        c.Short = Short?.DeepCopy() as FhirString;
        c.Definition = Definition?.DeepCopy() as FhirString;
        c.Comment = Comment?.DeepCopy() as FhirString;
        c.Min = Min?.DeepCopy() as FhirUnsignedInt;
        c.Max = Max?.DeepCopy() as FhirString;
        c.Type = Type?.Select(t => (ElementDefinitionTypeComponent)t.DeepCopy()).ToList();
        c.Binding = Binding?.DeepCopy() as ElementDefinitionBindingComponent;
        c.Constraint = Constraint?.Select(x => (ElementDefinitionConstraintComponent)x.DeepCopy()).ToList();
        c.Slicing = Slicing?.DeepCopy() as ElementDefinitionSlicingComponent;
        c.PatternCodeableConcept = PatternCodeableConcept?.DeepCopy() as CodeableConcept;
        c.PatternCoding = PatternCoding?.DeepCopy() as Coding;
        c.PatternString = PatternString?.DeepCopy() as FhirString;
        c.FixedCode = FixedCode?.DeepCopy() as FhirCode;
        c.FixedUri = FixedUri?.DeepCopy() as FhirUri;
        c.FixedString = FixedString?.DeepCopy() as FhirString;
        c.FixedBoolean = FixedBoolean?.DeepCopy() as FhirBoolean;
        c.FixedInteger = FixedInteger?.DeepCopy() as FhirInteger;
    }

    protected override bool IsExactlyInternal(ComplexTypeBase other)
    {
        var o = (ElementDefinition)other;
        return ValueEquals(Path, o.Path)
               && ValueEquals(SliceName, o.SliceName)
               && ValueEquals(Short, o.Short)
               && ValueEquals(Definition, o.Definition)
               && ValueEquals(Comment, o.Comment)
               && ValueEquals(Min, o.Min)
               && ValueEquals(Max, o.Max)
               && AreListsEqual(Type, o.Type)
               && ValueEquals(Binding, o.Binding)
               && AreListsEqual(Constraint, o.Constraint)
               && ValueEquals(Slicing, o.Slicing)
               && ValueEquals(PatternCodeableConcept, o.PatternCodeableConcept)
               && ValueEquals(PatternCoding, o.PatternCoding)
               && ValueEquals(PatternString, o.PatternString)
               && ValueEquals(FixedCode, o.FixedCode)
               && ValueEquals(FixedUri, o.FixedUri)
               && ValueEquals(FixedString, o.FixedString)
               && ValueEquals(FixedBoolean, o.FixedBoolean)
               && ValueEquals(FixedInteger, o.FixedInteger);
    }

    protected override IEnumerable<ValidationResult> ValidateInternal(ValidationContext validationContext)
    {
        foreach (var r in ValidateItem(Path, validationContext)) yield return r;
        foreach (var r in ValidateItem(SliceName, validationContext)) yield return r;
        foreach (var r in ValidateItem(Short, validationContext)) yield return r;
        foreach (var r in ValidateItem(Definition, validationContext)) yield return r;
        foreach (var r in ValidateItem(Comment, validationContext)) yield return r;
        foreach (var r in ValidateItem(Min, validationContext)) yield return r;
        foreach (var r in ValidateItem(Max, validationContext)) yield return r;
        foreach (var r in ValidateList(Type, validationContext)) yield return r;
        foreach (var r in ValidateItem(Binding, validationContext)) yield return r;
        foreach (var r in ValidateList(Constraint, validationContext)) yield return r;
        foreach (var r in ValidateItem(Slicing, validationContext)) yield return r;
        foreach (var r in ValidateItem(PatternCodeableConcept, validationContext)) yield return r;
        foreach (var r in ValidateItem(PatternCoding, validationContext)) yield return r;
        foreach (var r in ValidateItem(PatternString, validationContext)) yield return r;
        foreach (var r in ValidateItem(FixedCode, validationContext)) yield return r;
        foreach (var r in ValidateItem(FixedUri, validationContext)) yield return r;
        foreach (var r in ValidateItem(FixedString, validationContext)) yield return r;
        foreach (var r in ValidateItem(FixedBoolean, validationContext)) yield return r;
        foreach (var r in ValidateItem(FixedInteger, validationContext)) yield return r;
    }
}
