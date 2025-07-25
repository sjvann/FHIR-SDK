# XML 文件註解標準與規範

## 🎯 XML 註解問題與解決方案

### 常見問題
1. **過長的註解** - 影響可讀性和維護性
2. **特殊字元** - XML 保留字元造成編譯錯誤
3. **HTML 標籤** - FHIR 文件中的 HTML 需要處理
4. **換行問題** - 不當的換行造成格式錯誤
5. **Unicode 字元** - 特殊字元造成編碼問題

## ✅ 解決方案規範

### 1. 長度限制
```csharp
// ✅ 正確：簡潔明瞭的註解
/// <summary>
/// The patient's primary identifier used for medical records.
/// </summary>
public Identifier? Identifier { get; set; }

// ❌ 錯誤：過長的註解
/// <summary>
/// This is a very long description that goes on and on and provides way too much detail about every possible aspect of this property including historical context, implementation details, and various edge cases that most developers will never encounter in their day-to-day work with this SDK.
/// </summary>
public Identifier? Identifier { get; set; }
```

### 2. 特殊字元處理
```csharp
// ✅ 正確：轉義特殊字元
/// <summary>
/// Compares values using &lt; and &gt; operators.
/// Use &quot;exact&quot; for precise matching.
/// </summary>

// ❌ 錯誤：未轉義的特殊字元
/// <summary>
/// Compares values using < and > operators.
/// Use "exact" for precise matching.
/// </summary>
```

### 3. HTML 標籤處理
```csharp
// ✅ 正確：移除或轉換 HTML 標籤
/// <summary>
/// Patient contact information including:
/// - Phone numbers
/// - Email addresses  
/// - Physical addresses
/// </summary>

// ❌ 錯誤：保留 HTML 標籤
/// <summary>
/// Patient contact information including:<br/>
/// <ul>
/// <li>Phone numbers</li>
/// <li>Email addresses</li>
/// </ul>
/// </summary>
```

### 4. 換行和格式
```csharp
// ✅ 正確：適當的換行
/// <summary>
/// A human's name with the ability to identify parts and usage.
/// This includes family name, given names, prefixes, and suffixes.
/// </summary>

// ❌ 錯誤：不當的換行
/// <summary>
/// A human's name with the ability to identify parts and usage. This includes family name, given names, prefixes, and suffixes that can be very long and should be wrapped properly.
/// </summary>
```

## 🏗️ 實作範例

### 1. 基本類別註解
```csharp
/// <summary>
/// Represents a patient in the healthcare system.
/// Contains demographic and administrative information.
/// </summary>
/// <remarks>
/// This class implements the FHIR R4 Patient resource specification.
/// All properties follow FHIR naming conventions and cardinality rules.
/// </remarks>
public class Patient : DomainResource
{
    // ...
}
```

### 2. 屬性註解
```csharp
/// <summary>
/// Whether this patient record is in active use.
/// FHIR Path: Patient.active
/// Cardinality: 0..1
/// </summary>
[JsonPropertyName("active")]
public bool? Active { get; set; }

/// <summary>
/// A name associated with the individual.
/// FHIR Path: Patient.name
/// Cardinality: 0..*
/// </summary>
[JsonPropertyName("name")]
public List<HumanName>? Name { get; set; }
```

### 3. Choice Type 註解
```csharp
/// <summary>
/// Indicates if the individual is deceased or not.
/// 
/// Choice Type: deceased[x]
/// This is a choice element - only one of the following types may be present:
///   - boolean
///   - dateTime
/// </summary>
[JsonIgnore]
public ChoiceType<FhirBoolean, FhirDateTime>? DeceasedChoice { get; set; }
```

### 4. Reference 註解
```csharp
/// <summary>
/// The organization that is the custodian of the patient record.
/// 
/// Reference to:
///   - Organization
/// </summary>
[JsonPropertyName("managingOrganization")]
public Reference<Organization>? ManagingOrganization { get; set; }
```

### 5. BackboneElement 註解
```csharp
/// <summary>
/// A contact party (e.g. guardian, partner, friend) for the patient.
/// 
/// BackboneElement for Patient.Contact
/// This element is defined within the resource and contains additional
/// structured information that is part of the resource definition.
/// </summary>
public class Contact : BackboneElement
{
    // ...
}
```

