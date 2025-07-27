---
type: "manual"
---

# FHIR Generator 開發指南

## 🎯 **開發環境設定**

### **必要工具**
- ✅ **.NET 9.0 SDK** - [下載連結](https://dotnet.microsoft.com/download/dotnet/9.0)
- ✅ **Visual Studio 2022** 或 **VS Code**
- ✅ **Git** - 版本控制
- ✅ **PowerShell** 或 **Bash** - 命令列工具

### **推薦工具**
- 🔧 **ReSharper** 或 **Rider** - 程式碼分析
- 📊 **dotCover** - 程式碼覆蓋率
- 🧪 **xUnit Test Explorer** - 測試執行器

### **環境驗證**
```bash
# 檢查 .NET 版本
dotnet --version

# 檢查 Git 版本
git --version

# 檢查專案建置
dotnet build Fhir.Generator/
```

## 📁 **專案結構詳解**

```
Fhir.Generator/
├── Program.cs              # 程式進入點和命令列介面
├── Services/               # 核心服務
│   ├── SimpleGenerator.cs  # 主要生成邏輯
│   ├── TypeMapper.cs       # 類型映射
│   └── FhirDefinitionLoader.cs # 定義檔載入器
├── Models/                 # 資料模型
│   └── GeneratorModels.cs  # 內部資料結構
├── Definitions/            # FHIR 定義檔
│   └── R4/
│       └── definitions.json.zip
├── TestGeneration.cs       # 測試生成功能
└── Fhir.Generator.csproj   # 專案檔
```

## 🔧 **核心架構理解**

### **設計原則**
1. **單一職責** - 每個類別只負責一個功能
2. **關注點分離** - 生成邏輯與 SDK 功能分離
3. **可擴展性** - 容易添加新的 FHIR 版本支援
4. **可測試性** - 所有核心邏輯都可以單元測試

### **資料流程**
```
FHIR Definitions → FhirDefinitionLoader → ResourceInfo/PrimitiveTypeInfo → SimpleGenerator → C# Code
```

### **類型映射邏輯**
```csharp
// FHIR → C# 映射規則
"string" → "FhirString?"
"boolean" → "FhirBoolean?"
"integer" → "FhirInteger?"
"Identifier" → "List<Identifier>?" (if cardinality > 1)
```

## 🧪 **開發工作流程**

### **1. 設定開發環境**
```bash
# 克隆專案
git clone https://github.com/your-org/FHIR-SDK.git
cd FHIR-SDK

# 建立開發分支
git checkout -b feature/your-feature-name

# 建置專案
dotnet build
```

### **2. 開發新功能**
```bash
# 執行測試確保基線正常
dotnet test Fhir.Generator.Tests/

# 開發新功能...

# 執行測試驗證變更
dotnet test Fhir.Generator.Tests/

# 測試生成功能
dotnet run --project Fhir.Generator --fhir-version R4 --test
```

### **3. 程式碼品質檢查**
```bash
# 程式碼格式化
dotnet format

# 建置檢查
dotnet build --configuration Release

# 執行所有測試
dotnet test --configuration Release
```

## 📝 **程式碼風格指南**

### **命名慣例**
```csharp
// 類別名稱 - PascalCase
public class SimpleGenerator

// 方法名稱 - PascalCase
public string GenerateSimpleResource()

// 屬性名稱 - PascalCase
public string ClassName { get; set; }

// 私有欄位 - camelCase with underscore
private readonly TypeMapper _typeMapper;

// 常數 - PascalCase
public const string DefaultVersion = "R4";
```

### **註解規範**
```csharp
/// <summary>
/// 生成 FHIR Resource 類別的 C# 程式碼
/// </summary>
/// <param name="info">Resource 的定義資訊</param>
/// <param name="version">FHIR 版本 (如 "R4", "R5")</param>
/// <returns>生成的 C# 程式碼</returns>
public string GenerateSimpleResource(ResourceInfo info, string version)
{
    // 實作邏輯...
}
```

### **錯誤處理**
```csharp
// 使用具體的例外類型
if (string.IsNullOrEmpty(version))
{
    throw new ArgumentException("FHIR version cannot be null or empty", nameof(version));
}

// 提供有意義的錯誤訊息
if (!supportedVersions.Contains(version))
{
    throw new ArgumentException($"Unsupported FHIR version: {version}. Supported: {string.Join(", ", supportedVersions)}", nameof(version));
}
```

## 🧪 **測試指南**

### **測試結構**
```
Fhir.Generator.Tests/
├── GeneratedCodeCompilationTests.cs  # 編譯測試
├── SdkUsageTests.cs                   # SDK 使用測試
└── UnitTests/                         # 單元測試
    ├── SimpleGeneratorTests.cs
    ├── TypeMapperTests.cs
    └── DefinitionLoaderTests.cs
```

### **測試類型**

#### **單元測試**
```csharp
[Fact]
public void GenerateSimpleResource_WithValidInput_ShouldReturnValidCode()
{
    // Arrange
    var generator = new SimpleGenerator();
    var resourceInfo = new ResourceInfo
    {
        ClassName = "TestResource",
        ResourceType = "TestResource",
        Description = "Test description"
    };

    // Act
    var result = generator.GenerateSimpleResource(resourceInfo, "R4");

    // Assert
    Assert.Contains("public class TestResource : DomainResource", result);
    Assert.Contains("FhirString?", result);
}
```

#### **整合測試**
```csharp
[Fact]
public async Task GeneratedCode_ShouldCompile_Successfully()
{
    // Arrange
    var generator = new SimpleGenerator();
    var resourceInfo = CreateTestResourceInfo();
    
    // Act
    var generatedCode = generator.GenerateSimpleResource(resourceInfo, "R4");
    
    // Assert
    var compilationResult = await CompileCode(generatedCode);
    Assert.True(compilationResult.Success);
}
```

### **測試執行**
```bash
# 執行所有測試
dotnet test

# 執行特定測試類別
dotnet test --filter "SimpleGeneratorTests"

# 執行特定測試方法
dotnet test --filter "GenerateSimpleResource_WithValidInput_ShouldReturnValidCode"

# 產生覆蓋率報告
dotnet test --collect:"XPlat Code Coverage"
```

## 🔄 **新增 FHIR 版本支援**

### **步驟 1: 準備定義檔**
```bash
# 建立新版本目錄
mkdir Fhir.Generator/Definitions/R5

# 下載 R5 定義檔
# 從 FHIR 官方網站下載 definitions.json.zip
```

### **步驟 2: 更新版本驗證**
```csharp
// 在 SimpleGenerator.cs 中更新
private VersionInfo ValidateVersion(string version)
{
    var supportedVersions = new[] { "R4", "R5", "R6" }; // 添加 R5
    
    if (!supportedVersions.Contains(version.ToUpper()))
    {
        throw new ArgumentException($"Unsupported FHIR version: {version}");
    }
    
    return new VersionInfo
    {
        Name = version.ToUpper(),
        DefinitionFile = $"Definitions\\{version.ToUpper()}\\definitions.json.zip"
    };
}
```

### **步驟 3: 測試新版本**
```bash
# 測試 R5 生成
dotnet run --project Fhir.Generator --fhir-version R5 --test

# 檢查生成結果
dotnet build Fhir.R5.Models/
```

## 🐛 **除錯技巧**

### **常見問題診斷**

#### **生成的程式碼有語法錯誤**
```bash
# 檢查生成的程式碼
cat Generated_TestResource.cs

# 檢查編譯錯誤
dotnet build Fhir.R4.Models/ > build.log 2>&1
cat build.log
```

#### **類型映射錯誤**
```csharp
// 在 TypeMapper 中添加除錯輸出
public string MapType(string fhirType, string propertyName)
{
    Console.WriteLine($"Mapping: {fhirType} -> ?");
    var result = fhirType switch
    {
        // 映射邏輯...
    };
    Console.WriteLine($"Result: {fhirType} -> {result}");
    return result;
}
```

#### **記憶體使用問題**
```bash
# 監控記憶體使用
dotnet-counters monitor --process-id <pid> --counters System.Runtime

# 設定記憶體限制
export DOTNET_GCHeapHardLimit=4000000000
```

### **效能分析**
```bash
# 使用 dotnet-trace 分析效能
dotnet-trace collect --process-id <pid> --providers Microsoft-DotNETCore-SampleProfiler

# 分析結果
dotnet-trace report trace.nettrace
```

## 📋 **提交指南**

### **提交訊息格式**
```
<type>(<scope>): <description>

[optional body]

[optional footer]
```

### **類型說明**
- `feat`: 新功能
- `fix`: 錯誤修正
- `docs`: 文件更新
- `style`: 程式碼格式化
- `refactor`: 重構
- `test`: 測試相關
- `chore`: 建置或輔助工具變更

### **範例**
```
feat(generator): 添加 R5 版本支援

- 新增 R5 定義檔載入邏輯
- 更新版本驗證機制
- 添加 R5 特定的類型映射

Closes #123
```

## 🔮 **未來開發方向**

### **短期目標 (v1.1)**
- [ ] 完整的 R5 支援
- [ ] 版本間差異分析
- [ ] 改善錯誤處理

### **中期目標 (v1.2)**
- [ ] 互動式生成模式
- [ ] 自動備份機制
- [ ] 效能最佳化

### **長期目標 (v2.0)**
- [ ] 插件式架構
- [ ] 自訂範本支援
- [ ] 完整的 CI/CD 整合

## 📞 **開發支援**

### **取得幫助**
- 📖 查看 [架構文件](./Architecture.md)
- 🔧 查看 [API 參考](./API.md)
- 💬 參與 GitHub Discussions
- 🐛 回報 GitHub Issues

### **貢獻流程**
1. Fork 專案
2. 建立功能分支
3. 開發並測試
4. 提交 Pull Request
5. 程式碼審查
6. 合併到主分支

---

**記住：Generator 的核心使命是專注於 FHIR 模型生成，保持簡潔和專注！** 🎯
