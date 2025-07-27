using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.ComplexTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using OneOf;

namespace Fhir.TypeFramework.Extensions;

/// <summary>
/// FHIR Choice Type 擴展方法
/// 提供 LINQ 和匿名函數支援，增強使用者體驗
/// </summary>
public static class ChoiceTypeExtensions
{
    #region ExtensionValueChoice Extensions

    /// <summary>
    /// 為 ExtensionValueChoice 提供流暢的設定體驗
    /// </summary>
    /// <param name="extension">Extension 實例</param>
    /// <param name="valueSelector">值選擇器</param>
    /// <returns>Extension 實例</returns>
    public static Extension WithValue(this Extension extension, Func<ExtensionValueChoice, ExtensionValueChoice> valueSelector)
    {
        var choice = new ExtensionValueChoice();
        extension.Value = valueSelector(choice);
        return extension;
    }

    /// <summary>
    /// 設定 Extension 的字串值
    /// </summary>
    /// <param name="extension">Extension 實例</param>
    /// <param name="value">字串值</param>
    /// <returns>Extension 實例</returns>
    public static Extension WithStringValue(this Extension extension, string value)
    {
        extension.Value = new FhirString(value);
        return extension;
    }

    /// <summary>
    /// 設定 Extension 的整數值
    /// </summary>
    /// <param name="extension">Extension 實例</param>
    /// <param name="value">整數值</param>
    /// <returns>Extension 實例</returns>
    public static Extension WithIntegerValue(this Extension extension, int value)
    {
        extension.Value = new FhirInteger(value);
        return extension;
    }

    /// <summary>
    /// 設定 Extension 的布林值
    /// </summary>
    /// <param name="extension">Extension 實例</param>
    /// <param name="value">布林值</param>
    /// <returns>Extension 實例</returns>
    public static Extension WithBooleanValue(this Extension extension, bool value)
    {
        extension.Value = new FhirBoolean(value);
        return extension;
    }

    /// <summary>
    /// 設定 Extension 的小數值
    /// </summary>
    /// <param name="extension">Extension 實例</param>
    /// <param name="value">小數值</param>
    /// <returns>Extension 實例</returns>
    public static Extension WithDecimalValue(this Extension extension, decimal value)
    {
        extension.Value = new FhirDecimal(value);
        return extension;
    }

    /// <summary>
    /// 設定 Extension 的日期時間值
    /// </summary>
    /// <param name="extension">Extension 實例</param>
    /// <param name="value">日期時間值</param>
    /// <returns>Extension 實例</returns>
    public static Extension WithDateTimeValue(this Extension extension, DateTime value)
    {
        extension.Value = new FhirDateTime(value);
        return extension;
    }

    #endregion

    #region Patient Choice Extensions

    /// <summary>
    /// 設定 Patient 的死亡狀態（布林值）
    /// </summary>
    /// <param name="patient">Patient 實例</param>
    /// <param name="value">布林值</param>
    /// <returns>Patient 實例</returns>
    public static Patient WithDeceased(this Patient patient, bool value)
    {
        patient.Deceased = new PatientDeceasedChoice(new FhirBoolean(value));
        return patient;
    }

    /// <summary>
    /// 設定 Patient 的死亡日期
    /// </summary>
    /// <param name="patient">Patient 實例</param>
    /// <param name="value">日期時間值</param>
    /// <returns>Patient 實例</returns>
    public static Patient WithDeceasedDate(this Patient patient, DateTime value)
    {
        patient.Deceased = new PatientDeceasedChoice(new FhirDateTime(value));
        return patient;
    }

    /// <summary>
    /// 設定 Patient 的多胞胎狀態（布林值）
    /// </summary>
    /// <param name="patient">Patient 實例</param>
    /// <param name="value">布林值</param>
    /// <returns>Patient 實例</returns>
    public static Patient WithMultipleBirth(this Patient patient, bool value)
    {
        patient.MultipleBirth = new PatientMultipleBirthChoice(new FhirBoolean(value));
        return patient;
    }

