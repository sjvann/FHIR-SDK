using Fhir.Support.Examples;

namespace Fhir.Support;

/// <summary>
/// 主程式
/// </summary>
public class Program
{
    /// <summary>
    /// 主程式入口
    /// </summary>
    /// <param name="args">命令列參數</param>
    public static void Main(string[] args)
    {
        Console.WriteLine("FHIR SDK 簡化架構驗證");
        Console.WriteLine("========================");
        Console.WriteLine();

        // 執行範例
        Console.WriteLine("執行使用範例:");
        SimpleFrameworkExample.DemonstrateBasicUsage();
        SimpleFrameworkExample.DemonstrateValidation();
        SimpleFrameworkExample.DemonstrateTypeConversion();

        Console.WriteLine();
        Console.WriteLine("執行驗證測試:");
        SimpleFrameworkValidation.RunAllTests();

        Console.WriteLine();
        Console.WriteLine("按任意鍵結束...");
        Console.ReadKey();
    }
} 