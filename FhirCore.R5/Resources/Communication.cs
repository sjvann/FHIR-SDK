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
    /// FHIR R5 Communication 資源
    /// 
    /// <para>
    /// Communication 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var communication = new Communication("communication-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Communication 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Communication : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<FhirCanonical>? _instantiatescanonical;
        private List<FhirUri>? _instantiatesuri;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _partof;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _inresponseto;
        private FhirCode? _status;
        private CodeableConcept? _statusreason;
        private List<CodeableConcept>? _category;
        private FhirCode? _priority;
        private List<CodeableConcept>? _medium;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private CodeableConcept? _topic;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _about;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private FhirDateTime? _sent;
        private FhirDateTime? _received;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _recipient;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _sender;
        private List<CodeableReference>? _reason;
        private List<CommunicationPayload>? _payload;
        private List<Annotation>? _note;
        private CommunicationPayloadContentChoice? _content;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Communication";        /// <summary>
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
        /// Instantiatescanonical
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instantiatescanonical 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Instantiatescanonical
        {
            get => _instantiatescanonical;
            set
            {
                _instantiatescanonical = value;
                OnPropertyChanged(nameof(Instantiatescanonical));
            }
        }        /// <summary>
        /// Instantiatesuri
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instantiatesuri 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUri>? Instantiatesuri
        {
            get => _instantiatesuri;
            set
            {
                _instantiatesuri = value;
                OnPropertyChanged(nameof(Instantiatesuri));
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
        /// Partof
        /// </summary>
        /// <remarks>
        /// <para>
        /// Partof 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Partof
        {
            get => _partof;
            set
            {
                _partof = value;
                OnPropertyChanged(nameof(Partof));
            }
        }        /// <summary>
        /// Inresponseto
        /// </summary>
        /// <remarks>
        /// <para>
        /// Inresponseto 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Inresponseto
        {
            get => _inresponseto;
            set
            {
                _inresponseto = value;
                OnPropertyChanged(nameof(Inresponseto));
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
        /// Statusreason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Statusreason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Statusreason
        {
            get => _statusreason;
            set
            {
                _statusreason = value;
                OnPropertyChanged(nameof(Statusreason));
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
        /// Priority
        /// </summary>
        /// <remarks>
        /// <para>
        /// Priority 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(Priority));
            }
        }        /// <summary>
        /// Medium
        /// </summary>
        /// <remarks>
        /// <para>
        /// Medium 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Medium
        {
            get => _medium;
            set
            {
                _medium = value;
                OnPropertyChanged(nameof(Medium));
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
        /// Topic
        /// </summary>
        /// <remarks>
        /// <para>
        /// Topic 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Topic
        {
            get => _topic;
            set
            {
                _topic = value;
                OnPropertyChanged(nameof(Topic));
            }
        }        /// <summary>
        /// About
        /// </summary>
        /// <remarks>
        /// <para>
        /// About 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? About
        {
            get => _about;
            set
            {
                _about = value;
                OnPropertyChanged(nameof(About));
            }
        }        /// <summary>
        /// Encounter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Encounter 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Encounter
        {
            get => _encounter;
            set
            {
                _encounter = value;
                OnPropertyChanged(nameof(Encounter));
            }
        }        /// <summary>
        /// Sent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sent 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Sent
        {
            get => _sent;
            set
            {
                _sent = value;
                OnPropertyChanged(nameof(Sent));
            }
        }        /// <summary>
        /// Received
        /// </summary>
        /// <remarks>
        /// <para>
        /// Received 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Received
        {
            get => _received;
            set
            {
                _received = value;
                OnPropertyChanged(nameof(Received));
            }
        }        /// <summary>
        /// Recipient
        /// </summary>
        /// <remarks>
        /// <para>
        /// Recipient 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Recipient
        {
            get => _recipient;
            set
            {
                _recipient = value;
                OnPropertyChanged(nameof(Recipient));
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
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }        /// <summary>
        /// Payload
        /// </summary>
        /// <remarks>
        /// <para>
        /// Payload 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CommunicationPayload>? Payload
        {
            get => _payload;
            set
            {
                _payload = value;
                OnPropertyChanged(nameof(Payload));
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
        /// Content
        /// </summary>
        /// <remarks>
        /// <para>
        /// Content 的詳細描述。
        /// </para>
        /// </remarks>
        public CommunicationPayloadContentChoice? Content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged(nameof(Content));
            }
        }        /// <summary>
        /// 建立新的 Communication 資源實例
        /// </summary>
        public Communication()
        {
        }

        /// <summary>
        /// 建立新的 Communication 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Communication(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Communication(Id: {Id})";
        }
    }    /// <summary>
    /// CommunicationPayload 背骨元素
    /// </summary>
    public class CommunicationPayload
    {
        // TODO: 添加屬性實作
        
        public CommunicationPayload() { }
    }    /// <summary>
    /// CommunicationPayloadContentChoice 選擇類型
    /// </summary>
    public class CommunicationPayloadContentChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public CommunicationPayloadContentChoice(JsonObject value) : base("communicationpayloadcontent", value, _supportType) { }
        public CommunicationPayloadContentChoice(IComplexType? value) : base("communicationpayloadcontent", value) { }
        public CommunicationPayloadContentChoice(IPrimitiveType? value) : base("communicationpayloadcontent", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "CommunicationPayloadContent" : "communicationpayloadcontent";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
