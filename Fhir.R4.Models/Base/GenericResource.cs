using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using Fhir.R4.Models.DataTypes;
using Fhir.R4.Models.DataTypes.ComplexTypes;

namespace Fhir.R4.Models.Base;

/// <summary>
/// FHIR Resource 的泛型基礎類別
/// 提供所有 Resource 共同的行為和屬性
/// </summary>
/// <typeparam name="T">具體的 Resource 類型</typeparam>
public abstract class GenericResource<T> : IResource where T : GenericResource<T>
{
    /// <summary>
    /// 資源的邏輯識別碼
    /// FHIR Path: Resource.id
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("id")]
    public virtual FhirId? Id { get; set; }

    /// <summary>
    /// 資源的 metadata
    /// FHIR Path: Resource.meta
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("meta")]
    public virtual Meta? Meta { get; set; }

    /// <summary>
    /// 隱含規則的參考
    /// FHIR Path: Resource.implicitRules
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("implicitRules")]
    public virtual FhirUri? ImplicitRules { get; set; }

    /// <summary>
    /// 資源內容的基礎語言
    /// FHIR Path: Resource.language
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("language")]
    public virtual FhirCode? Language { get; set; }

    /// <summary>
    /// 資源類型名稱（由子類實現）
    /// </summary>
    [JsonPropertyName("resourceType")]
    public abstract FhirCode ResourceType { get; }

    /// <summary>
    /// 預設建構函式
    /// </summary>
    protected GenericResource() { }

    /// <summary>
    /// 建構函式，設定基本屬性
    /// </summary>
    /// <param name="id">資源 ID</param>
    protected GenericResource(FhirId? id = null)
    {
        if (id != null)
            Id = id;
    }

    /// <summary>
    /// 轉換為 JSON 字串
    /// </summary>
    /// <returns>JSON 表示</returns>
    public virtual string ToJson()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
        
        return JsonSerializer.Serialize(this, options);
    }

    /// <summary>
    /// 從 JSON 字串解析
    /// </summary>
    /// <param name="json">JSON 字串</param>
    public virtual void FromJson(string json)
    {
        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true
        };

        var parsed = JsonSerializer.Deserialize<T>(json, options);
        if (parsed != null)
        {
            // 複製屬性到當前實例
            Id = parsed.Id;
            Meta = parsed.Meta;
            ImplicitRules = parsed.ImplicitRules;
            Language = parsed.Language;
        }
    }

    /// <summary>
    /// 取得資源的摘要資訊
    /// </summary>
    /// <returns>資源摘要</returns>
    public virtual string GetSummary()
    {
        var parts = new List<string>
        {
            $"ResourceType: {ResourceType.Value}"
        };

        if (Id?.Value != null)
            parts.Add($"Id: {Id.Value}");

        if (Meta?.VersionId?.Value != null)
            parts.Add($"Version: {Meta.VersionId.Value}");

        if (Meta?.LastUpdated?.Value != null)
            parts.Add($"LastUpdated: {Meta.LastUpdated.Value:yyyy-MM-dd HH:mm:ss}");

        return string.Join(", ", parts);
    }

    /// <summary>
    /// 複製資源
    /// </summary>
    /// <returns>資源的副本</returns>
    public virtual IResource Clone()
    {
        var json = ToJson();
        var cloned = Activator.CreateInstance<T>();
        cloned.FromJson(json);
        return cloned;
    }

    /// <summary>
    /// 驗證資源根據 FHIR R4 規則
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();

        // 驗證 ID 格式
        if (Id?.Value != null && !IsValidId(Id.Value))
        {
            results.Add(new ValidationResult($"Resource.id '{Id.Value}' is not a valid FHIR id"));
        }

        // 驗證語言代碼
        if (Language?.Value != null && !IsValidLanguageCode(Language.Value))
        {
            results.Add(new ValidationResult($"Resource.language '{Language.Value}' is not a valid language code"));
        }

        // 驗證 ImplicitRules
        if (ImplicitRules?.Value != null && !Uri.IsWellFormedUriString(ImplicitRules.Value, UriKind.Absolute))
        {
            results.Add(new ValidationResult($"Resource.implicitRules '{ImplicitRules.Value}' is not a valid URI"));
        }

        // 驗證 Meta
        if (Meta != null)
        {
            var metaValidation = Meta.Validate(new ValidationContext(Meta));
            results.AddRange(metaValidation);
        }

        return results;
    }

    /// <summary>
    /// 驗證 FHIR ID 格式
    /// </summary>
    /// <param name="id">ID 字串</param>
    /// <returns>是否有效</returns>
    protected virtual bool IsValidId(string id)
    {
        if (string.IsNullOrEmpty(id) || id.Length > 64)
            return false;

        // FHIR ID 規則：[A-Za-z0-9\-\.]{1,64}
        return System.Text.RegularExpressions.Regex.IsMatch(id, @"^[A-Za-z0-9\-\.]{1,64}$");
    }

    /// <summary>
    /// 驗證語言代碼格式
    /// </summary>
    /// <param name="language">語言代碼</param>
    /// <returns>是否有效</returns>
    protected virtual bool IsValidLanguageCode(string language)
    {
        if (string.IsNullOrEmpty(language))
            return false;

        // 簡化的語言代碼驗證：2-3 個字母，可選的 - 和地區代碼
        return System.Text.RegularExpressions.Regex.IsMatch(language, @"^[a-z]{2,3}(-[A-Z]{2})?$");
    }

    /// <summary>
    /// 設定 Meta 資訊
    /// </summary>
    /// <param name="versionId">版本 ID</param>
    /// <param name="lastUpdated">最後更新時間</param>
    /// <param name="source">來源</param>
    public virtual void SetMeta(FhirId? versionId = null, FhirInstant? lastUpdated = null, FhirUri? source = null)
    {
        Meta ??= new Meta();

        if (versionId != null)
            Meta.VersionId = versionId;

        if (lastUpdated != null)
            Meta.LastUpdated = lastUpdated;

        if (source != null)
            Meta.Source = source;
    }

    /// <summary>
    /// 添加 Profile 到 Meta
    /// </summary>
    /// <param name="profileUrl">Profile URL</param>
    public virtual void AddProfile(FhirCanonical profileUrl)
    {
        Meta ??= new Meta();
        Meta.Profile ??= new List<FhirCanonical>();
        Meta.Profile.Add(profileUrl);
    }

    /// <summary>
    /// 添加 Tag 到 Meta
    /// </summary>
    /// <param name="system">編碼系統</param>
    /// <param name="code">編碼值</param>
    /// <param name="display">顯示名稱</param>
    public virtual void AddTag(FhirUri system, FhirCode code, FhirString? display = null)
    {
        Meta ??= new Meta();
        Meta.Tag ??= new List<Coding>();
        Meta.Tag.Add(new Coding
        {
            System = system,
            Code = code,
            Display = display
        });
    }

    /// <summary>
    /// 添加 Security Label 到 Meta
    /// </summary>
    /// <param name="system">編碼系統</param>
    /// <param name="code">編碼值</param>
    /// <param name="display">顯示名稱</param>
    public virtual void AddSecurity(FhirUri system, FhirCode code, FhirString? display = null)
    {
        Meta ??= new Meta();
        Meta.Security ??= new List<Coding>();
        Meta.Security.Add(new Coding
        {
            System = system,
            Code = code,
            Display = display
        });
    }

    /// <summary>
    /// 檢查是否有特定的 Tag
    /// </summary>
    /// <param name="system">編碼系統</param>
    /// <param name="code">編碼值</param>
    /// <returns>是否存在</returns>
    public virtual bool HasTag(FhirUri system, FhirCode code)
    {
        return Meta?.Tag?.Any(tag =>
            tag.System?.Value == system.Value &&
            tag.Code?.Value == code.Value) == true;
    }

    /// <summary>
    /// 檢查是否有特定的 Security Label
    /// </summary>
    /// <param name="system">編碼系統</param>
    /// <param name="code">編碼值</param>
    /// <returns>是否存在</returns>
    public virtual bool HasSecurity(FhirUri system, FhirCode code)
    {
        return Meta?.Security?.Any(security =>
            security.System?.Value == system.Value &&
            security.Code?.Value == code.Value) == true;
    }

    /// <summary>
    /// 檢查是否符合特定的 Profile
    /// </summary>
    /// <param name="profileUrl">Profile URL</param>
    /// <returns>是否符合</returns>
    public virtual bool ConformsToProfile(FhirCanonical profileUrl)
    {
        return Meta?.Profile?.Any(profile => profile.Value == profileUrl.Value) == true;
    }

    /// <summary>
    /// 字串表示
    /// </summary>
    /// <returns>資源的字串表示</returns>
    public override string ToString()
    {
        return GetSummary();
    }
}
