using System.Collections;
using System.Reflection;
using Fhir.Artifacts;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes;

namespace Fhir.Validation.Snapshot;

/// <summary>
/// 將 StructureDefinition.differential 合併為 snapshot。
/// 已有 snapshot.element 時原樣回傳；否則以 baseDefinition（經 resolver）為底再 overlay。
/// </summary>
public sealed class SnapshotGenerator
{
    private readonly IArtifactResolver? _resolver;
    private readonly Func<string, Base?>? _parse;

    public SnapshotGenerator(IArtifactResolver? resolver = null, Func<string, Base?>? parse = null)
    {
        _resolver = resolver;
        _parse = parse;
    }

    public Base Generate(Base structureDefinition)
    {
        var existing = ReadElementList(GetProperty(structureDefinition, "Snapshot"));
        if (existing is { Count: > 0 })
            return structureDefinition;

        var differential = ReadElementList(GetProperty(structureDefinition, "Differential")) ?? [];
        var merged = new List<ElementDefinition>();

        var baseUrl = ReadString(structureDefinition, "BaseDefinition") ?? ReadString(structureDefinition, "baseDefinition");
        if (!string.IsNullOrEmpty(baseUrl) && _resolver is not null && _parse is not null
            && _resolver.TryResolve(baseUrl, out var baseDoc))
        {
            var baseSd = _parse(baseDoc.Json);
            if (baseSd is not null)
            {
                var generated = Generate(baseSd);
                var baseElements = ReadElementList(GetProperty(generated, "Snapshot"));
                if (baseElements is not null)
                    merged.AddRange(baseElements);
            }
        }

        Overlay(merged, differential);
        WriteSnapshot(structureDefinition, merged);
        return structureDefinition;
    }

    private static void Overlay(List<ElementDefinition> snapshot, List<ElementDefinition> differential)
    {
        foreach (var diff in differential)
        {
            var path = diff.Path?.StringValue;
            if (string.IsNullOrEmpty(path))
                continue;

            var index = snapshot.FindIndex(e => string.Equals(e.Path?.StringValue, path, StringComparison.Ordinal)
                                                && string.Equals(e.SliceName?.StringValue, diff.SliceName?.StringValue, StringComparison.Ordinal));
            if (index >= 0)
                snapshot[index] = MergeElement(snapshot[index], diff);
            else
                snapshot.Add(diff);
        }
    }

    private static ElementDefinition MergeElement(ElementDefinition current, ElementDefinition overlay)
    {
        var merged = (ElementDefinition)current.DeepCopy();
        if (overlay.Min is not null) merged.Min = overlay.Min;
        if (overlay.Max is not null) merged.Max = overlay.Max;
        if (overlay.Type is { Count: > 0 }) merged.Type = overlay.Type;
        if (overlay.Binding is not null) merged.Binding = overlay.Binding;
        if (overlay.Constraint is { Count: > 0 }) merged.Constraint = overlay.Constraint;
        if (overlay.Slicing is not null) merged.Slicing = overlay.Slicing;
        if (overlay.FixedCode is not null) merged.FixedCode = overlay.FixedCode;
        if (overlay.FixedUri is not null) merged.FixedUri = overlay.FixedUri;
        if (overlay.FixedString is not null) merged.FixedString = overlay.FixedString;
        if (overlay.FixedBoolean is not null) merged.FixedBoolean = overlay.FixedBoolean;
        if (overlay.FixedInteger is not null) merged.FixedInteger = overlay.FixedInteger;
        if (overlay.PatternCoding is not null) merged.PatternCoding = overlay.PatternCoding;
        if (overlay.PatternCodeableConcept is not null) merged.PatternCodeableConcept = overlay.PatternCodeableConcept;
        if (overlay.PatternString is not null) merged.PatternString = overlay.PatternString;
        if (overlay.SliceName is not null) merged.SliceName = overlay.SliceName;
        return merged;
    }

    private static void WriteSnapshot(Base structureDefinition, List<ElementDefinition> elements)
    {
        var snapshot = GetProperty(structureDefinition, "Snapshot");
        if (snapshot is null)
        {
            var snapType = structureDefinition.GetType().GetNestedType("SnapshotComponent");
            if (snapType is null)
                return;
            snapshot = Activator.CreateInstance(snapType);
            SetProperty(structureDefinition, "Snapshot", snapshot);
        }

        if (snapshot is not null)
            SetProperty(snapshot, "Element", elements);
    }

    private static List<ElementDefinition>? ReadElementList(object? component)
    {
        if (component is null)
            return null;
        if (GetProperty(component, "Element") is not IEnumerable list)
            return null;

        var elements = new List<ElementDefinition>();
        foreach (var item in list)
        {
            if (item is ElementDefinition ed)
                elements.Add(ed);
        }

        return elements;
    }

    private static string? ReadString(object instance, string propertyName)
    {
        var value = GetProperty(instance, propertyName);
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

    private static void SetProperty(object instance, string name, object? value)
        => instance.GetType().GetProperty(name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase)
            ?.SetValue(instance, value);
}
