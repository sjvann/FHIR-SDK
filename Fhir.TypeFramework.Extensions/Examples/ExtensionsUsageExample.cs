using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.ComplexTypes;
using Fhir.TypeFramework.Extensions;

namespace Fhir.TypeFramework.Extensions.Examples;

/// <summary>
/// 擴展功能使用範例
/// 展示如何使用 LINQ、匿名函數和 Extension Methods 來提升使用者體驗
/// </summary>
public static class ExtensionsUsageExample
{
    /// <summary>
    /// 展示 Primitive Type 擴展方法的使用
    /// </summary>
    public static void DemonstratePrimitiveTypeExtensions()
    {
        Console.WriteLine("=== Primitive Type 擴展方法範例 ===");

        // 字串轉換
        var fhirString = "Hello FHIR".ToFhirString();
        var fhirUri = "https://example.com/fhir".ToFhirUri();
        var fhirCode = "active".ToFhirCode();
        var fhirId = "patient-123".ToFhirId();

        // 數值轉換
        var fhirInteger = 42.ToFhirInteger();
        var fhirPositiveInt = 10.ToFhirPositiveInt();
        var fhirDecimal = 3.14m.ToFhirDecimal();
        var fhirDouble = 2.718.ToFhirDecimal(); // 自動轉換

        // 布林值轉換
        var fhirBoolean = true.ToFhirBoolean();

        // 日期時間轉換
        var now = DateTime.Now;
        var fhirDateTime = now.ToFhirDateTime();
        var fhirDate = now.ToFhirDate();
        var fhirInstant = now.ToFhirInstant();

        // 時間轉換
        var timeSpan = TimeSpan.FromHours(14).Add(TimeSpan.FromMinutes(30));
        var fhirTime = timeSpan.ToFhirTime();

        Console.WriteLine($"FhirString: {fhirString.Value}");
        Console.WriteLine($"FhirUri: {fhirUri.Value}");
        Console.WriteLine($"FhirInteger: {fhirInteger.Value}");
        Console.WriteLine($"FhirDecimal: {fhirDecimal.Value}");
        Console.WriteLine($"FhirBoolean: {fhirBoolean.Value}");
        Console.WriteLine($"FhirDateTime: {fhirDateTime.Value}");
        Console.WriteLine($"FhirTime: {fhirTime.Value}");
    }

    /// <summary>
    /// 展示 Choice Type 擴展方法的使用
    /// </summary>
    public static void DemonstrateChoiceTypeExtensions()
    {
        Console.WriteLine("\n=== Choice Type 擴展方法範例 ===");

        // Extension 的 Choice Type 使用
        var extension = new Extension
        {
            Url = "https://example.com/extension"
        };

        // 使用流暢的 API 設定值
        extension.WithStringValue("這是一個字串值");
        Console.WriteLine($"Extension String Value: {extension.GetStringValue()}");

        extension.WithIntegerValue(42);
        Console.WriteLine($"Extension Integer Value: {extension.GetIntegerValue()}");

        extension.WithBooleanValue(true);
        Console.WriteLine($"Extension Boolean Value: {extension.GetBooleanValue()}");

        extension.WithDecimalValue(3.14159m);
        Console.WriteLine($"Extension Decimal Value: {extension.GetDecimalValue()}");

        extension.WithDateTimeValue(DateTime.Now);
        Console.WriteLine($"Extension DateTime Value: {extension.GetDateTimeValue()}");

        // 使用匿名函數和 LINQ 風格的 API
        extension.WithValue(x => x); // 這裡可以配合 IntelliSense 選擇類型
        Console.WriteLine("Extension with anonymous function set");
    }

    /// <summary>
    /// 展示 Patient Choice Type 的使用
    /// </summary>
    public static void DemonstratePatientChoiceExtensions()
    {
        Console.WriteLine("\n=== Patient Choice Type 範例 ===");

        var patient = new Patient();

        // 設定死亡狀態（布林值）
        patient.WithDeceased(true);
        Console.WriteLine($"Patient Deceased (Boolean): {patient.Deceased?.Match(
            boolean => boolean.Value.ToString(),
            dateTime => dateTime.Value.ToString(),
            _ => "Unknown"
        )}");

