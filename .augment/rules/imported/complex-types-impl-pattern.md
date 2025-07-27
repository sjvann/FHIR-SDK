---
type: "manual"
---

# Complex Data Types Impl 模式設計

## 🎯 問題描述

FHIR 中有些 Complex Data Types 本身是抽象定義，但在實際使用時需要設定具體值：

### 典型問題案例

1. **Quantity 系列**
   ```
   Quantity (抽象)
   ├── Age : Quantity
   ├── Distance : Quantity  
   ├── Duration : Quantity
   └── Count : Quantity
   ```

2. **實際使用困境**
   ```csharp
   // 問題：Quantity 是抽象的，不能直接實例化
   public abstract class Quantity : DataType
   {
       public decimal? Value { get; set; }
       public string Unit { get; set; }
       // ... 其他屬性
   }
   
   // 在 Resource 中使用
   public class Observation : DomainResource
   {
       public Quantity ValueQuantity { get; set; } // ❌ 不能實例化抽象類別
   }
   ```

## ✅ 解決方案：Impl 類別模式

### 設計原則
1. **保持抽象類別** - 維持 FHIR 的型別層次
2. **添加 Impl 類別** - 提供可實例化的具體實作
3. **自動映射** - 在需要具體實例的地方使用 Impl 類別
4. **型別相容** - Impl 類別完全相容於抽象基礎類別

### 實作模式

#### 1. 抽象基礎類別（保持不變）
```csharp
// Fhir.R4.Models/DataTypes/Quantity.cs
public abstract class Quantity : DataType
{
    [JsonPropertyName("value")]
    public decimal? Value { get; set; }
    
    [JsonPropertyName("comparator")]
    public string Comparator { get; set; }
    
    [JsonPropertyName("unit")]
    public string Unit { get; set; }
    
    [JsonPropertyName("system")]
    public string System { get; set; }
    
    [JsonPropertyName("code")]
    public string Code { get; set; }
    
    // FHIR 驗證邏輯
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;
            
        // Quantity 特定驗證
        if (Value.HasValue && Value < 0 && string.IsNullOrEmpty(Comparator))
        {
            yield return new ValidationResult("Negative values require a comparator");
        }
    }
}
```

#### 2. 具體 Impl 類別
```csharp
// Fhir.R4.Models/DataTypes/QuantityImpl.cs
[JsonConverter(typeof(QuantityImplConverter))]
public class QuantityImpl : Quantity
{
    public QuantityImpl() { }
    
    public QuantityImpl(decimal? value, string unit = null, string system = null, string code = null)
    {
        Value = value;
        Unit = unit;
        System = system;
        Code = code;
    }
    
    // 便利的建構方法
    public static QuantityImpl Create(decimal value, string unit)
        => new QuantityImpl(value, unit);
        
    public static QuantityImpl CreateWithCode(decimal value, string system, string code, string unit = null)
        => new QuantityImpl(value, unit, system, code);
}
```

#### 3. 特化類別（保持不變）
```csharp
// Fhir.R4.Models/DataTypes/Age.cs
public class Age : Quantity
{
    public Age() { }
    
    public Age(decimal? value, string unit = "a") // 預設單位為年
    {
        Value = value;
        Unit = unit;
        System = "http://unitsofmeasure.org";
        Code = unit;
    }
    
    // Age 特定驗證
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;
            
        // Age 必須是正數
        if (Value.HasValue && Value <= 0)
        {
            yield return new ValidationResult("Age must be positive");
        }
    }
}
```

### 型別映射器更新

#### 在 FhirCompliantTypeMapper 中處理
```csharp
public class FhirCompliantTypeMapper
{
    private readonly Dictionary<string, AbstractTypeMapping> _abstractTypeMappings = new()
    {
        ["Quantity"] = new AbstractTypeMapping
        {
            AbstractType = "Quantity",
            ImplType = "QuantityImpl",
            SpecializedTypes = new[] { "Age", "Distance", "Duration", "Count" }
        },
        ["Reference"] = new AbstractTypeMapping
        {
            AbstractType = "Reference", 
            ImplType = "ReferenceImpl",
            SpecializedTypes = new string[0] // Reference 沒有特化類別
        }
    };
    
    public string MapFhirTypeToCSharp(string fhirType, bool needsConcrete = false)
    {
        // 檢查是否為抽象型別
        if (_abstractTypeMappings.TryGetValue(fhirType, out var mapping))
        {
            if (needsConcrete)
            {
                // 需要具體實例時使用 Impl 類別
                return mapping.ImplType;
            }
            else
            {
                // 一般情況使用抽象類別
                return mapping.AbstractType;
            }
        }
        
        // 其他型別的正常處理
        return base.MapFhirTypeToCSharp(fhirType);
    }
}

public class AbstractTypeMapping
{
    public string AbstractType { get; set; }
    public string ImplType { get; set; }
    public string[] SpecializedTypes { get; set; }
}
```

