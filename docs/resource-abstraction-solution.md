# Resource 抽象類別實例化解決方案

## 🎯 問題描述

Resource 繼承結構中的抽象類別實例化問題：

```
Base (抽象)
└── Resource (抽象) : Base
    ├── DomainResource (抽象) : Resource
    │   ├── Patient : DomainResource
    │   ├── Observation : DomainResource
    │   └── ... 其他領域資源
    └── Infrastructure Resources : Resource
        ├── Bundle : Resource
        ├── OperationOutcome : Resource
        └── ... 其他基礎設施資源
```

### 問題場景
```csharp
// Bundle.entry.resource 需要能包含任何 Resource
public class BundleEntry : BackboneElement
{
    [JsonPropertyName("resource")]
    public Resource Resource { get; set; }  // ❌ 抽象類別無法實例化
}

// Parameters.parameter.resource 同樣問題
public class ParametersParameter : BackboneElement
{
    [JsonPropertyName("resource")]
    public Resource Resource { get; set; }  // ❌ 抽象類別無法實例化
}
```

## ✅ 解決方案：多重策略

### 策略 1：ResourceWrapper 模式（推薦）

#### 設計思路
建立一個 ResourceWrapper 類別，可以包裝任何具體的 Resource 實例，同時提供統一的 Resource 介面。

```csharp
// 1. 保持原有的抽象 Resource 類別
public abstract class Resource : Base
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    
    [JsonPropertyName("meta")]
    public Meta? Meta { get; set; }
    
    [JsonPropertyName("implicitRules")]
    public string? ImplicitRules { get; set; }
    
    [JsonPropertyName("language")]
    public string? Language { get; set; }
    
    [JsonPropertyName("resourceType")]
    public abstract string ResourceType { get; }
}

// 2. ResourceWrapper - 可以包裝任何具體 Resource
[JsonConverter(typeof(ResourceWrapperConverter))]
public class ResourceWrapper : Resource
{
    private Resource? _wrappedResource;
    
    public ResourceWrapper() { }
    
    public ResourceWrapper(Resource resource)
    {
        _wrappedResource = resource ?? throw new ArgumentNullException(nameof(resource));
        
        // 複製基本屬性
        Id = resource.Id;
        Meta = resource.Meta;
        ImplicitRules = resource.ImplicitRules;
        Language = resource.Language;
    }
    
    [JsonIgnore]
    public Resource? WrappedResource 
    { 
        get => _wrappedResource;
        set 
        {
            _wrappedResource = value;
            if (value != null)
            {
                Id = value.Id;
                Meta = value.Meta;
                ImplicitRules = value.ImplicitRules;
                Language = value.Language;
            }
        }
    }
    
    [JsonPropertyName("resourceType")]
    public override string ResourceType => _wrappedResource?.ResourceType ?? "Unknown";
    
    // 型別安全的轉換方法
    public T? As<T>() where T : Resource => _wrappedResource as T;
    
    public bool Is<T>() where T : Resource => _wrappedResource is T;
    
    // 隱式轉換
    public static implicit operator ResourceWrapper(Patient patient) => new(patient);
    public static implicit operator ResourceWrapper(Observation observation) => new(observation);
    public static implicit operator ResourceWrapper(Bundle bundle) => new(bundle);
    // ... 為所有 Resource 類型添加隱式轉換
    
    // 明確轉換
    public static explicit operator Patient?(ResourceWrapper wrapper) => wrapper.As<Patient>();
    public static explicit operator Observation?(ResourceWrapper wrapper) => wrapper.As<Observation>();
    public static explicit operator Bundle?(ResourceWrapper wrapper) => wrapper.As<Bundle>();
    // ... 為所有 Resource 類型添加明確轉換
}
```

