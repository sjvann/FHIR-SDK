# 應用層文件

本儲庫（FHIR-SDK）只發佈型別、產生器與多線別執行期。下列產品在 **[FHIR.Solutions](https://github.com/sjvann/FHIR.Solutions)**，但與本 SDK 的 `Fhir.Sdk.{Line}`、`Fhir.Path`、`Fhir.Packages.Registry` 相依，因此文件集中於此站交叉查閱。

| 產品 | 說明 |
|------|------|
| [IG SDK](ig-sdk/overview.md) | 由 Registry IG 套件產生 `Fhir.Ig.{ShortName}`，以 `Fhir.Ig.Core` 做 Profile 驗證 |
| [Terminology](terminology/index.md) | FHIR 術語 HTTP 服務（部署、操作、管理 API） |

應用仍應以 NuGet 引用本 SDK 的 `Fhir.Sdk.R*`，再疊加應用層套件。
