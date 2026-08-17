using Fhir.Path.Abstractions;
using Fhir.Path.Evaluation;
using Fhir.Path.Navigation;
using Fhir.Path.R5.Patch;
using Fhir.Path.R5.XQuery;
using Fhir.Resources.R5;

namespace Fhir.Path.R5;

/// <summary>R5 FHIRPath 引擎與 Patch / x-fhir-query 入口。</summary>
public sealed class FhirPathR5
{
    private readonly IFhirPathEngine _engine;

    public FhirPathR5(IFhirPathEngine? engine = null)
        => _engine = engine ?? new FhirPathEngine();

    public static FhirPathR5 Create() => new();

    public static IFhirPathEngine CreateEngine() => new FhirPathEngine();

    public IFhirPathEngine Engine => _engine;

    public FhirPathCollection Evaluate(string expression, object context, FhirPathEvaluationContext? ctx = null)
        => _engine.Evaluate(expression, context, ctx);

    public T ApplyPatch<T>(T resource, Parameters patch, bool inPlace = false) where T : class
    {
        if (resource is not Fhir.TypeFramework.Bases.Base baseResource)
            throw new ArgumentException("Resource must inherit Base.", nameof(resource));
        var copy = inPlace ? resource : (T)(object)baseResource.DeepCopy();
        FhirPathPatchApplicator.Apply(copy, patch, _engine);
        return copy;
    }

    public string ResolveXQuery(string query, FhirPathEvaluationContext ctx, bool percentEncode = false)
        => FhirXQuery.Resolve(query, _engine, ctx, percentEncode);
}
