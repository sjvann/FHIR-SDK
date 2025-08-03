# 開發環境設定與維護作業標準流程

## 🛠️ 開發環境設定

### 必要軟體

1. **.NET 9.0 SDK**
   ```bash
   # 下載並安裝 .NET 9.0 SDK
   # https://dotnet.microsoft.com/download/dotnet/9.0
   ```

2. **Visual Studio 2022 或 VS Code**
   - Visual Studio 2022 Community/Professional/Enterprise
   - VS Code + C# 擴充功能

3. **PowerShell 7.0+**
   ```bash
   # 安裝 PowerShell 7
   winget install Microsoft.PowerShell
   ```

4. **Git**
   ```bash
   # 安裝 Git
   winget install Git.Git
   ```

### 專案設定

```bash
# 1. 克隆專案
git clone https://github.com/your-org/Fhir_SDK.git
cd Fhir_SDK

# 2. 還原套件
dotnet restore

# 3. 建置專案
dotnet build --configuration Release

# 4. 執行測試
dotnet test --configuration Release
```

## 📋 日常開發流程

### 1. 開始新功能開發

```bash
# 1. 更新 develop 分支
git checkout develop
git pull origin develop

# 2. 建立功能分支
git checkout -b feature/your-feature-name

# 3. 開始開發
# ... 編寫程式碼 ...
```

### 2. 本地測試流程

```bash
# 1. 程式碼格式化
dotnet format

# 2. 靜態分析
dotnet build --verbosity normal

# 3. 執行單元測試
dotnet test --configuration Release --collect:"XPlat Code Coverage"

# 4. 執行效能測試
dotnet run --project PerformanceTests --configuration Release

# 5. 檢查程式碼覆蓋率
# 結果會在 ./coverage/ 目錄中
```

### 3. 提交前檢查清單

- [ ] 程式碼已格式化 (`dotnet format`)
- [ ] 靜態分析無警告 (`dotnet build`)
- [ ] 單元測試全部通過 (`dotnet test`)
- [ ] 效能測試通過 (`dotnet run --project PerformanceTests`)
- [ ] 程式碼覆蓋率 > 90%
- [ ] 已添加必要的 XML 文件
- [ ] 提交訊息符合規範

### 4. 提交變更

```bash
# 1. 添加變更
git add .

# 2. 提交變更
git commit -m "feat(validation): 新增 FHIR R4 結構驗證

- 實作 ResourceType 驗證
- 新增 RequiredAttribute 檢查
- 更新驗證引擎文件

Closes #123"

# 3. 推送分支
git push origin feature/your-feature-name
```

## 🔄 CI/CD 流程

### 自動化檢查

每次推送到 `develop` 或 `main` 分支時，GitHub Actions 會自動執行：

1. **建置與測試** (`build-and-test`)
   - 多平台建置 (Ubuntu, Windows)
   - 執行單元測試
   - 收集程式碼覆蓋率
   - 上傳到 Codecov

2. **程式碼品質** (`code-quality`)
   - 靜態程式碼分析
   - StyleCop 檢查
   - CodeQL 安全性掃描

3. **效能測試** (`performance-test`)
   - 執行效能基準測試
   - 生成效能報告

4. **發布** (`publish`) - 僅在 `main` 分支
   - 建置發布版本
   - 打包 NuGet 套件
   - 發布到 NuGet

### 手動觸發

```bash
# 在 GitHub 上手動觸發工作流程
# Actions > CI/CD Pipeline > Run workflow
```

## 🧪 測試策略

### 單元測試

```bash
# 執行所有測試
dotnet test --configuration Release

# 執行特定專案測試
dotnet test DataTypeServices.Tests --configuration Release

# 執行特定測試類別
dotnet test --filter "TestClass=PatientTests"

# 生成覆蓋率報告
dotnet test --collect:"XPlat Code Coverage" --results-directory ./coverage
```

### 效能測試

