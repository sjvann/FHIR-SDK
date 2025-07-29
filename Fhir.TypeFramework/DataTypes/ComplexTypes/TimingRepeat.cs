using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.TypeFramework.DataTypes.ComplexTypes;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// TimingRepeat - 時間重複型別
/// 用於描述時間重複的模式
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
public class TimingRepeat : UnifiedComplexTypeBase<TimingRepeat>
{
    /// <summary>
    /// 長度/範圍限制，或開始和/或結束限制
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
    /// 持續時間單位 - s | min | h | d | wk | mo | a
    /// FHIR Path: TimingRepeat.durationUnit
    /// Cardinality: 0..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("durationUnit")]
    public FhirCode? DurationUnit { get; set; }

    /// <summary>
    /// 頻率 - 事件在週期內發生的次數
    /// FHIR Path: TimingRepeat.frequency
    /// Cardinality: 0..1
    /// Type: positiveInt
    /// </summary>
    [JsonPropertyName("frequency")]
    public FhirPositiveInt? Frequency { get; set; }

    /// <summary>
    /// 最大頻率 - 事件在週期內最多發生的次數
    /// FHIR Path: TimingRepeat.frequencyMax
    /// Cardinality: 0..1
    /// Type: positiveInt
    /// </summary>
    [JsonPropertyName("frequencyMax")]
    public FhirPositiveInt? FrequencyMax { get; set; }

    /// <summary>
    /// 週期 - 事件在週期內發生的頻率
    /// FHIR Path: TimingRepeat.period
    /// Cardinality: 0..1
    /// Type: decimal
    /// </summary>
    [JsonPropertyName("period")]
    public FhirDecimal? Period { get; set; }

    /// <summary>
    /// 最大週期 - 週期上限
    /// FHIR Path: TimingRepeat.periodMax
    /// Cardinality: 0..1
    /// Type: decimal
    /// </summary>
    [JsonPropertyName("periodMax")]
    public FhirDecimal? PeriodMax { get; set; }

    /// <summary>
    /// 週期單位 - s | min | h | d | wk | mo | a
    /// FHIR Path: TimingRepeat.periodUnit
    /// Cardinality: 0..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("periodUnit")]
    public FhirCode? PeriodUnit { get; set; }

    /// <summary>
    /// 星期幾 - mon | tue | wed | thu | fri | sat | sun
    /// FHIR Path: TimingRepeat.dayOfWeek
    /// Cardinality: 0..*
    /// Type: code[]
    /// </summary>
    [JsonPropertyName("dayOfWeek")]
    public IList<FhirCode>? DayOfWeek { get; set; }

    /// <summary>
    /// 一天中的時間
    /// FHIR Path: TimingRepeat.timeOfDay
    /// Cardinality: 0..*
    /// Type: time[]
    /// </summary>
    [JsonPropertyName("timeOfDay")]
    public IList<FhirTime>? TimeOfDay { get; set; }

    /// <summary>
    /// 發生時間段的代碼
    /// FHIR Path: TimingRepeat.when
    /// Cardinality: 0..*
    /// Type: code[]
    /// </summary>
    [JsonPropertyName("when")]
    public IList<FhirCode>? When { get; set; }

    /// <summary>
    /// 與事件的偏移分鐘數（之前或之後）
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
    /// 檢查是否有計數
    /// </summary>
    /// <returns>如果存在計數則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasCount => Count?.Value != null;

    /// <summary>
    /// 檢查是否有最大計數
    /// </summary>
    /// <returns>如果存在最大計數則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasCountMax => CountMax?.Value != null;

    /// <summary>
    /// 檢查是否有持續時間
    /// </summary>
    /// <returns>如果存在持續時間則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasDuration => Duration?.Value != null;

    /// <summary>
    /// 檢查是否有最大持續時間
    /// </summary>
    /// <returns>如果存在最大持續時間則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasDurationMax => DurationMax?.Value != null;

