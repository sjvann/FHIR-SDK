using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.DataTypes;
using Fhir.R4.Models.Converters;

namespace Fhir.R4.Models.Base;

/// <summary>
/// Optional Extension Element - may be used to represent additional information 
/// that is not part of the basic definition of the element.
/// 直接繼承 Base，避免與 Element 的循環依賴
/// </summary>
/// <remarks>
/// FHIR R4 Extension
/// Optional Extension Element - may be used to represent additional information 
/// that is not part of the basic definition of the element.
/// </remarks>
[JsonConverter(typeof(ExtensionConverter))]
public class Extension : Base
{
    /// <summary>
    /// Source of the definition for the extension code - a logical name or a URL.
    /// FHIR Path: Extension.url
    /// Cardinality: 1..1
    /// Required: Yes
    /// </summary>
    [JsonPropertyName("url")]
    public FhirUri? Url { get; set; }
    
    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types.
    /// 
    /// Choice Type: value[x]
    /// This is a choice element - only one of the following types may be present:
    ///   - base64Binary
    ///   - boolean
    ///   - canonical
    ///   - code
    ///   - date
    ///   - dateTime
    ///   - decimal
    ///   - id
    ///   - instant
    ///   - integer
    ///   - markdown
    ///   - oid
    ///   - positiveInt
    ///   - string
    ///   - time
    ///   - unsignedInt
    ///   - uri
    ///   - url
    ///   - uuid
    ///   - Address
    ///   - Age
    ///   - Annotation
    ///   - Attachment
    ///   - CodeableConcept
    ///   - Coding
    ///   - ContactPoint
    ///   - Count
    ///   - Distance
    ///   - Duration
    ///   - HumanName
    ///   - Identifier
    ///   - Money
    ///   - Period
    ///   - Quantity
    ///   - Range
    ///   - Ratio
    ///   - Reference
    ///   - SampledData
    ///   - Signature
    ///   - Timing
    /// </summary>
    [JsonIgnore]
    public ChoiceType<FhirString, FhirInteger, FhirBoolean, FhirDecimal>? ValueChoice { get; set; }
    
    // JSON 序列化屬性 - 常用的型別
    [JsonPropertyName("valueString")]
    public string? ValueString 
    { 
        get => ValueChoice?.AsT1()?.Value;
        set => ValueChoice = value != null ? new FhirString(value) : null;
    }
    
    [JsonPropertyName("valueInteger")]
    public int? ValueInteger 
    { 
        get => ValueChoice?.AsT2()?.Value;
        set => ValueChoice = value != null ? new FhirInteger(value) : null;
    }
    
    [JsonPropertyName("valueBoolean")]
    public bool? ValueBoolean 
    { 
        get => ValueChoice?.AsT3()?.Value;
        set => ValueChoice = value != null ? new FhirBoolean(value) : null;
    }
    
    [JsonPropertyName("valueDecimal")]
    public decimal? ValueDecimal 
    { 
        get => ValueChoice?.AsT4()?.Value;
        set => ValueChoice = value != null ? new FhirDecimal(value) : null;
    }
    
    // 注意：為了簡化，我們暫時只支援基本的 primitive types
    // 完整的實作會包含所有 FHIR 允許的型別
    
    // 巢狀 Extensions
    [JsonPropertyName("extension")]
    public List<Extension>? SubExtensions { get; set; }
    
    /// <summary>
    /// 便利屬性：取得或設定 Extension 的值
    /// 自動處理不同型別的 value[x] 屬性
    /// </summary>
    [JsonIgnore]
    public object? Value
    {
        get => ValueChoice?.Value;
        set 
        {
            if (ValueChoice == null)
                ValueChoice = new ChoiceType<FhirString, FhirInteger, FhirBoolean, FhirDecimal>();
            ValueChoice.Value = value;
        }
    }
    
    /// <summary>
    /// 取得目前設定的值型別名稱
    /// </summary>
    [JsonIgnore]
    public string? ValueTypeName => ValueChoice?.ValueTypeName;
    
    /// <summary>
    /// 檢查是否有 value[x] 設定
    /// </summary>
    [JsonIgnore]
    public bool HasValue => ValueChoice?.HasValue == true;
    
    /// <summary>
    /// 檢查是否有子 Extensions
    /// </summary>
    [JsonIgnore]
    public bool HasExtensions => SubExtensions?.Any() == true;
    
    /// <summary>
    /// FHIR 驗證：Extension 特定驗證
    /// </summary>
    public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // URL 是必要的
        if (Url?.Value == null)
        {
            yield return new ValidationResult("Extension.url is required");
        }
        else
        {
            // URL 格式驗證
            if (!Uri.IsWellFormedUriString(Url.Value, UriKind.Absolute) && !Url.Value.StartsWith("#"))
            {
                yield return new ValidationResult($"Extension.url '{Url.Value}' must be a valid URI or start with '#'");
            }
        }
        
        // Extension 必須有 value[x] 或子 extension，但不能兩者都有
        var hasValue = HasValue;
        var hasSubExtensions = HasExtensions;
        
        if (!hasValue && !hasSubExtensions)
        {
            yield return new ValidationResult("Extension must have either a value[x] or sub-extensions");
        }
        else if (hasValue && hasSubExtensions)
        {
            yield return new ValidationResult("Extension cannot have both a value[x] and sub-extensions");
        }
        
        // 驗證 value[x]
        if (ValueChoice != null)
        {
            var valueValidationContext = new ValidationContext(ValueChoice);
            foreach (var result in ValueChoice.Validate(valueValidationContext))
            {
                yield return result;
            }
        }
        
        // 驗證子 extensions
        if (SubExtensions != null)
        {
            foreach (var ext in SubExtensions)
            {
                var extValidationContext = new ValidationContext(ext);
                foreach (var result in ext.Validate(extValidationContext))
                {
                    yield return result;
                }
            }
        }
    }
}
