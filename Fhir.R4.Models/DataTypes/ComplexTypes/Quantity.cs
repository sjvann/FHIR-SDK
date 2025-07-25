using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// A measured amount (or an amount that can potentially be measured).
/// </summary>
/// <remarks>
/// FHIR R4 Quantity DataType
/// A measured amount (or an amount that can potentially be measured).
/// </remarks>
public class Quantity : DataType
{
    /// <summary>
    /// Numerical value (with implicit precision).
    /// FHIR Path: Quantity.value
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("value")]
    public decimal? Value { get; set; }
    
    /// <summary>
    /// How the value should be understood and represented - whether the actual value is greater or less than the stated value due to measurement issues; e.g. if the comparator is "&lt;" , then the real value is &lt; stated value.
    /// FHIR Path: Quantity.comparator
    /// Cardinality: 0..1
    /// Allowed values: &lt;, &lt;=, &gt;=, &gt;
    /// </summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }
    
    /// <summary>
    /// A human-readable form of the unit.
    /// FHIR Path: Quantity.unit
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
    
    /// <summary>
    /// The identification of the system that provides the coded form of the unit.
    /// FHIR Path: Quantity.system
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("system")]
    public string? System { get; set; }
    
    /// <summary>
    /// A computer processable form of the unit in some unit representation system.
    /// FHIR Path: Quantity.code
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
    
    /// <summary>
    /// Validates the Quantity according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;
            
        // 驗證 comparator 值
        if (!string.IsNullOrEmpty(Comparator))
        {
            var validComparators = new[] { "<", "<=", ">=", ">" };
            if (!validComparators.Contains(Comparator))
            {
                yield return new ValidationResult($"Quantity.comparator '{Comparator}' is not valid. Must be one of: {string.Join(", ", validComparators)}");
            }
        }
        
        // 如果有 system，通常也應該有 code
        if (!string.IsNullOrEmpty(System) && string.IsNullOrEmpty(Code))
        {
            yield return new ValidationResult("Quantity with system should typically have a code");
        }
        
        // 驗證 system 是否為有效的 URI
        if (!string.IsNullOrEmpty(System) && !Uri.IsWellFormedUriString(System, UriKind.Absolute))
        {
            yield return new ValidationResult($"Quantity.system '{System}' must be a valid URI");
        }
    }
}

/// <summary>
/// 具體的 Quantity 實作，用於解決抽象型別問題
/// </summary>
/// <remarks>
/// Concrete implementation of Quantity for use in scenarios requiring instantiation.
/// </remarks>
public class QuantityImpl : Quantity
{
    /// <summary>
    /// Initializes a new instance of the QuantityImpl class.
    /// </summary>
    public QuantityImpl() { }

    /// <summary>
    /// Initializes a new instance of the QuantityImpl class with a value and optional unit.
    /// </summary>
    /// <param name="value">The numerical value.</param>
    /// <param name="unit">The human-readable unit (optional).</param>
    public QuantityImpl(decimal? value, string? unit = null)
    {
        Value = value;
        Unit = unit;
    }

    /// <summary>
    /// Initializes a new instance of the QuantityImpl class with full quantity information.
    /// </summary>
    /// <param name="value">The numerical value.</param>
    /// <param name="unit">The human-readable unit.</param>
    /// <param name="system">The system that provides the coded form of the unit.</param>
    /// <param name="code">The computer processable form of the unit.</param>
    public QuantityImpl(decimal? value, string? unit, string? system, string? code)
    {
        Value = value;
        Unit = unit;
        System = system;
        Code = code;
    }
}
