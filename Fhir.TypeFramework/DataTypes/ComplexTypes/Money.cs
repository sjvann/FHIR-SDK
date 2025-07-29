using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Money - 金錢型別
/// 用於在 FHIR 資源中表示金錢金額
/// </summary>
/// <remarks>
/// FHIR R5 Money (Complex Type)
/// An amount of economic utility in some recognized currency.
/// 
/// Structure:
/// - value: decimal (0..1) - Numerical value (with implicit precision)
/// - currency: code (0..1) - ISO 4217 Currency Code
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Money : UnifiedComplexTypeBase<Money>
{
    /// <summary>
    /// 數值（具有隱含精度）
    /// FHIR Path: Money.value
    /// Cardinality: 0..1
    /// Type: decimal
    /// </summary>
    [JsonPropertyName("value")]
    public FhirDecimal? Value { get; set; }

    /// <summary>
    /// ISO 4217 貨幣代碼
    /// FHIR Path: Money.currency
    /// Cardinality: 0..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("currency")]
    public FhirCode? Currency { get; set; }

    /// <summary>
    /// 檢查是否有值
    /// </summary>
    /// <returns>如果存在值則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasValue => Value?.Value != null;

    /// <summary>
    /// 檢查是否有貨幣
    /// </summary>
    /// <returns>如果存在貨幣則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasCurrency => !string.IsNullOrEmpty(Currency?.Value);

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
                parts.Add(Value?.Value?.ToString());
            }
            
            if (HasCurrency)
            {
                parts.Add(Currency?.Value);
            }
            
            return parts.Any() ? string.Join(" ", parts) : null;
        }
    }

    protected override void CopyFieldsTo(Money target)
    {
        target.Value = Value?.DeepCopy() as FhirDecimal;
        target.Currency = Currency?.DeepCopy() as FhirCode;
    }

    protected override bool FieldsAreExactly(Money other)
    {
        return DeepEqualityComparer.AreEqual(Value, other.Value) &&
               DeepEqualityComparer.AreEqual(Currency, other.Currency);
    }

    protected override IEnumerable<ValidationResult> ValidateFields(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();

        // 驗證 Value
        if (Value != null)
        {
            results.AddRange(Value.Validate(validationContext));
        }

        // 驗證 Currency
        if (Currency != null)
        {
            results.AddRange(Currency.Validate(validationContext));
        }

        return results;
    }
} 