// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;
using Fhir.Support.Attributes;

namespace Fhir.R5.Models;

/// <summary>
/// A whole number
/// </summary>
public class FhirInteger : FhirNumericType<int>
{
    /// <summary>
    /// 建立新的 FhirInteger 實例
    /// </summary>
    public FhirInteger() { }

    /// <summary>
    /// 建立新的 FhirInteger 實例
    /// </summary>
    /// <param name="value">初始值</param>
    public FhirInteger(int? value) : base(value) { }

    /// <summary>
    /// 隱式轉換從 int?
    /// </summary>
    /// <param name="value">原生值</param>
    public static implicit operator FhirInteger?(int? value)
    {
        return value == null ? null : new FhirInteger(value);
    }

    /// <summary>
    /// 隱式轉換到 int?
    /// </summary>
    /// <param name="fhirValue">FHIR 值</param>
    public static implicit operator int?(FhirInteger? fhirValue)
    {
        return fhirValue?.Value;
    }
}
