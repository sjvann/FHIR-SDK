# 應用層文件

本儲庫（FHIR-SDK）發佈型別、產生器、多線別執行期與 **Profile 執行期驗證**（`Fhir.Validation`）。下列產品在 **[FHIR.Solutions](https://github.com/sjvann/FHIR.Solutions)**，但與本 SDK 的 `Fhir.Sdk.{Line}`、`Fhir.Path` 相依，因此文件集中於此站交叉查閱。

| 產品 | 說明 |
|------|------|
| [IG SDK](ig-sdk/overview.md) | 執行期驗證在 `Fhir.Validation`；Solutions 可另做每 IG 產生器 |
| [Terminology](terminology/index.md) | FHIR 術語 HTTP 服務（部署、操作、管理 API）；本 SDK 只留 `ITerminologyService` |

應用仍應以 NuGet 引用本 SDK 的 `Fhir.Sdk.R*`，再疊加應用層套件。
