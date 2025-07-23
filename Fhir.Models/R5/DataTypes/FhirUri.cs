// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;
using Fhir.Support.Attributes;

namespace Fhir.R5.Models;

/// <summary>
/// String of characters used to identify a name or a resource
/// </summary>
public class FhirUri : FhirStringType
{
    /// <summary>
    /// 建立新的 FhirUri 實例
    /// </summary>
    public FhirUri() { }

    /// <summary>
    /// 建立新的 FhirUri 實例
    /// </summary>
    /// <param name="value">初始值</param>
    public FhirUri(string value) : base(value) { }

    /// <summary>
    /// 隱式轉換從 string
    /// </summary>
    /// <param name="value">原生值</param>
    public static implicit operator FhirUri?(string value)
    {
        return value == null ? null : new FhirUri(value);
    }

    /// <summary>
    /// 隱式轉換到 string
    /// </summary>
    /// <param name="fhirValue">FHIR 值</param>
    public static implicit operator string(FhirUri? fhirValue)
    {
        return fhirValue?.Value;
    }
}
