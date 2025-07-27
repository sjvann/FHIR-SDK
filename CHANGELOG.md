# 版本歷史

本文件記錄 FHIR .NET SDK 的所有重要變更。

格式基於 [Keep a Changelog](https://keepachangelog.com/zh-TW/1.0.0/)，
且本專案遵循 [Semantic Versioning](https://semver.org/lang/zh-TW/)。

## [未發布]

### 新增
- 完整的 FHIR R5 Type Framework 實作
- 強型別的 Choice Types 機制
- 使用者體驗增強模組
- 完整的文件化

### 變更
- 重構專案結構以符合 FHIR R5 規範
- 改善型別安全性

### 修正
- 修正繼承關係以符合 FHIR R5 規範
- 修正 Primitive Types 的命名衝突

## [1.0.0] - 2024-12-19

### 新增
- ✅ **完整的 FHIR R5 Type Framework 實作**
  - Base 類別層次結構
  - Element 基礎類別
  - DataType 基礎類別
  - PrimitiveType 基礎類別
  - Resource 基礎類別
  - DomainResource 基礎類別
  - CanonicalResource 基礎類別
  - MetadataResource 基礎類別
  - BackboneElement 基礎類別
  - BackboneType 基礎類別

- ✅ **所有 FHIR Primitive Types**
  - FhirString, FhirId, FhirUri, FhirCode, FhirBoolean
  - FhirInteger, FhirDecimal, FhirDateTime, FhirDate, FhirTime
  - FhirMarkdown, FhirUrl, FhirCanonical
  - 所有型別都使用 `Fhir` 前綴避免命名衝突

- ✅ **所有 FHIR Complex Types**
  - Extension, Annotation, Reference, Quantity
  - CodeableConcept, Period, Timing, Age, Range, Duration
  - Meta, Count, Distance, SimpleQuantity, SampledData, Narrative
  - ContactPoint, ContactDetail, UsageContext, RelatedArtifact

- ✅ **Choice Types 機制**
  - 強型別的 [x] 屬性實作
  - 支援 IntelliSense 的類型安全操作
  - 簡化的 API 設計

- ✅ **擴展機制**
  - 完整的 FHIR 擴展支援
  - 支援 modifier extensions
  - 簡化的擴展操作 API

- ✅ **驗證機制**
  - 內建的 FHIR 規範驗證
  - 完整的錯誤報告
  - 支援自訂驗證規則

- ✅ **深層複製**
  - 支援物件的深層複製
  - 正確處理循環參考

- ✅ **相等性比較**
  - 正確的物件相等性比較
  - 支援複雜物件的比較

- ✅ **JSON 序列化**
  - 完整的 FHIR JSON 序列化支援
  - 支援 FHIR R5 的 JSON 格式

- ✅ **使用者體驗增強**
  - Extension Methods 支援
  - Fluent API 設計
  - 簡化的類型轉換

### 技術特性
- 強型別安全
- 完整的 IntelliSense 支援
- 編譯時錯誤檢查
- 執行時驗證
- 深層複製支援
- 相等性比較
- JSON 序列化
- 擴展機制

### 文件
- 完整的 API 文件
- 使用範例
- 架構說明
- 開發指南

## [0.9.0] - 2024-12-01

### 新增
- 初始專案結構
- 基本的 FHIR 模型
- 核心功能模組

### 變更
- 建立專案基礎架構

## [0.8.0] - 2024-11-15

### 新增
- 專案初始化
- 基本文件結構

---

## 版本號碼說明

- **主版本號**：當進行不相容的 API 修改時遞增
- **次版本號**：當進行向下相容的功能性新增時遞增  
- **修訂號**：當進行向下相容的問題修正時遞增

## 發布類型

- **Alpha**：內部測試版本
- **Beta**：公開測試版本
- **RC**：候選發布版本
- **Stable**：穩定發布版本

---

**注意**：本文件會隨著專案的發展持續更新。 