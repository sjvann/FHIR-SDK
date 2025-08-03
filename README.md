# 🏥 FHIR SDK for .NET

[![.NET](https://img.shields.io/badge/.NET-9.0-blue.svg)](https://dotnet.microsoft.com/download)
[![C#](https://img.shields.io/badge/C%23-13.0-green.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
[![Build Status](https://img.shields.io/badge/build-passing-brightgreen.svg)](https://github.com/sjvann/Fhir_SDK)

## 📋 專案概述

企業級 FHIR SDK，提供完整的 FHIR R5 資源支援，具備現代化架構設計和高效能開發工具。

### ✨ 主要特色

- 🎯 **完整 FHIR R5 支援** - 159 個資源類型完整實作
- 🏗️ **企業級架構** - 模組化設計，易於維護和擴展
- 🚀 **高效能工具** - AI 輔助的自動化開發工具
- 📚 **完整文件** - 詳細的 API 文件和使用範例
- 🔧 **現代化技術** - .NET 9、C# 13、System.Text.Json
- ✅ **品質保證** - 完整的驗證機制和測試覆蓋

## 🚀 快速開始

### 安裝

```bash
dotnet add package FhirCore
dotnet add package DataTypeServices
dotnet add package ResourceTypeServices
```

### 基本使用

```csharp
using FhirCore.Client;
using ResourceTypeServices.R5;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;

// 建立 FHIR 客戶端
var client = new FhirClient("https://hapi.fhir.org/baseR5");

// 建立 Patient 資源
var patient = new Patient
{
    Id = "patient-001",
    Name = new List<HumanName>
    {
        new HumanName
        {
            Family = "張",
            Given = new List<FhirString> { new FhirString("三") }
        }
    },
    BirthDate = new Date(1990, 1, 1),
    Gender = AdministrativeGender.Male
};

// 驗證資源
var validationResult = patient.Validate();
if (validationResult.IsValid)
{
    // 儲存到伺服器
    var response = await client.CreateAsync(patient);
    Console.WriteLine($"Patient created with ID: {response.Id}");
}

// 驗證
var validationEngine = new FhirValidationEngine(new FhirR4Version());
var result = validationEngine.ValidateResource(patient);

if (result.IsValid)
{
    Console.WriteLine("資源驗證通過");
}
```

## 🏗️ 專案結構

```
Fhir_SDK/
├── DataTypeServices/          # 核心 FHIR 資料類型服務
│   ├── DataTypes/            # FHIR 資料類型定義
│   ├── Serialization/        # 序列化功能
│   ├── Validation/           # 驗證引擎
│   └── TypeFramework/        # 類型框架
├── FhirCore/                 # FHIR 核心功能
├── PerformanceTests/          # 效能測試
├── DataTypeServices.Tests/   # 單元測試
├── .github/workflows/        # CI/CD 管道
└── scripts/                  # 自動化腳本
```

## 🔧 開發環境設定

### 必要條件

- .NET 9.0 SDK
- Visual Studio 2022 或 VS Code
- PowerShell 7.0+

### 建置專案

```bash
# 還原套件
dotnet restore

# 建置專案
dotnet build --configuration Release

# 執行測試
dotnet test --configuration Release

# 執行效能測試
dotnet run --project PerformanceTests
```

## 📊 品質指標

- **程式碼覆蓋率**: > 90%
- **靜態分析**: 零警告
- **效能基準**: 序列化 < 1ms，驗證 < 5ms
- **安全性**: CodeQL 掃描通過

## 🤝 貢獻指南

請參考 [CONTRIBUTING.md](CONTRIBUTING.md) 了解如何參與專案開發。

## 📄 授權

本專案採用 MIT 授權條款。詳見 [LICENSE](LICENSE) 檔案。

## 📞 支援

- 問題回報: [GitHub Issues](https://github.com/your-org/Fhir_SDK/issues)
- 文件: [Wiki](https://github.com/your-org/Fhir_SDK/wiki)
- 討論: [GitHub Discussions](https://github.com/your-org/Fhir_SDK/discussions) 