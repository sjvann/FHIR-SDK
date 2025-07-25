# Element-Extension 循環依賴解決方案

## 🎯 問題描述

FHIR 的 Element 和 Extension 之間存在循環依賴：

```
Element
├── id: string
└── extension: List<Extension>
    └── Extension : DataType
        └── DataType : Element  ← 循環依賴！
```

這個設計造成：
1. **循環繼承問題** - 無法正確編譯
2. **型別系統混亂** - Extension 既是 DataType 又包含在 Element 中
3. **設計不清晰** - 違反物件導向設計原則

## ✅ 解決方案：重新設計型別層次

### 方案 1：Extension 不繼承 DataType（推薦）

#### 新的型別層次
```
Base (抽象)
├── Element (抽象) : Base
│   ├── id: string
│   └── extension: List<Extension>
├── DataType (抽象) : Element  
│   └── 所有 Complex DataTypes
└── Extension : Base  ← 直接繼承 Base，打破循環
    ├── url: string
    └── value[x]: DataType
```

#### 實作
```csharp
// 1. Base 類別
public abstract class Base
{
    // 最基礎的 FHIR 型別，沒有任何屬性
}

// 2. Extension 類別 - 直接繼承 Base
public class Extension : Base
{
    [JsonPropertyName("url")]
    public string Url { get; set; }
    
    // Choice Type: value[x]
    [JsonPropertyName("valueString")]
    public string? ValueString { get; set; }
    
    [JsonPropertyName("valueInteger")]
    public int? ValueInteger { get; set; }
    
    [JsonPropertyName("valueBoolean")]
    public bool? ValueBoolean { get; set; }
    
    // ... 所有其他 value[x] 型別
    
    [JsonPropertyName("extension")]
    public List<Extension>? Extension { get; set; }  // Extension 可以有子 Extension
    
    // 便利屬性
    [JsonIgnore]
    public object? Value
    {
        get => ValueString ?? (object?)ValueInteger ?? ValueBoolean;
        set
        {
            ClearValueProperties();
            switch (value)
            {
                case string s: ValueString = s; break;
                case int i: ValueInteger = i; break;
                case bool b: ValueBoolean = b; break;
                // ... 處理所有型別
            }
        }
    }
}

// 3. Element 類別 - 包含 Extension
public abstract class Element : Base
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    
    [JsonPropertyName("extension")]
    public List<Extension>? Extension { get; set; }
}

// 4. DataType 類別 - 繼承 Element
public abstract class DataType : Element
{
    // 所有可重用型別的基礎
}
```

### 方案 2：使用介面分離（備選）

#### 設計思路
```csharp
// 1. 基礎介面
public interface IFhirElement
{
    string? Id { get; set; }
}

public interface IExtensible
{
    List<Extension>? Extension { get; set; }
}

// 2. Extension 實作基礎介面但不繼承 Element
public class Extension : Base, IFhirElement
{
    public string? Id { get; set; }  // 實作 IFhirElement
    public string Url { get; set; }
    // ... value[x] 屬性
    public List<Extension>? Extension { get; set; }  // 自己的子 Extension
}

// 3. Element 實作兩個介面
public abstract class Element : Base, IFhirElement, IExtensible
{
    public string? Id { get; set; }
    public List<Extension>? Extension { get; set; }
}

// 4. DataType 繼承 Element
public abstract class DataType : Element
{
    // 所有可重用型別的基礎
}
```

## 🏗️ 推薦實作：方案 1

### 完整的類別定義

#### Base.cs
```csharp
namespace Fhir.R4.Models.Base;

/// <summary>
/// Base definition for all types defined in FHIR type system.
/// 所有 FHIR 型別的最基礎類別
/// </summary>
public abstract class Base
{
    // 空的基礎類別，提供型別系統的根
}
```

