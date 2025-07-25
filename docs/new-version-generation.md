# 新版本生成步驟指南

本指南詳細說明如何為新的 FHIR 版本（如 R6）生成程式碼的完整步驟。

## 🎯 概述

當 FHIR 發布新版本時，您可以按照以下步驟快速生成對應的 C# 模型：

1. 下載官方定義檔
2. 放置到正確位置
3. 執行生成命令
4. 驗證生成結果
5. 建立 NuGet 套件

## 📋 詳細步驟

### 步驟 1：下載 FHIR 定義檔

#### 1.1 取得官方定義檔

```bash
# 方法 1：從 FHIR 官網下載
# 訪問：https://www.hl7.org/fhir/downloads.html
# 下載：definitions.json.zip

# 方法 2：使用 curl 下載（以 R6 為例）
curl -L -o definitions.json.zip \
  "https://hl7.org/fhir/R6/definitions.json.zip"

# 方法 3：使用 wget 下載
wget -O definitions.json.zip \
  "https://hl7.org/fhir/R6/definitions.json.zip"
```

#### 1.2 驗證下載檔案

```bash
# 檢查檔案大小（通常 5-10 MB）
ls -lh definitions.json.zip

# 檢查檔案內容
unzip -l definitions.json.zip | head -20

# 驗證 JSON 格式
unzip -p definitions.json.zip profiles-resources.json | jq . | head -10
```

### 步驟 2：放置定義檔

#### 2.1 建立版本目錄

```bash
# 建立新版本目錄（以 R6 為例）
mkdir -p Definitions/R6

# 移動定義檔到正確位置
mv definitions.json.zip Definitions/R6/

# 驗證檔案位置
ls -la Definitions/R6/definitions.json.zip
```

#### 2.2 檢查目錄結構

```bash
# 確認目錄結構正確
tree Definitions/
# 輸出應該類似：
# Definitions/
# ├── R4/
# │   └── definitions.json.zip
# ├── R5/
# │   └── definitions.json.zip
# └── R6/
#     └── definitions.json.zip
```

### 步驟 3：執行生成命令

#### 3.1 檢查生成器狀態

```bash
# 確認生成器可以正常運作
dotnet build Fhir.Generator

# 檢查可用版本
dotnet run --project Fhir.Generator -- --fhir-version INVALID
# 這會顯示所有可用版本，包括新的 R6
```

#### 3.2 執行 R6 生成

```bash
# 生成 R6 程式碼
dotnet run --project Fhir.Generator -- --fhir-version R6

# 預期輸出：
# 🚀 FHIR Code Generator
# ======================
# 📋 Target FHIR Version: R6
# 📁 Definition file: Definitions\R6\definitions.json.zip (X.XX MB)
# 📅 File date: YYYY-MM-DD HH:mm:ss
# ⚡ Starting R6 code generation...
# ...
# 🎉 R6 code generation completed successfully!
```

#### 3.3 監控生成過程

```bash
# 使用 verbose 模式查看詳細資訊
dotnet run --project Fhir.Generator -- --fhir-version R6 --verbose

# 監控輸出目錄
watch -n 1 "find Fhir.R6.Models -name '*.cs' | wc -l"
```

### 步驟 4：驗證生成結果

#### 4.1 檢查生成的檔案

```bash
# 檢查輸出目錄結構
tree Fhir.R6.Models/ -L 2

# 統計生成的檔案數量
echo "Resources: $(find Fhir.R6.Models/Resources -name '*.cs' | wc -l)"
echo "DataTypes: $(find Fhir.R6.Models/DataTypes -name '*.cs' | wc -l)"

# 檢查重要檔案
ls -la Fhir.R6.Models/GlobalUsings.g.cs
ls -la Fhir.R6.Models/VERSION_SWITCH_GUIDE.md
```

#### 4.2 驗證程式碼品質

```bash
# 檢查編譯錯誤
dotnet build Fhir.R6.Models/

# 檢查程式碼格式
dotnet format Fhir.R6.Models/ --verify-no-changes

# 執行靜態分析
dotnet run --project CodeAnalysis -- Fhir.R6.Models/
```

#### 4.3 測試基本功能

```bash
# 建立測試專案
dotnet new console -n Fhir.R6.Test
cd Fhir.R6.Test

# 添加參照
dotnet add reference ../Fhir.R6.Models/Fhir.R6.Models.csproj

# 建立測試程式碼
cat > Program.cs << 'EOF'
using Fhir.R6.Models.Resources;

var patient = new Patient
{
    Id = "test-001",
    Active = true
};

Console.WriteLine($"Created R6 Patient: {patient.Id}");
Console.WriteLine($"Resource Type: {patient.ResourceType}");
EOF

# 執行測試
dotnet run
```

