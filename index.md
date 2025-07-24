# FHIR .NET SDK - 強型別 FHIR 開發工具包

[![.NET 9](https://img.shields.io/badge/.NET-9.0-blue.svg)](https://dotnet.microsoft.com/download/dotnet/9.0)
[![FHIR R5](https://img.shields.io/badge/FHIR-R5-green.svg)](https://www.hl7.org/fhir/R5/)
[![R6 Ready](https://img.shields.io/badge/FHIR-R6%20Ready-orange.svg)](https://www.hl7.org/fhir/R6/)
[![NuGet](https://img.shields.io/nuget/v/Fhir.SDK.svg)](https://www.nuget.org/packages/Fhir.SDK/)

## 概述

FHIR .NET SDK 是一個為 .NET 開發者設計的高性能、強型別的 FHIR 開發函式庫。它旨在提供一個清晰、版本化的架構，讓開發者可以輕鬆地在應用程式中處理不同版本的 FHIR 資料。

本 SDK 的核心理念是**版本特定的核心定義**與**通用的功能模組**分離。開發者只需在使用時宣告所要使用的 FHIR 版本，SDK 內部即可自動處理對應的強型別物件、序列化和驗證規則。

## 🚀 核心特性

- **多版本並行支援**：在同一個應用程式中無縫使用 FHIR R5 或未來的 R6 版本。
- **強型別核心**：每個 FHIR 版本都有其獨立的、強型別的 C# 類別庫 (例如 `Fhir.R5.Core`)。
- **通用功能模組**：提供共用的序列化 (JSON/XML) 和驗證功能，這些功能會根據您所選的 FHIR 版本自動調整。
- **CLI 工具驅動的版本擴充**：當新的 FHIR 版本發布時，可透過 CLI 工具讀取官方定義檔，自動生成對應版本的核心專案。

## 📦 專案結構

```
FHIR-SDK/
├── Fhir.Models/
│   ├── R5/                   # FHIR R5 的核心強型別定義
│   │   └── Fhir.R5.Core.csproj
│   └── Base/                   # FHIR 通用核心
│       └── Fhir.Models.csproj
├── Fhir.Serialization.Json/  # 通用的 JSON 序列化模組
├── Fhir.Serialization.Xml/   # 通用的 XML 序列化模組
├── Fhir.Validation/          # 通用的驗證模組
├── Fhir.Support/             # 共用的輔助函式庫
├── Fhir.Generator/           # 用於生成新版本核心的 CLI 工具
├── docs/                     # 專案文件
├── Fhir.Tests/               # 單元測試
└── FHIR Solution.sln         # Visual Studio 方案檔
```

## 🛠️ 快速開始

### 1. 建立並設定 FHIR 上下文
在您的應用程式中，首先需要建立一個 `IFhirContext` 的實例，來決定您想要使用的 FHIR 版本。

```csharp
using Fhir.Support;
using Fhir.Support.Versioning;

// 建立一個 R5 版本的上下文
IFhirContext fhirContext = new FhirContext(FhirVersion.R5);
```

### 2. 使用 SDK
將您建立的上下文實例傳遞給 SDK 的功能模組 (如序列化、驗證)。

```csharp
using Fhir.Models.R5; 
using Fhir.Serialization.Json;
using Fhir.Serialization.Xml;

// 將上下文注入到 Parser 中
var parser = new JsonParser(fhirContext); 
Patient patient = parser.Parse<Patient>(jsonContent);

// 驗證也會使用 R5 的規則
// var validator = new FhirValidator(fhirContext); // 範例
// var validationResult = validator.Validate(patient); 

// 序列化同樣遵循 R5 規範
// var serializer = new XmlSerializer(fhirContext); // 範例
// string xmlContent = serializer.SerializeToString(patient);
```

### 3. 未來擴充到 R6
當 HL7 發布 R6 版本時，您可以使用 CLI 工具來擴充 SDK：

```bash
# 透過 CLI 工具生成 R6 的核心專案
dotnet fhir-generator --version R6 --definition-file r6-definitions.zip
```

執行後，您的專案結構會變為：
```
FHIR-SDK/
├── Fhir.Models/
│   ├── R5/
│   └── R6/
├── Fhir.Serialization.Json/  # 通用的 JSON 序列化模組
├── Fhir.Serialization.Xml/   # 通用的 XML 序列化模組
├── Fhir.Validation/          # 通用的驗證模組
├── Fhir.Support/             # 共用的輔助函式庫
├── Fhir.Generator/           # 用於生成新版本核心的 CLI 工具
├── docs/                     # 專案文件
├── Fhir.Tests/               # 單元測試
└── FHIR Solution.sln         # Visual Studio 方案檔
```
接著，您只需將建立上下文的程式碼改為 `new FhirContext(FhirVersion.R6)`，即可在應用程式中使用 R6 的強型別物件和規則。

## 📚 文件

- **[快速入門指南](docs/Quick-Start-Guide.md)** - 學習如何設定和使用 SDK。
- **[架構說明](docs/Architecture.md)** - 深入了解 SDK 的設計理念。
- **[CLI 工具指南](docs/Cli-Guide.md)** - 學習如何使用 CLI 工具擴充新的 FHIR 版本。

## 🤝 貢獻

我們歡迎任何形式的貢獻！請參考 [CONTRIBUTING.md](CONTRIBUTING.md) 以了解如何參與。

## 📄 授權

此專案使用 MIT 授權 - 詳見 [LICENSE](LICENSE) 檔案。
