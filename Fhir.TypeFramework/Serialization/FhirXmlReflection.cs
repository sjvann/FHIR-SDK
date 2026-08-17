using System.Collections;
using System.Collections.Concurrent;
using System.Reflection;
using System.Text.Json.Serialization;
using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes;

namespace Fhir.TypeFramework.Serialization;

internal sealed record FhirXmlProperty(string ElementName, PropertyInfo Property, Type ItemType, bool IsList);

internal sealed class FhirXmlTypeMap
{
    public required IReadOnlyDictionary<string, FhirXmlProperty> ByElementName { get; init; }
}

internal static class FhirXmlReflection
{
    private static readonly ConcurrentDictionary<Type, FhirXmlTypeMap> Cache = new();
    private static readonly ConcurrentDictionary<string, Type> FhirTypeByName = new(StringComparer.Ordinal);

    static FhirXmlReflection()
    {
        foreach (var type in typeof(Base).Assembly.GetTypes())
        {
            if (type.IsAbstract || !typeof(Base).IsAssignableFrom(type))
                continue;
            FhirTypeByName[ToFhirTypeName(type)] = type;
        }
    }

    public static FhirXmlTypeMap GetMap(Type type) => Cache.GetOrAdd(type, Build);

    public static string ToFhirTypeName(Type type)
    {
        var name = type.Name;
        return name.StartsWith("Fhir", StringComparison.Ordinal) ? name[4..] : name;
    }

    public static Type? ResolveFhirType(string fhirTypeName)
        => FhirTypeByName.TryGetValue(fhirTypeName, out var type) ? type : null;

    public static bool IsPrimitive(Type type) => typeof(PrimitiveType).IsAssignableFrom(type);

    public static bool IsResource(Type type) => typeof(Resource).IsAssignableFrom(type);

    public static bool IsExtensionList(Type type)
    {
        var item = GetListItemType(type);
        return item == typeof(IExtension) || item == typeof(Extension);
    }

    public static Type? GetListItemType(Type type)
    {
        if (type.IsGenericType)
        {
            var def = type.GetGenericTypeDefinition();
            if (def == typeof(List<>) || def == typeof(IList<>) || def == typeof(IReadOnlyList<>))
                return type.GetGenericArguments()[0];
        }

        foreach (var iface in type.GetInterfaces())
        {
            if (iface.IsGenericType && iface.GetGenericTypeDefinition() == typeof(IList<>))
                return iface.GetGenericArguments()[0];
        }

        return null;
    }

    public static bool IsList(Type type) => GetListItemType(type) != null && type != typeof(string);

    public static string GetResourceTypeName(object instance)
    {
        var field = instance.GetType().GetField("ResourceTypeValue", BindingFlags.Public | BindingFlags.Static);
        if (field?.GetValue(null) is string name && name.Length > 0)
            return name;
        return instance.GetType().Name;
    }

    public static void SetPrimitiveString(object primitive, string? value)
    {
        var prop = primitive.GetType().GetProperty("StringValue");
        prop?.SetValue(primitive, value);
    }

    public static string? GetPrimitiveString(object primitive)
    {
        var prop = primitive.GetType().GetProperty("StringValue");
        return prop?.GetValue(primitive) as string;
    }

    public static object CreateInstance(Type type)
    {
        if (type == typeof(IExtension))
            return new Extension();
        if (type.IsInterface || type.IsAbstract)
            throw new InvalidOperationException($"Cannot create instance of {type.FullName}.");
        return Activator.CreateInstance(type)
               ?? throw new InvalidOperationException($"Activator returned null for {type.FullName}.");
    }

    public static IList CreateList(Type listType, Type itemType)
    {
        if (listType.IsInterface || listType.IsAbstract)
            return (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(itemType))!;
        return (IList)(Activator.CreateInstance(listType)
                       ?? Activator.CreateInstance(typeof(List<>).MakeGenericType(itemType))!);
    }

    public static void AddToList(object target, FhirXmlProperty property, object item)
    {
        var current = property.Property.GetValue(target);
        if (current is not IList list)
        {
            list = CreateList(property.Property.PropertyType, property.ItemType);
            property.Property.SetValue(target, list);
        }

        list.Add(item);
    }

    private static FhirXmlTypeMap Build(Type type)
    {
        var byName = new Dictionary<string, FhirXmlProperty>(StringComparer.Ordinal);
        foreach (var prop in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
        {
            if (prop.GetCustomAttribute<JsonIgnoreAttribute>() is not null)
                continue;
            if (prop.Name is "ResourceTypeJson" or "TypeName")
                continue;

            var jsonName = prop.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name ?? prop.Name;
            if (jsonName is "resourceType")
                continue;

            var itemType = GetListItemType(prop.PropertyType) ?? prop.PropertyType;
            byName[jsonName] = new FhirXmlProperty(jsonName, prop, itemType, IsList(prop.PropertyType));
        }

        return new FhirXmlTypeMap { ByElementName = byName };
    }
}