### 步驟 5：建立專案檔案

#### 5.1 生成專案檔

如果生成器沒有自動建立專案檔，手動建立：

```xml
<!-- Fhir.R6.Models/Fhir.R6.Models.csproj -->
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <GeneratePackageOnBuild>true</GeneratePackageOnBuild>
    
    <!-- 套件資訊 -->
    <PackageId>Fhir.R6.Models</PackageId>
    <PackageVersion>6.0.0</PackageVersion>
    <Title>FHIR R6 Models</Title>
    <Description>FHIR R6 resource and data type models for .NET</Description>
    <Authors>Your Organization</Authors>
    <PackageTags>FHIR;R6;Healthcare;HL7</PackageTags>
    <PackageProjectUrl>https://github.com/your-org/FHIR-SDK</PackageProjectUrl>
    <RepositoryUrl>https://github.com/your-org/FHIR-SDK</RepositoryUrl>
    <PackageLicenseExpression>MIT</PackageLicenseExpression>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="System.ComponentModel.Annotations" Version="5.0.0" />
    <PackageReference Include="System.Text.Json" Version="8.0.0" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="../Fhir.Abstractions/Fhir.Abstractions.csproj" />
    <ProjectReference Include="../Fhir.Support/Fhir.Support.csproj" />
  </ItemGroup>

</Project>
```

#### 5.2 更新生成器支援新版本

在 `Fhir.Generator/Program.cs` 中添加 R6 支援：

```csharp
switch (fhirVersion.ToUpper())
{
    case "R4":
        generatedDir = "Fhir.R4.Models";
        namespaceName = "Fhir.R4.Models";
        break;
    case "R5":
        generatedDir = "Fhir.R5.Models";
        namespaceName = "Fhir.R5.Models";
        break;
    case "R6":  // 新增 R6 支援
        generatedDir = "Fhir.R6.Models";
        namespaceName = "Fhir.R6.Models";
        break;
    default:
        Console.WriteLine($"❌ Unsupported FHIR version: {fhirVersion}");
        Console.WriteLine($"💡 Supported versions: R4, R5, R6");
        return;
}
```

### 步驟 6：建立 NuGet 套件

#### 6.1 建置套件

```bash
# 建置專案
dotnet build Fhir.R6.Models/ --configuration Release

# 建立 NuGet 套件
dotnet pack Fhir.R6.Models/ --configuration Release --output ./packages

# 檢查套件內容
dotnet nuget list source
ls -la packages/Fhir.R6.Models.*.nupkg
```

#### 6.2 測試套件

```bash
# 建立測試專案
dotnet new console -n PackageTest
cd PackageTest

# 添加本地套件來源
dotnet nuget add source ../packages --name local

# 安裝套件
dotnet add package Fhir.R6.Models --source local

# 測試使用
echo 'using Fhir.R6.Models.Resources; Console.WriteLine(new Patient().ResourceType);' > Program.cs
dotnet run
```

### 步驟 7：更新文件

#### 7.1 更新版本對照表

在 `docs/version-comparison.md` 中添加 R6 資訊：

```markdown
| 版本 | Resources | DataTypes | ValueSets | 發布日期 | 狀態 |
|------|-----------|-----------|-----------|----------|------|
| R4   | 148       | 63        | 661       | 2019-10  | ✅ 穩定 |
| R5   | 162       | 71        | 778       | 2023-03  | ✅ 穩定 |
| R6   | XXX       | XXX       | XXX       | 2024-XX  | 🚧 開發中 |
```

#### 7.2 更新範例程式碼

建立 R6 使用範例：

```csharp
// Examples/R6Example/Program.cs
using Fhir.R6.Models.Resources;

var patient = new Patient
{
    Id = "r6-example-001",
    Active = true
    // R6 特有的新屬性...
};

Console.WriteLine($"R6 Patient created: {patient.ResourceType}");
```

## ⚠️ 注意事項

### 1. 版本相容性

- 檢查新版本是否有破壞性變更
- 更新介面定義以保持相容性
- 測試現有程式碼是否仍能正常運作

### 2. 效能考量

- 新版本可能有更多 Resources 和 DataTypes
- 生成時間可能更長
- 記憶體使用量可能增加

### 3. 測試覆蓋

- 為新版本建立完整的測試套件
- 驗證序列化/反序列化功能
- 測試驗證規則

## 🔗 相關資源

- [FHIR 官方網站](https://www.hl7.org/fhir/)
- [FHIR 版本歷史](https://www.hl7.org/fhir/history.html)
- [程式碼生成指南](code-generation.md)
- [版本切換指南](version-switching.md)
