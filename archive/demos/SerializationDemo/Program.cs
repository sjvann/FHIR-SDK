using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using FhirCore.ExtensionMethods;
using TerminologyService.ValueSet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FHIR SDK 序列化示範");
            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine();

            DemonstratePrimitiveTypeSerialization();
            Console.WriteLine();

            DemonstrateComplexTypeSerialization();
            Console.WriteLine();

            DemonstrateJsonFormatting();
            Console.WriteLine();

            Console.WriteLine("示範完成！按任意鍵退出...");
            Console.ReadKey();
        }

        static void DemonstratePrimitiveTypeSerialization()
        {
            Console.WriteLine("--- 基本類型序列化示範 ---");

            // 創建各種基本類型
            var fhirString = new FhirString("Hello FHIR World!");
            var fhirInteger = new FhirInteger(42);
            var fhirBoolean = new FhirBoolean(true);
            var fhirDate = new FhirDate(DateTime.Today);
            var fhirUri = new FhirUri("https://example.com/fhir");

            // 使用現有的序列化方法
            Console.WriteLine("FhirString 序列化:");
            Console.WriteLine($"  ToJsonString(): {fhirString.ToJsonString()}");

            Console.WriteLine("\nFhirInteger 序列化:");
            Console.WriteLine($"  ToJsonString(): {fhirInteger.ToJsonString()}");

            Console.WriteLine("\nFhirBoolean 序列化:");
            Console.WriteLine($"  ToJsonString(): {fhirBoolean.ToJsonString()}");

            Console.WriteLine("\nFhirDate 序列化:");
            Console.WriteLine($"  ToJsonString(): {fhirDate.ToJsonString()}");

            Console.WriteLine("\nFhirUri 序列化:");
            Console.WriteLine($"  ToJsonString(): {fhirUri.ToJsonString()}");

            // 示範值的取得
            Console.WriteLine("\n值的取得:");
            Console.WriteLine($"FhirString 值: {fhirString.Value}");
            Console.WriteLine($"FhirInteger 值: {fhirInteger.Value}");
            Console.WriteLine($"FhirBoolean 值: {fhirBoolean.Value}");
            Console.WriteLine($"FhirDate 值: {fhirDate.Value:yyyy-MM-dd}");
            Console.WriteLine($"FhirUri 值: {fhirUri.Value}");
        }

        static void DemonstrateComplexTypeSerialization()
        {
            Console.WriteLine("--- 複雜類型序列化示範 ---");

            // 創建 HumanName
            var humanName = new HumanName();
            humanName.Use = new FhirCode("official");
            humanName.Family = new FhirString("Doe");
            humanName.Given = new List<FhirString>
            {
                new FhirString("John"),
                new FhirString("William")
            };
            humanName.Prefix = new List<FhirString> { new FhirString("Mr.") };

            Console.WriteLine("HumanName 序列化:");
            Console.WriteLine(humanName.ToJsonString());

            // 創建 Address
            var address = new Address();
            // 暫時跳過 Use 和 Type，因為它們需要特殊的構造方式
            address.Line = new List<FhirString>
            {
                new FhirString("123 Main Street"),
                new FhirString("Apt 4B")
            };
            address.City = new FhirString("Anytown");
            address.State = new FhirString("NY");
            address.PostalCode = new FhirString("12345");
            address.Country = new FhirString("USA");

            Console.WriteLine("\nAddress 序列化:");
            Console.WriteLine(address.ToJsonString());

            // 創建 Quantity
            var quantity = new Quantity();
            quantity.Value = new FhirDecimal(70.5m);
            quantity.Unit = new FhirString("kg");
            quantity.System = new FhirUri("http://unitsofmeasure.org");
            quantity.Code = new FhirCode("kg");

            Console.WriteLine("\nQuantity 序列化:");
            Console.WriteLine(quantity.ToJsonString());

            // 示範 JSON 對象取得
            Console.WriteLine("\nJSON 對象示範:");
            var humanNameJson = humanName.GetJsonObject();
            if (humanNameJson != null)
            {
                Console.WriteLine("HumanName JSON 對象:");
                Console.WriteLine(humanNameJson.SerializeCustom());
            }
        }

        static void DemonstrateJsonFormatting()
        {
            Console.WriteLine("--- JSON 格式化示範 ---");

            var contactPoint = new ContactPoint();
            contactPoint.System = new FhirCode("email");
            contactPoint.Value = new FhirString("john.doe@example.com");
            contactPoint.Use = new FhirCode("work");

            // 使用現有的序列化方法
            Console.WriteLine("ContactPoint 序列化:");
            Console.WriteLine(contactPoint.ToJsonString());

            // 取得 JSON 對象並格式化
            var jsonObject = contactPoint.GetJsonObject();
            if (jsonObject != null)
            {
                Console.WriteLine("\n緊湊格式:");
                Console.WriteLine(jsonObject.SerializeDefault());

                Console.WriteLine("\n格式化:");
                Console.WriteLine(jsonObject.SerializeCustom());
            }

            // 示範不同的序列化選項
            Console.WriteLine("\n使用 System.Text.Json 格式化:");
            if (jsonObject != null)
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                };
                Console.WriteLine(JsonSerializer.Serialize(jsonObject, options));
            }
        }
    }
}
