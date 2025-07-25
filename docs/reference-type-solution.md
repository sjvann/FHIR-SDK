# FHIR Reference 型別完整解決方案

## 🎯 Reference 複雜性分析

### FHIR Reference 的挑戰
1. **型別限制** - 每個 Reference 屬性都限制能參照的 Resource 型別
2. **多重目標** - 一個 Reference 可能允許參照多種 Resource
3. **Profile 限制** - 可能限制特定的 Profile
4. **參照格式** - 支援相對、絕對、邏輯參照
5. **解析驗證** - 需要驗證參照的有效性

### 典型使用場景
```csharp
// Observation.subject 只能參照 Patient, Group, Device, Location
public class Observation : DomainResource
{
    public Reference Subject { get; set; }  // ❌ 無法限制型別
}

// Encounter.participant.individual 只能參照 Practitioner, PractitionerRole
public class EncounterParticipant : BackboneElement
{
    public Reference Individual { get; set; }  // ❌ 無法限制型別
}
```

## ✅ 解決方案：強型別 Reference 系統

### 策略 1：泛型 Reference（推薦）

#### 設計思路
```csharp
// 基礎 Reference 類別
public abstract class Reference : DataType
{
    [JsonPropertyName("reference")]
    public string? ReferenceValue { get; set; }
    
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    
    [JsonPropertyName("identifier")]
    public Identifier? Identifier { get; set; }
    
    [JsonPropertyName("display")]
    public string? Display { get; set; }
}

// 強型別 Reference
public class Reference<T> : Reference where T : Resource
{
    // 型別安全的方法
    public bool IsValidTarget(Resource resource) => resource is T;
    public T? ResolveAs() => ResolvedResource as T;
    
    [JsonIgnore]
    public T? ResolvedResource { get; set; }
}

// 多型別 Reference
public class Reference<T1, T2> : Reference 
    where T1 : Resource 
    where T2 : Resource
{
    public bool IsValidTarget(Resource resource) => resource is T1 or T2;
}
```

#### 實作

