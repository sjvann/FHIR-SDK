using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
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
public class Money : Element, IExtensibleTypeFramework
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
                parts.Add(Value?.Value.ToString());
            }

            if (HasCurrency)
            {
                parts.Add(Currency?.Value);
            }

            return parts.Count > 0 ? string.Join(" ", parts) : null;
        }
    }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>Money 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = new Money
        {
            Id = Id,
            Value = Value?.DeepCopy() as FhirDecimal,
            Currency = Currency?.DeepCopy() as FhirCode
        };

        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 Money 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not Money otherMoney)
            return false;

        return base.IsExactly(other) &&
               Equals(Value, otherMoney.Value) &&
               Equals(Currency, otherMoney.Currency);
    }

    /// <summary>
    /// 驗證 Money 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證貨幣代碼（如果提供）
        if (!string.IsNullOrEmpty(Currency?.Value))
        {
            // 驗證是否為有效的 ISO 4217 貨幣代碼（3 字母）
            if (Currency.Value.Length != 3 || !Currency.Value.All(char.IsLetter))
            {
                yield return new ValidationResult("Money currency must be a valid 3-letter ISO 4217 currency code");
            }
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
} 