using FhirResourceGenerator.Core;
using Microsoft.Extensions.Logging;

namespace FhirResourceGenerator.Generators;

/// <summary>
/// 背骨元素生成器
/// </summary>
/// <remarks>
/// 負責生成 FHIR 背骨元素的 C# 類別
/// </remarks>
public class BackboneElementGenerator
{
    private readonly ILogger<BackboneElementGenerator> _logger;

    public BackboneElementGenerator(ILogger<BackboneElementGenerator> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// 生成背骨元素
    /// </summary>
    public async Task<string> GenerateBackboneElementAsync(BackboneElementDefinition definition, TemplateContext context)
    {
        await Task.CompletedTask; // 避免編譯器警告

        _logger.LogDebug("生成背骨元素：{Name}", definition.Name);

        // TODO: 實作完整的背骨元素生成邏輯
        return $@"using System;
using System.Collections.Generic;
using DataTypeServices.DataTypes.MetaTypes;

namespace {context.Namespace}.Resources
{{
    /// <summary>
    /// {definition.Name} 背骨元素
    /// </summary>
    /// <remarks>
    /// <para>
    /// {definition.Documentation.Summary}
    /// </para>
    /// </remarks>
    public class {definition.Name} : BackboneElement
    {{
        // TODO: 添加屬性實作
        
        public {definition.Name}() {{ }}
    }}
}}";
    }
}

/// <summary>
/// 選擇類型生成器
/// </summary>
/// <remarks>
/// 負責生成 FHIR 選擇類型的 C# 類別
/// </remarks>
public class ChoiceTypeGenerator
{
    private readonly ILogger<ChoiceTypeGenerator> _logger;

    public ChoiceTypeGenerator(ILogger<ChoiceTypeGenerator> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// 生成選擇類型
    /// </summary>
    public async Task<string> GenerateChoiceTypeAsync(ChoiceTypeDefinition definition, TemplateContext context)
    {
        await Task.CompletedTask; // 避免編譯器警告

        _logger.LogDebug("生成選擇類型：{Name}", definition.Name);

        var supportedTypesStr = string.Join(", ", definition.SupportedTypes.Select(t => $"\"{t}\""));

        // TODO: 實作完整的選擇類型生成邏輯
        return $@"using System;
using System.Collections.Generic;
using System.Text.Json;
using DataTypeServices.DataTypes.ChoiceTypes;

namespace {context.Namespace}.Resources
{{
    /// <summary>
    /// {definition.Name} 選擇類型
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
/// 工廠方法生成器
/// </summary>
/// <remarks>
/// 負責生成 FHIR 資源的工廠方法
/// </remarks>
public class FactoryMethodGenerator
{
    private readonly ILogger<FactoryMethodGenerator> _logger;

    public FactoryMethodGenerator(ILogger<FactoryMethodGenerator> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// 生成工廠方法
    /// </summary>
    public async Task<string> GenerateFactoryMethodAsync(ResourceDefinition definition, TemplateContext context)
    {
        await Task.CompletedTask; // 避免編譯器警告

        _logger.LogDebug("生成工廠方法：{ResourceName}", definition.Name);

        // TODO: 實作完整的工廠方法生成邏輯
        return $@"using System;
using {context.Namespace}.Resources;

namespace {context.Namespace}.Factory
{{
    /// <summary>
    /// {definition.Name} 工廠方法
    /// </summary>
    public static partial class {context.FhirVersion}Factory
    {{
        /// <summary>
        /// 建立 {definition.Name} 資源
        /// </summary>
        /// <param name=""id"">資源 ID</param>
        /// <returns>{definition.Name} 資源實例</returns>
        public static {definition.Name} Create{definition.Name}(string? id = null)
        {{
            return new {definition.Name}(id ?? Guid.NewGuid().ToString());
        }}

        /// <summary>
        /// 建立基本的 {definition.Name} 資源
        /// </summary>
        /// <returns>{definition.Name} 資源實例</returns>
        public static {definition.Name} CreateBasic{definition.Name}()
        {{
            var resource = new {definition.Name}(Guid.NewGuid().ToString());
            
            // TODO: 設定基本屬性
            
            return resource;
        }}
    }}
}}";
    }
}