using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Converters;

namespace Fhir.R4.Models.Base;

/// <summary>
/// 單一型別的 Choice Type
/// 用於處理 FHIR 的 [x] 型別，確保型別安全和互斥性
/// </summary>
[JsonConverter(typeof(ChoiceTypeConverter))]
public class ChoiceType<T1> : IChoiceType where T1 : class
{
    private T1? _value1;
    
    /// <summary>
    /// 第一個型別的值
    /// </summary>
    [JsonIgnore]
    public T1? Value1 
    { 
        get => _value1;
        set => _value1 = value;
    }
    
    /// <summary>
    /// 統一的值存取介面
    /// </summary>
    [JsonIgnore]
    public object? Value 
    { 
        get => Value1;
        set => SetValue(value);
    }
    
    /// <summary>
    /// 目前設定的值型別名稱
    /// </summary>
    [JsonIgnore]
    public string? ValueTypeName 
    {
        get
        {
            if (Value1 != null) return GetTypeName<T1>();
            return null;
        }
    }
    
    /// <summary>
    /// 檢查是否有設定值
    /// </summary>
    [JsonIgnore]
    public bool HasValue => Value1 != null;
    
    /// <summary>
    /// 清除所有值
    /// </summary>
    public void ClearValue()
    {
        Value1 = null;
    }
    
    /// <summary>
    /// 取得允許的型別列表
    /// </summary>
    public string[] GetAllowedTypes()
    {
        return new[] { GetTypeName<T1>() };
    }
    
    /// <summary>
    /// 檢查指定型別是否被允許
    /// </summary>
    public bool IsAllowedType<T>() => typeof(T) == typeof(T1);
    
    /// <summary>
    /// 檢查指定型別是否被允許
    /// </summary>
    public bool IsAllowedType(Type type) => type == typeof(T1);
    
    /// <summary>
    /// 設定值（型別安全）
    /// </summary>
    private void SetValue(object? value)
    {
        ClearValue();
        
        switch (value)
        {
            case null:
                break;
            case T1 v1:
                Value1 = v1;
                break;
            default:
                throw new ArgumentException($"Invalid type {value.GetType().Name}. Allowed types: {string.Join(", ", GetAllowedTypes())}");
        }
    }
    
    /// <summary>
    /// 型別安全的取值方法
    /// </summary>
    public T1? As<T>() where T : class, T1 => Value1 as T;
    
    /// <summary>
    /// 檢查是否為指定型別
    /// </summary>
    public bool Is<T>() where T : class => Value1 is T;
    
    /// <summary>
    /// 驗證 Choice Type
    /// </summary>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // Choice Type 必須有且只有一個值
        var valueCount = (Value1 != null ? 1 : 0);
        
        if (valueCount == 0)
        {
            yield return new ValidationResult("Choice type must have exactly one value");
        }
        else if (valueCount > 1)
        {
            yield return new ValidationResult("Choice type must have exactly one value, but multiple values are set");
        }
    }
    
    /// <summary>
    /// 隱式轉換
    /// </summary>
    public static implicit operator ChoiceType<T1>?(T1? value)
    {
        if (value == null) return null;
        return new ChoiceType<T1> { Value1 = value };
    }
    
    /// <summary>
    /// 明確轉換為 T1 型別
    /// </summary>
    public static explicit operator T1?(ChoiceType<T1>? choice) => choice?.Value1;
    
    private static string GetTypeName<T>()
    {
        var type = typeof(T);
        
        // 處理 FHIR Primitive Types
        if (type.Name.StartsWith("Fhir"))
        {
            return type.Name.Substring(4).ToLowerInvariant(); // FhirString -> string
        }
        
        // 處理一般型別
        return type.Name.ToLowerInvariant();
    }
}

