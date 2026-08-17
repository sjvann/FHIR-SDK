using Fhir.Path.Abstractions;
using Fhir.Path.Ast;
using Fhir.Path.Exceptions;
using Fhir.Path.Navigation;
using Fhir.Path.Parsing;
using Fhir.TypeFramework.Bases;
using Element = Fhir.TypeFramework.Bases.Element;

namespace Fhir.Path.Evaluation;

public sealed class FhirPathFunctionRegistry
{
    private readonly Dictionary<string, FhirPathFunction> _functions;

    public FhirPathFunctionRegistry()
    {
        _functions = new Dictionary<string, FhirPathFunction>(StringComparer.OrdinalIgnoreCase)
        {
            ["where"] = Where,
            ["select"] = Select,
            ["repeat"] = Repeat,
            ["exists"] = Exists,
            ["empty"] = Empty,
            ["count"] = Count,
            ["distinct"] = Distinct,
            ["first"] = First,
            ["iif"] = Iif,
            ["not"] = NotFunc,
            ["today"] = Today,
            ["now"] = Now,
            ["substring"] = Substring,
            ["startsWith"] = StartsWith,
            ["endsWith"] = EndsWith,
            ["matches"] = Matches,
            ["replace"] = Replace,
            ["toString"] = ToStringFunc,
            ["extension"] = Extension,
            ["resolve"] = Resolve,
            ["ofType"] = OfType,
            ["length"] = Length,
            ["item"] = Item,
            ["trace"] = Trace,
        };
    }

    public IReadOnlyCollection<string> FunctionNames => _functions.Keys;

    public bool TryInvoke(string name, IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args,
        FhirPathEvaluationContext ctx, out object? result)
    {
        if (_functions.TryGetValue(name, out var fn))
        {
            result = fn(focus, args, ctx);
            return true;
        }
        result = null;
        return false;
    }

