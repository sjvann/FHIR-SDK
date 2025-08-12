using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System;
using System.Linq;

namespace DataTypeServices.Examples
{
    /// <summary>
    /// 示範如何使用新的驗證功能
    /// </summary>
    public class ValidationExample
    {
        public static void RunExamples()
        {
            Console.WriteLine("=== FHIR SDK 驗證功能示範 ===\n");

            // 示範 FhirInteger 驗證
            DemonstrateIntegerValidation();
            
            // 示範 FhirDateTime 驗證
            DemonstrateDateTimeValidation();
            
            // 示範 FhirId 驗證
            DemonstrateIdValidation();
            
            // 示範 FhirString 驗證
            DemonstrateStringValidation();
        }

        private static void DemonstrateIntegerValidation()
        {
            Console.WriteLine("--- FhirInteger 驗證示範 ---");
            
            var validCases = new[] { "0", "123", "-456", "2147483647" };
            var invalidCases = new[] { "", "abc", "01", "3.14", "2147483648" };
            
            foreach (var value in validCases)
            {
                var fhirInt = new FhirInteger(value);
                var result = fhirInt.ValidateDetailed();
                Console.WriteLine($"✓ '{value}' -> {(result.IsValid ? "Valid" : result.ErrorMessage)}");
            }
            
            foreach (var value in invalidCases)
            {
                var fhirInt = new FhirInteger(value);
                var result = fhirInt.ValidateDetailed();
                Console.WriteLine($"✗ '{value}' -> {result.ErrorMessage}");
            }
            
            Console.WriteLine();
        }

        private static void DemonstrateDateTimeValidation()
        {
            Console.WriteLine("--- FhirDateTime 驗證示範 ---");
            
            var validCases = new[] { "2023", "2023-12", "2023-12-25", "2023-12-25T14:30:00Z" };
            var invalidCases = new[] { "", "23", "2023-13", "2023-12-32", "invalid-date" };
            
            foreach (var value in validCases)
            {
                var fhirDateTime = new FhirDateTime(value);
                var result = fhirDateTime.ValidateDetailed();
                Console.WriteLine($"✓ '{value}' -> {(result.IsValid ? "Valid" : result.ErrorMessage)}");
            }
            
            foreach (var value in invalidCases)
            {
                var fhirDateTime = new FhirDateTime(value);
                var result = fhirDateTime.ValidateDetailed();
                Console.WriteLine($"✗ '{value}' -> {result.ErrorMessage}");
            }
            
            Console.WriteLine();
        }

        private static void DemonstrateIdValidation()
        {
            Console.WriteLine("--- FhirId 驗證示範 ---");
            
            var validCases = new[] { "patient-123", "obs.vital-signs", "A1B2C3" };
            var invalidCases = new[] { "", "patient_123", "id with spaces", new string('a', 65) };
            
            foreach (var value in validCases)
            {
                var fhirId = new FhirId(value);
                var result = fhirId.ValidateDetailed();
                Console.WriteLine($"✓ '{value}' -> {(result.IsValid ? "Valid" : result.ErrorMessage)}");
            }
            
            foreach (var value in invalidCases)
            {
                var fhirId = new FhirId(value);
                var result = fhirId.ValidateDetailed();
                Console.WriteLine($"✗ '{value}' -> {result.ErrorMessage}");
            }
            
            Console.WriteLine();
        }

        private static void DemonstrateStringValidation()
        {
            Console.WriteLine("--- FhirString 驗證示範 ---");
            
            var validCases = new[] { "Hello World", "Patient Name", "多語言文字 🌍" };
            var invalidCases = new[] { "" }; // FhirString 幾乎接受所有非空字符串
            
            foreach (var value in validCases)
            {
                var fhirString = new FhirString(value);
                var result = fhirString.ValidateDetailed();
                Console.WriteLine($"✓ '{value}' -> {(result.IsValid ? "Valid" : result.ErrorMessage)}");
            }
            
            foreach (var value in invalidCases)
            {
                var fhirString = new FhirString(value);
                var result = fhirString.ValidateDetailed();
                Console.WriteLine($"✗ '{value}' -> {result.ErrorMessage}");
            }
            
            Console.WriteLine();
        }

        /// <summary>
        /// 示範如何使用 ValidationResults 來收集多個驗證結果
        /// </summary>
        public static void DemonstrateValidationResults()
        {
            Console.WriteLine("--- ValidationResults 集合示範 ---");
            
            var results = new ValidationResults();
            
            // 添加多個驗證結果
            results.Add(new FhirInteger("123").ValidateDetailed());
            results.Add(new FhirInteger("invalid").ValidateDetailed());
            results.Add(new FhirDateTime("2023-12-25").ValidateDetailed());
            results.Add(new FhirId("patient-123").ValidateDetailed());
            
            Console.WriteLine($"整體驗證結果: {results}");
            Console.WriteLine($"錯誤數量: {results.ErrorCount}");
            Console.WriteLine($"警告數量: {results.WarningCount}");
            
            if (!results.IsValid)
            {
                Console.WriteLine("錯誤詳情:");
                foreach (var error in results.GetErrorMessages())
                {
                    Console.WriteLine($"  - {error}");
                }
            }
            
            Console.WriteLine();
        }
    }
}
