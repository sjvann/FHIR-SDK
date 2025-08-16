using Microsoft.Extensions.Logging;
using FhirResourceGenerator.Core;
using FhirResourceGenerator.Configuration;

namespace FhirResourceGenerator.Templates;

/// <summary>
/// 模板引擎實作
/// 
/// <para>
/// 負責根據模板和資料生成程式碼片段。
/// </para>
/// </summary>
public class TemplateEngine : ITemplateEngine
{
    private readonly R4MappingConfig _mappingConfig;
    private readonly ILogger<TemplateEngine> _logger;

    public TemplateEngine(R4MappingConfig mappingConfig, ILogger<TemplateEngine> logger)
    {
        _mappingConfig = mappingConfig;
        _logger = logger;
    }

    /// <summary>
    /// 生成資源類別程式碼
    /// </summary>
    public string GenerateResourceClass(ResourceDefinition definition, TemplateContext context)
    {
        var usings = GenerateUsings(definition, context);
        var classDocumentation = GenerateClassDocumentation(definition, context);
        var privateFields = GeneratePrivateFields(definition, context);
        var publicProperties = GeneratePublicProperties(definition, context);
        var constructors = GenerateConstructors(definition, context);
        var validationMethod = GenerateValidationMethod(definition, context);
        var utilityMethods = GenerateUtilityMethods(definition, context);
        var backboneElements = GenerateBackboneElements(definition, context);
        var choiceTypes = GenerateChoiceTypes(definition, context);

        return $@"{usings}

namespace {context.GeneratorContext.ResourceNamespace}
{{
{classDocumentation}
    public class {definition.Name} : ResourceBase<{context.GeneratorContext.Version}Version>
    {{
{privateFields}

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => ""{definition.Name}"";

{publicProperties}

{constructors}

{validationMethod}

{utilityMethods}
    }}

{backboneElements}

{choiceTypes}
}}";
    }

    /// <summary>
    /// 生成屬性程式碼
    /// </summary>
    public string GenerateProperty(PropertyDefinition property, TemplateContext context)
    {
        var documentation = GeneratePropertyDocumentation(property);
        var propertyType = MapFhirTypeToCSharp(property.Type, property.IsArray);
        var propertyName = property.Name;
        var fieldName = "_" + char.ToLower(propertyName[0]) + propertyName[1..];

        return $@"        {documentation}
        public {propertyType} {propertyName}
        {{
            get => {fieldName};
            set {{ {fieldName} = value; OnPropertyChanged(); }}
        }}";
    }

    /// <summary>
    /// 生成文檔註解
    /// </summary>
    public string GenerateDocumentation(DocumentationData docs, TemplateContext context)
    {
        var summary = !string.IsNullOrEmpty(docs.Summary) ? docs.Summary : "FHIR 資源";
        var description = !string.IsNullOrEmpty(docs.Description) ? docs.Description : "詳細描述待補充";

        return $@"    /// <summary>
    /// {summary}
    /// 
    /// <para>
    /// {description}
    /// </para>
    /// </summary>";
    }

    /// <summary>
    /// 生成工廠方法程式碼
    /// </summary>
    public string GenerateFactoryMethods(ResourceDefinition definition, TemplateContext context)
    {
        return $@"
using {context.GeneratorContext.ResourceNamespace};

namespace {context.GeneratorContext.FactoryNamespace}
{{
    /// <summary>
    /// {definition.Name} 工廠方法
    /// </summary>
    public static partial class {context.GeneratorContext.Version}Factory
    {{
        /// <summary>
        /// 建立 {definition.Name} 資源
        /// </summary>
        /// <returns>新的 {definition.Name} 實例</returns>
        public static {definition.Name} Create{definition.Name}()
        {{
            return new {definition.Name}();
        }}

        /// <summary>
        /// 建立具有指定 ID 的 {definition.Name} 資源
        /// </summary>
        /// <param name=""id"">資源 ID</param>
        /// <returns>新的 {definition.Name} 實例</returns>
        public static {definition.Name} Create{definition.Name}(string id)
        {{
            return new {definition.Name}(id);
        }}
    }}
}}";
    }

