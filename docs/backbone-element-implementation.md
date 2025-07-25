# BackboneElement 實作設計

## 🎯 BackboneElement 特性分析

### FHIR 中的 BackboneElement
BackboneElement 是 FHIR 中一個特殊的設計，具有以下特性：

1. **類似 XML Group** - 用於組織 Resource 內部的複雜結構
2. **繼承 Element** - 擁有 id 和 extension 屬性
3. **支援 modifierExtension** - 可以修改父元素語義的擴展
4. **Resource 特定** - 每個 Resource 的 BackboneElement 都是獨特的
5. **巢狀結構** - 可以包含其他 BackboneElement

### 繼承層次
```
Base (抽象)
└── Element (抽象) : Base
    ├── id: string
    ├── extension: List<Extension>
    └── BackboneElement (抽象) : Element
        ├── modifierExtension: List<Extension>
        └── 具體的 BackboneElement 實作
            ├── Patient.Contact : BackboneElement
            ├── Observation.Component : BackboneElement
            ├── Bundle.Entry : BackboneElement
            └── ... 每個 Resource 特定的 BackboneElement
```

## ✅ 實作設計

### 1. BackboneElement 基礎類別

#### BackboneElement.cs
```csharp
namespace Fhir.R4.Models.Base;

/// <summary>
/// Base definition for all elements that are defined inside a resource - but not those in a data type.
/// BackboneElement 用於組織 Resource 內部的複雜結構，類似 XML 的 Group 概念
/// </summary>
public abstract class BackboneElement : Element
{
    /// <summary>
    /// May be used to represent additional information that is not part of the basic definition 
    /// of the element and that modifies the understanding of the element in which it is contained 
    /// and/or the understanding of the containing element's descendants.
    /// 
    /// 重要：modifierExtension 可以改變父元素的語義，必須謹慎處理
    /// </summary>
    [JsonPropertyName("modifierExtension")]
    public List<Extension>? ModifierExtension { get; set; }
    
    /// <summary>
    /// 檢查是否有 modifier extensions
    /// </summary>
    [JsonIgnore]
    public bool HasModifierExtensions => ModifierExtension?.Any() == true;
    
    /// <summary>
    /// 取得指定 URL 的 modifier extension
    /// </summary>
    public Extension? GetModifierExtension(string url)
    {
        return ModifierExtension?.FirstOrDefault(ext => ext.Url == url);
    }
    
    /// <summary>
    /// 添加 modifier extension
    /// </summary>
    public void AddModifierExtension(string url, object? value)
    {
        ModifierExtension ??= new List<Extension>();
        ModifierExtension.Add(new Extension { Url = url, Value = value });
    }
    
    /// <summary>
    /// 移除指定 URL 的 modifier extension
    /// </summary>
    public bool RemoveModifierExtension(string url)
    {
        if (ModifierExtension == null) return false;
        
        var toRemove = ModifierExtension.Where(ext => ext.Url == url).ToList();
        foreach (var ext in toRemove)
        {
            ModifierExtension.Remove(ext);
        }
        
        return toRemove.Any();
    }
    
    /// <summary>
    /// FHIR 驗證：檢查 modifierExtension 的使用是否正確
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;
        
        // 驗證 modifierExtension
        if (ModifierExtension != null)
        {
            foreach (var modExt in ModifierExtension)
            {
                if (string.IsNullOrEmpty(modExt.Url))
                {
                    yield return new ValidationResult("ModifierExtension must have a URL");
                }
                
                // 檢查是否為已知的 modifier extension
                if (!IsKnownModifierExtension(modExt.Url))
                {
                    yield return new ValidationResult(
                        $"Unknown modifier extension: {modExt.Url}. " +
                        "Modifier extensions can change the meaning of the element, " +
                        "so unknown modifier extensions should be handled carefully.");
                }
            }
        }
    }
    
    /// <summary>
    /// 檢查是否為已知的 modifier extension
    /// 子類別可以覆寫此方法來定義特定的 modifier extension
    /// </summary>
    protected virtual bool IsKnownModifierExtension(string url)
    {
        // 預設的已知 modifier extensions
        return url switch
        {
            "http://hl7.org/fhir/StructureDefinition/data-absent-reason" => true,
            "http://hl7.org/fhir/StructureDefinition/iso21090-nullFlavor" => true,
            _ => false
        };
    }
}
```

### 2. 具體 BackboneElement 實作範例

