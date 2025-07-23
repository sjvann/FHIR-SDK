// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;
using Fhir.Support.Attributes;

namespace Fhir.R5.Models;

/// <summary>
/// XHTML format, as defined by W3C
/// </summary>
public class FhirXhtml : FhirStringType
{
    /// <summary>
    /// 建立新的 FhirXhtml 實例
    /// </summary>
    public FhirXhtml() { }

    /// <summary>
    /// 建立新的 FhirXhtml 實例
    /// </summary>
    /// <param name="value">初始值</param>
    public FhirXhtml(string value) : base(value) { }

    /// <summary>
    /// 隱式轉換從 string
    /// </summary>
    /// <param name="value">原生值</param>
    public static implicit operator FhirXhtml?(string value)
    {
        return value == null ? null : new FhirXhtml(value);
    }

    /// <summary>
    /// 隱式轉換到 string
    /// </summary>
    /// <param name="fhirValue">FHIR 值</param>
    public static implicit operator string(FhirXhtml? fhirValue)
    {
        return fhirValue?.Value;
    }
}
