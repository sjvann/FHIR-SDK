using Xunit;
using Fhir.Support;
using Fhir.R5.Models;
using System.Text.Json;

namespace Fhir.Tests;

/// <summary>
/// 測試序列化功能
/// </summary>
public class SerializationTests
{
    [Fact]
    public void Patient_BasicSerialization_ShouldWork()
    {
        // Arrange
        var patient = new Patient
        {
            Id = "patient-123",
            Active = true
        };

        // 添加姓名
        patient.Name = new List<HumanName>
        {
            new HumanName
            {
                Use = "official",
                Family = "Doe",
                Given = new List<string> { "John", "William" }
            }
        };

        // Act - 使用 System.Text.Json 進行基本序列化測試
        var json = JsonSerializer.Serialize(patient, new JsonSerializerOptions 
        { 
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        // Assert
        Assert.NotNull(json);
        Assert.Contains("patient-123", json);
        Assert.Contains("John", json);
        Assert.Contains("Doe", json);
    }

    [Fact]
    public void Observation_ChoiceTypes_ShouldSerializeCorrectly()
    {
        // Arrange
        var observation = new Observation
        {
            Id = "obs-123",
            Status = "final",
            Code = new CodeableConcept
            {
                Text = "Blood Pressure"
            }
        };

        // 設定 Choice Type - 只能設定一個 value[x] 屬性
        observation.ValueQuantity = new Quantity
        {
            Value = 120,
            Unit = "mmHg",
            System = "http://unitsofmeasure.org",
            Code = "mm[Hg]"
        };

        // 設定 effective[x] - 使用 DateTime
        observation.EffectiveDateTime = new FhirDateTime
        {
            Value = DateTime.Now
        };

        // Act
        var json = JsonSerializer.Serialize(observation, new JsonSerializerOptions 
        { 
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        // Assert
        Assert.NotNull(json);
        Assert.Contains("obs-123", json);
        Assert.Contains("final", json);
        Assert.Contains("Blood Pressure", json);
        Assert.Contains("120", json);
        Assert.Contains("mmHg", json);
    }

    [Fact]
    public void Reference_StrongTyping_ShouldWork()
    {
        // Arrange
        var observation = new Observation
        {
            Id = "obs-456",
            Status = "final"
        };

        // 使用強型別 Reference
        observation.Subject = new Reference<Patient>
        {
            Reference = "Patient/patient-123",
            Display = "John Doe"
        };

        // Act
        var json = JsonSerializer.Serialize(observation, new JsonSerializerOptions 
        { 
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        // Assert
        Assert.NotNull(json);
        Assert.Contains("Patient/patient-123", json);
        Assert.Contains("John Doe", json);
    }

    [Fact]
    public void CodeableConcept_Enhancement_ShouldWork()
    {
        // Arrange
        var concept = new CodeableConcept();

        // 使用增強方法添加編碼
        concept.AddCoding("http://snomed.info/sct", "271649006", "Systolic blood pressure")
               .AddCoding("http://loinc.org", "8480-6", "Systolic blood pressure");

        concept.Text = "Systolic BP";

        // Act
        var json = JsonSerializer.Serialize(concept, new JsonSerializerOptions 
        { 
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        // Assert
        Assert.NotNull(json);
        Assert.Contains("snomed.info", json);
        Assert.Contains("271649006", json);
        Assert.Contains("loinc.org", json);
        Assert.Contains("8480-6", json);
        Assert.Contains("Systolic BP", json);

        // 測試增強方法
        Assert.True(concept.HasCoding("http://snomed.info/sct", "271649006"));
        Assert.True(concept.HasCodingFromSystem("http://loinc.org"));
        Assert.Equal("Systolic BP", concept.GetDisplayText());
    }

    [Fact]
    public void ChoiceType_Validation_ShouldWork()
    {
        // Arrange
        var observation = new Observation
        {
            Id = "obs-validation",
            Status = "final",
            Code = new CodeableConcept { Text = "Test" }
        };

        // 設定多個 value[x] 屬性（這應該會失敗驗證）
        observation.ValueQuantity = new Quantity { Value = 120 };
        observation.ValueString = "Test Value";

        // Act
        var context = new System.ComponentModel.DataAnnotations.ValidationContext(observation);
        var results = observation.Validate(context).ToList();

        // Assert
        // 應該有 Choice Type 驗證錯誤
        Assert.Contains(results, r => r.ErrorMessage?.Contains("Only one of") == true);
    }

    [Fact]
    public void Patient_ComplexStructure_ShouldSerialize()
    {
        // Arrange - 創建一個複雜的 Patient 結構
        var patient = new Patient
        {
            Id = "complex-patient",
            Active = true,
            Name = new List<HumanName>
            {
                new HumanName
                {
                    Use = "official",
                    Family = "Smith",
                    Given = new List<string> { "Jane", "Marie" },
                    Prefix = new List<string> { "Dr." }
                }
            },
            Telecom = new List<ContactPoint>
            {
                new ContactPoint
                {
                    System = "phone",
                    Value = "+1-555-123-4567",
                    Use = "home"
                },
                new ContactPoint
                {
                    System = "email",
                    Value = "jane.smith@example.com",
                    Use = "work"
                }
            },
            Gender = "female",
            BirthDate = "1985-03-15",
            Address = new List<Address>
            {
                new Address
                {
                    Use = "home",
                    Type = "physical",
                    Line = new List<string> { "123 Main St", "Apt 4B" },
                    City = "Anytown",
                    State = "CA",
                    PostalCode = "12345",
                    Country = "US"
                }
            }
        };

        // Act
        var json = JsonSerializer.Serialize(patient, new JsonSerializerOptions 
        { 
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        // Assert
        Assert.NotNull(json);
        Assert.Contains("complex-patient", json);
        Assert.Contains("Jane", json);
        Assert.Contains("Smith", json);
        Assert.Contains("Dr.", json);
        Assert.Contains("+1-555-123-4567", json);
        Assert.Contains("jane.smith@example.com", json);
        Assert.Contains("female", json);
        Assert.Contains("1985-03-15", json);
        Assert.Contains("123 Main St", json);
        Assert.Contains("Anytown", json);
    }
}
