# FHIR Generator 更新日誌

## [1.0.0] - 2024-12-XX

### 🎯 **重新定位 Generator 核心職責**

#### ✅ **新增功能**
- **專注於模型生成** - Generator 現在只專注於生成符合 FHIR 規範的 C# 模型類別
- **正確的 FHIR Primitive Types** - 生成 `FhirString?`, `FhirBoolean?` 等正確類型，不是 `string?`, `bool?`
- **完整的 FHIR 註解** - 包含 FHIR Path 和 Cardinality 資訊
- **正確的命名空間結構** - 使用 `Fhir.R4.Models.Resources`, `Fhir.R4.Models.DataTypes` 等
- **測試功能** - 提供 `--test` 參數來測試生成結果

#### 🔧 **改善功能**
- **簡化生成邏輯** - 移除複雜的驗證邏輯生成，由 SDK 主架構處理
- **清晰的職責分離** - Generator 只生成模型，不處理 JSON 序列化、驗證等 SDK 功能
- **更好的程式碼品質** - 生成的程式碼結構清晰，符合 FHIR 規範

#### ❌ **移除功能**
- **複雜驗證邏輯生成** - 這些由 SDK 主架構處理，不是 Generator 的職責
- **JSON 序列化邏輯** - 這些由 SDK 主架構處理
- **SDK 使用體驗功能** - 這些由 SDK 主架構處理

### 📋 **生成的程式碼範例**

#### **Resource 類別**
```csharp
// Auto-generated for FHIR R4 - Based on existing architecture
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.R4.Models.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// A simple test resource for validation
/// </summary>
/// <remarks>
/// FHIR R4 TestResource DomainResource
/// A simple test resource for validation
/// </remarks>
public class TestResource : DomainResource
{
    [JsonPropertyName("resourceType")]
    public override string ResourceType => "TestResource";

    /// <summary>
    /// A name for the test resource
    /// FHIR Path: TestResource.name
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("name")]
    public FhirString? Name { get; set; }

    /// <summary>
    /// Whether this test resource record is in active use
    /// FHIR Path: TestResource.active
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("active")]
    public FhirBoolean? Active { get; set; }
}
```

### 🎯 **設計原則**

#### **核心定位**
> Generator 是一個專門用於生成符合 FHIR 規範的 C# 模型類別的工具，當新的 FHIR 版本發布時使用。

#### **職責範圍**
- ✅ 讀取 FHIR 定義檔並生成對應的 C# 類別
- ✅ 使用正確的 FHIR Primitive Types
- ✅ 包含完整的 FHIR 註解資訊
- ✅ 保護現有的手工優化檔案
- ❌ 不處理 JSON 序列化功能
- ❌ 不處理複雜的驗證邏輯
- ❌ 不處理 SDK 使用體驗

### 🚀 **使用方法**

```bash
# 基本用法
dotnet run --project Fhir.Generator --fhir-version R4

# 測試功能
dotnet run --project Fhir.Generator --fhir-version R4 --test

# 未來功能 (規劃中)
dotnet run --project Fhir.Generator --fhir-version R5 --mode interactive
dotnet run --project Fhir.Generator --fhir-version R5 --backup
```

### 📊 **支援的 FHIR 版本**

- ✅ **R4** - 完整支援，可生成符合規範的模型
- 🚧 **R5** - 規劃中，將在 R5 正式發布後支援
- 🚧 **R6** - 規劃中，將在 R6 正式發布後支援

### 🧪 **測試覆蓋**

- ✅ 程式碼生成測試
- ✅ 類型映射測試
- ✅ 編譯驗證測試
- 🚧 SDK 整合測試 (規劃中)

### 🔮 **未來規劃**

#### **v1.1.0 - 版本管理功能**
- 支援 R5 模型生成
- 版本間差異分析
- 智能檔案保護機制

#### **v1.2.0 - 進階功能**
- 互動式生成模式
- 自動備份機制
- 批次生成功能

#### **v2.0.0 - 完整生態系統**
- 支援所有 FHIR 版本
- 插件式擴展機制
- CI/CD 整合支援

### 🐛 **已知問題**

- 目前只支援 R4 版本
- 部分複雜類型的映射需要進一步優化
- 需要更多的錯誤處理機制

### 🙏 **致謝**

感謝所有參與 FHIR Generator 開發和測試的貢獻者，特別是在重新定位 Generator 核心職責方面提供寶貴建議的團隊成員。

---

## 版本說明

- **主版本號** - 重大架構變更或不相容變更
- **次版本號** - 新功能添加，向後相容
- **修訂版本號** - 錯誤修正和小幅改善

## 貢獻指南

如果您想為 FHIR Generator 貢獻程式碼，請：

1. Fork 本專案
2. 建立功能分支
3. 提交您的變更
4. 建立 Pull Request
5. 等待程式碼審查

請確保您的貢獻符合 Generator 的核心定位：專注於 FHIR 模型生成，不偏離核心職責。
