using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Meta - 元資料型別
/// 用於在 FHIR 資源中表示元資料資訊
/// </summary>
/// <remarks>
/// FHIR R5 Meta (Complex Type)
/// Metadata about a resource.
/// 
/// Structure:
/// - versionId: id (0..1) - Version specific identifier
/// - lastUpdated: instant (0..1) - When the resource version last changed
/// - source: uri (0..1) - Identifies where the resource comes from
/// - profile: canonical[] (0..*) - Profiles this resource claims to conform to
/// - security: Coding[] (0..*) - Security labels applied to this resource
/// - tag: Coding[] (0..*) - Tags applied to this resource
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Meta : UnifiedComplexTypeBase<Meta>
{
    /// <summary>
    /// 版本特定識別碼
    /// FHIR Path: Meta.versionId
    /// Cardinality: 0..1
    /// Type: id
    /// </summary>
    [JsonPropertyName("versionId")]
    public FhirId? VersionId { get; set; }

    /// <summary>
    /// 資源版本最後變更的時間
    /// FHIR Path: Meta.lastUpdated
    /// Cardinality: 0..1
    /// Type: instant
    /// </summary>
    [JsonPropertyName("lastUpdated")]
    public FhirInstant? LastUpdated { get; set; }

    /// <summary>
    /// 識別資源來源
    /// FHIR Path: Meta.source
    /// Cardinality: 0..1
    /// Type: uri
    /// </summary>
    [JsonPropertyName("source")]
    public FhirUri? Source { get; set; }

    /// <summary>
    /// 此資源聲稱符合的配置檔案
    /// FHIR Path: Meta.profile
    /// Cardinality: 0..*
    /// Type: canonical[]
    /// </summary>
    [JsonPropertyName("profile")]
    public IList<FhirCanonical>? Profile { get; set; }

    /// <summary>
    /// 應用於此資源的安全標籤
    /// FHIR Path: Meta.security
    /// Cardinality: 0..*
    /// Type: Coding[]
    /// </summary>
    [JsonPropertyName("security")]
    public IList<Coding>? Security { get; set; }

    /// <summary>
    /// 應用於此資源的標籤
    /// FHIR Path: Meta.tag
    /// Cardinality: 0..*
    /// Type: Coding[]
    /// </summary>
    [JsonPropertyName("tag")]
    public IList<Coding>? Tag { get; set; }

    /// <summary>
    /// 檢查是否有版本識別碼
    /// </summary>
    /// <returns>如果存在版本識別碼則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasVersionId => !string.IsNullOrEmpty(VersionId?.Value);

    /// <summary>
    /// 檢查是否有最後更新時間
    /// </summary>
    /// <returns>如果存在最後更新時間則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasLastUpdated => LastUpdated?.Value != null;

    /// <summary>
    /// 檢查是否有來源
    /// </summary>
    /// <returns>如果存在來源則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasSource => !string.IsNullOrEmpty(Source?.Value);

    /// <summary>
    /// 檢查是否有配置檔案
    /// </summary>
    /// <returns>如果存在配置檔案則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasProfile => Profile?.Any() == true;

    /// <summary>
    /// 檢查是否有安全標籤
    /// </summary>
    /// <returns>如果存在安全標籤則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasSecurity => Security?.Any() == true;

    /// <summary>
    /// 檢查是否有標籤
    /// </summary>
    /// <returns>如果存在標籤則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasTag => Tag?.Any() == true;

    /// <summary>
    /// 檢查元資料是否有效
    /// </summary>
    /// <returns>如果元資料有效則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool IsValid => true; // Meta 總是有效的

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
            
            if (HasVersionId)
            {
                parts.Add($"v{VersionId?.Value}");
            }
            
            if (HasLastUpdated)
            {
                parts.Add($"updated {LastUpdated?.Value}");
            }
            
            if (HasSource)
            {
                parts.Add($"from {Source?.Value}");
            }
            
            return parts.Any() ? string.Join(" ", parts) : "Meta";
        }
    }

    protected override void CopyFieldsTo(Meta target)
    {
        target.VersionId = VersionId?.DeepCopy() as FhirId;
        target.LastUpdated = LastUpdated?.DeepCopy() as FhirInstant;
        target.Source = Source?.DeepCopy() as FhirUri;
        target.Profile = Profile?.Select(p => p.DeepCopy() as FhirCanonical).ToList();
        target.Security = Security?.Select(s => s.DeepCopy() as Coding).ToList();
        target.Tag = Tag?.Select(t => t.DeepCopy() as Coding).ToList();
    }

    protected override bool FieldsAreExactly(Meta other)
    {
        return DeepEqualityComparer.AreEqual(VersionId, other.VersionId) &&
               DeepEqualityComparer.AreEqual(LastUpdated, other.LastUpdated) &&
               DeepEqualityComparer.AreEqual(Source, other.Source) &&
               DeepEqualityComparer.AreEqual(Profile, other.Profile) &&
               DeepEqualityComparer.AreEqual(Security, other.Security) &&
               DeepEqualityComparer.AreEqual(Tag, other.Tag);
    }

    protected override IEnumerable<ValidationResult> ValidateFields(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();

        // 驗證 VersionId
        if (VersionId != null)
        {
            results.AddRange(VersionId.Validate(validationContext));
        }

        // 驗證 LastUpdated
        if (LastUpdated != null)
        {
            results.AddRange(LastUpdated.Validate(validationContext));
        }

        // 驗證 Source
        if (Source != null)
        {
            results.AddRange(Source.Validate(validationContext));
        }

        // 驗證 Profile
        if (Profile != null)
        {
            foreach (var profile in Profile)
            {
                if (profile != null)
                {
                    results.AddRange(profile.Validate(validationContext));
                }
            }
        }

        // 驗證 Security
        if (Security != null)
        {
            foreach (var security in Security)
            {
                if (security != null)
                {
                    results.AddRange(security.Validate(validationContext));
                }
            }
        }

        // 驗證 Tag
        if (Tag != null)
        {
            foreach (var tag in Tag)
            {
                if (tag != null)
                {
                    results.AddRange(tag.Validate(validationContext));
                }
            }
        }

        return results;
    }
} 