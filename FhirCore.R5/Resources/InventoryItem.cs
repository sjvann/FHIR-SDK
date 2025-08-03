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
    /// FHIR R5 InventoryItem 資源
    /// 
    /// <para>
    /// InventoryItem 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var inventoryitem = new InventoryItem("inventoryitem-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 InventoryItem 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class InventoryItem : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private List<CodeableConcept>? _category;
        private List<CodeableConcept>? _code;
        private List<InventoryItemName>? _name;
        private List<InventoryItemResponsibleOrganization>? _responsibleorganization;
        private InventoryItemDescription? _description;
        private List<CodeableConcept>? _inventorystatus;
        private CodeableConcept? _baseunit;
        private Quantity? _netcontent;
        private List<InventoryItemAssociation>? _association;
        private List<InventoryItemCharacteristic>? _characteristic;
        private InventoryItemInstance? _instance;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _productreference;
        private Coding? _nametype;
        private FhirCode? _language;
        private FhirString? _name;
        private CodeableConcept? _role;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _organization;
        private FhirCode? _language;
        private FhirString? _description;
        private CodeableConcept? _associationtype;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _relateditem;
        private Ratio? _quantity;
        private CodeableConcept? _characteristictype;
        private InventoryItemCharacteristicValueChoice? _value;
        private List<Identifier>? _identifier;
        private FhirString? _lotnumber;
        private FhirDateTime? _expiry;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _location;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "InventoryItem";        /// <summary>
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
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public List<InventoryItemName>? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Responsibleorganization
        /// </summary>
        /// <remarks>
        /// <para>
        /// Responsibleorganization 的詳細描述。
        /// </para>
        /// </remarks>
        public List<InventoryItemResponsibleOrganization>? Responsibleorganization
        {
            get => _responsibleorganization;
            set
            {
                _responsibleorganization = value;
                OnPropertyChanged(nameof(Responsibleorganization));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public InventoryItemDescription? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Inventorystatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Inventorystatus 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Inventorystatus
        {
            get => _inventorystatus;
            set
            {
                _inventorystatus = value;
                OnPropertyChanged(nameof(Inventorystatus));
            }
        }        /// <summary>
        /// Baseunit
        /// </summary>
        /// <remarks>
        /// <para>
        /// Baseunit 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Baseunit
        {
            get => _baseunit;
            set
            {
                _baseunit = value;
                OnPropertyChanged(nameof(Baseunit));
            }
        }        /// <summary>
        /// Netcontent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Netcontent 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Netcontent
        {
            get => _netcontent;
            set
            {
                _netcontent = value;
                OnPropertyChanged(nameof(Netcontent));
            }
        }        /// <summary>
        /// Association
        /// </summary>
        /// <remarks>
        /// <para>
        /// Association 的詳細描述。
        /// </para>
        /// </remarks>
        public List<InventoryItemAssociation>? Association
        {
            get => _association;
            set
            {
                _association = value;
                OnPropertyChanged(nameof(Association));
            }
        }        /// <summary>
        /// Characteristic
        /// </summary>
        /// <remarks>
        /// <para>
        /// Characteristic 的詳細描述。
        /// </para>
        /// </remarks>
        public List<InventoryItemCharacteristic>? Characteristic
        {
            get => _characteristic;
            set
            {
                _characteristic = value;
                OnPropertyChanged(nameof(Characteristic));
            }
        }        /// <summary>
        /// Instance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instance 的詳細描述。
        /// </para>
        /// </remarks>
        public InventoryItemInstance? Instance
        {
            get => _instance;
            set
            {
                _instance = value;
                OnPropertyChanged(nameof(Instance));
            }
        }        /// <summary>
        /// Productreference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productreference 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Productreference
        {
            get => _productreference;
            set
            {
                _productreference = value;
                OnPropertyChanged(nameof(Productreference));
            }
        }        /// <summary>
        /// Nametype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Nametype 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? Nametype
        {
            get => _nametype;
            set
            {
                _nametype = value;
                OnPropertyChanged(nameof(Nametype));
            }
        }        /// <summary>
        /// Language
        /// </summary>
        /// <remarks>
        /// <para>
        /// Language 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Language
        {
            get => _language;
            set
            {
                _language = value;
                OnPropertyChanged(nameof(Language));
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
        /// Role
        /// </summary>
        /// <remarks>
        /// <para>
        /// Role 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Role
        {
            get => _role;
            set
            {
                _role = value;
                OnPropertyChanged(nameof(Role));
            }
        }        /// <summary>
        /// Organization
        /// </summary>
        /// <remarks>
        /// <para>
        /// Organization 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Organization
        {
            get => _organization;
            set
            {
                _organization = value;
                OnPropertyChanged(nameof(Organization));
            }
        }        /// <summary>
        /// Language
        /// </summary>
        /// <remarks>
        /// <para>
        /// Language 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Language
        {
            get => _language;
            set
            {
                _language = value;
                OnPropertyChanged(nameof(Language));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Associationtype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Associationtype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Associationtype
        {
            get => _associationtype;
            set
            {
                _associationtype = value;
                OnPropertyChanged(nameof(Associationtype));
            }
        }        /// <summary>
        /// Relateditem
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relateditem 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Relateditem
        {
            get => _relateditem;
            set
            {
                _relateditem = value;
                OnPropertyChanged(nameof(Relateditem));
            }
        }        /// <summary>
        /// Quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Ratio? Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }        /// <summary>
        /// Characteristictype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Characteristictype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Characteristictype
        {
            get => _characteristictype;
            set
            {
                _characteristictype = value;
                OnPropertyChanged(nameof(Characteristictype));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public InventoryItemCharacteristicValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
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
        /// Lotnumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Lotnumber 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Lotnumber
        {
            get => _lotnumber;
            set
            {
                _lotnumber = value;
                OnPropertyChanged(nameof(Lotnumber));
            }
        }        /// <summary>
        /// Expiry
        /// </summary>
        /// <remarks>
        /// <para>
        /// Expiry 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Expiry
        {
            get => _expiry;
            set
            {
                _expiry = value;
                OnPropertyChanged(nameof(Expiry));
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
        /// Location
        /// </summary>
        /// <remarks>
        /// <para>
        /// Location 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }        /// <summary>
        /// 建立新的 InventoryItem 資源實例
        /// </summary>
        public InventoryItem()
        {
        }

        /// <summary>
        /// 建立新的 InventoryItem 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public InventoryItem(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"InventoryItem(Id: {Id})";
        }
    }    /// <summary>
    /// InventoryItemName 背骨元素
    /// </summary>
    public class InventoryItemName
    {
        // TODO: 添加屬性實作
        
        public InventoryItemName() { }
    }    /// <summary>
    /// InventoryItemResponsibleOrganization 背骨元素
    /// </summary>
    public class InventoryItemResponsibleOrganization
    {
        // TODO: 添加屬性實作
        
        public InventoryItemResponsibleOrganization() { }
    }    /// <summary>
    /// InventoryItemDescription 背骨元素
    /// </summary>
    public class InventoryItemDescription
    {
        // TODO: 添加屬性實作
        
        public InventoryItemDescription() { }
    }    /// <summary>
    /// InventoryItemAssociation 背骨元素
    /// </summary>
    public class InventoryItemAssociation
    {
        // TODO: 添加屬性實作
        
        public InventoryItemAssociation() { }
    }    /// <summary>
    /// InventoryItemCharacteristic 背骨元素
    /// </summary>
    public class InventoryItemCharacteristic
    {
        // TODO: 添加屬性實作
        
        public InventoryItemCharacteristic() { }
    }    /// <summary>
    /// InventoryItemInstance 背骨元素
    /// </summary>
    public class InventoryItemInstance
    {
        // TODO: 添加屬性實作
        
        public InventoryItemInstance() { }
    }    /// <summary>
    /// InventoryItemCharacteristicValueChoice 選擇類型
    /// </summary>
    public class InventoryItemCharacteristicValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public InventoryItemCharacteristicValueChoice(JsonObject value) : base("inventoryitemcharacteristicvalue", value, _supportType) { }
        public InventoryItemCharacteristicValueChoice(IComplexType? value) : base("inventoryitemcharacteristicvalue", value) { }
        public InventoryItemCharacteristicValueChoice(IPrimitiveType? value) : base("inventoryitemcharacteristicvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "InventoryItemCharacteristicValue" : "inventoryitemcharacteristicvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
