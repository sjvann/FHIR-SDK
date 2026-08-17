using Fhir.Path.Abstractions;
using Fhir.Path.Navigation;
using Fhir.TypeFramework.Bases;

namespace Fhir.Validation;

internal static class InstancePathWalker
{
    public static IReadOnlyList<IFhirNode> Select(Base instance, string fhirPath)
    {
        var root = PocoElementNavigator.Wrap(instance);
        var segments = SplitPath(fhirPath);
        if (segments.Count == 0)
            return [root];

        IEnumerable<IFhirNode> current = [root];
        var start = 0;
        if (string.Equals(segments[0], root.TypeName, StringComparison.OrdinalIgnoreCase)
            || string.Equals(segments[0], instance.TypeName, StringComparison.OrdinalIgnoreCase)
            || string.Equals(segments[0], GetResourceType(instance), StringComparison.OrdinalIgnoreCase))
            start = 1;

        for (var i = start; i < segments.Count; i++)
        {
            var segment = segments[i];
            current = current.SelectMany(n => Children(n, segment)).ToList();
        }

        return current.ToList();
    }

    public static IReadOnlyList<IFhirNode> Children(IFhirNode node, string elementName)
    {
        if (elementName.EndsWith("[x]", StringComparison.Ordinal))
        {
            var stem = elementName[..^3];
            return node.AllChildren()
                .Where(c => c.Name.StartsWith(stem, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        var colon = elementName.IndexOf(':');
        if (colon >= 0)
            elementName = elementName[..colon];

        return node.Children(elementName);
    }

    public static IReadOnlyList<string> SplitPath(string fhirPath)
    {
        var parts = new List<string>();
        foreach (var raw in fhirPath.Split('.', StringSplitOptions.RemoveEmptyEntries))
        {
            var name = raw;
            var colon = name.IndexOf(':');
            if (colon >= 0)
                name = name[..colon];
            parts.Add(name);
        }

        return parts;
    }

    public static string? GetResourceType(Base instance)
    {
        var field = instance.GetType().GetField("ResourceTypeValue",
            System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
        return field?.GetValue(null) as string ?? instance.TypeName;
    }

    public static string? FhirTypeName(IFhirNode node)
    {
        if (node.Native is PrimitiveType p)
        {
            var n = p.GetType().Name;
            return n.StartsWith("Fhir", StringComparison.Ordinal) ? n[4..].ToLowerInvariant() : n.ToLowerInvariant();
        }

        return node.TypeName;
    }
}
