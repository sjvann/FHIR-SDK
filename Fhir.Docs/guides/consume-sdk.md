# 在應用中使用 SDK

## 引用入口套件

見 [開始使用](../getting-started/index.md)。業務程式應依賴 `Fhir.Sdk.{Line}` 與（可選）`Fhir.VersionManager`，避免直接綁 `Fhir.Path.{Line}`。

## FHIRPath

```csharp
using Fhir.Sdk.R5;
using Fhir.Resources.R5;

var engine = FhirSdkR5.CreatePath();
var collection = engine.Evaluate("identifier.value", patient);
```

DI：

```csharp
using Fhir.Sdk.R5.DependencyInjection;

services.AddFhirSdkR5();
```

R4／R4B 將型別與方法名中的 `R5` 換成對應線別即可（`FhirSdkR4`、`AddFhirSdkR4`）。Patch API 目前僅 R5 門面提供。

## 多線別

需要依 `/metadata` 或設定切換線別時，註冊 VersionManager，再以窄化後的 Capability 模型驅動搜尋參數或 UI。細節見 [多線別開發體驗](../concepts/multi-version.md)。

```csharp
services.AddFhirVersionManager();
```

## 應用層產品

QueryBuilder、IG Profile 驗證、Terminology 服務不在本庫。請見 [應用層文件](../application/index.md) 與 [FHIR.Solutions](https://github.com/sjvann/FHIR.Solutions)。
