using FhirResourceGenerator.Core;
using Scriban;
using Scriban.Runtime;

namespace FhirResourceGenerator.Templates;

/// <summary>
/// Scriban �ҪO������@
/// </summary>
/// <remarks>
/// �ϥ� Scriban �ҪO�����ͦ��{���X
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
    /// �ͦ��귽���O
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
    /// �ͦ��ݩ�
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
    /// �ͦ����ɵ���
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
    /// �ͦ��u�t��k
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
    /// ��l�ƼҪO
    /// </summary>
    private void InitializeTemplates()
    {
        // �귽���O�ҪO
        var resourceTemplate = @"{{~ capture usings ~}}
{{~ for using in usings ~}}
using {{ using }};
{{~ end ~}}
{{~ end ~}}
{{ usings }}

namespace {{ namespace }}.Resources
{
    /// <summary>
    /// FHIR {{ fhir_version }} {{ resource.name }} �귽
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
        /// �귽����
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
        /// �إ߷s�� {{ resource.name }} �귽���
        /// </summary>
        public {{ resource.name }}()
        {
        }

        /// <summary>
        /// �إ߷s�� {{ resource.name }} �귽���
        /// </summary>
        /// <param name=""id"">�귽���ߤ@�ѧO�X</param>
        public {{ resource.name }}(string id)
        {
            Id = id;
        }

        /// <summary>
        /// �ഫ���r����
        /// </summary>
        public override string ToString()
        {
            return $""{{ resource.name }}(Id: {Id})"";
        }
    }
}";

        // �ݩʼҪO
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

        // ���ɼҪO
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

        // �u�t��k�ҪO
        var factoryTemplate = @"{{~ capture usings ~}}
using System;
using {{ namespace }}.Resources;
{{~ end ~}}
{{ usings }}

namespace {{ namespace }}.Factory
{
    /// <summary>
    /// {{ resource.name }} �u�t��k
    /// </summary>
    public static partial class {{ fhir_version }}Factory
    {
        /// <summary>
        /// �إ� {{ resource.name }} �귽
        /// </summary>
        /// <param name=""id"">�귽 ID</param>
        /// <returns>{{ resource.name }} �귽���</returns>
        public static {{ resource.name }} Create{{ resource.name }}(string? id = null)
        {
            return new {{ resource.name }}(id ?? Guid.NewGuid().ToString());
        }

        /// <summary>
        /// �إ߰򥻪� {{ resource.name }} �귽
        /// </summary>
        /// <returns>{{ resource.name }} �귽���</returns>
        public static {{ resource.name }} CreateBasic{{ resource.name }}()
        {
            var resource = new {{ resource.name }}(Guid.NewGuid().ToString());
            
            // TODO: �]�w���ݩ�
            
            return resource;
        }
    }
}";

        // �sĶ�ҪO
        _compiledTemplates["resource"] = Template.Parse(resourceTemplate);
        _compiledTemplates["property"] = Template.Parse(propertyTemplate);
        _compiledTemplates["documentation"] = Template.Parse(documentationTemplate);
        _compiledTemplates["factory"] = Template.Parse(factoryTemplate);
    }

    /// <summary>
    /// ���o�ҪO
    /// </summary>
    private Template GetTemplate(string templateName)
    {
        if (_compiledTemplates.TryGetValue(templateName, out var template))
        {
            return template;
        }

        throw new ArgumentException($"�䤣��ҪO�G{templateName}");
    }

    /// <summary>
    /// �Ыظ}������
    /// </summary>
    private ScriptObject CreateScriptObject(TemplateContext context)
    {
        var scriptObject = new ScriptObject();
        
        scriptObject.SetValue("fhir_version", context.FhirVersion, true);
        scriptObject.SetValue("namespace", context.Namespace, true);
        scriptObject.SetValue("usings", context.Usings, true);
        
        // �K�[�۩w�q���
        scriptObject.SetValue("generate_validation_attributes", new Func<PropertyDefinition, string>(GenerateValidationAttributes), true);
        scriptObject.SetValue("format_property_name", new Func<string, string>(FormatPropertyName), true);
        scriptObject.SetValue("generate_example", new Func<ResourceDefinition, string>(GenerateUsageExample), true);
        
        return scriptObject;
    }

    /// <summary>
    /// �ͦ������ݩ�
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
    /// �榡���ݩʦW��
    /// </summary>
    private string FormatPropertyName(string name)
    {
        // �T�O���r���j�g
        if (string.IsNullOrEmpty(name))
            return name;

        return char.ToUpper(name[0]) + name.Substring(1);
    }

    /// <summary>
    /// �ͦ��ϥνd��
    /// </summary>
    private string GenerateUsageExample(ResourceDefinition definition)
    {
        return $@"var {definition.Name.ToLower()} = new {definition.Name}(""{definition.Name.ToLower()}-001"");
{definition.Name.ToLower()}.Id = ""{definition.Name.ToLower()}-001"";
// �]�w��L�ݩ�...";
    }
}