#### Patient.Contact (PatientContact.cs)
```csharp
namespace Fhir.R4.Models.Resources;

public partial class Patient
{
    /// <summary>
    /// A contact party (e.g. guardian, partner, friend) for the patient.
    /// Patient 的聯絡人資訊 - 繼承 BackboneElement
    /// </summary>
    public class Contact : BackboneElement
    {
        /// <summary>
        /// The nature of the relationship between the patient and the contact person.
        /// </summary>
        [JsonPropertyName("relationship")]
        public List<CodeableConcept>? Relationship { get; set; }
        
        /// <summary>
        /// A name associated with the contact person.
        /// </summary>
        [JsonPropertyName("name")]
        public HumanName? Name { get; set; }
        
        /// <summary>
        /// A contact detail for the person, e.g. a telephone number or an email address.
        /// </summary>
        [JsonPropertyName("telecom")]
        public List<ContactPoint>? Telecom { get; set; }
        
        /// <summary>
        /// Address for the contact person.
        /// </summary>
        [JsonPropertyName("address")]
        public Address? Address { get; set; }
        
        /// <summary>
        /// Administrative Gender - the gender that the contact person is considered to have 
        /// for administration and record keeping purposes.
        /// </summary>
        [JsonPropertyName("gender")]
        public string? Gender { get; set; }
        
        /// <summary>
        /// Organization on behalf of which the contact is acting or for which the contact is working.
        /// </summary>
        [JsonPropertyName("organization")]
        public ReferenceImpl? Organization { get; set; }
        
        /// <summary>
        /// The period during which this contact person or organization is valid to be contacted 
        /// relating to this patient.
        /// </summary>
        [JsonPropertyName("period")]
        public Period? Period { get; set; }
        
        /// <summary>
        /// Patient.Contact 特定的驗證規則
        /// </summary>
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            foreach (var result in base.Validate(validationContext))
                yield return result;
            
            // Contact 必須至少有 name, telecom, address, 或 organization 其中之一
            if (Name == null && 
                (Telecom == null || !Telecom.Any()) && 
                Address == null && 
                Organization == null)
            {
                yield return new ValidationResult(
                    "Patient.Contact must have at least one of: name, telecom, address, or organization");
            }
        }
        
        /// <summary>
        /// Patient.Contact 已知的 modifier extensions
        /// </summary>
        protected override bool IsKnownModifierExtension(string url)
        {
            return url switch
            {
                "http://hl7.org/fhir/StructureDefinition/patient-contact-priority" => true,
                _ => base.IsKnownModifierExtension(url)
            };
        }
    }
}
```

