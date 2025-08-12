using FhirCore.SDK;
using ResourceTypeServices.R5;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;

namespace examples
{
    /// <summary>
    /// Basic 資源使用範例
    /// 
    /// <para>
    /// 展示如何使用企業級 FHIR SDK 來創建、驗證和管理 Basic 資源。
    /// 包含各種使用場景和最佳實踐。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>
    /// 此範例展示：
    /// - 基本資源創建
    /// - 資源驗證
    /// - 錯誤處理
    /// - 版本管理
    /// - 最佳實踐
    /// </para>
    /// </remarks>
    public class BasicResourceExample
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== FHIR Basic 資源使用範例 ===\n");

            // 設定 FHIR 版本
            FhirSDK.SetVersion("R5");
            Console.WriteLine($"使用 FHIR 版本: {FhirSDK.GetCurrentVersion()}\n");

            // 1. 基本使用範例
            Console.WriteLine("1. 基本使用範例");
            DemonstrateBasicUsage();

            // 2. 驗證範例
            Console.WriteLine("\n2. 驗證範例");
            DemonstrateValidation();

            // 3. 錯誤處理範例
            Console.WriteLine("\n3. 錯誤處理範例");
            DemonstrateErrorHandling();

            // 4. 進階使用範例
            Console.WriteLine("\n4. 進階使用範例");
            DemonstrateAdvancedUsage();

            Console.WriteLine("\n=== 範例完成 ===");
        }

        /// <summary>
        /// 展示基本使用方式
        /// </summary>
        private static void DemonstrateBasicUsage()
        {
            Console.WriteLine("創建基本的 Basic 資源...");

            // 創建一個基本的 Basic 資源
            var basic = new BasicR5("basic-001")
            {
                Code = new CodeableConcept
                {
                    Coding = new List<Coding>
                    {
                        new Coding
                        {
                            System = "http://terminology.hl7.org/CodeSystem/basic-resource-type",
                            Code = "consent",
                            Display = "Consent"
                        }
                    }
                },
                Subject = new ReferenceType
                {
                    Reference = "Patient/patient-001",
                    Display = "張三"
                },
                Created = new FhirDateTime(DateTime.Now),
                Author = new ReferenceType
                {
                    Reference = "Practitioner/practitioner-001",
                    Display = "李醫師"
                }
            };

            Console.WriteLine($"資源 ID: {basic.Id}");
            Console.WriteLine($"資源類型: {basic.ResourceType}");
            Console.WriteLine($"FHIR 版本: {basic.GetFhirVersion()}");
            Console.WriteLine($"代碼: {basic.Code?.Coding?.FirstOrDefault()?.Display}");
            Console.WriteLine($"主體: {basic.Subject?.Display}");
            Console.WriteLine($"作者: {basic.Author?.Display}");
        }

        /// <summary>
        /// 展示驗證功能
        /// </summary>
        private static void DemonstrateValidation()
        {
            Console.WriteLine("執行資源驗證...");

            // 創建有效的 Basic 資源
            var validBasic = CreateValidBasicResource();
            var validationResult = FhirSDK.ValidateResource(validBasic);
            Console.WriteLine($"有效資源驗證結果: {(validationResult == ValidationResult.Success ? "通過" : "失敗")}");

            // 創建無效的 Basic 資源
            var invalidBasic = CreateInvalidBasicResource();
            var invalidResult = FhirSDK.ValidateResource(invalidBasic);
            Console.WriteLine($"無效資源驗證結果: {(invalidResult == ValidationResult.Success ? "通過" : "失敗")}");
        }

        /// <summary>
        /// 展示錯誤處理
        /// </summary>
        private static void DemonstrateErrorHandling()
        {
            Console.WriteLine("展示錯誤處理...");

            try
            {
                // 嘗試創建無效的資源
                var invalidBasic = new BasicR5("invalid-basic")
                {
                    // 故意不設定必填的 Code 屬性
                    Subject = new ReferenceType { Reference = "InvalidResource/invalid-001" },
                    Created = new FhirDateTime(DateTime.Now.AddDays(1)) // 未來日期
                };

                var result = invalidBasic.Validate();
                if (result != ValidationResult.Success)
                {
                    Console.WriteLine($"驗證失敗: {result}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"捕獲到異常: {ex.Message}");
            }
        }

        /// <summary>
        /// 展示進階使用方式
        /// </summary>
        private static void DemonstrateAdvancedUsage()
        {
            Console.WriteLine("展示進階使用方式...");

            // 使用建構函數創建資源
            var basicWithConstructor = new BasicR5(
                "basic-002",
                new CodeableConcept
                {
                    Coding = new List<Coding>
                    {
                        new Coding
                        {
                            System = "http://example.com/codes",
                            Code = "patient-note",
                            Display = "Patient Note"
                        }
                    }
                },
                new ReferenceType { Reference = "Patient/patient-002", Display = "李四" }
            );

            // 深層複製
            var clonedBasic = basicWithConstructor.Clone();
            Console.WriteLine($"原始資源: {basicWithConstructor}");
            Console.WriteLine($"複製資源: {clonedBasic}");

            // 字串表示
            Console.WriteLine($"資源字串表示: {basicWithConstructor}");
        }

        /// <summary>
        /// 創建有效的 Basic 資源
        /// </summary>
        /// <returns>有效的 Basic 資源</returns>
        private static BasicR5 CreateValidBasicResource()
        {
            return new BasicR5("valid-basic-001")
            {
                Code = new CodeableConcept
                {
                    Coding = new List<Coding>
                    {
                        new Coding
                        {
                            System = "http://terminology.hl7.org/CodeSystem/basic-resource-type",
                            Code = "patient-info",
                            Display = "Patient Information"
                        }
                    }
                },
                Subject = new ReferenceType
                {
                    Reference = "Patient/patient-001",
                    Display = "王五"
                },
                Created = new FhirDateTime(DateTime.Now),
                Author = new ReferenceType
                {
                    Reference = "Practitioner/practitioner-001",
                    Display = "陳醫師"
                }
            };
        }

        /// <summary>
        /// 創建無效的 Basic 資源
        /// </summary>
        /// <returns>無效的 Basic 資源</returns>
        private static BasicR5 CreateInvalidBasicResource()
        {
            return new BasicR5("invalid-basic-001")
            {
                // 故意不設定必填的 Code 屬性
                Subject = new ReferenceType
                {
                    Reference = "InvalidResource/invalid-001", // 無效的資源類型
                    Display = "無效主體"
                },
                Created = new FhirDateTime(DateTime.Now.AddDays(1)), // 未來日期
                Author = new ReferenceType
                {
                    Reference = "InvalidResource/invalid-002", // 無效的資源類型
                    Display = "無效作者"
                }
            };
        }
    }
} 