#### 使用方式
```csharp
// Bundle 使用 ResourceWrapper
public class BundleEntry : BackboneElement
{
    [JsonPropertyName("resource")]
    public ResourceWrapper? Resource { get; set; }  // ✅ 可以實例化
}

// 使用範例
var bundle = new Bundle();
var entry = new BundleEntry();

// 方式 1：直接賦值（透過隱式轉換）
var patient = new Patient { Id = "patient-001" };
entry.Resource = patient;  // Patient → ResourceWrapper

// 方式 2：明確建立
entry.Resource = new ResourceWrapper(patient);

// 取值
if (entry.Resource?.Is<Patient>() == true)
{
    var retrievedPatient = entry.Resource.As<Patient>();
    // 或使用明確轉換
    var retrievedPatient2 = (Patient?)entry.Resource;
}
```

### 策略 2：泛型 Resource 容器

#### 設計思路
```csharp
// 泛型資源容器
public class ResourceContainer<T> where T : Resource
{
    [JsonPropertyName("resource")]
    public T? Resource { get; set; }
    
    // 轉換到通用容器
    public ResourceContainer ToGeneric() => new ResourceContainer { Resource = Resource };
}

// 通用資源容器
public class ResourceContainer
{
    [JsonPropertyName("resource")]
    public ResourceWrapper? Resource { get; set; }
    
    // 轉換到強型別容器
    public ResourceContainer<T>? As<T>() where T : Resource
    {
        if (Resource?.Is<T>() == true)
        {
            return new ResourceContainer<T> { Resource = Resource.As<T>() };
        }
        return null;
    }
}
```

### 策略 3：介面分離模式

#### 設計思路
```csharp
// 資源介面
public interface IResource
{
    string? Id { get; set; }
    Meta? Meta { get; set; }
    string? ImplicitRules { get; set; }
    string? Language { get; set; }
    string ResourceType { get; }
}

// 具體資源實作介面
public class Patient : DomainResource, IResource
{
    // Patient 的具體實作
}

// 在需要通用 Resource 的地方使用介面
public class BundleEntry : BackboneElement
{
    [JsonPropertyName("resource")]
    public IResource? Resource { get; set; }  // ✅ 介面可以實例化
}
```

## 🏗️ 推薦實作：ResourceWrapper 模式

### 完整實作

