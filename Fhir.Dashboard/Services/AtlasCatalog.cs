using System.Collections;
using System.Reflection;
using System.Text.Json.Serialization;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes;

namespace Fhir.Dashboard.Services;

public sealed class AtlasCatalog
{
    public IReadOnlyList<TypeEntry> Primitives { get; }
    public IReadOnlyList<TypeEntry> ComplexTypes { get; }
    public IReadOnlyList<TypeEntry> Types { get; }
    public IReadOnlyList<ResourceEntry> Resources { get; }
    public IReadOnlyList<string> Lines { get; } = OfficialDocs.Lines;

    public AtlasCatalog()
    {
        Primitives = ScanPrimitives();
        ComplexTypes = ScanComplexTypes();
        Types = Primitives.Concat(ComplexTypes).OrderBy(t => t.FhirName, StringComparer.OrdinalIgnoreCase).ToArray();
        Resources = ScanResources();
    }

    public TypeEntry? FindType(string fhirName)
        => Types.FirstOrDefault(t => t.FhirName.Equals(fhirName, StringComparison.OrdinalIgnoreCase));

    public ResourceEntry? FindResource(string resourceType)
        => Resources.FirstOrDefault(r => r.ResourceType.Equals(resourceType, StringComparison.OrdinalIgnoreCase));

    public IReadOnlyList<SearchHit> Suggest(string query, int take = 8)
    {
        var q = query.Trim();
        if (q.Length == 0)
            return [];

        return Types.Select(t => new SearchHit("type", t.FhirName, t.CsharpName, t.Kind.ToString()))
            .Concat(Resources.Select(r => new SearchHit("resource", r.ResourceType, r.CsharpName, string.Join(" ", r.Lines))))
            .Select(hit => (hit, score: Score(hit, q)))
            .Where(x => x.score > 0)
            .OrderByDescending(x => x.score)
            .ThenBy(x => x.hit.Name, StringComparer.OrdinalIgnoreCase)
            .Take(take)
            .Select(x => x.hit)
            .ToArray();
    }

    private static int Score(SearchHit hit, string query)
    {
        if (hit.Name.Equals(query, StringComparison.OrdinalIgnoreCase))
            return 100;
        if (hit.Name.StartsWith(query, StringComparison.OrdinalIgnoreCase))
            return 80;
        if (hit.Name.Contains(query, StringComparison.OrdinalIgnoreCase))
            return 60;
        if (hit.CsharpName.Contains(query, StringComparison.OrdinalIgnoreCase))
            return 40;
        return 0;
    }

    private static TypeEntry[] ScanPrimitives()
    {
        return typeof(PrimitiveType).Assembly
            .GetTypes()
            .Where(t => t is { IsPublic: true, IsAbstract: false, IsNested: false })
            .Where(t => t.Name.StartsWith("Fhir", StringComparison.Ordinal))
            .Where(t => t.IsAssignableTo(typeof(PrimitiveType)))
            .Select(t => new TypeEntry(
                FhirName: ToFhirPrimitiveName(t.Name),
                CsharpName: t.Name,
                Namespace: t.Namespace ?? "",
                Kind: TypeKind.Primitive,
                Summary: FirstDocLine(t),
                Members: ReadMembers(t)))
            .OrderBy(t => t.FhirName, StringComparer.OrdinalIgnoreCase)
            .ToArray();
    }

    private static TypeEntry[] ScanComplexTypes()
    {
        return typeof(HumanName).Assembly
            .GetTypes()
            .Where(t => t is { IsPublic: true, IsAbstract: false, IsNested: false })
            .Where(t => t.Namespace is "Fhir.TypeFramework.DataTypes")
            .Where(t => t.IsAssignableTo(typeof(ComplexTypeBase)))
            .Where(t => !t.Name.EndsWith("Component", StringComparison.Ordinal))
            .Select(t => new TypeEntry(
                FhirName: t.Name,
                CsharpName: t.Name,
                Namespace: t.Namespace ?? "",
                Kind: TypeKind.Complex,
                Summary: FirstDocLine(t),
                Members: ReadMembers(t)))
            .OrderBy(t => t.FhirName, StringComparer.OrdinalIgnoreCase)
            .ToArray();
    }

