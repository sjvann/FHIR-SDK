using Fhir.Support.Base;
using Fhir.R5.Models.Resources;
using Fhir.R5.Models.DataTypes;

namespace R5Example;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("🏥 FHIR R5 範例程式");
        Console.WriteLine("==================");

        // 建立 R5 Patient 資源
        var patient = new Patient
        {
            Id = "example-patient-r5-001",
            Active = true,
            // R5 可能有新的屬性或改變的屬性
            Gender = AdministrativeGender.Male,
        };

        Console.WriteLine($"✅ 建立 R5 Patient: {patient.Id}");
        Console.WriteLine($"   性別: {patient.Gender}");
        Console.WriteLine($"   啟用狀態: {patient.Active}");

        // 建立 R5 Observation 資源
        var observation = new Observation
        {
            Id = "example-observation-r5-001",
            Status = ObservationStatus.Final,
            // R5 可能有新的屬性或改變的屬性
        };

        Console.WriteLine($"✅ 建立 R5 Observation: {observation.Id}");
        Console.WriteLine($"   狀態: {observation.Status}");

        Console.WriteLine("\n🎉 R5 範例執行完成！");
        Console.WriteLine("💡 這個範例展示了如何使用獨立的 Fhir.R5.Models 套件");
        Console.WriteLine("🔄 R5 與 R4 可以在同一個解決方案中並存，但使用不同的套件");
    }
}