```bash
# 執行所有效能測試
dotnet run --project PerformanceTests --configuration Release

# 執行特定效能測試
dotnet run --project PerformanceTests --configuration Release --filter "*Serialization*"

# 生成 HTML 報告
dotnet run --project PerformanceTests --configuration Release --exporters HTML
```

### 整合測試

```bash
# 執行整合測試
dotnet test --filter "Category=Integration" --configuration Release
```

## 🔍 程式碼品質檢查

### 靜態分析

```bash
# 建置時自動執行靜態分析
dotnet build --verbosity normal

# 檢查特定分析器
dotnet build --verbosity normal /p:AnalysisLevel=latest
```

### 程式碼風格檢查

```bash
# 檢查程式碼格式
dotnet format --verify-no-changes

# 自動格式化
dotnet format
```

### 安全性掃描

```bash
# 執行 CodeQL 掃描 (在 CI/CD 中自動執行)
# 本地可以執行依賴掃描
dotnet list package --vulnerable
```

## 📊 監控與報告

### 程式碼覆蓋率

```bash
# 生成覆蓋率報告
dotnet test --collect:"XPlat Code Coverage" --results-directory ./coverage

# 查看覆蓋率結果
# 結果檔案: ./coverage/coverage.cobertura.xml
```

### 效能監控

```bash
# 執行效能測試並生成報告
dotnet run --project PerformanceTests --configuration Release --exporters JSON --artifacts ./benchmarks

# 查看效能結果
# 結果檔案: ./benchmarks/BenchmarkDotNet.Artifacts/results/
```

### 品質指標

- **程式碼覆蓋率**: > 90%
- **靜態分析警告**: 0
- **效能基準**: 
  - 序列化: < 1ms
  - 驗證: < 5ms
- **建置時間**: < 30 秒

## 🚀 發布流程

### 準備發布

```bash
# 1. 更新版本號
# 編輯 Directory.Build.props
# 更新 Version 屬性

# 2. 建立發布分支
git checkout develop
git checkout -b release/v1.2.0

# 3. 執行完整測試
dotnet test --configuration Release
dotnet run --project PerformanceTests --configuration Release

# 4. 提交版本更新
git add .
git commit -m "chore: 更新版本號至 v1.2.0"
```

### 發布到生產環境

```bash
# 1. 合併到 main 分支
git checkout main
git merge release/v1.2.0

# 2. 建立標籤
git tag v1.2.0

# 3. 推送變更
git push origin main --tags

# 4. CI/CD 會自動發布到 NuGet
```

## 🔧 故障排除

### 常見問題

1. **建置失敗**
   ```bash
   # 清理並重新建置
   dotnet clean
   dotnet restore
   dotnet build --configuration Release
   ```

2. **測試失敗**
   ```bash
   # 檢查測試環境
   dotnet test --verbosity normal
   
   # 重新執行失敗的測試
   dotnet test --filter "FullyQualifiedName~TestName"
   ```

3. **效能測試失敗**
   ```bash
   # 檢查效能測試環境
   dotnet run --project PerformanceTests --configuration Release --verbosity normal
   ```

### 開發工具設定

#### Visual Studio 2022

1. **安裝擴充功能**
   - StyleCop.Analyzers
   - Code Coverage
   - Performance Profiler

2. **設定程式碼風格**
   - 啟用 EditorConfig
   - 設定程式碼格式化規則

#### VS Code

1. **安裝擴充功能**
   - C# Dev Kit
   - .NET Install Tool
   - GitLens

2. **設定檔案**
   ```json
   // .vscode/settings.json
   {
     "dotnet.defaultSolution": "Fhir_SDK.sln",
     "omnisharp.enableEditorConfigSupport": true,
     "omnisharp.enableRoslynAnalyzers": true
   }
   ```

## 📚 相關資源

- [.NET 文件](https://docs.microsoft.com/dotnet/)
- [FHIR 規格](https://www.hl7.org/fhir/)
- [Git Flow 工作流程](https://nvie.com/posts/a-successful-git-branching-model/)
- [Conventional Commits](https://www.conventionalcommits.org/) 