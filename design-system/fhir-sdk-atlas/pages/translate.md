# Page Override: Translation

**Project:** FHIR SDK Atlas
**Page:** Locale + glossary overlay
**Overrides:** Master

## Mechanism

三層，立即切換，不呼叫外部翻譯 API：

1. **介面字串** — 內建 zh-TW／en／ja。
2. **詞彙表** — FHIR 名 → 標籤＋一句話。有譯文顯示「詞彙」；沒有顯示「待譯」並回退英文官方名。
3. **官方規格** — 一律連 HL7 英文頁。規格正文不在本機重譯，避免與 SoT 漂移。

`ISpecTranslator` 預留外掛（未來可接人工審定包）。預設實作只讀本機 glossary。

## UI

- 頂欄語言切換：`zh-TW`｜`EN`｜`日本語`，目前選項 `aria-current`。
- 每個型別／資源旁顯示翻譯來源徽章。
- 切語言時焦點留在觸發控制項，不把使用者甩回頁頂。
