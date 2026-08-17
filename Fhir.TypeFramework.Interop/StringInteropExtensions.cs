using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using Fhir.TypeFramework.Validation;

namespace Fhir.TypeFramework.Interop;

/// <summary>字串與 URI 轉 FHIR primitive 的擴充方法。</summary>
public static class StringInteropExtensions
{
    public static FhirString ToFhirString(this string value) => new(value);

    public static FhirString? ToFhirStringOrNull(this string? value) => value is null ? null : new FhirString(value);

    public static FhirCode ToFhirCode(this string value, bool validate = false)
    {
        var code = new FhirCode(value);
        if (validate) ValidationFramework.ValidateFhirCode(value);
        return code;
    }

    public static FhirUri ToFhirUri(this string value, bool validate = false)
    {
        if (validate) ValidationFramework.ValidateFhirUri(value);
        return new FhirUri(value);
    }

    public static FhirUri ToFhirUri(this Uri value) => new(value.AbsoluteUri);

    public static FhirId ToFhirId(this string value, bool validate = false)
    {
        if (validate) ValidationFramework.ValidateFhirId(value);
        return new FhirId(value);
    }

    public static FhirUuid ToFhirUuid(this Guid value, bool validate = false)
    {
        var s = value.ToString();
        if (validate) ValidationFramework.ValidateFhirUuid(s);
        return new FhirUuid(s);
    }

    public static FhirCanonical ToFhirCanonical(this string value) => new(value);
    public static FhirMarkdown ToFhirMarkdown(this string value) => new(value);
}