#### Observation.Component (ObservationComponent.cs)
```csharp
namespace Fhir.R4.Models.Resources;

public partial class Observation
{
    /// <summary>
    /// Some observations have multiple component observations.
    /// Observation 的組成部分 - 繼承 BackboneElement
    /// </summary>
    public class Component : BackboneElement
    {
        /// <summary>
        /// Describes what was observed. Sometimes this is called the observation "code".
        /// </summary>
        [JsonPropertyName("code")]
        public CodeableConcept Code { get; set; } = new();
        
        // Choice Type: value[x] - 觀察值可以是多種型別
        [JsonPropertyName("valueQuantity")]
        public QuantityImpl? ValueQuantity { get; set; }
        
        [JsonPropertyName("valueCodeableConcept")]
        public CodeableConcept? ValueCodeableConcept { get; set; }
        
        [JsonPropertyName("valueString")]
        public string? ValueString { get; set; }
        
        [JsonPropertyName("valueBoolean")]
        public bool? ValueBoolean { get; set; }
        
        [JsonPropertyName("valueInteger")]
        public int? ValueInteger { get; set; }
        
        [JsonPropertyName("valueRange")]
        public Range? ValueRange { get; set; }
        
        [JsonPropertyName("valueRatio")]
        public Ratio? ValueRatio { get; set; }
        
        [JsonPropertyName("valueSampledData")]
        public SampledData? ValueSampledData { get; set; }
        
        [JsonPropertyName("valueTime")]
        public string? ValueTime { get; set; }
        
        [JsonPropertyName("valueDateTime")]
        public string? ValueDateTime { get; set; }
        
        [JsonPropertyName("valuePeriod")]
        public Period? ValuePeriod { get; set; }
        
        /// <summary>
        /// 便利屬性：統一存取 value[x]
        /// </summary>
        [JsonIgnore]
        public object? Value
        {
            get => ValueQuantity ?? ValueCodeableConcept ?? (object?)ValueString ?? 
                   ValueBoolean ?? ValueInteger ?? ValueRange ?? ValueRatio ?? 
                   ValueSampledData ?? ValueTime ?? ValueDateTime ?? ValuePeriod;
            set
            {
                // 清除所有現有值
                ClearValueProperties();
                
                // 根據型別設定對應屬性
                switch (value)
                {
                    case QuantityImpl q: ValueQuantity = q; break;
                    case CodeableConcept cc: ValueCodeableConcept = cc; break;
                    case string s: ValueString = s; break;
                    case bool b: ValueBoolean = b; break;
                    case int i: ValueInteger = i; break;
                    case Range r: ValueRange = r; break;
                    case Ratio rat: ValueRatio = rat; break;
                    case SampledData sd: ValueSampledData = sd; break;
                    case Period p: ValuePeriod = p; break;
                    default:
                        if (value != null)
                            throw new ArgumentException($"Unsupported value type: {value.GetType().Name}");
                        break;
                }
            }
        }
        
        /// <summary>
        /// Provides a reason why the expected value in the element Observation.component.value[x] is missing.
        /// </summary>
        [JsonPropertyName("dataAbsentReason")]
        public CodeableConcept? DataAbsentReason { get; set; }
        
        /// <summary>
        /// A categorical assessment of an observation value.
        /// </summary>
        [JsonPropertyName("interpretation")]
        public List<CodeableConcept>? Interpretation { get; set; }
        
        /// <summary>
        /// Guidance on how to interpret the value by comparison to a normal or recommended range.
        /// </summary>
        [JsonPropertyName("referenceRange")]
        public List<Observation.ReferenceRange>? ReferenceRange { get; set; }
        
        private void ClearValueProperties()
        {
            ValueQuantity = null;
            ValueCodeableConcept = null;
            ValueString = null;
            ValueBoolean = null;
            ValueInteger = null;
            ValueRange = null;
            ValueRatio = null;
            ValueSampledData = null;
            ValueTime = null;
            ValueDateTime = null;
            ValuePeriod = null;
        }
        
        /// <summary>
        /// Observation.Component 特定的驗證規則
        /// </summary>
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            foreach (var result in base.Validate(validationContext))
                yield return result;
            
            // Code 是必要的
            if (Code == null || (Code.Coding == null || !Code.Coding.Any()) && string.IsNullOrEmpty(Code.Text))
            {
                yield return new ValidationResult("Observation.Component.code is required");
            }
            
            // value[x] 和 dataAbsentReason 不能同時存在
            if (Value != null && DataAbsentReason != null)
            {
                yield return new ValidationResult(
                    "Observation.Component cannot have both value[x] and dataAbsentReason");
            }
            
            // 必須有 value[x] 或 dataAbsentReason 其中之一
            if (Value == null && DataAbsentReason == null)
            {
                yield return new ValidationResult(
                    "Observation.Component must have either value[x] or dataAbsentReason");
            }
        }
    }
}
```

