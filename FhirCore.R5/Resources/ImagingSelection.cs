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
    /// FHIR R5 ImagingSelection 資源
    /// 
    /// <para>
    /// ImagingSelection 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var imagingselection = new ImagingSelection("imagingselection-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 ImagingSelection 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ImagingSelection : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private FhirInstant? _issued;
        private List<ImagingSelectionPerformer>? _performer;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private List<CodeableConcept>? _category;
        private CodeableConcept? _code;
        private FhirId? _studyuid;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _derivedfrom;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _endpoint;
        private FhirId? _seriesuid;
        private FhirUnsignedInt? _seriesnumber;
        private FhirId? _frameofreferenceuid;
        private CodeableReference? _bodysite;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _focus;
        private List<ImagingSelectionInstance>? _instance;
        private CodeableConcept? _function;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _actor;
        private FhirCode? _regiontype;
        private List<FhirDecimal>? _coordinate;
        private FhirCode? _regiontype;
        private List<FhirDecimal>? _coordinate;
        private FhirId? _uid;
        private FhirUnsignedInt? _number;
        private Coding? _sopclass;
        private List<FhirString>? _subset;
        private List<ImagingSelectionInstanceImageRegion2D>? _imageregion2d;
        private List<ImagingSelectionInstanceImageRegion3D>? _imageregion3d;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ImagingSelection";        /// <summary>
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
        /// Issued
        /// </summary>
        /// <remarks>
        /// <para>
        /// Issued 的詳細描述。
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
        }        /// <summary>
        /// Performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ImagingSelectionPerformer>? Performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(Performer));
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
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
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
        /// Studyuid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Studyuid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Studyuid
        {
            get => _studyuid;
            set
            {
                _studyuid = value;
                OnPropertyChanged(nameof(Studyuid));
            }
        }        /// <summary>
        /// Derivedfrom
        /// </summary>
        /// <remarks>
        /// <para>
        /// Derivedfrom 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Derivedfrom
        {
            get => _derivedfrom;
            set
            {
                _derivedfrom = value;
                OnPropertyChanged(nameof(Derivedfrom));
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
        /// Seriesuid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Seriesuid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Seriesuid
        {
            get => _seriesuid;
            set
            {
                _seriesuid = value;
                OnPropertyChanged(nameof(Seriesuid));
            }
        }        /// <summary>
        /// Seriesnumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Seriesnumber 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? Seriesnumber
        {
            get => _seriesnumber;
            set
            {
                _seriesnumber = value;
                OnPropertyChanged(nameof(Seriesnumber));
            }
        }        /// <summary>
        /// Frameofreferenceuid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Frameofreferenceuid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Frameofreferenceuid
        {
            get => _frameofreferenceuid;
            set
            {
                _frameofreferenceuid = value;
                OnPropertyChanged(nameof(Frameofreferenceuid));
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
        /// Focus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Focus 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Focus
        {
            get => _focus;
            set
            {
                _focus = value;
                OnPropertyChanged(nameof(Focus));
            }
        }        /// <summary>
        /// Instance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ImagingSelectionInstance>? Instance
        {
            get => _instance;
            set
            {
                _instance = value;
                OnPropertyChanged(nameof(Instance));
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
        /// Regiontype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Regiontype 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Regiontype
        {
            get => _regiontype;
            set
            {
                _regiontype = value;
                OnPropertyChanged(nameof(Regiontype));
            }
        }        /// <summary>
        /// Coordinate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Coordinate 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirDecimal>? Coordinate
        {
            get => _coordinate;
            set
            {
                _coordinate = value;
                OnPropertyChanged(nameof(Coordinate));
            }
        }        /// <summary>
        /// Regiontype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Regiontype 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Regiontype
        {
            get => _regiontype;
            set
            {
                _regiontype = value;
                OnPropertyChanged(nameof(Regiontype));
            }
        }        /// <summary>
        /// Coordinate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Coordinate 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirDecimal>? Coordinate
        {
            get => _coordinate;
            set
            {
                _coordinate = value;
                OnPropertyChanged(nameof(Coordinate));
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
        /// Subset
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subset 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Subset
        {
            get => _subset;
            set
            {
                _subset = value;
                OnPropertyChanged(nameof(Subset));
            }
        }        /// <summary>
        /// Imageregion2d
        /// </summary>
        /// <remarks>
        /// <para>
        /// Imageregion2d 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ImagingSelectionInstanceImageRegion2D>? Imageregion2d
        {
            get => _imageregion2d;
            set
            {
                _imageregion2d = value;
                OnPropertyChanged(nameof(Imageregion2d));
            }
        }        /// <summary>
        /// Imageregion3d
        /// </summary>
        /// <remarks>
        /// <para>
        /// Imageregion3d 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ImagingSelectionInstanceImageRegion3D>? Imageregion3d
        {
            get => _imageregion3d;
            set
            {
                _imageregion3d = value;
                OnPropertyChanged(nameof(Imageregion3d));
            }
        }        /// <summary>
        /// 建立新的 ImagingSelection 資源實例
        /// </summary>
        public ImagingSelection()
        {
        }

        /// <summary>
        /// 建立新的 ImagingSelection 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ImagingSelection(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ImagingSelection(Id: {Id})";
        }
    }    /// <summary>
    /// ImagingSelectionPerformer 背骨元素
    /// </summary>
    public class ImagingSelectionPerformer
    {
        // TODO: 添加屬性實作
        
        public ImagingSelectionPerformer() { }
    }    /// <summary>
    /// ImagingSelectionInstanceImageRegion2D 背骨元素
    /// </summary>
    public class ImagingSelectionInstanceImageRegion2D
    {
        // TODO: 添加屬性實作
        
        public ImagingSelectionInstanceImageRegion2D() { }
    }    /// <summary>
    /// ImagingSelectionInstanceImageRegion3D 背骨元素
    /// </summary>
    public class ImagingSelectionInstanceImageRegion3D
    {
        // TODO: 添加屬性實作
        
        public ImagingSelectionInstanceImageRegion3D() { }
    }    /// <summary>
    /// ImagingSelectionInstance 背骨元素
    /// </summary>
    public class ImagingSelectionInstance
    {
        // TODO: 添加屬性實作
        
        public ImagingSelectionInstance() { }
    }
}
