using Fhir.Resources.R5;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;

namespace Fhir.Path.R5.Patch;

/// <summary>從 <see cref="Parameters"/> 讀取 FHIRPath Patch 操作。</summary>
public static class FhirPathPatchReader
{
    public static IReadOnlyList<PatchOperation> Read(Parameters parameters)
    {
        if (parameters.Parameter is null) return [];
        return parameters.Parameter
            .Where(p => string.Equals(p.Name?.StringValue, "operation", StringComparison.Ordinal))
            .Select(ReadOperation)
            .ToList();
    }

    private static PatchOperation ReadOperation(Parameters.ParameterComponent op)
    {
        var parts = op.Part ?? [];
        var dict = parts.ToDictionary(
            p => p.Name?.StringValue ?? "",
            p => p,
            StringComparer.OrdinalIgnoreCase);

        return new PatchOperation
        {
            Type = GetCode(dict, "type") ?? "",
            Path = GetString(dict, "path"),
            Name = GetString(dict, "name"),
            Value = dict.TryGetValue("value", out var v) ? ReadValue(v) : null,
            Index = GetInteger(dict, "index"),
            Source = GetInteger(dict, "source"),
            Destination = GetInteger(dict, "destination")
        };
    }

    private static string? GetCode(IReadOnlyDictionary<string, Parameters.ParameterComponent.ParameterPartComponent> dict, string key)
        => dict.TryGetValue(key, out var p) ? p.ValueCode?.StringValue ?? p.ValueString?.StringValue : null;

    private static string? GetString(IReadOnlyDictionary<string, Parameters.ParameterComponent.ParameterPartComponent> dict, string key)
        => dict.TryGetValue(key, out var p) ? p.ValueString?.StringValue : null;

    private static int? GetInteger(IReadOnlyDictionary<string, Parameters.ParameterComponent.ParameterPartComponent> dict, string key)
    {
        if (!dict.TryGetValue(key, out var p)) return null;
        if (p.ValueInteger?.Value is int i) return i;
        return int.TryParse(p.ValueString?.StringValue, out var parsed) ? parsed : null;
    }

    private static object? ReadValue(Parameters.ParameterComponent.ParameterPartComponent valuePart)
    {
        if (valuePart.Part is { Count: > 0 })
            return ReadAnonymous(valuePart.Part);

        return ReadTypedValue(valuePart);
    }

    private static Dictionary<string, object?> ReadAnonymous(List<Parameters.ParameterComponent.ParameterPartComponent> parts)
    {
        var result = new Dictionary<string, object?>(StringComparer.Ordinal);
        foreach (var part in parts)
        {
            var name = part.Name?.StringValue ?? "";
            if (part.Part is { Count: > 0 })
                result[name] = ReadAnonymous(part.Part);
            else
                result[name] = ReadTypedValue(part);
        }
        return result;
    }

    private static object? ReadTypedValue(Parameters.ParameterComponent.ParameterPartComponent p)
    {
        if (p.ValueBoolean is { } b) return b;
        if (p.ValueString is { } s) return s;
        if (p.ValueCode is { } c) return c;
        if (p.ValueDate is { } d) return d;
        if (p.ValueDateTime is { } dt) return dt;
        if (p.ValueInteger is { } i) return i;
        if (p.ValueCoding is { } coding) return coding;
        if (p.ValueReference is { } r) return r;
        if (p.ValueHumanname is { } hn) return hn;
        if (p.ValueQuantity is { } q) return q;
        return null;
    }
}
