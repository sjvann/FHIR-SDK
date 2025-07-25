using Fhir.R4.Models.Base;
using Fhir.R4.Models.DataTypes;
using Fhir.R4.Models.Resources;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Examples;

/// <summary>
/// Choice Type 使用範例
/// 展示如何正確使用 FHIR 的 Choice Types ([x] 型別)
/// </summary>
public class ChoiceTypeUsageExample
{
    /// <summary>
    /// 基本 Choice Type 使用範例
    /// </summary>
    public void BasicChoiceTypeExample()
    {
        // 建立一個簡單的 Choice Type
        var choice = new ChoiceType<FhirString, FhirInteger>();

        // 方式 1：直接設定值（透過隱式轉換）
        choice = "Hello World";  // string → FhirString → ChoiceType
        Console.WriteLine($"String value: {choice.AsT1()?.Value}");
        Console.WriteLine($"Value type: {choice.ValueTypeName}");
        Console.WriteLine($"Has value: {choice.HasValue}");

        // 方式 2：設定不同型別的值
        choice = 42;  // int → FhirInteger → ChoiceType
        Console.WriteLine($"Integer value: {choice.AsT2()?.Value}");
        Console.WriteLine($"Value type: {choice.ValueTypeName}");

        // 方式 3：使用 Value 屬性
        choice.Value = new FhirString("Another string");
        Console.WriteLine($"Value via Value property: {choice.Value}");

        // 檢查型別
        if (choice.IsT1())
        {
            Console.WriteLine("Current value is a string");
        }
        else if (choice.IsT2())
        {
            Console.WriteLine("Current value is an integer");
        }
    }

    /// <summary>
    /// Extension.value[x] 使用範例
    /// </summary>
    public void ExtensionValueChoiceExample()
    {
        // Extension 的 value[x] 可以是多種型別
        var extension = new Extension
        {
            Url = "http://example.org/fhir/StructureDefinition/patient-importance"
        };

        // 設定 string 值
        extension.ValueString = "high";
        Console.WriteLine($"Extension string value: {extension.ValueString}");
        Console.WriteLine($"Extension value type: {extension.ValueChoice?.ValueTypeName}");

        // 清除並設定 boolean 值
        extension.ValueString = null;  // 清除 string 值
        extension.ValueBoolean = true;
        Console.WriteLine($"Extension boolean value: {extension.ValueBoolean}");

        // 設定 CodeableConcept 值
        extension.ValueBoolean = null;  // 清除 boolean 值
        extension.ValueCodeableConcept = new CodeableConcept
        {
            Text = "High Priority"
        };
        Console.WriteLine($"Extension CodeableConcept: {extension.ValueCodeableConcept?.Text}");

        // 使用統一的 Value 屬性
        Console.WriteLine($"Extension value (unified): {extension.Value}");
    }

