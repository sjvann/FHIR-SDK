using System.Collections;
using System.Reflection;
using System.Text.Json.Serialization;
using Fhir.Path.Abstractions;
using Fhir.Path.Exceptions;
using Fhir.TypeFramework.Bases;

namespace Fhir.Path.Navigation;

/// <summary>對 POCO 圖進行 FHIRPath Patch 寫入。</summary>
public static class PocoPatchWriter
{
    public static IFhirNode ResolvePath(object root, string pathExpression, FhirPathEvaluationContext? ctx = null)
    {
        var engine = new Evaluation.FhirPathEngine();
        var nodes = engine.EvaluateNodes(pathExpression, root, ctx);
        if (nodes.Count != 1)
            throw FhirPathException.Runtime($"Path '{pathExpression}' must resolve to a single element for patch.");
        return nodes[0];
    }

    public static void AddChild(IFhirNode parent, string name, object? value)
    {
        if (parent.Native is null) throw FhirPathException.Runtime("Cannot add to null parent.");
        var meta = ElementMetadataCache.Get(parent.Native.GetType());

        if (meta.Elements.TryGetValue(name, out var binding) && binding.IsChoice)
        {
            SetChoiceMember(parent.Native, binding, value);
            return;
        }

        if (!meta.Elements.TryGetValue(name, out binding) || binding.Property is null)
            throw FhirPathException.Runtime($"Element '{name}' not found on {parent.Native.GetType().Name}.");

        SetProperty(parent.Native, binding.Property, value);
    }

    public static void ReplaceNode(IFhirNode node, object? value)
    {
        if (node.Parent?.Native is null) throw FhirPathException.Runtime("Cannot replace root.");
        var parent = node.Parent;
        var meta = ElementMetadataCache.Get(parent.Native!.GetType());
        var prop = meta.Elements.Values.FirstOrDefault(b =>
            !b.IsChoice && b.Property is not null && ReferenceEquals(b.Property.GetValue(parent.Native), node.Native));

        if (prop?.Property is null)
            throw FhirPathException.Runtime("Could not locate property for replace.");

        prop.Property.SetValue(parent.Native, value);
    }

    public static void DeleteNode(IFhirNode node)
    {
        if (node.Parent?.Native is null) throw FhirPathException.Runtime("Cannot delete root.");
        var parent = node.Parent;
        var meta = ElementMetadataCache.Get(parent.Native!.GetType());

        foreach (var binding in meta.Elements.Values)
        {
            if (binding.IsChoice)
            {
                foreach (var m in binding.ChoiceMembers!)
                {
                    if (ReferenceEquals(m.Property!.GetValue(parent.Native), node.Native))
                    {
                        m.Property.SetValue(parent.Native, null);
                        return;
                    }
                }
            }
            else if (binding.Property is not null)
            {
                var current = binding.Property.GetValue(parent.Native);
                if (ReferenceEquals(current, node.Native))
                {
                    binding.Property.SetValue(parent.Native, null);
                    return;
                }
                if (current is IList list)
                {
                    for (var i = 0; i < list.Count; i++)
                    {
                        if (ReferenceEquals(list[i], node.Native))
                        {
                            list.RemoveAt(i);
                            return;
                        }
                    }
                }
            }
        }
        throw FhirPathException.Runtime("Could not delete node.");
    }

    public static void InsertAt(IList list, int index, object? value)
    {
        if (index < 0 || index > list.Count)
            throw FhirPathException.Runtime($"Insert index {index} out of range.");
        if (value is null) throw FhirPathException.Runtime("Cannot insert null.");
        list.Insert(index, value);
    }

    public static void MoveInList(IList list, int source, int destination)
    {
        if (source < 0 || source >= list.Count || destination < 0 || destination >= list.Count)
            throw FhirPathException.Runtime("Move indices out of range.");
        var item = list[source]!;
        list.RemoveAt(source);
        list.Insert(destination, item);
    }

    private static void SetProperty(object target, PropertyInfo prop, object? value)
    {
        if (value is null)
        {
            prop.SetValue(target, null);
            return;
        }

        if (typeof(IList).IsAssignableFrom(prop.PropertyType) && prop.PropertyType.IsGenericType)
        {
            var list = prop.GetValue(target) as IList;
            if (list is null)
            {
                list = Activator.CreateInstance(prop.PropertyType) as IList
                    ?? throw FhirPathException.Runtime($"Cannot create list for {prop.Name}.");
                prop.SetValue(target, list);
            }
            list.Add(value);
            return;
        }

        prop.SetValue(target, value);
    }

    private static void SetChoiceMember(object target, ElementBinding binding, object? value)
    {
        if (value is null) return;
        var valueType = value.GetType();
        foreach (var member in binding.ChoiceMembers!)
        {
            if (member.Property!.PropertyType.IsAssignableFrom(valueType))
            {
                member.Property.SetValue(target, value);
                return;
            }
        }
        throw FhirPathException.Runtime($"No choice variant on '{binding.ElementName}' for type {valueType.Name}.");
    }
}
