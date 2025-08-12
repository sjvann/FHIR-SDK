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
    /// FHIR R5 Encounter �귽
    /// 
    /// <para>
    /// �Ω�O���w�̻P�������Ѫ̤��������ʡA�]�A���E�B��|�B��E���U���������N�E�O���C
    /// Encounter �O FHIR ���{�ɤu�@�y�{���֤߸귽�A�s���w�̡B�����H���M�����欰�C
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
    ///         Display = new FhirString("���p��")
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
    /// Encounter �귽�i�H�O���U���������������ʡG
    /// - ���E�N�E�]Outpatient visit�^
    /// - ��|�v���]Inpatient stay�^
    /// - ��E�N��]Emergency visit�^
    /// - �����E���]Virtual visit�^
    /// - �~�a�@�z�]Home care�^
    /// </para>
    /// 
    /// <para>
    /// R5 �������D�n�S�I�G
    /// - �W�j�������A�Ȥ䴩
    /// - ��i���N�E�����t��
    /// - ���F�����ѻP�̺޲z
    /// - �䴩�������N�E��]�O��
    /// - �W�j���J�|/�X�|�޲z
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
        /// �귽����
        /// </summary>
        public override string ResourceType => "Encounter";

        /// <summary>
        /// �ѧO�X
        /// </summary>
        /// <remarks>
        /// <para>
        /// �N�E���ѧO�X�A�p���E���B��|���B��E�����C
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
        /// �N�E���A
        /// </summary>
        /// <remarks>
        /// <para>
        /// �N�E����e���A�A�p planned, in-progress, completed, cancelled ���C
        /// �o�O�������C
        /// </para>
        /// </remarks>
        [Required(ErrorMessage = "�N�E���������A")]
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
        /// �N�E����
        /// </summary>
        /// <remarks>
        /// <para>
        /// �N�E�������A�p���E�]AMB�^�B��|�]IMP�^�B��E�]EMER�^���C
        /// �o�O�������C
        /// </para>
        /// </remarks>
        [Required(ErrorMessage = "�N�E����������")]
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
        /// �N�E�u����
        /// </summary>
        /// <remarks>
        /// <para>
        /// �N�E�����{�ש��u���šA�p�`�W�B���B�M�浥�C
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
        /// �N�E����
        /// </summary>
        /// <remarks>
        /// <para>
        /// ����骺�N�E�����A�p��E�B�ƶE�B��N���C
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
        /// �A������
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���Ѫ������A�������A�p����B�~��B��E�쵥�C
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
        /// �N�E�D��
        /// </summary>
        /// <remarks>
        /// <para>
        /// �N�E���D��A�q�`�O�w�̡A���]�i�H�O�s�աC
        /// �o�O�������C
        /// </para>
        /// </remarks>
        [Required(ErrorMessage = "�N�E�������D��")]
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
        /// �D�骬�A
        /// </summary>
        /// <remarks>
        /// <para>
        /// �N�E�D�骺���A�A�p���E�w�̡B��|�w�̵��C
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
        /// �������@�ƥ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���N�E���ݪ����@�ƥ�]EpisodeOfCare�^�C
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
        /// ��󪺽ШD
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���N�E��������ШD����E��C
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
        /// ���@�ζ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// �ѻP���N�E�����@�ζ��C
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
        /// �W�ŴN�E
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���N�E���ݪ��W�ŴN�E�A�Ω��ܴN�E���h�����Y�C
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
        /// �A�ȴ��Ѫ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// �t�d���N�E����´���c�C
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
        /// �ѻP��
        /// </summary>
        /// <remarks>
        /// <para>
        /// �ѻP���N�E���H���A�]�A��v�B�@�z�v�B�w�̮a�ݵ��C
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
        /// �����w��
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���N�E�������w���O���C
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
        /// ��ڮɶ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// �N�E����ڶ}�l�M�����ɶ��C
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
        /// �p���}�l�ɶ�
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
        /// �p�������ɶ�
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
        /// �N�E�ɪ�
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
        /// �N�E��]
        /// </summary>
        /// <remarks>
        /// <para>
        /// �N�E����]�ξA���g�C
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
        /// �E�_
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���N�E�������E�_�C��C
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
        /// �����b��
        /// </summary>
        /// <remarks>
        /// <para>
        /// �P���N�E�������p�O�b��C
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
        /// �������n
        /// </summary>
        /// <remarks>
        /// <para>
        /// �w�̪��������n�έ���A�D�n�Ω��|�w�̡C
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
        /// �S��w��
        /// </summary>
        /// <remarks>
        /// <para>
        /// �N�E�һݪ��S��w�ơA�p���ȡB½Ķ���C
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
        /// �S��§�J
        /// </summary>
        /// <remarks>
        /// <para>
        /// �w�����ɨ����S��§�J�A�p VIP �A�ȵ��C
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
        /// �J�|��T
        /// </summary>
        /// <remarks>
        /// <para>
        /// ��|�w�̪��J�|�M�X�|������T�C
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
        /// ��m
        /// </summary>
        /// <remarks>
        /// <para>
        /// �N�E�����w�̩Ҧb����m�C��C
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
        /// �إ߷s�� Encounter �귽���
        /// </summary>
        public Encounter()
        {
        }

        /// <summary>
        /// �إ߷s�� Encounter �귽���
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        public Encounter(string id)
        {
            Id = id;
        }

        /// <summary>
        /// �إ߷s�� Encounter �귽���
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        /// <param name="status">�N�E���A</param>
        /// <param name="class">�N�E����</param>
        /// <param name="subject">�N�E�D��</param>
        public Encounter(string id, string status, CodeableConcept encounterClass, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject)
        {
            Id = id;
            Status = new FhirCode(status);
            Class = new List<CodeableConcept> { encounterClass };
            Subject = subject;
        }

        /// <summary>
        /// �ഫ���r����
        /// </summary>
        public override string ToString()
        {
            var status = Status?.Value ?? "���A����";
            var classDisplay = Class?.FirstOrDefault()?.Text?.Value ?? 
                               Class?.FirstOrDefault()?.Coding?.FirstOrDefault()?.Display?.Value ?? 
                               "��������";
            var subjectRef = Subject?.Reference?.Value ?? "�D�饼��";
            
            return $"Encounter(Id: {Id}, Status: {status}, Class: {classDisplay}, Subject: {subjectRef})";
        }
    }

    /// <summary>
    /// �N�E�ѻP��
    /// </summary>
    /// <remarks>
    /// <para>
    /// �y�z�ѻP�N�E���H���A�]�A�䨤��B�ѻP�ɶ����C
    /// </para>
    /// </remarks>
    public class EncounterParticipant
    {
        /// <summary>
        /// �ѻP������
        /// </summary>
        /// <remarks>
        /// <para>
        /// �ѻP�̪����������A�p�D�v��v�B�@�z�v�B�a�ݵ��C
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Type { get; set; }

        /// <summary>
        /// �ѻP�ɶ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// �ѻP�̰ѻP�N�E���ɶ��q�C
        /// </para>
        /// </remarks>
        public Period? Period { get; set; }

        /// <summary>
        /// �ѻP��
        /// </summary>
        /// <remarks>
        /// <para>
        /// �ѻP�̪��ޥΡA�i�H�O�����H���B�w�̩ά����H���C
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
    /// �N�E��]
    /// </summary>
    /// <remarks>
    /// <para>
    /// �y�z�N�E����]�ξA���g�C
    /// </para>
    /// </remarks>
    public class EncounterReason
    {
        /// <summary>
        /// ��]�γ~
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������]���γ~�A�p�D�n��]�B���n��]���C
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Use { get; set; }

        /// <summary>
        /// ��]��
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���骺��]�A�i�H�O�N�X�ι��L�귽���ޥΡC
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
    /// �N�E�E�_
    /// </summary>
    /// <remarks>
    /// <para>
    /// �O���P�N�E�������E�_��T�C
    /// </para>
    /// </remarks>
    public class EncounterDiagnosis
    {
        /// <summary>
        /// �E�_���p
        /// </summary>
        /// <remarks>
        /// <para>
        /// ��E�_���p���ޥΡA�i�H�O�N�X�ι� Condition �귽���ޥΡC
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Condition { get; set; }

        /// <summary>
        /// �E�_�γ~
        /// </summary>
        /// <remarks>
        /// <para>
        /// �E�_���γ~�A�p�J�|�E�_�B�X�|�E�_�B�D�n�E�_���C
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
    /// �N�E�J�|��T
    /// </summary>
    /// <remarks>
    /// <para>
    /// �O����|�w�̪��J�|�M�X�|������T�C
    /// </para>
    /// </remarks>
    public class EncounterAdmission
    {
        /// <summary>
        /// �J�|�e�ѧO�X
        /// </summary>
        public Identifier? PreAdmissionIdentifier { get; set; }

        /// <summary>
        /// �J�|�ӷ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// �w�̤J�|�e����m�A�p�a���B��L��|���C
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Origin { get; set; }

        /// <summary>
        /// �J�|�ӷ�����
        /// </summary>
        public CodeableConcept? AdmitSource { get; set; }

        /// <summary>
        /// �A�J�|����
        /// </summary>
        public CodeableConcept? ReAdmission { get; set; }

        /// <summary>
        /// �X�|�h�V
        /// </summary>
        /// <remarks>
        /// <para>
        /// �w�̥X�|�᪺�h�V�A�p�a���B��L��|�B�w�i���ߵ��C
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Destination { get; set; }

        /// <summary>
        /// �X�|�B�m
        /// </summary>
        public CodeableConcept? DischargeDisposition { get; set; }

        public EncounterAdmission() { }
    }

    /// <summary>
    /// �N�E��m
    /// </summary>
    /// <remarks>
    /// <para>
    /// �O���N�E�����w�̩Ҧb����m�ܤơC
    /// </para>
    /// </remarks>
    public class EncounterLocation
    {
        /// <summary>
        /// ��m
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���m�귽���ޥΡC
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Location { get; set; }

        /// <summary>
        /// ��m���A
        /// </summary>
        /// <remarks>
        /// <para>
        /// �w�̦b����m�����A�A�p planned, active, completed ���C
        /// </para>
        /// </remarks>
        public FhirCode? Status { get; set; }

        /// <summary>
        /// ��m�Φ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ��m�����z�Φ��A�p�ɦ�B�ж��B�E�����C
        /// </para>
        /// </remarks>
        public CodeableConcept? Form { get; set; }

        /// <summary>
        /// �b����m���ɶ�
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