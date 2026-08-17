using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using Fhir.Path.Abstractions;
using Fhir.Path.Navigation;
using Fhir.TypeFramework.DataTypes;

namespace Fhir.Path.R4.XQuery;

/// <summary><c>application/x-fhir-query</c> — 將 <c>{{ FHIRPath }}</c> 代入 REST 搜尋字串。</summary>
public static partial class FhirXQuery
{
    [GeneratedRegex(@"\{\{(.+?)\}\}", RegexOptions.Singleline)]
    private static partial Regex ExpressionPattern();

    public static string Resolve(
        string query,
        IFhirPathEngine engine,
        FhirPathEvaluationContext ctx,
        bool percentEncode = false)
    {
        var defaultRoot = ctx.Variables.Values.FirstOrDefault() ?? PocoElementNavigator.Wrap(null);
        return ExpressionPattern().Replace(query, match =>
        {
            var expr = match.Groups[1].Value.Trim();
            var evalRoot = ResolveContextRoot(expr, ctx) ?? defaultRoot;
            var collection = engine.Evaluate(expr, evalRoot, ctx);
            var substituted = expr.EndsWith(".id", StringComparison.Ordinal) && evalRoot.Native is TypeFramework.Bases.Base res
                ? $"{res.GetType().Name}/{collection.FirstOrDefault()}"
                : SubstituteCollection(collection);
            return percentEncode ? Uri.EscapeDataString(substituted) : substituted;
        });
    }

    public static string Resolve(
        string query,
        IFhirPathEngine engine,
        object? contextResource,
        FhirPathEvaluationContext ctx,
        bool percentEncode = false)
    {
        if (contextResource is not null)
            ctx.SetVariable("patient", PocoElementNavigator.Wrap(contextResource));

        var root = contextResource is not null
            ? PocoElementNavigator.Wrap(contextResource)
            : ctx.Variables.Values.FirstOrDefault() ?? PocoElementNavigator.Wrap(null);

        return ExpressionPattern().Replace(query, match =>
        {
            var expr = match.Groups[1].Value.Trim();
            var evalRoot = ResolveContextRoot(expr, ctx) ?? root;
            var collection = engine.Evaluate(expr, evalRoot, ctx);
            var substituted = expr.EndsWith(".id", StringComparison.Ordinal) && evalRoot.Native is TypeFramework.Bases.Base res
                ? $"{res.GetType().Name}/{collection.FirstOrDefault()}"
                : SubstituteCollection(collection);
            return percentEncode ? Uri.EscapeDataString(substituted) : substituted;
        });
    }

    private static Abstractions.IFhirNode? ResolveContextRoot(string expr, FhirPathEvaluationContext ctx)
    {
        if (!expr.StartsWith('%')) return null;
        var path = expr.TrimStart('%');
        var varName = path.Contains('.') ? path[..path.IndexOf('.')] : path;
        return ctx.TryGetVariable(varName, out var node) ? node : null;
    }

    private static string SubstituteCollection(FhirPathCollection collection)
    {
        if (collection.Count == 0) return "";
        if (collection.Count == 1) return SubstituteValue(collection[0]);

        return string.Join(",", collection.Select(SubstituteValue));
    }

    private static string SubstituteValue(object? value)
    {
        if (value is TypeFramework.Bases.Base resource
            && resource.GetType().GetProperty("Id")?.GetValue(resource) is TypeFramework.DataTypes.FhirId fhirId)
        {
            var typeName = resource.GetType().Name;
            var idVal = fhirId.StringValue ?? "";
            if (!string.IsNullOrEmpty(idVal) && !idVal.Contains('/'))
                return $"{typeName}/{idVal}";
        }

        return value switch
        {
            null => "",
            Coding coding => TokenFormat(coding.System?.StringValue, coding.Code?.StringValue),
            CodeableConcept cc => string.Join(",",
                (cc.Coding ?? []).Select(c => SubstituteValue(c))),
            Identifier id => TokenFormat(id.System?.StringValue, id.Value?.StringValue),
            Reference r => r.ReferenceValue?.StringValue ?? "",
            Quantity q => QuantityFormat(q),
            bool b => b ? "true" : "false",
            DateOnly d => d.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
            DateTime dt => dt.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
            _ => value.ToString() ?? ""
        };
    }

    private static string TokenFormat(string? system, string? code)
    {
        if (string.IsNullOrEmpty(system)) return code ?? "";
        return $"{system}|{code}";
    }

    private static string QuantityFormat(Quantity q)
    {
        var sb = new StringBuilder();
        if (q.Value?.StringValue is { } v) sb.Append(v);
        if (q.Comparator?.StringValue is { } cmp) sb.Append(cmp);
        if (q.System?.StringValue is { } sys && q.Code?.StringValue is { } c)
            sb.Append('|').Append(sys).Append('|').Append(c);
        else if (q.Unit?.StringValue is { } unit)
            sb.Append(unit);
        return sb.ToString();
    }
}
