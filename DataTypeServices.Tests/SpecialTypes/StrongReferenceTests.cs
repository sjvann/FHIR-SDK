using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using Ext = DataTypeServices.DataTypes.SpecialTypes;
using System.Text.Json.Nodes;
using Xunit;

namespace DataTypeServices.Tests.SpecialTypes
{
    // 測試用的假 Resource 類型
    // 最小 IResource 實作，僅供測試用，避免引入真實資源依賴
    public class TestPatient : IResource
    {
        public string? Id { get; set; } = "";
        public string ResourceType => "TestPatient";
        public FhirCore.Interfaces.Meta? Meta { get; set; }
        public string? ImplicitRules { get; set; }
        public string? Language { get; set; }
        public System.Collections.ObjectModel.ObservableCollection<FhirCore.Interfaces.Extension> Extension { get; } = new();
        public System.Collections.ObjectModel.ObservableCollection<FhirCore.Interfaces.Extension> ModifierExtension { get; } = new();
        public System.ComponentModel.DataAnnotations.ValidationResult Validate() => System.ComponentModel.DataAnnotations.ValidationResult.Success!;
        public string GetFhirVersion() => "5.0.0";

        // 測試輔助欄位
        public string Name { get; set; } = "";
    }

    public class TestPractitioner : IResource
    {
        public string? Id { get; set; } = "";
        public string ResourceType => "TestPractitioner";
        public FhirCore.Interfaces.Meta? Meta { get; set; }
        public string? ImplicitRules { get; set; }
        public string? Language { get; set; }
        public System.Collections.ObjectModel.ObservableCollection<FhirCore.Interfaces.Extension> Extension { get; } = new();
        public System.Collections.ObjectModel.ObservableCollection<FhirCore.Interfaces.Extension> ModifierExtension { get; } = new();
        public System.ComponentModel.DataAnnotations.ValidationResult Validate() => System.ComponentModel.DataAnnotations.ValidationResult.Success!;
        public string GetFhirVersion() => "5.0.0";

        public string Name { get; set; } = "";
    }

    public class StrongReferenceTests
    {
        [Fact]
        public void Reference_DefaultConstructor_SetsCorrectResourceType()
        {
            // Arrange & Act
            var reference = new Reference<TestPatient>();

            // Assert
            Assert.Equal("TestPatient", reference.ResourceTypeName);
            Assert.NotNull(reference.Type);
            Assert.Equal("TestPatient", reference.Type.Value);
        }

        [Fact]
        public void Reference_FromString_CreatesCorrectReference()
        {
            // Arrange
            var referenceString = "Patient/123";
            var displayText = "John Doe";

            // Act
            var reference = new Reference<TestPatient>(referenceString, displayText);

            // Assert
            Assert.Equal(referenceString, reference.ReferenceValue?.Value);
            Assert.Equal(displayText, reference.Display?.Value);
            Assert.Equal("TestPatient", reference.Type?.Value);
        }

        [Fact]
        public void Reference_FromResourceId_CreatesRelativeReference()
        {
            // Arrange
            var resourceId = new FhirId("patient-123");
            var displayText = "Jane Smith";

            // Act
            var reference = new Reference<TestPatient>(resourceId, displayText);

            // Assert
            Assert.Equal("TestPatient/patient-123", reference.ReferenceValue?.Value);
            Assert.Equal(displayText, reference.Display?.Value);
            Assert.True(reference.IsRelativeReference);
            Assert.False(reference.IsAbsoluteReference);
        }

        [Fact]
        public void Reference_FromIdentifier_CreatesLogicalReference()
        {
            // Arrange
            var identifier = new Identifier
            {
                System = new FhirUri("http://hospital.org/patients"),
                Value = new FhirString("12345")
            };
            var displayText = "Bob Johnson";

            // Act
            var reference = new Reference<TestPatient>(identifier, displayText);

            // Assert
            Assert.Equal(identifier, reference.Identifier);
            Assert.Equal(displayText, reference.Display?.Value);
            Assert.Null(reference.ReferenceValue);
        }

