# 版本切換指南

本指南說明如何在不同 FHIR 版本之間無縫切換。

## 🎯 核心概念

FHIR SDK 透過以下機制實現無縫版本切換：

1. **獨立套件** - 每個版本都是獨立的 NuGet 套件
2. **Global Using** - 自動生成的全域別名
3. **共用介面** - 版本無關的抽象介面

## 🔄 切換步驟

### 從 R4 切換到 R5

#### 步驟 1：更新套件參照

```bash
# 移除 R4 套件
dotnet remove package Fhir.R4.Models

# 安裝 R5 套件
dotnet add package Fhir.R5.Models
```

#### 步驟 2：更新 using 語句（可選）

```csharp
// 從
using Fhir.R4.Models.Resources;

// 改為
using Fhir.R5.Models.Resources;

// 或者使用 Global Using（推薦）
// 無需任何 using 語句！
```

#### 步驟 3：程式碼保持不變

```csharp
// 這段程式碼在 R4 和 R5 都能正常運作
var patient = new Patient
{
    Id = "example-001",
    Active = true,
    Gender = "male"
};

var observation = new Observation
{
    Id = "obs-001",
    Status = "final",
    Subject = new Reference($"Patient/{patient.Id}")
};
```

## 🏗️ 三種切換方法

### 方法 1：Global Using（推薦）⭐

每個版本套件都包含自動生成的 `GlobalUsings.g.cs`：

```csharp
// Fhir.R4.Models/GlobalUsings.g.cs
global using Patient = Fhir.R4.Models.Resources.Patient;
global using Observation = Fhir.R4.Models.Resources.Observation;
// ... 所有 Resources 和 DataTypes

// Fhir.R5.Models/GlobalUsings.g.cs  
global using Patient = Fhir.R5.Models.Resources.Patient;
global using Observation = Fhir.R5.Models.Resources.Observation;
// ... 所有 Resources 和 DataTypes
```

**優點**：
- 完全無縫切換
- 無需修改程式碼
- 自動包含所有類型

### 方法 2：介面程式設計

```csharp
using Fhir.Abstractions.Resources;

// 使用介面，版本無關
public void ProcessPatient(IPatient patient)
{
    Console.WriteLine($"Patient ID: {patient.Id}");
    Console.WriteLine($"Active: {patient.Active}");
}

// 可以傳入任何版本的 Patient
var r4Patient = new Fhir.R4.Models.Resources.Patient();
var r5Patient = new Fhir.R5.Models.Resources.Patient();

ProcessPatient(r4Patient);  // ✅ 正常運作
ProcessPatient(r5Patient);  // ✅ 正常運作
```

### 方法 3：條件編譯

```csharp
#if FHIR_R4
using Fhir.R4.Models.Resources;
#elif FHIR_R5
using Fhir.R5.Models.Resources;
#endif

// 在專案檔中定義條件
// <DefineConstants>FHIR_R4</DefineConstants>
```

## 📊 版本差異處理

### 檢查版本特定功能

```csharp
// 使用介面處理共通功能
IPatient patient = GetPatient();
patient.Active = true;

// 使用具體類型處理版本特定功能
if (patient is Fhir.R5.Models.Resources.Patient r5Patient)
{
    // R5 特有功能
    // r5Patient.SomeR5SpecificProperty = "value";
}
else if (patient is Fhir.R4.Models.Resources.Patient r4Patient)
{
    // R4 特有功能
    // r4Patient.SomeR4SpecificProperty = "value";
}
```

### 版本資訊檢查

```csharp
using Fhir.Core;

// 檢查當前版本
var versionInfo = FhirVersion.GetVersionInfo();
Console.WriteLine($"FHIR Version: {versionInfo.Name}");
Console.WriteLine($"Version Number: {versionInfo.Number}");

// 根據版本執行不同邏輯
switch (versionInfo.Name)
{
    case "R4":
        // R4 特定邏輯
        break;
    case "R5":
        // R5 特定邏輯
        break;
}
```

## 🧪 測試版本切換

### 建立測試專案

```bash
# 建立測試專案
dotnet new console -n VersionSwitchTest
cd VersionSwitchTest

# 測試 R4
dotnet add package Fhir.R4.Models
echo 'var p = new Patient(); Console.WriteLine($"R4: {p.ResourceType}");' > Program.cs
dotnet run

# 切換到 R5
dotnet remove package Fhir.R4.Models
dotnet add package Fhir.R5.Models
dotnet run  # 程式碼不變，但現在使用 R5
```

## ⚠️ 注意事項

### 1. 版本特定屬性

某些屬性可能只存在於特定版本：

```csharp
var patient = new Patient();

// 安全的方式檢查屬性是否存在
if (patient.GetType().GetProperty("SomeNewProperty") != null)
{
    // 屬性存在，可以使用
}
```

### 2. 序列化相容性

不同版本的序列化結果可能不同：

```csharp
// 建議指定版本資訊
var options = new JsonSerializerOptions();
options.Converters.Add(new FhirVersionConverter("R4"));

var json = JsonSerializer.Serialize(patient, options);
```

### 3. 驗證規則差異

不同版本的驗證規則可能不同：

```csharp
// 使用版本特定的驗證器
var validator = FhirValidatorFactory.Create("R4");
var results = validator.Validate(patient);
```

## 🔗 相關文件

- [快速開始](quick-start.md)
- [使用範例](usage-examples.md)
- [程式碼生成](code-generation.md)
- [架構設計](architecture.md)
