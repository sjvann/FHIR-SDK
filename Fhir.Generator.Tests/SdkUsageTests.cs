using System.Text.Json;
using Fhir.R4.Models.DataTypes;
using Fhir.R4.Models.Resources;
using Xunit;

namespace Fhir.Generator.Tests;

/// <summary>
/// 測試生成的程式碼是否能作為 SDK 使用
/// </summary>
public class SdkUsageTests
{
    [Fact]
    public void Patient_ShouldCreate_AndSerialize()
    {
        // Arrange & Act
        var patient = new Patient
        {
            Active = true,
            Gender = "male",
            BirthDate = "1990-01-01"
        };

        // Assert
        Assert.NotNull(patient);
        Assert.True(patient.Active);
        Assert.Equal("male", patient.Gender);
        Assert.Equal("1990-01-01", patient.BirthDate);
        Assert.Equal("Patient", patient.ResourceType);
    }

    [Fact]
    public void Patient_ShouldSerialize_ToJson()
    {
        // Arrange
        var patient = new Patient
        {
            Active = true,
            Gender = "female",
            BirthDate = "1985-12-25"
        };

        // Act
        var json = JsonSerializer.Serialize(patient, new JsonSerializerOptions
        {
            WriteIndented = true,
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
        });

        // Assert
        Assert.NotNull(json);
        Assert.Contains("\"resourceType\": \"Patient\"", json);
        Assert.Contains("\"active\": true", json);
        Assert.Contains("\"gender\": \"female\"", json);
        Assert.Contains("\"birthDate\": \"1985-12-25\"", json);
        
        Console.WriteLine("Generated JSON:");
        Console.WriteLine(json);
    }

    [Fact]
    public void Patient_ShouldDeserialize_FromJson()
    {
        // Arrange
        var json = """
        {
            "resourceType": "Patient",
            "active": true,
            "gender": "male",
            "birthDate": "1990-01-01",
            "name": [
                {
                    "family": "Doe",
                    "given": ["John"]
                }
            ]
        }
        """;

        // Act
        var patient = JsonSerializer.Deserialize<Patient>(json);

        // Assert
        Assert.NotNull(patient);
        Assert.Equal("Patient", patient.ResourceType);
        Assert.True(patient.Active);
        Assert.Equal("male", patient.Gender);
        Assert.Equal("1990-01-01", patient.BirthDate);
    }

    [Fact]
    public void Patient_ShouldValidate_Successfully()
    {
        // Arrange
        var patient = new Patient
        {
            Active = true,
            Gender = "male",
            BirthDate = "1990-01-01"
        };

        // Act
        var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(patient);
        var validationResults = patient.Validate(validationContext).ToList();

        // Assert
        Assert.Empty(validationResults); // 應該沒有驗證錯誤
    }

    [Fact]
    public void Patient_ShouldValidate_InvalidGender()
    {
        // Arrange
        var patient = new Patient
        {
            Gender = "invalid_gender" // 無效的 gender 值
        };

        // Act
        var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(patient);
        var validationResults = patient.Validate(validationContext).ToList();

        // Assert
        Assert.NotEmpty(validationResults); // 應該有驗證錯誤
        Assert.Contains(validationResults, vr => vr.ErrorMessage!.Contains("gender"));
    }

    [Fact]
    public void Organization_ShouldCreate_AndWork()
    {
        // Arrange & Act
        var organization = new Organization
        {
            Active = true,
            Name = "Test Hospital"
        };

        // Assert
        Assert.NotNull(organization);
        Assert.True(organization.Active);
        Assert.Equal("Test Hospital", organization.Name);
        Assert.Equal("Organization", organization.ResourceType);
    }

    [Fact]
    public void FhirPrimitiveTypes_ShouldWork_Correctly()
    {
        // 測試我們的 FHIR Primitive Types 是否正常工作
        // 注意：這個測試可能會失敗，因為當前的 Patient 使用 string? 而不是 FhirString?
        
        // Arrange
        var fhirString = new FhirString("test value");
        var fhirBoolean = new FhirBoolean(true);
        var fhirDate = new FhirDate("2023-01-01");

        // Act & Assert
        Assert.Equal("test value", fhirString.Value);
        Assert.True(fhirBoolean.Value);
        Assert.Equal("2023-01-01", fhirDate.Value);
        
        // 測試隱式轉換
        FhirString? implicitString = "converted value";
        Assert.Equal("converted value", implicitString?.Value);
        
        string? backToString = implicitString;
        Assert.Equal("converted value", backToString);
    }
}
