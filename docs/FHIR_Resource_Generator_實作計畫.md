# ??? FHIR Resource Generator 實作計畫

## ?? **專案概述**

**目標**: 建立一個基於 FHIR 官方定義檔的智能資源產生器，能夠自動生成符合現代化 SDK 要求的 R4 資源專案，並為未來新版本（如 R6）提供可重用的解決方案。

**實作對象**: R4 版本 (R5 已完成，R6 尚未公告)

## ?? **專案目標**

### **核心目標**
1. **自動化資源生成**: 基於 FHIR 官方 StructureDefinition 自動生成 R4 資源
2. **現代化架構**: 使用與 R5 相同的 `ResourceBase<TVersion>` 設計
3. **企業級品質**: 完整的文檔、驗證和工廠方法
4. **可擴展架構**: 為未來版本（R6/R7）奠定基礎

### **量化指標**
- **生成速度**: 3-5分鐘內完成全部 R4 資源（約100個）
- **程式碼品質**: 100% 編譯成功，0 警告
- **測試覆蓋**: 90% 以上程式碼覆蓋率
- **文檔完整**: 100% 資源有完整 XML 文檔

## ??? **系統架構設計**

### **專案結構**
```
Fhir_SDK/
├── Tools/
│   └── FhirResourceGenerator/
│       ├── FhirResourceGenerator.csproj
│       ├── Program.cs                      # CLI 主程式
│       ├── Core/
│       │   ├── IDefinitionParser.cs        # 定義檔解析介面
│       │   ├── IResourceGenerator.cs       # 資源生成介面
│       │   ├── ITemplateEngine.cs          # 模板引擎介面
│       │   ├── GeneratorContext.cs         # 生成上下文
│       │   └── GenerationResult.cs         # 生成結果
│       ├── Parsers/
│       │   ├── StructureDefinitionParser.cs # SD 解析器
│       │   ├── ElementDefinitionParser.cs   # 元素定義解析器
│       │   ├── FhirTypeResolver.cs         # 類型解析器
│       │   └── ConstraintProcessor.cs      # 約束處理器
│       ├── Generators/
│       │   ├── ResourceClassGenerator.cs   # 資源類別生成器
│       │   ├── BackboneElementGenerator.cs # 背骨元素生成器
│       │   ├── ChoiceTypeGenerator.cs      # 選擇類型生成器
│       │   ├── FactoryMethodGenerator.cs   # 工廠方法生成器
│       │   └── ProjectGenerator.cs         # 專案檔生成器
│       ├── Templates/
│       │   ├── ResourceTemplate.cs         # 資源模板
│       │   ├── PropertyTemplate.cs         # 屬性模板
│       │   ├── DocumentationTemplate.cs    # 文檔模板
│       │   └── FactoryTemplate.cs          # 工廠模板
│       ├── Configuration/
│       │   ├── GeneratorConfig.cs          # 生成器配置
│       │   ├── R4MappingConfig.cs          # R4 映射配置
│       │   └── TypeMappings.json           # 類型映射檔
│       └── Utilities/
│           ├── NamingUtils.cs              # 命名工具
│           ├── ValidationUtils.cs          # 驗證工具
│           └── FileUtils.cs                # 檔案工具
├── Definitions/
│   ├── R4/
│   │   ├── profiles-resources.json         # 資源定義檔
│   │   ├── profiles-types.json             # 類型定義檔
│   │   ├── valuesets.json                  # 值集定義檔
│   │   └── metadata.json                   # 版本元資料
│   ├── R5/ (已存在)
│   └── R6/ (未來)
├── FhirCore.R4/ (將生成)
│   ├── Resources/                          # 生成的資源類別
│   ├── Factory/                            # 生成的工廠類別
│   ├── FhirCore.R4.csproj                  # 專案檔
│   └── R4Version.cs                        # 版本實作
└── FhirCore.R4.Tests/ (將生成)
    ├── ResourceTests/                      # 資源測試
    ├── FactoryTests/                       # 工廠測試
    └── FhirCore.R4.Tests.csproj            # 測試專案檔
```

### **核心組件設計**

#### **1. 定義檔解析器 (Definition Parser)**
```csharp
public interface IDefinitionParser
{
    Task<IEnumerable<ResourceDefinition>> ParseResourceDefinitionsAsync(string definitionPath);
    Task<IEnumerable<DataTypeDefinition>> ParseDataTypeDefinitionsAsync(string definitionPath);
    Task<VersionMetadata> ExtractVersionMetadataAsync(string definitionPath);
}

public class StructureDefinitionParser : IDefinitionParser
{
    // 解析 StructureDefinition JSON 檔案
    // 提取資源屬性、約束、文檔等
    // 處理繼承關係和 profile 擴展
}
```

