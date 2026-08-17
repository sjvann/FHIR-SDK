using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.TypeFramework.Bases;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>ElementDefinition.constraint</summary>
public sealed class ElementDefinitionConstraintComponent : BackboneElement
{
    [JsonPropertyName("key")] public FhirId? Key { get; set; }
    [JsonPropertyName("severity")] public FhirCode? Severity { get; set; }
    [JsonPropertyName("human")] public FhirString? Human { get; set; }
    [JsonPropertyName("expression")] public FhirString? Expression { get; set; }
    [JsonPropertyName("source")] public FhirCanonical? Source { get; set; }

    public override Base DeepCopy()
    {
        var copy = (ElementDefinitionConstraintComponent)base.DeepCopy();
        copy.Key = Key?.DeepCopy() as FhirId;
        copy.Severity = Severity?.DeepCopy() as FhirCode;
        copy.Human = Human?.DeepCopy() as FhirString;
        copy.Expression = Expression?.DeepCopy() as FhirString;
        copy.Source = Source?.DeepCopy() as FhirCanonical;
        return copy;
    }

    public override bool IsExactly(Base other)
    {
        if (other is not ElementDefinitionConstraintComponent o) return false;
        if (!base.IsExactly(other)) return false;
        return ValueEq(Key, o.Key)
               && ValueEq(Severity, o.Severity)
               && ValueEq(Human, o.Human)
               && ValueEq(Expression, o.Expression)
               && ValueEq(Source, o.Source);
    }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var r in base.Validate(validationContext)) yield return r;
        if (string.IsNullOrEmpty(Key?.StringValue))
            yield return new ValidationResult("constraint.key is required", [nameof(Key)]);
    }

    private static bool ValueEq<T>(T? a, T? b) where T : Base =>
        (a == null && b == null) || (a != null && b != null && a.IsExactly(b));
}
