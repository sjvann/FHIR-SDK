using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using System.ComponentModel.DataAnnotations;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR Primitive Type: unsignedInt
/// </summary>
public class FhirUnsignedInt : PrimitiveTypeBase<uint>
{
    public FhirUnsignedInt() { }

    public FhirUnsignedInt(uint? value) : base(value) { }

    public FhirUnsignedInt(string? value) : base(ParseValue(value)) { }

    public static implicit operator FhirUnsignedInt(uint? value) => new(value);
    public static implicit operator FhirUnsignedInt(string? value) => new(value);
    public static implicit operator uint?(FhirUnsignedInt fhirValue) => fhirValue?.Value;
    public static implicit operator string?(FhirUnsignedInt fhirValue) => fhirValue?.ToString();

    public override uint? ParseValue(string? value)
    {
        if (string.IsNullOrEmpty(value)) return null;
        if (uint.TryParse(value, out var result))
        {
            return result;
        }
        return null;
    }

    public override string? ValueToString(uint? value)
    {
        return value?.ToString();
    }

    public override bool IsValidValue(uint? value)
    {
        return value == null || (value.Value >= uint.MinValue && value.Value <= uint.MaxValue);
    }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (Value.HasValue && (Value.Value < uint.MinValue || Value.Value > uint.MaxValue))
        {
            yield return new ValidationResult("UnsignedInt value is out of valid range");
        }
    }
} 