# FHIR SDK API 參考文件

## 📚 目錄

1. [快速開始](#快速開始)
2. [核心概念](#核心概念)
3. [資料類型](#資料類型)
4. [資源類型](#資源類型)
5. [客戶端操作](#客戶端操作)
6. [驗證系統](#驗證系統)
7. [序列化](#序列化)
8. [快取機制](#快取機制)
9. [最佳實踐](#最佳實踐)

## 🚀 快速開始

### 安裝

```bash
dotnet add package Fhir_SDK
```

### 基本使用

```csharp
using FhirCore.Client;
using ResourceTypeServices.R5;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;

// 建立客戶端
var client = new FhirClient("https://hapi.fhir.org/baseR5");

// 建立 Patient 資源
var patient = new Patient
{
    Id = "patient-001",
    Name = new List<HumanName>
    {
        new HumanName
        {
            Family = "張",
            Given = new List<FhirString> { new FhirString("三") }
        }
    },
    BirthDate = new Date(1990, 1, 1)
};

// 儲存到伺服器
var result = await client.CreateAsync(patient);
Console.WriteLine($"Patient created with ID: {result.Id}");
```

## 🏗️ 核心概念

### FHIR 版本支援

```csharp
// 設定 FHIR 版本
FhirSDK.SetVersion("R5");
Console.WriteLine($"Current version: {FhirSDK.GetCurrentVersion()}");
```

### 資源類型

所有 FHIR 資源都繼承自 `ResourceType<T>` 基類：

```csharp
public class Patient : ResourceType<Patient>
{
    public List<HumanName>? Name { get; set; }
    public FhirDate? BirthDate { get; set; }
    // ... 其他屬性
}
```

## 📊 資料類型

### 基本資料類型

```csharp
// 字串類型
var name = new FhirString("John Doe");

// 日期類型
var birthDate = new FhirDate(1990, 1, 1);

// 代碼類型
var gender = new FhirCode("male");

// URI 類型
var uri = new FhirUri("http://example.com");
```

### 複雜資料類型

```csharp
// 人類姓名
var humanName = HumanName.Builder()
    .WithUse("official")
    .WithFamily("Doe")
    .WithGiven("John", "William")
    .Build();

// 地址
var address = Address.Builder()
    .WithUse("home")
    .WithLine("123 Main Street")
    .WithCity("Anytown")
    .WithState("NY")
    .WithPostalCode("12345")
    .WithCountry("USA")
    .Build();

// 代碼概念
var codeableConcept = new CodeableConcept
{
    Coding = new List<Coding>
    {
        new Coding
        {
            System = "http://snomed.info/sct",
            Code = "123456",
            Display = "Diabetes mellitus"
        }
    }
};
```

## 🏥 資源類型

### 建立資源

```csharp
// Patient 資源
var patient = new Patient
{
    Id = "patient-001",
    Name = new List<HumanName>
    {
        HumanName.Builder()
            .WithUse("official")
            .WithFamily("張")
            .WithGiven("三")
            .Build()
    },
    Gender = new FhirCode("male"),
    BirthDate = new FhirDate(1990, 1, 1),
    Address = new List<Address>
    {
        Address.Builder()
            .WithUse("home")
            .WithCity("台北市")
            .WithCountry("TW")
            .Build()
    }
};

// Observation 資源
var observation = new Observation
{
    Id = "obs-001",
    Status = new FhirCode("final"),
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
    Subject = new ReferenceType
    {
        Reference = "Patient/patient-001"
    },
    ValueQuantity = new Quantity
    {
        Value = 175.0,
        Unit = "cm",
        System = "http://unitsofmeasure.org",
        Code = "cm"
    }
};
```

## 🌐 客戶端操作

### 基本 CRUD 操作

```csharp
var client = new FhirClient("https://hapi.fhir.org/baseR5");

// 建立資源
var createResult = await client.CreateAsync(patient);
Console.WriteLine($"Created: {createResult.Id}");

// 讀取資源
var readPatient = await client.ReadAsync<Patient>("Patient", "patient-001");

// 更新資源
patient.Name[0].Given = new string[] { "張", "三" };
var updateResult = await client.UpdateAsync(patient, "patient-001");

// 刪除資源
var deleteResult = await client.DeleteAsync("Patient", "patient-001");
```

### 搜尋操作

```csharp
// 基本搜尋
var searchParams = new SearchParameters()
    .Add("name", "張")
    .Add("gender", "male");

var searchResult = await client.SearchAsync<Patient>("Patient", searchParams);

foreach (var patient in searchResult.Entry)
{
    Console.WriteLine($"Found patient: {patient.Id}");
}

// 複雜搜尋
var complexSearch = new SearchParameters()
    .Add("birthdate", "gt1990-01-01")
    .Add("address-city", "台北市")
    .Add("_count", "10");

var results = await client.SearchAsync<Patient>("Patient", complexSearch);
```

### 批次操作

```csharp
var batchRequest = new BatchRequest
{
    Entry = new List<BatchEntry>
    {
        new BatchEntry
        {
            Request = new BatchRequest { Method = "POST", Url = "Patient" },
            Resource = patient1
        },
        new BatchEntry
        {
            Request = new BatchRequest { Method = "POST", Url = "Patient" },
            Resource = patient2
        }
    }
};

var batchResult = await client.BatchAsync(batchRequest);
```

## ✅ 驗證系統

### 基本驗證

```csharp
// 驗證資源
var validationEngine = new FhirValidationEngine(new FhirR4Version());
var result = validationEngine.ValidateResource(patient);

if (result.IsValid)
{
    Console.WriteLine("資源驗證通過");
}
else
{
    foreach (var error in result.GetErrorMessages())
    {
        Console.WriteLine($"驗證錯誤: {error}");
    }
}
```

### 自定義驗證

```csharp
public class CustomPatient : Patient
{
    [EmailValidation]
    public FhirString? Email { get; set; }
    
    [NumericRangeValidation(18, 120)]
    public FhirInteger? Age { get; set; }
    
    [Required]
    public FhirString? EmergencyContact { get; set; }
}

// 驗證自定義屬性
var customValidation = CustomValidationEngine.ValidateCustomAttributes(patient);
```

### 詳細驗證

```csharp
// 取得詳細驗證結果
var detailedResult = patient.ValidateDetailed();
Console.WriteLine(detailedResult.GetFormattedMessage());

// 驗證所有內容
var allResults = patient.ValidateAll();
Console.WriteLine($"總驗證項目: {allResults.Results.Count}");
Console.WriteLine($"錯誤數量: {allResults.ErrorCount}");
Console.WriteLine($"警告數量: {allResults.WarningCount}");
```

## 🔄 序列化

### JSON 序列化

```csharp
// 序列化為 JSON
var json = FhirSerializer.Serialize(patient, FhirSerializationFormat.JsonPretty);
Console.WriteLine(json);

// 反序列化
var deserializedPatient = FhirSerializer.Deserialize<Patient>(json);

// 自動格式檢測
var autoDeserialized = FhirSerializer.DeserializeAuto<Patient>(jsonOrXmlData);
```

### XML 序列化

```csharp
// 序列化為 XML
var xml = FhirSerializer.Serialize(patient, FhirSerializationFormat.Xml);
Console.WriteLine(xml);

// 格式轉換
var xmlData = FhirSerializer.ConvertFormat<Patient>(
    jsonData, 
    FhirSerializationFormat.Json, 
    FhirSerializationFormat.Xml
);
```

## 💾 快取機制

### 記憶體快取

```csharp
var cache = new MemoryCache();
var cacheManager = new FhirCacheManager(cache);

// 取得或設定快取
var patient = await cacheManager.GetOrSetAsync(
    "Patient:patient-001",
    async () => await client.ReadAsync<Patient>("Patient", "patient-001"),
    TimeSpan.FromMinutes(30)
);
```

### 分散式快取

```csharp
// 使用 Redis 快取
var redisCache = new DistributedCache(redisConnection);
var cacheManager = new FhirCacheManager(redisCache);

// 快取搜尋結果
var searchKey = FhirCacheManager.CreateSearchKey("Patient", "name=張");
var searchResults = await cacheManager.GetOrSetAsync(
    searchKey,
    async () => await client.SearchAsync<Patient>("Patient", searchParams),
    TimeSpan.FromMinutes(15)
);
```

## 🎯 最佳實踐

### 錯誤處理

```csharp
try
{
    var patient = await client.ReadAsync<Patient>("Patient", "patient-001");
    // 處理成功結果
}
catch (HttpRequestException ex)
{
    Console.WriteLine($"網路錯誤: {ex.Message}");
}
catch (JsonException ex)
{
    Console.WriteLine($"序列化錯誤: {ex.Message}");
}
catch (ValidationException ex)
{
    Console.WriteLine($"驗證錯誤: {ex.Message}");
}
```

### 效能優化

```csharp
// 使用快取
var cacheManager = new FhirCacheManager(new MemoryCache());

// 批次操作
var batchRequest = new BatchRequest();
foreach (var patient in patients)
{
    batchRequest.Entry.Add(new BatchEntry
    {
        Request = new BatchRequest { Method = "POST", Url = "Patient" },
        Resource = patient
    });
}

var batchResult = await client.BatchAsync(batchRequest);
```

### 非同步操作

```csharp
// 並行處理多個資源
var tasks = patients.Select(async patient =>
{
    try
    {
        return await client.CreateAsync(patient);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"建立 Patient 失敗: {ex.Message}");
        return null;
    }
});

var results = await Task.WhenAll(tasks);
```

### 資源驗證

```csharp
// 在儲存前驗證
var validationResult = validationEngine.ValidateResource(patient);
if (!validationResult.IsValid)
{
    throw new ValidationException("資源驗證失敗", validationResult);
}

// 自定義驗證
var customValidation = CustomValidationEngine.ValidateCustomAttributes(patient);
if (!customValidation.IsValid)
{
    throw new ValidationException("自定義驗證失敗", customValidation);
}
```

## 📝 注意事項

1. **版本相容性**: 確保使用正確的 FHIR 版本
2. **錯誤處理**: 總是處理可能的例外狀況
3. **效能考量**: 使用快取和批次操作來提升效能
4. **安全性**: 在生產環境中使用適當的認證機制
5. **記錄**: 記錄重要的操作和錯誤

## 🔗 相關連結

- [FHIR 官方文件](https://www.hl7.org/fhir/)
- [GitHub 專案](https://github.com/your-org/Fhir_SDK)
- [問題回報](https://github.com/your-org/Fhir_SDK/issues)
- [討論區](https://github.com/your-org/Fhir_SDK/discussions) 