#### Extension.cs
```csharp
namespace Fhir.R4.Models.Base;

/// <summary>
/// Optional Extension Element - may be used to represent additional information 
/// that is not part of the basic definition of the element.
/// 直接繼承 Base，避免與 Element 的循環依賴
/// </summary>
[JsonConverter(typeof(ExtensionConverter))]
public class Extension : Base
{
    /// <summary>
    /// Source of the definition for the extension code - a logical name or a URL.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;
    
    // Choice Type: value[x] - 所有可能的值型別
    [JsonPropertyName("valueBase64Binary")]
    public byte[]? ValueBase64Binary { get; set; }
    
    [JsonPropertyName("valueBoolean")]
    public bool? ValueBoolean { get; set; }
    
    [JsonPropertyName("valueCanonical")]
    public string? ValueCanonical { get; set; }
    
    [JsonPropertyName("valueCode")]
    public string? ValueCode { get; set; }
    
    [JsonPropertyName("valueDate")]
    public string? ValueDate { get; set; }
    
    [JsonPropertyName("valueDateTime")]
    public string? ValueDateTime { get; set; }
    
    [JsonPropertyName("valueDecimal")]
    public decimal? ValueDecimal { get; set; }
    
    [JsonPropertyName("valueId")]
    public string? ValueId { get; set; }
    
    [JsonPropertyName("valueInstant")]
    public DateTimeOffset? ValueInstant { get; set; }
    
    [JsonPropertyName("valueInteger")]
    public int? ValueInteger { get; set; }
    
    [JsonPropertyName("valueInteger64")]
    public long? ValueInteger64 { get; set; }
    
    [JsonPropertyName("valueMarkdown")]
    public string? ValueMarkdown { get; set; }
    
    [JsonPropertyName("valueOid")]
    public string? ValueOid { get; set; }
    
    [JsonPropertyName("valuePositiveInt")]
    public uint? ValuePositiveInt { get; set; }
    
    [JsonPropertyName("valueString")]
    public string? ValueString { get; set; }
    
    [JsonPropertyName("valueTime")]
    public TimeSpan? ValueTime { get; set; }
    
    [JsonPropertyName("valueUnsignedInt")]
    public uint? ValueUnsignedInt { get; set; }
    
    [JsonPropertyName("valueUri")]
    public string? ValueUri { get; set; }
    
    [JsonPropertyName("valueUrl")]
    public string? ValueUrl { get; set; }
    
    [JsonPropertyName("valueUuid")]
    public string? ValueUuid { get; set; }
    
    // Complex Types
    [JsonPropertyName("valueAddress")]
    public Address? ValueAddress { get; set; }
    
    [JsonPropertyName("valueAge")]
    public Age? ValueAge { get; set; }
    
    [JsonPropertyName("valueAnnotation")]
    public Annotation? ValueAnnotation { get; set; }
    
    [JsonPropertyName("valueAttachment")]
    public Attachment? ValueAttachment { get; set; }
    
    [JsonPropertyName("valueCodeableConcept")]
    public CodeableConcept? ValueCodeableConcept { get; set; }
    
    [JsonPropertyName("valueCoding")]
    public Coding? ValueCoding { get; set; }
    
    [JsonPropertyName("valueContactPoint")]
    public ContactPoint? ValueContactPoint { get; set; }
    
    [JsonPropertyName("valueCount")]
    public Count? ValueCount { get; set; }
    
    [JsonPropertyName("valueDistance")]
    public Distance? ValueDistance { get; set; }
    
    [JsonPropertyName("valueDuration")]
    public Duration? ValueDuration { get; set; }
    
    [JsonPropertyName("valueHumanName")]
    public HumanName? ValueHumanName { get; set; }
    
    [JsonPropertyName("valueIdentifier")]
    public Identifier? ValueIdentifier { get; set; }
    
    [JsonPropertyName("valueMoney")]
    public Money? ValueMoney { get; set; }
    
    [JsonPropertyName("valuePeriod")]
    public Period? ValuePeriod { get; set; }
    
    [JsonPropertyName("valueQuantity")]
    public QuantityImpl? ValueQuantity { get; set; }
    
    [JsonPropertyName("valueRange")]
    public Range? ValueRange { get; set; }
    
    [JsonPropertyName("valueRatio")]
    public Ratio? ValueRatio { get; set; }
    
    [JsonPropertyName("valueReference")]
    public ReferenceImpl? ValueReference { get; set; }
    
    [JsonPropertyName("valueSampledData")]
    public SampledData? ValueSampledData { get; set; }
    
    [JsonPropertyName("valueSignature")]
    public Signature? ValueSignature { get; set; }
    
    [JsonPropertyName("valueTiming")]
    public Timing? ValueTiming { get; set; }
    
    // 巢狀 Extensions
    [JsonPropertyName("extension")]
    public List<Extension>? Extension { get; set; }
    
    /// <summary>
    /// 便利屬性：取得或設定 Extension 的值
    /// 自動處理不同型別的 value[x] 屬性
    /// </summary>
    [JsonIgnore]
    public object? Value
    {
        get
        {
            // 按照優先順序返回第一個非 null 的值
            return ValueString ?? ValueInteger ?? ValueBoolean ?? ValueDecimal ??
                   ValueDate ?? ValueDateTime ?? ValueInstant ?? ValueTime ??
                   ValueUri ?? ValueUrl ?? ValueCanonical ?? ValueCode ??
                   ValueId ?? ValueOid ?? ValueUuid ?? ValueMarkdown ??
                   (object?)ValueBase64Binary ?? ValueInteger64 ?? ValuePositiveInt ?? ValueUnsignedInt ??
                   ValueAddress ?? ValueAge ?? ValueAnnotation ?? ValueAttachment ??
                   ValueCodeableConcept ?? ValueCoding ?? ValueContactPoint ??
                   ValueCount ?? ValueDistance ?? ValueDuration ?? ValueHumanName ??
                   ValueIdentifier ?? ValueMoney ?? ValuePeriod ?? ValueQuantity ??
                   ValueRange ?? ValueRatio ?? ValueReference ?? ValueSampledData ??
                   ValueSignature ?? ValueTiming;
        }
        set
        {
            // 清除所有現有值
            ClearAllValues();
            
            // 根據型別設定對應的屬性
            switch (value)
            {
                case string s: ValueString = s; break;
                case int i: ValueInteger = i; break;
                case bool b: ValueBoolean = b; break;
                case decimal d: ValueDecimal = d; break;
                case DateTime dt: ValueDateTime = dt.ToString("yyyy-MM-ddTHH:mm:ss.fffK"); break;
                case DateTimeOffset dto: ValueInstant = dto; break;
                case TimeSpan ts: ValueTime = ts; break;
                case byte[] ba: ValueBase64Binary = ba; break;
                case long l: ValueInteger64 = l; break;
                case uint ui: ValueUnsignedInt = ui; break;
                
                // Complex Types
                case Address addr: ValueAddress = addr; break;
                case Age age: ValueAge = age; break;
                case Annotation ann: ValueAnnotation = ann; break;
                case Attachment att: ValueAttachment = att; break;
                case CodeableConcept cc: ValueCodeableConcept = cc; break;
                case Coding cod: ValueCoding = cod; break;
                case ContactPoint cp: ValueContactPoint = cp; break;
                case Count cnt: ValueCount = cnt; break;
                case Distance dist: ValueDistance = dist; break;
                case Duration dur: ValueDuration = dur; break;
                case HumanName hn: ValueHumanName = hn; break;
                case Identifier id: ValueIdentifier = id; break;
                case Money mon: ValueMoney = mon; break;
                case Period per: ValuePeriod = per; break;
                case QuantityImpl qty: ValueQuantity = qty; break;
                case Range rng: ValueRange = rng; break;
                case Ratio rat: ValueRatio = rat; break;
                case ReferenceImpl rf: ValueReference = rf; break;
                case SampledData sd: ValueSampledData = sd; break;
                case Signature sig: ValueSignature = sig; break;
                case Timing tim: ValueTiming = tim; break;
                
                default:
                    throw new ArgumentException($"Unsupported value type: {value?.GetType().Name}");
            }
        }
    }
    
    /// <summary>
    /// 清除所有 value[x] 屬性
    /// </summary>
    private void ClearAllValues()
    {
        // Primitive types
        ValueBase64Binary = null;
        ValueBoolean = null;
        ValueCanonical = null;
        ValueCode = null;
        ValueDate = null;
        ValueDateTime = null;
        ValueDecimal = null;
        ValueId = null;
        ValueInstant = null;
        ValueInteger = null;
        ValueInteger64 = null;
        ValueMarkdown = null;
        ValueOid = null;
        ValuePositiveInt = null;
        ValueString = null;
        ValueTime = null;
        ValueUnsignedInt = null;
        ValueUri = null;
        ValueUrl = null;
        ValueUuid = null;
        
        // Complex types
        ValueAddress = null;
        ValueAge = null;
        ValueAnnotation = null;
        ValueAttachment = null;
        ValueCodeableConcept = null;
        ValueCoding = null;
        ValueContactPoint = null;
        ValueCount = null;
        ValueDistance = null;
        ValueDuration = null;
        ValueHumanName = null;
        ValueIdentifier = null;
        ValueMoney = null;
        ValuePeriod = null;
        ValueQuantity = null;
        ValueRange = null;
        ValueRatio = null;
        ValueReference = null;
        ValueSampledData = null;
        ValueSignature = null;
        ValueTiming = null;
    }
    
    /// <summary>
    /// 取得目前設定的值型別名稱
    /// </summary>
    [JsonIgnore]
    public string? ValueTypeName
    {
        get
        {
            if (ValueString != null) return "string";
            if (ValueInteger != null) return "integer";
            if (ValueBoolean != null) return "boolean";
            if (ValueDecimal != null) return "decimal";
            if (ValueDate != null) return "date";
            if (ValueDateTime != null) return "dateTime";
            if (ValueInstant != null) return "instant";
            if (ValueTime != null) return "time";
            if (ValueUri != null) return "uri";
            if (ValueUrl != null) return "url";
            if (ValueCanonical != null) return "canonical";
            if (ValueCode != null) return "code";
            if (ValueId != null) return "id";
            if (ValueOid != null) return "oid";
            if (ValueUuid != null) return "uuid";
            if (ValueMarkdown != null) return "markdown";
            if (ValueBase64Binary != null) return "base64Binary";
            if (ValueInteger64 != null) return "integer64";
            if (ValuePositiveInt != null) return "positiveInt";
            if (ValueUnsignedInt != null) return "unsignedInt";
            
            // Complex types
            if (ValueAddress != null) return "Address";
            if (ValueAge != null) return "Age";
            if (ValueAnnotation != null) return "Annotation";
            if (ValueAttachment != null) return "Attachment";
            if (ValueCodeableConcept != null) return "CodeableConcept";
            if (ValueCoding != null) return "Coding";
            if (ValueContactPoint != null) return "ContactPoint";
            if (ValueCount != null) return "Count";
            if (ValueDistance != null) return "Distance";
            if (ValueDuration != null) return "Duration";
            if (ValueHumanName != null) return "HumanName";
            if (ValueIdentifier != null) return "Identifier";
            if (ValueMoney != null) return "Money";
            if (ValuePeriod != null) return "Period";
            if (ValueQuantity != null) return "Quantity";
            if (ValueRange != null) return "Range";
            if (ValueRatio != null) return "Ratio";
            if (ValueReference != null) return "Reference";
            if (ValueSampledData != null) return "SampledData";
            if (ValueSignature != null) return "Signature";
            if (ValueTiming != null) return "Timing";
            
            return null;
        }
    }
}
```

