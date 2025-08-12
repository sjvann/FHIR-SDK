using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.SpecialTypes
{
    // 為了示例，我們創建一些假設的 Resource 類型
    // 在實際使用中，這些會是 ResourceTypeServices.R5 中的真實類型

    /// <summary>
    /// Patient 資源的強類型引用
    /// </summary>
    public class PatientReference : Reference<IPatientResource>
    {
        public PatientReference() : base() { }
        public PatientReference(JsonObject value) : base(value) { }
        public PatientReference(string value) : base(value) { }
        public PatientReference(string referenceValue, string? displayText = null) : base(referenceValue, displayText) { }
        public PatientReference(FhirId resourceId, string? displayText = null) : base(resourceId, displayText) { }
        public PatientReference(Identifier identifier, string? displayText = null) : base(identifier, displayText) { }

        /// <summary>
        /// 創建對 Patient 的引用
        /// </summary>
        public static PatientReference ToPatient(string patientId, string? displayName = null)
        {
            return new PatientReference($"Patient/{patientId}", displayName);
        }
    }

    /// <summary>
    /// Practitioner 資源的強類型引用
    /// </summary>
    public class PractitionerReference : Reference<IPractitionerResource>
    {
        public PractitionerReference() : base() { }
        public PractitionerReference(JsonObject value) : base(value) { }
        public PractitionerReference(string value) : base(value) { }
        public PractitionerReference(string referenceValue, string? displayText = null) : base(referenceValue, displayText) { }
        public PractitionerReference(FhirId resourceId, string? displayText = null) : base(resourceId, displayText) { }
        public PractitionerReference(Identifier identifier, string? displayText = null) : base(identifier, displayText) { }

        /// <summary>
        /// 創建對 Practitioner 的引用
        /// </summary>
        public static PractitionerReference ToPractitioner(string practitionerId, string? displayName = null)
        {
            return new PractitionerReference($"Practitioner/{practitionerId}", displayName);
        }
    }

    /// <summary>
    /// Organization 資源的強類型引用
    /// </summary>
    public class OrganizationReference : Reference<IOrganizationResource>
    {
        public OrganizationReference() : base() { }
        public OrganizationReference(JsonObject value) : base(value) { }
        public OrganizationReference(string value) : base(value) { }
        public OrganizationReference(string referenceValue, string? displayText = null) : base(referenceValue, displayText) { }
        public OrganizationReference(FhirId resourceId, string? displayText = null) : base(resourceId, displayText) { }
        public OrganizationReference(Identifier identifier, string? displayText = null) : base(identifier, displayText) { }

        /// <summary>
        /// 創建對 Organization 的引用
        /// </summary>
        public static OrganizationReference ToOrganization(string organizationId, string? displayName = null)
        {
            return new OrganizationReference($"Organization/{organizationId}", displayName);
        }
    }

    /// <summary>
    /// 多類型引用，支援多種資源類型
    /// 這類似於 FHIR 中的 Reference(Patient | Practitioner | Organization)
    /// </summary>
    public class SubjectReference
    {
        private readonly object _reference;

        private SubjectReference(object reference)
        {
            _reference = reference;
        }

        /// <summary>
        /// 創建 Patient 引用
        /// </summary>
        public static SubjectReference ToPatient(string patientId, string? displayName = null)
        {
            return new SubjectReference(PatientReference.ToPatient(patientId, displayName));
        }

        /// <summary>
        /// 創建 Practitioner 引用
        /// </summary>
        public static SubjectReference ToPractitioner(string practitionerId, string? displayName = null)
        {
            return new SubjectReference(PractitionerReference.ToPractitioner(practitionerId, displayName));
        }

        /// <summary>
        /// 創建 Organization 引用
        /// </summary>
        public static SubjectReference ToOrganization(string organizationId, string? displayName = null)
        {
            return new SubjectReference(OrganizationReference.ToOrganization(organizationId, displayName));
        }

        /// <summary>
        /// 檢查是否為 Patient 引用
        /// </summary>
        public bool IsPatient => _reference is PatientReference;

        /// <summary>
        /// 檢查是否為 Practitioner 引用
        /// </summary>
        public bool IsPractitioner => _reference is PractitionerReference;

        /// <summary>
        /// 檢查是否為 Organization 引用
        /// </summary>
        public bool IsOrganization => _reference is OrganizationReference;

        /// <summary>
        /// 取得 Patient 引用
        /// </summary>
        public PatientReference? AsPatient => _reference as PatientReference;

        /// <summary>
        /// 取得 Practitioner 引用
        /// </summary>
        public PractitionerReference? AsPractitioner => _reference as PractitionerReference;

        /// <summary>
        /// 取得 Organization 引用
        /// </summary>
        public OrganizationReference? AsOrganization => _reference as OrganizationReference;

        /// <summary>
        /// 模式匹配方法
        /// </summary>
        public TResult Match<TResult>(
            Func<PatientReference, TResult> onPatient,
            Func<PractitionerReference, TResult> onPractitioner,
            Func<OrganizationReference, TResult> onOrganization)
        {
            return _reference switch
            {
                PatientReference patient => onPatient(patient),
                PractitionerReference practitioner => onPractitioner(practitioner),
                OrganizationReference organization => onOrganization(organization),
                _ => throw new InvalidOperationException($"Unexpected reference type: {_reference.GetType()}")
            };
        }

        /// <summary>
        /// 轉換為通用的 ReferenceType
        /// </summary>
        public ReferenceType ToReferenceType()
        {
            return _reference switch
            {
                PatientReference patient => patient.ToReferenceType(),
                PractitionerReference practitioner => practitioner.ToReferenceType(),
                OrganizationReference organization => organization.ToReferenceType(),
                _ => throw new InvalidOperationException($"Unexpected reference type: {_reference.GetType()}")
            };
        }

        public override string ToString()
        {
            return _reference.ToString() ?? "SubjectReference";
        }
    }
}

// 為了示例，定義一些資源接口
// 在實際使用中，這些會在 ResourceTypeServices.R5 中定義
namespace FhirCore.Interfaces
{
    public interface IPatientResource : IResource
    {
        // Patient 特定的屬性和方法
    }

    public interface IPractitionerResource : IResource
    {
        // Practitioner 特定的屬性和方法
    }

    public interface IOrganizationResource : IResource
    {
        // Organization 特定的屬性和方法
    }
}
