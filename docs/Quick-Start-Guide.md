# FHIR SDK 快速入門指南

## 🎯 目標讀者
本指南專為剛接觸FHIR或想要快速開始FHIR應用開發的程式設計師而設計。

## 📚 什麼是FHIR？

FHIR (Fast Healthcare Interoperability Resources) 是一個現代化的醫療資訊交換標準，由HL7組織制定。

### 核心概念
- **資源 (Resources)**：表示醫療資訊的標準化資料結構，如患者、醫生、檢驗報告等
- **RESTful API**：使用HTTP協議進行資源的增刪查改操作
- **JSON/XML格式**：資料以標準格式傳輸和存儲
- **互操作性**：不同系統間能夠無縫交換醫療資訊

### 常見FHIR資源
- `Patient` - 患者資訊
- `Practitioner` - 醫護人員
- `Organization` - 醫療機構
- `Observation` - 檢驗/檢查結果
- `Medication` - 藥物資訊
- `Encounter` - 就診記錄

---

## 🚀 5分鐘快速開始

### 步驟1：建立新專案
```bash
# 建立新的Web API專案
dotnet new webapi -n MyFhirApp
cd MyFhirApp

# 安裝FHIR SDK套件
dotnet add package FhirSdk.Core
dotnet add package FhirSdk.ResourceTypes.R5
```

### 步驟2：基本配置
在 `Program.cs` 中添加：
```csharp
using Core.Extensions;

var builder = WebApplication.CreateBuilder(args);

// 添加FHIR SDK服務
builder.Services.AddFhirSdkDefault();

// 添加控制器
builder.Services.AddControllers();

var app = builder.Build();

// 配置管道
app.UseRouting();
app.MapControllers();

app.Run();
```

### 步驟3：建立第一個API
建立 `Controllers/PatientController.cs`：
```csharp
using Microsoft.AspNetCore.Mvc;
using Core.Factories;
using ResourceTypeServices.R5.PatientSub;

[ApiController]
[Route("api/[controller]")]
public class PatientController : ControllerBase
{
    private readonly IFhirResourceFactory _factory;
    
    public PatientController(IFhirResourceFactory factory)
    {
        _factory = factory;
    }
    
    [HttpGet("{id}")]
    public IActionResult GetPatient(string id)
    {
        var patient = _factory.Create<Patient>();
        patient.Id = id;
        patient.Active = true.ToFhirBoolean();
        
        return Ok(patient.ToJson());
    }
}
```

### 步驟4：運行測試
```bash
dotnet run
```

訪問：`https://localhost:7000/api/patient/123`

---

## 🏥 實用案例解說

### 案例1：患者資訊管理系統

#### 需求
建立一個簡單的患者管理系統，能夠：
- 註冊新患者
- 查詢患者資訊
- 更新患者資訊

#### 實現步驟

**1. 定義患者資料模型**
```csharp
public class PatientCreateRequest
{
    public string FamilyName { get; set; }
    public string GivenName { get; set; }
    public DateTime? BirthDate { get; set; }
    public string Gender { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
}
```

**2. 建立患者服務**
```csharp
public class PatientService
{
    private readonly IFhirResourceFactory _factory;
    private readonly List<Patient> _patients = new(); // 簡單的記憶體存儲
    
    public PatientService(IFhirResourceFactory factory)
    {
        _factory = factory;
    }
    
    public Patient CreatePatient(PatientCreateRequest request)
    {
        var patient = _factory.Create<Patient>();
        
        // 設定基本資訊
        patient.Id = Guid.NewGuid().ToString();
        patient.Active = true.ToFhirBoolean();
        
        // 設定姓名
        patient.Name = new[]
        {
            new HumanName
            {
                Use = NameUse.Official,
                Family = request.FamilyName.ToFhirString(),
                Given = new[] { request.GivenName.ToFhirString() }
            }
        };
        
        // 設定出生日期
        if (request.BirthDate.HasValue)
        {
            patient.BirthDate = request.BirthDate.Value.ToFhirDate();
        }
        
        // 設定性別
        if (!string.IsNullOrEmpty(request.Gender))
        {
            patient.Gender = Enum.Parse<AdministrativeGender>(request.Gender, true);
        }
        
        // 設定聯絡方式
        var contacts = new List<ContactPoint>();
        if (!string.IsNullOrEmpty(request.Phone))
        {
            contacts.Add(new ContactPoint
            {
                System = ContactPointSystem.Phone,
                Value = request.Phone.ToFhirString(),
                Use = ContactPointUse.Mobile
            });
        }
        
        if (!string.IsNullOrEmpty(request.Email))
        {
            contacts.Add(new ContactPoint
            {
                System = ContactPointSystem.Email,
                Value = request.Email.ToFhirString(),
                Use = ContactPointUse.Home
            });
        }
        
        patient.Telecom = contacts;
        
        // 儲存到記憶體
        _patients.Add(patient);
        
        return patient;
    }
    
    public Patient GetPatient(string id)
    {
        return _patients.FirstOrDefault(p => p.Id == id);
    }
    
    public IEnumerable<Patient> SearchPatients(string name = null)
    {
        if (string.IsNullOrEmpty(name))
            return _patients;
            
        return _patients.Where(p => 
            p.Name.Any(n => 
                n.Family?.Value?.Contains(name, StringComparison.OrdinalIgnoreCase) == true ||
                n.Given?.Any(g => g.Value?.Contains(name, StringComparison.OrdinalIgnoreCase) == true) == true
            ));
    }
}
```

