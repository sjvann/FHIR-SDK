using System.Text.Json;
using FhirResourceGenerator.Core;
using Microsoft.Extensions.Logging;

namespace FhirResourceGenerator.Parsers;

/// <summary>
/// 元素定義解析器
/// </summary>
/// <remarks>
/// 負責解析 StructureDefinition 中的元素定義
/// </remarks>
public class ElementDefinitionParser
{
    private readonly ILogger<ElementDefinitionParser> _logger;

    public ElementDefinitionParser(ILogger<ElementDefinitionParser> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// 解析元素列表
    /// </summary>
    public async Task<List<ElementDefinition>> ParseElementsAsync(JsonElement elementsArray)
    {
        var elements = new List<ElementDefinition>();

        foreach (var elementJson in elementsArray.EnumerateArray())
        {
            try
            {
                var element = await ParseElementAsync(elementJson);
                if (element != null)
                    elements.Add(element);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "解析元素定義時發生錯誤");
            }
        }

        return elements;
    }

    /// <summary>
    /// 解析單一元素定義
    /// </summary>
    private async Task<ElementDefinition?> ParseElementAsync(JsonElement elementJson)
    {
        await Task.CompletedTask; // 避免編譯器警告

        var element = new ElementDefinition
        {
            Id = GetStringProperty(elementJson, "id") ?? string.Empty,
            Path = GetStringProperty(elementJson, "path") ?? string.Empty,
            SliceName = GetStringProperty(elementJson, "sliceName"),
            Label = GetStringProperty(elementJson, "label"),
            Short = GetStringProperty(elementJson, "short"),
            Definition = GetStringProperty(elementJson, "definition"),
            Comment = GetStringProperty(elementJson, "comment"),
            Requirements = GetStringProperty(elementJson, "requirements"),
            Min = GetIntProperty(elementJson, "min"),
            Max = GetStringProperty(elementJson, "max") ?? "1",
            ContentReference = GetStringProperty(elementJson, "contentReference"),
            MeaningWhenMissing = GetStringProperty(elementJson, "meaningWhenMissing"),
            OrderMeaning = GetStringProperty(elementJson, "orderMeaning"),
            MaxLength = GetIntProperty(elementJson, "maxLength"),
            MustSupport = GetBooleanProperty(elementJson, "mustSupport"),
            IsModifier = GetBooleanProperty(elementJson, "isModifier"),
            IsModifierReason = GetStringProperty(elementJson, "isModifierReason"),
            IsSummary = GetBooleanProperty(elementJson, "isSummary")
        };

        // 解析別名
        if (elementJson.TryGetProperty("alias", out var aliasArray))
        {
            foreach (var alias in aliasArray.EnumerateArray())
            {
                element.Alias.Add(alias.GetString() ?? string.Empty);
            }
        }

        // 解析表示方式
        if (elementJson.TryGetProperty("representation", out var representationArray))
        {
            foreach (var representation in representationArray.EnumerateArray())
            {
                element.Representation.Add(representation.GetString() ?? string.Empty);
            }
        }

        // 解析基礎資訊
        if (elementJson.TryGetProperty("base", out var baseElement))
        {
            element.Base = new ElementBase
            {
                Path = GetStringProperty(baseElement, "path") ?? string.Empty,
                Min = GetIntProperty(baseElement, "min"),
                Max = GetStringProperty(baseElement, "max") ?? "1"
            };
        }

        // 解析類型
        if (elementJson.TryGetProperty("type", out var typeArray))
        {
            foreach (var typeElement in typeArray.EnumerateArray())
            {
                var elementType = new ElementType
                {
                    Code = GetStringProperty(typeElement, "code") ?? string.Empty,
                    Versioning = GetStringProperty(typeElement, "versioning")
                };

                // 解析 profile
                if (typeElement.TryGetProperty("profile", out var profileArray))
                {
                    foreach (var profile in profileArray.EnumerateArray())
                    {
                        elementType.Profile.Add(profile.GetString() ?? string.Empty);
                    }
                }

                // 解析 targetProfile
                if (typeElement.TryGetProperty("targetProfile", out var targetProfileArray))
                {
                    foreach (var targetProfile in targetProfileArray.EnumerateArray())
                    {
                        elementType.TargetProfile.Add(targetProfile.GetString() ?? string.Empty);
                    }
                }

                // 解析 aggregation
                if (typeElement.TryGetProperty("aggregation", out var aggregationArray))
                {
                    foreach (var aggregation in aggregationArray.EnumerateArray())
                    {
                        elementType.Aggregation.Add(aggregation.GetString() ?? string.Empty);
                    }
                }

                element.Type.Add(elementType);
            }
        }

        // 解析範例
        if (elementJson.TryGetProperty("example", out var exampleArray))
        {
            foreach (var exampleElement in exampleArray.EnumerateArray())
            {
                var example = new ElementExample
                {
                    Label = GetStringProperty(exampleElement, "label") ?? string.Empty
                };

                // 解析範例值 (可能是各種類型)
                if (exampleElement.TryGetProperty("valueString", out var valueString))
                    example.Value = valueString.GetString();
                else if (exampleElement.TryGetProperty("valueInteger", out var valueInteger))
                    example.Value = valueInteger.GetInt32();
                else if (exampleElement.TryGetProperty("valueBoolean", out var valueBoolean))
                    example.Value = valueBoolean.GetBoolean();
                // TODO: 添加其他值類型

                element.Example.Add(example);
            }
        }

        // 解析約束
        if (elementJson.TryGetProperty("constraint", out var constraintArray))
        {
            foreach (var constraintElement in constraintArray.EnumerateArray())
            {
                var constraint = new ElementConstraint
                {
                    Key = GetStringProperty(constraintElement, "key") ?? string.Empty,
                    Requirements = GetStringProperty(constraintElement, "requirements") ?? string.Empty,
                    Severity = GetStringProperty(constraintElement, "severity") ?? string.Empty,
                    Human = GetStringProperty(constraintElement, "human") ?? string.Empty,
                    Expression = GetStringProperty(constraintElement, "expression") ?? string.Empty,
                    Xpath = GetStringProperty(constraintElement, "xpath"),
                    Source = GetStringProperty(constraintElement, "source")
                };

                element.Constraint.Add(constraint);
            }
        }

        // 解析條件
        if (elementJson.TryGetProperty("condition", out var conditionArray))
        {
            foreach (var condition in conditionArray.EnumerateArray())
            {
                element.Condition.Add(condition.GetString() ?? string.Empty);
            }
        }

        // 解析綁定
        if (elementJson.TryGetProperty("binding", out var bindingElement))
        {
            element.Binding = new ElementBinding
            {
                Strength = GetStringProperty(bindingElement, "strength") ?? string.Empty,
                Description = GetStringProperty(bindingElement, "description"),
                ValueSet = GetStringProperty(bindingElement, "valueSet")
            };
        }

        // 解析映射
        if (elementJson.TryGetProperty("mapping", out var mappingArray))
        {
            foreach (var mappingElement in mappingArray.EnumerateArray())
            {
                var mapping = new ElementMapping
                {
                    Identity = GetStringProperty(mappingElement, "identity") ?? string.Empty,
                    Language = GetStringProperty(mappingElement, "language"),
                    Map = GetStringProperty(mappingElement, "map") ?? string.Empty,
                    Comment = GetStringProperty(mappingElement, "comment")
                };

                element.Mapping.Add(mapping);
            }
        }

        // 解析固定值和模式值
        ParseFixedAndPatternValues(elementJson, element);

        // 解析最小值和最大值
        ParseMinMaxValues(elementJson, element);

        return element;
    }