#### Element.cs
```csharp
namespace Fhir.R4.Models.Base;

/// <summary>
/// Base definition for all elements in a resource.
/// 現在可以安全地包含 Extension 而不會有循環依賴
/// </summary>
public abstract class Element : Base
{
    /// <summary>
    /// Unique id for the element within a resource (for internal references).
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    
    /// <summary>
    /// Additional information that is not part of the basic definition of the element.
    /// </summary>
    [JsonPropertyName("extension")]
    public List<Extension>? Extension { get; set; }
}
```

#### DataType.cs
```csharp
namespace Fhir.R4.Models.Base;

/// <summary>
/// The base class for all re-usable types defined as part of the FHIR Specification.
/// 現在可以安全地繼承 Element
/// </summary>
public abstract class DataType : Element
{
    // 所有可重用型別的基礎
    // 繼承了 Element 的 id 和 extension 屬性
}
```

## ✅ 優點

1. **打破循環依賴** - Extension 直接繼承 Base，不再循環
2. **保持 FHIR 語義** - Extension 仍然可以包含所有 FHIR 定義的值型別
3. **型別系統清晰** - 清楚的繼承層次
4. **便利使用** - 提供 Value 屬性統一存取
5. **完全相容** - 與 FHIR 規範完全相容

## 🎯 總結

這個解決方案：
- ✅ **解決循環依賴** - Extension 不再繼承 DataType
- ✅ **保持功能完整** - Extension 仍支援所有 FHIR 功能
- ✅ **型別系統清晰** - 清楚的繼承關係
- ✅ **易於實作** - 避免複雜的設計模式

這是處理 FHIR Element-Extension 循環依賴的最佳解決方案！