#### **2. 資源生成器 (Resource Generator)**
```csharp
public interface IResourceGenerator
{
    Task<GenerationResult> GenerateResourceAsync(ResourceDefinition definition, GeneratorContext context);
    Task<GenerationResult> GenerateProjectAsync(IEnumerable<ResourceDefinition> definitions, string targetPath);
}

public class ResourceClassGenerator : IResourceGenerator
{
    // 生成主要資源類別
    // 生成屬性、建構函式、驗證方法
    // 生成 BackboneElement 子類別
    // 生成 ChoiceType 類別
}
```

#### **3. 模板引擎 (Template Engine)**
```csharp
public interface ITemplateEngine
{
    string GenerateResourceClass(ResourceDefinition definition, TemplateContext context);
    string GenerateProperty(PropertyDefinition property, TemplateContext context);
    string GenerateDocumentation(DocumentationData docs, TemplateContext context);
}
```

## ?? **實作階段規劃**

### **第一階段：基礎設施建立** (Week 1)

#### **1.1 專案架構建立** (Day 1-2)
- [ ] 創建 `Tools/FhirResourceGenerator` 專案
- [ ] 設計核心介面和抽象類別
- [ ] 建立依賴注入容器
- [ ] 設定基礎配置系統

#### **1.2 定義檔管理** (Day 3-4)
- [ ] 建立 `Definitions/R4` 目錄結構
- [ ] 實作定義檔下載腳本
- [ ] 建立版本元資料管理
- [ ] 設計定義檔快取機制

#### **1.3 基礎解析器實作** (Day 5-7)
- [ ] 實作 JSON StructureDefinition 解析
- [ ] 實作 ElementDefinition 解析
- [ ] 建立 FHIR 類型映射系統
- [ ] 處理繼承關係和約束

### **第二階段：核心生成器實作** (Week 2)

#### **2.1 資源類別生成** (Day 8-10)
- [ ] 實作基本資源類別模板
- [ ] 實作屬性生成邏輯
- [ ] 實作建構函式生成
- [ ] 實作驗證方法生成

#### **2.2 複雜類型處理** (Day 11-12)
- [ ] BackboneElement 生成邏輯
- [ ] ChoiceType 生成邏輯
- [ ] 複雜巢狀結構處理
- [ ] 約束條件轉換

#### **2.3 文檔生成系統** (Day 13-14)
- [ ] XML 註解生成
- [ ] 使用範例生成
- [ ] 約束文檔生成
- [ ] DocFX 相容性確保

### **第三階段：R4 特殊處理** (Week 3)

#### **3.1 R4 vs R5 差異處理** (Day 15-17)
- [ ] 版本差異分析工具
- [ ] R4 特有類型處理
- [ ] 已移除屬性處理
- [ ] 約束條件差異處理

#### **3.2 工廠方法生成** (Day 18-19)
- [ ] 基本工廠方法生成
- [ ] 專業化工廠方法
- [ ] 測試資料生成方法
- [ ] 驗證輔助方法

#### **3.3 版本管理整合** (Day 20-21)
- [ ] R4Version 類別生成
- [ ] 版本管理器更新
- [ ] 支援資源列表生成
- [ ] 相容性檢查實作

### **第四階段：品質保證與優化** (Week 4)

#### **4.1 驗證系統整合** (Day 22-24)
- [ ] 自動驗證規則生成
- [ ] R4 特定驗證實作
- [ ] 錯誤訊息本地化
- [ ] 驗證效能優化

#### **4.2 測試生成** (Day 25-26)
- [ ] 單元測試自動生成
- [ ] 整合測試生成
- [ ] 效能測試基準
- [ ] 測試資料生成

#### **4.3 專案檔和配置** (Day 27-28)
- [ ] .csproj 檔案生成
- [ ] NuGet 套件配置
- [ ] 建置腳本生成
- [ ] CI/CD 配置更新

## ??? **技術實作細節**

### **定義檔解析策略**

