using Fhir.TypeFramework.DataTypes.PrimitiveTypes;

namespace Fhir.TypeFramework.Extensions;

/// <summary>
/// FHIR Primitive Type 擴展方法
/// 提供流暢的型別轉換體驗
/// </summary>
public static class PrimitiveTypeExtensions
{
    #region String Extensions

    /// <summary>
    /// 將字串轉換為 FhirString
    /// </summary>
    /// <param name="value">字串值</param>
    /// <returns>FhirString 實例</returns>
    public static FhirString ToFhirString(this string value)
    {
        return new FhirString(value);
    }

    /// <summary>
    /// 將字串轉換為 FhirUri
    /// </summary>
    /// <param name="value">URI 字串</param>
    /// <returns>FhirUri 實例</returns>
    public static FhirUri ToFhirUri(this string value)
    {
        return new FhirUri(value);
    }

    /// <summary>
    /// 將字串轉換為 FhirCode
    /// </summary>
    /// <param name="value">代碼字串</param>
    /// <returns>FhirCode 實例</returns>
    public static FhirCode ToFhirCode(this string value)
    {
        return new FhirCode(value);
    }

    /// <summary>
    /// 將字串轉換為 FhirId
    /// </summary>
    /// <param name="value">ID 字串</param>
    /// <returns>FhirId 實例</returns>
    public static FhirId ToFhirId(this string value)
    {
        return new FhirId(value);
    }

    /// <summary>
    /// 將字串轉換為 FhirCanonical
    /// </summary>
    /// <param name="value">Canonical 字串</param>
    /// <returns>FhirCanonical 實例</returns>
    public static FhirCanonical ToFhirCanonical(this string value)
    {
        return new FhirCanonical(value);
    }

    /// <summary>
    /// 將字串轉換為 FhirDateTime
    /// </summary>
    /// <param name="value">日期時間字串</param>
    /// <returns>FhirDateTime 實例</returns>
    public static FhirDateTime ToFhirDateTime(this string value)
    {
        return new FhirDateTime(value);
    }

    /// <summary>
    /// 將字串轉換為 FhirDate
    /// </summary>
    /// <param name="value">日期字串</param>
    /// <returns>FhirDate 實例</returns>
    public static FhirDate ToFhirDate(this string value)
    {
        return new FhirDate(value);
    }

    /// <summary>
    /// 將字串轉換為 FhirTime
    /// </summary>
    /// <param name="value">時間字串</param>
    /// <returns>FhirTime 實例</returns>
    public static FhirTime ToFhirTime(this string value)
    {
        return new FhirTime(value);
    }

    /// <summary>
    /// 將字串轉換為 FhirInstant
    /// </summary>
    /// <param name="value">即時字串</param>
    /// <returns>FhirInstant 實例</returns>
    public static FhirInstant ToFhirInstant(this string value)
    {
        return new FhirInstant(value);
    }

    /// <summary>
    /// 將字串轉換為 FhirXhtml
    /// </summary>
    /// <param name="value">XHTML 字串</param>
    /// <returns>FhirXhtml 實例</returns>
    public static FhirXhtml ToFhirXhtml(this string value)
    {
        return new FhirXhtml(value);
    }

    #endregion

    #region Numeric Extensions

    /// <summary>
    /// 將整數轉換為 FhirInteger
    /// </summary>
    /// <param name="value">整數值</param>
    /// <returns>FhirInteger 實例</returns>
    public static FhirInteger ToFhirInteger(this int value)
    {
        return new FhirInteger(value);
    }

    /// <summary>
    /// 將整數轉換為 FhirPositiveInt
    /// </summary>
    /// <param name="value">正整數值</param>
    /// <returns>FhirPositiveInt 實例</returns>
    public static FhirPositiveInt ToFhirPositiveInt(this int value)
    {
        return new FhirPositiveInt(value);
    }

    /// <summary>
    /// 將整數轉換為 FhirUnsignedInt
    /// </summary>
    /// <param name="value">無符號整數值</param>
    /// <returns>FhirUnsignedInt 實例</returns>
    public static FhirUnsignedInt ToFhirUnsignedInt(this int value)
    {
        return new FhirUnsignedInt(value);
    }

