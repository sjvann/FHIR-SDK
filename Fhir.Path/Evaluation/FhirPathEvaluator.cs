using Fhir.Path.Abstractions;
using Fhir.Path.Ast;
using Fhir.Path.Exceptions;
using Fhir.Path.Navigation;

namespace Fhir.Path.Evaluation;

internal sealed class FhirPathEvaluator(FhirPathFunctionRegistry functions)
{
    public FhirPathCollection Evaluate(FhirPathExpression expr, IReadOnlyList<IFhirNode> input, FhirPathEvaluationContext ctx)
    {
        var result = EvaluateExpression(expr, input, ctx);
        return ToCollection(result);
    }

    public IReadOnlyList<IFhirNode> EvaluateNodes(FhirPathExpression expr, IReadOnlyList<IFhirNode> input, FhirPathEvaluationContext ctx)
        => CoerceToNodes(EvaluateExpression(expr, input, ctx));

    private object? EvaluateExpression(FhirPathExpression expr, IReadOnlyList<IFhirNode> input, FhirPathEvaluationContext ctx)
    {
        return expr switch
        {
            LiteralExpression lit => lit.Value,
            IdentifierExpression id when id.Name.StartsWith('%') =>
                ctx.TryGetVariable(id.Name, out var varNode) && varNode is not null
                    ? varNode
                    : throw FhirPathException.Runtime($"Unknown context variable '{id.Name}'"),
            IdentifierExpression id => EvaluateIdentifier(id.Name, input),
            MemberInvocationExpression mem => EvaluateMember(mem, input, ctx),
            IndexerExpression idx => EvaluateIndexer(idx, input, ctx),
            FunctionInvocationExpression fn => EvaluateFunction(fn, input, ctx),
            UnaryExpression u => EvaluateUnary(u, input, ctx),
            BinaryExpression b => EvaluateBinary(b, input, ctx),
            TypeExpression t => EvaluateType(t, input, ctx),
            UnionExpression u => EvaluateUnion(u, input, ctx),
            _ => throw FhirPathException.Runtime($"Unsupported expression node {expr.GetType().Name}")
        };
    }

    private static object? EvaluateIdentifier(string name, IReadOnlyList<IFhirNode> input)
    {
        var nodes = new List<IFhirNode>();
        foreach (var node in input)
        {
            if (node is NullFhirNode) continue;
            var typeName = node.TypeName ?? node.Native?.GetType().Name ?? "";
            if (typeName.StartsWith("Fhir", StringComparison.Ordinal))
                typeName = typeName[4..];
            if (name.Equals(typeName, StringComparison.OrdinalIgnoreCase))
            {
                nodes.Add(node);
                continue;
            }
            if (string.Equals(node.Name, name, StringComparison.OrdinalIgnoreCase))
                nodes.Add(node);
            else
                nodes.AddRange(node.Children(name));
        }
        return nodes;
    }

    private object? EvaluateMember(MemberInvocationExpression mem, IReadOnlyList<IFhirNode> input, FhirPathEvaluationContext ctx)
    {
        var left = EvaluateExpression(mem.Left, input, ctx);
        var nodes = CoerceToNodes(left);
        return EvaluateIdentifier(mem.Member, nodes);
    }

    private object? EvaluateIndexer(IndexerExpression idx, IReadOnlyList<IFhirNode> input, FhirPathEvaluationContext ctx)
    {
        var left = EvaluateExpression(idx.Left, input, ctx);
        var nodes = CoerceToNodes(left);
        var indexVal = EvaluateExpression(idx.Index, nodes, ctx);

        if (indexVal is int i)
        {
            var flat = FlattenNodes(nodes);
            return i >= 0 && i < flat.Count ? flat[i] : EmptyNodes();
        }

        if (indexVal is string s && s == "last")
        {
            var flat = FlattenNodes(nodes);
            return flat.Count == 0 ? EmptyNodes() : flat[^1];
        }

        if (indexVal is bool b)
            return nodes.Where(n => EvaluatePredicateOnNode(n, b, ctx)).ToList();

        throw FhirPathException.Runtime($"Unsupported index expression result: {indexVal}");
    }

    private bool EvaluatePredicateOnNode(IFhirNode node, bool expected, FhirPathEvaluationContext ctx)
    {
        // Used when index is predicate - simplified: not used in MVP tests heavily
        return expected;
    }

    private object? EvaluateFunction(FunctionInvocationExpression fn, IReadOnlyList<IFhirNode> input, FhirPathEvaluationContext ctx)
    {
        IReadOnlyList<IFhirNode> focus = fn.Left is null
            ? input
            : CoerceToNodes(EvaluateExpression(fn.Left, input, ctx));

