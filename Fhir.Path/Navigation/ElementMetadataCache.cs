using System.Collections.Concurrent;
using System.Reflection;
using System.Text.Json.Serialization;
using Fhir.TypeFramework.Choices;
using Fhir.TypeFramework.Metadata;

namespace Fhir.Path.Navigation;

public static class ElementMetadataCache
{
    private static readonly ConcurrentDictionary<Type, TypeMetadata> Cache = new();

    /// <summary>可選。提供產生式元素表時，仍以 CLR 屬性綁定取值。</summary>
    public static IModelMetadataProvider? Provider { get; set; }

    public static TypeMetadata Get(Type type) => Cache.GetOrAdd(type, Build);

    private static TypeMetadata Build(Type type)
    {
        var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(p => p.GetCustomAttribute<JsonIgnoreAttribute>() is null)
            .Where(p => p.Name != "ResourceTypeJson")
            .ToList();

        var elements = new Dictionary<string, ElementBinding>(StringComparer.Ordinal);
        var choiceCandidates = new Dictionary<string, List<(string JsonName, PropertyInfo Prop)>>(StringComparer.Ordinal);

        foreach (var prop in props)
        {
            var jsonName = prop.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name ?? prop.Name;
            if (jsonName == "resourceType" || prop.Name == "ResourceTypeJson")
                continue;

            if (ChoiceElementNaming.TryGetChoiceStem(prop.Name, out var baseName))
            {
                if (!choiceCandidates.TryGetValue(baseName, out var list))
                {
                    list = [];
                    choiceCandidates[baseName] = list;
                }
                list.Add((jsonName, prop));
            }
            else
            {
                elements[jsonName] = new ElementBinding(jsonName, prop);
            }
        }

        foreach (var (baseName, members) in choiceCandidates)
        {
            var choiceBindings = members.Select(m => new ElementBinding(m.JsonName, m.Prop)).ToList();
            elements[baseName] = ElementBinding.ForChoice(baseName, choiceBindings);

            foreach (var member in members)
            {
                if (!elements.ContainsKey(member.JsonName))
                    elements[member.JsonName] = new ElementBinding(member.JsonName, member.Prop);
            }
        }

        return new TypeMetadata(type, elements);
    }

}

public sealed record ElementBinding(string ElementName, PropertyInfo? Property, bool IsChoice, IReadOnlyList<ElementBinding>? ChoiceMembers)
{
    public ElementBinding(string elementName, PropertyInfo property)
        : this(elementName, property, false, null) { }

    public static ElementBinding ForChoice(string baseName, List<ElementBinding> members)
        => new(baseName, null, true, members);
}

public sealed class TypeMetadata(Type clrType, Dictionary<string, ElementBinding> elements)
{
    public Type ClrType { get; } = clrType;
    public IReadOnlyDictionary<string, ElementBinding> Elements { get; } = elements;
}
