---
type: "manual"
---

# FHIR .NET SDK 文件中心

歡迎來到 FHIR .NET SDK 的完整文件中心！

## 📚 **文件導覽**

### **🔧 Generator 文件**
- [Generator 文件中心](./Generator/README.md) - FHIR 模型生成器完整文件
- [使用手冊](./Generator/UserGuide.md) - 詳細的使用說明和範例
- [快速開始](./Generator/QuickStart.md) - 5分鐘快速上手指南
- [API 參考](./Generator/API.md) - 完整的 API 文件
- [架構設計](./Generator/Architecture.md) - 系統架構和設計原則
- [開發指南](./Generator/Development.md) - 開發者指南
- [常見問題](./Generator/FAQ.md) - 常見問題解答
- [版本歷史](./Generator/CHANGELOG.md) - 版本更新記錄

### **📖 SDK 文件 (規劃中)**
- [API 參考](./api/) - 完整的 SDK API 文件
- [使用指南](./guides/) - 詳細的 SDK 使用說明
- [範例](./examples/) - 實用的程式碼範例
- [架構設計](./architecture/) - SDK 系統架構說明

## 🎯 **快速連結**

### **立即開始**
- 🚀 [SDK 快速開始](../README.md#快速開始) - 開始使用 FHIR SDK
- ⚡ [Generator 快速開始](./Generator/QuickStart.md) - 5分鐘上手 Generator

### **深入了解**
- 📋 [Generator 使用手冊](./Generator/UserGuide.md) - 完整的使用說明
- 🏗️ [Generator 架構設計](./Generator/Architecture.md) - 了解內部架構
- 🔧 [Generator 開發指南](./Generator/Development.md) - 參與開發

### **問題解決**
- ❓ [Generator 常見問題](./Generator/FAQ.md) - 快速找到答案
- 🐛 [GitHub Issues](https://github.com/your-org/FHIR-SDK/issues) - 回報問題
- 💬 [GitHub Discussions](https://github.com/your-org/FHIR-SDK/discussions) - 參與討論

## 📋 **文件狀態**

| 組件 | 文件狀態 | 完整度 |
|------|----------|--------|
| **Generator** | ✅ 完整 | 100% |
| **R4 Models** | ✅ 完整 | 100% |
| **Core SDK** | 🚧 規劃中 | 0% |
| **Serialization** | 🚧 規劃中 | 0% |
| **Validation** | 🚧 規劃中 | 0% |

## 🎯 **主要特色**

### ✅ **FHIR Generator**
- 專注於 FHIR 模型生成
- 使用正確的 FHIR Primitive Types
- 完整的 FHIR Path 和 Cardinality 註解
- 智能保護手工優化檔案

### ✅ **多版本支援**
- 支援 FHIR R4 (完整)
- 規劃支援 R5, R6
- 獨立的模型專案
- 版本間差異分析

### ✅ **開發者友善**
- 完整的文件和範例
- 清晰的 API 設計
- 豐富的測試覆蓋
- 活躍的社群支援

## 🚀 **快速範例**

### **使用 FHIR R4 模型**
```csharp
using Fhir.R4.Models.Resources;
using Fhir.R4.Models.DataTypes;

var patient = new Patient
{
    Active = true,
    Gender = "male",
    BirthDate = "1990-01-01"
};
```

### **使用 Generator**
```bash
# 生成 R4 模型
dotnet run --project Fhir.Generator --fhir-version R4

# 測試 Generator 功能
dotnet run --project Fhir.Generator --fhir-version R4 --test
```

## 🔗 **相關連結**

- [FHIR 官方網站](https://www.hl7.org/fhir/)
- [FHIR R4 規範](http://hl7.org/fhir/R4/)
- [FHIR R5 規範](http://hl7.org/fhir/R5/)
- [GitHub 專案](https://github.com/your-org/FHIR-SDK)

## 📞 **支援與回饋**

- 🐛 [GitHub Issues](https://github.com/your-org/FHIR-SDK/issues) - 回報問題
- 💬 [GitHub Discussions](https://github.com/your-org/FHIR-SDK/discussions) - 參與討論
- 📖 [Wiki](https://github.com/your-org/FHIR-SDK/wiki) - 社群文件

---

**開始探索：** [Generator 文件](./Generator/README.md) | **立即使用：** [快速開始](../README.md)
