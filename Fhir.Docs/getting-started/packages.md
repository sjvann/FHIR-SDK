# 選擇線別與套件

## 選哪一個 `Fhir.Sdk.*`

依你要對接的 FHIR 伺服器／IG 的 `fhirVersion`：

| 線別 | 套件 | 典型來源 |
|------|------|----------|
| R4 | `Fhir.Sdk.R4` | US Core 多數版本、多數正式環境 |
| R4B | `Fhir.Sdk.R4B` | 少數過渡部署 |
| R5 | `Fhir.Sdk.R5` | 新專案或已宣告 R5 的伺服器 |

同一應用可以同時引用多條線別，但強型別資源（如 `Fhir.Resources.R4.Patient` 與 `Fhir.Resources.R5.Patient`）**不能混用**。跨線別邏輯請走 [VersionManager](../concepts/multi-version.md) 的契約，而不是到處 `if (R4)`。

## 使用者不必單獨引用的套件

| 套件 | 原因 |
|------|------|
| `Fhir.Path` / `Fhir.Path.R*` | 由 `Fhir.Sdk.{Line}` 帶入；`Path.R*` 為線別門面 |
| `Fhir.Resources.R*` | 同上；資源 POCO 隨入口套件提供 |
| `Fhir.TypeFramework` | 同上；需要時仍可直接引用 |
| `Fhir.Validation` | 由 `Fhir.Sdk.{Line}` 帶入；亦可單獨引用 |
| `Fhir.ResourceCreator` | 產生器，不發佈給應用 |
| `Fhir.Packages.Registry` | 工具用，不發佈。執行期 IG `.tgz` 由應用自建，或用 `Fhir.Validation.Packages.FhirPackageArtifactReader` 讀本機檔 |

新大版本尚未出現在上表時，代表本庫尚未產生該線別。維護流程見 [新增或升級 FHIR 線別](../guides/add-fhir-line.md)；完成發佈後，應用改引用對應的 `Fhir.Sdk.{Line}` 即可。

詳見 [套件分層](../concepts/architecture.md)。