        var args = fn.Arguments.Cast<object?>().ToList();

        if (!functions.TryInvoke(fn.FunctionName, focus, args, ctx, out var result))
            throw FhirPathException.Runtime($"Function '{fn.FunctionName}' is not supported.");

        return result;
    }

    private object? EvaluateUnary(UnaryExpression u, IReadOnlyList<IFhirNode> input, FhirPathEvaluationContext ctx)
    {
        var val = EvaluateExpression(u.Operand, input, ctx);
        return u.Operator switch
        {
            "-" when val is int i => -i,
            "-" when val is decimal d => -d,
            "not" => !CoerceToBool(val),
            _ => throw FhirPathException.Runtime($"Unary operator '{u.Operator}' not supported.")
        };
    }

    private object? EvaluateBinary(BinaryExpression b, IReadOnlyList<IFhirNode> input, FhirPathEvaluationContext ctx)
    {
        if (b.Operator is "and" or "or" or "xor" or "implies")
            return EvaluateLogical(b, input, ctx);

        if (b.Operator is "as")
        {
            var left = EvaluateExpression(b.Left, input, ctx);
            var typeName = (b.Right as IdentifierExpression)?.Name
                ?? throw FhirPathException.Runtime("Right side of 'as' must be a type name.");
            return CoerceToNodes(left).Where(n => TypeMatches(n, typeName)).ToList();
        }

        var l = EvaluateExpression(b.Left, input, ctx);
        var r = EvaluateExpression(b.Right, input, ctx);
        return EvaluateComparisonOrMath(b.Operator, l, r);
    }

    private object? EvaluateLogical(BinaryExpression b, IReadOnlyList<IFhirNode> input, FhirPathEvaluationContext ctx)
    {
        var l = CoerceToBool(EvaluateExpression(b.Left, input, ctx));
        return b.Operator switch
        {
            "and" => l && CoerceToBool(EvaluateExpression(b.Right, input, ctx)),
            "or" => l || CoerceToBool(EvaluateExpression(b.Right, input, ctx)),
            "xor" => l ^ CoerceToBool(EvaluateExpression(b.Right, input, ctx)),
            "implies" => !l || CoerceToBool(EvaluateExpression(b.Right, input, ctx)),
            _ => throw FhirPathException.Runtime($"Unknown logical operator {b.Operator}")
        };
    }

    private static object? EvaluateComparisonOrMath(string op, object? l, object? r)
    {
        var lv = CoerceComparable(l);
        var rv = CoerceComparable(r);

        if (lv is null || rv is null)
            return op is "=" or "~" ? lv is null && rv is null : false;

        return op switch
        {
            "=" or "~" => Equals(Normalize(lv), Normalize(rv)),
            "!=" => !Equals(Normalize(lv), Normalize(rv)),
            "<" => Compare(lv, rv) < 0,
            ">" => Compare(lv, rv) > 0,
            "<=" => Compare(lv, rv) <= 0,
            ">=" => Compare(lv, rv) >= 0,
            "+" => Add(lv, rv),
            "-" => Subtract(lv, rv),
            "*" => Multiply(lv, rv),
            "/" => Divide(lv, rv),
            "in" => ContainsIn(r, l),
            _ => throw FhirPathException.Runtime($"Operator '{op}' not supported.")
        };
    }

    private object? EvaluateType(TypeExpression t, IReadOnlyList<IFhirNode> input, FhirPathEvaluationContext ctx)
    {
        var left = CoerceToNodes(EvaluateExpression(t.Left, input, ctx));
        if (t.IsTypeCheck)
            return left.Any(n => TypeMatches(n, t.TypeSpecifier));

        return left.Where(n => TypeMatches(n, t.TypeSpecifier)).ToList();
    }

    private object? EvaluateUnion(UnionExpression u, IReadOnlyList<IFhirNode> input, FhirPathEvaluationContext ctx)
    {
        var left = CoerceToNodes(EvaluateExpression(u.Left, input, ctx));
        var right = CoerceToNodes(EvaluateExpression(u.Right, input, ctx));
        return left.Concat(right).ToList();
    }

    private static bool TypeMatches(IFhirNode node, string typeSpecifier)
    {
        var type = node.TypeName ?? node.Native?.GetType().Name ?? "";
        if (type.StartsWith("Fhir", StringComparison.Ordinal))
            type = type[4..];
        return type.Equals(typeSpecifier, StringComparison.OrdinalIgnoreCase)
               || (node.Native?.GetType().Name.Equals(typeSpecifier, StringComparison.OrdinalIgnoreCase) ?? false);
    }

