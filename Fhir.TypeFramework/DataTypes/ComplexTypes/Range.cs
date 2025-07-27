using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
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
public class Range : Element, IExtensibleTypeFramework
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
            if (!HasLow || !HasHigh) return true; // 至少需要一個邊界
            
            // 如果兩個邊界都有值，檢查它們是否相容
            if (Low?.Value != null && High?.Value != null)
            {
                return Low.Value <= High.Value;
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
                parts.Add(Low?.DisplayText ?? "low");
            }
            
            parts.Add("-");
            
            if (HasHigh)
            {
                parts.Add(High?.DisplayText ?? "high");
            }
            
            return parts.Count > 0 ? string.Join(" ", parts) : null;
        }
    }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>Range 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = new Range
        {
            Id = Id,
            Low = Low?.DeepCopy() as Quantity,
            High = High?.DeepCopy() as Quantity
        };

        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 Range 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not Range otherRange)
            return false;

        return base.IsExactly(other) &&
               Equals(Low, otherRange.Low) &&
               Equals(High, otherRange.High);
    }

    /// <summary>
    /// 驗證 Range 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證至少需要一個邊界
        if (!HasLow && !HasHigh)
        {
            yield return new ValidationResult("Range must have at least one boundary (low or high)");
        }

        // 驗證範圍的有效性
        if (HasLow && HasHigh && Low?.Value != null && High?.Value != null)
        {
            if (Low.Value > High.Value)
            {
                yield return new ValidationResult("Range low value cannot be greater than high value");
            }
        }

        // 驗證下限（如果提供）
        if (Low != null)
        {
            var lowValidationContext = new ValidationContext(Low);
            foreach (var lowResult in Low.Validate(lowValidationContext))
            {
                yield return lowResult;
            }
        }

        // 驗證上限（如果提供）
        if (High != null)
        {
            var highValidationContext = new ValidationContext(High);
            foreach (var highResult in High.Validate(highValidationContext))
            {
                yield return highResult;
            }
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
} 