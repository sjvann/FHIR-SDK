# FHIR Generator 快速開始

## ⚡ **5分鐘快速上手**

這個指南將帶您在 5 分鐘內完成 FHIR Generator 的安裝和第一次使用。

## 📋 **前置需求**

在開始之前，請確保您的系統已安裝：

- ✅ **.NET 9.0 SDK** - [下載連結](https://dotnet.microsoft.com/download/dotnet/9.0)
- ✅ **Git** - [下載連結](https://git-scm.com/downloads)
- ✅ **文字編輯器** - VS Code, Visual Studio, 或任何您喜歡的編輯器

### **驗證安裝**
```bash
# 檢查 .NET 版本
dotnet --version
# 應該顯示 9.0.x 或更高版本

# 檢查 Git 版本
git --version
```

## 🚀 **步驟 1: 取得專案**

```bash
# 克隆專案
git clone https://github.com/your-org/FHIR-SDK.git

# 進入專案目錄
cd FHIR-SDK

# 檢查專案結構
ls -la
```

**預期輸出：**
```
Fhir.Core/
Fhir.Generator/
Fhir.R4.Models/
docs/
FHIR-SDK.sln
README.md
```

## 🔧 **步驟 2: 建置 Generator**

```bash
# 建置 Generator 專案
dotnet build Fhir.Generator/

# 驗證建置成功
echo $?
# 應該顯示 0 (表示成功)
```

**如果建置失敗：**
```bash
# 清理並重新建置
dotnet clean
dotnet restore
dotnet build Fhir.Generator/
```

## 🧪 **步驟 3: 測試 Generator**

```bash
# 執行測試模式
dotnet run --project Fhir.Generator --fhir-version R4 --test
```

**預期輸出：**
```
🚀 Enhanced FHIR Code Generator
================================
🧪 測試 Generator 生成結果
📄 生成的程式碼:
================
// Auto-generated for FHIR R4 - Based on existing architecture
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.R4.Models.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// A simple test resource for validation
/// </summary>
public class TestResource : DomainResource
{
    [JsonPropertyName("resourceType")]
    public override string ResourceType => "TestResource";

    /// <summary>
    /// A name for the test resource
    /// FHIR Path: TestResource.name
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("name")]
    public FhirString? Name { get; set; }
    
    // ... 更多屬性
}

✅ 程式碼已儲存到: Generated_TestResource.cs
```

## 📄 **步驟 4: 檢查生成結果**

```bash
# 查看生成的測試檔案
cat Generated_TestResource.cs

# 檢查現有的 R4 模型
ls Fhir.R4.Models/Resources/
```

**重要檢查點：**
- ✅ 使用 `FhirString?` 而不是 `string?`
- ✅ 包含 FHIR Path 註解
- ✅ 包含 Cardinality 資訊
- ✅ 正確的命名空間 `Fhir.R4.Models.Resources`

## 🎯 **步驟 5: 生成完整模型 (可選)**

```bash
# 生成完整的 R4 模型
dotnet run --project Fhir.Generator --fhir-version R4

# 檢查生成結果
dotnet build Fhir.R4.Models/
```

**注意：** 這個步驟會更新現有的 R4 模型，但會保護手工優化的檔案。

## ✅ **驗證安裝成功**

### **檢查 1: 編譯測試**
```bash
# 建置 R4 模型專案
dotnet build Fhir.R4.Models/

# 應該看到 "建置成功" 訊息
```

### **檢查 2: 執行測試**
```bash
# 執行 Generator 測試
dotnet test Fhir.Generator.Tests/

# 應該看到測試通過的訊息
```

### **檢查 3: 檢查生成的程式碼品質**
```bash
# 檢查 Patient.cs 是否使用正確的類型
grep -n "FhirString\|FhirBoolean" Fhir.R4.Models/Resources/Patient.cs

# 檢查是否包含 FHIR Path 註解
grep -n "FHIR Path:" Generated_TestResource.cs
```

## 🎉 **恭喜！您已成功設定 FHIR Generator**

現在您可以：

### **基本操作**
```bash
# 生成 R4 模型
dotnet run --project Fhir.Generator --fhir-version R4

# 測試生成功能
dotnet run --project Fhir.Generator --fhir-version R4 --test
```

### **未來功能 (規劃中)**
```bash
# 生成 R5 模型 (當 R5 支援完成時)
dotnet run --project Fhir.Generator --fhir-version R5

# 互動模式
dotnet run --project Fhir.Generator --fhir-version R5 --mode interactive

# 建立備份
dotnet run --project Fhir.Generator --fhir-version R4 --backup
```

## 🔧 **常見問題快速解決**

### **問題 1: 找不到 .NET**
```bash
# 檢查 PATH 環境變數
echo $PATH | grep dotnet

# 重新安裝 .NET SDK
# 前往 https://dotnet.microsoft.com/download
```

### **問題 2: 建置失敗**
```bash
# 清理並重新建置
dotnet clean
dotnet restore
dotnet build
```

### **問題 3: 權限錯誤**
```bash
# Linux/macOS
sudo chown -R $USER:$USER .

# Windows (以管理員身分執行)
icacls . /grant %USERNAME%:F /T
```

### **問題 4: 記憶體不足**
```bash
# 增加記憶體限制
export DOTNET_GCHeapHardLimit=4000000000  # 4GB
```

## 📚 **下一步**

現在您已經成功設定了 FHIR Generator，建議您：

1. **📖 閱讀完整文件**
   - [使用手冊](./UserGuide.md) - 詳細的使用說明
   - [API 參考](./API.md) - 完整的 API 文件

2. **🧪 深入測試**
   - 嘗試生成不同的 Resources
   - 檢查生成的程式碼品質
   - 執行完整的測試套件

3. **🔧 自訂設定**
   - 了解檔案保護機制
   - 學習進階生成選項
   - 設定 CI/CD 整合

4. **🤝 參與社群**
   - 回報問題或建議
   - 參與開發討論
   - 貢獻程式碼或文件

## 📞 **需要幫助？**

如果您在快速開始過程中遇到任何問題：

- 📖 **查看詳細文件** - [使用手冊](./UserGuide.md)
- ❓ **常見問題** - [FAQ](./FAQ.md)
- 🐛 **回報問題** - [GitHub Issues](https://github.com/your-org/FHIR-SDK/issues)
- 💬 **參與討論** - [GitHub Discussions](https://github.com/your-org/FHIR-SDK/discussions)

---

**🎯 記住：Generator 專注於 FHIR 模型生成，是您 FHIR 開發的強力工具！**
