using FhirResourceGenerator.Core;
using Microsoft.Extensions.Logging;

namespace FhirResourceGenerator.Generators;

/// <summary>
/// �I�������ͦ���
/// </summary>
/// <remarks>
/// �t�d�ͦ� FHIR �I�������� C# ���O
/// </remarks>
public class BackboneElementGenerator
{
    private readonly ILogger<BackboneElementGenerator> _logger;

    public BackboneElementGenerator(ILogger<BackboneElementGenerator> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// �ͦ��I������
    /// </summary>
    public async Task<string> GenerateBackboneElementAsync(BackboneElementDefinition definition, TemplateContext context)
    {
        await Task.CompletedTask; // �קK�sĶ��ĵ�i

        _logger.LogDebug("�ͦ��I�������G{Name}", definition.Name);

        // TODO: ��@���㪺�I�������ͦ��޿�
        return $@"using System;
using System.Collections.Generic;
using DataTypeServices.DataTypes.MetaTypes;

namespace {context.Namespace}.Resources
{{
    /// <summary>
    /// {definition.Name} �I������
    /// </summary>
    /// <remarks>
    /// <para>
    /// {definition.Documentation.Summary}
    /// </para>
    /// </remarks>
    public class {definition.Name} : BackboneElement
    {{
        // TODO: �K�[�ݩʹ�@
        
        public {definition.Name}() {{ }}
    }}
}}";
    }
}

/// <summary>
/// ��������ͦ���
/// </summary>
/// <remarks>
/// �t�d�ͦ� FHIR ��������� C# ���O
/// </remarks>
public class ChoiceTypeGenerator
{
    private readonly ILogger<ChoiceTypeGenerator> _logger;

    public ChoiceTypeGenerator(ILogger<ChoiceTypeGenerator> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// �ͦ��������
    /// </summary>
    public async Task<string> GenerateChoiceTypeAsync(ChoiceTypeDefinition definition, TemplateContext context)
    {
        await Task.CompletedTask; // �קK�sĶ��ĵ�i

        _logger.LogDebug("�ͦ���������G{Name}", definition.Name);

        var supportedTypesStr = string.Join(", ", definition.SupportedTypes.Select(t => $"\"{t}\""));

        // TODO: ��@���㪺��������ͦ��޿�
        return $@"using System;
using System.Collections.Generic;
using System.Text.Json;
using DataTypeServices.DataTypes.ChoiceTypes;

namespace {context.Namespace}.Resources
{{
    /// <summary>
    /// {definition.Name} �������
    /// </summary>
    /// <remarks>
    /// <para>
    /// {definition.Documentation.Summary}
    /// </para>
    /// </remarks>
    public class {definition.Name} : ChoiceType
    {{
        private static readonly List<string> _supportedTypes = new() {{ {supportedTypesStr} }};

        public {definition.Name}(JsonObject value) : base(""{definition.PrefixName.ToLower()}"", value, _supportedTypes) {{ }}
        public {definition.Name}(IComplexType? value) : base(""{definition.PrefixName.ToLower()}"", value) {{ }}
        public {definition.Name}(IPrimitiveType? value) : base(""{definition.PrefixName.ToLower()}"", value) {{ }}

        public override string GetPrefixName(bool withCapital = true) => withCapital ? ""{definition.PrefixName}"" : ""{definition.PrefixName.ToLower()}"";
        public override List<string> SetSupportDataType() => _supportedTypes;
    }}
}}";
    }
}

/// <summary>
/// �u�t��k�ͦ���
/// </summary>
/// <remarks>
/// �t�d�ͦ� FHIR �귽���u�t��k
/// </remarks>
public class FactoryMethodGenerator
{
    private readonly ILogger<FactoryMethodGenerator> _logger;

    public FactoryMethodGenerator(ILogger<FactoryMethodGenerator> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// �ͦ��u�t��k
    /// </summary>
    public async Task<string> GenerateFactoryMethodAsync(ResourceDefinition definition, TemplateContext context)
    {
        await Task.CompletedTask; // �קK�sĶ��ĵ�i

        _logger.LogDebug("�ͦ��u�t��k�G{ResourceName}", definition.Name);

        // TODO: ��@���㪺�u�t��k�ͦ��޿�
        return $@"using System;
using {context.Namespace}.Resources;

namespace {context.Namespace}.Factory
{{
    /// <summary>
    /// {definition.Name} �u�t��k
    /// </summary>
    public static partial class {context.FhirVersion}Factory
    {{
        /// <summary>
        /// �إ� {definition.Name} �귽
        /// </summary>
        /// <param name=""id"">�귽 ID</param>
        /// <returns>{definition.Name} �귽���</returns>
        public static {definition.Name} Create{definition.Name}(string? id = null)
        {{
            return new {definition.Name}(id ?? Guid.NewGuid().ToString());
        }}

        /// <summary>
        /// �إ߰򥻪� {definition.Name} �귽
        /// </summary>
        /// <returns>{definition.Name} �귽���</returns>
        public static {definition.Name} CreateBasic{definition.Name}()
        {{
            var resource = new {definition.Name}(Guid.NewGuid().ToString());
            
            // TODO: �]�w���ݩ�
            
            return resource;
        }}
    }}
}}";
    }
}