        [Fact]
        public void Reference_ToResource_CreatesCorrectReference()
        {
            // Arrange
            var resourceId = "patient-456";
            var displayText = "Alice Brown";

            // Act
            var reference = Reference<TestPatient>.ToResource(resourceId, displayText);

            // Assert
            Assert.Equal($"TestPatient/{resourceId}", reference.ReferenceValue?.Value);
            Assert.Equal(displayText, reference.Display?.Value);
        }

        [Fact]
        public void Reference_ToAbsoluteUrl_CreatesAbsoluteReference()
        {
            // Arrange
            var absoluteUrl = "https://fhir.server.com/Patient/123";
            var displayText = "Remote Patient";

            // Act
            var reference = Reference<TestPatient>.ToAbsoluteUrl(absoluteUrl, displayText);

            // Assert
            Assert.Equal(absoluteUrl, reference.ReferenceValue?.Value);
            Assert.Equal(displayText, reference.Display?.Value);
            Assert.True(reference.IsAbsoluteReference);
            Assert.False(reference.IsRelativeReference);
        }

        [Fact]
        public void Reference_ToIdentifier_CreatesLogicalReference()
        {
            // Arrange
            var system = "http://hospital.org/patients";
            var value = "67890";
            var displayText = "Charlie Wilson";

            // Act
            var reference = Reference<TestPatient>.ToIdentifier(system, value, displayText);

            // Assert
            Assert.Equal(system, reference.Identifier?.System?.Value);
            Assert.Equal(value, reference.Identifier?.Value?.Value);
            Assert.Equal(displayText, reference.Display?.Value);
        }

        [Fact]
        public void Reference_ExtractResourceId_ReturnsCorrectId()
        {
            // Arrange
            var reference = Reference<TestPatient>.ToResource("patient-789");

            // Act
            var extractedId = reference.ExtractResourceId();

            // Assert
            Assert.Equal("patient-789", extractedId);
        }

        [Fact]
        public void Reference_ExtractResourceId_FromAbsoluteUrl_ReturnsCorrectId()
        {
            // Arrange
            var reference = Reference<TestPatient>.ToAbsoluteUrl("https://fhir.server.com/Patient/abc123");

            // Act
            var extractedId = reference.ExtractResourceId();

            // Assert
            Assert.Equal("abc123", extractedId);
        }

        [Fact]
        public void Reference_ValidateResourceType_WithCorrectType_ReturnsSuccess()
        {
            // Arrange
            var reference = new Reference<TestPatient>();
            reference.Type = new FhirUri("TestPatient");

            // Act
            var result = reference.ValidateResourceType();

            // Assert
            Assert.True(result.IsValid);
        }

        [Fact]
        public void Reference_ValidateResourceType_WithIncorrectType_ReturnsError()
        {
            // Arrange
            var reference = new Reference<TestPatient>();
            reference.Type = new FhirUri("Practitioner");

            // Act
            var result = reference.ValidateResourceType();

            // Assert
            Assert.False(result.IsValid);
            Assert.Contains("type mismatch", result.ErrorMessage);
        }

        [Fact]
        public void Reference_IsEmpty_WithNoValues_ReturnsTrue()
        {
            // Arrange
            var reference = new Reference<TestPatient>();
            reference.ReferenceValue = null;
            reference.Identifier = null;
            reference.Type = null;

            // Act & Assert
            Assert.True(reference.IsEmpty);
        }

        [Fact]
        public void Reference_IsEmpty_WithReference_ReturnsFalse()
        {
            // Arrange
            var reference = Reference<TestPatient>.ToResource("123");

            // Act & Assert
            Assert.False(reference.IsEmpty);
        }

