using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using System.ComponentModel.DataAnnotations;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR Primitive Type: positiveInt
/// </summary>
public class FhirPositiveInt : PrimitiveTypeBase<int>
{
    public FhirPositiveInt() { }

    public FhirPositiveInt(int? value) : base(value) { }

    public FhirPositiveInt(string? value) : base(ParseValue(value)) { }

    public static implicit operator FhirPositiveInt(int? value) => new(value);
    public static implicit operator FhirPositiveInt(string? value) => new(value);
    public static implicit operator int?(FhirPositiveInt fhirValue) => fhirValue?.Value;
    public static implicit operator string?(FhirPositiveInt fhirValue) => fhirValue?.ToString();

    public override int? ParseValue(string? value)
    {
        if (string.IsNullOrEmpty(value)) return null;
        if (int.TryParse(value, out var result) && result > 0)
        {
            return result;
        }
        return null;
    }

    public override string? ValueToString(int? value)
    {
        return value?.ToString();
    }

    public override bool IsValidValue(int? value)
    {
        return value == null || (value.Value > 0 && value.Value <= int.MaxValue);
    }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (Value.HasValue && Value.Value <= 0)
        {
            yield return new ValidationResult("PositiveInt must be greater than 0");
        }
    }
} 