using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using OneOf;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// A reference from one resource to another.
/// </summary>
/// <remarks>
/// FHIR R4 Reference DataType
/// A reference from one resource to another.
/// This is the base Reference type that can reference any resource type.
/// </remarks>
public class Reference : ComplexType<Reference>
{
    /// <summary>
    /// Literal reference, Relative, internal or absolute URL.
    /// FHIR Path: Reference.reference
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("reference")]
    public FhirString? ReferenceValue { get; set; }
    
    /// <summary>
    /// Type the reference refers to (e.g. "Patient").
    /// FHIR Path: Reference.type
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("type")]
    public FhirUri? Type { get; set; }
    
    /// <summary>
    /// Logical reference, when literal reference is not known.
    /// FHIR Path: Reference.identifier
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("identifier")]
    public Identifier? Identifier { get; set; }
    
    /// <summary>
    /// Text alternative for the resource.
    /// FHIR Path: Reference.display
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("display")]
    public FhirString? Display { get; set; }

    /// <summary>
    /// Initializes a new instance of the Reference class.
    /// </summary>
    public Reference() { }

    /// <summary>
    /// Initializes a new instance of the Reference class with a reference value.
    /// </summary>
    /// <param name="reference">The reference value.</param>
    public Reference(string reference)
    {
        ReferenceValue = new FhirString(reference);
    }

    /// <summary>
    /// Initializes a new instance of the Reference class with a reference value and type.
    /// </summary>
    /// <param name="reference">The reference value.</param>
    /// <param name="type">The resource type.</param>
    public Reference(string reference, string type) : this(reference)
    {
        Type = new FhirUri(type);
    }

    /// <summary>
    /// Creates a reference with the specified reference value.
    /// </summary>
    /// <param name="reference">The reference value.</param>
    /// <returns>A new Reference instance.</returns>
    public static Reference To(string reference)
    {
        return new Reference(reference);
    }

    /// <summary>
    /// Creates a reference with the specified reference value and type.
    /// </summary>
    /// <param name="reference">The reference value.</param>
    /// <param name="type">The resource type.</param>
    /// <returns>A new Reference instance.</returns>
    public static Reference To(string reference, string type)
    {
        return new Reference(reference, type);
    }

    /// <summary>
    /// Gets the reference as a string.
    /// </summary>
    /// <returns>The reference string or identifier representation.</returns>
    public string? GetReferenceString()
    {
        if (!string.IsNullOrEmpty(ReferenceValue?.Value))
            return ReferenceValue.Value;
        
        if (Identifier != null)
            return $"{Identifier.System?.Value}|{Identifier.Value?.Value}";
        
        return null;
    }

    /// <summary>
    /// Validates the Reference according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    protected override IEnumerable<ValidationResult> ValidateComplexType(ValidationContext validationContext)
    {
        // At least one of reference, identifier and display SHALL be present
        if (string.IsNullOrEmpty(ReferenceValue?.Value) && 
            Identifier == null && 
            string.IsNullOrEmpty(Display?.Value))
        {
            yield return new ValidationResult(
                "At least one of reference, identifier and display SHALL be present",
                [nameof(ReferenceValue), nameof(Identifier), nameof(Display)]);
        }
    }

    protected override string? GetComplexTypeString()
    {
        var refStr = GetReferenceString();
        var typeStr = !string.IsNullOrEmpty(Type?.Value) ? $" ({Type.Value})" : "";
        var displayStr = !string.IsNullOrEmpty(Display?.Value) ? $" \"{Display.Value}\"" : "";
        return $"Reference: {refStr}{typeStr}{displayStr}";
    }
}

