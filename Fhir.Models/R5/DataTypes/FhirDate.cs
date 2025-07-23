// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;
using Fhir.Support.Attributes;

namespace Fhir.R5.Models;

/// <summary>
/// A date or partial date
/// </summary>
public class FhirDate : FhirPrimitiveType<DateTime?>
{
    /// <summary>
    /// 建立新的 FhirDate 實例
    /// </summary>
    public FhirDate() { }

    /// <summary>
    /// 建立新的 FhirDate 實例
    /// </summary>
    /// <param name="value">初始值</param>
    public FhirDate(DateTime? value) : base(value) { }

    /// <summary>
    /// 隱式轉換從 DateTime?
    /// </summary>
    /// <param name="value">原生值</param>
    public static implicit operator FhirDate?(DateTime? value)
    {
        return value == null ? null : new FhirDate(value);
    }

    /// <summary>
    /// 隱式轉換到 DateTime?
    /// </summary>
    /// <param name="fhirValue">FHIR 值</param>
    public static implicit operator DateTime?(FhirDate? fhirValue)
    {
        return fhirValue?.Value;
    }

    /// <summary>
    /// 轉換為 DateTime
    /// </summary>
    /// <returns>DateTime 值</returns>
    public DateTime? ToDateTime() => Value;

    /// <summary>
    /// 轉換為 DateOnly
    /// </summary>
    /// <returns>DateOnly 值</returns>
    public DateOnly? ToDateOnly() => Value.HasValue ? DateOnly.FromDateTime(Value.Value) : null;
}
