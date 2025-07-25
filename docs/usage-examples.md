# SDK 使用範例

本文檔提供 FHIR SDK 的詳細使用範例，涵蓋常見的使用場景和最佳實務。

## 🎯 快速開始

### 安裝套件

```bash
# 安裝基礎套件
dotnet add package Fhir.Support
dotnet add package Fhir.Abstractions

# 選擇 FHIR 版本（二選一）
dotnet add package Fhir.R4.Models    # FHIR R4
dotnet add package Fhir.R5.Models    # FHIR R5
```

### 基本設定

```csharp
// Program.cs
using Fhir.R4.Models.Resources;  // 使用 R4
// using Fhir.R5.Models.Resources;  // 或使用 R5

// 由於有 Global Using，可以直接使用
var patient = new Patient();
var observation = new Observation();
```

## 📋 基本範例

### 1. 建立 Patient 資源

```csharp
using Fhir.R4.Models.Resources;
using Fhir.R4.Models.DataTypes;

// 建立基本 Patient
var patient = new Patient
{
    Id = "patient-001",
    Active = true,
    Gender = "male",
    BirthDate = "1990-01-15"
};

// 添加姓名
patient.Name = new List<HumanName>
{
    new HumanName
    {
        Use = "official",
        Family = "王",
        Given = new List<string> { "小明" }
    }
};

// 添加聯絡資訊
patient.Telecom = new List<ContactPoint>
{
    new ContactPoint
    {
        System = "phone",
        Value = "+886-2-1234-5678",
        Use = "home"
    },
    new ContactPoint
    {
        System = "email",
        Value = "wang.xiaoming@example.com",
        Use = "work"
    }
};

// 添加地址
patient.Address = new List<Address>
{
    new Address
    {
        Use = "home",
        Type = "physical",
        Line = new List<string> { "台北市信義區信義路五段7號" },
        City = "台北市",
        PostalCode = "110",
        Country = "TW"
    }
};

Console.WriteLine($"建立 Patient: {patient.Id}");
Console.WriteLine($"姓名: {patient.Name?.FirstOrDefault()?.Family} {string.Join(" ", patient.Name?.FirstOrDefault()?.Given ?? new List<string>())}");
```

### 2. 建立 Observation 資源

```csharp
using Fhir.R4.Models.Resources;
using Fhir.R4.Models.DataTypes;

// 建立血壓觀察
var bloodPressure = new Observation
{
    Id = "bp-001",
    Status = "final",
    Category = new List<CodeableConcept>
    {
        new CodeableConcept
        {
            Coding = new List<Coding>
            {
                new Coding
                {
                    System = "http://terminology.hl7.org/CodeSystem/observation-category",
                    Code = "vital-signs",
                    Display = "Vital Signs"
                }
            }
        }
    },
    Code = new CodeableConcept
    {
        Coding = new List<Coding>
        {
            new Coding
            {
                System = "http://loinc.org",
                Code = "85354-9",
                Display = "Blood pressure panel with all children optional"
            }
        }
    },
    Subject = new Reference("Patient/patient-001"),
    EffectiveDateTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssZ"),
    Component = new List<object>  // 簡化版本，實際應使用正確的型別
    {
        // 收縮壓
        new
        {
            code = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = "http://loinc.org",
                        Code = "8480-6",
                        Display = "Systolic blood pressure"
                    }
                }
            },
            valueQuantity = new Quantity
            {
                Value = 120,
                Unit = "mmHg",
                System = "http://unitsofmeasure.org",
                Code = "mm[Hg]"
            }
        },
        // 舒張壓
        new
        {
            code = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = "http://loinc.org",
                        Code = "8462-4",
                        Display = "Diastolic blood pressure"
                    }
                }
            },
            valueQuantity = new Quantity
            {
                Value = 80,
                Unit = "mmHg",
                System = "http://unitsofmeasure.org",
                Code = "mm[Hg]"
            }
        }
    }
};

Console.WriteLine($"建立 Observation: {bloodPressure.Id}");
Console.WriteLine($"狀態: {bloodPressure.Status}");
Console.WriteLine($"受檢者: {bloodPressure.Subject?.Reference}");
```

### 3. 建立 Practitioner 資源

