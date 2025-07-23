// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;
using Fhir.Support.Attributes;

namespace Fhir.R5.Models;

/// <summary>
/// An instant in time - known at least to the second
/// </summary>
public class FhirInstant : FhirPrimitiveType<DateTimeOffset?>
{
    /// <summary>
    /// 建立新的 FhirInstant 實例
    /// </summary>
    public FhirInstant() { }

    /// <summary>
    /// 建立新的 FhirInstant 實例
    /// </summary>
    /// <param name="value">初始值</param>
    public FhirInstant(DateTimeOffset? value) : base(value) { }

    /// <summary>
    /// 隱式轉換從 DateTimeOffset?
    /// </summary>
    /// <param name="value">原生值</param>
    public static implicit operator FhirInstant?(DateTimeOffset? value)
    {
        return value == null ? null : new FhirInstant(value);
    }

    /// <summary>
    /// 隱式轉換到 DateTimeOffset?
    /// </summary>
    /// <param name="fhirValue">FHIR 值</param>
    public static implicit operator DateTimeOffset?(FhirInstant? fhirValue)
    {
        return fhirValue?.Value;
    }

    /// <summary>
    /// 轉換為 DateTimeOffset
    /// </summary>
    /// <returns>DateTimeOffset 值</returns>
    public DateTimeOffset? ToDateTimeOffset() => Value;

    /// <summary>
    /// 轉換為 UTC DateTime
    /// </summary>
    /// <returns>UTC DateTime 值</returns>
    public DateTime? ToUtcDateTime() => Value?.UtcDateTime;
}