        // 設定死亡日期
        patient.WithDeceasedDate(DateTime.Now.AddYears(-5));
        Console.WriteLine($"Patient Deceased (DateTime): {patient.Deceased?.Match(
            boolean => boolean.Value.ToString(),
            dateTime => dateTime.Value.ToString(),
            _ => "Unknown"
        )}");

        // 設定多胞胎狀態
        patient.WithMultipleBirth(true);
        Console.WriteLine($"Patient Multiple Birth (Boolean): {patient.MultipleBirth?.Match(
            boolean => boolean.Value.ToString(),
            integer => integer.Value.ToString(),
            _ => "Unknown"
        )}");

        // 設定多胞胎數量
        patient.WithMultipleBirthCount(3);
        Console.WriteLine($"Patient Multiple Birth (Integer): {patient.MultipleBirth?.Match(
            boolean => boolean.Value.ToString(),
            integer => integer.Value.ToString(),
            _ => "Unknown"
        )}");
    }

    /// <summary>
    /// 展示 Observation Choice Type 的使用
    /// </summary>
    public static void DemonstrateObservationChoiceExtensions()
    {
        Console.WriteLine("\n=== Observation Choice Type 範例 ===");

        var observation = new Observation();

        // 設定有效時間（日期時間）
        observation.WithEffectiveDateTime(DateTime.Now);
        Console.WriteLine($"Observation Effective (DateTime): {observation.Effective?.Match(
            dateTime => dateTime.Value.ToString(),
            period => $"Period: {period.Start?.Value} to {period.End?.Value}",
            timing => "Timing",
            instant => instant.Value.ToString(),
            _ => "Unknown"
        )}");

        // 設定有效時間（期間）
        var period = Extensions.ChoiceTypeExtensions.CreatePeriod(
            DateTime.Now.AddDays(-7),
            DateTime.Now
        );
        observation.WithEffectivePeriod(period);
        Console.WriteLine($"Observation Effective (Period): {observation.Effective?.Match(
            dateTime => dateTime.Value.ToString(),
            period => $"Period: {period.Start?.Value} to {period.End?.Value}",
            timing => "Timing",
            instant => instant.Value.ToString(),
            _ => "Unknown"
        )}");

        // 設定值（數量）
        var quantity = Extensions.ChoiceTypeExtensions.CreateQuantity(120.5m, "mmHg");
        observation.WithQuantityValue(quantity);
        Console.WriteLine($"Observation Value (Quantity): {observation.Value?.Match(
            quantity => $"{quantity.Value?.Value} {quantity.Unit?.Value}",
            codeableConcept => codeableConcept.Text?.Value ?? "No text",
            fhirString => fhirString.Value,
            fhirBoolean => fhirBoolean.Value.ToString(),
            fhirInteger => fhirInteger.Value.ToString(),
            _ => "Unknown"
        )}");

        // 設定值（字串）
        observation.WithStringValue("正常範圍內");
        Console.WriteLine($"Observation Value (String): {observation.Value?.Match(
            quantity => $"{quantity.Value?.Value} {quantity.Unit?.Value}",
            codeableConcept => codeableConcept.Text?.Value ?? "No text",
            fhirString => fhirString.Value,
            fhirBoolean => fhirBoolean.Value.ToString(),
            fhirInteger => fhirInteger.Value.ToString(),
            _ => "Unknown"
        )}");
    }

    /// <summary>
    /// 展示 Condition Choice Type 的使用
    /// </summary>
    public static void DemonstrateConditionChoiceExtensions()
    {
        Console.WriteLine("\n=== Condition Choice Type 範例 ===");

        var condition = new Condition();

        // 設定發作時間（日期時間）
        condition.WithOnsetDateTime(DateTime.Now.AddYears(-2));
        Console.WriteLine($"Condition Onset (DateTime): {condition.Onset?.Match(
            dateTime => dateTime.Value.ToString(),
            age => $"{age.Value?.Value} {age.Unit?.Value}",
            period => $"Period: {period.Start?.Value} to {period.End?.Value}",
            range => "Range",
            fhirString => fhirString.Value,
            _ => "Unknown"
        )}");

        // 設定發作時間（年齡）
        var age = Extensions.ChoiceTypeExtensions.CreateAge(25, "years");
        condition.WithOnsetAge(age);
        Console.WriteLine($"Condition Onset (Age): {condition.Onset?.Match(
            dateTime => dateTime.Value.ToString(),
            age => $"{age.Value?.Value} {age.Unit?.Value}",
            period => $"Period: {period.Start?.Value} to {period.End?.Value}",
            range => "Range",
            fhirString => fhirString.Value,
            _ => "Unknown"
        )}");

        // 設定發作時間（字串）
        condition.WithOnsetString("約 2 年前");
        Console.WriteLine($"Condition Onset (String): {condition.Onset?.Match(
            dateTime => dateTime.Value.ToString(),
            age => $"{age.Value?.Value} {age.Unit?.Value}",
            period => $"Period: {period.Start?.Value} to {period.End?.Value}",
            range => "Range",
            fhirString => fhirString.Value,
            _ => "Unknown"
        )}");
    }

    /// <summary>
    /// 展示 Complex Type 創建的流暢 API
    /// </summary>
    public static void DemonstrateComplexTypeCreation()
    {
        Console.WriteLine("\n=== Complex Type 創建範例 ===");

        // 創建 Quantity
        var quantity = Extensions.ChoiceTypeExtensions.CreateQuantity(70.5m, "kg");
        Console.WriteLine($"Quantity: {quantity.Value?.Value} {quantity.Unit?.Value}");

        // 創建 Period
        var period = Extensions.ChoiceTypeExtensions.CreatePeriod(
            DateTime.Now.AddDays(-30),
            DateTime.Now
        );
        Console.WriteLine($"Period: {period.Start?.Value} to {period.End?.Value}");

        // 創建 Range
        var lowQuantity = Extensions.ChoiceTypeExtensions.CreateQuantity(60.0m, "kg");
        var highQuantity = Extensions.ChoiceTypeExtensions.CreateQuantity(80.0m, "kg");
        var range = Extensions.ChoiceTypeExtensions.CreateRange(lowQuantity, highQuantity);
        Console.WriteLine($"Range: {range.Low?.Value?.Value} to {range.High?.Value?.Value} {range.Low?.Unit?.Value}");

        // 創建 Age
        var age = Extensions.ChoiceTypeExtensions.CreateAge(30, "years");
        Console.WriteLine($"Age: {age.Value?.Value} {age.Unit?.Value}");

        // 創建 Duration
        var duration = Extensions.ChoiceTypeExtensions.CreateDuration(2.5m, "hours");
        Console.WriteLine($"Duration: {duration.Value?.Value} {duration.Unit?.Value}");
    }

    /// <summary>
    /// 展示 IntelliSense 友好的使用方式
    /// </summary>
    public static void DemonstrateIntelliSenseFriendlyUsage()
    {
        Console.WriteLine("\n=== IntelliSense 友好範例 ===");

        // 使用 Extension Methods 讓 IntelliSense 提供更好的提示
        var extension = new Extension
        {
            Url = "https://example.com/extension"
        };

        // 當你輸入 extension.With 時，IntelliSense 會顯示所有可用的方法
        extension.WithStringValue("字串值");
        extension.WithIntegerValue(42);
        extension.WithBooleanValue(true);
        extension.WithDecimalValue(3.14m);
        extension.WithDateTimeValue(DateTime.Now);

        // 對於 Complex Types，可以使用 {} 方式設值
        var patient = new Patient();
        patient.WithDeceased(true);  // 布林值直接設值
        patient.WithDeceasedDate(DateTime.Now);  // 日期時間直接設值

        var observation = new Observation();
        observation.WithEffectiveDateTime(DateTime.Now);  // 日期時間直接設值
        observation.WithEffectivePeriod(new Period  // Complex Type 使用 {} 方式
        {
            Start = DateTime.Now.AddDays(-7).ToFhirDateTime(),
            End = DateTime.Now.ToFhirDateTime()
        });

        Console.WriteLine("IntelliSense 友好的 API 使用完成");
    }

    /// <summary>
    /// 主範例方法
    /// </summary>
    public static void RunAllExamples()
    {
        Console.WriteLine("🚀 FHIR TypeFramework Extensions 使用範例");
        Console.WriteLine("==========================================");

        DemonstratePrimitiveTypeExtensions();
        DemonstrateChoiceTypeExtensions();
        DemonstratePatientChoiceExtensions();
        DemonstrateObservationChoiceExtensions();
        DemonstrateConditionChoiceExtensions();
        DemonstrateComplexTypeCreation();
        DemonstrateIntelliSenseFriendlyUsage();

        Console.WriteLine("\n✅ 所有範例執行完成！");
        Console.WriteLine("\n💡 使用提示：");
        Console.WriteLine("1. 使用 .ToFhirXXX() 方法將基本型別轉換為 FHIR 型別");
        Console.WriteLine("2. 使用 .WithXXX() 方法設定 Choice Type 的值");
        Console.WriteLine("3. 配合 IntelliSense 獲得更好的開發體驗");
        Console.WriteLine("4. 對於 Complex Types，可以使用 {} 方式設值");
    }
} 