    /// <summary>
    /// 檢查是否有持續時間單位
    /// </summary>
    /// <returns>如果存在持續時間單位則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasDurationUnit => !string.IsNullOrEmpty(DurationUnit?.Value);

    /// <summary>
    /// 檢查是否有頻率
    /// </summary>
    /// <returns>如果存在頻率則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasFrequency => Frequency?.Value != null;

    /// <summary>
    /// 檢查是否有最大頻率
    /// </summary>
    /// <returns>如果存在最大頻率則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasFrequencyMax => FrequencyMax?.Value != null;

    /// <summary>
    /// 檢查是否有週期
    /// </summary>
    /// <returns>如果存在週期則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasPeriod => Period?.Value != null;

    /// <summary>
    /// 檢查是否有最大週期
    /// </summary>
    /// <returns>如果存在最大週期則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasPeriodMax => PeriodMax?.Value != null;

    /// <summary>
    /// 檢查是否有週期單位
    /// </summary>
    /// <returns>如果存在週期單位則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasPeriodUnit => !string.IsNullOrEmpty(PeriodUnit?.Value);

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
    /// 檢查是否有何時
    /// </summary>
    /// <returns>如果存在何時則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasWhen => When?.Any() == true;

    /// <summary>
    /// 檢查是否有偏移
    /// </summary>
    /// <returns>如果存在偏移則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasOffset => Offset?.Value != null;

    /// <summary>
    /// 檢查時間重複是否有效
    /// </summary>
    /// <returns>如果時間重複有效則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool IsValid => HasBounds || HasCount || HasFrequency || HasPeriod || HasDayOfWeek || HasTimeOfDay || HasWhen;

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
            
            if (HasFrequency && HasPeriod)
            {
                parts.Add($"{Frequency?.Value} times per {Period?.Value} {PeriodUnit?.Value}");
            }
            else if (HasFrequency)
            {
                parts.Add($"{Frequency?.Value} times");
            }
            
            if (HasDuration)
            {
                parts.Add($"for {Duration?.Value} {DurationUnit?.Value}");
            }
            
            if (HasDayOfWeek)
            {
                var days = DayOfWeek?.Select(d => d.Value).Where(d => !string.IsNullOrEmpty(d));
                if (days?.Any() == true)
                {
                    parts.Add($"on {string.Join(", ", days)}");
                }
            }
            
            if (HasTimeOfDay)
            {
                var times = TimeOfDay?.Select(t => t.Value?.ToString()).Where(t => !string.IsNullOrEmpty(t));
                if (times?.Any() == true)
                {
                    parts.Add($"at {string.Join(", ", times)}");
                }
            }
            
