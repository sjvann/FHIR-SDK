using OneOf;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;

namespace Fhir.TypeFramework.DataTypes.ComplexTypes;

/// <summary>
/// FHIR Choice Type - 支援多種資料型態的選擇
/// 根據 FHIR R5 規範，Choice Type 用 [x] 表示，可以接受多種型別
/// </summary>
/// <typeparam name="T1">第一種可能的型別</typeparam>
/// <typeparam name="T2">第二種可能的型別</typeparam>
/// <typeparam name="T3">第三種可能的型別</typeparam>
/// <typeparam name="T4">第四種可能的型別</typeparam>
/// <typeparam name="T5">第五種可能的型別</typeparam>
/// <remarks>
/// 使用 OneOf 套件實作 FHIR Choice Type，提供型別安全的選擇機制。
/// 支援隱含轉換，可以直接指派任何支援的型別。
/// </remarks>
public class ChoiceType<T1, T2, T3, T4, T5> : 
    OneOfBase<T1, T2, T3, T4, T5>
    where T1 : class
    where T2 : class
    where T3 : class
    where T4 : class
    where T5 : class
{
    /// <summary>
    /// 初始化 ChoiceType
    /// </summary>
    /// <param name="input">OneOf 輸入值</param>
    public ChoiceType(OneOf<T1, T2, T3, T4, T5> input) : base(input) { }

    // 隱含轉換運算子
    public static implicit operator ChoiceType<T1, T2, T3, T4, T5>(T1 t) => new(OneOf<T1, T2, T3, T4, T5>.FromT0(t));
    public static implicit operator ChoiceType<T1, T2, T3, T4, T5>(T2 t) => new(OneOf<T1, T2, T3, T4, T5>.FromT1(t));
    public static implicit operator ChoiceType<T1, T2, T3, T4, T5>(T3 t) => new(OneOf<T1, T2, T3, T4, T5>.FromT2(t));
    public static implicit operator ChoiceType<T1, T2, T3, T4, T5>(T4 t) => new(OneOf<T1, T2, T3, T4, T5>.FromT3(t));
    public static implicit operator ChoiceType<T1, T2, T3, T4, T5>(T5 t) => new(OneOf<T1, T2, T3, T4, T5>.FromT4(t));
}

/// <summary>
/// FHIR Choice Type - 支援 4 種資料型態的選擇
/// </summary>
public class ChoiceType<T1, T2, T3, T4> : 
    OneOfBase<T1, T2, T3, T4>
    where T1 : class
    where T2 : class
    where T3 : class
    where T4 : class
{
    public ChoiceType(OneOf<T1, T2, T3, T4> input) : base(input) { }

    public static implicit operator ChoiceType<T1, T2, T3, T4>(T1 t) => new(OneOf<T1, T2, T3, T4>.FromT0(t));
    public static implicit operator ChoiceType<T1, T2, T3, T4>(T2 t) => new(OneOf<T1, T2, T3, T4>.FromT1(t));
    public static implicit operator ChoiceType<T1, T2, T3, T4>(T3 t) => new(OneOf<T1, T2, T3, T4>.FromT2(t));
    public static implicit operator ChoiceType<T1, T2, T3, T4>(T4 t) => new(OneOf<T1, T2, T3, T4>.FromT3(t));
}

/// <summary>
/// FHIR Choice Type - 支援 3 種資料型態的選擇
/// </summary>
public class ChoiceType<T1, T2, T3> : 
    OneOfBase<T1, T2, T3>
    where T1 : class
    where T2 : class
    where T3 : class
{
    public ChoiceType(OneOf<T1, T2, T3> input) : base(input) { }

    public static implicit operator ChoiceType<T1, T2, T3>(T1 t) => new(OneOf<T1, T2, T3>.FromT0(t));
    public static implicit operator ChoiceType<T1, T2, T3>(T2 t) => new(OneOf<T1, T2, T3>.FromT1(t));
    public static implicit operator ChoiceType<T1, T2, T3>(T3 t) => new(OneOf<T1, T2, T3>.FromT2(t));
}

