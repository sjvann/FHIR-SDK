// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;
using Fhir.Support.Attributes;

namespace Fhir.R5.Models;

/// <summary>
/// A sequence of Unicode characters
/// </summary>
public class FhirString : FhirStringType
{
    /// <summary>
    /// 建立新的 FhirString 實例
    /// </summary>
    public FhirString() { }

    /// <summary>
    /// 建立新的 FhirString 實例
    /// </summary>
    /// <param name="value">初始值</param>
    public FhirString(string value) : base(value) { }

    /// <summary>
    /// 隱式轉換從 string
    /// </summary>
    /// <param name="value">原生值</param>
    public static implicit operator FhirString?(string value)
    {
        return value == null ? null : new FhirString(value);
    }

    /// <summary>
    /// 隱式轉換到 string
    /// </summary>
    /// <param name="fhirValue">FHIR 值</param>
    public static implicit operator string(FhirString? fhirValue)
    {
        return fhirValue?.Value;
    }
}
