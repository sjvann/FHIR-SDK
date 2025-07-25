# FHIR SDK 正確實作計劃

基於對 FHIR 官方規範的深入分析，制定完全符合 FHIR 複雜性的實作計劃。

## 🎯 核心理念

### 1. 完全尊重 FHIR 複雜性
- **不簡化任何型別對應** - FHIR 的複雜性是有其原因的
- **保持完整的繼承層次** - Base → Element → DataType → 具體型別
- **支援所有 FHIR 特性** - Choice Types, Extensions, References, etc.

### 2. 精確的型別系統
```
FHIR 型別層次 → C# 型別層次 (1:1 對應)
├── Base (抽象)
├── Element (抽象) : Base
│   ├── DataType (抽象) : Element
│   │   ├── PrimitiveType<T> (抽象) : DataType
│   │   │   ├── FhirBoolean : PrimitiveType<bool?>
│   │   │   ├── FhirString : PrimitiveType<string>
│   │   │   └── ... (所有 primitive types)
│   │   ├── BackboneType (抽象) : DataType
│   │   │   ├── Timing : BackboneType
│   │   │   ├── Dosage : BackboneType
│   │   │   └── ElementDefinition : BackboneType
│   │   └── Complex DataTypes : DataType
│   │       ├── Identifier : DataType
│   │       ├── HumanName : DataType
│   │       ├── Address : DataType
│   │       ├── CodeableConcept : DataType
│   │       ├── Reference : DataType
│   │       └── ... (所有 complex types)
│   └── BackboneElement (抽象) : Element
│       └── Resource-specific nested elements
└── Resource (抽象) : Base
    ├── DomainResource (抽象) : Resource
    │   ├── Patient : DomainResource
    │   ├── Observation : DomainResource
    │   └── ... (所有 domain resources)
    └── Infrastructure Resources : Resource
        ├── Bundle : Resource
        ├── OperationOutcome : Resource
        └── ... (基礎設施資源)
```

## 📋 實作階段

### 階段 1：基礎型別系統 (2-3 天)

#### 1.1 建立基礎抽象類別
```csharp
// Fhir.R4.Models/Base/Base.cs
public abstract class Base
{
    // 最基礎的 FHIR 型別
}

// Fhir.R4.Models/Base/Element.cs
public abstract class Element : Base
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    
    [JsonPropertyName("extension")]
    public List<Extension>? Extension { get; set; }
}

// Fhir.R4.Models/Base/DataType.cs
public abstract class DataType : Element
{
    // 所有可重用型別的基礎
}

// Fhir.R4.Models/Base/PrimitiveType.cs
public abstract class PrimitiveType<T> : DataType
{
    [JsonPropertyName("value")]
    public T? Value { get; set; }
    
    // 隱式轉換
    public static implicit operator T?(PrimitiveType<T> primitive) => primitive?.Value;
    public static implicit operator PrimitiveType<T>(T? value) => CreateInstance(value);
}
```

#### 1.2 實作所有 Primitive Types
```csharp
// Fhir.R4.Models/Primitives/FhirBoolean.cs
[JsonConverter(typeof(FhirBooleanConverter))]
public class FhirBoolean : PrimitiveType<bool?>
{
    public FhirBoolean() { }
    public FhirBoolean(bool? value) { Value = value; }
    
    // 驗證邏輯
    public override bool IsValid() => true; // boolean 總是有效
}

// 類似地實作所有 primitive types...
```

### 階段 2：Complex DataTypes (3-4 天)

#### 2.1 實作核心 DataTypes
```csharp
// Fhir.R4.Models/DataTypes/HumanName.cs
public class HumanName : DataType
{
    [JsonPropertyName("use")]
    public string? Use { get; set; }
    
    [JsonPropertyName("text")]
    public string? Text { get; set; }
    
    [JsonPropertyName("family")]
    public string? Family { get; set; }
    
    [JsonPropertyName("given")]
    public List<string>? Given { get; set; }
    
    [JsonPropertyName("prefix")]
    public List<string>? Prefix { get; set; }
    
    [JsonPropertyName("suffix")]
    public List<string>? Suffix { get; set; }
    
    [JsonPropertyName("period")]
    public Period? Period { get; set; }
    
    // FHIR 驗證規則
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;
            
        // HumanName 特定的驗證規則
        if (string.IsNullOrEmpty(Text) && string.IsNullOrEmpty(Family) && 
            (Given == null || !Given.Any()))
        {
            yield return new ValidationResult("HumanName must have either text, family, or given name");
        }
    }
}
```

