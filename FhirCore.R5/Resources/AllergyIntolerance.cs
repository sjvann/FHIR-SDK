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
    /// FHIR R5 AllergyIntolerance 資源
    /// 
    /// <para>
    /// AllergyIntolerance 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var allergyintolerance = new AllergyIntolerance("allergyintolerance-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 AllergyIntolerance 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class AllergyIntolerance : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private CodeableConcept? _clinicalstatus;
        private CodeableConcept? _verificationstatus;
        private CodeableConcept? _type;
        private List<FhirCode>? _category;
        private FhirCode? _criticality;
        private CodeableConcept? _code;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _patient;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private AllergyIntoleranceOnsetChoice? _onset;
        private FhirDateTime? _recordeddate;
        private List<AllergyIntoleranceParticipant>? _participant;
        private FhirDateTime? _lastoccurrence;
        private List<Annotation>? _note;
        private List<AllergyIntoleranceReaction>? _reaction;
        private CodeableConcept? _function;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _actor;
        private CodeableConcept? _substance;
        private List<CodeableReference>? _manifestation;
        private FhirString? _description;
        private FhirDateTime? _onset;
        private FhirCode? _severity;
        private CodeableConcept? _exposureroute;
        private List<Annotation>? _note;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "AllergyIntolerance";        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private List<Identifier>? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
            }
        }        /// <summary>
        /// Clinicalstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Clinicalstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Clinicalstatus
        {
            get => _clinicalstatus;
            set
            {
                _clinicalstatus = value;
                OnPropertyChanged(nameof(Clinicalstatus));
            }
        }        /// <summary>
        /// Verificationstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Verificationstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Verificationstatus
        {
            get => _verificationstatus;
            set
            {
                _verificationstatus = value;
                OnPropertyChanged(nameof(Verificationstatus));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Criticality
        /// </summary>
        /// <remarks>
        /// <para>
        /// Criticality 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Criticality
        {
            get => _criticality;
            set
            {
                _criticality = value;
                OnPropertyChanged(nameof(Criticality));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
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
        }        /// <summary>
        /// Patient
        /// </summary>
        /// <remarks>
        /// <para>
        /// Patient 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Patient
        {
            get => _patient;
            set
            {
                _patient = value;
                OnPropertyChanged(nameof(Patient));
            }
        }        /// <summary>
        /// Encounter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Encounter 的詳細描述。
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
        }        /// <summary>
        /// Onset
        /// </summary>
        /// <remarks>
        /// <para>
        /// Onset 的詳細描述。
        /// </para>
        /// </remarks>
        public AllergyIntoleranceOnsetChoice? Onset
        {
            get => _onset;
            set
            {
                _onset = value;
                OnPropertyChanged(nameof(Onset));
            }
        }        /// <summary>
        /// Recordeddate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Recordeddate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Recordeddate
        {
            get => _recordeddate;
            set
            {
                _recordeddate = value;
                OnPropertyChanged(nameof(Recordeddate));
            }
        }        /// <summary>
        /// Participant
        /// </summary>
        /// <remarks>
        /// <para>
        /// Participant 的詳細描述。
        /// </para>
        /// </remarks>
        public List<AllergyIntoleranceParticipant>? Participant
        {
            get => _participant;
            set
            {
                _participant = value;
                OnPropertyChanged(nameof(Participant));
            }
        }        /// <summary>
        /// Lastoccurrence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Lastoccurrence 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Lastoccurrence
        {
            get => _lastoccurrence;
            set
            {
                _lastoccurrence = value;
                OnPropertyChanged(nameof(Lastoccurrence));
            }
        }        /// <summary>
        /// Note
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note 的詳細描述。
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
        }        /// <summary>
        /// Reaction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reaction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<AllergyIntoleranceReaction>? Reaction
        {
            get => _reaction;
            set
            {
                _reaction = value;
                OnPropertyChanged(nameof(Reaction));
            }
        }        /// <summary>
        /// Function
        /// </summary>
        /// <remarks>
        /// <para>
        /// Function 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Function
        {
            get => _function;
            set
            {
                _function = value;
                OnPropertyChanged(nameof(Function));
            }
        }        /// <summary>
        /// Actor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Actor 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Actor
        {
            get => _actor;
            set
            {
                _actor = value;
                OnPropertyChanged(nameof(Actor));
            }
        }        /// <summary>
        /// Substance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Substance 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Substance
        {
            get => _substance;
            set
            {
                _substance = value;
                OnPropertyChanged(nameof(Substance));
            }
        }        /// <summary>
        /// Manifestation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Manifestation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Manifestation
        {
            get => _manifestation;
            set
            {
                _manifestation = value;
                OnPropertyChanged(nameof(Manifestation));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Onset
        /// </summary>
        /// <remarks>
        /// <para>
        /// Onset 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Onset
        {
            get => _onset;
            set
            {
                _onset = value;
                OnPropertyChanged(nameof(Onset));
            }
        }        /// <summary>
        /// Severity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Severity 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Severity
        {
            get => _severity;
            set
            {
                _severity = value;
                OnPropertyChanged(nameof(Severity));
            }
        }        /// <summary>
        /// Exposureroute
        /// </summary>
        /// <remarks>
        /// <para>
        /// Exposureroute 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Exposureroute
        {
            get => _exposureroute;
            set
            {
                _exposureroute = value;
                OnPropertyChanged(nameof(Exposureroute));
            }
        }        /// <summary>
        /// Note
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note 的詳細描述。
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
        }        /// <summary>
        /// 建立新的 AllergyIntolerance 資源實例
        /// </summary>
        public AllergyIntolerance()
        {
        }

        /// <summary>
        /// 建立新的 AllergyIntolerance 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public AllergyIntolerance(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"AllergyIntolerance(Id: {Id})";
        }
    }    /// <summary>
    /// AllergyIntoleranceParticipant 背骨元素
    /// </summary>
    public class AllergyIntoleranceParticipant
    {
        // TODO: 添加屬性實作
        
        public AllergyIntoleranceParticipant() { }
    }    /// <summary>
    /// AllergyIntoleranceReaction 背骨元素
    /// </summary>
    public class AllergyIntoleranceReaction
    {
        // TODO: 添加屬性實作
        
        public AllergyIntoleranceReaction() { }
    }    /// <summary>
    /// AllergyIntoleranceOnsetChoice 選擇類型
    /// </summary>
    public class AllergyIntoleranceOnsetChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public AllergyIntoleranceOnsetChoice(JsonObject value) : base("allergyintoleranceonset", value, _supportType) { }
        public AllergyIntoleranceOnsetChoice(IComplexType? value) : base("allergyintoleranceonset", value) { }
        public AllergyIntoleranceOnsetChoice(IPrimitiveType? value) : base("allergyintoleranceonset", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "AllergyIntoleranceOnset" : "allergyintoleranceonset";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
