# FHIR Choice Types 完整解決方案

## 🎯 Choice Types 複雜性分析

### FHIR Choice Types 的挑戰
1. **有限集合選擇** - 只能從預定義的型別中選一個（如 value[x] 可以是 string, integer, boolean 等）
2. **互斥性** - 同時只能設定一個值，其他必須為 null
3. **型別驗證** - 需要確保只設定了允許的型別
4. **JSON 序列化** - 需要正確的屬性名稱（valueString, valueInteger, valueBoolean）
5. **便利存取** - 需要統一的介面來存取不同型別的值

### 典型使用場景
```csharp
// Extension.value[x] 可以是多種型別
public class Extension : Base
{
    // ❌ 傳統做法：需要手動管理所有可能的型別
    public string? ValueString { get; set; }
    public int? ValueInteger { get; set; }
    public bool? ValueBoolean { get; set; }
    // ... 還有 20+ 種其他型別
    
    // ❌ 需要手動確保互斥性和驗證
}

// Observation.value[x] 也是 Choice Type
public class Observation : DomainResource
{
    public Quantity? ValueQuantity { get; set; }
    public CodeableConcept? ValueCodeableConcept { get; set; }
    public string? ValueString { get; set; }
    // ... 還有其他型別
}
```

## ✅ 解決方案：強型別 Choice Type 系統

### 策略 1：泛型 Choice Type（推薦）

#### 設計思路
```csharp
// 基礎 Choice Type 介面
public interface IChoiceType
{
    object? Value { get; set; }
    string? ValueTypeName { get; }
    bool HasValue { get; }
    void ClearValue();
}

// 強型別 Choice Type
public class ChoiceType<T1> : IChoiceType where T1 : class
{
    public T1? Value1 { get; set; }
    
    public object? Value 
    { 
        get => Value1;
        set => SetValue(value);
    }
}

// 多型別 Choice Type
public class ChoiceType<T1, T2> : IChoiceType 
    where T1 : class 
    where T2 : class
{
    public T1? Value1 { get; set; }
    public T2? Value2 { get; set; }
    
    public object? Value 
    { 
        get => Value1 ?? (object?)Value2;
        set => SetValue(value);
    }
}
```

#### 完整實作

##### IChoiceType.cs
```csharp
namespace Fhir.R4.Models.Base;

/// <summary>
/// Choice Type 的基礎介面
/// 用於處理 FHIR 的 [x] 型別（如 value[x], onset[x]）
/// </summary>
public interface IChoiceType
{
    /// <summary>
    /// 取得或設定 Choice Type 的值
    /// </summary>
    object? Value { get; set; }
    
    /// <summary>
    /// 取得目前設定的值型別名稱
    /// </summary>
    string? ValueTypeName { get; }
    
    /// <summary>
    /// 檢查是否有設定值
    /// </summary>
    bool HasValue { get; }
    
    /// <summary>
    /// 清除所有值
    /// </summary>
    void ClearValue();
    
    /// <summary>
    /// 取得允許的型別列表
    /// </summary>
    string[] GetAllowedTypes();
    
    /// <summary>
    /// 檢查指定型別是否被允許
    /// </summary>
    bool IsAllowedType<T>();
    
    /// <summary>
    /// 檢查指定型別是否被允許
    /// </summary>
    bool IsAllowedType(Type type);
    
    /// <summary>
    /// 驗證 Choice Type 的值
    /// </summary>
    IEnumerable<ValidationResult> Validate(ValidationContext validationContext);
}
```

##### ChoiceType 實作
```csharp
namespace Fhir.R4.Models.Base;

/// <summary>
/// 單一型別的 Choice Type
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
/// </summary>
[JsonConverter(typeof(ChoiceTypeConverter))]
public class ChoiceType<T1, T2> : IChoiceType 
    where T1 : class 
    where T2 : class
{
    private T1? _value1;
    private T2? _value2;
    
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

// 類似地實作 ChoiceType<T1, T2, T3> 和 ChoiceType<T1, T2, T3, T4> 等
```

## 🏗️ 實際使用範例

