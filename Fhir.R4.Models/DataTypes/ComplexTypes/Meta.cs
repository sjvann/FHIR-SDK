using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.R4.Models.DataTypes;

namespace Fhir.R4.Models.DataTypes.ComplexTypes;

/// <summary>
/// The metadata about a resource. This is content that is maintained by the infrastructure.
/// </summary>
/// <remarks>
/// FHIR R4 Meta Complex Type
/// The metadata about a resource. This is content that is maintained by the infrastructure. 
/// Changes to the content might not always be associated with version changes to the resource.
/// </remarks>
public class Meta : ComplexType<Meta>
{
    /// <summary>
    /// Version specific identifier.
    /// FHIR Path: Meta.versionId
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("versionId")]
    public FhirId? VersionId { get; set; }
    
    /// <summary>
    /// When the resource version last changed.
    /// FHIR Path: Meta.lastUpdated
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("lastUpdated")]
    public FhirInstant? LastUpdated { get; set; }
    
    /// <summary>
    /// Identifies where the resource comes from.
    /// FHIR Path: Meta.source
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("source")]
    public FhirUri? Source { get; set; }
    
    /// <summary>
    /// Profiles this resource claims to conform to.
    /// FHIR Path: Meta.profile
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("profile")]
    public List<FhirCanonical>? Profile { get; set; }
    
    /// <summary>
    /// Security Labels applied to this resource.
    /// FHIR Path: Meta.security
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("security")]
    public List<Coding>? Security { get; set; }
    
    /// <summary>
    /// Tags applied to this resource.
    /// FHIR Path: Meta.tag
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("tag")]
    public List<Coding>? Tag { get; set; }

    /// <summary>
    /// 預設建構函式
    /// </summary>
    public Meta() { }

    /// <summary>
    /// 建構函式，設定基本 metadata
    /// </summary>
    /// <param name="versionId">版本識別碼</param>
    /// <param name="lastUpdated">最後更新時間</param>
    public Meta(FhirId? versionId = null, FhirInstant? lastUpdated = null)
    {
        if (versionId != null)
            VersionId = versionId;

        if (lastUpdated != null)
            LastUpdated = lastUpdated;
    }

    /// <summary>
    /// 取得複雜型別的字串表示
    /// </summary>
    /// <returns>Meta 的字串表示</returns>
    protected override string? GetComplexTypeString()
    {
        var parts = new List<string>();
        
        if (VersionId?.Value != null)
            parts.Add($"v{VersionId.Value}");
            
        if (LastUpdated?.Value != null)
            parts.Add($"updated:{LastUpdated.Value:yyyy-MM-dd}");
            
        if (Profile?.Count > 0)
            parts.Add($"profiles:{Profile.Count}");
            
        if (Security?.Count > 0)
            parts.Add($"security:{Security.Count}");
            
        if (Tag?.Count > 0)
            parts.Add($"tags:{Tag.Count}");
        
        return parts.Count > 0 ? string.Join(", ", parts) : "Meta";
    }

    /// <summary>
    /// 驗證 Meta 根據 FHIR R4 規則
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // 驗證 Profile URLs
        if (Profile != null)
        {
            foreach (var profile in Profile)
            {
                if (profile?.Value != null && !Uri.IsWellFormedUriString(profile.Value, UriKind.Absolute))
                {
                    yield return new ValidationResult($"Meta.profile '{profile.Value}' is not a valid canonical URL");
                }
            }
        }

        // 驗證 Source URL
        if (Source?.Value != null && !Uri.IsWellFormedUriString(Source.Value, UriKind.Absolute))
        {
            yield return new ValidationResult($"Meta.source '{Source.Value}' is not a valid URI");
        }

        // 驗證 Security Coding
        if (Security != null)
        {
            foreach (var security in Security)
            {
                if (security != null)
                {
                    var securityValidation = security.Validate(new ValidationContext(security));
                    foreach (var result in securityValidation)
                        yield return result;
                }
            }
        }

        // 驗證 Tag Coding
        if (Tag != null)
        {
            foreach (var tag in Tag)
            {
                if (tag != null)
                {
                    var tagValidation = tag.Validate(new ValidationContext(tag));
                    foreach (var result in tagValidation)
                        yield return result;
                }
            }
        }
    }

    /// <summary>
    /// 添加 Profile
    /// </summary>
    /// <param name="profileUrl">Profile URL</param>
    public void AddProfile(FhirCanonical profileUrl)
    {
        Profile ??= new List<FhirCanonical>();
        Profile.Add(profileUrl);
    }

    /// <summary>
    /// 添加 Security Label
    /// </summary>
    /// <param name="system">編碼系統</param>
    /// <param name="code">編碼值</param>
    /// <param name="display">顯示名稱</param>
    public void AddSecurity(FhirUri system, FhirCode code, FhirString? display = null)
    {
        Security ??= new List<Coding>();
        Security.Add(new Coding
        {
            System = system,
            Code = code,
            Display = display
        });
    }

    /// <summary>
    /// 添加 Tag
    /// </summary>
    /// <param name="system">編碼系統</param>
    /// <param name="code">編碼值</param>
    /// <param name="display">顯示名稱</param>
    public void AddTag(FhirUri system, FhirCode code, FhirString? display = null)
    {
        Tag ??= new List<Coding>();
        Tag.Add(new Coding
        {
            System = system,
            Code = code,
            Display = display
        });
    }
}
