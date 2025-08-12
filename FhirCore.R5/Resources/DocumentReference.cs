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
    /// FHIR R5 DocumentReference 資源
    /// 
    /// <para>
    /// DocumentReference 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var documentreference = new DocumentReference("documentreference-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 DocumentReference 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class DocumentReference : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirString? _version;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private FhirCode? _status;
        private FhirCode? _docstatus;
        private List<CodeableConcept>? _modality;
        private CodeableConcept? _type;
        private List<CodeableConcept>? _category;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _context;
        private List<CodeableReference>? _event;
        private List<CodeableReference>? _bodysite;
        private CodeableConcept? _facilitytype;
        private CodeableConcept? _practicesetting;
        private Period? _period;
        private FhirInstant? _date;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _author;
        private List<DocumentReferenceAttester>? _attester;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _custodian;
        private List<DocumentReferenceRelatesTo>? _relatesto;
        private FhirMarkdown? _description;
        private List<CodeableConcept>? _securitylabel;
        private List<DocumentReferenceContent>? _content;
        private CodeableConcept? _mode;
        private FhirDateTime? _time;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _party;
        private CodeableConcept? _code;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _target;
        private DocumentReferenceContentProfileValueChoice? _value;
        private Attachment? _attachment;
        private List<DocumentReferenceContentProfile>? _profile;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "DocumentReference";        /// <summary>
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
        /// Docstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Docstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Docstatus
        {
            get => _docstatus;
            set
            {
                _docstatus = value;
                OnPropertyChanged(nameof(Docstatus));
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
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }        /// <summary>
        /// Context
        /// </summary>
        /// <remarks>
        /// <para>
        /// Context 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Context
        {
            get => _context;
            set
            {
                _context = value;
                OnPropertyChanged(nameof(Context));
            }
        }        /// <summary>
        /// Event
        /// </summary>
        /// <remarks>
        /// <para>
        /// Event 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Event
        {
            get => _event;
            set
            {
                _event = value;
                OnPropertyChanged(nameof(Event));
            }
        }        /// <summary>
        /// Bodysite
        /// </summary>
        /// <remarks>
        /// <para>
        /// Bodysite 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Bodysite
        {
            get => _bodysite;
            set
            {
                _bodysite = value;
                OnPropertyChanged(nameof(Bodysite));
            }
        }        /// <summary>
        /// Facilitytype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Facilitytype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Facilitytype
        {
            get => _facilitytype;
            set
            {
                _facilitytype = value;
                OnPropertyChanged(nameof(Facilitytype));
            }
        }        /// <summary>
        /// Practicesetting
        /// </summary>
        /// <remarks>
        /// <para>
        /// Practicesetting 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Practicesetting
        {
            get => _practicesetting;
            set
            {
                _practicesetting = value;
                OnPropertyChanged(nameof(Practicesetting));
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
        /// Date
        /// </summary>
        /// <remarks>
        /// <para>
        /// Date 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInstant? Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
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
        /// Attester
        /// </summary>
        /// <remarks>
        /// <para>
        /// Attester 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DocumentReferenceAttester>? Attester
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
        public List<DocumentReferenceRelatesTo>? Relatesto
        {
            get => _relatesto;
            set
            {
                _relatesto = value;
                OnPropertyChanged(nameof(Relatesto));
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
        /// Securitylabel
        /// </summary>
        /// <remarks>
        /// <para>
        /// Securitylabel 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Securitylabel
        {
            get => _securitylabel;
            set
            {
                _securitylabel = value;
                OnPropertyChanged(nameof(Securitylabel));
            }
        }        /// <summary>
        /// Content
        /// </summary>
        /// <remarks>
        /// <para>
        /// Content 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DocumentReferenceContent>? Content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged(nameof(Content));
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
        /// Target
        /// </summary>
        /// <remarks>
        /// <para>
        /// Target 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Target
        {
            get => _target;
            set
            {
                _target = value;
                OnPropertyChanged(nameof(Target));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public DocumentReferenceContentProfileValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Attachment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Attachment 的詳細描述。
        /// </para>
        /// </remarks>
        public Attachment? Attachment
        {
            get => _attachment;
            set
            {
                _attachment = value;
                OnPropertyChanged(nameof(Attachment));
            }
        }        /// <summary>
        /// Profile
        /// </summary>
        /// <remarks>
        /// <para>
        /// Profile 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DocumentReferenceContentProfile>? Profile
        {
            get => _profile;
            set
            {
                _profile = value;
                OnPropertyChanged(nameof(Profile));
            }
        }        /// <summary>
        /// 建立新的 DocumentReference 資源實例
        /// </summary>
        public DocumentReference()
        {
        }

        /// <summary>
        /// 建立新的 DocumentReference 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public DocumentReference(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"DocumentReference(Id: {Id})";
        }
    }    /// <summary>
    /// DocumentReferenceAttester 背骨元素
    /// </summary>
    public class DocumentReferenceAttester
    {
        // TODO: 添加屬性實作
        
        public DocumentReferenceAttester() { }
    }    /// <summary>
    /// DocumentReferenceRelatesTo 背骨元素
    /// </summary>
    public class DocumentReferenceRelatesTo
    {
        // TODO: 添加屬性實作
        
        public DocumentReferenceRelatesTo() { }
    }    /// <summary>
    /// DocumentReferenceContentProfile 背骨元素
    /// </summary>
    public class DocumentReferenceContentProfile
    {
        // TODO: 添加屬性實作
        
        public DocumentReferenceContentProfile() { }
    }    /// <summary>
    /// DocumentReferenceContent 背骨元素
    /// </summary>
    public class DocumentReferenceContent
    {
        // TODO: 添加屬性實作
        
        public DocumentReferenceContent() { }
    }    /// <summary>
    /// DocumentReferenceContentProfileValueChoice 選擇類型
    /// </summary>
    public class DocumentReferenceContentProfileValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public DocumentReferenceContentProfileValueChoice(JsonObject value) : base("documentreferencecontentprofilevalue", value, _supportType) { }
        public DocumentReferenceContentProfileValueChoice(IComplexType? value) : base("documentreferencecontentprofilevalue", value) { }
        public DocumentReferenceContentProfileValueChoice(IPrimitiveType? value) : base("documentreferencecontentprofilevalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "DocumentReferenceContentProfileValue" : "documentreferencecontentprofilevalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
