using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.TypeFramework.Bases;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>ElementDefinition.binding</summary>
public sealed class ElementDefinitionBindingComponent : BackboneElement
{
    [JsonPropertyName("strength")] public FhirCode? Strength { get; set; }
    [JsonPropertyName("description")] public FhirString? Description { get; set; }
    [JsonPropertyName("valueSet")] public FhirCanonical? ValueSet { get; set; }

    public override Base DeepCopy()
    {
        var copy = (ElementDefinitionBindingComponent)base.DeepCopy();
        copy.Strength = Strength?.DeepCopy() as FhirCode;
        copy.Description = Description?.DeepCopy() as FhirString;
        copy.ValueSet = ValueSet?.DeepCopy() as FhirCanonical;
        return copy;
    }

    public override bool IsExactly(Base other)
    {
        if (other is not ElementDefinitionBindingComponent o) return false;
        if (!base.IsExactly(other)) return false;
        return ValueEq(Strength, o.Strength) && ValueEq(Description, o.Description) && ValueEq(ValueSet, o.ValueSet);
    }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var r in base.Validate(validationContext)) yield return r;
        if (Strength != null)
        {
            foreach (var r in Strength.Validate(validationContext)) yield return r;
        }
    }

    private static bool ValueEq<T>(T? a, T? b) where T : Base =>
        (a == null && b == null) || (a != null && b != null && a.IsExactly(b));
}
