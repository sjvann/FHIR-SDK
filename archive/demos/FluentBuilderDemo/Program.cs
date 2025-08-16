using DataTypeServices.Builders;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using TerminologyService.ValueSet;
using System;
using System.Collections.Generic;

namespace FluentBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FHIR SDK Fluent Builder API 示範");
            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine();

            DemonstrateAddressBuilder();
            Console.WriteLine();

            DemonstrateHumanNameBuilder();
            Console.WriteLine();

            DemonstratePeriodBuilder();
            Console.WriteLine();

            DemonstrateAdvancedFeatures();
            Console.WriteLine();

            Console.WriteLine("示範完成！按任意鍵退出...");
            Console.ReadKey();
        }

        static void DemonstrateAddressBuilder()
        {
            Console.WriteLine("--- Address Builder 示範 ---");

            // 基本用法
            var homeAddress = Address.Builder()
                .WithUse(EnumAddressUse.home)
                .WithType(EnumAddressType.physical)
                .WithLine("123 Main Street")
                .WithLine("Apt 4B")
                .WithCity("Anytown")
                .WithState("NY")
                .WithPostalCode("12345")
                .WithCountry("USA")
                .Build();

            Console.WriteLine("基本家庭地址:");
            Console.WriteLine($"  用途: {homeAddress.Use?.Value}");
            Console.WriteLine($"  類型: {homeAddress.Type?.Value}");
            Console.WriteLine($"  地址行: {string.Join(", ", homeAddress.Line?.Select(l => l.Value) ?? new string[0])}");
            Console.WriteLine($"  城市: {homeAddress.City?.Value}");
            Console.WriteLine($"  州: {homeAddress.State?.Value}");
            Console.WriteLine($"  郵政編碼: {homeAddress.PostalCode?.Value}");
            Console.WriteLine($"  國家: {homeAddress.Country?.Value}");

            // 使用便利方法
            var usAddress = Address.Builder()
                .WithUSAddress("456 Oak Avenue", "Los Angeles", "CA", "90210")
                .Build();

            Console.WriteLine("\n美國地址便利方法:");
            Console.WriteLine($"  完整地址: {usAddress.Line?[0].Value}, {usAddress.City?.Value}, {usAddress.State?.Value} {usAddress.PostalCode?.Value}");

            // 使用靜態工廠方法
            var workAddress = Address.Work(builder => builder
                .WithLine("789 Business Blvd")
                .WithCity("Corporate City")
                .WithState("TX")
                .WithPostalCode("75001")
                .WithCountry("USA"));

            Console.WriteLine("\n工作地址（靜態工廠方法）:");
            Console.WriteLine($"  用途: {workAddress.Use?.Value}");
            Console.WriteLine($"  地址: {workAddress.Line?[0].Value}, {workAddress.City?.Value}");

            // 帶有效期的地址
            var tempAddress = Address.Builder()
                .WithUse(EnumAddressUse.temp)
                .WithCity("Temporary City")
                .WithPeriod(DateTime.Today, DateTime.Today.AddMonths(6))
                .Build();

            Console.WriteLine("\n臨時地址（帶有效期）:");
            Console.WriteLine($"  城市: {tempAddress.City?.Value}");
            Console.WriteLine($"  有效期: {tempAddress.Period?.Start?.Value:yyyy-MM-dd} 到 {tempAddress.Period?.End?.Value:yyyy-MM-dd}");
        }

        static void DemonstrateHumanNameBuilder()
        {
            Console.WriteLine("--- HumanName Builder 示範 ---");

            // 基本用法
            var officialName = HumanName.Builder()
                .WithUse("official")
                .WithPrefix("Dr.")
                .WithGiven("John", "William")
                .WithFamily("Doe")
                .WithSuffix("Jr.", "MD")
                .Build();

            Console.WriteLine("正式姓名:");
            Console.WriteLine($"  用途: {officialName.Use?.Value}");
            Console.WriteLine($"  前綴: {string.Join(" ", officialName.Prefix?.Select(p => p.Value) ?? new string[0])}");
            Console.WriteLine($"  名字: {string.Join(" ", officialName.Given?.Select(g => g.Value) ?? new string[0])}");
            Console.WriteLine($"  姓氏: {officialName.Family?.Value}");
            Console.WriteLine($"  後綴: {string.Join(" ", officialName.Suffix?.Select(s => s.Value) ?? new string[0])}");

            // 使用便利方法
            var westernName = HumanName.Builder()
                .WithWesternName("Jane", "Smith", "Marie")
                .Build();

            Console.WriteLine("\n西方姓名格式:");
            Console.WriteLine($"  姓氏: {westernName.Family?.Value}");
            Console.WriteLine($"  名字: {string.Join(" ", westernName.Given?.Select(g => g.Value) ?? new string[0])}");

            // 從完整姓名解析
            var parsedName = HumanName.Builder()
                .ParseFullName("Mary Elizabeth Johnson")
                .WithUse("official")
                .Build();

            Console.WriteLine("\n從完整姓名解析:");
            Console.WriteLine($"  原始文本: {parsedName.Text?.Value}");
            Console.WriteLine($"  解析後姓氏: {parsedName.Family?.Value}");
            Console.WriteLine($"  解析後名字: {string.Join(" ", parsedName.Given?.Select(g => g.Value) ?? new string[0])}");

            // 使用靜態工廠方法
            var nickname = HumanName.Nickname("Johnny");
            var quickOfficial = HumanName.Official("Alice", "Brown");

            Console.WriteLine("\n靜態工廠方法:");
            Console.WriteLine($"  暱稱: {nickname.Given?[0].Value} (用途: {nickname.Use?.Value})");
            Console.WriteLine($"  快速正式姓名: {quickOfficial.Given?[0].Value} {quickOfficial.Family?.Value}");

            // 帶有效期的姓名
            var marriedName = HumanName.Builder()
                .WithUse("official")
                .WithGiven("Sarah")
                .WithFamily("Johnson")
                .WithPeriod(period => period
                    .WithStart(DateTime.Today.AddYears(-2))
                    .WithEnd(DateTime.Today.AddYears(10)))
                .Build();

            Console.WriteLine("\n帶有效期的姓名:");
            Console.WriteLine($"  姓名: {marriedName.Given?[0].Value} {marriedName.Family?.Value}");
            Console.WriteLine($"  有效期: {marriedName.Period?.Start?.Value:yyyy-MM-dd} 到 {marriedName.Period?.End?.Value:yyyy-MM-dd}");
        }

        static void DemonstratePeriodBuilder()
        {
            Console.WriteLine("--- Period Builder 示範 ---");

            // 基本用法
            var basicPeriod = Period.Builder()
                .WithStart(DateTime.Today)
                .WithEnd(DateTime.Today.AddDays(30))
                .Build();

            Console.WriteLine("基本期間:");
            Console.WriteLine($"  開始: {basicPeriod.Start?.Value:yyyy-MM-dd}");
            Console.WriteLine($"  結束: {basicPeriod.End?.Value:yyyy-MM-dd}");
            Console.WriteLine($"  持續時間: {(basicPeriod.End?.Value - basicPeriod.Start?.Value)?.Days} 天");

            // 使用範圍方法
            var rangePeriod = Period.Builder()
                .WithRange(DateTime.Today.AddDays(-7), DateTime.Today)
                .Build();

            Console.WriteLine("\n範圍期間:");
            Console.WriteLine($"  過去一週: {rangePeriod.Start?.Value:yyyy-MM-dd} 到 {rangePeriod.End?.Value:yyyy-MM-dd}");

            // 使用便利方法
            var thisWeek = Period.Builder().ThisWeek().Build();
            var thisMonth = Period.Builder().ThisMonth().Build();
            var fromNow = Period.Builder().FromNow(TimeSpan.FromDays(90)).Build();

            Console.WriteLine("\n便利方法:");
            Console.WriteLine($"  本週: {thisWeek.Start?.Value:yyyy-MM-dd} 到 {thisWeek.End?.Value:yyyy-MM-dd}");
            Console.WriteLine($"  本月: {thisMonth.Start?.Value:yyyy-MM-dd} 到 {thisMonth.End?.Value:yyyy-MM-dd}");
            Console.WriteLine($"  未來90天: {fromNow.Start?.Value:yyyy-MM-dd} 到 {fromNow.End?.Value:yyyy-MM-dd}");

            // 使用靜態工廠方法
            var quickRange = Period.Range(DateTime.Today, DateTime.Today.AddYears(1));
            var quickFromNow = Period.FromNow(TimeSpan.FromDays(365));
            var quickThisWeek = Period.ThisWeek();

            Console.WriteLine("\n靜態工廠方法:");
            Console.WriteLine($"  一年期間: {quickRange.Start?.Value:yyyy-MM-dd} 到 {quickRange.End?.Value:yyyy-MM-dd}");
            Console.WriteLine($"  從現在開始一年: {quickFromNow.Start?.Value:yyyy-MM-dd HH:mm} 到 {quickFromNow.End?.Value:yyyy-MM-dd HH:mm}");

            // 開放式期間
            var openEnded = Period.Builder()
                .OpenEnded(DateTime.Today)
                .Build();

            var endingAt = Period.Builder()
                .EndingAt(DateTime.Today.AddYears(1))
                .Build();

            Console.WriteLine("\n開放式期間:");
            Console.WriteLine($"  只有開始時間: {openEnded.Start?.Value:yyyy-MM-dd} (結束時間: {openEnded.End?.Value?.ToString("yyyy-MM-dd") ?? "未設定"})");
            Console.WriteLine($"  只有結束時間: {endingAt.End?.Value:yyyy-MM-dd} (開始時間: {endingAt.Start?.Value?.ToString("yyyy-MM-dd") ?? "未設定"})");
        }

        static void DemonstrateAdvancedFeatures()
        {
            Console.WriteLine("--- 進階功能示範 ---");

            // 條件性建構
            var conditionalAddress = Address.Builder()
                .WithCity("Base City")
                .When(true, builder => builder.WithCountry("USA"))
                .When(false, builder => builder.WithCountry("Canada"))
                .When("12345", (builder, zip) => builder.WithPostalCode(zip))
                .Build();

            Console.WriteLine("條件性建構:");
            Console.WriteLine($"  城市: {conditionalAddress.City?.Value}");
            Console.WriteLine($"  國家: {conditionalAddress.Country?.Value}");
            Console.WriteLine($"  郵政編碼: {conditionalAddress.PostalCode?.Value}");

            // 自定義配置
            var customAddress = Address.Builder()
                .WithCity("Custom City")
                .Configure(addr => 
                {
                    addr.Text = new FhirString("自定義地址文本");
                    // 可以進行任何自定義配置
                })
                .Build();

            Console.WriteLine("\n自定義配置:");
            Console.WriteLine($"  城市: {customAddress.City?.Value}");
            Console.WriteLine($"  自定義文本: {customAddress.Text?.Value}");

            // Builder 複製
            var baseBuilder = HumanName.Builder()
                .WithFamily("Smith")
                .WithUse("official");

            var johnSmith = baseBuilder.Clone()
                .WithGiven("John")
                .Build();

            var janeSmith = baseBuilder.Clone()
                .WithGiven("Jane")
                .Build();

            Console.WriteLine("\nBuilder 複製:");
            Console.WriteLine($"  John: {johnSmith.Given?[0].Value} {johnSmith.Family?.Value}");
            Console.WriteLine($"  Jane: {janeSmith.Given?[0].Value} {janeSmith.Family?.Value}");

            // 隱式轉換
            Console.WriteLine("\n隱式轉換:");
            Address implicitAddress = Address.Builder()
                .WithCity("Implicit City")
                .WithCountry("USA");

            Console.WriteLine($"  隱式轉換地址: {implicitAddress.City?.Value}, {implicitAddress.Country?.Value}");

            // 驗證
            var validationBuilder = Period.Builder()
                .WithStart(DateTime.Today)
                .WithEnd(DateTime.Today.AddDays(30));

            var validationResults = validationBuilder.Validate();
            Console.WriteLine($"\n驗證結果: {(validationResults.IsValid ? "通過" : "失敗")}");

            try
            {
                var validatedPeriod = validationBuilder.BuildAndValidate();
                Console.WriteLine($"驗證並建構成功: {validatedPeriod.Start?.Value:yyyy-MM-dd} 到 {validatedPeriod.End?.Value:yyyy-MM-dd}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"驗證失敗: {ex.Message}");
            }
        }
    }
}