**3. 完整的API控制器**
```csharp
[ApiController]
[Route("api/[controller]")]
public class PatientController : ControllerBase
{
    private readonly PatientService _patientService;
    
    public PatientController(PatientService patientService)
    {
        _patientService = patientService;
    }
    
    [HttpPost]
    public IActionResult CreatePatient([FromBody] PatientCreateRequest request)
    {
        try
        {
            var patient = _patientService.CreatePatient(request);
            return CreatedAtAction(nameof(GetPatient), new { id = patient.Id }, patient.ToJson());
        }
        catch (Exception ex)
        {
            return BadRequest($"建立患者失敗: {ex.Message}");
        }
    }
    
    [HttpGet("{id}")]
    public IActionResult GetPatient(string id)
    {
        var patient = _patientService.GetPatient(id);
        if (patient == null)
            return NotFound($"找不到患者: {id}");
            
        return Ok(patient.ToJson());
    }
    
    [HttpGet]
    public IActionResult SearchPatients([FromQuery] string name = null)
    {
        var patients = _patientService.SearchPatients(name);
        var result = patients.Select(p => new
        {
            Id = p.Id,
            Name = p.Name?.FirstOrDefault()?.Given?.FirstOrDefault()?.Value + " " + 
                   p.Name?.FirstOrDefault()?.Family?.Value,
            BirthDate = p.BirthDate?.Value,
            Gender = p.Gender?.ToString()
        });
        
        return Ok(result);
    }
}
```

**4. 註冊服務**
在 `Program.cs` 中添加：
```csharp
builder.Services.AddScoped<PatientService>();
```

**5. 測試API**

建立患者：
```bash
curl -X POST "https://localhost:7000/api/patient" \
  -H "Content-Type: application/json" \
  -d '{
    "familyName": "王",
    "givenName": "小明",
    "birthDate": "1990-01-01",
    "gender": "male",
    "phone": "0912345678",
    "email": "wang@example.com"
  }'
```

查詢患者：
```bash
curl "https://localhost:7000/api/patient/{patient-id}"
```

---

### 案例2：醫療檢驗報告系統

#### 需求
建立一個檢驗報告管理系統，處理：
- 血壓測量記錄
- 血糖檢測結果
- 體溫記錄

#### 實現步驟

