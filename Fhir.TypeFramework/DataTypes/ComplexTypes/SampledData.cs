using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// SampledData - 採樣數據
/// 用於描述採樣數據
/// </summary>
/// <remarks>
/// FHIR R5 SampledData (Complex Type)
/// A series of measurements taken by a device, with upper and lower limits.
/// 
/// Structure:
/// - origin: SimpleQuantity (1..1) - Zero value and units
/// - period: decimal (1..1) - Number of milliseconds between samples
/// - factor: decimal (0..1) - Multiply data by this before adding to origin
/// - lowerLimit: decimal (0..1) - Lower limit of detection
/// - upperLimit: decimal (0..1) - Upper limit of detection
/// - dimensions: positiveInt (1..1) - Number of sample points at each time point
/// - data: string (0..1) - Decimal values with spaces, or "E" | "U" | "L"
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class SampledData : UnifiedComplexTypeBase<SampledData>
{
    /// <summary>
    /// 零值和單位
    /// FHIR Path: SampledData.origin
    /// Cardinality: 1..1
    /// Type: SimpleQuantity
    /// </summary>
    [JsonPropertyName("origin")]
    [Required(ErrorMessage = "SampledData.origin is required")]
    public SimpleQuantity? Origin { get; set; }

    /// <summary>
    /// 樣本間隔（毫秒）
    /// FHIR Path: SampledData.period
    /// Cardinality: 1..1
    /// Type: decimal
    /// </summary>
    [JsonPropertyName("period")]
    [Required(ErrorMessage = "SampledData.period is required")]
    public FhirDecimal? Period { get; set; }

    /// <summary>
    /// 乘以資料後加到原點
    /// FHIR Path: SampledData.factor
    /// Cardinality: 0..1
    /// Type: decimal
    /// </summary>
    [JsonPropertyName("factor")]
    public FhirDecimal? Factor { get; set; }

    /// <summary>
    /// 檢測下限
    /// FHIR Path: SampledData.lowerLimit
    /// Cardinality: 0..1
    /// Type: decimal
    /// </summary>
    [JsonPropertyName("lowerLimit")]
    public FhirDecimal? LowerLimit { get; set; }

    /// <summary>
    /// 檢測上限
    /// FHIR Path: SampledData.upperLimit
    /// Cardinality: 0..1
    /// Type: decimal
    /// </summary>
    [JsonPropertyName("upperLimit")]
    public FhirDecimal? UpperLimit { get; set; }

    /// <summary>
    /// 每個時間點的樣本點數
    /// FHIR Path: SampledData.dimensions
    /// Cardinality: 1..1
    /// Type: positiveInt
    /// </summary>
    [JsonPropertyName("dimensions")]
    [Required(ErrorMessage = "SampledData.dimensions is required")]
    public FhirPositiveInt? Dimensions { get; set; }

    /// <summary>
    /// 十進位值，用空格分隔，或 "E" | "U" | "L"
    /// FHIR Path: SampledData.data
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("data")]
    public FhirString? Data { get; set; }

    /// <summary>
    /// 檢查是否有原點
    /// </summary>
    /// <returns>如果存在原點則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasOrigin => Origin != null;

    /// <summary>
    /// 檢查是否有週期
    /// </summary>
    /// <returns>如果存在週期則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasPeriod => Period?.Value != null;

    /// <summary>
    /// 檢查是否有因子
    /// </summary>
    /// <returns>如果存在因子則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasFactor => Factor?.Value != null;

    /// <summary>
    /// 檢查是否有下限
    /// </summary>
    /// <returns>如果存在下限則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasLowerLimit => LowerLimit?.Value != null;

    /// <summary>
    /// 檢查是否有上限
    /// </summary>
    /// <returns>如果存在上限則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasUpperLimit => UpperLimit?.Value != null;

    /// <summary>
    /// 檢查是否有維度
    /// </summary>
    /// <returns>如果存在維度則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasDimensions => Dimensions?.Value != null;

    /// <summary>
    /// 檢查是否有資料
    /// </summary>
    /// <returns>如果存在資料則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasData => !string.IsNullOrEmpty(Data?.Value);

    /// <summary>
    /// 檢查採樣數據是否有效
    /// </summary>
    /// <returns>如果採樣數據有效則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool IsValid => HasOrigin && HasPeriod && HasDimensions;

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
            
            if (HasOrigin)
            {
                parts.Add($"Origin: {Origin?.DisplayText}");
            }
            
            if (HasPeriod)
            {
                parts.Add($"Period: {Period?.Value}ms");
            }
            
            if (HasDimensions)
            {
                parts.Add($"Dimensions: {Dimensions?.Value}");
            }
            
            return parts.Any() ? string.Join(", ", parts) : "SampledData";
        }
    }

    protected override void CopyFieldsTo(SampledData target)
    {
        target.Origin = Origin?.DeepCopy() as SimpleQuantity;
        target.Period = Period?.DeepCopy() as FhirDecimal;
        target.Factor = Factor?.DeepCopy() as FhirDecimal;
        target.LowerLimit = LowerLimit?.DeepCopy() as FhirDecimal;
        target.UpperLimit = UpperLimit?.DeepCopy() as FhirDecimal;
        target.Dimensions = Dimensions?.DeepCopy() as FhirPositiveInt;
        target.Data = Data?.DeepCopy() as FhirString;
    }

    protected override bool FieldsAreExactly(SampledData other)
    {
        return DeepEqualityComparer.AreEqual(Origin, other.Origin) &&
               DeepEqualityComparer.AreEqual(Period, other.Period) &&
               DeepEqualityComparer.AreEqual(Factor, other.Factor) &&
               DeepEqualityComparer.AreEqual(LowerLimit, other.LowerLimit) &&
               DeepEqualityComparer.AreEqual(UpperLimit, other.UpperLimit) &&
               DeepEqualityComparer.AreEqual(Dimensions, other.Dimensions) &&
               DeepEqualityComparer.AreEqual(Data, other.Data);
    }

    protected override IEnumerable<ValidationResult> ValidateFields(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();

        // 驗證 Origin
        if (Origin != null)
        {
            results.AddRange(Origin.Validate(validationContext));
        }
        else
        {
            results.Add(new ValidationResult("SampledData.origin is required"));
        }

        // 驗證 Period
        if (Period != null)
        {
            results.AddRange(Period.Validate(validationContext));
        }
        else
        {
            results.Add(new ValidationResult("SampledData.period is required"));
        }

        // 驗證 Factor
        if (Factor != null)
        {
            results.AddRange(Factor.Validate(validationContext));
        }

        // 驗證 LowerLimit
        if (LowerLimit != null)
        {
            results.AddRange(LowerLimit.Validate(validationContext));
        }

        // 驗證 UpperLimit
        if (UpperLimit != null)
        {
            results.AddRange(UpperLimit.Validate(validationContext));
        }

        // 驗證 Dimensions
        if (Dimensions != null)
        {
            results.AddRange(Dimensions.Validate(validationContext));
        }
        else
        {
            results.Add(new ValidationResult("SampledData.dimensions is required"));
        }

        // 驗證 Data
        if (Data != null)
        {
            results.AddRange(Data.Validate(validationContext));
        }

        return results;
    }
} 