using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Ratio - 比率型別
/// 用於在 FHIR 資源中表示比率
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
public class Ratio : UnifiedComplexTypeBase<Ratio>
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
    public bool IsValid => HasNumerator && HasDenominator;

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

            var numeratorText = Numerator?.DisplayText ?? "0";
            var denominatorText = Denominator?.DisplayText ?? "1";

            return $"{numeratorText}/{denominatorText}";
        }
    }

    protected override void CopyFieldsTo(Ratio target)
    {
        target.Numerator = Numerator?.DeepCopy() as Quantity;
        target.Denominator = Denominator?.DeepCopy() as Quantity;
    }

    protected override bool FieldsAreExactly(Ratio other)
    {
        return DeepEqualityComparer.AreEqual(Numerator, other.Numerator) &&
               DeepEqualityComparer.AreEqual(Denominator, other.Denominator);
    }

    protected override IEnumerable<ValidationResult> ValidateFields(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();

        // 驗證 Numerator
        if (Numerator != null)
        {
            results.AddRange(Numerator.Validate(validationContext));
        }

        // 驗證 Denominator
        if (Denominator != null)
        {
            results.AddRange(Denominator.Validate(validationContext));
        }

        // 驗證比率邏輯
        if (HasNumerator && HasDenominator)
        {
            if (Denominator?.Value?.Value != null && Denominator.Value.Value == 0)
            {
                results.Add(new ValidationResult("Ratio denominator cannot be zero"));
            }
        }

        return results;
    }
} 