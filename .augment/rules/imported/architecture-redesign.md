---
type: "manual"
---

# FHIR SDK 重新設計架構

基於對 FHIR 官方規範的深入分析，重新設計完全符合 FHIR 複雜性的 SDK 架構。

## 🎯 設計原則

### 1. 完全尊重 FHIR 複雜性
- 不簡化任何型別對應
- 保持完整的繼承層次
- 支援所有 FHIR 特性（Choice Types, Extensions, etc.）

### 2. 精確的型別系統
```csharp
// FHIR 型別層次完全對應
public abstract class Base { }
public abstract class Element : Base 
{
    public string Id { get; set; }
    public List<Extension> Extension { get; set; }
}
public abstract class DataType : Element { }
public abstract class PrimitiveType<T> : DataType 
{
    public T Value { get; set; }
}
public abstract class BackboneElement : Element 
{
    public List<Extension> ModifierExtension { get; set; }
}
```

### 3. 版本特定實作
```
Fhir.R4.Models/
├── Base/
│   ├── Base.cs
│   ├── Element.cs
│   ├── DataType.cs
│   ├── PrimitiveType.cs
│   └── BackboneElement.cs
├── Primitives/
│   ├── FhirBoolean.cs
│   ├── FhirString.cs
│   ├── FhirInteger.cs
│   └── ... (所有 primitive types)
├── DataTypes/
│   ├── HumanName.cs
│   ├── Address.cs
│   ├── CodeableConcept.cs
│   └── ... (所有 complex types)
├── Resources/
│   ├── Patient.cs
│   ├── Observation.cs
│   └── ... (所有 resources)
└── Generated/
    ├── GlobalUsings.g.cs
    └── TypeMappings.g.cs
```

## 🔧 生成器重新設計

### 1. 精確的型別映射器
```csharp
public class FhirTypeMapper
{
    // 基於 FHIR 官方定義的完整映射
    private readonly Dictionary<string, TypeMapping> _typeMappings = new()
    {
        // Primitive Types
        ["boolean"] = new TypeMapping 
        { 
            CSharpType = "FhirBoolean", 
            BaseType = "PrimitiveType<bool?>",
            JsonType = "bool",
            XmlType = "xs:boolean"
        },
        ["string"] = new TypeMapping 
        { 
            CSharpType = "FhirString", 
            BaseType = "PrimitiveType<string>",
            JsonType = "string",
            XmlType = "xs:string"
        },
        // Complex Types
        ["HumanName"] = new TypeMapping 
        { 
            CSharpType = "HumanName", 
            BaseType = "DataType",
            Properties = LoadFromDefinition("HumanName")
        },
        // Resources
        ["Patient"] = new TypeMapping 
        { 
            CSharpType = "Patient", 
            BaseType = "DomainResource",
            Properties = LoadFromDefinition("Patient")
        }
    };
}
```

### 2. 完整的屬性處理
```csharp
public class PropertyGenerator
{
    public void GenerateProperty(PropertyDefinition prop)
    {
        // 處理 Choice Types
        if (prop.IsChoiceType)
        {
            GenerateChoiceProperty(prop);
        }
        // 處理 Reference Types
        else if (prop.Type == "Reference")
        {
            GenerateReferenceProperty(prop);
        }
        // 處理一般屬性
        else
        {
            GenerateStandardProperty(prop);
        }
    }
    
    private void GenerateChoiceProperty(PropertyDefinition prop)
    {
        // value[x] -> ValueBoolean, ValueString, ValueQuantity...
        foreach (var choiceType in prop.ChoiceTypes)
        {
            var propertyName = $"Value{ToPascalCase(choiceType)}";
            var propertyType = MapFhirTypeToCSharp(choiceType);
            
            // 生成屬性和 JSON 序列化屬性
            GeneratePropertyWithSerialization(propertyName, propertyType, prop);
        }
    }
}
```

