using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Address - 地址型別
/// 用於在 FHIR 資源中表示郵政地址
/// </summary>
/// <remarks>
/// FHIR R5 Address (Complex Type)
/// An address expressed using postal conventions (as opposed to GPS or other location definition formats).
/// 
/// Structure:
/// - use: code (0..1) - home | work | temp | old | billing - purpose of this address
/// - type: code (0..1) - postal | physical | both
/// - text: string (0..1) - Text representation of the address
/// - line: string[] (0..*) - Street name, number, direction &amp; P.O. Box etc.
/// - city: string (0..1) - Name of city, town etc.
/// - district: string (0..1) - District name (aka county)
/// - state: string (0..1) - Sub-unit of country (abbreviations ok)
/// - postalCode: string (0..1) - Postal code for area
/// - country: string (0..1) - Country (e.g. can be ISO 3166 2 or 3 letter code)
/// - period: Period (0..1) - Time period when address was/is in use
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Address : Element, IExtensibleTypeFramework
{
    /// <summary>
    /// 地址的使用目的
    /// FHIR Path: Address.use
    /// Cardinality: 0..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("use")]
    public FhirCode? Use { get; set; }

    /// <summary>
    /// 地址類型
    /// FHIR Path: Address.type
    /// Cardinality: 0..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("type")]
    public FhirCode? Type { get; set; }

    /// <summary>
    /// 地址的文字表示
    /// FHIR Path: Address.text
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("text")]
    public FhirString? Text { get; set; }

    /// <summary>
    /// 街道名稱、號碼、方向及郵政信箱等
    /// FHIR Path: Address.line
    /// Cardinality: 0..*
    /// Type: string[]
    /// </summary>
    [JsonPropertyName("line")]
    public IList<FhirString>? Line { get; set; }

    /// <summary>
    /// 城市、城鎮等名稱
    /// FHIR Path: Address.city
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("city")]
    public FhirString? City { get; set; }

    /// <summary>
    /// 區域名稱（也稱為郡）
    /// FHIR Path: Address.district
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("district")]
    public FhirString? District { get; set; }

    /// <summary>
    /// 國家子單位（可以使用縮寫）
    /// FHIR Path: Address.state
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("state")]
    public FhirString? State { get; set; }

    /// <summary>
    /// 區域郵遞區號
    /// FHIR Path: Address.postalCode
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("postalCode")]
    public FhirString? PostalCode { get; set; }

    /// <summary>
    /// 國家（例如可以是 ISO 3166 2 或 3 字母代碼）
    /// FHIR Path: Address.country
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("country")]
    public FhirString? Country { get; set; }

    /// <summary>
    /// 地址使用期間
    /// FHIR Path: Address.period
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
    /// 檢查是否有地址行
    /// </summary>
    /// <returns>如果存在地址行則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasLine => Line?.Any() == true;

    /// <summary>
    /// 檢查是否有城市
    /// </summary>
    /// <returns>如果存在城市則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasCity => !string.IsNullOrEmpty(City?.Value);

    /// <summary>
    /// 檢查是否有郵遞區號
    /// </summary>
    /// <returns>如果存在郵遞區號則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasPostalCode => !string.IsNullOrEmpty(PostalCode?.Value);

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

            if (HasLine)
            {
                parts.AddRange(Line!.Select(l => l.Value));
            }

            if (HasCity)
            {
                parts.Add(City?.Value);
            }

            if (!string.IsNullOrEmpty(District?.Value))
            {
                parts.Add(District?.Value);
            }

            if (!string.IsNullOrEmpty(State?.Value))
            {
                parts.Add(State?.Value);
            }

            if (HasPostalCode)
            {
                parts.Add(PostalCode?.Value);
            }

            if (!string.IsNullOrEmpty(Country?.Value))
            {
                parts.Add(Country?.Value);
            }

            return parts.Count > 0 ? string.Join(", ", parts) : null;
        }
    }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>Address 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = new Address
        {
            Id = Id,
            Use = Use?.DeepCopy() as FhirCode,
            Type = Type?.DeepCopy() as FhirCode,
            Text = Text?.DeepCopy() as FhirString,
            City = City?.DeepCopy() as FhirString,
            District = District?.DeepCopy() as FhirString,
            State = State?.DeepCopy() as FhirString,
            PostalCode = PostalCode?.DeepCopy() as FhirString,
            Country = Country?.DeepCopy() as FhirString,
            Period = Period?.DeepCopy() as Period
        };

        if (Line != null)
        {
            copy.Line = Line.Select(l => l.DeepCopy() as FhirString).ToList();
        }

        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 Address 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not Address otherAddress)
            return false;

        return base.IsExactly(other) &&
               Equals(Use, otherAddress.Use) &&
               Equals(Type, otherAddress.Type) &&
               Equals(Text, otherAddress.Text) &&
               Equals(City, otherAddress.City) &&
               Equals(District, otherAddress.District) &&
               Equals(State, otherAddress.State) &&
               Equals(PostalCode, otherAddress.PostalCode) &&
               Equals(Country, otherAddress.Country) &&
               Equals(Period, otherAddress.Period) &&
               Line?.Count == otherAddress.Line?.Count &&
               (Line?.Zip(otherAddress.Line ?? new List<FhirString>(), 
                         (a, b) => a.IsExactly(b)).All(x => x) ?? true);
    }

    /// <summary>
    /// 驗證 Address 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證 use 值（如果提供）
        if (!string.IsNullOrEmpty(Use?.Value))
        {
            var validUses = new[] { "home", "work", "temp", "old", "billing" };
            if (!validUses.Contains(Use.Value))
            {
                yield return new ValidationResult($"Address use must be one of: {string.Join(", ", validUses)}");
            }
        }

        // 驗證 type 值（如果提供）
        if (!string.IsNullOrEmpty(Type?.Value))
        {
            var validTypes = new[] { "postal", "physical", "both" };
            if (!validTypes.Contains(Type.Value))
            {
                yield return new ValidationResult($"Address type must be one of: {string.Join(", ", validTypes)}");
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