# FHIR SDK 文件閱讀指引

歡迎使用 FHIR SDK！本指引將幫助您快速找到所需的文件和資源。

## 📖 文件結構

### 🚀 新手入門（建議閱讀順序）

1. **[快速開始](quick-start.md)** - 5 分鐘快速上手
2. **[安裝指南](installation.md)** - 詳細安裝步驟
3. **[使用範例](usage-examples.md)** - 實用程式碼範例
4. **[版本切換](version-switching.md)** - 無縫版本切換指南

### 🔧 開發者指南

- **[程式碼生成](code-generation.md)** - 從 FHIR 定義生成 C# 程式碼
- **[新版本生成步驟](new-version-generation.md)** - 如何支援新的 FHIR 版本（如 R6）
- **[架構設計](architecture.md)** - 專案架構和設計原則

### 📋 參考資料

- **[API 參考](api/)** - 詳細的 API 文件
- **[最佳實務](best-practices.md)** - 開發建議和注意事項
- **[故障排除](troubleshooting.md)** - 常見問題解決方案

## 🎯 依使用情境選擇文件

### 我是新手，想快速開始
👉 [快速開始](quick-start.md) → [使用範例](usage-examples.md)

### 我要安裝和設定環境
👉 [安裝指南](installation.md) → [環境設定](environment-setup.md)

### 我要在 R4 和 R5 之間切換
👉 [版本切換](version-switching.md) → [使用範例](usage-examples.md)

### 我要生成新版本的程式碼
👉 [程式碼生成](code-generation.md) → [新版本生成步驟](new-version-generation.md)

### 我要了解專案架構
👉 [架構設計](architecture.md) → [設計原則](design-principles.md)

### 我遇到問題需要解決
👉 [故障排除](troubleshooting.md) → [常見問題](faq.md)

## 📊 FHIR 版本支援狀態

| 版本 | 狀態 | Resources | DataTypes | 文件 |
|------|------|-----------|-----------|------|
| **R4** | ✅ 穩定 | 148 | 63 | [R4 指南](r4-guide.md) |
| **R5** | ✅ 穩定 | 162 | 71 | [R5 指南](r5-guide.md) |
| **R6** | 🚧 規劃中 | TBD | TBD | [R6 準備](r6-preparation.md) |

## 🔗 外部資源

### FHIR 官方資源
- [FHIR 官方網站](https://www.hl7.org/fhir/)
- [FHIR R4 規範](https://www.hl7.org/fhir/R4/)
- [FHIR R5 規範](https://www.hl7.org/fhir/R5/)

### 開發工具
- [FHIR Validator](https://confluence.hl7.org/display/FHIR/Using+the+FHIR+Validator)
- [FHIR Path Tester](http://hl7.org/fhirpath/)
- [Postman FHIR Collection](https://www.postman.com/fhir-org/)

## 🆘 需要幫助？

### 社群支援
- **GitHub Issues**: [回報問題或建議](https://github.com/your-org/FHIR-SDK/issues)
- **討論區**: [參與討論](https://github.com/your-org/FHIR-SDK/discussions)
- **Wiki**: [社群文件](https://github.com/your-org/FHIR-SDK/wiki)

### 商業支援
- **技術諮詢**: contact@your-org.com
- **客製化開發**: services@your-org.com
- **企業授權**: license@your-org.com

## 📝 貢獻指南

想要貢獻這個專案嗎？

1. **[貢獻指南](../CONTRIBUTING.md)** - 如何參與開發
2. **[程式碼規範](coding-standards.md)** - 程式碼風格指南
3. **[測試指南](testing-guide.md)** - 如何撰寫和執行測試

## 📄 授權資訊

本專案採用 **MIT 授權條款**。詳見 [LICENSE](../LICENSE) 檔案。

---

## 🔄 文件更新記錄

| 日期 | 版本 | 更新內容 |
|------|------|----------|
| 2024-07-24 | 1.0.0 | 初始版本，包含 R4/R5 支援 |
| 2024-07-24 | 1.1.0 | 新增程式碼生成指南 |
| 2024-07-24 | 1.2.0 | 新增版本切換功能 |

---

**💡 提示**: 如果您是第一次使用，建議從 [快速開始](quick-start.md) 開始！
