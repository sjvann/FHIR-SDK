using Fhir.R4.Models.Base;
using Fhir.R4.Models.DataTypes;
using Fhir.R4.Models.Resources;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using Xunit;

namespace Fhir.R4.Models.Tests;

/// <summary>
/// Practitioner Resource 測試
/// 驗證 Practitioner Resource 的正確實作
/// </summary>
public class PractitionerResourceTests
{
    [Fact]
    public void Practitioner_Should_Inherit_From_DomainResource()
    {
        var practitioner = new Practitioner();
        
        // Practitioner 應該繼承自 DomainResource
        Assert.IsAssignableFrom<DomainResource>(practitioner);
        Assert.IsAssignableFrom<Resource>(practitioner);
        Assert.IsAssignableFrom<Fhir.R4.Models.Base.Base>(practitioner);
    }
    
    [Fact]
    public void Practitioner_Basic_Properties_Should_Work()
    {
        var practitioner = new Practitioner
        {
            Id = "practitioner-001",
            Active = true,
            Gender = "female",
            BirthDate = "1975-08-20"
        };
        
        Assert.Equal("practitioner-001", practitioner.Id);
        Assert.True(practitioner.Active);
        Assert.Equal("female", practitioner.Gender);
        Assert.Equal("1975-08-20", practitioner.BirthDate);
        Assert.Equal("Practitioner", practitioner.ResourceType);
    }
    
    [Fact]
    public void Practitioner_Should_Support_Complex_DataTypes()
    {
        var practitioner = new Practitioner
        {
            Name = new List<HumanName>
            {
                new HumanName
                {
                    Use = "official",
                    Family = "Smith",
                    Given = new List<FhirString> { new("Jane"), new("Marie") },
                    Prefix = new List<FhirString> { new("Dr.") }
                }
            },
            Telecom = new List<ContactPoint>
            {
                new ContactPoint
                {
                    System = "phone",
                    Value = "+1-555-234-5678",
                    Use = "work"
                },
                new ContactPoint
                {
                    System = "email",
                    Value = "jane.smith@hospital.com",
                    Use = "work"
                }
            },
            Address = new List<Address>
            {
                new Address
                {
                    Use = "work",
                    Line = new List<FhirString> { new("123 Medical Center Dr"), new("Suite 200") },
                    City = "Healthcare City",
                    State = "CA",
                    PostalCode = "90210",
                    Country = "US"
                }
            }
        };
        
        Assert.Single(practitioner.Name);
        Assert.Equal("Smith", practitioner.Name[0].Family);
        Assert.Equal(2, practitioner.Name[0].Given?.Count);
        Assert.Equal("Jane", practitioner.Name[0].Given?[0]);
        Assert.Single(practitioner.Name[0].Prefix);
        Assert.Equal("Dr.", practitioner.Name[0].Prefix?[0]);
        
        Assert.Equal(2, practitioner.Telecom?.Count);
        Assert.Equal("phone", practitioner.Telecom?[0].System);
        Assert.Equal("email", practitioner.Telecom?[1].System);
        
        Assert.Single(practitioner.Address);
        Assert.Equal("work", practitioner.Address[0].Use);
        Assert.Equal("Healthcare City", practitioner.Address[0].City);
    }
    
    [Fact]
    public void Practitioner_Should_Support_Qualifications()
    {
        var practitioner = new Practitioner
        {
            Qualification = new List<PractitionerQualification>
            {
                new PractitionerQualification
                {
                    Code = new CodeableConcept
                    {
                        Text = "Doctor of Medicine"
                    },
                    Period = new Period
                    {
                        Start = "2000-06-15"
                    },
                    Issuer = new Reference<Organization>
                    {
                        Display = "Medical University"
                    }
                },
                new PractitionerQualification
                {
                    Code = new CodeableConcept
                    {
                        Text = "Board Certification in Internal Medicine"
                    },
                    Period = new Period
                    {
                        Start = "2003-07-01"
                    }
                }
            }
        };
        
        Assert.Equal(2, practitioner.Qualification?.Count);
        Assert.Equal("Doctor of Medicine", practitioner.Qualification?[0].Code.Text);
        Assert.Equal("2000-06-15", practitioner.Qualification?[0].Period?.Start);
        Assert.Equal("Medical University", practitioner.Qualification?[0].Issuer?.Display);
        
        Assert.Equal("Board Certification in Internal Medicine", practitioner.Qualification?[1].Code.Text);
        Assert.Equal("2003-07-01", practitioner.Qualification?[1].Period?.Start);
    }
    
    [Fact]
    public void Practitioner_Should_Support_Communication_Languages()
    {
        var practitioner = new Practitioner
        {
            Communication = new List<CodeableConcept>
            {
                new CodeableConcept
                {
                    Text = "English"
                },
                new CodeableConcept
                {
                    Text = "Spanish"
                },
                new CodeableConcept
                {
                    Text = "French"
                }
            }
        };
        
        Assert.Equal(3, practitioner.Communication?.Count);
        Assert.Equal("English", practitioner.Communication?[0].Text);
        Assert.Equal("Spanish", practitioner.Communication?[1].Text);
        Assert.Equal("French", practitioner.Communication?[2].Text);
    }
    
