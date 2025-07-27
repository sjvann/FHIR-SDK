# FHIR Code Generator

> **📚 完整文件已移至 [docs/Generator/](../docs/Generator/README.md)**

## 🎯 **核心定位**

FHIR Code Generator 是一個專門用於生成符合 FHIR 規範的 C# 模型類別的工具。

### **快速連結**
- 📖 [完整使用手冊](../docs/Generator/UserGuide.md)
- ⚡ [快速開始指南](../docs/Generator/QuickStart.md)
- ❓ [常見問題](../docs/Generator/FAQ.md)
- 🔧 [API 參考](../docs/Generator/API.md)

## 🚀 **使用方法**

### **基本用法**

```bash
# 生成 R4 模型 (使用現有邏輯)
dotnet run --project Fhir.Generator --fhir-version R4

# 生成 R5 模型 (未來功能)
dotnet run --project Fhir.Generator --fhir-version R5

# 測試 Generator 功能
dotnet run --project Fhir.Generator --fhir-version R4 --test
```

### **進階選項**

```bash
# 互動模式 (未來功能)
dotnet run --project Fhir.Generator --fhir-version R5 --mode interactive

# 只生成空殼類別 (未來功能)
dotnet run --project Fhir.Generator --fhir-version R5 --mode empty-only

# 從上一版本複製並升級 (未來功能)
dotnet run --project Fhir.Generator --fhir-version R5 --mode copy-from

# 建立備份 (未來功能)
dotnet run --project Fhir.Generator --fhir-version R5 --backup
```

## 📁 **生成的專案結構**

Generator 會生成以下結構的專案：

```
Fhir.R4.Models/
├── Fhir.R4.Models.csproj
├── Resources/
│   ├── Patient.cs
│   ├── Organization.cs
│   ├── Observation.cs
│   └── ... (其他 Resources)
├── DataTypes/
│   ├── PrimitiveTypes/
│   │   ├── FhirString.cs
│   │   ├── FhirBoolean.cs
│   │   └── ... (其他 Primitive Types)
│   ├── ComplexTypes/
│   │   ├── Identifier.cs
│   │   ├── HumanName.cs
│   │   └── ... (其他 Complex Types)
└── Base/
    ├── Element.cs
    ├── Resource.cs
    └── DomainResource.cs
```

## 🔧 **生成的程式碼特色**

### **正確的 FHIR 架構**

```csharp
// 使用正確的 FHIR Primitive Types
public FhirString? Name { get; set; }        // ✅ 正確
public FhirBoolean? Active { get; set; }     // ✅ 正確

// 不是錯誤的原生類型
public string? Name { get; set; }            // ❌ 錯誤
public bool? Active { get; set; }            // ❌ 錯誤
```

### **完整的 FHIR 註解**

```csharp
/// <summary>
/// A name for the patient
/// FHIR Path: Patient.name
/// Cardinality: 0..*
/// </summary>
[JsonPropertyName("name")]
public List<HumanName>? Name { get; set; }
```

### **正確的命名空間和繼承**

```csharp
using Fhir.R4.Models.Base;
using Fhir.R4.Models.DataTypes;

namespace Fhir.R4.Models.Resources;

public class Patient : DomainResource
{
    [JsonPropertyName("resourceType")]
    public override string ResourceType => "Patient";
    
    // ... 屬性定義
}
```

## 📋 **支援的 FHIR 版本**

- ✅ **R4** - 完整支援
- 🚧 **R5** - 規劃中
- 🚧 **R6** - 規劃中

## 🔄 **版本升級流程**

當新的 FHIR 版本發布時：

1. **下載新版本的定義檔** - `Definitions/R5/definitions.json.zip`
2. **執行 Generator** - `dotnet run --fhir-version R5`
3. **檢查差異** - Generator 會分析與上一版本的差異
4. **選擇生成方式** - 空殼類別、完整實作、或從上版複製
5. **保護手工優化** - 不會覆蓋已優化的檔案

## 🛡️ **檔案保護機制**

Generator 會自動保護以下類型的檔案：
- 包含 `GenericResource<T>` 的檔案
- 包含 `// 手工優化` 註解的檔案
- 包含 `// Custom implementation` 註解的檔案
- 明顯為手工優化的檔案

## 🧪 **測試功能**

```bash
# 測試 Generator 生成結果
dotnet run --project Fhir.Generator --fhir-version R4 --test

# 執行完整測試套件
dotnet test Fhir.Generator.Tests/
```

## 📝 **開發指南**

### **添加新的 FHIR 版本支援**

1. 在 `Definitions/` 目錄下建立新版本資料夾
2. 下載對應的 `definitions.json.zip`
3. 更新 `ValidateVersion` 方法支援新版本
4. 測試生成結果

### **修改生成邏輯**

主要的生成邏輯在 `SimpleGenerator.cs` 中：
- `GenerateSimpleResource` - 生成 Resource 類別
- `GenerateSimplePrimitiveType` - 生成 Primitive Type 類別
- `GetFhirCompliantPropertyType` - 類型映射邏輯

## 🚨 **注意事項**

1. **不要手動編輯生成的檔案** - 除非你確定要進行手工優化
2. **備份重要檔案** - 在執行 Generator 前建立備份
3. **測試生成結果** - 確保生成的程式碼能正確編譯
4. **遵循 FHIR 規範** - Generator 生成的程式碼應符合 FHIR 標準

## 🔗 **相關連結**

- [FHIR R4 規範](http://hl7.org/fhir/R4/)
- [FHIR R5 規範](http://hl7.org/fhir/R5/)
- [FHIR 官方網站](https://www.hl7.org/fhir/)
