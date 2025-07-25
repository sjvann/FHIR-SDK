# 快速開始

5 分鐘快速上手 FHIR SDK！

## 🎯 安裝

```bash
# 建立新專案
dotnet new console -n MyFhirApp
cd MyFhirApp

# 安裝 FHIR R4 套件
dotnet add package Fhir.Support
dotnet add package Fhir.Abstractions  
dotnet add package Fhir.R4.Models
```

## 🚀 第一個範例

```csharp
// Program.cs
using Fhir.R4.Models.Resources;

// 建立 Patient
var patient = new Patient
{
    Id = "example-001",
    Active = true,
    Gender = "male"
};

Console.WriteLine($"建立 Patient: {patient.Id}");
Console.WriteLine($"Resource Type: {patient.ResourceType}");
Console.WriteLine($"性別: {patient.Gender}");
Console.WriteLine($"啟用狀態: {patient.Active}");
```

## ▶️ 執行

```bash
dotnet run
```

輸出：
```
建立 Patient: example-001
Resource Type: Patient
性別: male
啟用狀態: True
```

## 🔄 切換到 R5

只需要改變套件參照：

```bash
# 移除 R4
dotnet remove package Fhir.R4.Models

# 安裝 R5  
dotnet add package Fhir.R5.Models
```

程式碼完全不用改！

## 📚 下一步

- [詳細使用範例](usage-examples.md)
- [版本切換指南](version-switching.md)
- [完整安裝指南](installation.md)
