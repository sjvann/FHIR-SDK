# 🚀 FHIR SDK 快速入門指南

本指南將幫助您在 5 分鐘內開始使用 FHIR SDK。

## 📦 安裝

### 使用 NuGet Package Manager

```bash
dotnet add package FhirCore
dotnet add package DataTypeServices
dotnet add package ResourceTypeServices
```

### 使用 Package Manager Console

```powershell
Install-Package FhirCore
Install-Package DataTypeServices
Install-Package ResourceTypeServices
```

## 🏥 基本範例

### 1. 建立 Patient 資源

```csharp
using ResourceTypeServices.R5;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;

var patient = new Patient
{
    Id = "patient-001",
    Active = true,
    Name = new List<HumanName>
    {
        new HumanName
        {
            Use = NameUse.Official,
            Family = "張",
            Given = new List<FhirString> 
            { 
                new FhirString("小明") 
            }
        }
    },
    Gender = AdministrativeGender.Male,
    BirthDate = new Date(1990, 5, 15),
    Telecom = new List<ContactPoint>
    {
        new ContactPoint
        {
            System = ContactPointSystem.Phone,
            Value = "+886-2-1234-5678",
            Use = ContactPointUse.Home
        },
        new ContactPoint
        {
            System = ContactPointSystem.Email,
            Value = "zhang.xiaoming@example.com",
            Use = ContactPointUse.Work
        }
    }
};
```

### 2. 建立 Observation 資源

```csharp
using ResourceTypeServices.R5;
using DataTypeServices.DataTypes.ComplexTypes;

var observation = new Observation
{
    Id = "obs-weight-001",
    Status = ObservationStatus.Final,
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
                Code = "29463-7",
                Display = "Body Weight"
            }
        }
    },
    Subject = new Reference("Patient/patient-001"),
    EffectiveDateTime = new FhirDateTime(DateTime.Now),
    ValueQuantity = new Quantity
    {
        Value = 70.5m,
        Unit = "kg",
        System = "http://unitsofmeasure.org",
        Code = "kg"
    }
};
```

### 3. 使用建構器模式

```csharp
using DataTypeServices.Builders;

var address = new AddressBuilder()
    .SetUse(AddressUse.Home)
    .SetType(AddressType.Physical)
    .AddLine("台北市信義區信義路五段7號")
    .SetCity("台北市")
    .SetDistrict("信義區")
    .SetPostalCode("11049")
    .SetCountry("台灣")
    .Build();

var humanName = new HumanNameBuilder()
    .SetUse(NameUse.Official)
    .SetFamily("王")
    .AddGiven("大明")
    .AddGiven("志強")
    .Build();
```

## 🔧 FHIR 客戶端使用

### 建立客戶端

```csharp
using FhirCore.Client;

// 連接到 HAPI FHIR 測試伺服器
var client = new FhirClient("https://hapi.fhir.org/baseR5");

// 或連接到本地伺服器
var localClient = new FhirClient("http://localhost:8080/fhir");
```

### CRUD 操作

```csharp
// 建立資源
var createdPatient = await client.CreateAsync(patient);
Console.WriteLine($"Created Patient with ID: {createdPatient.Id}");

// 讀取資源
var readPatient = await client.ReadAsync<Patient>("patient-001");
Console.WriteLine($"Patient name: {readPatient.Name[0].Family}");

// 更新資源
readPatient.Active = false;
var updatedPatient = await client.UpdateAsync(readPatient);

// 刪除資源
await client.DeleteAsync<Patient>("patient-001");
```

### 搜尋資源

```csharp
// 搜尋所有 Patient
var searchResults = await client.SearchAsync<Patient>();

// 使用參數搜尋
var searchParams = new Dictionary<string, string>
{
    ["family"] = "張",
    ["gender"] = "male"
};
var filteredResults = await client.SearchAsync<Patient>(searchParams);

foreach (var patient in filteredResults.Entry)
{
    Console.WriteLine($"Found patient: {patient.Resource.Name[0].Family}");
}
```

## ✅ 驗證資源

### 基本驗證

```csharp
// 驗證單一資源
var validationResult = patient.Validate();

if (validationResult.IsValid)
{
    Console.WriteLine("Patient 資源驗證通過");
}
else
{
    foreach (var error in validationResult.Errors)
    {
        Console.WriteLine($"驗證錯誤: {error.ErrorMessage}");
    }
}
```

### 自訂驗證規則

```csharp
using DataTypeServices.Validation;

// 建立自訂驗證器
var customValidator = new CustomValidationEngine();

// 添加自訂規則
customValidator.AddRule<Patient>(p => 
    p.Name != null && p.Name.Count > 0, 
    "Patient 必須至少有一個姓名");

// 執行驗證
var customResult = customValidator.Validate(patient);
```

## 📄 序列化和反序列化

### JSON 序列化

```csharp
using DataTypeServices.Serialization;

// 序列化為 JSON
string json = patient.ToJson(writeIndented: true);
Console.WriteLine(json);

// 從 JSON 反序列化
var deserializedPatient = DataType.FromJson<Patient>(json);
```

### 多格式支援

```csharp
// 序列化為 XML
string xml = patient.Serialize(FhirSerializationFormat.Xml);

// 自動檢測格式並反序列化
var autoPatient = DataType.DeserializeAuto<Patient>(jsonOrXmlString);
```

## 🎯 常見使用模式

### 1. 建立完整的病患記錄

```csharp
var completePatient = new Patient
{
    Id = "patient-complete-001",
    Active = true,
    Name = new List<HumanName> { /* 姓名資訊 */ },
    Gender = AdministrativeGender.Female,
    BirthDate = new Date(1985, 3, 20),
    Address = new List<Address> { address },
    Telecom = new List<ContactPoint> { /* 聯絡資訊 */ },
    MaritalStatus = new CodeableConcept
    {
        Coding = new List<Coding>
        {
            new Coding
            {
                System = "http://terminology.hl7.org/CodeSystem/v3-MaritalStatus",
                Code = "M",
                Display = "Married"
            }
        }
    }
};
```

### 2. 批次處理資源

```csharp
var patients = new List<Patient>();

for (int i = 1; i <= 10; i++)
{
    var patient = new Patient
    {
        Id = $"patient-{i:D3}",
        Name = new List<HumanName>
        {
            new HumanName
            {
                Family = $"測試姓氏{i}",
                Given = new List<FhirString> { new FhirString($"名字{i}") }
            }
        }
    };
    
    patients.Add(patient);
}

// 批次建立
foreach (var patient in patients)
{
    await client.CreateAsync(patient);
}
```

## 🔍 除錯技巧

### 啟用詳細日誌

```csharp
// 在 appsettings.json 中設定
{
  "Logging": {
    "LogLevel": {
      "FhirCore": "Debug",
      "DataTypeServices": "Debug"
    }
  }
}
```

### 驗證詳細資訊

```csharp
var detailedResult = patient.ValidateDetailed();
foreach (var issue in detailedResult.Issues)
{
    Console.WriteLine($"[{issue.Severity}] {issue.Location}: {issue.Details}");
}
```

## 📚 下一步

- 閱讀 [完整 API 文件](API_Reference.md)
- 查看 [架構設計文件](BASE_ARCHITECTURE.md)
- 探索 [進階功能範例](../examples/)
- 參與 [專案貢獻](../CONTRIBUTING.md)

## 🆘 需要幫助？

- 查看 [常見問題](FAQ.md)
- 建立 [GitHub Issue](https://github.com/sjvann/Fhir_SDK/issues)
- 聯絡開發團隊: sjvann@gmail.com
