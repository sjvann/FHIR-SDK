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
    /// FHIR R5 SubscriptionStatus 資源
    /// 
    /// <para>
    /// SubscriptionStatus 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var subscriptionstatus = new SubscriptionStatus("subscriptionstatus-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 SubscriptionStatus 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class SubscriptionStatus : ResourceBase<R5Version>
    {
        private Property
		private FhirCode? _status;
        private FhirCode? _type;
        private FhirInteger64? _eventssincesubscriptionstart;
        private List<SubscriptionStatusNotificationEvent>? _notificationevent;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subscription;
        private FhirCanonical? _topic;
        private List<CodeableConcept>? _error;
        private FhirInteger64? _eventnumber;
        private FhirInstant? _timestamp;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _focus;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _additionalcontext;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "SubscriptionStatus";        /// <summary>
        /// Status
        /// </summary>
        /// <remarks>
        /// <para>
        /// Status 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private FhirCode? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
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
        /// Eventssincesubscriptionstart
        /// </summary>
        /// <remarks>
        /// <para>
        /// Eventssincesubscriptionstart 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger64? Eventssincesubscriptionstart
        {
            get => _eventssincesubscriptionstart;
            set
            {
                _eventssincesubscriptionstart = value;
                OnPropertyChanged(nameof(Eventssincesubscriptionstart));
            }
        }        /// <summary>
        /// Notificationevent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Notificationevent 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubscriptionStatusNotificationEvent>? Notificationevent
        {
            get => _notificationevent;
            set
            {
                _notificationevent = value;
                OnPropertyChanged(nameof(Notificationevent));
            }
        }        /// <summary>
        /// Subscription
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subscription 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Subscription
        {
            get => _subscription;
            set
            {
                _subscription = value;
                OnPropertyChanged(nameof(Subscription));
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
        /// Error
        /// </summary>
        /// <remarks>
        /// <para>
        /// Error 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Error
        {
            get => _error;
            set
            {
                _error = value;
                OnPropertyChanged(nameof(Error));
            }
        }        /// <summary>
        /// Eventnumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Eventnumber 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger64? Eventnumber
        {
            get => _eventnumber;
            set
            {
                _eventnumber = value;
                OnPropertyChanged(nameof(Eventnumber));
            }
        }        /// <summary>
        /// Timestamp
        /// </summary>
        /// <remarks>
        /// <para>
        /// Timestamp 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInstant? Timestamp
        {
            get => _timestamp;
            set
            {
                _timestamp = value;
                OnPropertyChanged(nameof(Timestamp));
            }
        }        /// <summary>
        /// Focus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Focus 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Focus
        {
            get => _focus;
            set
            {
                _focus = value;
                OnPropertyChanged(nameof(Focus));
            }
        }        /// <summary>
        /// Additionalcontext
        /// </summary>
        /// <remarks>
        /// <para>
        /// Additionalcontext 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Additionalcontext
        {
            get => _additionalcontext;
            set
            {
                _additionalcontext = value;
                OnPropertyChanged(nameof(Additionalcontext));
            }
        }        /// <summary>
        /// 建立新的 SubscriptionStatus 資源實例
        /// </summary>
        public SubscriptionStatus()
        {
        }

        /// <summary>
        /// 建立新的 SubscriptionStatus 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public SubscriptionStatus(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"SubscriptionStatus(Id: {Id})";
        }
    }    /// <summary>
    /// SubscriptionStatusNotificationEvent 背骨元素
    /// </summary>
    public class SubscriptionStatusNotificationEvent
    {
        // TODO: 添加屬性實作
        
        public SubscriptionStatusNotificationEvent() { }
    }
}
