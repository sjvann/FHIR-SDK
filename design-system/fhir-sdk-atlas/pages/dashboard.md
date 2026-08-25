# Page Override: Overview

**Project:** FHIR SDK Atlas
**Page:** Dashboard / Overview
**Overrides:** Master

## Purpose

開發者打開 Atlas 的第一屏：立刻知道 TypeFramework 與已生成 Resource 線別的現況，並能用搜尋跳到任一型別或資源。

## Audience

SDK 維護者、IG 作者、AION Profile 工程師。工作站桌面為主（1024+），平板可用，手機只保證搜尋與導覽。

## Layout

```
[品牌 Atlas]  [全域搜尋 /]   [線別 R4 R4B R5]  [語言]
─────────────────────────────────────────────
側欄：概覽｜型別｜資源｜官方規格
主區：
  4 張狀態卡（Primitive／Complex／R4／R5 資源數）
  線別覆蓋長條（數字＋列表面板，不用雷達圖）
  最近／熱門入口（Patient、Observation、string、HumanName）
```

## Overrides vs Master

- 卡片**不**用 `translateY` hover（避免列表重排）。只改邊框與背景。
- Primary CTA 是搜尋，不是綠色大按鈕。
- 長條圖必須同時有數字表格（圖表無障礙後備）。
- 空狀態：顯示建議關鍵字，禁止只寫「0 results」。

## Interactions

- `/` 聚焦搜尋；輸入即過濾（150ms debounce）；↓↑ 選建議；Enter 前往。
- 線別切換是全域狀態，三顆都永遠可見，即使該線為 0。
- 語言切換立即重繪詞彙與介面，不整頁重整。

## Anti-patterns

- 不要把 ResourceCreator 操作按鈕放在第一屏（這是目錄，不是產生器主控台）。
- 不要 iframe HL7（會被擋）；官方文件用新分頁連出去。