##### Reference.cs
```csharp
namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// A reference from one resource to another.
/// 基礎 Reference 類別，提供所有 Reference 的共同功能
/// </summary>
[JsonConverter(typeof(ReferenceConverter))]
public abstract class Reference : DataType
{
    /// <summary>
    /// A reference to a location at which the other resource is found.
    /// </summary>
    [JsonPropertyName("reference")]
    public string? ReferenceValue { get; set; }
    
    /// <summary>
    /// The expected type of the target of the reference.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    
    /// <summary>
    /// An identifier for the target resource.
    /// </summary>
    [JsonPropertyName("identifier")]
    public Identifier? Identifier { get; set; }
    
    /// <summary>
    /// Plain text narrative that identifies the resource in addition to the resource reference.
    /// </summary>
    [JsonPropertyName("display")]
    public string? Display { get; set; }
    
    /// <summary>
    /// 解析後的 Resource（如果已載入）
    /// </summary>
    [JsonIgnore]
    public ResourceWrapper? ResolvedResource { get; set; }
    
    /// <summary>
    /// 檢查參照是否為空
    /// </summary>
    [JsonIgnore]
    public bool IsEmpty => string.IsNullOrEmpty(ReferenceValue) && 
                          Identifier == null && 
                          string.IsNullOrEmpty(Display);
    
    /// <summary>
    /// 取得參照的 Resource ID
    /// </summary>
    [JsonIgnore]
    public string? ResourceId
    {
        get
        {
            if (string.IsNullOrEmpty(ReferenceValue)) return null;
            
            // 處理不同格式的參照
            if (ReferenceValue.Contains('/'))
            {
                var parts = ReferenceValue.Split('/');
                return parts.Length >= 2 ? parts[^1] : null;
            }
            
            return ReferenceValue;
        }
    }
    
    /// <summary>
    /// 取得參照的 Resource 型別
    /// </summary>
    [JsonIgnore]
    public string? ResourceType
    {
        get
        {
            if (!string.IsNullOrEmpty(Type)) return Type;
            
            if (string.IsNullOrEmpty(ReferenceValue)) return null;
            
            // 從參照字串中解析型別
            if (ReferenceValue.Contains('/'))
            {
                var parts = ReferenceValue.Split('/');
                return parts.Length >= 2 ? parts[^2] : null;
            }
            
            return null;
        }
    }
    
    /// <summary>
    /// 檢查是否為相對參照
    /// </summary>
    [JsonIgnore]
    public bool IsRelativeReference => !string.IsNullOrEmpty(ReferenceValue) && 
                                      !ReferenceValue.StartsWith("http");
    
    /// <summary>
    /// 檢查是否為絕對參照
    /// </summary>
    [JsonIgnore]
    public bool IsAbsoluteReference => !string.IsNullOrEmpty(ReferenceValue) && 
                                      ReferenceValue.StartsWith("http");
    
    /// <summary>
    /// 檢查是否為邏輯參照（只有 identifier）
    /// </summary>
    [JsonIgnore]
    public bool IsLogicalReference => string.IsNullOrEmpty(ReferenceValue) && 
                                     Identifier != null;
    
    /// <summary>
    /// 抽象方法：檢查目標 Resource 是否為有效型別
    /// </summary>
    public abstract bool IsValidTarget(Resource resource);
    
    /// <summary>
    /// 抽象方法：取得允許的目標型別列表
    /// </summary>
    public abstract string[] GetAllowedTargetTypes();
    
    /// <summary>
    /// 建立參照字串
    /// </summary>
    public static string CreateReference(string resourceType, string id)
    {
        return $"{resourceType}/{id}";
    }
    
    /// <summary>
    /// 建立絕對參照字串
    /// </summary>
    public static string CreateAbsoluteReference(string baseUrl, string resourceType, string id)
    {
        return $"{baseUrl.TrimEnd('/')}/{resourceType}/{id}";
    }
    
    /// <summary>
    /// FHIR 驗證
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;
        
        // Reference 必須有 reference 或 identifier
        if (string.IsNullOrEmpty(ReferenceValue) && Identifier == null)
        {
            yield return new ValidationResult("Reference must have either reference or identifier");
        }
        
        // 如果有 reference，檢查格式
        if (!string.IsNullOrEmpty(ReferenceValue))
        {
            if (!IsValidReferenceFormat(ReferenceValue))
            {
                yield return new ValidationResult($"Invalid reference format: {ReferenceValue}");
            }
        }
        
        // 檢查 type 是否與 reference 一致
        if (!string.IsNullOrEmpty(Type) && !string.IsNullOrEmpty(ReferenceValue))
        {
            var inferredType = ResourceType;
            if (!string.IsNullOrEmpty(inferredType) && inferredType != Type)
            {
                yield return new ValidationResult(
                    $"Reference type '{Type}' does not match inferred type '{inferredType}'");
            }
        }
        
        // 檢查是否為允許的目標型別
        if (!string.IsNullOrEmpty(ResourceType))
        {
            var allowedTypes = GetAllowedTargetTypes();
            if (!allowedTypes.Contains(ResourceType))
            {
                yield return new ValidationResult(
                    $"Reference target type '{ResourceType}' is not allowed. " +
                    $"Allowed types: {string.Join(", ", allowedTypes)}");
            }
        }
    }
    
    private bool IsValidReferenceFormat(string reference)
    {
        // 絕對 URL
        if (reference.StartsWith("http"))
        {
            return Uri.IsWellFormedUriString(reference, UriKind.Absolute);
        }
        
        // 相對參照：ResourceType/id 或 ResourceType/id/_history/vid
        var parts = reference.Split('/');
        if (parts.Length < 2) return false;
        
        // 檢查 ResourceType 是否有效
        var resourceType = parts[0];
        if (string.IsNullOrEmpty(resourceType) || !char.IsUpper(resourceType[0]))
            return false;
        
        // 檢查 ID 是否有效
        var id = parts[1];
        if (string.IsNullOrEmpty(id))
            return false;
        
        return true;
    }
}
```

