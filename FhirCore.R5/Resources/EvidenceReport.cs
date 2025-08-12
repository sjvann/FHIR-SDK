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
    /// FHIR R5 EvidenceReport 資源
    /// 
    /// <para>
    /// EvidenceReport 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var evidencereport = new EvidenceReport("evidencereport-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 EvidenceReport 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class EvidenceReport : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private FhirCode? _status;
        private List<UsageContext>? _usecontext;
        private List<Identifier>? _identifier;
        private List<Identifier>? _relatedidentifier;
        private EvidenceReportCiteAsChoice? _citeas;
        private CodeableConcept? _type;
        private List<Annotation>? _note;
        private List<RelatedArtifact>? _relatedartifact;
        private EvidenceReportSubject? _subject;
        private FhirString? _publisher;
        private List<ContactDetail>? _contact;
        private List<ContactDetail>? _author;
        private List<ContactDetail>? _editor;
        private List<ContactDetail>? _reviewer;
        private List<ContactDetail>? _endorser;
        private List<EvidenceReportRelatesTo>? _relatesto;
        private List<EvidenceReportSection>? _section;
        private CodeableConcept? _code;
        private EvidenceReportSubjectCharacteristicValueChoice? _value;
        private FhirBoolean? _exclude;
        private Period? _period;
        private List<EvidenceReportSubjectCharacteristic>? _characteristic;
        private List<Annotation>? _note;
        private FhirUri? _url;
        private Identifier? _identifier;
        private FhirMarkdown? _display;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _resource;
        private FhirCode? _code;
        private EvidenceReportRelatesToTarget? _target;
        private FhirString? _title;
        private CodeableConcept? _focus;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _focusreference;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _author;
        private FhirCode? _mode;
        private CodeableConcept? _orderedby;
        private List<CodeableConcept>? _entryclassifier;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _entryreference;
        private List<Quantity>? _entryquantity;
        private CodeableConcept? _emptyreason;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "EvidenceReport";        /// <summary>
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
        /// Relatedidentifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relatedidentifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Relatedidentifier
        {
            get => _relatedidentifier;
            set
            {
                _relatedidentifier = value;
                OnPropertyChanged(nameof(Relatedidentifier));
            }
        }        /// <summary>
        /// Citeas
        /// </summary>
        /// <remarks>
        /// <para>
        /// Citeas 的詳細描述。
        /// </para>
        /// </remarks>
        public EvidenceReportCiteAsChoice? Citeas
        {
            get => _citeas;
            set
            {
                _citeas = value;
                OnPropertyChanged(nameof(Citeas));
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
        /// Relatedartifact
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relatedartifact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<RelatedArtifact>? Relatedartifact
        {
            get => _relatedartifact;
            set
            {
                _relatedartifact = value;
                OnPropertyChanged(nameof(Relatedartifact));
            }
        }        /// <summary>
        /// Subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject 的詳細描述。
        /// </para>
        /// </remarks>
        public EvidenceReportSubject? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }        /// <summary>
        /// Publisher
        /// </summary>
        /// <remarks>
        /// <para>
        /// Publisher 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Publisher
        {
            get => _publisher;
            set
            {
                _publisher = value;
                OnPropertyChanged(nameof(Publisher));
            }
        }        /// <summary>
        /// Contact
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactDetail>? Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }        /// <summary>
        /// Author
        /// </summary>
        /// <remarks>
        /// <para>
        /// Author 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactDetail>? Author
        {
            get => _author;
            set
            {
                _author = value;
                OnPropertyChanged(nameof(Author));
            }
        }        /// <summary>
        /// Editor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Editor 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactDetail>? Editor
        {
            get => _editor;
            set
            {
                _editor = value;
                OnPropertyChanged(nameof(Editor));
            }
        }        /// <summary>
        /// Reviewer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reviewer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactDetail>? Reviewer
        {
            get => _reviewer;
            set
            {
                _reviewer = value;
                OnPropertyChanged(nameof(Reviewer));
            }
        }        /// <summary>
        /// Endorser
        /// </summary>
        /// <remarks>
        /// <para>
        /// Endorser 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactDetail>? Endorser
        {
            get => _endorser;
            set
            {
                _endorser = value;
                OnPropertyChanged(nameof(Endorser));
            }
        }        /// <summary>
        /// Relatesto
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relatesto 的詳細描述。
        /// </para>
        /// </remarks>
        public List<EvidenceReportRelatesTo>? Relatesto
        {
            get => _relatesto;
            set
            {
                _relatesto = value;
                OnPropertyChanged(nameof(Relatesto));
            }
        }        /// <summary>
        /// Section
        /// </summary>
        /// <remarks>
        /// <para>
        /// Section 的詳細描述。
        /// </para>
        /// </remarks>
        public List<EvidenceReportSection>? Section
        {
            get => _section;
            set
            {
                _section = value;
                OnPropertyChanged(nameof(Section));
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
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public EvidenceReportSubjectCharacteristicValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Exclude
        /// </summary>
        /// <remarks>
        /// <para>
        /// Exclude 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Exclude
        {
            get => _exclude;
            set
            {
                _exclude = value;
                OnPropertyChanged(nameof(Exclude));
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
        /// Characteristic
        /// </summary>
        /// <remarks>
        /// <para>
        /// Characteristic 的詳細描述。
        /// </para>
        /// </remarks>
        public List<EvidenceReportSubjectCharacteristic>? Characteristic
        {
            get => _characteristic;
            set
            {
                _characteristic = value;
                OnPropertyChanged(nameof(Characteristic));
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
        /// Url
        /// </summary>
        /// <remarks>
        /// <para>
        /// Url 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Url
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
        public Identifier? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
            }
        }        /// <summary>
        /// Display
        /// </summary>
        /// <remarks>
        /// <para>
        /// Display 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Display
        {
            get => _display;
            set
            {
                _display = value;
                OnPropertyChanged(nameof(Display));
            }
        }        /// <summary>
        /// Resource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resource 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Resource
        {
            get => _resource;
            set
            {
                _resource = value;
                OnPropertyChanged(nameof(Resource));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Target
        /// </summary>
        /// <remarks>
        /// <para>
        /// Target 的詳細描述。
        /// </para>
        /// </remarks>
        public EvidenceReportRelatesToTarget? Target
        {
            get => _target;
            set
            {
                _target = value;
                OnPropertyChanged(nameof(Target));
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
        public CodeableConcept? Focus
        {
            get => _focus;
            set
            {
                _focus = value;
                OnPropertyChanged(nameof(Focus));
            }
        }        /// <summary>
        /// Focusreference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Focusreference 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Focusreference
        {
            get => _focusreference;
            set
            {
                _focusreference = value;
                OnPropertyChanged(nameof(Focusreference));
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
        /// Mode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Mode 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Mode
        {
            get => _mode;
            set
            {
                _mode = value;
                OnPropertyChanged(nameof(Mode));
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
        /// Entryclassifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Entryclassifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Entryclassifier
        {
            get => _entryclassifier;
            set
            {
                _entryclassifier = value;
                OnPropertyChanged(nameof(Entryclassifier));
            }
        }        /// <summary>
        /// Entryreference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Entryreference 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Entryreference
        {
            get => _entryreference;
            set
            {
                _entryreference = value;
                OnPropertyChanged(nameof(Entryreference));
            }
        }        /// <summary>
        /// Entryquantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Entryquantity 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Quantity>? Entryquantity
        {
            get => _entryquantity;
            set
            {
                _entryquantity = value;
                OnPropertyChanged(nameof(Entryquantity));
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
        /// 建立新的 EvidenceReport 資源實例
        /// </summary>
        public EvidenceReport()
        {
        }

        /// <summary>
        /// 建立新的 EvidenceReport 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public EvidenceReport(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"EvidenceReport(Id: {Id})";
        }
    }    /// <summary>
    /// EvidenceReportSubjectCharacteristic 背骨元素
    /// </summary>
    public class EvidenceReportSubjectCharacteristic
    {
        // TODO: 添加屬性實作
        
        public EvidenceReportSubjectCharacteristic() { }
    }    /// <summary>
    /// EvidenceReportSubject 背骨元素
    /// </summary>
    public class EvidenceReportSubject
    {
        // TODO: 添加屬性實作
        
        public EvidenceReportSubject() { }
    }    /// <summary>
    /// EvidenceReportRelatesToTarget 背骨元素
    /// </summary>
    public class EvidenceReportRelatesToTarget
    {
        // TODO: 添加屬性實作
        
        public EvidenceReportRelatesToTarget() { }
    }    /// <summary>
    /// EvidenceReportRelatesTo 背骨元素
    /// </summary>
    public class EvidenceReportRelatesTo
    {
        // TODO: 添加屬性實作
        
        public EvidenceReportRelatesTo() { }
    }    /// <summary>
    /// EvidenceReportSection 背骨元素
    /// </summary>
    public class EvidenceReportSection
    {
        // TODO: 添加屬性實作
        
        public EvidenceReportSection() { }
    }    /// <summary>
    /// EvidenceReportCiteAsChoice 選擇類型
    /// </summary>
    public class EvidenceReportCiteAsChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public EvidenceReportCiteAsChoice(JsonObject value) : base("evidencereportciteas", value, _supportType) { }
        public EvidenceReportCiteAsChoice(IComplexType? value) : base("evidencereportciteas", value) { }
        public EvidenceReportCiteAsChoice(IPrimitiveType? value) : base("evidencereportciteas", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "EvidenceReportCiteAs" : "evidencereportciteas";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// EvidenceReportSubjectCharacteristicValueChoice 選擇類型
    /// </summary>
    public class EvidenceReportSubjectCharacteristicValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public EvidenceReportSubjectCharacteristicValueChoice(JsonObject value) : base("evidencereportsubjectcharacteristicvalue", value, _supportType) { }
        public EvidenceReportSubjectCharacteristicValueChoice(IComplexType? value) : base("evidencereportsubjectcharacteristicvalue", value) { }
        public EvidenceReportSubjectCharacteristicValueChoice(IPrimitiveType? value) : base("evidencereportsubjectcharacteristicvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "EvidenceReportSubjectCharacteristicValue" : "evidencereportsubjectcharacteristicvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
