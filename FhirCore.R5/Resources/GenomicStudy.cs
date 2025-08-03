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
    /// FHIR R5 GenomicStudy 資源
    /// 
    /// <para>
    /// GenomicStudy 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var genomicstudy = new GenomicStudy("genomicstudy-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 GenomicStudy 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class GenomicStudy : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private List<CodeableConcept>? _type;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private FhirDateTime? _startdate;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _referrer;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _interpreter;
        private List<CodeableReference>? _reason;
        private FhirCanonical? _instantiatescanonical;
        private FhirUri? _instantiatesuri;
        private List<Annotation>? _note;
        private FhirMarkdown? _description;
        private List<GenomicStudyAnalysis>? _analysis;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _file;
        private CodeableConcept? _type;
        private GenomicStudyAnalysisInputGeneratedByChoice? _generatedby;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _file;
        private CodeableConcept? _type;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _actor;
        private CodeableConcept? _role;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _device;
        private CodeableConcept? _function;
        private List<Identifier>? _identifier;
        private List<CodeableConcept>? _methodtype;
        private List<CodeableConcept>? _changetype;
        private CodeableConcept? _genomebuild;
        private FhirCanonical? _instantiatescanonical;
        private FhirUri? _instantiatesuri;
        private FhirString? _title;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _focus;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _specimen;
        private FhirDateTime? _date;
        private List<Annotation>? _note;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _protocolperformed;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _regionsstudied;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _regionscalled;
        private List<GenomicStudyAnalysisInput>? _input;
        private List<GenomicStudyAnalysisOutput>? _output;
        private List<GenomicStudyAnalysisPerformer>? _performer;
        private List<GenomicStudyAnalysisDevice>? _device;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "GenomicStudy";        /// <summary>
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
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
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
        /// Startdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Startdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Startdate
        {
            get => _startdate;
            set
            {
                _startdate = value;
                OnPropertyChanged(nameof(Startdate));
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
        /// Interpreter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Interpreter 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Interpreter
        {
            get => _interpreter;
            set
            {
                _interpreter = value;
                OnPropertyChanged(nameof(Interpreter));
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
        /// Instantiatescanonical
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instantiatescanonical 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Instantiatescanonical
        {
            get => _instantiatescanonical;
            set
            {
                _instantiatescanonical = value;
                OnPropertyChanged(nameof(Instantiatescanonical));
            }
        }        /// <summary>
        /// Instantiatesuri
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instantiatesuri 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Instantiatesuri
        {
            get => _instantiatesuri;
            set
            {
                _instantiatesuri = value;
                OnPropertyChanged(nameof(Instantiatesuri));
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
        public FhirMarkdown? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Analysis
        /// </summary>
        /// <remarks>
        /// <para>
        /// Analysis 的詳細描述。
        /// </para>
        /// </remarks>
        public List<GenomicStudyAnalysis>? Analysis
        {
            get => _analysis;
            set
            {
                _analysis = value;
                OnPropertyChanged(nameof(Analysis));
            }
        }        /// <summary>
        /// File
        /// </summary>
        /// <remarks>
        /// <para>
        /// File 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? File
        {
            get => _file;
            set
            {
                _file = value;
                OnPropertyChanged(nameof(File));
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
        /// Generatedby
        /// </summary>
        /// <remarks>
        /// <para>
        /// Generatedby 的詳細描述。
        /// </para>
        /// </remarks>
        public GenomicStudyAnalysisInputGeneratedByChoice? Generatedby
        {
            get => _generatedby;
            set
            {
                _generatedby = value;
                OnPropertyChanged(nameof(Generatedby));
            }
        }        /// <summary>
        /// File
        /// </summary>
        /// <remarks>
        /// <para>
        /// File 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? File
        {
            get => _file;
            set
            {
                _file = value;
                OnPropertyChanged(nameof(File));
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
        /// Role
        /// </summary>
        /// <remarks>
        /// <para>
        /// Role 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Role
        {
            get => _role;
            set
            {
                _role = value;
                OnPropertyChanged(nameof(Role));
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
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
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
        }        /// <summary>
        /// Methodtype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Methodtype 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Methodtype
        {
            get => _methodtype;
            set
            {
                _methodtype = value;
                OnPropertyChanged(nameof(Methodtype));
            }
        }        /// <summary>
        /// Changetype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Changetype 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Changetype
        {
            get => _changetype;
            set
            {
                _changetype = value;
                OnPropertyChanged(nameof(Changetype));
            }
        }        /// <summary>
        /// Genomebuild
        /// </summary>
        /// <remarks>
        /// <para>
        /// Genomebuild 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Genomebuild
        {
            get => _genomebuild;
            set
            {
                _genomebuild = value;
                OnPropertyChanged(nameof(Genomebuild));
            }
        }        /// <summary>
        /// Instantiatescanonical
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instantiatescanonical 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Instantiatescanonical
        {
            get => _instantiatescanonical;
            set
            {
                _instantiatescanonical = value;
                OnPropertyChanged(nameof(Instantiatescanonical));
            }
        }        /// <summary>
        /// Instantiatesuri
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instantiatesuri 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Instantiatesuri
        {
            get => _instantiatesuri;
            set
            {
                _instantiatesuri = value;
                OnPropertyChanged(nameof(Instantiatesuri));
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
        /// Protocolperformed
        /// </summary>
        /// <remarks>
        /// <para>
        /// Protocolperformed 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Protocolperformed
        {
            get => _protocolperformed;
            set
            {
                _protocolperformed = value;
                OnPropertyChanged(nameof(Protocolperformed));
            }
        }        /// <summary>
        /// Regionsstudied
        /// </summary>
        /// <remarks>
        /// <para>
        /// Regionsstudied 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Regionsstudied
        {
            get => _regionsstudied;
            set
            {
                _regionsstudied = value;
                OnPropertyChanged(nameof(Regionsstudied));
            }
        }        /// <summary>
        /// Regionscalled
        /// </summary>
        /// <remarks>
        /// <para>
        /// Regionscalled 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Regionscalled
        {
            get => _regionscalled;
            set
            {
                _regionscalled = value;
                OnPropertyChanged(nameof(Regionscalled));
            }
        }        /// <summary>
        /// Input
        /// </summary>
        /// <remarks>
        /// <para>
        /// Input 的詳細描述。
        /// </para>
        /// </remarks>
        public List<GenomicStudyAnalysisInput>? Input
        {
            get => _input;
            set
            {
                _input = value;
                OnPropertyChanged(nameof(Input));
            }
        }        /// <summary>
        /// Output
        /// </summary>
        /// <remarks>
        /// <para>
        /// Output 的詳細描述。
        /// </para>
        /// </remarks>
        public List<GenomicStudyAnalysisOutput>? Output
        {
            get => _output;
            set
            {
                _output = value;
                OnPropertyChanged(nameof(Output));
            }
        }        /// <summary>
        /// Performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<GenomicStudyAnalysisPerformer>? Performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(Performer));
            }
        }        /// <summary>
        /// Device
        /// </summary>
        /// <remarks>
        /// <para>
        /// Device 的詳細描述。
        /// </para>
        /// </remarks>
        public List<GenomicStudyAnalysisDevice>? Device
        {
            get => _device;
            set
            {
                _device = value;
                OnPropertyChanged(nameof(Device));
            }
        }        /// <summary>
        /// 建立新的 GenomicStudy 資源實例
        /// </summary>
        public GenomicStudy()
        {
        }

        /// <summary>
        /// 建立新的 GenomicStudy 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public GenomicStudy(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"GenomicStudy(Id: {Id})";
        }
    }    /// <summary>
    /// GenomicStudyAnalysisInput 背骨元素
    /// </summary>
    public class GenomicStudyAnalysisInput
    {
        // TODO: 添加屬性實作
        
        public GenomicStudyAnalysisInput() { }
    }    /// <summary>
    /// GenomicStudyAnalysisOutput 背骨元素
    /// </summary>
    public class GenomicStudyAnalysisOutput
    {
        // TODO: 添加屬性實作
        
        public GenomicStudyAnalysisOutput() { }
    }    /// <summary>
    /// GenomicStudyAnalysisPerformer 背骨元素
    /// </summary>
    public class GenomicStudyAnalysisPerformer
    {
        // TODO: 添加屬性實作
        
        public GenomicStudyAnalysisPerformer() { }
    }    /// <summary>
    /// GenomicStudyAnalysisDevice 背骨元素
    /// </summary>
    public class GenomicStudyAnalysisDevice
    {
        // TODO: 添加屬性實作
        
        public GenomicStudyAnalysisDevice() { }
    }    /// <summary>
    /// GenomicStudyAnalysis 背骨元素
    /// </summary>
    public class GenomicStudyAnalysis
    {
        // TODO: 添加屬性實作
        
        public GenomicStudyAnalysis() { }
    }    /// <summary>
    /// GenomicStudyAnalysisInputGeneratedByChoice 選擇類型
    /// </summary>
    public class GenomicStudyAnalysisInputGeneratedByChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public GenomicStudyAnalysisInputGeneratedByChoice(JsonObject value) : base("genomicstudyanalysisinputgeneratedby", value, _supportType) { }
        public GenomicStudyAnalysisInputGeneratedByChoice(IComplexType? value) : base("genomicstudyanalysisinputgeneratedby", value) { }
        public GenomicStudyAnalysisInputGeneratedByChoice(IPrimitiveType? value) : base("genomicstudyanalysisinputgeneratedby", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "GenomicStudyAnalysisInputGeneratedBy" : "genomicstudyanalysisinputgeneratedby";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
