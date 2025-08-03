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
    /// FHIR R5 Specimen 資源
    /// 
    /// <para>
    /// Specimen 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var specimen = new Specimen("specimen-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Specimen 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Specimen : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private Identifier? _accessionidentifier;
        private FhirCode? _status;
        private CodeableConcept? _type;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private FhirDateTime? _receivedtime;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _parent;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _request;
        private FhirCode? _combined;
        private List<CodeableConcept>? _role;
        private List<SpecimenFeature>? _feature;
        private SpecimenCollection? _collection;
        private List<SpecimenProcessing>? _processing;
        private List<SpecimenContainer>? _container;
        private List<CodeableConcept>? _condition;
        private List<Annotation>? _note;
        private CodeableConcept? _type;
        private FhirString? _description;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _collector;
        private SpecimenCollectionCollectedChoice? _collected;
        private Duration? _duration;
        private Quantity? _quantity;
        private CodeableConcept? _method;
        private CodeableReference? _device;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _procedure;
        private CodeableReference? _bodysite;
        private SpecimenCollectionFastingStatusChoice? _fastingstatus;
        private FhirString? _description;
        private CodeableConcept? _method;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _additive;
        private SpecimenProcessingTimeChoice? _time;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _device;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _location;
        private Quantity? _specimenquantity;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Specimen";        /// <summary>
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
        /// Accessionidentifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Accessionidentifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? Accessionidentifier
        {
            get => _accessionidentifier;
            set
            {
                _accessionidentifier = value;
                OnPropertyChanged(nameof(Accessionidentifier));
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
        /// Receivedtime
        /// </summary>
        /// <remarks>
        /// <para>
        /// Receivedtime 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Receivedtime
        {
            get => _receivedtime;
            set
            {
                _receivedtime = value;
                OnPropertyChanged(nameof(Receivedtime));
            }
        }        /// <summary>
        /// Parent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Parent 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Parent
        {
            get => _parent;
            set
            {
                _parent = value;
                OnPropertyChanged(nameof(Parent));
            }
        }        /// <summary>
        /// Request
        /// </summary>
        /// <remarks>
        /// <para>
        /// Request 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Request
        {
            get => _request;
            set
            {
                _request = value;
                OnPropertyChanged(nameof(Request));
            }
        }        /// <summary>
        /// Combined
        /// </summary>
        /// <remarks>
        /// <para>
        /// Combined 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Combined
        {
            get => _combined;
            set
            {
                _combined = value;
                OnPropertyChanged(nameof(Combined));
            }
        }        /// <summary>
        /// Role
        /// </summary>
        /// <remarks>
        /// <para>
        /// Role 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Role
        {
            get => _role;
            set
            {
                _role = value;
                OnPropertyChanged(nameof(Role));
            }
        }        /// <summary>
        /// Feature
        /// </summary>
        /// <remarks>
        /// <para>
        /// Feature 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SpecimenFeature>? Feature
        {
            get => _feature;
            set
            {
                _feature = value;
                OnPropertyChanged(nameof(Feature));
            }
        }        /// <summary>
        /// Collection
        /// </summary>
        /// <remarks>
        /// <para>
        /// Collection 的詳細描述。
        /// </para>
        /// </remarks>
        public SpecimenCollection? Collection
        {
            get => _collection;
            set
            {
                _collection = value;
                OnPropertyChanged(nameof(Collection));
            }
        }        /// <summary>
        /// Processing
        /// </summary>
        /// <remarks>
        /// <para>
        /// Processing 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SpecimenProcessing>? Processing
        {
            get => _processing;
            set
            {
                _processing = value;
                OnPropertyChanged(nameof(Processing));
            }
        }        /// <summary>
        /// Container
        /// </summary>
        /// <remarks>
        /// <para>
        /// Container 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SpecimenContainer>? Container
        {
            get => _container;
            set
            {
                _container = value;
                OnPropertyChanged(nameof(Container));
            }
        }        /// <summary>
        /// Condition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Condition 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Condition
        {
            get => _condition;
            set
            {
                _condition = value;
                OnPropertyChanged(nameof(Condition));
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
        /// Collector
        /// </summary>
        /// <remarks>
        /// <para>
        /// Collector 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Collector
        {
            get => _collector;
            set
            {
                _collector = value;
                OnPropertyChanged(nameof(Collector));
            }
        }        /// <summary>
        /// Collected
        /// </summary>
        /// <remarks>
        /// <para>
        /// Collected 的詳細描述。
        /// </para>
        /// </remarks>
        public SpecimenCollectionCollectedChoice? Collected
        {
            get => _collected;
            set
            {
                _collected = value;
                OnPropertyChanged(nameof(Collected));
            }
        }        /// <summary>
        /// Duration
        /// </summary>
        /// <remarks>
        /// <para>
        /// Duration 的詳細描述。
        /// </para>
        /// </remarks>
        public Duration? Duration
        {
            get => _duration;
            set
            {
                _duration = value;
                OnPropertyChanged(nameof(Duration));
            }
        }        /// <summary>
        /// Quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }        /// <summary>
        /// Method
        /// </summary>
        /// <remarks>
        /// <para>
        /// Method 的詳細描述。
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
        }        /// <summary>
        /// Device
        /// </summary>
        /// <remarks>
        /// <para>
        /// Device 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Device
        {
            get => _device;
            set
            {
                _device = value;
                OnPropertyChanged(nameof(Device));
            }
        }        /// <summary>
        /// Procedure
        /// </summary>
        /// <remarks>
        /// <para>
        /// Procedure 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Procedure
        {
            get => _procedure;
            set
            {
                _procedure = value;
                OnPropertyChanged(nameof(Procedure));
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
        /// Fastingstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Fastingstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public SpecimenCollectionFastingStatusChoice? Fastingstatus
        {
            get => _fastingstatus;
            set
            {
                _fastingstatus = value;
                OnPropertyChanged(nameof(Fastingstatus));
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
        /// Method
        /// </summary>
        /// <remarks>
        /// <para>
        /// Method 的詳細描述。
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
        }        /// <summary>
        /// Additive
        /// </summary>
        /// <remarks>
        /// <para>
        /// Additive 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Additive
        {
            get => _additive;
            set
            {
                _additive = value;
                OnPropertyChanged(nameof(Additive));
            }
        }        /// <summary>
        /// Time
        /// </summary>
        /// <remarks>
        /// <para>
        /// Time 的詳細描述。
        /// </para>
        /// </remarks>
        public SpecimenProcessingTimeChoice? Time
        {
            get => _time;
            set
            {
                _time = value;
                OnPropertyChanged(nameof(Time));
            }
        }        /// <summary>
        /// Device
        /// </summary>
        /// <remarks>
        /// <para>
        /// Device 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Device
        {
            get => _device;
            set
            {
                _device = value;
                OnPropertyChanged(nameof(Device));
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
        /// Specimenquantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Specimenquantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Specimenquantity
        {
            get => _specimenquantity;
            set
            {
                _specimenquantity = value;
                OnPropertyChanged(nameof(Specimenquantity));
            }
        }        /// <summary>
        /// 建立新的 Specimen 資源實例
        /// </summary>
        public Specimen()
        {
        }

        /// <summary>
        /// 建立新的 Specimen 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Specimen(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Specimen(Id: {Id})";
        }
    }    /// <summary>
    /// SpecimenFeature 背骨元素
    /// </summary>
    public class SpecimenFeature
    {
        // TODO: 添加屬性實作
        
        public SpecimenFeature() { }
    }    /// <summary>
    /// SpecimenCollection 背骨元素
    /// </summary>
    public class SpecimenCollection
    {
        // TODO: 添加屬性實作
        
        public SpecimenCollection() { }
    }    /// <summary>
    /// SpecimenProcessing 背骨元素
    /// </summary>
    public class SpecimenProcessing
    {
        // TODO: 添加屬性實作
        
        public SpecimenProcessing() { }
    }    /// <summary>
    /// SpecimenContainer 背骨元素
    /// </summary>
    public class SpecimenContainer
    {
        // TODO: 添加屬性實作
        
        public SpecimenContainer() { }
    }    /// <summary>
    /// SpecimenCollectionCollectedChoice 選擇類型
    /// </summary>
    public class SpecimenCollectionCollectedChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public SpecimenCollectionCollectedChoice(JsonObject value) : base("specimencollectioncollected", value, _supportType) { }
        public SpecimenCollectionCollectedChoice(IComplexType? value) : base("specimencollectioncollected", value) { }
        public SpecimenCollectionCollectedChoice(IPrimitiveType? value) : base("specimencollectioncollected", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "SpecimenCollectionCollected" : "specimencollectioncollected";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// SpecimenCollectionFastingStatusChoice 選擇類型
    /// </summary>
    public class SpecimenCollectionFastingStatusChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public SpecimenCollectionFastingStatusChoice(JsonObject value) : base("specimencollectionfastingstatus", value, _supportType) { }
        public SpecimenCollectionFastingStatusChoice(IComplexType? value) : base("specimencollectionfastingstatus", value) { }
        public SpecimenCollectionFastingStatusChoice(IPrimitiveType? value) : base("specimencollectionfastingstatus", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "SpecimenCollectionFastingStatus" : "specimencollectionfastingstatus";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// SpecimenProcessingTimeChoice 選擇類型
    /// </summary>
    public class SpecimenProcessingTimeChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public SpecimenProcessingTimeChoice(JsonObject value) : base("specimenprocessingtime", value, _supportType) { }
        public SpecimenProcessingTimeChoice(IComplexType? value) : base("specimenprocessingtime", value) { }
        public SpecimenProcessingTimeChoice(IPrimitiveType? value) : base("specimenprocessingtime", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "SpecimenProcessingTime" : "specimenprocessingtime";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
