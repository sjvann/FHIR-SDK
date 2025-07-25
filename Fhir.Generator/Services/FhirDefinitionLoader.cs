using System.IO.Compression;
using System.Text.Json;
using Fhir.Generator.Models;

namespace Fhir.Generator.Services;

/// <summary>
/// FHIR 定義檔載入器
/// 從 definitions.json.zip 載入 FHIR 結構定義
/// </summary>
public class FhirDefinitionLoader
{
    /// <summary>
    /// 從 ZIP 檔案載入 FHIR Schema
    /// </summary>
    /// <param name="zipPath">ZIP 檔案路徑</param>
    /// <returns>FHIR Schema</returns>
    public async Task<FhirSchema> LoadFromZipAsync(string zipPath)
    {
        Console.WriteLine($"📦 Loading FHIR definitions from: {zipPath}");
        
        var schema = new FhirSchema();
        
        using var fileStream = new FileStream(zipPath, FileMode.Open, FileAccess.Read);
        using var archive = new ZipArchive(fileStream, ZipArchiveMode.Read);
        
        // 尋找 profiles-resources.json 或類似的檔案
        var resourcesEntry = archive.Entries.FirstOrDefault(e => 
            e.Name.Contains("profiles-resources") || 
            e.Name.Contains("resources") ||
            e.Name.EndsWith("resources.json"));
            
        var typesEntry = archive.Entries.FirstOrDefault(e => 
            e.Name.Contains("profiles-types") || 
            e.Name.Contains("types") ||
            e.Name.EndsWith("types.json"));
            
        var valueSetsEntry = archive.Entries.FirstOrDefault(e => 
            e.Name.Contains("valuesets") ||
            e.Name.EndsWith("valuesets.json"));

        // 載入 Resources
        if (resourcesEntry != null)
        {
            Console.WriteLine($"  📄 Loading resources from: {resourcesEntry.Name}");
            using var stream = resourcesEntry.Open();
            using var reader = new StreamReader(stream);
            var content = await reader.ReadToEndAsync();
            
            await LoadResourcesFromJsonAsync(content, schema);
        }
        
        // 載入 DataTypes
        if (typesEntry != null)
        {
            Console.WriteLine($"  🔧 Loading data types from: {typesEntry.Name}");
            using var stream = typesEntry.Open();
            using var reader = new StreamReader(stream);
            var content = await reader.ReadToEndAsync();
            
            await LoadDataTypesFromJsonAsync(content, schema);
        }
        
        // 載入 ValueSets
        if (valueSetsEntry != null)
        {
            Console.WriteLine($"  📋 Loading value sets from: {valueSetsEntry.Name}");
            using var stream = valueSetsEntry.Open();
            using var reader = new StreamReader(stream);
            var content = await reader.ReadToEndAsync();
            
            await LoadValueSetsFromJsonAsync(content, schema);
        }
        
        Console.WriteLine($"✅ Loaded schema:");
        Console.WriteLine($"   📄 Resources: {schema.Resources.Count}");
        Console.WriteLine($"   🔧 DataTypes: {schema.DataTypes.Count}");
        Console.WriteLine($"   📋 ValueSets: {schema.ValueSets.Count}");
        
        return schema;
    }
    
