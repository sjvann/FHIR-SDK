---
type: "manual"
---

# SDK 架構說明

## 核心設計理念

本 FHIR .NET SDK 的核心設計理念是將**版本特定的核心定義**與**通用的功能模組**徹底分離。這個設計旨在提供一個清晰、可擴充且易於維護的架構，讓開發者能夠在同一個應用程式中無縫地處理多個 FHIR 版本。

### 版本特定的核心定義 (Core)

- **獨立的核心專案**：每個 FHIR 版本 (如 R5, R6) 都有一個獨立的、強型別的 C# 類別庫，例如 `Fhir.R5.Core`。這個專案只包含該版本所有資源和資料類型的定義，不包含任何業務邏輯。
- **由 CLI 工具生成**：當一個新的 FHIR 版本發布時，開發者可以使用本 SDK 提供的 `fhir-generator` CLI 工具，讀取官方發布的定義檔 (通常是 `definitions.json.zip`)，並自動生成對應版本的核心專案 (例如 `Fhir.R6.Core`)。

### 通用的功能模組

- **序列化 (Serialization)**：提供 `Fhir.Serialization.Json` 和 `Fhir.Serialization.Xml` 兩個專案，負責處理強型別物件與 JSON/XML 之間的轉換。這些模組是**版本感知 (Version-Aware)**的，它們會根據開發者當前宣告使用的 FHIR 版本，來採用對應的序列化規則。
- **驗證 (Validation)**：`Fhir.Validation` 專案提供了資源驗證的功能。它同樣是**版本感知**的，會根據當前宣告的版本，載入並執行該版本的驗證規則。
- **支援 (Support)**：`Fhir.Support` 專案提供了一些共用的輔助函式、擴充方法和基礎介面 (如 `IVersionAware`)。

## 架構圖

```mermaid
graph TD
    subgraph "通用功能模組"
        A[Serialization.Json]
        B[Serialization.Xml]
        C[Validation]
        D[Support]
    end

    subgraph "版本特定的核心定義"
        E(Core) --> F[R5]
        E --> G[R6 (未來)]
    end

    A --> D
    B --> D
    C --> D

    A --> E
    B --> E
    C --> E
```

## 工作流程

1.  **宣告版本**：開發者在應用程式的進入點 (例如，一個靜慶設定檔或啟動類別) 中，宣告要使用的 FHIR 版本。
    ```csharp
    FhirEnvironment.CurrentVersion = FhirVersion.R5;
    ```

2.  **使用 SDK**：當開發者呼叫 `new FhirJsonParser().Parse<Patient>(json)` 時，`FhirJsonParser` 內部會檢查 `FhirEnvironment.CurrentVersion`。
    - 它會發現當前版本是 `R5`。
    - 它會動態地載入 `Fhir.R5.Core` 函式庫。
    - 它會使用 R5 版本的 `Patient` 強型別定義來進行反序列化。

3.  **擴充新版本**：
    - 開發者取得 FHIR R6 的官方定義檔 `r6-definitions.zip`。
    - 執行 CLI 工具：`dotnet fhir-generator --version R6 --definition-file r6-definitions.zip`。
    - CLI 工具會在 `Core/` 資料夾下建立一個新的 `R6/` 子資料夾，其中包含 `Fhir.R6.Core.csproj`。
    - 開發者將 `Fhir.R6.Core.csproj` 加入到他們的方案檔中。
    - 現在，開發者可以將應用程式中的版本宣告改為 `FhirEnvironment.CurrentVersion = FhirVersion.R6;`，SDK 的所有功能都會自動切換到 R6 的實作。

這個架構的最大優勢是**可擴充性**和**關注點分離**。通用功能模組的開發可以獨立於任何特定的 FHIR 版本，而對新版本的支援則可以透過 CLI 工具快速、自動地完成，大大降低了維護成本。