**1. 檢驗服務類別**
```csharp
public class ObservationService
{
    private readonly IFhirResourceFactory _factory;
    private readonly List<Observation> _observations = new();
    
    public ObservationService(IFhirResourceFactory factory)
    {
        _factory = factory;
    }
    
    // 建立血壓記錄
    public Observation CreateBloodPressure(string patientId, int systolic, int diastolic)
    {
        var observation = _factory.Create<Observation>();
        
        observation.Id = Guid.NewGuid().ToString();
        observation.Status = ObservationStatus.Final;
        observation.Subject = new Reference($"Patient/{patientId}");
        observation.EffectiveDateTime = DateTime.UtcNow.ToFhirDateTime();
        
        // 血壓代碼 (LOINC)
        observation.Code = new CodeableConcept
        {
            Coding = new[]
            {
                new Coding
                {
                    System = "http://loinc.org".ToFhirUri(),
                    Code = "85354-9".ToFhirCode(),
                    Display = "Blood pressure panel with all children optional".ToFhirString()
                }
            }
        };
        
        // 血壓值（組合測量）
        observation.Component = new[]
        {
            new ObservationComponent
            {
                Code = new CodeableConcept
                {
                    Coding = new[]
                    {
                        new Coding
                        {
                            System = "http://loinc.org".ToFhirUri(),
                            Code = "8480-6".ToFhirCode(),
                            Display = "Systolic blood pressure".ToFhirString()
                        }
                    }
                },
                ValueQuantity = new Quantity
                {
                    Value = systolic.ToFhirDecimal(),
                    Unit = "mmHg".ToFhirString(),
                    System = "http://unitsofmeasure.org".ToFhirUri(),
                    Code = "mm[Hg]".ToFhirCode()
                }
            },
            new ObservationComponent
            {
                Code = new CodeableConcept
                {
                    Coding = new[]
                    {
                        new Coding
                        {
                            System = "http://loinc.org".ToFhirUri(),
                            Code = "8462-4".ToFhirCode(),
                            Display = "Diastolic blood pressure".ToFhirString()
                        }
                    }
                },
                ValueQuantity = new Quantity
                {
                    Value = diastolic.ToFhirDecimal(),
                    Unit = "mmHg".ToFhirString(),
                    System = "http://unitsofmeasure.org".ToFhirUri(),
                    Code = "mm[Hg]".ToFhirCode()
                }
            }
        };
        
        _observations.Add(observation);
        return observation;
    }
    
    // 建立血糖記錄
    public Observation CreateBloodGlucose(string patientId, decimal glucoseLevel)
    {
        var observation = _factory.Create<Observation>();
        
        observation.Id = Guid.NewGuid().ToString();
        observation.Status = ObservationStatus.Final;
        observation.Subject = new Reference($"Patient/{patientId}");
        observation.EffectiveDateTime = DateTime.UtcNow.ToFhirDateTime();
        
        // 血糖代碼
        observation.Code = new CodeableConcept
        {
            Coding = new[]
            {
                new Coding
                {
                    System = "http://loinc.org".ToFhirUri(),
                    Code = "33747-0".ToFhirCode(),
                    Display = "Glucose [Mass/volume] in Blood".ToFhirString()
                }
            }
        };
        
        // 血糖值
        observation.ValueQuantity = new Quantity
        {
            Value = glucoseLevel.ToFhirDecimal(),
            Unit = "mg/dL".ToFhirString(),
            System = "http://unitsofmeasure.org".ToFhirUri(),
            Code = "mg/dL".ToFhirCode()
        };
        
        // 參考範圍
        observation.ReferenceRange = new[]
        {
            new ObservationReferenceRange
            {
                Low = new Quantity
                {
                    Value = 70.ToFhirDecimal(),
                    Unit = "mg/dL".ToFhirString()
                },
                High = new Quantity
                {
                    Value = 100.ToFhirDecimal(),
                    Unit = "mg/dL".ToFhirString()
                },
                Text = "正常空腹血糖範圍".ToFhirString()
            }
        };
        
        _observations.Add(observation);
        return observation;
    }
    
    // 獲取患者的所有檢驗記錄
    public IEnumerable<Observation> GetPatientObservations(string patientId)
    {
        return _observations.Where(o => o.Subject?.Reference == $"Patient/{patientId}");
    }
}
```

**2. API控制器**
```csharp
[ApiController]
[Route("api/[controller]")]
public class ObservationController : ControllerBase
{
    private readonly ObservationService _observationService;
    
    public ObservationController(ObservationService observationService)
    {
        _observationService = observationService;
    }
    
    [HttpPost("blood-pressure")]
    public IActionResult CreateBloodPressure([FromBody] BloodPressureRequest request)
    {
        var observation = _observationService.CreateBloodPressure(
            request.PatientId, 
            request.Systolic, 
            request.Diastolic);
            
        return Ok(observation.ToJson());
    }
    
    [HttpPost("blood-glucose")]
    public IActionResult CreateBloodGlucose([FromBody] BloodGlucoseRequest request)
    {
        var observation = _observationService.CreateBloodGlucose(
            request.PatientId, 
            request.GlucoseLevel);
            
        return Ok(observation.ToJson());
    }
    
    [HttpGet("patient/{patientId}")]
    public IActionResult GetPatientObservations(string patientId)
    {
        var observations = _observationService.GetPatientObservations(patientId);
        var result = observations.Select(o => new
        {
            Id = o.Id,
            Code = o.Code?.Coding?.FirstOrDefault()?.Display?.Value,
            Value = GetObservationValue(o),
            Date = o.EffectiveDateTime?.Value,
            Status = o.Status?.ToString()
        });
        
        return Ok(result);
    }
    
    private object GetObservationValue(Observation observation)
    {
        if (observation.ValueQuantity != null)
        {
            return new
            {
                Value = observation.ValueQuantity.Value?.Value,
                Unit = observation.ValueQuantity.Unit?.Value
            };
        }
        
        if (observation.Component?.Any() == true)
        {
            return observation.Component.Select(c => new
            {
                Code = c.Code?.Coding?.FirstOrDefault()?.Display?.Value,
                Value = c.ValueQuantity?.Value?.Value,
                Unit = c.ValueQuantity?.Unit?.Value
            });
        }
        
        return null;
    }
}

public class BloodPressureRequest
{
    public string PatientId { get; set; }
    public int Systolic { get; set; }
    public int Diastolic { get; set; }
}

public class BloodGlucoseRequest
{
    public string PatientId { get; set; }
    public decimal GlucoseLevel { get; set; }
}
```

