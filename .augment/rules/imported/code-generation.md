---
type: "manual"
---

# FHIR 程式碼生成指南

本指南詳細說明如何使用 FHIR Generator 從官方 FHIR 定義生成 C# 程式碼。

## 🎯 概述

FHIR Generator 是一個命令列工具，能夠：
- 從官方 FHIR 定義檔自動生成 C# 類別
- 支援多個 FHIR 版本（R4、R5、R6...）
- 自動生成 Global Using 別名以實現無縫版本切換
- 生成完整的型別安全程式碼

## 📁 目錄結構

```
FHIR-SDK/
├── Definitions/                    # FHIR 官方定義檔
│   ├── R4/definitions.json.zip    # R4 定義檔
│   ├── R5/definitions.json.zip    # R5 定義檔
│   └── R6/definitions.json.zip    # R6 定義檔（未來）
├── Fhir.Generator/                 # 程式碼生成器
├── Fhir.Support/                   # 共用基礎框架
├── Fhir.R4.Models/                 # R4 生成的模型
├── Fhir.R5.Models/                 # R5 生成的模型
└── Fhir.R6.Models/                 # R6 生成的模型（未來）
```

## 🔧 生成器架構

### 核心元件

1. **FhirDefinitionLoader** - 載入 FHIR 定義檔
2. **FhirCodeGenerator** - 生成 C# 程式碼
3. **GlobalUsingGenerator** - 生成全域別名
4. **EnhancedTypeMapper** - 型別對應

### 生成流程

1. **載入定義檔** - 從 ZIP 檔案載入 FHIR 定義
2. **解析結構** - 解析 JSON 格式的結構定義
3. **建立 Schema** - 建立內部資料結構
4. **生成程式碼** - 產生 C# 類別檔案
5. **生成別名** - 產生 Global Using 檔案

## 🚀 基本使用

### 生成 R4 模型

```bash
# 確保定義檔存在
ls Definitions/R4/definitions.json.zip

# 生成 R4 程式碼
dotnet run --project Fhir.Generator -- --fhir-version R4
```

### 生成 R5 模型

```bash
# 確保定義檔存在
ls Definitions/R5/definitions.json.zip

# 生成 R5 程式碼
dotnet run --project Fhir.Generator -- --fhir-version R5
```

## 📊 生成結果

### 輸出檔案結構

```
Fhir.R4.Models/
├── Resources/                      # FHIR Resources
│   ├── Patient.cs                  # Patient 資源
│   ├── Observation.cs              # Observation 資源
│   └── ... (148 個 Resources)
├── DataTypes/                      # FHIR DataTypes
│   ├── HumanName.cs                # HumanName 資料型別
│   ├── Address.cs                  # Address 資料型別
│   └── ... (63 個 DataTypes)
├── GlobalUsings.g.cs               # 自動生成的全域別名
├── VERSION_SWITCH_GUIDE.md         # 版本切換指南
└── Fhir.R4.Models.csproj          # 專案檔
```

### 生成統計（R4 vs R5）

| 項目 | R4 | R5 | 說明 |
|------|----|----|------|
| Resources | 148 | 162 | R5 新增 14 個 Resources |
| DataTypes | 63 | 71 | R5 新增 8 個 DataTypes |
| ValueSets | 661 | 778 | R5 新增 117 個 ValueSets |
| 檔案大小 | 8.48 MB | 6.73 MB | R5 定義更精簡 |

## 🔍 詳細功能

### 1. 版本自動偵測

生成器會自動偵測可用的 FHIR 版本：

```bash
# 如果定義檔不存在，會顯示可用版本
dotnet run --project Fhir.Generator -- --fhir-version R6

# 輸出：
# ❌ Definition file not found: Definitions/R6/definitions.json.zip
# 🔍 Available versions:
#    ✅ R4 (8.48 MB)
#    ✅ R5 (6.73 MB)
```

### 2. Global Using 自動生成

每個版本都會自動生成 `GlobalUsings.g.cs`：

```csharp
// Fhir.R4.Models/GlobalUsings.g.cs
global using Patient = Fhir.R4.Models.Resources.Patient;
global using Observation = Fhir.R4.Models.Resources.Observation;
global using HumanName = Fhir.R4.Models.DataTypes.HumanName;
// ... 所有 Resources 和 DataTypes
```

### 3. 型別安全程式碼

生成的程式碼具有完整的型別安全：

```csharp
// 自動生成的 Patient 類別
public class Patient : IDomainResource
{
    [JsonPropertyName("resourceType")]
    public string ResourceType => "Patient";
    
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    
    [JsonPropertyName("active")]
    public bool? Active { get; set; }
    
    [JsonPropertyName("name")]
    public IList<HumanName>? Name { get; set; }
    
    // 驗證方法
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 自動生成的驗證邏輯
    }
}
```

## ⚠️ 注意事項

### 1. 記憶體使用

大型定義檔（>5MB）可能需要較多記憶體：

```bash
# 監控記憶體使用
dotnet run --project Fhir.Generator -- --fhir-version R5 --verbosity detailed
```

### 2. 生成時間

完整生成可能需要 1-2 分鐘：

```bash
# R4: ~60 秒（148 Resources + 63 DataTypes）
# R5: ~90 秒（162 Resources + 71 DataTypes）
```

### 3. 檔案覆寫

生成器會覆寫現有檔案，請確保：
- 沒有未儲存的修改
- 已備份自訂程式碼

## 🐛 故障排除

### 常見問題

#### 1. 定義檔載入失敗

```bash
# 檢查檔案是否存在
ls -la Definitions/R4/definitions.json.zip

# 檢查檔案大小
du -h Definitions/R4/definitions.json.zip
```

#### 2. 記憶體不足

```bash
# 增加記憶體限制
export DOTNET_GCHeapHardLimit=2000000000
dotnet run --project Fhir.Generator -- --fhir-version R5
```

#### 3. 編譯錯誤

```bash
# 清理並重新生成
dotnet clean Fhir.Generator
dotnet build Fhir.Generator
```

## 📈 效能最佳化

### 1. 並行生成

```csharp
// 在 FhirCodeGenerator 中啟用並行處理
await Task.WhenAll(
    resources.Select(r => GenerateResourceAsync(r, outputDir, version))
);
```

### 2. 增量生成

```csharp
// 只生成變更的檔案
if (File.Exists(outputPath) && !HasChanged(definition))
{
    Console.WriteLine($"⏭️  Skipping unchanged: {resourceName}");
    return;
}
```

## 🔗 相關文件

- [新版本生成步驟](new-version-generation.md)
- [版本切換指南](version-switching.md)
- [架構設計](architecture.md)
