using System.Reflection;
using Fhir.Artifacts;
using Fhir.Path.Abstractions;
using Fhir.Path.Navigation;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes;

namespace Fhir.Validation;

/// <summary>收入已 Parse 的 StructureDefinition／ValueSet（<see cref="Base"/>），不依賴各線別 Resources 組件。</summary>
public sealed class ProfileCatalog
{
    private readonly Dictionary<string, ProfileSnapshot> _profiles = new(StringComparer.Ordinal);
    private readonly Dictionary<string, ValueSetExpansion> _valueSets = new(StringComparer.Ordinal);

    public IReadOnlyDictionary<string, ProfileSnapshot> Profiles => _profiles;
    public IReadOnlyDictionary<string, ValueSetExpansion> ValueSets => _valueSets;

    public void AddFrom(IArtifactResolver resolver, Func<string, Base?> parse)
    {
        foreach (var doc in resolver.Enumerate())
        {
            var parsed = parse(doc.Json);
            if (parsed is not null)
                Add(parsed);
        }
    }

    public void Add(Base resource)
    {
        var typeName = GetResourceTypeName(resource);
        var url = ReadString(resource, "url");
        if (string.IsNullOrEmpty(url))
            return;

        if (string.Equals(typeName, "StructureDefinition", StringComparison.Ordinal))
            _profiles[url] = ExtractSnapshot(resource, url);
        else if (string.Equals(typeName, "ValueSet", StringComparison.Ordinal))
            _valueSets[url] = ExtractValueSet(resource, url);
    }

    public bool TryGetProfile(string canonical, out ProfileSnapshot snapshot)
        => _profiles.TryGetValue(StripVersion(canonical), out snapshot!)
           || _profiles.TryGetValue(canonical, out snapshot!);

    public bool TryGetValueSet(string canonical, out ValueSetExpansion expansion)
        => _valueSets.TryGetValue(StripVersion(canonical), out expansion!)
           || _valueSets.TryGetValue(canonical, out expansion!);

    private static string StripVersion(string canonical)
    {
        var pipe = canonical.IndexOf('|');
        return pipe < 0 ? canonical : canonical[..pipe];
    }

    private static ProfileSnapshot ExtractSnapshot(Base resource, string url)
    {
        var elements = new List<ElementDefinition>();
        var snapshot = GetProperty(resource, "Snapshot");
        var list = snapshot is null ? null : GetProperty(snapshot, "Element") as System.Collections.IEnumerable;
        if (list is not null)
        {
            foreach (var item in list)
            {
                if (item is ElementDefinition ed)
                    elements.Add(ed);
            }
        }

        return new ProfileSnapshot(url, ReadString(resource, "type"), elements);
    }

    private static ValueSetExpansion ExtractValueSet(Base resource, string url)
    {
        var codes = new HashSet<string>(StringComparer.Ordinal);
        var root = PocoElementNavigator.Wrap(resource);
        foreach (var include in Walk(root, "compose", "include"))
        {
            var system = FirstString(include, "system");
            foreach (var concept in include.Children("concept"))
            {
                var code = FirstString(concept, "code");
                if (!string.IsNullOrEmpty(code))
                    codes.Add(Key(system, code));
            }
        }

        return new ValueSetExpansion(url, codes);
    }

    private static IEnumerable<IFhirNode> Walk(IFhirNode root, params string[] path)
    {
        IEnumerable<IFhirNode> current = [root];
        foreach (var segment in path)
        {
            current = current.SelectMany(n => n.Children(segment)).ToList();
        }

        return current;
    }

    private static string? FirstString(IFhirNode node, string name)
        => node.Children(name).FirstOrDefault()?.GetValue()?.ToString();

    internal static string Key(string? system, string? code) => $"{system ?? ""}|{code ?? ""}";

    private static string? ReadString(object instance, string propertyName)
    {
        var value = GetProperty(instance, ToPascal(propertyName));
        return value switch
        {
            null => null,
            PrimitiveType p => p.GetType().GetProperty("StringValue")?.GetValue(p) as string,
            string s => s,
            _ => value.ToString()
        };
    }

    private static object? GetProperty(object instance, string name)
        => instance.GetType().GetProperty(name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase)
            ?.GetValue(instance);

    private static string ToPascal(string name)
        => name.Length == 0 ? name : char.ToUpperInvariant(name[0]) + name[1..];

    private static string GetResourceTypeName(Base resource)
    {
        var field = resource.GetType().GetField("ResourceTypeValue", BindingFlags.Public | BindingFlags.Static);
        if (field?.GetValue(null) is string name && name.Length > 0)
            return name;
        return resource.TypeName;
    }
}

public sealed record ProfileSnapshot(string Canonical, string? TypeName, IReadOnlyList<ElementDefinition> Elements);

public sealed record ValueSetExpansion(string Canonical, IReadOnlySet<string> Codes);
