using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Meta - 資源元資料
/// 用於描述 FHIR 資源的元資料資訊
/// </summary>
/// <remarks>
/// FHIR R5 Meta (Complex Type)
/// The metadata about a resource. This is content that is maintained by the infrastructure.
/// Changes to the content might not always be associated with version changes to the resource.
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
public class Meta : Element, IExtensibleTypeFramework
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
    /// 資源版本最後更新時間
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
    /// 此資源聲明符合的配置文件
    /// FHIR Path: Meta.profile
    /// Cardinality: 0..*
    /// Type: canonical[]
    /// </summary>
    [JsonPropertyName("profile")]
    public List<FhirCanonical>? Profile { get; set; }

    /// <summary>
    /// 應用於此資源的安全標籤
    /// FHIR Path: Meta.security
    /// Cardinality: 0..*
    /// Type: Coding[]
    /// </summary>
    [JsonPropertyName("security")]
    public List<Coding>? Security { get; set; }

    /// <summary>
    /// 應用於此資源的標籤
    /// FHIR Path: Meta.tag
    /// Cardinality: 0..*
    /// Type: Coding[]
    /// </summary>
    [JsonPropertyName("tag")]
    public List<Coding>? Tag { get; set; }

    /// <summary>
    /// 檢查是否有配置文件
    /// </summary>
    /// <returns>如果存在配置文件則為 true，否則為 false</returns>
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
    /// 添加配置文件
    /// </summary>
    /// <param name="profile">配置文件 URL</param>
    public void AddProfile(string profile)
    {
        Profile ??= new List<FhirCanonical>();
        Profile.Add(new FhirCanonical(profile));
    }

    /// <summary>
    /// 添加安全標籤
    /// </summary>
    /// <param name="coding">安全標籤</param>
    public void AddSecurity(Coding coding)
    {
        Security ??= new List<Coding>();
        Security.Add(coding);
    }

    /// <summary>
    /// 添加標籤
    /// </summary>
    /// <param name="coding">標籤</param>
    public void AddTag(Coding coding)
    {
        Tag ??= new List<Coding>();
        Tag.Add(coding);
    }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>Meta 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = new Meta
        {
            Id = Id,
            VersionId = VersionId,
            LastUpdated = LastUpdated,
            Source = Source
        };

        if (Profile != null)
        {
            copy.Profile = Profile.Select(p => p.DeepCopy() as FhirCanonical).ToList();
        }

        if (Security != null)
        {
            copy.Security = Security.Select(s => s.DeepCopy() as Coding).ToList();
        }

        if (Tag != null)
        {
            copy.Tag = Tag.Select(t => t.DeepCopy() as Coding).ToList();
        }

        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 Meta 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not Meta otherMeta)
            return false;

        return base.IsExactly(other) &&
               Equals(VersionId, otherMeta.VersionId) &&
               Equals(LastUpdated, otherMeta.LastUpdated) &&
               Equals(Source, otherMeta.Source) &&
               Profile?.Count == otherMeta.Profile?.Count &&
               Security?.Count == otherMeta.Security?.Count &&
               Tag?.Count == otherMeta.Tag?.Count;
    }

    /// <summary>
    /// 驗證 Meta 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證 VersionId 格式
        if (!string.IsNullOrEmpty(VersionId) && !IsValidVersionId(VersionId))
        {
            yield return new ValidationResult("Meta.versionId must be a valid ID format");
        }

        // 驗證 Source URI 格式
        if (!string.IsNullOrEmpty(Source) && !Uri.IsWellFormedUriString(Source, UriKind.Absolute))
        {
            yield return new ValidationResult("Meta.source must be a valid absolute URI");
        }

        // 驗證 Profile URLs
        if (Profile != null)
        {
            foreach (var profile in Profile)
            {
                if (!string.IsNullOrEmpty(profile) && !Uri.IsWellFormedUriString(profile, UriKind.Absolute))
                {
                    yield return new ValidationResult($"Meta.profile '{profile}' must be a valid absolute URI");
                }
            }
        }

        // 驗證 Security Codings
        if (Security != null)
        {
            foreach (var security in Security)
            {
                var securityValidationContext = new ValidationContext(security);
                foreach (var result in security.Validate(securityValidationContext))
                {
                    yield return result;
                }
            }
        }

        // 驗證 Tag Codings
        if (Tag != null)
        {
            foreach (var tag in Tag)
            {
                var tagValidationContext = new ValidationContext(tag);
                foreach (var result in tag.Validate(tagValidationContext))
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

    /// <summary>
    /// 驗證 VersionId 格式
    /// </summary>
    /// <param name="versionId">要驗證的版本 ID</param>
    /// <returns>如果格式正確則為 true，否則為 false</returns>
    private bool IsValidVersionId(string versionId)
    {
        if (string.IsNullOrEmpty(versionId) || versionId.Length > 64)
            return false;
            
        // Version ID 只能包含字母、數字、連字號和點
        return versionId.All(c => char.IsLetterOrDigit(c) || c == '-' || c == '.');
    }
} 