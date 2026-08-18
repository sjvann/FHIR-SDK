using System.Collections.Concurrent;
using System.Collections;
using System.Reflection;
using System.Text.Json.Serialization;
using Fhir.TypeFramework.Choices;

namespace Fhir.TypeFramework.Metadata;

/// <summary>以 JsonPropertyName 反射建立 metadata；產生器尚未產出時的預設來源。</summary>
public sealed class ReflectionModelMetadataProvider : IModelMetadataProvider
{
    private readonly ConcurrentDictionary<Type, ModelTypeMetadata> _byType = new();
    private readonly ConcurrentDictionary<string, ModelTypeMetadata> _byName = new(StringComparer.Ordinal);

    public bool TryGet(Type clrType, out ModelTypeMetadata metadata)
    {
        metadata = _byType.GetOrAdd(clrType, Build);
        _byName.TryAdd(metadata.TypeName, metadata);
        return true;
    }

    public bool TryGet(string typeName, out ModelTypeMetadata metadata)
        => _byName.TryGetValue(typeName, out metadata!);

    public void Register(ModelTypeMetadata metadata)
    {
        _byName[metadata.TypeName] = metadata;
        if (metadata.ClrType is not null)
            _byType[metadata.ClrType] = metadata;
    }

    private static ModelTypeMetadata Build(Type type)
    {
        var elements = new List<ModelElementMetadata>();
        var seen = new HashSet<string>(StringComparer.Ordinal);

        foreach (var prop in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
        {
            if (prop.GetCustomAttribute<JsonIgnoreAttribute>() is not null)
                continue;
            if (prop.GetCustomAttribute<JsonExtensionDataAttribute>() is not null)
                continue;

            var jsonName = prop.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name;
            if (jsonName is null or "resourceType")
                continue;

            if (ChoiceElementNaming.TryGetChoiceStem(prop.Name, out var stem))
            {
                if (!seen.Add(stem))
                    continue;
                elements.Add(new ModelElementMetadata(
                    stem,
                    null,
                    IsCollection(prop.PropertyType),
                    IsChoice: true,
                    ChoiceTypes: [jsonName]));
                continue;
            }

            seen.Add(jsonName);
            elements.Add(new ModelElementMetadata(
                jsonName,
                UnwrapTypeName(prop.PropertyType),
                IsCollection(prop.PropertyType),
                IsChoice: false));
        }

        return new ModelTypeMetadata(type.Name, type, elements);
    }

    private static bool IsCollection(Type type)
        => type != typeof(string)
           && typeof(IEnumerable).IsAssignableFrom(type)
           && !typeof(Fhir.TypeFramework.Bases.Base).IsAssignableFrom(type);

    private static string? UnwrapTypeName(Type type)
    {
        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>))
            type = type.GetGenericArguments()[0];
        var name = type.Name;
        if (name.StartsWith("Fhir", StringComparison.Ordinal) && name.Length > 4)
            return char.ToLowerInvariant(name[4]) + name[5..];
        return name.TrimEnd('?');
    }
}
