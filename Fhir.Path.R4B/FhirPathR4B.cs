using Fhir.Path.Abstractions;
using Fhir.Path.Evaluation;
using Fhir.Path.R4B.XQuery;

namespace Fhir.Path.R4B;

/// <summary>R4B FHIRPath 引擎與 x-fhir-query 入口（Patch 僅 R5 提供）。</summary>
public sealed class FhirPathR4B
{
    private readonly IFhirPathEngine _engine;

    public FhirPathR4B(IFhirPathEngine? engine = null)
        => _engine = engine ?? new FhirPathEngine();

    public static FhirPathR4B Create() => new();

    public static IFhirPathEngine CreateEngine() => new FhirPathEngine();

    public IFhirPathEngine Engine => _engine;

    public FhirPathCollection Evaluate(string expression, object context, FhirPathEvaluationContext? ctx = null)
        => _engine.Evaluate(expression, context, ctx);

    public string ResolveXQuery(string query, FhirPathEvaluationContext ctx, bool percentEncode = false)
        => FhirXQuery.Resolve(query, _engine, ctx, percentEncode);
}