---

### 案例3：CDS Hooks - BMI健康提醒

CDS Hooks是一個標準，允許臨床決策支援系統在醫療工作流程中提供實時建議。

#### 實現BMI提醒服務

**1. BMI計算服務**
```csharp
public class BmiCdsService
{
    public class BmiCalculationResult
    {
        public decimal BmiValue { get; set; }
        public string Category { get; set; }
        public string Recommendation { get; set; }
        public string RiskLevel { get; set; }
    }
    
    public BmiCalculationResult CalculateBmi(decimal heightCm, decimal weightKg)
    {
        var heightM = heightCm / 100;
        var bmi = weightKg / (heightM * heightM);
        
        var result = new BmiCalculationResult
        {
            BmiValue = Math.Round(bmi, 1)
        };
        
        // 根據BMI值分類
        if (bmi < 18.5m)
        {
            result.Category = "體重過輕";
            result.RiskLevel = "警告";
            result.Recommendation = "建議增加營養攝取，諮詢營養師制定增重計畫";
        }
        else if (bmi < 24m)
        {
            result.Category = "正常體重";
            result.RiskLevel = "正常";
            result.Recommendation = "維持良好的飲食和運動習慣";
        }
        else if (bmi < 27m)
        {
            result.Category = "體重過重";
            result.RiskLevel = "注意";
            result.Recommendation = "建議控制飲食，增加運動量";
        }
        else if (bmi < 30m)
        {
            result.Category = "輕度肥胖";
            result.RiskLevel = "警告";
            result.Recommendation = "建議諮詢醫師，制定減重計畫";
        }
        else if (bmi < 35m)
        {
            result.Category = "中度肥胖";
            result.RiskLevel = "嚴重";
            result.Recommendation = "強烈建議醫療介入，可能需要藥物治療";
        }
        else
        {
            result.Category = "重度肥胖";
            result.RiskLevel = "危險";
            result.Recommendation = "需要立即醫療介入，考慮手術治療";
        }
        
        return result;
    }
}
```

**2. CDS Hooks API**
```csharp
[ApiController]
[Route("cds-services")]
public class CdsHooksController : ControllerBase
{
    private readonly BmiCdsService _bmiService;
    
    public CdsHooksController(BmiCdsService bmiService)
    {
        _bmiService = bmiService;
    }
    
    // 服務發現端點
    [HttpGet]
    public IActionResult GetServices()
    {
        var services = new
        {
            services = new[]
            {
                new
                {
                    hook = "patient-view",
                    title = "BMI健康提醒",
                    description = "根據患者身高體重計算BMI並提供健康建議",
                    id = "bmi-advisor",
                    prefetch = new
                    {
                        patient = "Patient/{{context.patientId}}",
                        observations = "Observation?patient={{context.patientId}}&code=http://loinc.org|8302-2,http://loinc.org|29463-7"
                    }
                }
            }
        };
        
        return Ok(services);
    }
    
    // BMI建議服務
    [HttpPost("bmi-advisor")]
    public IActionResult BmiAdvisor([FromBody] CdsHookRequest request)
    {
        try
        {
            var cards = new List<object>();
            
            // 從預取資料中獲取患者和觀察記錄
            var patient = request.Prefetch?.Patient;
            var observations = request.Prefetch?.Observations?.Entry;
            
            if (observations?.Any() == true)
            {
                var heightObs = observations.FirstOrDefault(o => 
                    o.Resource?.Code?.Coding?.Any(c => c.Code == "8302-2") == true);
                var weightObs = observations.FirstOrDefault(o => 
                    o.Resource?.Code?.Coding?.Any(c => c.Code == "29463-7") == true);
                
                if (heightObs?.Resource?.ValueQuantity != null && 
                    weightObs?.Resource?.ValueQuantity != null)
                {
                    var height = heightObs.Resource.ValueQuantity.Value;
                    var weight = weightObs.Resource.ValueQuantity.Value;
                    
                    var bmiResult = _bmiService.CalculateBmi(height, weight);
                    
                    var card = new
                    {
                        uuid = Guid.NewGuid().ToString(),
                        summary = $"BMI: {bmiResult.BmiValue} ({bmiResult.Category})",
                        detail = bmiResult.Recommendation,
                        indicator = GetIndicatorLevel(bmiResult.RiskLevel),
                        source = new
                        {
                            label = "BMI健康助手",
                            url = "https://example.com/bmi-calculator"
                        },
                        links = new[]
                        {
                            new
                            {
                                label = "查看營養諮詢",
                                url = "https://example.com/nutrition-consultation",
                                type = "absolute"
                            }
                        }
                    };
                    
                    cards.Add(card);
                }
            }
            
            var response = new { cards };
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(new { error = ex.Message });
        }
    }
    
    private string GetIndicatorLevel(string riskLevel)
    {
        return riskLevel switch
        {
            "正常" => "info",
            "注意" => "warning",
            "警告" => "warning",
            "嚴重" => "critical",
            "危險" => "critical",
            _ => "info"
        };
    }
}

public class CdsHookRequest
{
    public string Hook { get; set; }
    public string HookInstance { get; set; }
    public object Context { get; set; }
    public PrefetchData Prefetch { get; set; }
}

public class PrefetchData
{
    public Patient Patient { get; set; }
    public Bundle Observations { get; set; }
}
```

