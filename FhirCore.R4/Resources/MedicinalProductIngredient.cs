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
    /// FHIR R4 MedicinalProductIngredient 資源
    /// 
    /// <para>
    /// An ingredient of a manufactured item or pharmaceutical product.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var medicinalproductingredient = new MedicinalProductIngredient("medicinalproductingredient-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 MedicinalProductIngredient 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MedicinalProductIngredient : ResourceBase<R4Version>
    {
        private FhirBoolean? _allergenicindicator;

        /// <summary>
        /// allergenicIndicator
        /// </summary>
        /// <remarks>
        /// <para>
        /// allergenicIndicator 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? allergenicIndicator
        {
            get => _allergenicindicator;
            set
            {
                _allergenicindicator = value;
                OnPropertyChanged(nameof(allergenicIndicator));
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

        private List<ReferenceType>? _manufacturer;

        /// <summary>
        /// manufacturer
        /// </summary>
        /// <remarks>
        /// <para>
        /// manufacturer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? manufacturer
        {
            get => _manufacturer;
            set
            {
                _manufacturer = value;
                OnPropertyChanged(nameof(manufacturer));
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

        private CodeableConcept? _role;

        /// <summary>
        /// role
        /// </summary>
        /// <remarks>
        /// <para>
        /// role 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? role
        {
            get => _role;
            set
            {
                _role = value;
                OnPropertyChanged(nameof(role));
            }
        }

        private List<BackboneElement>? _specifiedsubstance;

        /// <summary>
        /// specifiedSubstance
        /// </summary>
        /// <remarks>
        /// <para>
        /// specifiedSubstance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? specifiedSubstance
        {
            get => _specifiedsubstance;
            set
            {
                _specifiedsubstance = value;
                OnPropertyChanged(nameof(specifiedSubstance));
            }
        }

        private BackboneElement? _substance;

        /// <summary>
        /// substance
        /// </summary>
        /// <remarks>
        /// <para>
        /// substance 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? substance
        {
            get => _substance;
            set
            {
                _substance = value;
                OnPropertyChanged(nameof(substance));
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
        public override string ResourceType => "MedicinalProductIngredient";

        /// <summary>
        /// 建立新的 MedicinalProductIngredient 資源實例
        /// </summary>
        public MedicinalProductIngredient()
        {
        }

        /// <summary>
        /// 建立新的 MedicinalProductIngredient 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public MedicinalProductIngredient(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"MedicinalProductIngredient(Id: {Id})";
        }
    }
}
