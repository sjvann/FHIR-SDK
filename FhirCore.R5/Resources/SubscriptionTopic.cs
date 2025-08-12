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
    /// FHIR R5 SubscriptionTopic 資源
    /// 
    /// <para>
    /// SubscriptionTopic 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var subscriptiontopic = new SubscriptionTopic("subscriptiontopic-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 SubscriptionTopic 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class SubscriptionTopic : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private SubscriptionTopicVersionAlgorithmChoice? _versionalgorithm;
        private FhirString? _name;
        private FhirString? _title;
        private List<FhirCanonical>? _derivedfrom;
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
        private FhirDate? _approvaldate;
        private FhirDate? _lastreviewdate;
        private Period? _effectiveperiod;
        private List<SubscriptionTopicResourceTrigger>? _resourcetrigger;
        private List<SubscriptionTopicEventTrigger>? _eventtrigger;
        private List<SubscriptionTopicCanFilterBy>? _canfilterby;
        private List<SubscriptionTopicNotificationShape>? _notificationshape;
        private FhirString? _previous;
        private FhirCode? _resultforcreate;
        private FhirString? _current;
        private FhirCode? _resultfordelete;
        private FhirBoolean? _requireboth;
        private FhirMarkdown? _description;
        private FhirUri? _resource;
        private List<FhirCode>? _supportedinteraction;
        private SubscriptionTopicResourceTriggerQueryCriteria? _querycriteria;
        private FhirString? _fhirpathcriteria;
        private FhirMarkdown? _description;
        private CodeableConcept? _event;
        private FhirUri? _resource;
        private FhirMarkdown? _description;
        private FhirUri? _resource;
        private FhirString? _filterparameter;
        private FhirUri? _filterdefinition;
        private List<FhirCode>? _comparator;
        private List<FhirCode>? _modifier;
        private FhirUri? _resource;
        private List<FhirString>? _include;
        private List<FhirString>? _revinclude;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "SubscriptionTopic";        /// <summary>
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
        public SubscriptionTopicVersionAlgorithmChoice? Versionalgorithm
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
        public List<FhirCanonical>? Derivedfrom
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
        /// Approvaldate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Approvaldate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Approvaldate
        {
            get => _approvaldate;
            set
            {
                _approvaldate = value;
                OnPropertyChanged(nameof(Approvaldate));
            }
        }        /// <summary>
        /// Lastreviewdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Lastreviewdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Lastreviewdate
        {
            get => _lastreviewdate;
            set
            {
                _lastreviewdate = value;
                OnPropertyChanged(nameof(Lastreviewdate));
            }
        }        /// <summary>
        /// Effectiveperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Effectiveperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Effectiveperiod
        {
            get => _effectiveperiod;
            set
            {
                _effectiveperiod = value;
                OnPropertyChanged(nameof(Effectiveperiod));
            }
        }        /// <summary>
        /// Resourcetrigger
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resourcetrigger 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubscriptionTopicResourceTrigger>? Resourcetrigger
        {
            get => _resourcetrigger;
            set
            {
                _resourcetrigger = value;
                OnPropertyChanged(nameof(Resourcetrigger));
            }
        }        /// <summary>
        /// Eventtrigger
        /// </summary>
        /// <remarks>
        /// <para>
        /// Eventtrigger 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubscriptionTopicEventTrigger>? Eventtrigger
        {
            get => _eventtrigger;
            set
            {
                _eventtrigger = value;
                OnPropertyChanged(nameof(Eventtrigger));
            }
        }        /// <summary>
        /// Canfilterby
        /// </summary>
        /// <remarks>
        /// <para>
        /// Canfilterby 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubscriptionTopicCanFilterBy>? Canfilterby
        {
            get => _canfilterby;
            set
            {
                _canfilterby = value;
                OnPropertyChanged(nameof(Canfilterby));
            }
        }        /// <summary>
        /// Notificationshape
        /// </summary>
        /// <remarks>
        /// <para>
        /// Notificationshape 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubscriptionTopicNotificationShape>? Notificationshape
        {
            get => _notificationshape;
            set
            {
                _notificationshape = value;
                OnPropertyChanged(nameof(Notificationshape));
            }
        }        /// <summary>
        /// Previous
        /// </summary>
        /// <remarks>
        /// <para>
        /// Previous 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Previous
        {
            get => _previous;
            set
            {
                _previous = value;
                OnPropertyChanged(nameof(Previous));
            }
        }        /// <summary>
        /// Resultforcreate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resultforcreate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Resultforcreate
        {
            get => _resultforcreate;
            set
            {
                _resultforcreate = value;
                OnPropertyChanged(nameof(Resultforcreate));
            }
        }        /// <summary>
        /// Current
        /// </summary>
        /// <remarks>
        /// <para>
        /// Current 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Current
        {
            get => _current;
            set
            {
                _current = value;
                OnPropertyChanged(nameof(Current));
            }
        }        /// <summary>
        /// Resultfordelete
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resultfordelete 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Resultfordelete
        {
            get => _resultfordelete;
            set
            {
                _resultfordelete = value;
                OnPropertyChanged(nameof(Resultfordelete));
            }
        }        /// <summary>
        /// Requireboth
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requireboth 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Requireboth
        {
            get => _requireboth;
            set
            {
                _requireboth = value;
                OnPropertyChanged(nameof(Requireboth));
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
        /// Resource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resource 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Resource
        {
            get => _resource;
            set
            {
                _resource = value;
                OnPropertyChanged(nameof(Resource));
            }
        }        /// <summary>
        /// Supportedinteraction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supportedinteraction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Supportedinteraction
        {
            get => _supportedinteraction;
            set
            {
                _supportedinteraction = value;
                OnPropertyChanged(nameof(Supportedinteraction));
            }
        }        /// <summary>
        /// Querycriteria
        /// </summary>
        /// <remarks>
        /// <para>
        /// Querycriteria 的詳細描述。
        /// </para>
        /// </remarks>
        public SubscriptionTopicResourceTriggerQueryCriteria? Querycriteria
        {
            get => _querycriteria;
            set
            {
                _querycriteria = value;
                OnPropertyChanged(nameof(Querycriteria));
            }
        }        /// <summary>
        /// Fhirpathcriteria
        /// </summary>
        /// <remarks>
        /// <para>
        /// Fhirpathcriteria 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Fhirpathcriteria
        {
            get => _fhirpathcriteria;
            set
            {
                _fhirpathcriteria = value;
                OnPropertyChanged(nameof(Fhirpathcriteria));
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
        /// Event
        /// </summary>
        /// <remarks>
        /// <para>
        /// Event 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Event
        {
            get => _event;
            set
            {
                _event = value;
                OnPropertyChanged(nameof(Event));
            }
        }        /// <summary>
        /// Resource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resource 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Resource
        {
            get => _resource;
            set
            {
                _resource = value;
                OnPropertyChanged(nameof(Resource));
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
        /// Resource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resource 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Resource
        {
            get => _resource;
            set
            {
                _resource = value;
                OnPropertyChanged(nameof(Resource));
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
        /// Filterdefinition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Filterdefinition 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Filterdefinition
        {
            get => _filterdefinition;
            set
            {
                _filterdefinition = value;
                OnPropertyChanged(nameof(Filterdefinition));
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
        /// Resource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resource 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Resource
        {
            get => _resource;
            set
            {
                _resource = value;
                OnPropertyChanged(nameof(Resource));
            }
        }        /// <summary>
        /// Include
        /// </summary>
        /// <remarks>
        /// <para>
        /// Include 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Include
        {
            get => _include;
            set
            {
                _include = value;
                OnPropertyChanged(nameof(Include));
            }
        }        /// <summary>
        /// Revinclude
        /// </summary>
        /// <remarks>
        /// <para>
        /// Revinclude 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Revinclude
        {
            get => _revinclude;
            set
            {
                _revinclude = value;
                OnPropertyChanged(nameof(Revinclude));
            }
        }        /// <summary>
        /// 建立新的 SubscriptionTopic 資源實例
        /// </summary>
        public SubscriptionTopic()
        {
        }

        /// <summary>
        /// 建立新的 SubscriptionTopic 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public SubscriptionTopic(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"SubscriptionTopic(Id: {Id})";
        }
    }    /// <summary>
    /// SubscriptionTopicResourceTriggerQueryCriteria 背骨元素
    /// </summary>
    public class SubscriptionTopicResourceTriggerQueryCriteria
    {
        // TODO: 添加屬性實作
        
        public SubscriptionTopicResourceTriggerQueryCriteria() { }
    }    /// <summary>
    /// SubscriptionTopicResourceTrigger 背骨元素
    /// </summary>
    public class SubscriptionTopicResourceTrigger
    {
        // TODO: 添加屬性實作
        
        public SubscriptionTopicResourceTrigger() { }
    }    /// <summary>
    /// SubscriptionTopicEventTrigger 背骨元素
    /// </summary>
    public class SubscriptionTopicEventTrigger
    {
        // TODO: 添加屬性實作
        
        public SubscriptionTopicEventTrigger() { }
    }    /// <summary>
    /// SubscriptionTopicCanFilterBy 背骨元素
    /// </summary>
    public class SubscriptionTopicCanFilterBy
    {
        // TODO: 添加屬性實作
        
        public SubscriptionTopicCanFilterBy() { }
    }    /// <summary>
    /// SubscriptionTopicNotificationShape 背骨元素
    /// </summary>
    public class SubscriptionTopicNotificationShape
    {
        // TODO: 添加屬性實作
        
        public SubscriptionTopicNotificationShape() { }
    }    /// <summary>
    /// SubscriptionTopicVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class SubscriptionTopicVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public SubscriptionTopicVersionAlgorithmChoice(JsonObject value) : base("subscriptiontopicversionalgorithm", value, _supportType) { }
        public SubscriptionTopicVersionAlgorithmChoice(IComplexType? value) : base("subscriptiontopicversionalgorithm", value) { }
        public SubscriptionTopicVersionAlgorithmChoice(IPrimitiveType? value) : base("subscriptiontopicversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "SubscriptionTopicVersionAlgorithm" : "subscriptiontopicversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
