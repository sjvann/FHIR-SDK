// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;
using Fhir.Support.Attributes;

namespace Fhir.R5.Models;

/// <summary>
/// An integer with a value that is positive
/// </summary>
public class FhirPositiveInt : FhirNumericType<uint>
{
    /// <summary>
    /// 建立新的 FhirPositiveInt 實例
    /// </summary>
    public FhirPositiveInt() { }

    /// <summary>
    /// 建立新的 FhirPositiveInt 實例
    /// </summary>
    /// <param name="value">初始值</param>
    public FhirPositiveInt(uint? value) : base(value) { }

    /// <summary>
    /// 隱式轉換從 uint?
    /// </summary>
    /// <param name="value">原生值</param>
    public static implicit operator FhirPositiveInt?(uint? value)
    {
        return value == null ? null : new FhirPositiveInt(value);
    }

    /// <summary>
    /// 隱式轉換到 uint?
    /// </summary>
    /// <param name="fhirValue">FHIR 值</param>
    public static implicit operator uint?(FhirPositiveInt? fhirValue)
    {
        return fhirValue?.Value;
    }
}
