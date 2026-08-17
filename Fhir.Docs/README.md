# Fhir.Docs

本儲庫**唯一**公開文件根目錄。以 DocFX 建置，並可發佈至 GitHub Pages。

| 區塊 | 路徑 | 說明 |
|------|------|------|
| 開始使用 | [getting-started/](getting-started/index.md) | 安裝、選擇 `Fhir.Sdk.R*` |
| 概念 | [concepts/](concepts/architecture.md) | 套件分層、TypeFramework、多線別、產生管線 |
| 指南 | [guides/](guides/consume-sdk.md) | 使用 SDK、ResourceCreator、測試、疑難排解 |
| 參考 | [reference/](reference/configuration.md) | 設定鍵、命名與發佈 |
| API | [api/](api/index.md) | DocFX 自公開專案抽出 |
| 應用層 | [application/](application/index.md) | IG SDK、Terminology（實作在 FHIR.Solutions） |
| 貢獻 | [contribute/](contribute/documentation.md) | 本機建置與 Pages 發佈 |

```powershell
dotnet tool restore
dotnet docfx Fhir.Docs/docfx.json --serve
```

細節見 [建置與發佈文件](contribute/documentation.md)。
