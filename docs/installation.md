# 安裝指南

本指南詳細說明如何安裝和設定 FHIR SDK。

## 📋 系統需求

- **.NET 8.0** 或更新版本
- **Visual Studio 2022** 或 **VS Code**（推薦）
- **Git**（用於版本控制）

## 🎯 安裝方式

### 方式 1：NuGet 套件（推薦）

```bash
# 基礎套件
dotnet add package Fhir.Support
dotnet add package Fhir.Abstractions

# 選擇 FHIR 版本
dotnet add package Fhir.R4.Models    # R4
# 或
dotnet add package Fhir.R5.Models    # R5
```

### 方式 2：從原始碼建置

```bash
# 複製專案
git clone https://github.com/your-org/FHIR-SDK.git
cd FHIR-SDK

# 建置所有專案
dotnet build

# 建立本地 NuGet 套件
dotnet pack --output ./packages
```

## 🔧 專案設定

### 基本專案檔

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Fhir.Support" Version="1.0.0" />
    <PackageReference Include="Fhir.Abstractions" Version="1.0.0" />
    <PackageReference Include="Fhir.R4.Models" Version="4.0.1" />
  </ItemGroup>
</Project>
```

### Global Using 設定

由於套件已包含 Global Using，您可以直接使用：

```csharp
// 無需 using 語句
var patient = new Patient();
var observation = new Observation();
```

## ✅ 驗證安裝

建立測試檔案：

```csharp
// Test.cs
using Fhir.R4.Models.Resources;

var patient = new Patient
{
    Id = "test-001",
    Active = true
};

Console.WriteLine($"✅ FHIR SDK 安裝成功！");
Console.WriteLine($"Patient ID: {patient.Id}");
Console.WriteLine($"Resource Type: {patient.ResourceType}");
```

執行測試：

```bash
dotnet run
```

## 🐛 故障排除

### 常見問題

#### 1. 套件版本衝突

```bash
# 清理 NuGet 快取
dotnet nuget locals all --clear

# 重新安裝
dotnet restore
```

#### 2. Global Using 不生效

確認專案檔包含：

```xml
<PropertyGroup>
  <ImplicitUsings>enable</ImplicitUsings>
</PropertyGroup>
```

#### 3. 編譯錯誤

```bash
# 清理並重新建置
dotnet clean
dotnet build
```

## 🔗 下一步

- [快速開始](quick-start.md)
- [使用範例](usage-examples.md)
- [版本切換](version-switching.md)
