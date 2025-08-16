using System.Text.Json;
using FhirResourceGenerator.Core;
using Microsoft.Extensions.Logging;

namespace FhirResourceGenerator.Parsers;

/// <summary>
/// �����w�q�ѪR��
/// </summary>
/// <remarks>
/// �t�d�ѪR StructureDefinition ���������w�q
/// </remarks>
public class ElementDefinitionParser
{
    private readonly ILogger<ElementDefinitionParser> _logger;

    public ElementDefinitionParser(ILogger<ElementDefinitionParser> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// �ѪR�����C��
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
                _logger.LogWarning(ex, "�ѪR�����w�q�ɵo�Ϳ��~");
            }
        }

        return elements;
    }

    /// <summary>
    /// �ѪR��@�����w�q
    /// </summary>
    private async Task<ElementDefinition?> ParseElementAsync(JsonElement elementJson)
    {
        await Task.CompletedTask; // �קK�sĶ��ĵ�i

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

        // �ѪR�O�W
        if (elementJson.TryGetProperty("alias", out var aliasArray))
        {
            foreach (var alias in aliasArray.EnumerateArray())
            {
                element.Alias.Add(alias.GetString() ?? string.Empty);
            }
        }

        // �ѪR��ܤ覡
        if (elementJson.TryGetProperty("representation", out var representationArray))
        {
            foreach (var representation in representationArray.EnumerateArray())
            {
                element.Representation.Add(representation.GetString() ?? string.Empty);
            }
        }

        // �ѪR��¦��T
        if (elementJson.TryGetProperty("base", out var baseElement))
        {
            element.Base = new ElementBase
            {
                Path = GetStringProperty(baseElement, "path") ?? string.Empty,
                Min = GetIntProperty(baseElement, "min"),
                Max = GetStringProperty(baseElement, "max") ?? "1"
            };
        }

        // �ѪR����
        if (elementJson.TryGetProperty("type", out var typeArray))
        {
            foreach (var typeElement in typeArray.EnumerateArray())
            {
                var elementType = new ElementType
                {
                    Code = GetStringProperty(typeElement, "code") ?? string.Empty,
                    Versioning = GetStringProperty(typeElement, "versioning")
                };

                // �ѪR profile
                if (typeElement.TryGetProperty("profile", out var profileArray))
                {
                    foreach (var profile in profileArray.EnumerateArray())
                    {
                        elementType.Profile.Add(profile.GetString() ?? string.Empty);
                    }
                }

                // �ѪR targetProfile
                if (typeElement.TryGetProperty("targetProfile", out var targetProfileArray))
                {
                    foreach (var targetProfile in targetProfileArray.EnumerateArray())
                    {
                        elementType.TargetProfile.Add(targetProfile.GetString() ?? string.Empty);
                    }
                }

                // �ѪR aggregation
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

        // �ѪR�d��
        if (elementJson.TryGetProperty("example", out var exampleArray))
        {
            foreach (var exampleElement in exampleArray.EnumerateArray())
            {
                var example = new ElementExample
                {
                    Label = GetStringProperty(exampleElement, "label") ?? string.Empty
                };

                // �ѪR�d�ҭ� (�i��O�U������)
                if (exampleElement.TryGetProperty("valueString", out var valueString))
                    example.Value = valueString.GetString();
                else if (exampleElement.TryGetProperty("valueInteger", out var valueInteger))
                    example.Value = valueInteger.GetInt32();
                else if (exampleElement.TryGetProperty("valueBoolean", out var valueBoolean))
                    example.Value = valueBoolean.GetBoolean();
                // TODO: �K�[��L������

                element.Example.Add(example);
            }
        }

        // �ѪR����
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

        // �ѪR����
        if (elementJson.TryGetProperty("condition", out var conditionArray))
        {
            foreach (var condition in conditionArray.EnumerateArray())
            {
                element.Condition.Add(condition.GetString() ?? string.Empty);
            }
        }

        // �ѪR�j�w
        if (elementJson.TryGetProperty("binding", out var bindingElement))
        {
            element.Binding = new ElementBinding
            {
                Strength = GetStringProperty(bindingElement, "strength") ?? string.Empty,
                Description = GetStringProperty(bindingElement, "description"),
                ValueSet = GetStringProperty(bindingElement, "valueSet")
            };
        }

        // �ѪR�M�g
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

        // �ѪR�T�w�ȩM�Ҧ���
        ParseFixedAndPatternValues(elementJson, element);

        // �ѪR�̤p�ȩM�̤j��
        ParseMinMaxValues(elementJson, element);

        return element;
    }

    /// <summary>
    /// �ѪR�T�w�ȩM�Ҧ���
    /// </summary>
    private void ParseFixedAndPatternValues(JsonElement elementJson, ElementDefinition element)
    {
        // �T�w��
        foreach (var property in elementJson.EnumerateObject())
        {
            if (property.Name.StartsWith("fixed"))
            {
                element.Fixed = ParseValueByType(property.Value, property.Name.Substring(5));
                break;
            }
        }

        // �Ҧ���
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
    /// �ѪR�̤p�ȩM�̤j��
    /// </summary>
    private void ParseMinMaxValues(JsonElement elementJson, ElementDefinition element)
    {
        // �̤p��
        foreach (var property in elementJson.EnumerateObject())
        {
            if (property.Name.StartsWith("minValue"))
            {
                element.MinValue = ParseValueByType(property.Value, property.Name.Substring(8));
                break;
            }
        }

        // �̤j��
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
    /// �ھ������ѪR��
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
            _ => value.GetRawText() // ���������O�d��l JSON
        };
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
    /// ���o����ݩ�
    /// </summary>
    private static int GetIntProperty(JsonElement element, string propertyName)
    {
        return element.TryGetProperty(propertyName, out var property) ? 
            property.GetInt32() : 0;
    }

    /// <summary>
    /// ���o�i�ž���ݩ�
    /// </summary>
    private static int? GetNullableIntProperty(JsonElement element, string propertyName)
    {
        return element.TryGetProperty(propertyName, out var property) ? 
            property.GetInt32() : null;
    }

    /// <summary>
    /// ���o�i�ť��L�ݩ�
    /// </summary>
    private static bool? GetBooleanProperty(JsonElement element, string propertyName)
    {
        return element.TryGetProperty(propertyName, out var property) ? 
            property.GetBoolean() : null;
    }
}