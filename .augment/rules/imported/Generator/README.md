---
type: "manual"
---

# FHIR Generator 文件中心

## 📚 **文件導覽**

### **📖 使用手冊**
- [使用手冊](./UserGuide.md) - 完整的使用說明和範例
- [快速開始](./QuickStart.md) - 5分鐘快速上手指南
- [常見問題](./FAQ.md) - 常見問題解答

### **🔧 技術文件**
- [架構設計](./Architecture.md) - 系統架構和設計原則
- [API 參考](./API.md) - 完整的 API 文件
- [開發指南](./Development.md) - 開發者指南

### **📋 專案管理**
- [版本歷史](./CHANGELOG.md) - 版本更新記錄
- [路線圖](./Roadmap.md) - 未來發展規劃
- [貢獻指南](./Contributing.md) - 如何參與開發

## 🎯 **Generator 概述**

FHIR Generator 是 FHIR .NET SDK 的核心工具，專門負責：

### **核心職責**
- ✅ **生成 FHIR 模型** - 當新版本發布時生成對應的 C# 類別
- ✅ **符合 FHIR 規範** - 使用正確的 FHIR Primitive Types
- ✅ **保護現有工作** - 不覆蓋手工優化的檔案
- ✅ **版本化支援** - 支援多個 FHIR 版本

### **不是 Generator 的職責**
- ❌ JSON 序列化功能 (由 SDK 主架構處理)
- ❌ 複雜驗證邏輯 (由 SDK 主架構處理)
- ❌ SDK 使用體驗 (由 SDK 主架構處理)

## 🚀 **快速開始**

```bash
# 生成 R4 模型
dotnet run --project Fhir.Generator --fhir-version R4

# 測試 Generator 功能
dotnet run --project Fhir.Generator --fhir-version R4 --test
```

詳細說明請參考 [快速開始指南](./QuickStart.md)。

## 📋 **支援的 FHIR 版本**

| 版本 | 狀態 | 說明 |
|------|------|------|
| R4   | ✅ 完整支援 | 可生成完整的 R4 模型 |
| R5   | 🚧 規劃中 | 等待 R5 正式發布 |
| R6   | 🚧 規劃中 | 等待 R6 正式發布 |

## 🔗 **相關連結**

- [FHIR 官方網站](https://www.hl7.org/fhir/)
- [FHIR R4 規範](http://hl7.org/fhir/R4/)
- [FHIR R5 規範](http://hl7.org/fhir/R5/)
- [GitHub 專案](https://github.com/your-org/FHIR-SDK)

## 📞 **需要幫助？**

- 📖 查看 [使用手冊](./UserGuide.md)
- ❓ 查看 [常見問題](./FAQ.md)
- 🐛 在 GitHub 回報問題
- 💬 參與 GitHub Discussions

---

**開始使用：** [快速開始指南](./QuickStart.md) | **深入了解：** [使用手冊](./UserGuide.md)