/// <summary>
/// FHIR Choice Type - 支援 2 種資料型態的選擇
/// </summary>
public class ChoiceType<T1, T2> : 
    OneOfBase<T1, T2>
    where T1 : class
    where T2 : class
{
    public ChoiceType(OneOf<T1, T2> input) : base(input) { }

    public static implicit operator ChoiceType<T1, T2>(T1 t) => new(OneOf<T1, T2>.FromT0(t));
    public static implicit operator ChoiceType<T1, T2>(T2 t) => new(OneOf<T1, T2>.FromT1(t));
}

// ============================================================================
// 具體的 Choice Type 定義
// ============================================================================

/// <summary>
/// Extension.value[x] - 支援所有 FHIR 資料型別
/// 根據 FHIR R5 規範，Extension.value[x] 可以接受所有 FHIR 資料型別
/// </summary>
public class ExtensionValueChoice : ChoiceType<
    // Primitive Types
    FhirString, FhirInteger, FhirBoolean, FhirDecimal, FhirDateTime
>
{
    public ExtensionValueChoice(OneOf<FhirString, FhirInteger, FhirBoolean, FhirDecimal, FhirDateTime> input) : base(input) { }

    // 隱含轉換運算子 - 主要 Primitive Types
    public static implicit operator ExtensionValueChoice(FhirString value) => new(value);
    public static implicit operator ExtensionValueChoice(FhirInteger value) => new(value);
    public static implicit operator ExtensionValueChoice(FhirBoolean value) => new(value);
    public static implicit operator ExtensionValueChoice(FhirDecimal value) => new(value);
    public static implicit operator ExtensionValueChoice(FhirDateTime value) => new(value);
}

/// <summary>
/// Annotation.author[x] - 支援 Reference 或 string
/// 根據 FHIR R5 規範，Annotation.author[x] 可以是 Reference 或 string
/// </summary>
public class AnnotationAuthorChoice : ChoiceType<Reference, FhirString>
{
    public AnnotationAuthorChoice(OneOf<Reference, FhirString> input) : base(input) { }

    public static implicit operator AnnotationAuthorChoice(Reference value) => new(value);
    public static implicit operator AnnotationAuthorChoice(FhirString value) => new(value);
}

/// <summary>
/// Patient.deceased[x] - 支援 boolean 或 dateTime
/// 根據 FHIR R5 規範，Patient.deceased[x] 可以是 boolean 或 dateTime
/// </summary>
public class PatientDeceasedChoice : ChoiceType<FhirBoolean, FhirDateTime>
{
    public PatientDeceasedChoice(OneOf<FhirBoolean, FhirDateTime> input) : base(input) { }

    public static implicit operator PatientDeceasedChoice(FhirBoolean value) => new(value);
    public static implicit operator PatientDeceasedChoice(FhirDateTime value) => new(value);
}

/// <summary>
/// Patient.multipleBirth[x] - 支援 boolean 或 integer
/// 根據 FHIR R5 規範，Patient.multipleBirth[x] 可以是 boolean 或 integer
/// </summary>
public class PatientMultipleBirthChoice : ChoiceType<FhirBoolean, FhirInteger>
{
    public PatientMultipleBirthChoice(OneOf<FhirBoolean, FhirInteger> input) : base(input) { }

    public static implicit operator PatientMultipleBirthChoice(FhirBoolean value) => new(value);
    public static implicit operator PatientMultipleBirthChoice(FhirInteger value) => new(value);
}

/// <summary>
/// Observation.effective[x] - 支援多種時間型別
/// 根據 FHIR R5 規範，Observation.effective[x] 可以是 dateTime, Period, Timing, instant
/// </summary>
public class ObservationEffectiveChoice : ChoiceType<FhirDateTime, Period, Timing, FhirInstant>
{
    public ObservationEffectiveChoice(OneOf<FhirDateTime, Period, Timing, FhirInstant> input) : base(input) { }

    public static implicit operator ObservationEffectiveChoice(FhirDateTime value) => new(value);
    public static implicit operator ObservationEffectiveChoice(Period value) => new(value);
    public static implicit operator ObservationEffectiveChoice(Timing value) => new(value);
    public static implicit operator ObservationEffectiveChoice(FhirInstant value) => new(value);
}