## 🏗️ 使用範例

### 1. 在 Resource 中使用
```csharp
public class Observation : DomainResource
{
    // 使用 QuantityImpl 而非抽象的 Quantity
    [JsonPropertyName("valueQuantity")]
    public QuantityImpl ValueQuantity { get; set; }
    
    // 或者使用特化類別
    [JsonPropertyName("valueAge")]  
    public Age ValueAge { get; set; }
}
```

### 2. 便利的建立方式
```csharp
var observation = new Observation();

// 使用 QuantityImpl
observation.ValueQuantity = new QuantityImpl(70.5m, "kg");
observation.ValueQuantity = QuantityImpl.Create(180m, "cm");
observation.ValueQuantity = QuantityImpl.CreateWithCode(
    98.6m, "http://unitsofmeasure.org", "degF", "°F");

// 使用特化類別
observation.ValueAge = new Age(25, "a"); // 25 歲
```

### 3. 型別相容性
```csharp
// QuantityImpl 可以當作 Quantity 使用
Quantity quantity = new QuantityImpl(100m, "mg");

// 可以在需要 Quantity 的地方使用
void ProcessQuantity(Quantity qty) { /* ... */ }

ProcessQuantity(new QuantityImpl(50m, "ml")); // ✅ 正常工作
ProcessQuantity(new Age(30)); // ✅ 也正常工作
```

## 🔧 生成器實作

### 自動檢測抽象型別
```csharp
public class ComplexTypeGenerator
{
    public void GenerateComplexType(StructureDefinition definition)
    {
        var typeName = definition.Name;
        var isAbstract = definition.Abstract == true;
        
        if (isAbstract && HasConcreteUsage(typeName))
        {
            // 生成抽象基礎類別
            GenerateAbstractClass(definition);
            
            // 生成 Impl 類別
            GenerateImplClass(definition);
        }
        else
        {
            // 生成一般類別
            GenerateConcreteClass(definition);
        }
    }
    
    private bool HasConcreteUsage(string typeName)
    {
        // 檢查是否有 Resource 或其他地方需要具體實例
        return _usageAnalyzer.RequiresConcreteInstance(typeName);
    }
}
```

## 📋 需要 Impl 類別的型別清單

### 確定需要的型別
1. **Quantity** → **QuantityImpl**
   - 在 Observation.valueQuantity 等地方需要具體實例
   
2. **Reference** → **ReferenceImpl** 
   - 在所有 Reference 屬性中需要具體實例
   
3. **CodeableConcept** → **CodeableConceptImpl** (如果是抽象的)
   - 在大量地方使用，需要具體實例

### 檢查方式
```csharp
// 分析 FHIR StructureDefinitions 找出：
// 1. 標記為 abstract="true" 的型別
// 2. 在 Resource 屬性中被直接使用的型別
// 3. 需要具體實例化的場景
```

## ✅ 優點

1. **保持 FHIR 型別層次** - 抽象類別維持 FHIR 的設計
2. **提供具體實例** - Impl 類別可以實際使用
3. **型別安全** - 編譯時期檢查
4. **向後相容** - 不影響現有的特化類別
5. **便利使用** - 提供多種建構方式

## 🎯 總結

這個 Impl 模式解決了 FHIR Complex Data Types 的抽象性問題：
- ✅ **抽象類別** - 維持 FHIR 規範的型別層次
- ✅ **Impl 類別** - 提供可實例化的具體實作  
- ✅ **特化類別** - 保持現有的 Age, Distance 等
- ✅ **自動選擇** - 生成器根據使用場景自動選擇合適的型別

這確保了既符合 FHIR 規範，又能實際使用！
