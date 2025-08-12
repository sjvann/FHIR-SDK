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
    /// FHIR R5 DeviceRequest 資源
    /// 
    /// <para>
    /// DeviceRequest 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var devicerequest = new DeviceRequest("devicerequest-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 DeviceRequest 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class DeviceRequest : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<FhirCanonical>? _instantiatescanonical;
        private List<FhirUri>? _instantiatesuri;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _replaces;
        private Identifier? _groupidentifier;
        private FhirCode? _status;
        private FhirCode? _intent;
        private FhirCode? _priority;
        private FhirBoolean? _donotperform;
        private CodeableReference? _code;
        private FhirInteger? _quantity;
        private List<DeviceRequestParameter>? _parameter;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private DeviceRequestOccurrenceChoice? _occurrence;
        private FhirDateTime? _authoredon;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _requester;
        private CodeableReference? _performer;
        private List<CodeableReference>? _reason;
        private FhirBoolean? _asneeded;
        private CodeableConcept? _asneededfor;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _insurance;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _supportinginfo;
        private List<Annotation>? _note;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _relevanthistory;
        private CodeableConcept? _code;
        private DeviceRequestParameterValueChoice? _value;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "DeviceRequest";        /// <summary>
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
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }        /// <summary>
        /// Parameter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Parameter 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DeviceRequestParameter>? Parameter
        {
            get => _parameter;
            set
            {
                _parameter = value;
                OnPropertyChanged(nameof(Parameter));
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
        /// Occurrence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Occurrence 的詳細描述。
        /// </para>
        /// </remarks>
        public DeviceRequestOccurrenceChoice? Occurrence
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
        /// Performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performer 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(Performer));
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
        /// Asneeded
        /// </summary>
        /// <remarks>
        /// <para>
        /// Asneeded 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Asneeded
        {
            get => _asneeded;
            set
            {
                _asneeded = value;
                OnPropertyChanged(nameof(Asneeded));
            }
        }        /// <summary>
        /// Asneededfor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Asneededfor 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Asneededfor
        {
            get => _asneededfor;
            set
            {
                _asneededfor = value;
                OnPropertyChanged(nameof(Asneededfor));
            }
        }        /// <summary>
        /// Insurance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Insurance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Insurance
        {
            get => _insurance;
            set
            {
                _insurance = value;
                OnPropertyChanged(nameof(Insurance));
            }
        }        /// <summary>
        /// Supportinginfo
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supportinginfo 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Supportinginfo
        {
            get => _supportinginfo;
            set
            {
                _supportinginfo = value;
                OnPropertyChanged(nameof(Supportinginfo));
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
        /// Relevanthistory
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relevanthistory 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Relevanthistory
        {
            get => _relevanthistory;
            set
            {
                _relevanthistory = value;
                OnPropertyChanged(nameof(Relevanthistory));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public DeviceRequestParameterValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// 建立新的 DeviceRequest 資源實例
        /// </summary>
        public DeviceRequest()
        {
        }

        /// <summary>
        /// 建立新的 DeviceRequest 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public DeviceRequest(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"DeviceRequest(Id: {Id})";
        }
    }    /// <summary>
    /// DeviceRequestParameter 背骨元素
    /// </summary>
    public class DeviceRequestParameter
    {
        // TODO: 添加屬性實作
        
        public DeviceRequestParameter() { }
    }    /// <summary>
    /// DeviceRequestParameterValueChoice 選擇類型
    /// </summary>
    public class DeviceRequestParameterValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public DeviceRequestParameterValueChoice(JsonObject value) : base("devicerequestparametervalue", value, _supportType) { }
        public DeviceRequestParameterValueChoice(IComplexType? value) : base("devicerequestparametervalue", value) { }
        public DeviceRequestParameterValueChoice(IPrimitiveType? value) : base("devicerequestparametervalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "DeviceRequestParameterValue" : "devicerequestparametervalue";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// DeviceRequestOccurrenceChoice 選擇類型
    /// </summary>
    public class DeviceRequestOccurrenceChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public DeviceRequestOccurrenceChoice(JsonObject value) : base("devicerequestoccurrence", value, _supportType) { }
        public DeviceRequestOccurrenceChoice(IComplexType? value) : base("devicerequestoccurrence", value) { }
        public DeviceRequestOccurrenceChoice(IPrimitiveType? value) : base("devicerequestoccurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "DeviceRequestOccurrence" : "devicerequestoccurrence";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
