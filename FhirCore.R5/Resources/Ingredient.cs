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
    /// FHIR R5 Ingredient 資源
    /// 
    /// <para>
    /// Ingredient 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var ingredient = new Ingredient("ingredient-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Ingredient 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Ingredient : ResourceBase<R5Version>
    {
        private Property
		private Identifier? _identifier;
        private FhirCode? _status;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _for;
        private CodeableConcept? _role;
        private List<CodeableConcept>? _function;
        private CodeableConcept? _group;
        private FhirBoolean? _allergenicindicator;
        private FhirMarkdown? _comment;
        private List<IngredientManufacturer>? _manufacturer;
        private IngredientSubstance? _substance;
        private FhirCode? _role;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _manufacturer;
        private CodeableReference? _substance;
        private IngredientSubstanceStrengthReferenceStrengthStrengthChoice? _strength;
        private FhirString? _measurementpoint;
        private List<CodeableConcept>? _country;
        private IngredientSubstanceStrengthPresentationChoice? _presentation;
        private FhirString? _textpresentation;
        private IngredientSubstanceStrengthConcentrationChoice? _concentration;
        private FhirString? _textconcentration;
        private CodeableConcept? _basis;
        private FhirString? _measurementpoint;
        private List<CodeableConcept>? _country;
        private List<IngredientSubstanceStrengthReferenceStrength>? _referencestrength;
        private CodeableReference? _code;
        private List<IngredientSubstanceStrength>? _strength;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Ingredient";        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private Identifier? Identifier
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
        /// For
        /// </summary>
        /// <remarks>
        /// <para>
        /// For 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? For
        {
            get => _for;
            set
            {
                _for = value;
                OnPropertyChanged(nameof(For));
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
        /// Group
        /// </summary>
        /// <remarks>
        /// <para>
        /// Group 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Group
        {
            get => _group;
            set
            {
                _group = value;
                OnPropertyChanged(nameof(Group));
            }
        }        /// <summary>
        /// Allergenicindicator
        /// </summary>
        /// <remarks>
        /// <para>
        /// Allergenicindicator 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Allergenicindicator
        {
            get => _allergenicindicator;
            set
            {
                _allergenicindicator = value;
                OnPropertyChanged(nameof(Allergenicindicator));
            }
        }        /// <summary>
        /// Comment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Comment 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Comment
        {
            get => _comment;
            set
            {
                _comment = value;
                OnPropertyChanged(nameof(Comment));
            }
        }        /// <summary>
        /// Manufacturer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Manufacturer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<IngredientManufacturer>? Manufacturer
        {
            get => _manufacturer;
            set
            {
                _manufacturer = value;
                OnPropertyChanged(nameof(Manufacturer));
            }
        }        /// <summary>
        /// Substance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Substance 的詳細描述。
        /// </para>
        /// </remarks>
        public IngredientSubstance? Substance
        {
            get => _substance;
            set
            {
                _substance = value;
                OnPropertyChanged(nameof(Substance));
            }
        }        /// <summary>
        /// Role
        /// </summary>
        /// <remarks>
        /// <para>
        /// Role 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Role
        {
            get => _role;
            set
            {
                _role = value;
                OnPropertyChanged(nameof(Role));
            }
        }        /// <summary>
        /// Manufacturer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Manufacturer 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Manufacturer
        {
            get => _manufacturer;
            set
            {
                _manufacturer = value;
                OnPropertyChanged(nameof(Manufacturer));
            }
        }        /// <summary>
        /// Substance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Substance 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Substance
        {
            get => _substance;
            set
            {
                _substance = value;
                OnPropertyChanged(nameof(Substance));
            }
        }        /// <summary>
        /// Strength
        /// </summary>
        /// <remarks>
        /// <para>
        /// Strength 的詳細描述。
        /// </para>
        /// </remarks>
        public IngredientSubstanceStrengthReferenceStrengthStrengthChoice? Strength
        {
            get => _strength;
            set
            {
                _strength = value;
                OnPropertyChanged(nameof(Strength));
            }
        }        /// <summary>
        /// Measurementpoint
        /// </summary>
        /// <remarks>
        /// <para>
        /// Measurementpoint 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Measurementpoint
        {
            get => _measurementpoint;
            set
            {
                _measurementpoint = value;
                OnPropertyChanged(nameof(Measurementpoint));
            }
        }        /// <summary>
        /// Country
        /// </summary>
        /// <remarks>
        /// <para>
        /// Country 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Country
        {
            get => _country;
            set
            {
                _country = value;
                OnPropertyChanged(nameof(Country));
            }
        }        /// <summary>
        /// Presentation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Presentation 的詳細描述。
        /// </para>
        /// </remarks>
        public IngredientSubstanceStrengthPresentationChoice? Presentation
        {
            get => _presentation;
            set
            {
                _presentation = value;
                OnPropertyChanged(nameof(Presentation));
            }
        }        /// <summary>
        /// Textpresentation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Textpresentation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Textpresentation
        {
            get => _textpresentation;
            set
            {
                _textpresentation = value;
                OnPropertyChanged(nameof(Textpresentation));
            }
        }        /// <summary>
        /// Concentration
        /// </summary>
        /// <remarks>
        /// <para>
        /// Concentration 的詳細描述。
        /// </para>
        /// </remarks>
        public IngredientSubstanceStrengthConcentrationChoice? Concentration
        {
            get => _concentration;
            set
            {
                _concentration = value;
                OnPropertyChanged(nameof(Concentration));
            }
        }        /// <summary>
        /// Textconcentration
        /// </summary>
        /// <remarks>
        /// <para>
        /// Textconcentration 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Textconcentration
        {
            get => _textconcentration;
            set
            {
                _textconcentration = value;
                OnPropertyChanged(nameof(Textconcentration));
            }
        }        /// <summary>
        /// Basis
        /// </summary>
        /// <remarks>
        /// <para>
        /// Basis 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Basis
        {
            get => _basis;
            set
            {
                _basis = value;
                OnPropertyChanged(nameof(Basis));
            }
        }        /// <summary>
        /// Measurementpoint
        /// </summary>
        /// <remarks>
        /// <para>
        /// Measurementpoint 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Measurementpoint
        {
            get => _measurementpoint;
            set
            {
                _measurementpoint = value;
                OnPropertyChanged(nameof(Measurementpoint));
            }
        }        /// <summary>
        /// Country
        /// </summary>
        /// <remarks>
        /// <para>
        /// Country 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Country
        {
            get => _country;
            set
            {
                _country = value;
                OnPropertyChanged(nameof(Country));
            }
        }        /// <summary>
        /// Referencestrength
        /// </summary>
        /// <remarks>
        /// <para>
        /// Referencestrength 的詳細描述。
        /// </para>
        /// </remarks>
        public List<IngredientSubstanceStrengthReferenceStrength>? Referencestrength
        {
            get => _referencestrength;
            set
            {
                _referencestrength = value;
                OnPropertyChanged(nameof(Referencestrength));
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
        /// Strength
        /// </summary>
        /// <remarks>
        /// <para>
        /// Strength 的詳細描述。
        /// </para>
        /// </remarks>
        public List<IngredientSubstanceStrength>? Strength
        {
            get => _strength;
            set
            {
                _strength = value;
                OnPropertyChanged(nameof(Strength));
            }
        }        /// <summary>
        /// 建立新的 Ingredient 資源實例
        /// </summary>
        public Ingredient()
        {
        }

        /// <summary>
        /// 建立新的 Ingredient 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Ingredient(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Ingredient(Id: {Id})";
        }
    }    /// <summary>
    /// IngredientManufacturer 背骨元素
    /// </summary>
    public class IngredientManufacturer
    {
        // TODO: 添加屬性實作
        
        public IngredientManufacturer() { }
    }    /// <summary>
    /// IngredientSubstanceStrengthReferenceStrength 背骨元素
    /// </summary>
    public class IngredientSubstanceStrengthReferenceStrength
    {
        // TODO: 添加屬性實作
        
        public IngredientSubstanceStrengthReferenceStrength() { }
    }    /// <summary>
    /// IngredientSubstanceStrength 背骨元素
    /// </summary>
    public class IngredientSubstanceStrength
    {
        // TODO: 添加屬性實作
        
        public IngredientSubstanceStrength() { }
    }    /// <summary>
    /// IngredientSubstance 背骨元素
    /// </summary>
    public class IngredientSubstance
    {
        // TODO: 添加屬性實作
        
        public IngredientSubstance() { }
    }    /// <summary>
    /// IngredientSubstanceStrengthPresentationChoice 選擇類型
    /// </summary>
    public class IngredientSubstanceStrengthPresentationChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public IngredientSubstanceStrengthPresentationChoice(JsonObject value) : base("ingredientsubstancestrengthpresentation", value, _supportType) { }
        public IngredientSubstanceStrengthPresentationChoice(IComplexType? value) : base("ingredientsubstancestrengthpresentation", value) { }
        public IngredientSubstanceStrengthPresentationChoice(IPrimitiveType? value) : base("ingredientsubstancestrengthpresentation", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "IngredientSubstanceStrengthPresentation" : "ingredientsubstancestrengthpresentation";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// IngredientSubstanceStrengthConcentrationChoice 選擇類型
    /// </summary>
    public class IngredientSubstanceStrengthConcentrationChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public IngredientSubstanceStrengthConcentrationChoice(JsonObject value) : base("ingredientsubstancestrengthconcentration", value, _supportType) { }
        public IngredientSubstanceStrengthConcentrationChoice(IComplexType? value) : base("ingredientsubstancestrengthconcentration", value) { }
        public IngredientSubstanceStrengthConcentrationChoice(IPrimitiveType? value) : base("ingredientsubstancestrengthconcentration", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "IngredientSubstanceStrengthConcentration" : "ingredientsubstancestrengthconcentration";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// IngredientSubstanceStrengthReferenceStrengthStrengthChoice 選擇類型
    /// </summary>
    public class IngredientSubstanceStrengthReferenceStrengthStrengthChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public IngredientSubstanceStrengthReferenceStrengthStrengthChoice(JsonObject value) : base("ingredientsubstancestrengthreferencestrengthstrength", value, _supportType) { }
        public IngredientSubstanceStrengthReferenceStrengthStrengthChoice(IComplexType? value) : base("ingredientsubstancestrengthreferencestrengthstrength", value) { }
        public IngredientSubstanceStrengthReferenceStrengthStrengthChoice(IPrimitiveType? value) : base("ingredientsubstancestrengthreferencestrengthstrength", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "IngredientSubstanceStrengthReferenceStrengthStrength" : "ingredientsubstancestrengthreferencestrengthstrength";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
