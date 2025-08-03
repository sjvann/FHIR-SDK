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
    /// FHIR R5 ImagingStudy 資源
    /// 
    /// <para>
    /// ImagingStudy 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var imagingstudy = new ImagingStudy("imagingstudy-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 ImagingStudy 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ImagingStudy : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private List<CodeableConcept>? _modality;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private FhirDateTime? _started;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _partof;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _referrer;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _endpoint;
        private FhirUnsignedInt? _numberofseries;
        private FhirUnsignedInt? _numberofinstances;
        private List<CodeableReference>? _procedure;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _location;
        private List<CodeableReference>? _reason;
        private List<Annotation>? _note;
        private FhirString? _description;
        private List<ImagingStudySeries>? _series;
        private CodeableConcept? _function;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _actor;
        private FhirId? _uid;
        private Coding? _sopclass;
        private FhirUnsignedInt? _number;
        private FhirString? _title;
        private FhirId? _uid;
        private FhirUnsignedInt? _number;
        private CodeableConcept? _modality;
        private FhirString? _description;
        private FhirUnsignedInt? _numberofinstances;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _endpoint;
        private CodeableReference? _bodysite;
        private CodeableConcept? _laterality;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _specimen;
        private FhirDateTime? _started;
        private List<ImagingStudySeriesPerformer>? _performer;
        private List<ImagingStudySeriesInstance>? _instance;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ImagingStudy";        /// <summary>
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
        /// Modality
        /// </summary>
        /// <remarks>
        /// <para>
        /// Modality 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Modality
        {
            get => _modality;
            set
            {
                _modality = value;
                OnPropertyChanged(nameof(Modality));
            }
        }        /// <summary>
        /// Subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
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
        /// Started
        /// </summary>
        /// <remarks>
        /// <para>
        /// Started 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Started
        {
            get => _started;
            set
            {
                _started = value;
                OnPropertyChanged(nameof(Started));
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
        /// Partof
        /// </summary>
        /// <remarks>
        /// <para>
        /// Partof 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Partof
        {
            get => _partof;
            set
            {
                _partof = value;
                OnPropertyChanged(nameof(Partof));
            }
        }        /// <summary>
        /// Referrer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Referrer 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Referrer
        {
            get => _referrer;
            set
            {
                _referrer = value;
                OnPropertyChanged(nameof(Referrer));
            }
        }        /// <summary>
        /// Endpoint
        /// </summary>
        /// <remarks>
        /// <para>
        /// Endpoint 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Endpoint
        {
            get => _endpoint;
            set
            {
                _endpoint = value;
                OnPropertyChanged(nameof(Endpoint));
            }
        }        /// <summary>
        /// Numberofseries
        /// </summary>
        /// <remarks>
        /// <para>
        /// Numberofseries 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? Numberofseries
        {
            get => _numberofseries;
            set
            {
                _numberofseries = value;
                OnPropertyChanged(nameof(Numberofseries));
            }
        }        /// <summary>
        /// Numberofinstances
        /// </summary>
        /// <remarks>
        /// <para>
        /// Numberofinstances 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? Numberofinstances
        {
            get => _numberofinstances;
            set
            {
                _numberofinstances = value;
                OnPropertyChanged(nameof(Numberofinstances));
            }
        }        /// <summary>
        /// Procedure
        /// </summary>
        /// <remarks>
        /// <para>
        /// Procedure 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Procedure
        {
            get => _procedure;
            set
            {
                _procedure = value;
                OnPropertyChanged(nameof(Procedure));
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
        /// Series
        /// </summary>
        /// <remarks>
        /// <para>
        /// Series 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ImagingStudySeries>? Series
        {
            get => _series;
            set
            {
                _series = value;
                OnPropertyChanged(nameof(Series));
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
        /// Uid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Uid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Uid
        {
            get => _uid;
            set
            {
                _uid = value;
                OnPropertyChanged(nameof(Uid));
            }
        }        /// <summary>
        /// Sopclass
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sopclass 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? Sopclass
        {
            get => _sopclass;
            set
            {
                _sopclass = value;
                OnPropertyChanged(nameof(Sopclass));
            }
        }        /// <summary>
        /// Number
        /// </summary>
        /// <remarks>
        /// <para>
        /// Number 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? Number
        {
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged(nameof(Number));
            }
        }        /// <summary>
        /// Title
        /// </summary>
        /// <remarks>
        /// <para>
        /// Title 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }        /// <summary>
        /// Uid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Uid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Uid
        {
            get => _uid;
            set
            {
                _uid = value;
                OnPropertyChanged(nameof(Uid));
            }
        }        /// <summary>
        /// Number
        /// </summary>
        /// <remarks>
        /// <para>
        /// Number 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? Number
        {
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged(nameof(Number));
            }
        }        /// <summary>
        /// Modality
        /// </summary>
        /// <remarks>
        /// <para>
        /// Modality 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Modality
        {
            get => _modality;
            set
            {
                _modality = value;
                OnPropertyChanged(nameof(Modality));
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
        /// Numberofinstances
        /// </summary>
        /// <remarks>
        /// <para>
        /// Numberofinstances 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? Numberofinstances
        {
            get => _numberofinstances;
            set
            {
                _numberofinstances = value;
                OnPropertyChanged(nameof(Numberofinstances));
            }
        }        /// <summary>
        /// Endpoint
        /// </summary>
        /// <remarks>
        /// <para>
        /// Endpoint 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Endpoint
        {
            get => _endpoint;
            set
            {
                _endpoint = value;
                OnPropertyChanged(nameof(Endpoint));
            }
        }        /// <summary>
        /// Bodysite
        /// </summary>
        /// <remarks>
        /// <para>
        /// Bodysite 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Bodysite
        {
            get => _bodysite;
            set
            {
                _bodysite = value;
                OnPropertyChanged(nameof(Bodysite));
            }
        }        /// <summary>
        /// Laterality
        /// </summary>
        /// <remarks>
        /// <para>
        /// Laterality 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Laterality
        {
            get => _laterality;
            set
            {
                _laterality = value;
                OnPropertyChanged(nameof(Laterality));
            }
        }        /// <summary>
        /// Specimen
        /// </summary>
        /// <remarks>
        /// <para>
        /// Specimen 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Specimen
        {
            get => _specimen;
            set
            {
                _specimen = value;
                OnPropertyChanged(nameof(Specimen));
            }
        }        /// <summary>
        /// Started
        /// </summary>
        /// <remarks>
        /// <para>
        /// Started 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Started
        {
            get => _started;
            set
            {
                _started = value;
                OnPropertyChanged(nameof(Started));
            }
        }        /// <summary>
        /// Performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ImagingStudySeriesPerformer>? Performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(Performer));
            }
        }        /// <summary>
        /// Instance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ImagingStudySeriesInstance>? Instance
        {
            get => _instance;
            set
            {
                _instance = value;
                OnPropertyChanged(nameof(Instance));
            }
        }        /// <summary>
        /// 建立新的 ImagingStudy 資源實例
        /// </summary>
        public ImagingStudy()
        {
        }

        /// <summary>
        /// 建立新的 ImagingStudy 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ImagingStudy(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ImagingStudy(Id: {Id})";
        }
    }    /// <summary>
    /// ImagingStudySeriesPerformer 背骨元素
    /// </summary>
    public class ImagingStudySeriesPerformer
    {
        // TODO: 添加屬性實作
        
        public ImagingStudySeriesPerformer() { }
    }    /// <summary>
    /// ImagingStudySeriesInstance 背骨元素
    /// </summary>
    public class ImagingStudySeriesInstance
    {
        // TODO: 添加屬性實作
        
        public ImagingStudySeriesInstance() { }
    }    /// <summary>
    /// ImagingStudySeries 背骨元素
    /// </summary>
    public class ImagingStudySeries
    {
        // TODO: 添加屬性實作
        
        public ImagingStudySeries() { }
    }
}
