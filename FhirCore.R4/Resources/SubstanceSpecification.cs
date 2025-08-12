using FhirCore.Base;
using FhirCore.R4;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using FhirCore.Interfaces;

namespace FhirCore.R4.Resources
{
    /// <summary>
    /// FHIR R4 SubstanceSpecification 資源
    /// 
    /// <para>
    /// The detailed description of a substance, typically at a level beyond what is used for prescribing.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var substancespecification = new SubstanceSpecification("substancespecification-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 SubstanceSpecification 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class SubstanceSpecification : ResourceBase<R4Version>
    {
        private List<BackboneElement>? _code;

        /// <summary>
        /// code
        /// </summary>
        /// <remarks>
        /// <para>
        /// code 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(code));
            }
        }

        private FhirString? _comment;

        /// <summary>
        /// comment
        /// </summary>
        /// <remarks>
        /// <para>
        /// comment 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? comment
        {
            get => _comment;
            set
            {
                _comment = value;
                OnPropertyChanged(nameof(comment));
            }
        }

        private List<FhirString>? _contained;

        /// <summary>
        /// contained
        /// </summary>
        /// <remarks>
        /// <para>
        /// contained 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? contained
        {
            get => _contained;
            set
            {
                _contained = value;
                OnPropertyChanged(nameof(contained));
            }
        }

        private FhirString? _description;

        /// <summary>
        /// description
        /// </summary>
        /// <remarks>
        /// <para>
        /// description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(description));
            }
        }

        private CodeableConcept? _domain;

        /// <summary>
        /// domain
        /// </summary>
        /// <remarks>
        /// <para>
        /// domain 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? domain
        {
            get => _domain;
            set
            {
                _domain = value;
                OnPropertyChanged(nameof(domain));
            }
        }

        private List<Extension>? _extension;

        /// <summary>
        /// extension
        /// </summary>
        /// <remarks>
        /// <para>
        /// extension 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Extension>? extension
        {
            get => _extension;
            set
            {
                _extension = value;
                OnPropertyChanged(nameof(extension));
            }
        }

        private FhirString? _id;

        /// <summary>
        /// id
        /// </summary>
        /// <remarks>
        /// <para>
        /// id 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(id));
            }
        }

        private Identifier? _identifier;

        /// <summary>
        /// identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(identifier));
            }
        }

        private FhirUri? _implicitrules;

        /// <summary>
        /// implicitRules
        /// </summary>
        /// <remarks>
        /// <para>
        /// implicitRules 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? implicitRules
        {
            get => _implicitrules;
            set
            {
                _implicitrules = value;
                OnPropertyChanged(nameof(implicitRules));
            }
        }

        private FhirCode? _language;

        /// <summary>
        /// language
        /// </summary>
        /// <remarks>
        /// <para>
        /// language 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? language
        {
            get => _language;
            set
            {
                _language = value;
                OnPropertyChanged(nameof(language));
            }
        }

        private Meta? _meta;

        /// <summary>
        /// meta
        /// </summary>
        /// <remarks>
        /// <para>
        /// meta 的詳細描述。
        /// </para>
        /// </remarks>
        public Meta? meta
        {
            get => _meta;
            set
            {
                _meta = value;
                OnPropertyChanged(nameof(meta));
            }
        }

        private List<Extension>? _modifierextension;

        /// <summary>
        /// modifierExtension
        /// </summary>
        /// <remarks>
        /// <para>
        /// modifierExtension 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Extension>? modifierExtension
        {
            get => _modifierextension;
            set
            {
                _modifierextension = value;
                OnPropertyChanged(nameof(modifierExtension));
            }
        }

        private List<BackboneElement>? _moiety;

        /// <summary>
        /// moiety
        /// </summary>
        /// <remarks>
        /// <para>
        /// moiety 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? moiety
        {
            get => _moiety;
            set
            {
                _moiety = value;
                OnPropertyChanged(nameof(moiety));
            }
        }

        private List<FhirString>? _molecularweight;

        /// <summary>
        /// molecularWeight
        /// </summary>
        /// <remarks>
        /// <para>
        /// molecularWeight 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? molecularWeight
        {
            get => _molecularweight;
            set
            {
                _molecularweight = value;
                OnPropertyChanged(nameof(molecularWeight));
            }
        }

        private List<BackboneElement>? _name;

        /// <summary>
        /// name
        /// </summary>
        /// <remarks>
        /// <para>
        /// name 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(name));
            }
        }

        private ReferenceType? _nucleicacid;

        /// <summary>
        /// nucleicAcid
        /// </summary>
        /// <remarks>
        /// <para>
        /// nucleicAcid 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? nucleicAcid
        {
            get => _nucleicacid;
            set
            {
                _nucleicacid = value;
                OnPropertyChanged(nameof(nucleicAcid));
            }
        }

        private ReferenceType? _polymer;

        /// <summary>
        /// polymer
        /// </summary>
        /// <remarks>
        /// <para>
        /// polymer 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? polymer
        {
            get => _polymer;
            set
            {
                _polymer = value;
                OnPropertyChanged(nameof(polymer));
            }
        }

        private List<BackboneElement>? _property;

        /// <summary>
        /// property
        /// </summary>
        /// <remarks>
        /// <para>
        /// property 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? property
        {
            get => _property;
            set
            {
                _property = value;
                OnPropertyChanged(nameof(property));
            }
        }

        private ReferenceType? _protein;

        /// <summary>
        /// protein
        /// </summary>
        /// <remarks>
        /// <para>
        /// protein 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? protein
        {
            get => _protein;
            set
            {
                _protein = value;
                OnPropertyChanged(nameof(protein));
            }
        }

        private ReferenceType? _referenceinformation;

        /// <summary>
        /// referenceInformation
        /// </summary>
        /// <remarks>
        /// <para>
        /// referenceInformation 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? referenceInformation
        {
            get => _referenceinformation;
            set
            {
                _referenceinformation = value;
                OnPropertyChanged(nameof(referenceInformation));
            }
        }

        private List<BackboneElement>? _relationship;

        /// <summary>
        /// relationship
        /// </summary>
        /// <remarks>
        /// <para>
        /// relationship 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? relationship
        {
            get => _relationship;
            set
            {
                _relationship = value;
                OnPropertyChanged(nameof(relationship));
            }
        }

        private List<ReferenceType>? _source;

        /// <summary>
        /// source
        /// </summary>
        /// <remarks>
        /// <para>
        /// source 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(source));
            }
        }

        private ReferenceType? _sourcematerial;

        /// <summary>
        /// sourceMaterial
        /// </summary>
        /// <remarks>
        /// <para>
        /// sourceMaterial 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? sourceMaterial
        {
            get => _sourcematerial;
            set
            {
                _sourcematerial = value;
                OnPropertyChanged(nameof(sourceMaterial));
            }
        }

        private CodeableConcept? _status;

        /// <summary>
        /// status
        /// </summary>
        /// <remarks>
        /// <para>
        /// status 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(status));
            }
        }

        private BackboneElement? _structure;

        /// <summary>
        /// structure
        /// </summary>
        /// <remarks>
        /// <para>
        /// structure 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? structure
        {
            get => _structure;
            set
            {
                _structure = value;
                OnPropertyChanged(nameof(structure));
            }
        }

        private FhirString? _text;

        /// <summary>
        /// text
        /// </summary>
        /// <remarks>
        /// <para>
        /// text 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? text
        {
            get => _text;
            set
            {
                _text = value;
                OnPropertyChanged(nameof(text));
            }
        }

        private CodeableConcept? _type;

        /// <summary>
        /// type
        /// </summary>
        /// <remarks>
        /// <para>
        /// type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(type));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "SubstanceSpecification";

        /// <summary>
        /// 建立新的 SubstanceSpecification 資源實例
        /// </summary>
        public SubstanceSpecification()
        {
        }

        /// <summary>
        /// 建立新的 SubstanceSpecification 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public SubstanceSpecification(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"SubstanceSpecification(Id: {Id})";
        }
    }
}
