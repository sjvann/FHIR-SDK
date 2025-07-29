using Fhir.TypeFramework.Abstractions;
using System.Collections.Concurrent;

namespace Fhir.TypeFramework.Performance;

/// <summary>
/// 深層複製優化器
/// 提供安全的深層複製優化功能
/// </summary>
/// <remarks>
/// 這個優化器設計為：
/// - 不破壞現有架構
/// - 提供可選的優化功能
/// - 保持向後相容性
/// - 提供效能監控
/// </remarks>
public static class DeepCopyOptimizer
{
    private static readonly ConcurrentDictionary<Type, bool> _needsDeepCopyCache = new();
    
    /// <summary>
    /// 是否啟用深層複製優化
    /// </summary>
    public static bool EnableOptimization { get; set; } = true;

    /// <summary>
    /// 優化的列表深層複製
    /// </summary>
    /// <typeparam name="T">列表元素型別</typeparam>
    /// <param name="source">來源列表</param>
    /// <returns>深層複製的列表</returns>
    public static IList<T>? OptimizedDeepCopyList<T>(IList<T>? source) where T : Base
    {
        if (!EnableOptimization)
        {
            // 使用原有的邏輯
            if (source == null) return null;
            return source.Select(item => item.DeepCopy() as T).ToList();
        }

        if (source == null || source.Count == 0) return source;
        
        // 預分配容量，減少記憶體重新分配
        var result = new List<T>(source.Count);
        foreach (var item in source)
        {
            if (item != null)
            {
                var copiedItem = item.DeepCopy() as T;
                if (copiedItem != null)
                {
                    result.Add(copiedItem);
                }
            }
        }
        return result;
    }

    /// <summary>
    /// 檢查是否需要深層複製
    /// </summary>
    /// <typeparam name="T">物件型別</typeparam>
    /// <param name="obj">要檢查的物件</param>
    /// <returns>如果需要深層複製則為 true，否則為 false</returns>
    public static bool NeedsDeepCopy<T>(T? obj) where T : class
    {
        if (obj == null) return false;
        
        var type = obj.GetType();
        return _needsDeepCopyCache.GetOrAdd(type, t => t.IsClass && !t.IsValueType);
    }

    /// <summary>
    /// 安全的深層複製檢查
    /// </summary>
    /// <typeparam name="T">物件型別</typeparam>
    /// <param name="obj">要檢查的物件</param>
    /// <returns>如果物件需要深層複製則為 true，否則為 false</returns>
    public static bool ShouldDeepCopy<T>(T? obj) where T : class
    {
        if (!EnableOptimization) return true;
        
        return NeedsDeepCopy(obj) && obj is Base;
    }

    /// <summary>
    /// 批次深層複製
    /// </summary>
    /// <typeparam name="T">物件型別</typeparam>
    /// <param name="items">要複製的物件集合</param>
    /// <returns>深層複製的物件集合</returns>
    public static IEnumerable<T> BatchDeepCopy<T>(IEnumerable<T> items) where T : Base
    {
        if (!EnableOptimization)
        {
            return items.Select(item => item.DeepCopy() as T).Where(item => item != null)!;
        }

        var result = new List<T>();
        foreach (var item in items)
        {
            if (item != null)
            {
                var copiedItem = item.DeepCopy() as T;
                if (copiedItem != null)
                {
                    result.Add(copiedItem);
                }
            }
        }
        return result;
    }

    /// <summary>
    /// 清除快取
    /// </summary>
    public static void ClearCache()
    {
        _needsDeepCopyCache.Clear();
    }
} 