### Extension 中使用 Choice Type
```csharp
public class Extension : Base
{
    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;
    
    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types
    /// 使用強型別 Choice Type 限制允許的型別
    /// </summary>
    [JsonIgnore]
    public ChoiceType<FhirString, FhirInteger, FhirBoolean, FhirDecimal, FhirDate, 
                     FhirDateTime, FhirTime, FhirInstant, FhirUri, FhirCanonical,
                     Address, CodeableConcept, Coding, ContactPoint, HumanName,
                     Identifier, Period, Quantity, Range, Reference>? ValueChoice { get; set; }
    
    // JSON 序列化屬性（自動生成）
    [JsonPropertyName("valueString")]
    public string? ValueString 
    { 
        get => ValueChoice?.AsT1()?.Value;
        set => ValueChoice = value != null ? new FhirString(value) : null;
    }
    
    [JsonPropertyName("valueInteger")]
    public int? ValueInteger 
    { 
        get => ValueChoice?.AsT2()?.Value;
        set => ValueChoice = value != null ? new FhirInteger(value) : null;
    }
    
    [JsonPropertyName("valueBoolean")]
    public bool? ValueBoolean 
    { 
        get => ValueChoice?.AsT3()?.Value;
        set => ValueChoice = value != null ? new FhirBoolean(value) : null;
    }
    
    // ... 其他所有 value[x] 屬性
    
    /// <summary>
    /// 便利屬性：統一存取 value[x]
    /// </summary>
    [JsonIgnore]
    public object? Value
    {
        get => ValueChoice?.Value;
        set => ValueChoice?.SetValue(value);
    }
}
```

### Observation 中使用 Choice Type
```csharp
public class Observation : DomainResource
{
    /// <summary>
    /// The information determined as a result of making the observation
    /// 使用 Choice Type 限制允許的值型別
    /// </summary>
    [JsonIgnore]
    public ChoiceType<Quantity, CodeableConcept, FhirString, FhirBoolean, 
                     FhirInteger, Range, Ratio, SampledData, FhirTime, 
                     FhirDateTime, Period>? ValueChoice { get; set; }
    
    // JSON 序列化屬性
    [JsonPropertyName("valueQuantity")]
    public Quantity? ValueQuantity 
    { 
        get => ValueChoice?.AsT1();
        set => ValueChoice = value;
    }
    
    [JsonPropertyName("valueCodeableConcept")]
    public CodeableConcept? ValueCodeableConcept 
    { 
        get => ValueChoice?.AsT2();
        set => ValueChoice = value;
    }
    
    [JsonPropertyName("valueString")]
    public string? ValueString 
    { 
        get => ValueChoice?.AsT3()?.Value;
        set => ValueChoice = value != null ? new FhirString(value) : null;
    }
    
    // ... 其他 value[x] 屬性
    
    /// <summary>
    /// 便利屬性：統一存取 value[x]
    /// </summary>
    [JsonIgnore]
    public object? Value
    {
        get => ValueChoice?.Value;
        set 
        {
            if (ValueChoice == null)
                ValueChoice = new ChoiceType<Quantity, CodeableConcept, FhirString, FhirBoolean, 
                                           FhirInteger, Range, Ratio, SampledData, FhirTime, 
                                           FhirDateTime, Period>();
            ValueChoice.Value = value;
        }
    }
}
```

## 🔧 JSON 序列化處理

### ChoiceTypeConverter
```csharp
public class ChoiceTypeConverter : JsonConverter<IChoiceType>
{
    public override IChoiceType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // Choice Type 的反序列化由包含它的類別處理
        // 因為需要知道具體的屬性名稱（如 valueString, valueInteger）
        throw new NotSupportedException("ChoiceType deserialization is handled by the containing class");
    }
    
    public override void Write(Utf8JsonWriter writer, IChoiceType value, JsonSerializerOptions options)
    {
        // Choice Type 的序列化由包含它的類別處理
        // 因為需要輸出正確的屬性名稱
        throw new NotSupportedException("ChoiceType serialization is handled by the containing class");
    }
}
```

## ✅ 優點

1. **型別安全** - 編譯時期檢查允許的型別
2. **互斥性保證** - 自動確保只設定一個值
3. **便利使用** - 統一的 Value 屬性存取
4. **FHIR 相容** - 完全符合 FHIR Choice Type 規範
5. **驗證整合** - 內建驗證規則
6. **JSON 支援** - 正確的序列化/反序列化

## 🎯 總結

強型別 Choice Type 系統解決了 FHIR Choice Types 的複雜性：
- ✅ **型別限制** - 編譯時期強制執行
- ✅ **互斥性** - 自動確保只有一個值
- ✅ **便利存取** - 統一的 Value 介面
- ✅ **驗證整合** - 自動檢查有效性
- ✅ **FHIR 相容** - 完全符合規範

這確保了開發者必須在有限集合中選擇正確的資料型別，同時提供優秀的開發體驗！
