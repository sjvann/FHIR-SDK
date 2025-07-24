# FHIR SDK 簡化架構

## 概述

這是一個簡化的 FHIR SDK 架構，採用**簡化優先 + 漸進式改進**的開發策略。

## 核心架構

### SimpleTypeFramework
```
SimpleElement (基礎元素)
├── SimplePrimitiveType<T> (原始型別)
├── SimpleComplexType (複雜型別)
├── SimpleResource (資源)
└── SimpleDomainResource (領域資源)
```

## 快速開始

### 1. 建立簡單的 FHIR 資源

```csharp
using Fhir.Support.Base;

// 建立一個 Patient 資源
var patient = new SimplePatient
{
    Id = "patient-001",
    Gender = "male",
    Name = new List<SimpleHumanName>
    {
        new SimpleHumanName
        {
            Family = "Doe",
            Given = new List<string> { "John" }
        }
    }
};
```

### 2. JSON 序列化/反序列化

```csharp
using System.Text.Json;

// 序列化
var json = JsonSerializer.Serialize(patient, new JsonSerializerOptions
{
    WriteIndented = true
});

// 反序列化
var deserializedPatient = JsonSerializer.Deserialize<SimplePatient>(json);
```

### 3. 驗證

```csharp
using System.ComponentModel.DataAnnotations;

var validationResults = new List<ValidationResult>();
var validationContext = new ValidationContext(patient);

if (!Validator.TryValidateObject(patient, validationContext, validationResults, true))
{
    foreach (var result in validationResults)
    {
        Console.WriteLine($"驗證錯誤: {result.ErrorMessage}");
    }
}
```

## 執行驗證

```bash
# 編譯並執行
dotnet build Fhir.Support
dotnet run --project Fhir.Support
```

## 架構優勢

### 相比複雜架構的優點：

1. **簡單易懂**
   - 架構清晰，容易理解
   - 新團隊成員容易上手

2. **快速開發**
   - 可以快速建立可用的版本
   - 減少開發時間

3. **降低風險**
   - 減少架構錯誤的風險
   - 更容易除錯

4. **易於維護**
   - 減少複雜性
   - 降低維護成本

## 版本管理策略

### R5 階段
- ✅ 建立基礎架構
- ✅ 確保基本功能可用
- 🔄 完善所有 FHIR 類別
- 🔄 建立完整的驗證系統

### R6 階段
- 🔄 以 R5 為基礎進行增修
- 🔄 建立版本差異分析工具
- 🔄 準備自動化測試

## 開發流程

### 1. 建立新的 FHIR 類別

```csharp
public class SimpleObservation : SimpleDomainResource
{
    public override string ResourceType => "Observation";
    
    public string? Status { get; set; }
    public SimpleCodeableConcept? Code { get; set; }
    public SimpleReference? Subject { get; set; }
    
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;
            
        // 自訂驗證邏輯
        if (string.IsNullOrEmpty(Status))
        {
            yield return new ValidationResult("Status is required");
        }
    }
}
```

### 2. 添加自訂驗證

```csharp
public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
{
    foreach (var result in base.Validate(validationContext))
        yield return result;
        
    // 自訂驗證邏輯
    if (!string.IsNullOrEmpty(Gender) && 
        !new[] { "male", "female", "other", "unknown" }.Contains(Gender.ToLower()))
    {
        yield return new ValidationResult(
            "Gender must be one of: male, female, other, unknown",
            new[] { nameof(Gender) });
    }
}
```

## 檔案結構

```
Fhir.Support/
├── Base/
│   └── SimpleTypeFramework.cs      # 簡化架構基礎
├── Examples/
│   ├── SimpleFrameworkExample.cs   # 使用範例
│   └── SimpleFrameworkValidation.cs # 驗證程式
└── Program.cs                      # 主程式
```

## 下一步計劃

1. **生成完整的 FHIR 類別**
   - 使用 SimpleGenerator 生成所有 R5 類別
   - 確保編譯通過

2. **完善功能**
   - 添加更多驗證規則
   - 優化 JSON 處理
   - 添加單元測試

3. **準備 R6 支援**
   - 建立版本差異分析
   - 準備增修機制

## 結論

這個簡化架構提供了一個實用、可維護的 FHIR SDK 基礎，可以快速建立可用的版本，並為未來的版本管理奠定基礎。 