    /// <summary>
    /// 生成專案檔案
    /// </summary>
    public string GenerateProjectFile(ProjectInfo projectInfo, TemplateContext context)
    {
        var packageReferences = string.Join("\n", projectInfo.PackageReferences.Select(p => 
            $"    <PackageReference Include=\"{p.Name}\" Version=\"{p.Version}\" />"));
        
        var projectReferences = string.Join("\n", projectInfo.ProjectReferences.Select(p => 
            $"    <ProjectReference Include=\"{p}\" />"));

        return $@"<Project Sdk=""Microsoft.NET.Sdk"">

  <PropertyGroup>
    <TargetFramework>{projectInfo.TargetFramework}</TargetFramework>
    <LangVersion>13.0</LangVersion>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <AssemblyName>{projectInfo.Name}</AssemblyName>
    <RootNamespace>{projectInfo.Name}</RootNamespace>
    <AssemblyTitle>{projectInfo.Name}</AssemblyTitle>
    <AssemblyDescription>{projectInfo.Description}</AssemblyDescription>
    <AssemblyVersion>{projectInfo.Version}.0</AssemblyVersion>
    <FileVersion>{projectInfo.Version}.0</FileVersion>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
  </PropertyGroup>

  <ItemGroup>
{packageReferences}
  </ItemGroup>

  <ItemGroup>
{projectReferences}
  </ItemGroup>

</Project>";
    }

    #region Private Methods

    /// <summary>
    /// 生成 using 語句
    /// </summary>
    private string GenerateUsings(ResourceDefinition definition, TemplateContext context)
    {
        return $@"using FhirCore.Base;
using FhirCore.{context.GeneratorContext.Version};
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using FhirCore.Interfaces;";
    }

    /// <summary>
    /// 生成類別文檔
    /// </summary>
    private string GenerateClassDocumentation(ResourceDefinition definition, TemplateContext context)
    {
        var summary = !string.IsNullOrEmpty(definition.Documentation.Summary) 
            ? definition.Documentation.Summary 
            : $"FHIR {context.GeneratorContext.Version} {definition.Name} 資源";
        
        var description = !string.IsNullOrEmpty(definition.Documentation.Description)
            ? definition.Documentation.Description
            : $"{definition.Name} 資源的詳細描述將在此處添加。";

        return $@"    /// <summary>
    /// {summary}
    /// 
    /// <para>
    /// {description}
    /// 這是 FHIR {context.GeneratorContext.Version} 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var {definition.Name.ToLower()} = new {definition.Name}(""{definition.Name.ToLower()}-001"");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// {context.GeneratorContext.Version} 版本的 {definition.Name} 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>";
    }

    /// <summary>
    /// 生成私有欄位
    /// </summary>
    private string GeneratePrivateFields(ResourceDefinition definition, TemplateContext context)
    {
        var fields = new List<string>();
        
        // 只處理基本屬性，避免過於複雜
        var simpleElements = definition.PropertyElements.Take(10).Where(e => 
            !e.IsChoiceType && 
            e.Types.Count == 1 && 
            !string.IsNullOrEmpty(e.Types.FirstOrDefault()?.Code));

        foreach (var element in simpleElements)
        {
            var fieldType = MapFhirTypeToCSharp(element.Types.First().Code, element.IsArray);
            var fieldName = "_" + char.ToLower(element.PropertyName[0]) + element.PropertyName[1..];
            fields.Add($"        private {fieldType} {fieldName};");
        }

        return string.Join("\n", fields);
    }

    /// <summary>
    /// 生成公開屬性
    /// </summary>
    private string GeneratePublicProperties(ResourceDefinition definition, TemplateContext context)
    {
        var properties = new List<string>();
        
        // 只處理基本屬性
        var simpleElements = definition.PropertyElements.Take(10).Where(e => 
            !e.IsChoiceType && 
            e.Types.Count == 1 && 
            !string.IsNullOrEmpty(e.Types.FirstOrDefault()?.Code));

        foreach (var element in simpleElements)
        {
            var property = new PropertyDefinition
            {
                Name = element.PropertyName,
                Type = element.Types.First().Code,
                IsArray = element.IsArray,
                IsRequired = element.IsRequired,
                Documentation = element.Short ?? ""
            };

            properties.Add(GenerateProperty(property, context));
        }

        return string.Join("\n\n", properties);
    }

