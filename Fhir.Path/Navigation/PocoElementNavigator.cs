using System.Collections;
using Fhir.Path.Abstractions;
using Fhir.TypeFramework.Bases;

namespace Fhir.Path.Navigation;

/// <summary>以 POCO + JsonPropertyName 對應 FHIR 邏輯模型的節點導覽器。</summary>
public static class PocoElementNavigator
{
    public static IFhirNode Wrap(object? native, string? name = null, IFhirNode? parent = null)
    {
        if (native is null)
            return new NullFhirNode(name ?? "null", parent);

        if (native is IFhirNode existing)
            return existing;

        if (IsPrimitiveNode(native))
            return new PrimitiveFhirNode(name ?? GetPrimitiveName(native), native, parent);

        return new ComplexFhirNode(name ?? native.GetType().Name, native, parent);
    }

    public static IReadOnlyList<IFhirNode> WrapCollection(IEnumerable? items, string elementName, IFhirNode? parent)
    {
        if (items is null) return [];
        var list = new List<IFhirNode>();
        foreach (var item in items)
            list.Add(Wrap(item, elementName, parent));
        return list;
    }

    internal static bool IsPrimitiveNode(object native)
        => native is PrimitiveType;

    internal static string GetPrimitiveName(object native)
        => native.GetType().Name switch
        {
            var n when n.StartsWith("Fhir", StringComparison.Ordinal) => n[4..],
            _ => native.GetType().Name
        };

    internal static object? GetPrimitiveValue(object native)
    {
        if (native is not PrimitiveType) return native;
        var prop = native.GetType().GetProperty("StringValue");
        return prop?.GetValue(native) ?? native;
    }
}

public sealed class NullFhirNode(string name, IFhirNode? parent) : IFhirNode
{
    public string Name { get; } = name;
    public object? Native => null;
    public IFhirNode? Parent { get; } = parent;
    public bool IsPrimitive => false;
    public string? TypeName => null;
    public int Count => 0;
    public IReadOnlyList<IFhirNode> Children(string elementName) => [];
    public IReadOnlyList<IFhirNode> AllChildren() => [];
    public IFhirNode? AtIndex(int index) => null;
    public object? GetValue() => null;
}

internal class ComplexFhirNode : IFhirNode
{
    private readonly TypeMetadata _meta;

    public ComplexFhirNode(string name, object native, IFhirNode? parent)
    {
        Name = name;
        Native = native;
        Parent = parent;
        _meta = ElementMetadataCache.Get(native.GetType());
    }

    public string Name { get; }
    public object? Native { get; }
    public IFhirNode? Parent { get; }
    public bool IsPrimitive => false;
    public string? TypeName => Native?.GetType().Name;
    public int Count => 1;

    public IReadOnlyList<IFhirNode> Children(string elementName)
    {
        if (Native is null) return [];

        if (string.Equals(elementName, "contained", StringComparison.OrdinalIgnoreCase))
            return ResolveContained();

        if (!_meta.Elements.TryGetValue(elementName, out var binding))
            return ResolveOverflow(elementName);

        if (binding.IsChoice)
            return ResolveChoice(binding);

        var value = binding.Property!.GetValue(Native);
        return ToChildNodes(elementName, value);
    }

    public IReadOnlyList<IFhirNode> AllChildren()
    {
        var result = new List<IFhirNode>();
        foreach (var key in _meta.Elements.Keys)
            result.AddRange(Children(key));
        if (Native is Base b && b.Overflow is not null)
        {
            foreach (var name in b.Overflow.Keys)
                result.AddRange(ResolveOverflow(name));
        }
        return result;
    }

    public IFhirNode? AtIndex(int index)
    {
        if (index != 0) return null;
        return this;
    }

    public object? GetValue() => Native;

    private IReadOnlyList<IFhirNode> ResolveContained()
    {
        var prop = Native!.GetType().GetProperty("Contained");
        if (prop?.GetValue(Native) is not IEnumerable contained) return [];

        var nodes = new List<IFhirNode>();
        foreach (var res in contained)
        {
            if (res is null) continue;
            nodes.Add(PocoElementNavigator.Wrap(res, res.GetType().Name, this));
        }
        return nodes;
    }

    private IReadOnlyList<IFhirNode> ResolveChoice(ElementBinding binding)
    {
        var nodes = new List<IFhirNode>();
        foreach (var member in binding.ChoiceMembers!)
        {
            var value = member.Property!.GetValue(Native);
            if (value is null) continue;
            nodes.AddRange(ToChildNodes(binding.ElementName, value));
        }
        return nodes;
    }

    private IReadOnlyList<IFhirNode> ResolveOverflow(string elementName)
    {
        if (Native is not Base b || b.Overflow is null)
            return [];
        if (!b.Overflow.TryGetValue(elementName, out var el))
            return [];
        return [PocoElementNavigator.Wrap(el.ValueKind == System.Text.Json.JsonValueKind.String ? el.GetString() : el.GetRawText(), elementName, this)];
    }

    private IReadOnlyList<IFhirNode> ToChildNodes(string elementName, object? value)
    {
        if (value is null) return [];

        if (value is IEnumerable list and not string and not PrimitiveType)
        {
            var nodes = new List<IFhirNode>();
            foreach (var item in list)
                nodes.Add(PocoElementNavigator.Wrap(item, elementName, this));
            return nodes;
        }

        return [PocoElementNavigator.Wrap(value, elementName, this)];
    }
}

internal sealed class PrimitiveFhirNode : IFhirNode
{
    public PrimitiveFhirNode(string name, object native, IFhirNode? parent)
    {
        Name = name;
        Native = native;
        Parent = parent;
    }

    public string Name { get; }
    public object? Native { get; }
    public IFhirNode? Parent { get; }
    public bool IsPrimitive => true;
    public string? TypeName => Name;
    public int Count => 1;
    public IReadOnlyList<IFhirNode> Children(string elementName) => [];
    public IReadOnlyList<IFhirNode> AllChildren() => [];
    public IFhirNode? AtIndex(int index) => index == 0 ? this : null;
    public object? GetValue() => PocoElementNavigator.GetPrimitiveValue(Native!);
}