#### **StructureDefinition 解析**
```csharp
public class StructureDefinitionParser
{
    public async Task<ResourceDefinition> ParseAsync(JsonElement structureDef)
    {
        var resourceDef = new ResourceDefinition
        {
            Name = structureDef.GetProperty("name").GetString(),
            Kind = structureDef.GetProperty("kind").GetString(),
            Abstract = structureDef.GetProperty("abstract").GetBoolean(),
            BaseDefinition = structureDef.GetProperty("baseDefinition").GetString(),
            Elements = await ParseElementsAsync(structureDef.GetProperty("snapshot").GetProperty("element")),
            Documentation = ExtractDocumentation(structureDef),
            Constraints = ExtractConstraints(structureDef)
        };
        
        return resourceDef;
    }
}
```

#### **資料類型映射**
```csharp
public static class FhirTypeMapper
{
    private static readonly Dictionary<string, TypeMapping> R4TypeMappings = new()
    {
        ["string"] = new("FhirString", "DataTypeServices.DataTypes.PrimitiveTypes"),
        ["boolean"] = new("FhirBoolean", "DataTypeServices.DataTypes.PrimitiveTypes"),
        ["integer"] = new("FhirInteger", "DataTypeServices.DataTypes.PrimitiveTypes"),
        ["dateTime"] = new("FhirDateTime", "DataTypeServices.DataTypes.PrimitiveTypes"),
        ["Reference"] = new("ReferenceType", "DataTypeServices.DataTypes.SpecialTypes"),
        ["CodeableConcept"] = new("CodeableConcept", "DataTypeServices.DataTypes.ComplexTypes"),
        // ... 完整的 R4 類型映射
    };
    
    public static TypeMapping MapFhirTypeToCSharp(string fhirType, bool isArray = false)
    {
        var mapping = R4TypeMappings.TryGetValue(fhirType, out var mapped) ? mapped : new(fhirType, "");
        return isArray ? mapping.AsArray() : mapping;
    }
}
```

### **程式碼生成模板**

#### **資源類別模板**
```csharp
public class ResourceTemplate
{
    public static string Generate(ResourceDefinition definition, TemplateContext context)
    {
        return $@"
using FhirCore.Base;
using FhirCore.R4;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using System.ComponentModel.DataAnnotations;

namespace FhirCore.R4.Resources
{{
    /// <summary>
    /// FHIR R4 {definition.Name} 資源
    /// 
    /// <para>
    /// {definition.Documentation.Summary}
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// {GenerateUsageExample(definition)}
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>FHIR R4 版本特點：</para>
    /// <list type="bullet">
    /// {GenerateR4Features(definition)}
    /// </list>
    /// 
    /// <para>約束條件：</para>
    /// <list type="bullet">
    /// {GenerateConstraints(definition)}
    /// </list>
    /// </remarks>
    public class {definition.Name} : ResourceBase<R4Version>
    {{
        {GeneratePrivateFields(definition)}
        
        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => ""{definition.Name}"";
        
        {GeneratePublicProperties(definition)}
        
        {GenerateConstructors(definition)}
        
        {GenerateValidationMethod(definition)}
        
        {GenerateUtilityMethods(definition)}
    }}
    
    {GenerateBackboneElements(definition)}
    
    {GenerateChoiceTypes(definition)}
}}";
    }
}
```

### **自動化工作流程**

#### **PowerShell 自動化腳本**
```powershell
# Generate-R4Resources.ps1
param(
    [string]$DefinitionsPath = "Definitions\R4",
    [string]$OutputPath = "FhirCore.R4",
    [switch]$Force = $false,
    [switch]$IncludeTests = $true,
    [switch]$UpdateSolution = $true
)

Write-Host "?? 開始 FHIR R4 資源生成..." -ForegroundColor Green

# 1. 驗證定義檔
Write-Host "?? 驗證定義檔..." -ForegroundColor Yellow
if (-not (Test-Path $DefinitionsPath)) {
    Write-Error "定義檔路徑不存在: $DefinitionsPath"
    exit 1
}

# 2. 執行資源生成器
Write-Host "?? 執行資源生成器..." -ForegroundColor Yellow
$args = @(
    "--definitions-path", $DefinitionsPath,
    "--output-path", $OutputPath,
    "--version", "R4"
)

if ($Force) { $args += "--force" }
if ($IncludeTests) { $args += "--include-tests" }

dotnet run --project Tools\FhirResourceGenerator -- $args

if ($LASTEXITCODE -ne 0) {
    Write-Error "資源生成失敗，錯誤代碼: $LASTEXITCODE"
    exit 1
}

# 3. 更新解決方案檔
if ($UpdateSolution) {
    Write-Host "?? 更新解決方案檔..." -ForegroundColor Yellow
    dotnet sln add "$OutputPath\FhirCore.R4.csproj"
    if ($IncludeTests) {
        dotnet sln add "$OutputPath.Tests\FhirCore.R4.Tests.csproj"
    }
}

# 4. 建置驗證
Write-Host "?? 驗證生成結果..." -ForegroundColor Yellow
dotnet build "$OutputPath\FhirCore.R4.csproj" --configuration Release

if ($LASTEXITCODE -eq 0) {
    Write-Host "? R4 資源生成完成！" -ForegroundColor Green
    
    # 顯示統計資訊
    $resourceCount = (Get-ChildItem "$OutputPath\Resources" -Filter "*.cs").Count
    $factoryCount = (Get-ChildItem "$OutputPath\Factory" -Filter "*.cs").Count
    
    Write-Host "?? 生成統計：" -ForegroundColor Cyan
    Write-Host "  - 資源檔案: $resourceCount" -ForegroundColor White
    Write-Host "  - 工廠檔案: $factoryCount" -ForegroundColor White
} else {
    Write-Error "建置驗證失敗，請檢查生成的程式碼"
    exit 1
}
```

