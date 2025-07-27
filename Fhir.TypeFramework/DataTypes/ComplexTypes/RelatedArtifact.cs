using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// RelatedArtifact - 相關文件
/// 用於描述相關的文件、引用等
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
/// </remarks>
public class RelatedArtifact : Element, IExtensibleTypeFramework
{
    /// <summary>
    /// documentation | justification | citation | predecessor | successor | derived-from | depends-on | composed-of
    /// FHIR Path: RelatedArtifact.type
    /// Cardinality: 1..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("type")]
    public FhirCode Type { get; set; } = new();

    /// <summary>
    /// Short label
    /// FHIR Path: RelatedArtifact.label
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("label")]
    public FhirString? Label { get; set; }

    /// <summary>
    /// Brief description of the related artifact
    /// FHIR Path: RelatedArtifact.display
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("display")]
    public FhirString? Display { get; set; }

    /// <summary>
    /// Bibliographic citation for the artifact
    /// FHIR Path: RelatedArtifact.citation
    /// Cardinality: 0..1
    /// Type: markdown
    /// </summary>
    [JsonPropertyName("citation")]
    public FhirMarkdown? Citation { get; set; }

    /// <summary>
    /// Where the artifact can be accessed
    /// FHIR Path: RelatedArtifact.url
    /// Cardinality: 0..1
    /// Type: url
    /// </summary>
    [JsonPropertyName("url")]
    public FhirUrl? Url { get; set; }

    /// <summary>
    /// The document being referenced
    /// FHIR Path: RelatedArtifact.document
    /// Cardinality: 0..1
    /// Type: Attachment
    /// </summary>
    [JsonPropertyName("document")]
    public Attachment? Document { get; set; }

    /// <summary>
    /// What artifact is being referenced
    /// FHIR Path: RelatedArtifact.resource
    /// Cardinality: 0..1
    /// Type: canonical
    /// </summary>
    [JsonPropertyName("resource")]
    public FhirCanonical? Resource { get; set; }

    /// <summary>
    /// 檢查是否有 URL
    /// </summary>
    /// <returns>如果存在 URL 則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasUrl => !string.IsNullOrEmpty(Url);

    /// <summary>
    /// 檢查是否有文件
    /// </summary>
    /// <returns>如果存在文件則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasDocument => Document != null;

    /// <summary>
    /// 檢查是否有資源引用
    /// </summary>
    /// <returns>如果存在資源引用則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasResource => !string.IsNullOrEmpty(Resource);

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>RelatedArtifact 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = new RelatedArtifact
        {
            Id = Id,
            Type = Type,
            Label = Label,
            Display = Display,
            Citation = Citation,
            Url = Url,
            Resource = Resource
        };

        if (Document != null)
        {
            copy.Document = Document.DeepCopy() as Attachment;
        }

        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 RelatedArtifact 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not RelatedArtifact otherArtifact)
            return false;

        return base.IsExactly(other) &&
               Equals(Type, otherArtifact.Type) &&
               Equals(Label, otherArtifact.Label) &&
               Equals(Display, otherArtifact.Display) &&
               Equals(Citation, otherArtifact.Citation) &&
               Equals(Url, otherArtifact.Url) &&
               Equals(Document, otherArtifact.Document) &&
               Equals(Resource, otherArtifact.Resource);
    }

    /// <summary>
    /// 驗證 RelatedArtifact 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證 Type
        if (string.IsNullOrEmpty(Type))
        {
            yield return new ValidationResult("RelatedArtifact.type is required");
        }
        else
        {
            var validTypes = new[] { "documentation", "justification", "citation", "predecessor", "successor", "derived-from", "depends-on", "composed-of" };
            if (!validTypes.Contains(Type))
            {
                yield return new ValidationResult($"RelatedArtifact.type '{Type}' is not a valid type");
            }
        }

        // 驗證 URL 格式
        if (!string.IsNullOrEmpty(Url) && !Uri.IsWellFormedUriString(Url, UriKind.Absolute))
        {
            yield return new ValidationResult($"RelatedArtifact.url '{Url}' must be a valid absolute URI");
        }

        // 驗證 Document
        if (Document != null)
        {
            var documentValidationContext = new ValidationContext(Document);
            foreach (var result in Document.Validate(documentValidationContext))
            {
                yield return result;
            }
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
} 