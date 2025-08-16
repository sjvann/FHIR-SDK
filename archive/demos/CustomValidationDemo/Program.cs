using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.Examples;
using DataTypeServices.Validation;
using System;
using System.Collections.Generic;

namespace CustomValidationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FHIR SDK 自定義驗證示範");
            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine();

            DemonstratePatientValidation();
            Console.WriteLine();

            DemonstrateMedicationValidation();
            Console.WriteLine();

            DemonstrateValidationIntegration();
            Console.WriteLine();

            Console.WriteLine("示範完成！按任意鍵退出...");
            Console.ReadKey();
        }

        static void DemonstratePatientValidation()
        {
            Console.WriteLine("--- Patient 自定義驗證示範 ---");

            // 創建一個有效的 Patient
            var validPatient = new ValidatedPatient
            {
                Id = new FhirId("PAT-123456"),
                BirthDate = new FhirDate(new DateTime(1990, 5, 15)),
                Height = new FhirDecimal(175.5m),
                SocialSecurityNumber = new FhirString("123-45-6789"),
                Website = new FhirString("https://patient.example.com"),
                Telecom = new List<ContactPoint>
                {
                    new ContactPoint
                    {
                        System = new FhirCode("email"),
                        Value = new FhirString("patient@example.com")
                    },
                    new ContactPoint
                    {
                        System = new FhirCode("phone"),
                        Value = new FhirString("+1234567890")
                    }
                }
            };

            Console.WriteLine("有效的 Patient:");
            var validResults = validPatient.ValidateAll();
            Console.WriteLine($"驗證結果: {(validResults.IsValid ? "✓ 通過" : "✗ 失敗")}");
            if (!validResults.IsValid)
            {
                foreach (var error in validResults.GetErrorMessages())
                {
                    Console.WriteLine($"  錯誤: {error}");
                }
            }

            Console.WriteLine();

            // 創建一個無效的 Patient
            var invalidPatient = new ValidatedPatient
            {
                Id = new FhirId("INVALID-ID"), // 錯誤格式
                BirthDate = new FhirDate(new DateTime(2050, 1, 1)), // 未來日期
                Height = new FhirDecimal(500m), // 超出範圍
                SocialSecurityNumber = new FhirString("000-00-0000"), // 無效 SSN
                Website = new FhirString("not-a-url"), // 無效 URL
                Telecom = new List<ContactPoint>
                {
                    new ContactPoint
                    {
                        System = new FhirCode("email"),
                        Value = new FhirString("invalid-email") // 無效電子郵件
                    }
                }
            };

            Console.WriteLine("無效的 Patient:");
            var invalidResults = invalidPatient.ValidateAll();
            Console.WriteLine($"驗證結果: {(invalidResults.IsValid ? "✓ 通過" : "✗ 失敗")}");
            if (!invalidResults.IsValid)
            {
                Console.WriteLine($"發現 {invalidResults.ErrorCount} 個錯誤:");
                foreach (var error in invalidResults.GetErrorMessages())
                {
                    Console.WriteLine($"  • {error}");
                }
            }
        }

        static void DemonstrateMedicationValidation()
        {
            Console.WriteLine("--- Medication 自定義驗證示範 ---");

            // 創建一個有效的 Medication
            var validMedication = new ValidatedMedication
            {
                Code = new FhirString("MED-0001"),
                Name = new FhirString("Aspirin"),
                Strength = new FhirDecimal(100m),
                ExpiryDate = new FhirDate(DateTime.Today.AddYears(2))
            };

            Console.WriteLine("有效的 Medication:");
            var validResults = validMedication.ValidateAll();
            Console.WriteLine($"驗證結果: {(validResults.IsValid ? "✓ 通過" : "✗ 失敗")}");

            Console.WriteLine();

            // 創建一個無效的 Medication
            var invalidMedication = new ValidatedMedication
            {
                Code = new FhirString("MED-9999"), // 不在批准列表中
                Name = new FhirString("A"), // 太短
                Strength = new FhirDecimal(2000m), // 超出範圍
                ExpiryDate = new FhirDate(DateTime.Today.AddDays(-1)) // 過期
            };

            Console.WriteLine("無效的 Medication:");
            var invalidResults = invalidMedication.ValidateAll();
            Console.WriteLine($"驗證結果: {(invalidResults.IsValid ? "✓ 通過" : "✗ 失敗")}");
            if (!invalidResults.IsValid)
            {
                Console.WriteLine($"發現 {invalidResults.ErrorCount} 個錯誤:");
                foreach (var error in invalidResults.GetErrorMessages())
                {
                    Console.WriteLine($"  • {error}");
                }
            }

            Console.WriteLine();

            // 測試多重驗證
            var multiValidationMedication = new ValidatedMedication
            {
                Code = new FhirString("INVALID"), // 格式錯誤，會觸發第一個驗證失敗
                Name = new FhirString("Valid Medication Name"),
                Strength = new FhirDecimal(50m),
                ExpiryDate = new FhirDate(DateTime.Today.AddMonths(6))
            };

            Console.WriteLine("多重驗證測試 (Code 格式錯誤):");
            var multiResults = multiValidationMedication.ValidateAll();
            Console.WriteLine($"驗證結果: {(multiResults.IsValid ? "✓ 通過" : "✗ 失敗")}");
            if (!multiResults.IsValid)
            {
                foreach (var error in multiResults.GetErrorMessages())
                {
                    Console.WriteLine($"  • {error}");
                }
            }
        }

        static void DemonstrateValidationIntegration()
        {
            Console.WriteLine("--- 驗證整合示範 ---");

            // 創建一個同時有 cardinality 和自定義驗證錯誤的對象
            var patient = new ValidatedPatient
            {
                // 缺少必填欄位會觸發 cardinality 驗證錯誤
                Id = new FhirId("WRONG-FORMAT"), // 自定義驗證錯誤
                Height = new FhirDecimal(-10m), // 數值範圍錯誤
                Website = new FhirString("invalid-url") // URL 格式錯誤
            };

            Console.WriteLine("整合驗證測試:");
            
            // 分別測試不同類型的驗證
            var cardinalityResults = patient.ValidateCardinality();
            var customResults = patient.ValidateCustomAttributes();
            var allResults = patient.ValidateAll();

            Console.WriteLine($"Cardinality 驗證: {(cardinalityResults.IsValid ? "✓ 通過" : $"✗ {cardinalityResults.ErrorCount} 個錯誤")}");
            Console.WriteLine($"自定義驗證: {(customResults.IsValid ? "✓ 通過" : $"✗ {customResults.ErrorCount} 個錯誤")}");
            Console.WriteLine($"完整驗證: {(allResults.IsValid ? "✓ 通過" : $"✗ {allResults.ErrorCount} 個錯誤")}");

            Console.WriteLine("\n所有驗證錯誤:");
            foreach (var error in allResults.GetErrorMessages())
            {
                Console.WriteLine($"  • {error}");
            }

            Console.WriteLine();

            // 展示驗證結果的詳細信息
            Console.WriteLine("驗證結果詳細信息:");
            foreach (var result in allResults.Results)
            {
                Console.WriteLine($"  屬性: {result.PropertyPath ?? "Unknown"}");
                Console.WriteLine($"  狀態: {(result.IsValid ? "有效" : "無效")}");
                if (!result.IsValid)
                {
                    Console.WriteLine($"  錯誤: {result.ErrorMessage}");
                }
                Console.WriteLine();
            }

            // 展示如何處理驗證錯誤
            Console.WriteLine("錯誤處理示範:");
            if (!allResults.IsValid)
            {
                var errorsByProperty = new Dictionary<string, List<string>>();

                foreach (var result in allResults.Results.Where(r => !r.IsValid))
                {
                    var propertyName = result.PropertyPath ?? "Unknown";
                    if (!errorsByProperty.ContainsKey(propertyName))
                    {
                        errorsByProperty[propertyName] = new List<string>();
                    }
                    errorsByProperty[propertyName].Add(result.ErrorMessage ?? "Unknown error");
                }

                foreach (var kvp in errorsByProperty)
                {
                    Console.WriteLine($"  {kvp.Key}:");
                    foreach (var error in kvp.Value)
                    {
                        Console.WriteLine($"    - {error}");
                    }
                }
            }
        }
    }
}
