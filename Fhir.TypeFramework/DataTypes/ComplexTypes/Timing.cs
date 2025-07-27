using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Timing - 時間安排
/// 用於描述事件發生的時間安排
/// </summary>
/// <remarks>
/// FHIR R5 Timing (Complex Type)
/// Specifies an event that may occur multiple times. Timing schedules are used for
/// recording when things are planned, expected or requested to occur.
/// 
/// Structure:
/// - event: dateTime[] (0..*) - When the event occurs
/// - repeat: TimingRepeat (0..1) - When the event is to occur
/// - code: CodeableConcept (0..1) - BID | TID | QID | AM | PM | QD | QOD | +
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Timing : Element, IExtensibleTypeFramework
{
    /// <summary>
    /// 事件發生的時間
    /// FHIR Path: Timing.event
    /// Cardinality: 0..*
    /// Type: dateTime[]
    /// </summary>
    [JsonPropertyName("event")]
    public List<FhirDateTime>? Event { get; set; }

    /// <summary>
    /// 事件重複的時間安排
    /// FHIR Path: Timing.repeat
    /// Cardinality: 0..1
    /// Type: TimingRepeat
    /// </summary>
    [JsonPropertyName("repeat")]
    public TimingRepeat? Repeat { get; set; }

    /// <summary>
    /// 時間安排代碼
    /// FHIR Path: Timing.code
    /// Cardinality: 0..1
    /// Type: CodeableConcept
    /// </summary>
    [JsonPropertyName("code")]
    public CodeableConcept? Code { get; set; }

    /// <summary>
    /// 檢查是否有事件時間
    /// </summary>
    /// <returns>如果存在事件時間則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasEvent => Event?.Any() == true;

    /// <summary>
    /// 檢查是否有重複安排
    /// </summary>
    /// <returns>如果存在重複安排則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasRepeat => Repeat != null;

    /// <summary>
    /// 檢查是否有代碼
    /// </summary>
    /// <returns>如果存在代碼則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasCode => Code != null;

    /// <summary>
    /// 添加事件時間
    /// </summary>
    /// <param name="eventTime">事件時間</param>
    public void AddEvent(DateTime eventTime)
    {
        Event ??= new List<FhirDateTime>();
        Event.Add(new FhirDateTime(eventTime));
    }

    /// <summary>
    /// 添加事件時間（字串格式）
    /// </summary>
    /// <param name="eventTime">事件時間字串</param>
    public void AddEvent(string eventTime)
    {
        Event ??= new List<FhirDateTime>();
        Event.Add(new FhirDateTime(eventTime));
    }

    /// <summary>
    /// 設定重複安排
    /// </summary>
    /// <param name="repeat">重複安排</param>
    public void SetRepeat(TimingRepeat repeat)
    {
        Repeat = repeat;
    }

    /// <summary>
    /// 設定代碼
    /// </summary>
    /// <param name="code">時間安排代碼</param>
    public void SetCode(CodeableConcept code)
    {
        Code = code;
    }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>Timing 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = new Timing
        {
            Id = Id
        };

        if (Event != null)
        {
            copy.Event = Event.Select(e => e.DeepCopy() as FhirDateTime).ToList();
        }

        if (Repeat != null)
        {
            copy.Repeat = Repeat.DeepCopy() as TimingRepeat;
        }

        if (Code != null)
        {
            copy.Code = Code.DeepCopy() as CodeableConcept;
        }

        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 Timing 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not Timing otherTiming)
            return false;

        return base.IsExactly(other) &&
               Event?.Count == otherTiming.Event?.Count &&
               Equals(Repeat, otherTiming.Repeat) &&
               Equals(Code, otherTiming.Code);
    }

    /// <summary>
    /// 驗證 Timing 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證事件時間
        if (Event != null)
        {
            foreach (var eventTime in Event)
            {
                if (eventTime != null)
                {
                    var eventValidationContext = new ValidationContext(eventTime);
                    foreach (var result in eventTime.Validate(eventValidationContext))
                    {
                        yield return result;
                    }
                }
            }
        }

        // 驗證重複安排
        if (Repeat != null)
        {
            var repeatValidationContext = new ValidationContext(Repeat);
            foreach (var result in Repeat.Validate(repeatValidationContext))
            {
                yield return result;
            }
        }

        // 驗證代碼
        if (Code != null)
        {
            var codeValidationContext = new ValidationContext(Code);
            foreach (var result in Code.Validate(codeValidationContext))
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