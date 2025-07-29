using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Timing - 時間型別
/// 用於描述時間相關的資訊
/// </summary>
/// <remarks>
/// FHIR R5 Timing (Complex Type)
/// Specifies an event that may occur multiple times.
/// 
/// Structure:
/// - event: dateTime[] (0..*) - When the event occurs
/// - repeat: TimingRepeat (0..1) - When the event is to occur
/// - code: CodeableConcept (0..1) - BID | TID | QID | AM | PM | QD | QOD | +
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Timing : UnifiedComplexTypeBase<Timing>
{
    /// <summary>
    /// 事件發生的時間
    /// FHIR Path: Timing.event
    /// Cardinality: 0..*
    /// Type: dateTime[]
    /// </summary>
    [JsonPropertyName("event")]
    public IList<FhirDateTime>? Event { get; set; }

    /// <summary>
    /// 事件發生的重複模式
    /// FHIR Path: Timing.repeat
    /// Cardinality: 0..1
    /// Type: TimingRepeat
    /// </summary>
    [JsonPropertyName("repeat")]
    public TimingRepeat? Repeat { get; set; }

    /// <summary>
    /// 代碼 - BID | TID | QID | AM | PM | QD | QOD | +
    /// FHIR Path: Timing.code
    /// Cardinality: 0..1
    /// Type: CodeableConcept
    /// </summary>
    [JsonPropertyName("code")]
    public CodeableConcept? Code { get; set; }

    /// <summary>
    /// 檢查是否有事件
    /// </summary>
    /// <returns>如果存在事件則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasEvent => Event?.Any() == true;

    /// <summary>
    /// 檢查是否有重複
    /// </summary>
    /// <returns>如果存在重複則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasRepeat => Repeat != null;

    /// <summary>
    /// 檢查是否有代碼
    /// </summary>
    /// <returns>如果存在代碼則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasCode => Code != null;

    /// <summary>
    /// 檢查時間是否有效
    /// </summary>
    /// <returns>如果時間有效則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool IsValid => HasEvent || HasRepeat || HasCode;

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
            
            if (HasCode)
            {
                parts.Add(Code?.DisplayText);
            }
            
            if (HasRepeat)
            {
                parts.Add(Repeat?.DisplayText);
            }
            
            if (HasEvent)
            {
                var eventTexts = Event?.Select(e => e.Value?.ToString()).Where(e => !string.IsNullOrEmpty(e));
                if (eventTexts?.Any() == true)
                {
                    parts.Add($"Events: {string.Join(", ", eventTexts)}");
                }
            }
            
            return parts.Any() ? string.Join(" ", parts) : "Timing";
        }
    }

    protected override void CopyFieldsTo(Timing target)
    {
        target.Event = Event?.Select(e => e.DeepCopy() as FhirDateTime).ToList();
        target.Repeat = Repeat?.DeepCopy() as TimingRepeat;
        target.Code = Code?.DeepCopy() as CodeableConcept;
    }

    protected override bool FieldsAreExactly(Timing other)
    {
        return DeepEqualityComparer.AreEqual(Event, other.Event) &&
               DeepEqualityComparer.AreEqual(Repeat, other.Repeat) &&
               DeepEqualityComparer.AreEqual(Code, other.Code);
    }

    protected override IEnumerable<ValidationResult> ValidateFields(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();

        // 驗證 Event
        if (Event != null)
        {
            foreach (var evt in Event)
            {
                if (evt != null)
                {
                    results.AddRange(evt.Validate(validationContext));
                }
            }
        }

        // 驗證 Repeat
        if (Repeat != null)
        {
            results.AddRange(Repeat.Validate(validationContext));
        }

        // 驗證 Code
        if (Code != null)
        {
            results.AddRange(Code.Validate(validationContext));
        }

        return results;
    }
} 