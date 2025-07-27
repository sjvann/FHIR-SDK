using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
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
public class SampledData : Element, IExtensibleTypeFramework
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
    /// 乘以數據的因子
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
    /// 每個時間點的樣本點數量
    /// FHIR Path: SampledData.dimensions
    /// Cardinality: 1..1
    /// Type: positiveInt
    /// </summary>
    [JsonPropertyName("dimensions")]
    [Required(ErrorMessage = "SampledData.dimensions is required")]
    public FhirPositiveInt? Dimensions { get; set; }

    /// <summary>
    /// 數據字串
    /// FHIR Path: SampledData.data
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("data")]
    public FhirString? Data { get; set; }

    /// <summary>
    /// 檢查是否有因子
    /// </summary>
    /// <returns>如果存在因子則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasFactor => Factor != null;

    /// <summary>
    /// 檢查是否有下限
    /// </summary>
    /// <returns>如果存在下限則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasLowerLimit => LowerLimit != null;

    /// <summary>
    /// 檢查是否有上限
    /// </summary>
    /// <returns>如果存在上限則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasUpperLimit => UpperLimit != null;

    /// <summary>
    /// 檢查是否有數據
    /// </summary>
    /// <returns>如果存在數據則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasData => !string.IsNullOrEmpty(Data);

    /// <summary>
    /// 設定原點
    /// </summary>
    /// <param name="origin">原點</param>
    public void SetOrigin(SimpleQuantity origin)
    {
        Origin = origin;
    }

    /// <summary>
    /// 設定週期
    /// </summary>
    /// <param name="period">週期（毫秒）</param>
    public void SetPeriod(decimal period)
    {
        Period = new FhirDecimal(period);
    }

    /// <summary>
    /// 設定因子
    /// </summary>
    /// <param name="factor">因子</param>
    public void SetFactor(decimal factor)
    {
        Factor = new FhirDecimal(factor);
    }

    /// <summary>
    /// 設定下限
    /// </summary>
    /// <param name="lowerLimit">下限</param>
    public void SetLowerLimit(decimal lowerLimit)
    {
        LowerLimit = new FhirDecimal(lowerLimit);
    }

    /// <summary>
    /// 設定上限
    /// </summary>
    /// <param name="upperLimit">上限</param>
    public void SetUpperLimit(decimal upperLimit)
    {
        UpperLimit = new FhirDecimal(upperLimit);
    }

    /// <summary>
    /// 設定維度
    /// </summary>
    /// <param name="dimensions">維度</param>
    public void SetDimensions(int dimensions)
    {
        Dimensions = new FhirPositiveInt(dimensions);
    }

    /// <summary>
    /// 設定數據
    /// </summary>
    /// <param name="data">數據字串</param>
    public void SetData(string data)
    {
        Data = new FhirString(data);
    }

    /// <summary>
    /// 取得週期
    /// </summary>
    /// <returns>週期，如果不存在則返回 null</returns>
    public decimal? GetPeriod()
    {
        return Period?.Value;
    }

    /// <summary>
    /// 取得因子
    /// </summary>
    /// <returns>因子，如果不存在則返回 null</returns>
    public decimal? GetFactor()
    {
        return Factor?.Value;
    }

    /// <summary>
    /// 取得下限
    /// </summary>
    /// <returns>下限，如果不存在則返回 null</returns>
    public decimal? GetLowerLimit()
    {
        return LowerLimit?.Value;
    }

    /// <summary>
    /// 取得上限
    /// </summary>
    /// <returns>上限，如果不存在則返回 null</returns>
    public decimal? GetUpperLimit()
    {
        return UpperLimit?.Value;
    }

    /// <summary>
    /// 取得維度
    /// </summary>
    /// <returns>維度，如果不存在則返回 null</returns>
    public int? GetDimensions()
    {
        return Dimensions?.Value;
    }

    /// <summary>
    /// 取得數據
    /// </summary>
    /// <returns>數據字串，如果不存在則返回 null</returns>
    public string? GetData()
    {
        return Data?.Value;
    }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>SampledData 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = new SampledData
        {
            Id = Id,
            Period = Period,
            Factor = Factor,
            LowerLimit = LowerLimit,
            UpperLimit = UpperLimit,
            Dimensions = Dimensions,
            Data = Data
        };

        if (Origin != null)
        {
            copy.Origin = Origin.DeepCopy() as SimpleQuantity;
        }

        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 SampledData 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not SampledData otherSampledData)
            return false;

        return base.IsExactly(other) &&
               Equals(Origin, otherSampledData.Origin) &&
               Equals(Period, otherSampledData.Period) &&
               Equals(Factor, otherSampledData.Factor) &&
               Equals(LowerLimit, otherSampledData.LowerLimit) &&
               Equals(UpperLimit, otherSampledData.UpperLimit) &&
               Equals(Dimensions, otherSampledData.Dimensions) &&
               Equals(Data, otherSampledData.Data);
    }

    /// <summary>
    /// 驗證 SampledData 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證必需的原點
        if (Origin == null)
        {
            yield return new ValidationResult("SampledData.origin is required");
        }
        else
        {
            var originValidationContext = new ValidationContext(Origin);
            foreach (var result in Origin.Validate(originValidationContext))
            {
                yield return result;
            }
        }

        // 驗證必需的週期
        if (Period == null)
        {
            yield return new ValidationResult("SampledData.period is required");
        }
        else if (Period.Value <= 0)
        {
            yield return new ValidationResult("SampledData.period must be greater than zero");
        }

        // 驗證必需的維度
        if (Dimensions == null)
        {
            yield return new ValidationResult("SampledData.dimensions is required");
        }
        else if (Dimensions.Value <= 0)
        {
            yield return new ValidationResult("SampledData.dimensions must be greater than zero");
        }

        // 驗證週期
        if (Period != null)
        {
            var periodValidationContext = new ValidationContext(Period);
            foreach (var result in Period.Validate(periodValidationContext))
            {
                yield return result;
            }
        }

        // 驗證因子
        if (Factor != null)
        {
            var factorValidationContext = new ValidationContext(Factor);
            foreach (var result in Factor.Validate(factorValidationContext))
            {
                yield return result;
            }
        }

        // 驗證下限
        if (LowerLimit != null)
        {
            var lowerLimitValidationContext = new ValidationContext(LowerLimit);
            foreach (var result in LowerLimit.Validate(lowerLimitValidationContext))
            {
                yield return result;
            }
        }

        // 驗證上限
        if (UpperLimit != null)
        {
            var upperLimitValidationContext = new ValidationContext(UpperLimit);
            foreach (var result in UpperLimit.Validate(upperLimitValidationContext))
            {
                yield return result;
            }
        }

        // 驗證維度
        if (Dimensions != null)
        {
            var dimensionsValidationContext = new ValidationContext(Dimensions);
            foreach (var result in Dimensions.Validate(dimensionsValidationContext))
            {
                yield return result;
            }
        }

        // 驗證數據
        if (Data != null)
        {
            var dataValidationContext = new ValidationContext(Data);
            foreach (var result in Data.Validate(dataValidationContext))
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