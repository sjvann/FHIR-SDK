# FHIR Type Framework 新架構

## 專案架構

### Fhir.Support - 底層共通性架構
存放所有底層的基礎類別和介面，提供 Type Framework 的核心架構。

```
Fhir.Support/
├── Base/
│   ├── TypeFramework.cs          # 主要型別架構
│   ├── FhirPrimitiveType.cs     # 原始型別基底（舊版）
│   ├── DataType.cs              # 資料型別基底
│   ├── Element.cs               # 元素基底
│   ├── Resource.cs              # 資源基底
│   └── DomainResource.cs        # 領域資源基底
├── Interfaces/
│   ├── IDataType.cs             # 資料型別介面
│   ├── IPrimitiveType.cs        # 原始型別介面
│   ├── IComplexType.cs          # 複雜型別介面
│   └── IChoiceType.cs           # 選擇型別介面
├── VersionManager.cs             # 版本管理器
└── Examples/
    └── NewFrameworkExample.cs    # 使用範例
```

### Fhir.Models - 版本管理
只存放生成的 FHIR 類別，按版本分目錄。

```
Fhir.Models/
├── R4/                          # R4 版本類別
├── R5/                          # R5 版本類別
└── R6/                          # R6 版本類別
```

## 主要特色

### 1. 完整的型別階層

- **PrimitiveType<T>**: 處理 FHIR 原始型別（如 string、int、bool 等）
- **ComplexType<T>**: 處理 FHIR 複雜型別（如 CodeableConcept、Address 等）
- **ChoiceType**: 處理 FHIR 選擇型別（如 [x] 欄位）

### 2. 強大的 JSON 支援

- 完整的 JSON 序列化/反序列化
- 支援 FHIR 的 JSON 格式
- 自動處理元素（Element）和擴展（Extension）

### 3. 版本管理

- 支援多個 FHIR 版本（R4、R5、R6）
- 自動版本切換
- 版本隔離

### 4. 型別安全

- 強型別支援
- 隱式轉換
- 驗證機制

## 使用方式

### 1. 基本使用

```csharp
// 設定版本
VersionManager.SetCurrentVersion("R5");

// 取得命名空間
var namespaceName = VersionManager.GetCurrentNamespace();
Console.WriteLine($"Current Namespace: {namespaceName}");

// 檢查版本支援
bool isSupported = VersionManager.IsVersionSupported("R5");
```

### 2. 生成器使用

```bash
# 使用新 Type Framework 生成
dotnet run --project Fhir.Generator -- --fhir-version R5 --definition-file definitions.R5.json.zip --use-new-framework

# 使用舊架構生成
dotnet run --project Fhir.Generator -- --fhir-version R5 --definition-file definitions.R5.json.zip
```

## 與 FhirServerHelper 的一致性

新的 Type Framework 採用與 FhirServerHelper 相同的設計理念：

1. **相同的型別階層**: PrimitiveType、ComplexType、ChoiceType
2. **相同的 JSON 處理**: 支援 FHIR 的 JSON 格式
3. **相同的介面定義**: IPrimitiveType、IComplexType、IChoiceType
4. **相同的功能**: 驗證、序列化、型別轉換

## 主要改進

### 1. 架構清晰

- **Fhir.Support**: 底層共通性架構
- **Fhir.Models**: 版本管理，只存放生成的類別
- **Fhir.Generator**: 程式碼生成器

### 2. 版本管理

- 自動版本切換
- 版本隔離
- 向後相容

### 3. 型別安全

- 強型別支援
- 隱式轉換
- 驗證機制

## 與舊架構的差異

| 特性 | 舊架構 | 新架構 |
|------|--------|--------|
| 架構清晰度 | 混合 | 清晰分離 |
| 型別階層 | 簡單的 FhirPrimitiveType<T> | 完整的 PrimitiveType<T>、ComplexType<T>、ChoiceType |
| JSON 支援 | 基本支援 | 完整支援，包括元素和擴展 |
| 版本管理 | 手動管理 | 自動版本管理 |
| 與 FhirServerHelper 一致性 | 低 | 高 |

## 未來規劃

1. **ChoiceType 支援**: 完整實作 ChoiceType 生成器
2. **驗證規則**: 加入更多 FHIR 驗證規則
3. **效能優化**: 優化 JSON 序列化/反序列化效能
4. **測試覆蓋**: 增加完整的單元測試
5. **文件完善**: 完善 API 文件和使用範例

## 範例程式碼

詳細的使用範例請參考 `Fhir.Support/Examples/NewFrameworkExample.cs`。 