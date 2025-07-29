using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.DataTypes.ComplexTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using Fhir.TypeFramework.Performance;
using System.ComponentModel.DataAnnotations;

namespace Fhir.TypeFramework.Examples;

/// <summary>
/// 效能優化範例
/// 展示如何使用新的效能優化功能
/// </summary>
public static class PerformanceOptimizationExample
{
    /// <summary>
    /// 基本效能優化範例
    /// </summary>
    public static void BasicOptimizationExample()
    {
        Console.WriteLine("=== 基本效能優化範例 ===");

        // 1. 使用效能監控
        using (PerformanceMonitor.Measure("建立 FHIR 物件"))
        {
            var patient = CreateSamplePatient();
            Console.WriteLine($"建立 Patient 物件完成");
        }

        // 2. 批次驗證
        var items = CreateSampleItems();
        using (PerformanceMonitor.Measure("批次驗證"))
        {
            var context = new ValidationContext(items.First());
            var results = ValidationOptimizer.BatchValidate(items, context);
            var resultList = results.ToList();
            Console.WriteLine($"批次驗證完成，發現 {resultList.Count} 個錯誤");
        }

        // 3. 快速驗證
        using (PerformanceMonitor.Measure("快速驗證"))
        {
            var validCount = 0;
            foreach (var item in items)
            {
                if (ValidationOptimizer.QuickValidate(item))
                {
                    validCount++;
                }
            }
            Console.WriteLine($"快速驗證完成，{validCount}/{items.Count()} 個物件有效");
        }

        // 4. 生成效能報告
        var report = PerformanceMonitor.GenerateReport();
        Console.WriteLine($"效能報告：總操作 {report.TotalOperations}，總耗時 {report.TotalElapsedTime}ms");
    }

    /// <summary>
    /// 快取機制範例
    /// </summary>
    public static void CachingExample()
    {
        Console.WriteLine("\n=== 快取機制範例 ===");

        // 1. 單例快取
        var singleton1 = TypeFrameworkCache.GetSingleton<FhirString>();
        var singleton2 = TypeFrameworkCache.GetSingleton<FhirString>();
        Console.WriteLine($"單例快取測試：{ReferenceEquals(singleton1, singleton2)}");

        // 2. Regex 快取
        var pattern = @"^[A-Za-z0-9\-\.]{1,64}$";
        var regex1 = TypeFrameworkCache.GetCachedRegex(pattern);
        var regex2 = TypeFrameworkCache.GetCachedRegex(pattern);
        Console.WriteLine($"Regex 快取測試：{ReferenceEquals(regex1, regex2)}");

        // 3. 效能指標記錄
        TypeFrameworkCache.RecordPerformance("快取測試", 50);
        var metric = TypeFrameworkCache.GetPerformanceMetric("快取測試");
        Console.WriteLine($"效能指標：{metric}ms");
    }

    /// <summary>
    /// 深層複製優化範例
    /// </summary>
    public static void DeepCopyOptimizationExample()
    {
        Console.WriteLine("\n=== 深層複製優化範例 ===");

        // 1. 建立複雜物件
        var original = CreateComplexObject();
        
        // 2. 測量深層複製效能
        using (PerformanceMonitor.Measure("深層複製"))
        {
            var copy = original.DeepCopy();
            Console.WriteLine($"深層複製完成，型別：{copy.GetType().Name}");
        }

        // 3. 批次深層複製
        var items = CreateSampleItems();
        using (PerformanceMonitor.Measure("批次深層複製"))
        {
            var copies = DeepCopyOptimizer.BatchDeepCopy(items).ToList();
            Console.WriteLine($"批次深層複製完成，複製了 {copies.Count} 個物件");
        }

        // 4. 檢查是否需要深層複製
        var needsCopy = DeepCopyOptimizer.ShouldDeepCopy(original);
        Console.WriteLine($"是否需要深層複製：{needsCopy}");
    }

    /// <summary>
    /// 驗證優化範例
    /// </summary>
    public static void ValidationOptimizationExample()
    {
        Console.WriteLine("\n=== 驗證優化範例 ===");

        // 1. 建立測試資料
        var items = CreateSampleItems();
        var context = new ValidationContext(items.First());

        // 2. 批次驗證並分類
        using (PerformanceMonitor.Measure("驗證並分類"))
        {
            var summary = ValidationOptimizer.ValidateAndCategorize(items, context);
            Console.WriteLine($"驗證分類結果：");
            Console.WriteLine($"  總物件：{summary.TotalItems}");
            Console.WriteLine($"  有效物件：{summary.ValidCount}");
            Console.WriteLine($"  無效物件：{summary.InvalidCount}");
            Console.WriteLine($"  成功率：{summary.SuccessRate:P2}");
        }

        // 3. 批次快速驗證
        using (PerformanceMonitor.Measure("批次快速驗證"))
        {
            var validItems = ValidationOptimizer.BatchQuickValidate(items).ToList();
            Console.WriteLine($"快速驗證完成，{validItems.Count}/{items.Count()} 個物件有效");
        }
    }

