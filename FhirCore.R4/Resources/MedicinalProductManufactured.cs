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
    /// FHIR R4 MedicinalProductManufactured 資源
    /// 
    /// <para>
    /// The manufactured item as contained in the packaged medicinal product.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var medicinalproductmanufactured = new MedicinalProductManufactured("medicinalproductmanufactured-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 MedicinalProductManufactured 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MedicinalProductManufactured : ResourceBase<R4Version>
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

        private CodeableConcept? _manufactureddoseform;

        /// <summary>
        /// manufacturedDoseForm
        /// </summary>
        /// <remarks>
        /// <para>
        /// manufacturedDoseForm 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? manufacturedDoseForm
        {
            get => _manufactureddoseform;
            set
            {
                _manufactureddoseform = value;
                OnPropertyChanged(nameof(manufacturedDoseForm));
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

        private List<CodeableConcept>? _othercharacteristics;

        /// <summary>
        /// otherCharacteristics
        /// </summary>
        /// <remarks>
        /// <para>
        /// otherCharacteristics 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? otherCharacteristics
        {
            get => _othercharacteristics;
            set
            {
                _othercharacteristics = value;
                OnPropertyChanged(nameof(otherCharacteristics));
            }
        }

        private FhirString? _physicalcharacteristics;

        /// <summary>
        /// physicalCharacteristics
        /// </summary>
        /// <remarks>
        /// <para>
        /// physicalCharacteristics 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? physicalCharacteristics
        {
            get => _physicalcharacteristics;
            set
            {
                _physicalcharacteristics = value;
                OnPropertyChanged(nameof(physicalCharacteristics));
            }
        }

        private Quantity? _quantity;

        /// <summary>
        /// quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(quantity));
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
        public override string ResourceType => "MedicinalProductManufactured";

        /// <summary>
        /// 建立新的 MedicinalProductManufactured 資源實例
        /// </summary>
        public MedicinalProductManufactured()
        {
        }

        /// <summary>
        /// 建立新的 MedicinalProductManufactured 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public MedicinalProductManufactured(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"MedicinalProductManufactured(Id: {Id})";
        }
    }
}