/// <summary>
/// 雙型別的 Choice Type
/// 確保同時只能設定一個值，提供型別安全的存取
/// </summary>
[JsonConverter(typeof(ChoiceTypeConverter))]
public class ChoiceType<T1, T2> : IChoiceType 
    where T1 : class 
    where T2 : class
{
    private T1? _value1;
    private T2? _value2;
    
    /// <summary>
    /// 第一個型別的值
    /// </summary>
    [JsonIgnore]
    public T1? Value1
    { 
        get => _value1;
        set 
        {
            if (value != null) ClearOtherValues(1);
            _value1 = value;
        }
    }
    
    [JsonIgnore]
    public T2? Value2 
    { 
        get => _value2;
        set 
        {
            if (value != null) ClearOtherValues(2);
            _value2 = value;
        }
    }
    
    [JsonIgnore]
    public object? Value 
    { 
        get => Value1 ?? (object?)Value2;
        set => SetValue(value);
    }
    
    [JsonIgnore]
    public string? ValueTypeName 
    {
        get
        {
            if (Value1 != null) return GetTypeName<T1>();
            if (Value2 != null) return GetTypeName<T2>();
            return null;
        }
    }
    
    [JsonIgnore]
    public bool HasValue => Value1 != null || Value2 != null;
    
    public void ClearValue()
    {
        Value1 = null;
        Value2 = null;
    }
    
    private void ClearOtherValues(int except)
    {
        if (except != 1) Value1 = null;
        if (except != 2) Value2 = null;
    }
    
    public string[] GetAllowedTypes()
    {
        return new[] { GetTypeName<T1>(), GetTypeName<T2>() };
    }
    
    public bool IsAllowedType<T>() => typeof(T) == typeof(T1) || typeof(T) == typeof(T2);
    
    public bool IsAllowedType(Type type) => type == typeof(T1) || type == typeof(T2);
    
    private void SetValue(object? value)
    {
        ClearValue();
        
        switch (value)
        {
            case null:
                break;
            case T1 v1:
                Value1 = v1;
                break;
            case T2 v2:
                Value2 = v2;
                break;
            default:
                throw new ArgumentException($"Invalid type {value.GetType().Name}. Allowed types: {string.Join(", ", GetAllowedTypes())}");
        }
    }
    
    // 型別安全的存取方法
    public T1? AsT1() => Value1;
    public T2? AsT2() => Value2;
    
    public bool IsT1() => Value1 != null;
    public bool IsT2() => Value2 != null;
    
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var valueCount = (Value1 != null ? 1 : 0) + (Value2 != null ? 1 : 0);
        
        if (valueCount == 0)
        {
            yield return new ValidationResult("Choice type must have exactly one value");
        }
        else if (valueCount > 1)
        {
            yield return new ValidationResult("Choice type must have exactly one value, but multiple values are set");
        }
    }
    
    // 隱式轉換
    public static implicit operator ChoiceType<T1, T2>?(T1? value)
    {
        if (value == null) return null;
        return new ChoiceType<T1, T2> { Value1 = value };
    }
    
    public static implicit operator ChoiceType<T1, T2>?(T2? value)
    {
        if (value == null) return null;
        return new ChoiceType<T1, T2> { Value2 = value };
    }
    
    private static string GetTypeName<T>()
    {
        var type = typeof(T);
        if (type.Name.StartsWith("Fhir"))
        {
            return type.Name.Substring(4).ToLowerInvariant();
        }
        return type.Name.ToLowerInvariant();
    }
}

