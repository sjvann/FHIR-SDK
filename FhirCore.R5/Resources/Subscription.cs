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
    /// FHIR R5 Subscription 資源
    /// 
    /// <para>
    /// Subscription 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var subscription = new Subscription("subscription-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Subscription 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Subscription : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirString? _name;
        private FhirCode? _status;
        private FhirCanonical? _topic;
        private List<ContactPoint>? _contact;
        private FhirInstant? _end;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _managingentity;
        private FhirString? _reason;
        private List<SubscriptionFilterBy>? _filterby;
        private Coding? _channeltype;
        private FhirUrl? _endpoint;
        private List<SubscriptionParameter>? _parameter;
        private FhirUnsignedInt? _heartbeatperiod;
        private FhirUnsignedInt? _timeout;
        private FhirCode? _contenttype;
        private FhirCode? _content;
        private FhirPositiveInt? _maxcount;
        private FhirUri? _resourcetype;
        private FhirString? _filterparameter;
        private FhirCode? _comparator;
        private FhirCode? _modifier;
        private FhirString? _value;
        private FhirString? _name;
        private FhirString? _value;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Subscription";        /// <summary>
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
        /// Topic
        /// </summary>
        /// <remarks>
        /// <para>
        /// Topic 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Topic
        {
            get => _topic;
            set
            {
                _topic = value;
                OnPropertyChanged(nameof(Topic));
            }
        }        /// <summary>
        /// Contact
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactPoint>? Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }        /// <summary>
        /// End
        /// </summary>
        /// <remarks>
        /// <para>
        /// End 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInstant? End
        {
            get => _end;
            set
            {
                _end = value;
                OnPropertyChanged(nameof(End));
            }
        }        /// <summary>
        /// Managingentity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Managingentity 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Managingentity
        {
            get => _managingentity;
            set
            {
                _managingentity = value;
                OnPropertyChanged(nameof(Managingentity));
            }
        }        /// <summary>
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }        /// <summary>
        /// Filterby
        /// </summary>
        /// <remarks>
        /// <para>
        /// Filterby 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubscriptionFilterBy>? Filterby
        {
            get => _filterby;
            set
            {
                _filterby = value;
                OnPropertyChanged(nameof(Filterby));
            }
        }        /// <summary>
        /// Channeltype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Channeltype 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? Channeltype
        {
            get => _channeltype;
            set
            {
                _channeltype = value;
                OnPropertyChanged(nameof(Channeltype));
            }
        }        /// <summary>
        /// Endpoint
        /// </summary>
        /// <remarks>
        /// <para>
        /// Endpoint 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUrl? Endpoint
        {
            get => _endpoint;
            set
            {
                _endpoint = value;
                OnPropertyChanged(nameof(Endpoint));
            }
        }        /// <summary>
        /// Parameter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Parameter 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubscriptionParameter>? Parameter
        {
            get => _parameter;
            set
            {
                _parameter = value;
                OnPropertyChanged(nameof(Parameter));
            }
        }        /// <summary>
        /// Heartbeatperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Heartbeatperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? Heartbeatperiod
        {
            get => _heartbeatperiod;
            set
            {
                _heartbeatperiod = value;
                OnPropertyChanged(nameof(Heartbeatperiod));
            }
        }        /// <summary>
        /// Timeout
        /// </summary>
        /// <remarks>
        /// <para>
        /// Timeout 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? Timeout
        {
            get => _timeout;
            set
            {
                _timeout = value;
                OnPropertyChanged(nameof(Timeout));
            }
        }        /// <summary>
        /// Contenttype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contenttype 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Contenttype
        {
            get => _contenttype;
            set
            {
                _contenttype = value;
                OnPropertyChanged(nameof(Contenttype));
            }
        }        /// <summary>
        /// Content
        /// </summary>
        /// <remarks>
        /// <para>
        /// Content 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged(nameof(Content));
            }
        }        /// <summary>
        /// Maxcount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Maxcount 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Maxcount
        {
            get => _maxcount;
            set
            {
                _maxcount = value;
                OnPropertyChanged(nameof(Maxcount));
            }
        }        /// <summary>
        /// Resourcetype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resourcetype 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Resourcetype
        {
            get => _resourcetype;
            set
            {
                _resourcetype = value;
                OnPropertyChanged(nameof(Resourcetype));
            }
        }        /// <summary>
        /// Filterparameter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Filterparameter 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Filterparameter
        {
            get => _filterparameter;
            set
            {
                _filterparameter = value;
                OnPropertyChanged(nameof(Filterparameter));
            }
        }        /// <summary>
        /// Comparator
        /// </summary>
        /// <remarks>
        /// <para>
        /// Comparator 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Comparator
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
        public FhirCode? Modifier
        {
            get => _modifier;
            set
            {
                _modifier = value;
                OnPropertyChanged(nameof(Modifier));
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
        public FhirString? Name
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
        /// 建立新的 Subscription 資源實例
        /// </summary>
        public Subscription()
        {
        }

        /// <summary>
        /// 建立新的 Subscription 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Subscription(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Subscription(Id: {Id})";
        }
    }    /// <summary>
    /// SubscriptionFilterBy 背骨元素
    /// </summary>
    public class SubscriptionFilterBy
    {
        // TODO: 添加屬性實作
        
        public SubscriptionFilterBy() { }
    }    /// <summary>
    /// SubscriptionParameter 背骨元素
    /// </summary>
    public class SubscriptionParameter
    {
        // TODO: 添加屬性實作
        
        public SubscriptionParameter() { }
    }
}
