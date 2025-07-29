using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Count - 計數
/// 用於描述計數值
/// </summary>
/// <remarks>
/// FHIR R5 Count (Complex Type)
/// A measured amount (or an amount that can potentially be measured).
/// 
/// Structure:
/// - value: decimal (0..1) - Numerical value (with implicit precision)
/// - comparator: code (0..1) - < | <= | >= | > - how to understand the value
/// - unit: string (0..1) - Unit representation
/// - system: uri (0..1) - System that defines coded unit form
/// - code: code (0..1) - Coded form of the unit
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Count : UnifiedComplexTypeBase<Count>
{
    /// <summary>
    /// 數值（隱含精度）
    /// FHIR Path: Count.value
    /// Cardinality: 0..1
    /// Type: decimal
    /// </summary>
    [JsonPropertyName("value")]
    public FhirDecimal? Value { get; set; }

    /// <summary>
    /// 比較器
    /// FHIR Path: Count.comparator
    /// Cardinality: 0..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("comparator")]
    public FhirCode? Comparator { get; set; }

    /// <summary>
    /// 單位表示
    /// FHIR Path: Count.unit
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("unit")]
    public FhirString? Unit { get; set; }

    /// <summary>
    /// 定義編碼單位形式的系統
    /// FHIR Path: Count.system
    /// Cardinality: 0..1
    /// Type: uri
    /// </summary>
    [JsonPropertyName("system")]
    public FhirUri? System { get; set; }

    /// <summary>
    /// 單位的編碼形式
    /// FHIR Path: Count.code
    /// Cardinality: 0..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("code")]
    public FhirCode? Code { get; set; }

    /// <summary>
    /// 檢查是否有值
    /// </summary>
    /// <returns>如果存在值則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasValue => Value?.Value != null;

    /// <summary>
    /// 檢查是否有比較器
    /// </summary>
    /// <returns>如果存在比較器則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasComparator => !string.IsNullOrEmpty(Comparator?.Value);

    /// <summary>
    /// 檢查是否有單位
    /// </summary>
    /// <returns>如果存在單位則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasUnit => !string.IsNullOrEmpty(Unit?.Value);

    /// <summary>
    /// 檢查是否有系統
    /// </summary>
    /// <returns>如果存在系統則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasSystem => !string.IsNullOrEmpty(System?.Value);

    /// <summary>
    /// 檢查是否有編碼
    /// </summary>
    /// <returns>如果存在編碼則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasCode => !string.IsNullOrEmpty(Code?.Value);

    /// <summary>
    /// 取得顯示文字
    /// </summary>
    /// <returns>顯示文字</returns>
    [JsonIgnore]
    public string? DisplayText
    {
        get
        {
            var parts = new List<string>();
            
            if (HasValue)
            {
                var valueText = Value?.Value?.ToString();
                if (HasComparator)
                {
                    valueText = $"{Comparator?.Value}{valueText}";
                }
                parts.Add(valueText);
            }
            
            if (HasUnit)
            {
                parts.Add(Unit?.Value);
            }
            else if (HasCode)
            {
                parts.Add(Code?.Value);
            }
            
            return parts.Any() ? string.Join(" ", parts) : null;
        }
    }

    protected override void CopyFieldsTo(Count target)
    {
        target.Value = Value?.DeepCopy() as FhirDecimal;
        target.Comparator = Comparator?.DeepCopy() as FhirCode;
        target.Unit = Unit?.DeepCopy() as FhirString;
        target.System = System?.DeepCopy() as FhirUri;
        target.Code = Code?.DeepCopy() as FhirCode;
    }

    protected override bool FieldsAreExactly(Count other)
    {
        return DeepEqualityComparer.AreEqual(Value, other.Value) &&
               DeepEqualityComparer.AreEqual(Comparator, other.Comparator) &&
               DeepEqualityComparer.AreEqual(Unit, other.Unit) &&
               DeepEqualityComparer.AreEqual(System, other.System) &&
               DeepEqualityComparer.AreEqual(Code, other.Code);
    }

    protected override IEnumerable<ValidationResult> ValidateFields(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();

        // 驗證 Value
        if (Value != null)
        {
            results.AddRange(Value.Validate(validationContext));
        }

        // 驗證 Comparator
        if (Comparator != null)
        {
            results.AddRange(Comparator.Validate(validationContext));
        }

        // 驗證 Unit
        if (Unit != null)
        {
            results.AddRange(Unit.Validate(validationContext));
        }

        // 驗證 System
        if (System != null)
        {
            results.AddRange(System.Validate(validationContext));
        }

        // 驗證 Code
        if (Code != null)
        {
            results.AddRange(Code.Validate(validationContext));
        }

        return results;
    }
} 