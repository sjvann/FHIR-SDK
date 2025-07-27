using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;

namespace Fhir.TypeFramework.Query;

/// <summary>
/// FHIR LINQ 擴展方法
/// 提供 LINQ 風格的查詢 API
/// </summary>
public static class FhirLinqExtensions
{
    /// <summary>
    /// 根據擴展篩選資源
    /// </summary>
    /// <typeparam name="T">資源型別</typeparam>
    /// <param name="resources">資源集合</param>
    /// <param name="url">擴展 URL</param>
    /// <returns>具有指定擴展的資源</returns>
    public static IEnumerable<T> WhereExtension<T>(this IEnumerable<T> resources, string url) 
        where T : IExtensibleTypeFramework
    {
        return resources.Where(r => r.HasExtension(url));
    }
    
    /// <summary>
    /// 根據 ID 篩選資源
    /// </summary>
    /// <typeparam name="T">資源型別</typeparam>
    /// <param name="resources">資源集合</param>
    /// <param name="id">資源 ID</param>
    /// <returns>具有指定 ID 的資源</returns>
    public static IEnumerable<T> WhereId<T>(this IEnumerable<T> resources, string id) 
        where T : IIdentifiableTypeFramework
    {
        return resources.Where(r => r.Id == id);
    }
    
    /// <summary>
    /// 根據擴展值篩選資源
    /// </summary>
    /// <typeparam name="T">資源型別</typeparam>
    /// <param name="resources">資源集合</param>
    /// <param name="url">擴展 URL</param>
    /// <param name="value">擴展值</param>
    /// <returns>具有指定擴展值的資源</returns>
    public static IEnumerable<T> WhereExtensionValue<T>(this IEnumerable<T> resources, string url, object value) 
        where T : IExtensibleTypeFramework
    {
        return resources.Where(r => 
        {
            var extension = r.GetExtension(url);
            return extension?.Value?.Equals(value) == true;
        });
    }
    
    /// <summary>
    /// 根據字串屬性篩選資源
    /// </summary>
    /// <typeparam name="T">資源型別</typeparam>
    /// <param name="resources">資源集合</param>
    /// <param name="propertySelector">屬性選擇器</param>
    /// <param name="value">比較值</param>
    /// <returns>符合條件的資源</returns>
    public static IEnumerable<T> WhereString<T>(this IEnumerable<T> resources, Func<T, FhirString?> propertySelector, string value) 
        where T : ITypeFramework
    {
        return resources.Where(r => 
        {
            var property = propertySelector(r);
            return property?.Value?.Equals(value, StringComparison.OrdinalIgnoreCase) == true;
        });
    }
    
    /// <summary>
    /// 根據整數屬性篩選資源
    /// </summary>
    /// <typeparam name="T">資源型別</typeparam>
    /// <param name="resources">資源集合</param>
    /// <param name="propertySelector">屬性選擇器</param>
    /// <param name="value">比較值</param>
    /// <returns>符合條件的資源</returns>
    public static IEnumerable<T> WhereInteger<T>(this IEnumerable<T> resources, Func<T, FhirInteger?> propertySelector, int value) 
        where T : ITypeFramework
    {
        return resources.Where(r => 
        {
            var property = propertySelector(r);
            return property?.Value == value;
        });
    }
    
    /// <summary>
    /// 根據布林屬性篩選資源
    /// </summary>
    /// <typeparam name="T">資源型別</typeparam>
    /// <param name="resources">資源集合</param>
    /// <param name="propertySelector">屬性選擇器</param>
    /// <param name="value">比較值</param>
    /// <returns>符合條件的資源</returns>
    public static IEnumerable<T> WhereBoolean<T>(this IEnumerable<T> resources, Func<T, FhirBoolean?> propertySelector, bool value) 
        where T : ITypeFramework
    {
        return resources.Where(r => 
        {
            var property = propertySelector(r);
            return property?.Value == value;
        });
    }
    
    /// <summary>
    /// 根據日期屬性篩選資源
    /// </summary>
    /// <typeparam name="T">資源型別</typeparam>
    /// <param name="resources">資源集合</param>
    /// <param name="propertySelector">屬性選擇器</param>
    /// <param name="startDate">開始日期</param>
    /// <param name="endDate">結束日期</param>
    /// <returns>符合條件的資源</returns>
    public static IEnumerable<T> WhereDateRange<T>(this IEnumerable<T> resources, Func<T, FhirDate?> propertySelector, DateTime startDate, DateTime endDate) 
        where T : ITypeFramework
    {
        return resources.Where(r => 
        {
            var property = propertySelector(r);
            return property?.Value >= startDate && property?.Value <= endDate;
        });
    }
    
    /// <summary>
    /// 根據日期時間屬性篩選資源
    /// </summary>
    /// <typeparam name="T">資源型別</typeparam>
    /// <param name="resources">資源集合</param>
    /// <param name="propertySelector">屬性選擇器</param>
    /// <param name="startDateTime">開始日期時間</param>
    /// <param name="endDateTime">結束日期時間</param>
    /// <returns>符合條件的資源</returns>
    public static IEnumerable<T> WhereDateTimeRange<T>(this IEnumerable<T> resources, Func<T, FhirDateTime?> propertySelector, DateTime startDateTime, DateTime endDateTime) 
        where T : ITypeFramework
    {
        return resources.Where(r => 
        {
            var property = propertySelector(r);
            return property?.Value >= startDateTime && property?.Value <= endDateTime;
        });
    }
    
