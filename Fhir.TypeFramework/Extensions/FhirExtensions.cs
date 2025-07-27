using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;

namespace Fhir.TypeFramework.Extensions;

/// <summary>
/// FHIR 擴展方法
/// 提供流暢的 API 和便利的開發者體驗
/// </summary>
public static class FhirExtensions
{
    /// <summary>
    /// 為元素添加擴展並返回元素本身（支援流暢 API）
    /// </summary>
    /// <typeparam name="T">元素型別</typeparam>
    /// <param name="element">要添加擴展的元素</param>
    /// <param name="url">擴展的 URL</param>
    /// <param name="value">擴展的值</param>
    /// <returns>元素本身，支援流暢 API</returns>
    public static T WithExtension<T>(this T element, string url, object value) 
        where T : IExtensibleTypeFramework
    {
        element.AddExtension(url, value);
        return element;
    }
    
    /// <summary>
    /// 為元素設定 ID 並返回元素本身（支援流暢 API）
    /// </summary>
    /// <typeparam name="T">元素型別</typeparam>
    /// <param name="element">要設定 ID 的元素</param>
    /// <param name="id">ID 值</param>
    /// <returns>元素本身，支援流暢 API</returns>
    public static T WithId<T>(this T element, string id) 
        where T : IIdentifiableTypeFramework
    {
        element.Id = id;
        return element;
    }
    
    /// <summary>
    /// 檢查元素是否具有指定的擴展
    /// </summary>
    /// <typeparam name="T">元素型別</typeparam>
    /// <param name="element">要檢查的元素</param>
    /// <param name="url">擴展的 URL</param>
    /// <returns>如果存在指定的擴展則為 true，否則為 false</returns>
    public static bool HasExtension<T>(this T element, string url) 
        where T : IExtensibleTypeFramework
    {
        return element.GetExtension(url) != null;
    }
    
    /// <summary>
    /// 取得擴展的值（強型別版本）
    /// </summary>
    /// <typeparam name="T">元素型別</typeparam>
    /// <typeparam name="TValue">期望的值型別</typeparam>
    /// <param name="element">要取得擴展的元素</param>
    /// <param name="url">擴展的 URL</param>
    /// <returns>擴展的值，如果不存在或型別不匹配則為 null</returns>
    public static TValue? GetExtensionValue<T, TValue>(this T element, string url) 
        where T : IExtensibleTypeFramework
        where TValue : class
    {
        var extension = element.GetExtension(url);
        return extension?.Value as TValue;
    }
    
    /// <summary>
    /// 移除指定的擴展並返回元素本身（支援流暢 API）
    /// </summary>
    /// <typeparam name="T">元素型別</typeparam>
    /// <param name="element">要移除擴展的元素</param>
    /// <param name="url">要移除的擴展 URL</param>
    /// <returns>元素本身，支援流暢 API</returns>
    public static T WithoutExtension<T>(this T element, string url) 
        where T : IExtensibleTypeFramework
    {
        element.RemoveExtension(url);
        return element;
    }
    
    /// <summary>
    /// 為字串設定值並返回字串本身（支援流暢 API）
    /// </summary>
    /// <param name="fhirString">FHIR 字串</param>
    /// <param name="value">要設定的值</param>
    /// <returns>字串本身，支援流暢 API</returns>
    public static FhirString WithValue(this FhirString fhirString, string value)
    {
        fhirString.Value = value;
        return fhirString;
    }
    
    /// <summary>
    /// 為整數設定值並返回整數本身（支援流暢 API）
    /// </summary>
    /// <param name="fhirInteger">FHIR 整數</param>
    /// <param name="value">要設定的值</param>
    /// <returns>整數本身，支援流暢 API</returns>
    public static FhirInteger WithValue(this FhirInteger fhirInteger, int value)
    {
        fhirInteger.Value = value;
        return fhirInteger;
    }
    
    /// <summary>
    /// 為布林值設定值並返回布林值本身（支援流暢 API）
    /// </summary>
    /// <param name="fhirBoolean">FHIR 布林值</param>
    /// <param name="value">要設定的值</param>
    /// <returns>布林值本身，支援流暢 API</returns>
    public static FhirBoolean WithValue(this FhirBoolean fhirBoolean, bool value)
    {
        fhirBoolean.Value = value;
        return fhirBoolean;
    }
    
