using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using System.ComponentModel.DataAnnotations;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR Primitive Type: integer64
/// </summary>
public class FhirInteger64 : PrimitiveTypeBase<long>
{
    public FhirInteger64() { }

    public FhirInteger64(long? value) : base(value) { }

    public FhirInteger64(string? value) : base(ParseValue(value)) { }

    public static implicit operator FhirInteger64(long? value) => new(value);
    public static implicit operator FhirInteger64(string? value) => new(value);
    public static implicit operator long?(FhirInteger64 fhirValue) => fhirValue?.Value;
    public static implicit operator string?(FhirInteger64 fhirValue) => fhirValue?.ToString();

    public override long? ParseValue(string? value)
    {
        if (string.IsNullOrEmpty(value)) return null;
        if (long.TryParse(value, out var result))
        {
            return result;
        }
        return null;
    }

    public override string? ValueToString(long? value)
    {
        return value?.ToString();
    }

    public override bool IsValidValue(long? value)
    {
        return value == null || (value.Value >= long.MinValue && value.Value <= long.MaxValue);
    }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (Value.HasValue && (Value.Value < long.MinValue || Value.Value > long.MaxValue))
        {
            yield return new ValidationResult("Integer64 value is out of valid range");
        }
    }
} 