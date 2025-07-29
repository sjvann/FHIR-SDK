using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.ComplexTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.Bases;

/// <summary>
/// MetadataResource - 元資料資源
/// 具有元資料性質的 FHIR 資源基礎類別
/// </summary>
/// <remarks>
/// FHIR R5 MetadataResource (Abstract)
/// A resource that is defined as part of the FHIR specification and contains metadata about other resources.
/// Metadata resources are those that contain metadata about other resources or the system.
/// They include resources like StructureDefinition, ValueSet, CodeSystem, etc.
/// 
/// Structure:
/// - approvalDate: date (0..1) - When the resource was approved by publisher
/// - lastReviewDate: date (0..1) - When the resource was last reviewed
/// - effectivePeriod: Period (0..1) - When the resource is expected to be used
/// - topic: CodeableConcept[] (0..*) - E.g. Education, Treatment, Assessment, etc.
/// - author: ContactDetail[] (0..*) - Who authored the resource
/// - editor: ContactDetail[] (0..*) - Who edited the resource
/// - reviewer: ContactDetail[] (0..*) - Who reviewed the resource
/// - endorser: ContactDetail[] (0..*) - Who endorsed the resource
/// - relatedArtifact: RelatedArtifact[] (0..*) - Additional documentation, citations, etc.
/// </remarks>
public abstract class MetadataResource : DomainResource, IMetadataResource
{
    /// <summary>
    /// When the resource was approved by publisher
    /// FHIR Path: MetadataResource.approvalDate
    /// Cardinality: 0..1
    /// Type: date
    /// </summary>
    [JsonPropertyName("approvalDate")]
    public FhirDate? ApprovalDate { get; set; }

    /// <summary>
    /// When the resource was last reviewed
    /// FHIR Path: MetadataResource.lastReviewDate
    /// Cardinality: 0..1
    /// Type: date
    /// </summary>
    [JsonPropertyName("lastReviewDate")]
    public FhirDate? LastReviewDate { get; set; }

    /// <summary>
    /// When the resource is expected to be used
    /// FHIR Path: MetadataResource.effectivePeriod
    /// Cardinality: 0..1
    /// Type: Period
    /// </summary>
    [JsonPropertyName("effectivePeriod")]
    public Period? EffectivePeriod { get; set; }

    /// <summary>
    /// E.g. Education, Treatment, Assessment, etc.
    /// FHIR Path: MetadataResource.topic
    /// Cardinality: 0..*
    /// Type: CodeableConcept[]
    /// </summary>
    [JsonPropertyName("topic")]
    public IList<CodeableConcept>? Topic { get; set; }

    /// <summary>
    /// Who authored the resource
    /// FHIR Path: MetadataResource.author
    /// Cardinality: 0..*
    /// Type: ContactDetail[]
    /// </summary>
    [JsonPropertyName("author")]
    public IList<ContactDetail>? Author { get; set; }

    /// <summary>
    /// Who edited the resource
    /// FHIR Path: MetadataResource.editor
    /// Cardinality: 0..*
    /// Type: ContactDetail[]
    /// </summary>
    [JsonPropertyName("editor")]
    public IList<ContactDetail>? Editor { get; set; }

    /// <summary>
    /// Who reviewed the resource
    /// FHIR Path: MetadataResource.reviewer
    /// Cardinality: 0..*
    /// Type: ContactDetail[]
    /// </summary>
    [JsonPropertyName("reviewer")]
    public IList<ContactDetail>? Reviewer { get; set; }

    /// <summary>
    /// Who endorsed the resource
    /// FHIR Path: MetadataResource.endorser
    /// Cardinality: 0..*
    /// Type: ContactDetail[]
    /// </summary>
    [JsonPropertyName("endorser")]
    public IList<ContactDetail>? Endorser { get; set; }

    /// <summary>
    /// Additional documentation, citations, etc.
    /// FHIR Path: MetadataResource.relatedArtifact
    /// Cardinality: 0..*
    /// Type: RelatedArtifact[]
    /// </summary>
    [JsonPropertyName("relatedArtifact")]
    public IList<RelatedArtifact>? RelatedArtifact { get; set; }

    /// <summary>
    /// 檢查是否有核准日期
    /// </summary>
    /// <returns>如果存在核准日期則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasApprovalDate => ApprovalDate != null;

    /// <summary>
    /// 檢查是否有最後審查日期
    /// </summary>
    /// <returns>如果存在最後審查日期則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasLastReviewDate => LastReviewDate != null;

    /// <summary>
    /// 檢查是否有有效期間
    /// </summary>
    /// <returns>如果存在有效期間則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasEffectivePeriod => EffectivePeriod != null;

    /// <summary>
    /// 檢查是否有主題
    /// </summary>
    /// <returns>如果存在主題則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasTopic => Topic?.Any() == true;

    /// <summary>
    /// 檢查是否有作者
    /// </summary>
    /// <returns>如果存在作者則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasAuthor => Author?.Any() == true;

    /// <summary>
    /// 檢查是否有編輯者
    /// </summary>
    /// <returns>如果存在編輯者則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasEditor => Editor?.Any() == true;

    /// <summary>
    /// 檢查是否有審查者
    /// </summary>
    /// <returns>如果存在審查者則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasReviewer => Reviewer?.Any() == true;

    /// <summary>
    /// 檢查是否有背書者
    /// </summary>
    /// <returns>如果存在背書者則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasEndorser => Endorser?.Any() == true;

    /// <summary>
    /// 檢查是否有相關文件
    /// </summary>
    /// <returns>如果存在相關文件則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasRelatedArtifact => RelatedArtifact?.Any() == true;

