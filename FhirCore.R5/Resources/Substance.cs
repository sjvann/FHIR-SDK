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
    /// FHIR R5 Substance 資源
    /// 
    /// <para>
    /// Substance 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var substance = new Substance("substance-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Substance 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Substance : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirBoolean? _instance;
        private FhirCode? _status;
        private List<CodeableConcept>? _category;
        private CodeableReference? _code;
        private FhirMarkdown? _description;
        private FhirDateTime? _expiry;
        private Quantity? _quantity;
        private List<SubstanceIngredient>? _ingredient;
        private Ratio? _quantity;
        private SubstanceIngredientSubstanceChoice? _substance;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Substance";        /// <summary>
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
        /// Instance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instance 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Instance
        {
            get => _instance;
            set
            {
                _instance = value;
                OnPropertyChanged(nameof(Instance));
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
        public CodeableReference? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
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
        /// Ingredient
        /// </summary>
        /// <remarks>
        /// <para>
        /// Ingredient 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstanceIngredient>? Ingredient
        {
            get => _ingredient;
            set
            {
                _ingredient = value;
                OnPropertyChanged(nameof(Ingredient));
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
        /// Substance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Substance 的詳細描述。
        /// </para>
        /// </remarks>
        public SubstanceIngredientSubstanceChoice? Substance
        {
            get => _substance;
            set
            {
                _substance = value;
                OnPropertyChanged(nameof(Substance));
            }
        }        /// <summary>
        /// 建立新的 Substance 資源實例
        /// </summary>
        public Substance()
        {
        }

        /// <summary>
        /// 建立新的 Substance 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Substance(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Substance(Id: {Id})";
        }
    }    /// <summary>
    /// SubstanceIngredient 背骨元素
    /// </summary>
    public class SubstanceIngredient
    {
        // TODO: 添加屬性實作
        
        public SubstanceIngredient() { }
    }    /// <summary>
    /// SubstanceIngredientSubstanceChoice 選擇類型
    /// </summary>
    public class SubstanceIngredientSubstanceChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public SubstanceIngredientSubstanceChoice(JsonObject value) : base("substanceingredientsubstance", value, _supportType) { }
        public SubstanceIngredientSubstanceChoice(IComplexType? value) : base("substanceingredientsubstance", value) { }
        public SubstanceIngredientSubstanceChoice(IPrimitiveType? value) : base("substanceingredientsubstance", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "SubstanceIngredientSubstance" : "substanceingredientsubstance";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