    /// <summary>
    /// 為日期時間設定值並返回日期時間本身（支援流暢 API）
    /// </summary>
    /// <param name="fhirDateTime">FHIR 日期時間</param>
    /// <param name="value">要設定的值</param>
    /// <returns>日期時間本身，支援流暢 API</returns>
    public static FhirDateTime WithValue(this FhirDateTime fhirDateTime, DateTime value)
    {
        fhirDateTime.Value = value;
        return fhirDateTime;
    }
    
    /// <summary>
    /// 為 URI 設定值並返回 URI 本身（支援流暢 API）
    /// </summary>
    /// <param name="fhirUri">FHIR URI</param>
    /// <param name="value">要設定的值</param>
    /// <returns>URI 本身，支援流暢 API</returns>
    public static FhirUri WithValue(this FhirUri fhirUri, string value)
    {
        fhirUri.Value = value;
        return fhirUri;
    }
    
    /// <summary>
    /// 檢查 FHIR 字串是否為空或 null
    /// </summary>
    /// <param name="fhirString">FHIR 字串</param>
    /// <returns>如果字串為空或 null 則為 true，否則為 false</returns>
    public static bool IsNullOrEmpty(this FhirString? fhirString)
    {
        return fhirString?.Value == null || string.IsNullOrEmpty(fhirString.Value);
    }
    
    /// <summary>
    /// 檢查 FHIR 字串是否為空或空白
    /// </summary>
    /// <param name="fhirString">FHIR 字串</param>
    /// <returns>如果字串為空或空白則為 true，否則為 false</returns>
    public static bool IsNullOrWhiteSpace(this FhirString? fhirString)
    {
        return fhirString?.Value == null || string.IsNullOrWhiteSpace(fhirString.Value);
    }
    
    /// <summary>
    /// 取得 FHIR 字串的值，如果為 null 則返回預設值
    /// </summary>
    /// <param name="fhirString">FHIR 字串</param>
    /// <param name="defaultValue">預設值</param>
    /// <returns>字串值或預設值</returns>
    public static string GetValueOrDefault(this FhirString? fhirString, string defaultValue = "")
    {
        return fhirString?.Value ?? defaultValue;
    }
    
    /// <summary>
    /// 取得 FHIR 整數的值，如果為 null 則返回預設值
    /// </summary>
    /// <param name="fhirInteger">FHIR 整數</param>
    /// <param name="defaultValue">預設值</param>
    /// <returns>整數值或預設值</returns>
    public static int GetValueOrDefault(this FhirInteger? fhirInteger, int defaultValue = 0)
    {
        return fhirInteger?.Value ?? defaultValue;
    }
    
    /// <summary>
    /// 取得 FHIR 布林值的值，如果為 null 則返回預設值
    /// </summary>
    /// <param name="fhirBoolean">FHIR 布林值</param>
    /// <param name="defaultValue">預設值</param>
    /// <returns>布林值或預設值</returns>
    public static bool GetValueOrDefault(this FhirBoolean? fhirBoolean, bool defaultValue = false)
    {
        return fhirBoolean?.Value ?? defaultValue;
    }
    
    /// <summary>
    /// 檢查 FHIR 整數是否為零
    /// </summary>
    /// <param name="fhirInteger">FHIR 整數</param>
    /// <returns>如果整數為 null 或零則為 true，否則為 false</returns>
    public static bool IsZero(this FhirInteger? fhirInteger)
    {
        return fhirInteger?.Value == null || fhirInteger.Value == 0;
    }
    
    /// <summary>
    /// 檢查 FHIR 整數是否為正數
    /// </summary>
    /// <param name="fhirInteger">FHIR 整數</param>
    /// <returns>如果整數為正數則為 true，否則為 false</returns>
    public static bool IsPositive(this FhirInteger? fhirInteger)
    {
        return fhirInteger?.Value > 0;
    }
    
    /// <summary>
    /// 檢查 FHIR 整數是否為負數
    /// </summary>
    /// <param name="fhirInteger">FHIR 整數</param>
    /// <returns>如果整數為負數則為 true，否則為 false</returns>
    public static bool IsNegative(this FhirInteger? fhirInteger)
    {
        return fhirInteger?.Value < 0;
    }
} 