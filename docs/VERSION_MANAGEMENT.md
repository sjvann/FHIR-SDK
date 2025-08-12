# FHIR 多版本管理架構

## 🎯 **架構設計理念**

### **問題分析**

您提出的兩個核心問題非常關鍵：

1. **專案結構選擇**：單一專案 vs 分離專案
2. **使用者體驗**：如何讓開發者簡單切換版本

### **推薦解決方案：混合架構**

我們採用**單一專案多版本架構**，結合**版本管理器模式**，提供最佳的維護性和使用者體驗。

## 🏗️ **架構設計**

### **核心組件**

```
FhirCore/
├── Versioning/
│   ├── IFhirVersionManager.cs      # 版本管理器介面
│   ├── FhirVersionManager.cs       # 版本管理器實作
│   ├── IFhirVersion.cs            # 版本介面
│   ├── FhirR4Version.cs           # R4 版本實作
│   └── FhirR5Version.cs           # R5 版本實作
└── SDK/
    └── FhirSDK.cs                 # 主要 SDK 介面
```

### **資源組織結構**

```
ResourceTypeServices/
├── R4/                            # R4 資源實作
│   ├── Patient.cs
│   ├── Observation.cs
│   └── ...
├── R5/                            # R5 資源實作
│   ├── Patient.cs
│   ├── Observation.cs
│   └── ...
└── R6/                            # 未來 R6 資源實作
    ├── Patient.cs
    └── ...
```

## 🚀 **使用方式**

### **基本使用**

```csharp
using FhirCore.SDK;

// 1. 設定版本（一次設定，全域生效）
FhirSDK.SetVersion("R5");

// 2. 建立資源（自動使用當前版本）
var patient = FhirSDK.CreateResource<Patient>();

// 3. 驗證資源
var result = FhirSDK.ValidateResource(patient);
```

### **多版本並存使用**

```csharp
// 建立 R4 版本的 Patient
var patientR4 = FhirSDK.CreateResource<Patient>("R4");

// 建立 R5 版本的 Patient
var patientR5 = FhirSDK.CreateResource<Patient>("R5");

// 驗證不同版本
var resultR4 = FhirSDK.ValidateResource(patientR4, "R4");
var resultR5 = FhirSDK.ValidateResource(patientR5, "R5");
```

### **版本檢查**

```csharp
// 檢查支援的版本
var supportedVersions = FhirSDK.GetSupportedVersions();
// 返回: ["R4", "R5"]

// 檢查當前版本
var currentVersion = FhirSDK.GetCurrentVersion();
// 返回: "R5"

// 檢查是否支援特定版本
bool isR6Supported = FhirSDK.IsVersionSupported("R6");
// 返回: false
```

## 🔧 **維護優勢**

### **1. 單一專案優勢**

- **統一建置流程**：所有版本在同一專案中
- **共享核心功能**：DataTypeServices 等核心功能共用
- **簡化依賴管理**：單一套件，減少版本衝突
- **統一測試**：所有版本的測試在同一專案中

### **2. 版本隔離優勢**

- **命名空間隔離**：`ResourceTypeServices.R4` vs `ResourceTypeServices.R5`
- **類型安全**：編譯時檢查版本相容性
- **清晰結構**：每個版本的資源在獨立目錄中

### **3. 擴展性優勢**

```csharp
// 未來添加 R6 支援
public class FhirR6Version : IFhirVersion
{
    public string Version => "6.0.0";
    // R6 特定實作
}

// 在 FhirVersionManager 中添加
_versions["R6"] = new FhirR6Version();
```

## 📋 **版本差異處理**

### **R4 vs R5 差異**

| 特性 | R4 | R5 |
|------|----|----|
| 版本號 | 4.0.1 | 5.0.0 |
| 新資源 | 基礎資源 | 新增 Evidence, EvidenceReport 等 |
| 資料類型 | 基礎類型 | 新增 CodeableReference, RatioRange 等 |
| 驗證規則 | 基礎規則 | 更嚴格的驗證規則 |

### **版本遷移策略**

```csharp
// 版本遷移輔助方法
public static class VersionMigration
{
    public static T MigrateResource<T>(object sourceResource, string fromVersion, string toVersion)
    {
        // 實作版本遷移邏輯
        return (T)ConvertResource(sourceResource, fromVersion, toVersion);
    }
}
```

## 🎯 **使用者體驗設計**

### **簡潔的 API**

```csharp
// 最簡單的使用方式
FhirSDK.SetVersion("R5");
var patient = FhirSDK.CreateResource<Patient>();
var result = FhirSDK.ValidateResource(patient);
```

### **版本感知的開發**

```csharp
// 開發時可以明確指定版本
public class PatientService
{
    private readonly string _fhirVersion;
    
    public PatientService(string fhirVersion = "R5")
    {
        _fhirVersion = fhirVersion;
    }
    
    public Patient CreatePatient()
    {
        return FhirSDK.CreateResource<Patient>(_fhirVersion);
    }
}
```

## 🔄 **未來擴展計劃**

### **R6 支援**

1. **創建 R6 目錄結構**
   ```
   ResourceTypeServices/R6/
   ├── Patient.cs
   ├── Observation.cs
   └── ...
   ```

2. **實作 FhirR6Version**
   ```csharp
   public class FhirR6Version : IFhirVersion
   {
       public string Version => "6.0.0";
       // R6 特定實作
   }
   ```

3. **更新版本管理器**
   ```csharp
   _versions["R6"] = new FhirR6Version();
   ```

### **向後相容性**

- **保持 API 穩定**：主要介面不變
- **版本標記**：明確標記每個版本的支援狀態
- **遷移工具**：提供版本間遷移輔助

## 📊 **效能考量**

### **記憶體使用**

- **延遲載入**：只在需要時載入特定版本的資源
- **快取機制**：快取常用的資源類型映射
- **資源池**：重用資源實例

### **建置時間**

- **條件編譯**：可選的版本編譯
- **模組化**：按需載入版本模組

## 🎯 **結論**

這個架構設計解決了您提出的兩個核心問題：

### **✅ 專案結構**
- **單一專案**：統一維護，簡化管理
- **版本隔離**：清晰的命名空間分離
- **擴展性**：輕鬆添加新版本

### **✅ 使用者體驗**
- **簡單切換**：`FhirSDK.SetVersion("R5")`
- **自動版本**：建立資源時自動使用正確版本
- **類型安全**：編譯時檢查版本相容性

### **✅ 未來準備**
- **R6 支援**：架構已準備好支援 R6
- **向後相容**：保持 API 穩定
- **漸進式升級**：可以逐步遷移到新版本

這個架構既滿足了企業級 SDK 的要求，又提供了優秀的開發者體驗！🚀 