##### 強型別 Reference 實作
```csharp
namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// 單一型別的強型別 Reference
/// </summary>
public class Reference<T> : Reference where T : Resource
{
    private static readonly string[] _allowedTypes = { GetResourceTypeName<T>() };
    
    public override bool IsValidTarget(Resource resource) => resource is T;
    
    public override string[] GetAllowedTargetTypes() => _allowedTypes;
    
    /// <summary>
    /// 型別安全的解析方法
    /// </summary>
    public T? ResolveAs() => ResolvedResource?.As<T>();
    
    /// <summary>
    /// 設定參照目標
    /// </summary>
    public void SetTarget(T resource)
    {
        if (resource == null) throw new ArgumentNullException(nameof(resource));
        
        ReferenceValue = CreateReference(GetResourceTypeName<T>(), resource.Id ?? "");
        Type = GetResourceTypeName<T>();
        ResolvedResource = new ResourceWrapper(resource);
    }
    
    /// <summary>
    /// 建立對指定 Resource 的參照
    /// </summary>
    public static Reference<T> To(T resource)
    {
        var reference = new Reference<T>();
        reference.SetTarget(resource);
        return reference;
    }
    
    /// <summary>
    /// 建立對指定 ID 的參照
    /// </summary>
    public static Reference<T> To(string id, string? display = null)
    {
        return new Reference<T>
        {
            ReferenceValue = CreateReference(GetResourceTypeName<T>(), id),
            Type = GetResourceTypeName<T>(),
            Display = display
        };
    }
    
    private static string GetResourceTypeName<TResource>() where TResource : Resource
    {
        // 從型別名稱取得 Resource 型別名稱
        var typeName = typeof(TResource).Name;
        return typeName;
    }
}

/// <summary>
/// 雙型別的強型別 Reference
/// </summary>
public class Reference<T1, T2> : Reference 
    where T1 : Resource 
    where T2 : Resource
{
    private static readonly string[] _allowedTypes = 
    { 
        GetResourceTypeName<T1>(), 
        GetResourceTypeName<T2>() 
    };
    
    public override bool IsValidTarget(Resource resource) => resource is T1 or T2;
    
    public override string[] GetAllowedTargetTypes() => _allowedTypes;
    
    public T1? ResolveAsT1() => ResolvedResource?.As<T1>();
    public T2? ResolveAsT2() => ResolvedResource?.As<T2>();
    
    public void SetTarget(T1 resource) => SetTargetInternal(resource);
    public void SetTarget(T2 resource) => SetTargetInternal(resource);
    
    private void SetTargetInternal(Resource resource)
    {
        if (resource == null) throw new ArgumentNullException(nameof(resource));
        
        ReferenceValue = CreateReference(resource.ResourceType, resource.Id ?? "");
        Type = resource.ResourceType;
        ResolvedResource = new ResourceWrapper(resource);
    }
    
    private static string GetResourceTypeName<TResource>() where TResource : Resource
    {
        return typeof(TResource).Name;
    }
}

/// <summary>
/// 三型別的強型別 Reference
/// </summary>
public class Reference<T1, T2, T3> : Reference 
    where T1 : Resource 
    where T2 : Resource 
    where T3 : Resource
{
    private static readonly string[] _allowedTypes = 
    { 
        GetResourceTypeName<T1>(), 
        GetResourceTypeName<T2>(),
        GetResourceTypeName<T3>() 
    };
    
    public override bool IsValidTarget(Resource resource) => resource is T1 or T2 or T3;
    
    public override string[] GetAllowedTargetTypes() => _allowedTypes;
    
    public T1? ResolveAsT1() => ResolvedResource?.As<T1>();
    public T2? ResolveAsT2() => ResolvedResource?.As<T2>();
    public T3? ResolveAsT3() => ResolvedResource?.As<T3>();
    
    public void SetTarget(T1 resource) => SetTargetInternal(resource);
    public void SetTarget(T2 resource) => SetTargetInternal(resource);
    public void SetTarget(T3 resource) => SetTargetInternal(resource);
    
    private void SetTargetInternal(Resource resource)
    {
        if (resource == null) throw new ArgumentNullException(nameof(resource));
        
        ReferenceValue = CreateReference(resource.ResourceType, resource.Id ?? "");
        Type = resource.ResourceType;
        ResolvedResource = new ResourceWrapper(resource);
    }
    
    private static string GetResourceTypeName<TResource>() where TResource : Resource
    {
        return typeof(TResource).Name;
    }
}

/// <summary>
/// 四型別的強型別 Reference
/// </summary>
public class Reference<T1, T2, T3, T4> : Reference 
    where T1 : Resource 
    where T2 : Resource 
    where T3 : Resource 
    where T4 : Resource
{
    private static readonly string[] _allowedTypes = 
    { 
        GetResourceTypeName<T1>(), 
        GetResourceTypeName<T2>(),
        GetResourceTypeName<T3>(),
        GetResourceTypeName<T4>() 
    };
    
    public override bool IsValidTarget(Resource resource) => resource is T1 or T2 or T3 or T4;
    
    public override string[] GetAllowedTargetTypes() => _allowedTypes;
    
    public T1? ResolveAsT1() => ResolvedResource?.As<T1>();
    public T2? ResolveAsT2() => ResolvedResource?.As<T2>();
    public T3? ResolveAsT3() => ResolvedResource?.As<T3>();
    public T4? ResolveAsT4() => ResolvedResource?.As<T4>();
    
    public void SetTarget(T1 resource) => SetTargetInternal(resource);
    public void SetTarget(T2 resource) => SetTargetInternal(resource);
    public void SetTarget(T3 resource) => SetTargetInternal(resource);
    public void SetTarget(T4 resource) => SetTargetInternal(resource);
    
    private void SetTargetInternal(Resource resource)
    {
        if (resource == null) throw new ArgumentNullException(nameof(resource));
        
        ReferenceValue = CreateReference(resource.ResourceType, resource.Id ?? "");
        Type = resource.ResourceType;
        ResolvedResource = new ResourceWrapper(resource);
    }
    
    private static string GetResourceTypeName<TResource>() where TResource : Resource
    {
        return typeof(TResource).Name;
    }
}
```

