using FhirCore.Base;
using FhirCore.R5;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using FhirCore.Interfaces;

namespace FhirCore.R5.Resources
{
    /// <summary>
    /// FHIR R5 Encounter 資源
    /// 
    /// <para>
    /// 用於記錄患者與醫療提供者之間的互動，包括門診、住院、急診等各種類型的就診記錄。
    /// Encounter 是 FHIR 中臨床工作流程的核心資源，連接患者、醫療人員和醫療行為。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var encounter = new Encounter("encounter-001")
    /// {
    ///     Status = new FhirCode("in-progress"),
    ///     Class = new List&lt;CodeableConcept&gt;
    ///     {
    ///         new CodeableConcept
    ///         {
    ///             Coding = new List&lt;Coding&gt;
    ///             {
    ///                 new Coding
    ///                 {
    ///                     System = new FhirUri("http://terminology.hl7.org/CodeSystem/v3-ActCode"),
    ///                     Code = new FhirCode("AMB"),
    ///                     Display = new FhirString("Ambulatory")
    ///                 }
    ///             }
    ///         }
    ///     },
    ///     Subject = new ReferenceType
    ///     {
    ///         Reference = new FhirString("Patient/patient-001"),
    ///         Display = new FhirString("王小明")
    ///     },
    ///     ActualPeriod = new Period
    ///     {
    ///         Start = new FhirDateTime("2024-01-15T09:00:00Z"),
    ///         End = new FhirDateTime("2024-01-15T10:30:00Z")
    ///     }
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Encounter 資源可以記錄各種類型的醫療互動：
    /// - 門診就診（Outpatient visit）
    /// - 住院治療（Inpatient stay）
    /// - 急診就醫（Emergency visit）
    /// - 虛擬診療（Virtual visit）
    /// - 居家護理（Home care）
    /// </para>
    /// 
    /// <para>
    /// R5 版本的主要特點：
    /// - 增強的虛擬服務支援
    /// - 改進的就診分類系統
    /// - 更靈活的參與者管理
    /// - 支援複雜的就診原因記錄
    /// - 增強的入院/出院管理
    /// </para>
    /// </remarks>
    public class Encounter : ResourceBase<R5Version>
    {
        private List<Identifier>? _identifier;
        private FhirCode? _status;
        private List<CodeableConcept>? _class;
        private CodeableConcept? _priority;
        private List<CodeableConcept>? _type;
        private List<CodeableReference>? _serviceType;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private CodeableConcept? _subjectStatus;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _episodeOfCare;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedOn;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _careTeam;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _partOf;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _serviceProvider;
        private List<EncounterParticipant>? _participant;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _appointment;
        private Period? _actualPeriod;
        private FhirDateTime? _plannedStartDate;
        private FhirDateTime? _plannedEndDate;
        private Duration? _length;
        private List<EncounterReason>? _reason;
        private List<EncounterDiagnosis>? _diagnosis;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _account;
        private List<CodeableConcept>? _dietPreference;
        private List<CodeableConcept>? _specialArrangement;
        private List<CodeableConcept>? _specialCourtesy;
        private EncounterAdmission? _admission;
        private List<EncounterLocation>? _location;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Encounter";