    /// <summary>
    /// 添加主題
    /// </summary>
    /// <param name="topic">主題</param>
    public void AddTopic(CodeableConcept topic)
    {
        Topic ??= new List<CodeableConcept>();
        Topic.Add(topic);
    }

    /// <summary>
    /// 添加作者
    /// </summary>
    /// <param name="author">作者</param>
    public void AddAuthor(ContactDetail author)
    {
        Author ??= new List<ContactDetail>();
        Author.Add(author);
    }

    /// <summary>
    /// 添加編輯者
    /// </summary>
    /// <param name="editor">編輯者</param>
    public void AddEditor(ContactDetail editor)
    {
        Editor ??= new List<ContactDetail>();
        Editor.Add(editor);
    }

    /// <summary>
    /// 添加審查者
    /// </summary>
    /// <param name="reviewer">審查者</param>
    public void AddReviewer(ContactDetail reviewer)
    {
        Reviewer ??= new List<ContactDetail>();
        Reviewer.Add(reviewer);
    }

    /// <summary>
    /// 添加背書者
    /// </summary>
    /// <param name="endorser">背書者</param>
    public void AddEndorser(ContactDetail endorser)
    {
        Endorser ??= new List<ContactDetail>();
        Endorser.Add(endorser);
    }

    /// <summary>
    /// 添加相關文件
    /// </summary>
    /// <param name="relatedArtifact">相關文件</param>
    public void AddRelatedArtifact(RelatedArtifact relatedArtifact)
    {
        RelatedArtifact ??= new List<RelatedArtifact>();
        RelatedArtifact.Add(relatedArtifact);
    }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>MetadataResource 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = (MetadataResource)MemberwiseClone();

        // 深層複製 EffectivePeriod
        if (EffectivePeriod != null)
        {
            copy.EffectivePeriod = EffectivePeriod.DeepCopy() as Period;
        }

        // 深層複製 Topic
        if (Topic != null)
        {
            copy.Topic = Topic.Select(t => t.DeepCopy() as CodeableConcept).ToList();
        }

        // 深層複製 Author
        if (Author != null)
        {
            copy.Author = Author.Select(a => a.DeepCopy() as ContactDetail).ToList();
        }

        // 深層複製 Editor
        if (Editor != null)
        {
            copy.Editor = Editor.Select(e => e.DeepCopy() as ContactDetail).ToList();
        }

        // 深層複製 Reviewer
        if (Reviewer != null)
        {
            copy.Reviewer = Reviewer.Select(r => r.DeepCopy() as ContactDetail).ToList();
        }

        // 深層複製 Endorser
        if (Endorser != null)
        {
            copy.Endorser = Endorser.Select(e => e.DeepCopy() as ContactDetail).ToList();
        }

        // 深層複製 RelatedArtifact
        if (RelatedArtifact != null)
        {
            copy.RelatedArtifact = RelatedArtifact.Select(ra => ra.DeepCopy() as RelatedArtifact).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 MetadataResource 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not MetadataResource otherMetadata)
            return false;

        return base.IsExactly(other) &&
               Equals(ApprovalDate, otherMetadata.ApprovalDate) &&
               Equals(LastReviewDate, otherMetadata.LastReviewDate) &&
               Equals(EffectivePeriod, otherMetadata.EffectivePeriod) &&
               Topic?.Count == otherMetadata.Topic?.Count &&
               Author?.Count == otherMetadata.Author?.Count &&
               Editor?.Count == otherMetadata.Editor?.Count &&
               Reviewer?.Count == otherMetadata.Reviewer?.Count &&
               Endorser?.Count == otherMetadata.Endorser?.Count &&
               RelatedArtifact?.Count == otherMetadata.RelatedArtifact?.Count;
    }

    /// <summary>
    /// 驗證 MetadataResource 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證 EffectivePeriod
        if (EffectivePeriod != null)
        {
            var periodValidationContext = new ValidationContext(EffectivePeriod);
            foreach (var result in EffectivePeriod.Validate(periodValidationContext))
            {
                yield return result;
            }
        }

        // 驗證 Topic
        if (Topic != null)
        {
            foreach (var topic in Topic)
            {
                var topicValidationContext = new ValidationContext(topic);
                foreach (var result in topic.Validate(topicValidationContext))
                {
                    yield return result;
                }
            }
        }

        // 驗證 Author
        if (Author != null)
        {
            foreach (var author in Author)
            {
                var authorValidationContext = new ValidationContext(author);
                foreach (var result in author.Validate(authorValidationContext))
                {
                    yield return result;
                }
            }
        }

        // 驗證 Editor
        if (Editor != null)
        {
            foreach (var editor in Editor)
            {
                var editorValidationContext = new ValidationContext(editor);
                foreach (var result in editor.Validate(editorValidationContext))
                {
                    yield return result;
                }
            }
        }

        // 驗證 Reviewer
        if (Reviewer != null)
        {
            foreach (var reviewer in Reviewer)
            {
                var reviewerValidationContext = new ValidationContext(reviewer);
                foreach (var result in reviewer.Validate(reviewerValidationContext))
                {
                    yield return result;
                }
            }
        }

        // 驗證 Endorser
        if (Endorser != null)
        {
            foreach (var endorser in Endorser)
            {
                var endorserValidationContext = new ValidationContext(endorser);
                foreach (var result in endorser.Validate(endorserValidationContext))
                {
                    yield return result;
                }
            }
        }

        // 驗證 RelatedArtifact
        if (RelatedArtifact != null)
        {
            foreach (var relatedArtifact in RelatedArtifact)
            {
                var relatedArtifactValidationContext = new ValidationContext(relatedArtifact);
                foreach (var result in relatedArtifact.Validate(relatedArtifactValidationContext))
                {
                    yield return result;
                }
            }
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
} 