        [Fact]
        public void Reference_ToReferenceType_ConvertsCorrectly()
        {
            // Arrange
            var reference = Reference<TestPatient>.ToResource("patient-123", "Test Patient");

            // Act
            var referenceType = reference.ToReferenceType();

            // Assert
            Assert.Equal(reference.ReferenceValue?.Value, referenceType.Reference?.Value);
            Assert.Equal(reference.Type?.Value, referenceType.Type?.Value);
            Assert.Equal(reference.Display?.Value, referenceType.Display?.Value);
        }

        [Fact]
        public void Reference_FromReferenceType_ConvertsCorrectly()
        {
            // Arrange
            var referenceType = new ReferenceType
            {
                Reference = new FhirString("Patient/456"),
                Type = new FhirUri("Patient"),
                Display = new FhirString("Test Patient")
            };

            // Act
            var strongReference = Reference<TestPatient>.FromReferenceType(referenceType);

            // Assert
            Assert.Equal(referenceType.Reference?.Value, strongReference.ReferenceValue?.Value);
            Assert.Equal(referenceType.Type?.Value, strongReference.Type?.Value);
            Assert.Equal(referenceType.Display?.Value, strongReference.Display?.Value);
        }

        [Fact]
        public void Reference_ToString_WithDisplay_ReturnsDisplay()
        {
            // Arrange
            var reference = Reference<TestPatient>.ToResource("123", "John Doe");

            // Act
            var result = reference.ToString();

            // Assert
            Assert.Equal("John Doe", result);
        }

        [Fact]
        public void Reference_ToString_WithoutDisplay_ReturnsReference()
        {
            // Arrange
            var reference = Reference<TestPatient>.ToResource("123");

            // Act
            var result = reference.ToString();

            // Assert
            Assert.Equal("TestPatient/123", result);
        }

        [Fact]
        public async Task Reference_ResolveAsync_WithValidReference_ReturnsResource()
        {
            // Arrange
            var resolver = new InMemoryResourceResolver();
            var patient = new TestPatient { Id = "123", Name = "John Doe" };
            resolver.AddResource<TestPatient>("123", patient);

            var reference = Reference<TestPatient>.ToResource("123");

            // Act
            var resolved = await reference.ResolveAsync(resolver);

            // Assert
            Assert.NotNull(resolved);
            Assert.Equal(patient.Id, resolved.Id);
        }

        [Fact]
        public async Task Reference_ExistsAsync_WithExistingReference_ReturnsTrue()
        {
            // Arrange
            var resolver = new InMemoryResourceResolver();
            var patient = new TestPatient { Id = "123", Name = "John Doe" };
            resolver.AddResource<TestPatient>("123", patient);

            var reference = Reference<TestPatient>.ToResource("123");

            // Act
            var exists = await reference.ExistsAsync(resolver);

            // Assert
            Assert.True(exists);
        }

        [Fact]
        public async Task Reference_ExistsAsync_WithNonExistingReference_ReturnsFalse()
        {
            // Arrange
            var resolver = new InMemoryResourceResolver();
            var reference = Reference<TestPatient>.ToResource("nonexistent");

            // Act
            var exists = await reference.ExistsAsync(resolver);

            // Assert
            Assert.False(exists);
        }

        [Fact]
        public async Task Reference_ValidateAsync_WithExistingReference_ReturnsSuccess()
        {
            // Arrange
            var resolver = new InMemoryResourceResolver();
            var patient = new TestPatient { Id = "123", Name = "John Doe" };
            resolver.AddResource<TestPatient>("123", patient);

            var reference = Reference<TestPatient>.ToResource("123");

            // Act
            var result = await reference.ValidateAsync(resolver);

            // Assert
            Assert.True(result.IsValid);
        }