#### Bundle.Entry (BundleEntry.cs)
```csharp
namespace Fhir.R4.Models.Resources;

public partial class Bundle
{
    /// <summary>
    /// An entry in a bundle resource - will either contain a resource or information about a resource.
    /// Bundle 的條目 - 繼承 BackboneElement
    /// </summary>
    public class Entry : BackboneElement
    {
        /// <summary>
        /// A series of links that provide context to this entry.
        /// </summary>
        [JsonPropertyName("link")]
        public List<Bundle.Link>? Link { get; set; }
        
        /// <summary>
        /// The Absolute URL for the resource.
        /// </summary>
        [JsonPropertyName("fullUrl")]
        public string? FullUrl { get; set; }
        
        /// <summary>
        /// The Resource for the entry.
        /// 使用 ResourceWrapper 解決 Resource 抽象類別問題
        /// </summary>
        [JsonPropertyName("resource")]
        public ResourceWrapper? Resource { get; set; }
        
        /// <summary>
        /// Information about the search process that lead to the creation of this entry.
        /// </summary>
        [JsonPropertyName("search")]
        public Bundle.Search? Search { get; set; }
        
        /// <summary>
        /// Additional information about how this entry should be processed as part of a transaction or batch.
        /// </summary>
        [JsonPropertyName("request")]
        public Bundle.Request? Request { get; set; }
        
        /// <summary>
        /// Indicates the results of processing the corresponding 'request' entry.
        /// </summary>
        [JsonPropertyName("response")]
        public Bundle.Response? Response { get; set; }
        
        /// <summary>
        /// Bundle.Entry 特定的驗證規則
        /// </summary>
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            foreach (var result in base.Validate(validationContext))
                yield return result;
            
            // 根據 Bundle 型別驗證不同的規則
            var bundle = validationContext.ObjectInstance as Bundle;
            if (bundle != null)
            {
                switch (bundle.Type)
                {
                    case "document":
                        // Document bundle 的第一個 entry 必須是 Composition
                        if (bundle.Entry?.FirstOrDefault() == this && 
                            Resource?.ResourceType != "Composition")
                        {
                            yield return new ValidationResult(
                                "First entry in a document bundle must be a Composition");
                        }
                        break;
                        
                    case "message":
                        // Message bundle 的第一個 entry 必須是 MessageHeader
                        if (bundle.Entry?.FirstOrDefault() == this && 
                            Resource?.ResourceType != "MessageHeader")
                        {
                            yield return new ValidationResult(
                                "First entry in a message bundle must be a MessageHeader");
                        }
                        break;
                        
                    case "transaction":
                    case "batch":
                        // Transaction/batch bundle 的每個 entry 都必須有 request
                        if (Request == null)
                        {
                            yield return new ValidationResult(
                                "Entries in transaction/batch bundles must have a request");
                        }
                        break;
                }
            }
            
            // fullUrl 格式驗證
            if (!string.IsNullOrEmpty(FullUrl) && !Uri.IsWellFormedUriString(FullUrl, UriKind.Absolute))
            {
                yield return new ValidationResult("Bundle.Entry.fullUrl must be a valid absolute URL");
            }
        }
    }
}
```

## 🔧 生成器實作

### BackboneElement 自動生成
```csharp
public class BackboneElementGenerator
{
    public void GenerateBackboneElement(StructureDefinition definition, string resourceName, string elementName)
    {
        var className = $"{resourceName}{ToPascalCase(elementName)}";
        
        var code = $@"
namespace Fhir.R4.Models.Resources;

public partial class {resourceName}
{{
    /// <summary>
    /// {definition.Description}
    /// </summary>
    public class {ToPascalCase(elementName)} : BackboneElement
    {{
        {GenerateProperties(definition.Snapshot.Element)}
        
        {GenerateValidationMethod(definition)}
        
        {GenerateModifierExtensionMethod(definition)}
    }}
}}";
        
        SaveToFile($"Resources/{resourceName}/{className}.cs", code);
    }
    
    private string GenerateProperties(List<ElementDefinition> elements)
    {
        var properties = new StringBuilder();
        
        foreach (var element in elements.Where(e => e.Path.Contains('.')))
        {
            var propertyName = GetPropertyName(element.Path);
            var propertyType = _typeMapper.MapFhirTypeToCSharp(
                element.Type?.FirstOrDefault()?.Code ?? "string",
                element.Max == "*",
                needsConcrete: true
            );
            
            properties.AppendLine($@"
        /// <summary>
        /// {element.Short}
        /// </summary>
        [JsonPropertyName(""{element.Path.Split('.').Last()}"")]
        public {propertyType} {propertyName} {{ get; set; }}");
        }
        
        return properties.ToString();
    }
}
```

## ✅ 優點

1. **正確的繼承層次** - BackboneElement 繼承 Element，支援 modifierExtension
2. **Resource 特定** - 每個 Resource 的 BackboneElement 都是獨特的類別
3. **型別安全** - 強型別的屬性和方法
4. **FHIR 驗證** - 內建 FHIR 特定的驗證規則
5. **modifierExtension 支援** - 正確處理可以改變語義的擴展
6. **便利方法** - 提供易用的 API 來操作 extensions

## 🎯 總結

BackboneElement 的正確實作：
- ✅ **繼承 Element** - 擁有 id 和 extension
- ✅ **支援 modifierExtension** - 可以改變父元素語義
- ✅ **Resource 特定** - 每個都是獨特的類別
- ✅ **型別安全** - 強型別的屬性定義
- ✅ **FHIR 驗證** - 內建驗證規則
- ✅ **便利使用** - 提供易用的 API

這確保了 BackboneElement 既符合 FHIR 規範，又提供良好的開發體驗！
