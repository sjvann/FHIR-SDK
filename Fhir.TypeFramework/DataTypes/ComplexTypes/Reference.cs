using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Reference - 參考型別
/// 用於在 FHIR 資源中引用其他資源
/// </summary>
/// <remarks>
/// FHIR R5 Reference (Complex Type)
/// A reference from one resource to another.
/// 
/// Structure:
/// - reference: string (0..1) - Literal reference, Relative, internal or absolute URL
/// - type: uri (0..1) - Type the reference refers to (e.g. "Patient")
/// - identifier: Identifier (0..1) - Logical reference, when literal reference is not known
/// - display: string (0..1) - Text alternative for the resource
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Reference : UnifiedComplexTypeBase<Reference>
{
    /// <summary>
    /// 字面參考 - 相對、內部或絕對 URL
    /// FHIR Path: Reference.reference
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("reference")]
    public FhirString? ReferenceId { get; set; }

    /// <summary>
    /// 參考的資源型別
    /// FHIR Path: Reference.type
    /// Cardinality: 0..1
    /// Type: uri
    /// </summary>
    [JsonPropertyName("type")]
    public FhirUri? Type { get; set; }

    /// <summary>
    /// 邏輯參考 - 當字面參考未知時使用
    /// FHIR Path: Reference.identifier
    /// Cardinality: 0..1
    /// Type: Identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public Identifier? Identifier { get; set; }

    /// <summary>
    /// 資源的文字替代
    /// FHIR Path: Reference.display
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("display")]
    public FhirString? Display { get; set; }

    /// <summary>
    /// 檢查是否有參考
    /// </summary>
    /// <returns>如果存在參考則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasReference => !string.IsNullOrEmpty(ReferenceId?.Value);

    /// <summary>
    /// 檢查是否有型別
    /// </summary>
    /// <returns>如果存在型別則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasType => !string.IsNullOrEmpty(Type?.Value);

    /// <summary>
    /// 檢查是否有識別碼
    /// </summary>
    /// <returns>如果存在識別碼則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasIdentifier => Identifier != null;

    /// <summary>
    /// 檢查是否有顯示文字
    /// </summary>
    /// <returns>如果存在顯示文字則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasDisplay => !string.IsNullOrEmpty(Display?.Value);

    /// <summary>
    /// 檢查參考是否有效
    /// </summary>
    /// <returns>如果參考有效則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool IsValid => HasReference || HasIdentifier;

    /// <summary>
    /// 取得顯示文字
    /// </summary>
    /// <returns>顯示文字</returns>
    [JsonIgnore]
    public string? DisplayText
    {
        get
        {
            if (HasDisplay)
            {
                return Display?.Value;
            }

            if (HasReference)
            {
                return ReferenceId?.Value;
            }

            if (HasIdentifier)
            {
                return Identifier?.DisplayText;
            }

            return null;
        }
    }

    protected override void CopyFieldsTo(Reference target)
    {
        target.ReferenceId = ReferenceId?.DeepCopy() as FhirString;
        target.Type = Type?.DeepCopy() as FhirUri;
        target.Identifier = Identifier?.DeepCopy() as Identifier;
        target.Display = Display?.DeepCopy() as FhirString;
    }

    protected override bool FieldsAreExactly(Reference other)
    {
        return DeepEqualityComparer.AreEqual(ReferenceId, other.ReferenceId) &&
               DeepEqualityComparer.AreEqual(Type, other.Type) &&
               DeepEqualityComparer.AreEqual(Identifier, other.Identifier) &&
               DeepEqualityComparer.AreEqual(Display, other.Display);
    }

    protected override IEnumerable<ValidationResult> ValidateFields(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();

        // 驗證 ReferenceId
        if (ReferenceId != null)
        {
            results.AddRange(ReferenceId.Validate(validationContext));
        }

        // 驗證 Type
        if (Type != null)
        {
            results.AddRange(Type.Validate(validationContext));
        }

        // 驗證 Identifier
        if (Identifier != null)
        {
            results.AddRange(Identifier.Validate(validationContext));
        }

        // 驗證 Display
        if (Display != null)
        {
            results.AddRange(Display.Validate(validationContext));
        }

        // 驗證參考邏輯
        if (!HasReference && !HasIdentifier)
        {
            results.Add(new ValidationResult("Reference must have either reference or identifier"));
        }

        return results;
    }
} 