## 🏗️ 實際使用範例

### 在 Resource 中使用強型別 Reference
```csharp
public class Observation : DomainResource
{
    /// <summary>
    /// The patient, or group of patients, location, or device this observation is about.
    /// 只能參照 Patient, Group, Device, Location
    /// </summary>
    [JsonPropertyName("subject")]
    public Reference<Patient, Group, Device, Location>? Subject { get; set; }
    
    /// <summary>
    /// Who was responsible for asserting the observed value as "true".
    /// 只能參照 Practitioner, PractitionerRole, Organization, CareTeam, Patient, RelatedPerson
    /// </summary>
    [JsonPropertyName("performer")]
    public List<Reference<Practitioner, PractitionerRole, Organization, CareTeam>>? Performer { get; set; }
}

public class Encounter : DomainResource
{
    /// <summary>
    /// The patient present at the encounter.
    /// 只能參照 Patient
    /// </summary>
    [JsonPropertyName("subject")]
    public Reference<Patient>? Subject { get; set; }
    
    public class Participant : BackboneElement
    {
        /// <summary>
        /// Persons involved in the encounter other than the patient.
        /// 只能參照 Practitioner, PractitionerRole
        /// </summary>
        [JsonPropertyName("individual")]
        public Reference<Practitioner, PractitionerRole>? Individual { get; set; }
    }
}
```

