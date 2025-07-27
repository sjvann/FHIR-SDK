using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using System.ComponentModel.DataAnnotations;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR Primitive Type: time
/// </summary>
public class FhirTime : PrimitiveTypeBase<TimeSpan>
{
    public FhirTime() { }

    public FhirTime(TimeSpan? value) : base(value) { }

    public FhirTime(string? value) : base(ParseValue(value)) { }

    public static implicit operator FhirTime(TimeSpan? value) => new(value);
    public static implicit operator FhirTime(string? value) => new(value);
    public static implicit operator TimeSpan?(FhirTime fhirValue) => fhirValue?.Value;
    public static implicit operator string?(FhirTime fhirValue) => fhirValue?.ToString();

    public override TimeSpan? ParseValue(string? value)
    {
        if (string.IsNullOrEmpty(value)) return null;
        if (TimeSpan.TryParse(value, out var result))
        {
            return result;
        }
        return null;
    }

    public override string? ValueToString(TimeSpan? value)
    {
        return value?.ToString(@"hh\:mm\:ss");
    }

    public override bool IsValidValue(TimeSpan? value)
    {
        return value == null || (value.Value >= TimeSpan.MinValue && value.Value <= TimeSpan.MaxValue);
    }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (Value.HasValue && (Value.Value < TimeSpan.MinValue || Value.Value > TimeSpan.MaxValue))
        {
            yield return new ValidationResult("Time value is out of valid range");
        }
    }
} 