    private static ResourceEntry[] ScanResources()
    {
        var groups = new Dictionary<string, Dictionary<string, IReadOnlyList<MemberEntry>>>(StringComparer.OrdinalIgnoreCase);

        foreach (var (line, assembly) in LineAssemblies())
        {
            foreach (var type in assembly.GetTypes())
            {
                if (type is not { IsPublic: true, IsAbstract: false, IsNested: false })
                    continue;
                if (!type.IsAssignableTo(typeof(Resource)))
                    continue;
                var field = type.GetField("ResourceTypeValue", BindingFlags.Public | BindingFlags.Static);
                if (field?.GetValue(null) is not string resourceType || string.IsNullOrWhiteSpace(resourceType))
                    continue;

                if (!groups.TryGetValue(resourceType, out var byLine))
                {
                    byLine = new Dictionary<string, IReadOnlyList<MemberEntry>>(StringComparer.Ordinal);
                    groups[resourceType] = byLine;
                }

                byLine[line] = ReadMembers(type);
            }
        }

        return groups
            .Select(pair => new ResourceEntry(
                ResourceType: pair.Key,
                CsharpName: pair.Key,
                Lines: OfficialDocs.Lines.Where(pair.Value.ContainsKey).ToArray(),
                MembersByLine: pair.Value))
            .OrderBy(r => r.ResourceType, StringComparer.OrdinalIgnoreCase)
            .ToArray();
    }

    private static IEnumerable<(string Line, Assembly Assembly)> LineAssemblies()
    {
        yield return ("R4", typeof(Fhir.Resources.R4.Patient).Assembly);
        yield return ("R4B", typeof(Fhir.Resources.R4B.Patient).Assembly);
        yield return ("R5", typeof(Fhir.Resources.R5.Patient).Assembly);
    }

    private static IReadOnlyList<MemberEntry> ReadMembers(Type type)
    {
        return type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
            .Where(p => p.GetIndexParameters().Length == 0)
            .Select(p =>
            {
                var json = p.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name ?? ToCamel(p.Name);
                var (typeName, collection) = DescribeType(p.PropertyType);
                return new MemberEntry(json, p.Name, typeName, collection);
            })
            .OrderBy(m => m.JsonName, StringComparer.OrdinalIgnoreCase)
            .ToArray();
    }

    private static (string TypeName, bool Collection) DescribeType(Type type)
    {
        var unwrap = Nullable.GetUnderlyingType(type) ?? type;
        if (unwrap != typeof(string) && typeof(IEnumerable).IsAssignableFrom(unwrap) && unwrap.IsGenericType)
        {
            var item = unwrap.GetGenericArguments()[0];
            return (ShortName(item), true);
        }

        return (ShortName(unwrap), false);
    }

    private static string ShortName(Type type)
    {
        if (type.IsGenericType)
        {
            var args = string.Join(", ", type.GetGenericArguments().Select(ShortName));
            return $"{type.Name.Split('`')[0]}<{args}>";
        }

        return type.Name;
    }

    private static string ToFhirPrimitiveName(string csharpName)
    {
        var name = csharpName.StartsWith("Fhir", StringComparison.Ordinal) ? csharpName[4..] : csharpName;
        if (name.Length == 0)
            return name;
        return char.ToLowerInvariant(name[0]) + name[1..];
    }

    private static string ToCamel(string name)
        => name.Length == 0 ? name : char.ToLowerInvariant(name[0]) + name[1..];

    private static string? FirstDocLine(Type type)
    {
        // XML docs are not loaded at runtime; keep a short framework hint from type name.
        return type.Namespace?.EndsWith("PrimitiveTypes", StringComparison.Ordinal) == true
            ? "TypeFramework primitive"
            : "TypeFramework complex type";
    }
}

public sealed record SearchHit(string Kind, string Name, string CsharpName, string Meta);
