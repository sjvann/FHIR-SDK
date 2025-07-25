using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// Generic base class for FHIR complex data types.
/// </summary>
/// <typeparam name="TSelf">The concrete FHIR complex type (for fluent API and type safety).</typeparam>
/// <remarks>
/// This generic base class provides common functionality for all FHIR complex data types,
/// reducing code duplication and ensuring consistent behavior across all complex types.
/// All FHIR complex types inherit from DataType, which in turn inherits from Element.
/// </remarks>
public abstract class ComplexType<TSelf> : DataType
    where TSelf : ComplexType<TSelf>, new()
{
    /// <summary>
    /// Initializes a new instance of the complex type.
    /// </summary>
    protected ComplexType() { }

    /// <summary>
    /// Creates a new instance of the complex type.
    /// </summary>
    /// <returns>A new instance of the complex type.</returns>
    public static TSelf Create()
    {
        return new TSelf();
    }

    /// <summary>
    /// Creates a new instance of the complex type with a configuration action.
    /// </summary>
    /// <param name="configure">Action to configure the instance.</param>
    /// <returns>A configured instance of the complex type.</returns>
    public static TSelf Create(Action<TSelf> configure)
    {
        var instance = new TSelf();
        configure(instance);
        return instance;
    }

    /// <summary>
    /// Provides a fluent interface for configuring the complex type.
    /// </summary>
    /// <param name="configure">Action to configure the instance.</param>
    /// <returns>The configured instance for method chaining.</returns>
    public TSelf Configure(Action<TSelf> configure)
    {
        configure((TSelf)this);
        return (TSelf)this;
    }

    /// <summary>
    /// Validates the complex type according to FHIR R4 rules.
    /// Override this method in derived classes to provide specific validation logic.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Derived classes can override ValidateComplexType for specific validation
        foreach (var result in ValidateComplexType(validationContext))
            yield return result;
    }

    /// <summary>
    /// Validates the specific complex type. Override in derived classes for custom validation.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    protected virtual IEnumerable<ValidationResult> ValidateComplexType(ValidationContext validationContext)
    {
        // Default implementation - no additional validation
        yield break;
    }

    /// <summary>
    /// Determines whether the specified object is equal to the current complex type.
    /// </summary>
    /// <param name="obj">The object to compare with the current complex type.</param>
    /// <returns>True if the specified object is equal to the current complex type; otherwise, false.</returns>
    public override bool Equals(object? obj)
    {
        if (obj is TSelf other)
        {
            return EqualsComplexType(other);
        }
        return false;
    }

    /// <summary>
    /// Determines whether the specified complex type is equal to the current complex type.
    /// Override in derived classes for specific equality logic.
    /// </summary>
    /// <param name="other">The complex type to compare with the current complex type.</param>
    /// <returns>True if the specified complex type is equal to the current complex type; otherwise, false.</returns>
    protected virtual bool EqualsComplexType(TSelf other)
    {
        // Default implementation - reference equality
        return ReferenceEquals(this, other);
    }

    /// <summary>
    /// Returns the hash code for this complex type.
    /// Override in derived classes for specific hash code logic.
    /// </summary>
    /// <returns>A hash code for the current complex type.</returns>
    public override int GetHashCode()
    {
        return GetComplexTypeHashCode();
    }

    /// <summary>
    /// Returns the hash code for this complex type.
    /// Override in derived classes for specific hash code logic.
    /// </summary>
    /// <returns>A hash code for the current complex type.</returns>
    protected virtual int GetComplexTypeHashCode()
    {
        // Default implementation
        return base.GetHashCode();
    }

    /// <summary>
    /// Returns a string representation of the complex type.
    /// Override in derived classes for specific string representation.
    /// </summary>
    /// <returns>The string representation of the complex type.</returns>
    public override string? ToString()
    {
        return GetComplexTypeString() ?? base.ToString();
    }

    /// <summary>
    /// Returns a string representation of the complex type.
    /// Override in derived classes for specific string representation.
    /// </summary>
    /// <returns>The string representation of the complex type.</returns>
    protected virtual string? GetComplexTypeString()
    {
        // Default implementation - return type name
        return GetType().Name;
    }
}

/// <summary>
/// Simplified generic complex type for basic scenarios.
/// </summary>
/// <remarks>
/// This class provides a simplified way to create FHIR complex types
/// for scenarios where you don't need the full type safety of the specific classes.
/// </remarks>
public class ComplexType : ComplexType<ComplexType>
{
    /// <summary>
    /// Initializes a new instance of the ComplexType class.
    /// </summary>
    public ComplexType() { }

    /// <summary>
    /// Additional properties for dynamic complex types.
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object>? AdditionalProperties { get; set; }

    /// <summary>
    /// Sets an additional property.
    /// </summary>
    /// <param name="name">The property name.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The current instance for method chaining.</returns>
    public ComplexType SetProperty(string name, object value)
    {
        AdditionalProperties ??= new Dictionary<string, object>();
        AdditionalProperties[name] = value;
        return this;
    }

    /// <summary>
    /// Gets an additional property.
    /// </summary>
    /// <typeparam name="T">The expected type of the property value.</typeparam>
    /// <param name="name">The property name.</param>
    /// <returns>The property value, or default if not found.</returns>
    public T? GetProperty<T>(string name)
    {
        if (AdditionalProperties?.TryGetValue(name, out var value) == true && value is T typedValue)
        {
            return typedValue;
        }
        return default;
    }
}