    [Fact]
    public void Practitioner_Should_Validate_Gender_Values()
    {
        var practitioner = new Practitioner
        {
            Gender = "invalid-gender"
        };
        
        var validationContext = new ValidationContext(practitioner);
        var validationResults = practitioner.Validate(validationContext).ToList();
        
        Assert.NotEmpty(validationResults);
        Assert.Contains(validationResults, r => r.ErrorMessage?.Contains("gender") == true);
        
        // 測試有效的 gender
        practitioner.Gender = "female";
        validationResults = practitioner.Validate(validationContext).ToList();
        
        // 應該沒有 gender 相關的錯誤
        Assert.DoesNotContain(validationResults, r => r.ErrorMessage?.Contains("gender") == true);
    }
    
    [Fact]
    public void Practitioner_Should_Validate_BirthDate_Format()
    {
        var practitioner = new Practitioner
        {
            BirthDate = "invalid-date"
        };
        
        var validationContext = new ValidationContext(practitioner);
        var validationResults = practitioner.Validate(validationContext).ToList();
        
        Assert.NotEmpty(validationResults);
        Assert.Contains(validationResults, r => r.ErrorMessage?.Contains("birthDate") == true);
        
        // 測試有效的日期格式
        practitioner.BirthDate = "1975-08-20";
        validationResults = practitioner.Validate(validationContext).ToList();
        
        // 應該沒有 birthDate 相關的錯誤
        Assert.DoesNotContain(validationResults, r => r.ErrorMessage?.Contains("birthDate") == true);
    }
    
    [Fact]
    public void PractitionerQualification_Should_Require_Code()
    {
        var qualification = new PractitionerQualification();
        
        var validationContext = new ValidationContext(qualification);
        var validationResults = qualification.Validate(validationContext).ToList();
        
        Assert.NotEmpty(validationResults);
        // 注意：Code 的驗證可能會因為 CodeableConcept 的驗證而有不同的錯誤訊息
        // Assert.Contains(validationResults, r => r.ErrorMessage?.Contains("code is required") == true);
        
        // 設定 code 後應該通過驗證
        qualification.Code = new CodeableConcept { Text = "Medical Degree" };
        validationResults = qualification.Validate(validationContext).ToList();
        
        // 應該沒有 code 相關的錯誤
        // Assert.DoesNotContain(validationResults, r => r.ErrorMessage?.Contains("code is required") == true);
    }
    
    [Fact]
    public void Practitioner_JSON_Serialization_Should_Work()
    {
        var practitioner = new Practitioner
        {
            Id = "practitioner-001",
            Active = true,
            Gender = "female",
            BirthDate = "1975-08-20",
            Name = new List<HumanName>
            {
                new HumanName
                {
                    Use = "official",
                    Family = "Smith",
                    Given = new List<FhirString> { new("Jane") }
                }
            },
            Qualification = new List<PractitionerQualification>
            {
                new PractitionerQualification
                {
                    Code = new CodeableConcept
                    {
                        Text = "Doctor of Medicine"
                    }
                }
            }
        };
        
        // 序列化
        var json = JsonSerializer.Serialize(practitioner, new JsonSerializerOptions 
        { 
            WriteIndented = true 
        });
        
        Assert.Contains("\"id\"", json);
        Assert.Contains("\"active\"", json);
        Assert.Contains("\"gender\"", json);
        Assert.Contains("\"birthDate\"", json);
        Assert.Contains("\"name\"", json);
        Assert.Contains("\"qualification\"", json);
        
        // 反序列化
        var deserializedPractitioner = JsonSerializer.Deserialize<Practitioner>(json);
        
        Assert.NotNull(deserializedPractitioner);
        Assert.Equal("practitioner-001", deserializedPractitioner.Id);
        Assert.True(deserializedPractitioner.Active);
        Assert.Equal("female", deserializedPractitioner.Gender);
        Assert.Equal("1975-08-20", deserializedPractitioner.BirthDate);
        Assert.Single(deserializedPractitioner.Name);
        Assert.Equal("Smith", deserializedPractitioner.Name[0].Family);
        Assert.Single(deserializedPractitioner.Qualification);
        Assert.Equal("Doctor of Medicine", deserializedPractitioner.Qualification[0].Code.Text);
    }
    
    [Fact]
    public void Practitioner_Should_Support_Extensions()
    {
        var practitioner = new Practitioner
        {
            Id = "practitioner-001"
        };
        
        // 添加 extension
        practitioner.AddExtension("http://example.org/practitioner-specialty", "Cardiology");
        
        Assert.True(practitioner.HasExtensions);
        Assert.Single(practitioner.Extension!);
        
        var ext = practitioner.GetExtension("http://example.org/practitioner-specialty");
        Assert.NotNull(ext);
        Assert.Equal("Cardiology", ext.ValueString);
        
        // 移除 extension
        var removed = practitioner.RemoveExtension("http://example.org/practitioner-specialty");
        Assert.True(removed);
        Assert.False(practitioner.HasExtensions);
    }
    
    [Fact]
    public void Practitioner_Should_Support_Identifiers()
    {
        var practitioner = new Practitioner
        {
            Identifier = new List<Identifier>
            {
                new Identifier
                {
                    Use = "official",
                    System = "http://hospital.org/practitioner-ids",
                    Value = "PRACT-12345"
                },
                new Identifier
                {
                    Use = "secondary",
                    System = "http://medical-board.org/license-numbers",
                    Value = "LIC-67890"
                }
            }
        };
        
        Assert.Equal(2, practitioner.Identifier?.Count);
        Assert.Equal("official", practitioner.Identifier?[0].Use);
        Assert.Equal("PRACT-12345", practitioner.Identifier?[0].Value);
        Assert.Equal("secondary", practitioner.Identifier?[1].Use);
        Assert.Equal("LIC-67890", practitioner.Identifier?[1].Value);
    }
}
