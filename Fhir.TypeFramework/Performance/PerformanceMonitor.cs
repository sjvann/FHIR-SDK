using System.Diagnostics;
using System.Collections.Concurrent;

namespace Fhir.TypeFramework.Performance;

/// <summary>
/// 效能監控器
/// 提供詳細的效能監控和報告功能
/// </summary>
/// <remarks>
/// 這個監控器設計為：
/// - 非侵入式監控
/// - 詳細的效能指標
/// - 可選啟用
/// - 提供報告功能
/// </remarks>
public static class PerformanceMonitor
{
    private static readonly ConcurrentDictionary<string, PerformanceMetric> _metrics = new();
    private static readonly ConcurrentDictionary<string, Stopwatch> _activeTimers = new();
    
    /// <summary>
    /// 是否啟用效能監控
    /// </summary>
    public static bool EnableMonitoring { get; set; } = true;

    /// <summary>
    /// 開始測量操作
    /// </summary>
    /// <param name="operation">操作名稱</param>
    /// <returns>測量範圍物件</returns>
    public static IDisposable Measure(string operation)
    {
        return new TimingScope(operation);
    }

    /// <summary>
    /// 記錄操作時間
    /// </summary>
    /// <param name="operation">操作名稱</param>
    /// <param name="elapsedMilliseconds">耗時（毫秒）</param>
    public static void RecordOperation(string operation, long elapsedMilliseconds)
    {
        if (!EnableMonitoring) return;
        
        var metric = _metrics.GetOrAdd(operation, _ => new PerformanceMetric(operation));
        metric.Record(elapsedMilliseconds);
    }

    /// <summary>
    /// 取得效能指標
    /// </summary>
    /// <param name="operation">操作名稱</param>
    /// <returns>效能指標</returns>
    public static PerformanceMetric? GetMetric(string operation)
    {
        return _metrics.TryGetValue(operation, out var metric) ? metric : null;
    }

    /// <summary>
    /// 取得所有效能指標
    /// </summary>
    /// <returns>所有效能指標</returns>
    public static IReadOnlyDictionary<string, PerformanceMetric> GetAllMetrics()
    {
        return _metrics.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    }

    /// <summary>
    /// 生成效能報告
    /// </summary>
    /// <returns>效能報告</returns>
    public static PerformanceReport GenerateReport()
    {
        var report = new PerformanceReport
        {
            GeneratedAt = DateTime.UtcNow,
            Metrics = _metrics.Values.ToList(),
            TotalOperations = _metrics.Values.Sum(m => m.Count),
            TotalElapsedTime = _metrics.Values.Sum(m => m.TotalElapsedTime)
        };

        return report;
    }

    /// <summary>
    /// 清除所有指標
    /// </summary>
    public static void ClearMetrics()
    {
        _metrics.Clear();
        _activeTimers.Clear();
    }

    /// <summary>
    /// 開始計時
    /// </summary>
    /// <param name="operation">操作名稱</param>
    public static void StartTimer(string operation)
    {
        if (!EnableMonitoring) return;
        
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        _activeTimers[operation] = stopwatch;
    }

    /// <summary>
    /// 停止計時
    /// </summary>
    /// <param name="operation">操作名稱</param>
    public static void StopTimer(string operation)
    {
        if (!EnableMonitoring) return;
        
        if (_activeTimers.TryRemove(operation, out var stopwatch))
        {
            stopwatch.Stop();
            RecordOperation(operation, stopwatch.ElapsedMilliseconds);
        }
    }

    /// <summary>
    /// 測量範圍
    /// </summary>
    private class TimingScope : IDisposable
    {
        private readonly string _operation;
        private readonly Stopwatch _stopwatch;

        public TimingScope(string operation)
        {
            _operation = operation;
            _stopwatch = Stopwatch.StartNew();
        }

        public void Dispose()
        {
            _stopwatch.Stop();
            RecordOperation(_operation, _stopwatch.ElapsedMilliseconds);
        }
    }
}

/// <summary>
/// 效能指標
/// </summary>
public class PerformanceMetric
{
    /// <summary>
    /// 操作名稱
    /// </summary>
    public string Operation { get; }

    /// <summary>
    /// 執行次數
    /// </summary>
    public long Count { get; private set; }

    /// <summary>
    /// 總耗時（毫秒）
    /// </summary>
    public long TotalElapsedTime { get; private set; }

    /// <summary>
    /// 平均耗時（毫秒）
    /// </summary>
    public double AverageElapsedTime => Count > 0 ? (double)TotalElapsedTime / Count : 0;

    /// <summary>
    /// 最小耗時（毫秒）
    /// </summary>
    public long MinElapsedTime { get; private set; } = long.MaxValue;

    /// <summary>
    /// 最大耗時（毫秒）
    /// </summary>
    public long MaxElapsedTime { get; private set; }

    /// <summary>
    /// 最後執行時間
    /// </summary>
    public DateTime LastExecuted { get; private set; }

    public PerformanceMetric(string operation)
    {
        Operation = operation;
    }

    /// <summary>
    /// 記錄操作
    /// </summary>
    /// <param name="elapsedMilliseconds">耗時（毫秒）</param>
    public void Record(long elapsedMilliseconds)
    {
        Count++;
        TotalElapsedTime += elapsedMilliseconds;
        MinElapsedTime = Math.Min(MinElapsedTime, elapsedMilliseconds);
        MaxElapsedTime = Math.Max(MaxElapsedTime, elapsedMilliseconds);
        LastExecuted = DateTime.UtcNow;
    }

    /// <summary>
    /// 重置指標
    /// </summary>
    public void Reset()
    {
        Count = 0;
        TotalElapsedTime = 0;
        MinElapsedTime = long.MaxValue;
        MaxElapsedTime = 0;
        LastExecuted = DateTime.MinValue;
    }
}

/// <summary>
/// 效能報告
/// </summary>
public class PerformanceReport
{
    /// <summary>
    /// 報告生成時間
    /// </summary>
    public DateTime GeneratedAt { get; set; }

    /// <summary>
    /// 所有效能指標
    /// </summary>
    public IList<PerformanceMetric> Metrics { get; set; } = new List<PerformanceMetric>();

    /// <summary>
    /// 總操作次數
    /// </summary>
    public long TotalOperations { get; set; }

    /// <summary>
    /// 總耗時（毫秒）
    /// </summary>
    public long TotalElapsedTime { get; set; }

    /// <summary>
    /// 平均操作時間（毫秒）
    /// </summary>
    public double AverageOperationTime => TotalOperations > 0 ? (double)TotalElapsedTime / TotalOperations : 0;

    /// <summary>
    /// 最慢的操作
    /// </summary>
    public PerformanceMetric? SlowestOperation => Metrics.OrderByDescending(m => m.AverageElapsedTime).FirstOrDefault();

    /// <summary>
    /// 最常執行的操作
    /// </summary>
    public PerformanceMetric? MostFrequentOperation => Metrics.OrderByDescending(m => m.Count).FirstOrDefault();
} 