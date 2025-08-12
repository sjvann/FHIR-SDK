using FhirResourceGenerator.Core;
using Microsoft.Extensions.Logging;
using System.Text;

namespace FhirResourceGenerator.Generators;

/// <summary>
/// 專案生成器
/// </summary>
/// <remarks>
/// 負責生成專案結構和專案檔案
/// </remarks>
public class ProjectGenerator
{
    private readonly ILogger<ProjectGenerator> _logger;

    public ProjectGenerator(ILogger<ProjectGenerator> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// 創建專案結構
    /// </summary>
    public async Task CreateProjectStructureAsync(GeneratorContext context)
    {
        _logger.LogInformation("創建專案結構：{OutputPath}", context.OutputPath);

        await Task.CompletedTask; // 避免編譯器警告

        var directories = new[]
        {
            context.OutputPath,
            Path.Combine(context.OutputPath, "Resources"),
            Path.Combine(context.OutputPath, "Factory"),
            Path.Combine(context.OutputPath, "Extensions"),
            Path.Combine(context.OutputPath, "Validation")
        };

        foreach (var directory in directories)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
                _logger.LogDebug("創建目錄：{Directory}", directory);
            }
        }

        // 創建測試專案結構（如果需要）
        if (context.IncludeTests)
        {
            var testDirectories = new[]
            {
                $"{context.OutputPath}.Tests",
                Path.Combine($"{context.OutputPath}.Tests", "ResourceTests"),
                Path.Combine($"{context.OutputPath}.Tests", "FactoryTests"),
                Path.Combine($"{context.OutputPath}.Tests", "ValidationTests")
            };

            foreach (var directory in testDirectories)
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                    _logger.LogDebug("創建測試目錄：{Directory}", directory);
                }
            }
        }
    }

    /// <summary>
    /// 生成專案檔案
    /// </summary>
    public async Task GenerateProjectFilesAsync(GeneratorContext context, IEnumerable<ResourceDefinition> definitions)
    {
        _logger.LogInformation("生成專案檔案");

        // 生成主專案檔
        await GenerateMainProjectFileAsync(context);

        // 生成版本類別檔
        await GenerateVersionClassAsync(context);

        // 生成主要工廠類別
        await GenerateMainFactoryClassAsync(context, definitions);

        // 生成 README 檔案
        await GenerateReadmeFileAsync(context, definitions);
    }

    /// <summary>
    /// 生成主專案檔
    /// </summary>
    private async Task GenerateMainProjectFileAsync(GeneratorContext context)
    {
        var projectContent = $@"<Project Sdk=""Microsoft.NET.Sdk"">

  <PropertyGroup>
    <TargetFramework>net9.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <GeneratePackageOnBuild>True</GeneratePackageOnBuild>
    <Title>FHIR Core {context.Version}</Title>
    <Authors>sjvann</Authors>
    <Description>FHIR {context.Version} 資源實作</Description>
    <Version>1.0.0</Version>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
    <DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile>
    <NoWarn>$(NoWarn);1591</NoWarn>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include=""..\..\FhirCore\FhirCore.csproj"" />
    <ProjectReference Include=""..\..\DataTypeServices\DataTypeServices.csproj"" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include=""System.Text.Json"" Version=""9.0.0"" />
    <PackageReference Include=""System.ComponentModel.Annotations"" Version=""5.0.0"" />
  </ItemGroup>

</Project>";

        var projectFile = Path.Combine(context.OutputPath, $"FhirCore.{context.Version}.csproj");
        await File.WriteAllTextAsync(projectFile, projectContent);
        
        _logger.LogDebug("已生成專案檔：{File}", projectFile);
    }

    /// <summary>
    /// 生成版本類別
    /// </summary>
    private async Task GenerateVersionClassAsync(GeneratorContext context)
    {
        var versionContent = $@"using FhirCore.Versioning;

namespace FhirCore.{context.Version};

/// <summary>
/// FHIR {context.Version} 版本實作
/// </summary>
/// <remarks>
/// 實作 FHIR {context.Version} 版本的特定邏輯和設定
/// </remarks>
public class {context.Version}Version : IFhirVersion
{{
    /// <summary>
    /// 版本識別碼
    /// </summary>
    public string Version => ""{context.Version}";

    /// <summary>
    /// 版本名稱
    /// </summary>
    public string Name => ""FHIR {context.Version}";

    /// <summary>
    /// 版本描述
    /// </summary>
    public string Description => ""Fast Healthcare Interoperability Resources {context.Version}";

    /// <summary>
    /// 支援的資源類型
    /// </summary>
    public IEnumerable<string> SupportedResources => new[]
    {{
        // TODO: 添加支援的資源列表
        ""Patient"",
        ""Observation"",
        ""Practitioner""
        // ... 更多資源
    }};

    /// <summary>
    /// 是否支援指定的資源類型
    /// </summary>
    /// <param name=""resourceType"">資源類型</param>
    /// <returns>是否支援</returns>
    public bool IsResourceSupported(string resourceType)
    {{
        return SupportedResources.Contains(resourceType, StringComparer.OrdinalIgnoreCase);
    }}

    /// <summary>
    /// 取得版本特定的設定
    /// </summary>
    /// <param name=""key"">設定鍵</param>
    /// <returns>設定值</returns>
    public object? GetVersionSpecificSetting(string key)
    {{
        // TODO: 實作版本特定設定
        return key switch
        {{
            ""MaxResourceSize"" => 16 * 1024 * 1024, // 16MB
            ""DefaultEncoding"" => ""UTF-8"",
            ""SupportedFormats"" => new[] {{ ""json"", ""xml"" }},
            _ => null
        }};
    }}
}}";

        var versionFile = Path.Combine(context.OutputPath, $"{context.Version}Version.cs");
        await File.WriteAllTextAsync(versionFile, versionContent);
        
        _logger.LogDebug("已生成版本類別：{File}", versionFile);
    }

    /// <summary>
    /// 生成主要工廠類別
    /// </summary>
    private async Task GenerateMainFactoryClassAsync(GeneratorContext context, IEnumerable<ResourceDefinition> definitions)
    {
        var factoryBuilder = new StringBuilder();
        
        factoryBuilder.AppendLine($"using System;");
        factoryBuilder.AppendLine($"using FhirCore.{context.Version}.Resources;");
        factoryBuilder.AppendLine();
        factoryBuilder.AppendLine($"namespace FhirCore.{context.Version}.Factory;");
        factoryBuilder.AppendLine();
        factoryBuilder.AppendLine("/// <summary>");
        factoryBuilder.AppendLine($"/// FHIR {context.Version} 資源工廠");
        factoryBuilder.AppendLine("/// </summary>");
        factoryBuilder.AppendLine("/// <remarks>");
        factoryBuilder.AppendLine($"/// 提供建立 FHIR {context.Version} 資源的便利方法");
        factoryBuilder.AppendLine("/// </remarks>");
        factoryBuilder.AppendLine($"public static class {context.Version}Factory");
        factoryBuilder.AppendLine("{");

        // 為每個資源生成工廠方法
        foreach (var definition in definitions.Take(5)) // 限制數量以避免檔案過大
        {
            factoryBuilder.AppendLine($"    /// <summary>");
            factoryBuilder.AppendLine($"    /// 建立 {definition.Name} 資源");
            factoryBuilder.AppendLine($"    /// </summary>");
            factoryBuilder.AppendLine($"    /// <param name=\"id\">資源 ID</param>");
            factoryBuilder.AppendLine($"    /// <returns>{definition.Name} 資源實例</returns>");
            factoryBuilder.AppendLine($"    public static {definition.Name} Create{definition.Name}(string? id = null)");
            factoryBuilder.AppendLine($"    {{");
            factoryBuilder.AppendLine($"        return new {definition.Name}(id ?? Guid.NewGuid().ToString());");
            factoryBuilder.AppendLine($"    }}");
            factoryBuilder.AppendLine();
        }

        factoryBuilder.AppendLine("}");

        var factoryFile = Path.Combine(context.OutputPath, "Factory", $"{context.Version}Factory.cs");
        await File.WriteAllTextAsync(factoryFile, factoryBuilder.ToString());
        
        _logger.LogDebug("已生成主要工廠類別：{File}", factoryFile);
    }

    /// <summary>
    /// 生成測試專案
    /// </summary>
    public async Task GenerateTestProjectAsync(GeneratorContext context, IEnumerable<ResourceDefinition> definitions)
    {
        if (!context.IncludeTests)
            return;

        _logger.LogInformation("生成測試專案");

        var testProjectPath = $"{context.OutputPath}.Tests";

        // 生成測試專案檔
        await GenerateTestProjectFileAsync(context, testProjectPath);

        // 生成基本測試類別
        await GenerateBaseTestClassAsync(context, testProjectPath);

        // 為每個資源生成測試類別
        foreach (var definition in definitions.Take(3)) // 限制數量
        {
            await GenerateResourceTestClassAsync(context, testProjectPath, definition);
        }
    }

    /// <summary>
    /// 生成測試專案檔
    /// </summary>
    private async Task GenerateTestProjectFileAsync(GeneratorContext context, string testProjectPath)
    {
        var testProjectContent = $@"<Project Sdk=""Microsoft.NET.Sdk"">

  <PropertyGroup>
    <TargetFramework>net9.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <IsPackable>false</IsPackable>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include=""Microsoft.NET.Test.Sdk"" Version=""17.8.0"" />
    <PackageReference Include=""NUnit"" Version=""4.0.1"" />
    <PackageReference Include=""NUnit3TestAdapter"" Version=""4.5.0"" />
    <PackageReference Include=""NUnit.Analyzers"" Version=""3.9.0"" />
    <PackageReference Include=""coverlet.collector"" Version=""6.0.0"" />
    <PackageReference Include=""FluentAssertions"" Version=""6.12.0"" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include=""..\..\FhirCore.{context.Version}\FhirCore.{context.Version}.csproj"" />
  </ItemGroup>

</Project>";

        var testProjectFile = Path.Combine(testProjectPath, $"FhirCore.{context.Version}.Tests.csproj");
        await File.WriteAllTextAsync(testProjectFile, testProjectContent);
        
        _logger.LogDebug("已生成測試專案檔：{File}", testProjectFile);
    }

    /// <summary>
    /// 生成基本測試類別
    /// </summary>
    private async Task GenerateBaseTestClassAsync(GeneratorContext context, string testProjectPath)
    {
        var baseTestContent = $@"using NUnit.Framework;
using FluentAssertions;
using FhirCore.{context.Version}.Factory;

namespace FhirCore.{context.Version}.Tests;

/// <summary>
/// 基本測試類別
/// </summary>
[TestFixture]
public abstract class BaseResourceTest
{{
    [SetUp]
    public virtual void SetUp()
    {{
        // 測試設定
    }}

    [TearDown]
    public virtual void TearDown()
    {{
        // 測試清理
    }}

    /// <summary>
    /// 驗證資源基本屬性
    /// </summary>
    protected void ValidateResourceBasics<T>(T resource, string expectedResourceType)
        where T : class
    {{
        resource.Should().NotBeNull();
        // TODO: 添加更多基本驗證
    }}
}}";

        var baseTestFile = Path.Combine(testProjectPath, "BaseResourceTest.cs");
        await File.WriteAllTextAsync(baseTestFile, baseTestContent);
        
        _logger.LogDebug("已生成基本測試類別：{File}", baseTestFile);
    }

    /// <summary>
    /// 生成資源測試類別
    /// </summary>
    private async Task GenerateResourceTestClassAsync(GeneratorContext context, string testProjectPath, ResourceDefinition definition)
    {
        var testContent = $@"using NUnit.Framework;
using FluentAssertions;
using FhirCore.{context.Version}.Resources;
using FhirCore.{context.Version}.Factory;

namespace FhirCore.{context.Version}.Tests.ResourceTests;

/// <summary>
/// {definition.Name} 資源測試
/// </summary>
[TestFixture]
public class {definition.Name}Tests : BaseResourceTest
{{
    [Test]
    public void Create{definition.Name}_ShouldReturnValidInstance()
    {{
        // Arrange & Act
        var resource = {context.Version}Factory.Create{definition.Name}();

        // Assert
        ValidateResourceBasics(resource, ""{definition.Name}"");
        resource.Should().BeOfType<{definition.Name}>();
    }}

    [Test]
    public void Create{definition.Name}WithId_ShouldSetId()
    {{
        // Arrange
        var expectedId = ""test-{definition.Name.ToLower()}-001"";

        // Act
        var resource = {context.Version}Factory.Create{definition.Name}(expectedId);

        // Assert
        // TODO: 驗證 ID 設定
        resource.Should().NotBeNull();
    }}

    [Test]
    public void {definition.Name}_ToString_ShouldReturnExpectedFormat()
    {{
        // Arrange
        var resource = {context.Version}Factory.Create{definition.Name}(""test-001"");

        // Act
        var result = resource.ToString();

        // Assert
        result.Should().Contain(""{definition.Name}"");
        result.Should().Contain(""test-001"");
    }}
}}";

        var testFile = Path.Combine(testProjectPath, "ResourceTests", $"{definition.Name}Tests.cs");
        
        // 確保目錄存在
        var testDirectory = Path.GetDirectoryName(testFile)!;
        if (!Directory.Exists(testDirectory))
        {
            Directory.CreateDirectory(testDirectory);
        }

        await File.WriteAllTextAsync(testFile, testContent);
        
        _logger.LogDebug("已生成資源測試類別：{File}", testFile);
    }

    /// <summary>
    /// 生成 README 檔案
    /// </summary>
    private async Task GenerateReadmeFileAsync(GeneratorContext context, IEnumerable<ResourceDefinition> definitions)
    {
        var readmeContent = $@"# FHIR Core {context.Version}

這是自動生成的 FHIR {context.Version} 資源實作專案。

## ?? 專案概述

本專案包含 {definitions.Count()} 個 FHIR {context.Version} 資源的 C# 實作。

## ?? 使用方式

### 基本使用

```csharp
using FhirCore.{context.Version}.Factory;
using FhirCore.{context.Version}.Resources;

// 建立 Patient 資源
var patient = {context.Version}Factory.CreatePatient(""patient-001"");

// 設定基本資訊
// TODO: 添加屬性設定範例
```

### 驗證資源

```csharp
// TODO: 添加驗證範例
```

## ?? 資源統計

本專案包含以下資源：

{string.Join(Environment.NewLine, definitions.Select(d => $"- {d.Name}"))}

## ?? 開發資訊

- **生成時間**: {DateTime.UtcNow:yyyy-MM-dd HH:mm:ss} UTC
- **FHIR 版本**: {context.Version}
- **目標框架**: .NET 9.0

## ?? 注意事項

此專案由 FHIR Resource Generator 自動生成，請勿手動修改檔案。
如需修改，請調整生成器設定並重新生成。
";

        var readmeFile = Path.Combine(context.OutputPath, "README.md");
        await File.WriteAllTextAsync(readmeFile, readmeContent);
        
        _logger.LogDebug("已生成 README 檔案：{File}", readmeFile);
    }
}