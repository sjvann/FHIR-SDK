# 貢獻指南

感謝您對 FHIR SDK 專案的關注！本文檔將指導您如何參與專案開發。

## 📋 開發流程

### 1. 環境準備

```bash
# 克隆專案
git clone https://github.com/your-org/Fhir_SDK.git
cd Fhir_SDK

# 還原套件
dotnet restore

# 建置專案
dotnet build --configuration Release
```

### 2. 分支策略

我們採用 [Git Flow](https://nvie.com/posts/a-successful-git-branching-model/) 分支策略：

- `main` - 生產版本分支
- `develop` - 開發分支
- `feature/*` - 功能開發分支
- `hotfix/*` - 緊急修復分支
- `release/*` - 發布準備分支

### 3. 開發工作流程

```bash
# 1. 從 develop 分支建立功能分支
git checkout develop
git pull origin develop
git checkout -b feature/your-feature-name

# 2. 進行開發
# ... 編寫程式碼 ...

# 3. 執行本地測試
dotnet test --configuration Release
dotnet run --project PerformanceTests

# 4. 提交變更
git add .
git commit -m "feat: 新增 FHIR 驗證功能

- 實作結構驗證
- 新增語義驗證規則
- 更新文件"

# 5. 推送分支
git push origin feature/your-feature-name

# 6. 建立 Pull Request
```

## 🔧 程式碼規範

### 命名規範

- **類別**: PascalCase (`Patient`, `FhirValidationEngine`)
- **方法**: PascalCase (`ValidateResource`, `Serialize`)
- **屬性**: PascalCase (`ResourceType`, `BirthDate`)
- **常數**: PascalCase (`MaxLength`, `DefaultValue`)
- **私有欄位**: camelCase (`_supportedTypes`, `_validationEngine`)

### 程式碼風格

```csharp
// ✅ 正確
public class Patient : DomainResource
{
    private readonly string _id;
    
    public string Id 
    { 
        get => _id; 
        set => _id = value ?? throw new ArgumentNullException(nameof(value)); 
    }
    
    public HumanName Name { get; set; }
    
    public ValidationResult Validate()
    {
        if (string.IsNullOrEmpty(Id))
        {
            return ValidationResult.Error("ID 不能為空", nameof(Id));
        }
        
        return ValidationResult.Success();
    }
}

// ❌ 錯誤
public class patient : domainresource
{
    private string id;
    
    public string id 
    { 
        get { return id; } 
        set { id = value; } 
    }
}
```

### 文件規範

所有公開 API 必須包含 XML 文件：

```csharp
/// <summary>
/// 驗證 FHIR 資源
/// </summary>
/// <param name="resource">要驗證的資源</param>
/// <returns>驗證結果</returns>
/// <exception cref="ArgumentNullException">當 resource 為 null 時拋出</exception>
public ValidationResult ValidateResource(object resource)
{
    // 實作
}
```

## 🧪 測試要求

### 單元測試

- **覆蓋率要求**: 至少 90%
- **測試命名**: `[被測試類別]_[測試方法]_[預期結果]`
- **測試結構**: Arrange-Act-Assert

```csharp
[Test]
public void Patient_Validate_WithValidData_ReturnsSuccess()
{
    // Arrange
    var patient = new Patient { Id = "test-001", Name = new HumanName() };
    var validator = new FhirValidationEngine(new FhirR4Version());
    
    // Act
    var result = validator.ValidateResource(patient);
    
    // Assert
    Assert.That(result.IsValid, Is.True);
    Assert.That(result.Messages, Is.Empty);
}
```

### 效能測試

所有新功能必須包含效能測試：

```csharp
[Benchmark]
public void ValidatePatient_Performance()
{
    var patient = CreateTestPatient();
    var validator = new FhirValidationEngine(new FhirR4Version());
    
    var result = validator.ValidateResource(patient);
}
```

## 🔍 品質檢查

### 提交前檢查

```bash
# 1. 程式碼格式化
dotnet format

# 2. 靜態分析
dotnet build --verbosity normal

# 3. 執行測試
dotnet test --configuration Release --collect:"XPlat Code Coverage"

# 4. 效能測試
dotnet run --project PerformanceTests --configuration Release
```

### CI/CD 檢查

每次提交都會自動執行：

- ✅ 建置檢查
- ✅ 單元測試
- ✅ 程式碼覆蓋率分析
- ✅ 靜態程式碼分析
- ✅ 安全性掃描
- ✅ 效能基準測試

## 📝 提交訊息規範

採用 [Conventional Commits](https://www.conventionalcommits.org/) 規範：

```
<type>[optional scope]: <description>

[optional body]

[optional footer(s)]
```

### 類型

- `feat`: 新功能
- `fix`: 錯誤修復
- `docs`: 文件更新
- `style`: 程式碼風格調整
- `refactor`: 重構
- `test`: 測試相關
- `chore`: 建置工具或輔助工具變動

### 範例

```
feat(validation): 新增 FHIR R4 結構驗證

- 實作 ResourceType 驗證
- 新增 RequiredAttribute 檢查
- 更新驗證引擎文件

Closes #123
```

## 🚀 發布流程

### 版本號規範

採用 [Semantic Versioning](https://semver.org/)：

- `MAJOR.MINOR.PATCH`
- 範例: `1.2.3`

### 發布步驟

1. **準備發布分支**
   ```bash
   git checkout develop
   git checkout -b release/v1.2.0
   ```

2. **更新版本號**
   - 更新 `Directory.Build.props`
   - 更新 `README.md`

3. **執行完整測試**
   ```bash
   dotnet test --configuration Release
   dotnet run --project PerformanceTests
   ```

4. **合併到 main**
   ```bash
   git checkout main
   git merge release/v1.2.0
   git tag v1.2.0
   git push origin main --tags
   ```

5. **發布到 NuGet**
   - CI/CD 會自動發布

## 📞 支援與討論

- **技術討論**: [GitHub Discussions](https://github.com/your-org/Fhir_SDK/discussions)
- **問題回報**: [GitHub Issues](https://github.com/your-org/Fhir_SDK/issues)
- **功能請求**: [GitHub Issues](https://github.com/your-org/Fhir_SDK/issues)

## 📚 相關文件

- [開發環境設定](docs/DEVELOPMENT.md)
- [API 文件](docs/API.md)
- [效能測試指南](docs/PERFORMANCE.md)
- [安全性指南](docs/SECURITY.md) 