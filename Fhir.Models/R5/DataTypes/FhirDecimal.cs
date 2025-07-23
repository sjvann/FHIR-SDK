// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;
using Fhir.Support.Attributes;

namespace Fhir.R5.Models;

/// <summary>
/// A rational number with implicit precision
/// </summary>
public class FhirDecimal : FhirNumericType<decimal>
{
    /// <summary>
    /// 建立新的 FhirDecimal 實例
    /// </summary>
    public FhirDecimal() { }

    /// <summary>
    /// 建立新的 FhirDecimal 實例
    /// </summary>
    /// <param name="value">初始值</param>
    public FhirDecimal(decimal? value) : base(value) { }

    /// <summary>
    /// 隱式轉換從 decimal?
    /// </summary>
    /// <param name="value">原生值</param>
    public static implicit operator FhirDecimal?(decimal? value)
    {
        return value == null ? null : new FhirDecimal(value);
    }

    /// <summary>
    /// 隱式轉換到 decimal?
    /// </summary>
    /// <param name="fhirValue">FHIR 值</param>
    public static implicit operator decimal?(FhirDecimal? fhirValue)
    {
        return fhirValue?.Value;
    }
}
