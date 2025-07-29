using Fhir.TypeFramework.Bases;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// {TypeName} - {Description}
/// </summary>
/// <remarks>
/// FHIR R5 {TypeName} PrimitiveType
/// {DetailedDescription}
/// 
/// JSON Representation:
/// - Simple: "{jsonExample}"
/// - Full: "{jsonFullExample}"
/// </remarks>
public class {ClassName} : {BaseClass}
{
    /// <summary>
    /// {ValueDescription}
    /// </summary>
    [JsonIgnore]
    public {ValueType}? Value
    {
        get => {GetValueExpression};
        set => {SetValueExpression};
    }

    /// <summary>
    /// Initializes a new instance of the {ClassName} class.
    /// </summary>
    public {ClassName}() { }
    
    /// <summary>
    /// Initializes a new instance of the {ClassName} class with the specified value.
    /// </summary>
    /// <param name="value">The {ValueType} value.</param>
    public {ClassName}({ValueType}? value) : base(value) { }
    
    /// <summary>
    /// Implicitly converts a {ValueType} to a {ClassName}.
    /// </summary>
    /// <param name="value">The {ValueType} value to convert.</param>
    /// <returns>A {ClassName} instance, or null if the value is null.</returns>
    public static implicit operator {ClassName}?({ValueType}? value)
    {
        return CreateFromValue<{ClassName}>(value);
    }
    
    /// <summary>
    /// Implicitly converts a {ClassName} to a {ValueType}.
    /// </summary>
    /// <param name="instance">The {ClassName} to convert.</param>
    /// <returns>The {ValueType} value, or null if the {ClassName} is null.</returns>
    public static implicit operator {ValueType}?({ClassName}? instance)
    {
        return GetValue<{ClassName}>(instance);
    }
    
    /// <summary>
    /// {ParseValueDescription}
    /// </summary>
    /// <param name="value">要解析的字串</param>
    /// <returns>解析後的{ValueType}值</returns>
    protected override {ValueType}? {ParseValueMethod}(string value)
    {
        {ParseValueImplementation}
    }

    /// <summary>
    /// {ValidateValueDescription}
    /// </summary>
    /// <param name="value">要驗證的{ValueType}值</param>
    /// <returns>如果值符合規範則為 true，否則為 false</returns>
    protected override bool {ValidateValueMethod}({ValueType} value)
    {
        {ValidateValueImplementation}
    }
} 