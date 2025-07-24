using System.Text.Json;
using System.Collections.Generic;

namespace Fhir.Generator.Services;

public class ResourceDefinitionParser
{
    private readonly string _jsonFilePath;
    private readonly long _maxMemorySize = 50 * 1024 * 1024; // 50MB

    public ResourceDefinitionParser(string jsonFilePath)
    {
        _jsonFilePath = jsonFilePath;
    }

    /// <summary>
    /// Streaming 解析 profiles-resources.json，取得所有 kind=resource 的 StructureDefinition 名稱清單
    /// </summary>
    public IEnumerable<string> GetAllResourceNames()
    {
        using var stream = File.OpenRead(_jsonFilePath);
        using var doc = JsonDocument.Parse(stream, new JsonDocumentOptions { AllowTrailingCommas = true });
        var root = doc.RootElement;
        if (root.TryGetProperty("entry", out var entries))
        {
            foreach (var entry in entries.EnumerateArray())
            {
                if (entry.TryGetProperty("resource", out var resource))
                {
                    if (resource.TryGetProperty("resourceType", out var resourceTypeElem) &&
                        resourceTypeElem.GetString() == "StructureDefinition")
                    {
                        if (resource.TryGetProperty("kind", out var kindElem) &&
                            kindElem.GetString() == "resource")
                        {
                            if (resource.TryGetProperty("name", out var nameElem))
                            {
                                var name = nameElem.GetString();
                                if (!string.IsNullOrWhiteSpace(name))
                                    yield return name;
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>
    /// Streaming 解析，根據 Resource 名稱取得對應 StructureDefinition 的 JSON 元素
    /// </summary>
    public JsonElement? GetResourceDefinitionByName(string resourceName)
    {
        using var stream = File.OpenRead(_jsonFilePath);
        using var doc = JsonDocument.Parse(stream, new JsonDocumentOptions { AllowTrailingCommas = true });
        var root = doc.RootElement;
        if (root.TryGetProperty("entry", out var entries))
        {
            foreach (var entry in entries.EnumerateArray())
            {
                if (entry.TryGetProperty("resource", out var resource))
                {
                    if (resource.TryGetProperty("resourceType", out var resourceTypeElem) &&
                        resourceTypeElem.GetString() == "StructureDefinition")
                    {
                        if (resource.TryGetProperty("kind", out var kindElem) &&
                            kindElem.GetString() == "resource")
                        {
                            if (resource.TryGetProperty("name", out var nameElem) &&
                                nameElem.GetString() == resourceName)
                            {
                                return resource;
                            }
                        }
                    }
                }
            }
        }
        return null;
    }
} 