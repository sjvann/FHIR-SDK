using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using System.ComponentModel.DataAnnotations;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR Primitive Type: markdown
/// </summary>
public class FhirMarkdown : PrimitiveTypeBase<string>
{
    public FhirMarkdown() { }

    public FhirMarkdown(string? value) : base(value) { }

    public static implicit operator FhirMarkdown(string? value) => new(value);
    public static implicit operator string?(FhirMarkdown fhirValue) => fhirValue?.Value;

    public override string? ParseValue(string? value)
    {
        return value;
    }

    public override string? ValueToString(string? value)
    {
        return value;
    }

    public override bool IsValidValue(string? value)
    {
        if (string.IsNullOrEmpty(value)) return true;
        return value.Length <= 1048576; // 1MB limit
    }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (!string.IsNullOrEmpty(Value) && Value.Length > 1048576)
        {
            yield return new ValidationResult("Markdown value cannot exceed 1MB");
        }
    }
} 