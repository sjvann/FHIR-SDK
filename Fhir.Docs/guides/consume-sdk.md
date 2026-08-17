# 在應用中使用 SDK

## 引用入口套件

見 [開始使用](../getting-started/index.md)。業務程式應依賴 `Fhir.Sdk.{Line}` 與（可選）`Fhir.VersionManager`，避免直接綁 `Fhir.Path.{Line}`。

套件發佈在 **GitHub Packages**（不是 nuget.org、也不是本機 `LocalNuget`）。引用專案必須加上來源並完成驗證，見下方。

## GitHub Packages 來源（FHIR.Solutions 等應用）

套件來源：`https://nuget.pkg.github.com/sjvann/index.json`

在應用儲庫根目錄的 `nuget.config` 加入（可與 nuget.org 並存；**不要**把密碼寫進此檔並提交）：

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <clear />
    <add key="nuget.org" value="https://api.nuget.org/v3/index.json" protocolVersion="3" />
    <add key="github-sjvann" value="https://nuget.pkg.github.com/sjvann/index.json" />
  </packageSources>
</configuration>
```

然後引用入口套件：

```xml
<ItemGroup>
  <PackageReference Include="Fhir.Sdk.R4" Version="1.0.0" />
  <!-- 或 Fhir.Sdk.R4B / Fhir.Sdk.R5；需要線別偵測時再加 Fhir.VersionManager -->
</ItemGroup>
```

### 本機還原

GitHub Packages 即使套件所屬 repo 為 public，還原仍通常要登入。擇一：

```powershell
# 用 PAT（至少 read:packages；private 套件再加 repo）
dotnet nuget add source "https://nuget.pkg.github.com/sjvann/index.json" `
  --name github-sjvann `
  --username YOUR_GITHUB_USERNAME `
  --password YOUR_GITHUB_PAT `
  --store-password-in-clear-text
```

或已安裝 GitHub CLI 時，用目前登入的 token：

```powershell
dotnet nuget add source "https://nuget.pkg.github.com/sjvann/index.json" `
  --name github-sjvann `
  --username YOUR_GITHUB_USERNAME `
  --password (gh auth token) `
  --store-password-in-clear-text
```

若來源已存在，改用 `dotnet nuget update source github-sjvann ...`。

### 應用的 GitHub Actions

```yaml
- name: Setup .NET
  uses: actions/setup-dotnet@v4
  with:
    dotnet-version: "10.0.x"
    source-url: https://nuget.pkg.github.com/sjvann/index.json
  env:
    NUGET_AUTH_TOKEN: ${{ secrets.GITHUB_TOKEN }}
```

跨儲庫（例如 FHIR-ProfileServer、FHIR.Solutions 還原 FHIR-SDK 套件）時：第一次發佈後，到 GitHub → **Packages** → 各套件（至少 `Fhir.Sdk.R4`／`R4B`／`R5`、`Fhir.VersionManager`、`Fhir.Validation`）→ **Package settings** → **Manage Actions access**，把應用儲庫加進去。若 `GITHUB_TOKEN` 仍讀不到，改在應用儲庫設 secret（PAT，`read:packages`），並把上面的 `NUGET_AUTH_TOKEN` 換成該 secret。

本倉發佈：將變更推上預設分支後，推 `v*` tag 或在 Actions 手動跑 **Publish NuGet**（`workflow_dispatch`）。列出／還原套件的 PAT 必須含 `read:packages`（目前僅 `repo`／`workflow` 的 `gh` token 會 403）。本機開發可用隔壁倉庫 `ProjectReference`，不擋功能實作。

不要把 FHIR-SDK 的本機 `LocalNuget` 路徑寫進應用的 `nuget.config`。

## Parse／Serialize

```csharp
using Fhir.Sdk.R4;
using Fhir.Resources.R4;

var patient = FhirSdkR4.ParseJson<Patient>(json);
var jsonOut = FhirSdkR4.SerializeJson(patient!);
var xmlOut = FhirSdkR4.SerializeXml(patient!);
var fromXml = FhirSdkR4.ParseXml<Patient>(xmlOut);
```

JSON 與 XML 寫入同一 POCO，禁止字串對翻。R4B／R5 將型別名中的 `R4` 換成對應線別。

## FHIRPath

```csharp
using Fhir.Sdk.R5;
using Fhir.Resources.R5;

var engine = FhirSdkR5.CreatePath();
var collection = engine.Evaluate("identifier.value", patient);
```

DI：

```csharp
using Fhir.Sdk.R5.DependencyInjection;

services.AddFhirSdkR5();
```

R4／R4B 將型別與方法名中的 `R5` 換成對應線別即可（`FhirSdkR4`、`AddFhirSdkR4`）。Patch API 目前僅 R5 門面提供。

## 多線別

需要依 `/metadata` 或設定切換線別時，註冊 VersionManager，再以窄化後的 Capability 模型驅動搜尋參數或 UI。細節見 [多線別開發體驗](../concepts/multi-version.md)。

```csharp
services.AddFhirVersionManager();
```

## Profile 驗證

```csharp
using Fhir.Sdk.R4;
using Fhir.Validation;

var catalog = new ProfileCatalog();
catalog.Add(structureDefinition); // 已 Parse 的 StructureDefinition POCO
var validator = FhirSdkR4.CreateValidator(catalog);
var report = validator.Validate(observation, ["http://hl7.org/fhir/StructureDefinition/Observation"]);
```

`Fhir.Validation` 由 `Fhir.Sdk.{Line}` 帶入。完整 ValueSet `$expand` 須外接 `ITerminologyService`。

## FHIR Package `.tgz`

- **執行期 IG 載入**（例如 FHIR Profile Server）由應用自建解壓，見消費端 ADR-0012。**不要**把未發佈的 `Fhir.Packages.Registry` 當 PackageReference。
- **ResourceCreator** 繼續用本倉內部 `Fhir.Packages.Registry` 下載 `hl7.fhir.r*.core`（工具用、不發佈）。
- **`Fhir.Validation.Packages.FhirPackageArtifactReader`** 只讀本機 `.tgz` 並列舉 conformance JSON，不做 HTTP Registry。

## 應用層產品

QueryBuilder、Terminology **服務實作**、每 IG 產生器不在本庫。請見 [應用層文件](../application/index.md) 與 [FHIR.Solutions](https://github.com/sjvann/FHIR.Solutions)。執行期 Profile 驗證見上方。

HL7 發布新大版本後，維護者須先產生並發佈對應的 `Fhir.Sdk.{Line}`，應用再改 `PackageReference`。手順見 [新增或升級 FHIR 線別](add-fhir-line.md)。