    private static object? Where(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
    {
        var predicate = GetLambda(args, 0);
        var evaluator = new FhirPathEvaluator(CreateDefaultRegistry());
        var kept = new List<IFhirNode>();
        foreach (var node in focus)
        {
            var r = evaluator.Evaluate(predicate, [node], ctx);
            if (r.Count > 0 && CoerceBool(r[0])) kept.Add(node);
        }
        return kept;
    }

    private static object? Select(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
    {
        var proj = GetLambda(args, 0);
        var evaluator = new FhirPathEvaluator(CreateDefaultRegistry());
        var results = new List<IFhirNode>();
        foreach (var node in focus)
        {
            var r = evaluator.Evaluate(proj, [node], ctx);
            results.AddRange(CoerceNodesFromCollection(r));
        }
        return results;
    }

    private static object? Repeat(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => Select(focus, args, ctx);

    private static object? Exists(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => focus.Count > 0;

    private static object? Empty(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => focus.Count == 0;

    private static object? Count(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => focus.Count;

    private static object? Distinct(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => focus.GroupBy(n => n.GetValue()?.ToString() ?? n.Native?.GetType().FullName).Select(g => g.First()).ToList();

    private static object? First(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => focus.Count == 0 ? new List<IFhirNode>() : new List<IFhirNode> { focus[0] };

    private static object? Iif(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
    {
        if (args.Count < 3) throw FhirPathException.Runtime("iif requires 3 arguments.");
        var condition = CoerceBool(args[0]);
        var branch = condition ? args[1] : args[2];
        if (branch is FhirPathExpression expr)
        {
            var evaluator = new FhirPathEvaluator(CreateDefaultRegistry());
            return evaluator.Evaluate(expr, focus, ctx);
        }
        return branch;
    }

    private static object? NotFunc(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => !CoerceBool(args[0]);

    private static object? Today(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => DateOnly.FromDateTime(ctx.Clock().Date);

    private static object? Now(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => ctx.Clock().UtcDateTime;

    private static object? Substring(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
    {
        var s = focus.FirstOrDefault()?.GetValue()?.ToString() ?? "";
        var start = Convert.ToInt32(args[0]);
        if (args.Count > 1)
        {
            var len = Convert.ToInt32(args[1]);
            return s.Substring(start, Math.Min(len, s.Length - start));
        }
        return s[start..];
    }

    private static object? StartsWith(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => (focus.FirstOrDefault()?.GetValue()?.ToString() ?? "").StartsWith(args[0]?.ToString() ?? "", StringComparison.Ordinal);

    private static object? EndsWith(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => (focus.FirstOrDefault()?.GetValue()?.ToString() ?? "").EndsWith(args[0]?.ToString() ?? "", StringComparison.Ordinal);

    private static object? Matches(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => System.Text.RegularExpressions.Regex.IsMatch(focus.FirstOrDefault()?.GetValue()?.ToString() ?? "", args[0]?.ToString() ?? "");

    private static object? Replace(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
    {
        var s = focus.FirstOrDefault()?.GetValue()?.ToString() ?? "";
        return s.Replace(args[0]?.ToString() ?? "", args[1]?.ToString() ?? "");
    }

    private static object? ToStringFunc(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => focus.FirstOrDefault()?.GetValue()?.ToString() ?? "";

    private static object? Extension(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
    {
        var url = args[0]?.ToString() ?? "";
        var results = new List<IFhirNode>();
        foreach (var node in focus)
        {
            if (node.Native is not Element el || el.Extension is null) continue;
            foreach (var ext in el.Extension)
            {
                if (string.Equals(ext.Url?.ToString(), url, StringComparison.Ordinal))
                    results.Add(PocoElementNavigator.Wrap(ext, "extension", node));
            }
        }
        return results;
    }

    private static object? Resolve(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
    {
        var root = FindRoot(focus.FirstOrDefault());
        if (root?.Native is not { } resource) return new List<IFhirNode>();
        var containedProp = resource.GetType().GetProperty("Contained");
        if (containedProp?.GetValue(resource) is not System.Collections.IEnumerable contained) return new List<IFhirNode>();

        var refVal = focus.FirstOrDefault()?.GetValue()?.ToString();
        foreach (var c in contained)
        {
            if (c is null) continue;
            var idProp = c.GetType().GetProperty("Id");
            var id = idProp?.GetValue(c)?.ToString();
            if (refVal is not null && id is not null && refVal.Contains(id, StringComparison.Ordinal))
                return new List<IFhirNode> { PocoElementNavigator.Wrap(c, c.GetType().Name, root) };
        }
        return new List<IFhirNode>();
    }

    private static object? OfType(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
    {
        var typeName = args[0]?.ToString() ?? "";
        return focus.Where(n =>
        {
            var t = n.TypeName ?? n.Native?.GetType().Name ?? "";
            if (t.StartsWith("Fhir", StringComparison.Ordinal)) t = t[4..];
            return t.Equals(typeName, StringComparison.OrdinalIgnoreCase);
        }).ToList();
    }

    private static object? Length(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
    {
        var v = focus.FirstOrDefault()?.GetValue();
        return v switch
        {
            string s => s.Length,
            System.Collections.ICollection c => c.Count,
            _ => focus.Count
        };
    }

    private static object? Item(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
    {
        var index = Convert.ToInt32(args[0]);
        return index >= 0 && index < focus.Count
            ? new List<IFhirNode> { focus[index] }
            : new List<IFhirNode>();
    }

    private static object? Trace(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => focus;

    private static IFhirNode? FindRoot(IFhirNode? node)
    {
        while (node?.Parent is not null) node = node.Parent;
        return node;
    }

    private static FhirPathExpression GetLambda(IReadOnlyList<object?> args, int index)
    {
        if (args[index] is FhirPathExpression expr) return expr;
        if (args[index] is string s) return FhirPathParser.Parse(s);
        throw FhirPathException.Runtime("Expected expression argument.");
    }

    private static bool CoerceBool(object? v) => v switch
    {
        bool b => b,
        FhirPathCollection c => c.Count > 0,
        _ => v is not null && v.ToString() is { Length: > 0 }
    };

    private static List<IFhirNode> CoerceNodesFromCollection(FhirPathCollection col)
        => col.Select(v => PocoElementNavigator.Wrap(v)).ToList();

    public static FhirPathFunctionRegistry CreateDefaultRegistry() => new();
}

internal delegate object? FhirPathFunction(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx);
