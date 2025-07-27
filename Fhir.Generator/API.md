# FHIR Generator API 文件

> **📚 此文件已移至 [docs/Generator/API.md](../docs/Generator/API.md)**

請前往新位置查看完整的 API 參考文件。

## 🔧 **核心 API**

### **SimpleGenerator**

主要的程式碼生成類別，負責將 FHIR 定義轉換為 C# 程式碼。

#### **方法**

##### `GenerateSimpleResource(ResourceInfo info, string version)`

生成 FHIR Resource 類別的 C# 程式碼。

**參數:**
- `info` (ResourceInfo): Resource 的定義資訊
- `version` (string): FHIR 版本 (如 "R4", "R5")

**回傳值:**
- `string`: 生成的 C# 程式碼

**範例:**
```csharp
var generator = new SimpleGenerator();
var resourceInfo = new ResourceInfo
{
    ClassName = "Patient",
    ResourceType = "Patient",
    Description = "Information about an individual or animal receiving care",
    Properties = new List<PropertyDefinition>
    {
        new PropertyDefinition
        {
            Name = "Active",
            Type = "boolean",
            Description = "Whether this patient record is in active use"
        }
    }
};

string code = generator.GenerateSimpleResource(resourceInfo, "R4");
```

##### `GenerateSimplePrimitiveType(PrimitiveTypeInfo info, string version)`

生成 FHIR Primitive Type 類別的 C# 程式碼。

**參數:**
- `info` (PrimitiveTypeInfo): Primitive Type 的定義資訊
- `version` (string): FHIR 版本

**回傳值:**
- `string`: 生成的 C# 程式碼

### **TypeMapper**

負責 FHIR 類型到 C# 類型的映射。

#### **方法**

##### `MapType(string fhirType, string propertyName)`

將 FHIR 類型映射為對應的 C# 類型。

**參數:**
- `fhirType` (string): FHIR 類型名稱
- `propertyName` (string): 屬性名稱

**回傳值:**
- `string`: 對應的 C# 類型

**映射規則:**
```csharp
"string" → "FhirString?"
"boolean" → "FhirBoolean?"
"integer" → "FhirInteger?"
"date" → "FhirDate?"
"Identifier" → "List<Identifier>?" (if cardinality > 1)
"Reference" → "Reference?"
```

### **FhirDefinitionLoader**

負責載入和解析 FHIR 定義檔。

#### **方法**

##### `LoadDefinitionsAsync(string definitionFile)`

非同步載入 FHIR 定義檔。

**參數:**
- `definitionFile` (string): 定義檔路徑

**回傳值:**
- `Task<FhirDefinitions>`: FHIR 定義物件

## 📋 **資料模型**

### **ResourceInfo**

表示 FHIR Resource 的定義資訊。

```csharp
public class ResourceInfo
{
    /// <summary>
    /// 類別名稱 (如 "Patient")
    /// </summary>
    public string ClassName { get; set; }
    
    /// <summary>
    /// FHIR Resource 類型 (如 "Patient")
    /// </summary>
    public string ResourceType { get; set; }
    
    /// <summary>
    /// Resource 描述
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// 屬性定義列表
    /// </summary>
    public List<PropertyDefinition> Properties { get; set; }
}
```

### **PropertyDefinition**

表示 Resource 屬性的定義資訊。

```csharp
public class PropertyDefinition
{
    /// <summary>
    /// 屬性名稱 (如 "Active")
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// FHIR 類型 (如 "boolean", "string")
    /// </summary>
    public string Type { get; set; }
    
    /// <summary>
    /// 屬性描述
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// 最小出現次數
    /// </summary>
    public int MinCardinality { get; set; }
    
    /// <summary>
    /// 最大出現次數 ("1", "*")
    /// </summary>
    public string MaxCardinality { get; set; }
    
    /// <summary>
    /// 屬性順序
    /// </summary>
    public int Order { get; set; }
    
    /// <summary>
    /// 是否為必填欄位
    /// </summary>
    public bool IsRequired => MinCardinality > 0;
}
```

