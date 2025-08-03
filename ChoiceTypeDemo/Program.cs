using DataTypeServices.DataTypes.ChoiceTypes;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using System;

namespace ChoiceTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FHIR SDK 現代化 ChoiceType 示範");
            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine();

            DemonstrateAsNeededChoice();
            Console.WriteLine();
            
            DemonstrateDeceasedChoice();
            Console.WriteLine();
            
            DemonstrateServicedChoice();
            Console.WriteLine();
            
            DemonstratePatternMatching();
            Console.WriteLine();

            Console.WriteLine("示範完成！按任意鍵退出...");
            Console.ReadKey();
        }

        static void DemonstrateAsNeededChoice()
        {
            Console.WriteLine("--- AsNeeded ChoiceType 示範 ---");

            // 創建 boolean 類型的 AsNeeded
            var asNeededTrue = AsNeededChoice.FromBoolean(true);
            Console.WriteLine($"AsNeeded (boolean): {asNeededTrue.AsBooleanValue}");
            Console.WriteLine($"是否為 boolean 類型: {asNeededTrue.IsT1}");

            // 創建 CodeableConcept 類型的 AsNeeded
            var concept = new CodeableConcept();
            var asNeededConcept = AsNeededChoice.FromCodeableConcept(concept);
            Console.WriteLine($"AsNeeded (concept): {asNeededConcept.AsCodeableConcept != null}");
            Console.WriteLine($"是否為 CodeableConcept 類型: {asNeededConcept.IsT2}");

            // 類型安全的值提取
            if (asNeededTrue.TryGetValue<FhirBoolean>(out var boolValue))
            {
                Console.WriteLine($"安全提取的 boolean 值: {boolValue.Value}");
            }
        }

        static void DemonstrateDeceasedChoice()
        {
            Console.WriteLine("--- Deceased ChoiceType 示範 ---");

            // 創建 boolean 類型的 Deceased
            var deceasedFalse = DeceasedChoice.FromBoolean(false);
            Console.WriteLine($"Deceased (boolean): {deceasedFalse.IsDeceased}");

            // 創建 DateTime 類型的 Deceased
            var deathDate = new DateTime(2023, 12, 25);
            var deceasedDate = DeceasedChoice.FromDateTime(deathDate);
            Console.WriteLine($"Deceased (date): {deceasedDate.DeceasedDateTime:yyyy-MM-dd}");

            // 從字符串創建 DateTime
            var deceasedString = DeceasedChoice.FromDateTimeString("2023-01-01");
            Console.WriteLine($"Deceased (from string): {deceasedString.DeceasedDateTime?.ToString("yyyy-MM-dd")}");
        }

        static void DemonstrateServicedChoice()
        {
            Console.WriteLine("--- Serviced ChoiceType 示範 ---");

            // 創建單一日期的 Serviced
            var serviceDate = ServicedChoice.FromDate(DateTime.Today);
            Console.WriteLine($"Service date: {serviceDate.ServiceDate:yyyy-MM-dd}");

            // 創建日期範圍的 Serviced
            var servicePeriod = ServicedChoice.FromPeriod(
                DateTime.Today, 
                DateTime.Today.AddDays(7)
            );
            Console.WriteLine($"Service period: {servicePeriod.ServicePeriod?.Start?.Value:yyyy-MM-dd} to {servicePeriod.ServicePeriod?.End?.Value:yyyy-MM-dd}");

            // 從字符串創建日期
            var serviceDateString = ServicedChoice.FromDateString("2023-12-25");
            Console.WriteLine($"Service date (from string): {serviceDateString.ServiceDate?.ToString("yyyy-MM-dd")}");
        }

        static void DemonstratePatternMatching()
        {
            Console.WriteLine("--- 模式匹配示範 ---");

            var choices = new object[]
            {
                AsNeededChoice.FromBoolean(true),
                AsNeededChoice.FromCodeableConcept(new CodeableConcept()),
                DeceasedChoice.FromBoolean(false),
                DeceasedChoice.FromDateTime(DateTime.Now),
                ServicedChoice.FromDate(DateTime.Today)
            };

            foreach (var choice in choices)
            {
                switch (choice)
                {
                    case AsNeededChoice asNeeded:
                        var description = asNeeded.Match(
                            boolean => $"AsNeeded boolean: {boolean.Value}",
                            concept => "AsNeeded with CodeableConcept"
                        );
                        Console.WriteLine(description);
                        break;

                    case DeceasedChoice deceased:
                        deceased.Switch(
                            boolean => Console.WriteLine($"Deceased status: {boolean.Value}"),
                            dateTime => Console.WriteLine($"Deceased on: {dateTime.Value:yyyy-MM-dd}")
                        );
                        break;

                    case ServicedChoice serviced:
                        var serviceInfo = serviced.Match(
                            date => $"Service date: {date.Value:yyyy-MM-dd}",
                            period => $"Service period: {period.Start?.Value:yyyy-MM-dd} to {period.End?.Value:yyyy-MM-dd}"
                        );
                        Console.WriteLine(serviceInfo);
                        break;
                }
            }
        }
    }
}
