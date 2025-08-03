# FHIR SDK 架構重構實作計畫

## 問題分析

### 當前架構問題
1. **版本混合問題** - `ResourceTypeServices.R5` 命名空間下混合了所有 R5 資源
2. **IntelliSense 支援不佳** - 開發者無法在編譯時期獲得精確的版本特定提示
3. **類型衝突風險** - 不同版本的相同資源類型可能產生衝突
4. **維護複雜度高** - 版本管理器需要複雜的類型映射
5. **部署包冗餘** - 應用程式需要包含所有版本的程式碼

## 建議的新架構

### 專案結構重組
```
FhirSDK/
├── Docs/                           # 文件目錄
├── FhirCore/                       # 核心共用專案
│   ├── Interfaces/                 # 共用介面
│   ├── Base/                       # 基礎類別
│   ├── Validation/                 # 共用驗證邏輯
│   └── Common/                     # 共用工具
├── DataTypeServices/               # 資料類型服務 (版本無關)
├── TerminologyService/             # 術語服務 (版本無關)
├── FhirCore.R4/                   # R4 版本特定專案
│   ├── Resources/                  # R4 資源
│   ├── DataTypes/                  # R4 特定資料類型
│   └── Validation/                 # R4 驗證邏輯
├── FhirCore.R5/                   # R5 版本特定專案
│   ├── Resources/                  # R5 資源
│   ├── DataTypes/                  # R5 特定資料類型
│   └── Validation/                 # R5 驗證邏輯
└── FhirCore.R6/                   # R6 版本特定專案 (未來)
```

### NuGet 套件策略
```
FhirCore                           # 基礎套件
├── DataTypeServices              # 資料類型
├── TerminologyService            # 術語服務
├── FhirCore.R4                   # R4 完整套件
├── FhirCore.R5                   # R5 完整套件
└── FhirCore.Tools                # 開發工具套件
```

## 實作步驟

### 第一階段：建立新的核心架構 (1-2 週)

#### 1.1 重構 FhirCore 專案
```csharp
// FhirCore/Interfaces/IFhirVersion.cs
namespace FhirCore.Interfaces
{
    public interface IFhirVersion
    {
        string VersionNumber { get; }
        string DisplayName { get; }
        string Specification { get; }
    }
}

// FhirCore/Interfaces/IFhirResource.cs
namespace FhirCore.Interfaces
{
    public interface IFhirResource<TVersion> where TVersion : IFhirVersion
    {
        string Id { get; set; }
        string ResourceType { get; }
        TVersion Version { get; }
        ValidationResult Validate();
    }
}
```

#### 1.2 建立版本特定基礎類別
```csharp
// FhirCore/Base/ResourceBase.cs
namespace FhirCore.Base
{
    public abstract class ResourceBase<TVersion> : IFhirResource<TVersion> 
        where TVersion : IFhirVersion, new()
    {
        public string Id { get; set; } = string.Empty;
        public abstract string ResourceType { get; }
        public TVersion Version => new();
        
        public virtual ValidationResult Validate()
        {
            // 基礎驗證邏輯
            return ValidationResult.Success();
        }
    }
}
```

### 第二階段：建立 R5 版本專案 (2-3 週)

#### 2.1 建立 FhirCore.R5 專案
```xml
<!-- FhirCore.R5/FhirCore.R5.csproj -->
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>net9.0</TargetFramework>
    <PackageId>FhirCore.R5</PackageId>
    <Version>1.0.0</Version>
    <Title>FHIR R5 Implementation</Title>
    <Description>FHIR R5 資源和資料類型實作</Description>
  </PropertyGroup>
  
  <ItemGroup>
    <ProjectReference Include="../FhirCore/FhirCore.csproj" />
    <ProjectReference Include="../DataTypeServices/DataTypeServices.csproj" />
    <ProjectReference Include="../TerminologyService/TerminologyService.csproj" />
  </ItemGroup>
</Project>
```

#### 2.2 定義 R5 版本
```csharp
// FhirCore.R5/R5Version.cs
namespace FhirCore.R5
{
    public class R5Version : IFhirVersion
    {
        public string VersionNumber => "5.0.0";
        public string DisplayName => "FHIR R5";
        public string Specification => "http://hl7.org/fhir/R5/";
    }
}
```

#### 2.3 遷移 R5 資源
```csharp
// FhirCore.R5/Resources/Patient.cs
namespace FhirCore.R5.Resources
{
    public class Patient : ResourceBase<R5Version>
    {
        public override string ResourceType => "Patient";
        
        // R5 特定屬性
        public List<HumanName>? Name { get; set; }
        public CodeableConcept? Gender { get; set; }
        public FhirDate? BirthDate { get; set; }
        
        // R5 特定驗證
        public override ValidationResult Validate()
        {
            var result = base.Validate();
            // R5 特定驗證邏輯
            return result;
        }
    }
}
```

### 第三階段：建立 R4 版本專案 (2-3 週)

