namespace Fhir.TypeFramework.Serialization;

/// <summary>Strict 模式下無法接受的 FHIR 序列化內容。</summary>
public sealed class FhirSerializationException : Exception
{
    public FhirSerializationException(string message) : base(message)
    {
    }

    public FhirSerializationException(string message, Exception inner) : base(message, inner)
    {
    }

    public IReadOnlyList<string> UnknownElements { get; init; } = [];
}
