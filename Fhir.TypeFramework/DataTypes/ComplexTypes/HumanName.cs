using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// HumanName - 人名型別
/// 用於在 FHIR 資源中表示人名
/// </summary>
/// <remarks>
/// FHIR R5 HumanName (Complex Type)
/// A human's name with the ability to identify parts and usage.
/// 
/// Structure:
/// - use: code (0..1) - usual | official | temp | nickname | anonymous | old | maiden
/// - text: string (0..1) - Text representation of the full name
/// - family: string (0..1) - Family name (often called 'Surname')
/// - given: string[] (0..*) - Given names (not always 'first'). Includes middle names
/// - prefix: string[] (0..*) - Parts that come before the name
/// - suffix: string[] (0..*) - Parts that come after the name
/// - period: Period (0..1) - Time period when name was/is in use
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class HumanName : Element, IExtensibleTypeFramework
{
    /// <summary>
    /// 名稱的使用目的
    /// FHIR Path: HumanName.use
    /// Cardinality: 0..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("use")]
    public FhirCode? Use { get; set; }

    /// <summary>
    /// 完整名稱的文字表示
    /// FHIR Path: HumanName.text
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("text")]
    public FhirString? Text { get; set; }

    /// <summary>
    /// 姓氏（通常稱為 'Surname'）
    /// FHIR Path: HumanName.family
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("family")]
    public FhirString? Family { get; set; }

    /// <summary>
    /// 名字（不總是 'first'）。包括中間名
    /// FHIR Path: HumanName.given
    /// Cardinality: 0..*
    /// Type: string[]
    /// </summary>
    [JsonPropertyName("given")]
    public IList<FhirString>? Given { get; set; }

    /// <summary>
    /// 名稱前的部分
    /// FHIR Path: HumanName.prefix
    /// Cardinality: 0..*
    /// Type: string[]
    /// </summary>
    [JsonPropertyName("prefix")]
    public IList<FhirString>? Prefix { get; set; }

    /// <summary>
    /// 名稱後的部分
    /// FHIR Path: HumanName.suffix
    /// Cardinality: 0..*
    /// Type: string[]
    /// </summary>
    [JsonPropertyName("suffix")]
    public IList<FhirString>? Suffix { get; set; }

    /// <summary>
    /// 名稱使用期間
    /// FHIR Path: HumanName.period
    /// Cardinality: 0..1
    /// Type: Period
    /// </summary>
    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    /// <summary>
    /// 檢查是否有文字
    /// </summary>
    /// <returns>如果存在文字則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasText => !string.IsNullOrEmpty(Text?.Value);

    /// <summary>
    /// 檢查是否有姓氏
    /// </summary>
    /// <returns>如果存在姓氏則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasFamily => !string.IsNullOrEmpty(Family?.Value);

    /// <summary>
    /// 檢查是否有名字
    /// </summary>
    /// <returns>如果存在名字則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasGiven => Given?.Any() == true;

    /// <summary>
    /// 檢查是否有前綴
    /// </summary>
    /// <returns>如果存在前綴則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasPrefix => Prefix?.Any() == true;

    /// <summary>
    /// 檢查是否有後綴
    /// </summary>
    /// <returns>如果存在後綴則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasSuffix => Suffix?.Any() == true;

    /// <summary>
    /// 取得顯示文字
    /// </summary>
    /// <returns>顯示文字</returns>
    [JsonIgnore]
    public string? DisplayText
    {
        get
        {
            if (HasText)
            {
                return Text?.Value;
            }

            var parts = new List<string>();

            if (HasPrefix)
            {
                parts.AddRange(Prefix!.Select(p => p.Value));
            }

            if (HasGiven)
            {
                parts.AddRange(Given!.Select(g => g.Value));
            }

            if (HasFamily)
            {
                parts.Add(Family?.Value);
            }

            if (HasSuffix)
            {
                parts.AddRange(Suffix!.Select(s => s.Value));
            }

            return parts.Count > 0 ? string.Join(" ", parts) : null;
        }
    }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>HumanName 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = new HumanName
        {
            Id = Id,
            Use = Use?.DeepCopy() as FhirCode,
            Text = Text?.DeepCopy() as FhirString,
            Family = Family?.DeepCopy() as FhirString,
            Period = Period?.DeepCopy() as Period
        };

        if (Given != null)
        {
            copy.Given = Given.Select(g => g.DeepCopy() as FhirString).ToList();
        }

        if (Prefix != null)
        {
            copy.Prefix = Prefix.Select(p => p.DeepCopy() as FhirString).ToList();
        }

        if (Suffix != null)
        {
            copy.Suffix = Suffix.Select(s => s.DeepCopy() as FhirString).ToList();
        }

        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 HumanName 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not HumanName otherHumanName)
            return false;

        return base.IsExactly(other) &&
               Equals(Use, otherHumanName.Use) &&
               Equals(Text, otherHumanName.Text) &&
               Equals(Family, otherHumanName.Family) &&
               Equals(Period, otherHumanName.Period) &&
               Given?.Count == otherHumanName.Given?.Count &&
               (Given?.Zip(otherHumanName.Given ?? new List<FhirString>(), 
                          (a, b) => a.IsExactly(b)).All(x => x) ?? true) &&
               Prefix?.Count == otherHumanName.Prefix?.Count &&
               (Prefix?.Zip(otherHumanName.Prefix ?? new List<FhirString>(), 
                           (a, b) => a.IsExactly(b)).All(x => x) ?? true) &&
               Suffix?.Count == otherHumanName.Suffix?.Count &&
               (Suffix?.Zip(otherHumanName.Suffix ?? new List<FhirString>(), 
                           (a, b) => a.IsExactly(b)).All(x => x) ?? true);
    }

    /// <summary>
    /// 驗證 HumanName 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證 use 值（如果提供）
        if (!string.IsNullOrEmpty(Use?.Value))
        {
            var validUses = new[] { "usual", "official", "temp", "nickname", "anonymous", "old", "maiden" };
            if (!validUses.Contains(Use.Value))
            {
                yield return new ValidationResult($"HumanName use must be one of: {string.Join(", ", validUses)}");
            }
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