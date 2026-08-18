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
            ["isDistinct"] = IsDistinct,
            ["first"] = First,
            ["last"] = Last,
            ["tail"] = Tail,
            ["skip"] = Skip,
            ["take"] = Take,
            ["single"] = Single,
            ["all"] = All,
            ["allTrue"] = AllTrue,
            ["anyTrue"] = AnyTrue,
            ["allFalse"] = AllFalse,
            ["anyFalse"] = AnyFalse,
            ["iif"] = Iif,
            ["not"] = NotFunc,
            ["today"] = Today,
            ["now"] = Now,
            ["substring"] = Substring,
            ["startsWith"] = StartsWith,
            ["endsWith"] = EndsWith,
            ["contains"] = Contains,
            ["indexOf"] = IndexOf,
            ["matches"] = Matches,
            ["replace"] = Replace,
            ["upper"] = Upper,
            ["lower"] = Lower,
            ["toString"] = ToStringFunc,
            ["toInteger"] = ToInteger,
            ["toDecimal"] = ToDecimal,
            ["toBoolean"] = ToBoolean,
            ["hasValue"] = HasValue,
            ["children"] = ChildrenFn,
            ["descendants"] = Descendants,
            ["combine"] = Combine,
            ["extension"] = Extension,
            ["resolve"] = Resolve,
            ["ofType"] = OfType,
            ["length"] = Length,
            ["item"] = Item,
            ["abs"] = Abs,
            ["ceiling"] = Ceiling,
            ["floor"] = Floor,
            ["round"] = Round,
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
    {
        if (args.Count == 0)
            return focus.Count > 0;
        return Where(focus, args, ctx) is IReadOnlyList<IFhirNode> kept && kept.Count > 0;
    }

    private static object? Empty(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => focus.Count == 0;

    private static object? Count(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => focus.Count;

    private static object? Distinct(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => focus.GroupBy(n => n.GetValue()?.ToString() ?? n.Native?.GetType().FullName).Select(g => g.First()).ToList();

    private static object? First(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => focus.Count == 0 ? new List<IFhirNode>() : new List<IFhirNode> { focus[0] };

    private static object? Last(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => focus.Count == 0 ? new List<IFhirNode>() : new List<IFhirNode> { focus[^1] };

    private static object? Tail(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => focus.Count <= 1 ? new List<IFhirNode>() : focus.Skip(1).ToList();

    private static object? Skip(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
    {
        var n = args.Count > 0 ? Convert.ToInt32(CoerceNumber(args[0])) : 0;
        return focus.Skip(Math.Max(0, n)).ToList();
    }

    private static object? Take(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
    {
        var n = args.Count > 0 ? Convert.ToInt32(CoerceNumber(args[0])) : 0;
        return focus.Take(Math.Max(0, n)).ToList();
    }

    private static object? Single(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => focus.Count == 1 ? new List<IFhirNode> { focus[0] } : new List<IFhirNode>();

    private static object? All(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
    {
        if (args.Count == 0)
            return focus.Count == 0 || focus.All(n => CoerceBool(n.GetValue()));
        var predicate = GetLambda(args, 0);
        var evaluator = new FhirPathEvaluator(CreateDefaultRegistry());
        return focus.All(node => CoerceBool(evaluator.Evaluate(predicate, [node], ctx).FirstOrDefault()));
    }

    private static object? AllTrue(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => focus.Count > 0 && focus.All(n => CoerceBool(n.GetValue()));

    private static object? AnyTrue(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => focus.Any(n => CoerceBool(n.GetValue()));

    private static object? AllFalse(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => focus.Count > 0 && focus.All(n => !CoerceBool(n.GetValue()));

    private static object? AnyFalse(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => focus.Any(n => !CoerceBool(n.GetValue()));

    private static object? IsDistinct(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
    {
        var keys = focus.Select(n => n.GetValue()?.ToString() ?? n.Native?.GetType().FullName).ToList();
        return keys.Count == keys.Distinct().Count();
    }

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

    private static object? Contains(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => (focus.FirstOrDefault()?.GetValue()?.ToString() ?? "").Contains(args[0]?.ToString() ?? "", StringComparison.Ordinal);

    private static object? IndexOf(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => (focus.FirstOrDefault()?.GetValue()?.ToString() ?? "").IndexOf(args[0]?.ToString() ?? "", StringComparison.Ordinal);

    private static object? Upper(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => (focus.FirstOrDefault()?.GetValue()?.ToString() ?? "").ToUpperInvariant();

    private static object? Lower(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => (focus.FirstOrDefault()?.GetValue()?.ToString() ?? "").ToLowerInvariant();

    private static object? ToInteger(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => int.TryParse(focus.FirstOrDefault()?.GetValue()?.ToString(), out var n) ? n : null;

    private static object? ToDecimal(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => decimal.TryParse(focus.FirstOrDefault()?.GetValue()?.ToString(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out var n) ? n : null;

    private static object? ToBoolean(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
    {
        var s = focus.FirstOrDefault()?.GetValue()?.ToString();
        return s switch
        {
            "true" or "1" or "t" or "yes" or "y" => true,
            "false" or "0" or "f" or "no" or "n" => false,
            _ => null
        };
    }

    private static object? HasValue(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => focus.Any(n => n.GetValue() is not null && n.GetValue()?.ToString() is { Length: > 0 });

    private static object? ChildrenFn(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => focus.SelectMany(n => n.AllChildren()).ToList();

    private static object? Descendants(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
    {
        var acc = new List<IFhirNode>();
        var queue = new Queue<IFhirNode>(focus.SelectMany(n => n.AllChildren()));
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            acc.Add(node);
            foreach (var child in node.AllChildren())
                queue.Enqueue(child);
        }
        return acc;
    }

    private static object? Combine(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
    {
        var extra = args.Count > 0 ? CoerceNodesFromArg(args[0]) : [];
        return focus.Concat(extra).ToList();
    }

    private static object? Abs(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => Math.Abs(CoerceNumber(focus.FirstOrDefault()?.GetValue()));

    private static object? Ceiling(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => Math.Ceiling(CoerceNumber(focus.FirstOrDefault()?.GetValue()));

    private static object? Floor(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => Math.Floor(CoerceNumber(focus.FirstOrDefault()?.GetValue()));

    private static object? Round(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx)
        => Math.Round(CoerceNumber(focus.FirstOrDefault()?.GetValue()));

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

    private static List<IFhirNode> CoerceNodesFromArg(object? arg) => arg switch
    {
        IReadOnlyList<IFhirNode> nodes => nodes.ToList(),
        FhirPathCollection col => CoerceNodesFromCollection(col),
        IFhirNode node => [node],
        null => [],
        _ => [PocoElementNavigator.Wrap(arg)]
    };

    private static decimal CoerceNumber(object? value) => value switch
    {
        decimal d => d,
        int i => i,
        long l => l,
        double db => (decimal)db,
        IFhirNode n => CoerceNumber(n.GetValue()),
        string s when decimal.TryParse(s, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out var d) => d,
        _ => 0
    };

    public static FhirPathFunctionRegistry CreateDefaultRegistry() => new();
}

internal delegate object? FhirPathFunction(IReadOnlyList<IFhirNode> focus, IReadOnlyList<object?> args, FhirPathEvaluationContext ctx);
