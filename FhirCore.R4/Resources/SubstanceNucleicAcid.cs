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
    /// FHIR R4 SubstanceNucleicAcid 資源
    /// 
    /// <para>
    /// Nucleic acids are defined by three distinct elements: the base, sugar and linkage. Individual substance/moiety IDs will be created for each of these elements. The nucleotide sequence will be always entered in the 5’-3’ direction.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var substancenucleicacid = new SubstanceNucleicAcid("substancenucleicacid-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 SubstanceNucleicAcid 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class SubstanceNucleicAcid : ResourceBase<R4Version>
    {
        private FhirString? _areaofhybridisation;

        /// <summary>
        /// areaOfHybridisation
        /// </summary>
        /// <remarks>
        /// <para>
        /// areaOfHybridisation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? areaOfHybridisation
        {
            get => _areaofhybridisation;
            set
            {
                _areaofhybridisation = value;
                OnPropertyChanged(nameof(areaOfHybridisation));
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

        private FhirInteger? _numberofsubunits;

        /// <summary>
        /// numberOfSubunits
        /// </summary>
        /// <remarks>
        /// <para>
        /// numberOfSubunits 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? numberOfSubunits
        {
            get => _numberofsubunits;
            set
            {
                _numberofsubunits = value;
                OnPropertyChanged(nameof(numberOfSubunits));
            }
        }

        private CodeableConcept? _oligonucleotidetype;

        /// <summary>
        /// oligoNucleotideType
        /// </summary>
        /// <remarks>
        /// <para>
        /// oligoNucleotideType 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? oligoNucleotideType
        {
            get => _oligonucleotidetype;
            set
            {
                _oligonucleotidetype = value;
                OnPropertyChanged(nameof(oligoNucleotideType));
            }
        }

        private CodeableConcept? _sequencetype;

        /// <summary>
        /// sequenceType
        /// </summary>
        /// <remarks>
        /// <para>
        /// sequenceType 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? sequenceType
        {
            get => _sequencetype;
            set
            {
                _sequencetype = value;
                OnPropertyChanged(nameof(sequenceType));
            }
        }

        private List<BackboneElement>? _subunit;

        /// <summary>
        /// subunit
        /// </summary>
        /// <remarks>
        /// <para>
        /// subunit 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? subunit
        {
            get => _subunit;
            set
            {
                _subunit = value;
                OnPropertyChanged(nameof(subunit));
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
        public override string ResourceType => "SubstanceNucleicAcid";

        /// <summary>
        /// 建立新的 SubstanceNucleicAcid 資源實例
        /// </summary>
        public SubstanceNucleicAcid()
        {
        }

        /// <summary>
        /// 建立新的 SubstanceNucleicAcid 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public SubstanceNucleicAcid(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"SubstanceNucleicAcid(Id: {Id})";
        }
    }
}