            return parts.Any() ? string.Join(" ", parts) : "TimingRepeat";
        }
    }

    protected override void CopyFieldsTo(TimingRepeat target)
    {
        target.Bounds = Bounds?.DeepCopy() as TimingRepeatBoundsChoice;
        target.Count = Count?.DeepCopy() as FhirPositiveInt;
        target.CountMax = CountMax?.DeepCopy() as FhirPositiveInt;
        target.Duration = Duration?.DeepCopy() as FhirDecimal;
        target.DurationMax = DurationMax?.DeepCopy() as FhirDecimal;
        target.DurationUnit = DurationUnit?.DeepCopy() as FhirCode;
        target.Frequency = Frequency?.DeepCopy() as FhirPositiveInt;
        target.FrequencyMax = FrequencyMax?.DeepCopy() as FhirPositiveInt;
        target.Period = Period?.DeepCopy() as FhirDecimal;
        target.PeriodMax = PeriodMax?.DeepCopy() as FhirDecimal;
        target.PeriodUnit = PeriodUnit?.DeepCopy() as FhirCode;
        target.DayOfWeek = DayOfWeek?.Select(d => d.DeepCopy() as FhirCode).ToList();
        target.TimeOfDay = TimeOfDay?.Select(t => t.DeepCopy() as FhirTime).ToList();
        target.When = When?.Select(w => w.DeepCopy() as FhirCode).ToList();
        target.Offset = Offset?.DeepCopy() as FhirUnsignedInt;
    }

    protected override bool FieldsAreExactly(TimingRepeat other)
    {
        return DeepEqualityComparer.AreEqual(Bounds, other.Bounds) &&
               DeepEqualityComparer.AreEqual(Count, other.Count) &&
               DeepEqualityComparer.AreEqual(CountMax, other.CountMax) &&
               DeepEqualityComparer.AreEqual(Duration, other.Duration) &&
               DeepEqualityComparer.AreEqual(DurationMax, other.DurationMax) &&
               DeepEqualityComparer.AreEqual(DurationUnit, other.DurationUnit) &&
               DeepEqualityComparer.AreEqual(Frequency, other.Frequency) &&
               DeepEqualityComparer.AreEqual(FrequencyMax, other.FrequencyMax) &&
               DeepEqualityComparer.AreEqual(Period, other.Period) &&
               DeepEqualityComparer.AreEqual(PeriodMax, other.PeriodMax) &&
               DeepEqualityComparer.AreEqual(PeriodUnit, other.PeriodUnit) &&
               DeepEqualityComparer.AreEqual(DayOfWeek, other.DayOfWeek) &&
               DeepEqualityComparer.AreEqual(TimeOfDay, other.TimeOfDay) &&
               DeepEqualityComparer.AreEqual(When, other.When) &&
               DeepEqualityComparer.AreEqual(Offset, other.Offset);
    }

    protected override IEnumerable<ValidationResult> ValidateFields(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();

        // 驗證 Bounds
        if (Bounds != null)
        {
            results.AddRange(Bounds.Validate(validationContext));
        }

        // 驗證 Count
        if (Count != null)
        {
            results.AddRange(Count.Validate(validationContext));
        }

        // 驗證 CountMax
        if (CountMax != null)
        {
            results.AddRange(CountMax.Validate(validationContext));
        }

        // 驗證 Duration
        if (Duration != null)
        {
            results.AddRange(Duration.Validate(validationContext));
        }

        // 驗證 DurationMax
        if (DurationMax != null)
        {
            results.AddRange(DurationMax.Validate(validationContext));
        }

        // 驗證 DurationUnit
        if (DurationUnit != null)
        {
            results.AddRange(DurationUnit.Validate(validationContext));
        }

        // 驗證 Frequency
        if (Frequency != null)
        {
            results.AddRange(Frequency.Validate(validationContext));
        }

        // 驗證 FrequencyMax
        if (FrequencyMax != null)
        {
            results.AddRange(FrequencyMax.Validate(validationContext));
        }

        // 驗證 Period
        if (Period != null)
        {
            results.AddRange(Period.Validate(validationContext));
        }

        // 驗證 PeriodMax
        if (PeriodMax != null)
        {
            results.AddRange(PeriodMax.Validate(validationContext));
        }

        // 驗證 PeriodUnit
        if (PeriodUnit != null)
        {
            results.AddRange(PeriodUnit.Validate(validationContext));
        }

        // 驗證 DayOfWeek
        if (DayOfWeek != null)
        {
            foreach (var day in DayOfWeek)
            {
                if (day != null)
                {
                    results.AddRange(day.Validate(validationContext));
                }
            }
        }

        // 驗證 TimeOfDay
        if (TimeOfDay != null)
        {
            foreach (var time in TimeOfDay)
            {
                if (time != null)
                {
                    results.AddRange(time.Validate(validationContext));
                }
            }
        }

        // 驗證 When
        if (When != null)
        {
            foreach (var when in When)
            {
                if (when != null)
                {
                    results.AddRange(when.Validate(validationContext));
                }
            }
        }

        // 驗證 Offset
        if (Offset != null)
        {
            results.AddRange(Offset.Validate(validationContext));
        }

        return results;
    }
} 