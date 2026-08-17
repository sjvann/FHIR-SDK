# FHIR IG SDK 使用手冊

> **執行期驗證**請用本 SDK 的 [`Fhir.Validation`](../../guides/consume-sdk.md)（`FhirSdkR4.CreateValidator`）。下列 IG 產生器／每 IG NuGet 流程屬 **[FHIR.Solutions](https://github.com/sjvann/FHIR.Solutions)**（可選，不是 Profile Server 的必要路徑）。

## 前置需求

- **.NET SDK**：與方案一致（`net10.0`）。
- **網路**：可連線 `https://packages.fhir.org`（或備援 Registry）。
- **已產生之 FHIR 線別資源**：對應線別的 `Fhir.Sdk.{Line}`（例如 US Core 8.0.1 為 **R4** → `Fhir.Sdk.R4`）。同 repo 開發時由 `Fhir.ResourceCreator` 產生 `Fhir.Resources.R4` 後 scaffold Sdk。

## 快速開始（US Core 範例）

### 1. 產生 IG SDK

於儲存庫根目錄或任意目錄執行（快取路徑相對於 repo 根目錄 `artifacts/fhir-packages`）：

```powershell
cd path\to\FHIR.Solutions
dotnet run --project Fhir.IGCreator -- install hl7.fhir.us.core@8.0.1
```

預期輸出類似：

```
Installing hl7.fhir.us.core@8.0.1...
Installed N package(s).
Found 39 constraint profile(s).
Generated Fhir.Ig.USCore at ...\Fhir.IGCreator\generated\Fhir.Ig.USCore (FHIR R4).
```

### 2. 建置產物

```powershell
dotnet build Fhir.IGCreator\generated\Fhir.Ig.USCore\Fhir.Ig.USCore.csproj
dotnet test Fhir.IGCreator\generated\Fhir.Ig.USCore.Tests\Fhir.Ig.USCore.Tests.csproj
```

### 3. 在應用程式引用

**同儲存庫開發**（`ProjectReference`）：

```xml
<ItemGroup>
  <ProjectReference Include="path\to\Fhir.IGCreator\generated\Fhir.Ig.USCore\Fhir.Ig.USCore.csproj" />
</ItemGroup>
```

**已發佈 NuGet**：

```xml
<ItemGroup>
  <PackageReference Include="Fhir.Ig.USCore" Version="1.0.0" />
  <!-- 會 transitive 帶入 Fhir.Ig.Core、Fhir.Sdk.R4 -->
</ItemGroup>
```

### 4. 註冊 DI 並驗證

```csharp
using Fhir.Ig.Core.Validation;
using Fhir.Ig.USCore;
using Fhir.Resources.R4;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddUSCoreIgWithPath();   // 含 Fhir.Ig.Core + US Core catalog + FHIRPath 引擎

var sp = services.BuildServiceProvider();
var validator = sp.GetRequiredService<IProfileConformanceValidator>();

var patient = new Patient
{
    Meta = new Meta
    {
        Profile = [new FhirCanonical(USCoreProfiles.us_core_patient)]
    },
    // ... 其他必填欄位
};

var result = validator.ValidateAgainstDeclaredProfiles(patient);
if (!result.Success)
{
    foreach (var issue in result.Issues)
        Console.WriteLine($"{issue.Severity}: {issue.Message}");
}
```

亦可指定 Profile URL（不讀 `meta.profile`）：

```csharp
var result = validator.Validate(patient, USCoreProfiles.us_core_patient);
```

## CLI 指令

```
Fhir.IGCreator install <packageId@version>
```

| 範例 | 產出專案 | DI 擴充方法 |
|------|----------|-------------|
| `hl7.fhir.us.core@8.0.1` | `Fhir.Ig.USCore` | `AddUSCoreIg()` / `AddUSCoreIgWithPath()` |
| `hl7.fhir.uv.ips@2.0.0`（示意） | `Fhir.Ig.UvIps` | `AddUvIpsIg()` / `AddUvIpsIgWithPath()` |

語意對齊 FHIR CLI 的 `fhir install packageId@version`。

## 產生器設定

目前以程式內預設為主（[`IgInstallOptions`](https://github.com/sjvann/FHIR.Solutions) 專案內 `Fhir.IGCreator/Pipeline/IgInstallOptions.cs`）；可於後續擴充 `appsettings.json`。

| 項目 | 預設 | 說明 |
|------|------|------|
| `RegistryBaseUrl` | `https://packages.fhir.org` | 主 Registry |
| `RegistryFallbackUrl` | `https://packages2.fhir.org` | 主站失敗時備援 |
| `PackageCacheDirectory` | `artifacts/fhir-packages` | 相對 **repo 根目錄** |
| `OutputRoot` | `generated` | 相對 `Fhir.IGCreator/` |

## 產出目錄結構

以 `hl7.fhir.us.core` 為例：

```
Fhir.IGCreator/generated/
  Fhir.Ig.USCore/
    Fhir.Ig.USCore.csproj
    USCoreProfiles.cs              # 各 Profile canonical URL 常數
    USCoreProfileInheritance.g.cs    # baseDefinition 父子關係
    USCoreBindings.g.cs            # binding 登錄表
    USCoreFixedValues.g.cs         # fixed 值常數
    USCoreProfileRules.g.cs        # cardinality / constraint 規則
    USCoreIgCatalogContributor.g.cs
    USCoreIgServiceCollectionExtensions.cs
  Fhir.Ig.USCore.Tests/
    Fhir.Ig.USCore.Tests.csproj
    IgCatalogTests.cs
```

## DI 擴充方法說明

每個產生的 IG 套件提供：

| 方法 | 說明 |
|------|------|
| `Add{ShortName}Ig()` | 註冊 `Fhir.Ig.Core` + 該 IG 的 `IIgCatalogContributor`（規則表寫入記憶體登錄） |
| `Add{ShortName}IgWithPath()` | 同上，並註冊對應線別 `FhirPath{Line}.CreateEngine()`，以執行 cardinality／constraint |

**建議**：需要驗證時使用 `*WithPath()`；僅需 Profile 常數與 binding 登錄、不需 FHIRPath 時可用 `Add{ShortName}Ig()`。

觸發 catalog 載入：解析任一 `IgCatalogLoader` 或 `IProfileConformanceValidator` 時，會套用所有已註冊的 `IIgCatalogContributor`。

## 產生檔案用途

| 檔案 | 用途 |
|------|------|
| `{Prefix}Profiles` | IntelliSense 友善的 Profile URL；例如 `USCoreProfiles.us_core_patient` |
| `{Prefix}ProfileInheritance` | 供 `IProfileInheritanceResolver` 判斷祖先／子 Profile |
| `{Prefix}Bindings` | `InMemoryBindingRegistry` 資料來源 |
| `{Prefix}ProfileRules` | `IProfileRuleRegistry`：cardinality、fixed、FHIRPath constraint |
| `{Prefix}IgServiceCollectionExtensions` | 應用程式 DI 入口 |

## 驗證 API（Fhir.Ig.Core）

| 介面／類型 | 說明 |
|------------|------|
| `IProfileConformanceValidator` | `Validate(resource, profileUrl)`、`ValidateAgainstDeclaredProfiles(resource)` |
| `ProfileValidationResult` | `Success`、`Issues`（含 `Severity`、`Message`、`ElementPath`） |
| `IProfileRuleRegistry` | 已註冊之 Profile URL 清單（測試／除錯用） |

### 驗證範圍（MVP）

| 已支援 | 說明 |
|--------|------|
| Cardinality | 依 FHIRPath 計算元素出現次數 |
| fixed 值 | 與 SD 中 fixedCode 等比對 |
| Binding 登錄 | 確認 binding 已登錄；**尚未**完整 ValueSet 展開驗證 |
| FHIRPath constraint | 執行 SD 上 constraint 運算式；失敗或無法解析時可能為 Warning |
| Profile 繼承鏈 | 驗證時沿 `baseDefinition` 合併祖先規則 |

| 尚未完整支援 | 說明 |
|----------------|------|
| Slicing | Phase 2 |
| mustSupport 語意 | 部分可透過 cardinality 間接涵蓋 |
| 外部 HAPI／Firely Validator | 可後接 `IExternalProfileValidator` |

## 多 IG 並存

應用可同時引用多個 IG 套件，並分別註冊：

```csharp
services.AddUSCoreIgWithPath();
services.AddUvIpsIgWithPath();   // 未來其他 IG
```

驗證時僅會套用 **資源 `meta.profile` 與已註冊 catalog 交集** 的 Profile。

## 與 Terminology 服務整合

開發／單機：產生的 `{Prefix}Bindings` + `InMemoryBindingRegistry` 即可進行 binding 存在性檢查。

若需 **ValueSet/$validate-code** 語意：可於伺服器情境將 SD 同步至 Terminology 的 Binding 登錄（見 [Terminology 使用手冊](../terminology/user-manual.md)），或後續使用 `TerminologyBindingValidator` 實作（規劃中）。

## 常見調整

| 需求 | 作法 |
|------|------|
| 新增另一 IG | 對該 package 再執行一次 `install packageId@version` |
| 更新 US Core 版本 | 修改 `@version` 後重新 `install`（會覆寫 `generated/Fhir.Ig.USCore`） |
| 僅要 Profile 常數、不驗證 | 引用 `Fhir.Ig.USCore`，使用 `USCoreProfiles.*` 即可，可不呼叫 Validator |
| 需要 FHIRPath 驗證 | 必須 `Add{ShortName}IgWithPath()` |

## QueryBuilder 整合

Blazor WASM 與 Avalonia 版 Query Builder 於「結果」區塊提供 **驗證** 按鈕：

1. 執行查詢取得 JSON（通常為 `Bundle`）。
2. 按 **驗證** 開啟雙欄視窗：左為查詢結果快照，右為 FHIR **`OperationOutcome`**（多筆時以 **`Bundle`** 包裝）。
3. 選擇 **Implementation Guide**（目前 pilot：**US Core**）。
4. **Profile** 可多選；未選則驗證該 IG 內全部相符 Profile。
5. 按 **執行驗證**。

驗證規則與本手冊前述一致：有 `meta.profile` 時取最特定 Profile；無宣告時對同 `resourceType` 之所有 IG Profile 各跑一次。

應用程式 DI 需呼叫：

```csharp
services.AddFhirQueryBuilderMultiVersionWithPath(...);
services.AddFhirQueryBuilderIgValidation();
```

## 延伸閱讀

- [IG SDK 架構](overview.md)
- [IG 命名與發佈](naming.md)
- [IG 疑難排解](troubleshooting.md)
- [ResourceCreator 使用手冊](../../guides/resource-creator.md)
