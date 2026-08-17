# IG SDK 命名與 NuGet 發佈約定

## 套件邊界

| 套件 | Packable | 說明 |
|------|----------|------|
| `Fhir.Validation` | 是（本 SDK） | 執行期 Profile 驗證；由 `Fhir.Sdk.{Line}` 帶入 |
| `Fhir.Ig.{ShortName}` | 是（Solutions，可選） | 每 IG 一個；例 `Fhir.Ig.USCore` |
| `Fhir.IGCreator` | 否 | CLI 工具，不發佈 |
| `Fhir.Packages.Registry` | 否 | 內部共用，不發佈。Server 執行期勿引用 |

## PackageId → ShortName 推斷

由 FHIR.Solutions 內 `Fhir.IGCreator/Configuration/GeneratedIgNaming.cs` 自 `package-id` 推導：

| Registry package-id | ShortName | 專案／NuGet | DI 前綴 |
|---------------------|-----------|-------------|---------|
| `hl7.fhir.us.core` | `USCore` | `Fhir.Ig.USCore` | `USCore` → `AddUSCoreIg()` |
| `hl7.fhir.uv.ips` | `UvIps` | `Fhir.Ig.UvIps` | `UvIps` → `AddUvIpsIg()` |

規則摘要：

- 去掉 `hl7.fhir.` 前綴後，各段轉 PascalCase。
- 兩字母國別／領域碼 `us` → `US`；`uv` → `Uv`。
- **不要** 在 IG 套件名稱使用 `Core`（與資源組件相同理由；共用邏輯在 `Fhir.Ig.Core`）。

## 產出命名空間

- 根命名空間：`Fhir.Ig.{ShortName}`（與組件名一致）。
- Profile 常數類別：`{ShortName}Profiles`（例 `USCoreProfiles`）。
- 規則表：`{ShortName}ProfileRules`、`{ShortName}Bindings` 等。

## 對外依賴

產生的 `Fhir.Ig.{ShortName}.csproj` 固定引用：

- `Fhir.Ig.Core`
- `Fhir.Sdk.{Line}`（由 IG 內 `fhirVersion`／`package.json` 推斷，US Core 8.0.1 為 **R4**）

應用程式引用 **`Fhir.Ig.USCore` 單一套件** 即可取得 Sdk transitive 依賴，無需再手動加 `Fhir.Sdk.R4`（除非應用直接使用 Sdk API）。

## 打包

```powershell
cd Fhir.IGCreator\generated\Fhir.Ig.USCore
dotnet pack -c Release
```

測試專案 `Fhir.Ig.{ShortName}.Tests` 預設 **不打包**。

## 儲存庫開發 vs 已發佈

| 情境 | 建議引用 |
|------|----------|
| 同 repo | `ProjectReference` → `Fhir.IGCreator/generated/Fhir.Ig.USCore/Fhir.Ig.USCore.csproj` |
| 已發佈 NuGet | `PackageReference Include="Fhir.Ig.USCore"` |

## 延伸閱讀

- [IG SDK 使用手冊](user-manual.md)
- [資源組件命名](../../reference/naming-and-packaging.md)
- `AGENTS.md`
