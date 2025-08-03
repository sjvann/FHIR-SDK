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
    /// FHIR R5 CommunicationRequest 資源
    /// 
    /// <para>
    /// CommunicationRequest 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var communicationrequest = new CommunicationRequest("communicationrequest-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 CommunicationRequest 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class CommunicationRequest : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _replaces;
        private Identifier? _groupidentifier;
        private FhirCode? _status;
        private CodeableConcept? _statusreason;
        private FhirCode? _intent;
        private List<CodeableConcept>? _category;
        private FhirCode? _priority;
        private FhirBoolean? _donotperform;
        private List<CodeableConcept>? _medium;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _about;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private List<CommunicationRequestPayload>? _payload;
        private CommunicationRequestOccurrenceChoice? _occurrence;
        private FhirDateTime? _authoredon;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _requester;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _recipient;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _informationprovider;
        private List<CodeableReference>? _reason;
        private List<Annotation>? _note;
        private CommunicationRequestPayloadContentChoice? _content;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "CommunicationRequest";        /// <summary>
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
        /// Replaces
        /// </summary>
        /// <remarks>
        /// <para>
        /// Replaces 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Replaces
        {
            get => _replaces;
            set
            {
                _replaces = value;
                OnPropertyChanged(nameof(Replaces));
            }
        }        /// <summary>
        /// Groupidentifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Groupidentifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? Groupidentifier
        {
            get => _groupidentifier;
            set
            {
                _groupidentifier = value;
                OnPropertyChanged(nameof(Groupidentifier));
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
        /// Intent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Intent 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Intent
        {
            get => _intent;
            set
            {
                _intent = value;
                OnPropertyChanged(nameof(Intent));
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
        /// Donotperform
        /// </summary>
        /// <remarks>
        /// <para>
        /// Donotperform 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Donotperform
        {
            get => _donotperform;
            set
            {
                _donotperform = value;
                OnPropertyChanged(nameof(Donotperform));
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
        /// Payload
        /// </summary>
        /// <remarks>
        /// <para>
        /// Payload 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CommunicationRequestPayload>? Payload
        {
            get => _payload;
            set
            {
                _payload = value;
                OnPropertyChanged(nameof(Payload));
            }
        }        /// <summary>
        /// Occurrence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Occurrence 的詳細描述。
        /// </para>
        /// </remarks>
        public CommunicationRequestOccurrenceChoice? Occurrence
        {
            get => _occurrence;
            set
            {
                _occurrence = value;
                OnPropertyChanged(nameof(Occurrence));
            }
        }        /// <summary>
        /// Authoredon
        /// </summary>
        /// <remarks>
        /// <para>
        /// Authoredon 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Authoredon
        {
            get => _authoredon;
            set
            {
                _authoredon = value;
                OnPropertyChanged(nameof(Authoredon));
            }
        }        /// <summary>
        /// Requester
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requester 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Requester
        {
            get => _requester;
            set
            {
                _requester = value;
                OnPropertyChanged(nameof(Requester));
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
        /// Informationprovider
        /// </summary>
        /// <remarks>
        /// <para>
        /// Informationprovider 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Informationprovider
        {
            get => _informationprovider;
            set
            {
                _informationprovider = value;
                OnPropertyChanged(nameof(Informationprovider));
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
        public CommunicationRequestPayloadContentChoice? Content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged(nameof(Content));
            }
        }        /// <summary>
        /// 建立新的 CommunicationRequest 資源實例
        /// </summary>
        public CommunicationRequest()
        {
        }

        /// <summary>
        /// 建立新的 CommunicationRequest 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public CommunicationRequest(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"CommunicationRequest(Id: {Id})";
        }
    }    /// <summary>
    /// CommunicationRequestPayload 背骨元素
    /// </summary>
    public class CommunicationRequestPayload
    {
        // TODO: 添加屬性實作
        
        public CommunicationRequestPayload() { }
    }    /// <summary>
    /// CommunicationRequestPayloadContentChoice 選擇類型
    /// </summary>
    public class CommunicationRequestPayloadContentChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public CommunicationRequestPayloadContentChoice(JsonObject value) : base("communicationrequestpayloadcontent", value, _supportType) { }
        public CommunicationRequestPayloadContentChoice(IComplexType? value) : base("communicationrequestpayloadcontent", value) { }
        public CommunicationRequestPayloadContentChoice(IPrimitiveType? value) : base("communicationrequestpayloadcontent", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "CommunicationRequestPayloadContent" : "communicationrequestpayloadcontent";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// CommunicationRequestOccurrenceChoice 選擇類型
    /// </summary>
    public class CommunicationRequestOccurrenceChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public CommunicationRequestOccurrenceChoice(JsonObject value) : base("communicationrequestoccurrence", value, _supportType) { }
        public CommunicationRequestOccurrenceChoice(IComplexType? value) : base("communicationrequestoccurrence", value) { }
        public CommunicationRequestOccurrenceChoice(IPrimitiveType? value) : base("communicationrequestoccurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "CommunicationRequestOccurrence" : "communicationrequestoccurrence";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
