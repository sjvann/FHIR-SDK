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
    /// FHIR R5 GraphDefinition 資源
    /// 
    /// <para>
    /// GraphDefinition 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var graphdefinition = new GraphDefinition("graphdefinition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 GraphDefinition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class GraphDefinition : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private GraphDefinitionVersionAlgorithmChoice? _versionalgorithm;
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
        private FhirId? _start;
        private List<GraphDefinitionNode>? _node;
        private List<GraphDefinitionLink>? _link;
        private FhirId? _nodeid;
        private FhirString? _description;
        private FhirCode? _type;
        private FhirCanonical? _profile;
        private FhirCode? _use;
        private FhirCode? _rule;
        private FhirCode? _code;
        private FhirString? _expression;
        private FhirString? _description;
        private FhirString? _description;
        private FhirInteger? _min;
        private FhirString? _max;
        private FhirId? _sourceid;
        private FhirString? _path;
        private FhirString? _slicename;
        private FhirId? _targetid;
        private FhirString? _params;
        private List<GraphDefinitionLinkCompartment>? _compartment;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "GraphDefinition";        /// <summary>
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
        public GraphDefinitionVersionAlgorithmChoice? Versionalgorithm
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
        /// Start
        /// </summary>
        /// <remarks>
        /// <para>
        /// Start 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Start
        {
            get => _start;
            set
            {
                _start = value;
                OnPropertyChanged(nameof(Start));
            }
        }        /// <summary>
        /// Node
        /// </summary>
        /// <remarks>
        /// <para>
        /// Node 的詳細描述。
        /// </para>
        /// </remarks>
        public List<GraphDefinitionNode>? Node
        {
            get => _node;
            set
            {
                _node = value;
                OnPropertyChanged(nameof(Node));
            }
        }        /// <summary>
        /// Link
        /// </summary>
        /// <remarks>
        /// <para>
        /// Link 的詳細描述。
        /// </para>
        /// </remarks>
        public List<GraphDefinitionLink>? Link
        {
            get => _link;
            set
            {
                _link = value;
                OnPropertyChanged(nameof(Link));
            }
        }        /// <summary>
        /// Nodeid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Nodeid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Nodeid
        {
            get => _nodeid;
            set
            {
                _nodeid = value;
                OnPropertyChanged(nameof(Nodeid));
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
        /// Profile
        /// </summary>
        /// <remarks>
        /// <para>
        /// Profile 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Profile
        {
            get => _profile;
            set
            {
                _profile = value;
                OnPropertyChanged(nameof(Profile));
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
        /// Rule
        /// </summary>
        /// <remarks>
        /// <para>
        /// Rule 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Rule
        {
            get => _rule;
            set
            {
                _rule = value;
                OnPropertyChanged(nameof(Rule));
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
        /// Sourceid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sourceid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Sourceid
        {
            get => _sourceid;
            set
            {
                _sourceid = value;
                OnPropertyChanged(nameof(Sourceid));
            }
        }        /// <summary>
        /// Path
        /// </summary>
        /// <remarks>
        /// <para>
        /// Path 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Path
        {
            get => _path;
            set
            {
                _path = value;
                OnPropertyChanged(nameof(Path));
            }
        }        /// <summary>
        /// Slicename
        /// </summary>
        /// <remarks>
        /// <para>
        /// Slicename 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Slicename
        {
            get => _slicename;
            set
            {
                _slicename = value;
                OnPropertyChanged(nameof(Slicename));
            }
        }        /// <summary>
        /// Targetid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Targetid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Targetid
        {
            get => _targetid;
            set
            {
                _targetid = value;
                OnPropertyChanged(nameof(Targetid));
            }
        }        /// <summary>
        /// Params
        /// </summary>
        /// <remarks>
        /// <para>
        /// Params 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Params
        {
            get => _params;
            set
            {
                _params = value;
                OnPropertyChanged(nameof(Params));
            }
        }        /// <summary>
        /// Compartment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Compartment 的詳細描述。
        /// </para>
        /// </remarks>
        public List<GraphDefinitionLinkCompartment>? Compartment
        {
            get => _compartment;
            set
            {
                _compartment = value;
                OnPropertyChanged(nameof(Compartment));
            }
        }        /// <summary>
        /// 建立新的 GraphDefinition 資源實例
        /// </summary>
        public GraphDefinition()
        {
        }

        /// <summary>
        /// 建立新的 GraphDefinition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public GraphDefinition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"GraphDefinition(Id: {Id})";
        }
    }    /// <summary>
    /// GraphDefinitionNode 背骨元素
    /// </summary>
    public class GraphDefinitionNode
    {
        // TODO: 添加屬性實作
        
        public GraphDefinitionNode() { }
    }    /// <summary>
    /// GraphDefinitionLinkCompartment 背骨元素
    /// </summary>
    public class GraphDefinitionLinkCompartment
    {
        // TODO: 添加屬性實作
        
        public GraphDefinitionLinkCompartment() { }
    }    /// <summary>
    /// GraphDefinitionLink 背骨元素
    /// </summary>
    public class GraphDefinitionLink
    {
        // TODO: 添加屬性實作
        
        public GraphDefinitionLink() { }
    }    /// <summary>
    /// GraphDefinitionVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class GraphDefinitionVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public GraphDefinitionVersionAlgorithmChoice(JsonObject value) : base("graphdefinitionversionalgorithm", value, _supportType) { }
        public GraphDefinitionVersionAlgorithmChoice(IComplexType? value) : base("graphdefinitionversionalgorithm", value) { }
        public GraphDefinitionVersionAlgorithmChoice(IPrimitiveType? value) : base("graphdefinitionversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "GraphDefinitionVersionAlgorithm" : "graphdefinitionversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
