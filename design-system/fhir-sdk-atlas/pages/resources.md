# Page Override: Resources

**Project:** FHIR SDK Atlas
**Page:** Generated resource catalog
**Overrides:** Master

## Purpose

列出 ResourceCreator 已生成的各線別資源，並對照 R4／R4B／R5 覆蓋與官方頁。

## Layout

```
工具列：搜尋｜線別 chip｜僅顯示缺線
對照表：Resource｜R4｜R4B｜R5｜詞彙｜官方
詳情：宣告欄位、C# 型別、選擇型、官方連結
```

## Rules

- 線別欄用文字「有／無」，再加徽章；禁止只靠綠／灰點。
- 超過一頁用篩選，不一次渲染不可讀的牆。
- 詳情可切線別，切換不得丢掉目前資源名。

## Official mapping

- `https://hl7.org/fhir/{R4|R4B|R5}/{resource}.html`
- Canonical：`http://hl7.org/fhir/StructureDefinition/{ResourceType}`
