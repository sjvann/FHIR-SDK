using System.Text;
using Xunit;

namespace Fhir.Support.Tests;

/// <summary>
/// 編碼測試
/// </summary>
public class EncodingTests
{
    /// <summary>
    /// 測試 UTF-8 編碼
    /// </summary>
    [Fact]
    public void TestUtf8Encoding()
    {
        // 設定控制台編碼
        Console.OutputEncoding = Encoding.UTF8;
        
        // 測試中文字符
        var chineseText = "測試文字";
        var bytes = Encoding.UTF8.GetBytes(chineseText);
        var decodedText = Encoding.UTF8.GetString(bytes);
        
        Assert.Equal(chineseText, decodedText);
        
        // 測試控制台輸出 - 使用英文避免編碼問題
        Console.WriteLine($"UTF-8 Test: {chineseText}");
        Console.WriteLine($"Byte Count: {bytes.Length}");
        Console.WriteLine($"Decoded Result: {decodedText}");
    }

    /// <summary>
    /// 測試檔案編碼
    /// </summary>
    [Fact]
    public void TestFileEncoding()
    {
        var testText = "FHIR SDK Test";
        var tempFile = Path.GetTempFileName();
        
        try
        {
            // 寫入 UTF-8 檔案
            File.WriteAllText(tempFile, testText, Encoding.UTF8);
            
            // 讀取檔案
            var readText = File.ReadAllText(tempFile, Encoding.UTF8);
            
            Assert.Equal(testText, readText);
            Console.WriteLine($"File Encoding Test: {readText}");
        }
        finally
        {
            // 清理臨時檔案
            if (File.Exists(tempFile))
                File.Delete(tempFile);
        }
    }

    /// <summary>
    /// 測試 JSON 編碼
    /// </summary>
    [Fact]
    public void TestJsonEncoding()
    {
        var testData = new
        {
            Name = "Test Patient",
            Description = "This is a test patient",
            Gender = "male"
        };

        var json = System.Text.Json.JsonSerializer.Serialize(testData, new System.Text.Json.JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase
        });

        Console.WriteLine($"JSON Encoding Test:");
        Console.WriteLine(json);

        // 反序列化測試
        var deserialized = System.Text.Json.JsonSerializer.Deserialize<dynamic>(json);
        Assert.NotNull(deserialized);
    }
} 