/// <summary>
/// A strongly-typed reference that can point to one of the specified resource types.
/// </summary>
/// <typeparam name="T1">First allowed resource type.</typeparam>
public class Reference<T1> : Reference 
    where T1 : Resource
{
    /// <summary>
    /// Gets the allowed target resource types.
    /// </summary>
    [JsonIgnore]
    public string[] AllowedTypes => [typeof(T1).Name];

    /// <summary>
    /// Initializes a new instance of the Reference class.
    /// </summary>
    public Reference() { }

    /// <summary>
    /// Initializes a new instance of the Reference class with a reference value.
    /// </summary>
    /// <param name="reference">The reference value.</param>
    public Reference(string reference) : base(reference) { }

    /// <summary>
    /// Creates a reference with the specified reference value.
    /// </summary>
    /// <param name="reference">The reference value.</param>
    /// <returns>A new Reference instance.</returns>
    public static new Reference<T1> To(string reference)
    {
        return new Reference<T1>(reference);
    }

    /// <summary>
    /// Validates that the reference type is one of the allowed types.
    /// </summary>
    protected override IEnumerable<ValidationResult> ValidateComplexType(ValidationContext validationContext)
    {
        foreach (var result in base.ValidateComplexType(validationContext))
        {
            yield return result;
        }

        // Validate that type is one of the allowed types
        if (Type?.Value != null && !AllowedTypes.Contains(Type.Value))
        {
            yield return new ValidationResult(
                $"Reference type '{Type.Value}' is not allowed. Must be one of: {string.Join(", ", AllowedTypes)}",
                [nameof(Type)]);
        }
    }

    protected override string? GetComplexTypeString()
    {
        var refStr = GetReferenceString();
        var displayStr = !string.IsNullOrEmpty(Display?.Value) ? $" \"{Display.Value}\"" : "";
        return $"Reference<{string.Join(", ", AllowedTypes)}>: {refStr}{displayStr}";
    }
}

/// <summary>
/// A strongly-typed reference that can point to one of two specified resource types.
/// </summary>
/// <typeparam name="T1">First allowed resource type.</typeparam>
/// <typeparam name="T2">Second allowed resource type.</typeparam>
public class Reference<T1, T2> : Reference 
    where T1 : Resource 
    where T2 : Resource
{
    /// <summary>
    /// Gets the allowed target resource types.
    /// </summary>
    [JsonIgnore]
    public string[] AllowedTypes => [typeof(T1).Name, typeof(T2).Name];

    /// <summary>
    /// Initializes a new instance of the Reference class.
    /// </summary>
    public Reference() { }

    /// <summary>
    /// Initializes a new instance of the Reference class with a reference value.
    /// </summary>
    /// <param name="reference">The reference value.</param>
    public Reference(string reference) : base(reference) { }

    /// <summary>
    /// Creates a reference with the specified reference value.
    /// </summary>
    /// <param name="reference">The reference value.</param>
    /// <returns>A new Reference instance.</returns>
    public static new Reference<T1, T2> To(string reference)
    {
        return new Reference<T1, T2>(reference);
    }

    /// <summary>
    /// Validates that the reference type is one of the allowed types.
    /// </summary>
    protected override IEnumerable<ValidationResult> ValidateComplexType(ValidationContext validationContext)
    {
        foreach (var result in base.ValidateComplexType(validationContext))
        {
            yield return result;
        }

        // Validate that type is one of the allowed types
        if (Type?.Value != null && !AllowedTypes.Contains(Type.Value))
        {
            yield return new ValidationResult(
                $"Reference type '{Type.Value}' is not allowed. Must be one of: {string.Join(", ", AllowedTypes)}",
                [nameof(Type)]);
        }
    }

    protected override string? GetComplexTypeString()
    {
        var refStr = GetReferenceString();
        var displayStr = !string.IsNullOrEmpty(Display?.Value) ? $" \"{Display.Value}\"" : "";
        return $"Reference<{string.Join(", ", AllowedTypes)}>: {refStr}{displayStr}";
    }
}