    /// <summary>
    /// 解析固定值和模式值
    /// </summary>
    private void ParseFixedAndPatternValues(JsonElement elementJson, ElementDefinition element)
    {
        // 固定值
        foreach (var property in elementJson.EnumerateObject())
        {
            if (property.Name.StartsWith("fixed"))
            {
                element.Fixed = ParseValueByType(property.Value, property.Name.Substring(5));
                break;
            }
        }

        // 模式值
        foreach (var property in elementJson.EnumerateObject())
        {
            if (property.Name.StartsWith("pattern"))
            {
                element.Pattern = ParseValueByType(property.Value, property.Name.Substring(7));
                break;
            }
        }
    }

    /// <summary>
    /// 解析最小值和最大值
    /// </summary>
    private void ParseMinMaxValues(JsonElement elementJson, ElementDefinition element)
    {
        // 最小值
        foreach (var property in elementJson.EnumerateObject())
        {
            if (property.Name.StartsWith("minValue"))
            {
                element.MinValue = ParseValueByType(property.Value, property.Name.Substring(8));
                break;
            }
        }

        // 最大值
        foreach (var property in elementJson.EnumerateObject())
        {
            if (property.Name.StartsWith("maxValue"))
            {
                element.MaxValue = ParseValueByType(property.Value, property.Name.Substring(8));
                break;
            }
        }
    }

    /// <summary>
    /// 根據類型解析值
    /// </summary>
    private object? ParseValueByType(JsonElement value, string typeName)
    {
        return typeName.ToLower() switch
        {
            "string" or "code" or "id" or "markdown" or "uri" or "url" or "canonical" => value.GetString(),
            "boolean" => value.GetBoolean(),
            "integer" or "positiveint" or "unsignedint" => value.GetInt32(),
            "decimal" => value.GetDecimal(),
            "datetime" or "date" or "time" or "instant" => value.GetString(),
            _ => value.GetRawText() // 複雜類型保留原始 JSON
        };
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
    /// 取得整數屬性
    /// </summary>
    private static int GetIntProperty(JsonElement element, string propertyName)
    {
        return element.TryGetProperty(propertyName, out var property) ? 
            property.GetInt32() : 0;
    }

    /// <summary>
    /// 取得可空整數屬性
    /// </summary>
    private static int? GetNullableIntProperty(JsonElement element, string propertyName)
    {
        return element.TryGetProperty(propertyName, out var property) ? 
            property.GetInt32() : null;
    }

    /// <summary>
    /// 取得可空布林屬性
    /// </summary>
    private static bool? GetBooleanProperty(JsonElement element, string propertyName)
    {
        return element.TryGetProperty(propertyName, out var property) ? 
            property.GetBoolean() : null;
    }
}