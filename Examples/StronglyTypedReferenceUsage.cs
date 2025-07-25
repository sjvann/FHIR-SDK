using Fhir.R4.Models.Base;
using Fhir.R4.Models.Resources;
using Fhir.R4.Models.DataTypes;

namespace Examples;

/// <summary>
/// 強型別 Reference 使用範例
/// 展示如何使用 FHIR 的強型別 Reference 系統
/// </summary>
public class StronglyTypedReferenceUsage
{
    /// <summary>
    /// 基本 Reference 使用範例
    /// </summary>
    public void BasicReferenceExample()
    {
        // 建立 Patient
        var patient = new Patient
        {
            Id = "patient-001",
            Active = true,
            Gender = "male",
            Name = new List<HumanName>
            {
                new HumanName
                {
                    Family = "Smith",
                    Given = new List<string> { "John" }
                }
            }
        };

        // 建立 Observation - subject 只能參照 Patient, Group, Device, Location
        var observation = new Observation
        {
            Id = "obs-001",
            Status = "final",
            Code = new CodeableConcept
            {
                Text = "Blood Pressure"
            }
        };

        // 方式 1：直接設定 Resource
        observation.Subject = Reference<Patient, Group, Device, Location>.To(patient);

        // 方式 2：使用 ID 建立參照
        observation.Subject = Reference<Patient, Group, Device, Location>.To("patient-001", "John Smith");

        // 方式 3：手動建立
        observation.Subject = new Reference<Patient, Group, Device, Location>
        {
            ReferenceValue = "Patient/patient-001",
            Type = "Patient",
            Display = "John Smith"
        };

        Console.WriteLine($"Observation subject: {observation.Subject?.ReferenceValue}");
        Console.WriteLine($"Subject type: {observation.Subject?.ResourceType}");
        Console.WriteLine($"Allowed types: {string.Join(", ", observation.Subject?.GetAllowedTargetTypes() ?? Array.Empty<string>())}");
    }

    /// <summary>
    /// 型別安全解析範例
    /// </summary>
    public void TypeSafeResolutionExample()
    {
        var observation = new Observation();
        
        // 設定 subject 為 Patient
        var patient = new Patient { Id = "patient-001", Gender = "female" };
        observation.Subject = Reference<Patient, Group, Device, Location>.To(patient);

        // 型別安全的解析
        if (observation.Subject != null)
        {
            // 檢查是否為 Patient
            var resolvedPatient = observation.Subject.ResolveAsT1(); // T1 = Patient
            if (resolvedPatient != null)
            {
                Console.WriteLine($"Patient gender: {resolvedPatient.Gender}");
            }

            // 檢查是否為 Group
            var resolvedGroup = observation.Subject.ResolveAsT2(); // T2 = Group
            if (resolvedGroup != null)
            {
                Console.WriteLine("This is a Group reference");
            }

            // 通用檢查
            if (observation.Subject.IsValidTarget(patient))
            {
                Console.WriteLine("Patient is a valid target for this reference");
            }
        }
    }

    /// <summary>
    /// 單一型別 Reference 範例
    /// </summary>
    public void SingleTypeReferenceExample()
    {
        // Encounter.subject 只能參照 Patient
        var encounter = new Encounter
        {
            Id = "encounter-001",
            Status = "finished",
            Class = new Coding
            {
                System = "http://terminology.hl7.org/CodeSystem/v3-ActCode",
                Code = "AMB",
                Display = "ambulatory"
            }
        };

        var patient = new Patient { Id = "patient-001" };

        // 型別安全：只能設定 Patient
        encounter.Subject = Reference<Patient>.To(patient);
        // encounter.Subject = Reference<Patient>.To(group); // ❌ 編譯錯誤

        // 型別安全的解析
        var resolvedPatient = encounter.Subject?.ResolveAs(); // 直接返回 Patient?
        Console.WriteLine($"Encounter patient: {resolvedPatient?.Id}");
    }

    /// <summary>
    /// 多型別 Reference 範例
    /// </summary>
    public void MultiTypeReferenceExample()
    {
        // Encounter.participant.individual 可以參照 Practitioner 或 PractitionerRole
        var participant = new Encounter.Participant
        {
            Type = new List<CodeableConcept>
            {
                new CodeableConcept { Text = "Primary Performer" }
            }
        };

        var practitioner = new Practitioner
        {
            Id = "practitioner-001",
            Active = true,
            Name = new List<HumanName>
            {
                new HumanName
                {
                    Family = "Johnson",
                    Given = new List<string> { "Dr. Sarah" }
                }
            }
        };

        // 設定參照
        participant.Individual = Reference<Practitioner, PractitionerRole>.To(practitioner);

        // 型別安全的解析
        if (participant.Individual != null)
        {
            var resolvedPractitioner = participant.Individual.ResolveAsT1(); // Practitioner?
            var resolvedRole = participant.Individual.ResolveAsT2(); // PractitionerRole?

            if (resolvedPractitioner != null)
            {
                Console.WriteLine($"Practitioner: {resolvedPractitioner.Name?.FirstOrDefault()?.Family}");
            }
            else if (resolvedRole != null)
            {
                Console.WriteLine("This is a PractitionerRole reference");
            }
        }
    }

