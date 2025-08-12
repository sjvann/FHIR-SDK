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
    /// FHIR R5 Requirements 資源
    /// 
    /// <para>
    /// Requirements 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var requirements = new Requirements("requirements-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Requirements 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Requirements : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private RequirementsVersionAlgorithmChoice? _versionalgorithm;
        private FhirString? _name;
        private FhirString? _title;
        private FhirCode? _status;
        private FhirBoolean? _experimental;
        private FhirDateTime? _date;
        private FhirString? _publisher;
        private List<ContactDetail>? _contact;
        private FhirMarkdown? _description;
        private List<UsageContext>? _usecontext;
        private List<CodeableConcept>? _jurisdiction;
        private FhirMarkdown? _purpose;
        private FhirMarkdown? _copyright;
        private FhirString? _copyrightlabel;
        private List<FhirCanonical>? _derivedfrom;
        private List<FhirUrl>? _reference;
        private List<FhirCanonical>? _actor;
        private List<RequirementsStatement>? _statement;
        private FhirId? _key;
        private FhirString? _label;
        private List<FhirCode>? _conformance;
        private FhirBoolean? _conditionality;
        private FhirMarkdown? _requirement;
        private FhirString? _derivedfrom;
        private FhirString? _parent;
        private List<FhirUrl>? _satisfiedby;
        private List<FhirUrl>? _reference;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _source;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Requirements";        /// <summary>
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
        /// Versionalgorithm
        /// </summary>
        /// <remarks>
        /// <para>
        /// Versionalgorithm 的詳細描述。
        /// </para>
        /// </remarks>
        public RequirementsVersionAlgorithmChoice? Versionalgorithm
        {
            get => _versionalgorithm;
            set
            {
                _versionalgorithm = value;
                OnPropertyChanged(nameof(Versionalgorithm));
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
        /// Experimental
        /// </summary>
        /// <remarks>
        /// <para>
        /// Experimental 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Experimental
        {
            get => _experimental;
            set
            {
                _experimental = value;
                OnPropertyChanged(nameof(Experimental));
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
        /// Jurisdiction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Jurisdiction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Jurisdiction
        {
            get => _jurisdiction;
            set
            {
                _jurisdiction = value;
                OnPropertyChanged(nameof(Jurisdiction));
            }
        }        /// <summary>
        /// Purpose
        /// </summary>
        /// <remarks>
        /// <para>
        /// Purpose 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Purpose
        {
            get => _purpose;
            set
            {
                _purpose = value;
                OnPropertyChanged(nameof(Purpose));
            }
        }        /// <summary>
        /// Copyright
        /// </summary>
        /// <remarks>
        /// <para>
        /// Copyright 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Copyright
        {
            get => _copyright;
            set
            {
                _copyright = value;
                OnPropertyChanged(nameof(Copyright));
            }
        }        /// <summary>
        /// Copyrightlabel
        /// </summary>
        /// <remarks>
        /// <para>
        /// Copyrightlabel 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Copyrightlabel
        {
            get => _copyrightlabel;
            set
            {
                _copyrightlabel = value;
                OnPropertyChanged(nameof(Copyrightlabel));
            }
        }        /// <summary>
        /// Derivedfrom
        /// </summary>
        /// <remarks>
        /// <para>
        /// Derivedfrom 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Derivedfrom
        {
            get => _derivedfrom;
            set
            {
                _derivedfrom = value;
                OnPropertyChanged(nameof(Derivedfrom));
            }
        }        /// <summary>
        /// Reference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reference 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUrl>? Reference
        {
            get => _reference;
            set
            {
                _reference = value;
                OnPropertyChanged(nameof(Reference));
            }
        }        /// <summary>
        /// Actor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Actor 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Actor
        {
            get => _actor;
            set
            {
                _actor = value;
                OnPropertyChanged(nameof(Actor));
            }
        }        /// <summary>
        /// Statement
        /// </summary>
        /// <remarks>
        /// <para>
        /// Statement 的詳細描述。
        /// </para>
        /// </remarks>
        public List<RequirementsStatement>? Statement
        {
            get => _statement;
            set
            {
                _statement = value;
                OnPropertyChanged(nameof(Statement));
            }
        }        /// <summary>
        /// Key
        /// </summary>
        /// <remarks>
        /// <para>
        /// Key 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Key
        {
            get => _key;
            set
            {
                _key = value;
                OnPropertyChanged(nameof(Key));
            }
        }        /// <summary>
        /// Label
        /// </summary>
        /// <remarks>
        /// <para>
        /// Label 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Label
        {
            get => _label;
            set
            {
                _label = value;
                OnPropertyChanged(nameof(Label));
            }
        }        /// <summary>
        /// Conformance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Conformance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Conformance
        {
            get => _conformance;
            set
            {
                _conformance = value;
                OnPropertyChanged(nameof(Conformance));
            }
        }        /// <summary>
        /// Conditionality
        /// </summary>
        /// <remarks>
        /// <para>
        /// Conditionality 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Conditionality
        {
            get => _conditionality;
            set
            {
                _conditionality = value;
                OnPropertyChanged(nameof(Conditionality));
            }
        }        /// <summary>
        /// Requirement
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requirement 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Requirement
        {
            get => _requirement;
            set
            {
                _requirement = value;
                OnPropertyChanged(nameof(Requirement));
            }
        }        /// <summary>
        /// Derivedfrom
        /// </summary>
        /// <remarks>
        /// <para>
        /// Derivedfrom 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Derivedfrom
        {
            get => _derivedfrom;
            set
            {
                _derivedfrom = value;
                OnPropertyChanged(nameof(Derivedfrom));
            }
        }        /// <summary>
        /// Parent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Parent 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Parent
        {
            get => _parent;
            set
            {
                _parent = value;
                OnPropertyChanged(nameof(Parent));
            }
        }        /// <summary>
        /// Satisfiedby
        /// </summary>
        /// <remarks>
        /// <para>
        /// Satisfiedby 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUrl>? Satisfiedby
        {
            get => _satisfiedby;
            set
            {
                _satisfiedby = value;
                OnPropertyChanged(nameof(Satisfiedby));
            }
        }        /// <summary>
        /// Reference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reference 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUrl>? Reference
        {
            get => _reference;
            set
            {
                _reference = value;
                OnPropertyChanged(nameof(Reference));
            }
        }        /// <summary>
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
            }
        }        /// <summary>
        /// 建立新的 Requirements 資源實例
        /// </summary>
        public Requirements()
        {
        }

        /// <summary>
        /// 建立新的 Requirements 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Requirements(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Requirements(Id: {Id})";
        }
    }    /// <summary>
    /// RequirementsStatement 背骨元素
    /// </summary>
    public class RequirementsStatement
    {
        // TODO: 添加屬性實作
        
        public RequirementsStatement() { }
    }    /// <summary>
    /// RequirementsVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class RequirementsVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public RequirementsVersionAlgorithmChoice(JsonObject value) : base("requirementsversionalgorithm", value, _supportType) { }
        public RequirementsVersionAlgorithmChoice(IComplexType? value) : base("requirementsversionalgorithm", value) { }
        public RequirementsVersionAlgorithmChoice(IPrimitiveType? value) : base("requirementsversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "RequirementsVersionAlgorithm" : "requirementsversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
