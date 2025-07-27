using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using System.ComponentModel.DataAnnotations;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR Primitive Type: date
/// </summary>
public class FhirDate : PrimitiveTypeBase<DateTime>
{
    public FhirDate() { }

    public FhirDate(DateTime? value) : base(value) { }

    public FhirDate(string? value) : base(ParseValue(value)) { }

    public static implicit operator FhirDate(DateTime? value) => new(value);
    public static implicit operator FhirDate(string? value) => new(value);
    public static implicit operator DateTime?(FhirDate fhirValue) => fhirValue?.Value;
    public static implicit operator string?(FhirDate fhirValue) => fhirValue?.ToString();

    public override DateTime? ParseValue(string? value)
    {
        if (string.IsNullOrEmpty(value)) return null;
        if (DateTime.TryParse(value, out var result))
        {
            return result.Date; // Only date part
        }
        return null;
    }

    public override string? ValueToString(DateTime? value)
    {
        return value?.ToString("yyyy-MM-dd");
    }

    public override bool IsValidValue(DateTime? value)
    {
        return value == null || (value.Value >= DateTime.MinValue && value.Value <= DateTime.MaxValue);
    }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (Value.HasValue && (Value.Value < DateTime.MinValue || Value.Value > DateTime.MaxValue))
        {
            yield return new ValidationResult("Date value is out of valid range");
        }
    }
} 