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
    /// FHIR R5 PackagedProductDefinition 資源
    /// 
    /// <para>
    /// PackagedProductDefinition 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var packagedproductdefinition = new PackagedProductDefinition("packagedproductdefinition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 PackagedProductDefinition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class PackagedProductDefinition : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirString? _name;
        private CodeableConcept? _type;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _packagefor;
        private CodeableConcept? _status;
        private FhirDateTime? _statusdate;
        private List<Quantity>? _containeditemquantity;
        private FhirMarkdown? _description;
        private List<PackagedProductDefinitionLegalStatusOfSupply>? _legalstatusofsupply;
        private List<MarketingStatus>? _marketingstatus;
        private FhirBoolean? _copackagedindicator;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _manufacturer;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _attacheddocument;
        private PackagedProductDefinitionPackaging? _packaging;
        private CodeableConcept? _code;
        private CodeableConcept? _jurisdiction;
        private CodeableConcept? _type;
        private PackagedProductDefinitionPackagingPropertyValueChoice? _value;
        private CodeableReference? _item;
        private Quantity? _amount;
        private List<Identifier>? _identifier;
        private CodeableConcept? _type;
        private FhirBoolean? _componentpart;
        private FhirInteger? _quantity;
        private List<CodeableConcept>? _material;
        private List<CodeableConcept>? _alternatematerial;
        private List<ProductShelfLife>? _shelflifestorage;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _manufacturer;
        private List<PackagedProductDefinitionPackagingProperty>? _property;
        private List<PackagedProductDefinitionPackagingContainedItem>? _containeditem;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "PackagedProductDefinition";        /// <summary>
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
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Packagefor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Packagefor 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Packagefor
        {
            get => _packagefor;
            set
            {
                _packagefor = value;
                OnPropertyChanged(nameof(Packagefor));
            }
        }        /// <summary>
        /// Status
        /// </summary>
        /// <remarks>
        /// <para>
        /// Status 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }        /// <summary>
        /// Statusdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Statusdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Statusdate
        {
            get => _statusdate;
            set
            {
                _statusdate = value;
                OnPropertyChanged(nameof(Statusdate));
            }
        }        /// <summary>
        /// Containeditemquantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Containeditemquantity 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Quantity>? Containeditemquantity
        {
            get => _containeditemquantity;
            set
            {
                _containeditemquantity = value;
                OnPropertyChanged(nameof(Containeditemquantity));
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
        /// Legalstatusofsupply
        /// </summary>
        /// <remarks>
        /// <para>
        /// Legalstatusofsupply 的詳細描述。
        /// </para>
        /// </remarks>
        public List<PackagedProductDefinitionLegalStatusOfSupply>? Legalstatusofsupply
        {
            get => _legalstatusofsupply;
            set
            {
                _legalstatusofsupply = value;
                OnPropertyChanged(nameof(Legalstatusofsupply));
            }
        }        /// <summary>
        /// Marketingstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Marketingstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MarketingStatus>? Marketingstatus
        {
            get => _marketingstatus;
            set
            {
                _marketingstatus = value;
                OnPropertyChanged(nameof(Marketingstatus));
            }
        }        /// <summary>
        /// Copackagedindicator
        /// </summary>
        /// <remarks>
        /// <para>
        /// Copackagedindicator 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Copackagedindicator
        {
            get => _copackagedindicator;
            set
            {
                _copackagedindicator = value;
                OnPropertyChanged(nameof(Copackagedindicator));
            }
        }        /// <summary>
        /// Manufacturer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Manufacturer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Manufacturer
        {
            get => _manufacturer;
            set
            {
                _manufacturer = value;
                OnPropertyChanged(nameof(Manufacturer));
            }
        }        /// <summary>
        /// Attacheddocument
        /// </summary>
        /// <remarks>
        /// <para>
        /// Attacheddocument 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Attacheddocument
        {
            get => _attacheddocument;
            set
            {
                _attacheddocument = value;
                OnPropertyChanged(nameof(Attacheddocument));
            }
        }        /// <summary>
        /// Packaging
        /// </summary>
        /// <remarks>
        /// <para>
        /// Packaging 的詳細描述。
        /// </para>
        /// </remarks>
        public PackagedProductDefinitionPackaging? Packaging
        {
            get => _packaging;
            set
            {
                _packaging = value;
                OnPropertyChanged(nameof(Packaging));
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
        /// Jurisdiction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Jurisdiction 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Jurisdiction
        {
            get => _jurisdiction;
            set
            {
                _jurisdiction = value;
                OnPropertyChanged(nameof(Jurisdiction));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public PackagedProductDefinitionPackagingPropertyValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Item
        /// </summary>
        /// <remarks>
        /// <para>
        /// Item 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged(nameof(Item));
            }
        }        /// <summary>
        /// Amount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Amount 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
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
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Componentpart
        /// </summary>
        /// <remarks>
        /// <para>
        /// Componentpart 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Componentpart
        {
            get => _componentpart;
            set
            {
                _componentpart = value;
                OnPropertyChanged(nameof(Componentpart));
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
        /// Material
        /// </summary>
        /// <remarks>
        /// <para>
        /// Material 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Material
        {
            get => _material;
            set
            {
                _material = value;
                OnPropertyChanged(nameof(Material));
            }
        }        /// <summary>
        /// Alternatematerial
        /// </summary>
        /// <remarks>
        /// <para>
        /// Alternatematerial 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Alternatematerial
        {
            get => _alternatematerial;
            set
            {
                _alternatematerial = value;
                OnPropertyChanged(nameof(Alternatematerial));
            }
        }        /// <summary>
        /// Shelflifestorage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Shelflifestorage 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ProductShelfLife>? Shelflifestorage
        {
            get => _shelflifestorage;
            set
            {
                _shelflifestorage = value;
                OnPropertyChanged(nameof(Shelflifestorage));
            }
        }        /// <summary>
        /// Manufacturer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Manufacturer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Manufacturer
        {
            get => _manufacturer;
            set
            {
                _manufacturer = value;
                OnPropertyChanged(nameof(Manufacturer));
            }
        }        /// <summary>
        /// Property
        /// </summary>
        /// <remarks>
        /// <para>
        /// Property 的詳細描述。
        /// </para>
        /// </remarks>
        public List<PackagedProductDefinitionPackagingProperty>? Property
        {
            get => _property;
            set
            {
                _property = value;
                OnPropertyChanged(nameof(Property));
            }
        }        /// <summary>
        /// Containeditem
        /// </summary>
        /// <remarks>
        /// <para>
        /// Containeditem 的詳細描述。
        /// </para>
        /// </remarks>
        public List<PackagedProductDefinitionPackagingContainedItem>? Containeditem
        {
            get => _containeditem;
            set
            {
                _containeditem = value;
                OnPropertyChanged(nameof(Containeditem));
            }
        }        /// <summary>
        /// 建立新的 PackagedProductDefinition 資源實例
        /// </summary>
        public PackagedProductDefinition()
        {
        }

        /// <summary>
        /// 建立新的 PackagedProductDefinition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public PackagedProductDefinition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"PackagedProductDefinition(Id: {Id})";
        }
    }    /// <summary>
    /// PackagedProductDefinitionLegalStatusOfSupply 背骨元素
    /// </summary>
    public class PackagedProductDefinitionLegalStatusOfSupply
    {
        // TODO: 添加屬性實作
        
        public PackagedProductDefinitionLegalStatusOfSupply() { }
    }    /// <summary>
    /// PackagedProductDefinitionPackagingProperty 背骨元素
    /// </summary>
    public class PackagedProductDefinitionPackagingProperty
    {
        // TODO: 添加屬性實作
        
        public PackagedProductDefinitionPackagingProperty() { }
    }    /// <summary>
    /// PackagedProductDefinitionPackagingContainedItem 背骨元素
    /// </summary>
    public class PackagedProductDefinitionPackagingContainedItem
    {
        // TODO: 添加屬性實作
        
        public PackagedProductDefinitionPackagingContainedItem() { }
    }    /// <summary>
    /// PackagedProductDefinitionPackaging 背骨元素
    /// </summary>
    public class PackagedProductDefinitionPackaging
    {
        // TODO: 添加屬性實作
        
        public PackagedProductDefinitionPackaging() { }
    }    /// <summary>
    /// PackagedProductDefinitionPackagingPropertyValueChoice 選擇類型
    /// </summary>
    public class PackagedProductDefinitionPackagingPropertyValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public PackagedProductDefinitionPackagingPropertyValueChoice(JsonObject value) : base("packagedproductdefinitionpackagingpropertyvalue", value, _supportType) { }
        public PackagedProductDefinitionPackagingPropertyValueChoice(IComplexType? value) : base("packagedproductdefinitionpackagingpropertyvalue", value) { }
        public PackagedProductDefinitionPackagingPropertyValueChoice(IPrimitiveType? value) : base("packagedproductdefinitionpackagingpropertyvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "PackagedProductDefinitionPackagingPropertyValue" : "packagedproductdefinitionpackagingpropertyvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