### 使用方式
```csharp
// 建立 Observation
var observation = new Observation();

// 設定 subject（型別安全）
var patient = new Patient { Id = "patient-001" };
observation.Subject = Reference<Patient, Group, Device, Location>.To(patient);

// 或使用 ID
observation.Subject = Reference<Patient, Group, Device, Location>.To("patient-001");

// 型別安全的解析
if (observation.Subject?.ResolveAsT1() is Patient resolvedPatient)
{
    Console.WriteLine($"Patient: {resolvedPatient.Id}");
}

// 驗證會自動檢查型別限制
var validationResults = observation.Subject?.Validate(new ValidationContext(observation.Subject));
```

## 🔧 從 FHIR StructureDefinition 提取 Reference 限制

### FHIR ElementDefinition 中的 Reference 資訊
```json
{
  "path": "Observation.subject",
  "type": [
    {
      "code": "Reference",
      "targetProfile": [
        "http://hl7.org/fhir/StructureDefinition/Patient",
        "http://hl7.org/fhir/StructureDefinition/Group",
        "http://hl7.org/fhir/StructureDefinition/Device",
        "http://hl7.org/fhir/StructureDefinition/Location"
      ]
    }
  ]
}
```

### 提取邏輯實作
```csharp
public class ReferenceTargetExtractor
{
    public string[] ExtractTargetTypes(ElementDefinition element)
    {
        var referenceType = element.Type?.FirstOrDefault(t => t.Code == "Reference");
        if (referenceType?.TargetProfile == null || !referenceType.TargetProfile.Any())
        {
            return Array.Empty<string>(); // 沒有限制
        }

        var targetTypes = new List<string>();
        foreach (var profileUrl in referenceType.TargetProfile)
        {
            var resourceType = ExtractResourceTypeFromProfile(profileUrl);
            if (!string.IsNullOrEmpty(resourceType))
            {
                targetTypes.Add(resourceType);
            }
        }

        return targetTypes.ToArray();
    }

    private string ExtractResourceTypeFromProfile(string profileUrl)
    {
        // 標準 FHIR Profile URL 格式：
        // http://hl7.org/fhir/StructureDefinition/Patient
        if (profileUrl.StartsWith("http://hl7.org/fhir/StructureDefinition/"))
        {
            return profileUrl.Substring("http://hl7.org/fhir/StructureDefinition/".Length);
        }

        // 自定義 Profile 可能需要額外處理
        // 例如：http://example.org/fhir/StructureDefinition/MyPatient -> Patient

        return null;
    }
}
```

### 常見的 Reference 限制範例
```csharp
// 從實際 FHIR R4 StructureDefinition 中提取的限制
public static class CommonReferenceTargets
{
    public static readonly Dictionary<string, string[]> KnownReferences = new()
    {
        // Observation
        ["Observation.subject"] = new[] { "Patient", "Group", "Device", "Location" },
        ["Observation.performer"] = new[] { "Practitioner", "PractitionerRole", "Organization", "CareTeam", "Patient", "RelatedPerson" },
        ["Observation.encounter"] = new[] { "Encounter" },

        // Patient
        ["Patient.managingOrganization"] = new[] { "Organization" },
        ["Patient.generalPractitioner"] = new[] { "Organization", "Practitioner", "PractitionerRole" },
        ["Patient.link.other"] = new[] { "Patient", "RelatedPerson" },

        // Encounter
        ["Encounter.subject"] = new[] { "Patient", "Group" },
        ["Encounter.participant.individual"] = new[] { "Practitioner", "PractitionerRole" },
        ["Encounter.serviceProvider"] = new[] { "Organization" },

        // DiagnosticReport
        ["DiagnosticReport.subject"] = new[] { "Patient", "Group", "Device", "Location" },
        ["DiagnosticReport.performer"] = new[] { "Practitioner", "PractitionerRole", "Organization", "CareTeam" },

        // MedicationRequest
        ["MedicationRequest.subject"] = new[] { "Patient", "Group" },
        ["MedicationRequest.requester"] = new[] { "Practitioner", "PractitionerRole", "Organization", "Patient", "RelatedPerson", "Device" },

        // Procedure
        ["Procedure.subject"] = new[] { "Patient", "Group" },
        ["Procedure.performer.actor"] = new[] { "Practitioner", "PractitionerRole", "Organization", "Patient", "RelatedPerson", "Device" },

        // Condition
        ["Condition.subject"] = new[] { "Patient", "Group" },
        ["Condition.asserter"] = new[] { "Practitioner", "PractitionerRole", "Patient", "RelatedPerson" }
    };
}
```

