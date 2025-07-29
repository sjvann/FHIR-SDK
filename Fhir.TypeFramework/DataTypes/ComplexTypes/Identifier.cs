using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Identifier - 識別碼型別
/// 用於在 FHIR 資源中表示識別碼
/// </summary>
/// <remarks>
/// FHIR R5 Identifier (Complex Type)
/// An identifier for this resource.
/// 
/// Structure:
/// - use: code (0..1) - usual | official | temp | secondary | old (If known)
/// - type: CodeableConcept (0..1) - Description of identifier
/// - system: uri (0..1) - The namespace for the identifier value
/// - value: string (0..1) - The value that is unique
/// - period: Period (0..1) - Time period when id is/was valid for use
/// - assigner: Reference (0..1) - Organization that issued id (may be just text)
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Identifier : UnifiedComplexTypeBase<Identifier>
{
    /// <summary>
    /// 識別碼的使用目的
    /// FHIR Path: Identifier.use
    /// Cardinality: 0..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("use")]
    public FhirCode? Use { get; set; }

    /// <summary>
    /// 識別碼的類型描述
    /// FHIR Path: Identifier.type
    /// Cardinality: 0..1
    /// Type: CodeableConcept
    /// </summary>
    [JsonPropertyName("type")]
    public CodeableConcept? Type { get; set; }

    /// <summary>
    /// 識別碼值的命名空間
    /// FHIR Path: Identifier.system
    /// Cardinality: 0..1
    /// Type: uri
    /// </summary>
    [JsonPropertyName("system")]
    public FhirUri? System { get; set; }

    /// <summary>
    /// 識別碼的值
    /// FHIR Path: Identifier.value
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("value")]
    public FhirString? Value { get; set; }

    /// <summary>
    /// 識別碼有效的時間週期
    /// FHIR Path: Identifier.period
    /// Cardinality: 0..1
    /// Type: Period
    /// </summary>
    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    /// <summary>
    /// 發行識別碼的組織
    /// FHIR Path: Identifier.assigner
    /// Cardinality: 0..1
    /// Type: Reference
    /// </summary>
    [JsonPropertyName("assigner")]
    public Reference? Assigner { get; set; }

    /// <summary>
    /// 檢查是否有使用目的
    /// </summary>
    /// <returns>如果存在使用目的則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasUse => !string.IsNullOrEmpty(Use?.Value);

    /// <summary>
    /// 檢查是否有類型
    /// </summary>
    /// <returns>如果存在類型則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasType => Type != null;

    /// <summary>
    /// 檢查是否有系統
    /// </summary>
    /// <returns>如果存在系統則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasSystem => !string.IsNullOrEmpty(System?.Value);

    /// <summary>
    /// 檢查是否有值
    /// </summary>
    /// <returns>如果存在值則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasValue => !string.IsNullOrEmpty(Value?.Value);

    /// <summary>
    /// 檢查是否有週期
    /// </summary>
    /// <returns>如果存在週期則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasPeriod => Period != null;

    /// <summary>
    /// 檢查是否有發行者
    /// </summary>
    /// <returns>如果存在發行者則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasAssigner => Assigner != null;

    /// <summary>
    /// 取得顯示文字
    /// </summary>
    /// <returns>顯示文字</returns>
    [JsonIgnore]
    public string? DisplayText
    {
        get
        {
            var parts = new List<string>();
            
            if (HasSystem)
            {
                parts.Add(System?.Value);
            }
            
            if (HasValue)
            {
                parts.Add(Value?.Value);
            }
            
            if (HasType && Type?.HasText == true)
            {
                parts.Add($"({Type.Text?.Value})");
            }
            
            return parts.Any() ? string.Join(" ", parts) : null;
        }
    }

    protected override void CopyFieldsTo(Identifier target)
    {
        target.Use = Use?.DeepCopy() as FhirCode;
        target.Type = Type?.DeepCopy() as CodeableConcept;
        target.System = System?.DeepCopy() as FhirUri;
        target.Value = Value?.DeepCopy() as FhirString;
        target.Period = Period?.DeepCopy() as Period;
        target.Assigner = Assigner?.DeepCopy() as Reference;
    }

    protected override bool FieldsAreExactly(Identifier other)
    {
        return DeepEqualityComparer.AreEqual(Use, other.Use) &&
               DeepEqualityComparer.AreEqual(Type, other.Type) &&
               DeepEqualityComparer.AreEqual(System, other.System) &&
               DeepEqualityComparer.AreEqual(Value, other.Value) &&
               DeepEqualityComparer.AreEqual(Period, other.Period) &&
               DeepEqualityComparer.AreEqual(Assigner, other.Assigner);
    }

    protected override IEnumerable<ValidationResult> ValidateFields(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();

        // 驗證 Use
        if (Use != null)
        {
            results.AddRange(Use.Validate(validationContext));
        }

        // 驗證 Type
        if (Type != null)
        {
            results.AddRange(Type.Validate(validationContext));
        }

        // 驗證 System
        if (System != null)
        {
            results.AddRange(System.Validate(validationContext));
        }

        // 驗證 Value
        if (Value != null)
        {
            results.AddRange(Value.Validate(validationContext));
        }

        // 驗證 Period
        if (Period != null)
        {
            results.AddRange(Period.Validate(validationContext));
        }

        // 驗證 Assigner
        if (Assigner != null)
        {
            results.AddRange(Assigner.Validate(validationContext));
        }

        return results;
    }
} 