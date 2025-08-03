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
    /// FHIR R4 SubstanceSourceMaterial 資源
    /// 
    /// <para>
    /// Source material shall capture information on the taxonomic and anatomical origins as well as the fraction of a material that can result in or can be modified to form a substance. This set of data elements shall be used to define polymer substances isolated from biological matrices. Taxonomic and anatomical origins shall be described using a controlled vocabulary as required. This information is captured for naturally derived polymers ( . starch) and structurally diverse substances. For Organisms belonging to the Kingdom Plantae the Substance level defines the fresh material of a single species or infraspecies, the Herbal Drug and the Herbal preparation. For Herbal preparations, the fraction information will be captured at the Substance information level and additional information for herbal extracts will be captured at the Specified Substance Group 1 information level. See for further explanation the Substance Class: Structurally Diverse and the herbal annex.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var substancesourcematerial = new SubstanceSourceMaterial("substancesourcematerial-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 SubstanceSourceMaterial 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class SubstanceSourceMaterial : ResourceBase<R4Version>
    {
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

        private List<CodeableConcept>? _countryoforigin;

        /// <summary>
        /// countryOfOrigin
        /// </summary>
        /// <remarks>
        /// <para>
        /// countryOfOrigin 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? countryOfOrigin
        {
            get => _countryoforigin;
            set
            {
                _countryoforigin = value;
                OnPropertyChanged(nameof(countryOfOrigin));
            }
        }

        private CodeableConcept? _developmentstage;

        /// <summary>
        /// developmentStage
        /// </summary>
        /// <remarks>
        /// <para>
        /// developmentStage 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? developmentStage
        {
            get => _developmentstage;
            set
            {
                _developmentstage = value;
                OnPropertyChanged(nameof(developmentStage));
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

        private List<BackboneElement>? _fractiondescription;

        /// <summary>
        /// fractionDescription
        /// </summary>
        /// <remarks>
        /// <para>
        /// fractionDescription 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? fractionDescription
        {
            get => _fractiondescription;
            set
            {
                _fractiondescription = value;
                OnPropertyChanged(nameof(fractionDescription));
            }
        }

        private List<FhirString>? _geographicallocation;

        /// <summary>
        /// geographicalLocation
        /// </summary>
        /// <remarks>
        /// <para>
        /// geographicalLocation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? geographicalLocation
        {
            get => _geographicallocation;
            set
            {
                _geographicallocation = value;
                OnPropertyChanged(nameof(geographicalLocation));
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

        private BackboneElement? _organism;

        /// <summary>
        /// organism
        /// </summary>
        /// <remarks>
        /// <para>
        /// organism 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? organism
        {
            get => _organism;
            set
            {
                _organism = value;
                OnPropertyChanged(nameof(organism));
            }
        }

        private Identifier? _organismid;

        /// <summary>
        /// organismId
        /// </summary>
        /// <remarks>
        /// <para>
        /// organismId 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? organismId
        {
            get => _organismid;
            set
            {
                _organismid = value;
                OnPropertyChanged(nameof(organismId));
            }
        }

        private FhirString? _organismname;

        /// <summary>
        /// organismName
        /// </summary>
        /// <remarks>
        /// <para>
        /// organismName 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? organismName
        {
            get => _organismname;
            set
            {
                _organismname = value;
                OnPropertyChanged(nameof(organismName));
            }
        }

        private List<Identifier>? _parentsubstanceid;

        /// <summary>
        /// parentSubstanceId
        /// </summary>
        /// <remarks>
        /// <para>
        /// parentSubstanceId 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? parentSubstanceId
        {
            get => _parentsubstanceid;
            set
            {
                _parentsubstanceid = value;
                OnPropertyChanged(nameof(parentSubstanceId));
            }
        }

        private List<FhirString>? _parentsubstancename;

        /// <summary>
        /// parentSubstanceName
        /// </summary>
        /// <remarks>
        /// <para>
        /// parentSubstanceName 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? parentSubstanceName
        {
            get => _parentsubstancename;
            set
            {
                _parentsubstancename = value;
                OnPropertyChanged(nameof(parentSubstanceName));
            }
        }

        private List<BackboneElement>? _partdescription;

        /// <summary>
        /// partDescription
        /// </summary>
        /// <remarks>
        /// <para>
        /// partDescription 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? partDescription
        {
            get => _partdescription;
            set
            {
                _partdescription = value;
                OnPropertyChanged(nameof(partDescription));
            }
        }

        private CodeableConcept? _sourcematerialclass;

        /// <summary>
        /// sourceMaterialClass
        /// </summary>
        /// <remarks>
        /// <para>
        /// sourceMaterialClass 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? sourceMaterialClass
        {
            get => _sourcematerialclass;
            set
            {
                _sourcematerialclass = value;
                OnPropertyChanged(nameof(sourceMaterialClass));
            }
        }

        private CodeableConcept? _sourcematerialstate;

        /// <summary>
        /// sourceMaterialState
        /// </summary>
        /// <remarks>
        /// <para>
        /// sourceMaterialState 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? sourceMaterialState
        {
            get => _sourcematerialstate;
            set
            {
                _sourcematerialstate = value;
                OnPropertyChanged(nameof(sourceMaterialState));
            }
        }

        private CodeableConcept? _sourcematerialtype;

        /// <summary>
        /// sourceMaterialType
        /// </summary>
        /// <remarks>
        /// <para>
        /// sourceMaterialType 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? sourceMaterialType
        {
            get => _sourcematerialtype;
            set
            {
                _sourcematerialtype = value;
                OnPropertyChanged(nameof(sourceMaterialType));
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

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "SubstanceSourceMaterial";

        /// <summary>
        /// 建立新的 SubstanceSourceMaterial 資源實例
        /// </summary>
        public SubstanceSourceMaterial()
        {
        }

        /// <summary>
        /// 建立新的 SubstanceSourceMaterial 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public SubstanceSourceMaterial(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"SubstanceSourceMaterial(Id: {Id})";
        }
    }
}
