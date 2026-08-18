using System.Collections.Concurrent;
using Fhir.Path.Abstractions;
using Fhir.Path.Ast;
using Fhir.Path.Navigation;
using Fhir.Path.Parsing;

namespace Fhir.Path.Evaluation;

/// <summary>預設 FHIRPath 引擎實作。</summary>
public sealed class FhirPathEngine : IFhirPathEngine
{
    private static readonly ConcurrentDictionary<string, CompiledExpressionImpl> Cache = new();
    private readonly FhirPathFunctionRegistry _functions;
    private readonly FhirPathEvaluator _evaluator;

    public FhirPathEngine(FhirPathFunctionRegistry? functions = null)
    {
        _functions = functions ?? FhirPathFunctionRegistry.CreateDefaultRegistry();
        _evaluator = new FhirPathEvaluator(_functions);
        Capabilities = new FhirPathCapabilities
        {
            SupportedFunctions = _functions.FunctionNames.OrderBy(x => x).ToList(),
            SupportedOperators =
            [
                "=", "!=", "<", ">", "<=", ">=", "+", "-", "*", "/",
                "and", "or", "xor", "implies", "|", "in", "is", "as", "not"
            ],
            Version = "2.0"
        };
    }

    public FhirPathCapabilities Capabilities { get; }

    public CompiledExpression Compile(string expression)
        => Cache.GetOrAdd(expression, expr => new CompiledExpressionImpl(expr, FhirPathParser.Parse(expr), _evaluator));

    public FhirPathCollection Evaluate(string expression, IFhirNode context, FhirPathEvaluationContext? evaluationContext = null)
        => Compile(expression).Evaluate(context, evaluationContext);

    public FhirPathCollection Evaluate(string expression, object context, FhirPathEvaluationContext? evaluationContext = null)
        => Evaluate(expression, PocoElementNavigator.Wrap(context), evaluationContext);

    public IReadOnlyList<IFhirNode> EvaluateNodes(string expression, object context, FhirPathEvaluationContext? evaluationContext = null)
        => EvaluateNodes(expression, PocoElementNavigator.Wrap(context), evaluationContext);

    public IReadOnlyList<IFhirNode> EvaluateNodes(string expression, IFhirNode context, FhirPathEvaluationContext? evaluationContext = null)
    {
        var ctx = evaluationContext ?? new FhirPathEvaluationContext();
        var compiled = Compile(expression);
        if (compiled is not CompiledExpressionImpl impl)
            throw new InvalidOperationException("Unexpected compiled expression type.");
        return impl.EvaluateNodes(context, ctx);
    }

    private sealed class CompiledExpressionImpl(string expression, FhirPathExpression ast, FhirPathEvaluator evaluator)
        : CompiledExpression
    {
        public string Expression { get; } = expression;

        public FhirPathCollection Evaluate(IFhirNode context, FhirPathEvaluationContext? evaluationContext = null)
        {
            var ctx = evaluationContext ?? new FhirPathEvaluationContext();
            var input = BuildInitialInput(ast, context);
            return evaluator.Evaluate(ast, input, ctx);
        }

        public IReadOnlyList<IFhirNode> EvaluateNodes(IFhirNode context, FhirPathEvaluationContext? evaluationContext = null)
        {
            var ctx = evaluationContext ?? new FhirPathEvaluationContext();
            var input = BuildInitialInput(ast, context);
            return evaluator.EvaluateNodes(ast, input, ctx);
        }

        private static IReadOnlyList<IFhirNode> BuildInitialInput(FhirPathExpression ast, IFhirNode context)
        {
            if (ast is IdentifierExpression id && !id.Name.StartsWith('%'))
            {
                var typeName = context.TypeName ?? context.Native?.GetType().Name ?? "";
                if (typeName.StartsWith("Fhir", StringComparison.Ordinal))
                    typeName = typeName[4..];
                if (id.Name.Equals(typeName, StringComparison.OrdinalIgnoreCase)
                    || id.Name.Equals(context.Native?.GetType().Name, StringComparison.OrdinalIgnoreCase))
                    return [context];
            }
            return [context];
        }
    }
}