#### 2.2 處理 Choice Types
```csharp
// 在 Observation 中的 value[x]
public class Observation : DomainResource
{
    // Choice Type 的所有可能型別
    [JsonPropertyName("valueQuantity")]
    public Quantity? ValueQuantity { get; set; }
    
    [JsonPropertyName("valueCodeableConcept")]
    public CodeableConcept? ValueCodeableConcept { get; set; }
    
    [JsonPropertyName("valueString")]
    public string? ValueString { get; set; }
    
    [JsonPropertyName("valueBoolean")]
    public bool? ValueBoolean { get; set; }
    
    // ... 所有其他 value[x] 型別
    
    // 便利屬性
    [JsonIgnore]
    public object? Value
    {
        get => ValueQuantity ?? ValueCodeableConcept ?? 
               (object?)ValueString ?? ValueBoolean;
        set
        {
            // 清除所有其他值
            ClearValueProperties();
            
            // 設定正確的屬性
            switch (value)
            {
                case Quantity q: ValueQuantity = q; break;
                case CodeableConcept cc: ValueCodeableConcept = cc; break;
                case string s: ValueString = s; break;
                case bool b: ValueBoolean = b; break;
                // ... 處理所有型別
            }
        }
    }
}
```

### 階段 3：Resources (4-5 天)

#### 3.1 建立 Resource 基礎類別
```csharp
// Fhir.R4.Models/Base/Resource.cs
public abstract class Resource : Base
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    
    [JsonPropertyName("meta")]
    public Meta? Meta { get; set; }
    
    [JsonPropertyName("implicitRules")]
    public string? ImplicitRules { get; set; }
    
    [JsonPropertyName("language")]
    public string? Language { get; set; }
    
    [JsonPropertyName("resourceType")]
    public abstract string ResourceType { get; }
}

// Fhir.R4.Models/Base/DomainResource.cs
public abstract class DomainResource : Resource
{
    [JsonPropertyName("text")]
    public Narrative? Text { get; set; }
    
    [JsonPropertyName("contained")]
    public List<Resource>? Contained { get; set; }
    
    [JsonPropertyName("extension")]
    public List<Extension>? Extension { get; set; }
    
    [JsonPropertyName("modifierExtension")]
    public List<Extension>? ModifierExtension { get; set; }
}
```

#### 3.2 實作具體 Resources
```csharp
// Fhir.R4.Models/Resources/Patient.cs
public class Patient : DomainResource, IPatient
{
    [JsonPropertyName("resourceType")]
    public override string ResourceType => "Patient";
    
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }
    
    [JsonPropertyName("active")]
    public bool? Active { get; set; }
    
    [JsonPropertyName("name")]
    public List<HumanName>? Name { get; set; }
    
    [JsonPropertyName("telecom")]
    public List<ContactPoint>? Telecom { get; set; }
    
    [JsonPropertyName("gender")]
    public string? Gender { get; set; }
    
    [JsonPropertyName("birthDate")]
    public string? BirthDate { get; set; }
    
    // Choice Type: deceased[x]
    [JsonPropertyName("deceasedBoolean")]
    public bool? DeceasedBoolean { get; set; }
    
    [JsonPropertyName("deceasedDateTime")]
    public string? DeceasedDateTime { get; set; }
    
    [JsonIgnore]
    public object? Deceased
    {
        get => DeceasedBoolean ?? (object?)DeceasedDateTime;
        set
        {
            DeceasedBoolean = null;
            DeceasedDateTime = null;
            
            switch (value)
            {
                case bool b: DeceasedBoolean = b; break;
                case string s: DeceasedDateTime = s; break;
            }
        }
    }
    
    // FHIR 驗證規則
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;
            
        // Patient 特定的驗證規則
        if (DeceasedBoolean.HasValue && !string.IsNullOrEmpty(DeceasedDateTime))
        {
            yield return new ValidationResult("Patient cannot have both deceasedBoolean and deceasedDateTime");
        }
    }
}
```

