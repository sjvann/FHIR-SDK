using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using System.ComponentModel.DataAnnotations;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR Primitive Type: oid
/// </summary>
public class FhirOid : PrimitiveTypeBase<string>
{
    public FhirOid() { }

    public FhirOid(string? value) : base(value) { }

    public static implicit operator FhirOid(string? value) => new(value);
    public static implicit operator string?(FhirOid fhirValue) => fhirValue?.Value;

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
            yield return new ValidationResult("Oid value cannot exceed 1MB");
        }
    }
} 