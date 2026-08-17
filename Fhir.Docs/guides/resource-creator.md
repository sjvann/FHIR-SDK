# Fhir.ResourceCreator 使用手冊

`Fhir.ResourceCreator` 是**維護本 SDK 用的產生器**，不發佈給應用。它從 FHIR Package Registry 下載官方核心套件，解析 StructureDefinition，寫出 `Fhir.Resources.{Line}` 強型別 POCO，並可 scaffold 對應的 `Fhir.Path.{Line}`／`Fhir.Sdk.{Line}`。

應用／前端請引用已發佈的 `Fhir.Sdk.R*`，見 [在應用中使用 SDK](consume-sdk.md)。**新大版本（如 R6）的完整手順**（要下載什麼、指令、事後改哪些檔、前端怎麼接）見 **[新增或升級 FHIR 線別](add-fhir-line.md)**。

## 兩種工作

| 情境 | 做什麼 |
|------|--------|
| 既有線別（R4／R4B／R5）資源過期或缺檔 | 改 `appsettings.json` 的 `Version`（或 `ResourcesInclude`），再 `dotnet run` |
| HL7 出了新線別 | 取得 `hl7.fhir.r{n}.core` 的 id／版本 → 產生 → scaffold → 改 slnx 與 VersionManager → pack。逐步清單在 [新增或升級 FHIR 線別](add-fhir-line.md) |

產生器**不會**改 `Fhir.Sdk.slnx`，也**不會**自動擴充 `FhirVersion` 列舉。

## 前置需求

- **.NET SDK**：與方案一致（目前 `net10.0`）。
- **網路**：Registry 模式需能連線 `packages.fhir.org`（或設定之備援 URL）。
- **工作目錄**：請在 **`Fhir.ResourceCreator`** 專案目錄執行 `dotnet run`，以便 `appsettings.json`、`OutputRoot`、`PackageCacheDirectory` 等相對路徑正確。

輸入是 Registry 上的 **`hl7.fhir.r*.core` `.tgz`**（內含 StructureDefinition snapshot），不是 Excel。`Mode: Excel` 僅供舊流程。

## 設定檔

主要設定檔為 **`Fhir.ResourceCreator/appsettings.json`** 內之 **`Generator`** 區段。

| 鍵 | 說明 |
|----|------|
| `Mode` | `Registry`（主線）或 `Excel`（舊版 Excel） |
| `RegistryBaseUrl` | 主 Registry，預設 `https://packages.fhir.org` |
| `RegistryFallbackUrl` | 選用；主站失敗時改試 `packages2` 等 |
| `PackageCacheDirectory` | 解包快取根目錄，預設 `artifacts/fhir-packages` |
| `OutputRoot` | 產生專案根目錄，預設 `generated` |
| `RootNamespace` | 選填；留空時通常與推斷之組件名稱對齊（見命名文件） |
| `TypeFrameworkPackageVersion` | 發射之 `.csproj` 中 `Fhir.TypeFramework` **PackageReference** 版本 |
| `Packages` | 多筆套件目標，見下表 |

### `Packages[]` 每一筆

