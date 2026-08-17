# 開始使用

本 SDK 以 **線別（FHIR 大版本）** 對外：R4、R4B、R5。應用程式通常只引用對應的 `Fhir.Sdk.{Line}`。

## 前置需求

- [.NET SDK](https://dotnet.microsoft.com/download) **10**（與方案 `net10.0` 對齊）
- 本機開發可直接 `ProjectReference` 本儲庫；發佈後改用 NuGet `PackageReference`

## 安裝（NuGet）

擇一：

```xml
<ItemGroup>
  <PackageReference Include="Fhir.Sdk.R4" Version="1.0.0" />
  <!-- 或 Fhir.Sdk.R4B / Fhir.Sdk.R5 -->
</ItemGroup>
```

同儲存庫開發：

```xml
<ItemGroup>
  <ProjectReference Include="..\FHIR-SDK\Fhir.Sdk.R4\Fhir.Sdk.R4.csproj" />
</ItemGroup>
```

## 最小範例（R4）

```csharp
using Fhir.Resources.R4;
using Fhir.Sdk.R4;
using Fhir.TypeFramework.DataTypes;

var patient = new Patient
{
    Id = new FhirId("example"),
};

var path = FhirSdkR4.CreatePath();
var names = path.Evaluate("name.family", patient);
```

使用 DI 時：

```csharp
using Fhir.Sdk.R4.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

services.AddFhirSdkR4();
```

## 下一步

- [選擇線別與套件](packages.md) — 何時用 R4／R4B／R5，以及不必引用 Path
- [套件分層](../concepts/architecture.md) — Sdk、Path、Resources 的職責
- [在應用中使用 SDK](../guides/consume-sdk.md)
