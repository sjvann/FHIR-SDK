using System.Text.Json;
using System.Text.Json.Nodes;
using Fhir.Support.Base;
using Fhir.Support;

namespace Fhir.Support.Examples;

/// <summary>
/// 新 Type Framework 使用範例
/// </summary>
public static class NewFrameworkExample
{
    /// <summary>
    /// 展示 PrimitiveType 的使用
    /// </summary>
    public static void PrimitiveTypeExample()
    {
        Console.WriteLine("=== PrimitiveType 範例 ===");
        
        // 展示 PrimitiveType 的基本概念
        Console.WriteLine("PrimitiveType<T> 提供以下功能：");
        Console.WriteLine("- 與 C# 原生型別的轉換");
        Console.WriteLine("- JSON 序列化/反序列化");
        Console.WriteLine("- 驗證機制");
        Console.WriteLine("- 元素和擴展支援");
        
        // 實際使用需要等生成的類別
        Console.WriteLine("注意：實際使用需要等 Fhir.Generator 生成對應的類別");
    }

    /// <summary>
    /// 展示 ComplexType 的使用
    /// </summary>
    public static void ComplexTypeExample()
    {
        Console.WriteLine("\n=== ComplexType 範例 ===");
        
        Console.WriteLine("ComplexType<T> 提供以下功能：");
        Console.WriteLine("- 複雜資料結構的處理");
        Console.WriteLine("- 自動 JSON 序列化/反序列化");
        Console.WriteLine("- 屬性變更通知");
        Console.WriteLine("- 驗證機制");
        
        Console.WriteLine("注意：實際使用需要等 Fhir.Generator 生成對應的類別");
    }

    /// <summary>
    /// 展示 ChoiceType 的使用
    /// </summary>
    public static void ChoiceTypeExample()
    {
        Console.WriteLine("\n=== ChoiceType 範例 ===");
        
        Console.WriteLine("ChoiceType 提供以下功能：");
        Console.WriteLine("- 處理 FHIR 的 [x] 欄位");
        Console.WriteLine("- 多種型別的選擇");
        Console.WriteLine("- 型別安全的存取");
        Console.WriteLine("- JSON 序列化支援");
        
        Console.WriteLine("注意：實際使用需要等 Fhir.Generator 生成對應的類別");
    }

    /// <summary>
    /// 展示版本管理
    /// </summary>
    public static void VersionManagementExample()
    {
        Console.WriteLine("\n=== 版本管理範例 ===");
        
        // 設定版本
        VersionManager.SetCurrentVersion("R5");
        Console.WriteLine($"Current Version: {VersionManager.CurrentVersion}");
        
        // 取得命名空間
        var namespaceName = VersionManager.GetCurrentNamespace();
        Console.WriteLine($"Current Namespace: {namespaceName}");
        
        // 檢查版本支援
        Console.WriteLine($"R4 支援: {VersionManager.IsVersionSupported("R4")}");
        Console.WriteLine($"R5 支援: {VersionManager.IsVersionSupported("R5")}");
        Console.WriteLine($"R6 支援: {VersionManager.IsVersionSupported("R6")}");
        
        // 取得版本目錄
        var versionDir = VersionManager.GetCurrentVersionDirectory();
        Console.WriteLine($"Version Directory: {versionDir}");
    }

    /// <summary>
    /// 展示 Type Framework 架構
    /// </summary>
    public static void TypeFrameworkExample()
    {
        Console.WriteLine("\n=== Type Framework 架構範例 ===");
        
        Console.WriteLine("Type Framework 包含以下核心組件：");
        Console.WriteLine("1. PrimitiveType<T> - 處理原始型別");
        Console.WriteLine("2. ComplexType<T> - 處理複雜型別");
        Console.WriteLine("3. ChoiceType - 處理選擇型別");
        Console.WriteLine("4. Element - 基礎元素類別");
        Console.WriteLine("5. DataType - 資料型別基底");
        Console.WriteLine("6. Resource - 資源基底");
        Console.WriteLine("7. DomainResource - 領域資源基底");
        
        Console.WriteLine("\n介面定義：");
        Console.WriteLine("- IDataType - 資料型別介面");
        Console.WriteLine("- IPrimitiveType - 原始型別介面");
        Console.WriteLine("- IComplexType - 複雜型別介面");
        Console.WriteLine("- IChoiceType - 選擇型別介面");
    }

    /// <summary>
    /// 展示 JSON 處理概念
    /// </summary>
    public static void JsonHandlingExample()
    {
        Console.WriteLine("\n=== JSON 處理概念範例 ===");
        
        Console.WriteLine("Type Framework 提供完整的 JSON 支援：");
        Console.WriteLine("- 自動 JSON 序列化/反序列化");
        Console.WriteLine("- 支援 FHIR 的 JSON 格式");
        Console.WriteLine("- 處理元素（Element）和擴展（Extension）");
        Console.WriteLine("- 型別安全的 JSON 操作");
        
        // 展示 JSON 節點處理
        var sampleJson = """
        {
            "resourceType": "Patient",
            "id": "example",
            "active": true,
            "name": [
                {
                    "use": "official",
                    "text": "John Doe"
                }
            ]
        }
        """;
        
        var jsonNode = JsonNode.Parse(sampleJson);
        Console.WriteLine($"\nJSON 節點類型: {jsonNode?.GetType().Name}");
        Console.WriteLine($"JSON 內容: {jsonNode?.ToJsonString()}");
    }

    /// <summary>
    /// 執行所有範例
    /// </summary>
    public static void RunAllExamples()
    {
        Console.WriteLine("🚀 開始執行新 Type Framework 範例\n");
        
        try
        {
            PrimitiveTypeExample();
            ComplexTypeExample();
            ChoiceTypeExample();
            VersionManagementExample();
            TypeFrameworkExample();
            JsonHandlingExample();
            
            Console.WriteLine("\n✅ 所有範例執行完成！");
            Console.WriteLine("\n📝 注意事項：");
            Console.WriteLine("- 這些範例展示了 Type Framework 的概念和架構");
            Console.WriteLine("- 實際使用需要等 Fhir.Generator 生成對應的類別");
            Console.WriteLine("- 生成的類別會繼承這些基礎類別並提供具體實作");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ 範例執行失敗: {ex.Message}");
        }
    }
} 