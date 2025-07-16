# FHIR SDK - 企業級FHIR解決方案

[![.NET 8](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download/dotnet/8.0)
[![FHIR R5](https://img.shields.io/badge/FHIR-R5-green.svg)](https://hl7.org/fhir/R5/)
[![R6 Ready](https://img.shields.io/badge/FHIR-R6%20Ready-orange.svg)](https://hl7.org/fhir/R6/)

## 概述

FHIR SDK 是一個為.NET開發者設計的企業級FHIR R5解決方案，具備完整的R6升級準備能力。提供強型別的C#類別來表示FHIR資源，並支援無縫的資料轉換和版本遷移。

## 🚀 核心特性

### ✅ 已實現功能
- **完整FHIR R5支援** - 所有資源類型和資料類型
- **強型別API** - C#原生類型到FHIR類型的自動轉換
- **CDS Hooks整合** - 臨床決策支援標準實現
- **多版本架構** - 為FHIR R6準備的版本化基礎設施
- **企業級配置** - 靈活的配置管理和依賴注入
- **高性能** - 優化的序列化和快取機制

### 🔄 版本遷移能力
- **自動版本檢測** - 智能識別FHIR資源版本
- **漸進式遷移** - 支援R5到R6的平滑升級路徑
- **資料備份** - 遷移前自動備份和回滾機制
- **兼容性檢查** - 確保版本間的最大兼容性

## 📦 專案結構

```
FHIR-SDK/
├── Core/                    # 核心基礎設施 (版本無關)
│   ├── Versioning/         # 版本管理和遷移
│   ├── Contracts/          # 核心介面定義
│   ├── Factories/          # 資源工廠
│   └── Configuration/      # 配置管理
├── DataTypeService/        # FHIR資料類型實現
├── DataTypeHelper/         # 類型轉換輔助工具
├── ResourceTypeServices/   # FHIR R5資源實現
├── ResourceService/        # 資源管理服務
├── TerminologyService/     # 術語服務
├── CdsApp/                # CDS Hooks應用範例
├── CdsService/            # CDS Hooks服務
├── MainServices/          # 主要API服務
└── DataSource/            # 資料持久化 (Umbraco)
```

## 🛠️ 快速開始

### 1. 安裝套件
```bash
dotnet add package FhirSdk.Core
dotnet add package FhirSdk.ResourceTypes.R5
```

### 2. 配置服務
```csharp
// 開發環境 - 使用預設配置
services.AddFhirSdkDefault();

// 生產環境 - 使用生產配置
services.AddFhirSdkProduction();

// R6準備 - 支援雙版本
services.AddFhirSdkR6Ready();
```

### 3. 使用資源
```csharp
// 建立患者資源
var patient = resourceFactory.Create<Patient>();
patient.Id = "patient-123";
patient.Name = new[]
{
    new HumanName
    {
        Family = "王".ToFhirString(),
        Given = new[] { "小明".ToFhirString() }
    }
};

// 轉換為JSON
var json = patient.ToJson();

// 從JSON建立資源
var restoredPatient = resourceFactory.CreateFromJson<Patient>(json);
```

### 4. 版本遷移 (R6準備)
```csharp
// 自動遷移 (當R6可用時)
var migratedData = await versionManager.MigrateAsync(
    r5Data, 
    FhirVersion.R5, 
    FhirVersion.R6
);
```

## ⚙️ 配置選項

### appsettings.json
```json
{
  "FhirSdk": {
    "DefaultVersion": "R5",
    "SupportedVersions": ["R5"],
    "EnableAutoMigration": true,
    "Validation": {
      "StrictValidation": false,
      "ValidateProfiles": true,
      "ValidateTerminology": false
    },
    "Performance": {
      "EnableCaching": true,
      "CacheExpirationMinutes": 60,
      "MaxCacheSizeMB": 100
    }
  }
}
```

### 程式碼配置
```csharp
services.AddFhirSdk(options =>
{
    options.DefaultVersion = FhirVersion.R5;
    options.SupportedVersions = new[] { FhirVersion.R5, FhirVersion.R6 };
    options.EnableAutoMigration = true;
    options.Validation.StrictValidation = true;
});
```

## 🔧 開發工具

### 型別轉換助手
```csharp
// 字串轉換
"Hello World".ToFhirString();
"2023-12-25".ToFhirDate();
"https://example.com".ToFhirUri();

// 數值轉換
42.ToFhirInteger();
3.14m.ToFhirDecimal();
true.ToFhirBoolean();

// 複雜型別
DateTime.Now.ToFhirDateTime();
TimeSpan.FromHours(1).ToFhirTime();
```

### CDS Hooks範例
```csharp
public class BmiChecker
{
    public IEnumerable<CardModel> CheckBmi(IEnumerable<Observation> observations)
    {
        return observations
            .Where(obs => obs.Code.Coding.Any(c => c.Code == "39156-5"))
            .Select(CreateBmiCard);
    }
}
```

## 🚦 R6升級路徑

### 當前狀態 (R5)
- ✅ 完整R5實現
- ✅ 版本化基礎設施
- ✅ 遷移框架準備

### R6 Beta階段
- 🔄 R6規範追蹤
- 🔄 R5到R6遷移器開發
- 🔄 雙版本測試

### R6正式發布
- ⏳ R6生產支援
- ⏳ 性能優化
- ⏳ 完整文檔

### 升級檢查清單
- [ ] 更新配置啟用R6支援
- [ ] 測試現有R5資料遷移
- [ ] 驗證應用程式相容性
- [ ] 部署新版本

## 📋 最佳實踐

### 1. 版本管理
```csharp
// 始終檢查版本相容性
if (!resource.CanHandle(targetVersion))
{
    await versionManager.MigrateAsync(data, currentVersion, targetVersion);
}
```

### 2. 錯誤處理
```csharp
try
{
    var patient = factory.CreateFromJson<Patient>(json);
}
catch (FhirValidationException ex)
{
    logger.LogError("驗證失敗: {Issues}", ex.OperationOutcome);
}
catch (FhirVersionNotSupportedException ex)
{
    logger.LogError("版本不支援: {Version}", ex.RequestedVersion);
}
```

### 3. 性能優化
```csharp
// 使用快取
services.Configure<PerformanceOptions>(options =>
{
    options.EnableCaching = true;
    options.CacheExpirationMinutes = 120;
});

// 批次處理
var results = await repository.SearchAsync(searchParams);
```

## 🧪 測試

### 單元測試
```bash
dotnet test Core.Tests
dotnet test ResourceTypeServices.Tests
```

### 整合測試
```bash
dotnet test --filter Category=Integration
```

### 版本遷移測試
```bash
dotnet test --filter Category=Migration
```

## 📚 文檔

### 🚀 開始使用
- **[快速入門指南](docs/Quick-Start-Guide.md)** - 適合初學者的完整教學與實用案例
- **[進階使用手冊](docs/Advanced-User-Manual.md)** - 資深開發者的詳細參考手冊

### 📋 部署與維護
- [FHIR R6升級遷移策略](docs/R6-Migration-Strategy.md) - 無痛升級到R6版本
- [實施檢查清單](docs/Implementation-Checklist.md) - 部署前的完整檢查項目

### 📖 參考資料
- [API文檔](docs/api/README.md)
- [配置指南](docs/Configuration.md)
- [最佳實踐](docs/BestPractices.md)
- [疑難排解](docs/Troubleshooting.md)

## 🤝 貢獻

1. Fork專案
2. 建立功能分支 (`git checkout -b feature/AmazingFeature`)
3. 提交變更 (`git commit -m 'Add some AmazingFeature'`)
4. 推送分支 (`git push origin feature/AmazingFeature`)
5. 開啟Pull Request

## 📄 授權

此專案使用 MIT 授權 - 詳見 [LICENSE](LICENSE) 檔案

## 🙋‍♂️ 支援

- 建立 [Issue](https://github.com/sjvann/FHIR-SDK/issues) 回報問題
- 查看 [Wiki](https://github.com/sjvann/FHIR-SDK/wiki) 取得詳細文檔
- 聯絡維護團隊

---

## 版本歷史

### v1.0.0 (2025-01-01)
- ✅ 完整FHIR R5支援
- ✅ 版本化架構實現
- ✅ R6遷移準備完成
- ✅ 企業級配置系統
- ✅ CDS Hooks整合
- ✅ 效能優化

### 下一版本計畫
- 🔄 FHIR R6 Beta支援
- 🔄 增強術語服務
- 🔄 GraphQL支援
- 🔄 更多CDS應用範例
