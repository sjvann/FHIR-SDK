// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.R4.Models;

/// <summary>
/// FHIR Integer primitive type
/// </summary>
public class FhirInteger : SimplePrimitiveType<int>
{
    /// <summary>
    /// 建立新的 FhirInteger 實例
    /// </summary>
    public FhirInteger() { }

    /// <summary>
    /// 建立新的 FhirInteger 實例
    /// </summary>
    /// <param name="value">初始值</param>
    public FhirInteger(int? value)
    {
        Value = value;
    }

    /// <summary>
    /// 驗證值
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果</returns>
    protected override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 基礎驗證邏輯
        if (Value == null) yield break;

        // 預設無額外驗證
    }
}
