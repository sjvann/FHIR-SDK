using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System;

namespace ValidationTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("FHIR SDK 驗證功能測試");
                Console.WriteLine("=".PadRight(50, '='));
                Console.WriteLine();

                // 簡單測試
                TestBasicValidation();

                Console.WriteLine("測試完成！按任意鍵退出...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"發生錯誤: {ex.Message}");
                Console.WriteLine($"詳細信息: {ex}");
                Console.ReadKey();
            }
        }

        static void TestBasicValidation()
        {
            Console.WriteLine("--- 基本驗證測試 ---");

            try
            {
                // 測試 FhirInteger
                var validInt = new FhirInteger("123");
                var invalidInt = new FhirInteger("abc");

                Console.WriteLine($"Valid integer '123': {validInt.IsValidValue()}");
                Console.WriteLine($"Invalid integer 'abc': {invalidInt.IsValidValue()}");

                // 測試詳細驗證
                var result = invalidInt.ValidateDetailed();
                Console.WriteLine($"詳細錯誤: {result?.ErrorMessage ?? "No error message"}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"測試中發生錯誤: {ex.Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
            }

            Console.WriteLine();
        }
    }
}
