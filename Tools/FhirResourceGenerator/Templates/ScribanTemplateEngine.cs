using FhirResourceGenerator.Core;
using Scriban;
using Scriban.Runtime;

namespace FhirResourceGenerator.Templates;

/// <summary>
/// Scriban 模板引擎實作
/// </summary>
/// <remarks>
/// 使用 Scriban 模板引擎生成程式碼
/// </remarks>
public class ScribanTemplateEngine : ITemplateEngine
{
    private readonly Dictionary<string, Template> _compiledTemplates;

    public ScribanTemplateEngine()
    {
        _compiledTemplates = new Dictionary<string, Template>();
        InitializeTemplates();
    }

    /// <summary>
    /// 生成資源類別
    /// </summary>
    public string GenerateResourceClass(ResourceDefinition definition, TemplateContext context)
    {
        var template = GetTemplate("resource");
        var scriptObject = CreateScriptObject(context);
        
        scriptObject.SetValue("resource", definition, true);
        
        var templateContext = new Scriban.TemplateContext();
        templateContext.PushGlobal(scriptObject);
        
        return template.Render(templateContext);
    }

    /// <summary>
    /// 生成屬性
    /// </summary>
    public string GenerateProperty(PropertyDefinition property, TemplateContext context)
    {
        var template = GetTemplate("property");
        var scriptObject = CreateScriptObject(context);
        
        scriptObject.SetValue("property", property, true);
        
        var templateContext = new Scriban.TemplateContext();
        templateContext.PushGlobal(scriptObject);
        
        return template.Render(templateContext);
    }

    /// <summary>
    /// 生成文檔註解
    /// </summary>
    public string GenerateDocumentation(DocumentationData docs, TemplateContext context)
    {
        var template = GetTemplate("documentation");
        var scriptObject = CreateScriptObject(context);
        
        scriptObject.SetValue("docs", docs, true);
        
        var templateContext = new Scriban.TemplateContext();
        templateContext.PushGlobal(scriptObject);
        
        return template.Render(templateContext);
    }

    /// <summary>
    /// 生成工廠方法
    /// </summary>
    public string GenerateFactoryMethod(ResourceDefinition definition, TemplateContext context)
    {
        var template = GetTemplate("factory");
        var scriptObject = CreateScriptObject(context);
        
        scriptObject.SetValue("resource", definition, true);
        
        var templateContext = new Scriban.TemplateContext();
        templateContext.PushGlobal(scriptObject);
        
        return template.Render(templateContext);
    }

