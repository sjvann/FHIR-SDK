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
    /// FHIR R5 Composition 資源
    /// 
    /// <para>
    /// Composition 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var composition = new Composition("composition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Composition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Composition : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private FhirCode? _status;
        private CodeableConcept? _type;
        private List<CodeableConcept>? _category;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private FhirDateTime? _date;
        private List<UsageContext>? _usecontext;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _author;
        private FhirString? _name;
        private FhirString? _title;
        private List<Annotation>? _note;
        private List<CompositionAttester>? _attester;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _custodian;
        private List<RelatedArtifact>? _relatesto;
        private List<CompositionEvent>? _event;
        private List<CompositionSection>? _section;
        private CodeableConcept? _mode;
        private FhirDateTime? _time;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _party;
        private Period? _period;
        private List<CodeableReference>? _detail;
        private FhirString? _title;
        private CodeableConcept? _code;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _author;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _focus;
        private CodeableConcept? _orderedby;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _entry;
        private CodeableConcept? _emptyreason;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Composition";        /// <summary>
        /// Url
        /// </summary>
        /// <remarks>
        /// <para>
        /// Url 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private FhirUri? Url
        {
            get => _url;
            set
            {
                _url = value;
                OnPropertyChanged(nameof(Url));
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
        /// Version
        /// </summary>
        /// <remarks>
        /// <para>
        /// Version 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Version
        {
            get => _version;
            set
            {
                _version = value;
                OnPropertyChanged(nameof(Version));
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
        /// Subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Subject
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
        /// Usecontext
        /// </summary>
        /// <remarks>
        /// <para>
        /// Usecontext 的詳細描述。
        /// </para>
        /// </remarks>
        public List<UsageContext>? Usecontext
        {
            get => _usecontext;
            set
            {
                _usecontext = value;
                OnPropertyChanged(nameof(Usecontext));
            }
        }        /// <summary>
        /// Author
        /// </summary>
        /// <remarks>
        /// <para>
        /// Author 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Author
        {
            get => _author;
            set
            {
                _author = value;
                OnPropertyChanged(nameof(Author));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
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
        /// Attester
        /// </summary>
        /// <remarks>
        /// <para>
        /// Attester 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CompositionAttester>? Attester
        {
            get => _attester;
            set
            {
                _attester = value;
                OnPropertyChanged(nameof(Attester));
            }
        }        /// <summary>
        /// Custodian
        /// </summary>
        /// <remarks>
        /// <para>
        /// Custodian 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Custodian
        {
            get => _custodian;
            set
            {
                _custodian = value;
                OnPropertyChanged(nameof(Custodian));
            }
        }        /// <summary>
        /// Relatesto
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relatesto 的詳細描述。
        /// </para>
        /// </remarks>
        public List<RelatedArtifact>? Relatesto
        {
            get => _relatesto;
            set
            {
                _relatesto = value;
                OnPropertyChanged(nameof(Relatesto));
            }
        }        /// <summary>
        /// Event
        /// </summary>
        /// <remarks>
        /// <para>
        /// Event 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CompositionEvent>? Event
        {
            get => _event;
            set
            {
                _event = value;
                OnPropertyChanged(nameof(Event));
            }
        }        /// <summary>
        /// Section
        /// </summary>
        /// <remarks>
        /// <para>
        /// Section 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CompositionSection>? Section
        {
            get => _section;
            set
            {
                _section = value;
                OnPropertyChanged(nameof(Section));
            }
        }        /// <summary>
        /// Mode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Mode 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Mode
        {
            get => _mode;
            set
            {
                _mode = value;
                OnPropertyChanged(nameof(Mode));
            }
        }        /// <summary>
        /// Time
        /// </summary>
        /// <remarks>
        /// <para>
        /// Time 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Time
        {
            get => _time;
            set
            {
                _time = value;
                OnPropertyChanged(nameof(Time));
            }
        }        /// <summary>
        /// Party
        /// </summary>
        /// <remarks>
        /// <para>
        /// Party 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Party
        {
            get => _party;
            set
            {
                _party = value;
                OnPropertyChanged(nameof(Party));
            }
        }        /// <summary>
        /// Period
        /// </summary>
        /// <remarks>
        /// <para>
        /// Period 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Period
        {
            get => _period;
            set
            {
                _period = value;
                OnPropertyChanged(nameof(Period));
            }
        }        /// <summary>
        /// Detail
        /// </summary>
        /// <remarks>
        /// <para>
        /// Detail 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Detail
        {
            get => _detail;
            set
            {
                _detail = value;
                OnPropertyChanged(nameof(Detail));
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
        /// Author
        /// </summary>
        /// <remarks>
        /// <para>
        /// Author 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Author
        {
            get => _author;
            set
            {
                _author = value;
                OnPropertyChanged(nameof(Author));
            }
        }        /// <summary>
        /// Focus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Focus 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Focus
        {
            get => _focus;
            set
            {
                _focus = value;
                OnPropertyChanged(nameof(Focus));
            }
        }        /// <summary>
        /// Orderedby
        /// </summary>
        /// <remarks>
        /// <para>
        /// Orderedby 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Orderedby
        {
            get => _orderedby;
            set
            {
                _orderedby = value;
                OnPropertyChanged(nameof(Orderedby));
            }
        }        /// <summary>
        /// Entry
        /// </summary>
        /// <remarks>
        /// <para>
        /// Entry 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Entry
        {
            get => _entry;
            set
            {
                _entry = value;
                OnPropertyChanged(nameof(Entry));
            }
        }        /// <summary>
        /// Emptyreason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Emptyreason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Emptyreason
        {
            get => _emptyreason;
            set
            {
                _emptyreason = value;
                OnPropertyChanged(nameof(Emptyreason));
            }
        }        /// <summary>
        /// 建立新的 Composition 資源實例
        /// </summary>
        public Composition()
        {
        }

        /// <summary>
        /// 建立新的 Composition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Composition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Composition(Id: {Id})";
        }
    }    /// <summary>
    /// CompositionAttester 背骨元素
    /// </summary>
    public class CompositionAttester
    {
        // TODO: 添加屬性實作
        
        public CompositionAttester() { }
    }    /// <summary>
    /// CompositionEvent 背骨元素
    /// </summary>
    public class CompositionEvent
    {
        // TODO: 添加屬性實作
        
        public CompositionEvent() { }
    }    /// <summary>
    /// CompositionSection 背骨元素
    /// </summary>
    public class CompositionSection
    {
        // TODO: 添加屬性實作
        
        public CompositionSection() { }
    }
}
