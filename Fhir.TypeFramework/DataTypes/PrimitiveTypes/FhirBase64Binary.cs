using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR Primitive Type: base64Binary
/// </summary>
public class FhirBase64Binary : PrimitiveTypeBase<byte[]>
{
    public FhirBase64Binary() { }

    public FhirBase64Binary(byte[]? value) : base(value) { }

    public FhirBase64Binary(string? value) : base(ParseValue(value)) { }

    public static implicit operator FhirBase64Binary(byte[]? value) => new(value);
    public static implicit operator FhirBase64Binary(string? value) => new(value);
    public static implicit operator byte[]?(FhirBase64Binary fhirValue) => fhirValue?.Value;
    public static implicit operator string?(FhirBase64Binary fhirValue) => fhirValue?.ToString();

    public override byte[]? ParseValue(string? value)
    {
        if (string.IsNullOrEmpty(value)) return null;
        try
        {
            return Convert.FromBase64String(value);
        }
        catch
        {
            return null;
        }
    }

    public override string? ValueToString(byte[]? value)
    {
        return value != null ? Convert.ToBase64String(value) : null;
    }

    public override bool IsValidValue(byte[]? value)
    {
        return value == null || value.Length <= 1024 * 1024; // 1MB limit
    }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (Value != null && Value.Length > 1024 * 1024)
        {
            yield return new ValidationResult("Base64Binary value cannot exceed 1MB");
        }
    }
} 