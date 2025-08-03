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
    /// FHIR R5 Condition �귽
    /// 
    /// <para>
    /// �Ω�O���w�̪��e�f�B�E�_�B�g���Ψ�L���d���p�C
    /// Condition �O�{�ɶE�_���֤߸귽�A�y�z�w�̪����d���D�����`�I�C
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var condition = new Condition("condition-001")
    /// {
    ///     ClinicalStatus = new CodeableConcept
    ///     {
    ///         Coding = new List&lt;Coding&gt;
    ///         {
    ///             new Coding
    ///             {
    ///                 System = new FhirUri("http://terminology.hl7.org/CodeSystem/condition-clinical"),
    ///                 Code = new FhirCode("active"),
    ///                 Display = new FhirString("Active")
    ///             }
    ///         }
    ///     },
    ///     VerificationStatus = new CodeableConcept
    ///     {
    ///         Coding = new List&lt;Coding&gt;
    ///         {
    ///             new Coding
    ///             {
    ///                 System = new FhirUri("http://terminology.hl7.org/CodeSystem/condition-ver-status"),
    ///                 Code = new FhirCode("confirmed"),
    ///                 Display = new FhirString("Confirmed")
    ///             }
    ///         }
    ///     },
    ///     Code = new CodeableConcept
    ///     {
    ///         Coding = new List&lt;Coding&gt;
    ///         {
    ///             new Coding
    ///             {
    ///                 System = new FhirUri("http://snomed.info/sct"),
    ///                 Code = new FhirCode("73211009"),
    ///                 Display = new FhirString("Diabetes mellitus")
    ///             }
    ///         }
    ///     },
    ///     Subject = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType
    ///     {
    ///         Reference = new FhirString("Patient/patient-001"),
    ///         Display = new FhirString("���p��")
    ///     }
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Condition �귽�i�H�O���U�����������d���p�G
    /// - �T�E�e�f�]�p�}���f�B�������^
    /// - �g���]�p�Y�h�B�o�N�^
    /// - ���d���`�I�]�p�L�Ӥ������I�^
    /// - �E�_�]�D�n�E�_�B���n�E�_�^
    /// - ���D�C����
    /// </para>
    /// 
    /// <para>
    /// R5 �������D�n�S�I�G
    /// - �W�j���ѻP�̺޲z
    /// - ��i�����q�l��
    /// - ���F�����o�f�M�w�Ѯɶ��O��
    /// - �䴩��ԲӪ��ҾڰO��
    /// - �ﵽ�����鳡��y�z
    /// </para>
    /// </remarks>
    public class Condition : ResourceBase<R5Version>
    {
        private List<Identifier>? _identifier;
        private CodeableConcept? _clinicalStatus;
        private CodeableConcept? _verificationStatus;
        private List<CodeableConcept>? _category;
        private CodeableConcept? _severity;
        private CodeableConcept? _code;
        private List<CodeableConcept>? _bodySite;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private ConditionOnsetChoice? _onset;
        private ConditionAbatementChoice? _abatement;
        private FhirDateTime? _recordedDate;
        private List<ConditionParticipant>? _participant;
        private List<ConditionStage>? _stage;
        private List<CodeableReference>? _evidence;
        private List<Annotation>? _note;

        /// <summary>
        /// �귽����
        /// </summary>
        public override string ResourceType => "Condition";

        /// <summary>
        /// �ѧO�X
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���󪺥~���ѧO�X�A�p�E�_�s���B���D�C��s�����C
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
        /// �{�ɪ��A
        /// </summary>
        /// <remarks>
        /// <para>
        /// �����{�ɪ��A�A�p active�Binactive�Bresolved ���C
        /// �o�O�������C
        /// </para>
        /// </remarks>
        [Required(ErrorMessage = "���󥲶����{�ɪ��A")]
        public CodeableConcept? ClinicalStatus
        {
            get => _clinicalStatus;
            set
            {
                _clinicalStatus = value;
                OnPropertyChanged(nameof(ClinicalStatus));
            }
        }

        /// <summary>
        /// ���Ҫ��A
        /// </summary>
        /// <remarks>
        /// <para>
        /// ����E�_���T�w�{�סA�p provisional�Bdifferential�Bconfirmed ���C
        /// </para>
        /// </remarks>
        public CodeableConcept? VerificationStatus
        {
            get => _verificationStatus;
            set
            {
                _verificationStatus = value;
                OnPropertyChanged(nameof(VerificationStatus));
            }
        }

        /// <summary>
        /// �������
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���󪺤����A�p�D�n�E�_�B���n�E�_�B���D�C���C
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }

        /// <summary>
        /// �Y���{��
        /// </summary>
        /// <remarks>
        /// <para>
        /// �����Y���{�סA�p���L�B�����B�Y�����C
        /// </para>
        /// </remarks>
        public CodeableConcept? Severity
        {
            get => _severity;
            set
            {
                _severity = value;
                OnPropertyChanged(nameof(Severity));
            }
        }

        /// <summary>
        /// ����N�X
        /// </summary>
        /// <remarks>
        /// <para>
        /// �ѧO����B���D�ζE�_���N�X�A�q�`�ϥ� SNOMED CT�BICD-10 ���зǥN�X�t�ΡC
        /// </para>
        /// </remarks>
        public CodeableConcept? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }

        /// <summary>
        /// ���鳡��
        /// </summary>
        /// <remarks>
        /// <para>
        /// ����v�T�����鳡��Ψt�ΡC
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? BodySite
        {
            get => _bodySite;
            set
            {
                _bodySite = value;
                OnPropertyChanged(nameof(BodySite));
            }
        }

        /// <summary>
        /// ����D��
        /// </summary>
        /// <remarks>
        /// <para>
        /// �㦳�����󪺱w�̩θs�աC
        /// �o�O�������C
        /// </para>
        /// </remarks>
        [Required(ErrorMessage = "���󥲶����D��")]
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
        /// �����N�E
        /// </summary>
        /// <remarks>
        /// <para>
        /// �E�_�ΰO�������󪺴N�E�C
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Encounter
        {
            get => _encounter;
            set
            {
                _encounter = value;
                OnPropertyChanged(nameof(Encounter));
            }
        }

        /// <summary>
        /// �o�f�ɶ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ����}�l�έ����Q�ѧO���ɶ��C
        /// </para>
        /// </remarks>
        public ConditionOnsetChoice? Onset
        {
            get => _onset;
            set
            {
                _onset = value;
                OnPropertyChanged(nameof(Onset));
            }
        }

        /// <summary>
        /// �w�Ѯɶ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���󵲧��B�w�ѩΤ��A�O���`�I���ɶ��C
        /// </para>
        /// </remarks>
        public ConditionAbatementChoice? Abatement
        {
            get => _abatement;
            set
            {
                _abatement = value;
                OnPropertyChanged(nameof(Abatement));
            }
        }

        /// <summary>
        /// �O�����
        /// </summary>
        /// <remarks>
        /// <para>
        /// ����Q�O���b�t�Τ�������C
        /// </para>
        /// </remarks>
        public FhirDateTime? RecordedDate
        {
            get => _recordedDate;
            set
            {
                _recordedDate = value;
                OnPropertyChanged(nameof(RecordedDate));
            }
        }

        /// <summary>
        /// �ѻP��
        /// </summary>
        /// <remarks>
        /// <para>
        /// �ѻP�E�_�Ϊv�������󪺤H���C
        /// </para>
        /// </remarks>
        public List<ConditionParticipant>? Participant
        {
            get => _participant;
            set
            {
                _participant = value;
                OnPropertyChanged(nameof(Participant));
            }
        }

        /// <summary>
        /// ���q
        /// </summary>
        /// <remarks>
        /// <para>
        /// �����{�ɶ��q�ε��šC
        /// </para>
        /// </remarks>
        public List<ConditionStage>? Stage
        {
            get => _stage;
            set
            {
                _stage = value;
                OnPropertyChanged(nameof(Stage));
            }
        }

        /// <summary>
        /// �Ҿ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// �������s�b���Y���{�ת��ҾڡC
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Evidence
        {
            get => _evidence;
            set
            {
                _evidence = value;
                OnPropertyChanged(nameof(Evidence));
            }
        }

        /// <summary>
        /// ����
        /// </summary>
        /// <remarks>
        /// <para>
        /// ��������B�~���ѩλ����C
        /// </para>
        /// </remarks>
        public List<Annotation>? Note
        {
            get => _note;
            set
            {
                _note = value;
                OnPropertyChanged(nameof(Note));
            }
        }

        /// <summary>
        /// �إ߷s�� Condition �귽���
        /// </summary>
        public Condition()
        {
        }

        /// <summary>
        /// �إ߷s�� Condition �귽���
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        public Condition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// �إ߷s�� Condition �귽���
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        /// <param name="code">����N�X</param>
        /// <param name="subject">����D��</param>
        public Condition(string id, CodeableConcept code, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject)
        {
            Id = id;
            Code = code;
            Subject = subject;
            RecordedDate = new FhirDateTime(DateTime.Now);
        }

        /// <summary>
        /// �إ߷s�� Condition �귽���
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        /// <param name="code">����N�X</param>
        /// <param name="subject">����D��</param>
        /// <param name="clinicalStatus">�{�ɪ��A</param>
        /// <param name="verificationStatus">���Ҫ��A</param>
        public Condition(string id, CodeableConcept code, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject, 
            CodeableConcept clinicalStatus, CodeableConcept? verificationStatus = null)
        {
            Id = id;
            Code = code;
            Subject = subject;
            ClinicalStatus = clinicalStatus;
            VerificationStatus = verificationStatus;
            RecordedDate = new FhirDateTime(DateTime.Now);
        }

        /// <summary>
        /// �ഫ���r����
        /// </summary>
        public override string ToString()
        {
            var codeDisplay = Code?.Text?.Value ?? 
                              Code?.Coding?.FirstOrDefault()?.Display?.Value ?? 
                              "��������";

            var status = ClinicalStatus?.Coding?.FirstOrDefault()?.Code?.Value ?? "���A����";
            var subjectRef = Subject?.Reference?.Value ?? "�D�饼��";
            
            return $"Condition(Id: {Id}, Code: {codeDisplay}, Status: {status}, Subject: {subjectRef})";
        }
    }

    /// <summary>
    /// ����ѻP��
    /// </summary>
    /// <remarks>
    /// <para>
    /// �y�z�ѻP�E�_�Ϊv�������󪺤H���C
    /// </para>
    /// </remarks>
    public class ConditionParticipant
    {
        /// <summary>
        /// �ѻP�\��
        /// </summary>
        /// <remarks>
        /// <para>
        /// �ѻP�̦b�����󤤪��\�ਤ��C
        /// </para>
        /// </remarks>
        public CodeableConcept? Function { get; set; }

        /// <summary>
        /// �ѻP��
        /// </summary>
        /// <remarks>
        /// <para>
        /// �ѻP�̪��ޥΡA�i�H�O�����H���B�w�̩ά����H���C
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Actor { get; set; }

        public ConditionParticipant() { }

        public ConditionParticipant(DataTypeServices.DataTypes.SpecialTypes.ReferenceType actor, CodeableConcept? function = null)
        {
            Actor = actor;
            Function = function;
        }
    }

    /// <summary>
    /// ���󶥬q
    /// </summary>
    /// <remarks>
    /// <para>
    /// �y�z�����{�ɶ��q�ε��Ÿ�T�C
    /// </para>
    /// </remarks>
    public class ConditionStage
    {
        /// <summary>
        /// ���q�K�n
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���q��²�n�y�z�Τ����C
        /// </para>
        /// </remarks>
        public CodeableConcept? Summary { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        /// <remarks>
        /// <para>
        /// �Ω�T�w���q�������O���C
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Assessment { get; set; }

        /// <summary>
        /// ���q����
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���q�����������A�p�f�z�B�{�ɵ��C
        /// </para>
        /// </remarks>
        public CodeableConcept? Type { get; set; }

        public ConditionStage() { }

        public ConditionStage(CodeableConcept summary, CodeableConcept? type = null)
        {
            Summary = summary;
            Type = type;
        }
    }

    /// <summary>
    /// Condition �o�f�ɶ��������
    /// </summary>
    public class ConditionOnsetChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "dateTime", "Age", "Period", "Range", "string" };

        public ConditionOnsetChoice(JsonObject value) : base("onset", value, _supportType) { }
        public ConditionOnsetChoice(IComplexType? value) : base("onset", value) { }
        public ConditionOnsetChoice(IPrimitiveType? value) : base("onset", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "Onset" : "onset";

        public override List<string> SetSupportDataType() => _supportType;
    }

    /// <summary>
    /// Condition �w�Ѯɶ��������
    /// </summary>
    public class ConditionAbatementChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "dateTime", "Age", "Period", "Range", "string" };

        public ConditionAbatementChoice(JsonObject value) : base("abatement", value, _supportType) { }
        public ConditionAbatementChoice(IComplexType? value) : base("abatement", value) { }
        public ConditionAbatementChoice(IPrimitiveType? value) : base("abatement", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "Abatement" : "abatement";

        public override List<string> SetSupportDataType() => _supportType;
    }
}