/// <summary>
/// A strongly-typed reference that can point to one of three specified resource types.
/// </summary>
/// <typeparam name="T1">First allowed resource type.</typeparam>
/// <typeparam name="T2">Second allowed resource type.</typeparam>
/// <typeparam name="T3">Third allowed resource type.</typeparam>
public class Reference<T1, T2, T3> : Reference
    where T1 : Resource
    where T2 : Resource
    where T3 : Resource
{
    /// <summary>
    /// Gets the allowed target resource types.
    /// </summary>
    [JsonIgnore]
    public string[] AllowedTypes => [typeof(T1).Name, typeof(T2).Name, typeof(T3).Name];

    /// <summary>
    /// Initializes a new instance of the Reference class.
    /// </summary>
    public Reference() { }

    /// <summary>
    /// Initializes a new instance of the Reference class with a reference value.
    /// </summary>
    /// <param name="reference">The reference value.</param>
    public Reference(string reference) : base(reference) { }

    /// <summary>
    /// Creates a reference with the specified reference value.
    /// </summary>
    /// <param name="reference">The reference value.</param>
    /// <returns>A new Reference instance.</returns>
    public static new Reference<T1, T2, T3> To(string reference)
    {
        return new Reference<T1, T2, T3>(reference);
    }

    /// <summary>
    /// Validates that the reference type is one of the allowed types.
    /// </summary>
    protected override IEnumerable<ValidationResult> ValidateComplexType(ValidationContext validationContext)
    {
        foreach (var result in base.ValidateComplexType(validationContext))
        {
            yield return result;
        }

        // Validate that type is one of the allowed types
        if (Type?.Value != null && !AllowedTypes.Contains(Type.Value))
        {
            yield return new ValidationResult(
                $"Reference type '{Type.Value}' is not allowed. Must be one of: {string.Join(", ", AllowedTypes)}",
                [nameof(Type)]);
        }
    }

    protected override string? GetComplexTypeString()
    {
        var refStr = GetReferenceString();
        var displayStr = !string.IsNullOrEmpty(Display?.Value) ? $" \"{Display.Value}\"" : "";
        return $"Reference<{string.Join(", ", AllowedTypes)}>: {refStr}{displayStr}";
    }
}

/// <summary>
/// A strongly-typed reference that can point to one of four specified resource types.
/// </summary>
/// <typeparam name="T1">First allowed resource type.</typeparam>
/// <typeparam name="T2">Second allowed resource type.</typeparam>
/// <typeparam name="T3">Third allowed resource type.</typeparam>
/// <typeparam name="T4">Fourth allowed resource type.</typeparam>
public class Reference<T1, T2, T3, T4> : Reference
    where T1 : Resource
    where T2 : Resource
    where T3 : Resource
    where T4 : Resource
{
    /// <summary>
    /// Gets the allowed target resource types.
    /// </summary>
    [JsonIgnore]
    public string[] AllowedTypes => [typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name];

    /// <summary>
    /// Initializes a new instance of the Reference class.
    /// </summary>
    public Reference() { }

    /// <summary>
    /// Initializes a new instance of the Reference class with a reference value.
    /// </summary>
    /// <param name="reference">The reference value.</param>
    public Reference(string reference) : base(reference) { }

    /// <summary>
    /// Creates a reference with the specified reference value.
    /// </summary>
    /// <param name="reference">The reference value.</param>
    /// <returns>A new Reference instance.</returns>
    public static new Reference<T1, T2, T3, T4> To(string reference)
    {
        return new Reference<T1, T2, T3, T4>(reference);
    }

    /// <summary>
    /// Validates that the reference type is one of the allowed types.
    /// </summary>
    protected override IEnumerable<ValidationResult> ValidateComplexType(ValidationContext validationContext)
    {
        foreach (var result in base.ValidateComplexType(validationContext))
        {
            yield return result;
        }

        // Validate that type is one of the allowed types
        if (Type?.Value != null && !AllowedTypes.Contains(Type.Value))
        {
            yield return new ValidationResult(
                $"Reference type '{Type.Value}' is not allowed. Must be one of: {string.Join(", ", AllowedTypes)}",
                [nameof(Type)]);
        }
    }

    protected override string? GetComplexTypeString()
    {
        var refStr = GetReferenceString();
        var displayStr = !string.IsNullOrEmpty(Display?.Value) ? $" \"{Display.Value}\"" : "";
        return $"Reference<{string.Join(", ", AllowedTypes)}>: {refStr}{displayStr}";
    }
}
