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
    /// FHIR R5 OperationDefinition 資源
    /// 
    /// <para>
    /// OperationDefinition 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var operationdefinition = new OperationDefinition("operationdefinition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 OperationDefinition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class OperationDefinition : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private OperationDefinitionVersionAlgorithmChoice? _versionalgorithm;
        private FhirString? _name;
        private FhirString? _title;
        private FhirCode? _status;
        private FhirCode? _kind;
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
        private FhirBoolean? _affectsstate;
        private FhirCode? _code;
        private FhirMarkdown? _comment;
        private FhirCanonical? _base;
        private List<FhirCode>? _resource;
        private FhirBoolean? _system;
        private FhirBoolean? _type;
        private FhirBoolean? _instance;
        private FhirCanonical? _inputprofile;
        private FhirCanonical? _outputprofile;
        private List<OperationDefinitionParameter>? _parameter;
        private List<OperationDefinitionOverload>? _overload;
        private FhirCode? _strength;
        private FhirCanonical? _valueset;
        private FhirString? _source;
        private FhirString? _sourceid;
        private FhirCode? _name;
        private FhirCode? _use;
        private List<FhirCode>? _scope;
        private FhirInteger? _min;
        private FhirString? _max;
        private FhirMarkdown? _documentation;
        private FhirCode? _type;
        private List<FhirCode>? _allowedtype;
        private List<FhirCanonical>? _targetprofile;
        private FhirCode? _searchtype;
        private OperationDefinitionParameterBinding? _binding;
        private List<OperationDefinitionParameterReferencedFrom>? _referencedfrom;
        private List<FhirString>? _parametername;
        private FhirString? _comment;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "OperationDefinition";        /// <summary>
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
        public OperationDefinitionVersionAlgorithmChoice? Versionalgorithm
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
        /// Kind
        /// </summary>
        /// <remarks>
        /// <para>
        /// Kind 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Kind
        {
            get => _kind;
            set
            {
                _kind = value;
                OnPropertyChanged(nameof(Kind));
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
        /// Affectsstate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Affectsstate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Affectsstate
        {
            get => _affectsstate;
            set
            {
                _affectsstate = value;
                OnPropertyChanged(nameof(Affectsstate));
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
        /// Comment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Comment 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Comment
        {
            get => _comment;
            set
            {
                _comment = value;
                OnPropertyChanged(nameof(Comment));
            }
        }        /// <summary>
        /// Base
        /// </summary>
        /// <remarks>
        /// <para>
        /// Base 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Base
        {
            get => _base;
            set
            {
                _base = value;
                OnPropertyChanged(nameof(Base));
            }
        }        /// <summary>
        /// Resource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resource 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Resource
        {
            get => _resource;
            set
            {
                _resource = value;
                OnPropertyChanged(nameof(Resource));
            }
        }        /// <summary>
        /// System
        /// </summary>
        /// <remarks>
        /// <para>
        /// System 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? System
        {
            get => _system;
            set
            {
                _system = value;
                OnPropertyChanged(nameof(System));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Instance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instance 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Instance
        {
            get => _instance;
            set
            {
                _instance = value;
                OnPropertyChanged(nameof(Instance));
            }
        }        /// <summary>
        /// Inputprofile
        /// </summary>
        /// <remarks>
        /// <para>
        /// Inputprofile 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Inputprofile
        {
            get => _inputprofile;
            set
            {
                _inputprofile = value;
                OnPropertyChanged(nameof(Inputprofile));
            }
        }        /// <summary>
        /// Outputprofile
        /// </summary>
        /// <remarks>
        /// <para>
        /// Outputprofile 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Outputprofile
        {
            get => _outputprofile;
            set
            {
                _outputprofile = value;
                OnPropertyChanged(nameof(Outputprofile));
            }
        }        /// <summary>
        /// Parameter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Parameter 的詳細描述。
        /// </para>
        /// </remarks>
        public List<OperationDefinitionParameter>? Parameter
        {
            get => _parameter;
            set
            {
                _parameter = value;
                OnPropertyChanged(nameof(Parameter));
            }
        }        /// <summary>
        /// Overload
        /// </summary>
        /// <remarks>
        /// <para>
        /// Overload 的詳細描述。
        /// </para>
        /// </remarks>
        public List<OperationDefinitionOverload>? Overload
        {
            get => _overload;
            set
            {
                _overload = value;
                OnPropertyChanged(nameof(Overload));
            }
        }        /// <summary>
        /// Strength
        /// </summary>
        /// <remarks>
        /// <para>
        /// Strength 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Strength
        {
            get => _strength;
            set
            {
                _strength = value;
                OnPropertyChanged(nameof(Strength));
            }
        }        /// <summary>
        /// Valueset
        /// </summary>
        /// <remarks>
        /// <para>
        /// Valueset 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Valueset
        {
            get => _valueset;
            set
            {
                _valueset = value;
                OnPropertyChanged(nameof(Valueset));
            }
        }        /// <summary>
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
            }
        }        /// <summary>
        /// Sourceid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sourceid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Sourceid
        {
            get => _sourceid;
            set
            {
                _sourceid = value;
                OnPropertyChanged(nameof(Sourceid));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Use
        /// </summary>
        /// <remarks>
        /// <para>
        /// Use 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Use
        {
            get => _use;
            set
            {
                _use = value;
                OnPropertyChanged(nameof(Use));
            }
        }        /// <summary>
        /// Scope
        /// </summary>
        /// <remarks>
        /// <para>
        /// Scope 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Scope
        {
            get => _scope;
            set
            {
                _scope = value;
                OnPropertyChanged(nameof(Scope));
            }
        }        /// <summary>
        /// Min
        /// </summary>
        /// <remarks>
        /// <para>
        /// Min 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Min
        {
            get => _min;
            set
            {
                _min = value;
                OnPropertyChanged(nameof(Min));
            }
        }        /// <summary>
        /// Max
        /// </summary>
        /// <remarks>
        /// <para>
        /// Max 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Max
        {
            get => _max;
            set
            {
                _max = value;
                OnPropertyChanged(nameof(Max));
            }
        }        /// <summary>
        /// Documentation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Documentation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Documentation
        {
            get => _documentation;
            set
            {
                _documentation = value;
                OnPropertyChanged(nameof(Documentation));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Allowedtype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Allowedtype 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Allowedtype
        {
            get => _allowedtype;
            set
            {
                _allowedtype = value;
                OnPropertyChanged(nameof(Allowedtype));
            }
        }        /// <summary>
        /// Targetprofile
        /// </summary>
        /// <remarks>
        /// <para>
        /// Targetprofile 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Targetprofile
        {
            get => _targetprofile;
            set
            {
                _targetprofile = value;
                OnPropertyChanged(nameof(Targetprofile));
            }
        }        /// <summary>
        /// Searchtype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Searchtype 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Searchtype
        {
            get => _searchtype;
            set
            {
                _searchtype = value;
                OnPropertyChanged(nameof(Searchtype));
            }
        }        /// <summary>
        /// Binding
        /// </summary>
        /// <remarks>
        /// <para>
        /// Binding 的詳細描述。
        /// </para>
        /// </remarks>
        public OperationDefinitionParameterBinding? Binding
        {
            get => _binding;
            set
            {
                _binding = value;
                OnPropertyChanged(nameof(Binding));
            }
        }        /// <summary>
        /// Referencedfrom
        /// </summary>
        /// <remarks>
        /// <para>
        /// Referencedfrom 的詳細描述。
        /// </para>
        /// </remarks>
        public List<OperationDefinitionParameterReferencedFrom>? Referencedfrom
        {
            get => _referencedfrom;
            set
            {
                _referencedfrom = value;
                OnPropertyChanged(nameof(Referencedfrom));
            }
        }        /// <summary>
        /// Parametername
        /// </summary>
        /// <remarks>
        /// <para>
        /// Parametername 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Parametername
        {
            get => _parametername;
            set
            {
                _parametername = value;
                OnPropertyChanged(nameof(Parametername));
            }
        }        /// <summary>
        /// Comment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Comment 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Comment
        {
            get => _comment;
            set
            {
                _comment = value;
                OnPropertyChanged(nameof(Comment));
            }
        }        /// <summary>
        /// 建立新的 OperationDefinition 資源實例
        /// </summary>
        public OperationDefinition()
        {
        }

        /// <summary>
        /// 建立新的 OperationDefinition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public OperationDefinition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"OperationDefinition(Id: {Id})";
        }
    }    /// <summary>
    /// OperationDefinitionParameterBinding 背骨元素
    /// </summary>
    public class OperationDefinitionParameterBinding
    {
        // TODO: 添加屬性實作
        
        public OperationDefinitionParameterBinding() { }
    }    /// <summary>
    /// OperationDefinitionParameterReferencedFrom 背骨元素
    /// </summary>
    public class OperationDefinitionParameterReferencedFrom
    {
        // TODO: 添加屬性實作
        
        public OperationDefinitionParameterReferencedFrom() { }
    }    /// <summary>
    /// OperationDefinitionParameter 背骨元素
    /// </summary>
    public class OperationDefinitionParameter
    {
        // TODO: 添加屬性實作
        
        public OperationDefinitionParameter() { }
    }    /// <summary>
    /// OperationDefinitionOverload 背骨元素
    /// </summary>
    public class OperationDefinitionOverload
    {
        // TODO: 添加屬性實作
        
        public OperationDefinitionOverload() { }
    }    /// <summary>
    /// OperationDefinitionVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class OperationDefinitionVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public OperationDefinitionVersionAlgorithmChoice(JsonObject value) : base("operationdefinitionversionalgorithm", value, _supportType) { }
        public OperationDefinitionVersionAlgorithmChoice(IComplexType? value) : base("operationdefinitionversionalgorithm", value) { }
        public OperationDefinitionVersionAlgorithmChoice(IPrimitiveType? value) : base("operationdefinitionversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "OperationDefinitionVersionAlgorithm" : "operationdefinitionversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
