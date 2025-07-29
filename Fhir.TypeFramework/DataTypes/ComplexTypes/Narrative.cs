using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Narrative - 敘述
/// 用於描述人類可讀的敘述內容
/// </summary>
/// <remarks>
/// FHIR R5 Narrative (Complex Type)
/// A human-readable summary of the resource conveying the essential clinical and business information.
/// 
/// Structure:
/// - status: code (1..1) - generated | extensions | additional | empty
/// - div: xhtml (1..1) - Limited xhtml content
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Narrative : UnifiedComplexTypeBase<Narrative>
{
    /// <summary>
    /// 狀態
    /// FHIR Path: Narrative.status
    /// Cardinality: 1..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("status")]
    [Required(ErrorMessage = "Narrative.status is required")]
    public FhirCode? Status { get; set; }

    /// <summary>
    /// 限制的 xhtml 內容
    /// FHIR Path: Narrative.div
    /// Cardinality: 1..1
    /// Type: xhtml
    /// </summary>
    [JsonPropertyName("div")]
    [Required(ErrorMessage = "Narrative.div is required")]
    public FhirXhtml? Div { get; set; }

    /// <summary>
    /// 檢查是否有狀態
    /// </summary>
    /// <returns>如果存在狀態則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasStatus => !string.IsNullOrEmpty(Status?.Value);

    /// <summary>
    /// 檢查是否有內容
    /// </summary>
    /// <returns>如果存在內容則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasDiv => !string.IsNullOrEmpty(Div?.Value);

    /// <summary>
    /// 檢查敘述是否有效
    /// </summary>
    /// <returns>如果敘述有效則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool IsValid => HasStatus && HasDiv;

    /// <summary>
    /// 取得顯示文字
    /// </summary>
    /// <returns>顯示文字</returns>
    [JsonIgnore]
    public string? DisplayText
    {
        get
        {
            if (!IsValid)
                return null;

            return Div?.Value;
        }
    }

    protected override void CopyFieldsTo(Narrative target)
    {
        target.Status = Status?.DeepCopy() as FhirCode;
        target.Div = Div?.DeepCopy() as FhirXhtml;
    }

    protected override bool FieldsAreExactly(Narrative other)
    {
        return DeepEqualityComparer.AreEqual(Status, other.Status) &&
               DeepEqualityComparer.AreEqual(Div, other.Div);
    }

    protected override IEnumerable<ValidationResult> ValidateFields(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();

        // 驗證 Status
        if (Status != null)
        {
            results.AddRange(Status.Validate(validationContext));
        }
        else
        {
            results.Add(new ValidationResult("Narrative.status is required"));
        }

        // 驗證 Div
        if (Div != null)
        {
            results.AddRange(Div.Validate(validationContext));
        }
        else
        {
            results.Add(new ValidationResult("Narrative.div is required"));
        }

        // 驗證狀態值
        if (HasStatus)
        {
            var validStatuses = new[] { "generated", "extensions", "additional", "empty" };
            if (!validStatuses.Contains(Status?.Value))
            {
                results.Add(new ValidationResult($"Narrative.status must be one of: {string.Join(", ", validStatuses)}"));
            }
        }

        return results;
    }
} 