#### ResourceWrapper.cs
```csharp
namespace Fhir.R4.Models.Base;

/// <summary>
/// Resource 包裝器，解決抽象 Resource 類別無法實例化的問題
/// 可以包裝任何具體的 Resource 實例
/// </summary>
[JsonConverter(typeof(ResourceWrapperConverter))]
public class ResourceWrapper : Resource
{
    private Resource? _wrappedResource;
    
    public ResourceWrapper() { }
    
    public ResourceWrapper(Resource resource)
    {
        WrappedResource = resource ?? throw new ArgumentNullException(nameof(resource));
    }
    
    /// <summary>
    /// 被包裝的具體 Resource 實例
    /// </summary>
    [JsonIgnore]
    public Resource? WrappedResource 
    { 
        get => _wrappedResource;
        set 
        {
            _wrappedResource = value;
            if (value != null)
            {
                // 同步基本屬性
                Id = value.Id;
                Meta = value.Meta;
                ImplicitRules = value.ImplicitRules;
                Language = value.Language;
            }
        }
    }
    
    /// <summary>
    /// 資源型別名稱
    /// </summary>
    [JsonPropertyName("resourceType")]
    public override string ResourceType => _wrappedResource?.ResourceType ?? "Unknown";
    
    /// <summary>
    /// 型別安全的轉換方法
    /// </summary>
    public T? As<T>() where T : Resource => _wrappedResource as T;
    
    /// <summary>
    /// 檢查是否為指定型別
    /// </summary>
    public bool Is<T>() where T : Resource => _wrappedResource is T;
    
    /// <summary>
    /// 檢查是否為指定型別名稱
    /// </summary>
    public bool Is(string resourceType) => ResourceType == resourceType;
    
    // 隱式轉換 - 讓使用更便利
    public static implicit operator ResourceWrapper?(Resource? resource) 
        => resource == null ? null : new ResourceWrapper(resource);
    
    // 常用 Resource 的明確轉換
    public static explicit operator Patient?(ResourceWrapper? wrapper) => wrapper?.As<Patient>();
    public static explicit operator Observation?(ResourceWrapper? wrapper) => wrapper?.As<Observation>();
    public static explicit operator Bundle?(ResourceWrapper? wrapper) => wrapper?.As<Bundle>();
    public static explicit operator Organization?(ResourceWrapper? wrapper) => wrapper?.As<Organization>();
    public static explicit operator Practitioner?(ResourceWrapper? wrapper) => wrapper?.As<Practitioner>();
    public static explicit operator Encounter?(ResourceWrapper? wrapper) => wrapper?.As<Encounter>();
    public static explicit operator Condition?(ResourceWrapper? wrapper) => wrapper?.As<Condition>();
    public static explicit operator Procedure?(ResourceWrapper? wrapper) => wrapper?.As<Procedure>();
    public static explicit operator MedicationRequest?(ResourceWrapper? wrapper) => wrapper?.As<MedicationRequest>();
    public static explicit operator DiagnosticReport?(ResourceWrapper? wrapper) => wrapper?.As<DiagnosticReport>();
    
    /// <summary>
    /// 建立強型別的 ResourceWrapper
    /// </summary>
    public static ResourceWrapper<T> Create<T>(T resource) where T : Resource
        => new ResourceWrapper<T>(resource);
}

/// <summary>
/// 強型別的 Resource 包裝器
/// </summary>
public class ResourceWrapper<T> : ResourceWrapper where T : Resource
{
    public ResourceWrapper() { }
    
    public ResourceWrapper(T resource) : base(resource) { }
    
    /// <summary>
    /// 強型別的 Resource 存取
    /// </summary>
    [JsonIgnore]
    public new T? WrappedResource 
    { 
        get => base.WrappedResource as T;
        set => base.WrappedResource = value;
    }
    
    // 隱式轉換
    public static implicit operator ResourceWrapper<T>?(T? resource) 
        => resource == null ? null : new ResourceWrapper<T>(resource);
    
    public static explicit operator T?(ResourceWrapper<T>? wrapper) 
        => wrapper?.WrappedResource;
}
```

#### ResourceWrapperConverter.cs
```csharp
namespace Fhir.R4.Models.Converters;

/// <summary>
/// ResourceWrapper 的 JSON 轉換器
/// 處理序列化和反序列化
/// </summary>
public class ResourceWrapperConverter : JsonConverter<ResourceWrapper>
{
    public override ResourceWrapper? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
            return null;
            
        // 讀取 JSON 物件
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        
        // 取得 resourceType
        if (!root.TryGetProperty("resourceType", out var resourceTypeElement))
            throw new JsonException("Resource must have a resourceType property");
            
        var resourceType = resourceTypeElement.GetString();
        if (string.IsNullOrEmpty(resourceType))
            throw new JsonException("resourceType cannot be null or empty");
        
        // 根據 resourceType 反序列化為具體型別
        var concreteResource = DeserializeConcreteResource(root, resourceType, options);
        
        return new ResourceWrapper(concreteResource);
    }
    
    public override void Write(Utf8JsonWriter writer, ResourceWrapper value, JsonSerializerOptions options)
    {
        if (value?.WrappedResource == null)
        {
            writer.WriteNullValue();
            return;
        }
        
        // 直接序列化被包裝的 Resource
        JsonSerializer.Serialize(writer, value.WrappedResource, value.WrappedResource.GetType(), options);
    }
    
    private Resource DeserializeConcreteResource(JsonElement element, string resourceType, JsonSerializerOptions options)
    {
        // 根據 resourceType 映射到具體的 C# 型別
        var concreteType = GetConcreteResourceType(resourceType);
        if (concreteType == null)
            throw new JsonException($"Unknown resource type: {resourceType}");
        
        // 反序列化為具體型別
        var json = element.GetRawText();
        var resource = JsonSerializer.Deserialize(json, concreteType, options) as Resource;
        
        return resource ?? throw new JsonException($"Failed to deserialize {resourceType}");
    }
    
    private Type? GetConcreteResourceType(string resourceType)
    {
        // 資源型別映射表
        return resourceType switch
        {
            "Patient" => typeof(Patient),
            "Observation" => typeof(Observation),
            "Bundle" => typeof(Bundle),
            "Organization" => typeof(Organization),
            "Practitioner" => typeof(Practitioner),
            "Encounter" => typeof(Encounter),
            "Condition" => typeof(Condition),
            "Procedure" => typeof(Procedure),
            "MedicationRequest" => typeof(MedicationRequest),
            "DiagnosticReport" => typeof(DiagnosticReport),
            "OperationOutcome" => typeof(OperationOutcome),
            "Parameters" => typeof(Parameters),
            // ... 添加所有 Resource 型別
            _ => null
        };
    }
}
```