    /// <summary>
    /// 初始化模板
    /// </summary>
    private void InitializeTemplates()
    {
        // 資源類別模板
        var resourceTemplate = @"{{~ capture usings ~}}
{{~ for using in usings ~}}
using {{ using }};
{{~ end ~}}
{{~ end ~}}
{{ usings }}

namespace {{ namespace }}.Resources
{
    /// <summary>
    /// FHIR {{ fhir_version }} {{ resource.name }} 資源
    /// </summary>
    /// <remarks>
    /// <para>
    /// {{ resource.documentation.summary }}
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var {{ resource.name | string.downcase }} = new {{ resource.name }}(""{{ resource.name | string.downcase }}-001"");
    /// </code>
    /// </example>
    /// </remarks>
    public class {{ resource.name }} : ResourceBase<{{ fhir_version }}Version>
    {
        {{~ for property in resource.properties ~}}
        private {{ property.csharp_type }} _{{ property.name | string.downcase }};
        
        {{~ end ~}}

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => ""{{ resource.name }}"";

        {{~ for property in resource.properties ~}}
        /// <summary>
        /// {{ property.summary }}
        /// </summary>
        /// <remarks>
        /// <para>
        /// {{ property.description }}
        /// </para>
        /// </remarks>
        public {{ property.csharp_type }}{{ if property.is_nullable }}?{{ end }} {{ property.name }}
        {
            get => _{{ property.name | string.downcase }};
            set
            {
                _{{ property.name | string.downcase }} = value;
                OnPropertyChanged(nameof({{ property.name }}));
            }
        }
        
        {{~ end ~}}

        /// <summary>
        /// 建立新的 {{ resource.name }} 資源實例
        /// </summary>
        public {{ resource.name }}()
        {
        }

        /// <summary>
        /// 建立新的 {{ resource.name }} 資源實例
        /// </summary>
        /// <param name=""id"">資源的唯一識別碼</param>
        public {{ resource.name }}(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $""{{ resource.name }}(Id: {Id})"";
        }
    }
}";

        // 屬性模板
        var propertyTemplate = @"/// <summary>
/// {{ property.summary }}
/// </summary>
/// <remarks>
/// <para>
/// {{ property.description }}
/// </para>
/// </remarks>
public {{ property.csharp_type }}{{ if property.is_nullable }}?{{ end }} {{ property.name }}
{
    get => _{{ property.name | string.downcase }};
    set
    {
        _{{ property.name | string.downcase }} = value;
        OnPropertyChanged(nameof({{ property.name }}));
    }
}";

        // 文檔模板
        var documentationTemplate = @"/// <summary>
/// {{ docs.summary }}
/// </summary>
/// <remarks>
/// <para>
/// {{ docs.description }}
/// </para>
/// 
/// {{ if docs.example }}
/// <example>
/// <code>
/// {{ docs.example }}
/// </code>
/// </example>
/// {{ end }}
/// 
/// {{ if docs.remarks }}
/// <para>{{ docs.remarks }}</para>
/// {{ end }}
/// </remarks>";

        // 工廠方法模板
        var factoryTemplate = @"{{~ capture usings ~}}
using System;
using {{ namespace }}.Resources;
{{~ end ~}}
{{ usings }}

namespace {{ namespace }}.Factory
{
    /// <summary>
    /// {{ resource.name }} 工廠方法
    /// </summary>
    public static partial class {{ fhir_version }}Factory
    {
        /// <summary>
        /// 建立 {{ resource.name }} 資源
        /// </summary>
        /// <param name=""id"">資源 ID</param>
        /// <returns>{{ resource.name }} 資源實例</returns>
        public static {{ resource.name }} Create{{ resource.name }}(string? id = null)
        {
            return new {{ resource.name }}(id ?? Guid.NewGuid().ToString());
        }

        /// <summary>
        /// 建立基本的 {{ resource.name }} 資源
        /// </summary>
        /// <returns>{{ resource.name }} 資源實例</returns>
        public static {{ resource.name }} CreateBasic{{ resource.name }}()
        {
            var resource = new {{ resource.name }}(Guid.NewGuid().ToString());
            
            // TODO: 設定基本屬性
            
            return resource;
        }
    }
}";

        // 編譯模板
        _compiledTemplates["resource"] = Template.Parse(resourceTemplate);
        _compiledTemplates["property"] = Template.Parse(propertyTemplate);
        _compiledTemplates["documentation"] = Template.Parse(documentationTemplate);
        _compiledTemplates["factory"] = Template.Parse(factoryTemplate);
    }

    /// <summary>
    /// 取得模板
    /// </summary>
    private Template GetTemplate(string templateName)
    {
        if (_compiledTemplates.TryGetValue(templateName, out var template))
        {
            return template;
        }

        throw new ArgumentException($"找不到模板：{templateName}");
    }

    /// <summary>
    /// 創建腳本物件
    /// </summary>
    private ScriptObject CreateScriptObject(TemplateContext context)
    {
        var scriptObject = new ScriptObject();
        
        scriptObject.SetValue("fhir_version", context.FhirVersion, true);
        scriptObject.SetValue("namespace", context.Namespace, true);
        scriptObject.SetValue("usings", context.Usings, true);
        
        // 添加自定義函數
        scriptObject.SetValue("generate_validation_attributes", new Func<PropertyDefinition, string>(GenerateValidationAttributes), true);
        scriptObject.SetValue("format_property_name", new Func<string, string>(FormatPropertyName), true);
        scriptObject.SetValue("generate_example", new Func<ResourceDefinition, string>(GenerateUsageExample), true);
        
        return scriptObject;
    }

    /// <summary>
    /// 生成驗證屬性
    /// </summary>
    private string GenerateValidationAttributes(PropertyDefinition property)
    {
        var attributes = new List<string>();

        if (property.MinOccurs > 0)
        {
            attributes.Add("[Required]");
        }

        if (property.IsArray && property.MaxOccurs != "*")
        {
            if (int.TryParse(property.MaxOccurs, out var maxCount))
            {
                attributes.Add($"[MaxLength({maxCount})]");
            }
        }

        return string.Join("\n        ", attributes);
    }

    /// <summary>
    /// 格式化屬性名稱
    /// </summary>
    private string FormatPropertyName(string name)
    {
        // 確保首字母大寫
        if (string.IsNullOrEmpty(name))
            return name;

        return char.ToUpper(name[0]) + name.Substring(1);
    }

    /// <summary>
    /// 生成使用範例
    /// </summary>
    private string GenerateUsageExample(ResourceDefinition definition)
    {
        return $@"var {definition.Name.ToLower()} = new {definition.Name}(""{definition.Name.ToLower()}-001"");
{definition.Name.ToLower()}.Id = ""{definition.Name.ToLower()}-001"";
// 設定其他屬性...";
    }
}