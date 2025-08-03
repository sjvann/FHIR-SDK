using DataTypeServices.Attributes;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.Examples;
using DataTypeServices.Validation;
using System;
using System.Collections.Generic;

namespace CardinalityDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FHIR SDK Cardinality 約束示範");
            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine();

            DemonstrateCardinalityAttributes();
            Console.WriteLine();

            DemonstratePatientValidation();
            Console.WriteLine();

            DemonstrateObservationValidation();
            Console.WriteLine();

            DemonstrateCardinalityInfo();
            Console.WriteLine();

            Console.WriteLine("示範完成！按任意鍵退出...");
            Console.ReadKey();
        }

        static void DemonstrateCardinalityAttributes()
        {
            Console.WriteLine("--- Cardinality 屬性示範 ---");

            // 展示不同的 cardinality 屬性
            var attributes = new[]
            {
                new RequiredAttribute(),
                new OptionalAttribute(),
                new RequiredMultipleAttribute(),
                new OptionalMultipleAttribute(),
                new CardinalityAttribute(2, 5),
                new CardinalityAttribute(1, -1)
            };

            foreach (var attr in attributes)
            {
                Console.WriteLine($"{attr.GetType().Name}: {attr.GetCardinalityString()}");
                Console.WriteLine($"  - 是否必填: {attr.IsRequired}");
                Console.WriteLine($"  - 允許多值: {attr.AllowsMultiple}");
                Console.WriteLine($"  - 範圍: {attr.Min}..{(attr.Max == -1 ? "*" : attr.Max.ToString())}");
                Console.WriteLine();
            }
        }

        static void DemonstratePatientValidation()
        {
            Console.WriteLine("--- Patient Cardinality 驗證示範 ---");

            // 創建一個有效的 Patient
            var validPatient = new ExamplePatient
            {
                Id = new FhirId("patient-123"),
                Name = new List<HumanName>
                {
                    new HumanName() // 必填，至少一個
                },
                Active = new FhirBoolean(true),
                Gender = new FhirCode("male"),
                Address = new List<Address>
                {
                    new Address(),
                    new Address() // 最多 3 個
                }
            };

            Console.WriteLine("有效的 Patient:");
            var validResults = validPatient.ValidateCardinality();
            Console.WriteLine($"驗證結果: {(validResults.IsValid ? "✓ 通過" : "✗ 失敗")}");
            if (!validResults.IsValid)
            {
                foreach (var error in validResults.GetErrorMessages())
                {
                    Console.WriteLine($"  錯誤: {error}");
                }
            }

            Console.WriteLine();

            // 創建一個無效的 Patient（缺少必填欄位）
            var invalidPatient = new ExamplePatient
            {
                Id = new FhirId("patient-456"),
                // Name = null, // 缺少必填的 Name
                Active = new FhirBoolean(true),
                Address = new List<Address>
                {
                    new Address(),
                    new Address(),
                    new Address(),
                    new Address() // 超過最大值 3
                }
            };

            Console.WriteLine("無效的 Patient (缺少必填欄位且地址過多):");
            var invalidResults = invalidPatient.ValidateCardinality();
            Console.WriteLine($"驗證結果: {(invalidResults.IsValid ? "✓ 通過" : "✗ 失敗")}");
            if (!invalidResults.IsValid)
            {
                foreach (var error in invalidResults.GetErrorMessages())
                {
                    Console.WriteLine($"  錯誤: {error}");
                }
            }
        }

        static void DemonstrateObservationValidation()
        {
            Console.WriteLine("--- Observation Cardinality 驗證示範 ---");

            // 創建一個有效的 Observation
            var validObservation = new ExampleObservation
            {
                Id = new FhirId("obs-123"),
                Status = new FhirCode("final"), // 必填
                Code = new CodeableConcept(), // 必填
                Subject = new ReferenceType(),
                Component = new List<ObservationComponent>
                {
                    new ObservationComponent
                    {
                        Code = new CodeableConcept() // 必填
                    }
                }
            };

            Console.WriteLine("有效的 Observation:");
            var validResults = validObservation.ValidateCardinality();
            Console.WriteLine($"驗證結果: {(validResults.IsValid ? "✓ 通過" : "✗ 失敗")}");

            Console.WriteLine();

            // 創建一個無效的 Observation（缺少必填欄位）
            var invalidObservation = new ExampleObservation
            {
                Id = new FhirId("obs-456"),
                // Status = null, // 缺少必填的 Status
                // Code = null,   // 缺少必填的 Code
                Component = new List<ObservationComponent>()
            };

            // 添加太多組件（超過最大值 10）
            for (int i = 0; i < 12; i++)
            {
                invalidObservation.Component.Add(new ObservationComponent
                {
                    Code = new CodeableConcept()
                });
            }

            Console.WriteLine("無效的 Observation (缺少必填欄位且組件過多):");
            var invalidResults = invalidObservation.ValidateCardinality();
            Console.WriteLine($"驗證結果: {(invalidResults.IsValid ? "✓ 通過" : "✗ 失敗")}");
            if (!invalidResults.IsValid)
            {
                foreach (var error in invalidResults.GetErrorMessages())
                {
                    Console.WriteLine($"  錯誤: {error}");
                }
            }
        }

        static void DemonstrateCardinalityInfo()
        {
            Console.WriteLine("--- Cardinality 信息查詢示範 ---");

            // 取得 Patient 的 cardinality 信息
            var patientInfo = CardinalityValidator.GetCardinalityInfo(typeof(ExamplePatient));
            Console.WriteLine("ExamplePatient 的 Cardinality 約束:");
            foreach (var info in patientInfo.Values)
            {
                Console.WriteLine($"  {info.PropertyName}: {info.CardinalityString} ({info.PropertyType.Name})");
                Console.WriteLine($"    - 必填: {info.IsRequired}");
                Console.WriteLine($"    - 多值: {info.AllowsMultiple}");
            }

            Console.WriteLine();

            // 取得 Observation 的 cardinality 信息
            var observationInfo = CardinalityValidator.GetCardinalityInfo(typeof(ExampleObservation));
            Console.WriteLine("ExampleObservation 的 Cardinality 約束:");
            foreach (var info in observationInfo.Values)
            {
                Console.WriteLine($"  {info.PropertyName}: {info.CardinalityString} ({info.PropertyType.Name})");
                Console.WriteLine($"    - 必填: {info.IsRequired}");
                Console.WriteLine($"    - 多值: {info.AllowsMultiple}");
            }

            Console.WriteLine();

            // 檢查必填屬性
            var requiredProps = CardinalityValidator.GetRequiredProperties(typeof(ExampleObservation));
            Console.WriteLine("ExampleObservation 的必填屬性:");
            foreach (var prop in requiredProps)
            {
                Console.WriteLine($"  - {prop.Name}");
            }

            Console.WriteLine();

            // 檢查多值屬性
            var multipleProps = CardinalityValidator.GetMultipleValueProperties(typeof(ExamplePatient));
            Console.WriteLine("ExamplePatient 的多值屬性:");
            foreach (var prop in multipleProps)
            {
                Console.WriteLine($"  - {prop.Name}");
            }
        }
    }
}
