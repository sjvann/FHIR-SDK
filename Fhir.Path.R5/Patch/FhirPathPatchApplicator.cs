using System.Collections;
using Fhir.Path.Abstractions;
using Fhir.Path.Exceptions;
using Fhir.Path.Navigation;
using Fhir.Path.R5.Patch;
using Fhir.Resources.R5;
using Fhir.TypeFramework.Bases;

namespace Fhir.Path.R5.Patch;

/// <summary>將 FHIRPath Patch 套用至資源 POCO。</summary>
public static class FhirPathPatchApplicator
{
    public static void Apply(object resource, Parameters patch, IFhirPathEngine engine)
    {
        var ops = FhirPathPatchReader.Read(patch);
        object current = resource;
        foreach (var op in ops)
            current = ApplyOne(current, op, engine);
    }

    private static object ApplyOne(object resource, PatchOperation op, IFhirPathEngine engine)
    {
        return op.Type.ToLowerInvariant() switch
        {
            "add" => ApplyAdd(resource, op, engine),
            "insert" => ApplyInsert(resource, op, engine),
            "delete" => ApplyDelete(resource, op, engine),
            "replace" => ApplyReplace(resource, op, engine),
            "move" => ApplyMove(resource, op, engine),
            _ => throw FhirPathException.Runtime($"Unsupported patch operation '{op.Type}'.")
        };
    }

    private static object ApplyAdd(object resource, PatchOperation op, IFhirPathEngine engine)
    {
        var parent = PocoPatchWriter.ResolvePath(resource, op.Path ?? throw FhirPathException.Runtime("add requires path."));
        var value = MaterializeValue(op.Value, parent.Native!.GetType(), op.Name!);
        PocoPatchWriter.AddChild(parent, op.Name ?? throw FhirPathException.Runtime("add requires name."), value);
        return resource;
    }

    private static object ApplyInsert(object resource, PatchOperation op, IFhirPathEngine engine)
    {
        var listNode = PocoPatchWriter.ResolvePath(resource, op.Path ?? throw FhirPathException.Runtime("insert requires path."));
        if (listNode.Native is not IList list)
            throw FhirPathException.Runtime("insert path must resolve to a list.");
        var value = MaterializeValue(op.Value, list.GetType().GetGenericArguments()[0], null);
        PocoPatchWriter.InsertAt(list, op.Index ?? throw FhirPathException.Runtime("insert requires index."), value);
        return resource;
    }

    private static object ApplyDelete(object resource, PatchOperation op, IFhirPathEngine engine)
    {
        var node = PocoPatchWriter.ResolvePath(resource, op.Path ?? throw FhirPathException.Runtime("delete requires path."));
        PocoPatchWriter.DeleteNode(node);
        return resource;
    }

    private static object ApplyReplace(object resource, PatchOperation op, IFhirPathEngine engine)
    {
        var node = PocoPatchWriter.ResolvePath(resource, op.Path ?? throw FhirPathException.Runtime("replace requires path."));
        var value = MaterializeValue(op.Value, node.Native!.GetType(), null);
        PocoPatchWriter.ReplaceNode(node, value);
        return resource;
    }

    private static object ApplyMove(object resource, PatchOperation op, IFhirPathEngine engine)
    {
        var listNode = PocoPatchWriter.ResolvePath(resource, op.Path ?? throw FhirPathException.Runtime("move requires path."));
        if (listNode.Native is not IList list)
            throw FhirPathException.Runtime("move path must resolve to a list.");
        PocoPatchWriter.MoveInList(list, op.Source ?? 0, op.Destination ?? 0);
        return resource;
    }

    private static object? MaterializeValue(object? value, Type parentType, string? elementName)
    {
        if (value is Dictionary<string, object?> dict)
            return AnonymousTypeBuilder.Build(dict, parentType, elementName);
        return value;
    }
}