#### **命令列介面設計**
```sh
# 生成 R4 所有資源
dotnet run --project Tools/FhirResourceGenerator -- generate --version R4

# 生成特定資源
dotnet run --project Tools/FhirResourceGenerator -- generate --version R4 --resources Patient,Observation,Condition

# 更新現有專案
dotnet run --project Tools/FhirResourceGenerator -- update --version R4 --target FhirCore.R4

# 驗證定義檔
dotnet run --project Tools/FhirResourceGenerator -- validate --definitions-path Definitions/R4

# 比較版本差異
dotnet run --project Tools/FhirResourceGenerator -- compare --from R4 --to R5 --output docs/R4-R5-differences.md

# 生成專案報告
dotnet run --project Tools/FhirResourceGenerator -- report --version R4 --output reports/R4-generation-report.md
```

## ?? **品質保證措施**

### **1. 自動化測試**
```csharp
[TestFixture]
public class GeneratedResourceValidationTests
{
    [Test]
    [TestCaseSource(nameof(GetAllR4Resources))]
    public void AllResources_Should_CompileSuccessfully(Type resourceType)
    {
        // 驗證所有生成的資源都能正常編譯
        var instance = Activator.CreateInstance(resourceType);
        Assert.That(instance, Is.Not.Null);
        Assert.That(instance, Is.InstanceOf<ResourceBase<R4Version>>());
    }
    
    [Test]
    [TestCaseSource(nameof(GetAllR4Resources))]
    public void AllResources_Should_HaveFactoryMethods(Type resourceType)
    {
        // 驗證所有資源都有對應的工廠方法
        var factoryMethod = typeof(R4Factory).GetMethod($"Create{resourceType.Name}");
        Assert.That(factoryMethod, Is.Not.Null);
    }
    
    [Test]
    [TestCaseSource(nameof(GetAllR4Resources))]
    public void AllResources_Should_HaveCompleteDocumentation(Type resourceType)
    {
        // 驗證所有資源都有完整的 XML 文檔
        var xmlDoc = resourceType.GetCustomAttribute<System.ComponentModel.DescriptionAttribute>();
        Assert.That(xmlDoc, Is.Not.Null);
    }
}
```

### **2. 程式碼品質檢查**
```yaml
# .github/workflows/r4-generation-quality.yml
name: R4 Resource Generation Quality Check
on: 
  push:
    paths: ['Tools/FhirResourceGenerator/**', 'Definitions/R4/**']
  pull_request:
    paths: ['Tools/FhirResourceGenerator/**', 'Definitions/R4/**']

jobs:
  generate-and-test:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4
      
      - name: Setup .NET 9
        uses: actions/setup-dotnet@v4
        with:
          dotnet-version: '9.0.x'
      
      - name: Download R4 Definitions
        run: |
          ./Tools/Scripts/Download-FhirDefinitions.ps1 -Version R4
      
      - name: Generate R4 Resources
        run: |
          dotnet run --project Tools/FhirResourceGenerator -- generate --version R4
      
      - name: Build Generated Code
        run: |
          dotnet build FhirCore.R4/FhirCore.R4.csproj --configuration Release
      
      - name: Run Tests
        run: |
          dotnet test FhirCore.R4.Tests/FhirCore.R4.Tests.csproj --configuration Release
      
      - name: Code Quality Analysis
        run: |
          dotnet format FhirCore.R4/FhirCore.R4.csproj --verify-no-changes
          dotnet build FhirCore.R4/FhirCore.R4.csproj --verbosity normal /p:TreatWarningsAsErrors=true
```