    /// <summary>
    /// 效能監控範例
    /// </summary>
    public static void PerformanceMonitoringExample()
    {
        Console.WriteLine("\n=== 效能監控範例 ===");

        // 1. 手動計時
        PerformanceMonitor.StartTimer("手動計時測試");
        Thread.Sleep(100); // 模擬工作
        PerformanceMonitor.StopTimer("手動計時測試");

        // 2. 使用 using 語句
        using (PerformanceMonitor.Measure("using 語句測試"))
        {
            Thread.Sleep(50); // 模擬工作
        }

        // 3. 取得效能指標
        var metric = PerformanceMonitor.GetMetric("using 語句測試");
        if (metric != null)
        {
            Console.WriteLine($"效能指標：");
            Console.WriteLine($"  操作：{metric.Operation}");
            Console.WriteLine($"  執行次數：{metric.Count}");
            Console.WriteLine($"  總耗時：{metric.TotalElapsedTime}ms");
            Console.WriteLine($"  平均耗時：{metric.AverageElapsedTime:F2}ms");
            Console.WriteLine($"  最小耗時：{metric.MinElapsedTime}ms");
            Console.WriteLine($"  最大耗時：{metric.MaxElapsedTime}ms");
        }

        // 4. 生成完整報告
        var report = PerformanceMonitor.GenerateReport();
        Console.WriteLine($"完整效能報告：");
        Console.WriteLine($"  生成時間：{report.GeneratedAt}");
        Console.WriteLine($"  總操作：{report.TotalOperations}");
        Console.WriteLine($"  總耗時：{report.TotalElapsedTime}ms");
        Console.WriteLine($"  平均操作時間：{report.AverageOperationTime:F2}ms");
        
        if (report.SlowestOperation != null)
        {
            Console.WriteLine($"  最慢操作：{report.SlowestOperation.Operation} ({report.SlowestOperation.AverageElapsedTime:F2}ms)");
        }
        
        if (report.MostFrequentOperation != null)
        {
            Console.WriteLine($"  最常執行：{report.MostFrequentOperation.Operation} ({report.MostFrequentOperation.Count} 次)");
        }
    }

    /// <summary>
    /// 效能優化設定範例
    /// </summary>
    public static void OptimizationSettingsExample()
    {
        Console.WriteLine("\n=== 效能優化設定範例 ===");

        // 1. 顯示當前設定
        Console.WriteLine("當前效能優化設定：");
        Console.WriteLine($"  快取啟用：{TypeFrameworkCache.EnableCaching}");
        Console.WriteLine($"  效能監控啟用：{TypeFrameworkCache.EnablePerformanceMonitoring}");
        Console.WriteLine($"  深層複製優化啟用：{DeepCopyOptimizer.EnableOptimization}");
        Console.WriteLine($"  驗證優化啟用：{ValidationOptimizer.EnableOptimization}");
        Console.WriteLine($"  效能監控啟用：{PerformanceMonitor.EnableMonitoring}");

        // 2. 動態調整設定
        TypeFrameworkCache.EnableCaching = false;
        Console.WriteLine("已停用快取功能");

        // 3. 清除快取和指標
        TypeFrameworkCache.ClearAll();
        DeepCopyOptimizer.ClearCache();
        PerformanceMonitor.ClearMetrics();
        Console.WriteLine("已清除所有快取和指標");
    }

    // ============================================================================
    // 輔助方法
    // ============================================================================

    private static ITypeFramework CreateSamplePatient()
    {
        // 建立一個簡單的 Patient 物件作為範例
        return new FhirString("sample-patient-id");
    }

    private static List<ITypeFramework> CreateSampleItems()
    {
        var items = new List<ITypeFramework>();
        
        // 建立各種 FHIR 物件
        items.Add(new FhirString("test-string"));
        items.Add(new FhirInteger(123));
        items.Add(new FhirBoolean(true));
        items.Add(new FhirUri("http://example.com"));
        items.Add(new FhirId("test-id"));
        
        return items;
    }

    private static ITypeFramework CreateComplexObject()
    {
        // 建立一個複雜的物件作為深層複製測試
        var extension = new Extension
        {
            Url = "http://example.com/extension",
            Value = new FhirString("test-value")
        };

        return extension;
    }
} 