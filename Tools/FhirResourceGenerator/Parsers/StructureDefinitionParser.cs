using System.Text.Json;
using FhirResourceGenerator.Core;
using Microsoft.Extensions.Logging;

namespace FhirResourceGenerator.Parsers;

/// <summary>
/// StructureDefinition �ѪR��
/// </summary>
/// <remarks>
/// �t�d�ѪR FHIR StructureDefinition JSON �ɮ�
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
    /// �ѪR�귽�w�q��
    /// </summary>
    public async Task<IEnumerable<ResourceDefinition>> ParseResourceDefinitionsAsync(string definitionPath)
    {
        _logger.LogInformation("�}�l�ѪR�귽�w�q�ɡG{Path}", definitionPath);

        var definitions = new List<ResourceDefinition>();

        try
        {
            // �B�z��@�ɮשΥؿ�
            if (File.Exists(definitionPath))
            {
                var definition = await ParseSingleFileAsync(definitionPath);
                if (definition != null)
                    definitions.Add(definition);
            }
            else if (Directory.Exists(definitionPath))
            {
                // �d��Ҧ� JSON �ɮ�
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
                        _logger.LogWarning(ex, "�L�k�ѪR�ɮסG{File}", file);
                    }
                }
            }
            else
            {
                // ���է@�� Bundle �ɮ׸ѪR
                var bundleDefinitions = await ParseBundleFileAsync(definitionPath);
                definitions.AddRange(bundleDefinitions);
            }

            _logger.LogInformation("���\�ѪR {Count} �Ӹ귽�w�q", definitions.Count);
            return definitions;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "�ѪR�귽�w�q�ɮɵo�Ϳ��~");
            throw;
        }
    }

    /// <summary>
    /// �ѪR��������w�q��
    /// </summary>
    public async Task<IEnumerable<DataTypeDefinition>> ParseDataTypeDefinitionsAsync(string definitionPath)
    {
        _logger.LogInformation("�}�l�ѪR��������w�q�ɡG{Path}", definitionPath);

        // TODO: ��@��������ѪR
        await Task.CompletedTask;
        return new List<DataTypeDefinition>();
    }

    /// <summary>
    /// �������������
    /// </summary>
    public async Task<VersionMetadata> ExtractVersionMetadataAsync(string definitionPath)
    {
        _logger.LogInformation("������������ơG{Path}", definitionPath);

        // TODO: ��@��������ƴ���
        await Task.CompletedTask;
        return new VersionMetadata();
    }

    /// <summary>
    /// �ѪR��@�ɮ�
    /// </summary>
    private async Task<ResourceDefinition?> ParseSingleFileAsync(string filePath)
    {
        var jsonContent = await File.ReadAllTextAsync(filePath);
        
        using var document = JsonDocument.Parse(jsonContent);
        var root = document.RootElement;

        // �ˬd�O�_�� StructureDefinition
        if (!root.TryGetProperty("resourceType", out var resourceType) ||
            resourceType.GetString() != "StructureDefinition")
        {
            return null;
        }

        return await ParseStructureDefinitionAsync(root);
    }

    /// <summary>
    /// �ѪR Bundle �ɮ�
    /// </summary>
    private async Task<IEnumerable<ResourceDefinition>> ParseBundleFileAsync(string filePath)
    {
        var definitions = new List<ResourceDefinition>();

        var jsonContent = await File.ReadAllTextAsync(filePath);
        using var document = JsonDocument.Parse(jsonContent);
        var root = document.RootElement;

        // �ˬd�O�_�� Bundle
        if (!root.TryGetProperty("resourceType", out var resourceType) ||
            resourceType.GetString() != "Bundle")
        {
            throw new InvalidOperationException($"�ɮפ��O���Ī� Bundle: {filePath}");
        }

        // �ѪR Bundle ���� entry
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
    /// �ѪR StructureDefinition
    /// </summary>
    private async Task<ResourceDefinition?> ParseStructureDefinitionAsync(JsonElement structureDef)
    {
        try
        {
            // �򥻸�T
            var name = structureDef.GetProperty("name").GetString() ?? string.Empty;
            var kind = structureDef.GetProperty("kind").GetString() ?? string.Empty;
            
            // �u�B�z�귽����
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

            // �ѪR�����w�q
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

            // �ഫ���ݩʩw�q
            definition.Properties = await ConvertElementsToPropertiesAsync(definition.Elements, definition.Name);

            // �ѧO�I�������M�������
            definition.BackboneElements = IdentifyBackboneElements(definition.Elements, definition.Name);
            definition.ChoiceTypes = IdentifyChoiceTypes(definition.Elements, definition.Name);

            _logger.LogDebug("���\�ѪR�귽�w�q�G{Name} ({PropertyCount} ���ݩ�)", 
                name, definition.Properties.Count);

            return definition;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "�ѪR StructureDefinition �ɵo�Ϳ��~");
            return null;
        }
    }

    /// <summary>
    /// �������ɸ�T
    /// </summary>
    private DocumentationData ExtractDocumentation(JsonElement structureDef)
    {
        var docs = new DocumentationData();

        // �򥻸�T
        docs.Summary = GetStringProperty(structureDef, "title") ??
                      GetStringProperty(structureDef, "name") ?? 
                      string.Empty;

        docs.Description = GetStringProperty(structureDef, "description") ?? string.Empty;
        docs.Remarks = GetStringProperty(structureDef, "purpose") ?? string.Empty;

        // �����ϥλ���
        if (structureDef.TryGetProperty("useContext", out var useContext))
        {
            foreach (var context in useContext.EnumerateArray())
            {
                // TODO: �ѪR�ϥΤW�U��
            }
        }

        return docs;
    }

    /// <summary>
    /// �ഫ�������ݩ�
    /// </summary>
    private async Task<List<PropertyDefinition>> ConvertElementsToPropertiesAsync(
        List<ElementDefinition> elements, string resourceName)
    {
        var properties = new List<PropertyDefinition>();

        // �z��ڼh���ݩ� (�ư��ڤ�������)
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
    /// �ഫ��@�������ݩ�
    /// </summary>
    private async Task<PropertyDefinition?> ConvertElementToPropertyAsync(
        ElementDefinition element, string resourceName)
    {
        try
        {
            // �����ݩʦW�� (�����귽�W�٫e��)
            var propertyName = element.Path.Substring(resourceName.Length + 1);
            
            // �B�z������� (e.g., value[x])
            if (propertyName.Contains("[x]"))
            {
                propertyName = propertyName.Replace("[x]", "");
            }

            // �T�w�������
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

            // �B�z����
            foreach (var constraint in element.Constraint)
            {
                property.Constraints.Add($"{constraint.Key}: {constraint.Human}");
            }

            return property;
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "�ഫ�������ݩʮɵo�Ϳ��~�G{Path}", element.Path);
            return null;
        }
    }

    /// <summary>
    /// �ѧO�I������
    /// </summary>
    private List<BackboneElementDefinition> IdentifyBackboneElements(
        List<ElementDefinition> elements, string resourceName)
    {
        var backboneElements = new List<BackboneElementDefinition>();

        // �d��I������ (�]�t�l��������������)
        var candidates = elements.Where(e => 
            e.Type.Any(t => t.Code == "BackboneElement") ||
            (e.Path.Count(c => c == '.') > 1 && 
             elements.Any(child => child.Path.StartsWith(e.Path + ".")))).ToList();

        // TODO: ��@�I�������ѧO�޿�

        return backboneElements;
    }

    /// <summary>
    /// �ѧO�������
    /// </summary>
    private List<ChoiceTypeDefinition> IdentifyChoiceTypes(
        List<ElementDefinition> elements, string resourceName)
    {
        var choiceTypes = new List<ChoiceTypeDefinition>();

        // �d�������� (�h��������)
        var choiceElements = elements.Where(e => 
            e.Type.Count > 1 || e.Path.Contains("[x]")).ToList();

        // TODO: ��@��������ѧO�޿�

        return choiceTypes;
    }

    /// <summary>
    /// �T�w FHIR ����
    /// </summary>
    private string DetermineFhirType(ElementDefinition element)
    {
        if (element.Type.Count == 1)
            return element.Type[0].Code;

        if (element.Type.Count > 1)
            return "ChoiceType"; // �������

        // �ˬd���e�Ѧ�
        if (!string.IsNullOrEmpty(element.ContentReference))
            return "BackboneElement";

        return "Element"; // �w�]����
    }

    /// <summary>
    /// ���r���j�g
    /// </summary>
    private static string CapitalizeFirstLetter(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        return char.ToUpper(input[0]) + input.Substring(1);
    }

    /// <summary>
    /// ���o�r���ݩ�
    /// </summary>
    private static string? GetStringProperty(JsonElement element, string propertyName)
    {
        return element.TryGetProperty(propertyName, out var property) ? 
            property.GetString() : null;
    }

    /// <summary>
    /// ���o���L�ݩ�
    /// </summary>
    private static bool GetBooleanProperty(JsonElement element, string propertyName)
    {
        return element.TryGetProperty(propertyName, out var property) && 
            property.GetBoolean();
    }
}