    /// <summary>
    /// Reference 驗證範例
    /// </summary>
    public void ReferenceValidationExample()
    {
        var observation = new Observation();

        // 建立一個無效的 Reference（空的）
        var invalidReference = new Reference<Patient, Group, Device, Location>();

        // 驗證
        var validationContext = new ValidationContext(invalidReference);
        var validationResults = invalidReference.Validate(validationContext).ToList();

        Console.WriteLine($"Invalid reference validation errors: {validationResults.Count}");
        foreach (var result in validationResults)
        {
            Console.WriteLine($"  Error: {result.ErrorMessage}");
        }

        // 建立一個有效的 Reference
        var validReference = Reference<Patient, Group, Device, Location>.To("patient-001", "John Doe");
        var validResults = validReference.Validate(new ValidationContext(validReference)).ToList();

        Console.WriteLine($"Valid reference validation errors: {validResults.Count}");

        // 測試型別限制驗證
        var organization = new Organization { Id = "org-001" };
        
        // 這會在驗證時失敗，因為 Organization 不在允許的型別中
        var wrongTypeReference = new Reference<Patient, Group, Device, Location>
        {
            ReferenceValue = "Organization/org-001",
            Type = "Organization"
        };

        var wrongTypeResults = wrongTypeReference.Validate(new ValidationContext(wrongTypeReference)).ToList();
        Console.WriteLine($"Wrong type reference validation errors: {wrongTypeResults.Count}");
        foreach (var result in wrongTypeResults)
        {
            Console.WriteLine($"  Error: {result.ErrorMessage}");
        }
    }

    /// <summary>
    /// Reference 格式處理範例
    /// </summary>
    public void ReferenceFormatExample()
    {
        // 相對參照
        var relativeRef = new Reference<Patient>
        {
            ReferenceValue = "Patient/patient-001"
        };

        // 絕對參照
        var absoluteRef = new Reference<Patient>
        {
            ReferenceValue = "https://example.org/fhir/Patient/patient-001"
        };

        // 邏輯參照（只有 identifier）
        var logicalRef = new Reference<Patient>
        {
            Identifier = new Identifier
            {
                System = "http://example.org/patient-ids",
                Value = "12345"
            }
        };

        Console.WriteLine($"Relative reference: {relativeRef.ReferenceValue}");
        Console.WriteLine($"  Resource ID: {relativeRef.ResourceId}");
        Console.WriteLine($"  Resource Type: {relativeRef.ResourceType}");
        Console.WriteLine($"  Is relative: {relativeRef.IsRelativeReference}");

        Console.WriteLine($"Absolute reference: {absoluteRef.ReferenceValue}");
        Console.WriteLine($"  Is absolute: {absoluteRef.IsAbsoluteReference}");

        Console.WriteLine($"Logical reference has identifier: {logicalRef.Identifier?.Value}");
        Console.WriteLine($"  Is logical: {logicalRef.IsLogicalReference}");
    }

    /// <summary>
    /// Reference 建立輔助方法範例
    /// </summary>
    public void ReferenceCreationHelpersExample()
    {
        // 使用靜態方法建立參照字串
        var referenceString = Reference.CreateReference("Patient", "patient-001");
        Console.WriteLine($"Created reference: {referenceString}");

        var absoluteReferenceString = Reference.CreateAbsoluteReference(
            "https://example.org/fhir", "Patient", "patient-001");
        Console.WriteLine($"Created absolute reference: {absoluteReferenceString}");

        // 在實際 Resource 中使用
        var observation = new Observation
        {
            Subject = new Reference<Patient, Group, Device, Location>
            {
                ReferenceValue = referenceString,
                Type = "Patient",
                Display = "John Doe"
            }
        };

        Console.WriteLine($"Observation subject: {observation.Subject.ReferenceValue}");
    }

    /// <summary>
    /// 複雜場景：Bundle 中的 Reference 處理
    /// </summary>
    public void BundleReferenceExample()
    {
        var bundle = new Bundle
        {
            Id = "bundle-001",
            Type = "collection"
        };

        // 建立 Patient
        var patient = new Patient
        {
            Id = "patient-001",
            Active = true
        };

        // 建立 Observation，參照 Patient
        var observation = new Observation
        {
            Id = "obs-001",
            Status = "final",
            Subject = Reference<Patient, Group, Device, Location>.To(patient),
            Code = new CodeableConcept { Text = "Temperature" }
        };

        // 添加到 Bundle
        bundle.Entry = new List<Bundle.Entry>
        {
            new Bundle.Entry
            {
                FullUrl = "Patient/patient-001",
                Resource = patient
            },
            new Bundle.Entry
            {
                FullUrl = "Observation/obs-001",
                Resource = observation
            }
        };

        Console.WriteLine($"Bundle contains {bundle.Entry.Count} entries");

        // 解析 Bundle 中的 Reference
        foreach (var entry in bundle.Entry)
        {
            if (entry.Resource?.Is<Observation>() == true)
            {
                var obs = entry.Resource.As<Observation>();
                if (obs?.Subject != null)
                {
                    Console.WriteLine($"Observation {obs.Id} references {obs.Subject.ReferenceValue}");
                    Console.WriteLine($"Allowed target types: {string.Join(", ", obs.Subject.GetAllowedTargetTypes())}");
                }
            }
        }
    }
}
