# FHIR R5 版本切換指南

## 🎯 無縫版本切換

這個專案已經自動設定了所有 FHIR Resources 和 DataTypes 的 Global Using 別名。

### 使用方式
```csharp
// 直接使用，無需 using 語句
var patient = new Patient();
var observation = new Observation();
var humanName = new HumanName();
```

### 切換到其他版本
1. 改變套件參照
2. 重新生成程式碼
3. 程式碼自動適用新版本！

### 版本資訊
- 當前版本: R5
- 生成時間: 2025-07-24 13:34:30 UTC
- Global Using 檔案: GlobalUsings.g.cs
