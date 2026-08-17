# 建置與發佈文件

所有公開文件集中在 **`Fhir.Docs/`**，以 [DocFX](https://dotnet.github.io/docfx/) 建置靜態站，並由 GitHub Actions 發佈到 GitHub Pages。

## 本機建置

於儲存庫根目錄：

```powershell
dotnet tool restore
dotnet docfx Fhir.Docs/docfx.json --serve
```

瀏覽器開啟提示的本機位址（預設 `http://localhost:8080`）。只建置不預覽則省略 `--serve`。

亦可：

```powershell
dotnet build Fhir.Docs/Fhir.Docs.csproj -t:BuildDocs
```

產出目錄為 `Fhir.Docs/_site/`（已列入 `.gitignore`）。API YAML 寫入 `Fhir.Docs/api/`（產生檔亦不提交）。

## 站台結構

| 區塊 | 對象 |
|------|------|
| 開始使用／概念／指南／參考 | 本 SDK 使用者與維護者 |
| API | 由公開 `.csproj` 抽出的 API 參考（不含產生之整包 Resources） |
| 應用層 | FHIR.Solutions 的 IG／Terminology，供交叉查閱 |
| 貢獻 | 本頁 |

新增文章：在對應資料夾放 Markdown，並於該層 `toc.yml` 列入。交叉連結請用相對路徑。

## GitHub Pages

工作流程：`.github/workflows/docs.yml`。

第一次啟用時，於 GitHub 儲存庫：

1. **Settings → Pages → Build and deployment → Source** 選 **GitHub Actions**。
2. 將變更推到預設分支（`main` 或 `master`），或手動 **Actions → Publish docs → Run workflow**。

站台網址為 `https://<owner>.github.io/<repo>/`。DocFX 使用相對連結，專案 Pages 與自訂網域皆可。