/// <summary>
/// 三型別的 Choice Type
/// 確保同時只能設定一個值，提供型別安全的存取
/// </summary>
[JsonConverter(typeof(ChoiceTypeConverter))]
public class ChoiceType<T1, T2, T3> : IChoiceType
    where T1 : class
    where T2 : class
    where T3 : class
{
    private T1? _value1;
    private T2? _value2;
    private T3? _value3;

    [JsonIgnore]
    public T1? Value1
    {
        get => _value1;
        set
        {
            if (value != null) ClearOtherValues(1);
            _value1 = value;
        }
    }

    [JsonIgnore]
    public T2? Value2
    {
        get => _value2;
        set
        {
            if (value != null) ClearOtherValues(2);
            _value2 = value;
        }
    }

    [JsonIgnore]
    public T3? Value3
    {
        get => _value3;
        set
        {
            if (value != null) ClearOtherValues(3);
            _value3 = value;
        }
    }

    [JsonIgnore]
    public object? Value
    {
        get => Value1 ?? Value2 ?? (object?)Value3;
        set => SetValue(value);
    }

    [JsonIgnore]
    public string? ValueTypeName
    {
        get
        {
            if (Value1 != null) return GetTypeName<T1>();
            if (Value2 != null) return GetTypeName<T2>();
            if (Value3 != null) return GetTypeName<T3>();
            return null;
        }
    }

    [JsonIgnore]
    public bool HasValue => Value1 != null || Value2 != null || Value3 != null;

    public void ClearValue()
    {
        Value1 = null;
        Value2 = null;
        Value3 = null;
    }

    private void ClearOtherValues(int except)
    {
        if (except != 1) Value1 = null;
        if (except != 2) Value2 = null;
        if (except != 3) Value3 = null;
    }

    public string[] GetAllowedTypes()
    {
        return new[] { GetTypeName<T1>(), GetTypeName<T2>(), GetTypeName<T3>() };
    }

    public bool IsAllowedType<T>() => typeof(T) == typeof(T1) || typeof(T) == typeof(T2) || typeof(T) == typeof(T3);

    public bool IsAllowedType(Type type) => type == typeof(T1) || type == typeof(T2) || type == typeof(T3);

    private void SetValue(object? value)
    {
        ClearValue();

        switch (value)
        {
            case null:
                break;
            case T1 v1:
                Value1 = v1;
                break;
            case T2 v2:
                Value2 = v2;
                break;
            case T3 v3:
                Value3 = v3;
                break;
            default:
                throw new ArgumentException($"Invalid type {value.GetType().Name}. Allowed types: {string.Join(", ", GetAllowedTypes())}");
        }
    }

    // 型別安全的存取方法
    public T1? AsT1() => Value1;
    public T2? AsT2() => Value2;
    public T3? AsT3() => Value3;

    public bool IsT1() => Value1 != null;
    public bool IsT2() => Value2 != null;
    public bool IsT3() => Value3 != null;

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var valueCount = (Value1 != null ? 1 : 0) + (Value2 != null ? 1 : 0) + (Value3 != null ? 1 : 0);

        if (valueCount == 0)
        {
            yield return new ValidationResult("Choice type must have exactly one value");
        }
        else if (valueCount > 1)
        {
            yield return new ValidationResult("Choice type must have exactly one value, but multiple values are set");
        }
    }

    // 隱式轉換
    public static implicit operator ChoiceType<T1, T2, T3>?(T1? value)
    {
        if (value == null) return null;
        return new ChoiceType<T1, T2, T3> { Value1 = value };
    }

    public static implicit operator ChoiceType<T1, T2, T3>?(T2? value)
    {
        if (value == null) return null;
        return new ChoiceType<T1, T2, T3> { Value2 = value };
    }

    public static implicit operator ChoiceType<T1, T2, T3>?(T3? value)
    {
        if (value == null) return null;
        return new ChoiceType<T1, T2, T3> { Value3 = value };
    }

    private static string GetTypeName<T>()
    {
        var type = typeof(T);
        if (type.Name.StartsWith("Fhir"))
        {
            return type.Name.Substring(4).ToLowerInvariant();
        }
        return type.Name.ToLowerInvariant();
    }
}

