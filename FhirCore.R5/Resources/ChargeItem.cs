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
    /// FHIR R5 ChargeItem 資源
    /// 
    /// <para>
    /// ChargeItem 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var chargeitem = new ChargeItem("chargeitem-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 ChargeItem 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ChargeItem : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<FhirUri>? _definitionuri;
        private List<FhirCanonical>? _definitioncanonical;
        private FhirCode? _status;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _partof;
        private CodeableConcept? _code;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private ChargeItemOccurrenceChoice? _occurrence;
        private List<ChargeItemPerformer>? _performer;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _performingorganization;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _requestingorganization;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _costcenter;
        private Quantity? _quantity;
        private List<CodeableConcept>? _bodysite;
        private MonetaryComponent? _unitpricecomponent;
        private MonetaryComponent? _totalpricecomponent;
        private CodeableConcept? _overridereason;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _enterer;
        private FhirDateTime? _entereddate;
        private List<CodeableConcept>? _reason;
        private List<CodeableReference>? _service;
        private List<CodeableReference>? _product;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _account;
        private List<Annotation>? _note;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _supportinginformation;
        private CodeableConcept? _function;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _actor;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ChargeItem";        /// <summary>
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
        /// Definitionuri
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definitionuri 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUri>? Definitionuri
        {
            get => _definitionuri;
            set
            {
                _definitionuri = value;
                OnPropertyChanged(nameof(Definitionuri));
            }
        }        /// <summary>
        /// Definitioncanonical
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definitioncanonical 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Definitioncanonical
        {
            get => _definitioncanonical;
            set
            {
                _definitioncanonical = value;
                OnPropertyChanged(nameof(Definitioncanonical));
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
        public ChargeItemOccurrenceChoice? Occurrence
        {
            get => _occurrence;
            set
            {
                _occurrence = value;
                OnPropertyChanged(nameof(Occurrence));
            }
        }        /// <summary>
        /// Performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ChargeItemPerformer>? Performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(Performer));
            }
        }        /// <summary>
        /// Performingorganization
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performingorganization 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Performingorganization
        {
            get => _performingorganization;
            set
            {
                _performingorganization = value;
                OnPropertyChanged(nameof(Performingorganization));
            }
        }        /// <summary>
        /// Requestingorganization
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requestingorganization 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Requestingorganization
        {
            get => _requestingorganization;
            set
            {
                _requestingorganization = value;
                OnPropertyChanged(nameof(Requestingorganization));
            }
        }        /// <summary>
        /// Costcenter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Costcenter 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Costcenter
        {
            get => _costcenter;
            set
            {
                _costcenter = value;
                OnPropertyChanged(nameof(Costcenter));
            }
        }        /// <summary>
        /// Quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }        /// <summary>
        /// Bodysite
        /// </summary>
        /// <remarks>
        /// <para>
        /// Bodysite 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Bodysite
        {
            get => _bodysite;
            set
            {
                _bodysite = value;
                OnPropertyChanged(nameof(Bodysite));
            }
        }        /// <summary>
        /// Unitpricecomponent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Unitpricecomponent 的詳細描述。
        /// </para>
        /// </remarks>
        public MonetaryComponent? Unitpricecomponent
        {
            get => _unitpricecomponent;
            set
            {
                _unitpricecomponent = value;
                OnPropertyChanged(nameof(Unitpricecomponent));
            }
        }        /// <summary>
        /// Totalpricecomponent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Totalpricecomponent 的詳細描述。
        /// </para>
        /// </remarks>
        public MonetaryComponent? Totalpricecomponent
        {
            get => _totalpricecomponent;
            set
            {
                _totalpricecomponent = value;
                OnPropertyChanged(nameof(Totalpricecomponent));
            }
        }        /// <summary>
        /// Overridereason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Overridereason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Overridereason
        {
            get => _overridereason;
            set
            {
                _overridereason = value;
                OnPropertyChanged(nameof(Overridereason));
            }
        }        /// <summary>
        /// Enterer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Enterer 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Enterer
        {
            get => _enterer;
            set
            {
                _enterer = value;
                OnPropertyChanged(nameof(Enterer));
            }
        }        /// <summary>
        /// Entereddate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Entereddate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Entereddate
        {
            get => _entereddate;
            set
            {
                _entereddate = value;
                OnPropertyChanged(nameof(Entereddate));
            }
        }        /// <summary>
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }        /// <summary>
        /// Service
        /// </summary>
        /// <remarks>
        /// <para>
        /// Service 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Service
        {
            get => _service;
            set
            {
                _service = value;
                OnPropertyChanged(nameof(Service));
            }
        }        /// <summary>
        /// Product
        /// </summary>
        /// <remarks>
        /// <para>
        /// Product 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Product
        {
            get => _product;
            set
            {
                _product = value;
                OnPropertyChanged(nameof(Product));
            }
        }        /// <summary>
        /// Account
        /// </summary>
        /// <remarks>
        /// <para>
        /// Account 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Account
        {
            get => _account;
            set
            {
                _account = value;
                OnPropertyChanged(nameof(Account));
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
        /// Supportinginformation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supportinginformation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Supportinginformation
        {
            get => _supportinginformation;
            set
            {
                _supportinginformation = value;
                OnPropertyChanged(nameof(Supportinginformation));
            }
        }        /// <summary>
        /// Function
        /// </summary>
        /// <remarks>
        /// <para>
        /// Function 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Function
        {
            get => _function;
            set
            {
                _function = value;
                OnPropertyChanged(nameof(Function));
            }
        }        /// <summary>
        /// Actor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Actor 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Actor
        {
            get => _actor;
            set
            {
                _actor = value;
                OnPropertyChanged(nameof(Actor));
            }
        }        /// <summary>
        /// 建立新的 ChargeItem 資源實例
        /// </summary>
        public ChargeItem()
        {
        }

        /// <summary>
        /// 建立新的 ChargeItem 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ChargeItem(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ChargeItem(Id: {Id})";
        }
    }    /// <summary>
    /// ChargeItemPerformer 背骨元素
    /// </summary>
    public class ChargeItemPerformer
    {
        // TODO: 添加屬性實作
        
        public ChargeItemPerformer() { }
    }    /// <summary>
    /// ChargeItemOccurrenceChoice 選擇類型
    /// </summary>
    public class ChargeItemOccurrenceChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ChargeItemOccurrenceChoice(JsonObject value) : base("chargeitemoccurrence", value, _supportType) { }
        public ChargeItemOccurrenceChoice(IComplexType? value) : base("chargeitemoccurrence", value) { }
        public ChargeItemOccurrenceChoice(IPrimitiveType? value) : base("chargeitemoccurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ChargeItemOccurrence" : "chargeitemoccurrence";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
