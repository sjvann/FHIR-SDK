using System.IO.Compression;
using System.Text.Json;
using Fhir.Generator.Models;

namespace Fhir.Generator.Services;

public class FhirDefinitionProcessor
{
    public async Task<FhirSchema> ProcessDefinitionsAsync(string definitionsZipPath, string version)
    {
        var schema = new FhirSchema { Version = version };
        
        using var archive = ZipFile.OpenRead(definitionsZipPath);
        
        // 階段 1: 處理基礎型別 (profiles-types.json)
        await ProcessTypesBundle(archive, schema);
        
        // 階段 2: 處理資源 (profiles-resources.json)  
        await ProcessResourcesBundle(archive, schema);
        
        // 階段 3: 處理值集 (valuesets.json)
        await ProcessValueSetsBundle(archive, schema);
        
        return schema;
    }
    
    private async Task ProcessTypesBundle(ZipArchive archive, FhirSchema schema)
    {
        var typesEntry = archive.GetEntry("profiles-types.json");
        if (typesEntry == null) return;
        
        using var stream = typesEntry.Open();
        using var doc = await JsonDocument.ParseAsync(stream);
        
        if (doc.RootElement.TryGetProperty("entry", out var entries))
        {
            foreach (var entry in entries.EnumerateArray())
            {
                if (entry.TryGetProperty("resource", out var resource))
                {
                    ProcessStructureDefinition(resource, schema, isResource: false);
                }
            }
        }
    }
    
    private async Task ProcessResourcesBundle(ZipArchive archive, FhirSchema schema)
    {
        var resourcesEntry = archive.GetEntry("profiles-resources.json");
        if (resourcesEntry == null) return;
        
        using var stream = resourcesEntry.Open();
        using var doc = await JsonDocument.ParseAsync(stream);
        
        if (doc.RootElement.TryGetProperty("entry", out var entries))
        {
            foreach (var entry in entries.EnumerateArray())
            {
                if (entry.TryGetProperty("resource", out var resource))
                {
                    ProcessStructureDefinition(resource, schema, isResource: true);
                }
            }
        }
    }
    
    private void ProcessStructureDefinition(JsonElement structDef, FhirSchema schema, bool isResource)
    {
        if (!structDef.TryGetProperty("resourceType", out var resourceType) || 
            resourceType.GetString() != "StructureDefinition")
            return;
            
        var name = structDef.GetProperty("name").GetString()!;
        var kind = structDef.GetProperty("kind").GetString();
        
        // 跳過抽象基礎類型，我們會手動定義這些
        if (IsAbstractBaseType(name)) return;
        
        var definition = isResource ? new ResourceDefinition() : new TypeDefinition();
        definition.Name = name;
        definition.Description = GetDescription(structDef);
        definition.BaseType = ExtractBaseType(structDef);
        definition.Kind = DetermineTypeKind(kind, isResource);
        
        if (definition is ResourceDefinition resDef)
        {
            resDef.ResourceType = name;
        }
        
        // 處理元素定義
        if (structDef.TryGetProperty("snapshot", out var snapshot) &&
            snapshot.TryGetProperty("element", out var elements))
        {
            var typeMapper = new EnhancedTypeMapper();
            ElementProcessor.ProcessElements(elements, definition, typeMapper);

            // 提取驗證規則
            var validationGenerator = new ValidationRuleGenerator();
            definition.ValidationRules = validationGenerator.ExtractValidationRules(structDef);
        }
        
        // 添加到 schema
        if (isResource)
        {
            schema.Resources[name] = (ResourceDefinition)definition;
        }
        else
        {
            schema.DataTypes[name] = definition;
        }
    }

    private async Task ProcessValueSetsBundle(ZipArchive archive, FhirSchema schema)
    {
        var valueSetsEntry = archive.GetEntry("valuesets.json");
        if (valueSetsEntry == null) return;

        using var stream = valueSetsEntry.Open();
        using var doc = await JsonDocument.ParseAsync(stream);

        if (doc.RootElement.TryGetProperty("entry", out var entries))
        {
            foreach (var entry in entries.EnumerateArray())
            {
                if (entry.TryGetProperty("resource", out var resource))
                {
                    ProcessValueSet(resource, schema);
                }
            }
        }
    }

    private void ProcessValueSet(JsonElement valueSet, FhirSchema schema)
    {
        if (!valueSet.TryGetProperty("resourceType", out var resourceType) ||
            resourceType.GetString() != "ValueSet")
            return;

        var name = valueSet.GetProperty("name").GetString() ?? string.Empty;
        var url = valueSet.GetProperty("url").GetString() ?? string.Empty;
        var description = GetDescription(valueSet);

        var definition = new ValueSetDefinition
        {
            Name = name,
            Url = url,
            Description = description
        };

        schema.ValueSets[name] = definition;
    }

    private static bool IsAbstractBaseType(string name)
    {
        return name is "Element" or "BackboneElement" or "DataType" or "PrimitiveType" or "Resource" or "DomainResource";
    }

    private static string GetDescription(JsonElement element)
    {
        if (element.TryGetProperty("description", out var description))
            return description.GetString() ?? string.Empty;
        if (element.TryGetProperty("definition", out var definition))
            return definition.GetString() ?? string.Empty;
        return string.Empty;
    }

    private static string ExtractBaseType(JsonElement structDef)
    {
        if (structDef.TryGetProperty("baseDefinition", out var baseDefinition))
        {
            var baseUrl = baseDefinition.GetString() ?? string.Empty;
            // 從 URL 中提取型別名稱
            var parts = baseUrl.Split('/');
            return parts.LastOrDefault() ?? "object";
        }
        return "object";
    }

    private static TypeKind DetermineTypeKind(string? kind, bool isResource)
    {
        if (isResource) return TypeKind.Resource;

        return kind switch
        {
            "primitive-type" => TypeKind.PrimitiveType,
            "complex-type" => TypeKind.ComplexType,
            "resource" => TypeKind.Resource,
            _ => TypeKind.ComplexType
        };
    }
}