### **3. 效能基準測試**
```csharp
[MemoryDiagnoser]
[SimpleJob(RuntimeMoniker.Net90)]
public class ResourceGenerationBenchmarks
{
    [Benchmark]
    public async Task GenerateSingleResource()
    {
        var parser = new StructureDefinitionParser();
        var generator = new ResourceClassGenerator();
        
        var definition = await parser.ParseAsync("Definitions/R4/Patient.json");
        await generator.GenerateResourceAsync(definition, new GeneratorContext());
    }
    
    [Benchmark]
    public async Task GenerateAllR4Resources()
    {
        var generator = new ProjectGenerator();
        await generator.GenerateProjectAsync("Definitions/R4", "temp/R4");
    }
    
    [Benchmark]
    public void R4Factory_CreatePatient()
    {
        var patient = R4Factory.CreatePatient("test-001");
    }
}
```

## ?? **未來擴展計劃**

### **R6 支援準備**
當 R6 定義檔發布時，只需要：
1. **下載 R6 定義檔**: `./Download-FhirDefinitions.ps1 -Version R6`
2. **執行生成器**: `dotnet run --project Tools/FhirResourceGenerator -- generate --version R6`
3. **處理版本差異**: 新增 R6 特定類型映射
4. **更新版本管理**: 新增 `FhirR6Version` 類別

### **跨版本遷移工具**
```csharp
// 自動生成版本遷移器
public static class ResourceMigrator
{
    public static FhirCore.R5.Resources.Patient MigrateToR5(FhirCore.R4.Resources.Patient r4Patient)
    {
        // 基於定義檔差異自動生成遷移邏輯
        return new FhirCore.R5.Resources.Patient
        {
            Id = r4Patient.Id,
            Identifier = r4Patient.Identifier,
            Name = r4Patient.Name,
            // 處理 R4 -> R5 的屬性變化
        };
    }
}
```

### **Visual Studio 整合**
```xml
<!-- FhirResourceGenerator.targets -->
<Project>
  <PropertyGroup>
    <GenerateFhirResourcesOnBuild Condition="'$(GenerateFhirResourcesOnBuild)' == ''">false</GenerateFhirResourcesOnBuild>
  </PropertyGroup>
  
  <Target Name="GenerateR4Resources" BeforeTargets="BeforeBuild" Condition="'$(GenerateFhirResourcesOnBuild)' == 'true'">
    <Exec Command="dotnet run --project $(MSBuildThisFileDirectory)Tools\FhirResourceGenerator -- generate --version R4" />
  </Target>
</Project>
```

## ?? **成功指標**

### **技術指標**
- **生成速度**: < 5分鐘完成全部 R4 資源
- **程式碼品質**: 100% 編譯成功，0 靜態分析警告
- **測試覆蓋**: > 90% 程式碼覆蓋率
- **文檔完整**: 100% 資源有企業級 XML 文檔

### **質量指標**
- **架構一致性**: 與 R5 相同的設計模式
- **向前相容性**: 為 R6 做好架構準備
- **開發體驗**: 完整的 IntelliSense 和編譯時檢查
- **維護性**: 清晰的程式碼結構和文檔

### **業務指標**
- **開發效率**: 相比手動開發提升 95% 效率
- **錯誤減少**: 自動化消除人為錯誤
- **標準化**: 100% 符合 FHIR 官方規範
- **可重用性**: 工具可用於未來所有版本

## ?? **執行計劃**

### **立即開始**
1. **確認計劃**: 審核並確認此實作計劃
2. **建立專案**: 創建 `Tools/FhirResourceGenerator` 專案
3. **下載定義檔**: 取得 FHIR R4 官方定義檔
4. **開始第一階段**: 建立基礎設施

### **里程碑檢查點**
- **Week 1 結束**: 基礎設施完成，基本解析器工作
- **Week 2 結束**: 能生成基本的資源類別
- **Week 3 結束**: R4 特殊處理完成，工廠方法生成
- **Week 4 結束**: 完整的 R4 專案生成，所有測試通過

### **風險管控**
- **技術風險**: 複雜的 StructureDefinition 解析 → 段階式實作，先處理簡單資源
- **品質風險**: 生成程式碼品質不一致 → 嚴格的模板和驗證機制
- **時程風險**: 低估複雜度 → 每週檢查點，及時調整

---

**文件版本**: 1.0  
**建立日期**: 2025年8月3日  
**負責人**: GitHub Copilot  
**審核狀態**: 待確認