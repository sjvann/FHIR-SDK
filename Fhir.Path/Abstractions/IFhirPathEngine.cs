using Fhir.Path.Abstractions;

namespace Fhir.Path.Abstractions;

/// <summary>FHIRPath 編譯與評估引擎。</summary>
public interface IFhirPathEngine
{
    /// <summary>支援的函式與運算子能力。</summary>
    FhirPathCapabilities Capabilities { get; }

    /// <summary>編譯表達式（含快取）。</summary>
    CompiledExpression Compile(string expression);

    /// <summary>對單一 context 評估。</summary>
    FhirPathCollection Evaluate(string expression, IFhirNode context, FhirPathEvaluationContext? evaluationContext = null);

    /// <summary>對 POCO 評估。</summary>
    FhirPathCollection Evaluate(string expression, object context, FhirPathEvaluationContext? evaluationContext = null);

    /// <summary>評估並回傳邏輯節點（供 Patch 路徑解析）。</summary>
    IReadOnlyList<IFhirNode> EvaluateNodes(string expression, object context, FhirPathEvaluationContext? evaluationContext = null);
}

/// <summary>已編譯的 FHIRPath 表達式。</summary>
public interface CompiledExpression
{
    string Expression { get; }
    FhirPathCollection Evaluate(IFhirNode context, FhirPathEvaluationContext? evaluationContext = null);
}

/// <summary>引擎能力宣告。</summary>
public sealed class FhirPathCapabilities
{
    public IReadOnlyList<string> SupportedFunctions { get; init; } = [];
    public IReadOnlyList<string> SupportedOperators { get; init; } = [];
    public string Version { get; init; } = "1.0-mvp";
}
