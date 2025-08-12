using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using FhirCore.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace StrongReferenceDemo
{
    // 示例資源類型
    public class Patient : IPatientResource
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";

        public string GetResourceTypeName(bool withCapital = true) => withCapital ? "Patient" : "patient";
        public JsonObject? GetJsonResource() => new JsonObject
        {
            ["resourceType"] = "Patient",
            ["id"] = Id,
            ["name"] = Name,
            ["email"] = Email
        };

        public override string ToString() => $"Patient: {Name} (ID: {Id})";
    }

    public class Practitioner : IPractitionerResource
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public string Specialty { get; set; } = "";

        public string GetResourceTypeName(bool withCapital = true) => withCapital ? "Practitioner" : "practitioner";
        public JsonObject? GetJsonResource() => new JsonObject
        {
            ["resourceType"] = "Practitioner",
            ["id"] = Id,
            ["name"] = Name,
            ["specialty"] = Specialty
        };

        public override string ToString() => $"Dr. {Name} ({Specialty}) (ID: {Id})";
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("FHIR SDK 強類型 Reference 示範");
            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine();

            DemonstrateBasicReferences();
            Console.WriteLine();

            await DemonstrateReferenceResolution();
            Console.WriteLine();

            await DemonstrateReferenceValidation();
            Console.WriteLine();

            DemonstrateMultiTypeReferences();
            Console.WriteLine();

            Console.WriteLine("示範完成！按任意鍵退出...");
            Console.ReadKey();
        }

        static void DemonstrateBasicReferences()
        {
            Console.WriteLine("--- 基本 Reference 創建示範 ---");

            // 創建 Patient 引用
            var patientRef = Reference<Patient>.ToResource("patient-123", "John Doe");
            Console.WriteLine($"Patient Reference: {patientRef}");
            Console.WriteLine($"Reference Value: {patientRef.ReferenceValue?.Value}");
            Console.WriteLine($"Resource Type: {patientRef.ResourceTypeName}");
            Console.WriteLine($"Is Relative: {patientRef.IsRelativeReference}");

            // 創建絕對 URL 引用
            var absoluteRef = Reference<Patient>.ToAbsoluteUrl(
                "https://fhir.server.com/Patient/remote-456",
                "Remote Patient");
            Console.WriteLine($"Absolute Reference: {absoluteRef}");
            Console.WriteLine($"Is Absolute: {absoluteRef.IsAbsoluteReference}");

            // 創建邏輯引用
            var logicalRef = Reference<Patient>.ToIdentifier(
                "http://hospital.org/patients",
                "MRN-789",
                "Patient by MRN");
            Console.WriteLine($"Logical Reference: {logicalRef}");
            Console.WriteLine($"Identifier System: {logicalRef.Identifier?.System?.Value}");
            Console.WriteLine($"Identifier Value: {logicalRef.Identifier?.Value?.Value}");
        }

        static async Task DemonstrateReferenceResolution()
        {
            Console.WriteLine("--- Reference 解析示範 ---");

            // 設置資源解析器
            var resolver = new InMemoryResourceResolver();
            
            // 添加一些測試資源
            var patient1 = new Patient { Id = "patient-123", Name = "John Doe", Email = "john@example.com" };
            var patient2 = new Patient { Id = "patient-456", Name = "Jane Smith", Email = "jane@example.com" };
            var doctor = new Practitioner { Id = "practitioner-789", Name = "Smith", Specialty = "Cardiology" };

            resolver.AddResource<Patient>("patient-123", patient1);
            resolver.AddResource<Patient>("patient-456", patient2);
            resolver.AddResource<Practitioner>("practitioner-789", doctor);

            // 創建引用並解析
            var patientRef = Reference<Patient>.ToResource("patient-123", "John Doe");
            var resolvedPatient = await patientRef.ResolveAsync(resolver);
            
            if (resolvedPatient != null)
            {
                Console.WriteLine($"✓ 成功解析: {resolvedPatient}");
            }
            else
            {
                Console.WriteLine("✗ 解析失敗");
            }

            // 檢查引用存在性
            var exists = await patientRef.ExistsAsync(resolver);
            Console.WriteLine($"Reference 存在: {exists}");

            // 嘗試解析不存在的引用
            var nonExistentRef = Reference<Patient>.ToResource("patient-999", "Non-existent");
            var nonExistentPatient = await nonExistentRef.ResolveAsync(resolver);
            Console.WriteLine($"不存在的引用解析結果: {nonExistentPatient?.ToString() ?? "null"}");
        }

        static async Task DemonstrateReferenceValidation()
        {
            Console.WriteLine("--- Reference 驗證示範 ---");

            var resolver = new InMemoryResourceResolver();
            var patient = new Patient { Id = "patient-123", Name = "John Doe", Email = "john@example.com" };
            resolver.AddResource<Patient>("patient-123", patient);

            // 驗證存在的引用
            var validRef = Reference<Patient>.ToResource("patient-123", "John Doe");
            var validationResult = await validRef.ValidateAsync(resolver);
            Console.WriteLine($"有效引用驗證: {(validationResult.IsValid ? "✓ 通過" : "✗ 失敗")}");
            if (!validationResult.IsValid)
            {
                Console.WriteLine($"錯誤: {validationResult.ErrorMessage}");
            }

            // 驗證不存在的引用
            var invalidRef = Reference<Patient>.ToResource("patient-999", "Non-existent");
            var invalidResult = await invalidRef.ValidateAsync(resolver);
            Console.WriteLine($"無效引用驗證: {(invalidResult.IsValid ? "✓ 通過" : "✗ 失敗")}");
            if (!invalidResult.IsValid)
            {
                Console.WriteLine($"錯誤: {invalidResult.ErrorMessage}");
            }

            // 驗證空引用
            var emptyRef = new Reference<Patient>();
            emptyRef.ReferenceValue = null;
            emptyRef.Identifier = null;
            emptyRef.Type = null;
            var emptyResult = await emptyRef.ValidateAsync(resolver);
            Console.WriteLine($"空引用驗證: {(emptyResult.IsValid ? "✓ 通過" : "✗ 失敗")}");
            if (!emptyResult.IsValid)
            {
                Console.WriteLine($"錯誤: {emptyResult.ErrorMessage}");
            }
        }

        static void DemonstrateMultiTypeReferences()
        {
            Console.WriteLine("--- 多類型 Reference 示範 ---");

            // 創建不同類型的 Subject 引用
            var patientSubject = SubjectReference.ToPatient("patient-123", "John Doe");
            var practitionerSubject = SubjectReference.ToPractitioner("practitioner-456", "Dr. Smith");

            Console.WriteLine($"Patient Subject: {patientSubject}");
            Console.WriteLine($"Is Patient: {patientSubject.IsPatient}");
            Console.WriteLine($"Is Practitioner: {patientSubject.IsPractitioner}");

            Console.WriteLine($"Practitioner Subject: {practitionerSubject}");
            Console.WriteLine($"Is Patient: {practitionerSubject.IsPatient}");
            Console.WriteLine($"Is Practitioner: {practitionerSubject.IsPractitioner}");

            // 使用模式匹配
            var subjects = new[] { patientSubject, practitionerSubject };

            foreach (var subject in subjects)
            {
                var description = subject.Match(
                    patient => $"這是一個 Patient 引用: {patient.ReferenceValue?.Value}",
                    practitioner => $"這是一個 Practitioner 引用: {practitioner.ReferenceValue?.Value}",
                    organization => $"這是一個 Organization 引用: {organization.ReferenceValue?.Value}"
                );
                Console.WriteLine(description);
            }

            // 轉換為通用 ReferenceType
            var genericRef = patientSubject.ToReferenceType();
            Console.WriteLine($"轉換為通用 Reference: {genericRef.Reference?.Value}");
        }
    }
}
