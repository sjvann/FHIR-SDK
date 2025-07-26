// 全域別名 - 實現無縫切換的關鍵
global using Patient = Fhir.R4.Models.Resources.Patient;
global using Observation = Fhir.R4.Models.Resources.Observation;

using Fhir.Abstractions.Resources;
using Fhir.Core;
using Fhir.R4.Models.Resources;

namespace R4Example;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("🏥 FHIR R4 範例程式 - 無縫版本切換");
        Console.WriteLine("=====================================");

        // 設定使用 R4 版本
        FhirVersion.UseR4();
        var versionInfo = FhirVersion.GetVersionInfo();
        Console.WriteLine($"📋 使用版本: {versionInfo.Name} ({versionInfo.Number})");

        Console.WriteLine("\n🔧 方法 1: 使用具體類型 (版本特定)");
        // 直接使用 R4 具體類型
        var r4Patient = new Patient
        {
            Id = "r4-patient-001",
            Active = true,
            Gender = "male",
            BirthDate = "1990-01-01"
        };

        Console.WriteLine($"✅ R4 Patient: {r4Patient.Id}");
        Console.WriteLine($"   類型: {r4Patient.GetType().FullName}");

        Console.WriteLine("\n🔧 方法 2: 使用泛型 Resource (版本無關)");
        // 使用 IResource - 這是無縫切換的關鍵
        var interfacePatient = new Patient
        {
            Id = "interface-patient-001",
            Active = true,
            Gender = "female",
            BirthDate = "1985-05-15"
        };

        Console.WriteLine($"✅ Generic Patient: {interfacePatient.Id}");
        Console.WriteLine($"   Resource Type: {interfacePatient.ResourceType}");
        Console.WriteLine($"   實作類型: {interfacePatient.GetType().FullName}");

        Console.WriteLine("\n🔧 方法 3: 使用全域別名 (推薦)");
        // 使用全域別名 - 切換版本只需要改變 global using
        var aliasPatient = new Patient  // 這個 Patient 來自 global using
        {
            Id = "alias-patient-001",
            Active = true,
            Gender = "other"
        };

        Console.WriteLine($"✅ Alias Patient: {aliasPatient.Id}");
        Console.WriteLine($"   實際類型: {aliasPatient.GetType().FullName}");

        Console.WriteLine("\n🎉 無縫版本切換範例完成！");
        Console.WriteLine("💡 要切換到 R5，只需要：");
        Console.WriteLine("   1. 改變套件參照: Fhir.R4.Models → Fhir.R5.Models");
        Console.WriteLine("   2. 改變 global using: Fhir.R4.Models → Fhir.R5.Models");
        Console.WriteLine("   3. 程式碼保持不變！");
    }
}
