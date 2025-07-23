// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;
using Fhir.Support.Attributes;

namespace Fhir.R5.Models;

/// <summary>
/// A string which has at least one character and no leading or trailing whitespace
/// </summary>
public class FhirCode : FhirStringType
{
    /// <summary>
    /// 建立新的 FhirCode 實例
    /// </summary>
    public FhirCode() { }

    /// <summary>
    /// 建立新的 FhirCode 實例
    /// </summary>
    /// <param name="value">初始值</param>
    public FhirCode(string value) : base(value) { }

    /// <summary>
    /// 隱式轉換從 string
    /// </summary>
    /// <param name="value">原生值</param>
    public static implicit operator FhirCode?(string value)
    {
        return value == null ? null : new FhirCode(value);
    }

    /// <summary>
    /// 隱式轉換到 string
    /// </summary>
    /// <param name="fhirValue">FHIR 值</param>
    public static implicit operator string(FhirCode? fhirValue)
    {
        return fhirValue?.Value;
    }
}