| 鍵 | 說明 |
|----|------|
| `PackageId` | NPM 套件 id，例如 `hl7.fhir.r5.core` |
| `Version` | 語意化版本，例如 `5.0.0`（到 [packages.fhir.org](https://packages.fhir.org) 查實際發行號） |
| `OutputProjectName` | 選填；資料夾名、組件名、NuGet **PackageId**。空則依 `PackageId` 推斷（如 `hl7.fhir.r5.core` → `Fhir.Resources.R5`）。`r4b` 會推成 `R4b`，必須明示 `Fhir.Resources.R4B` |
| `RootNamespace` | 選填；覆寫該套件產生類別的根命名空間 |
| `ResourcesInclude` | 選填；**非空**時僅產生列表內之資源類型名稱（如 `Patient`）。**空陣列**表示不篩選，由套件內所有符合條件之 SD 決定 |
| `ResourcesExclude` | 選填；排除之資源類型名稱 |

## 指令一覽

於 **`Fhir.ResourceCreator` 目錄**（產生）：

```powershell
cd path\to\FHIR-SDK\Fhir.ResourceCreator
dotnet run -c Release
```

成功時主控台會輸出 `Fhir.ResourceCreator finished.`

於**儲存庫根目錄**（scaffold 門面；可重複執行）：

```powershell
dotnet run --project Fhir.ResourceCreator -- --scaffold-fhir-lines
```

其他旗標：

| 旗標 | 作用 |
|------|------|
| `--scaffold-fhir-lines` | 依已產生的 `Fhir.Resources.{Line}` 寫出／更新 `Fhir.Path.{Line}` 與 `Fhir.Sdk.{Line}` |
| `--emit-choice-helpers` | 為 choice 元素補產生輔助程式（進階；一般全量產生後不必單獨跑） |

### 產出目錄結構（範例）

```
generated/
  Fhir.Resources.R5/
    Fhir.Resources.R5.csproj
    Patient.cs
    Observation.cs
    ...
    Fhir.Resources.R5.Tests/
      Fhir.Resources.R5.Tests.csproj
      PatientSerializationTests.cs
      ...
```

## 建置與打包資源組件

於產出目錄（範例）：

```powershell
cd generated\Fhir.Resources.R5
dotnet build -c Release
dotnet pack -c Release
```

或在方案根目錄一次打包入口套件（應用實際該引用的是 `Fhir.Sdk.R*`）：

```powershell
dotnet pack Fhir.Sdk.slnx -c Release -o LocalNuget
```

測試專案通常 **`IsPackable` 為 false**，僅供驗證，不發佈為 NuGet。

## 引用產生之組件

- **應用／前端**：引用 **`Fhir.Sdk.{Line}`**，不要只加 `Fhir.Resources.*`。見 [開始使用](../getting-started/index.md)。
- **同儲存庫開發**：`ProjectReference` 指向 `Fhir.Sdk.R5/Fhir.Sdk.R5.csproj`（或新線別對應路徑）。
- **已發佈 NuGet**：`PackageReference` `Fhir.Sdk.R5`（會帶入 Resources、Path、TypeFramework）。

新線別要進方案與 VersionManager 之後，前端才能用偵測／宣告切到該版，見 [新增或升級 FHIR 線別](add-fhir-line.md) §3–§4。

## 與 IG SDK 的關係

產生 **核心資源**（`Fhir.Resources.R4` 等）後，方可對應線別產生 **Implementation Guide** 套件。IG 產生與 Profile 驗證請見 **[IG SDK 使用手冊](../application/ig-sdk/user-manual.md)**。

## 常見調整

| 需求 | 作法 |
|------|------|
| 僅產生部分資源 | 設定 `ResourcesInclude` 為類型名稱陣列 |
| 一次盡量全產 | `ResourcesInclude` 設為 `[]` 或省略鍵（若繫結模型預設為空） |
| 新大版本（R6 等） | 見 [新增或升級 FHIR 線別](add-fhir-line.md) |
| R4／R4B 套件 | `PackageId` 如 `hl7.fhir.r4.core`；R4B 請設 `OutputProjectName` 為 `Fhir.Resources.R4B` |
| 避免「Core」誤解 | 組件／命名空間使用 `Fhir.Resources.R5` 這類 **線別**名稱，不要用後綴 `Core` 表示整包資源（見命名文件） |

## 故障排除

- **找不到套件／HTTP 錯誤**：檢查網路、`RegistryBaseUrl`／`RegistryFallbackUrl`、防火牆與 Proxy。
- **建置失敗（缺少複合型別）**：多數為 **TypeFramework** 尚未涵蓋某 FHIR datatype；需在 `Fhir.TypeFramework` 擴充後重新產生。
- **路徑錯亂**：確認於 `Fhir.ResourceCreator` 目錄執行，或改為設定 **絕對路徑** 之 `OutputRoot`／快取目錄。
- **scaffold 沒寫出新線別**：確認 `generated/Fhir.Resources.{Line}/{Line}.csproj` 已存在，且從儲存庫根目錄執行 `--scaffold-fhir-lines`。

更細設定鍵請見 [設定參考](../reference/configuration.md)。
