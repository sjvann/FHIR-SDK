# FHIR SDK 架構重構建議

## 新架構概述

### 核心套件結構
```
FhirCore/                          # 核心共用套件
├── FhirCore.csproj               # 基礎介面和抽象類
├── Interfaces/                   # 共用介面
├── Base/                         # 基礎類別
├── Validation/                   # 共用驗證邏輯
└── Common/                       # 共用工具

DataTypeServices/                  # 資料類型共用套件
├── DataTypeServices.csproj       # 基礎資料類型
├── PrimitiveTypes/               # 原始資料類型
├── ComplexTypes/                 # 複合資料類型
└── Common/                       # 共用資料類型邏輯

FhirCore.R4/                      # R4 版本特定套件
├── FhirCore.R4.csproj           # R4 核心
├── Resources/                    # R4 資源定義
├── DataTypes/                    # R4 特定資料類型
├── Validation/                   # R4 驗證邏輯
└── Extensions/                   # R4 擴展

FhirCore.R5/                      # R5 版本特定套件
├── FhirCore.R5.csproj           # R5 核心
├── Resources/                    # R5 資源定義
├── DataTypes/                    # R5 特定資料類型
├── Validation/                   # R5 驗證邏輯
└── Extensions/                   # R5 擴展

FhirCore.R6/                      # R6 版本特定套件 (未來)
├── FhirCore.R6.csproj           # R6 核心
└── ...

TerminologyService/               # 術語服務 (版本無關)
├── TerminologyService.csproj
└── ValueSets/

FhirCore.Tools/                   # 開發工具套件
├── FhirCore.Tools.csproj
├── CodeGeneration/              # 程式碼產生工具
└── Migration/                   # 版本遷移工具
```

### 套件相依性架構
```
FhirCore (基礎)
├── DataTypeServices → FhirCore
├── TerminologyService → FhirCore
├── FhirCore.R4 → FhirCore + DataTypeServices
├── FhirCore.R5 → FhirCore + DataTypeServices
└── FhirCore.R6 → FhirCore + DataTypeServices
```

## 實作細節

### 1. 核心介面定義 (FhirCore)
```csharp
namespace FhirCore.Interfaces
{
    public interface IFhirResource<TVersion> where TVersion : IFhirVersion
    {
        string Id { get; set; }
        string ResourceType { get; }
        TVersion Version { get; }
    }
    
    public interface IFhirVersion
    {
        string VersionNumber { get; }
        string DisplayName { get; }
    }
}
```

### 2. 版本特定實作 (FhirCore.R5)
```csharp
namespace FhirCore.R5
{
    public class R5Version : IFhirVersion
    {
        public string VersionNumber => "5.0.0";
        public string DisplayName => "FHIR R5";
    }
    
    public class Patient : ResourceBase<R5Version>, IFhirResource<R5Version>
    {
        public R5Version Version => new();
        public string ResourceType => "Patient";
        
        // R5 特定屬性
        public List<HumanName>? Name { get; set; }
        public CodeableConcept? Gender { get; set; }
        // ... 其他 R5 Patient 屬性
    }
}
```

### 3. 開發者使用方式
```csharp
// 方案 A: 明確版本選擇
using FhirCore.R5;
using R5Patient = FhirCore.R5.Patient;

var patient = new R5Patient
{
    Name = new List<HumanName> { ... }
};

// 方案 B: 工廠模式
using FhirCore.Factory;

var factory = FhirFactory.ForVersion("R5");
var patient = factory.CreateResource<Patient>();

// 方案 C: 強型別版本選擇
using FhirCore.R5;

public class MyR5Service
{
    public void ProcessPatient(Patient patient) // 明確為 R5 Patient
    {
        // 編譯時期就確定版本，完整 IntelliSense 支援
    }
}
```

## 優勢

### 1. 編譯時期版本安全
- 開發者在專案中明確選擇版本
- IDE 提供完整的版本特定 IntelliSense
- 編譯時期就能發現版本不相容問題

### 2. 簡化的相依性管理
```xml
<!-- 使用 R5 的專案 -->
<PackageReference Include="FhirCore.R5" Version="1.0.0" />

<!-- 使用 R4 的專案 -->
<PackageReference Include="FhirCore.R4" Version="1.0.0" />

<!-- 同時支援多版本的專案 -->
<PackageReference Include="FhirCore.R4" Version="1.0.0" />
<PackageReference Include="FhirCore.R5" Version="1.0.0" />
```

### 3. 獨立版本演進
- 每個版本可以獨立更新
- 減少版本間的相互影響
- 便於維護和測試

### 4. 更好的開發者體驗
- 清晰的套件選擇
- 完整的 IntelliSense 支援
- 減少執行時期錯誤

### 5. 靈活的部署選項
- 只部署需要的版本
- 減少應用程式大小
- 提高載入效能

## 遷移策略

### 階段 1: 重構核心架構 (2-3 週)
1. 建立新的 FhirCore 基礎套件
2. 重構 DataTypeServices 為共用套件
3. 建立版本特定的基礎架構

### 階段 2: 建立 R5 版本套件 (2-3 週)
1. 建立 FhirCore.R5 專案
2. 遷移現有 R5 資源到新架構
3. 實作 R5 特定驗證邏輯

### 階段 3: 建立 R4 版本套件 (2-3 週)
1. 建立 FhirCore.R4 專案
2. 實作 R4 資源和驗證
3. 確保 R4/R5 並存

### 階段 4: 工具和文件 (1-2 週)
1. 建立遷移工具
2. 撰寫使用文件
3. 建立範例專案

## 技術考量

### 命名空間策略
```csharp
// 清晰的命名空間區分
FhirCore.R4.Resources.Patient
FhirCore.R5.Resources.Patient
FhirCore.R6.Resources.Patient

// 或使用別名
using R4 = FhirCore.R4.Resources;
using R5 = FhirCore.R5.Resources;

var r4Patient = new R4.Patient();
var r5Patient = new R5.Patient();
```

### 共用程式碼處理
```csharp
// 使用泛型基礎類別處理共用邏輯
public abstract class ResourceBase<TVersion> 
    where TVersion : IFhirVersion, new()
{
    public string Id { get; set; }
    public abstract string ResourceType { get; }
    public TVersion Version => new();
    
    // 共用驗證邏輯
    public virtual ValidationResult Validate()
    {
        // 基礎驗證
    }
}
```

### 序列化支援
```csharp
// 版本感知的序列化
public class FhirJsonConverter<TVersion> : JsonConverter
    where TVersion : IFhirVersion
{
    public override object ReadJson(JsonReader reader, Type objectType, 
        object existingValue, JsonSerializer serializer)
    {
        // 版本特定的反序列化邏輯
    }
}
```

這個架構將提供更好的開發者體驗、更清晰的版本管理，以及更靈活的部署選項。建議優先實作這個新架構來解決目前的問題。