    /// <summary>
    /// Patient.deceased[x] 使用範例
    /// </summary>
    public void PatientDeceasedChoiceExample()
    {
        var patient = new Patient
        {
            Id = "patient-001",
            Active = true
        };

        // deceased[x] 可以是 boolean 或 dateTime
        
        // 方式 1：設定 boolean 值
        patient.DeceasedBoolean = false;
        Console.WriteLine($"Patient is deceased: {patient.DeceasedBoolean}");
        Console.WriteLine($"Deceased type: {patient.DeceasedChoice?.ValueTypeName}");

        // 方式 2：設定 dateTime 值
        patient.DeceasedBoolean = null;  // 清除 boolean 值
        patient.DeceasedDateTime = "2023-01-15";
        Console.WriteLine($"Patient deceased date: {patient.DeceasedDateTime}");

        // 使用 Choice Type 直接設定
        patient.DeceasedChoice = new FhirBoolean(true);
        Console.WriteLine($"Deceased via ChoiceType: {patient.DeceasedChoice?.AsT1()?.Value}");

        // 驗證互斥性
        try
        {
            patient.DeceasedBoolean = false;
            patient.DeceasedDateTime = "2023-01-15";  // 這會清除 boolean 值
            Console.WriteLine($"Boolean after setting DateTime: {patient.DeceasedBoolean}");  // 應該是 null
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    /// <summary>
    /// Observation.value[x] 使用範例
    /// </summary>
    public void ObservationValueChoiceExample()
    {
        var observation = new Observation
        {
            Id = "obs-001",
            Status = "final",
            Code = new CodeableConcept
            {
                Text = "Blood Pressure"
            }
        };

        // value[x] 可以是多種型別：Quantity, CodeableConcept, string, boolean 等

        // 設定 Quantity 值
        observation.ValueQuantity = new QuantityImpl(120, "mmHg");
        Console.WriteLine($"Observation Quantity: {observation.ValueQuantity?.Value} {observation.ValueQuantity?.Unit}");

        // 設定 CodeableConcept 值
        observation.ValueQuantity = null;  // 清除 Quantity
        observation.ValueCodeableConcept = new CodeableConcept
        {
            Text = "Normal"
        };
        Console.WriteLine($"Observation CodeableConcept: {observation.ValueCodeableConcept?.Text}");

        // 設定 string 值
        observation.ValueCodeableConcept = null;  // 清除 CodeableConcept
        observation.ValueString = "Within normal limits";
        Console.WriteLine($"Observation string: {observation.ValueString}");

        // 使用統一的 Value 屬性
        Console.WriteLine($"Observation value (unified): {observation.Value}");
    }

    /// <summary>
    /// Choice Type 驗證範例
    /// </summary>
    public void ChoiceTypeValidationExample()
    {
        var choice = new ChoiceType<FhirString, FhirInteger>();

        // 測試空值驗證
        var validationContext = new ValidationContext(choice);
        var validationResults = choice.Validate(validationContext).ToList();

        Console.WriteLine($"Empty choice validation errors: {validationResults.Count}");
        foreach (var result in validationResults)
        {
            Console.WriteLine($"  Error: {result.ErrorMessage}");
        }

        // 設定有效值
        choice.Value1 = new FhirString("Valid value");
        validationResults = choice.Validate(validationContext).ToList();
        Console.WriteLine($"Valid choice validation errors: {validationResults.Count}");

        // 測試型別檢查
        Console.WriteLine($"Allows string: {choice.IsAllowedType<FhirString>()}");
        Console.WriteLine($"Allows integer: {choice.IsAllowedType<FhirInteger>()}");
        Console.WriteLine($"Allows boolean: {choice.IsAllowedType<FhirBoolean>()}");

        // 測試不允許的型別
        try
        {
            choice.Value = new FhirBoolean(true);  // 這應該拋出異常
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Expected error: {ex.Message}");
        }
    }

    /// <summary>
    /// JSON 序列化範例
    /// </summary>
    public void JsonSerializationExample()
    {
        var extension = new Extension
        {
            Url = "http://example.org/extension",
            ValueString = "test value"
        };

        // 序列化為 JSON
        var json = JsonSerializer.Serialize(extension, new JsonSerializerOptions 
        { 
            WriteIndented = true 
        });
        Console.WriteLine("Serialized Extension:");
        Console.WriteLine(json);

        // 反序列化
        var deserializedExtension = JsonSerializer.Deserialize<Extension>(json);
        Console.WriteLine($"Deserialized value: {deserializedExtension?.ValueString}");

        // 測試不同型別的序列化
        extension.ValueString = null;
        extension.ValueInteger = 42;

        json = JsonSerializer.Serialize(extension, new JsonSerializerOptions 
        { 
            WriteIndented = true 
        });
        Console.WriteLine("Extension with integer value:");
        Console.WriteLine(json);
    }

    /// <summary>
    /// 複雜 Choice Type 範例
    /// </summary>
    public void ComplexChoiceTypeExample()
    {
        // 四型別的 Choice Type
        var complexChoice = new ChoiceType<FhirString, FhirInteger, CodeableConcept, Quantity>();

        // 設定不同型別的值
        complexChoice = "String value";
        Console.WriteLine($"String: {complexChoice.AsT1()?.Value}");

        complexChoice = 123;
        Console.WriteLine($"Integer: {complexChoice.AsT2()?.Value}");

        complexChoice = new CodeableConcept { Text = "Concept" };
        Console.WriteLine($"CodeableConcept: {complexChoice.AsT3()?.Text}");

        complexChoice = new QuantityImpl(10.5m, "kg");
        Console.WriteLine($"Quantity: {complexChoice.AsT4()?.Value} {complexChoice.AsT4()?.Unit}");

        // 檢查允許的型別
        Console.WriteLine("Allowed types:");
        foreach (var type in complexChoice.GetAllowedTypes())
        {
            Console.WriteLine($"  - {type}");
        }
    }

    /// <summary>
    /// Choice Type 最佳實踐範例
    /// </summary>
    public void BestPracticesExample()
    {
        var observation = new Observation();

        // 最佳實踐 1：使用型別安全的方法
        if (observation.ValueChoice?.IsT1() == true)
        {
            var quantity = observation.ValueChoice.AsT1();
            Console.WriteLine($"Quantity value: {quantity?.Value}");
        }

        // 最佳實踐 2：檢查值是否存在
        if (observation.ValueChoice?.HasValue == true)
        {
            Console.WriteLine($"Observation has a value of type: {observation.ValueChoice.ValueTypeName}");
        }

        // 最佳實踐 3：使用 null 檢查
        var stringValue = observation.ValueString;
        if (stringValue != null)
        {
            Console.WriteLine($"String value: {stringValue}");
        }

        // 最佳實踐 4：清除值時設為 null
        observation.ValueString = null;  // 明確清除
        observation.ValueQuantity = new QuantityImpl(100, "mg");  // 設定新值

        // 最佳實踐 5：驗證設定的值
        var validationResults = observation.ValueChoice?.Validate(new ValidationContext(observation.ValueChoice));
        if (validationResults?.Any() == true)
        {
            Console.WriteLine("Validation errors found:");
            foreach (var result in validationResults)
            {
                Console.WriteLine($"  - {result.ErrorMessage}");
            }
        }
    }
}
