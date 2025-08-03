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
    /// FHIR R4 MedicinalProductPharmaceutical 資源
    /// 
    /// <para>
    /// A pharmaceutical product described in terms of its composition and dose form.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var medicinalproductpharmaceutical = new MedicinalProductPharmaceutical("medicinalproductpharmaceutical-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 MedicinalProductPharmaceutical 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MedicinalProductPharmaceutical : ResourceBase<R4Version>
    {
        private CodeableConcept? _administrabledoseform;

        /// <summary>
        /// administrableDoseForm
        /// </summary>
        /// <remarks>
        /// <para>
        /// administrableDoseForm 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? administrableDoseForm
        {
            get => _administrabledoseform;
            set
            {
                _administrabledoseform = value;
                OnPropertyChanged(nameof(administrableDoseForm));
            }
        }

        private List<BackboneElement>? _characteristics;

        /// <summary>
        /// characteristics
        /// </summary>
        /// <remarks>
        /// <para>
        /// characteristics 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? characteristics
        {
            get => _characteristics;
            set
            {
                _characteristics = value;
                OnPropertyChanged(nameof(characteristics));
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

        private List<ReferenceType>? _device;

        /// <summary>
        /// device
        /// </summary>
        /// <remarks>
        /// <para>
        /// device 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? device
        {
            get => _device;
            set
            {
                _device = value;
                OnPropertyChanged(nameof(device));
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

        private List<Identifier>? _identifier;

        /// <summary>
        /// identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? identifier
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

        private List<ReferenceType>? _ingredient;

        /// <summary>
        /// ingredient
        /// </summary>
        /// <remarks>
        /// <para>
        /// ingredient 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? ingredient
        {
            get => _ingredient;
            set
            {
                _ingredient = value;
                OnPropertyChanged(nameof(ingredient));
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

        private List<BackboneElement>? _routeofadministration;

        /// <summary>
        /// routeOfAdministration
        /// </summary>
        /// <remarks>
        /// <para>
        /// routeOfAdministration 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? routeOfAdministration
        {
            get => _routeofadministration;
            set
            {
                _routeofadministration = value;
                OnPropertyChanged(nameof(routeOfAdministration));
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

        private CodeableConcept? _unitofpresentation;

        /// <summary>
        /// unitOfPresentation
        /// </summary>
        /// <remarks>
        /// <para>
        /// unitOfPresentation 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? unitOfPresentation
        {
            get => _unitofpresentation;
            set
            {
                _unitofpresentation = value;
                OnPropertyChanged(nameof(unitOfPresentation));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "MedicinalProductPharmaceutical";

        /// <summary>
        /// 建立新的 MedicinalProductPharmaceutical 資源實例
        /// </summary>
        public MedicinalProductPharmaceutical()
        {
        }

        /// <summary>
        /// 建立新的 MedicinalProductPharmaceutical 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public MedicinalProductPharmaceutical(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"MedicinalProductPharmaceutical(Id: {Id})";
        }
    }
}