```csharp
using Fhir.R4.Models.Resources;
using Fhir.R4.Models.DataTypes;

var practitioner = new Practitioner
{
    Id = "dr-001",
    Active = true,
    Name = new List<HumanName>
    {
        new HumanName
        {
            Use = "official",
            Prefix = new List<string> { "Dr." },
            Family = "李",
            Given = new List<string> { "大華" }
        }
    },
    Telecom = new List<ContactPoint>
    {
        new ContactPoint
        {
            System = "phone",
            Value = "+886-2-8765-4321",
            Use = "work"
        }
    },
    Gender = "male",
    BirthDate = "1975-03-20",
    Qualification = new List<object>  // 簡化版本
    {
        new
        {
            code = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = "http://terminology.hl7.org/CodeSystem/v2-0360",
                        Code = "MD",
                        Display = "Doctor of Medicine"
                    }
                }
            },
            period = new Period
            {
                Start = "2000-06-01"
            },
            issuer = new Reference("Organization/medical-university")
        }
    }
};

Console.WriteLine($"建立 Practitioner: {practitioner.Id}");
Console.WriteLine($"姓名: Dr. {practitioner.Name?.FirstOrDefault()?.Family} {string.Join(" ", practitioner.Name?.FirstOrDefault()?.Given ?? new List<string>())}");
```

## 🏥 進階範例

### 1. 建立完整的就診記錄

```csharp
using Fhir.R4.Models.Resources;
using Fhir.R4.Models.DataTypes;

// 建立就診記錄
var encounter = new Encounter
{
    Id = "encounter-001",
    Status = "finished",
    Class = new Coding
    {
        System = "http://terminology.hl7.org/CodeSystem/v3-ActCode",
        Code = "AMB",
        Display = "ambulatory"
    },
    Type = new List<CodeableConcept>
    {
        new CodeableConcept
        {
            Coding = new List<Coding>
            {
                new Coding
                {
                    System = "http://snomed.info/sct",
                    Code = "185349003",
                    Display = "Encounter for check up"
                }
            }
        }
    },
    Subject = new Reference("Patient/patient-001"),
    Participant = new List<object>  // 簡化版本
    {
        new
        {
            type = new List<CodeableConcept>
            {
                new CodeableConcept
                {
                    Coding = new List<Coding>
                    {
                        new Coding
                        {
                            System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType",
                            Code = "PPRF",
                            Display = "primary performer"
                        }
                    }
                }
            },
            individual = new Reference("Practitioner/dr-001")
        }
    },
    Period = new Period
    {
        Start = "2024-01-15T09:00:00Z",
        End = "2024-01-15T09:30:00Z"
    },
    ReasonCode = new List<CodeableConcept>
    {
        new CodeableConcept
        {
            Coding = new List<Coding>
            {
                new Coding
                {
                    System = "http://snomed.info/sct",
                    Code = "410620009",
                    Display = "Well child visit"
                }
            }
        }
    }
};

Console.WriteLine($"建立 Encounter: {encounter.Id}");
Console.WriteLine($"就診類型: {encounter.Class?.Display}");
Console.WriteLine($"就診期間: {encounter.Period?.Start} - {encounter.Period?.End}");
```

### 2. 建立藥物處方

```csharp
using Fhir.R4.Models.Resources;
using Fhir.R4.Models.DataTypes;

// 建立藥物資源
var medication = new Medication
{
    Id = "med-001",
    Code = new CodeableConcept
    {
        Coding = new List<Coding>
        {
            new Coding
            {
                System = "http://www.nlm.nih.gov/research/umls/rxnorm",
                Code = "313782",
                Display = "Acetaminophen 325 MG Oral Tablet"
            }
        }
    },
    Form = new CodeableConcept
    {
        Coding = new List<Coding>
        {
            new Coding
            {
                System = "http://snomed.info/sct",
                Code = "385055001",
                Display = "Tablet dose form"
            }
        }
    }
};

// 建立處方
var medicationRequest = new MedicationRequest
{
    Id = "prescription-001",
    Status = "active",
    Intent = "order",
    MedicationReference = new Reference($"Medication/{medication.Id}"),
    Subject = new Reference("Patient/patient-001"),
    Encounter = new Reference("Encounter/encounter-001"),
    AuthoredOn = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssZ"),
    Requester = new Reference("Practitioner/dr-001"),
    DosageInstruction = new List<object>  // 簡化版本
    {
        new
        {
            text = "Take 1-2 tablets every 4-6 hours as needed for pain",
            timing = new
            {
                repeat = new
                {
                    frequency = 1,
                    period = 4,
                    periodUnit = "h",
                    asNeededBoolean = true
                }
            },
            route = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = "http://snomed.info/sct",
                        Code = "26643006",
                        Display = "Oral route"
                    }
                }
            },
            doseAndRate = new List<object>
            {
                new
                {
                    doseRange = new Range
                    {
                        Low = new Quantity { Value = 1, Unit = "tablet" },
                        High = new Quantity { Value = 2, Unit = "tablet" }
                    }
                }
            }
        }
    }
};

Console.WriteLine($"建立 Medication: {medication.Id}");
Console.WriteLine($"建立 MedicationRequest: {medicationRequest.Id}");
Console.WriteLine($"處方狀態: {medicationRequest.Status}");
```

