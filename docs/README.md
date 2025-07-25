# FHIR SDK 文件

歡迎使用 FHIR SDK！這是一個完整的 .NET FHIR 開發套件，支援多版本無縫切換。

## 📖 文件導覽

### 🚀 快速開始
- [安裝指南](installation.md)
- [快速開始](quick-start.md)
- [版本切換](version-switching.md)

### 🔧 開發指南
- [FHIR 程式碼生成](code-generation.md)
- [新版本生成步驟](new-version-generation.md)
- [SDK 使用範例](usage-examples.md)

### 📋 API 參考
- [Fhir.Support API](api/Fhir.Support.md)
- [Fhir.R4.Models API](api/Fhir.R4.Models.md)
- [Fhir.R5.Models API](api/Fhir.R5.Models.md)

### 🏗️ 架構設計
- [專案架構](architecture.md)
- [設計原則](design-principles.md)
- [版本管理策略](version-management.md)

## 🎯 主要特色

### ✅ 多版本支援
- 支援 FHIR R4、R5
- 獨立的 NuGet 套件
- 無縫版本切換

### ✅ 自動程式碼生成
- 從官方 FHIR 定義自動生成
- 完整的型別安全
- 自動 Global Using 別名

### ✅ 開發者友善
- 完整的 IntelliSense 支援
- 清晰的 API 設計
- 豐富的使用範例

## 🚀 快速範例

```csharp
// 安裝套件
// dotnet add package Fhir.Support
// dotnet add package Fhir.R4.Models

// 使用 R4
using Fhir.R4.Models.Resources;

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

## 📞 支援

- [GitHub Issues](https://github.com/your-org/FHIR-SDK/issues)
- [討論區](https://github.com/your-org/FHIR-SDK/discussions)
- [Wiki](https://github.com/your-org/FHIR-SDK/wiki)

## 📄 授權

本專案採用 MIT 授權條款。詳見 [LICENSE](../LICENSE) 檔案。
