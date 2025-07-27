using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Period - 期間型別
/// 用於在 FHIR 資源中表示時間期間
/// </summary>
/// <remarks>
/// FHIR R5 Period (Complex Type)
/// A time period defined by a start and end date and optionally time.
/// 
/// Structure:
/// - start: dateTime (0..1) - Starting time with inclusive boundary
/// - end: dateTime (0..1) - End time with inclusive boundary, if not ongoing
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Period : Element, IExtensibleTypeFramework
{
    /// <summary>
    /// 開始時間（包含邊界）
    /// FHIR Path: Period.start
    /// Cardinality: 0..1
    /// Type: dateTime
    /// </summary>
    [JsonPropertyName("start")]
    public FhirDateTime? Start { get; set; }

    /// <summary>
    /// 結束時間（包含邊界，如果不是持續中）
    /// FHIR Path: Period.end
    /// Cardinality: 0..1
    /// Type: dateTime
    /// </summary>
    [JsonPropertyName("end")]
    public FhirDateTime? End { get; set; }

    /// <summary>
    /// 檢查是否有開始時間
    /// </summary>
    /// <returns>如果存在開始時間則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasStart => Start?.Value != null;

    /// <summary>
    /// 檢查是否有結束時間
    /// </summary>
    /// <returns>如果存在結束時間則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasEnd => End?.Value != null;

    /// <summary>
    /// 檢查是否為持續中
    /// </summary>
    /// <returns>如果沒有結束時間則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool IsOngoing => HasStart && !HasEnd;

    /// <summary>
    /// 檢查期間是否有效
    /// </summary>
    /// <returns>如果開始時間早於或等於結束時間則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool IsValid => !HasStart || !HasEnd || Start?.Value <= End?.Value;

    /// <summary>
    /// 取得期間的持續時間
    /// </summary>
    /// <returns>期間的持續時間，如果無法計算則為 null</returns>
    [JsonIgnore]
    public TimeSpan? Duration
    {
        get
        {
            if (Start?.Value != null && End?.Value != null)
            {
                return End.Value - Start.Value;
            }
            return null;
        }
    }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>Period 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = new Period
        {
            Id = Id,
            Start = Start?.DeepCopy() as FhirDateTime,
            End = End?.DeepCopy() as FhirDateTime
        };

        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 Period 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not Period otherPeriod)
            return false;

        return base.IsExactly(other) &&
               Equals(Start, otherPeriod.Start) &&
               Equals(End, otherPeriod.End);
    }

    /// <summary>
    /// 驗證 Period 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證期間的有效性
        if (Start?.Value != null && End?.Value != null)
        {
            if (Start.Value > End.Value)
            {
                yield return new ValidationResult("Period start time cannot be after end time");
            }
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
} 