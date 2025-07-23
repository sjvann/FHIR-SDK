// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;
using Fhir.Support.Attributes;

namespace Fhir.R5.Models;

/// <summary>
/// Value of "true" or "false"
/// </summary>
public class FhirBoolean : FhirPrimitiveType<bool?>
{
    /// <summary>
    /// 建立新的 FhirBoolean 實例
    /// </summary>
    public FhirBoolean() { }

    /// <summary>
    /// 建立新的 FhirBoolean 實例
    /// </summary>
    /// <param name="value">初始值</param>
    public FhirBoolean(bool? value) : base(value) { }

    /// <summary>
    /// 隱式轉換從 bool?
    /// </summary>
    /// <param name="value">原生值</param>
    public static implicit operator FhirBoolean?(bool? value)
    {
        return value == null ? null : new FhirBoolean(value);
    }

    /// <summary>
    /// 隱式轉換到 bool?
    /// </summary>
    /// <param name="fhirValue">FHIR 值</param>
    public static implicit operator bool?(FhirBoolean? fhirValue)
    {
        return fhirValue?.Value;
    }
}
