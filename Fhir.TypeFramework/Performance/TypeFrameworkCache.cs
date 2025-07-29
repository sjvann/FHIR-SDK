using System.Collections.Concurrent;
using System.Diagnostics;

namespace Fhir.TypeFramework.Performance;

/// <summary>
/// FHIR Type Framework 快取機制
/// 提供安全的物件快取和效能監控功能
/// </summary>
/// <remarks>
/// 這個快取機制設計為：
/// - 執行緒安全
/// - 可選啟用
/// - 不影響現有架構
/// - 提供效能監控
/// </remarks>
public static class TypeFrameworkCache
{
    private static readonly ConcurrentDictionary<Type, object> _singletonCache = new();
    private static readonly ConcurrentDictionary<string, object> _patternCache = new();
    private static readonly ConcurrentDictionary<string, long> _performanceMetrics = new();
    
    /// <summary>
    /// 是否啟用快取功能
    /// </summary>
    public static bool EnableCaching { get; set; } = true;
    
    /// <summary>
    /// 是否啟用效能監控
    /// </summary>
    public static bool EnablePerformanceMonitoring { get; set; } = true;

    /// <summary>
    /// 取得單例物件（適用於不變的物件）
    /// </summary>
    /// <typeparam name="T">物件型別</typeparam>
    /// <returns>單例物件</returns>
    public static T GetSingleton<T>() where T : class, new()
    {
        if (!EnableCaching)
            return new T();
            
        return (T)_singletonCache.GetOrAdd(typeof(T), _ => new T());
    }

    /// <summary>
    /// 取得快取的 Regex 物件
    /// </summary>
    /// <param name="pattern">正則表達式模式</param>
    /// <param name="options">Regex 選項</param>
    /// <returns>快取的 Regex 物件</returns>
    public static Regex GetCachedRegex(string pattern, RegexOptions options = RegexOptions.Compiled)
    {
        var key = $"{pattern}_{options}";
        return (Regex)_patternCache.GetOrAdd(key, _ => new Regex(pattern, options));
    }

    /// <summary>
    /// 記錄效能指標
    /// </summary>
    /// <param name="operation">操作名稱</param>
    /// <param name="elapsedMilliseconds">耗時（毫秒）</param>
    public static void RecordPerformance(string operation, long elapsedMilliseconds)
    {
        if (!EnablePerformanceMonitoring) return;
        
        _performanceMetrics.AddOrUpdate(operation, elapsedMilliseconds, 
            (key, oldValue) => oldValue + elapsedMilliseconds);
    }

    /// <summary>
    /// 取得效能指標
    /// </summary>
    /// <param name="operation">操作名稱</param>
    /// <returns>總耗時（毫秒）</returns>
    public static long GetPerformanceMetric(string operation)
    {
        return _performanceMetrics.TryGetValue(operation, out var value) ? value : 0;
    }

    /// <summary>
    /// 取得所有效能指標
    /// </summary>
    /// <returns>效能指標字典</returns>
    public static IReadOnlyDictionary<string, long> GetAllPerformanceMetrics()
    {
        return _performanceMetrics.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    }

    /// <summary>
    /// 清除快取
    /// </summary>
    public static void ClearCache()
    {
        _singletonCache.Clear();
        _patternCache.Clear();
    }

    /// <summary>
    /// 清除效能指標
    /// </summary>
    public static void ClearPerformanceMetrics()
    {
        _performanceMetrics.Clear();
    }

    /// <summary>
    /// 清除所有快取和指標
    /// </summary>
    public static void ClearAll()
    {
        ClearCache();
        ClearPerformanceMetrics();
    }
} 