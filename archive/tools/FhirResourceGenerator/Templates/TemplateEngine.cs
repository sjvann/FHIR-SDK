using Microsoft.Extensions.Logging;
using FhirResourceGenerator.Core;
using FhirResourceGenerator.Configuration;

namespace FhirResourceGenerator.Templates;

/// <summary>
/// �ҪO������@
/// 
/// <para>
/// �t�d�ھڼҪO�M��ƥͦ��{���X���q�C
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
    /// �ͦ��귽���O�{���X
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
        /// �귽����
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
    /// �ͦ��ݩʵ{���X
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
    /// �ͦ����ɵ���
    /// </summary>
    public string GenerateDocumentation(DocumentationData docs, TemplateContext context)
    {
        var summary = !string.IsNullOrEmpty(docs.Summary) ? docs.Summary : "FHIR �귽";
        var description = !string.IsNullOrEmpty(docs.Description) ? docs.Description : "�ԲӴy�z�ݸɥR";

        return $@"    /// <summary>
    /// {summary}
    /// 
    /// <para>
    /// {description}
    /// </para>
    /// </summary>";
    }

    /// <summary>
    /// �ͦ��u�t��k�{���X
    /// </summary>
    public string GenerateFactoryMethods(ResourceDefinition definition, TemplateContext context)
    {
        return $@"
using {context.GeneratorContext.ResourceNamespace};

namespace {context.GeneratorContext.FactoryNamespace}
{{
    /// <summary>
    /// {definition.Name} �u�t��k
    /// </summary>
    public static partial class {context.GeneratorContext.Version}Factory
    {{
        /// <summary>
        /// �إ� {definition.Name} �귽
        /// </summary>
        /// <returns>�s�� {definition.Name} ���</returns>
        public static {definition.Name} Create{definition.Name}()
        {{
            return new {definition.Name}();
        }}

        /// <summary>
        /// �إߨ㦳���w ID �� {definition.Name} �귽
        /// </summary>
        /// <param name=""id"">�귽 ID</param>
        /// <returns>�s�� {definition.Name} ���</returns>
        public static {definition.Name} Create{definition.Name}(string id)
        {{
            return new {definition.Name}(id);
        }}
    }}
}}";
    }

    /// <summary>
    /// �ͦ��M���ɮ�
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
    /// �ͦ� using �y�y
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
    /// �ͦ����O����
    /// </summary>
    private string GenerateClassDocumentation(ResourceDefinition definition, TemplateContext context)
    {
        var summary = !string.IsNullOrEmpty(definition.Documentation.Summary) 
            ? definition.Documentation.Summary 
            : $"FHIR {context.GeneratorContext.Version} {definition.Name} �귽";
        
        var description = !string.IsNullOrEmpty(definition.Documentation.Description)
            ? definition.Documentation.Description
            : $"{definition.Name} �귽���ԲӴy�z�N�b���B�K�[�C";

        return $@"    /// <summary>
    /// {summary}
    /// 
    /// <para>
    /// {description}
    /// �o�O FHIR {context.GeneratorContext.Version} �зǤ������n�귽�����C
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var {definition.Name.ToLower()} = new {definition.Name}(""{definition.Name.ToLower()}-001"");
    /// // �]�w�귽�ݩ�...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// {context.GeneratorContext.Version} ������ {definition.Name} �귽�㦳�H�U�S�I�G
    /// - �W�j����Ƶ��c
    /// - ��i�����ҳW�h  
    /// - ��n�����ާ@��
    /// </para>
    /// </remarks>";
    }

    /// <summary>
    /// �ͦ��p�����
    /// </summary>
    private string GeneratePrivateFields(ResourceDefinition definition, TemplateContext context)
    {
        var fields = new List<string>();
        
        // �u�B�z���ݩʡA�קK�L�����
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
    /// �ͦ����}�ݩ�
    /// </summary>
    private string GeneratePublicProperties(ResourceDefinition definition, TemplateContext context)
    {
        var properties = new List<string>();
        
        // �u�B�z���ݩ�
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
    /// �ͦ��غc�禡
    /// </summary>
    private string GenerateConstructors(ResourceDefinition definition, TemplateContext context)
    {
        return $@"        /// <summary>
        /// �w�]�غc�禡
        /// </summary>
        public {definition.Name}() : base()
        {{
        }}

        /// <summary>
        /// �غc�禡�A���w�귽 ID
        /// </summary>
        /// <param name=""id"">�귽���ߤ@�ѧO�X</param>
        public {definition.Name}(string id) : base()
        {{
            Id = id;
        }}";
    }

    /// <summary>
    /// �ͦ����Ҥ�k
    /// </summary>
    private string GenerateValidationMethod(ResourceDefinition definition, TemplateContext context)
    {
        return $@"        /// <summary>
        /// ���Ҹ귽
        /// </summary>
        /// <returns>���ҵ��G</returns>
        public override ValidationResult Validate()
        {{
            var results = new List<ValidationResult>();
            
            // ��¦����
            results.AddRange(base.Validate());
            
            // TODO: �K�[ {definition.Name} �S�w�����ҳW�h
            
            return results.Any() 
                ? new ValidationResult($""���ҥ���: {{string.Join("", "", results.Select(r => r.ErrorMessage))}}"") 
                : ValidationResult.Success!;
        }}";
    }

    /// <summary>
    /// �ͦ��u���k
    /// </summary>
    private string GenerateUtilityMethods(ResourceDefinition definition, TemplateContext context)
    {
        return $@"        /// <summary>
        /// �ഫ���r����
        /// </summary>
        public override string ToString()
        {{
            return $""{definition.Name}(Id: {{Id}})"";
        }}";
    }

    /// <summary>
    /// �ͦ� BackboneElement ���O
    /// </summary>
    private string GenerateBackboneElements(ResourceDefinition definition, TemplateContext context)
    {
        // ²�ƪ����A�u�ͦ��Ū� BackboneElement ���O
        var backboneElements = definition.PropertyElements
            .Where(e => e.Types.Any(t => t.Code == "BackboneElement"))
            .Take(5) // ����ƶq
            .Select(e => $@"    /// <summary>
    /// {definition.Name}{e.PropertyName} �I������
    /// </summary>
    public class {definition.Name}{e.PropertyName}
    {{
        // TODO: �K�[�ݩʹ�@
        
        public {definition.Name}{e.PropertyName}() {{ }}
    }}");

        return string.Join("\n", backboneElements);
    }

    /// <summary>
    /// �ͦ� ChoiceType ���O
    /// </summary>
    private string GenerateChoiceTypes(ResourceDefinition definition, TemplateContext context)
    {
        // ²�ƪ����A�u�ͦ��Ū� ChoiceType ���O
        var choiceTypes = definition.PropertyElements
            .Where(e => e.IsChoiceType)
            .Take(3) // ����ƶq
            .Select(e => $@"    /// <summary>
    /// {definition.Name}{e.PropertyName}Choice �������
    /// </summary>
    public class {definition.Name}{e.PropertyName}Choice : ChoiceType
    {{
        // TODO: �K�[���������@
        
        public {definition.Name}{e.PropertyName}Choice() {{ }}
    }}");

        return string.Join("\n", choiceTypes);
    }

    /// <summary>
    /// �ͦ��ݩʤ���
    /// </summary>
    private string GeneratePropertyDocumentation(PropertyDefinition property)
    {
        var required = property.IsRequired ? " (����)" : "";
        return $@"        /// <summary>
        /// {property.Documentation}{required}
        /// </summary>";
    }

    /// <summary>
    /// �M�g FHIR ������ C# ����
    /// </summary>
    private string MapFhirTypeToCSharp(string fhirType, bool isArray)
    {
        var mapping = _mappingConfig.GetCSharpType(fhirType);
        return isArray ? $"List<{mapping}>?" : $"{mapping}?";
    }

    #endregion
}

/// <summary>
/// �ݩʩw�q�]�Ω�ҪO�ͦ��^
/// </summary>
public class PropertyDefinition
{
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public bool IsArray { get; set; }
    public bool IsRequired { get; set; }
    public string Documentation { get; set; } = string.Empty;
}