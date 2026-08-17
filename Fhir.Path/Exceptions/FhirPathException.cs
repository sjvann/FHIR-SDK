namespace Fhir.Path.Exceptions;

/// <summary>FHIRPath 語法或執行錯誤。</summary>
public sealed class FhirPathException : Exception
{
    public int? Position { get; }

    public FhirPathException(string message, int? position = null, Exception? inner = null)
        : base(position is null ? message : $"{message} (at {position})")
        => Position = position;

    public static FhirPathException Syntax(string message, int position)
        => new(message, position);

    public static FhirPathException Runtime(string message)
        => new(message);
}
