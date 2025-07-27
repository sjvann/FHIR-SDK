using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Ratio - 比率型別
/// 用於在 FHIR 資源中表示兩個數量之間的比率
/// </summary>
/// <remarks>
/// FHIR R5 Ratio (Complex Type)
/// A relationship of two Quantity values - expressed as a numerator and a denominator.
/// 
/// Structure:
/// - numerator: Quantity (0..1) - Numerator value
/// - denominator: Quantity (0..1) - Denominator value
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Ratio : Element, IExtensibleTypeFramework
{
    /// <summary>
    /// 分子值
    /// FHIR Path: Ratio.numerator
    /// Cardinality: 0..1
    /// Type: Quantity
    /// </summary>
    [JsonPropertyName("numerator")]
    public Quantity? Numerator { get; set; }

    /// <summary>
    /// 分母值
    /// FHIR Path: Ratio.denominator
    /// Cardinality: 0..1
    /// Type: Quantity
    /// </summary>
    [JsonPropertyName("denominator")]
    public Quantity? Denominator { get; set; }

    /// <summary>
    /// 檢查是否有分子
    /// </summary>
    /// <returns>如果存在分子則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasNumerator => Numerator != null;

    /// <summary>
    /// 檢查是否有分母
    /// </summary>
    /// <returns>如果存在分母則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasDenominator => Denominator != null;

    /// <summary>
    /// 檢查比率是否有效
    /// </summary>
    /// <returns>如果比率有效則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool IsValid
    {
        get
        {
            if (!HasNumerator || !HasDenominator) return true; // 至少需要一個值
            
            // 如果兩個值都有，檢查分母是否不為零
            if (Denominator?.Value?.Value != null && Denominator.Value.Value == 0)
            {
                return false;
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

            if (HasNumerator)
            {
                parts.Add(Numerator?.DisplayText ?? "numerator");
            }

            parts.Add("/");

            if (HasDenominator)
            {
                parts.Add(Denominator?.DisplayText ?? "denominator");
            }

            return parts.Count > 0 ? string.Join(" ", parts) : null;
        }
    }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>Ratio 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = new Ratio
        {
            Id = Id,
            Numerator = Numerator?.DeepCopy() as Quantity,
            Denominator = Denominator?.DeepCopy() as Quantity
        };

        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 Ratio 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not Ratio otherRatio)
            return false;

        return base.IsExactly(other) &&
               Equals(Numerator, otherRatio.Numerator) &&
               Equals(Denominator, otherRatio.Denominator);
    }

    /// <summary>
    /// 驗證 Ratio 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證至少需要一個值
        if (!HasNumerator && !HasDenominator)
        {
            yield return new ValidationResult("Ratio must have at least one value (numerator or denominator)");
        }

        // 驗證分母不能為零
        if (HasDenominator && Denominator?.Value?.Value == 0)
        {
            yield return new ValidationResult("Ratio denominator cannot be zero");
        }

        // 驗證分子（如果提供）
        if (Numerator != null)
        {
            var numeratorValidationContext = new ValidationContext(Numerator);
            foreach (var numeratorResult in Numerator.Validate(numeratorValidationContext))
            {
                yield return numeratorResult;
            }
        }

        // 驗證分母（如果提供）
        if (Denominator != null)
        {
            var denominatorValidationContext = new ValidationContext(Denominator);
            foreach (var denominatorResult in Denominator.Validate(denominatorValidationContext))
            {
                yield return denominatorResult;
            }
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
} 