### 階段 4：序列化和驗證 (2-3 天)

#### 4.1 JSON 序列化
```csharp
// 自定義 JsonConverter 處理 FHIR 特殊需求
public class FhirJsonConverter : JsonConverter<Base>
{
    public override Base Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // 處理 FHIR JSON 的特殊格式
        // 包括 resourceType 識別、primitive extensions 等
    }
    
    public override void Write(Utf8JsonWriter writer, Base value, JsonSerializerOptions options)
    {
        // 輸出符合 FHIR JSON 規範的格式
    }
}
```

#### 4.2 FHIR 驗證
```csharp
public class FhirValidator
{
    public ValidationResult Validate(Resource resource)
    {
        var context = new ValidationContext(resource);
        var results = new List<ValidationResult>();
        
        // 1. 基本 DataAnnotations 驗證
        Validator.TryValidateObject(resource, context, results, true);
        
        // 2. FHIR 特定驗證規則
        ValidateFhirRules(resource, results);
        
        // 3. 基數驗證
        ValidateCardinality(resource, results);
        
        // 4. Choice Type 驗證
        ValidateChoiceTypes(resource, results);
        
        return new ValidationResult(results);
    }
}
```

### 階段 5：版本切換機制 (1-2 天)

#### 5.1 自動 Global Using 生成
```csharp
// 在生成過程中自動產生
// Fhir.R4.Models/GlobalUsings.g.cs
global using Patient = Fhir.R4.Models.Resources.Patient;
global using Observation = Fhir.R4.Models.Resources.Observation;
global using HumanName = Fhir.R4.Models.DataTypes.HumanName;
// ... 所有 Resources 和 DataTypes
```

#### 5.2 介面統一
```csharp
// Fhir.Abstractions/IPatient.cs
public interface IPatient : IDomainResource
{
    List<IIdentifier>? Identifier { get; set; }
    bool? Active { get; set; }
    List<IHumanName>? Name { get; set; }
    string? Gender { get; set; }
    string? BirthDate { get; set; }
}
```

## 🔧 技術挑戰與解決方案

### 1. Choice Types 處理
**挑戰**: FHIR 的 `value[x]` 可以是多種型別
**解決方案**: 
- 為每種可能的型別建立獨立屬性
- 提供統一的便利屬性
- 實作型別安全的設定邏輯

### 2. Reference Types 處理
**挑戰**: Reference 可以指向多種 Resource 型別
**解決方案**:
- 使用基礎 Reference 類別
- 執行時透過 `type` 欄位判斷實際型別
- 提供型別安全的解析方法

### 3. Extensions 處理
**挑戰**: 每個 Element 都可以有任意 Extensions
**解決方案**:
- 在 Element 基礎類別中提供 Extension 屬性
- 實作強型別的 Extension 存取方法
- 支援 Modifier Extensions

### 4. 版本差異處理
**挑戰**: R4 和 R5 有不同的 Resources 和屬性
**解決方案**:
- 完全獨立的版本實作
- 共用介面提供相容性
- 自動 Global Using 實現無縫切換

## 📊 預期成果

### 1. 完全符合 FHIR 規範
- 支援所有 FHIR 型別和特性
- 通過官方 FHIR 驗證測試
- 與其他 FHIR 實作完全相容

### 2. 開發者友善
- 強型別支援和 IntelliSense
- 無縫版本切換
- 清晰的錯誤訊息和驗證

### 3. 高效能
- 最小化記憶體使用
- 快速序列化/反序列化
- 延遲載入和快取機制

這個實作計劃確保我們建立一個真正專業級的 FHIR SDK，完全尊重 FHIR 的複雜性，同時提供優秀的開發者體驗。
