# 貢獻指南

感謝您對 FHIR .NET SDK 的關注！我們歡迎所有形式的貢獻。

## 🤝 如何貢獻

### 報告問題

如果您發現了問題或有改進建議，請：

1. 檢查 [Issues](https://github.com/your-username/FHIR-SDK/issues) 是否已經有相關討論
2. 創建新的 Issue，並包含：
   - 問題的詳細描述
   - 重現步驟
   - 預期行為和實際行為
   - 環境資訊（作業系統、.NET 版本等）

### 提交程式碼

#### 1. Fork 專案

1. 前往 [GitHub 專案頁面](https://github.com/your-username/FHIR-SDK)
2. 點擊右上角的 "Fork" 按鈕
3. 將您的 Fork 複製到本地：

```bash
git clone https://github.com/your-username/FHIR-SDK.git
cd FHIR-SDK
```

#### 2. 設定開發環境

```bash
# 安裝 .NET 9.0 SDK
# 建置專案
dotnet build

# 執行測試
dotnet test
```

#### 3. 創建功能分支

```bash
# 確保您在 main 分支
git checkout main
git pull origin main

# 創建新的功能分支
git checkout -b feature/your-feature-name
```

#### 4. 進行開發

- 遵循現有的程式碼風格
- 添加適當的註解和文件
- 確保所有測試通過
- 添加新功能的測試

#### 5. 提交變更

```bash
# 添加變更的檔案
git add .

# 提交變更（使用清晰的提交訊息）
git commit -m "feat: add new FHIR primitive type support"

# 推送到您的 Fork
git push origin feature/your-feature-name
```

#### 6. 創建 Pull Request

1. 前往您的 GitHub Fork 頁面
2. 點擊 "Compare & pull request"
3. 填寫 PR 描述，包含：
   - 變更的詳細說明
   - 相關的 Issue 編號
   - 測試結果
   - 截圖（如果適用）

## 📋 開發指南

### 程式碼風格

我們遵循以下程式碼風格：

- 使用 4 個空格進行縮排
- 使用 PascalCase 命名類別和方法
- 使用 camelCase 命名變數和參數
- 使用有意義的變數和方法名稱
- 添加適當的 XML 文件註解

### 測試要求

- 所有新功能必須包含單元測試
- 測試覆蓋率應該保持在 80% 以上
- 測試應該清晰且易於理解

### 文件要求

- 所有公開 API 都必須有文件
- 使用範例應該清楚且實用
- 更新相關的 README 文件

## 🏗️ 專案結構

### 核心模組

- `Fhir.TypeFramework/` - FHIR R5 Type Framework 實作
- `Fhir.Core/` - 核心功能模組
- `Fhir.Generator/` - 程式碼生成工具

### 測試

- `Fhir.TypeFramework.Tests/` - Type Framework 測試
- `Fhir.Core.Tests/` - 核心功能測試
- `Fhir.Generator.Tests/` - 生成器測試

### 文件

- `docs/` - 專案文件
- `Examples/` - 使用範例

## 🔧 開發工具

### 必要工具

- .NET 9.0 SDK
- Visual Studio 2022 或 VS Code
- Git

### 建議工具

- ReSharper 或 Rider
- GitKraken 或 SourceTree
- Postman 或 Insomnia（API 測試）

## 📝 提交訊息規範

我們使用 [Conventional Commits](https://www.conventionalcommits.org/) 規範：

```
<type>[optional scope]: <description>

[optional body]

[optional footer(s)]
```

### 類型

- `feat`: 新功能
- `fix`: 錯誤修正
- `docs`: 文件變更
- `style`: 程式碼風格變更
- `refactor`: 重構
- `test`: 測試相關
- `chore`: 建置過程或輔助工具的變動

### 範例

```
feat(typeframework): add new FHIR primitive type FhirOid

fix(serialization): resolve JSON serialization issue with extensions

docs(readme): update installation instructions
```

## 🧪 測試指南

### 執行測試

```bash
# 執行所有測試
dotnet test

# 執行特定專案的測試
dotnet test Fhir.TypeFramework.Tests/

# 執行測試並生成覆蓋率報告
dotnet test --collect:"XPlat Code Coverage"
```

### 撰寫測試

```csharp
[Fact]
public void Should_Create_Valid_FhirString()
{
    // Arrange
    var value = "test";
    
    // Act
    var fhirString = new FhirString(value);
    
    // Assert
    Assert.Equal(value, fhirString.Value);
    Assert.True(fhirString.IsValid());
}
```

## 📚 文件指南

### 程式碼註解

```csharp
/// <summary>
/// 建立 FHIR 字串型別
/// </summary>
/// <param name="value">字串值</param>
/// <returns>FhirString 實例</returns>
/// <remarks>
/// FHIR R5 string 型別
/// 用於表示字串資料
/// </remarks>
public FhirString(string value)
{
    Value = value;
}
```

### README 文件

- 使用清晰的標題結構
- 包含程式碼範例
- 提供完整的安裝和使用說明
- 包含截圖和圖表（如果適用）

## 🚀 發布流程

### 版本號碼

我們使用 [Semantic Versioning](https://semver.org/)：

- `MAJOR.MINOR.PATCH`
- 例如：`1.0.0`、`1.1.0`、`1.1.1`

### 發布步驟

1. 更新版本號碼
2. 更新 CHANGELOG.md
3. 創建 Release Tag
4. 發布到 NuGet（如果適用）

## 🤝 行為準則

### 我們承諾

- 營造開放且友善的環境
- 尊重所有貢獻者
- 建設性地處理分歧

### 我們期望

- 使用友善和包容的語言
- 尊重不同的觀點和經驗
- 優雅地接受建設性批評
- 專注於對社群最有利的事情

## 📞 聯絡資訊

- 專案維護者：[your-email@example.com](mailto:your-email@example.com)
- 討論區：[GitHub Discussions](https://github.com/your-username/FHIR-SDK/discussions)
- Issue 追蹤：[GitHub Issues](https://github.com/your-username/FHIR-SDK/issues)

## 🙏 致謝

感謝所有為這個專案做出貢獻的開發者！

---

**注意**：本指南會隨著專案的發展持續更新。 