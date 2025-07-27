using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// ContactPoint - 聯絡點型別
/// 用於在 FHIR 資源中表示聯絡點（如電話、電子郵件、URL）
/// </summary>
/// <remarks>
/// FHIR R5 ContactPoint (Complex Type)
/// Details for all kinds of technology mediated contact points for a person or organization,
/// including telephone, email, etc.
/// 
/// Structure:
/// - system: code (0..1) - phone | fax | email | pager | url | sms | other
/// - value: string (0..1) - The actual contact point details
/// - use: code (0..1) - home | work | temp | old | mobile - purpose of this contact point
/// - rank: positiveInt (0..1) - Specify preferred order of use (1 = highest)
/// - period: Period (0..1) - Time period when the contact point was/is in use
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class ContactPoint : Element, IExtensibleTypeFramework
{
    /// <summary>
    /// 聯絡點系統
    /// FHIR Path: ContactPoint.system
    /// Cardinality: 0..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("system")]
    public FhirCode? System { get; set; }

    /// <summary>
    /// 實際聯絡點詳細資訊
    /// FHIR Path: ContactPoint.value
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("value")]
    public FhirString? Value { get; set; }

    /// <summary>
    /// 聯絡點的使用目的
    /// FHIR Path: ContactPoint.use
    /// Cardinality: 0..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("use")]
    public FhirCode? Use { get; set; }

    /// <summary>
    /// 指定使用優先順序（1 = 最高）
    /// FHIR Path: ContactPoint.rank
    /// Cardinality: 0..1
    /// Type: positiveInt
    /// </summary>
    [JsonPropertyName("rank")]
    public FhirPositiveInt? Rank { get; set; }

    /// <summary>
    /// 聯絡點使用期間
    /// FHIR Path: ContactPoint.period
    /// Cardinality: 0..1
    /// Type: Period
    /// </summary>
    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    /// <summary>
    /// 檢查是否有系統
    /// </summary>
    /// <returns>如果存在系統則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasSystem => !string.IsNullOrEmpty(System?.Value);

    /// <summary>
    /// 檢查是否有值
    /// </summary>
    /// <returns>如果存在值則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasValue => !string.IsNullOrEmpty(Value?.Value);

    /// <summary>
    /// 檢查是否有使用目的
    /// </summary>
    /// <returns>如果存在使用目的則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasUse => !string.IsNullOrEmpty(Use?.Value);

    /// <summary>
    /// 檢查是否有排名
    /// </summary>
    /// <returns>如果存在排名則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasRank => Rank?.Value != null;

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

            if (HasSystem)
            {
                parts.Add(System?.Value);
            }

            if (HasValue)
            {
                parts.Add(Value?.Value);
            }

            if (HasUse)
            {
                parts.Add($"({Use?.Value})");
            }

            return parts.Count > 0 ? string.Join(": ", parts) : null;
        }
    }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>ContactPoint 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = new ContactPoint
        {
            Id = Id,
            System = System?.DeepCopy() as FhirCode,
            Value = Value?.DeepCopy() as FhirString,
            Use = Use?.DeepCopy() as FhirCode,
            Rank = Rank?.DeepCopy() as FhirPositiveInt,
            Period = Period?.DeepCopy() as Period
        };

        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 ContactPoint 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not ContactPoint otherContactPoint)
            return false;

        return base.IsExactly(other) &&
               Equals(System, otherContactPoint.System) &&
               Equals(Value, otherContactPoint.Value) &&
               Equals(Use, otherContactPoint.Use) &&
               Equals(Rank, otherContactPoint.Rank) &&
               Equals(Period, otherContactPoint.Period);
    }

    /// <summary>
    /// 驗證 ContactPoint 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證 system 值（如果提供）
        if (!string.IsNullOrEmpty(System?.Value))
        {
            var validSystems = new[] { "phone", "fax", "email", "pager", "url", "sms", "other" };
            if (!validSystems.Contains(System.Value))
            {
                yield return new ValidationResult($"ContactPoint system must be one of: {string.Join(", ", validSystems)}");
            }
        }

        // 驗證 use 值（如果提供）
        if (!string.IsNullOrEmpty(Use?.Value))
        {
            var validUses = new[] { "home", "work", "temp", "old", "mobile" };
            if (!validUses.Contains(Use.Value))
            {
                yield return new ValidationResult($"ContactPoint use must be one of: {string.Join(", ", validUses)}");
            }
        }

        // 驗證排名值（如果提供）
        if (Rank?.Value != null && Rank.Value <= 0)
        {
            yield return new ValidationResult("ContactPoint rank must be a positive integer");
        }

        // 驗證期間（如果提供）
        if (Period != null)
        {
            var periodValidationContext = new ValidationContext(Period);
            foreach (var periodResult in Period.Validate(periodValidationContext))
            {
                yield return periodResult;
            }
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
} 