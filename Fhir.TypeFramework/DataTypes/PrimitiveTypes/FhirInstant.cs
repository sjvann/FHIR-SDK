using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using System.ComponentModel.DataAnnotations;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR Primitive Type: instant
/// </summary>
public class FhirInstant : PrimitiveTypeBase<DateTime>
{
    public FhirInstant() { }

    public FhirInstant(DateTime? value) : base(value) { }

    public FhirInstant(string? value) : base(ParseValue(value)) { }

    public static implicit operator FhirInstant(DateTime? value) => new(value);
    public static implicit operator FhirInstant(string? value) => new(value);
    public static implicit operator DateTime?(FhirInstant fhirValue) => fhirValue?.Value;
    public static implicit operator string?(FhirInstant fhirValue) => fhirValue?.ToString();

    public override DateTime? ParseValue(string? value)
    {
        if (string.IsNullOrEmpty(value)) return null;
        if (DateTime.TryParse(value, out var result))
        {
            return result.ToUniversalTime();
        }
        return null;
    }

    public override string? ValueToString(DateTime? value)
    {
        return value?.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
    }

    public override bool IsValidValue(DateTime? value)
    {
        return value == null || (value.Value >= DateTime.MinValue && value.Value <= DateTime.MaxValue);
    }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (Value.HasValue && (Value.Value < DateTime.MinValue || Value.Value > DateTime.MaxValue))
        {
            yield return new ValidationResult("Instant value is out of valid range");
        }
    }
} 