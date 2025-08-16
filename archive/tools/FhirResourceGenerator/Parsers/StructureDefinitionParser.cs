using System.Text.Json;
using FhirResourceGenerator.Core;
using Microsoft.Extensions.Logging;

namespace FhirResourceGenerator.Parsers;

/// <summary>
/// StructureDefinition 解析器
/// </summary>
/// <remarks>
/// 負責解析 FHIR StructureDefinition JSON 檔案
/// </remarks>
public class StructureDefinitionParser : IDefinitionParser
{
    private readonly ILogger<StructureDefinitionParser> _logger;
    private readonly ElementDefinitionParser _elementParser;
    private readonly FhirTypeResolver _typeResolver;

    public StructureDefinitionParser(
        ILogger<StructureDefinitionParser> logger,
        ElementDefinitionParser elementParser,
        FhirTypeResolver typeResolver)
    {
        _logger = logger;
        _elementParser = elementParser;
        _typeResolver = typeResolver;
    }

    /// <summary>
    /// 解析資源定義檔
    /// </summary>
    public async Task<IEnumerable<ResourceDefinition>> ParseResourceDefinitionsAsync(string definitionPath)
    {
        _logger.LogInformation("開始解析資源定義檔：{Path}", definitionPath);

        var definitions = new List<ResourceDefinition>();

        try
        {
            // 處理單一檔案或目錄
            if (File.Exists(definitionPath))
            {
                var definition = await ParseSingleFileAsync(definitionPath);
                if (definition != null)
                    definitions.Add(definition);
            }
            else if (Directory.Exists(definitionPath))
            {
                // 查找所有 JSON 檔案
                var jsonFiles = Directory.GetFiles(definitionPath, "*.json", SearchOption.AllDirectories);
                
                foreach (var file in jsonFiles)
                {
                    try
                    {
                        var definition = await ParseSingleFileAsync(file);
                        if (definition != null)
                            definitions.Add(definition);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogWarning(ex, "無法解析檔案：{File}", file);
                    }
                }
            }
            else
            {
                // 嘗試作為 Bundle 檔案解析
                var bundleDefinitions = await ParseBundleFileAsync(definitionPath);
                definitions.AddRange(bundleDefinitions);
            }

            _logger.LogInformation("成功解析 {Count} 個資源定義", definitions.Count);
            return definitions;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "解析資源定義檔時發生錯誤");
            throw;
        }
    }

    /// <summary>
    /// 解析資料類型定義檔
    /// </summary>
    public async Task<IEnumerable<DataTypeDefinition>> ParseDataTypeDefinitionsAsync(string definitionPath)
    {
        _logger.LogInformation("開始解析資料類型定義檔：{Path}", definitionPath);

        // TODO: 實作資料類型解析
        await Task.CompletedTask;
        return new List<DataTypeDefinition>();
    }

    /// <summary>
    /// 提取版本元資料
    /// </summary>
    public async Task<VersionMetadata> ExtractVersionMetadataAsync(string definitionPath)
    {
        _logger.LogInformation("提取版本元資料：{Path}", definitionPath);

        // TODO: 實作版本元資料提取
        await Task.CompletedTask;
        return new VersionMetadata();
    }

    /// <summary>
    /// 解析單一檔案
    /// </summary>
    private async Task<ResourceDefinition?> ParseSingleFileAsync(string filePath)
    {
        var jsonContent = await File.ReadAllTextAsync(filePath);
        
        using var document = JsonDocument.Parse(jsonContent);
        var root = document.RootElement;

        // 檢查是否為 StructureDefinition
        if (!root.TryGetProperty("resourceType", out var resourceType) ||
            resourceType.GetString() != "StructureDefinition")
        {
            return null;
        }

        return await ParseStructureDefinitionAsync(root);
    }

    /// <summary>
    /// 解析 Bundle 檔案
    /// </summary>
    private async Task<IEnumerable<ResourceDefinition>> ParseBundleFileAsync(string filePath)
    {
        var definitions = new List<ResourceDefinition>();

        var jsonContent = await File.ReadAllTextAsync(filePath);
        using var document = JsonDocument.Parse(jsonContent);
        var root = document.RootElement;

        // 檢查是否為 Bundle
        if (!root.TryGetProperty("resourceType", out var resourceType) ||
            resourceType.GetString() != "Bundle")
        {
            throw new InvalidOperationException($"檔案不是有效的 Bundle: {filePath}");
        }

        // 解析 Bundle 中的 entry
        if (root.TryGetProperty("entry", out var entries))
        {
            foreach (var entry in entries.EnumerateArray())
            {
                if (entry.TryGetProperty("resource", out var resource))
                {
                    var definition = await ParseStructureDefinitionAsync(resource);
                    if (definition != null)
                        definitions.Add(definition);
                }
            }
        }

        return definitions;
    }

    /// <summary>
    /// 解析 StructureDefinition
    /// </summary>
    private async Task<ResourceDefinition?> ParseStructureDefinitionAsync(JsonElement structureDef)
    {
        try
        {
            // 基本資訊
            var name = structureDef.GetProperty("name").GetString() ?? string.Empty;
            var kind = structureDef.GetProperty("kind").GetString() ?? string.Empty;
            
            // 只處理資源類型
            if (kind != "resource")
                return null;

            var definition = new ResourceDefinition
            {
                Name = name,
                Kind = kind,
                Abstract = GetBooleanProperty(structureDef, "abstract"),
                BaseDefinition = GetStringProperty(structureDef, "baseDefinition"),
                Url = GetStringProperty(structureDef, "url"),
                Version = GetStringProperty(structureDef, "version"),
                Status = GetStringProperty(structureDef, "status"),
                Experimental = GetBooleanProperty(structureDef, "experimental"),
                Date = GetStringProperty(structureDef, "date"),
                Publisher = GetStringProperty(structureDef, "publisher"),
                Description = GetStringProperty(structureDef, "description"),
                Purpose = GetStringProperty(structureDef, "purpose"),
                Copyright = GetStringProperty(structureDef, "copyright"),
                Documentation = ExtractDocumentation(structureDef)
            };

            // 解析元素定義
            if (structureDef.TryGetProperty("snapshot", out var snapshot) &&
                snapshot.TryGetProperty("element", out var elements))
            {
                definition.Elements = await _elementParser.ParseElementsAsync(elements);
            }
            else if (structureDef.TryGetProperty("differential", out var differential) &&
                     differential.TryGetProperty("element", out var diffElements))
            {
                definition.Elements = await _elementParser.ParseElementsAsync(diffElements);
            }

            // 轉換為屬性定義
            definition.Properties = await ConvertElementsToPropertiesAsync(definition.Elements, definition.Name);

            // 識別背骨元素和選擇類型
            definition.BackboneElements = IdentifyBackboneElements(definition.Elements, definition.Name);
            definition.ChoiceTypes = IdentifyChoiceTypes(definition.Elements, definition.Name);

            _logger.LogDebug("成功解析資源定義：{Name} ({PropertyCount} 個屬性)", 
                name, definition.Properties.Count);

            return definition;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "解析 StructureDefinition 時發生錯誤");
            return null;
        }
    }

    /// <summary>
    /// 提取文檔資訊
    /// </summary>
    private DocumentationData ExtractDocumentation(JsonElement structureDef)
    {
        var docs = new DocumentationData();

        // 基本資訊
        docs.Summary = GetStringProperty(structureDef, "title") ??
                      GetStringProperty(structureDef, "name") ?? 
                      string.Empty;

        docs.Description = GetStringProperty(structureDef, "description") ?? string.Empty;
        docs.Remarks = GetStringProperty(structureDef, "purpose") ?? string.Empty;

        // 提取使用說明
        if (structureDef.TryGetProperty("useContext", out var useContext))
        {
            foreach (var context in useContext.EnumerateArray())
            {
                // TODO: 解析使用上下文
            }
        }

        return docs;
    }

    /// <summary>
    /// 轉換元素為屬性
    /// </summary>
    private async Task<List<PropertyDefinition>> ConvertElementsToPropertiesAsync(
        List<ElementDefinition> elements, string resourceName)
    {
        var properties = new List<PropertyDefinition>();

        // 篩選根層級屬性 (排除根元素本身)
        var rootElements = elements.Where(e => 
            e.Path.Count(c => c == '.') == 1 && 
            e.Path.StartsWith($"{resourceName}.") &&
            !e.Path.Contains("[")).ToList();

        foreach (var element in rootElements)
        {
            var property = await ConvertElementToPropertyAsync(element, resourceName);
            if (property != null)
                properties.Add(property);
        }

        return properties;
    }

    /// <summary>
    /// 轉換單一元素為屬性
    /// </summary>
    private async Task<PropertyDefinition?> ConvertElementToPropertyAsync(
        ElementDefinition element, string resourceName)
    {
        try
        {
            // 提取屬性名稱 (移除資源名稱前綴)
            var propertyName = element.Path.Substring(resourceName.Length + 1);
            
            // 處理選擇類型 (e.g., value[x])
            if (propertyName.Contains("[x]"))
            {
                propertyName = propertyName.Replace("[x]", "");
            }

            // 確定資料類型
            var fhirType = DetermineFhirType(element);
            var csharpType = await _typeResolver.ResolveCSharpTypeAsync(fhirType, element.Max != "1");

            var property = new PropertyDefinition
            {
                Name = CapitalizeFirstLetter(propertyName),
                CSharpType = csharpType,
                FhirType = fhirType,
                IsArray = element.Max != "1",
                IsNullable = element.Min == 0,
                MinOccurs = element.Min,
                MaxOccurs = element.Max,
                Summary = element.Short,
                Description = element.Definition,
                IsChoiceType = element.Type.Count > 1 || propertyName.EndsWith("[x]"),
                ChoiceTypeOptions = element.Type.Select(t => t.Code).ToList()
            };

            // 處理約束
            foreach (var constraint in element.Constraint)
            {
                property.Constraints.Add($"{constraint.Key}: {constraint.Human}");
            }

            return property;
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "轉換元素為屬性時發生錯誤：{Path}", element.Path);
            return null;
        }
    }

    /// <summary>
    /// 識別背骨元素
    /// </summary>
    private List<BackboneElementDefinition> IdentifyBackboneElements(
        List<ElementDefinition> elements, string resourceName)
    {
        var backboneElements = new List<BackboneElementDefinition>();

        // 查找背骨元素 (包含子元素的複雜元素)
        var candidates = elements.Where(e => 
            e.Type.Any(t => t.Code == "BackboneElement") ||
            (e.Path.Count(c => c == '.') > 1 && 
             elements.Any(child => child.Path.StartsWith(e.Path + ".")))).ToList();

        // TODO: 實作背骨元素識別邏輯

        return backboneElements;
    }

    /// <summary>
    /// 識別選擇類型
    /// </summary>
    private List<ChoiceTypeDefinition> IdentifyChoiceTypes(
        List<ElementDefinition> elements, string resourceName)
    {
        var choiceTypes = new List<ChoiceTypeDefinition>();

        // 查找選擇類型 (多類型元素)
        var choiceElements = elements.Where(e => 
            e.Type.Count > 1 || e.Path.Contains("[x]")).ToList();

        // TODO: 實作選擇類型識別邏輯

        return choiceTypes;
    }

    /// <summary>
    /// 確定 FHIR 類型
    /// </summary>
    private string DetermineFhirType(ElementDefinition element)
    {
        if (element.Type.Count == 1)
            return element.Type[0].Code;

        if (element.Type.Count > 1)
            return "ChoiceType"; // 選擇類型

        // 檢查內容參考
        if (!string.IsNullOrEmpty(element.ContentReference))
            return "BackboneElement";

        return "Element"; // 預設類型
    }

    /// <summary>
    /// 首字母大寫
    /// </summary>
    private static string CapitalizeFirstLetter(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        return char.ToUpper(input[0]) + input.Substring(1);
    }

    /// <summary>
    /// 取得字串屬性
    /// </summary>
    private static string? GetStringProperty(JsonElement element, string propertyName)
    {
        return element.TryGetProperty(propertyName, out var property) ? 
            property.GetString() : null;
    }

    /// <summary>
    /// 取得布林屬性
    /// </summary>
    private static bool GetBooleanProperty(JsonElement element, string propertyName)
    {
        return element.TryGetProperty(propertyName, out var property) && 
            property.GetBoolean();
    }
}