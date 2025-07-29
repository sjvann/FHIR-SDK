using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// RelatedArtifact - 相關成品型別
/// 用於在 FHIR 資源中表示相關成品資訊
/// </summary>
/// <remarks>
/// FHIR R5 RelatedArtifact (Complex Type)
/// Related artifacts such as additional documentation, justification, or bibliographic references.
/// 
/// Structure:
/// - type: code (1..1) - documentation | justification | citation | predecessor | successor | derived-from | depends-on | composed-of
/// - label: string (0..1) - Short label
/// - display: string (0..1) - Brief description of the related artifact
/// - citation: markdown (0..1) - Bibliographic citation for the artifact
/// - url: url (0..1) - Where the artifact can be accessed
/// - document: Attachment (0..1) - The document being referenced
/// - resource: canonical (0..1) - What artifact is being referenced
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class RelatedArtifact : UnifiedComplexTypeBase<RelatedArtifact>
{
    /// <summary>
    /// 相關成品的類型
    /// FHIR Path: RelatedArtifact.type
    /// Cardinality: 1..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("type")]
    [Required(ErrorMessage = "RelatedArtifact.type is required")]
    public FhirCode? Type { get; set; }

    /// <summary>
    /// 簡短標籤
    /// FHIR Path: RelatedArtifact.label
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("label")]
    public FhirString? Label { get; set; }

    /// <summary>
    /// 相關成品的簡要描述
    /// FHIR Path: RelatedArtifact.display
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("display")]
    public FhirString? Display { get; set; }

    /// <summary>
    /// 成品的書目引用
    /// FHIR Path: RelatedArtifact.citation
    /// Cardinality: 0..1
    /// Type: markdown
    /// </summary>
    [JsonPropertyName("citation")]
    public FhirMarkdown? Citation { get; set; }

    /// <summary>
    /// 可以存取成品的位置
    /// FHIR Path: RelatedArtifact.url
    /// Cardinality: 0..1
    /// Type: url
    /// </summary>
    [JsonPropertyName("url")]
    public FhirUrl? Url { get; set; }

    /// <summary>
    /// 被引用的文件
    /// FHIR Path: RelatedArtifact.document
    /// Cardinality: 0..1
    /// Type: Attachment
    /// </summary>
    [JsonPropertyName("document")]
    public Attachment? Document { get; set; }

    /// <summary>
    /// 被引用的成品
    /// FHIR Path: RelatedArtifact.resource
    /// Cardinality: 0..1
    /// Type: canonical
    /// </summary>
    [JsonPropertyName("resource")]
    public FhirCanonical? Resource { get; set; }

    /// <summary>
    /// 檢查是否有類型
    /// </summary>
    /// <returns>如果存在類型則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasType => !string.IsNullOrEmpty(Type?.Value);

    /// <summary>
    /// 檢查是否有標籤
    /// </summary>
    /// <returns>如果存在標籤則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasLabel => !string.IsNullOrEmpty(Label?.Value);

    /// <summary>
    /// 檢查是否有顯示
    /// </summary>
    /// <returns>如果存在顯示則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasDisplay => !string.IsNullOrEmpty(Display?.Value);

    /// <summary>
    /// 檢查是否有引用
    /// </summary>
    /// <returns>如果存在引用則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasCitation => !string.IsNullOrEmpty(Citation?.Value);

    /// <summary>
    /// 檢查是否有 URL
    /// </summary>
    /// <returns>如果存在 URL 則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasUrl => !string.IsNullOrEmpty(Url?.Value);

    /// <summary>
    /// 檢查是否有文件
    /// </summary>
    /// <returns>如果存在文件則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasDocument => Document != null;

    /// <summary>
    /// 檢查是否有資源
    /// </summary>
    /// <returns>如果存在資源則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasResource => !string.IsNullOrEmpty(Resource?.Value);

    /// <summary>
    /// 檢查相關成品是否有效
    /// </summary>
    /// <returns>如果相關成品有效則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool IsValid => HasType;

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
            
            if (HasLabel)
            {
                parts.Add(Label?.Value);
            }
            
            if (HasDisplay)
            {
                parts.Add(Display?.Value);
            }
            
            if (HasUrl)
            {
                parts.Add($"({Url?.Value})");
            }
            
            return parts.Any() ? string.Join(" ", parts) : Type?.Value;
        }
    }

    protected override void CopyFieldsTo(RelatedArtifact target)
    {
        target.Type = Type?.DeepCopy() as FhirCode;
        target.Label = Label?.DeepCopy() as FhirString;
        target.Display = Display?.DeepCopy() as FhirString;
        target.Citation = Citation?.DeepCopy() as FhirMarkdown;
        target.Url = Url?.DeepCopy() as FhirUrl;
        target.Document = Document?.DeepCopy() as Attachment;
        target.Resource = Resource?.DeepCopy() as FhirCanonical;
    }

    protected override bool FieldsAreExactly(RelatedArtifact other)
    {
        return DeepEqualityComparer.AreEqual(Type, other.Type) &&
               DeepEqualityComparer.AreEqual(Label, other.Label) &&
               DeepEqualityComparer.AreEqual(Display, other.Display) &&
               DeepEqualityComparer.AreEqual(Citation, other.Citation) &&
               DeepEqualityComparer.AreEqual(Url, other.Url) &&
               DeepEqualityComparer.AreEqual(Document, other.Document) &&
               DeepEqualityComparer.AreEqual(Resource, other.Resource);
    }

    protected override IEnumerable<ValidationResult> ValidateFields(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();

        // 驗證 Type
        if (Type != null)
        {
            results.AddRange(Type.Validate(validationContext));
        }
        else
        {
            results.Add(new ValidationResult("RelatedArtifact.type is required"));
        }

        // 驗證 Label
        if (Label != null)
        {
            results.AddRange(Label.Validate(validationContext));
        }

        // 驗證 Display
        if (Display != null)
        {
            results.AddRange(Display.Validate(validationContext));
        }

        // 驗證 Citation
        if (Citation != null)
        {
            results.AddRange(Citation.Validate(validationContext));
        }

        // 驗證 Url
        if (Url != null)
        {
            results.AddRange(Url.Validate(validationContext));
        }

        // 驗證 Document
        if (Document != null)
        {
            results.AddRange(Document.Validate(validationContext));
        }

        // 驗證 Resource
        if (Resource != null)
        {
            results.AddRange(Resource.Validate(validationContext));
        }

        // 驗證類型值
        if (HasType)
        {
            var validTypes = new[] { "documentation", "justification", "citation", "predecessor", "successor", "derived-from", "depends-on", "composed-of" };
            if (!validTypes.Contains(Type?.Value))
            {
                results.Add(new ValidationResult($"RelatedArtifact.type must be one of: {string.Join(", ", validTypes)}"));
            }
        }

        return results;
    }
} 