## 🔄 版本切換範例

### 從 R4 切換到 R5

```csharp
// 原本的 R4 程式碼
// using Fhir.R4.Models.Resources;

// 切換到 R5 只需要改變 using
using Fhir.R5.Models.Resources;

// 程式碼保持不變！
var patient = new Patient
{
    Id = "patient-001",
    Active = true,
    Gender = "male"
};

// R5 可能有新的屬性
// patient.SomeNewR5Property = "value";
```

### 使用介面進行版本無關程式設計

```csharp
using Fhir.Abstractions.Resources;

// 使用介面，版本無關
public void ProcessPatient(IPatient patient)
{
    Console.WriteLine($"Processing patient: {patient.Id}");
    Console.WriteLine($"Active: {patient.Active}");
    Console.WriteLine($"Gender: {patient.Gender}");
}

// 可以傳入任何版本的 Patient
var r4Patient = new Fhir.R4.Models.Resources.Patient { Id = "r4-001" };
var r5Patient = new Fhir.R5.Models.Resources.Patient { Id = "r5-001" };

ProcessPatient(r4Patient);  // 正常運作
ProcessPatient(r5Patient);  // 正常運作
```

## 🧪 測試範例

### 單元測試

```csharp
using Xunit;
using Fhir.R4.Models.Resources;
using Fhir.R4.Models.DataTypes;

public class PatientTests
{
    [Fact]
    public void Patient_ShouldHaveCorrectResourceType()
    {
        // Arrange & Act
        var patient = new Patient();
        
        // Assert
        Assert.Equal("Patient", patient.ResourceType);
    }
    
    [Fact]
    public void Patient_ShouldValidateRequiredFields()
    {
        // Arrange
        var patient = new Patient
        {
            Id = "test-001",
            Active = true
        };
        
        // Act
        var validationResults = patient.Validate(new ValidationContext(patient));
        
        // Assert
        Assert.Empty(validationResults);
    }
    
    [Fact]
    public void Patient_ShouldSerializeToJson()
    {
        // Arrange
        var patient = new Patient
        {
            Id = "test-001",
            Active = true,
            Gender = "male"
        };
        
        // Act
        var json = JsonSerializer.Serialize(patient);
        
        // Assert
        Assert.Contains("\"resourceType\":\"Patient\"", json);
        Assert.Contains("\"id\":\"test-001\"", json);
        Assert.Contains("\"active\":true", json);
    }
}
```

### 整合測試

```csharp
using Microsoft.Extensions.DependencyInjection;
using Fhir.R4.Models.Resources;

public class FhirIntegrationTests
{
    [Fact]
    public async Task ShouldCreateAndRetrievePatient()
    {
        // Arrange
        var services = new ServiceCollection();
        services.AddFhirServices();  // 假設的擴充方法
        var provider = services.BuildServiceProvider();
        
        var fhirClient = provider.GetRequiredService<IFhirClient>();
        
        var patient = new Patient
        {
            Id = "integration-test-001",
            Active = true,
            Gender = "female"
        };
        
        // Act
        await fhirClient.CreateAsync(patient);
        var retrieved = await fhirClient.ReadAsync<Patient>(patient.Id);
        
        // Assert
        Assert.NotNull(retrieved);
        Assert.Equal(patient.Id, retrieved.Id);
        Assert.Equal(patient.Active, retrieved.Active);
        Assert.Equal(patient.Gender, retrieved.Gender);
    }
}
```

## 🔗 相關文件

- [安裝指南](installation.md)
- [版本切換指南](version-switching.md)
- [API 參考](api/README.md)
- [最佳實務](best-practices.md)
