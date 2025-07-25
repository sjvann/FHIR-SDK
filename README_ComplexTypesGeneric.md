# FHIR R4 Complex Types 泛型實作總結

## 📊 **實作概述**

根據您的建議，我們成功將泛型概念應用到 Complex Types，並補充了缺失的 FHIR R4 Complex Types。

## 🏗️ **泛型 ComplexType 基類架構**

### **1. 泛型基類設計**
```csharp
// 泛型 Complex Type 基類
public abstract class ComplexType<TSelf> : DataType
    where TSelf : ComplexType<TSelf>, new()
{
    // 流暢 API 支援
    public static TSelf Create() => new TSelf();
    public static TSelf Create(Action<TSelf> configure) { ... }
    public TSelf Configure(Action<TSelf> configure) { ... }
    
    // 統一的驗證框架
    protected virtual IEnumerable<ValidationResult> ValidateComplexType(...) { ... }
    
    // 統一的相等性比較
    protected virtual bool EqualsComplexType(TSelf other) { ... }
    protected virtual int GetComplexTypeHashCode() { ... }
    protected virtual string? GetComplexTypeString() { ... }
}

// 簡化的泛型類別
public class ComplexType : ComplexType<ComplexType>
{
    // 動態屬性支援
    public Dictionary<string, object>? AdditionalProperties { get; set; }
    public ComplexType SetProperty(string name, object value) { ... }
    public T? GetProperty<T>(string name) { ... }
}
```

## 📋 **新增的 Complex Types**

### **1. 補充缺失的 FHIR R4 Complex Types**

#### **SimpleQuantity** ✅
```csharp
public class SimpleQuantity : ComplexType<SimpleQuantity>
{
    public FhirDecimal? Value { get; set; }
    public FhirString? Unit { get; set; }
    public FhirUri? System { get; set; }
    public FhirCode? Code { get; set; }
    public FhirCode? Comparator { get; set; } // 不允許使用
    
    // 驗證：SimpleQuantity 不能有 comparator
    protected override IEnumerable<ValidationResult> ValidateComplexType(...) { ... }
}
```

#### **SampledData** ✅
```csharp
public class SampledData : ComplexType<SampledData>
{
    public SimpleQuantity Origin { get; set; } = null!;     // 必填
    public FhirDecimal Period { get; set; } = null!;        // 必填
    public FhirDecimal? Factor { get; set; }
    public FhirDecimal? LowerLimit { get; set; }
    public FhirDecimal? UpperLimit { get; set; }
    public FhirPositiveInt Dimensions { get; set; } = null!; // 必填
    public FhirString? Data { get; set; }
    
    // 便利方法
    public SampledData SetData(decimal[] values) { ... }
    public SampledData SetData(string[] values) { ... }
    public string[] GetDataPoints() { ... }
    public decimal?[] GetNumericDataPoints() { ... }
    public decimal?[] GetActualValues() { ... }
}
```

#### **Quantity 特化類型** ✅
```csharp
// Age - 年齡
public class Age : ComplexType<Age>
{
    public static Age Years(decimal years) => new Age(years, "a");
    public static Age Months(decimal months) => new Age(months, "mo");
    public static Age Days(decimal days) => new Age(days, "d");
}

// Distance - 距離
public class Distance : ComplexType<Distance>
{
    public static Distance Meters(decimal meters) => new Distance(meters, "m");
    public static Distance Centimeters(decimal cm) => new Distance(cm, "cm");
    public static Distance Kilometers(decimal km) => new Distance(km, "km");
}

// Count - 計數
public class Count : ComplexType<Count>
{
    public static Count Of(decimal count) => new Count(count);
    public static Count Of(int count) => new Count(count);
}
```

## 🎯 **泛型設計的優勢**

### **1. 統一的 API 模式**
```csharp
// 所有 Complex Types 都支援相同的流暢 API
var age = Age.Create(age => age.Value = new FhirDecimal(30));
var distance = Distance.Create(d => d.Value = new FhirDecimal(180));
var count = Count.Create(c => c.Value = new FhirDecimal(5));

// 方法鏈
var sampledData = SampledData.Create()
    .Configure(sd => {
        sd.Origin = new SimpleQuantity(0m, "mV");
        sd.Period = new FhirDecimal(1000m);
        sd.Dimensions = new FhirPositiveInt(1);
    })
    .SetData(new[] { 1.0m, 2.0m, 3.0m });
```