    /// <summary>
    /// 設定 Patient 的多胞胎數量
    /// </summary>
    /// <param name="patient">Patient 實例</param>
    /// <param name="value">整數值</param>
    /// <returns>Patient 實例</returns>
    public static Patient WithMultipleBirthCount(this Patient patient, int value)
    {
        patient.MultipleBirth = new PatientMultipleBirthChoice(new FhirInteger(value));
        return patient;
    }

    #endregion

    #region Observation Choice Extensions

    /// <summary>
    /// 設定 Observation 的有效時間（日期時間）
    /// </summary>
    /// <param name="observation">Observation 實例</param>
    /// <param name="value">日期時間值</param>
    /// <returns>Observation 實例</returns>
    public static Observation WithEffectiveDateTime(this Observation observation, DateTime value)
    {
        observation.Effective = new ObservationEffectiveChoice(new FhirDateTime(value));
        return observation;
    }

    /// <summary>
    /// 設定 Observation 的有效時間（期間）
    /// </summary>
    /// <param name="observation">Observation 實例</param>
    /// <param name="value">期間值</param>
    /// <returns>Observation 實例</returns>
    public static Observation WithEffectivePeriod(this Observation observation, Period value)
    {
        observation.Effective = new ObservationEffectiveChoice(value);
        return observation;
    }

    /// <summary>
    /// 設定 Observation 的有效時間（時間安排）
    /// </summary>
    /// <param name="observation">Observation 實例</param>
    /// <param name="value">時間安排值</param>
    /// <returns>Observation 實例</returns>
    public static Observation WithEffectiveTiming(this Observation observation, Timing value)
    {
        observation.Effective = new ObservationEffectiveChoice(value);
        return observation;
    }

    /// <summary>
    /// 設定 Observation 的有效時間（即時）
    /// </summary>
    /// <param name="observation">Observation 實例</param>
    /// <param name="value">即時值</param>
    /// <returns>Observation 實例</returns>
    public static Observation WithEffectiveInstant(this Observation observation, DateTime value)
    {
        observation.Effective = new ObservationEffectiveChoice(new FhirInstant(value));
        return observation;
    }

    /// <summary>
    /// 設定 Observation 的值（數量）
    /// </summary>
    /// <param name="observation">Observation 實例</param>
    /// <param name="value">數量值</param>
    /// <returns>Observation 實例</returns>
    public static Observation WithQuantityValue(this Observation observation, Quantity value)
    {
        observation.Value = new ObservationValueChoice(value);
        return observation;
    }

    /// <summary>
    /// 設定 Observation 的值（可編碼概念）
    /// </summary>
    /// <param name="observation">Observation 實例</param>
    /// <param name="value">可編碼概念值</param>
    /// <returns>Observation 實例</returns>
    public static Observation WithCodeableConceptValue(this Observation observation, CodeableConcept value)
    {
        observation.Value = new ObservationValueChoice(value);
        return observation;
    }

    /// <summary>
    /// 設定 Observation 的值（字串）
    /// </summary>
    /// <param name="observation">Observation 實例</param>
    /// <param name="value">字串值</param>
    /// <returns>Observation 實例</returns>
    public static Observation WithStringValue(this Observation observation, string value)
    {
        observation.Value = new ObservationValueChoice(new FhirString(value));
        return observation;
    }

    /// <summary>
    /// 設定 Observation 的值（布林值）
    /// </summary>
    /// <param name="observation">Observation 實例</param>
    /// <param name="value">布林值</param>
    /// <returns>Observation 實例</returns>
    public static Observation WithBooleanValue(this Observation observation, bool value)
    {
        observation.Value = new ObservationValueChoice(new FhirBoolean(value));
        return observation;
    }

    /// <summary>
    /// 設定 Observation 的值（整數）
    /// </summary>
    /// <param name="observation">Observation 實例</param>
    /// <param name="value">整數值</param>
    /// <returns>Observation 實例</returns>
    public static Observation WithIntegerValue(this Observation observation, int value)
    {
        observation.Value = new ObservationValueChoice(new FhirInteger(value));
        return observation;
    }

    #endregion

