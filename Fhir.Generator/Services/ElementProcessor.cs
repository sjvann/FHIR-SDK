using System.Text.Json;
using Fhir.Generator.Models;

namespace Fhir.Generator.Services;

public static class ElementProcessor
{
    public static void ProcessElements(JsonElement elements, TypeDefinition definition, EnhancedTypeMapper typeMapper)
    {
        var rootPath = definition.Name;
        var order = 10; // 從 10 開始，為基礎屬性留空間

        foreach (var element in elements.EnumerateArray())
        {
            var path = element.GetProperty("path").GetString()!;

            // 跳過根元素
            if (path == rootPath) continue;

            // 只處理直接子元素
            var pathParts = path.Split('.');
            var rootParts = rootPath.Split('.');

            if (pathParts.Length != rootParts.Length + 1) continue;

            var elementName = path.Split('.').Last();

            // 處理 Choice Types - 生成多個強型別屬性
            if (elementName.EndsWith("[x]"))
            {
                var choiceProperties = CreateChoiceProperties(element, elementName, order, typeMapper);
                foreach (var choiceProperty in choiceProperties)
                {
                    definition.Properties.Add(choiceProperty);
                    order++;
                }
            }
            else
            {
                // 處理普通屬性
                var property = CreatePropertyFromElement(element, order++, typeMapper);
                if (property != null)
                {
                    definition.Properties.Add(property);
                }
            }
        }
    }

    private static PropertyDefinition? CreatePropertyFromElement(JsonElement element, int order, EnhancedTypeMapper typeMapper)
    {
        var path = element.GetProperty("path").GetString()!;
        var elementName = path.Split('.').Last();

        // 檢查是否為 Choice Type - 如果是，應該由 ChoiceTypeHandler 處理
        if (elementName.EndsWith("[x]"))
        {
            return null; // Choice Types 由 ChoiceTypeHandler 處理
        }

        // 處理普通屬性
        if (!element.TryGetProperty("type", out var types)) return null;

        var typeArray = types.EnumerateArray().ToArray();
        if (typeArray.Length == 0) return null;

        var firstType = typeArray[0];
        var typeCode = firstType.GetProperty("code").GetString()!;

        // 提取 target profiles (用於 Reference 型別)
        var targetProfiles = ExtractTargetProfiles(firstType);

        // 提取基數
        var cardinality = ExtractCardinality(element);

        var property = new PropertyDefinition
        {
            Name = ToPascalCase(elementName),
            Type = typeMapper.MapFhirTypeToCSharpWithCardinality(typeCode, cardinality.Min, cardinality.Max, targetProfiles),
            Description = GetElementDescription(element),
            MinCardinality = cardinality.Min,
            MaxCardinality = cardinality.Max,
            Order = order
        };

        return property;
    }
    
    /// <summary>
    /// 處理 Choice Type 元素，生成 OneOf 屬性
    /// </summary>
    private static PropertyDefinition? CreateOneOfChoiceProperty(JsonElement element, int order, EnhancedTypeMapper typeMapper)
    {
        var choiceHandler = new ChoiceTypeHandler(typeMapper);
        return choiceHandler.GenerateOneOfChoiceProperty(element, order);
    }

    /// <summary>
    /// 處理 Choice Type 元素，使用舊的多屬性模式（保留以備需要）
    /// </summary>
    private static List<PropertyDefinition> CreateChoiceProperties(JsonElement element, string elementName, int order, EnhancedTypeMapper typeMapper)
    {
        var choiceHandler = new ChoiceTypeHandler(typeMapper);
        return choiceHandler.GenerateChoiceProperties(element, order);
    }

    private static string GetElementDescription(JsonElement element)
    {
        if (element.TryGetProperty("definition", out var definition))
            return definition.GetString() ?? string.Empty;
        if (element.TryGetProperty("short", out var shortDesc))
            return shortDesc.GetString() ?? string.Empty;
        return string.Empty;
    }

    private static (int Min, string Max, bool IsArray) ExtractCardinality(JsonElement element)
    {
        var min = 0;
        var max = "1";

        if (element.TryGetProperty("min", out var minElement))
            min = minElement.GetInt32();

        if (element.TryGetProperty("max", out var maxElement))
            max = maxElement.GetString() ?? "1";

        var isArray = max == "*" || (int.TryParse(max, out var maxInt) && maxInt > 1);

        return (min, max, isArray);
    }

    private static List<string>? ExtractTargetProfiles(JsonElement type)
    {
        if (!type.TryGetProperty("targetProfile", out var profiles))
            return null;

        return profiles.EnumerateArray()
            .Select(p => p.GetString())
            .Where(p => !string.IsNullOrEmpty(p))
            .ToList()!;
    }

    private static string ToPascalCase(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;
        return char.ToUpper(input[0]) + input[1..];
    }
}