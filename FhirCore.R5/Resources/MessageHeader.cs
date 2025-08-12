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
    /// FHIR R5 MessageHeader 資源
    /// 
    /// <para>
    /// MessageHeader 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var messageheader = new MessageHeader("messageheader-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 MessageHeader 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MessageHeader : ResourceBase<R5Version>
    {
        private Property
		private MessageHeaderEventChoice? _event;
        private List<MessageHeaderDestination>? _destination;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _sender;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _author;
        private MessageHeaderSource? _source;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _responsible;
        private CodeableConcept? _reason;
        private MessageHeaderResponse? _response;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _focus;
        private FhirCanonical? _definition;
        private MessageHeaderDestinationEndpointChoice? _endpoint;
        private FhirString? _name;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _target;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _receiver;
        private MessageHeaderSourceEndpointChoice? _endpoint;
        private FhirString? _name;
        private FhirString? _software;
        private FhirString? _version;
        private ContactPoint? _contact;
        private Identifier? _identifier;
        private FhirCode? _code;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _details;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "MessageHeader";        /// <summary>
        /// Event
        /// </summary>
        /// <remarks>
        /// <para>
        /// Event 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private MessageHeaderEventChoice? Event
        {
            get => _event;
            set
            {
                _event = value;
                OnPropertyChanged(nameof(Event));
            }
        }        /// <summary>
        /// Destination
        /// </summary>
        /// <remarks>
        /// <para>
        /// Destination 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MessageHeaderDestination>? Destination
        {
            get => _destination;
            set
            {
                _destination = value;
                OnPropertyChanged(nameof(Destination));
            }
        }        /// <summary>
        /// Sender
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sender 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Sender
        {
            get => _sender;
            set
            {
                _sender = value;
                OnPropertyChanged(nameof(Sender));
            }
        }        /// <summary>
        /// Author
        /// </summary>
        /// <remarks>
        /// <para>
        /// Author 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Author
        {
            get => _author;
            set
            {
                _author = value;
                OnPropertyChanged(nameof(Author));
            }
        }        /// <summary>
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public MessageHeaderSource? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
            }
        }        /// <summary>
        /// Responsible
        /// </summary>
        /// <remarks>
        /// <para>
        /// Responsible 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Responsible
        {
            get => _responsible;
            set
            {
                _responsible = value;
                OnPropertyChanged(nameof(Responsible));
            }
        }        /// <summary>
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }        /// <summary>
        /// Response
        /// </summary>
        /// <remarks>
        /// <para>
        /// Response 的詳細描述。
        /// </para>
        /// </remarks>
        public MessageHeaderResponse? Response
        {
            get => _response;
            set
            {
                _response = value;
                OnPropertyChanged(nameof(Response));
            }
        }        /// <summary>
        /// Focus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Focus 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Focus
        {
            get => _focus;
            set
            {
                _focus = value;
                OnPropertyChanged(nameof(Focus));
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
        /// Endpoint
        /// </summary>
        /// <remarks>
        /// <para>
        /// Endpoint 的詳細描述。
        /// </para>
        /// </remarks>
        public MessageHeaderDestinationEndpointChoice? Endpoint
        {
            get => _endpoint;
            set
            {
                _endpoint = value;
                OnPropertyChanged(nameof(Endpoint));
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
        /// Receiver
        /// </summary>
        /// <remarks>
        /// <para>
        /// Receiver 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Receiver
        {
            get => _receiver;
            set
            {
                _receiver = value;
                OnPropertyChanged(nameof(Receiver));
            }
        }        /// <summary>
        /// Endpoint
        /// </summary>
        /// <remarks>
        /// <para>
        /// Endpoint 的詳細描述。
        /// </para>
        /// </remarks>
        public MessageHeaderSourceEndpointChoice? Endpoint
        {
            get => _endpoint;
            set
            {
                _endpoint = value;
                OnPropertyChanged(nameof(Endpoint));
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
        /// Software
        /// </summary>
        /// <remarks>
        /// <para>
        /// Software 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Software
        {
            get => _software;
            set
            {
                _software = value;
                OnPropertyChanged(nameof(Software));
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
        /// Contact
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contact 的詳細描述。
        /// </para>
        /// </remarks>
        public ContactPoint? Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
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
        /// Details
        /// </summary>
        /// <remarks>
        /// <para>
        /// Details 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Details
        {
            get => _details;
            set
            {
                _details = value;
                OnPropertyChanged(nameof(Details));
            }
        }        /// <summary>
        /// 建立新的 MessageHeader 資源實例
        /// </summary>
        public MessageHeader()
        {
        }

        /// <summary>
        /// 建立新的 MessageHeader 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public MessageHeader(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"MessageHeader(Id: {Id})";
        }
    }    /// <summary>
    /// MessageHeaderDestination 背骨元素
    /// </summary>
    public class MessageHeaderDestination
    {
        // TODO: 添加屬性實作
        
        public MessageHeaderDestination() { }
    }    /// <summary>
    /// MessageHeaderSource 背骨元素
    /// </summary>
    public class MessageHeaderSource
    {
        // TODO: 添加屬性實作
        
        public MessageHeaderSource() { }
    }    /// <summary>
    /// MessageHeaderResponse 背骨元素
    /// </summary>
    public class MessageHeaderResponse
    {
        // TODO: 添加屬性實作
        
        public MessageHeaderResponse() { }
    }    /// <summary>
    /// MessageHeaderEventChoice 選擇類型
    /// </summary>
    public class MessageHeaderEventChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MessageHeaderEventChoice(JsonObject value) : base("messageheaderevent", value, _supportType) { }
        public MessageHeaderEventChoice(IComplexType? value) : base("messageheaderevent", value) { }
        public MessageHeaderEventChoice(IPrimitiveType? value) : base("messageheaderevent", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MessageHeaderEvent" : "messageheaderevent";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// MessageHeaderDestinationEndpointChoice 選擇類型
    /// </summary>
    public class MessageHeaderDestinationEndpointChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MessageHeaderDestinationEndpointChoice(JsonObject value) : base("messageheaderdestinationendpoint", value, _supportType) { }
        public MessageHeaderDestinationEndpointChoice(IComplexType? value) : base("messageheaderdestinationendpoint", value) { }
        public MessageHeaderDestinationEndpointChoice(IPrimitiveType? value) : base("messageheaderdestinationendpoint", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MessageHeaderDestinationEndpoint" : "messageheaderdestinationendpoint";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// MessageHeaderSourceEndpointChoice 選擇類型
    /// </summary>
    public class MessageHeaderSourceEndpointChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MessageHeaderSourceEndpointChoice(JsonObject value) : base("messageheadersourceendpoint", value, _supportType) { }
        public MessageHeaderSourceEndpointChoice(IComplexType? value) : base("messageheadersourceendpoint", value) { }
        public MessageHeaderSourceEndpointChoice(IPrimitiveType? value) : base("messageheadersourceendpoint", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MessageHeaderSourceEndpoint" : "messageheadersourceendpoint";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
