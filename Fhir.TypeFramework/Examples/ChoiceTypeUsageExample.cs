using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.ComplexTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;

namespace Fhir.TypeFramework.Examples;

/// <summary>
/// Choice Type 使用範例
/// 展示如何正確使用 FHIR 的 Choice Types ([x] 型別)
/// </summary>
/// <remarks>
/// 本範例展示如何使用改進後的 Choice Type 解決方案，
/// 包括 Extension.value[x]、Patient.deceased[x]、Observation.value[x] 等
/// </remarks>
public class ChoiceTypeUsageExample
{
    /// <summary>
    /// 執行所有 Choice Type 範例
    /// </summary>
    public static void RunAllExamples()
    {
        Console.WriteLine("🏥 FHIR Choice Type 使用範例");
        Console.WriteLine("================================");

        ExtensionValueExample();
        PatientDeceasedExample();
        ObservationValueExample();
        AnnotationAuthorExample();
        ConditionOnsetExample();
        ProcedurePerformedExample();
        TimingRepeatBoundsExample();

        Console.WriteLine("\n✅ 所有 Choice Type 範例執行完成！");
    }

    /// <summary>
    /// Extension.value[x] 使用範例
    /// </summary>
    /// <remarks>
    /// Extension 的 value[x] 可以是多種型別
    /// </remarks>
    public static void ExtensionValueExample()
    {
        Console.WriteLine("\n🔧 Extension.value[x] 使用範例");
        Console.WriteLine("--------------------------------");

        // 建立 Extension
        var extension = new Extension
        {
            Url = "http://example.com/custom-extension"
        };

        // 方法 1: 使用隱含轉換
        extension.Value = "Hello World";  // 自動轉換為 FhirString
        Console.WriteLine($"✅ 字串值: {extension.GetStringValue()}");

        // 方法 2: 使用專用方法
        extension.SetIntegerValue(42);
        Console.WriteLine($"✅ 整數值: {extension.GetIntegerValue()}");

        extension.SetBooleanValue(true);
        Console.WriteLine($"✅ 布林值: {extension.GetBooleanValue()}");

        extension.SetDecimalValue(3.14m);
        Console.WriteLine($"✅ 小數值: {extension.GetDecimalValue()}");

        extension.SetDateTimeValue(DateTime.Now);
        Console.WriteLine($"✅ 日期時間值: {extension.GetDateTimeValue()}");

        // 方法 3: 使用泛型方法
        extension.SetValue(new FhirString("Generic method"));
        Console.WriteLine($"✅ 泛型方法: {extension.GetStringValue()}");
    }

    /// <summary>
    /// Patient.deceased[x] 使用範例
    /// </summary>
    /// <remarks>
    /// deceased[x] 可以是 boolean 或 dateTime
    /// </remarks>
    public static void PatientDeceasedExample()
    {
        Console.WriteLine("\n🔧 Patient.deceased[x] 使用範例");
        Console.WriteLine("--------------------------------");

        // 建立 Patient 資源（模擬）
        var patient = new { Deceased = (PatientDeceasedChoice?)null };

        // 方法 1: 使用布林值
        var deceasedBoolean = new PatientDeceasedChoice(new FhirBoolean(true));
        Console.WriteLine($"✅ 布林值: {deceasedBoolean.Match(
            boolean => boolean.Value.ToString(),
            dateTime => dateTime.Value.ToString()
        )}");

