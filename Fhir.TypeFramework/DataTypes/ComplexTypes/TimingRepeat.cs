using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// TimingRepeat - 時間重複安排
/// 用於描述事件重複的時間安排
/// </summary>
/// <remarks>
/// FHIR R5 TimingRepeat (Complex Type)
/// A set of rules that describe when the event is scheduled to occur.
/// 
/// Structure:
/// - bounds[x]: Duration|Range|Period (0..1) - Length/Range of lengths, or (Start and/or end) limits
/// - count: positiveInt (0..1) - Number of times to repeat
/// - countMax: positiveInt (0..1) - Maximum number of times to repeat
/// - duration: decimal (0..1) - How long when it happens
/// - durationMax: decimal (0..1) - How long when it happens (Max)
/// - durationUnit: code (0..1) - s | min | h | d | wk | mo | a - unit of time (UCUM)
/// - frequency: positiveInt (0..1) - Event occurs frequency times per period
/// - frequencyMax: positiveInt (0..1) - Event occurs up to frequencyMax times per period
/// - period: decimal (0..1) - Event occurs frequency times per period
/// - periodMax: decimal (0..1) - Upper limit of period (3-4 hours)
/// - periodUnit: code (0..1) - s | min | h | d | wk | mo | a - unit of time (UCUM)
/// - dayOfWeek: code[] (0..*) - mon | tue | wed | thu | fri | sat | sun
/// - timeOfDay: time[] (0..*) - Time of day for action
/// - when: code[] (0..*) - Code for time period of occurrence
/// - offset: unsignedInt (0..1) - Minutes from event (before or after)
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class TimingRepeat : Element, IExtensibleTypeFramework
{
    /// <summary>
    /// 重複的邊界 - 使用 Choice Type 支援 Duration, Range, Period
    /// FHIR Path: TimingRepeat.bounds[x]
    /// Cardinality: 0..1
    /// Type: Duration|Range|Period
    /// </summary>
    [JsonPropertyName("bounds")]
    public TimingRepeatBoundsChoice? Bounds { get; set; }

    /// <summary>
    /// 重複次數
    /// FHIR Path: TimingRepeat.count
    /// Cardinality: 0..1
    /// Type: positiveInt
    /// </summary>
    [JsonPropertyName("count")]
    public FhirPositiveInt? Count { get; set; }

    /// <summary>
    /// 最大重複次數
    /// FHIR Path: TimingRepeat.countMax
    /// Cardinality: 0..1
    /// Type: positiveInt
    /// </summary>
    [JsonPropertyName("countMax")]
    public FhirPositiveInt? CountMax { get; set; }

    /// <summary>
    /// 持續時間
    /// FHIR Path: TimingRepeat.duration
    /// Cardinality: 0..1
    /// Type: decimal
    /// </summary>
    [JsonPropertyName("duration")]
    public FhirDecimal? Duration { get; set; }

    /// <summary>
    /// 最大持續時間
    /// FHIR Path: TimingRepeat.durationMax
    /// Cardinality: 0..1
    /// Type: decimal
    /// </summary>
    [JsonPropertyName("durationMax")]
    public FhirDecimal? DurationMax { get; set; }

    /// <summary>
    /// 持續時間單位
    /// FHIR Path: TimingRepeat.durationUnit
    /// Cardinality: 0..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("durationUnit")]
    public FhirCode? DurationUnit { get; set; }

    /// <summary>
    /// 頻率
    /// FHIR Path: TimingRepeat.frequency
    /// Cardinality: 0..1
    /// Type: positiveInt
    /// </summary>
    [JsonPropertyName("frequency")]
    public FhirPositiveInt? Frequency { get; set; }

    /// <summary>
    /// 最大頻率
    /// FHIR Path: TimingRepeat.frequencyMax
    /// Cardinality: 0..1
    /// Type: positiveInt
    /// </summary>
    [JsonPropertyName("frequencyMax")]
    public FhirPositiveInt? FrequencyMax { get; set; }

    /// <summary>
    /// 週期
    /// FHIR Path: TimingRepeat.period
    /// Cardinality: 0..1
    /// Type: decimal
    /// </summary>
    [JsonPropertyName("period")]
    public FhirDecimal? Period { get; set; }

    /// <summary>
    /// 最大週期
    /// FHIR Path: TimingRepeat.periodMax
    /// Cardinality: 0..1
    /// Type: decimal
    /// </summary>
    [JsonPropertyName("periodMax")]
    public FhirDecimal? PeriodMax { get; set; }

    /// <summary>
    /// 週期單位
    /// FHIR Path: TimingRepeat.periodUnit
    /// Cardinality: 0..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("periodUnit")]
    public FhirCode? PeriodUnit { get; set; }

    /// <summary>
    /// 星期幾
    /// FHIR Path: TimingRepeat.dayOfWeek
    /// Cardinality: 0..*
    /// Type: code[]
    /// </summary>
    [JsonPropertyName("dayOfWeek")]
    public List<FhirCode>? DayOfWeek { get; set; }

    /// <summary>
    /// 一天中的時間
    /// FHIR Path: TimingRepeat.timeOfDay
    /// Cardinality: 0..*
    /// Type: time[]
    /// </summary>
    [JsonPropertyName("timeOfDay")]
    public List<FhirTime>? TimeOfDay { get; set; }

    /// <summary>
    /// 發生時間代碼
    /// FHIR Path: TimingRepeat.when
    /// Cardinality: 0..*
    /// Type: code[]
    /// </summary>
    [JsonPropertyName("when")]
    public List<FhirCode>? When { get; set; }

    /// <summary>
    /// 偏移量（分鐘）
    /// FHIR Path: TimingRepeat.offset
    /// Cardinality: 0..1
    /// Type: unsignedInt
    /// </summary>
    [JsonPropertyName("offset")]
    public FhirUnsignedInt? Offset { get; set; }

    /// <summary>
    /// 檢查是否有邊界
    /// </summary>
    /// <returns>如果存在邊界則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasBounds => Bounds != null;

    /// <summary>
    /// 檢查是否有星期幾
    /// </summary>
    /// <returns>如果存在星期幾則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasDayOfWeek => DayOfWeek?.Any() == true;

    /// <summary>
    /// 檢查是否有時間
    /// </summary>
    /// <returns>如果存在時間則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasTimeOfDay => TimeOfDay?.Any() == true;

    /// <summary>
    /// 檢查是否有發生時間代碼
    /// </summary>
    /// <returns>如果存在發生時間代碼則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasWhen => When?.Any() == true;

    /// <summary>
    /// 設定邊界
    /// </summary>
    /// <param name="bounds">邊界值</param>
    public void SetBounds(TimingRepeatBoundsChoice bounds)
    {
        Bounds = bounds;
    }

    /// <summary>
    /// 添加星期幾
    /// </summary>
    /// <param name="dayOfWeek">星期幾代碼</param>
    public void AddDayOfWeek(string dayOfWeek)
    {
        DayOfWeek ??= new List<FhirCode>();
        DayOfWeek.Add(new FhirCode(dayOfWeek));
    }

    /// <summary>
    /// 添加時間
    /// </summary>
    /// <param name="timeOfDay">時間</param>
    public void AddTimeOfDay(TimeSpan timeOfDay)
    {
        TimeOfDay ??= new List<FhirTime>();
        TimeOfDay.Add(new FhirTime(timeOfDay));
    }

    /// <summary>
    /// 添加發生時間代碼
    /// </summary>
    /// <param name="when">發生時間代碼</param>
    public void AddWhen(string when)
    {
        When ??= new List<FhirCode>();
        When.Add(new FhirCode(when));
    }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>TimingRepeat 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = new TimingRepeat
        {
            Id = Id,
            Count = Count,
            CountMax = CountMax,
            Duration = Duration,
            DurationMax = DurationMax,
            DurationUnit = DurationUnit,
            Frequency = Frequency,
            FrequencyMax = FrequencyMax,
            Period = Period,
            PeriodMax = PeriodMax,
            PeriodUnit = PeriodUnit,
            Offset = Offset
        };

        if (Bounds != null)
        {
            copy.Bounds = Bounds;
        }

        if (DayOfWeek != null)
        {
            copy.DayOfWeek = DayOfWeek.Select(d => d.DeepCopy() as FhirCode).ToList();
        }

        if (TimeOfDay != null)
        {
            copy.TimeOfDay = TimeOfDay.Select(t => t.DeepCopy() as FhirTime).ToList();
        }

        if (When != null)
        {
            copy.When = When.Select(w => w.DeepCopy() as FhirCode).ToList();
        }

        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 TimingRepeat 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not TimingRepeat otherRepeat)
            return false;

        return base.IsExactly(other) &&
               Equals(Bounds, otherRepeat.Bounds) &&
               Equals(Count, otherRepeat.Count) &&
               Equals(CountMax, otherRepeat.CountMax) &&
               Equals(Duration, otherRepeat.Duration) &&
               Equals(DurationMax, otherRepeat.DurationMax) &&
               Equals(DurationUnit, otherRepeat.DurationUnit) &&
               Equals(Frequency, otherRepeat.Frequency) &&
               Equals(FrequencyMax, otherRepeat.FrequencyMax) &&
               Equals(Period, otherRepeat.Period) &&
               Equals(PeriodMax, otherRepeat.PeriodMax) &&
               Equals(PeriodUnit, otherRepeat.PeriodUnit) &&
               Equals(Offset, otherRepeat.Offset) &&
               DayOfWeek?.Count == otherRepeat.DayOfWeek?.Count &&
               TimeOfDay?.Count == otherRepeat.TimeOfDay?.Count &&
               When?.Count == otherRepeat.When?.Count;
    }

    /// <summary>
    /// 驗證 TimingRepeat 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證邊界
        if (Bounds != null)
        {
            var boundsValidationContext = new ValidationContext(Bounds);
            foreach (var result in Bounds.Validate(boundsValidationContext))
            {
                yield return result;
            }
        }

        // 驗證持續時間單位
        if (!string.IsNullOrEmpty(DurationUnit))
        {
            var validUnits = new[] { "s", "min", "h", "d", "wk", "mo", "a" };
            if (!validUnits.Contains(DurationUnit))
            {
                yield return new ValidationResult($"TimingRepeat.durationUnit '{DurationUnit}' is not a valid UCUM time unit");
            }
        }

        // 驗證週期單位
        if (!string.IsNullOrEmpty(PeriodUnit))
        {
            var validUnits = new[] { "s", "min", "h", "d", "wk", "mo", "a" };
            if (!validUnits.Contains(PeriodUnit))
            {
                yield return new ValidationResult($"TimingRepeat.periodUnit '{PeriodUnit}' is not a valid UCUM time unit");
            }
        }

        // 驗證星期幾代碼
        if (DayOfWeek != null)
        {
            var validDays = new[] { "mon", "tue", "wed", "thu", "fri", "sat", "sun" };
            foreach (var day in DayOfWeek)
            {
                if (!string.IsNullOrEmpty(day) && !validDays.Contains(day))
                {
                    yield return new ValidationResult($"TimingRepeat.dayOfWeek '{day}' is not a valid day code");
                }
            }
        }

        // 驗證發生時間代碼
        if (When != null)
        {
            var validWhens = new[] { "MORN", "AFT", "EVE", "NIGHT", "PHS", "HS", "WAKE", "C", "CM", "CD", "CV", "AC", "ACM", "ACD", "ACV", "PC", "PCM", "PCD", "PCV" };
            foreach (var when in When)
            {
                if (!string.IsNullOrEmpty(when) && !validWhens.Contains(when))
                {
                    yield return new ValidationResult($"TimingRepeat.when '{when}' is not a valid when code");
                }
            }
        }

        // 驗證時間
        if (TimeOfDay != null)
        {
            foreach (var time in TimeOfDay)
            {
                if (time != null)
                {
                    var timeValidationContext = new ValidationContext(time);
                    foreach (var result in time.Validate(timeValidationContext))
                    {
                        yield return result;
                    }
                }
            }
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
} 