        [Fact]
        public async Task Reference_ValidateAsync_WithNonExistingReference_ReturnsError()
        {
            // Arrange
            var resolver = new InMemoryResourceResolver();
            var reference = Reference<TestPatient>.ToResource("nonexistent");

            // Act
            var result = await reference.ValidateAsync(resolver);

            // Assert
            Assert.False(result.IsValid);
            Assert.Contains("does not exist", result.ErrorMessage);
        }
    }

    public class TypedReferencesTests
    {
        [Fact]
        public void PatientReference_ToPatient_CreatesCorrectReference()
        {
            // Arrange
            var patientId = "patient-123";
            var displayName = "John Doe";

            // Act
            var reference = PatientReference.ToPatient(patientId, displayName);

            // Assert
            Assert.Equal($"Patient/{patientId}", reference.ReferenceValue?.Value);
            Assert.Equal(displayName, reference.Display?.Value);
        }

        [Fact]
        public void PractitionerReference_ToPractitioner_CreatesCorrectReference()
        {
            // Arrange
            var practitionerId = "practitioner-456";
            var displayName = "Dr. Smith";

            // Act
            var reference = PractitionerReference.ToPractitioner(practitionerId, displayName);

            // Assert
            Assert.Equal($"Practitioner/{practitionerId}", reference.ReferenceValue?.Value);
            Assert.Equal(displayName, reference.Display?.Value);
        }

        [Fact]
        public void SubjectReference_ToPatient_CreatesPatientReference()
        {
            // Arrange
            var patientId = "patient-789";
            var displayName = "Jane Doe";

            // Act
            var subjectRef = SubjectReference.ToPatient(patientId, displayName);

            // Assert
            Assert.True(subjectRef.IsPatient);
            Assert.False(subjectRef.IsPractitioner);
            Assert.False(subjectRef.IsOrganization);
            Assert.NotNull(subjectRef.AsPatient);
            Assert.Equal($"Patient/{patientId}", subjectRef.AsPatient?.ReferenceValue?.Value);
        }

        [Fact]
        public void SubjectReference_ToPractitioner_CreatesPractitionerReference()
        {
            // Arrange
            var practitionerId = "practitioner-101";
            var displayName = "Dr. Johnson";

            // Act
            var subjectRef = SubjectReference.ToPractitioner(practitionerId, displayName);

            // Assert
            Assert.False(subjectRef.IsPatient);
            Assert.True(subjectRef.IsPractitioner);
            Assert.False(subjectRef.IsOrganization);
            Assert.NotNull(subjectRef.AsPractitioner);
            Assert.Equal($"Practitioner/{practitionerId}", subjectRef.AsPractitioner?.ReferenceValue?.Value);
        }

        [Fact]
        public void SubjectReference_Match_HandlesAllTypes()
        {
            // Arrange
            var patientRef = SubjectReference.ToPatient("123", "Patient");
            var practitionerRef = SubjectReference.ToPractitioner("456", "Doctor");
            var organizationRef = SubjectReference.ToOrganization("789", "Hospital");

            // Act
            var patientResult = patientRef.Match(
                patient => "Patient",
                practitioner => "Practitioner",
                organization => "Organization"
            );

            var practitionerResult = practitionerRef.Match(
                patient => "Patient",
                practitioner => "Practitioner",
                organization => "Organization"
            );

            var organizationResult = organizationRef.Match(
                patient => "Patient",
                practitioner => "Practitioner",
                organization => "Organization"
            );

            // Assert
            Assert.Equal("Patient", patientResult);
            Assert.Equal("Practitioner", practitionerResult);
            Assert.Equal("Organization", organizationResult);
        }

        [Fact]
        public void SubjectReference_ToReferenceType_ConvertsCorrectly()
        {
            // Arrange
            var subjectRef = SubjectReference.ToPatient("patient-123", "Test Patient");

            // Act
            var referenceType = subjectRef.ToReferenceType();

            // Assert
            Assert.Equal("Patient/patient-123", referenceType.Reference?.Value);
            Assert.Equal("Test Patient", referenceType.Display?.Value);
        }
    }
}
