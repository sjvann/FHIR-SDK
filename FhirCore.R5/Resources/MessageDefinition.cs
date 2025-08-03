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
    /// FHIR R5 MessageDefinition 資源
    /// 
    /// <para>
    /// MessageDefinition 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var messagedefinition = new MessageDefinition("messagedefinition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 MessageDefinition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MessageDefinition : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private MessageDefinitionVersionAlgorithmChoice? _versionalgorithm;
        private FhirString? _name;
        private FhirString? _title;
        private List<FhirCanonical>? _replaces;
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
        private FhirCanonical? _base;
        private List<FhirCanonical>? _parent;
        private MessageDefinitionEventChoice? _event;
        private FhirCode? _category;
        private List<MessageDefinitionFocus>? _focus;
        private FhirCode? _responserequired;
        private List<MessageDefinitionAllowedResponse>? _allowedresponse;
        private FhirCanonical? _graph;
        private FhirCode? _code;
        private FhirCanonical? _profile;
        private FhirUnsignedInt? _min;
        private FhirString? _max;
        private FhirCanonical? _message;
        private FhirMarkdown? _situation;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "MessageDefinition";        /// <summary>
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
        public MessageDefinitionVersionAlgorithmChoice? Versionalgorithm
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
        /// Replaces
        /// </summary>
        /// <remarks>
        /// <para>
        /// Replaces 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Replaces
        {
            get => _replaces;
            set
            {
                _replaces = value;
                OnPropertyChanged(nameof(Replaces));
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
        /// Parent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Parent 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Parent
        {
            get => _parent;
            set
            {
                _parent = value;
                OnPropertyChanged(nameof(Parent));
            }
        }        /// <summary>
        /// Event
        /// </summary>
        /// <remarks>
        /// <para>
        /// Event 的詳細描述。
        /// </para>
        /// </remarks>
        public MessageDefinitionEventChoice? Event
        {
            get => _event;
            set
            {
                _event = value;
                OnPropertyChanged(nameof(Event));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Focus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Focus 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MessageDefinitionFocus>? Focus
        {
            get => _focus;
            set
            {
                _focus = value;
                OnPropertyChanged(nameof(Focus));
            }
        }        /// <summary>
        /// Responserequired
        /// </summary>
        /// <remarks>
        /// <para>
        /// Responserequired 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Responserequired
        {
            get => _responserequired;
            set
            {
                _responserequired = value;
                OnPropertyChanged(nameof(Responserequired));
            }
        }        /// <summary>
        /// Allowedresponse
        /// </summary>
        /// <remarks>
        /// <para>
        /// Allowedresponse 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MessageDefinitionAllowedResponse>? Allowedresponse
        {
            get => _allowedresponse;
            set
            {
                _allowedresponse = value;
                OnPropertyChanged(nameof(Allowedresponse));
            }
        }        /// <summary>
        /// Graph
        /// </summary>
        /// <remarks>
        /// <para>
        /// Graph 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Graph
        {
            get => _graph;
            set
            {
                _graph = value;
                OnPropertyChanged(nameof(Graph));
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
        /// Min
        /// </summary>
        /// <remarks>
        /// <para>
        /// Min 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? Min
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
        /// Message
        /// </summary>
        /// <remarks>
        /// <para>
        /// Message 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Message
        {
            get => _message;
            set
            {
                _message = value;
                OnPropertyChanged(nameof(Message));
            }
        }        /// <summary>
        /// Situation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Situation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Situation
        {
            get => _situation;
            set
            {
                _situation = value;
                OnPropertyChanged(nameof(Situation));
            }
        }        /// <summary>
        /// 建立新的 MessageDefinition 資源實例
        /// </summary>
        public MessageDefinition()
        {
        }

        /// <summary>
        /// 建立新的 MessageDefinition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public MessageDefinition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"MessageDefinition(Id: {Id})";
        }
    }    /// <summary>
    /// MessageDefinitionFocus 背骨元素
    /// </summary>
    public class MessageDefinitionFocus
    {
        // TODO: 添加屬性實作
        
        public MessageDefinitionFocus() { }
    }    /// <summary>
    /// MessageDefinitionAllowedResponse 背骨元素
    /// </summary>
    public class MessageDefinitionAllowedResponse
    {
        // TODO: 添加屬性實作
        
        public MessageDefinitionAllowedResponse() { }
    }    /// <summary>
    /// MessageDefinitionVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class MessageDefinitionVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MessageDefinitionVersionAlgorithmChoice(JsonObject value) : base("messagedefinitionversionalgorithm", value, _supportType) { }
        public MessageDefinitionVersionAlgorithmChoice(IComplexType? value) : base("messagedefinitionversionalgorithm", value) { }
        public MessageDefinitionVersionAlgorithmChoice(IPrimitiveType? value) : base("messagedefinitionversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MessageDefinitionVersionAlgorithm" : "messagedefinitionversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// MessageDefinitionEventChoice 選擇類型
    /// </summary>
    public class MessageDefinitionEventChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MessageDefinitionEventChoice(JsonObject value) : base("messagedefinitionevent", value, _supportType) { }
        public MessageDefinitionEventChoice(IComplexType? value) : base("messagedefinitionevent", value) { }
        public MessageDefinitionEventChoice(IPrimitiveType? value) : base("messagedefinitionevent", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MessageDefinitionEvent" : "messagedefinitionevent";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