---

## 🔧 開發環境設置

### 推薦工具

**1. 開發環境**
- Visual Studio 2022 或 VS Code
- .NET 8 SDK
- Postman 或類似的API測試工具

**2. FHIR工具**
- [FHIR官方網站](https://hl7.org/fhir/) - 規範文檔
- [Simplifier.net](https://simplifier.net/) - FHIR資源瀏覽器
- [HAPI FHIR Test Server](https://hapi.fhir.org/) - 測試用FHIR服務器

### 偵錯技巧

**1. JSON格式化**
```csharp
public static class JsonHelper
{
    public static string PrettyPrint(string json)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        var document = JsonDocument.Parse(json);
        return JsonSerializer.Serialize(document, options);
    }
}
```

**2. 日誌配置**
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Core.Factories": "Debug",
      "Microsoft.AspNetCore": "Warning"
    }
  }
}
```

---

## 📖 學習資源

### 推薦閱讀順序

1. **FHIR基礎**
   - [FHIR Overview](https://hl7.org/fhir/overview.html)
   - [FHIR Resources](https://hl7.org/fhir/resourcelist.html)

2. **實作指引**
   - [FHIR RESTful API](https://hl7.org/fhir/http.html)
   - [Search Parameters](https://hl7.org/fhir/search.html)

3. **進階主題**
   - [Profiles and Extensions](https://hl7.org/fhir/profiling.html)
   - [Terminology](https://hl7.org/fhir/terminology.html)

### 社群資源

- [FHIR Chat](https://chat.fhir.org/) - 官方聊天室
- [StackOverflow FHIR標籤](https://stackoverflow.com/questions/tagged/hl7-fhir)
- [GitHub FHIR組織](https://github.com/HL7)

---

## 🎯 下一步

完成這個快速入門後，建議：

1. **深入學習**
   - 閱讀[完整使用手冊](Advanced-User-Manual.md)
   - 了解FHIR Profile概念
   - 學習術語服務使用

2. **實際專案**
   - 擴展患者管理系統
   - 整合現有醫療系統
   - 開發自定義CDS Hooks

3. **部署準備**
   - 學習Docker容器化
   - 了解雲端部署
   - 實施安全措施

## 💡 常見問題

**Q: FHIR R5和R4有什麼區別？**
A: R5是最新版本，包含更多資源類型和改進的資料結構。本SDK專注於R5並為R6做準備。

**Q: 如何處理大量資料？**
A: 使用分頁查詢、啟用快取機制，考慮使用非同步處理。

**Q: 是否支援自定義資源？**
A: 是的，可以通過擴展現有資源或建立新的資源類型來實現。

**Q: 如何確保資料安全？**
A: 實施SMART on FHIR認證、使用HTTPS、記錄審計日誌。

---

*這份快速入門指南提供了FHIR開發的基礎知識和實用範例。如需更深入的內容，請參考完整使用手冊。*