    #region Condition Choice Extensions

    /// <summary>
    /// 設定 Condition 的發作時間（日期時間）
    /// </summary>
    /// <param name="condition">Condition 實例</param>
    /// <param name="value">日期時間值</param>
    /// <returns>Condition 實例</returns>
    public static Condition WithOnsetDateTime(this Condition condition, DateTime value)
    {
        condition.Onset = new ConditionOnsetChoice(new FhirDateTime(value));
        return condition;
    }

    /// <summary>
    /// 設定 Condition 的發作時間（年齡）
    /// </summary>
    /// <param name="condition">Condition 實例</param>
    /// <param name="value">年齡值</param>
    /// <returns>Condition 實例</returns>
    public static Condition WithOnsetAge(this Condition condition, Age value)
    {
        condition.Onset = new ConditionOnsetChoice(value);
        return condition;
    }

    /// <summary>
    /// 設定 Condition 的發作時間（期間）
    /// </summary>
    /// <param name="condition">Condition 實例</param>
    /// <param name="value">期間值</param>
    /// <returns>Condition 實例</returns>
    public static Condition WithOnsetPeriod(this Condition condition, Period value)
    {
        condition.Onset = new ConditionOnsetChoice(value);
        return condition;
    }

    /// <summary>
    /// 設定 Condition 的發作時間（範圍）
    /// </summary>
    /// <param name="condition">Condition 實例</param>
    /// <param name="value">範圍值</param>
    /// <returns>Condition 實例</returns>
    public static Condition WithOnsetRange(this Condition condition, Range value)
    {
        condition.Onset = new ConditionOnsetChoice(value);
        return condition;
    }

    /// <summary>
    /// 設定 Condition 的發作時間（字串）
    /// </summary>
    /// <param name="condition">Condition 實例</param>
    /// <param name="value">字串值</param>
    /// <returns>Condition 實例</returns>
    public static Condition WithOnsetString(this Condition condition, string value)
    {
        condition.Onset = new ConditionOnsetChoice(new FhirString(value));
        return condition;
    }

    #endregion

    #region Procedure Choice Extensions

    /// <summary>
    /// 設定 Procedure 的執行時間（日期時間）
    /// </summary>
    /// <param name="procedure">Procedure 實例</param>
    /// <param name="value">日期時間值</param>
    /// <returns>Procedure 實例</returns>
    public static Procedure WithPerformedDateTime(this Procedure procedure, DateTime value)
    {
        procedure.Performed = new ProcedurePerformedChoice(new FhirDateTime(value));
        return procedure;
    }

    /// <summary>
    /// 設定 Procedure 的執行時間（期間）
    /// </summary>
    /// <param name="procedure">Procedure 實例</param>
    /// <param name="value">期間值</param>
    /// <returns>Procedure 實例</returns>
    public static Procedure WithPerformedPeriod(this Procedure procedure, Period value)
    {
        procedure.Performed = new ProcedurePerformedChoice(value);
        return procedure;
    }

    /// <summary>
    /// 設定 Procedure 的執行時間（字串）
    /// </summary>
    /// <param name="procedure">Procedure 實例</param>
    /// <param name="value">字串值</param>
    /// <returns>Procedure 實例</returns>
    public static Procedure WithPerformedString(this Procedure procedure, string value)
    {
        procedure.Performed = new ProcedurePerformedChoice(new FhirString(value));
        return procedure;
    }

    /// <summary>
    /// 設定 Procedure 的執行時間（年齡）
    /// </summary>
    /// <param name="procedure">Procedure 實例</param>
    /// <param name="value">年齡值</param>
    /// <returns>Procedure 實例</returns>
    public static Procedure WithPerformedAge(this Procedure procedure, Age value)
    {
        procedure.Performed = new ProcedurePerformedChoice(value);
        return procedure;
    }

    /// <summary>
    /// 設定 Procedure 的執行時間（範圍）
    /// </summary>
    /// <param name="procedure">Procedure 實例</param>
    /// <param name="value">範圍值</param>
    /// <returns>Procedure 實例</returns>
    public static Procedure WithPerformedRange(this Procedure procedure, Range value)
    {
        procedure.Performed = new ProcedurePerformedChoice(value);
        return procedure;
    }

