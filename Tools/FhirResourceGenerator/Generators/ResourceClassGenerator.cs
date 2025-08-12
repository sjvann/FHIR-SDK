using FhirResourceGenerator.Core;
using Microsoft.Extensions.Logging;

namespace FhirResourceGenerator.Generators;

/// <summary>
/// �귽���O�ͦ���
/// </summary>
/// <remarks>
/// �t�d�ͦ� FHIR �귽�� C# ���O�ɮ�
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
    /// �ͦ��M��
    /// </summary>
    public async Task<GenerationResult> GenerateProjectAsync(GeneratorContext context)
    {
        _logger.LogInformation("�}�l�ͦ� FHIR {Version} �M��", context.Version);

        try
        {
            // ���ҤW�U��
            if (!context.IsValid())
            {
                return GenerationResult.CreateFailure("�ͦ��W�U��L��");
            }

            var startTime = DateTime.UtcNow;

            // �ѪR�귽�w�q
            _logger.LogInformation("�ѪR�귽�w�q�ɡG{Path}", context.DefinitionsPath);
            var allDefinitions = await _definitionParser.ParseResourceDefinitionsAsync(context.DefinitionsPath);
            
            // �z��ؼи귽
            var targetDefinitions = FilterTargetResources(allDefinitions, context.TargetResources);
            
            _logger.LogInformation("��� {Count} �Ӹ귽�w�q�ݭn�ͦ�", targetDefinitions.Count());

            // �ͦ��M�׵��c
            await _projectGenerator.CreateProjectStructureAsync(context);

            // �ͦ��귽�ɮ�
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
                        _logger.LogWarning("�ͦ��귽���ѡG{ResourceName} - {Error}", 
                            definition.Name, resourceResult.ErrorMessage);
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "�ͦ��귽�ɵo�Ϳ��~�G{ResourceName}", definition.Name);
                }
            }

            // �ͦ��M���ɮ�
            await _projectGenerator.GenerateProjectFilesAsync(context, targetDefinitions);

            // �ͦ����ձM�ס]�p�G�ݭn�^
            if (context.IncludeTests)
            {
                await _projectGenerator.GenerateTestProjectAsync(context, targetDefinitions);
            }

            var endTime = DateTime.UtcNow;
            var duration = endTime - startTime;

            _logger.LogInformation("�M�ץͦ������I�귽�G{ResourceCount}�A�ɮסG{FileCount}�A�ӮɡG{Duration}", 
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
            _logger.LogError(ex, "�ͦ��M�׮ɵo�Ϳ��~");
            return GenerationResult.CreateFailure($"�ͦ��M�׮ɵo�Ϳ��~�G{ex.Message}");
        }
    }

    /// <summary>
    /// �ͦ���@�귽
    /// </summary>
    public async Task<GenerationResult> GenerateResourceAsync(ResourceDefinition definition, GeneratorContext context)
    {
        _logger.LogDebug("�ͦ��귽�G{ResourceName}", definition.Name);

        try
        {
            var generatedFiles = new List<string>();
            var templateContext = CreateTemplateContext(context);

            // �ͦ��D�n�귽���O
            var resourceCode = _templateEngine.GenerateResourceClass(definition, templateContext);
            var resourceFile = Path.Combine(context.OutputPath, "Resources", $"{definition.Name}.cs");
            
            await EnsureDirectoryExistsAsync(Path.GetDirectoryName(resourceFile)!);
            await File.WriteAllTextAsync(resourceFile, resourceCode);
            generatedFiles.Add(resourceFile);

            _logger.LogDebug("�w�ͦ��귽�ɮסG{File}", resourceFile);

            // �ͦ��I���������O
            foreach (var backboneElement in definition.BackboneElements)
            {
                var backboneCode = GenerateBackboneElement(backboneElement, templateContext);
                var backboneFile = Path.Combine(context.OutputPath, "Resources", 
                    $"{definition.Name}{backboneElement.Name}.cs");
                
                await File.WriteAllTextAsync(backboneFile, backboneCode);
                generatedFiles.Add(backboneFile);
            }

            // �ͦ�����������O
            foreach (var choiceType in definition.ChoiceTypes)
            {
                var choiceCode = GenerateChoiceType(choiceType, templateContext);
                var choiceFile = Path.Combine(context.OutputPath, "Resources", 
                    $"{choiceType.Name}.cs");
                
                await File.WriteAllTextAsync(choiceFile, choiceCode);
                generatedFiles.Add(choiceFile);
            }

            // �ͦ��u�t��k
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
            _logger.LogError(ex, "�ͦ��귽�ɵo�Ϳ��~�G{ResourceName}", definition.Name);
            return GenerationResult.CreateFailure($"�ͦ��귽 {definition.Name} �ɵo�Ϳ��~�G{ex.Message}");
        }
    }

    /// <summary>
    /// �z��ؼи귽
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
    /// �ЫؼҪO�W�U��
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
    /// �ͦ��I������
    /// </summary>
    private string GenerateBackboneElement(BackboneElementDefinition backboneElement, TemplateContext context)
    {
        // TODO: ��@�I�������ͦ��޿�
        return $@"using System;
using System.Collections.Generic;

namespace {context.Namespace}.Resources
{{
    /// <summary>
    /// {backboneElement.Name} �I������
    /// </summary>
    public class {backboneElement.Name}
    {{
        // TODO: �K�[�ݩʹ�@
        
        public {backboneElement.Name}() {{ }}
    }}
}}";
    }

    /// <summary>
    /// �ͦ��������
    /// </summary>
    private string GenerateChoiceType(ChoiceTypeDefinition choiceType, TemplateContext context)
    {
        // TODO: ��@��������ͦ��޿�
        var supportedTypesStr = string.Join(", ", choiceType.SupportedTypes.Select(t => $"\"{t}\""));
        
        return $@"using System;
using System.Collections.Generic;
using System.Text.Json;
using DataTypeServices.DataTypes.ChoiceTypes;

namespace {context.Namespace}.Resources
{{
    /// <summary>
    /// {choiceType.Name} �������
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
    /// �T�O�ؿ��s�b
    /// </summary>
    private async Task EnsureDirectoryExistsAsync(string directoryPath)
    {
        await Task.CompletedTask; // �קK�sĶ��ĵ�i
        
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }
    }
}