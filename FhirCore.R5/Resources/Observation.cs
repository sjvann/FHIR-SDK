using FhirCore.Base;
using FhirCore.R5;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using FhirCore.Interfaces;
using Range = DataTypeServices.DataTypes.ComplexTypes.Range;

namespace FhirCore.R5.Resources
{
    /// <summary>
    /// FHIR R5 Observation �귽
    /// 
    /// <para>
    /// �Ω�O���w�̪��[��ȡB���q���G�B������i���{�ɼƾڡC
    /// �O FHIR ���̭��n���{�ɸ귽���@�A�䴩�U�����������q�M�[��C
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var observation = new Observation("obs-001")
    /// {
    ///     Status = new FhirCode("final"),
    ///     Code = new CodeableConcept
    ///     {
    ///         Coding = new List&lt;Coding&gt;
    ///         {
    ///             new Coding
    ///             {
    ///                 System = new FhirUri("http://loinc.org"),
    ///                 Code = new FhirCode("8302-2"),
    ///                 Display = new FhirString("Body height")
    ///             }
    ///         }
    ///     },
    ///     Subject = new ReferenceType
    ///     {
    ///         Reference = new FhirString("Patient/patient-001")
    ///     },
    ///     Value = new ObservationValueChoice(new Quantity
    ///     {
    ///         Value = new FhirDecimal(175),
    ///         Unit = new FhirString("cm"),
    ///         System = new FhirUri("http://unitsofmeasure.org"),
    ///         Code = new FhirCode("cm")
    ///     })
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Observation �귽�i�H�O���U���������{�ɼƾڡG
    /// - �ͩR��x�]�����B�߲v�B��ŵ��^
    /// - ��������絲�G�]��}�B����J�յ��^
    /// - �v���ˬd���G
    /// - �ݶE���
    /// - �����q�����
    /// </para>
    /// 
    /// <para>
    /// R5 �������D�n�S�I�G
    /// - �W�j��Ĳ�o����䴩
    /// - ��i���զX�[��ȳB�z
    /// - ���F�������Įɶ��]�w
    /// - �䴩��h���ƭ�����
    /// </para>
    /// </remarks>
    public class Observation : ResourceBase<R5Version>
    {
        private List<Identifier>? _identifier;
        private ObservationInstantiatesChoice? _instantiates;
        private List<ReferenceType>? _basedOn;
        private List<ObservationTriggeredBy>? _triggeredBy;
        private List<ReferenceType>? _partOf;
        private FhirCode? _status;
        private List<CodeableConcept>? _category;
        private CodeableConcept? _code;
        private ReferenceType? _subject;
        private List<ReferenceType>? _focus;
        private ReferenceType? _encounter;
        private ObservationEffectiveChoice? _effective;
        private FhirInstant? _issued;
        private List<ReferenceType>? _performer;
        private ObservationValueChoice? _value;
        private CodeableConcept? _dataAbsentReason;
        private List<CodeableConcept>? _interpretation;
        private List<Annotation>? _note;
        private CodeableConcept? _bodySite;
        private ReferenceType? _bodyStructure;
        private CodeableConcept? _method;
        private ReferenceType? _specimen;
        private ReferenceType? _device;
        private List<ObservationReferenceRange>? _referenceRange;
        private List<ReferenceType>? _hasMember;
        private List<ReferenceType>? _derivedFrom;
        private List<ObservationComponent>? _component;

        /// <summary>
        /// �귽����
        /// </summary>
        public override string ResourceType => "Observation";

        /// <summary>
        /// �ѧO�X
        /// </summary>
        /// <remarks>
        /// <para>
        /// �[��Ȫ��ߤ@�ѧO�X�A�p������i�s���B�[��O�������C
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
        /// ��ҤƩw�q
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���V�w�q���[��Ȫ� ObservationDefinition�C
        /// </para>
        /// </remarks>
        public ObservationInstantiatesChoice? Instantiates
        {
            get => _instantiates;
            set
            {
                _instantiates = value;
                OnPropertyChanged(nameof(Instantiates));
            }
        }

        /// <summary>
        /// ��󪺽ШD
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���[��Ȱ�������ШD�A�p����ӽг�C
        /// </para>
        /// </remarks>
        public List<ReferenceType>? BasedOn
        {
            get => _basedOn;
            set
            {
                _basedOn = value;
                OnPropertyChanged(nameof(BasedOn));
            }
        }

        /// <summary>
        /// Ĳ�o�ӷ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// �y�z����Ĳ�o�F���[��Ȫ����͡C
        /// </para>
        /// </remarks>
        public List<ObservationTriggeredBy>? TriggeredBy
        {
            get => _triggeredBy;
            set
            {
                _triggeredBy = value;
                OnPropertyChanged(nameof(TriggeredBy));
            }
        }

        /// <summary>
        /// ���ݪ��զX
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���[��ȬO���j�զX���@�����C
        /// </para>
        /// </remarks>
        public List<ReferenceType>? PartOf
        {
            get => _partOf;
            set
            {
                _partOf = value;
                OnPropertyChanged(nameof(PartOf));
            }
        }

        /// <summary>
        /// �[��Ȫ��A
        /// </summary>
        /// <remarks>
        /// <para>
        /// �[��Ȫ����A�A�p registered�Bpreliminary�Bfinal�Bamended ���C
        /// �o�O�������C
        /// </para>
        /// </remarks>
        [Required(ErrorMessage = "�[��ȥ��������A")]
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
        /// �[��Ȥ���
        /// </summary>
        /// <remarks>
        /// <para>
        /// �[��Ȫ������A�p vital-signs�Blaboratory�Bimaging ���C
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
        /// �[��ȥN�X
        /// </summary>
        /// <remarks>
        /// <para>
        /// �y�z�[����������N�X�A�q�`�ϥ� LOINC �N�X�C
        /// �o�O�������C
        /// </para>
        /// </remarks>
        [Required(ErrorMessage = "�[��ȥ������N�X")]
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
        /// �[��D��
        /// </summary>
        /// <remarks>
        /// <para>
        /// �[��Ȫ��D��A�q�`�O�w�̡A�]�i�H�O�]�ơB��m���C
        /// </para>
        /// </remarks>
        public ReferenceType? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }

        /// <summary>
        /// ���`�J�I
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���[��ȥD�餣�O�w�̮ɡA�u�����`����H�C
        /// </para>
        /// </remarks>
        public List<ReferenceType>? Focus
        {
            get => _focus;
            set
            {
                _focus = value;
                OnPropertyChanged(nameof(Focus));
            }
        }

        /// <summary>
        /// �����N�E
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���ͦ��[��Ȫ��N�E�O���C
        /// </para>
        /// </remarks>
        public ReferenceType? Encounter
        {
            get => _encounter;
            set
            {
                _encounter = value;
                OnPropertyChanged(nameof(Encounter));
            }
        }

        /// <summary>
        /// ���Įɶ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// �[��Ȫ����Įɶ��A�i�H�O�ɶ��I�B�ɶ��q�Ωw�ɦw�ơC
        /// </para>
        /// </remarks>
        public ObservationEffectiveChoice? Effective
        {
            get => _effective;
            set
            {
                _effective = value;
                OnPropertyChanged(nameof(Effective));
            }
        }

        /// <summary>
        /// �o���ɶ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// �[��ȵo�����ɶ��C
        /// </para>
        /// </remarks>
        public FhirInstant? Issued
        {
            get => _issued;
            set
            {
                _issued = value;
                OnPropertyChanged(nameof(Issued));
            }
        }

        /// <summary>
        /// �����
        /// </summary>
        /// <remarks>
        /// <para>
        /// �t�d�����[��H���β�´�C
        /// </para>
        /// </remarks>
        public List<ReferenceType>? Performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(Performer));
            }
        }

        /// <summary>
        /// �[���
        /// </summary>
        /// <remarks>
        /// <para>
        /// �[����G�ȡA�i�H�O�ƶq�B�N�X�B�r�굥�h�������C
        /// </para>
        /// </remarks>
        public ObservationValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }

        /// <summary>
        /// �ƾگʥ���]
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���[��ȯʥ��ɡA�����ʥ�����]�C
        /// </para>
        /// </remarks>
        public CodeableConcept? DataAbsentReason
        {
            get => _dataAbsentReason;
            set
            {
                _dataAbsentReason = value;
                OnPropertyChanged(nameof(DataAbsentReason));
            }
        }

        /// <summary>
        /// ���G����
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���[��Ȫ��{�ɸ����A�p���`�B���`�B�����B���C���C
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Interpretation
        {
            get => _interpretation;
            set
            {
                _interpretation = value;
                OnPropertyChanged(nameof(Interpretation));
            }
        }

        /// <summary>
        /// ����
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���[��Ȫ��B�~���ѩλ����C
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
        /// ���鳡��
        /// </summary>
        /// <remarks>
        /// <para>
        /// �[����鳡��C
        /// </para>
        /// </remarks>
        public CodeableConcept? BodySite
        {
            get => _bodySite;
            set
            {
                _bodySite = value;
                OnPropertyChanged(nameof(BodySite));
            }
        }

        /// <summary>
        /// ���鵲�c
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���������鵲�c�귽�ޥΡC
        /// </para>
        /// </remarks>
        public ReferenceType? BodyStructure
        {
            get => _bodyStructure;
            set
            {
                _bodyStructure = value;
                OnPropertyChanged(nameof(BodyStructure));
            }
        }

        /// <summary>
        /// �[���k
        /// </summary>
        /// <remarks>
        /// <para>
        /// �����[��ϥΪ���k�Χ޳N�C
        /// </para>
        /// </remarks>
        public CodeableConcept? Method
        {
            get => _method;
            set
            {
                _method = value;
                OnPropertyChanged(nameof(Method));
            }
        }

        /// <summary>
        /// ����
        /// </summary>
        /// <remarks>
        /// <para>
        /// �Ω��[�����C
        /// </para>
        /// </remarks>
        public ReferenceType? Specimen
        {
            get => _specimen;
            set
            {
                _specimen = value;
                OnPropertyChanged(nameof(Specimen));
            }
        }

        /// <summary>
        /// �ϥγ]��
        /// </summary>
        /// <remarks>
        /// <para>
        /// �Ω��[��]�ơC
        /// </para>
        /// </remarks>
        public ReferenceType? Device
        {
            get => _device;
            set
            {
                _device = value;
                OnPropertyChanged(nameof(Device));
            }
        }

        /// <summary>
        /// �Ѧҽd��
        /// </summary>
        /// <remarks>
        /// <para>
        /// �[��Ȫ����`�Ѧҽd��C
        /// </para>
        /// </remarks>
        public List<ObservationReferenceRange>? ReferenceRange
        {
            get => _referenceRange;
            set
            {
                _referenceRange = value;
                OnPropertyChanged(nameof(ReferenceRange));
            }
        }

        /// <summary>
        /// �]�t����
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���[��ȥ]�t���l�[��ȡA�Ω�զX�[��ȡC
        /// </para>
        /// </remarks>
        public List<ReferenceType>? HasMember
        {
            get => _hasMember;
            set
            {
                _hasMember = value;
                OnPropertyChanged(nameof(HasMember));
            }
        }

        /// <summary>
        /// �l�ͨӷ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���[��ȭl�۪ͦ���L�[��ȩδC��C
        /// </para>
        /// </remarks>
        public List<ReferenceType>? DerivedFrom
        {
            get => _derivedFrom;
            set
            {
                _derivedFrom = value;
                OnPropertyChanged(nameof(DerivedFrom));
            }
        }

        /// <summary>
        /// �ե�
        /// </summary>
        /// <remarks>
        /// <para>
        /// �[��Ȫ��ե�A�Ω�h�ե��[��ȡC
        /// </para>
        /// </remarks>
        public List<ObservationComponent>? Component
        {
            get => _component;
            set
            {
                _component = value;
                OnPropertyChanged(nameof(Component));
            }
        }

        /// <summary>
        /// �إ߷s�� Observation �귽���
        /// </summary>
        public Observation()
        {
        }

        /// <summary>
        /// �إ߷s�� Observation �귽���
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        public Observation(string id)
        {
            Id = id;
        }

        /// <summary>
        /// �إ߷s�� Observation �귽���
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        /// <param name="status">�[��Ȫ��A</param>
        /// <param name="code">�[��ȥN�X</param>
        /// <param name="subject">�[��D��</param>
        public Observation(string id, string status, CodeableConcept code, ReferenceType subject)
        {
            Id = id;
            Status = new FhirCode(status);
            Code = code;
            Subject = subject;
        }

        /// <summary>
        /// �ഫ���r����
        /// </summary>
        public override string ToString()
        {
            var displayName = Code?.Text?.Value ?? 
                              Code?.Coding?.FirstOrDefault()?.Display?.Value ?? 
                              "���R�W�[���";

            var status = Status?.Value ?? "���A����";
            var subjectRef = Subject?.Reference?.Value ?? "�D�饼��";
            
            return $"Observation(Id: {Id}, Code: {displayName}, Status: {status}, Subject: {subjectRef})";
        }
    }

    /// <summary>
    /// �[���Ĳ�o�ӷ�
    /// </summary>
    /// <remarks>
    /// <para>
    /// �y�zĲ�o���[��Ȳ��ͪ��ӷ��M��]�C
    /// </para>
    /// </remarks>
    public class ObservationTriggeredBy
    {
        /// <summary>
        /// Ĳ�o�[���
        /// </summary>
        public ReferenceType? Observation { get; set; }

        /// <summary>
        /// Ĳ�o����
        /// </summary>
        public FhirCode? Type { get; set; }

        /// <summary>
        /// Ĳ�o��]
        /// </summary>
        public FhirString? Reason { get; set; }

        public ObservationTriggeredBy() { }

        public ObservationTriggeredBy(ReferenceType observation, string type)
        {
            Observation = observation;
            Type = new FhirCode(type);
        }
    }

    /// <summary>
    /// �[��ȰѦҽd��
    /// </summary>
    /// <remarks>
    /// <para>
    /// �w�q�[��Ȫ����`�Ѧҽd��M�A�α���C
    /// </para>
    /// </remarks>
    public class ObservationReferenceRange
    {
        /// <summary>
        /// �U����
        /// </summary>
        public Quantity? Low { get; set; }

        /// <summary>
        /// �W����
        /// </summary>
        public Quantity? High { get; set; }

        /// <summary>
        /// ���`��
        /// </summary>
        public CodeableConcept? NormalValue { get; set; }

        /// <summary>
        /// �d������
        /// </summary>
        public CodeableConcept? Type { get; set; }

        /// <summary>
        /// �A�ι�H
        /// </summary>
        public List<CodeableConcept>? AppliesTo { get; set; }

        /// <summary>
        /// �A�Φ~��
        /// </summary>
        public Range? Age { get; set; }

        public ObservationReferenceRange() { }

        public ObservationReferenceRange(Quantity? low, Quantity? high)
        {
            Low = low;
            High = high;
        }
    }

    /// <summary>
    /// �[��Ȳե�
    /// </summary>
    /// <remarks>
    /// <para>
    /// �Ω�h�ե��[��ȡA�p�����]�t���Y���M�αi����Ӳե�C
    /// </para>
    /// </remarks>
    public class ObservationComponent
    {
        /// <summary>
        /// �ե�N�X
        /// </summary>
        [Required(ErrorMessage = "�[��Ȳե󥲶����N�X")]
        public CodeableConcept? Code { get; set; }

        /// <summary>
        /// �ե��
        /// </summary>
        public ObservationComponentValueChoice? Value { get; set; }

        /// <summary>
        /// �ƾگʥ���]
        /// </summary>
        public CodeableConcept? DataAbsentReason { get; set; }

        /// <summary>
        /// ���G����
        /// </summary>
        public List<CodeableConcept>? Interpretation { get; set; }

        public ObservationComponent() { }

        public ObservationComponent(CodeableConcept code)
        {
            Code = code;
        }
    }

    /// <summary>
    /// Observation ��Ҥƿ������
    /// </summary>
    public class ObservationInstantiatesChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "canonical", "Reference" };

        public ObservationInstantiatesChoice(JsonObject value) : base("instantiates", value, _supportType) { }
        public ObservationInstantiatesChoice(IComplexType? value) : base("instantiates", value) { }
        public ObservationInstantiatesChoice(IPrimitiveType? value) : base("instantiates", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "Instantiates" : "instantiates";

        public override List<string> SetSupportDataType() => _supportType;
    }

    /// <summary>
    /// Observation ���Įɶ��������
    /// </summary>
    public class ObservationEffectiveChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "dateTime", "Period", "Timing", "instant" };

        public ObservationEffectiveChoice(JsonObject value) : base("effective", value, _supportType) { }
        public ObservationEffectiveChoice(IComplexType? value) : base("effective", value) { }
        public ObservationEffectiveChoice(IPrimitiveType? value) : base("effective", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "Effective" : "effective";

        public override List<string> SetSupportDataType() => _supportType;
    }

    /// <summary>
    /// Observation �ȿ������
    /// </summary>
    public class ObservationValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() 
        { 
            "Quantity", "CodeableConcept", "string", "boolean", "integer", 
            "Range", "Ratio", "SampledData", "time", "dateTime", "Period", 
            "Attachment", "Reference" 
        };

        public ObservationValueChoice(JsonObject value) : base("value", value, _supportType) { }
        public ObservationValueChoice(IComplexType? value) : base("value", value) { }
        public ObservationValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "Value" : "value";

        public override List<string> SetSupportDataType() => _supportType;
    }

    /// <summary>
    /// Observation �ե�ȿ������
    /// </summary>
    public class ObservationComponentValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() 
        { 
            "Quantity", "CodeableConcept", "string", "boolean", "integer", 
            "Range", "Ratio", "SampledData", "time", "dateTime", "Period", 
            "Attachment", "Reference" 
        };

        public ObservationComponentValueChoice(JsonObject value) : base("value", value, _supportType) { }
        public ObservationComponentValueChoice(IComplexType? value) : base("value", value) { }
        public ObservationComponentValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "Value" : "value";

        public override List<string> SetSupportDataType() => _supportType;
    }
}