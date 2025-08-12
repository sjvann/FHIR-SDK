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
    /// FHIR R5 NutritionProduct 資源
    /// 
    /// <para>
    /// NutritionProduct 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var nutritionproduct = new NutritionProduct("nutritionproduct-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 NutritionProduct 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class NutritionProduct : ResourceBase<R5Version>
    {
        private Property
		private CodeableConcept? _code;
        private FhirCode? _status;
        private List<CodeableConcept>? _category;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _manufacturer;
        private List<NutritionProductNutrient>? _nutrient;
        private List<NutritionProductIngredient>? _ingredient;
        private List<CodeableReference>? _knownallergen;
        private List<NutritionProductCharacteristic>? _characteristic;
        private List<NutritionProductInstance>? _instance;
        private List<Annotation>? _note;
        private CodeableReference? _item;
        private List<Ratio>? _amount;
        private CodeableReference? _item;
        private List<Ratio>? _amount;
        private CodeableConcept? _type;
        private NutritionProductCharacteristicValueChoice? _value;
        private Quantity? _quantity;
        private List<Identifier>? _identifier;
        private FhirString? _name;
        private FhirString? _lotnumber;
        private FhirDateTime? _expiry;
        private FhirDateTime? _useby;
        private Identifier? _biologicalsourceevent;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "NutritionProduct";        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private CodeableConcept? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
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
        /// Nutrient
        /// </summary>
        /// <remarks>
        /// <para>
        /// Nutrient 的詳細描述。
        /// </para>
        /// </remarks>
        public List<NutritionProductNutrient>? Nutrient
        {
            get => _nutrient;
            set
            {
                _nutrient = value;
                OnPropertyChanged(nameof(Nutrient));
            }
        }        /// <summary>
        /// Ingredient
        /// </summary>
        /// <remarks>
        /// <para>
        /// Ingredient 的詳細描述。
        /// </para>
        /// </remarks>
        public List<NutritionProductIngredient>? Ingredient
        {
            get => _ingredient;
            set
            {
                _ingredient = value;
                OnPropertyChanged(nameof(Ingredient));
            }
        }        /// <summary>
        /// Knownallergen
        /// </summary>
        /// <remarks>
        /// <para>
        /// Knownallergen 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Knownallergen
        {
            get => _knownallergen;
            set
            {
                _knownallergen = value;
                OnPropertyChanged(nameof(Knownallergen));
            }
        }        /// <summary>
        /// Characteristic
        /// </summary>
        /// <remarks>
        /// <para>
        /// Characteristic 的詳細描述。
        /// </para>
        /// </remarks>
        public List<NutritionProductCharacteristic>? Characteristic
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
        public List<NutritionProductInstance>? Instance
        {
            get => _instance;
            set
            {
                _instance = value;
                OnPropertyChanged(nameof(Instance));
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
        public List<Ratio>? Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
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
        public List<Ratio>? Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
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
        public NutritionProductCharacteristicValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
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
        /// Useby
        /// </summary>
        /// <remarks>
        /// <para>
        /// Useby 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Useby
        {
            get => _useby;
            set
            {
                _useby = value;
                OnPropertyChanged(nameof(Useby));
            }
        }        /// <summary>
        /// Biologicalsourceevent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Biologicalsourceevent 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? Biologicalsourceevent
        {
            get => _biologicalsourceevent;
            set
            {
                _biologicalsourceevent = value;
                OnPropertyChanged(nameof(Biologicalsourceevent));
            }
        }        /// <summary>
        /// 建立新的 NutritionProduct 資源實例
        /// </summary>
        public NutritionProduct()
        {
        }

        /// <summary>
        /// 建立新的 NutritionProduct 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public NutritionProduct(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"NutritionProduct(Id: {Id})";
        }
    }    /// <summary>
    /// NutritionProductNutrient 背骨元素
    /// </summary>
    public class NutritionProductNutrient
    {
        // TODO: 添加屬性實作
        
        public NutritionProductNutrient() { }
    }    /// <summary>
    /// NutritionProductIngredient 背骨元素
    /// </summary>
    public class NutritionProductIngredient
    {
        // TODO: 添加屬性實作
        
        public NutritionProductIngredient() { }
    }    /// <summary>
    /// NutritionProductCharacteristic 背骨元素
    /// </summary>
    public class NutritionProductCharacteristic
    {
        // TODO: 添加屬性實作
        
        public NutritionProductCharacteristic() { }
    }    /// <summary>
    /// NutritionProductInstance 背骨元素
    /// </summary>
    public class NutritionProductInstance
    {
        // TODO: 添加屬性實作
        
        public NutritionProductInstance() { }
    }    /// <summary>
    /// NutritionProductCharacteristicValueChoice 選擇類型
    /// </summary>
    public class NutritionProductCharacteristicValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public NutritionProductCharacteristicValueChoice(JsonObject value) : base("nutritionproductcharacteristicvalue", value, _supportType) { }
        public NutritionProductCharacteristicValueChoice(IComplexType? value) : base("nutritionproductcharacteristicvalue", value) { }
        public NutritionProductCharacteristicValueChoice(IPrimitiveType? value) : base("nutritionproductcharacteristicvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "NutritionProductCharacteristicValue" : "nutritionproductcharacteristicvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