        /// <summary>
        /// 識別碼
        /// </summary>
        /// <remarks>
        /// <para>
        /// 就診的識別碼，如門診號、住院號、急診號等。
        /// </para>
        /// </remarks>
        public List<Identifier>? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
            }
        }

        /// <summary>
        /// 就診狀態
        /// </summary>
        /// <remarks>
        /// <para>
        /// 就診的當前狀態，如 planned, in-progress, completed, cancelled 等。
        /// 這是必填欄位。
        /// </para>
        /// </remarks>
        [Required(ErrorMessage = "就診必須有狀態")]
        public FhirCode? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }

        /// <summary>
        /// 就診分類
        /// </summary>
        /// <remarks>
        /// <para>
        /// 就診的分類，如門診（AMB）、住院（IMP）、急診（EMER）等。
        /// 這是必填欄位。
        /// </para>
        /// </remarks>
        [Required(ErrorMessage = "就診必須有分類")]
        public List<CodeableConcept>? Class
        {
            get => _class;
            set
            {
                _class = value;
                OnPropertyChanged(nameof(Class));
            }
        }

        /// <summary>
        /// 就診優先級
        /// </summary>
        /// <remarks>
        /// <para>
        /// 就診的緊急程度或優先級，如常規、緊急、危急等。
        /// </para>
        /// </remarks>
        public CodeableConcept? Priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(Priority));
            }
        }

        /// <summary>
        /// 就診類型
        /// </summary>
        /// <remarks>
        /// <para>
        /// 更具體的就診類型，如初診、複診、手術等。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }

        /// <summary>
        /// 服務類型
        /// </summary>
        /// <remarks>
        /// <para>
        /// 提供的醫療服務類型，如內科、外科、急診科等。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? ServiceType
        {
            get => _serviceType;
            set
            {
                _serviceType = value;
                OnPropertyChanged(nameof(ServiceType));
            }
        }

        /// <summary>
        /// 就診主體
        /// </summary>
        /// <remarks>
        /// <para>
        /// 就診的主體，通常是患者，但也可以是群組。
        /// 這是必填欄位。
        /// </para>
        /// </remarks>
        [Required(ErrorMessage = "就診必須有主體")]
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }

        /// <summary>
        /// 主體狀態
        /// </summary>
        /// <remarks>
        /// <para>
        /// 就診主體的狀態，如門診患者、住院患者等。
        /// </para>
        /// </remarks>
        public CodeableConcept? SubjectStatus
        {
            get => _subjectStatus;
            set
            {
                _subjectStatus = value;
                OnPropertyChanged(nameof(SubjectStatus));
            }
        }

        /// <summary>
        /// 相關照護事件
        /// </summary>
        /// <remarks>
        /// <para>
        /// 此就診所屬的照護事件（EpisodeOfCare）。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? EpisodeOfCare
        {
            get => _episodeOfCare;
            set
            {
                _episodeOfCare = value;
                OnPropertyChanged(nameof(EpisodeOfCare));
            }
        }

        /// <summary>
        /// 基於的請求
        /// </summary>
        /// <remarks>
        /// <para>
        /// 此就診基於的醫療請求或轉診單。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? BasedOn
        {
            get => _basedOn;
            set
            {
                _basedOn = value;
                OnPropertyChanged(nameof(BasedOn));
            }
        }

        /// <summary>
        /// 照護團隊
        /// </summary>
        /// <remarks>
        /// <para>
        /// 參與此就診的照護團隊。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? CareTeam
        {
            get => _careTeam;
            set
            {
                _careTeam = value;
                OnPropertyChanged(nameof(CareTeam));
            }
        }

        /// <summary>
        /// 上級就診
        /// </summary>
        /// <remarks>
        /// <para>
        /// 此就診所屬的上級就診，用於表示就診的層級關係。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? PartOf
        {
            get => _partOf;
            set
            {
                _partOf = value;
                OnPropertyChanged(nameof(PartOf));
            }
        }

        /// <summary>
        /// 服務提供者
        /// </summary>
        /// <remarks>
        /// <para>
        /// 負責此就診的組織機構。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? ServiceProvider
        {
            get => _serviceProvider;
            set
            {
                _serviceProvider = value;
                OnPropertyChanged(nameof(ServiceProvider));
            }
        }

        /// <summary>
        /// 參與者
        /// </summary>
        /// <remarks>
        /// <para>
        /// 參與此就診的人員，包括醫師、護理師、患者家屬等。
        /// </para>
        /// </remarks>
        public List<EncounterParticipant>? Participant
        {
            get => _participant;
            set
            {
                _participant = value;
                OnPropertyChanged(nameof(Participant));
            }
        }

        /// <summary>
        /// 相關預約
        /// </summary>
        /// <remarks>
        /// <para>
        /// 此就診相關的預約記錄。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Appointment
        {
            get => _appointment;
            set
            {
                _appointment = value;
                OnPropertyChanged(nameof(Appointment));
            }
        }

        /// <summary>
        /// 實際時間
        /// </summary>
        /// <remarks>
        /// <para>
        /// 就診的實際開始和結束時間。
        /// </para>
        /// </remarks>
        public Period? ActualPeriod
        {
            get => _actualPeriod;
            set
            {
                _actualPeriod = value;
                OnPropertyChanged(nameof(ActualPeriod));
            }
        }

        /// <summary>
        /// 計劃開始時間
        /// </summary>
        public FhirDateTime? PlannedStartDate
        {
            get => _plannedStartDate;
            set
            {
                _plannedStartDate = value;
                OnPropertyChanged(nameof(PlannedStartDate));
            }
        }

        /// <summary>
        /// 計劃結束時間
        /// </summary>
        public FhirDateTime? PlannedEndDate
        {
            get => _plannedEndDate;
            set
            {
                _plannedEndDate = value;
                OnPropertyChanged(nameof(PlannedEndDate));
            }
        }

        /// <summary>
        /// 就診時長
        /// </summary>
        public Duration? Length
        {
            get => _length;
            set
            {
                _length = value;
                OnPropertyChanged(nameof(Length));
            }
        }

        /// <summary>
        /// 就診原因
        /// </summary>
        /// <remarks>
        /// <para>
        /// 就診的原因或適應症。
        /// </para>
        /// </remarks>
        public List<EncounterReason>? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }

        /// <summary>
        /// 診斷
        /// </summary>
        /// <remarks>
        /// <para>
        /// 此就診相關的診斷列表。
        /// </para>
        /// </remarks>
        public List<EncounterDiagnosis>? Diagnosis
        {
            get => _diagnosis;
            set
            {
                _diagnosis = value;
                OnPropertyChanged(nameof(Diagnosis));
            }
        }

        /// <summary>
        /// 相關帳戶
        /// </summary>
        /// <remarks>
        /// <para>
        /// 與此就診相關的計費帳戶。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Account
        {
            get => _account;
            set
            {
                _account = value;
                OnPropertyChanged(nameof(Account));
            }
        }

        /// <summary>
        /// 飲食偏好
        /// </summary>
        /// <remarks>
        /// <para>
        /// 患者的飲食偏好或限制，主要用於住院患者。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? DietPreference
        {
            get => _dietPreference;
            set
            {
                _dietPreference = value;
                OnPropertyChanged(nameof(DietPreference));
            }
        }

        /// <summary>
        /// 特殊安排
        /// </summary>
        /// <remarks>
        /// <para>
        /// 就診所需的特殊安排，如輪椅、翻譯等。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? SpecialArrangement
        {
            get => _specialArrangement;
            set
            {
                _specialArrangement = value;
                OnPropertyChanged(nameof(SpecialArrangement));
            }
        }

        /// <summary>
        /// 特殊禮遇
        /// </summary>
        /// <remarks>
        /// <para>
        /// 患者應享受的特殊禮遇，如 VIP 服務等。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? SpecialCourtesy
        {
            get => _specialCourtesy;
            set
            {
                _specialCourtesy = value;
                OnPropertyChanged(nameof(SpecialCourtesy));
            }
        }

        /// <summary>
        /// 入院資訊
        /// </summary>
        /// <remarks>
        /// <para>
        /// 住院患者的入院和出院相關資訊。
        /// </para>
        /// </remarks>
        public EncounterAdmission? Admission
        {
            get => _admission;
            set
            {
                _admission = value;
                OnPropertyChanged(nameof(Admission));
            }
        }

        /// <summary>
        /// 位置
        /// </summary>
        /// <remarks>
        /// <para>
        /// 就診期間患者所在的位置列表。
        /// </para>
        /// </remarks>
        public List<EncounterLocation>? Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }

        /// <summary>
        /// 建立新的 Encounter 資源實例
        /// </summary>
        public Encounter()
        {
        }

        /// <summary>
        /// 建立新的 Encounter 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Encounter(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 建立新的 Encounter 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        /// <param name="status">就診狀態</param>
        /// <param name="class">就診分類</param>
        /// <param name="subject">就診主體</param>
        public Encounter(string id, string status, CodeableConcept encounterClass, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject)
        {
            Id = id;
            Status = new FhirCode(status);
            Class = new List<CodeableConcept> { encounterClass };
            Subject = subject;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            var status = Status?.Value ?? "狀態未知";
            var classDisplay = Class?.FirstOrDefault()?.Text?.Value ?? 
                               Class?.FirstOrDefault()?.Coding?.FirstOrDefault()?.Display?.Value ?? 
                               "分類未知";
            var subjectRef = Subject?.Reference?.Value ?? "主體未知";
            
            return $"Encounter(Id: {Id}, Status: {status}, Class: {classDisplay}, Subject: {subjectRef})";
        }
    }

    /// <summary>
    /// 就診參與者
    /// </summary>
    /// <remarks>
    /// <para>
    /// 描述參與就診的人員，包括其角色、參與時間等。
    /// </para>
    /// </remarks>
    public class EncounterParticipant
    {
        /// <summary>
        /// 參與者類型
        /// </summary>
        /// <remarks>
        /// <para>
        /// 參與者的角色類型，如主治醫師、護理師、家屬等。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Type { get; set; }

        /// <summary>
        /// 參與時間
        /// </summary>
        /// <remarks>
        /// <para>
        /// 參與者參與就診的時間段。
        /// </para>
        /// </remarks>
        public Period? Period { get; set; }

        /// <summary>
        /// 參與者
        /// </summary>
        /// <remarks>
        /// <para>
        /// 參與者的引用，可以是醫療人員、患者或相關人員。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Actor { get; set; }

        public EncounterParticipant() { }

        public EncounterParticipant(DataTypeServices.DataTypes.SpecialTypes.ReferenceType actor, CodeableConcept type)
        {
            Actor = actor;
            Type = new List<CodeableConcept> { type };
        }
    }

    /// <summary>
    /// 就診原因
    /// </summary>
    /// <remarks>
    /// <para>
    /// 描述就診的原因或適應症。
    /// </para>
    /// </remarks>
    public class EncounterReason
    {
        /// <summary>
        /// 原因用途
        /// </summary>
        /// <remarks>
        /// <para>
        /// 說明原因的用途，如主要原因、次要原因等。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Use { get; set; }

        /// <summary>
        /// 原因值
        /// </summary>
        /// <remarks>
        /// <para>
        /// 具體的原因，可以是代碼或對其他資源的引用。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Value { get; set; }

        public EncounterReason() { }

        public EncounterReason(CodeableReference value, CodeableConcept? use = null)
        {
            Value = new List<CodeableReference> { value };
            if (use != null)
            {
                Use = new List<CodeableConcept> { use };
            }
        }
    }

    /// <summary>
    /// 就診診斷
    /// </summary>
    /// <remarks>
    /// <para>
    /// 記錄與就診相關的診斷資訊。
    /// </para>
    /// </remarks>
    public class EncounterDiagnosis
    {
        /// <summary>
        /// 診斷狀況
        /// </summary>
        /// <remarks>
        /// <para>
        /// 對診斷狀況的引用，可以是代碼或對 Condition 資源的引用。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Condition { get; set; }

        /// <summary>
        /// 診斷用途
        /// </summary>
        /// <remarks>
        /// <para>
        /// 診斷的用途，如入院診斷、出院診斷、主要診斷等。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Use { get; set; }

        public EncounterDiagnosis() { }

        public EncounterDiagnosis(CodeableReference condition, CodeableConcept? use = null)
        {
            Condition = new List<CodeableReference> { condition };
            if (use != null)
            {
                Use = new List<CodeableConcept> { use };
            }
        }
    }

    /// <summary>
    /// 就診入院資訊
    /// </summary>
    /// <remarks>
    /// <para>
    /// 記錄住院患者的入院和出院相關資訊。
    /// </para>
    /// </remarks>
    public class EncounterAdmission
    {
        /// <summary>
        /// 入院前識別碼
        /// </summary>
        public Identifier? PreAdmissionIdentifier { get; set; }

        /// <summary>
        /// 入院來源
        /// </summary>
        /// <remarks>
        /// <para>
        /// 患者入院前的位置，如家中、其他醫院等。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Origin { get; set; }

        /// <summary>
        /// 入院來源類型
        /// </summary>
        public CodeableConcept? AdmitSource { get; set; }

        /// <summary>
        /// 再入院指示
        /// </summary>
        public CodeableConcept? ReAdmission { get; set; }

        /// <summary>
        /// 出院去向
        /// </summary>
        /// <remarks>
        /// <para>
        /// 患者出院後的去向，如家中、其他醫院、安養中心等。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Destination { get; set; }

        /// <summary>
        /// 出院處置
        /// </summary>
        public CodeableConcept? DischargeDisposition { get; set; }

        public EncounterAdmission() { }
    }

    /// <summary>
    /// 就診位置
    /// </summary>
    /// <remarks>
    /// <para>
    /// 記錄就診期間患者所在的位置變化。
    /// </para>
    /// </remarks>
    public class EncounterLocation
    {
        /// <summary>
        /// 位置
        /// </summary>
        /// <remarks>
        /// <para>
        /// 對位置資源的引用。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Location { get; set; }

        /// <summary>
        /// 位置狀態
        /// </summary>
        /// <remarks>
        /// <para>
        /// 患者在此位置的狀態，如 planned, active, completed 等。
        /// </para>
        /// </remarks>
        public FhirCode? Status { get; set; }

        /// <summary>
        /// 位置形式
        /// </summary>
        /// <remarks>
        /// <para>
        /// 位置的物理形式，如床位、房間、診間等。
        /// </para>
        /// </remarks>
        public CodeableConcept? Form { get; set; }

        /// <summary>
        /// 在此位置的時間
        /// </summary>
        public Period? Period { get; set; }

        public EncounterLocation() { }

        public EncounterLocation(DataTypeServices.DataTypes.SpecialTypes.ReferenceType location, string status)
        {
            Location = location;
            Status = new FhirCode(status);
        }
    }
}