# FHIR-SDK — 代理與協作者指引

本庫為 **FHIR SDK 核心**：TypeFramework、ResourceCreator、Resources、Path／Sdk、VersionManager。

| 項目 | 約定 |
|------|------|
| **.NET** | `net10.0` |
| **C#** | `ImplicitUsings` / `Nullable` 啟用 |
| **方案** | `Fhir.Sdk.slnx` |
| **套件版控** | `Directory.Packages.props`（Central Package Management） |

## 依賴邊界（SOLID）

- **單一職責**：本庫只提供型別、產生器與多線別執行期；不含 QueryBuilder／Terminology／Auth UI。
- **依賴方向**：應用層 → 本 SDK（NuGet）。禁止 SDK／測試反向依賴應用專案。
- **多線別**：以 `Fhir.VersionManager` 與跨線別契約擴充，避免呼叫端到處 `if (R4)`。

## 發佈套件

`Fhir.TypeFramework`、`Fhir.TypeFramework.Interop`、`Fhir.Path`、`Fhir.Path.R*`、`Fhir.Resources.R*`、`Fhir.Sdk.R*`、`Fhir.VersionManager`。

不發佈：`Packages.Registry`、`ResourceCreator`、測試專案。應用仍應優先只引用 `Fhir.Sdk.R*`（會帶入 Path.R*）。

## 文件

公開文件只維護在 **`Fhir.Docs/`**（DocFX → GitHub Pages）。勿再新增根目錄 `docs/`。

## 應用層

見獨立儲庫 **FHIR.Solutions**（QueryBuilder、Terminology、未來 CQL 等）。
