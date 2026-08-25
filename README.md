# FHIR .NET SDK

強型別 FHIR 基礎型別、資源產生器與多線別（R4／R4B／R5）執行期支援。

## 產品定位

- **單一 TypeFramework**：跨線別共用 Normative primitives／基底型別（`Fhir.TypeFramework`）。
- **線別資源套件**：`Fhir.Resources.R4`／`R4B`／`R5`（由 `Fhir.ResourceCreator` 自 FHIR Package Registry 產生）。
- **對外入口**：應用通常只引用 `Fhir.Sdk.R4`／`R4B`／`R5`（含 TypeFramework、Interop、FHIRPath、Resources）。
- **多線別 DX（競爭優勢）**：透過 `Fhir.VersionManager` **宣告或偵測** FHIR 線別；理想情況下切換線別時業務程式不變或僅小幅調整（Capability 窄化模型等）。SDK **不強迫**綁死單一版本——由開發端決定使用哪一線別。

## 方案結構

| 專案 | 角色 |
|------|------|
| `Fhir.TypeFramework` | 基底資料型別 NuGet |
| `Fhir.TypeFramework.Interop` | POCO 建構輔助 |
| `Fhir.Packages.Registry` | FHIR NPM 套件下載／解析（工具用，不發佈） |
| `Fhir.ResourceCreator` | 執行檔：產生 `Fhir.Resources.*` 並 scaffold `Fhir.Sdk.*` |
| `Fhir.Resources.R*` | 各線別資源 POCO NuGet |
| `Fhir.Path` / `Fhir.Path.R*` | FHIRPath（線別門面由 Sdk 帶入） |
| `Fhir.Sdk.R*` | 各線別單一入口 NuGet |
| `Fhir.VersionManager` | 線別偵測／宣告與 Capability 窄化 |

應用層（QueryBuilder、Terminology、CQL 等）請使用 **[FHIR.Solutions](https://github.com/sjvann/FHIR.Solutions)**，以 NuGet 引用本 SDK。

## SDK Atlas（開發者目錄）

`Fhir.Dashboard` 是給工程師看的目錄，不是產品線、不發佈 NuGet。可檢視 TypeFramework datatype、ResourceCreator 已生成的 R4／R4B／R5 資源，並連回 HL7 官方文件；介面詞彙支援 zh-TW／en／ja。

```bash
dotnet run --project Fhir.Dashboard --urls http://localhost:5090
```

AION 控制台群組 **SDK** → **FHIR SDK Atlas**（埠 5090）。設計規格在 [`design-system/fhir-sdk-atlas/`](design-system/fhir-sdk-atlas/MASTER.md)。

## 建置

```bash
dotnet build Fhir.Sdk.slnx
dotnet test Fhir.Sdk.slnx
dotnet pack Fhir.Sdk.slnx -o LocalNuget
```

## ResourceCreator

```bash
dotnet run --project Fhir.ResourceCreator -- --help
```

詳見 [Fhir.Docs/guides/resource-creator.md](Fhir.Docs/guides/resource-creator.md)。接上新的 FHIR 大版本（取得套件、指令、融入方案、應用如何引用）見 [Fhir.Docs/guides/add-fhir-line.md](Fhir.Docs/guides/add-fhir-line.md)。

## 多線別使用（VersionManager）

```csharp
services.AddFhirVersionManager();
// 宣告或依 /metadata、Base URL 偵測 FhirVersion.R4 | R4B | R5
// 再以 IFhirCapabilityRuntime 取得跨線別 ICapabilityModel
```

詳見 [Fhir.Docs/concepts/multi-version.md](Fhir.Docs/concepts/multi-version.md)。

## 文件

公開文件集中於 **`Fhir.Docs/`**（DocFX）。本機預覽：

```bash
dotnet tool restore
dotnet docfx Fhir.Docs/docfx.json --serve
```

推送到預設分支後可由 GitHub Actions 發佈至 GitHub Pages。見 [Fhir.Docs/contribute/documentation.md](Fhir.Docs/contribute/documentation.md)。

## 授權

MIT（見 LICENSE；若尚未還原請沿用上游授權條款）。