### **2. 一致的驗證框架**
```csharp
// 所有 Complex Types 都有統一的驗證方式
var validationResults = complexType.Validate(new ValidationContext(complexType));

// 每個類型可以覆寫 ValidateComplexType 提供特定驗證
protected override IEnumerable<ValidationResult> ValidateComplexType(ValidationContext context)
{
    if (Value?.Value < 0)
        yield return new ValidationResult("Age cannot be negative");
}
```

### **3. 統一的相等性比較**
```csharp
// 所有 Complex Types 都有一致的相等性比較
var age1 = Age.Years(30);
var age2 = Age.Years(30);
Assert.True(age1.Equals(age2));

// 每個類型可以覆寫 EqualsComplexType 提供特定比較邏輯
protected override bool EqualsComplexType(Age other)
{
    return EqualityComparer<FhirDecimal?>.Default.Equals(Value, other.Value) &&
           EqualityComparer<FhirString?>.Default.Equals(Unit, other.Unit);
}
```

## 📈 **實作統計**

### **完成的 Complex Types**
| 類別 | 數量 | 狀態 |
|------|------|------|
| **現有 Complex Types** | 15+ | ✅ 保持相容 |
| **新增 Complex Types** | 5 | ✅ 完成實作 |
| **泛型基類** | 2 | ✅ 完成實作 |
| **測試覆蓋** | 11 | ✅ 全部通過 |

### **新增的 Complex Types**
1. **SimpleQuantity** - Range 和 SampledData 使用的簡化 Quantity
2. **SampledData** - 設備測量數據的時間序列
3. **Age** - 年齡（Quantity 特化）
4. **Distance** - 距離（Quantity 特化）
5. **Count** - 計數（Quantity 特化）

## 🔧 **使用範例**

### **1. SampledData 使用範例**
```csharp
// 建立心電圖數據
var ecgData = new SampledData
{
    Origin = new SimpleQuantity(0m, "mV"),
    Period = new FhirDecimal(4m), // 4ms between samples (250 Hz)
    Dimensions = new FhirPositiveInt(1),
    Factor = new FhirDecimal(0.001m), // Convert to mV
    LowerLimit = new FhirDecimal(-5m),
    UpperLimit = new FhirDecimal(5m)
};

// 設定數據點
ecgData.SetData(new[] { 1000m, 1100m, 1200m, 1050m, 950m });

// 獲取實際值
var actualValues = ecgData.GetActualValues();
// 結果: [1.0, 1.1, 1.2, 1.05, 0.95] mV
```

### **2. Age/Distance/Count 使用範例**
```csharp
// 年齡
var patientAge = Age.Years(35);
var infantAge = Age.Months(6);
var newbornAge = Age.Days(3);

// 距離
var height = Distance.Centimeters(175);
var walkingDistance = Distance.Kilometers(5.2m);

// 計數
var childrenCount = Count.Of(3);
var medicationCount = Count.Of(2);
```

### **3. 泛型 ComplexType 動態使用**
```csharp
// 動態屬性
var dynamicComplex = new ComplexType()
    .SetProperty("customField", "customValue")
    .SetProperty("numericField", 42);

var customValue = dynamicComplex.GetProperty<string>("customField");
var numericValue = dynamicComplex.GetProperty<int>("numericField");
```

## 🏆 **重要成就**

### **1. 架構統一性** ✅
- **泛型基類** 提供統一的 API 模式
- **流暢介面** 支援方法鏈和配置
- **一致的驗證** 框架

### **2. FHIR 規範完整性** ✅
- **補充缺失** 的 Complex Types
- **符合 FHIR R4** 規範
- **完整的 XML 註解** 文件

### **3. 開發者體驗** ✅
- **直觀的 API** 設計
- **型別安全** 的泛型支援
- **豐富的便利方法**

### **4. 測試覆蓋** ✅
- **101 個測試** 全部通過
- **11 個新測試** 覆蓋泛型功能
- **完整的驗證** 測試

## 📝 **總結**

我們成功地：

1. **✅ 實作了泛型 ComplexType 基類** - 提供統一的 API 和功能
2. **✅ 補充了缺失的 FHIR R4 Complex Types** - SimpleQuantity、SampledData、Age、Distance、Count
3. **✅ 保持了向後相容性** - 現有的 Complex Types 繼續正常工作
4. **✅ 提供了完整的 XML 註解** - 符合專業開發標準
5. **✅ 建立了完整的測試覆蓋** - 確保功能正確性

這個實作展示了如何將泛型概念成功應用到 Complex Types，同時保持 FHIR 規範的嚴格性和開發者體驗的優秀性！
