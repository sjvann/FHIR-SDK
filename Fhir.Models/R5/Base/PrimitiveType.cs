// Auto-generated for FHIR R5
namespace Fhir.R5.Models;

/// <summary>
/// Base definition for all primitive types.
/// </summary>
public abstract class PrimitiveType<T> : DataType
{
    /// <summary>
    /// The actual value
    /// </summary>
    public T? Value { get; set; }
}