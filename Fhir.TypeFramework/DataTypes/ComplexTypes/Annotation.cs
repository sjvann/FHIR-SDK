using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.TypeFramework.DataTypes.ComplexTypes;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Annotation - 註解型別
/// 用於在 FHIR 資源中添加註解資訊
/// </summary>
/// <remarks>
/// FHIR R5 Annotation (Complex Type)
/// A text note which also contains information about who made the statement and when.
/// 
/// Structure:
/// - author[x]: Reference|string (0..1) - Individual responsible for the annotation
/// - time: dateTime (0..1) - When the annotation was made
/// - text: markdown (1..1) - The annotation - text content (as markdown)
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Annotation : UnifiedComplexTypeBase<Annotation>
{
    /// <summary>
    /// 註解的作者 - 使用 Choice Type 支援 Reference 或 string
    /// FHIR Path: Annotation.author[x]
    /// Cardinality: 0..1
    /// Type: Reference(Organization|Patient|Practitioner|PractitionerRole|RelatedPerson)|string
    /// 根據 FHIR R5 規範，author[x] 可以是 Reference 或 string
    /// </summary>
    [JsonPropertyName("author")]
    public AnnotationAuthorChoice? Author { get; set; }

    /// <summary>
    /// 註解的時間
    /// FHIR Path: Annotation.time
    /// Cardinality: 0..1
    /// Type: dateTime
    /// </summary>
    [JsonPropertyName("time")]
    public FhirDateTime? Time { get; set; }

    /// <summary>
    /// 註解的文字內容（markdown 格式）
    /// FHIR Path: Annotation.text
    /// Cardinality: 1..1
    /// Type: markdown
    /// </summary>
    [JsonPropertyName("text")]
    [Required(ErrorMessage = "Annotation text is required")]
    public FhirMarkdown? Text { get; set; }

    /// <summary>
    /// 檢查是否有作者
    /// </summary>
    /// <returns>如果存在作者則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasAuthor => Author != null;

    /// <summary>
    /// 檢查是否有時間
    /// </summary>
    /// <returns>如果存在時間則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasTime => Time?.Value != null;

    /// <summary>
    /// 檢查是否有文字
    /// </summary>
    /// <returns>如果存在文字則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasText => !string.IsNullOrEmpty(Text?.Value);

    /// <summary>
    /// 檢查註解是否有效
    /// </summary>
    /// <returns>如果註解有效則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool IsValid => HasText;

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

            var parts = new List<string>();
            
            if (HasText)
            {
                parts.Add(Text?.Value);
            }
            
            if (HasAuthor)
            {
                parts.Add($"by {Author}");
            }
            
            if (HasTime)
            {
                parts.Add($"at {Time?.Value}");
            }
            
            return parts.Any() ? string.Join(" ", parts) : null;
        }
    }

    protected override void CopyFieldsTo(Annotation target)
    {
        target.Author = Author?.DeepCopy() as AnnotationAuthorChoice;
        target.Time = Time?.DeepCopy() as FhirDateTime;
        target.Text = Text?.DeepCopy() as FhirMarkdown;
    }

    protected override bool FieldsAreExactly(Annotation other)
    {
        return DeepEqualityComparer.AreEqual(Author, other.Author) &&
               DeepEqualityComparer.AreEqual(Time, other.Time) &&
               DeepEqualityComparer.AreEqual(Text, other.Text);
    }

    protected override IEnumerable<ValidationResult> ValidateFields(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();

        // 驗證 Author
        if (Author != null)
        {
            results.AddRange(Author.Validate(validationContext));
        }

        // 驗證 Time
        if (Time != null)
        {
            results.AddRange(Time.Validate(validationContext));
        }

        // 驗證 Text
        if (Text != null)
        {
            results.AddRange(Text.Validate(validationContext));
        }
        else
        {
            results.Add(new ValidationResult("Annotation.text is required"));
        }

        return results;
    }
} 