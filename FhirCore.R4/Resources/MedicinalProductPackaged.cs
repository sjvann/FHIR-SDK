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
    /// FHIR R4 MedicinalProductPackaged 資源
    /// 
    /// <para>
    /// A medicinal product in a container or package.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var medicinalproductpackaged = new MedicinalProductPackaged("medicinalproductpackaged-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 MedicinalProductPackaged 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MedicinalProductPackaged : ResourceBase<R4Version>
    {
        private List<BackboneElement>? _batchidentifier;

        /// <summary>
        /// batchIdentifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// batchIdentifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? batchIdentifier
        {
            get => _batchidentifier;
            set
            {
                _batchidentifier = value;
                OnPropertyChanged(nameof(batchIdentifier));
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

        private CodeableConcept? _legalstatusofsupply;

        /// <summary>
        /// legalStatusOfSupply
        /// </summary>
        /// <remarks>
        /// <para>
        /// legalStatusOfSupply 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? legalStatusOfSupply
        {
            get => _legalstatusofsupply;
            set
            {
                _legalstatusofsupply = value;
                OnPropertyChanged(nameof(legalStatusOfSupply));
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

        private ReferenceType? _marketingauthorization;

        /// <summary>
        /// marketingAuthorization
        /// </summary>
        /// <remarks>
        /// <para>
        /// marketingAuthorization 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? marketingAuthorization
        {
            get => _marketingauthorization;
            set
            {
                _marketingauthorization = value;
                OnPropertyChanged(nameof(marketingAuthorization));
            }
        }

        private List<FhirString>? _marketingstatus;

        /// <summary>
        /// marketingStatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// marketingStatus 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? marketingStatus
        {
            get => _marketingstatus;
            set
            {
                _marketingstatus = value;
                OnPropertyChanged(nameof(marketingStatus));
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

        private List<BackboneElement>? _packageitem;

        /// <summary>
        /// packageItem
        /// </summary>
        /// <remarks>
        /// <para>
        /// packageItem 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? packageItem
        {
            get => _packageitem;
            set
            {
                _packageitem = value;
                OnPropertyChanged(nameof(packageItem));
            }
        }

        private List<ReferenceType>? _subject;

        /// <summary>
        /// subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// subject 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(subject));
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
        public override string ResourceType => "MedicinalProductPackaged";

        /// <summary>
        /// 建立新的 MedicinalProductPackaged 資源實例
        /// </summary>
        public MedicinalProductPackaged()
        {
        }

        /// <summary>
        /// 建立新的 MedicinalProductPackaged 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public MedicinalProductPackaged(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"MedicinalProductPackaged(Id: {Id})";
        }
    }
}
