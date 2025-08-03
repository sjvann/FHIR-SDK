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
    /// FHIR R5 SubstanceReferenceInformation 資源
    /// 
    /// <para>
    /// SubstanceReferenceInformation 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var substancereferenceinformation = new SubstanceReferenceInformation("substancereferenceinformation-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 SubstanceReferenceInformation 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class SubstanceReferenceInformation : ResourceBase<R5Version>
    {
        private Property
		private FhirString? _comment;
        private List<SubstanceReferenceInformationGene>? _gene;
        private List<SubstanceReferenceInformationGeneElement>? _geneelement;
        private List<SubstanceReferenceInformationTarget>? _target;
        private CodeableConcept? _genesequenceorigin;
        private CodeableConcept? _gene;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _source;
        private CodeableConcept? _type;
        private Identifier? _element;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _source;
        private Identifier? _target;
        private CodeableConcept? _type;
        private CodeableConcept? _interaction;
        private CodeableConcept? _organism;
        private CodeableConcept? _organismtype;
        private SubstanceReferenceInformationTargetAmountChoice? _amount;
        private CodeableConcept? _amounttype;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _source;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "SubstanceReferenceInformation";        /// <summary>
        /// Comment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Comment 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private FhirString? Comment
        {
            get => _comment;
            set
            {
                _comment = value;
                OnPropertyChanged(nameof(Comment));
            }
        }        /// <summary>
        /// Gene
        /// </summary>
        /// <remarks>
        /// <para>
        /// Gene 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstanceReferenceInformationGene>? Gene
        {
            get => _gene;
            set
            {
                _gene = value;
                OnPropertyChanged(nameof(Gene));
            }
        }        /// <summary>
        /// Geneelement
        /// </summary>
        /// <remarks>
        /// <para>
        /// Geneelement 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstanceReferenceInformationGeneElement>? Geneelement
        {
            get => _geneelement;
            set
            {
                _geneelement = value;
                OnPropertyChanged(nameof(Geneelement));
            }
        }        /// <summary>
        /// Target
        /// </summary>
        /// <remarks>
        /// <para>
        /// Target 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstanceReferenceInformationTarget>? Target
        {
            get => _target;
            set
            {
                _target = value;
                OnPropertyChanged(nameof(Target));
            }
        }        /// <summary>
        /// Genesequenceorigin
        /// </summary>
        /// <remarks>
        /// <para>
        /// Genesequenceorigin 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Genesequenceorigin
        {
            get => _genesequenceorigin;
            set
            {
                _genesequenceorigin = value;
                OnPropertyChanged(nameof(Genesequenceorigin));
            }
        }        /// <summary>
        /// Gene
        /// </summary>
        /// <remarks>
        /// <para>
        /// Gene 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Gene
        {
            get => _gene;
            set
            {
                _gene = value;
                OnPropertyChanged(nameof(Gene));
            }
        }        /// <summary>
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
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
        /// Element
        /// </summary>
        /// <remarks>
        /// <para>
        /// Element 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? Element
        {
            get => _element;
            set
            {
                _element = value;
                OnPropertyChanged(nameof(Element));
            }
        }        /// <summary>
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
            }
        }        /// <summary>
        /// Target
        /// </summary>
        /// <remarks>
        /// <para>
        /// Target 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? Target
        {
            get => _target;
            set
            {
                _target = value;
                OnPropertyChanged(nameof(Target));
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
        /// Interaction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Interaction 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Interaction
        {
            get => _interaction;
            set
            {
                _interaction = value;
                OnPropertyChanged(nameof(Interaction));
            }
        }        /// <summary>
        /// Organism
        /// </summary>
        /// <remarks>
        /// <para>
        /// Organism 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Organism
        {
            get => _organism;
            set
            {
                _organism = value;
                OnPropertyChanged(nameof(Organism));
            }
        }        /// <summary>
        /// Organismtype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Organismtype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Organismtype
        {
            get => _organismtype;
            set
            {
                _organismtype = value;
                OnPropertyChanged(nameof(Organismtype));
            }
        }        /// <summary>
        /// Amount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Amount 的詳細描述。
        /// </para>
        /// </remarks>
        public SubstanceReferenceInformationTargetAmountChoice? Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }        /// <summary>
        /// Amounttype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Amounttype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Amounttype
        {
            get => _amounttype;
            set
            {
                _amounttype = value;
                OnPropertyChanged(nameof(Amounttype));
            }
        }        /// <summary>
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
            }
        }        /// <summary>
        /// 建立新的 SubstanceReferenceInformation 資源實例
        /// </summary>
        public SubstanceReferenceInformation()
        {
        }

        /// <summary>
        /// 建立新的 SubstanceReferenceInformation 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public SubstanceReferenceInformation(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"SubstanceReferenceInformation(Id: {Id})";
        }
    }    /// <summary>
    /// SubstanceReferenceInformationGene 背骨元素
    /// </summary>
    public class SubstanceReferenceInformationGene
    {
        // TODO: 添加屬性實作
        
        public SubstanceReferenceInformationGene() { }
    }    /// <summary>
    /// SubstanceReferenceInformationGeneElement 背骨元素
    /// </summary>
    public class SubstanceReferenceInformationGeneElement
    {
        // TODO: 添加屬性實作
        
        public SubstanceReferenceInformationGeneElement() { }
    }    /// <summary>
    /// SubstanceReferenceInformationTarget 背骨元素
    /// </summary>
    public class SubstanceReferenceInformationTarget
    {
        // TODO: 添加屬性實作
        
        public SubstanceReferenceInformationTarget() { }
    }    /// <summary>
    /// SubstanceReferenceInformationTargetAmountChoice 選擇類型
    /// </summary>
    public class SubstanceReferenceInformationTargetAmountChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public SubstanceReferenceInformationTargetAmountChoice(JsonObject value) : base("substancereferenceinformationtargetamount", value, _supportType) { }
        public SubstanceReferenceInformationTargetAmountChoice(IComplexType? value) : base("substancereferenceinformationtargetamount", value) { }
        public SubstanceReferenceInformationTargetAmountChoice(IPrimitiveType? value) : base("substancereferenceinformationtargetamount", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "SubstanceReferenceInformationTargetAmount" : "substancereferenceinformationtargetamount";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
