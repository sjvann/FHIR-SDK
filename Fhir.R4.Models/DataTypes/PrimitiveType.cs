using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// Generic base class for FHIR primitive types.
/// </summary>
/// <typeparam name="TValue">The underlying .NET type for the primitive value.</typeparam>
/// <typeparam name="TSelf">The concrete FHIR primitive type (for fluent API).</typeparam>
/// <remarks>
/// This generic base class provides common functionality for all FHIR primitive types,
/// reducing code duplication and ensuring consistent behavior across all primitive types.
/// </remarks>
public abstract class PrimitiveType<TValue, TSelf> : Element
    where TSelf : PrimitiveType<TValue, TSelf>, new()
{
    private TValue? _value;

    /// <summary>
    /// The actual primitive value.
    /// </summary>
    [JsonPropertyName("value")]
    public virtual TValue? Value
    {
        get => _value;
        set => _value = value;
    }

    /// <summary>
    /// Initializes a new instance of the primitive type.
    /// </summary>
    protected PrimitiveType() { }

    /// <summary>
    /// Initializes a new instance of the primitive type with the specified value.
    /// </summary>
    /// <param name="value">The primitive value.</param>
    protected PrimitiveType(TValue? value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new instance of the primitive type with the specified value.
    /// </summary>
    /// <param name="value">The primitive value.</param>
    /// <returns>A new instance of the primitive type.</returns>
    public static TSelf Create(TValue? value)
    {
        return new TSelf { Value = value };
    }

    // Note: Implicit operators cannot be defined in generic base classes
    // They must be defined in concrete derived classes

    /// <summary>
    /// Returns a string representation of the primitive value.
    /// </summary>
    /// <returns>The string representation of the value.</returns>
    public override string? ToString() => Value?.ToString();

    /// <summary>
    /// Determines whether the specified object is equal to the current primitive.
    /// </summary>
    /// <param name="obj">The object to compare with the current primitive.</param>
    /// <returns>True if the specified object is equal to the current primitive; otherwise, false.</returns>
    public override bool Equals(object? obj)
    {
        if (obj is PrimitiveType<TValue, TSelf> other)
        {
            return EqualityComparer<TValue?>.Default.Equals(Value, other.Value);
        }
        return false;
    }

    /// <summary>
    /// Returns the hash code for this primitive.
    /// </summary>
    /// <returns>A hash code for the current primitive.</returns>
    public override int GetHashCode()
    {
        return Value?.GetHashCode() ?? 0;
    }

    /// <summary>
    /// Validates the primitive value according to FHIR R4 rules.
    /// Override this method in derived classes to provide specific validation logic.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Derived classes can override this method to add specific validation
        foreach (var result in ValidateValue(validationContext))
            yield return result;
    }

    /// <summary>
    /// Validates the specific primitive value. Override in derived classes for custom validation.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    protected virtual IEnumerable<ValidationResult> ValidateValue(ValidationContext validationContext)
    {
        // Default implementation - no additional validation
        yield break;
    }
}

/// <summary>
/// Simplified generic primitive type for basic scenarios.
/// </summary>
/// <typeparam name="T">The underlying .NET type.</typeparam>
/// <remarks>
/// This class provides a simplified way to create FHIR primitive types
/// for scenarios where you don't need the full type safety of the specific classes.
/// </remarks>
public class PrimitiveType<T> : PrimitiveType<T, PrimitiveType<T>>
{
    /// <summary>
    /// Initializes a new instance of the PrimitiveType class.
    /// </summary>
    public PrimitiveType() { }

    /// <summary>
    /// Initializes a new instance of the PrimitiveType class with the specified value.
    /// </summary>
    /// <param name="value">The primitive value.</param>
    public PrimitiveType(T? value) : base(value) { }

    /// <summary>
    /// Implicitly converts a value to a PrimitiveType.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>A PrimitiveType instance, or null if the value is null.</returns>
    public static implicit operator PrimitiveType<T>?(T? value)
    {
        return value == null ? null : new PrimitiveType<T>(value);
    }

    /// <summary>
    /// Implicitly converts a PrimitiveType to its underlying value.
    /// </summary>
    /// <param name="primitive">The PrimitiveType to convert.</param>
    /// <returns>The underlying value, or default if the PrimitiveType is null.</returns>
    public static implicit operator T?(PrimitiveType<T>? primitive)
    {
        return primitive != null ? primitive.Value : default;
    }
}