### 3. 版本感知的生成
```csharp
public class VersionAwareGenerator
{
    public async Task GenerateVersionAsync(string fhirVersion)
    {
        var schema = await LoadSchemaAsync(fhirVersion);
        var versionConfig = GetVersionConfig(fhirVersion);
        
        // 生成基礎類型
        await GenerateBaseTypesAsync(schema, versionConfig);
        
        // 生成 Primitive Types
        await GeneratePrimitiveTypesAsync(schema, versionConfig);
        
        // 生成 Complex DataTypes
        await GenerateDataTypesAsync(schema, versionConfig);
        
        // 生成 Resources
        await GenerateResourcesAsync(schema, versionConfig);
        
        // 生成版本特定的輔助類
        await GenerateVersionHelpersAsync(schema, versionConfig);
    }
}
```

## 📋 實作細節

### 1. Primitive Types 實作
```csharp
// FhirBoolean.cs
[JsonConverter(typeof(FhirBooleanConverter))]
public class FhirBoolean : PrimitiveType<bool?>
{
    public FhirBoolean() { }
    public FhirBoolean(bool? value) { Value = value; }
    
    public static implicit operator bool?(FhirBoolean fhirBoolean) 
        => fhirBoolean?.Value;
    public static implicit operator FhirBoolean(bool? value) 
        => new FhirBoolean(value);
        
    public override string ToString() => Value?.ToString() ?? "";
}
```

### 2. Complex DataTypes 實作
```csharp
// HumanName.cs
public class HumanName : DataType
{
    [JsonPropertyName("use")]
    public string Use { get; set; }
    
    [JsonPropertyName("text")]
    public string Text { get; set; }
    
    [JsonPropertyName("family")]
    public string Family { get; set; }
    
    [JsonPropertyName("given")]
    public List<string> Given { get; set; }
    
    [JsonPropertyName("prefix")]
    public List<string> Prefix { get; set; }
    
    [JsonPropertyName("suffix")]
    public List<string> Suffix { get; set; }
    
    [JsonPropertyName("period")]
    public Period Period { get; set; }
}
```

### 3. Resources 實作
```csharp
// Patient.cs
public class Patient : DomainResource, IPatient
{
    [JsonPropertyName("resourceType")]
    public override string ResourceType => "Patient";
    
    [JsonPropertyName("identifier")]
    public List<Identifier> Identifier { get; set; }
    
    [JsonPropertyName("active")]
    public bool? Active { get; set; }
    
    [JsonPropertyName("name")]
    public List<HumanName> Name { get; set; }
    
    [JsonPropertyName("telecom")]
    public List<ContactPoint> Telecom { get; set; }
    
    [JsonPropertyName("gender")]
    public string Gender { get; set; }
    
    [JsonPropertyName("birthDate")]
    public string BirthDate { get; set; }
    
    // Choice Type 範例
    [JsonPropertyName("deceasedBoolean")]
    public bool? DeceasedBoolean { get; set; }
    
    [JsonPropertyName("deceasedDateTime")]
    public string DeceasedDateTime { get; set; }
    
    [JsonIgnore]
    public object Deceased 
    {
        get => DeceasedBoolean ?? (object)DeceasedDateTime;
        set 
        {
            if (value is bool b) DeceasedBoolean = b;
            else if (value is string s) DeceasedDateTime = s;
        }
    }
}
```

## 🚀 無縫版本切換

### 1. 介面統一
```csharp
// Fhir.Abstractions/IPatient.cs
public interface IPatient : IDomainResource
{
    List<IIdentifier> Identifier { get; set; }
    bool? Active { get; set; }
    List<IHumanName> Name { get; set; }
    string Gender { get; set; }
    string BirthDate { get; set; }
}
```

### 2. 自動 Global Using
```csharp
// Fhir.R4.Models/GlobalUsings.g.cs (自動生成)
global using Patient = Fhir.R4.Models.Resources.Patient;
global using Observation = Fhir.R4.Models.Resources.Observation;
global using HumanName = Fhir.R4.Models.DataTypes.HumanName;
global using Address = Fhir.R4.Models.DataTypes.Address;
// ... 所有 Resources 和 DataTypes
```

### 3. 版本切換
```csharp
// 從 R4 切換到 R5 只需要：
// 1. 改變套件參照
// 2. Global Using 自動更新
// 3. 程式碼保持不變

var patient = new Patient(); // 自動對應到正確版本
```

這個重新設計的架構完全尊重 FHIR 的複雜性，提供精確的型別映射和真正的無縫版本切換。
