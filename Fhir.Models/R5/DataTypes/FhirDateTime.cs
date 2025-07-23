// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;
using Fhir.Support.Attributes;

namespace Fhir.R5.Models;

/// <summary>
/// A date, date-time or partial date
/// </summary>
public class FhirDateTime : FhirPrimitiveType<DateTime?>
{
    /// <summary>
    /// 建立新的 FhirDateTime 實例
    /// </summary>
    public FhirDateTime() { }

    /// <summary>
    /// 建立新的 FhirDateTime 實例
    /// </summary>
    /// <param name="value">初始值</param>
    public FhirDateTime(DateTime? value) : base(value) { }

    /// <summary>
    /// 隱式轉換從 DateTime?
    /// </summary>
    /// <param name="value">原生值</param>
    public static implicit operator FhirDateTime?(DateTime? value)
    {
        return value == null ? null : new FhirDateTime(value);
    }

    /// <summary>
    /// 隱式轉換到 DateTime?
    /// </summary>
    /// <param name="fhirValue">FHIR 值</param>
    public static implicit operator DateTime?(FhirDateTime? fhirValue)
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
