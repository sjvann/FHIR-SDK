using Fhir.R4.Models.Base;
using Fhir.R4.Models.Resources;
using Fhir.R4.Models.DataTypes;

namespace Examples;

/// <summary>
/// BackboneElement 使用範例
/// 展示如何正確使用 FHIR 的 BackboneElement
/// </summary>
public class BackboneElementUsage
{
    /// <summary>
    /// Patient.Contact 使用範例
    /// </summary>
    public void PatientContactExample()
    {
        var patient = new Patient
        {
            Id = "patient-001",
            Active = true,
            Name = new List<HumanName>
            {
                new HumanName
                {
                    Use = "official",
                    Family = "Smith",
                    Given = new List<string> { "John" }
                }
            }
        };

        // 添加聯絡人 - 使用 BackboneElement
        var contact = new Patient.Contact
        {
            // BackboneElement 的基本屬性
            Id = "contact-001",  // 來自 Element
            
            // Patient.Contact 特定屬性
            Relationship = new List<CodeableConcept>
            {
                new CodeableConcept
                {
                    Coding = new List<Coding>
                    {
                        new Coding
                        {
                            System = "http://terminology.hl7.org/CodeSystem/v2-0131",
                            Code = "C",
                            Display = "Emergency Contact"
                        }
                    }
                }
            },
            Name = new HumanName
            {
                Use = "usual",
                Family = "Smith",
                Given = new List<string> { "Jane" }
            },
            Telecom = new List<ContactPoint>
            {
                new ContactPoint
                {
                    System = "phone",
                    Value = "+1-555-123-4567",
                    Use = "mobile"
                }
            },
            Gender = "female"
        };

        // 添加 Extension（來自 Element）
        contact.Extension = new List<Extension>
        {
            new Extension
            {
                Url = "http://example.org/fhir/StructureDefinition/contact-priority",
                Value = "high"
            }
        };

        // 添加 ModifierExtension（BackboneElement 特有）
        contact.AddModifierExtension(
            "http://example.org/fhir/StructureDefinition/contact-verification-status",
            "verified"
        );

        patient.Contact = new List<Patient.Contact> { contact };

        Console.WriteLine($"Patient {patient.Name?.FirstOrDefault()?.Family} has {patient.Contact?.Count} contacts");
        Console.WriteLine($"Emergency contact: {contact.Name?.Family}");
        Console.WriteLine($"Has modifier extensions: {contact.HasModifierExtensions}");
    }

    /// <summary>
    /// Bundle.Entry 使用範例
    /// </summary>
    public void BundleEntryExample()
    {
        var bundle = new Bundle
        {
            Id = "bundle-001",
            Type = "collection"
        };

        // 建立 Bundle Entry - 使用 BackboneElement
        var entry1 = new Bundle.Entry
        {
            Id = "entry-001",  // 來自 Element
            FullUrl = "http://example.org/fhir/Patient/patient-001",
            Resource = new Patient  // 使用 ResourceWrapper（隱式轉換）
            {
                Id = "patient-001",
                Active = true,
                Gender = "male"
            }
        };

        var entry2 = new Bundle.Entry
        {
            Id = "entry-002",
            FullUrl = "http://example.org/fhir/Observation/obs-001",
            Resource = new Observation
            {
                Id = "obs-001",
                Status = "final",
                Code = new CodeableConcept
                {
                    Text = "Blood Pressure"
                }
            }
        };

        // 添加 ModifierExtension 到 Bundle.Entry
        entry1.AddModifierExtension(
            "http://example.org/fhir/StructureDefinition/entry-processing-mode",
            "strict"
        );

        bundle.Entry = new List<Bundle.Entry> { entry1, entry2 };

        Console.WriteLine($"Bundle contains {bundle.Entry?.Count} entries");
        
        foreach (var entry in bundle.Entry)
        {
            Console.WriteLine($"Entry {entry.Id}: {entry.Resource?.ResourceType}");
            
            // 型別安全的 Resource 存取
            if (entry.Resource?.Is<Patient>() == true)
            {
                var patient = entry.Resource.As<Patient>();
                Console.WriteLine($"  Patient gender: {patient?.Gender}");
            }
            else if (entry.Resource?.Is<Observation>() == true)
            {
                var observation = entry.Resource.As<Observation>();
                Console.WriteLine($"  Observation status: {observation?.Status}");
            }
        }
    }

