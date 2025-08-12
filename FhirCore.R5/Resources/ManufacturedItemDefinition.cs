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
    /// FHIR R5 ManufacturedItemDefinition 資源
    /// 
    /// <para>
    /// ManufacturedItemDefinition 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var manufactureditemdefinition = new ManufacturedItemDefinition("manufactureditemdefinition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 ManufacturedItemDefinition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ManufacturedItemDefinition : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private FhirString? _name;
        private CodeableConcept? _manufactureddoseform;
        private CodeableConcept? _unitofpresentation;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _manufacturer;
        private List<MarketingStatus>? _marketingstatus;
        private List<CodeableConcept>? _ingredient;
        private List<ManufacturedItemDefinitionProperty>? _property;
        private List<ManufacturedItemDefinitionComponent>? _component;
        private CodeableConcept? _type;
        private ManufacturedItemDefinitionPropertyValueChoice? _value;
        private List<Quantity>? _amount;
        private List<CodeableConcept>? _location;
        private List<CodeableConcept>? _function;
        private List<CodeableReference>? _hasingredient;
        private CodeableConcept? _type;
        private List<CodeableConcept>? _function;
        private List<Quantity>? _amount;
        private List<ManufacturedItemDefinitionComponentConstituent>? _constituent;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ManufacturedItemDefinition";        /// <summary>
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
        /// Manufactureddoseform
        /// </summary>
        /// <remarks>
        /// <para>
        /// Manufactureddoseform 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Manufactureddoseform
        {
            get => _manufactureddoseform;
            set
            {
                _manufactureddoseform = value;
                OnPropertyChanged(nameof(Manufactureddoseform));
            }
        }        /// <summary>
        /// Unitofpresentation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Unitofpresentation 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Unitofpresentation
        {
            get => _unitofpresentation;
            set
            {
                _unitofpresentation = value;
                OnPropertyChanged(nameof(Unitofpresentation));
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
        /// Ingredient
        /// </summary>
        /// <remarks>
        /// <para>
        /// Ingredient 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Ingredient
        {
            get => _ingredient;
            set
            {
                _ingredient = value;
                OnPropertyChanged(nameof(Ingredient));
            }
        }        /// <summary>
        /// Property
        /// </summary>
        /// <remarks>
        /// <para>
        /// Property 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ManufacturedItemDefinitionProperty>? Property
        {
            get => _property;
            set
            {
                _property = value;
                OnPropertyChanged(nameof(Property));
            }
        }        /// <summary>
        /// Component
        /// </summary>
        /// <remarks>
        /// <para>
        /// Component 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ManufacturedItemDefinitionComponent>? Component
        {
            get => _component;
            set
            {
                _component = value;
                OnPropertyChanged(nameof(Component));
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
        public ManufacturedItemDefinitionPropertyValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Amount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Amount 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Quantity>? Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }        /// <summary>
        /// Location
        /// </summary>
        /// <remarks>
        /// <para>
        /// Location 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }        /// <summary>
        /// Function
        /// </summary>
        /// <remarks>
        /// <para>
        /// Function 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Function
        {
            get => _function;
            set
            {
                _function = value;
                OnPropertyChanged(nameof(Function));
            }
        }        /// <summary>
        /// Hasingredient
        /// </summary>
        /// <remarks>
        /// <para>
        /// Hasingredient 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Hasingredient
        {
            get => _hasingredient;
            set
            {
                _hasingredient = value;
                OnPropertyChanged(nameof(Hasingredient));
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
        /// Function
        /// </summary>
        /// <remarks>
        /// <para>
        /// Function 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Function
        {
            get => _function;
            set
            {
                _function = value;
                OnPropertyChanged(nameof(Function));
            }
        }        /// <summary>
        /// Amount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Amount 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Quantity>? Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }        /// <summary>
        /// Constituent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Constituent 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ManufacturedItemDefinitionComponentConstituent>? Constituent
        {
            get => _constituent;
            set
            {
                _constituent = value;
                OnPropertyChanged(nameof(Constituent));
            }
        }        /// <summary>
        /// 建立新的 ManufacturedItemDefinition 資源實例
        /// </summary>
        public ManufacturedItemDefinition()
        {
        }

        /// <summary>
        /// 建立新的 ManufacturedItemDefinition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ManufacturedItemDefinition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ManufacturedItemDefinition(Id: {Id})";
        }
    }    /// <summary>
    /// ManufacturedItemDefinitionProperty 背骨元素
    /// </summary>
    public class ManufacturedItemDefinitionProperty
    {
        // TODO: 添加屬性實作
        
        public ManufacturedItemDefinitionProperty() { }
    }    /// <summary>
    /// ManufacturedItemDefinitionComponentConstituent 背骨元素
    /// </summary>
    public class ManufacturedItemDefinitionComponentConstituent
    {
        // TODO: 添加屬性實作
        
        public ManufacturedItemDefinitionComponentConstituent() { }
    }    /// <summary>
    /// ManufacturedItemDefinitionComponent 背骨元素
    /// </summary>
    public class ManufacturedItemDefinitionComponent
    {
        // TODO: 添加屬性實作
        
        public ManufacturedItemDefinitionComponent() { }
    }    /// <summary>
    /// ManufacturedItemDefinitionPropertyValueChoice 選擇類型
    /// </summary>
    public class ManufacturedItemDefinitionPropertyValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ManufacturedItemDefinitionPropertyValueChoice(JsonObject value) : base("manufactureditemdefinitionpropertyvalue", value, _supportType) { }
        public ManufacturedItemDefinitionPropertyValueChoice(IComplexType? value) : base("manufactureditemdefinitionpropertyvalue", value) { }
        public ManufacturedItemDefinitionPropertyValueChoice(IPrimitiveType? value) : base("manufactureditemdefinitionpropertyvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ManufacturedItemDefinitionPropertyValue" : "manufactureditemdefinitionpropertyvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
