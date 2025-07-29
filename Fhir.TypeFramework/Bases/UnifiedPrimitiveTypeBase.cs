using Fhir.TypeFramework.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.Bases;

/// <summary>
/// 統一的 Primitive Type 基礎類別
/// 提供所有 Primitive Type 的通用實作，使用泛型支援不同型別
/// </summary>
/// <typeparam name="TValue">值的型別</typeparam>
/// <remarks>
/// 這個統一的基礎類別可以取代：
/// - StringPrimitiveTypeBase
/// - BooleanPrimitiveTypeBase
/// - NumericPrimitiveTypeBase<TNumeric>
/// - DateTimePrimitiveTypeBase<TDateTime>
/// 
/// 提供統一的：
/// - 值儲存和存取
/// - 建構函式模式
/// - 隱式轉換運算子
/// - 驗證框架
/// - 型別安全的泛型約束
/// </remarks>
public abstract class UnifiedPrimitiveTypeBase<TValue> : PrimitiveTypeBase<TValue>
    where TValue : struct, IEquatable<TValue>
{
    /// <summary>
    /// 預設建構函式
    /// </summary>
    protected UnifiedPrimitiveTypeBase() { }

    /// <summary>
    /// 帶值的建構函式
    /// </summary>
    /// <param name="value">值</param>
    protected UnifiedPrimitiveTypeBase(TValue? value) : base(value) { }

    /// <summary>
    /// 從字串解析值（內部實作）
    /// </summary>
    /// <param name="value">要解析的字串</param>
    /// <returns>解析後的值</returns>
    protected override TValue? ParseValueInternal(string value)
    {
        return ParseValueFromString(value);
    }

    /// <summary>
    /// 將值轉換為字串（內部實作）
    /// </summary>
    /// <param name="value">要轉換的值</param>
    /// <returns>值的字串表示</returns>
    protected override string? ValueToStringInternal(TValue? value)
    {
        return ValueToString(value);
    }

    /// <summary>
    /// 驗證值是否符合 FHIR 規範
    /// </summary>
    /// <param name="value">要驗證的值</param>
    /// <returns>如果值符合規範則為 true，否則為 false</returns>
    protected override bool IsValidValueInternal(TValue? value)
    {
        if (value == null) return true;
        
        // 呼叫子類別的特定驗證邏輯
        return ValidateValue(value.Value);
    }

    /// <summary>
    /// 從字串解析值（子類別必須實作）
    /// </summary>
    /// <param name="value">要解析的字串</param>
    /// <returns>解析後的值</returns>
    protected abstract TValue? ParseValueFromString(string value);

    /// <summary>
    /// 將值轉換為字串（子類別必須實作）
    /// </summary>
    /// <param name="value">要轉換的值</param>
    /// <returns>值的字串表示</returns>
    protected abstract string? ValueToString(TValue? value);

    /// <summary>
    /// 驗證值（子類別必須實作）
    /// </summary>
    /// <param name="value">要驗證的值</param>
    /// <returns>如果值符合規範則為 true，否則為 false</returns>
    protected abstract bool ValidateValue(TValue value);

    // ============================================================================
    // 通用工廠方法
    // ============================================================================

    /// <summary>
    /// 從值建立實例
    /// </summary>
    /// <typeparam name="T">目標型別</typeparam>
    /// <param name="value">值</param>
    /// <returns>建立的實例</returns>
    protected static T? CreateFromValue<T>(TValue? value) where T : UnifiedPrimitiveTypeBase<TValue>, new()
    {
        if (value == null) return null;
        
        var instance = new T();
        instance.Value = value.Value;
        return instance;
    }

    /// <summary>
    /// 從字串建立實例
    /// </summary>
    /// <typeparam name="T">目標型別</typeparam>
    /// <param name="value">字串值</param>
    /// <returns>建立的實例</returns>
    protected static T? CreateFromString<T>(string? value) where T : UnifiedPrimitiveTypeBase<TValue>, new()
    {
        if (value == null) return null;
        
        var instance = new T();
        var parsedValue = instance.ParseValueFromString(value);
        if (parsedValue.HasValue)
        {
            instance.Value = parsedValue.Value;
        }
        return instance;
    }

    /// <summary>
    /// 取得值
    /// </summary>
    /// <typeparam name="T">來源型別</typeparam>
    /// <param name="instance">實例</param>
    /// <returns>值</returns>
    protected static TValue? GetValue<T>(T? instance) where T : UnifiedPrimitiveTypeBase<TValue>
    {
        return instance?.Value;
    }

    /// <summary>
    /// 取得字串值
    /// </summary>
    /// <typeparam name="T">來源型別</typeparam>
    /// <param name="instance">實例</param>
    /// <returns>字串值</returns>
    protected static string? GetStringValue<T>(T? instance) where T : UnifiedPrimitiveTypeBase<TValue>
    {
        return instance?.ValueToString(instance.Value);
    }
} 