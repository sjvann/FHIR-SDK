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
    /// FHIR R5 SearchParameter 資源
    /// 
    /// <para>
    /// SearchParameter 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var searchparameter = new SearchParameter("searchparameter-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 SearchParameter 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class SearchParameter : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private SearchParameterVersionAlgorithmChoice? _versionalgorithm;
        private FhirString? _name;
        private FhirString? _title;
        private FhirCanonical? _derivedfrom;
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
        private FhirCode? _code;
        private List<FhirCode>? _base;
        private FhirCode? _type;
        private FhirString? _expression;
        private FhirCode? _processingmode;
        private FhirString? _constraint;
        private List<FhirCode>? _target;
        private FhirBoolean? _multipleor;
        private FhirBoolean? _multipleand;
        private List<FhirCode>? _comparator;
        private List<FhirCode>? _modifier;
        private List<FhirString>? _chain;
        private List<SearchParameterComponent>? _component;
        private FhirCanonical? _definition;
        private FhirString? _expression;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "SearchParameter";        /// <summary>
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
        public SearchParameterVersionAlgorithmChoice? Versionalgorithm
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
        /// Derivedfrom
        /// </summary>
        /// <remarks>
        /// <para>
        /// Derivedfrom 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Derivedfrom
        {
            get => _derivedfrom;
            set
            {
                _derivedfrom = value;
                OnPropertyChanged(nameof(Derivedfrom));
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
        /// Base
        /// </summary>
        /// <remarks>
        /// <para>
        /// Base 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Base
        {
            get => _base;
            set
            {
                _base = value;
                OnPropertyChanged(nameof(Base));
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
        /// Expression
        /// </summary>
        /// <remarks>
        /// <para>
        /// Expression 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Expression
        {
            get => _expression;
            set
            {
                _expression = value;
                OnPropertyChanged(nameof(Expression));
            }
        }        /// <summary>
        /// Processingmode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Processingmode 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Processingmode
        {
            get => _processingmode;
            set
            {
                _processingmode = value;
                OnPropertyChanged(nameof(Processingmode));
            }
        }        /// <summary>
        /// Constraint
        /// </summary>
        /// <remarks>
        /// <para>
        /// Constraint 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Constraint
        {
            get => _constraint;
            set
            {
                _constraint = value;
                OnPropertyChanged(nameof(Constraint));
            }
        }        /// <summary>
        /// Target
        /// </summary>
        /// <remarks>
        /// <para>
        /// Target 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Target
        {
            get => _target;
            set
            {
                _target = value;
                OnPropertyChanged(nameof(Target));
            }
        }        /// <summary>
        /// Multipleor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Multipleor 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Multipleor
        {
            get => _multipleor;
            set
            {
                _multipleor = value;
                OnPropertyChanged(nameof(Multipleor));
            }
        }        /// <summary>
        /// Multipleand
        /// </summary>
        /// <remarks>
        /// <para>
        /// Multipleand 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Multipleand
        {
            get => _multipleand;
            set
            {
                _multipleand = value;
                OnPropertyChanged(nameof(Multipleand));
            }
        }        /// <summary>
        /// Comparator
        /// </summary>
        /// <remarks>
        /// <para>
        /// Comparator 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Comparator
        {
            get => _comparator;
            set
            {
                _comparator = value;
                OnPropertyChanged(nameof(Comparator));
            }
        }        /// <summary>
        /// Modifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Modifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Modifier
        {
            get => _modifier;
            set
            {
                _modifier = value;
                OnPropertyChanged(nameof(Modifier));
            }
        }        /// <summary>
        /// Chain
        /// </summary>
        /// <remarks>
        /// <para>
        /// Chain 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Chain
        {
            get => _chain;
            set
            {
                _chain = value;
                OnPropertyChanged(nameof(Chain));
            }
        }        /// <summary>
        /// Component
        /// </summary>
        /// <remarks>
        /// <para>
        /// Component 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SearchParameterComponent>? Component
        {
            get => _component;
            set
            {
                _component = value;
                OnPropertyChanged(nameof(Component));
            }
        }        /// <summary>
        /// Definition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definition 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Definition
        {
            get => _definition;
            set
            {
                _definition = value;
                OnPropertyChanged(nameof(Definition));
            }
        }        /// <summary>
        /// Expression
        /// </summary>
        /// <remarks>
        /// <para>
        /// Expression 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Expression
        {
            get => _expression;
            set
            {
                _expression = value;
                OnPropertyChanged(nameof(Expression));
            }
        }        /// <summary>
        /// 建立新的 SearchParameter 資源實例
        /// </summary>
        public SearchParameter()
        {
        }

        /// <summary>
        /// 建立新的 SearchParameter 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public SearchParameter(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"SearchParameter(Id: {Id})";
        }
    }    /// <summary>
    /// SearchParameterComponent 背骨元素
    /// </summary>
    public class SearchParameterComponent
    {
        // TODO: 添加屬性實作
        
        public SearchParameterComponent() { }
    }    /// <summary>
    /// SearchParameterVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class SearchParameterVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public SearchParameterVersionAlgorithmChoice(JsonObject value) : base("searchparameterversionalgorithm", value, _supportType) { }
        public SearchParameterVersionAlgorithmChoice(IComplexType? value) : base("searchparameterversionalgorithm", value) { }
        public SearchParameterVersionAlgorithmChoice(IPrimitiveType? value) : base("searchparameterversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "SearchParameterVersionAlgorithm" : "searchparameterversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
