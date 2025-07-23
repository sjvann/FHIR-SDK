# CLI 工具指南

FHIR .NET SDK 提供了一個命令列介面 (CLI) 工具 `fhir-generator`，用於協助開發者從 FHIR 官方的定義檔自動生成特定版本的強型別核心專案。

## 安裝

_(這部分需要您提供安裝 CLI 工具的具體說明，例如是透過 .NET Global Tool 或是其他方式)_

```bash
# 範例：如果是 .NET Global Tool
dotnet tool install --global fhir-generator
```

## 使用方法

`fhir-generator` 的主要功能是讀取一個包含 FHIR 資源定義的檔案 (通常是 zip 檔)，並在 `Core/` 目錄下生成對應的 C# 專案。

### 基本語法

```bash
dotnet fhir-generator --version <VERSION> --definition-file <PATH_TO_DEFINITIONS>
```

### 參數說明

-   `--version <VERSION>`: (必要) 指定要生成的 FHIR 版本號，例如 `R6`。這個名稱將會用作 `Core/` 下的子目錄名稱。
-   `--definition-file <PATH_TO_DEFINITIONS>`: (必要) 指向官方 FHIR 定義檔的路徑 (zip 格式)。

### 範例

假設您已經下載了 FHIR R6 的定義檔 `r6-definitions.zip`，您可以使用以下命令來生成 `Core/R6/` 專案：

```bash
dotnet fhir-generator --version R6 --definition-file r6-definitions.zip
```

執行成功後，您的專案結構將會擴充如下：

```
FHIR-SDK/
├── Core/
│   ├── R5/
│   └── R6/  <-- 新生成的專案
├── ...
```

## 注意事項

-   請確保您提供的定義檔是完整且未損壞的。
-   生成過程可能需要幾分鐘的時間，具體取決於定義檔的大小和您的機器性能。 