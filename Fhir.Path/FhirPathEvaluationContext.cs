using Fhir.Path.Abstractions;

namespace Fhir.Path;

/// <summary>FHIRPath 評估上下文（變數、時鐘）。</summary>
public sealed class FhirPathEvaluationContext
{
    private readonly Dictionary<string, IFhirNode> _variables = new(StringComparer.OrdinalIgnoreCase);

    public FhirPathEvaluationContext() { }

    public FhirPathEvaluationContext(IDictionary<string, IFhirNode> variables)
    {
        foreach (var (k, v) in variables)
            _variables[k] = v;
    }

    /// <summary>可注入的時鐘（供 <c>today()</c>、<c>now()</c>）。</summary>
    public Func<DateTimeOffset> Clock { get; set; } = () => DateTimeOffset.UtcNow;

    public IReadOnlyDictionary<string, IFhirNode> Variables => _variables;

    public void SetVariable(string name, IFhirNode node)
    {
        var key = name.TrimStart('%');
        _variables[key] = node;
    }

    public bool TryGetVariable(string name, out IFhirNode? node)
    {
        var key = name.TrimStart('%');
        return _variables.TryGetValue(key, out node);
    }
}
