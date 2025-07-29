using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.DataTypes.ComplexTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.Bases;

/// <summary>
/// 泛型 Primitive Type 基礎類別
/// 提供所有 Primitive Type 的通用實作
/// </summary>
/// <typeparam name="TValue">原始值的型別</typeparam>
/// <remarks>
/// 這個基礎類別提供：
/// - 統一的建構函式模式
/// - 隱式轉換運算子
/// - 通用的深層複製邏輯
/// - 統一的相等性比較
/// - 基礎驗證框架
/// </remarks>
public abstract class PrimitiveTypeBase<TValue> : PrimitiveType
{
    /// <summary>
    /// 原始值
    /// </summary>
    protected TValue? _value;

    /// <summary>
    /// 原始值屬性
    /// </summary>
    [JsonIgnore]
    public TValue? Value
    {
        get => _value;
        set
        {
            _value = value;
            StringValue = ValueToString(value);
        }
    }

    /// <summary>
    /// 預設建構函式
    /// </summary>
    protected PrimitiveTypeBase() { }

    /// <summary>
    /// 帶值的建構函式
    /// </summary>
    /// <param name="value">初始值</param>
    protected PrimitiveTypeBase(TValue? value)
    {
        Value = value;
    }

    /// <summary>
    /// 從字串解析值
    /// </summary>
    /// <param name="value">要解析的字串</param>
    /// <returns>解析後的值</returns>
    public override object? ParseValue(string value)
    {
        return ParseValueInternal(value);
    }

    /// <summary>
    /// 將值轉換為字串
    /// </summary>
    /// <param name="value">要轉換的值</param>
    /// <returns>值的字串表示</returns>
    public override string? ValueToString(object? value)
    {
        if (value is TValue typedValue)
        {
            return ValueToStringInternal(typedValue);
        }
        return value?.ToString();
    }

    /// <summary>
    /// 驗證值是否符合 FHIR 規範
    /// </summary>
    /// <param name="value">要驗證的值</param>
    /// <returns>如果值符合規範則為 true，否則為 false</returns>
    public override bool IsValidValue(object? value)
    {
        if (value is TValue typedValue)
        {
            return IsValidValueInternal(typedValue);
        }
        return value == null;
    }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>PrimitiveTypeBase 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = (PrimitiveTypeBase<TValue>)MemberwiseClone();
        copy._value = _value;
        
        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not PrimitiveTypeBase<TValue> otherTyped)
            return false;

        return base.IsExactly(other) && 
               EqualityComparer<TValue>.Default.Equals(_value, otherTyped._value);
    }

    /// <summary>
    /// 驗證 PrimitiveTypeBase 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證值
        if (!IsValidValueInternal(_value))
        {
            yield return new ValidationResult($"Invalid value for {GetType().Name}: {_value}");
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }

    // ============================================================================
    // 抽象方法 - 子類別必須實作
    // ============================================================================

    /// <summary>
    /// 從字串解析值（內部實作）
    /// </summary>
    /// <param name="value">要解析的字串</param>
    /// <returns>解析後的值</returns>
    protected abstract TValue? ParseValueInternal(string value);

    /// <summary>
    /// 將值轉換為字串（內部實作）
    /// </summary>
    /// <param name="value">要轉換的值</param>
    /// <returns>值的字串表示</returns>
    protected abstract string? ValueToStringInternal(TValue? value);

    /// <summary>
    /// 驗證值是否符合 FHIR 規範（內部實作）
    /// </summary>
    /// <param name="value">要驗證的值</param>
    /// <returns>如果值符合規範則為 true，否則為 false</returns>
    protected abstract bool IsValidValueInternal(TValue? value);

    // ============================================================================
    // 通用工廠方法
    // ============================================================================

    /// <summary>
    /// 從字串建立實例
    /// </summary>
    /// <typeparam name="T">目標型別</typeparam>
    /// <param name="value">字串值</param>
    /// <returns>建立的實例</returns>
    protected static T? CreateFromString<T>(string? value) where T : PrimitiveTypeBase<TValue>, new()
    {
        if (value == null) return null;
        
        var instance = new T();
        instance.StringValue = value;
        return instance;
    }

    /// <summary>
    /// 從原始值建立實例
    /// </summary>
    /// <typeparam name="T">目標型別</typeparam>
    /// <param name="value">原始值</param>
    /// <returns>建立的實例</returns>
    protected static T? CreateFromValue<T>(TValue? value) where T : PrimitiveTypeBase<TValue>, new()
    {
        if (value == null) return null;
        
        var instance = new T();
        instance.Value = value;
        return instance;
    }

    /// <summary>
    /// 取得字串值
    /// </summary>
    /// <typeparam name="T">來源型別</typeparam>
    /// <param name="instance">實例</param>
    /// <returns>字串值</returns>
    protected static string? GetStringValue<T>(T? instance) where T : PrimitiveTypeBase<TValue>
    {
        return instance?.StringValue;
    }

    /// <summary>
    /// 取得原始值
    /// </summary>
    /// <typeparam name="T">來源型別</typeparam>
    /// <param name="instance">實例</param>
    /// <returns>原始值</returns>
    protected static TValue? GetValue<T>(T? instance) where T : PrimitiveTypeBase<TValue>
    {
        return instance?.Value;
    }
} 