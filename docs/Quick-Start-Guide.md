# FHIR SDK 快速入門指南

## 🎯 目標讀者
本指南專為想要在 .NET 環境中使用 FHIR 的開發者而設計，無論您是初學者還是有經驗的開發者，都能快速上手。

## 📚 什麼是 FHIR？

FHIR (Fast Healthcare Interoperability Resources) 是一個現代化的醫療資訊交換標準，由 HL7 組織制定。它利用 RESTful API 和標準的 JSON/XML 格式，讓不同的醫療資訊系統能夠無縫地交換資料。

### 核心概念
- **資源 (Resources)**：標準化的資料結構，如 `Patient`、`Observation` 等。
- **序列化**：將 C# 物件轉換為 JSON 或 XML 字串。
- **反序列化**：將 JSON 或 XML 字串轉換為 C# 物件。
- **驗證**：確保資料符合 FHIR 規範。

---

## 🚀 5分鐘快速開始

### 步驟1：建立新專案
```bash
# 建立一個新的主控台應用程式
dotnet new console -n MyFhirApp
cd MyFhirApp

# 安裝 FHIR SDK 套件 (假設已發布至 NuGet)
dotnet add package Fhir.SDK
```

### 步驟2：讀取、驗證與轉換

假設您有一個 `patient.json` 檔案：
```json
{
  "resourceType": "Patient",
  "id": "example",
  "name": [
    {
      "use": "official",
      "family": "Chalmers",
      "given": [
        "Peter",
        "James"
      ]
    }
  ],
  "gender": "male",
  "birthDate": "1974-12-25"
}
```

在 `Program.cs` 中撰寫以下程式碼：

```csharp
using System;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

class Program
{
    static void Main(string[] args)
    {
        // 1. 從 JSON 檔案讀取並反序列化
        var jsonContent = File.ReadAllText("patient.json");
        var parser = new FhirJsonParser();
        Patient patient = parser.Parse<Patient>(jsonContent);

        Console.WriteLine($"成功讀取患者: {patient.Name.FirstOrDefault()}");

        // 2. 進行一些簡單的操作
        patient.Active = true;

        // 3. 內建驗證
        var validationResult = patient.Validate();
        if (validationResult.IsValid)
        {
            Console.WriteLine("患者資料驗證通過！");
        }
        else
        {
            Console.WriteLine("患者資料驗證失敗：");
            foreach (var issue in validationResult.Issues)
            {
                Console.WriteLine($"- {issue.Details}");
            }
        }

        // 4. 序列化為 XML
        var serializer = new FhirXmlSerializer(new SerializerSettings
        {
            Pretty = true // 輸出格式化的 XML
        });
        var xmlContent = serializer.SerializeToString(patient);

        Console.WriteLine("\n轉換為 XML 格式：");
        Console.WriteLine(xmlContent);

        // 5. 將 XML 寫入檔案
        File.WriteAllText("patient.xml", xmlContent);
        Console.WriteLine("\n已將 XML 內容儲存至 patient.xml");
    }
}
```

### 步驟3：運行應用程式
```bash
dotnet run
```

---

## 🔧 開發工具與資源

### 推薦工具
- **Visual Studio 2022** 或 **VS Code**
- **.NET 9 SDK**
- **[FHIR Official Website](https://hl7.org/fhir/)**：查閱官方規範文件
- **[Simplifier.net](https://simplifier.net/)**：瀏覽和查找 FHIR 資源定義

### 偵錯技巧
- 使用 `SerializerSettings` 中的 `Pretty = true` 來輸出可讀性更高的 JSON/XML。
- 在偵錯模式下，檢查反序列化後物件的屬性，確保資料正確對應。

---

## 📖 學習資源

1.  **[FHIR 官方文件](https://hl7.org/fhir/resourcelist.html)**：所有 FHIR 資源的權威指南。
2.  **[本 SDK 的進階使用手冊](docs/Advanced-User-Manual.md)**：深入了解本 SDK 的高級功能。
3.  **[StackOverflow FHIR 標籤](https://stackoverflow.com/questions/tagged/hl7-fhir)**：尋求社群的幫助。

---

## 🎯 下一步

完成本指南後，您可以嘗試：
- 處理更複雜的 FHIR 資源，例如 `Bundle`。
- 探索如何使用本 SDK 處理自訂的 FHIR Profile 和擴充。
- 將本 SDK 整合到您現有的 .NET 應用程式中。