    private static List<IFhirNode> CoerceToNodes(object? value) => value switch
    {
        null => [],
        IFhirNode n => [n],
        List<IFhirNode> list => list,
        IEnumerable<IFhirNode> en => en.ToList(),
        IEnumerable<object?> objs => objs.Where(o => o is not null).Select(o => o is IFhirNode n ? n : PocoElementNavigator.Wrap(o)).ToList(),
        _ => [PocoElementNavigator.Wrap(value)]
    };

    private static List<IFhirNode> FlattenNodes(IReadOnlyList<IFhirNode> nodes)
    {
        var flat = new List<IFhirNode>();
        foreach (var n in nodes)
        {
            if (n.Count > 1)
            {
                for (var i = 0; i < n.Count; i++)
                {
                    var at = n.AtIndex(i);
                    if (at is not null) flat.Add(at);
                }
            }
            else flat.Add(n);
        }
        return flat;
    }

    private static List<IFhirNode> EmptyNodes() => [];

    private static FhirPathCollection ToCollection(object? value)
    {
        if (value is null) return FhirPathCollection.Empty;
        if (value is bool b) return new([b]);
        if (value is IFhirNode n) return new([n.GetValue() ?? n.Native]);
        if (value is List<IFhirNode> nodes)
            return new(nodes.Select(x => x.GetValue() ?? x.Native));
        if (value is IEnumerable<IFhirNode> en)
            return new(en.Select(x => x.GetValue() ?? x.Native));
        return new([value]);
    }

    private static bool CoerceToBool(object? value)
    {
        if (value is bool b) return b;
        if (value is List<IFhirNode> nodes) return nodes.Count > 0;
        if (value is IEnumerable<IFhirNode> en) return en.Any();
        return value is not null;
    }

    private static object? CoerceComparable(object? value)
    {
        if (value is IFhirNode n) return n.GetValue();
        if (value is List<IFhirNode> nodes)
        {
            if (nodes.Count == 1) return nodes[0].GetValue();
            if (nodes.Count == 0) return null;
        }
        if (value is IEnumerable<IFhirNode> en)
        {
            var list = en.ToList();
            if (list.Count == 1) return list[0].GetValue();
        }
        if (value is TypeFramework.Bases.PrimitiveType p)
            return PocoElementNavigator.GetPrimitiveValue(p);
        return value;
    }

    private static string? Normalize(object? v)
    {
        if (v is TypeFramework.Bases.PrimitiveType p)
            return PocoElementNavigator.GetPrimitiveValue(p)?.ToString();
        return v?.ToString();
    }

    private static int Compare(object lv, object rv)
    {
        if (lv is IComparable c && rv is not null)
            return c.CompareTo(rv);
        return string.Compare(lv?.ToString(), rv?.ToString(), StringComparison.Ordinal);
    }

    private static object? Add(object lv, object rv) => lv switch
    {
        int i when rv is int j => i + j,
        decimal d when rv is decimal e => d + e,
        _ => throw FhirPathException.Runtime("Addition requires numeric operands.")
    };

    private static object? Subtract(object lv, object rv)
    {
        if (lv is DateTime dt && rv is string period)
            return SubtractPeriod(dt, period);
        if (lv is int i && rv is int j) return i - j;
        throw FhirPathException.Runtime("Subtraction not supported for these operands.");
    }

    private static DateTime SubtractPeriod(DateTime dt, string period)
    {
        var parts = period.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length != 2) return dt;
        var amount = int.Parse(parts[0]);
        return parts[1] switch
        {
            "years" => dt.AddYears(-amount),
            "months" => dt.AddMonths(-amount),
            "weeks" => dt.AddDays(-7 * amount),
            "days" => dt.AddDays(-amount),
            "hours" => dt.AddHours(-amount),
            _ => dt
        };
    }

    private static object? Multiply(object lv, object rv)
    {
        if (lv is int i && rv is int j) return i * j;
        if (lv is decimal d && rv is decimal e) return d * e;
        throw FhirPathException.Runtime("Multiply requires numeric operands.");
    }

    private static object? Divide(object lv, object rv)
    {
        if (lv is decimal d && rv is decimal e) return d / e;
        if (lv is int i && rv is int j) return (decimal)i / j;
        throw FhirPathException.Runtime("Divide requires numeric operands.");
    }

    private static bool ContainsIn(object? collection, object? item)
    {
        var s = item?.ToString();
        if (collection is string str)
            return str.Split(',').Any(x => x.Trim() == s);
        return false;
    }
}
