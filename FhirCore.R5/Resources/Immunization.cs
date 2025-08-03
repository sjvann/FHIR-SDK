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
    /// FHIR R5 Immunization 資源
    /// 
    /// <para>
    /// Immunization 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var immunization = new Immunization("immunization-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Immunization 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Immunization : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private FhirCode? _status;
        private CodeableConcept? _statusreason;
        private CodeableConcept? _vaccinecode;
        private CodeableReference? _administeredproduct;
        private CodeableReference? _manufacturer;
        private FhirString? _lotnumber;
        private FhirDate? _expirationdate;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _patient;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _supportinginformation;
        private ImmunizationOccurrenceChoice? _occurrence;
        private FhirBoolean? _primarysource;
        private CodeableReference? _informationsource;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _location;
        private CodeableConcept? _site;
        private CodeableConcept? _route;
        private Quantity? _dosequantity;
        private List<ImmunizationPerformer>? _performer;
        private List<Annotation>? _note;
        private List<CodeableReference>? _reason;
        private FhirBoolean? _issubpotent;
        private List<CodeableConcept>? _subpotentreason;
        private List<ImmunizationProgramEligibility>? _programeligibility;
        private CodeableConcept? _fundingsource;
        private List<ImmunizationReaction>? _reaction;
        private List<ImmunizationProtocolApplied>? _protocolapplied;
        private CodeableConcept? _function;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _actor;
        private CodeableConcept? _program;
        private CodeableConcept? _programstatus;
        private FhirDateTime? _date;
        private CodeableReference? _manifestation;
        private FhirBoolean? _reported;
        private FhirString? _series;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _authority;
        private List<CodeableConcept>? _targetdisease;
        private FhirString? _dosenumber;
        private FhirString? _seriesdoses;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Immunization";        /// <summary>
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
        /// Basedon
        /// </summary>
        /// <remarks>
        /// <para>
        /// Basedon 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Basedon
        {
            get => _basedon;
            set
            {
                _basedon = value;
                OnPropertyChanged(nameof(Basedon));
            }
        }        /// <summary>
        /// Status
        /// </summary>
        /// <remarks>
        /// <para>
        /// Status 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }        /// <summary>
        /// Statusreason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Statusreason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Statusreason
        {
            get => _statusreason;
            set
            {
                _statusreason = value;
                OnPropertyChanged(nameof(Statusreason));
            }
        }        /// <summary>
        /// Vaccinecode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Vaccinecode 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Vaccinecode
        {
            get => _vaccinecode;
            set
            {
                _vaccinecode = value;
                OnPropertyChanged(nameof(Vaccinecode));
            }
        }        /// <summary>
        /// Administeredproduct
        /// </summary>
        /// <remarks>
        /// <para>
        /// Administeredproduct 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Administeredproduct
        {
            get => _administeredproduct;
            set
            {
                _administeredproduct = value;
                OnPropertyChanged(nameof(Administeredproduct));
            }
        }        /// <summary>
        /// Manufacturer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Manufacturer 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Manufacturer
        {
            get => _manufacturer;
            set
            {
                _manufacturer = value;
                OnPropertyChanged(nameof(Manufacturer));
            }
        }        /// <summary>
        /// Lotnumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Lotnumber 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Lotnumber
        {
            get => _lotnumber;
            set
            {
                _lotnumber = value;
                OnPropertyChanged(nameof(Lotnumber));
            }
        }        /// <summary>
        /// Expirationdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Expirationdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Expirationdate
        {
            get => _expirationdate;
            set
            {
                _expirationdate = value;
                OnPropertyChanged(nameof(Expirationdate));
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
        /// Supportinginformation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supportinginformation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Supportinginformation
        {
            get => _supportinginformation;
            set
            {
                _supportinginformation = value;
                OnPropertyChanged(nameof(Supportinginformation));
            }
        }        /// <summary>
        /// Occurrence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Occurrence 的詳細描述。
        /// </para>
        /// </remarks>
        public ImmunizationOccurrenceChoice? Occurrence
        {
            get => _occurrence;
            set
            {
                _occurrence = value;
                OnPropertyChanged(nameof(Occurrence));
            }
        }        /// <summary>
        /// Primarysource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Primarysource 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Primarysource
        {
            get => _primarysource;
            set
            {
                _primarysource = value;
                OnPropertyChanged(nameof(Primarysource));
            }
        }        /// <summary>
        /// Informationsource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Informationsource 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Informationsource
        {
            get => _informationsource;
            set
            {
                _informationsource = value;
                OnPropertyChanged(nameof(Informationsource));
            }
        }        /// <summary>
        /// Location
        /// </summary>
        /// <remarks>
        /// <para>
        /// Location 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }        /// <summary>
        /// Site
        /// </summary>
        /// <remarks>
        /// <para>
        /// Site 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Site
        {
            get => _site;
            set
            {
                _site = value;
                OnPropertyChanged(nameof(Site));
            }
        }        /// <summary>
        /// Route
        /// </summary>
        /// <remarks>
        /// <para>
        /// Route 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Route
        {
            get => _route;
            set
            {
                _route = value;
                OnPropertyChanged(nameof(Route));
            }
        }        /// <summary>
        /// Dosequantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dosequantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Dosequantity
        {
            get => _dosequantity;
            set
            {
                _dosequantity = value;
                OnPropertyChanged(nameof(Dosequantity));
            }
        }        /// <summary>
        /// Performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ImmunizationPerformer>? Performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(Performer));
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
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }        /// <summary>
        /// Issubpotent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Issubpotent 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Issubpotent
        {
            get => _issubpotent;
            set
            {
                _issubpotent = value;
                OnPropertyChanged(nameof(Issubpotent));
            }
        }        /// <summary>
        /// Subpotentreason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subpotentreason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Subpotentreason
        {
            get => _subpotentreason;
            set
            {
                _subpotentreason = value;
                OnPropertyChanged(nameof(Subpotentreason));
            }
        }        /// <summary>
        /// Programeligibility
        /// </summary>
        /// <remarks>
        /// <para>
        /// Programeligibility 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ImmunizationProgramEligibility>? Programeligibility
        {
            get => _programeligibility;
            set
            {
                _programeligibility = value;
                OnPropertyChanged(nameof(Programeligibility));
            }
        }        /// <summary>
        /// Fundingsource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Fundingsource 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Fundingsource
        {
            get => _fundingsource;
            set
            {
                _fundingsource = value;
                OnPropertyChanged(nameof(Fundingsource));
            }
        }        /// <summary>
        /// Reaction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reaction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ImmunizationReaction>? Reaction
        {
            get => _reaction;
            set
            {
                _reaction = value;
                OnPropertyChanged(nameof(Reaction));
            }
        }        /// <summary>
        /// Protocolapplied
        /// </summary>
        /// <remarks>
        /// <para>
        /// Protocolapplied 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ImmunizationProtocolApplied>? Protocolapplied
        {
            get => _protocolapplied;
            set
            {
                _protocolapplied = value;
                OnPropertyChanged(nameof(Protocolapplied));
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
        /// Program
        /// </summary>
        /// <remarks>
        /// <para>
        /// Program 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Program
        {
            get => _program;
            set
            {
                _program = value;
                OnPropertyChanged(nameof(Program));
            }
        }        /// <summary>
        /// Programstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Programstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Programstatus
        {
            get => _programstatus;
            set
            {
                _programstatus = value;
                OnPropertyChanged(nameof(Programstatus));
            }
        }        /// <summary>
        /// Date
        /// </summary>
        /// <remarks>
        /// <para>
        /// Date 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }        /// <summary>
        /// Manifestation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Manifestation 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Manifestation
        {
            get => _manifestation;
            set
            {
                _manifestation = value;
                OnPropertyChanged(nameof(Manifestation));
            }
        }        /// <summary>
        /// Reported
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reported 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Reported
        {
            get => _reported;
            set
            {
                _reported = value;
                OnPropertyChanged(nameof(Reported));
            }
        }        /// <summary>
        /// Series
        /// </summary>
        /// <remarks>
        /// <para>
        /// Series 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Series
        {
            get => _series;
            set
            {
                _series = value;
                OnPropertyChanged(nameof(Series));
            }
        }        /// <summary>
        /// Authority
        /// </summary>
        /// <remarks>
        /// <para>
        /// Authority 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Authority
        {
            get => _authority;
            set
            {
                _authority = value;
                OnPropertyChanged(nameof(Authority));
            }
        }        /// <summary>
        /// Targetdisease
        /// </summary>
        /// <remarks>
        /// <para>
        /// Targetdisease 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Targetdisease
        {
            get => _targetdisease;
            set
            {
                _targetdisease = value;
                OnPropertyChanged(nameof(Targetdisease));
            }
        }        /// <summary>
        /// Dosenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dosenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Dosenumber
        {
            get => _dosenumber;
            set
            {
                _dosenumber = value;
                OnPropertyChanged(nameof(Dosenumber));
            }
        }        /// <summary>
        /// Seriesdoses
        /// </summary>
        /// <remarks>
        /// <para>
        /// Seriesdoses 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Seriesdoses
        {
            get => _seriesdoses;
            set
            {
                _seriesdoses = value;
                OnPropertyChanged(nameof(Seriesdoses));
            }
        }        /// <summary>
        /// 建立新的 Immunization 資源實例
        /// </summary>
        public Immunization()
        {
        }

        /// <summary>
        /// 建立新的 Immunization 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Immunization(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Immunization(Id: {Id})";
        }
    }    /// <summary>
    /// ImmunizationPerformer 背骨元素
    /// </summary>
    public class ImmunizationPerformer
    {
        // TODO: 添加屬性實作
        
        public ImmunizationPerformer() { }
    }    /// <summary>
    /// ImmunizationProgramEligibility 背骨元素
    /// </summary>
    public class ImmunizationProgramEligibility
    {
        // TODO: 添加屬性實作
        
        public ImmunizationProgramEligibility() { }
    }    /// <summary>
    /// ImmunizationReaction 背骨元素
    /// </summary>
    public class ImmunizationReaction
    {
        // TODO: 添加屬性實作
        
        public ImmunizationReaction() { }
    }    /// <summary>
    /// ImmunizationProtocolApplied 背骨元素
    /// </summary>
    public class ImmunizationProtocolApplied
    {
        // TODO: 添加屬性實作
        
        public ImmunizationProtocolApplied() { }
    }    /// <summary>
    /// ImmunizationOccurrenceChoice 選擇類型
    /// </summary>
    public class ImmunizationOccurrenceChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ImmunizationOccurrenceChoice(JsonObject value) : base("immunizationoccurrence", value, _supportType) { }
        public ImmunizationOccurrenceChoice(IComplexType? value) : base("immunizationoccurrence", value) { }
        public ImmunizationOccurrenceChoice(IPrimitiveType? value) : base("immunizationoccurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ImmunizationOccurrence" : "immunizationoccurrence";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
