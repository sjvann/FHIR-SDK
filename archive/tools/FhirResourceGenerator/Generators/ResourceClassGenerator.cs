using FhirResourceGenerator.Core;
using Microsoft.Extensions.Logging;

namespace FhirResourceGenerator.Generators;

/// <summary>
/// 資源類別生成器
/// </summary>
/// <remarks>
/// 負責生成 FHIR 資源的 C# 類別檔案
/// </remarks>
public class ResourceClassGenerator : IResourceGenerator
{
    private readonly ILogger<ResourceClassGenerator> _logger;
    private readonly IDefinitionParser _definitionParser;
    private readonly ITemplateEngine _templateEngine;
    private readonly ProjectGenerator _projectGenerator;

    public ResourceClassGenerator(
        ILogger<ResourceClassGenerator> logger,
        IDefinitionParser definitionParser,
        ITemplateEngine templateEngine,
        ProjectGenerator projectGenerator)
    {
        _logger = logger;
        _definitionParser = definitionParser;
        _templateEngine = templateEngine;
        _projectGenerator = projectGenerator;
    }

    /// <summary>
    /// 生成專案
    /// </summary>
    public async Task<GenerationResult> GenerateProjectAsync(GeneratorContext context)
    {
        _logger.LogInformation("開始生成 FHIR {Version} 專案", context.Version);

        try
        {
            // 驗證上下文
            if (!context.IsValid())
            {
                return GenerationResult.CreateFailure("生成上下文無效");
            }

            var startTime = DateTime.UtcNow;

            // 解析資源定義
            _logger.LogInformation("解析資源定義檔：{Path}", context.DefinitionsPath);
            var allDefinitions = await _definitionParser.ParseResourceDefinitionsAsync(context.DefinitionsPath);
            
            // 篩選目標資源
            var targetDefinitions = FilterTargetResources(allDefinitions, context.TargetResources);
            
            _logger.LogInformation("找到 {Count} 個資源定義需要生成", targetDefinitions.Count());

            // 生成專案結構
            await _projectGenerator.CreateProjectStructureAsync(context);

            // 生成資源檔案
            var generatedFiles = new List<string>();
            var resourceCount = 0;

            foreach (var definition in targetDefinitions)
            {
                try
                {
                    var resourceResult = await GenerateResourceAsync(definition, context);
                    if (resourceResult.Success)
                    {
                        generatedFiles.AddRange(resourceResult.GeneratedFiles);
                        resourceCount++;
                    }
                    else
                    {
                        _logger.LogWarning("生成資源失敗：{ResourceName} - {Error}", 
                            definition.Name, resourceResult.ErrorMessage);
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "生成資源時發生錯誤：{ResourceName}", definition.Name);
                }
            }

            // 生成專案檔案
            await _projectGenerator.GenerateProjectFilesAsync(context, targetDefinitions);

            // 生成測試專案（如果需要）
            if (context.IncludeTests)
            {
                await _projectGenerator.GenerateTestProjectAsync(context, targetDefinitions);
            }

            var endTime = DateTime.UtcNow;
            var duration = endTime - startTime;

            _logger.LogInformation("專案生成完成！資源：{ResourceCount}，檔案：{FileCount}，耗時：{Duration}", 
                resourceCount, generatedFiles.Count, duration);

            return new GenerationResult
            {
                Success = true,
                ResourcesGenerated = resourceCount,
                FilesGenerated = generatedFiles.Count,
                GeneratedFiles = generatedFiles,
                StartTime = startTime,
                EndTime = endTime
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "生成專案時發生錯誤");
            return GenerationResult.CreateFailure($"生成專案時發生錯誤：{ex.Message}");
        }
    }

