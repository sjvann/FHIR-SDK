## 檔案目的
本文件彙整 FHIR SDK 方案之目標、現況、分工模式與 8–10 週執行計畫，供決策與排程使用。

### 讀者對象
- 產品/技術決策者
- 各模組負責人（Core、Resource、Tooling、Validation、QA、Docs）

---

## 目標重述（Enterprise-grade FHIR SDK）
- 跨版本支援：R4、R5，預留 R6
- 類型安全與清晰專案結構，易於維護與擴展
- 統一 SDK 介面：資源建立、驗證、序列化、版本切換
- 以版本管理為核心，確保相容性與穩定 API

---

## 目前進度與基礎（來自 docs/BASE_ARCHITECTURE.md）
- 版本管理：IFhirVersionManager、FhirVersionManager、IFhirVersion、FhirR4Version、FhirR5Version
- 核心基礎：IResource、ResourceBase、FhirSDK（主要 SDK 介面）
- 範例：ResourceTypeServices/R5/PatientR5.cs、examples/MultiVersionExample.cs
- 專案設定：FhirCore.csproj、ResourceTypeServices.csproj、Fhir_SDK.sln 均已更新

短期目標（文件共識）
- 擴充 R5 資源實作；完善驗證與序列化
- 建立 R4 目錄與實作、版本遷移工具
- 強化版本管理（映射、相容檢查、遷移）

中期目標
- R6 預備（介面、模板）
- 效能優化（快取、切版效能、記憶體）
- 開發工具（資源生成器、版本檢查、自動化測試）

---

## 主要問題與改進方向（綜合文件）
1) 單一真實來源（SSOT）缺失
- 支援資源清單於多處重複（SupportsResourceType vs GetSupportedResourceTypes），數量不一致
- 建議集中一處維護，其餘 API 全部引用

2) R5 覆蓋不足
- 目前僅 Patient 範例；整體覆蓋率約 0.6%（1/159）
- 需以「資源生成器」加速批次擴充

3) 工具與自動化不足
- 尚缺資源生成器、版本檢查工具、DocFX 一體化流程

4) 工程一致性需強化
- 命名、命名空間/目錄、驗證/序列化策略需一致
- 自動化測試與 CI Gate 需落地

5) 文件品質
- docs/問題分析與解決方案.md 出現編碼亂碼，需轉 UTF‑8
- 建議「專案狀態儀表板」成為單一匯總入口

---

## 分工模式建議（模組導向）
1) Core Platform（核心平台）
- 範圍：Versioning、FhirSDK、核心介面與基底類別
- 目標：穩定 API、型別安全、相容/遷移策略、效能
- KPI：API 變更可追溯、相容性測試通過率、切版耗時/記憶體

2) Resource Implementation（資源實作）
- 範圍：ResourceTypeServices/R5、ResourceTypeServices/R4
- 劃分建議（按領域/用途分小組）
  - 臨床觀察/診斷：Observation、DiagnosticReport…
  - 病患/人員：Patient、Practitioner、Organization…
  - 工作流程：Task、Appointment、Encounter…
  - 行政/帳務：Account、Claim…
- KPI：每週新增/完善資源數、測試覆蓋率、Lint/Style 合格率

3) Tooling/Generator（生成與工具）
- 範圍：FHIR Resource Generator、版本檢查工具、DocFX 整合
- 目標：由 FHIR 規格/定義自動產生 C# 骨架與文件
- KPI：生成成功率、手工修補比例、文件完整度

4) Validation & Compliance（驗證與相容）
- 範圍：驗證規則、跨版本相容與遷移工具
- 目標：可組態規則集；R4/R5 資料轉換可行
- KPI：規則覆蓋率、誤報/漏報率、遷移成功率

5) QA/Testing（測試與品質）
- 範圍：單元/整合/效能測試、CI Gate
- 目標：主線綠燈；關鍵模組 > 80% 覆蓋；回歸自動化

6) Docs/DevEx（文件與開發者體驗）
- 範圍：QUICK_START、API_Reference、遷移指南、儀表板
- 目標：DocFX 自動化、示例可執行、版本標註清晰

