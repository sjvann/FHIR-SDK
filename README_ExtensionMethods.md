# FHIR R4 Primitive Types Extension Methods

## 📖 **概述**

Extension Methods 為 FHIR R4 Primitive Types 提供了更直觀和流暢的 API，讓開發者能夠輕鬆地將 .NET 原生型別轉換為 FHIR 型別。

## 🚀 **使用方式**

### **引入命名空間**
```csharp
using Fhir.R4.Models.Extensions;
```

### **基本使用範例**

#### **❌ 傳統方式（冗長且容易出錯）**
```csharp
var name = new FhirString("John Doe");
var age = new FhirInteger(30);
var isActive = new FhirBoolean(true);
var birthDate = new FhirDate("1990-01-01");
var data = new FhirBase64Binary(Convert.ToBase64String(bytes));
```

#### **✅ Extension Methods（簡潔且直觀）**
```csharp
var name = "John Doe".ToFhirString();
var age = 30.ToFhirInteger();
var isActive = true.ToFhirBoolean();
var birthDate = "1990-01-01".ToFhirDate();
var data = bytes.ToFhirBase64Binary();
```

## 📋 **支援的 Extension Methods**

### **字串型別**
```csharp
"Hello".ToFhirString()           // FhirString
"active".ToFhirCode()            // FhirCode
"patient-123".ToFhirId()         // FhirId
"http://example.com".ToFhirUri() // FhirUri
"https://example.com".ToFhirUrl() // FhirUrl
"urn:oid:1.2.3".ToFhirOid()      // FhirOid
"urn:uuid:123-456".ToFhirUuid()  // FhirUuid
"# Markdown".ToFhirMarkdown()    // FhirMarkdown
"http://hl7.org/fhir/Patient".ToFhirCanonical() // FhirCanonical
"1990-01-01".ToFhirDate()        // FhirDate
"2023-12-25T10:30:00Z".ToFhirDateTime() // FhirDateTime
"2023-12-25T10:30:00Z".ToFhirInstant()  // FhirInstant
"14:30:00".ToFhirTime()          // FhirTime
```

### **數值型別**
```csharp
42.ToFhirInteger()        // FhirInteger
10.ToFhirPositiveInt()    // FhirPositiveInt (> 0)
0.ToFhirUnsignedInt()     // FhirUnsignedInt (>= 0)
123.45m.ToFhirDecimal()   // FhirDecimal
```

### **布林型別**
```csharp
true.ToFhirBoolean()      // FhirBoolean
false.ToFhirBoolean()     // FhirBoolean
```

### **二進制資料**
```csharp
byte[] bytes = { 1, 2, 3 };
bytes.ToFhirBase64Binary() // FhirBase64Binary
```

### **時間型別**
```csharp
TimeSpan.FromHours(14).ToFhirTime() // FhirTime
```

### **GUID 型別**
```csharp
Guid.NewGuid().ToFhirUuid() // FhirUuid
```

## 🔄 **雙向轉換**

Extension Methods 支援與現有的隱式轉換和專用方法配合使用：

```csharp
// Extension Method -> FHIR Type -> .NET Type
var bytes = new byte[] { 1, 2, 3 };
var fhirData = bytes.ToFhirBase64Binary();
var backToBytes = fhirData.ToByteArray();

// TimeSpan 雙向轉換
var timeSpan = TimeSpan.FromHours(14);
var fhirTime = timeSpan.ToFhirTime();
var backToTimeSpan = fhirTime.ToTimeSpan();

// Guid 雙向轉換
var guid = Guid.NewGuid();
var fhirUuid = guid.ToFhirUuid();
var backToGuid = fhirUuid.ToGuid();
```

## 🛡️ **Null 安全**

Extension Methods 正確處理 null 值：

```csharp
string? nullString = null;
int? nullInt = null;
byte[]? nullBytes = null;

var result1 = nullString.ToFhirString(); // null
var result2 = nullInt.ToFhirInteger();   // null
var result3 = nullBytes.ToFhirBase64Binary(); // null
```

## 💡 **實際應用範例**

### **建立 FHIR 資源**
```csharp
var coding = new Coding
{
    System = "http://loinc.org".ToFhirUri(),
    Code = "29463-7".ToFhirCode(),
    Display = "Body Weight".ToFhirString()
};

var quantity = new Quantity
{
    Value = 70.5m.ToFhirDecimal(),
    Unit = "kg".ToFhirString(),
    System = "http://unitsofmeasure.org".ToFhirUri(),
    Code = "kg".ToFhirCode()
};
```

### **處理二進制資料**
```csharp
var imageBytes = File.ReadAllBytes("image.jpg");
var attachment = new Attachment
{
    ContentType = "image/jpeg".ToFhirCode(),
    Data = imageBytes.ToFhirBase64Binary(),
    Title = "Patient Photo".ToFhirString()
};
```

## 🎯 **優勢**

1. **🔍 更清晰的意圖表達** - 明確顯示轉換目標型別
2. **📝 更簡潔的程式碼** - 減少冗長的建構函式呼叫
3. **🛡️ 型別安全** - 編譯時型別檢查
4. **🔄 一致的 API** - 統一的轉換模式
5. **💡 IntelliSense 友善** - 更好的開發者體驗
6. **🚫 Null 安全** - 正確處理 null 值

## 📚 **相關文件**

- [FHIR R4 Primitive Types 規範](https://hl7.org/fhir/datatypes.html#primitive)
- [FHIR R4 SDK 文件](./README.md)
- [測試範例](./Fhir.R4.Models.Tests/Extensions/PrimitiveTypeExtensionsTests.cs)
