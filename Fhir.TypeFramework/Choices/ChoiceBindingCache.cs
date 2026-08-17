using System.Collections.Concurrent;
using System.Reflection;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.Choices;

public static class ChoiceBindingCache
{
    private static readonly ConcurrentDictionary<Type, IReadOnlyDictionary<string, ChoiceGroupBinding>> Cache = new();

    public static IReadOnlyDictionary<string, ChoiceGroupBinding> GetGroups(Type type)
        => Cache.GetOrAdd(type, Build);

    public static bool TryGetGroup(Type type, string elementName, out ChoiceGroupBinding? group)
    {
        var groups = GetGroups(type);
        if (groups.TryGetValue(elementName, out var g))
        {
            group = g;
            return true;
        }

        group = null;
        return false;
    }

    private static IReadOnlyDictionary<string, ChoiceGroupBinding> Build(Type type)
    {
        var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(p => p.GetCustomAttribute<JsonIgnoreAttribute>() is null)
            .Where(p => p.Name != "ResourceTypeJson")
            .ToList();

        var singles = new Dictionary<string, PropertyInfo>(StringComparer.Ordinal);
        var choiceCandidates = new Dictionary<string, List<ChoiceMemberBinding>>(StringComparer.Ordinal);

        foreach (var prop in props)
        {
            var jsonName = prop.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name ?? prop.Name;
            if (jsonName == "resourceType")
                continue;

            if (!ChoiceElementNaming.TryGetChoiceStem(prop.Name, out var stem))
            {
                singles[jsonName] = prop;
                continue;
            }

            if (!choiceCandidates.TryGetValue(stem, out var list))
            {
                list = [];
                choiceCandidates[stem] = list;
            }

            list.Add(new ChoiceMemberBinding(jsonName, prop, GetMemberTypeSuffix(prop.Name)));
        }

        var result = new Dictionary<string, ChoiceGroupBinding>(StringComparer.Ordinal);
        foreach (var (stem, members) in choiceCandidates)
        {
            if (members.Count >= 2)
                result[stem] = new ChoiceGroupBinding(stem, members);
            else if (members.Count == 1)
                singles[members[0].JsonName] = members[0].Property;
        }

        _ = singles;
        return result;
    }

    private static string GetMemberTypeSuffix(string propertyName)
    {
        foreach (var suffix in ChoiceElementNaming.TypeSuffixes.OrderByDescending(s => s.Length))
        {
            if (!propertyName.EndsWith(suffix, StringComparison.Ordinal))
                continue;
            return char.ToLowerInvariant(suffix[0]) + suffix[1..];
        }

        return propertyName;
    }
}
