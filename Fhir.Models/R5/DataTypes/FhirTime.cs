// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;
using Fhir.Support.Attributes;

namespace Fhir.R5.Models;

/// <summary>
/// A time during the day, with no date specified
/// </summary>
public class FhirTime : FhirPrimitiveType<TimeSpan?>
{
    /// <summary>
    /// 建立新的 FhirTime 實例
    /// </summary>
    public FhirTime() { }

    /// <summary>
    /// 建立新的 FhirTime 實例
    /// </summary>
    /// <param name="value">初始值</param>
    public FhirTime(TimeSpan? value) : base(value) { }

    /// <summary>
    /// 隱式轉換從 TimeSpan?
    /// </summary>
    /// <param name="value">原生值</param>
    public static implicit operator FhirTime?(TimeSpan? value)
    {
        return value == null ? null : new FhirTime(value);
    }

    /// <summary>
    /// 隱式轉換到 TimeSpan?
    /// </summary>
    /// <param name="fhirValue">FHIR 值</param>
    public static implicit operator TimeSpan?(FhirTime? fhirValue)
    {
        return fhirValue?.Value;
    }

    /// <summary>
    /// 轉換為 TimeSpan
    /// </summary>
    /// <returns>TimeSpan 值</returns>
    public TimeSpan? ToTimeSpan() => Value;

    /// <summary>
    /// 轉換為 TimeOnly
    /// </summary>
    /// <returns>TimeOnly 值</returns>
    public TimeOnly? ToTimeOnly() => Value.HasValue ? TimeOnly.FromTimeSpan(Value.Value) : null;
}
