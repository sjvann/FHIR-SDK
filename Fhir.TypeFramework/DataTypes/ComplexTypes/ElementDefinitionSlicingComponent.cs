using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.TypeFramework.Bases;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>ElementDefinition.slicing</summary>
public sealed class ElementDefinitionSlicingComponent : BackboneElement
{
    [JsonPropertyName("discriminator")] public List<ElementDefinitionSlicingDiscriminatorComponent>? Discriminator { get; set; }
    [JsonPropertyName("description")] public FhirString? Description { get; set; }
    [JsonPropertyName("ordered")] public FhirBoolean? Ordered { get; set; }
    [JsonPropertyName("rules")] public FhirCode? Rules { get; set; }

    public override Base DeepCopy()
    {
        var copy = (ElementDefinitionSlicingComponent)base.DeepCopy();
        copy.Discriminator = Discriminator?.Select(d => (ElementDefinitionSlicingDiscriminatorComponent)d.DeepCopy()).ToList();
        copy.Description = Description?.DeepCopy() as FhirString;
        copy.Ordered = Ordered?.DeepCopy() as FhirBoolean;
        copy.Rules = Rules?.DeepCopy() as FhirCode;
        return copy;
    }

    public override bool IsExactly(Base other)
    {
        if (other is not ElementDefinitionSlicingComponent o) return false;
        if (!base.IsExactly(other)) return false;
        if (!ListEq(Discriminator, o.Discriminator)) return false;
        return ValueEq(Description, o.Description) && ValueEq(Ordered, o.Ordered) && ValueEq(Rules, o.Rules);
    }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var r in base.Validate(validationContext)) yield return r;
        if (Discriminator != null)
        {
            foreach (var d in Discriminator)
            {
                foreach (var r in d.Validate(new ValidationContext(d))) yield return r;
            }
        }
    }

    private static bool ValueEq<T>(T? a, T? b) where T : Base =>
        (a == null && b == null) || (a != null && b != null && a.IsExactly(b));

    private static bool ListEq<T>(IList<T>? a, IList<T>? b) where T : Base
    {
        if (a == null && b == null) return true;
        if (a == null || b == null || a.Count != b.Count) return false;
        return a.Zip(b, (x, y) => x.IsExactly(y)).All(z => z);
    }
}

/// <summary>ElementDefinition.slicing.discriminator</summary>
public sealed class ElementDefinitionSlicingDiscriminatorComponent : BackboneElement
{
    [JsonPropertyName("type")] public FhirCode? Type { get; set; }
    [JsonPropertyName("path")] public FhirString? Path { get; set; }

    public override Base DeepCopy()
    {
        var copy = (ElementDefinitionSlicingDiscriminatorComponent)base.DeepCopy();
        copy.Type = Type?.DeepCopy() as FhirCode;
        copy.Path = Path?.DeepCopy() as FhirString;
        return copy;
    }

    public override bool IsExactly(Base other)
    {
        if (other is not ElementDefinitionSlicingDiscriminatorComponent o) return false;
        if (!base.IsExactly(other)) return false;
        return ValueEq(Type, o.Type) && ValueEq(Path, o.Path);
    }

    private static bool ValueEq<T>(T? a, T? b) where T : Base =>
        (a == null && b == null) || (a != null && b != null && a.IsExactly(b));
}
