using Fhir.Resources.R5;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;

namespace Fhir.Path.R5.Patch;

/// <summary>建構 FHIRPath Patch <see cref="Parameters"/> 資源。</summary>
public sealed class FhirPathPatchBuilder
{
    private readonly List<Parameters.ParameterComponent> _operations = [];

    public static FhirPathPatchBuilder Create() => new();

    public FhirPathPatchBuilder Add(string path, string name, object? value)
    {
        _operations.Add(BuildOperation("add", path, name, value, null, null, null));
        return this;
    }

    public FhirPathPatchBuilder Replace(string path, object? value)
    {
        _operations.Add(BuildOperation("replace", path, null, value, null, null, null));
        return this;
    }

    public FhirPathPatchBuilder Delete(string path)
    {
        _operations.Add(BuildOperation("delete", path, null, null, null, null, null));
        return this;
    }

    public Parameters BuildParameters() => new() { Parameter = _operations };

    private static Parameters.ParameterComponent BuildOperation(
        string type, string? path, string? name, object? value,
        int? index, int? source, int? destination)
    {
        var parts = new List<Parameters.ParameterComponent.ParameterPartComponent>
        {
            Part("type", type),
            Part("path", path)
        };
        if (name is not null) parts.Add(Part("name", name));
        if (value is not null) parts.Add(ValuePart(value));
        if (index is not null) parts.Add(Part("index", index.Value.ToString(), isInteger: true));
        if (source is not null) parts.Add(Part("source", source.Value.ToString(), isInteger: true));
        if (destination is not null) parts.Add(Part("destination", destination.Value.ToString(), isInteger: true));

        return new Parameters.ParameterComponent
        {
            Name = "operation".ToFhirString(),
            Part = parts
        };
    }

    private static Parameters.ParameterComponent.ParameterPartComponent Part(string name, string? value, bool isInteger = false)
    {
        var p = new Parameters.ParameterComponent.ParameterPartComponent { Name = name.ToFhirString() };
        if (isInteger && int.TryParse(value, out var i))
            p.ValueInteger = new Fhir.TypeFramework.DataTypes.FhirInteger(i);
        else if (name == "type")
            p.ValueCode = value?.ToFhirCode();
        else
            p.ValueString = value?.ToFhirString();
        return p;
    }

    private static Parameters.ParameterComponent.ParameterPartComponent ValuePart(object value)
    {
        var p = new Parameters.ParameterComponent.ParameterPartComponent { Name = "value".ToFhirString() };
        switch (value)
        {
            case Dictionary<string, object?> dict:
                p.Part = dict.Select(kv => AnonymousPart(kv.Key, kv.Value)).ToList();
                break;
            case Fhir.TypeFramework.Bases.Base b:
                AssignValue(p, b);
                break;
            default:
                p.ValueString = value.ToString()?.ToFhirString();
                break;
        }
        return p;
    }

    private static Parameters.ParameterComponent.ParameterPartComponent AnonymousPart(string name, object? value)
    {
        if (value is Dictionary<string, object?> dict)
        {
            return new Parameters.ParameterComponent.ParameterPartComponent
            {
                Name = name.ToFhirString(),
                Part = dict.Select(kv => AnonymousPart(kv.Key, kv.Value)).ToList()
            };
        }
        var p = new Parameters.ParameterComponent.ParameterPartComponent { Name = name.ToFhirString() };
        if (value is Fhir.TypeFramework.Bases.Base b) AssignValue(p, b);
        else p.ValueString = value?.ToString()?.ToFhirString();
        return p;
    }

    private static void AssignValue(Parameters.ParameterComponent.ParameterPartComponent p, Fhir.TypeFramework.Bases.Base value)
    {
        switch (value)
        {
            case Fhir.TypeFramework.DataTypes.FhirDate d: p.ValueDate = d; break;
            case Fhir.TypeFramework.DataTypes.FhirDateTime dt: p.ValueDateTime = dt; break;
            case Fhir.TypeFramework.DataTypes.FhirCode c: p.ValueCode = c; break;
            case FhirString s: p.ValueString = s; break;
            case Fhir.TypeFramework.DataTypes.Coding coding: p.ValueCoding = coding; break;
            default: p.ValueString = value.ToString()?.ToFhirString(); break;
        }
    }
}

file static class PatchBuilderStringExt
{
    public static FhirString ToFhirString(this string s) => new(s);
    public static Fhir.TypeFramework.DataTypes.FhirCode ToFhirCode(this string s) => new(s);
}
