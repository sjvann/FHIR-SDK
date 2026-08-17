using System.Reflection;
using Fhir.TypeFramework.Choices;

namespace FhirResourceCreator.Generation;

/// <summary>自已編譯的資源組件反射產生 choice helper（無需重跑 Registry）。</summary>
public static class ChoiceHelperReflectionGenerator
{
    public static string? Generate(Type clrType, string? rootNamespace = null)
    {
        if (clrType.ContainsGenericParameters || clrType.IsInterface)
            return null;

        var bindingGroups = ChoiceBindingCache.GetGroups(clrType);
        if (bindingGroups.Count == 0)
            return null;

        rootNamespace ??= clrType.Namespace
            ?? throw new InvalidOperationException($"Type {clrType.FullName} has no namespace.");

        var classNames = GetDeclaringChain(clrType).Select(t => t.Name).ToList();
        var emitGroups = bindingGroups.Values
            .Select(g => new ChoiceEmitGroup(
                g.ElementName,
                g.Members.Select(m => new ChoiceEmitMember(
                    m.JsonName,
                    m.TypeSuffix,
                    GetClrTypeName(m.Property.PropertyType))).ToList()))
            .ToList();

        return ChoiceHelperCodeEmitter.Generate(rootNamespace, classNames, emitGroups);
    }

    public static string GetOutputFileName(Type clrType)
    {
        if (clrType.DeclaringType is null)
            return $"{clrType.Name}.Choice.generated.cs";

        var parts = new List<string>();
        for (var t = clrType; t is not null; t = t.DeclaringType)
            parts.Add(t.Name);
        parts.Reverse();
        return string.Join('.', parts) + ".Choice.generated.cs";
    }

    private static List<Type> GetDeclaringChain(Type type)
    {
        var list = new List<Type>();
        for (var t = type; t is not null; t = t.DeclaringType)
            list.Add(t);
        list.Reverse();
        return list;
    }

    private static string GetClrTypeName(Type propertyType)
    {
        var t = Nullable.GetUnderlyingType(propertyType) ?? propertyType;
        if (t.IsGenericType)
        {
            var def = t.GetGenericTypeDefinition();
            if (def == typeof(List<>))
                return $"List<{GetClrTypeName(t.GetGenericArguments()[0])}>";
            if (def.FullName?.StartsWith("System.Collections.Generic.IList", StringComparison.Ordinal) == true)
                return $"IList<{GetClrTypeName(t.GetGenericArguments()[0])}>";
        }

        if (t.Namespace == "Fhir.TypeFramework.DataTypes" && t.Name == "Range")
            return "global::Fhir.TypeFramework.DataTypes.Range";
        if (t.Namespace?.StartsWith("Fhir.TypeFramework", StringComparison.Ordinal) == true)
            return t.Name;
        return t.Name;
    }
}
