using System.Reflection;
using System.Text.Json.Serialization;
using Fhir.Path.Exceptions;
using Fhir.TypeFramework.Bases;

namespace Fhir.Path.R5.Patch;

/// <summary>由 Patch nested parts 建立匿名 backbone / complex 實例。</summary>
internal static class AnonymousTypeBuilder
{
    public static object Build(Dictionary<string, object?> values, Type parentType, string? elementName)
    {
        var targetType = ResolveTargetType(parentType, elementName)
            ?? throw FhirPathException.Runtime($"Cannot resolve type for element '{elementName}'.");

        var instance = Activator.CreateInstance(targetType)
            ?? throw FhirPathException.Runtime($"Cannot create {targetType.Name}.");

        foreach (var (key, val) in values)
        {
            var prop = targetType.GetProperties()
                .FirstOrDefault(p => p.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name == key
                    || string.Equals(p.Name, key, StringComparison.OrdinalIgnoreCase));
            if (prop is null) continue;

            object? assigned = val switch
            {
                Dictionary<string, object?> nested => Build(nested, targetType, key),
                _ => val
            };
            prop.SetValue(instance, assigned);
        }
        return instance;
    }

    private static Type? ResolveTargetType(Type parentType, string? elementName)
    {
        if (elementName is null) return null;
        var meta = Fhir.Path.Navigation.ElementMetadataCache.Get(parentType);
        if (meta.Elements.TryGetValue(elementName, out var binding))
        {
            if (!binding.IsChoice && binding.Property is not null)
                return GetItemType(binding.Property.PropertyType);
            if (binding.IsChoice && binding.ChoiceMembers?.Count > 0)
                return binding.ChoiceMembers[0].Property!.PropertyType;
        }

        var nested = parentType.GetNestedTypes(BindingFlags.Public)
            .FirstOrDefault(t => t.Name.Contains(elementName, StringComparison.OrdinalIgnoreCase));
        return nested;
    }

    private static Type GetItemType(Type propType)
    {
        if (propType.IsGenericType && typeof(System.Collections.IEnumerable).IsAssignableFrom(propType))
            return propType.GetGenericArguments()[0];
        return propType;
    }
}