/// <summary>
/// Observation.value[x] - 支援多種數值型別
/// 根據 FHIR R5 規範，Observation.value[x] 可以是 Quantity, CodeableConcept, string, boolean 等
/// </summary>
public class ObservationValueChoice : ChoiceType<Quantity, CodeableConcept, FhirString, FhirBoolean, FhirInteger>
{
    public ObservationValueChoice(OneOf<Quantity, CodeableConcept, FhirString, FhirBoolean, FhirInteger> input) : base(input) { }

    public static implicit operator ObservationValueChoice(Quantity value) => new(value);
    public static implicit operator ObservationValueChoice(CodeableConcept value) => new(value);
    public static implicit operator ObservationValueChoice(FhirString value) => new(value);
    public static implicit operator ObservationValueChoice(FhirBoolean value) => new(value);
    public static implicit operator ObservationValueChoice(FhirInteger value) => new(value);
}

/// <summary>
/// Condition.onset[x] - 支援多種時間型別
/// 根據 FHIR R5 規範，Condition.onset[x] 可以是 dateTime, Age, Period, Range, FhirString
/// </summary>
public class ConditionOnsetChoice : ChoiceType<FhirDateTime, Age, Period, Range, FhirString>
{
    public ConditionOnsetChoice(OneOf<FhirDateTime, Age, Period, Range, FhirString> input) : base(input) { }

    public static implicit operator ConditionOnsetChoice(FhirDateTime value) => new(value);
    public static implicit operator ConditionOnsetChoice(Age value) => new(value);
    public static implicit operator ConditionOnsetChoice(Period value) => new(value);
    public static implicit operator ConditionOnsetChoice(Range value) => new(value);
    public static implicit operator ConditionOnsetChoice(FhirString value) => new(value);
}

/// <summary>
/// Condition.abatement[x] - 支援多種時間型別
/// 根據 FHIR R5 規範，Condition.abatement[x] 可以是 dateTime, Age, Period, Range, FhirString
/// </summary>
public class ConditionAbatementChoice : ChoiceType<FhirDateTime, Age, Period, Range, FhirString>
{
    public ConditionAbatementChoice(OneOf<FhirDateTime, Age, Period, Range, FhirString> input) : base(input) { }

    public static implicit operator ConditionAbatementChoice(FhirDateTime value) => new(value);
    public static implicit operator ConditionAbatementChoice(Age value) => new(value);
    public static implicit operator ConditionAbatementChoice(Period value) => new(value);
    public static implicit operator ConditionAbatementChoice(Range value) => new(value);
    public static implicit operator ConditionAbatementChoice(FhirString value) => new(value);
}

/// <summary>
/// Procedure.performed[x] - 支援多種時間型別
/// 根據 FHIR R5 規範，Procedure.performed[x] 可以是 dateTime, Period, FhirString, Age, Range
/// </summary>
public class ProcedurePerformedChoice : ChoiceType<FhirDateTime, Period, FhirString, Age, Range>
{
    public ProcedurePerformedChoice(OneOf<FhirDateTime, Period, FhirString, Age, Range> input) : base(input) { }

    public static implicit operator ProcedurePerformedChoice(FhirDateTime value) => new(value);
    public static implicit operator ProcedurePerformedChoice(Period value) => new(value);
    public static implicit operator ProcedurePerformedChoice(FhirString value) => new(value);
    public static implicit operator ProcedurePerformedChoice(Age value) => new(value);
    public static implicit operator ProcedurePerformedChoice(Range value) => new(value);
}

/// <summary>
/// Timing.repeat.bounds[x] - 支援 Duration 或 Range
/// 根據 FHIR R5 規範，Timing.repeat.bounds[x] 可以是 Duration 或 Range
/// </summary>
public class TimingRepeatBoundsChoice : ChoiceType<Duration, Range>
{
    public TimingRepeatBoundsChoice(OneOf<Duration, Range> input) : base(input) { }

    public static implicit operator TimingRepeatBoundsChoice(Duration value) => new(value);
    public static implicit operator TimingRepeatBoundsChoice(Range value) => new(value);
} 