    #endregion

    #region Timing Repeat Choice Extensions

    /// <summary>
    /// 設定 TimingRepeat 的邊界（持續時間）
    /// </summary>
    /// <param name="timingRepeat">TimingRepeat 實例</param>
    /// <param name="value">持續時間值</param>
    /// <returns>TimingRepeat 實例</returns>
    public static TimingRepeat WithBoundsDuration(this TimingRepeat timingRepeat, Duration value)
    {
        timingRepeat.Bounds = new TimingRepeatBoundsChoice(value);
        return timingRepeat;
    }

    /// <summary>
    /// 設定 TimingRepeat 的邊界（範圍）
    /// </summary>
    /// <param name="timingRepeat">TimingRepeat 實例</param>
    /// <param name="value">範圍值</param>
    /// <returns>TimingRepeat 實例</returns>
    public static TimingRepeat WithBoundsRange(this TimingRepeat timingRepeat, Range value)
    {
        timingRepeat.Bounds = new TimingRepeatBoundsChoice(value);
        return timingRepeat;
    }

    #endregion

    #region Annotation Choice Extensions

    /// <summary>
    /// 設定 Annotation 的作者（參考）
    /// </summary>
    /// <param name="annotation">Annotation 實例</param>
    /// <param name="value">參考值</param>
    /// <returns>Annotation 實例</returns>
    public static Annotation WithAuthorReference(this Annotation annotation, Reference value)
    {
        annotation.Author = new AnnotationAuthorChoice(value);
        return annotation;
    }

    /// <summary>
    /// 設定 Annotation 的作者（字串）
    /// </summary>
    /// <param name="annotation">Annotation 實例</param>
    /// <param name="value">字串值</param>
    /// <returns>Annotation 實例</returns>
    public static Annotation WithAuthorString(this Annotation annotation, string value)
    {
        annotation.Author = new AnnotationAuthorChoice(new FhirString(value));
        return annotation;
    }

    #endregion

    #region Fluent API for Complex Type Creation

    /// <summary>
    /// 創建 Quantity 的流暢 API
    /// </summary>
    /// <param name="value">數值</param>
    /// <param name="unit">單位</param>
    /// <returns>Quantity 實例</returns>
    public static Quantity CreateQuantity(decimal value, string unit)
    {
        return new Quantity
        {
            Value = new FhirDecimal(value),
            Unit = new FhirString(unit)
        };
    }

    /// <summary>
    /// 創建 Period 的流暢 API
    /// </summary>
    /// <param name="start">開始時間</param>
    /// <param name="end">結束時間</param>
    /// <returns>Period 實例</returns>
    public static Period CreatePeriod(DateTime start, DateTime end)
    {
        return new Period
        {
            Start = new FhirDateTime(start),
            End = new FhirDateTime(end)
        };
    }

    /// <summary>
    /// 創建 Range 的流暢 API
    /// </summary>
    /// <param name="low">低值</param>
    /// <param name="high">高值</param>
    /// <returns>Range 實例</returns>
    public static Range CreateRange(Quantity low, Quantity high)
    {
        return new Range
        {
            Low = low,
            High = high
        };
    }

    /// <summary>
    /// 創建 Age 的流暢 API
    /// </summary>
    /// <param name="value">數值</param>
    /// <param name="unit">單位</param>
    /// <returns>Age 實例</returns>
    public static Age CreateAge(decimal value, string unit)
    {
        return new Age
        {
            Value = new FhirDecimal(value),
            Unit = new FhirString(unit)
        };
    }

    /// <summary>
    /// 創建 Duration 的流暢 API
    /// </summary>
    /// <param name="value">數值</param>
    /// <param name="unit">單位</param>
    /// <returns>Duration 實例</returns>
    public static Duration CreateDuration(decimal value, string unit)
    {
        return new Duration
        {
            Value = new FhirDecimal(value),
            Unit = new FhirString(unit)
        };
    }

    #endregion
} 