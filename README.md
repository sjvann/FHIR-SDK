# FHIR .NET SDK

一個高效能、強型別的 FHIR 開發函式庫，專為 .NET 平台設計。

## 🚀 專案特色

- **版本無關設計**：適用於不同 FHIR 版本的通用型別框架
- **強型別安全**：完整的編譯時型別檢查和 IntelliSense 支援
- **介面優先設計**：使用介面定義基本行為，確保可測試性、可擴展性和鬆耦合
- **混合驗證模式**：集中驗證工具 + 型別特定邏輯
- **效能優化**：安全的快取和優化機制
- **開發體驗**：豐富的開發工具和使用範例
- **循環依賴解決**：使用介面解決循環依賴問題

## 📁 專案結構

```
FHIR-SDK/
├── Fhir.Core/                    # 核心功能模組
├── Fhir.Generator/               # 程式碼生成工具
├── Fhir.R4.Models/              # FHIR R4 模型
├── Fhir.TypeFramework/          # FHIR R5 Type Framework ⭐
├── Fhir.TypeFramework.Extensions/ # 使用者體驗增強
└── Examples/                    # 使用範例
```

## 🏗️ FHIR Type Framework

### 完整的 FHIR R5 Type Framework 實作

```
Base (基礎類別) ← 對應 FHIR R5 的 BaseElement
├── Element (元素)
    ├── DataType (資料型別)
    │   ├── PrimitiveType (原始類型)
    │   │   ├── FhirString, FhirId, FhirUri, FhirCode, FhirBoolean, etc.
    │   │   └── 所有 FHIR Primitive Types
    │   ├── Resource (資源)
    │   │   └── DomainResource (領域資源)
    │   │       ├── CanonicalResource (規範資源)
    │   │       └── MetadataResource (元資料資源)
    │   └── BackboneType (骨幹型別)
    └── BackboneElement (骨幹元素)
```

### 核心功能

- ✅ **版本無關設計**：適用於不同 FHIR 版本的通用框架
- ✅ **強型別安全**：所有 FHIR 型別都有對應的強型別 C# 類別
- ✅ **混合驗證模式**：集中驗證工具 + 型別特定邏輯
- ✅ **效能優化**：安全的快取和優化機制
- ✅ **開發體驗**：豐富的 IntelliSense 支援和開發工具
- ✅ **深層複製**：支援物件的深層複製
- ✅ **相等性比較**：正確的物件相等性比較
- ✅ **Choice Types**：強型別的 [x] 屬性實作
- ✅ **Extension 支援**：完整的擴展功能

## 🚀 快速開始

### 安裝

```bash
# 克隆專案
git clone https://github.com/your-username/FHIR-SDK.git
cd FHIR-SDK

# 建置專案
dotnet build
```

### 基本使用

```csharp
using Fhir.TypeFramework.Base;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;

// 建立一個簡單的資源
var patient = new Patient
{
    Id = "patient-123",
    Name = new HumanName
    {
        Family = "張",
        Given = new List<FhirString> { "三" }
    },
    BirthDate = new FhirDate("1990-01-01"),
    Gender = new FhirCode("male")
};

// 添加擴展
patient.AddExtension("http://example.com/custom", new FhirString("custom-value"));

// 驗證資源
var validationResults = patient.Validate(new ValidationContext(patient));
```

### Choice Types 使用

```csharp
// 使用強型別的 Choice Type
var extension = new Extension
{
    Url = "http://example.com/extension",
    Value = new ExtensionValueChoice()
};

// 設定值（支援 IntelliSense）
extension.Value.SetStringValue("Hello World");
// 或
extension.Value.SetIntegerValue(42);
// 或
extension.Value.SetBooleanValue(true);
```

## 📚 文件

- [FHIR R5 Type Framework 實作文件](Fhir.TypeFramework/README_FHIR_R5_TypeFramework_Implementation.md)
- [Choice Type 最佳解決方案](Fhir.TypeFramework/README_ChoiceType_Best_Solution.md)
- [FHIR Primitive Types 設計](Fhir.TypeFramework/README_FHIR_Primitive_Design.md)
- [使用者體驗增強](Fhir.TypeFramework.Extensions/README.md)

## 🔧 開發

### 建置專案

```bash
# 建置所有專案
dotnet build

# 建置特定專案
dotnet build Fhir.TypeFramework/Fhir.TypeFramework.csproj
```

### 執行測試

```bash
# 執行所有測試
dotnet test

# 執行特定測試專案
dotnet test Fhir.TypeFramework.Tests/
```

### 程式碼生成

```bash
# 生成 FHIR R4 模型
dotnet run --project Fhir.Generator/Fhir.Generator.csproj -- --version R4 --output Fhir.R4.Models
```

## 📊 符合性檢查

### ✅ FHIR R5 規範符合性

- [x] 正確的類別層次結構
- [x] 正確的屬性定義和基數
- [x] 正確的 FHIR Path 映射
- [x] 正確的資料型別使用
- [x] 正確的擴展機制
- [x] 正確的驗證邏輯
- [x] 正確的序列化支援

### ✅ 技術特性

- [x] 強型別安全
- [x] 完整的 IntelliSense 支援
- [x] 編譯時錯誤檢查
- [x] 執行時驗證
- [x] 深層複製支援
- [x] 相等性比較
- [x] JSON 序列化
- [x] 擴展機制

## 🤝 貢獻

我們歡迎所有形式的貢獻！請參閱 [貢獻指南](CONTRIBUTING.md) 了解詳細資訊。

### 貢獻步驟

1. Fork 專案
2. 創建功能分支 (`git checkout -b feature/AmazingFeature`)
3. 提交變更 (`git commit -m 'Add some AmazingFeature'`)
4. 推送到分支 (`git push origin feature/AmazingFeature`)
5. 開啟 Pull Request

## 📄 授權

本專案採用 MIT 授權條款 - 詳見 [LICENSE](LICENSE) 檔案

## 📞 聯絡資訊

- 專案首頁：[https://github.com/your-username/FHIR-SDK](https://github.com/your-username/FHIR-SDK)
- 問題回報：[https://github.com/your-username/FHIR-SDK/issues](https://github.com/your-username/FHIR-SDK/issues)
- 討論區：[https://github.com/your-username/FHIR-SDK/discussions](https://github.com/your-username/FHIR-SDK/discussions)

## 🙏 致謝

感謝所有為這個專案做出貢獻的開發者！

---

**注意**：本專案正在積極開發中，API 可能會有所變更。
