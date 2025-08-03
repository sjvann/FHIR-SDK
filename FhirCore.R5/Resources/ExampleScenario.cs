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
    /// FHIR R5 ExampleScenario 資源
    /// 
    /// <para>
    /// ExampleScenario 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var examplescenario = new ExampleScenario("examplescenario-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 ExampleScenario 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ExampleScenario : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private ExampleScenarioVersionAlgorithmChoice? _versionalgorithm;
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
        private List<ExampleScenarioActor>? _actor;
        private List<ExampleScenarioInstance>? _instance;
        private List<ExampleScenarioProcess>? _process;
        private FhirString? _key;
        private FhirCode? _type;
        private FhirString? _title;
        private FhirMarkdown? _description;
        private FhirString? _key;
        private FhirString? _title;
        private FhirMarkdown? _description;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _content;
        private FhirString? _instancereference;
        private FhirString? _versionreference;
        private FhirString? _key;
        private Coding? _structuretype;
        private FhirString? _structureversion;
        private ExampleScenarioInstanceStructureProfileChoice? _structureprofile;
        private FhirString? _title;
        private FhirMarkdown? _description;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _content;
        private List<ExampleScenarioInstanceVersion>? _version;
        private List<ExampleScenarioInstanceContainedInstance>? _containedinstance;
        private Coding? _type;
        private FhirString? _title;
        private FhirString? _initiator;
        private FhirString? _receiver;
        private FhirMarkdown? _description;
        private FhirBoolean? _initiatoractive;
        private FhirBoolean? _receiveractive;
        private FhirString? _title;
        private FhirMarkdown? _description;
        private FhirString? _number;
        private FhirCanonical? _workflow;
        private ExampleScenarioProcessStepOperation? _operation;
        private List<ExampleScenarioProcessStepAlternative>? _alternative;
        private FhirBoolean? _pause;
        private FhirString? _title;
        private FhirMarkdown? _description;
        private FhirMarkdown? _preconditions;
        private FhirMarkdown? _postconditions;
        private List<ExampleScenarioProcessStep>? _step;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ExampleScenario";        /// <summary>
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
        public ExampleScenarioVersionAlgorithmChoice? Versionalgorithm
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
        /// Actor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Actor 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExampleScenarioActor>? Actor
        {
            get => _actor;
            set
            {
                _actor = value;
                OnPropertyChanged(nameof(Actor));
            }
        }        /// <summary>
        /// Instance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExampleScenarioInstance>? Instance
        {
            get => _instance;
            set
            {
                _instance = value;
                OnPropertyChanged(nameof(Instance));
            }
        }        /// <summary>
        /// Process
        /// </summary>
        /// <remarks>
        /// <para>
        /// Process 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExampleScenarioProcess>? Process
        {
            get => _process;
            set
            {
                _process = value;
                OnPropertyChanged(nameof(Process));
            }
        }        /// <summary>
        /// Key
        /// </summary>
        /// <remarks>
        /// <para>
        /// Key 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Key
        {
            get => _key;
            set
            {
                _key = value;
                OnPropertyChanged(nameof(Key));
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
        /// Key
        /// </summary>
        /// <remarks>
        /// <para>
        /// Key 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Key
        {
            get => _key;
            set
            {
                _key = value;
                OnPropertyChanged(nameof(Key));
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
        /// Content
        /// </summary>
        /// <remarks>
        /// <para>
        /// Content 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged(nameof(Content));
            }
        }        /// <summary>
        /// Instancereference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instancereference 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Instancereference
        {
            get => _instancereference;
            set
            {
                _instancereference = value;
                OnPropertyChanged(nameof(Instancereference));
            }
        }        /// <summary>
        /// Versionreference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Versionreference 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Versionreference
        {
            get => _versionreference;
            set
            {
                _versionreference = value;
                OnPropertyChanged(nameof(Versionreference));
            }
        }        /// <summary>
        /// Key
        /// </summary>
        /// <remarks>
        /// <para>
        /// Key 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Key
        {
            get => _key;
            set
            {
                _key = value;
                OnPropertyChanged(nameof(Key));
            }
        }        /// <summary>
        /// Structuretype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Structuretype 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? Structuretype
        {
            get => _structuretype;
            set
            {
                _structuretype = value;
                OnPropertyChanged(nameof(Structuretype));
            }
        }        /// <summary>
        /// Structureversion
        /// </summary>
        /// <remarks>
        /// <para>
        /// Structureversion 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Structureversion
        {
            get => _structureversion;
            set
            {
                _structureversion = value;
                OnPropertyChanged(nameof(Structureversion));
            }
        }        /// <summary>
        /// Structureprofile
        /// </summary>
        /// <remarks>
        /// <para>
        /// Structureprofile 的詳細描述。
        /// </para>
        /// </remarks>
        public ExampleScenarioInstanceStructureProfileChoice? Structureprofile
        {
            get => _structureprofile;
            set
            {
                _structureprofile = value;
                OnPropertyChanged(nameof(Structureprofile));
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
        /// Content
        /// </summary>
        /// <remarks>
        /// <para>
        /// Content 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged(nameof(Content));
            }
        }        /// <summary>
        /// Version
        /// </summary>
        /// <remarks>
        /// <para>
        /// Version 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExampleScenarioInstanceVersion>? Version
        {
            get => _version;
            set
            {
                _version = value;
                OnPropertyChanged(nameof(Version));
            }
        }        /// <summary>
        /// Containedinstance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Containedinstance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExampleScenarioInstanceContainedInstance>? Containedinstance
        {
            get => _containedinstance;
            set
            {
                _containedinstance = value;
                OnPropertyChanged(nameof(Containedinstance));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
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
        /// Initiator
        /// </summary>
        /// <remarks>
        /// <para>
        /// Initiator 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Initiator
        {
            get => _initiator;
            set
            {
                _initiator = value;
                OnPropertyChanged(nameof(Initiator));
            }
        }        /// <summary>
        /// Receiver
        /// </summary>
        /// <remarks>
        /// <para>
        /// Receiver 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Receiver
        {
            get => _receiver;
            set
            {
                _receiver = value;
                OnPropertyChanged(nameof(Receiver));
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
        /// Initiatoractive
        /// </summary>
        /// <remarks>
        /// <para>
        /// Initiatoractive 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Initiatoractive
        {
            get => _initiatoractive;
            set
            {
                _initiatoractive = value;
                OnPropertyChanged(nameof(Initiatoractive));
            }
        }        /// <summary>
        /// Receiveractive
        /// </summary>
        /// <remarks>
        /// <para>
        /// Receiveractive 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Receiveractive
        {
            get => _receiveractive;
            set
            {
                _receiveractive = value;
                OnPropertyChanged(nameof(Receiveractive));
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
        /// Number
        /// </summary>
        /// <remarks>
        /// <para>
        /// Number 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Number
        {
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged(nameof(Number));
            }
        }        /// <summary>
        /// Workflow
        /// </summary>
        /// <remarks>
        /// <para>
        /// Workflow 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Workflow
        {
            get => _workflow;
            set
            {
                _workflow = value;
                OnPropertyChanged(nameof(Workflow));
            }
        }        /// <summary>
        /// Operation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Operation 的詳細描述。
        /// </para>
        /// </remarks>
        public ExampleScenarioProcessStepOperation? Operation
        {
            get => _operation;
            set
            {
                _operation = value;
                OnPropertyChanged(nameof(Operation));
            }
        }        /// <summary>
        /// Alternative
        /// </summary>
        /// <remarks>
        /// <para>
        /// Alternative 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExampleScenarioProcessStepAlternative>? Alternative
        {
            get => _alternative;
            set
            {
                _alternative = value;
                OnPropertyChanged(nameof(Alternative));
            }
        }        /// <summary>
        /// Pause
        /// </summary>
        /// <remarks>
        /// <para>
        /// Pause 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Pause
        {
            get => _pause;
            set
            {
                _pause = value;
                OnPropertyChanged(nameof(Pause));
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
        /// Preconditions
        /// </summary>
        /// <remarks>
        /// <para>
        /// Preconditions 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Preconditions
        {
            get => _preconditions;
            set
            {
                _preconditions = value;
                OnPropertyChanged(nameof(Preconditions));
            }
        }        /// <summary>
        /// Postconditions
        /// </summary>
        /// <remarks>
        /// <para>
        /// Postconditions 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Postconditions
        {
            get => _postconditions;
            set
            {
                _postconditions = value;
                OnPropertyChanged(nameof(Postconditions));
            }
        }        /// <summary>
        /// Step
        /// </summary>
        /// <remarks>
        /// <para>
        /// Step 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExampleScenarioProcessStep>? Step
        {
            get => _step;
            set
            {
                _step = value;
                OnPropertyChanged(nameof(Step));
            }
        }        /// <summary>
        /// 建立新的 ExampleScenario 資源實例
        /// </summary>
        public ExampleScenario()
        {
        }

        /// <summary>
        /// 建立新的 ExampleScenario 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ExampleScenario(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ExampleScenario(Id: {Id})";
        }
    }    /// <summary>
    /// ExampleScenarioActor 背骨元素
    /// </summary>
    public class ExampleScenarioActor
    {
        // TODO: 添加屬性實作
        
        public ExampleScenarioActor() { }
    }    /// <summary>
    /// ExampleScenarioInstanceVersion 背骨元素
    /// </summary>
    public class ExampleScenarioInstanceVersion
    {
        // TODO: 添加屬性實作
        
        public ExampleScenarioInstanceVersion() { }
    }    /// <summary>
    /// ExampleScenarioInstanceContainedInstance 背骨元素
    /// </summary>
    public class ExampleScenarioInstanceContainedInstance
    {
        // TODO: 添加屬性實作
        
        public ExampleScenarioInstanceContainedInstance() { }
    }    /// <summary>
    /// ExampleScenarioInstance 背骨元素
    /// </summary>
    public class ExampleScenarioInstance
    {
        // TODO: 添加屬性實作
        
        public ExampleScenarioInstance() { }
    }    /// <summary>
    /// ExampleScenarioProcessStepOperation 背骨元素
    /// </summary>
    public class ExampleScenarioProcessStepOperation
    {
        // TODO: 添加屬性實作
        
        public ExampleScenarioProcessStepOperation() { }
    }    /// <summary>
    /// ExampleScenarioProcessStepAlternative 背骨元素
    /// </summary>
    public class ExampleScenarioProcessStepAlternative
    {
        // TODO: 添加屬性實作
        
        public ExampleScenarioProcessStepAlternative() { }
    }    /// <summary>
    /// ExampleScenarioProcessStep 背骨元素
    /// </summary>
    public class ExampleScenarioProcessStep
    {
        // TODO: 添加屬性實作
        
        public ExampleScenarioProcessStep() { }
    }    /// <summary>
    /// ExampleScenarioProcess 背骨元素
    /// </summary>
    public class ExampleScenarioProcess
    {
        // TODO: 添加屬性實作
        
        public ExampleScenarioProcess() { }
    }    /// <summary>
    /// ExampleScenarioVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class ExampleScenarioVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ExampleScenarioVersionAlgorithmChoice(JsonObject value) : base("examplescenarioversionalgorithm", value, _supportType) { }
        public ExampleScenarioVersionAlgorithmChoice(IComplexType? value) : base("examplescenarioversionalgorithm", value) { }
        public ExampleScenarioVersionAlgorithmChoice(IPrimitiveType? value) : base("examplescenarioversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ExampleScenarioVersionAlgorithm" : "examplescenarioversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ExampleScenarioInstanceStructureProfileChoice 選擇類型
    /// </summary>
    public class ExampleScenarioInstanceStructureProfileChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ExampleScenarioInstanceStructureProfileChoice(JsonObject value) : base("examplescenarioinstancestructureprofile", value, _supportType) { }
        public ExampleScenarioInstanceStructureProfileChoice(IComplexType? value) : base("examplescenarioinstancestructureprofile", value) { }
        public ExampleScenarioInstanceStructureProfileChoice(IPrimitiveType? value) : base("examplescenarioinstancestructureprofile", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ExampleScenarioInstanceStructureProfile" : "examplescenarioinstancestructureprofile";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
