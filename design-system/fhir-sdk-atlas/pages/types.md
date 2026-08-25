# Page Override: Types

**Project:** FHIR SDK Atlas
**Page:** TypeFramework catalog
**Overrides:** Master

## Purpose

檢視 TypeFramework 已實作的 primitive／complex datatype、狀態，以及對應的官方規格與多語詞彙。

## Layout

```
工具列：搜尋｜Primitive / Complex chip｜狀態
表格（密）：FHIR 名｜C# 型別｜種類｜詞彙｜官方
列點進詳情：欄位、XML 摘要、canonical、翻譯來源
```

## Rules

- Chip 可換行，禁止單列裁切。
- FHIR 名用 JetBrains Mono；說明用 IBM Plex Sans。
- 狀態只用「就緒／缺文件／待譯」徽章＋文字，不只靠顏色。
- 詳情頁麵包屑：概覽 > 型別 > HumanName。

## Official mapping

- Primitive → `https://hl7.org/fhir/{line}/datatypes.html#{fhirName}`
- Complex → `https://hl7.org/fhir/{line}/{fhirName}.html`（小寫）
- Canonical → `http://hl7.org/fhir/StructureDefinition/{Name}`
