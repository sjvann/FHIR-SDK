using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// UsageContext - 使用上下文型別
/// 用於在 FHIR 資源中表示使用上下文資訊
/// </summary>
/// <remarks>
/// FHIR R5 UsageContext (Complex Type)
/// Specifies clinical/business/etc. metadata that can be used to retrieve, index and/or categorize an artifact.
/// 
/// Structure:
/// - code: Coding (1..1) - Type of context being specified
/// - value[x]: CodeableConcept|Quantity|Range|Reference (1..1) - Value that defines the context
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class UsageContext : UnifiedComplexTypeBase<UsageContext>
{
    /// <summary>
    /// 指定上下文的類型
    /// FHIR Path: UsageContext.code
    /// Cardinality: 1..1
    /// Type: Coding
    /// </summary>
    [JsonPropertyName("code")]
    [Required(ErrorMessage = "UsageContext.code is required")]
    public Coding? Code { get; set; }

    /// <summary>
    /// 定義上下文的值 - 使用 Choice Type 支援多種資料型態
    /// FHIR Path: UsageContext.value[x]
    /// Cardinality: 1..1
    /// Type: CodeableConcept|Quantity|Range|Reference
    /// </summary>
    [JsonPropertyName("value")]
    [Required(ErrorMessage = "UsageContext.value is required")]
    public UsageContextValueChoice? Value { get; set; }

    /// <summary>
    /// 檢查是否有代碼
    /// </summary>
    /// <returns>如果存在代碼則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasCode => Code != null;

    /// <summary>
    /// 檢查是否有值
    /// </summary>
    /// <returns>如果存在值則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasValue => Value != null;

    /// <summary>
    /// 檢查使用上下文是否有效
    /// </summary>
    /// <returns>如果使用上下文有效則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool IsValid => HasCode && HasValue;

    /// <summary>
    /// 取得顯示文字
    /// </summary>
    /// <returns>顯示文字</returns>
    [JsonIgnore]
    public string? DisplayText
    {
        get
        {
            if (!IsValid)
                return null;

            var parts = new List<string>();
            
            if (HasCode)
            {
                parts.Add(Code?.DisplayText);
            }
            
            if (HasValue)
            {
                parts.Add(Value?.ToString());
            }
            
            return parts.Any() ? string.Join(": ", parts) : null;
        }
    }

    protected override void CopyFieldsTo(UsageContext target)
    {
        target.Code = Code?.DeepCopy() as Coding;
        target.Value = Value?.DeepCopy() as UsageContextValueChoice;
    }

    protected override bool FieldsAreExactly(UsageContext other)
    {
        return DeepEqualityComparer.AreEqual(Code, other.Code) &&
               DeepEqualityComparer.AreEqual(Value, other.Value);
    }

    protected override IEnumerable<ValidationResult> ValidateFields(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();

        // 驗證 Code
        if (Code != null)
        {
            results.AddRange(Code.Validate(validationContext));
        }
        else
        {
            results.Add(new ValidationResult("UsageContext.code is required"));
        }

        // 驗證 Value
        if (Value != null)
        {
            results.AddRange(Value.Validate(validationContext));
        }
        else
        {
            results.Add(new ValidationResult("UsageContext.value is required"));
        }

        return results;
    }
} 