using FhirResourceGenerator.Core;
using Microsoft.Extensions.Logging;
using System.Text;

namespace FhirResourceGenerator.Generators;

/// <summary>
/// �M�ץͦ���
/// </summary>
/// <remarks>
/// �t�d�ͦ��M�׵��c�M�M���ɮ�
/// </remarks>
public class ProjectGenerator
{
    private readonly ILogger<ProjectGenerator> _logger;

    public ProjectGenerator(ILogger<ProjectGenerator> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// �ЫرM�׵��c
    /// </summary>
    public async Task CreateProjectStructureAsync(GeneratorContext context)
    {
        _logger.LogInformation("�ЫرM�׵��c�G{OutputPath}", context.OutputPath);

        await Task.CompletedTask; // �קK�sĶ��ĵ�i

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
                _logger.LogDebug("�Ыإؿ��G{Directory}", directory);
            }
        }

        // �Ыش��ձM�׵��c�]�p�G�ݭn�^
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
                    _logger.LogDebug("�Ыش��եؿ��G{Directory}", directory);
                }
            }
        }
    }

    /// <summary>
    /// �ͦ��M���ɮ�
    /// </summary>
    public async Task GenerateProjectFilesAsync(GeneratorContext context, IEnumerable<ResourceDefinition> definitions)
    {
        _logger.LogInformation("�ͦ��M���ɮ�");

        // �ͦ��D�M����
        await GenerateMainProjectFileAsync(context);

        // �ͦ��������O��
        await GenerateVersionClassAsync(context);

        // �ͦ��D�n�u�t���O
        await GenerateMainFactoryClassAsync(context, definitions);

        // �ͦ� README �ɮ�
        await GenerateReadmeFileAsync(context, definitions);
    }

    /// <summary>
    /// �ͦ��D�M����
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
    <Description>FHIR {context.Version} �귽��@</Description>
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
        
        _logger.LogDebug("�w�ͦ��M���ɡG{File}", projectFile);
    }

    /// <summary>
    /// �ͦ��������O
    /// </summary>
    private async Task GenerateVersionClassAsync(GeneratorContext context)
    {
        var versionContent = $@"using FhirCore.Versioning;

namespace FhirCore.{context.Version};

/// <summary>
/// FHIR {context.Version} ������@
/// </summary>
/// <remarks>
/// ��@ FHIR {context.Version} �������S�w�޿�M�]�w
/// </remarks>
public class {context.Version}Version : IFhirVersion
{{
    /// <summary>
    /// �����ѧO�X
    /// </summary>
    public string Version => ""{context.Version}";

    /// <summary>
    /// �����W��
    /// </summary>
    public string Name => ""FHIR {context.Version}";

    /// <summary>
    /// �����y�z
    /// </summary>
    public string Description => ""Fast Healthcare Interoperability Resources {context.Version}";

    /// <summary>
    /// �䴩���귽����
    /// </summary>
    public IEnumerable<string> SupportedResources => new[]
    {{
        // TODO: �K�[�䴩���귽�C��
        ""Patient"",
        ""Observation"",
        ""Practitioner""
        // ... ��h�귽
    }};

    /// <summary>
    /// �O�_�䴩���w���귽����
    /// </summary>
    /// <param name=""resourceType"">�귽����</param>
    /// <returns>�O�_�䴩</returns>
    public bool IsResourceSupported(string resourceType)
    {{
        return SupportedResources.Contains(resourceType, StringComparer.OrdinalIgnoreCase);
    }}

    /// <summary>
    /// ���o�����S�w���]�w
    /// </summary>
    /// <param name=""key"">�]�w��</param>
    /// <returns>�]�w��</returns>
    public object? GetVersionSpecificSetting(string key)
    {{
        // TODO: ��@�����S�w�]�w
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
        
        _logger.LogDebug("�w�ͦ��������O�G{File}", versionFile);
    }

    /// <summary>
    /// �ͦ��D�n�u�t���O
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
        factoryBuilder.AppendLine($"/// FHIR {context.Version} �귽�u�t");
        factoryBuilder.AppendLine("/// </summary>");
        factoryBuilder.AppendLine("/// <remarks>");
        factoryBuilder.AppendLine($"/// ���ѫإ� FHIR {context.Version} �귽���K�Q��k");
        factoryBuilder.AppendLine("/// </remarks>");
        factoryBuilder.AppendLine($"public static class {context.Version}Factory");
        factoryBuilder.AppendLine("{");

        // ���C�Ӹ귽�ͦ��u�t��k
        foreach (var definition in definitions.Take(5)) // ����ƶq�H�קK�ɮ׹L�j
        {
            factoryBuilder.AppendLine($"    /// <summary>");
            factoryBuilder.AppendLine($"    /// �إ� {definition.Name} �귽");
            factoryBuilder.AppendLine($"    /// </summary>");
            factoryBuilder.AppendLine($"    /// <param name=\"id\">�귽 ID</param>");
            factoryBuilder.AppendLine($"    /// <returns>{definition.Name} �귽���</returns>");
            factoryBuilder.AppendLine($"    public static {definition.Name} Create{definition.Name}(string? id = null)");
            factoryBuilder.AppendLine($"    {{");
            factoryBuilder.AppendLine($"        return new {definition.Name}(id ?? Guid.NewGuid().ToString());");
            factoryBuilder.AppendLine($"    }}");
            factoryBuilder.AppendLine();
        }

        factoryBuilder.AppendLine("}");

        var factoryFile = Path.Combine(context.OutputPath, "Factory", $"{context.Version}Factory.cs");
        await File.WriteAllTextAsync(factoryFile, factoryBuilder.ToString());
        
        _logger.LogDebug("�w�ͦ��D�n�u�t���O�G{File}", factoryFile);
    }

    /// <summary>
    /// �ͦ����ձM��
    /// </summary>
    public async Task GenerateTestProjectAsync(GeneratorContext context, IEnumerable<ResourceDefinition> definitions)
    {
        if (!context.IncludeTests)
            return;

        _logger.LogInformation("�ͦ����ձM��");

        var testProjectPath = $"{context.OutputPath}.Tests";

        // �ͦ����ձM����
        await GenerateTestProjectFileAsync(context, testProjectPath);

        // �ͦ��򥻴������O
        await GenerateBaseTestClassAsync(context, testProjectPath);

        // ���C�Ӹ귽�ͦ��������O
        foreach (var definition in definitions.Take(3)) // ����ƶq
        {
            await GenerateResourceTestClassAsync(context, testProjectPath, definition);
        }
    }

    /// <summary>
    /// �ͦ����ձM����
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
        
        _logger.LogDebug("�w�ͦ����ձM���ɡG{File}", testProjectFile);
    }

    /// <summary>
    /// �ͦ��򥻴������O
    /// </summary>
    private async Task GenerateBaseTestClassAsync(GeneratorContext context, string testProjectPath)
    {
        var baseTestContent = $@"using NUnit.Framework;
using FluentAssertions;
using FhirCore.{context.Version}.Factory;

namespace FhirCore.{context.Version}.Tests;

/// <summary>
/// �򥻴������O
/// </summary>
[TestFixture]
public abstract class BaseResourceTest
{{
    [SetUp]
    public virtual void SetUp()
    {{
        // ���ճ]�w
    }}

    [TearDown]
    public virtual void TearDown()
    {{
        // ���ղM�z
    }}

    /// <summary>
    /// ���Ҹ귽���ݩ�
    /// </summary>
    protected void ValidateResourceBasics<T>(T resource, string expectedResourceType)
        where T : class
    {{
        resource.Should().NotBeNull();
        // TODO: �K�[��h������
    }}
}}";

        var baseTestFile = Path.Combine(testProjectPath, "BaseResourceTest.cs");
        await File.WriteAllTextAsync(baseTestFile, baseTestContent);
        
        _logger.LogDebug("�w�ͦ��򥻴������O�G{File}", baseTestFile);
    }

    /// <summary>
    /// �ͦ��귽�������O
    /// </summary>
    private async Task GenerateResourceTestClassAsync(GeneratorContext context, string testProjectPath, ResourceDefinition definition)
    {
        var testContent = $@"using NUnit.Framework;
using FluentAssertions;
using FhirCore.{context.Version}.Resources;
using FhirCore.{context.Version}.Factory;

namespace FhirCore.{context.Version}.Tests.ResourceTests;

/// <summary>
/// {definition.Name} �귽����
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
        // TODO: ���� ID �]�w
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
        
        // �T�O�ؿ��s�b
        var testDirectory = Path.GetDirectoryName(testFile)!;
        if (!Directory.Exists(testDirectory))
        {
            Directory.CreateDirectory(testDirectory);
        }

        await File.WriteAllTextAsync(testFile, testContent);
        
        _logger.LogDebug("�w�ͦ��귽�������O�G{File}", testFile);
    }

    /// <summary>
    /// �ͦ� README �ɮ�
    /// </summary>
    private async Task GenerateReadmeFileAsync(GeneratorContext context, IEnumerable<ResourceDefinition> definitions)
    {
        var readmeContent = $@"# FHIR Core {context.Version}

�o�O�۰ʥͦ��� FHIR {context.Version} �귽��@�M�סC

## ?? �M�׷��z

���M�ץ]�t {definitions.Count()} �� FHIR {context.Version} �귽�� C# ��@�C

## ?? �ϥΤ覡

### �򥻨ϥ�

```csharp
using FhirCore.{context.Version}.Factory;
using FhirCore.{context.Version}.Resources;

// �إ� Patient �귽
var patient = {context.Version}Factory.CreatePatient(""patient-001"");

// �]�w�򥻸�T
// TODO: �K�[�ݩʳ]�w�d��
```

### ���Ҹ귽

```csharp
// TODO: �K�[���ҽd��
```

## ?? �귽�έp

���M�ץ]�t�H�U�귽�G

{string.Join(Environment.NewLine, definitions.Select(d => $"- {d.Name}"))}

## ?? �}�o��T

- **�ͦ��ɶ�**: {DateTime.UtcNow:yyyy-MM-dd HH:mm:ss} UTC
- **FHIR ����**: {context.Version}
- **�ؼЮج[**: .NET 9.0

## ?? �`�N�ƶ�

���M�ץ� FHIR Resource Generator �۰ʥͦ��A�ФŤ�ʭק��ɮסC
�p�ݭק�A�нվ�ͦ����]�w�í��s�ͦ��C
";

        var readmeFile = Path.Combine(context.OutputPath, "README.md");
        await File.WriteAllTextAsync(readmeFile, readmeContent);
        
        _logger.LogDebug("�w�ͦ� README �ɮסG{File}", readmeFile);
    }
}