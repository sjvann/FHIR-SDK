using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using System.ComponentModel.DataAnnotations;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR Primitive Type: url
/// </summary>
public class FhirUrl : PrimitiveTypeBase<string>
{
    public FhirUrl() { }

    public FhirUrl(string? value) : base(value) { }

    public static implicit operator FhirUrl(string? value) => new(value);
    public static implicit operator string?(FhirUrl fhirValue) => fhirValue?.Value;

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
        return Uri.IsWellFormedUriString(value, UriKind.Absolute);
    }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (!string.IsNullOrEmpty(Value) && !Uri.IsWellFormedUriString(Value, UriKind.Absolute))
        {
            yield return new ValidationResult("Url must be a valid absolute URI");
        }
    }
} 