    /// <summary>
    /// Observation.Component 使用範例
    /// </summary>
    public void ObservationComponentExample()
    {
        var observation = new Observation
        {
            Id = "obs-vitals",
            Status = "final",
            Code = new CodeableConcept
            {
                Text = "Vital Signs Panel"
            }
        };

        // 血壓組成部分
        var systolicComponent = new Observation.Component
        {
            Id = "component-systolic",  // 來自 Element
            Code = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = "http://loinc.org",
                        Code = "8480-6",
                        Display = "Systolic blood pressure"
                    }
                }
            },
            ValueQuantity = new QuantityImpl(120, "mmHg")
        };

        var diastolicComponent = new Observation.Component
        {
            Id = "component-diastolic",
            Code = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = "http://loinc.org",
                        Code = "8462-4",
                        Display = "Diastolic blood pressure"
                    }
                }
            },
            ValueQuantity = new QuantityImpl(80, "mmHg")
        };

        // 添加 Extension 到 Component
        systolicComponent.Extension = new List<Extension>
        {
            new Extension
            {
                Url = "http://example.org/fhir/StructureDefinition/measurement-method",
                Value = "automatic"
            }
        };

        // 添加 ModifierExtension
        systolicComponent.AddModifierExtension(
            "http://example.org/fhir/StructureDefinition/measurement-reliability",
            "questionable"
        );

        observation.Component = new List<Observation.Component> 
        { 
            systolicComponent, 
            diastolicComponent 
        };

        Console.WriteLine($"Observation has {observation.Component?.Count} components");
        
        foreach (var component in observation.Component)
        {
            var code = component.Code?.Coding?.FirstOrDefault()?.Display ?? "Unknown";
            var value = component.ValueQuantity;
            Console.WriteLine($"  {code}: {value?.Value} {value?.Unit}");
            
            if (component.HasModifierExtensions)
            {
                Console.WriteLine($"    Has modifier extensions (may affect interpretation)");
            }
        }
    }

    /// <summary>
    /// BackboneElement 驗證範例
    /// </summary>
    public void ValidationExample()
    {
        // 建立一個無效的 Patient.Contact
        var invalidContact = new Patient.Contact
        {
            // 沒有設定任何必要屬性（name, telecom, address, organization）
            Gender = "female"
        };

        // 驗證
        var validationContext = new ValidationContext(invalidContact);
        var validationResults = invalidContact.Validate(validationContext).ToList();

        Console.WriteLine($"Validation results: {validationResults.Count} errors");
        foreach (var result in validationResults)
        {
            Console.WriteLine($"  Error: {result.ErrorMessage}");
        }

        // 建立一個有效的 Contact
        var validContact = new Patient.Contact
        {
            Name = new HumanName
            {
                Family = "Doe",
                Given = new List<string> { "Jane" }
            }
        };

        var validResults = validContact.Validate(new ValidationContext(validContact)).ToList();
        Console.WriteLine($"Valid contact validation results: {validResults.Count} errors");
    }

    /// <summary>
    /// ModifierExtension 處理範例
    /// </summary>
    public void ModifierExtensionExample()
    {
        var contact = new Patient.Contact
        {
            Name = new HumanName { Family = "Smith" }
        };

        // 添加 modifier extension
        contact.AddModifierExtension(
            "http://example.org/fhir/StructureDefinition/contact-deceased",
            true
        );

        // 檢查是否有 modifier extensions
        if (contact.HasModifierExtensions)
        {
            Console.WriteLine("Warning: This contact has modifier extensions that may change its meaning");
            
            // 取得特定的 modifier extension
            var deceasedExt = contact.GetModifierExtension(
                "http://example.org/fhir/StructureDefinition/contact-deceased"
            );
            
            if (deceasedExt?.Value is bool isDeceased && isDeceased)
            {
                Console.WriteLine("This contact is marked as deceased");
            }
        }

        // 移除 modifier extension
        var removed = contact.RemoveModifierExtension(
            "http://example.org/fhir/StructureDefinition/contact-deceased"
        );
        
        Console.WriteLine($"Modifier extension removed: {removed}");
        Console.WriteLine($"Still has modifier extensions: {contact.HasModifierExtensions}");
    }
}