### 6. 方法註解
```csharp
/// <summary>
/// Validates the patient data according to FHIR rules.
/// </summary>
/// <param name="validationContext">The validation context containing the patient data</param>
/// <returns>A collection of validation results indicating any errors or warnings</returns>
/// <exception cref="ArgumentNullException">Thrown when validationContext is null</exception>
public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
{
    // ...
}
```

## 🔧 自動生成規則

### 1. 長度限制
- **Summary**: 最大 500 字元
- **行長度**: 最大 120 字元
- **自動換行**: 超過長度時自動換行

### 2. 文字清理流程
```
原始 FHIR 文字
    ↓
移除多餘空白和換行
    ↓
處理 HTML 標籤
    ↓
轉義 XML 特殊字元
    ↓
移除控制字元
    ↓
標準化引號和標點
    ↓
自動換行
    ↓
最終 XML 註解
```

### 3. 特殊情況處理
```csharp
// FHIR 原始描述（可能包含問題）
var originalText = "Use <code>exact</code> for precise matching & validation.";

// 清理後的註解
/// <summary>
/// Use exact for precise matching &amp; validation.
/// </summary>
```

## 📋 驗證規則

### 1. 編譯時驗證
- XML 格式正確性
- 特殊字元轉義
- 標籤配對完整

### 2. 內容驗證
- 長度限制遵循
- 換行格式正確
- 無控制字元

### 3. 一致性驗證
- 命名規範統一
- 格式風格一致
- FHIR 術語正確

## 🎯 最佳實踐

### 1. 簡潔明瞭
```csharp
// ✅ 好的註解
/// <summary>
/// Patient's birth date in YYYY-MM-DD format.
/// </summary>

// ❌ 冗長的註解
/// <summary>
/// This property represents the date on which the patient was born, 
/// formatted according to the ISO 8601 standard using the YYYY-MM-DD 
/// format as specified in the FHIR specification for date values.
/// </summary>
```

### 2. 包含關鍵資訊
```csharp
/// <summary>
/// Administrative gender of the patient.
/// FHIR Path: Patient.gender
/// Required: No
/// Allowed values: male, female, other, unknown
/// </summary>
```

### 3. 避免實作細節
```csharp
// ✅ 好的註解 - 描述用途
/// <summary>
/// Validates that the patient has required demographic information.
/// </summary>

// ❌ 壞的註解 - 描述實作
/// <summary>
/// Loops through all properties and checks if Name and BirthDate are not null.
/// </summary>
```

### 4. 使用標準術語
```csharp
/// <summary>
/// FHIR Resource identifier for this patient.
/// Cardinality: 0..1
/// Type: string
/// </summary>
```

## 🚀 自動化工具

### 1. XmlDocumentationGenerator 使用
```csharp
var docGenerator = new XmlDocumentationGenerator();

// 生成類別註解
var classDoc = docGenerator.GenerateClassDocumentation(
    summary: fhirDefinition.Description,
    remarks: $"FHIR {fhirVersion} {resourceType} Resource"
);

// 生成屬性註解
var propertyDoc = docGenerator.GeneratePropertyDocumentation(
    summary: element.Short,
    fhirPath: element.Path,
    cardinality: $"{element.Min}..{element.Max}",
    isRequired: element.Min > 0
);
```

### 2. 驗證工具
```csharp
// 驗證生成的註解
if (!docGenerator.ValidateXmlDocumentation(generatedDoc))
{
    throw new InvalidOperationException("Generated XML documentation is invalid");
}
```

## ✅ 總結

正確的 XML 註解確保：
- ✅ **編譯成功** - 無 XML 格式錯誤
- ✅ **可讀性佳** - 適當的長度和格式
- ✅ **資訊完整** - 包含必要的 FHIR 資訊
- ✅ **一致性** - 統一的風格和格式
- ✅ **專業性** - 符合 .NET 文件標準

這確保了生成的 SDK 具有高品質的文件，提供優秀的開發者體驗！
