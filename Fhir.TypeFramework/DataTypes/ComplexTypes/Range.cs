using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Range - 範圍型別
/// 用於在 FHIR 資源中表示範圍
/// </summary>
/// <remarks>
/// FHIR R5 Range (Complex Type)
/// A set of ordered Quantities defined by a low and high limit.
/// 
/// Structure:
/// - low: Quantity (0..1) - Low limit
/// - high: Quantity (0..1) - High limit
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Range : UnifiedComplexTypeBase<Range>
{
    /// <summary>
    /// 下限
    /// FHIR Path: Range.low
    /// Cardinality: 0..1
    /// Type: Quantity
    /// </summary>
    [JsonPropertyName("low")]
    public Quantity? Low { get; set; }

    /// <summary>
    /// 上限
    /// FHIR Path: Range.high
    /// Cardinality: 0..1
    /// Type: Quantity
    /// </summary>
    [JsonPropertyName("high")]
    public Quantity? High { get; set; }

    /// <summary>
    /// 檢查是否有下限
    /// </summary>
    /// <returns>如果存在下限則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasLow => Low != null;

    /// <summary>
    /// 檢查是否有上限
    /// </summary>
    /// <returns>如果存在上限則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasHigh => High != null;

    /// <summary>
    /// 檢查範圍是否有效
    /// </summary>
    /// <returns>如果範圍有效則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool IsValid
    {
        get
        {
            if (!HasLow && !HasHigh)
                return false;

            if (HasLow && HasHigh)
            {
                // 檢查低值是否小於等於高值
                if (Low?.Value?.Value != null && High?.Value?.Value != null)
                {
                    return Low.Value.Value <= High.Value.Value;
                }
            }

            return true;
        }
    }

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
            
            if (HasLow)
            {
                parts.Add($"≥{Low?.DisplayText}");
            }
            
            if (HasHigh)
            {
                parts.Add($"≤{High?.DisplayText}");
            }
            
            return parts.Any() ? string.Join(" ", parts) : null;
        }
    }

    protected override void CopyFieldsTo(Range target)
    {
        target.Low = Low?.DeepCopy() as Quantity;
        target.High = High?.DeepCopy() as Quantity;
    }

    protected override bool FieldsAreExactly(Range other)
    {
        return DeepEqualityComparer.AreEqual(Low, other.Low) &&
               DeepEqualityComparer.AreEqual(High, other.High);
    }

    protected override IEnumerable<ValidationResult> ValidateFields(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();

        // 驗證 Low
        if (Low != null)
        {
            results.AddRange(Low.Validate(validationContext));
        }

        // 驗證 High
        if (High != null)
        {
            results.AddRange(High.Validate(validationContext));
        }

        // 驗證範圍邏輯
        if (HasLow && HasHigh)
        {
            if (Low?.Value?.Value != null && High?.Value?.Value != null)
            {
                if (Low.Value.Value > High.Value.Value)
                {
                    results.Add(new ValidationResult("Range low value cannot be greater than high value"));
                }
            }
        }

        return results;
    }
} 