/// <summary>
/// 四型別的 Choice Type
/// 確保同時只能設定一個值，提供型別安全的存取
/// </summary>
[JsonConverter(typeof(ChoiceTypeConverter))]
public class ChoiceType<T1, T2, T3, T4> : IChoiceType
    where T1 : class
    where T2 : class
    where T3 : class
    where T4 : class
{
    private T1? _value1;
    private T2? _value2;
    private T3? _value3;
    private T4? _value4;

    [JsonIgnore]
    public T1? Value1
    {
        get => _value1;
        set
        {
            if (value != null) ClearOtherValues(1);
            _value1 = value;
        }
    }

    [JsonIgnore]
    public T2? Value2
    {
        get => _value2;
        set
        {
            if (value != null) ClearOtherValues(2);
            _value2 = value;
        }
    }

    [JsonIgnore]
    public T3? Value3
    {
        get => _value3;
        set
        {
            if (value != null) ClearOtherValues(3);
            _value3 = value;
        }
    }

    [JsonIgnore]
    public T4? Value4
    {
        get => _value4;
        set
        {
            if (value != null) ClearOtherValues(4);
            _value4 = value;
        }
    }

    [JsonIgnore]
    public object? Value
    {
        get => Value1 ?? Value2 ?? Value3 ?? (object?)Value4;
        set => SetValue(value);
    }

    [JsonIgnore]
    public string? ValueTypeName
    {
        get
        {
            if (Value1 != null) return GetTypeName<T1>();
            if (Value2 != null) return GetTypeName<T2>();
            if (Value3 != null) return GetTypeName<T3>();
            if (Value4 != null) return GetTypeName<T4>();
            return null;
        }
    }

    [JsonIgnore]
    public bool HasValue => Value1 != null || Value2 != null || Value3 != null || Value4 != null;

    public void ClearValue()
    {
        Value1 = null;
        Value2 = null;
        Value3 = null;
        Value4 = null;
    }

    private void ClearOtherValues(int except)
    {
        if (except != 1) Value1 = null;
        if (except != 2) Value2 = null;
        if (except != 3) Value3 = null;
        if (except != 4) Value4 = null;
    }

    public string[] GetAllowedTypes()
    {
        return new[] { GetTypeName<T1>(), GetTypeName<T2>(), GetTypeName<T3>(), GetTypeName<T4>() };
    }

    public bool IsAllowedType<T>() => typeof(T) == typeof(T1) || typeof(T) == typeof(T2) || typeof(T) == typeof(T3) || typeof(T) == typeof(T4);

    public bool IsAllowedType(Type type) => type == typeof(T1) || type == typeof(T2) || type == typeof(T3) || type == typeof(T4);

    private void SetValue(object? value)
    {
        ClearValue();

        switch (value)
        {
            case null:
                break;
            case T1 v1:
                Value1 = v1;
                break;
            case T2 v2:
                Value2 = v2;
                break;
            case T3 v3:
                Value3 = v3;
                break;
            case T4 v4:
                Value4 = v4;
                break;
            default:
                throw new ArgumentException($"Invalid type {value.GetType().Name}. Allowed types: {string.Join(", ", GetAllowedTypes())}");
        }
    }

    // 型別安全的存取方法
    public T1? AsT1() => Value1;
    public T2? AsT2() => Value2;
    public T3? AsT3() => Value3;
    public T4? AsT4() => Value4;

    public bool IsT1() => Value1 != null;
    public bool IsT2() => Value2 != null;
    public bool IsT3() => Value3 != null;
    public bool IsT4() => Value4 != null;

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var valueCount = (Value1 != null ? 1 : 0) + (Value2 != null ? 1 : 0) + (Value3 != null ? 1 : 0) + (Value4 != null ? 1 : 0);

        if (valueCount == 0)
        {
            yield return new ValidationResult("Choice type must have exactly one value");
        }
        else if (valueCount > 1)
        {
            yield return new ValidationResult("Choice type must have exactly one value, but multiple values are set");
        }
    }

    // 隱式轉換
    public static implicit operator ChoiceType<T1, T2, T3, T4>?(T1? value)
    {
        if (value == null) return null;
        return new ChoiceType<T1, T2, T3, T4> { Value1 = value };
    }

    public static implicit operator ChoiceType<T1, T2, T3, T4>?(T2? value)
    {
        if (value == null) return null;
        return new ChoiceType<T1, T2, T3, T4> { Value2 = value };
    }

    public static implicit operator ChoiceType<T1, T2, T3, T4>?(T3? value)
    {
        if (value == null) return null;
        return new ChoiceType<T1, T2, T3, T4> { Value3 = value };
    }

    public static implicit operator ChoiceType<T1, T2, T3, T4>?(T4? value)
    {
        if (value == null) return null;
        return new ChoiceType<T1, T2, T3, T4> { Value4 = value };
    }

    private static string GetTypeName<T>()
    {
        var type = typeof(T);
        if (type.Name.StartsWith("Fhir"))
        {
            return type.Name.Substring(4).ToLowerInvariant();
        }
        return type.Name.ToLowerInvariant();
    }
}