    /// <summary>
    /// 將小數轉換為 FhirDecimal
    /// </summary>
    /// <param name="value">小數值</param>
    /// <returns>FhirDecimal 實例</returns>
    public static FhirDecimal ToFhirDecimal(this decimal value)
    {
        return new FhirDecimal(value);
    }

    /// <summary>
    /// 將雙精度浮點數轉換為 FhirDecimal
    /// </summary>
    /// <param name="value">雙精度浮點數值</param>
    /// <returns>FhirDecimal 實例</returns>
    public static FhirDecimal ToFhirDecimal(this double value)
    {
        return new FhirDecimal((decimal)value);
    }

    /// <summary>
    /// 將單精度浮點數轉換為 FhirDecimal
    /// </summary>
    /// <param name="value">單精度浮點數值</param>
    /// <returns>FhirDecimal 實例</returns>
    public static FhirDecimal ToFhirDecimal(this float value)
    {
        return new FhirDecimal((decimal)value);
    }

    #endregion

    #region Boolean Extensions

    /// <summary>
    /// 將布林值轉換為 FhirBoolean
    /// </summary>
    /// <param name="value">布林值</param>
    /// <returns>FhirBoolean 實例</returns>
    public static FhirBoolean ToFhirBoolean(this bool value)
    {
        return new FhirBoolean(value);
    }

    #endregion

    #region DateTime Extensions

    /// <summary>
    /// 將 DateTime 轉換為 FhirDateTime
    /// </summary>
    /// <param name="value">日期時間值</param>
    /// <returns>FhirDateTime 實例</returns>
    public static FhirDateTime ToFhirDateTime(this DateTime value)
    {
        return new FhirDateTime(value);
    }

    /// <summary>
    /// 將 DateTime 轉換為 FhirDate
    /// </summary>
    /// <param name="value">日期時間值</param>
    /// <returns>FhirDate 實例</returns>
    public static FhirDate ToFhirDate(this DateTime value)
    {
        return new FhirDate(value);
    }

    /// <summary>
    /// 將 DateTime 轉換為 FhirInstant
    /// </summary>
    /// <param name="value">日期時間值</param>
    /// <returns>FhirInstant 實例</returns>
    public static FhirInstant ToFhirInstant(this DateTime value)
    {
        return new FhirInstant(value);
    }

    #endregion

    #region TimeSpan Extensions

    /// <summary>
    /// 將 TimeSpan 轉換為 FhirTime
    /// </summary>
    /// <param name="value">時間間隔值</param>
    /// <returns>FhirTime 實例</returns>
    public static FhirTime ToFhirTime(this TimeSpan value)
    {
        return new FhirTime(value);
    }

    #endregion

    #region Nullable Extensions

    /// <summary>
    /// 將可空整數轉換為 FhirInteger
    /// </summary>
    /// <param name="value">可空整數值</param>
    /// <returns>FhirInteger 實例，如果輸入為 null 則返回 null</returns>
    public static FhirInteger? ToFhirInteger(this int? value)
    {
        return value?.ToFhirInteger();
    }

    /// <summary>
    /// 將可空小數轉換為 FhirDecimal
    /// </summary>
    /// <param name="value">可空小數值</param>
    /// <returns>FhirDecimal 實例，如果輸入為 null 則返回 null</returns>
    public static FhirDecimal? ToFhirDecimal(this decimal? value)
    {
        return value?.ToFhirDecimal();
    }

    /// <summary>
    /// 將可空布林值轉換為 FhirBoolean
    /// </summary>
    /// <param name="value">可空布林值</param>
    /// <returns>FhirBoolean 實例，如果輸入為 null 則返回 null</returns>
    public static FhirBoolean? ToFhirBoolean(this bool? value)
    {
        return value?.ToFhirBoolean();
    }

    /// <summary>
    /// 將可空 DateTime 轉換為 FhirDateTime
    /// </summary>
    /// <param name="value">可空日期時間值</param>
    /// <returns>FhirDateTime 實例，如果輸入為 null 則返回 null</returns>
    public static FhirDateTime? ToFhirDateTime(this DateTime? value)
    {
        return value?.ToFhirDateTime();
    }

    #endregion
} 