        // 方法 2: 使用日期時間
        var deceasedDateTime = new PatientDeceasedChoice(new FhirDateTime(DateTime.Now));
        Console.WriteLine($"✅ 日期時間值: {deceasedDateTime.Match(
            boolean => boolean.Value.ToString(),
            dateTime => dateTime.Value.ToString()
        )}");

        // 方法 3: 隱含轉換
        PatientDeceasedChoice implicitBoolean = new FhirBoolean(false);
        PatientDeceasedChoice implicitDateTime = new FhirDateTime(DateTime.Now.AddDays(-1));
        
        Console.WriteLine($"✅ 隱含轉換布林值: {implicitBoolean.Match(
            boolean => boolean.Value.ToString(),
            dateTime => dateTime.Value.ToString()
        )}");
    }

    /// <summary>
    /// Observation.value[x] 使用範例
    /// </summary>
    /// <remarks>
    /// value[x] 可以是多種型別：Quantity, CodeableConcept, string, boolean 等
    /// </remarks>
    public static void ObservationValueExample()
    {
        Console.WriteLine("\n🔧 Observation.value[x] 使用範例");
        Console.WriteLine("--------------------------------");

        // 建立不同的 Observation 值
        var stringValue = new ObservationValueChoice(new FhirString("Normal"));
        var booleanValue = new ObservationValueChoice(new FhirBoolean(true));
        var integerValue = new ObservationValueChoice(new FhirInteger(100));

        // 使用 Match 方法處理不同型別
        Console.WriteLine($"✅ 字串值: {stringValue.Match(
            quantity => quantity.ToString(),
            codeableConcept => codeableConcept.ToString(),
            str => str.Value,
            boolean => boolean.Value.ToString(),
            integer => integer.Value.ToString()
        )}");

        Console.WriteLine($"✅ 布林值: {booleanValue.Match(
            quantity => quantity.ToString(),
            codeableConcept => codeableConcept.ToString(),
            str => str.Value,
            boolean => boolean.Value.ToString(),
            integer => integer.Value.ToString()
        )}");

        Console.WriteLine($"✅ 整數值: {integerValue.Match(
            quantity => quantity.ToString(),
            codeableConcept => codeableConcept.ToString(),
            str => str.Value,
            boolean => boolean.Value.ToString(),
            integer => integer.Value.ToString()
        )}");
    }

    /// <summary>
    /// Annotation.author[x] 使用範例
    /// </summary>
    /// <remarks>
    /// author[x] 可以是 Reference 或 string
    /// </remarks>
    public static void AnnotationAuthorExample()
    {
        Console.WriteLine("\n🔧 Annotation.author[x] 使用範例");
        Console.WriteLine("--------------------------------");

        // 建立 Annotation
        var annotation = new Annotation
        {
            Text = "This is a test annotation"
        };

        // 方法 1: 使用字串
        annotation.SetAuthor(new FhirString("Dr. Smith"));
        Console.WriteLine($"✅ 字串作者: {annotation.GetAuthor<FhirString>()?.Value}");

        // 方法 2: 使用 Reference
        var reference = new Reference { Reference = "Practitioner/practitioner-001" };
        annotation.SetAuthor(reference);
        Console.WriteLine($"✅ Reference 作者: {annotation.GetAuthor<Reference>()?.Reference}");

        // 方法 3: 使用 Choice Type
        var authorChoice = new AnnotationAuthorChoice(new FhirString("Dr. Johnson"));
        Console.WriteLine($"✅ Choice Type 作者: {authorChoice.Match(
            reference => reference.Reference,
            str => str.Value
        )}");
    }

    /// <summary>
    /// Condition.onset[x] 使用範例
    /// </summary>
    /// <remarks>
    /// onset[x] 可以是 dateTime, Age, Period, Range, string
    /// </remarks>
    public static void ConditionOnsetExample()
    {
        Console.WriteLine("\n🔧 Condition.onset[x] 使用範例");
        Console.WriteLine("--------------------------------");

        // 建立不同的 onset 值
        var dateTimeOnset = new ConditionOnsetChoice(new FhirDateTime(DateTime.Now));
        var stringOnset = new ConditionOnsetChoice(new FhirString("Last week"));

        Console.WriteLine($"✅ 日期時間 onset: {dateTimeOnset.Match(
            dateTime => dateTime.Value.ToString(),
            age => age.ToString(),
            period => period.ToString(),
            range => range.ToString(),
            str => str.Value
        )}");

        Console.WriteLine($"✅ 字串 onset: {stringOnset.Match(
            dateTime => dateTime.Value.ToString(),
            age => age.ToString(),
            period => period.ToString(),
            range => range.ToString(),
            str => str.Value
        )}");
    }

    /// <summary>
    /// Procedure.performed[x] 使用範例
    /// </summary>
    /// <remarks>
    /// performed[x] 可以是 dateTime, Period, string, Age, Range
    /// </remarks>
    public static void ProcedurePerformedExample()
    {
        Console.WriteLine("\n🔧 Procedure.performed[x] 使用範例");
        Console.WriteLine("--------------------------------");

        // 建立不同的 performed 值
        var dateTimePerformed = new ProcedurePerformedChoice(new FhirDateTime(DateTime.Now));
        var stringPerformed = new ProcedurePerformedChoice(new FhirString("Yesterday"));

        Console.WriteLine($"✅ 日期時間 performed: {dateTimePerformed.Match(
            dateTime => dateTime.Value.ToString(),
            period => period.ToString(),
            str => str.Value,
            age => age.ToString(),
            range => range.ToString()
        )}");

        Console.WriteLine($"✅ 字串 performed: {stringPerformed.Match(
            dateTime => dateTime.Value.ToString(),
            period => period.ToString(),
            str => str.Value,
            age => age.ToString(),
            range => range.ToString()
        )}");
    }

    /// <summary>
    /// Timing.repeat.bounds[x] 使用範例
    /// </summary>
    /// <remarks>
    /// bounds[x] 可以是 Duration 或 Range
    /// </remarks>
    public static void TimingRepeatBoundsExample()
    {
        Console.WriteLine("\n🔧 Timing.repeat.bounds[x] 使用範例");
        Console.WriteLine("--------------------------------");

        // 建立不同的 bounds 值
        var durationBounds = new TimingRepeatBoundsChoice(new Duration { Value = 30 });
        var rangeBounds = new TimingRepeatBoundsChoice(new Range { Low = new Quantity { Value = 10 } });

        Console.WriteLine($"✅ Duration bounds: {durationBounds.Match(
            duration => duration.Value.ToString(),
            range => range.ToString()
        )}");

        Console.WriteLine($"✅ Range bounds: {rangeBounds.Match(
            duration => duration.Value.ToString(),
            range => range.ToString()
        )}");
    }
} 