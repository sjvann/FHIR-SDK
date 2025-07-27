---
type: "manual"
---

# FHIR Generator 使用手冊

## 📖 **目錄**

1. [概述](#概述)
2. [安裝與設定](#安裝與設定)
3. [基本使用](#基本使用)
4. [進階功能](#進階功能)
5. [生成的程式碼](#生成的程式碼)
6. [故障排除](#故障排除)
7. [最佳實務](#最佳實務)

## 🎯 **概述**

FHIR Generator 是一個命令列工具，用於從 FHIR 定義檔生成符合規範的 C# 模型類別。

### **使用場景**
- 🆕 **新版本發布** - 當 FHIR R5、R6 等新版本發布時
- 🔄 **模型更新** - 需要更新現有模型以符合最新規範
- 🧪 **測試驗證** - 驗證生成的程式碼是否正確

### **核心優勢**
- ⚡ **快速生成** - 幾分鐘內生成完整的 FHIR 模型
- 🎯 **規範符合** - 100% 符合 FHIR 官方規範
- 🛡️ **安全保護** - 自動保護手工優化的檔案
- 📝 **完整註解** - 包含 FHIR Path 和 Cardinality 資訊

## 🛠️ **安裝與設定**

### **系統需求**
- .NET 9.0 或更高版本
- Windows 10/11, macOS, 或 Linux
- 至少 4GB RAM
- 1GB 可用磁碟空間

### **安裝步驟**

#### **1. 克隆專案**
```bash
git clone https://github.com/your-org/FHIR-SDK.git
cd FHIR-SDK
```

#### **2. 建置 Generator**
```bash
dotnet build Fhir.Generator/Fhir.Generator.csproj
```

#### **3. 驗證安裝**
```bash
dotnet run --project Fhir.Generator --help
```

### **環境設定**

#### **設定 FHIR 定義檔路徑**
```bash
# 預設路徑
Fhir.Generator/Definitions/R4/definitions.json.zip

# 自訂路徑 (未來功能)
export FHIR_DEFINITIONS_PATH="/path/to/definitions"
```

## 🚀 **基本使用**

### **命令語法**
```bash
dotnet run --project Fhir.Generator [選項]
```

### **基本選項**
| 選項 | 必填 | 說明 | 範例 |
|------|------|------|------|
| `--fhir-version` | ✅ | FHIR 版本 | `R4`, `R5` |
| `--test` | ❌ | 執行測試模式 | `--test` |
| `--mode` | ❌ | 生成模式 | `interactive`, `empty-only` |
| `--backup` | ❌ | 建立備份 | `--backup` |

### **基本範例**

#### **生成 R4 模型**
```bash
dotnet run --project Fhir.Generator --fhir-version R4
```

#### **測試 Generator 功能**
```bash
dotnet run --project Fhir.Generator --fhir-version R4 --test
```

#### **查看生成結果**
```bash
# 檢查生成的檔案
ls Fhir.R4.Models/Resources/
ls Fhir.R4.Models/DataTypes/

# 檢查特定檔案
cat Fhir.R4.Models/Resources/Patient.cs
```

## 🔧 **進階功能**

### **生成模式 (未來功能)**

#### **互動模式**
```bash
dotnet run --project Fhir.Generator --fhir-version R5 --mode interactive
```
- 提供互動式選單
- 可選擇要生成的 Resources
- 顯示詳細的進度資訊

#### **空殼模式**
```bash
dotnet run --project Fhir.Generator --fhir-version R5 --mode empty-only
```
- 只生成空的類別結構
- 快速解決編譯問題
- 後續可手動實作

#### **複製升級模式**
```bash
dotnet run --project Fhir.Generator --fhir-version R5 --mode copy-from
```
- 從上一版本複製並升級
- 保留現有的手工優化
- 自動處理版本差異

### **備份功能**
```bash
dotnet run --project Fhir.Generator --fhir-version R4 --backup
```
- 自動建立時間戳記備份
- 備份格式：`Fhir.R4.Models.backup.20241225_143022`
- 可安全回復到備份狀態

### **批次處理 (未來功能)**
```bash
# 生成多個版本
dotnet run --project Fhir.Generator --versions R4,R5

# 指定輸出目錄
dotnet run --project Fhir.Generator --fhir-version R4 --output ./Generated/
```

## 📄 **生成的程式碼**

### **專案結構**
```
Fhir.R4.Models/
├── Fhir.R4.Models.csproj
├── Resources/              # FHIR Resources
│   ├── Patient.cs
│   ├── Organization.cs
│   ├── Observation.cs
│   └── ... (150+ Resources)
├── DataTypes/              # FHIR DataTypes
│   ├── PrimitiveTypes/     # 基本類型
│   │   ├── FhirString.cs
│   │   ├── FhirBoolean.cs
│   │   └── ... (20+ Types)
│   └── ComplexTypes/       # 複雜類型
│       ├── Identifier.cs
│       ├── HumanName.cs
│       └── ... (100+ Types)
└── Base/                   # 基礎類別
    ├── Element.cs
    ├── Resource.cs
    └── DomainResource.cs
```

### **程式碼特色**

#### **正確的 FHIR 類型**
```csharp
// ✅ 正確 - 使用 FHIR Primitive Types
public FhirString? Name { get; set; }
public FhirBoolean? Active { get; set; }
public FhirDate? BirthDate { get; set; }

// ❌ 錯誤 - 使用原生 C# 類型
public string? Name { get; set; }
public bool? Active { get; set; }
public string? BirthDate { get; set; }
```

#### **完整的 FHIR 註解**
```csharp
/// <summary>
/// A name associated with the patient
/// FHIR Path: Patient.name
/// Cardinality: 0..*
/// </summary>
[JsonPropertyName("name")]
public List<HumanName>? Name { get; set; }
```

#### **正確的繼承結構**
```csharp
namespace Fhir.R4.Models.Resources;

public class Patient : DomainResource
{
    [JsonPropertyName("resourceType")]
    public override string ResourceType => "Patient";
    
    // ... 屬性定義
}
```

### **檔案保護機制**

Generator 會自動保護以下檔案：
- 包含 `GenericResource<T>` 的檔案
- 包含 `// 手工優化` 註解的檔案
- 包含 `// Custom implementation` 的檔案
- 明顯為手工優化的檔案

## 🔧 **故障排除**

### **常見問題**

#### **編譯錯誤**
```bash
# 問題：找不到 FHIR Primitive Types
error CS0246: 找不到類型或命名空間名稱 'FhirString'

# 解決方案：檢查專案參考
dotnet add reference ../Fhir.R4.Models/
```

#### **檔案權限錯誤**
```bash
# 問題：無法寫入檔案
IOException: Access to the path 'Patient.cs' is denied.

# 解決方案：檢查檔案權限
chmod 644 Fhir.R4.Models/Resources/Patient.cs
```

#### **記憶體不足**
```bash
# 問題：生成大型專案時記憶體不足
OutOfMemoryException: Exception of type 'System.OutOfMemoryException'

# 解決方案：增加記憶體限制
export DOTNET_GCHeapHardLimit=8000000000  # 8GB
```

### **除錯技巧**

#### **啟用詳細日誌**
```bash
dotnet run --project Fhir.Generator --fhir-version R4 --verbosity detailed
```

#### **檢查生成的程式碼**
```bash
# 檢查語法錯誤
dotnet build Fhir.R4.Models/

# 檢查特定檔案
cat Generated_TestResource.cs
```

#### **驗證 FHIR 定義檔**
```bash
# 檢查定義檔是否存在
ls -la Fhir.Generator/Definitions/R4/definitions.json.zip

# 檢查檔案大小 (應該 > 10MB)
du -h Fhir.Generator/Definitions/R4/definitions.json.zip
```

## 💡 **最佳實務**

### **使用建議**

#### **1. 版本管理**
```bash
# 為每個 FHIR 版本建立獨立分支
git checkout -b fhir-r5-generation
dotnet run --project Fhir.Generator --fhir-version R5
git add .
git commit -m "feat: 生成 FHIR R5 模型"
```

#### **2. 備份策略**
```bash
# 生成前建立備份
dotnet run --project Fhir.Generator --fhir-version R4 --backup

# 定期備份手工優化檔案
cp Fhir.R4.Models/Resources/Patient.cs backups/Patient.cs.$(date +%Y%m%d)
```

#### **3. 測試驗證**
```bash
# 生成後立即測試
dotnet run --project Fhir.Generator --fhir-version R4
dotnet build Fhir.R4.Models/
dotnet test Fhir.Generator.Tests/
```

### **效能最佳化**

#### **大型專案處理**
```bash
# 分批生成 (未來功能)
dotnet run --project Fhir.Generator --fhir-version R4 --batch-size 50

# 並行處理 (未來功能)
dotnet run --project Fhir.Generator --fhir-version R4 --parallel 4
```

#### **記憶體管理**
```bash
# 設定記憶體限制
export DOTNET_GCHeapHardLimit=4000000000  # 4GB

# 啟用伺服器 GC
export DOTNET_gcServer=1
```

### **團隊協作**

#### **CI/CD 整合**
```yaml
# .github/workflows/generator.yml
name: FHIR Generator
on:
  workflow_dispatch:
    inputs:
      fhir_version:
        description: 'FHIR Version'
        required: true
        default: 'R4'

jobs:
  generate:
    runs-on: ubuntu-latest
    steps:
    - uses: actions/checkout@v3
    - name: Setup .NET
      uses: actions/setup-dotnet@v3
      with:
        dotnet-version: '9.0.x'
    - name: Generate FHIR Models
      run: |
        dotnet run --project Fhir.Generator --fhir-version ${{ github.event.inputs.fhir_version }}
        dotnet build Fhir.${{ github.event.inputs.fhir_version }}.Models/
```

#### **程式碼審查清單**
- [ ] 生成的程式碼能正確編譯
- [ ] 使用正確的 FHIR Primitive Types
- [ ] 包含完整的 FHIR 註解
- [ ] 沒有覆蓋手工優化檔案
- [ ] 通過所有單元測試

---

## 📞 **需要更多幫助？**

- 📖 查看 [API 參考](./API.md)
- ❓ 查看 [常見問題](./FAQ.md)
- 🔧 查看 [開發指南](./Development.md)
- 🐛 在 GitHub 回報問題
