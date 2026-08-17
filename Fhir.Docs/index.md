# FHIR .NET SDK 文件

強型別 FHIR 基礎型別、資源產生器，以及 R4／R4B／R5 多線別執行期。

## 應用開發者從這裡開始

1. 依目標 FHIR 版本引用 **一個** 套件：`Fhir.Sdk.R4`、`Fhir.Sdk.R4B` 或 `Fhir.Sdk.R5`。
2. 不必單獨引用 `Fhir.Path.*` 或 `Fhir.Resources.*`——入口套件會帶入 TypeFramework、Interop、FHIRPath 與資源 POCO。
3. 需要依伺服器宣告或偵測線別時，再加上 `Fhir.VersionManager`。

| 我想… | 請看 |
|--------|------|
| 安裝並寫第一段程式 | [開始使用](getting-started/index.md) |
| 理解 Path／Sdk／Resources 為何拆開 | [套件分層](concepts/architecture.md) |
| 切換 R4／R4B／R5 | [多線別開發體驗](concepts/multi-version.md) |
| 重新產生資源 POCO | [ResourceCreator 手冊](guides/resource-creator.md) |
| 接上新的 FHIR 大版本（如 R6） | [新增或升級 FHIR 線別](guides/add-fhir-line.md) |
| 查公開 API | [API 參考](api/index.md) |

## 本庫與應用層

本儲庫只提供 **SDK 核心**（型別、產生器、多線別執行期）。QueryBuilder、Terminology、IG Profile 驗證等應用層請見 [FHIR.Solutions](https://github.com/sjvann/FHIR.Solutions)；相關說明收在 [應用層文件](application/index.md)。