    /// <summary>
    /// 生成建構函式
    /// </summary>
    private string GenerateConstructors(ResourceDefinition definition, TemplateContext context)
    {
        return $@"        /// <summary>
        /// 預設建構函式
        /// </summary>
        public {definition.Name}() : base()
        {{
        }}

        /// <summary>
        /// 建構函式，指定資源 ID
        /// </summary>
        /// <param name=""id"">資源的唯一識別碼</param>
        public {definition.Name}(string id) : base()
        {{
            Id = id;
        }}";
    }

    /// <summary>
    /// 生成驗證方法
    /// </summary>
    private string GenerateValidationMethod(ResourceDefinition definition, TemplateContext context)
    {
        return $@"        /// <summary>
        /// 驗證資源
        /// </summary>
        /// <returns>驗證結果</returns>
        public override ValidationResult Validate()
        {{
            var results = new List<ValidationResult>();
            
            // 基礎驗證
            results.AddRange(base.Validate());
            
            // TODO: 添加 {definition.Name} 特定的驗證規則
            
            return results.Any() 
                ? new ValidationResult($""驗證失敗: {{string.Join("", "", results.Select(r => r.ErrorMessage))}}"") 
                : ValidationResult.Success!;
        }}";
    }

    /// <summary>
    /// 生成工具方法
    /// </summary>
    private string GenerateUtilityMethods(ResourceDefinition definition, TemplateContext context)
    {
        return $@"        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {{
            return $""{definition.Name}(Id: {{Id}})"";
        }}";
    }

    /// <summary>
    /// 生成 BackboneElement 類別
    /// </summary>
    private string GenerateBackboneElements(ResourceDefinition definition, TemplateContext context)
    {
        // 簡化版本，只生成空的 BackboneElement 類別
        var backboneElements = definition.PropertyElements
            .Where(e => e.Types.Any(t => t.Code == "BackboneElement"))
            .Take(5) // 限制數量
            .Select(e => $@"    /// <summary>
    /// {definition.Name}{e.PropertyName} 背骨元素
    /// </summary>
    public class {definition.Name}{e.PropertyName}
    {{
        // TODO: 添加屬性實作
        
        public {definition.Name}{e.PropertyName}() {{ }}
    }}");

        return string.Join("\n", backboneElements);
    }

    /// <summary>
    /// 生成 ChoiceType 類別
    /// </summary>
    private string GenerateChoiceTypes(ResourceDefinition definition, TemplateContext context)
    {
        // 簡化版本，只生成空的 ChoiceType 類別
        var choiceTypes = definition.PropertyElements
            .Where(e => e.IsChoiceType)
            .Take(3) // 限制數量
            .Select(e => $@"    /// <summary>
    /// {definition.Name}{e.PropertyName}Choice 選擇類型
    /// </summary>
    public class {definition.Name}{e.PropertyName}Choice : ChoiceType
    {{
        // TODO: 添加選擇類型實作
        
        public {definition.Name}{e.PropertyName}Choice() {{ }}
    }}");

        return string.Join("\n", choiceTypes);
    }

    /// <summary>
    /// 生成屬性文檔
    /// </summary>
    private string GeneratePropertyDocumentation(PropertyDefinition property)
    {
        var required = property.IsRequired ? " (必填)" : "";
        return $@"        /// <summary>
        /// {property.Documentation}{required}
        /// </summary>";
    }

    /// <summary>
    /// 映射 FHIR 類型到 C# 類型
    /// </summary>
    private string MapFhirTypeToCSharp(string fhirType, bool isArray)
    {
        var mapping = _mappingConfig.GetCSharpType(fhirType);
        return isArray ? $"List<{mapping}>?" : $"{mapping}?";
    }

    #endregion
}

/// <summary>
/// 屬性定義（用於模板生成）
/// </summary>
public class PropertyDefinition
{
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public bool IsArray { get; set; }
    public bool IsRequired { get; set; }
    public string Documentation { get; set; } = string.Empty;
}