### 使用範例

#### Bundle 中使用
```csharp
public class Bundle : Resource
{
    public class BundleEntry : BackboneElement
    {
        [JsonPropertyName("resource")]
        public ResourceWrapper? Resource { get; set; }  // ✅ 可以實例化
    }
}

// 使用方式
var bundle = new Bundle();

// 添加 Patient
var patient = new Patient { Id = "patient-001", Active = true };
bundle.Entry.Add(new BundleEntry { Resource = patient });  // 隱式轉換

// 添加 Observation
var observation = new Observation { Id = "obs-001", Status = "final" };
bundle.Entry.Add(new BundleEntry { Resource = observation });

// 讀取資源
foreach (var entry in bundle.Entry)
{
    if (entry.Resource?.Is<Patient>() == true)
    {
        var pat = entry.Resource.As<Patient>();
        Console.WriteLine($"Patient: {pat?.Id}");
    }
    else if (entry.Resource?.Is<Observation>() == true)
    {
        var obs = entry.Resource.As<Observation>();
        Console.WriteLine($"Observation: {obs?.Id}");
    }
}
```

#### Parameters 中使用
```csharp
public class Parameters : Resource
{
    public class ParametersParameter : BackboneElement
    {
        [JsonPropertyName("resource")]
        public ResourceWrapper? Resource { get; set; }  // ✅ 可以實例化
    }
}
```

## 🔧 型別映射器更新

### 在 FhirCompliantTypeMapper 中處理
```csharp
public string MapFhirTypeToCSharp(string fhirType, bool isArray = false, bool needsConcrete = false)
{
    // 特殊處理 Resource 型別
    if (fhirType == "Resource" && needsConcrete)
    {
        return isArray ? "List<ResourceWrapper>?" : "ResourceWrapper?";
    }
    
    // 其他型別的正常處理
    return base.MapFhirTypeToCSharp(fhirType, isArray, needsConcrete);
}
```

## ✅ 優點

1. **解決實例化問題** - ResourceWrapper 可以實例化
2. **型別安全** - 提供強型別的轉換方法
3. **便利使用** - 隱式轉換讓使用更簡單
4. **完全相容** - 與 FHIR JSON 格式完全相容
5. **效能良好** - 最小的包裝開銷
6. **可擴展** - 容易添加新的 Resource 型別

## 🎯 總結

ResourceWrapper 模式解決了 Resource 抽象類別的實例化問題：
- ✅ **可以實例化** - ResourceWrapper 是具體類別
- ✅ **包裝任何 Resource** - 支援所有具體 Resource 型別
- ✅ **型別安全轉換** - 提供 As<T>() 和 Is<T>() 方法
- ✅ **便利使用** - 隱式轉換和明確轉換
- ✅ **JSON 相容** - 透過自定義 Converter 處理序列化

這確保了 Bundle.entry.resource 和其他類似場景可以正常工作！