### **PrimitiveTypeInfo**

表示 FHIR Primitive Type 的定義資訊。

```csharp
public class PrimitiveTypeInfo
{
    /// <summary>
    /// 類別名稱 (如 "FhirString")
    /// </summary>
    public string ClassName { get; set; }
    
    /// <summary>
    /// 對應的原生 C# 類型 (如 "string")
    /// </summary>
    public string NativeType { get; set; }
    
    /// <summary>
    /// 類型描述
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// 驗證模式 (正規表達式)
    /// </summary>
    public string Pattern { get; set; }
}
```

## 🎯 **使用範例**

### **基本使用**

```csharp
using Fhir.Generator.Services;
using Fhir.Generator.Models;

// 建立 Generator
var generator = new SimpleGenerator();

// 定義 Resource
var patientInfo = new ResourceInfo
{
    ClassName = "Patient",
    ResourceType = "Patient",
    Description = "Information about an individual receiving care",
    Properties = new List<PropertyDefinition>
    {
        new PropertyDefinition
        {
            Name = "Active",
            Type = "boolean",
            Description = "Whether this patient record is in active use",
            MinCardinality = 0,
            MaxCardinality = "1"
        },
        new PropertyDefinition
        {
            Name = "Name",
            Type = "HumanName",
            Description = "A name associated with the patient",
            MinCardinality = 0,
            MaxCardinality = "*"
        }
    }
};

// 生成程式碼
string generatedCode = generator.GenerateSimpleResource(patientInfo, "R4");

// 儲存到檔案
await File.WriteAllTextAsync("Patient.cs", generatedCode);
```

### **批次生成**

```csharp
var resources = new List<ResourceInfo>
{
    patientInfo,
    organizationInfo,
    observationInfo
};

foreach (var resource in resources)
{
    string code = generator.GenerateSimpleResource(resource, "R4");
    string fileName = $"{resource.ClassName}.cs";
    await File.WriteAllTextAsync(fileName, code);
}
```

## 🔧 **擴展 API**

### **自訂類型映射**

```csharp
public class CustomTypeMapper : TypeMapper
{
    public override string MapType(string fhirType, string propertyName)
    {
        return fhirType switch
        {
            "custom-type" => "MyCustomType?",
            _ => base.MapType(fhirType, propertyName)
        };
    }
}

// 使用自訂映射器
var generator = new SimpleGenerator(new CustomTypeMapper());
```

### **自訂程式碼範本**

```csharp
public class CustomGenerator : SimpleGenerator
{
    protected override string GeneratePropertyComment(PropertyDefinition property)
    {
        return $"/// <summary>\n/// {property.Description}\n/// Custom: {property.Name}\n/// </summary>";
    }
}
```

## ⚠️ **注意事項**

### **執行緒安全性**
- `SimpleGenerator` 是執行緒安全的
- `TypeMapper` 是無狀態的，可以安全地在多執行緒環境中使用

### **記憶體使用**
- 大型 FHIR 定義檔可能消耗大量記憶體
- 建議在處理完成後及時釋放 `FhirDefinitions` 物件

### **錯誤處理**
- 所有公開方法都可能拋出 `ArgumentException` 或 `InvalidOperationException`
- 檔案 I/O 操作可能拋出 `IOException`
- 建議使用 try-catch 包裝所有 API 呼叫

## 🔮 **未來 API 擴展**

### **v1.1.0 規劃**
- `IGenerator` 介面抽象化
- `IDefinitionLoader` 介面支援多種定義來源
- 非同步生成方法

### **v1.2.0 規劃**
- 插件式擴展 API
- 自訂範本引擎支援
- 批次處理 API

### **v2.0.0 規劃**
- 完整的 FHIR 版本管理 API
- 差異分析 API
- 自動遷移 API
