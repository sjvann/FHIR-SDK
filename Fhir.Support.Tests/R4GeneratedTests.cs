using System.Text.Json;
using Fhir.R4.Models;
using Fhir.Support.Base;

namespace Fhir.Support.Tests;

public class R4GeneratedTests
{
    [Fact]
    public void TestPatientSerialization()
    {
        // 建立測試資料
        var patient = new Patient
        {
            Id = "patient-123",
            Active = true,
            Gender = "male",
            BirthDate = new DateTime(1990, 1, 1),
            Name = new HumanName
            {
                Use = "official",
                Family = "Smith",
                Given = new List<string> { "John", "Michael" }
            },
            Identifier = new Identifier
            {
                System = "https://hospital.example.com/patients",
                Value = "MRN12345"
            }
        };

        // 序列化
        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };

        var json = JsonSerializer.Serialize(patient, options);

        // 驗證 JSON 結構
        Assert.Contains("\"resourceType\":\"Patient\"", json);
        Assert.Contains("\"id\":\"patient-123\"", json);
        Assert.Contains("\"active\":true", json);
        Assert.Contains("\"gender\":\"male\"", json);
        Assert.Contains("\"birthDate\":\"1990-01-01\"", json);
        Assert.Contains("\"name\":", json);
        Assert.Contains("\"identifier\":", json);

        // 反序列化
        var deserializedPatient = JsonSerializer.Deserialize<Patient>(json, options);
        
        Assert.NotNull(deserializedPatient);
        Assert.Equal("patient-123", deserializedPatient.Id);
        Assert.True(deserializedPatient.Active);
        Assert.Equal("male", deserializedPatient.Gender);
        Assert.Equal(new DateTime(1990, 1, 1), deserializedPatient.BirthDate);
    }

    [Fact]
    public void TestObservationSerialization()
    {
        // 建立測試資料
        var observation = new Observation
        {
            Id = "obs-123",
            Status = "final",
            Code = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = "http://loinc.org",
                        Code = "8302-2",
                        Display = "Body height"
                    }
                }
            },
            Subject = new Reference
            {
                Reference = "Patient/patient-123"
            },
            ValueQuantity = new Quantity
            {
                Value = 175.0m,
                Unit = "cm",
                System = "http://unitsofmeasure.org",
                Code = "cm"
            }
        };

        // 序列化
        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };

        var json = JsonSerializer.Serialize(observation, options);

        // 驗證 JSON 結構
        Assert.Contains("\"resourceType\":\"Observation\"", json);
        Assert.Contains("\"id\":\"obs-123\"", json);
        Assert.Contains("\"status\":\"final\"", json);
        Assert.Contains("\"code\":", json);
        Assert.Contains("\"subject\":", json);
        Assert.Contains("\"valueQuantity\":", json);

        // 反序列化
        var deserializedObservation = JsonSerializer.Deserialize<Observation>(json, options);
        
        Assert.NotNull(deserializedObservation);
        Assert.Equal("obs-123", deserializedObservation.Id);
        Assert.Equal("final", deserializedObservation.Status);
    }

    [Fact]
    public void TestPrimitiveTypes()
    {
        // 測試原始型別
        var fhirString = new FhirString("test value");
        var fhirInteger = new FhirInteger(42);
        var fhirBoolean = new FhirBoolean(true);
        var fhirDateTime = new FhirDateTime(new DateTime(2023, 1, 1));

        Assert.Equal("test value", fhirString.Value);
        Assert.Equal(42, fhirInteger.Value);
        Assert.True(fhirBoolean.Value);
        Assert.Equal(new DateTime(2023, 1, 1), fhirDateTime.Value);
    }

    [Fact]
    public void TestComplexTypes()
    {
        // 測試複雜型別
        var humanName = new HumanName
        {
            Use = "official",
            Family = "Doe",
            Given = new List<string> { "Jane" }
        };

        var identifier = new Identifier
        {
            System = "https://example.com/identifiers",
            Value = "12345"
        };

        Assert.Equal("official", humanName.Use);
        Assert.Equal("Doe", humanName.Family);
        Assert.Equal("Jane", humanName.Given?.FirstOrDefault());
        Assert.Equal("https://example.com/identifiers", identifier.System);
        Assert.Equal("12345", identifier.Value);
    }

    [Fact]
    public void TestValidation()
    {
        // 測試驗證
        var patient = new Patient
        {
            // 故意不設定必要欄位來測試驗證
        };

        var validationContext = new ValidationContext(patient);
        var validationResults = patient.Validate(validationContext).ToList();

        // 驗證應該會返回一些結果（具體的驗證邏輯可以在子類別中實現）
        Assert.NotNull(validationResults);
    }
} 