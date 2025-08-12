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
    /// FHIR R4 SubstancePolymer 資源
    /// 
    /// <para>
    /// Todo.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var substancepolymer = new SubstancePolymer("substancepolymer-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 SubstancePolymer 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class SubstancePolymer : ResourceBase<R4Version>
    {
        private CodeableConcept? _class;

        /// <summary>
        /// class
        /// </summary>
        /// <remarks>
        /// <para>
        /// class 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? class
        {
            get => _class;
            set
            {
                _class = value;
                OnPropertyChanged(nameof(class));
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

        private List<CodeableConcept>? _copolymerconnectivity;

        /// <summary>
        /// copolymerConnectivity
        /// </summary>
        /// <remarks>
        /// <para>
        /// copolymerConnectivity 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? copolymerConnectivity
        {
            get => _copolymerconnectivity;
            set
            {
                _copolymerconnectivity = value;
                OnPropertyChanged(nameof(copolymerConnectivity));
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

        private CodeableConcept? _geometry;

        /// <summary>
        /// geometry
        /// </summary>
        /// <remarks>
        /// <para>
        /// geometry 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? geometry
        {
            get => _geometry;
            set
            {
                _geometry = value;
                OnPropertyChanged(nameof(geometry));
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

        private List<FhirString>? _modification;

        /// <summary>
        /// modification
        /// </summary>
        /// <remarks>
        /// <para>
        /// modification 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? modification
        {
            get => _modification;
            set
            {
                _modification = value;
                OnPropertyChanged(nameof(modification));
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

        private List<BackboneElement>? _monomerset;

        /// <summary>
        /// monomerSet
        /// </summary>
        /// <remarks>
        /// <para>
        /// monomerSet 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? monomerSet
        {
            get => _monomerset;
            set
            {
                _monomerset = value;
                OnPropertyChanged(nameof(monomerSet));
            }
        }

        private List<BackboneElement>? _repeat;

        /// <summary>
        /// repeat
        /// </summary>
        /// <remarks>
        /// <para>
        /// repeat 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? repeat
        {
            get => _repeat;
            set
            {
                _repeat = value;
                OnPropertyChanged(nameof(repeat));
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
        public override string ResourceType => "SubstancePolymer";

        /// <summary>
        /// 建立新的 SubstancePolymer 資源實例
        /// </summary>
        public SubstancePolymer()
        {
        }

        /// <summary>
        /// 建立新的 SubstancePolymer 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public SubstancePolymer(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"SubstancePolymer(Id: {Id})";
        }
    }
}
