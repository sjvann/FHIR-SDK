# 多線別開發體驗（Multi-version DX）

## 目標

開發端只需**宣告或切換** FHIR 線別（R4／R4B／R5），業務程式盡可能不受影響——這是本 SDK 相對「單線別綁死」函式庫的差異化優勢。

## 分層

1. **TypeFramework**：線別無關的基底與 Normative primitives（單一 NuGet）。
2. **Resources / Sdk.R\***：線別專屬 POCO 與入口套件；應用可只引用當前線別的 `Fhir.Sdk.*`。
3. **VersionManager（第一塊積木）**：
   - 自設定宣告、`/metadata` JSON、Base URL **解析／偵測** `FhirVersion`
   - 將各線別 `CapabilityStatement` **窄化**為跨線別 `ICapabilityModel`
   - DI：`AddFhirVersionManager()`

## 建議用法

```csharp
// 應用啟動：註冊一次
services.AddFhirVersionManager();

// 執行期：依伺服器或設定取得線別與 Capability
var runtime = sp.GetRequiredService<IFhirCapabilityRuntime>();
var result = runtime.Resolve(metadataJson, baseUrl, declared: FhirVersion.R5);
// result.SelectedVersion / result.Model → 驅動搜尋參數、UI、驗證路徑
```

切換線別時：優先改設定或偵測結果，再透過窄化模型消費；僅在使用線別專屬資源型別時才調整強型別程式碼。

## 路線圖

| 階段 | 內容 |
|------|------|
| 短期（已提供） | VersionManager 偵測／宣告 + Capability 窄化 |
| 中期 | 減少應用硬綁單一 `Fhir.Sdk.R5`；查詢／驗證介面更多走跨線別契約 |
| 長期 | 應用主要依賴跨線別契約 + 選定線別的 Sdk 實作 |

## 非目標

VersionManager **不是** TypeFramework 套件的 SemVer 版控工具；基底型別異動仍依 NuGet／CHANGELOG 語意化版本管理。