## 🔧 型別映射器更新

### 在 FhirCompliantTypeMapper 中處理
```csharp
public string MapReferenceType(string[] allowedTargetTypes, bool isArray = false)
{
    if (allowedTargetTypes == null || allowedTargetTypes.Length == 0)
    {
        return isArray ? "List<Reference>?" : "Reference?";
    }

    var referenceType = allowedTargetTypes.Length switch
    {
        1 => $"Reference<{allowedTargetTypes[0]}>",
        2 => $"Reference<{allowedTargetTypes[0]}, {allowedTargetTypes[1]}>",
        3 => $"Reference<{allowedTargetTypes[0]}, {allowedTargetTypes[1]}, {allowedTargetTypes[2]}>",
        4 => $"Reference<{allowedTargetTypes[0]}, {allowedTargetTypes[1]}, {allowedTargetTypes[2]}, {allowedTargetTypes[3]}>",
        _ => "Reference"  // 超過 4 個型別時使用基礎 Reference
    };

    return isArray ? $"List<{referenceType}>?" : $"{referenceType}?";
}

public string MapFhirPropertyToReference(string resourceType, string propertyPath)
{
    var fullPath = $"{resourceType}.{propertyPath}";

    if (CommonReferenceTargets.KnownReferences.TryGetValue(fullPath, out var allowedTypes))
    {
        return MapReferenceType(allowedTypes);
    }

    // 如果沒有找到已知限制，使用基礎 Reference
    return "Reference?";
}
```

### 自動生成 Reference 屬性
```csharp
public class PropertyGenerator
{
    public string GenerateReferenceProperty(ElementDefinition element, string resourceType)
    {
        var propertyName = GetPropertyName(element.Path);
        var targetTypes = _referenceExtractor.ExtractTargetTypes(element);
        var referenceType = _typeMapper.MapReferenceType(targetTypes, element.Max == "*");

        return $@"
        /// <summary>
        /// {element.Short}
        /// Allowed targets: {string.Join(", ", targetTypes)}
        /// </summary>
        [JsonPropertyName(""{element.Path.Split('.').Last()}"")]
        public {referenceType} {propertyName} {{ get; set; }}";
    }
}
```

## ✅ 優點

1. **型別安全** - 編譯時期檢查參照型別
2. **FHIR 規範遵循** - 自動驗證允許的目標型別
3. **便利使用** - 提供型別安全的解析方法
4. **完整驗證** - 內建 FHIR Reference 驗證規則
5. **可擴展** - 支援 1-4 個目標型別的組合

## 🎯 總結

強型別 Reference 系統解決了 FHIR Reference 的複雜性：
- ✅ **型別限制** - 編譯時期強制執行
- ✅ **多重目標** - 支援多型別泛型
- ✅ **驗證整合** - 自動檢查目標型別有效性
- ✅ **便利使用** - 型別安全的 API
- ✅ **FHIR 相容** - 完全符合 FHIR 規範

這確保了開發者必須遵守 FHIR 的參照限制，同時提供優秀的開發體驗！
