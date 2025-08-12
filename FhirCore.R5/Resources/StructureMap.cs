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
    /// FHIR R5 StructureMap 資源
    /// 
    /// <para>
    /// StructureMap 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var structuremap = new StructureMap("structuremap-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 StructureMap 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class StructureMap : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private StructureMapVersionAlgorithmChoice? _versionalgorithm;
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
        private List<StructureMapStructure>? _structure;
        private List<FhirCanonical>? _import;
        private List<StructureMapConst>? _const;
        private List<StructureMapGroup>? _group;
        private FhirCanonical? _url;
        private FhirCode? _mode;
        private FhirString? _alias;
        private FhirString? _documentation;
        private FhirId? _name;
        private FhirString? _value;
        private FhirId? _name;
        private FhirString? _type;
        private FhirCode? _mode;
        private FhirString? _documentation;
        private FhirId? _context;
        private FhirInteger? _min;
        private FhirString? _max;
        private FhirString? _type;
        private FhirString? _defaultvalue;
        private FhirString? _element;
        private FhirCode? _listmode;
        private FhirId? _variable;
        private FhirString? _condition;
        private FhirString? _check;
        private FhirString? _logmessage;
        private StructureMapGroupRuleTargetParameterValueChoice? _value;
        private FhirString? _context;
        private FhirString? _element;
        private FhirId? _variable;
        private List<FhirCode>? _listmode;
        private FhirId? _listruleid;
        private FhirCode? _transform;
        private List<StructureMapGroupRuleTargetParameter>? _parameter;
        private FhirId? _name;
        private FhirId? _name;
        private List<StructureMapGroupRuleSource>? _source;
        private List<StructureMapGroupRuleTarget>? _target;
        private List<StructureMapGroupRuleDependent>? _dependent;
        private FhirString? _documentation;
        private FhirId? _name;
        private FhirId? _extends;
        private FhirCode? _typemode;
        private FhirString? _documentation;
        private List<StructureMapGroupInput>? _input;
        private List<StructureMapGroupRule>? _rule;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "StructureMap";        /// <summary>
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
        public StructureMapVersionAlgorithmChoice? Versionalgorithm
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
        /// Structure
        /// </summary>
        /// <remarks>
        /// <para>
        /// Structure 的詳細描述。
        /// </para>
        /// </remarks>
        public List<StructureMapStructure>? Structure
        {
            get => _structure;
            set
            {
                _structure = value;
                OnPropertyChanged(nameof(Structure));
            }
        }        /// <summary>
        /// Import
        /// </summary>
        /// <remarks>
        /// <para>
        /// Import 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Import
        {
            get => _import;
            set
            {
                _import = value;
                OnPropertyChanged(nameof(Import));
            }
        }        /// <summary>
        /// Const
        /// </summary>
        /// <remarks>
        /// <para>
        /// Const 的詳細描述。
        /// </para>
        /// </remarks>
        public List<StructureMapConst>? Const
        {
            get => _const;
            set
            {
                _const = value;
                OnPropertyChanged(nameof(Const));
            }
        }        /// <summary>
        /// Group
        /// </summary>
        /// <remarks>
        /// <para>
        /// Group 的詳細描述。
        /// </para>
        /// </remarks>
        public List<StructureMapGroup>? Group
        {
            get => _group;
            set
            {
                _group = value;
                OnPropertyChanged(nameof(Group));
            }
        }        /// <summary>
        /// Url
        /// </summary>
        /// <remarks>
        /// <para>
        /// Url 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Url
        {
            get => _url;
            set
            {
                _url = value;
                OnPropertyChanged(nameof(Url));
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
        /// Alias
        /// </summary>
        /// <remarks>
        /// <para>
        /// Alias 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Alias
        {
            get => _alias;
            set
            {
                _alias = value;
                OnPropertyChanged(nameof(Alias));
            }
        }        /// <summary>
        /// Documentation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Documentation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Documentation
        {
            get => _documentation;
            set
            {
                _documentation = value;
                OnPropertyChanged(nameof(Documentation));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
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
        /// Documentation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Documentation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Documentation
        {
            get => _documentation;
            set
            {
                _documentation = value;
                OnPropertyChanged(nameof(Documentation));
            }
        }        /// <summary>
        /// Context
        /// </summary>
        /// <remarks>
        /// <para>
        /// Context 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Context
        {
            get => _context;
            set
            {
                _context = value;
                OnPropertyChanged(nameof(Context));
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
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Defaultvalue
        /// </summary>
        /// <remarks>
        /// <para>
        /// Defaultvalue 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Defaultvalue
        {
            get => _defaultvalue;
            set
            {
                _defaultvalue = value;
                OnPropertyChanged(nameof(Defaultvalue));
            }
        }        /// <summary>
        /// Element
        /// </summary>
        /// <remarks>
        /// <para>
        /// Element 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Element
        {
            get => _element;
            set
            {
                _element = value;
                OnPropertyChanged(nameof(Element));
            }
        }        /// <summary>
        /// Listmode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Listmode 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Listmode
        {
            get => _listmode;
            set
            {
                _listmode = value;
                OnPropertyChanged(nameof(Listmode));
            }
        }        /// <summary>
        /// Variable
        /// </summary>
        /// <remarks>
        /// <para>
        /// Variable 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Variable
        {
            get => _variable;
            set
            {
                _variable = value;
                OnPropertyChanged(nameof(Variable));
            }
        }        /// <summary>
        /// Condition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Condition 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Condition
        {
            get => _condition;
            set
            {
                _condition = value;
                OnPropertyChanged(nameof(Condition));
            }
        }        /// <summary>
        /// Check
        /// </summary>
        /// <remarks>
        /// <para>
        /// Check 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Check
        {
            get => _check;
            set
            {
                _check = value;
                OnPropertyChanged(nameof(Check));
            }
        }        /// <summary>
        /// Logmessage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Logmessage 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Logmessage
        {
            get => _logmessage;
            set
            {
                _logmessage = value;
                OnPropertyChanged(nameof(Logmessage));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public StructureMapGroupRuleTargetParameterValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Context
        /// </summary>
        /// <remarks>
        /// <para>
        /// Context 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Context
        {
            get => _context;
            set
            {
                _context = value;
                OnPropertyChanged(nameof(Context));
            }
        }        /// <summary>
        /// Element
        /// </summary>
        /// <remarks>
        /// <para>
        /// Element 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Element
        {
            get => _element;
            set
            {
                _element = value;
                OnPropertyChanged(nameof(Element));
            }
        }        /// <summary>
        /// Variable
        /// </summary>
        /// <remarks>
        /// <para>
        /// Variable 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Variable
        {
            get => _variable;
            set
            {
                _variable = value;
                OnPropertyChanged(nameof(Variable));
            }
        }        /// <summary>
        /// Listmode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Listmode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Listmode
        {
            get => _listmode;
            set
            {
                _listmode = value;
                OnPropertyChanged(nameof(Listmode));
            }
        }        /// <summary>
        /// Listruleid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Listruleid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Listruleid
        {
            get => _listruleid;
            set
            {
                _listruleid = value;
                OnPropertyChanged(nameof(Listruleid));
            }
        }        /// <summary>
        /// Transform
        /// </summary>
        /// <remarks>
        /// <para>
        /// Transform 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Transform
        {
            get => _transform;
            set
            {
                _transform = value;
                OnPropertyChanged(nameof(Transform));
            }
        }        /// <summary>
        /// Parameter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Parameter 的詳細描述。
        /// </para>
        /// </remarks>
        public List<StructureMapGroupRuleTargetParameter>? Parameter
        {
            get => _parameter;
            set
            {
                _parameter = value;
                OnPropertyChanged(nameof(Parameter));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public List<StructureMapGroupRuleSource>? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
            }
        }        /// <summary>
        /// Target
        /// </summary>
        /// <remarks>
        /// <para>
        /// Target 的詳細描述。
        /// </para>
        /// </remarks>
        public List<StructureMapGroupRuleTarget>? Target
        {
            get => _target;
            set
            {
                _target = value;
                OnPropertyChanged(nameof(Target));
            }
        }        /// <summary>
        /// Dependent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dependent 的詳細描述。
        /// </para>
        /// </remarks>
        public List<StructureMapGroupRuleDependent>? Dependent
        {
            get => _dependent;
            set
            {
                _dependent = value;
                OnPropertyChanged(nameof(Dependent));
            }
        }        /// <summary>
        /// Documentation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Documentation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Documentation
        {
            get => _documentation;
            set
            {
                _documentation = value;
                OnPropertyChanged(nameof(Documentation));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Extends
        /// </summary>
        /// <remarks>
        /// <para>
        /// Extends 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Extends
        {
            get => _extends;
            set
            {
                _extends = value;
                OnPropertyChanged(nameof(Extends));
            }
        }        /// <summary>
        /// Typemode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Typemode 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Typemode
        {
            get => _typemode;
            set
            {
                _typemode = value;
                OnPropertyChanged(nameof(Typemode));
            }
        }        /// <summary>
        /// Documentation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Documentation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Documentation
        {
            get => _documentation;
            set
            {
                _documentation = value;
                OnPropertyChanged(nameof(Documentation));
            }
        }        /// <summary>
        /// Input
        /// </summary>
        /// <remarks>
        /// <para>
        /// Input 的詳細描述。
        /// </para>
        /// </remarks>
        public List<StructureMapGroupInput>? Input
        {
            get => _input;
            set
            {
                _input = value;
                OnPropertyChanged(nameof(Input));
            }
        }        /// <summary>
        /// Rule
        /// </summary>
        /// <remarks>
        /// <para>
        /// Rule 的詳細描述。
        /// </para>
        /// </remarks>
        public List<StructureMapGroupRule>? Rule
        {
            get => _rule;
            set
            {
                _rule = value;
                OnPropertyChanged(nameof(Rule));
            }
        }        /// <summary>
        /// 建立新的 StructureMap 資源實例
        /// </summary>
        public StructureMap()
        {
        }

        /// <summary>
        /// 建立新的 StructureMap 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public StructureMap(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"StructureMap(Id: {Id})";
        }
    }    /// <summary>
    /// StructureMapStructure 背骨元素
    /// </summary>
    public class StructureMapStructure
    {
        // TODO: 添加屬性實作
        
        public StructureMapStructure() { }
    }    /// <summary>
    /// StructureMapConst 背骨元素
    /// </summary>
    public class StructureMapConst
    {
        // TODO: 添加屬性實作
        
        public StructureMapConst() { }
    }    /// <summary>
    /// StructureMapGroupInput 背骨元素
    /// </summary>
    public class StructureMapGroupInput
    {
        // TODO: 添加屬性實作
        
        public StructureMapGroupInput() { }
    }    /// <summary>
    /// StructureMapGroupRuleSource 背骨元素
    /// </summary>
    public class StructureMapGroupRuleSource
    {
        // TODO: 添加屬性實作
        
        public StructureMapGroupRuleSource() { }
    }    /// <summary>
    /// StructureMapGroupRuleTargetParameter 背骨元素
    /// </summary>
    public class StructureMapGroupRuleTargetParameter
    {
        // TODO: 添加屬性實作
        
        public StructureMapGroupRuleTargetParameter() { }
    }    /// <summary>
    /// StructureMapGroupRuleTarget 背骨元素
    /// </summary>
    public class StructureMapGroupRuleTarget
    {
        // TODO: 添加屬性實作
        
        public StructureMapGroupRuleTarget() { }
    }    /// <summary>
    /// StructureMapGroupRuleDependent 背骨元素
    /// </summary>
    public class StructureMapGroupRuleDependent
    {
        // TODO: 添加屬性實作
        
        public StructureMapGroupRuleDependent() { }
    }    /// <summary>
    /// StructureMapGroupRule 背骨元素
    /// </summary>
    public class StructureMapGroupRule
    {
        // TODO: 添加屬性實作
        
        public StructureMapGroupRule() { }
    }    /// <summary>
    /// StructureMapGroup 背骨元素
    /// </summary>
    public class StructureMapGroup
    {
        // TODO: 添加屬性實作
        
        public StructureMapGroup() { }
    }    /// <summary>
    /// StructureMapVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class StructureMapVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public StructureMapVersionAlgorithmChoice(JsonObject value) : base("structuremapversionalgorithm", value, _supportType) { }
        public StructureMapVersionAlgorithmChoice(IComplexType? value) : base("structuremapversionalgorithm", value) { }
        public StructureMapVersionAlgorithmChoice(IPrimitiveType? value) : base("structuremapversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "StructureMapVersionAlgorithm" : "structuremapversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// StructureMapGroupRuleTargetParameterValueChoice 選擇類型
    /// </summary>
    public class StructureMapGroupRuleTargetParameterValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public StructureMapGroupRuleTargetParameterValueChoice(JsonObject value) : base("structuremapgroupruletargetparametervalue", value, _supportType) { }
        public StructureMapGroupRuleTargetParameterValueChoice(IComplexType? value) : base("structuremapgroupruletargetparametervalue", value) { }
        public StructureMapGroupRuleTargetParameterValueChoice(IPrimitiveType? value) : base("structuremapgroupruletargetparametervalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "StructureMapGroupRuleTargetParameterValue" : "structuremapgroupruletargetparametervalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
