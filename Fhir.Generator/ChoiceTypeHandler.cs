using System.Text.Json;
using Fhir.Generator.Models;
using OneOf;
using Fhir.Generator.Services;

namespace Fhir.Generator;

/// <summary>
/// 處理 FHIR Choice Types (value[x]) 的強型別實現
/// </summary>
public class ChoiceTypeHandler
{
    private readonly EnhancedTypeMapper _typeMapper;

    public ChoiceTypeHandler(EnhancedTypeMapper typeMapper)
    {
        _typeMapper = typeMapper;
    }

    /// <summary>
    /// 為 Choice Type 元素生成強型別屬性
    /// </summary>
    public List<PropertyDefinition> GenerateChoiceProperties(JsonElement element, int baseOrder)
    {
        var properties = new List<PropertyDefinition>();
        var elementName = element.GetProperty("path").GetString()!.Split('.').Last();

        if (!elementName.EndsWith("[x]"))
            return properties;

        var baseName = elementName[..^3]; // 移除 "[x]"
        var description = GetElementDescription(element);
        var cardinality = ExtractCardinality(element);

        // 為每個可能的型別生成個別屬性
        var order = baseOrder;
        foreach (var type in element.GetProperty("type").EnumerateArray())
        {
            var typeCode = type.GetProperty("code").GetString()!;
            var targetProfiles = ExtractTargetProfiles(type);

            var property = new PropertyDefinition
            {
                Name = $"{ToPascalCase(baseName)}{ToPascalCase(typeCode)}",
                Type = _typeMapper.MapFhirTypeToCSharpWithCardinality(typeCode, cardinality.Min, cardinality.Max, targetProfiles),
                Description = $"{description} (as {typeCode})",
                MinCardinality = cardinality.Min,
                MaxCardinality = cardinality.Max,
                IsChoiceType = true,
                Order = order++
            };

            // 記錄這是 Choice Type 的一部分
            property.ChoiceTypes.Add(typeCode);

            properties.Add(property);
        }

        return properties;
    }

    /// <summary>
    /// 為 Choice Type 元素生成單一 OneOf 屬性
    /// </summary>
    public PropertyDefinition? GenerateOneOfChoiceProperty(JsonElement element, int baseOrder)
    {
        var elementName = element.GetProperty("path").GetString()!.Split('.').Last();

        if (!elementName.EndsWith("[x]"))
            return null;

        var baseName = elementName[..^3]; // 移除 "[x]"
        var description = GetElementDescription(element);
        var cardinality = ExtractCardinality(element);

        // 收集所有可能的型別
        var csharpTypes = new List<string>();
        var typeMapping = new Dictionary<string, string>();

        foreach (var type in element.GetProperty("type").EnumerateArray())
        {
            var typeCode = type.GetProperty("code").GetString()!;
            var targetProfiles = ExtractTargetProfiles(type);

            // 對於 Choice Type，每個選項都是非 nullable 的
            var csharpType = _typeMapper.MapFhirTypeToCSharp(typeCode, false, targetProfiles);
            csharpTypes.Add(csharpType);
            typeMapping[csharpType] = ToPascalCase(typeCode);
        }

        // 檢查是否超過 OneOf 支援的型別數量
        if (csharpTypes.Count > 16)
        {
            // 對於超過 16 個型別的 Choice Type，不使用 OneOf
            return null;
        }

        // 生成 OneOf 型別
        var oneOfType = GenerateOneOfType(csharpTypes);

        // 根據基數決定是否 nullable
        var finalType = cardinality.Min == 0 ? $"{oneOfType}?" : oneOfType;

        var property = new PropertyDefinition
        {
            Name = ToPascalCase(baseName),
            Type = finalType,
            Description = description,
            MinCardinality = cardinality.Min,
            MaxCardinality = cardinality.Max,
            Order = baseOrder,
            IsChoiceType = true,
            IsOneOfChoiceType = true,
            ChoiceBaseName = baseName,
            ChoiceTypeMapping = typeMapping
        };

        return property;
    }

    /// <summary>
    /// 生成 OneOf 型別字串
    /// </summary>
    private static string GenerateOneOfType(List<string> types)
    {
        // OneOf 套件最多支援 16 個型別
        // 對於超過 16 個型別的情況，回退到舊的多屬性模式
        if (types.Count > 16)
        {
            throw new NotSupportedException($"OneOf with {types.Count} types is not supported. Consider using multiple properties approach for this Choice Type.");
        }

        return types.Count switch
        {
            1 => types[0], // 單一型別不需要 OneOf
            2 => $"OneOf<{string.Join(", ", types)}>",
            3 => $"OneOf<{string.Join(", ", types)}>",
            4 => $"OneOf<{string.Join(", ", types)}>",
            5 => $"OneOf<{string.Join(", ", types)}>",
            6 => $"OneOf<{string.Join(", ", types)}>",
            7 => $"OneOf<{string.Join(", ", types)}>",
            8 => $"OneOf<{string.Join(", ", types)}>",
            9 => $"OneOf<{string.Join(", ", types)}>",
            10 => $"OneOf<{string.Join(", ", types)}>",
            11 => $"OneOf<{string.Join(", ", types)}>",
            12 => $"OneOf<{string.Join(", ", types)}>",
            13 => $"OneOf<{string.Join(", ", types)}>",
            14 => $"OneOf<{string.Join(", ", types)}>",
            15 => $"OneOf<{string.Join(", ", types)}>",
            16 => $"OneOf<{string.Join(", ", types)}>",
            _ => throw new NotSupportedException($"OneOf with {types.Count} types is not supported")
        };
    }

    /// <summary>
    /// 生成 Choice Type 的驗證邏輯
    /// </summary>
    public string GenerateChoiceValidationCode(List<PropertyDefinition> choiceProperties)
    {
        if (!choiceProperties.Any()) return string.Empty;

        var baseName = ExtractBaseName(choiceProperties.First().Name);
        var propertyNames = choiceProperties.Select(p => p.Name).ToList();

        return $@"
        // Choice Type validation for {baseName}[x]
        var {baseName.ToLower()}Properties = new[] {{ {string.Join(", ", propertyNames.Select(n => $"nameof({n})"))} }};
        var {baseName.ToLower()}SetCount = {baseName.ToLower()}Properties.Count(prop =>
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if ({baseName.ToLower()}SetCount > 1)
        {{
            yield return new ValidationIssue(
                Severity.Error,
                ""choice-type-conflict"",
                ""Only one of "" + string.Join("", "", propertyNames) + "" may be specified"");
        }}";
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

    private static string ExtractBaseName(string choicePropertyName)
    {
        // 從 "valueString" 提取 "value"
        // 從 "onsetDateTime" 提取 "onset"
        var knownTypes = new[] { "String", "Integer", "Boolean", "DateTime", "Code", "Uri", "Decimal", "Reference", "CodeableConcept", "Coding", "Quantity", "Period", "Range", "Ratio", "Attachment", "Identifier", "HumanName", "Address", "ContactPoint", "Timing", "Signature", "Annotation" };

        foreach (var type in knownTypes.OrderByDescending(t => t.Length))
        {
            if (choicePropertyName.EndsWith(type))
            {
                return choicePropertyName[..^type.Length];
            }
        }

        return choicePropertyName;
    }

    private static string ToPascalCase(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;
        return char.ToUpper(input[0]) + input[1..];
    }
}