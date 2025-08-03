using FhirCore.SDK;
using FhirCore.Versioning;
using ResourceTypeServices.R5;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;

namespace examples
{
    /// <summary>
    /// 多版本 FHIR SDK 使用範例
    /// 展示如何使用版本管理器來處理不同版本的 FHIR 資源
    /// </summary>
    public class MultiVersionExample
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== FHIR 多版本 SDK 使用範例 ===\n");

            // 1. 基本版本設定
            Console.WriteLine("1. 設定 FHIR 版本");
            FhirSDK.SetVersion("R5");
            Console.WriteLine($"當前版本: {FhirSDK.GetCurrentVersion()}");
            Console.WriteLine($"支援的版本: {string.Join(", ", FhirSDK.GetSupportedVersions())}\n");

            // 2. 建立 R5 Patient 資源
            Console.WriteLine("2. 建立 R5 Patient 資源");
            var patientR5 = CreateR5Patient();
            Console.WriteLine($"Patient ID: {patientR5.Id}");
            Console.WriteLine($"Resource Type: {patientR5.ResourceType}");
            Console.WriteLine($"FHIR Version: {patientR5.GetFhirVersion()}\n");

            // 3. 驗證資源
            Console.WriteLine("3. 驗證 Patient 資源");
            var validationResult = FhirSDK.ValidateResource(patientR5);
            Console.WriteLine($"驗證結果: {(validationResult == ValidationResult.Success ? "通過" : "失敗")}\n");

            // 4. 版本檢查
            Console.WriteLine("4. 版本支援檢查");
            Console.WriteLine($"是否支援 R4: {FhirSDK.IsVersionSupported("R4")}");
            Console.WriteLine($"是否支援 R5: {FhirSDK.IsVersionSupported("R5")}");
            Console.WriteLine($"是否支援 R6: {FhirSDK.IsVersionSupported("R6")}\n");

            // 5. 取得支援的資源類型
            Console.WriteLine("5. R5 支援的資源類型");
            var resourceTypes = FhirSDK.GetSupportedResourceTypes("R5");
            Console.WriteLine($"R5 支援 {resourceTypes.Count()} 種資源類型");
            Console.WriteLine($"前 10 種: {string.Join(", ", resourceTypes.Take(10))}\n");

            // 6. 多版本並存使用
            Console.WriteLine("6. 多版本並存使用");
            DemonstrateMultiVersionUsage();

            Console.WriteLine("=== 範例完成 ===");
        }

        /// <summary>
        /// 建立 R5 Patient 資源
        /// </summary>
        /// <returns>Patient 資源</returns>
        private static PatientR5 CreateR5Patient()
        {
            var patient = new PatientR5("patient-001")
            {
                Active = new FhirBoolean(true),
                Name = new List<HumanName>
                {
                    new HumanName
                    {
                        Family = "張",
                        Given = new List<string> { "三" }
                    }
                },
                Gender = new FhirCode("male"),
                BirthDate = new FhirDate(1990, 1, 1),
                Address = new List<Address>
                {
                    new Address
                    {
                        Type = new FhirCode("home"),
                        Text = "台北市信義區信義路五段7號",
                        City = "台北市",
                        State = "台北市",
                        PostalCode = "110"
                    }
                }
            };

            return patient;
        }

        /// <summary>
        /// 展示多版本並存使用
        /// </summary>
        private static void DemonstrateMultiVersionUsage()
        {
            Console.WriteLine("建立不同版本的資源...");

            // 建立 R5 版本的 Patient
            var patientR5 = new PatientR5("patient-r5-001")
            {
                Active = new FhirBoolean(true),
                Name = new List<HumanName>
                {
                    new HumanName { Family = "李", Given = new List<string> { "四" } }
                }
            };

            // 驗證不同版本
            var resultR5 = FhirSDK.ValidateResource(patientR5, "R5");
            Console.WriteLine($"R5 Patient 驗證: {(resultR5 == ValidationResult.Success ? "通過" : "失敗")}");

            // 檢查版本相容性
            Console.WriteLine($"R5 Patient 版本: {patientR5.GetFhirVersion()}");
            Console.WriteLine($"R5 Patient 資源類型: {patientR5.ResourceType}");

            Console.WriteLine("多版本並存使用完成\n");
        }
    }
} 