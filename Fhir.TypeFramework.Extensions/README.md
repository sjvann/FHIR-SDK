# Fhir.TypeFramework.Extensions

FHIR TypeFramework 的擴展功能專案，提供流暢的使用者體驗和開發便利性。

## 🎯 專案目標

這個專案旨在提供以下功能：

1. **Primitive Type 轉換** - 將基本 C# 型別轉換為 FHIR Primitive Types
2. **Choice Type 支援** - 提供 LINQ 和匿名函數風格的 API
3. **IntelliSense 友好** - 配合 IDE 提供更好的開發體驗
4. **流暢 API** - 使用 Fluent API 設計模式

## 📦 安裝

```xml
<PackageReference Include="Fhir.TypeFramework.Extensions" Version="1.0.0" />
```

## 🚀 快速開始

### 1. Primitive Type 轉換

```csharp
using Fhir.TypeFramework.Extensions;

// 字串轉換
var fhirString = "Hello FHIR".ToFhirString();
var fhirUri = "https://example.com/fhir".ToFhirUri();
var fhirCode = "active".ToFhirCode();

// 數值轉換
var fhirInteger = 42.ToFhirInteger();
var fhirDecimal = 3.14m.ToFhirDecimal();
var fhirBoolean = true.ToFhirBoolean();

// 日期時間轉換
var fhirDateTime = DateTime.Now.ToFhirDateTime();
var fhirDate = DateTime.Now.ToFhirDate();
var fhirInstant = DateTime.Now.ToFhirInstant();
```

### 2. Choice Type 使用

```csharp
// Extension 的 Choice Type
var extension = new Extension { Url = "https://example.com/extension" };
extension.WithStringValue("字串值");
extension.WithIntegerValue(42);
extension.WithBooleanValue(true);
extension.WithDecimalValue(3.14m);
extension.WithDateTimeValue(DateTime.Now);

// Patient 的 Choice Type
var patient = new Patient();
patient.WithDeceased(true);  // 布林值
patient.WithDeceasedDate(DateTime.Now);  // 日期時間
patient.WithMultipleBirth(true);  // 布林值
patient.WithMultipleBirthCount(3);  // 整數

// Observation 的 Choice Type
var observation = new Observation();
observation.WithEffectiveDateTime(DateTime.Now);  // 日期時間
observation.WithEffectivePeriod(new Period { ... });  // 期間
observation.WithQuantityValue(new Quantity { ... });  // 數量
observation.WithStringValue("正常範圍內");  // 字串
```

### 3. Complex Type 創建

```csharp
// 使用流暢的 API 創建 Complex Types
var quantity = Extensions.ChoiceTypeExtensions.CreateQuantity(70.5m, "kg");
var period = Extensions.ChoiceTypeExtensions.CreatePeriod(
    DateTime.Now.AddDays(-30),
    DateTime.Now
);
var range = Extensions.ChoiceTypeExtensions.CreateRange(lowQuantity, highQuantity);
var age = Extensions.ChoiceTypeExtensions.CreateAge(30, "years");
var duration = Extensions.ChoiceTypeExtensions.CreateDuration(2.5m, "hours");
```

## 🎨 特色功能

### 1. IntelliSense 友好

當你輸入 `extension.With` 時，IntelliSense 會顯示所有可用的方法：

```csharp
extension.WithStringValue()     // 字串值
extension.WithIntegerValue()    // 整數值
extension.WithBooleanValue()    // 布林值
extension.WithDecimalValue()    // 小數值
extension.WithDateTimeValue()   // 日期時間值
```

### 2. LINQ 風格 API

使用匿名函數和 LINQ 風格的 API：

```csharp
// 使用匿名函數設定值
extension.WithValue(x => x); // 配合 IntelliSense 選擇類型

// 使用 LINQ 風格的鏈式調用
patient.WithDeceased(true)
       .WithMultipleBirthCount(3);
```

### 3. 流暢的型別轉換

```csharp
// 基本型別直接轉換為 FHIR 型別
var fhirString = "Hello".ToFhirString();
var fhirInteger = 42.ToFhirInteger();
var fhirDateTime = DateTime.Now.ToFhirDateTime();

// 可空型別支援
var nullableInt = 42.ToFhirInteger();
var nullableDateTime = DateTime.Now.ToFhirDateTime();
```

### 4. Complex Type 支援

對於 Complex Types，可以使用 `{}` 方式設值：

```csharp
observation.WithEffectivePeriod(new Period
{
    Start = DateTime.Now.AddDays(-7).ToFhirDateTime(),
    End = DateTime.Now.ToFhirDateTime()
});
```

## 📋 支援的 Choice Types

### Extension.value[x]
- `WithStringValue(string)`
- `WithIntegerValue(int)`
- `WithBooleanValue(bool)`
- `WithDecimalValue(decimal)`
- `WithDateTimeValue(DateTime)`

### Patient.deceased[x]
- `WithDeceased(bool)` - 布林值
- `WithDeceasedDate(DateTime)` - 日期時間

### Patient.multipleBirth[x]
- `WithMultipleBirth(bool)` - 布林值
- `WithMultipleBirthCount(int)` - 整數

### Observation.effective[x]
- `WithEffectiveDateTime(DateTime)` - 日期時間
- `WithEffectivePeriod(Period)` - 期間
- `WithEffectiveTiming(Timing)` - 時間安排
- `WithEffectiveInstant(DateTime)` - 即時

### Observation.value[x]
- `WithQuantityValue(Quantity)` - 數量
- `WithCodeableConceptValue(CodeableConcept)` - 可編碼概念
- `WithStringValue(string)` - 字串
- `WithBooleanValue(bool)` - 布林值
- `WithIntegerValue(int)` - 整數

### Condition.onset[x]
- `WithOnsetDateTime(DateTime)` - 日期時間
- `WithOnsetAge(Age)` - 年齡
- `WithOnsetPeriod(Period)` - 期間
- `WithOnsetRange(Range)` - 範圍
- `WithOnsetString(string)` - 字串

### Procedure.performed[x]
- `WithPerformedDateTime(DateTime)` - 日期時間
- `WithPerformedPeriod(Period)` - 期間
- `WithPerformedString(string)` - 字串
- `WithPerformedAge(Age)` - 年齡
- `WithPerformedRange(Range)` - 範圍

### Timing.repeat.bounds[x]
- `WithBoundsDuration(Duration)` - 持續時間
- `WithBoundsRange(Range)` - 範圍

### Annotation.author[x]
- `WithAuthorReference(Reference)` - 參考
- `WithAuthorString(string)` - 字串

## 🔧 使用範例

完整的範例請參考 `Examples/ExtensionsUsageExample.cs`：

```csharp
using Fhir.TypeFramework.Extensions.Examples;

// 執行所有範例
ExtensionsUsageExample.RunAllExamples();
```

## 🏗️ 架構設計

### 專案結構

```
Fhir.TypeFramework.Extensions/
├── Extensions/
│   ├── PrimitiveTypeExtensions.cs    # Primitive Type 轉換
│   └── ChoiceTypeExtensions.cs       # Choice Type 支援
├── Examples/
│   └── ExtensionsUsageExample.cs     # 使用範例
└── README.md                         # 說明文件
```

### 設計原則

1. **職責分離** - 核心框架與擴展功能分離
2. **可選性** - 使用者可選擇是否使用擴展功能
3. **向後相容** - 不影響現有的 API
4. **IntelliSense 友好** - 提供良好的開發體驗

## 🤝 貢獻

歡迎提交 Issue 和 Pull Request 來改善這個專案！

## 📄 授權

本專案採用與 Fhir.TypeFramework 相同的授權條款。 