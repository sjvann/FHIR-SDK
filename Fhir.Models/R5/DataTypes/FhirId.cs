// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;
using Fhir.Support.Attributes;

namespace Fhir.R5.Models;

/// <summary>
/// Any combination of letters, numerals, "-" and ".", with a length limit of 64 characters
/// </summary>
public class FhirId : FhirStringType
{
    /// <summary>
    /// 建立新的 FhirId 實例
    /// </summary>
    public FhirId() { }

    /// <summary>
    /// 建立新的 FhirId 實例
    /// </summary>
    /// <param name="value">初始值</param>
    public FhirId(string value) : base(value) { }

    /// <summary>
    /// 隱式轉換從 string
    /// </summary>
    /// <param name="value">原生值</param>
    public static implicit operator FhirId?(string value)
    {
        return value == null ? null : new FhirId(value);
    }

    /// <summary>
    /// 隱式轉換到 string
    /// </summary>
    /// <param name="fhirValue">FHIR 值</param>
    public static implicit operator string(FhirId? fhirValue)
    {
        return fhirValue?.Value;
    }
}