    /// <summary>
    /// 從 JSON 內容載入 Resources
    /// </summary>
    private async Task LoadResourcesFromJsonAsync(string jsonContent, FhirSchema schema)
    {
        try
        {
            using var document = JsonDocument.Parse(jsonContent);
            var root = document.RootElement;
            
            if (root.TryGetProperty("entry", out var entries))
            {
                foreach (var entry in entries.EnumerateArray())
                {
                    if (entry.TryGetProperty("resource", out var resource))
                    {
                        var resourceDef = ParseResourceDefinition(resource);
                        if (resourceDef != null)
                        {
                            schema.Resources[resourceDef.Name] = resourceDef;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"⚠️  Warning: Failed to parse resources JSON: {ex.Message}");
        }
        
        await Task.CompletedTask;
    }
    
    /// <summary>
    /// 從 JSON 內容載入 DataTypes
    /// </summary>
    private async Task LoadDataTypesFromJsonAsync(string jsonContent, FhirSchema schema)
    {
        try
        {
            using var document = JsonDocument.Parse(jsonContent);
            var root = document.RootElement;
            
            if (root.TryGetProperty("entry", out var entries))
            {
                foreach (var entry in entries.EnumerateArray())
                {
                    if (entry.TryGetProperty("resource", out var resource))
                    {
                        var typeDef = ParseTypeDefinition(resource);
                        if (typeDef != null)
                        {
                            schema.DataTypes[typeDef.Name] = typeDef;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"⚠️  Warning: Failed to parse data types JSON: {ex.Message}");
        }
        
        await Task.CompletedTask;
    }
    
    /// <summary>
    /// 從 JSON 內容載入 ValueSets
    /// </summary>
    private async Task LoadValueSetsFromJsonAsync(string jsonContent, FhirSchema schema)
    {
        try
        {
            using var document = JsonDocument.Parse(jsonContent);
            var root = document.RootElement;
            
            if (root.TryGetProperty("entry", out var entries))
            {
                foreach (var entry in entries.EnumerateArray())
                {
                    if (entry.TryGetProperty("resource", out var resource))
                    {
                        var valueSetDef = ParseValueSetDefinition(resource);
                        if (valueSetDef != null)
                        {
                            schema.ValueSets[valueSetDef.Name] = valueSetDef;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"⚠️  Warning: Failed to parse value sets JSON: {ex.Message}");
        }
        
        await Task.CompletedTask;
    }
    
    /// <summary>
    /// 解析 Resource 定義
    /// </summary>
    private ResourceDefinition? ParseResourceDefinition(JsonElement resource)
    {
        if (!resource.TryGetProperty("resourceType", out var resourceType) || 
            resourceType.GetString() != "StructureDefinition")
        {
            return null;
        }
        
        if (!resource.TryGetProperty("kind", out var kind) || 
            kind.GetString() != "resource")
        {
            return null;
        }
        
        if (!resource.TryGetProperty("name", out var nameElement))
        {
            return null;
        }
        
        var name = nameElement.GetString();
        if (string.IsNullOrEmpty(name))
        {
            return null;
        }
        
        var resourceDef = new ResourceDefinition
        {
            Name = name,
            Description = resource.TryGetProperty("description", out var desc) ? desc.GetString() ?? "" : "",
            Properties = new List<PropertyDefinition>()
        };
        
        // 解析屬性
        if (resource.TryGetProperty("snapshot", out var snapshot) &&
            snapshot.TryGetProperty("element", out var elements))
        {
            foreach (var element in elements.EnumerateArray())
            {
                var property = ParsePropertyDefinition(element);
                if (property != null)
                {
                    resourceDef.Properties.Add(property);
                }
            }
        }
        
        return resourceDef;
    }
    
    /// <summary>
    /// 解析 Type 定義
    /// </summary>
    private TypeDefinition? ParseTypeDefinition(JsonElement resource)
    {
        if (!resource.TryGetProperty("resourceType", out var resourceType) || 
            resourceType.GetString() != "StructureDefinition")
        {
            return null;
        }
        
        if (!resource.TryGetProperty("kind", out var kind) || 
            (kind.GetString() != "complex-type" && kind.GetString() != "primitive-type"))
        {
            return null;
        }
        
        if (!resource.TryGetProperty("name", out var nameElement))
        {
            return null;
        }
        
        var name = nameElement.GetString();
        if (string.IsNullOrEmpty(name))
        {
            return null;
        }
        
        var typeDef = new TypeDefinition
        {
            Name = name,
            Description = resource.TryGetProperty("description", out var desc) ? desc.GetString() ?? "" : "",
            Properties = new List<PropertyDefinition>(),
            ValidationRules = new List<ValidationRule>()
        };
        
        // 解析屬性
        if (resource.TryGetProperty("snapshot", out var snapshot) &&
            snapshot.TryGetProperty("element", out var elements))
        {
            foreach (var element in elements.EnumerateArray())
            {
                var property = ParsePropertyDefinition(element);
                if (property != null)
                {
                    typeDef.Properties.Add(property);
                }
            }
        }
        
        return typeDef;
    }
    
    /// <summary>
    /// 解析 ValueSet 定義
    /// </summary>
    private ValueSetDefinition? ParseValueSetDefinition(JsonElement resource)
    {
        if (!resource.TryGetProperty("resourceType", out var resourceType) || 
            resourceType.GetString() != "ValueSet")
        {
            return null;
        }
        
        if (!resource.TryGetProperty("name", out var nameElement))
        {
            return null;
        }
        
        var name = nameElement.GetString();
        if (string.IsNullOrEmpty(name))
        {
            return null;
        }
        
        return new ValueSetDefinition
        {
            Name = name,
            Description = resource.TryGetProperty("description", out var desc) ? desc.GetString() ?? "" : "",
            Values = new List<string>() // 簡化實作
        };
    }
    
    /// <summary>
    /// 解析屬性定義
    /// </summary>
    private PropertyDefinition? ParsePropertyDefinition(JsonElement element)
    {
        if (!element.TryGetProperty("path", out var pathElement))
        {
            return null;
        }
        
        var path = pathElement.GetString();
        if (string.IsNullOrEmpty(path) || !path.Contains('.'))
        {
            return null; // 跳過根元素
        }
        
        var propertyName = path.Split('.').Last();
        
        var property = new PropertyDefinition
        {
            Name = propertyName,
            Description = element.TryGetProperty("short", out var shortDesc) ? shortDesc.GetString() ?? "" : ""
        };

        // 設定基數
        if (element.TryGetProperty("min", out var min))
        {
            property.MinCardinality = min.GetInt32();
        }

        if (element.TryGetProperty("max", out var max))
        {
            property.MaxCardinality = max.GetString() ?? "1";
        }
        
        // 解析類型
        if (element.TryGetProperty("type", out var types) && types.ValueKind == JsonValueKind.Array)
        {
            var firstType = types.EnumerateArray().FirstOrDefault();
            if (firstType.TryGetProperty("code", out var typeCode))
            {
                property.Type = typeCode.GetString() ?? "string";
            }
        }
        
        return property;
    }
}
