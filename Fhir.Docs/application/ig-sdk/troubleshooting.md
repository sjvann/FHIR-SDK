# IG SDK 疑難排解

## `install` 後 Found 0 constraint profile(s)

| 可能原因 | 處理 |
|----------|------|
| 套件未正確解壓 | 檢查 `artifacts/fhir-packages/{package-id}/{version}/package/` 是否存在 JSON |
| SD 非 constraint Profile | 產生器接受 `derivation=constraint` 或 `kind=constraint`；若套件僅含 differential 且無 snapshot，可能需更新掃描邏輯 |
| 快取損壞 | 刪除對應快取目錄後重新 `install` |

## 命名錯誤（例如 `Fhir.Ig.Uscore`）

請使用最新版 `Fhir.IGCreator` 重新 `install`。`hl7.fhir.us.core` 應產生 **`Fhir.Ig.USCore`**（`us` → `US`）。

## 建置 `Fhir.Ig.USCore` 失敗：`new[] { }` 或繼承圖錯誤

舊版產生器對空 `DerivedProfiles` 會產生無效 `new[] { }`。請重新執行 `install` 以產生 `Array.Empty<string>()`。

## 測試專案編譯進入主專案

測試專案應與主專案**同層**：

```
generated/Fhir.Ig.USCore/
generated/Fhir.Ig.USCore.Tests/    ← 正確
```

若測試在 `Fhir.Ig.USCore/Fhir.Ig.USCore.Tests/` 子目錄，主專案可能誤編譯測試檔。請重新 `install` 或手動移動並修正 `.csproj` 路徑。

## `BuildServiceProvider` 找不到

測試／應用專案需引用：

```xml
<PackageReference Include="Microsoft.Extensions.DependencyInjection" Version="9.0.0" />
```

產生器已於 `Fhir.Ig.{ShortName}.Tests` 範本包含此套件。

## 驗證永遠成功／永遠失敗

| 現象 | 檢查 |
|------|------|
| 未註冊 catalog | 是否呼叫 `AddUSCoreIg()` 或 `AddUSCoreIgWithPath()` |
| 未註冊 FHIRPath | cardinality／constraint 需 `*WithPath()` |
| Profile 不在 catalog | `meta.profile` URL 是否與 `USCoreProfiles.*` 一致（大小寫不敏感） |
| 未宣告 profile | `ValidateAgainstDeclaredProfiles` 需要 `meta.profile` |

## Binding 驗證僅檢查「已登錄」

MVP 的 `RegistryBindingCodeValidator` **不** 呼叫遠端 Terminology 展開 ValueSet。若需完整 code 驗證，請整合 [Terminology 服務](../terminology/user-manual.md) 或等待 `TerminologyBindingValidator`。

## FHIRPath constraint 出現 Warning

表示運算式無法執行或引擎尚未支援（如 `%resource`、`resolve()`）。不影響其他規則；Phase 2 會加強。

## 與 ResourceCreator 快取共用

兩者預設皆使用 repo 根目錄下 `artifacts/fhir-packages`。可安全共用；不同 package-id 分目錄存放。

## 取得協助時建議附上

- 完整 `install` 主控台輸出。
- `package-id@version` 與目標 Profile URL。
- `ProfileValidationResult.Issues` 內容。
- 相關資源 JSON 片段（可去識別化）。

## 延伸閱讀

- [IG SDK 使用手冊](ig-sdk-user-manual.md)
- [一般疑難排解](troubleshooting.md)
