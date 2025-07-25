# FHIR Primitive Types 設計原則

## 🎯 核心問題

FHIR 的 Primitive Types 與程式語言的原生資料型別會產生命名衝突：

- FHIR `boolean` vs C# `bool`
- FHIR `string` vs C# `string`  
- FHIR `integer` vs C# `int`
- FHIR `decimal` vs C# `decimal`

## ✅ 解決方案：Fhir 前綴

### 設計原則
1. **FHIR Primitive Types 加上 "Fhir" 前綴**
2. **FHIR 官方文件保持原本名稱**
3. **生成的 C# 類別使用前綴版本**
4. **內部包含對應的 C# 原生型別**

### 映射表

| FHIR 官方型別 | C# 類別名稱 | C# 原生型別 | 說明 |
|--------------|------------|------------|------|
| `boolean` | `FhirBoolean` | `bool?` | 避免與 C# bool 衝突 |
| `string` | `FhirString` | `string` | 避免與 C# string 衝突 |
| `integer` | `FhirInteger` | `int?` | 避免與 C# int 衝突 |
| `integer64` | `FhirInteger64` | `long?` | 64位元整數 |
| `decimal` | `FhirDecimal` | `decimal?` | 避免與 C# decimal 衝突 |
| `date` | `FhirDate` | `DateTime?` | FHIR 日期格式 |
| `dateTime` | `FhirDateTime` | `DateTime?` | FHIR 日期時間格式 |
| `time` | `FhirTime` | `TimeSpan?` | FHIR 時間格式 |
| `instant` | `FhirInstant` | `DateTimeOffset?` | 精確時間點 |
| `uri` | `FhirUri` | `string` | URI 格式 |
| `url` | `FhirUrl` | `string` | URL 格式 |
| `canonical` | `FhirCanonical` | `string` | 規範 URL |
| `code` | `FhirCode` | `string` | 編碼值 |
| `id` | `FhirId` | `string` | 識別碼 |
| `oid` | `FhirOid` | `string` | OID 格式 |
| `uuid` | `FhirUuid` | `string` | UUID 格式 |
| `markdown` | `FhirMarkdown` | `string` | Markdown 文字 |
| `base64Binary` | `FhirBase64Binary` | `byte[]` | Base64 編碼 |
| `unsignedInt` | `FhirUnsignedInt` | `uint?` | 無符號整數 |
| `positiveInt` | `FhirPositiveInt` | `uint?` | 正整數 |
| `xhtml` | `FhirXhtml` | `string` | XHTML 內容 |

## 🏗️ 實作範例

### FhirBoolean 實作
```csharp
[JsonConverter(typeof(FhirBooleanConverter))]
public class FhirBoolean : PrimitiveType<bool?>
{
    public FhirBoolean() { }
    public FhirBoolean(bool? value) { Value = value; }
    
    // 隱式轉換 - 讓使用更方便
    public static implicit operator bool?(FhirBoolean fhirBoolean) 
        => fhirBoolean?.Value;
    public static implicit operator FhirBoolean(bool? value) 
        => new FhirBoolean(value);
        
    // FHIR 驗證
    public override bool IsValid() => true; // boolean 總是有效
    
    public override string ToString() => Value?.ToString() ?? "";
}
```

### FhirString 實作
```csharp
[JsonConverter(typeof(FhirStringConverter))]
public class FhirString : PrimitiveType<string>
{
    public FhirString() { }
    public FhirString(string value) { Value = value; }
    
    // 隱式轉換
    public static implicit operator string(FhirString fhirString) 
        => fhirString?.Value;
    public static implicit operator FhirString(string value) 
        => new FhirString(value);
        
    // FHIR 驗證 - string 必須符合 FHIR 規範
    public override bool IsValid() 
    {
        if (Value == null) return true;
        // FHIR string 不能包含控制字元（除了 tab, CR, LF）
        return !Value.Any(c => char.IsControl(c) && c != '\t' && c != '\r' && c != '\n');
    }
}
```

### FhirInteger 實作
```csharp
[JsonConverter(typeof(FhirIntegerConverter))]
public class FhirInteger : PrimitiveType<int?>
{
    public FhirInteger() { }
    public FhirInteger(int? value) { Value = value; }
    
    // 隱式轉換
    public static implicit operator int?(FhirInteger fhirInteger) 
        => fhirInteger?.Value;
    public static implicit operator FhirInteger(int? value) 
        => new FhirInteger(value);
        
    // FHIR 驗證 - 必須在有效範圍內
    public override bool IsValid() 
    {
        if (!Value.HasValue) return true;
        return Value >= int.MinValue && Value <= int.MaxValue;
    }
}
```

## 🔄 使用範例

### 在 Patient Resource 中使用
```csharp
public class Patient : DomainResource
{
    [JsonPropertyName("active")]
    public FhirBoolean Active { get; set; }  // 使用 FhirBoolean 而非 bool
    
    [JsonPropertyName("gender")]
    public FhirCode Gender { get; set; }     // 使用 FhirCode 而非 string
    
    [JsonPropertyName("birthDate")]
    public FhirDate BirthDate { get; set; }  // 使用 FhirDate 而非 DateTime
}
```

### 便利的使用方式
```csharp
var patient = new Patient();

// 直接賦值 - 透過隱式轉換
patient.Active = true;           // bool → FhirBoolean
patient.Gender = "male";         // string → FhirCode
patient.BirthDate = "1990-01-01"; // string → FhirDate

// 直接取值 - 透過隱式轉換
bool? isActive = patient.Active;     // FhirBoolean → bool?
string gender = patient.Gender;      // FhirCode → string
string birthDate = patient.BirthDate; // FhirDate → string
```

## 📋 型別映射器實作

### 在 EnhancedTypeMapper 中
```csharp
private readonly Dictionary<string, string> _primitiveTypeMap = new()
{
    // FHIR 官方名稱 → C# 類別名稱（加 Fhir 前綴）
    ["boolean"] = "FhirBoolean",
    ["string"] = "FhirString", 
    ["integer"] = "FhirInteger",
    ["decimal"] = "FhirDecimal",
    // ... 所有其他 primitive types
};

private readonly Dictionary<string, string> _primitiveToNativeTypeMap = new()
{
    // FHIR 官方名稱 → C# 原生型別
    ["boolean"] = "bool?",
    ["string"] = "string",
    ["integer"] = "int?", 
    ["decimal"] = "decimal?",
    // ... 所有其他對應
};
```

## ✅ 優點

1. **避免命名衝突** - 不會與 C# 原生型別衝突
2. **保持 FHIR 語義** - 每個類別都包含 FHIR 特定的驗證和行為
3. **便利使用** - 透過隱式轉換提供良好的開發體驗
4. **型別安全** - 編譯時期就能發現型別錯誤
5. **符合 FHIR 規範** - 完全遵循 FHIR 的 Primitive Types 定義

## 🎯 總結

這個設計確保了：
- **FHIR 官方文件的一致性** - 文件中仍使用原本的名稱
- **C# 程式碼的正確性** - 避免與原生型別衝突
- **開發者體驗的優化** - 透過隱式轉換提供便利性
- **FHIR 規範的完整性** - 每個型別都有適當的驗證和行為

這是一個關鍵的設計決策，確保了 FHIR SDK 的專業性和可用性！