    /// <summary>
    /// 根據 URI 屬性篩選資源
    /// </summary>
    /// <typeparam name="T">資源型別</typeparam>
    /// <param name="resources">資源集合</param>
    /// <param name="propertySelector">屬性選擇器</param>
    /// <param name="uri">URI 值</param>
    /// <returns>符合條件的資源</returns>
    public static IEnumerable<T> WhereUri<T>(this IEnumerable<T> resources, Func<T, FhirUri?> propertySelector, string uri) 
        where T : ITypeFramework
    {
        return resources.Where(r => 
        {
            var property = propertySelector(r);
            return property?.Value?.Equals(uri, StringComparison.OrdinalIgnoreCase) == true;
        });
    }
    
    /// <summary>
    /// 根據多個條件篩選資源
    /// </summary>
    /// <typeparam name="T">資源型別</typeparam>
    /// <param name="resources">資源集合</param>
    /// <param name="predicates">條件集合</param>
    /// <returns>符合所有條件的資源</returns>
    public static IEnumerable<T> WhereAll<T>(this IEnumerable<T> resources, params Func<T, bool>[] predicates) 
        where T : ITypeFramework
    {
        return resources.Where(r => predicates.All(predicate => predicate(r)));
    }
    
    /// <summary>
    /// 根據多個條件篩選資源（任一條件符合）
    /// </summary>
    /// <typeparam name="T">資源型別</typeparam>
    /// <param name="resources">資源集合</param>
    /// <param name="predicates">條件集合</param>
    /// <returns>符合任一條件的資源</returns>
    public static IEnumerable<T> WhereAny<T>(this IEnumerable<T> resources, params Func<T, bool>[] predicates) 
        where T : ITypeFramework
    {
        return resources.Where(r => predicates.Any(predicate => predicate(r)));
    }
    
    /// <summary>
    /// 根據擴展數量篩選資源
    /// </summary>
    /// <typeparam name="T">資源型別</typeparam>
    /// <param name="resources">資源集合</param>
    /// <param name="minCount">最小擴展數量</param>
    /// <param name="maxCount">最大擴展數量</param>
    /// <returns>符合條件的資源</returns>
    public static IEnumerable<T> WhereExtensionCount<T>(this IEnumerable<T> resources, int minCount = 0, int? maxCount = null) 
        where T : IExtensibleTypeFramework
    {
        return resources.Where(r => 
        {
            var count = r.Extension?.Count ?? 0;
            return count >= minCount && (maxCount == null || count <= maxCount);
        });
    }
    
    /// <summary>
    /// 根據資源型別篩選
    /// </summary>
    /// <typeparam name="T">資源型別</typeparam>
    /// <param name="resources">資源集合</param>
    /// <param name="resourceType">目標資源型別</param>
    /// <returns>符合型別的資源</returns>
    public static IEnumerable<T> WhereResourceType<T>(this IEnumerable<T> resources, string resourceType) 
        where T : ITypeFramework
    {
        return resources.Where(r => r.GetType().Name.Equals(resourceType, StringComparison.OrdinalIgnoreCase));
    }
    
    /// <summary>
    /// 根據屬性值範圍篩選資源
    /// </summary>
    /// <typeparam name="T">資源型別</typeparam>
    /// <param name="resources">資源集合</param>
    /// <param name="propertySelector">屬性選擇器</param>
    /// <param name="minValue">最小值</param>
    /// <param name="maxValue">最大值</param>
    /// <returns>符合條件的資源</returns>
    public static IEnumerable<T> WhereRange<T, TValue>(this IEnumerable<T> resources, Func<T, TValue?> propertySelector, TValue minValue, TValue maxValue) 
        where T : ITypeFramework
        where TValue : IComparable<TValue>
    {
        return resources.Where(r => 
        {
            var property = propertySelector(r);
            return property != null && property.CompareTo(minValue) >= 0 && property.CompareTo(maxValue) <= 0;
        });
    }
    
    /// <summary>
    /// 根據屬性值是否為空篩選資源
    /// </summary>
    /// <typeparam name="T">資源型別</typeparam>
    /// <param name="resources">資源集合</param>
    /// <param name="propertySelector">屬性選擇器</param>
    /// <param name="isEmpty">是否為空</param>
    /// <returns>符合條件的資源</returns>
    public static IEnumerable<T> WhereEmpty<T>(this IEnumerable<T> resources, Func<T, FhirString?> propertySelector, bool isEmpty = true) 
        where T : ITypeFramework
    {
        return resources.Where(r => 
        {
            var property = propertySelector(r);
            var isPropertyEmpty = string.IsNullOrEmpty(property?.Value);
            return isPropertyEmpty == isEmpty;
        });
    }
    
    /// <summary>
    /// 根據屬性值是否為 null 篩選資源
    /// </summary>
    /// <typeparam name="T">資源型別</typeparam>
    /// <param name="resources">資源集合</param>
    /// <param name="propertySelector">屬性選擇器</param>
    /// <param name="isNull">是否為 null</param>
    /// <returns>符合條件的資源</returns>
    public static IEnumerable<T> WhereNull<T, TValue>(this IEnumerable<T> resources, Func<T, TValue?> propertySelector, bool isNull = true) 
        where T : ITypeFramework
    {
        return resources.Where(r => 
        {
            var property = propertySelector(r);
            return (property == null) == isNull;
        });
    }
} 