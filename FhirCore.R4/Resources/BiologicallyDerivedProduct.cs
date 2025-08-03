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
    /// FHIR R4 BiologicallyDerivedProduct 資源
    /// 
    /// <para>
    /// A material substance originating from a biological entity intended to be transplanted or infused into another (possibly the same) biological entity.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var biologicallyderivedproduct = new BiologicallyDerivedProduct("biologicallyderivedproduct-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 BiologicallyDerivedProduct 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class BiologicallyDerivedProduct : ResourceBase<R4Version>
    {
        private BackboneElement? _collection;

        /// <summary>
        /// collection
        /// </summary>
        /// <remarks>
        /// <para>
        /// collection 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? collection
        {
            get => _collection;
            set
            {
                _collection = value;
                OnPropertyChanged(nameof(collection));
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

        private BackboneElement? _manipulation;

        /// <summary>
        /// manipulation
        /// </summary>
        /// <remarks>
        /// <para>
        /// manipulation 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? manipulation
        {
            get => _manipulation;
            set
            {
                _manipulation = value;
                OnPropertyChanged(nameof(manipulation));
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

        private List<ReferenceType>? _parent;

        /// <summary>
        /// parent
        /// </summary>
        /// <remarks>
        /// <para>
        /// parent 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? parent
        {
            get => _parent;
            set
            {
                _parent = value;
                OnPropertyChanged(nameof(parent));
            }
        }

        private List<BackboneElement>? _processing;

        /// <summary>
        /// processing
        /// </summary>
        /// <remarks>
        /// <para>
        /// processing 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? processing
        {
            get => _processing;
            set
            {
                _processing = value;
                OnPropertyChanged(nameof(processing));
            }
        }

        private FhirCode? _productcategory;

        /// <summary>
        /// productCategory
        /// </summary>
        /// <remarks>
        /// <para>
        /// productCategory 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? productCategory
        {
            get => _productcategory;
            set
            {
                _productcategory = value;
                OnPropertyChanged(nameof(productCategory));
            }
        }

        private CodeableConcept? _productcode;

        /// <summary>
        /// productCode
        /// </summary>
        /// <remarks>
        /// <para>
        /// productCode 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? productCode
        {
            get => _productcode;
            set
            {
                _productcode = value;
                OnPropertyChanged(nameof(productCode));
            }
        }

        private FhirInteger? _quantity;

        /// <summary>
        /// quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(quantity));
            }
        }

        private List<ReferenceType>? _request;

        /// <summary>
        /// request
        /// </summary>
        /// <remarks>
        /// <para>
        /// request 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? request
        {
            get => _request;
            set
            {
                _request = value;
                OnPropertyChanged(nameof(request));
            }
        }

        private FhirCode? _status;

        /// <summary>
        /// status
        /// </summary>
        /// <remarks>
        /// <para>
        /// status 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(status));
            }
        }

        private List<BackboneElement>? _storage;

        /// <summary>
        /// storage
        /// </summary>
        /// <remarks>
        /// <para>
        /// storage 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? storage
        {
            get => _storage;
            set
            {
                _storage = value;
                OnPropertyChanged(nameof(storage));
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
        public override string ResourceType => "BiologicallyDerivedProduct";

        /// <summary>
        /// 建立新的 BiologicallyDerivedProduct 資源實例
        /// </summary>
        public BiologicallyDerivedProduct()
        {
        }

        /// <summary>
        /// 建立新的 BiologicallyDerivedProduct 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public BiologicallyDerivedProduct(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"BiologicallyDerivedProduct(Id: {Id})";
        }
    }
}
