# FHIR Type Framework 測試專案

## 概述

本測試專案為 `Fhir.TypeFramework` 提供完整的單元測試，確保所有 FHIR Primitive Types 的功能正確運作。

## 測試結構

### 1. **PrimitiveTypeTests.cs**
- 基本 Primitive Type 功能測試
- 隱含轉換測試
- 驗證測試
- JSON 序列化測試
- Extension 功能測試
- 深層複製測試
- 相等性測試

### 2. **AllPrimitiveTypesTests.cs**
- 所有 Primitive Types 的綜合測試
- 型別名稱測試
- 隱含轉換測試
- 驗證測試
- JSON 序列化測試
- Extension 功能測試
- 深層複製測試
- 相等性測試
- NULL 處理測試
- ToString 測試

## 測試涵蓋範圍

### ✅ **基本功能**
- [x] 物件建立
- [x] 值設定與取得
- [x] NULL 值處理
- [x] ToString 方法

### ✅ **型別轉換**
- [x] 隱含轉換（從程式語言型別到 FHIR 型別）
- [x] 隱含轉換（從 FHIR 型別到程式語言型別）
- [x] 型別安全檢查

### ✅ **驗證功能**
- [x] 基本驗證
- [x] FHIR 規範驗證
- [x] 錯誤訊息檢查

### ✅ **JSON 序列化**
- [x] 簡化 JSON 序列化
- [x] 完整 JSON 序列化
- [x] FHIR 格式 JSON 序列化
- [x] JSON 反序列化

### ✅ **Extension 功能**
- [x] 添加 Extension
- [x] 取得 Extension
- [x] 移除 Extension
- [x] Extension 驗證

### ✅ **物件操作**
- [x] 深層複製
- [x] 相等性比較
- [x] 型別名稱取得

## 測試的 Primitive Types

| FHIR Primitive Type | 測試狀態 | 說明 |
|-------------------|---------|------|
| FhirString | ✅ | 字串型別，支援 1MB 限制驗證 |
| FhirInteger | ✅ | 整數型別，支援 32-bit 範圍驗證 |
| FhirBoolean | ✅ | 布林型別，支援 true/false 值 |
| FhirDecimal | ✅ | 十進位數型別，支援精確度處理 |
| FhirDateTime | ✅ | 日期時間型別，支援 ISO 8601 格式 |
| FhirUri | ✅ | URI 型別，支援 URI 格式驗證 |

## 執行測試

### 使用 Visual Studio
1. 開啟 `Fhir.TypeFramework.Tests` 專案
2. 在測試總管中執行所有測試
3. 查看測試結果和覆蓋率

### 使用命令列
```bash
# 執行所有測試
dotnet test

# 執行特定測試
dotnet test --filter "FhirString_WithValidValue_ShouldWork"

# 生成覆蓋率報告
dotnet test --collect:"XPlat Code Coverage"
```

## 測試範例

### 基本使用測試
```csharp
[Fact]
public void FhirString_WithValidValue_ShouldWork()
{
    // Arrange & Act
    var fhirString = new FhirString("Hello World");

    // Assert
    Assert.Equal("Hello World", fhirString.Value);
    Assert.Equal("Hello World", fhirString.ToString());
    Assert.False(fhirString.IsNull);
}
```

### 隱含轉換測試
```csharp
[Fact]
public void FhirString_ImplicitConversion_FromString_ShouldWork()
{
    // Arrange & Act
    FhirString fhirString = "Implicit Conversion";

    // Assert
    Assert.Equal("Implicit Conversion", fhirString.Value);
}
```

### 驗證測試
```csharp
[Fact]
public void FhirString_WithLargeValue_ShouldFailValidation()
{
    // Arrange
    var largeString = new string('A', 1024 * 1024 + 1); // 超過 1MB
    var fhirString = new FhirString(largeString);

    // Act
    var validationResults = fhirString.Validate(new ValidationContext(fhirString));

    // Assert
    Assert.NotEmpty(validationResults);
    Assert.Contains("cannot exceed 1MB", validationResults.First().ErrorMessage);
}
```

### JSON 序列化測試
```csharp
[Fact]
public void FhirJsonSerializer_SerializeFhirFormat_ShouldWork()
{
    // Arrange
    var serializer = new FhirJsonSerializer();
    var fhirString = new FhirString("Test FHIR Format");
    fhirString.Id = "test-id";

    // Act
    var json = serializer.SerializeFhirFormat("name", fhirString);

    // Assert
    Assert.Contains("\"name\"", json);
    Assert.Contains("\"_name\"", json);
    Assert.Contains("Test FHIR Format", json);
    Assert.Contains("test-id", json);
}
```

## 測試結果

### 預期結果
- ✅ 所有基本功能測試通過
- ✅ 所有型別轉換測試通過
- ✅ 所有驗證測試通過
- ✅ 所有 JSON 序列化測試通過
- ✅ 所有 Extension 功能測試通過
- ✅ 所有物件操作測試通過

### 覆蓋率目標
- 程式碼覆蓋率：> 90%
- 分支覆蓋率：> 85%
- 行覆蓋率：> 95%

## 持續整合

### GitHub Actions
```yaml
name: Tests
on: [push, pull_request]
jobs:
  test:
    runs-on: ubuntu-latest
    steps:
    - uses: actions/checkout@v3
    - name: Setup .NET
      uses: actions/setup-dotnet@v3
      with:
        dotnet-version: 8.0.x
    - name: Restore dependencies
      run: dotnet restore
    - name: Build
      run: dotnet build --no-restore
    - name: Test
      run: dotnet test --no-build --verbosity normal
```

## 故障排除

### 常見問題

1. **測試失敗：隱含轉換**
   - 檢查是否正確實作了隱含轉換運算子
   - 確認型別約束正確

2. **測試失敗：JSON 序列化**
   - 檢查 JSON 格式是否符合 FHIR 規範
   - 確認序列化器設定正確

3. **測試失敗：驗證**
   - 檢查驗證邏輯是否符合 FHIR 規範
   - 確認錯誤訊息正確

### 除錯技巧

1. **使用 Debug 模式執行測試**
   ```bash
   dotnet test --verbosity normal --logger "console;verbosity=detailed"
   ```

2. **檢查特定測試**
   ```bash
   dotnet test --filter "FhirString" --verbosity normal
   ```

3. **生成詳細報告**
   ```bash
   dotnet test --logger "trx;LogFileName=test-results.trx"
   ```

## 未來擴展

### 計劃中的測試
- [ ] 效能測試
- [ ] 記憶體使用測試
- [ ] 並發測試
- [ ] 邊界條件測試
- [ ] 錯誤處理測試

### 新增 Primitive Types
當新增新的 Primitive Types 時，請確保：
1. 建立對應的測試類別
2. 實作所有必要的測試方法
3. 更新測試文件
4. 執行所有測試確保通過

## 結論

本測試專案提供了完整的 FHIR Primitive Types 測試覆蓋，確保：
- 所有功能正確運作
- 符合 FHIR R5 規範
- 提供良好的開發者體驗
- 支援持續整合和部署 