#### 3.1 建立 FhirCore.R4 專案
```csharp
// FhirCore.R4/R4Version.cs
namespace FhirCore.R4
{
    public class R4Version : IFhirVersion
    {
        public string VersionNumber => "4.0.1";
        public string DisplayName => "FHIR R4";
        public string Specification => "http://hl7.org/fhir/R4/";
    }
}

// FhirCore.R4/Resources/Patient.cs
namespace FhirCore.R4.Resources
{
    public class Patient : ResourceBase<R4Version>
    {
        public override string ResourceType => "Patient";
        
        // R4 特定屬性 (可能與 R5 略有不同)
        public List<HumanName>? Name { get; set; }
        public FhirCode? Gender { get; set; }  // R4 使用 code，R5 使用 CodeableConcept
        public FhirDate? BirthDate { get; set; }
        
        // R4 特定驗證
        public override ValidationResult Validate()
        {
            var result = base.Validate();
            // R4 特定驗證邏輯
            return result;
        }
    }
}
```

### 第四階段：開發者體驗優化 (1-2 週)

#### 4.1 工廠模式支援
```csharp
// FhirCore/Factory/FhirFactory.cs
namespace FhirCore.Factory
{
    public static class FhirFactory
    {
        public static class R4
        {
            public static FhirCore.R4.Resources.Patient CreatePatient() 
                => new FhirCore.R4.Resources.Patient();
            
            public static FhirCore.R4.Resources.Observation CreateObservation() 
                => new FhirCore.R4.Resources.Observation();
        }
        
        public static class R5
        {
            public static FhirCore.R5.Resources.Patient CreatePatient() 
                => new FhirCore.R5.Resources.Patient();
            
            public static FhirCore.R5.Resources.Observation CreateObservation() 
                => new FhirCore.R5.Resources.Observation();
        }
    }
}
```

#### 4.2 版本特定擴展方法
```csharp
// FhirCore.R5/Extensions/R5Extensions.cs
namespace FhirCore.R5.Extensions
{
    public static class R5Extensions
    {
        public static Patient WithName(this Patient patient, string given, string family)
        {
            patient.Name = new List<HumanName>
            {
                new HumanName
                {
                    Given = new List<FhirString> { new(given) },
                    Family = new FhirString(family)
                }
            };
            return patient;
        }
    }
}
```

## 開發者使用方式

### 方案 A：明確版本選擇
```csharp
// 專案只需引用特定版本
// <PackageReference Include="FhirCore.R5" Version="1.0.0" />

using FhirCore.R5.Resources;
using FhirCore.R5.Extensions;

// 編譯時期確定版本，完整 IntelliSense 支援
var patient = new Patient()
    .WithName("John", "Doe")
    .WithGender(GenderCodes.Male);
```

### 方案 B：工廠模式
```csharp
using FhirCore.Factory;

var r5Patient = FhirFactory.R5.CreatePatient();
var r4Patient = FhirFactory.R4.CreatePatient();
```

### 方案 C：多版本支援
```csharp
// 同時引用多個版本
// <PackageReference Include="FhirCore.R4" Version="1.0.0" />
// <PackageReference Include="FhirCore.R5" Version="1.0.0" />

using R4 = FhirCore.R4.Resources;
using R5 = FhirCore.R5.Resources;

var r4Patient = new R4.Patient();
var r5Patient = new R5.Patient();
```

## 遷移策略

### 自動遷移工具
```csharp
// FhirCore.Tools/Migration/VersionMigrator.cs
namespace FhirCore.Tools.Migration
{
    public static class VersionMigrator
    {
        public static FhirCore.R5.Resources.Patient MigrateToR5(
            FhirCore.R4.Resources.Patient r4Patient)
        {
            return new FhirCore.R5.Resources.Patient
            {
                Id = r4Patient.Id,
                Name = r4Patient.Name,
                // 處理 Gender 的轉換
                Gender = ConvertGender(r4Patient.Gender),
                BirthDate = r4Patient.BirthDate
            };
        }
        
        private static CodeableConcept? ConvertGender(FhirCode? r4Gender)
        {
            if (r4Gender?.Value == null) return null;
            
            return new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri("http://hl7.org/fhir/administrative-gender"),
                        Code = new FhirCode(r4Gender.Value),
                        Display = new FhirString(GetGenderDisplay(r4Gender.Value))
                    }
                }
            };
        }
    }
}
```

## 建議的下一步行動

### 立即行動
1. 建立 `Docs/` 目錄並將此計畫文件放入
2. 開始重構 `FhirCore` 專案的介面定義
3. 建立 `FhirCore.R5` 專案並遷移現有 R5 資源

### 中期行動
1. 建立 `FhirCore.R4` 專案
2. 實作版本間的遷移工具
3. 建立完整的使用文件和範例

### 長期行動
1. 為未來的 R6 版本預留架構空間
2. 建立 CI/CD 流程支援多版本測試
3. 建立社群貢獻指南

這個新架構將徹底解決當前的問題，提供更好的開發者體驗和更清晰的版本管理。