---

## 8–10 週執行計畫（2 週一 Sprint，可調整）
里程碑 M0（第 0 週）
- 決策與基線
  - 鎖定 FHIR R5 規格來源/版號
  - 資源生成器方案（自研或引入現有規格 JSON/StructureDefinition 再客製）
  - 設定工程規範：Analyzer/StyleCop、Nullable、警告視為錯誤
  - 修復亂碼文件並統一 docs 為 UTF‑8

里程碑 M1（週 1–2）
- 架構與 SSOT
  - 建立「支援資源清單」SSOT，所有 API 對齊引用
  - 定義驗證與序列化介面契約（可先簡化）
  - 資源生成器 PoC：先產出 5–10 個代表性資源骨架（含 XML Doc）
- CI
  - 新增編譯、Lint、單元測試、DocFX 預覽生成

里程碑 M2（週 3–4）
- R5 批次擴充（第一批 30–50 個）
  - 生成骨架＋人工補核心規則
  - 建立驗證規則集骨架與測試樣本
- 文檔
  - QUICK_START 與 API_Reference 自動化更新

里程碑 M3（週 5–6）
- R5 覆蓋 60–70%
  - 第二批 50–70 個資源
  - 跨版本介面與遷移函式雛形
- 效能
  - 初版快取策略與切版基準測試

里程碑 M4（週 7–8）
- R5 覆蓋 ~100%
  - 驗證與序列化主要路徑跑通
  - DocFX 完整導出與版本標註
- 穩定度
  - 回歸測試集與 CI Gate 收斂

里程碑 M5（週 9–10）
- R4 最小可用
  - 建立目錄與核心資源生成；與版本管理整合
- 策略預備
  - 規劃 R6 介面與模板；風險盤點與下一期計畫

---

## 工程規範與技術基線
- SSOT：支援資源清單、版本映射統一來源
- 生成器產出規範：目錄、命名空間、檔頭/屬性註解、驗證註記
- 測試：每資源至少 smoke；核心資源加強單元測試
- CI Gate：格式、Analyzer、測試、DocFX 生成成功方可合併
- 文件：公開 API 需 XML Doc；示例可編譯可運行

---

## KPI（量化指標）
- 覆蓋率：R5 資源實作數與百分比（分母 159）
- 測試：單元測試數與覆蓋率；關鍵模組 > 80%
- CI 穩定度：主線綠燈率、PR 合併 Lead Time
- 文件：DocFX 生成成功率、示例可運行率
- 效能：切版/創建/驗證中位時間、記憶體峰值

---

## 風險與應對
- 規格解析複雜
  - 優先依 StructureDefinition 自動生成；人工僅補差異
- 版本差異大
  - 建立遷移/相容策略清單，從高頻資源優先
- 協作衝突
  - 明確子模組所有權，PR 模板與檢核表控品質
- 文檔同步落差
  - DocFX 與生成器整合，避免手寫不同步

---

## 需要決策事項
- 資源生成器策略：自研或引入既有工具後客製？
- R5 實作優先級：是否有場景優先（就醫流程、理賠等）？
- 文檔語言與編碼：中文/英文或雙語？統一 UTF‑8？
- 是否先修復 docs/問題分析與解決方案.md 編碼並補綱要？

---

## 立即可執行的小步
- 建立 SSOT 與 API 對齊（1–2 天）
- 生成器 PoC（5–10 資源）（2–3 天）
- 新增 CI Gate：DocFX 與最小測試（1–2 天）
- 修復亂碼文件並統一 docs 編碼（0.5 天）

---

## 參考文件（docs/）
- BASE_ARCHITECTURE.md
- 問題分析與解決方案.md（建議轉 UTF‑8）
- FHIR_SDK_重構實作計畫.md
- FHIR_Resource_Generator_實作計畫.md
- 專案狀態儀表板.md

---

## 版本資訊
- 文件版本：v1.0（由現有 docs 彙整）
- 作者：Augment Agent
- 日期：{today}

