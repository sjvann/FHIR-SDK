using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using System.ComponentModel.DataAnnotations;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR Primitive Type: uuid
/// </summary>
public class FhirUuid : PrimitiveTypeBase<Guid>
{
    public FhirUuid() { }

    public FhirUuid(Guid? value) : base(value) { }

    public FhirUuid(string? value) : base(ParseValue(value)) { }

    public static implicit operator FhirUuid(Guid? value) => new(value);
    public static implicit operator FhirUuid(string? value) => new(value);
    public static implicit operator Guid?(FhirUuid fhirValue) => fhirValue?.Value;
    public static implicit operator string?(FhirUuid fhirValue) => fhirValue?.ToString();

    public override Guid? ParseValue(string? value)
    {
        if (string.IsNullOrEmpty(value)) return null;
        if (Guid.TryParse(value, out var result))
        {
            return result;
        }
        return null;
    }

    public override string? ValueToString(Guid? value)
    {
        return value?.ToString("D"); // Format: 00000000-0000-0000-0000-000000000000
    }

    public override bool IsValidValue(Guid? value)
    {
        return value == null || value.Value != Guid.Empty;
    }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (Value.HasValue && Value.Value == Guid.Empty)
        {
            yield return new ValidationResult("Uuid cannot be empty");
        }
    }
} 