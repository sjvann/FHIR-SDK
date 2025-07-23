using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Attributes;
using Fhir.Support.Interfaces;

namespace Fhir.Support.Base;

/// <summary>
/// FHIR 基礎型別的基底類別，提供與 C# 原生型別的轉換機制
/// </summary>
/// <typeparam name="T">對應的 C# 原生型別</typeparam>
public abstract class FhirPrimitiveType<T> : Element
{
    /// <summary>
    /// 原始值
    /// </summary>
    [JsonPropertyName("value")]
    public T? Value { get; set; }

    /// <summary>
    /// 建構函式
    /// </summary>
    protected FhirPrimitiveType() { }

    /// <summary>
    /// 建構函式
    /// </summary>
    /// <param name="value">初始值</param>
    protected FhirPrimitiveType(T? value)
    {
        Value = value;
    }

    /// <summary>
    /// 隱式轉換到原生型別
    /// </summary>
    /// <param name="fhirType">FHIR 型別實例</param>
    public static implicit operator T(FhirPrimitiveType<T>? fhirType)
    {
        return fhirType != null ? fhirType.Value : default(T)!;
    }

    /// <summary>
    /// 檢查是否有值
    /// </summary>
    public bool HasValue => Value != null;

    /// <summary>
    /// 檢查是否為空
    /// </summary>
    public bool IsEmpty => Value == null && (Extension?.Count ?? 0) == 0;

    /// <summary>
    /// 轉換為字串
    /// </summary>
    /// <returns>字串表示</returns>
    public override string ToString()
    {
        return Value?.ToString() ?? string.Empty;
    }

    /// <summary>
    /// 驗證基礎型別
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果</returns>
    public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 子類別可以覆寫此方法來添加特定的驗證邏輯
        foreach (var result in ValidateValue(validationContext))
            yield return result;
    }

    /// <summary>
    /// 驗證值的具體邏輯，由子類別實現
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果</returns>
    protected virtual IEnumerable<ValidationResult> ValidateValue(ValidationContext validationContext)
    {
        yield break;
    }

    /// <summary>
    /// 相等比較
    /// </summary>
    /// <param name="obj">比較對象</param>
    /// <returns>是否相等</returns>
    public override bool Equals(object? obj)
    {
        if (obj is FhirPrimitiveType<T> other)
        {
            return EqualityComparer<T>.Default.Equals(Value, other.Value);
        }
        if (obj is T directValue)
        {
            return EqualityComparer<T>.Default.Equals(Value, directValue);
        }
        return false;
    }

    /// <summary>
    /// 取得雜湊碼
    /// </summary>
    /// <returns>雜湊碼</returns>
    public override int GetHashCode()
    {
        return Value?.GetHashCode() ?? 0;
    }
}

/// <summary>
/// FHIR 字串型別基底類別，提供額外的字串操作
/// </summary>
public abstract class FhirStringType : FhirPrimitiveType<string>
{
    /// <summary>
    /// 建構函式
    /// </summary>
    protected FhirStringType() { }

    /// <summary>
    /// 建構函式
    /// </summary>
    /// <param name="value">初始值</param>
    protected FhirStringType(string? value) : base(value) { }

    /// <summary>
    /// 檢查是否為空或空白
    /// </summary>
    public bool IsNullOrWhiteSpace => string.IsNullOrWhiteSpace(Value);

    /// <summary>
    /// 取得長度
    /// </summary>
    public int Length => Value?.Length ?? 0;

    /// <summary>
    /// 轉換為小寫
    /// </summary>
    /// <returns>小寫字串</returns>
    public string ToLower() => Value?.ToLower() ?? string.Empty;

    /// <summary>
    /// 轉換為大寫
    /// </summary>
    /// <returns>大寫字串</returns>
    public string ToUpper() => Value?.ToUpper() ?? string.Empty;

    /// <summary>
    /// 修剪空白
    /// </summary>
    /// <returns>修剪後的字串</returns>
    public string Trim() => Value?.Trim() ?? string.Empty;

    /// <summary>
    /// 檢查是否包含指定字串
    /// </summary>
    /// <param name="value">要檢查的字串</param>
    /// <returns>是否包含</returns>
    public bool Contains(string value) => Value?.Contains(value) == true;

    /// <summary>
    /// 檢查是否以指定字串開始
    /// </summary>
    /// <param name="value">要檢查的字串</param>
    /// <returns>是否開始於</returns>
    public bool StartsWith(string value) => Value?.StartsWith(value) == true;

    /// <summary>
    /// 檢查是否以指定字串結束
    /// </summary>
    /// <param name="value">要檢查的字串</param>
    /// <returns>是否結束於</returns>
    public bool EndsWith(string value) => Value?.EndsWith(value) == true;
}

/// <summary>
/// FHIR 數值型別基底類別，提供額外的數值操作
/// </summary>
/// <typeparam name="T">數值型別</typeparam>
public abstract class FhirNumericType<T> : FhirPrimitiveType<T?> where T : struct, IComparable<T>
{
    /// <summary>
    /// 建構函式
    /// </summary>
    protected FhirNumericType() { }

    /// <summary>
    /// 建構函式
    /// </summary>
    /// <param name="value">初始值</param>
    protected FhirNumericType(T? value) : base(value) { }

    /// <summary>
    /// 比較值
    /// </summary>
    /// <param name="other">比較對象</param>
    /// <returns>比較結果</returns>
    public int CompareTo(T? other)
    {
        if (!HasValue && !other.HasValue) return 0;
        if (!HasValue) return -1;
        if (!other.HasValue) return 1;
        return Value!.Value.CompareTo(other.Value);
    }

    /// <summary>
    /// 大於比較
    /// </summary>
    /// <param name="other">比較值</param>
    /// <returns>是否大於</returns>
    public bool IsGreaterThan(T other) => HasValue && Value!.Value.CompareTo(other) > 0;

    /// <summary>
    /// 小於比較
    /// </summary>
    /// <param name="other">比較值</param>
    /// <returns>是否小於</returns>
    public bool IsLessThan(T other) => HasValue && Value!.Value.CompareTo(other) < 0;

    /// <summary>
    /// 等於比較
    /// </summary>
    /// <param name="other">比較值</param>
    /// <returns>是否等於</returns>
    public bool IsEqualTo(T other) => HasValue && Value!.Value.CompareTo(other) == 0;
}