    /// <summary>
    /// 生成單一資源
    /// </summary>
    public async Task<GenerationResult> GenerateResourceAsync(ResourceDefinition definition, GeneratorContext context)
    {
        _logger.LogDebug("生成資源：{ResourceName}", definition.Name);

        try
        {
            var generatedFiles = new List<string>();
            var templateContext = CreateTemplateContext(context);

            // 生成主要資源類別
            var resourceCode = _templateEngine.GenerateResourceClass(definition, templateContext);
            var resourceFile = Path.Combine(context.OutputPath, "Resources", $"{definition.Name}.cs");
            
            await EnsureDirectoryExistsAsync(Path.GetDirectoryName(resourceFile)!);
            await File.WriteAllTextAsync(resourceFile, resourceCode);
            generatedFiles.Add(resourceFile);

            _logger.LogDebug("已生成資源檔案：{File}", resourceFile);

            // 生成背骨元素類別
            foreach (var backboneElement in definition.BackboneElements)
            {
                var backboneCode = GenerateBackboneElement(backboneElement, templateContext);
                var backboneFile = Path.Combine(context.OutputPath, "Resources", 
                    $"{definition.Name}{backboneElement.Name}.cs");
                
                await File.WriteAllTextAsync(backboneFile, backboneCode);
                generatedFiles.Add(backboneFile);
            }

            // 生成選擇類型類別
            foreach (var choiceType in definition.ChoiceTypes)
            {
                var choiceCode = GenerateChoiceType(choiceType, templateContext);
                var choiceFile = Path.Combine(context.OutputPath, "Resources", 
                    $"{choiceType.Name}.cs");
                
                await File.WriteAllTextAsync(choiceFile, choiceCode);
                generatedFiles.Add(choiceFile);
            }

            // 生成工廠方法
            var factoryCode = _templateEngine.GenerateFactoryMethod(definition, templateContext);
            var factoryFile = Path.Combine(context.OutputPath, "Factory", $"{definition.Name}Factory.cs");
            
            await EnsureDirectoryExistsAsync(Path.GetDirectoryName(factoryFile)!);
            await File.WriteAllTextAsync(factoryFile, factoryCode);
            generatedFiles.Add(factoryFile);

            return new GenerationResult
            {
                Success = true,
                ResourcesGenerated = 1,
                FilesGenerated = generatedFiles.Count,
                GeneratedFiles = generatedFiles
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "生成資源時發生錯誤：{ResourceName}", definition.Name);
            return GenerationResult.CreateFailure($"生成資源 {definition.Name} 時發生錯誤：{ex.Message}");
        }
    }

    /// <summary>
    /// 篩選目標資源
    /// </summary>
    private IEnumerable<ResourceDefinition> FilterTargetResources(
        IEnumerable<ResourceDefinition> allDefinitions, List<string>? targetResources)
    {
        if (targetResources == null || !targetResources.Any())
        {
            return allDefinitions;
        }

        return allDefinitions.Where(d => targetResources.Contains(d.Name, StringComparer.OrdinalIgnoreCase));
    }

    /// <summary>
    /// 創建模板上下文
    /// </summary>
    private TemplateContext CreateTemplateContext(GeneratorContext context)
    {
        return new TemplateContext
        {
            FhirVersion = context.Version,
            Namespace = $"FhirCore.{context.Version}",
            Usings = new List<string>
            {
                "System",
                "System.Collections.Generic",
                "System.ComponentModel.DataAnnotations",
                "System.Text.Json",
                "FhirCore.Base",
                $"FhirCore.{context.Version}",
                "DataTypeServices.DataTypes.ComplexTypes",
                "DataTypeServices.DataTypes.PrimitiveTypes",
                "DataTypeServices.DataTypes.SpecialTypes"
            }
        };
    }

    /// <summary>
    /// 生成背骨元素
    /// </summary>
    private string GenerateBackboneElement(BackboneElementDefinition backboneElement, TemplateContext context)
    {
        // TODO: 實作背骨元素生成邏輯
        return $@"using System;
using System.Collections.Generic;

namespace {context.Namespace}.Resources
{{
    /// <summary>
    /// {backboneElement.Name} 背骨元素
    /// </summary>
    public class {backboneElement.Name}
    {{
        // TODO: 添加屬性實作
        
        public {backboneElement.Name}() {{ }}
    }}
}}";
    }

    /// <summary>
    /// 生成選擇類型
    /// </summary>
    private string GenerateChoiceType(ChoiceTypeDefinition choiceType, TemplateContext context)
    {
        // TODO: 實作選擇類型生成邏輯
        var supportedTypesStr = string.Join(", ", choiceType.SupportedTypes.Select(t => $"\"{t}\""));
        
        return $@"using System;
using System.Collections.Generic;
using System.Text.Json;
using DataTypeServices.DataTypes.ChoiceTypes;

namespace {context.Namespace}.Resources
{{
    /// <summary>
    /// {choiceType.Name} 選擇類型
    /// </summary>
    public class {choiceType.Name} : ChoiceType
    {{

        public {choiceType.Name}(JsonObject value) : base(""{choiceType.PrefixName.ToLower()}"", value, _supportedTypes) {{ }}
        public {choiceType.Name}(IComplexType? value) : base(""{choiceType.PrefixName.ToLower()}"", value) {{ }}
        public {choiceType.Name}(IPrimitiveType? value) : base(""{choiceType.PrefixName.ToLower()}"", value) {{ }}

        public override string GetPrefixName(bool withCapital = true) => withCapital ? ""{choiceType.PrefixName}"" : ""{choiceType.PrefixName.ToLower()}"";
        public override List<string> SetSupportDataType() => _supportedTypes;
    }}
}}";
    }

    /// <summary>
    /// 確保目錄存在
    /// </summary>
    private async Task EnsureDirectoryExistsAsync(string directoryPath)
    {
        await Task.CompletedTask; // 避免編譯器警告
        
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }
    }
}