# FHIR Generator 常見問題

## 📋 **目錄**

- [基本概念](#基本概念)
- [安裝與設定](#安裝與設定)
- [使用問題](#使用問題)
- [生成的程式碼](#生成的程式碼)
- [效能與最佳化](#效能與最佳化)
- [故障排除](#故障排除)

## 🎯 **基本概念**

### **Q: FHIR Generator 的主要用途是什麼？**

**A:** FHIR Generator 是一個專門的工具，用於：
- 當新的 FHIR 版本 (如 R5, R6) 發布時，快速生成對應的 C# 模型類別
- 生成符合 FHIR 規範的程式碼，使用正確的 FHIR Primitive Types
- 保護現有的手工優化檔案，不會意外覆蓋

**重要：** Generator 只負責模型生成，不處理 JSON 序列化、驗證邏輯等 SDK 功能。

### **Q: Generator 與其他 FHIR .NET 函式庫有什麼不同？**

**A:** 主要差異：
- **專注模型生成** - 不是完整的 FHIR SDK
- **版本特化** - 為每個 FHIR 版本生成獨立的模型專案
- **正確的類型系統** - 使用 `FhirString`, `FhirBoolean` 等，不是原生 C# 類型
- **保護機制** - 智能保護手工優化的檔案

### **Q: 什麼時候需要使用 Generator？**

**A:** 典型使用場景：
- 🆕 FHIR 新版本發布 (R5, R6)
- 🔄 需要更新現有模型以符合最新規範
- 🧪 驗證生成的程式碼品質
- 🏗️ 建立新的 FHIR 專案

## 🛠️ **安裝與設定**

### **Q: 支援哪些作業系統？**

**A:** Generator 支援所有 .NET 9.0 支援的平台：
- ✅ Windows 10/11
- ✅ macOS 10.15+
- ✅ Linux (Ubuntu, CentOS, Debian 等)

### **Q: 最低系統需求是什麼？**

**A:** 
- **.NET 9.0 SDK** (必須)
- **4GB RAM** (建議 8GB)
- **1GB 可用磁碟空間**
- **Git** (用於克隆專案)

### **Q: 如何驗證安裝是否成功？**

**A:** 執行以下命令：
```bash
# 檢查 .NET 版本
dotnet --version

# 測試 Generator
dotnet run --project Fhir.Generator --fhir-version R4 --test

# 檢查建置
dotnet build Fhir.R4.Models/
```

## 🚀 **使用問題**

### **Q: 如何生成 R4 模型？**

**A:** 
```bash
# 基本生成
dotnet run --project Fhir.Generator --fhir-version R4

# 測試模式
dotnet run --project Fhir.Generator --fhir-version R4 --test
```

### **Q: 支援 R5 嗎？**

**A:** 目前狀態：
- ✅ **R4** - 完整支援
- 🚧 **R5** - 規劃中，等待 R5 正式發布
- 🚧 **R6** - 規劃中

### **Q: 如何保護手工優化的檔案？**

**A:** Generator 會自動保護包含以下內容的檔案：
- `GenericResource<T>`
- `// 手工優化`
- `// Custom implementation`
- 明顯的手工優化模式

您也可以手動標記檔案：
```csharp
// 手工優化 - 請勿覆蓋
public class Patient : GenericDomainResource<Patient>
{
    // 自訂實作
}
```

### **Q: 如何建立備份？**

**A:** 
```bash
# 自動備份 (未來功能)
dotnet run --project Fhir.Generator --fhir-version R4 --backup

# 手動備份
cp -r Fhir.R4.Models Fhir.R4.Models.backup.$(date +%Y%m%d)
```

## 📄 **生成的程式碼**

### **Q: 為什麼使用 FhirString 而不是 string？**

**A:** 這是 FHIR 規範的要求：
```csharp
// ✅ 正確 - 符合 FHIR 規範
public FhirString? Name { get; set; }

// ❌ 錯誤 - 不符合 FHIR 規範
public string? Name { get; set; }
```

**原因：**
- FHIR Primitive Types 包含額外的驗證邏輯
- 支援 FHIR 特定的序列化需求
- 提供更好的類型安全性

### **Q: 生成的程式碼包含哪些資訊？**

**A:** 每個屬性都包含：
```csharp
/// <summary>
/// 屬性描述
/// FHIR Path: Resource.property
/// Cardinality: 0..1
/// </summary>
[JsonPropertyName("property")]
public FhirString? Property { get; set; }
```

### **Q: 如何自訂生成的程式碼？**

**A:** 目前 Generator 專注於標準 FHIR 規範，不支援自訂。如需自訂：
1. 生成標準程式碼
2. 手動修改並標記為手工優化
3. Generator 會自動保護這些檔案

## ⚡ **效能與最佳化**

### **Q: 生成大型專案時記憶體不足怎麼辦？**

**A:** 
```bash
# 增加記憶體限制
export DOTNET_GCHeapHardLimit=8000000000  # 8GB

# 啟用伺服器 GC
export DOTNET_gcServer=1

# 分批生成 (未來功能)
dotnet run --project Fhir.Generator --fhir-version R4 --batch-size 50
```

### **Q: 生成速度很慢怎麼辦？**

**A:** 最佳化建議：
- 確保有足夠的 RAM (建議 8GB+)
- 使用 SSD 硬碟
- 關閉防毒軟體的即時掃描
- 使用 Release 模式建置

### **Q: 可以並行生成嗎？**

**A:** 
```bash
# 未來功能 - 並行處理
dotnet run --project Fhir.Generator --fhir-version R4 --parallel 4
```

## 🔧 **故障排除**

### **Q: 編譯錯誤：找不到 FhirString**

**A:** 
```bash
# 檢查專案參考
dotnet list reference

# 添加缺失的參考
dotnet add reference ../Fhir.R4.Models/

# 重新建置
dotnet build
```

### **Q: 權限錯誤：無法寫入檔案**

**A:** 
```bash
# Linux/macOS
chmod 755 Fhir.R4.Models/
chmod 644 Fhir.R4.Models/Resources/*.cs

# Windows (以管理員身分執行)
icacls Fhir.R4.Models /grant %USERNAME%:F /T
```

### **Q: OutOfMemoryException 錯誤**

**A:** 
```bash
# 檢查可用記憶體
free -h  # Linux
vm_stat  # macOS

# 增加虛擬記憶體
# 或使用更強大的機器
```

### **Q: 生成的程式碼有語法錯誤**

**A:** 
```bash
# 檢查 Generator 版本
git log --oneline -5

# 重新生成
dotnet clean
dotnet run --project Fhir.Generator --fhir-version R4

# 檢查語法
dotnet build Fhir.R4.Models/
```

### **Q: 定義檔案損壞或缺失**

**A:** 
```bash
# 檢查定義檔
ls -la Fhir.Generator/Definitions/R4/definitions.json.zip

# 重新下載定義檔 (如果需要)
# 從 FHIR 官方網站下載最新的定義檔
```

## 🔮 **未來功能**

### **Q: 什麼時候會支援 R5？**

**A:** R5 支援正在規劃中，預計在 FHIR R5 正式發布後的 3-6 個月內提供支援。

### **Q: 會支援自訂範本嗎？**

**A:** 這在我們的長期規劃中 (v2.0)，但目前專注於標準 FHIR 規範的支援。

### **Q: 會有 GUI 介面嗎？**

**A:** 目前專注於命令列介面，GUI 介面可能在未來版本中考慮。

## 📞 **還有其他問題？**

如果您的問題沒有在這裡找到答案：

- 📖 查看 [使用手冊](./UserGuide.md)
- 🔧 查看 [開發指南](./Development.md)
- 🐛 在 [GitHub Issues](https://github.com/your-org/FHIR-SDK/issues) 回報問題
- 💬 參與 [GitHub Discussions](https://github.com/your-org/FHIR-SDK/discussions)

---

**💡 提示：大部分問題都可以通過重新建置和清理快取解決！**
