---
type: "manual"
---

# FHIR Generator 完整文件

## 📚 **文件索引**

### **基礎文件**
- [README.md](../Fhir.Generator/README.md) - 使用說明和快速開始
- [ARCHITECTURE.md](../Fhir.Generator/ARCHITECTURE.md) - 架構設計文件
- [API.md](../Fhir.Generator/API.md) - API 參考文件
- [CHANGELOG.md](../Fhir.Generator/CHANGELOG.md) - 版本更新日誌

### **開發文件**
- [開發指南](#開發指南) - 如何參與 Generator 開發
- [測試指南](#測試指南) - 如何執行和編寫測試
- [部署指南](#部署指南) - 如何部署和發布

## 🎯 **Generator 概述**

FHIR Generator 是 FHIR .NET SDK 的核心工具，專門負責生成符合 FHIR 規範的 C# 模型類別。

### **核心定位**
> 當新的 FHIR 版本發布時，快速生成對應的 C# 模型專案

### **設計哲學**
- **專注核心職責** - 只做模型生成，不偏離核心功能
- **符合 FHIR 規範** - 生成的程式碼完全符合 FHIR 標準
- **保護現有工作** - 不會覆蓋手工優化的檔案
- **版本化支援** - 支援多個 FHIR 版本並存

## 🚀 **快速開始**

### **安裝需求**
- .NET 9.0 或更高版本
- Visual Studio 2022 或 VS Code

### **基本使用**
```bash
# 克隆專案
git clone https://github.com/your-org/FHIR-SDK.git
cd FHIR-SDK

# 建置 Generator
dotnet build Fhir.Generator/

# 生成 R4 模型
dotnet run --project Fhir.Generator --fhir-version R4

# 測試 Generator
dotnet run --project Fhir.Generator --fhir-version R4 --test
```

### **驗證安裝**
```bash
# 執行測試
dotnet test Fhir.Generator.Tests/

# 檢查生成結果
ls Fhir.R4.Models/Resources/
```

## 🔧 **開發指南**

### **專案結構**
```
Fhir.Generator/
├── Services/           # 核心生成邏輯
│   ├── SimpleGenerator.cs
│   ├── TypeMapper.cs
│   └── FhirDefinitionLoader.cs
├── Models/             # 內部資料模型
│   └── GeneratorModels.cs
├── Definitions/        # FHIR 定義檔
│   └── R4/
│       └── definitions.json.zip
├── Tests/              # 單元測試
└── docs/               # 文件
```

### **開發環境設定**
1. **安裝 .NET 9.0 SDK**
2. **安裝 Visual Studio 2022** (推薦) 或 VS Code
3. **克隆專案並開啟方案檔** `FHIR-SDK.sln`

### **程式碼風格**
- 使用 C# 命名慣例
- 所有公開成員都要有 XML 註解
- 遵循 SOLID 原則
- 保持方法簡潔 (< 50 行)

### **提交規範**
```
feat: 添加 R5 支援
fix: 修正類型映射錯誤
docs: 更新 API 文件
test: 添加生成測試
refactor: 重構 TypeMapper
```

## 🧪 **測試指南**

### **測試結構**
```
Fhir.Generator.Tests/
├── GeneratedCodeCompilationTests.cs  # 編譯測試
├── SdkUsageTests.cs                   # SDK 使用測試
└── UnitTests/                         # 單元測試
    ├── SimpleGeneratorTests.cs
    ├── TypeMapperTests.cs
    └── DefinitionLoaderTests.cs
```

### **執行測試**
```bash
# 執行所有測試
dotnet test Fhir.Generator.Tests/

# 執行特定測試
dotnet test --filter "GeneratedCodeCompilationTests"

# 產生覆蓋率報告
dotnet test --collect:"XPlat Code Coverage"
```

### **編寫測試**
```csharp
[Fact]
public void GenerateSimpleResource_ShouldCreateValidCode()
{
    // Arrange
    var generator = new SimpleGenerator();
    var resourceInfo = CreateTestResourceInfo();
    
    // Act
    var result = generator.GenerateSimpleResource(resourceInfo, "R4");
    
    // Assert
    Assert.Contains("public class TestResource : DomainResource", result);
    Assert.Contains("FhirString?", result);
}
```

## 📦 **部署指南**

### **建置發布版本**
```bash
# 建置 Release 版本
dotnet build --configuration Release

# 發布獨立執行檔
dotnet publish --configuration Release --self-contained true
```

### **Docker 部署**
```dockerfile
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY . .
RUN dotnet publish Fhir.Generator -c Release -o /app

FROM mcr.microsoft.com/dotnet/runtime:9.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "Fhir.Generator.dll"]
```

### **CI/CD 整合**
```yaml
# GitHub Actions 範例
name: Build and Test Generator
on: [push, pull_request]

jobs:
  test:
    runs-on: ubuntu-latest
    steps:
    - uses: actions/checkout@v3
    - name: Setup .NET
      uses: actions/setup-dotnet@v3
      with:
        dotnet-version: '9.0.x'
    - name: Build
      run: dotnet build Fhir.Generator/
    - name: Test
      run: dotnet test Fhir.Generator.Tests/
```

## 🔮 **未來規劃**

### **短期目標 (v1.1)**
- [ ] 支援 FHIR R5
- [ ] 版本間差異分析
- [ ] 互動式生成模式

### **中期目標 (v1.2)**
- [ ] 自動備份機制
- [ ] 批次生成功能
- [ ] 效能最佳化

### **長期目標 (v2.0)**
- [ ] 支援所有 FHIR 版本
- [ ] 插件式擴展機制
- [ ] 完整的 CI/CD 整合

## 🤝 **貢獻指南**

### **如何貢獻**
1. **Fork 專案**
2. **建立功能分支** (`git checkout -b feature/amazing-feature`)
3. **提交變更** (`git commit -m 'Add amazing feature'`)
4. **推送到分支** (`git push origin feature/amazing-feature`)
5. **建立 Pull Request**

### **貢獻類型**
- 🐛 **錯誤修正** - 修正現有功能的問題
- ✨ **新功能** - 添加新的生成功能
- 📚 **文件改善** - 改善文件品質
- 🧪 **測試增強** - 添加或改善測試
- 🔧 **重構** - 改善程式碼結構

### **程式碼審查**
所有 Pull Request 都需要經過程式碼審查：
- 確保符合程式碼風格
- 驗證測試覆蓋率
- 檢查文件完整性
- 確認不偏離 Generator 核心職責

## 📞 **支援與回饋**

### **取得幫助**
- 📖 **文件** - 查看完整文件
- 🐛 **問題回報** - 在 GitHub Issues 回報問題
- 💬 **討論** - 在 GitHub Discussions 參與討論

### **聯絡方式**
- **Email**: fhir-sdk@example.com
- **GitHub**: https://github.com/your-org/FHIR-SDK
- **文件**: https://fhir-sdk.readthedocs.io/

---

**記住：Generator 的核心使命是專注於 FHIR 模型生成，不偏離核心職責！** 🎯
