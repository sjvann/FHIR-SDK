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
    /// FHIR R4 CatalogEntry 資源
    /// 
    /// <para>
    /// Catalog entries are wrappers that contextualize items included in a catalog.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var catalogentry = new CatalogEntry("catalogentry-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 CatalogEntry 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class CatalogEntry : ResourceBase<R4Version>
    {
        private List<CodeableConcept>? _additionalcharacteristic;

        /// <summary>
        /// additionalCharacteristic
        /// </summary>
        /// <remarks>
        /// <para>
        /// additionalCharacteristic 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? additionalCharacteristic
        {
            get => _additionalcharacteristic;
            set
            {
                _additionalcharacteristic = value;
                OnPropertyChanged(nameof(additionalCharacteristic));
            }
        }

        private List<CodeableConcept>? _additionalclassification;

        /// <summary>
        /// additionalClassification
        /// </summary>
        /// <remarks>
        /// <para>
        /// additionalClassification 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? additionalClassification
        {
            get => _additionalclassification;
            set
            {
                _additionalclassification = value;
                OnPropertyChanged(nameof(additionalClassification));
            }
        }

        private List<Identifier>? _additionalidentifier;

        /// <summary>
        /// additionalIdentifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// additionalIdentifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? additionalIdentifier
        {
            get => _additionalidentifier;
            set
            {
                _additionalidentifier = value;
                OnPropertyChanged(nameof(additionalIdentifier));
            }
        }

        private List<CodeableConcept>? _classification;

        /// <summary>
        /// classification
        /// </summary>
        /// <remarks>
        /// <para>
        /// classification 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? classification
        {
            get => _classification;
            set
            {
                _classification = value;
                OnPropertyChanged(nameof(classification));
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

        private FhirDateTime? _lastupdated;

        /// <summary>
        /// lastUpdated
        /// </summary>
        /// <remarks>
        /// <para>
        /// lastUpdated 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? lastUpdated
        {
            get => _lastupdated;
            set
            {
                _lastupdated = value;
                OnPropertyChanged(nameof(lastUpdated));
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

        private FhirBoolean? _orderable;

        /// <summary>
        /// orderable
        /// </summary>
        /// <remarks>
        /// <para>
        /// orderable 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? orderable
        {
            get => _orderable;
            set
            {
                _orderable = value;
                OnPropertyChanged(nameof(orderable));
            }
        }

        private ReferenceType? _referenceditem;

        /// <summary>
        /// referencedItem
        /// </summary>
        /// <remarks>
        /// <para>
        /// referencedItem 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? referencedItem
        {
            get => _referenceditem;
            set
            {
                _referenceditem = value;
                OnPropertyChanged(nameof(referencedItem));
            }
        }

        private List<BackboneElement>? _relatedentry;

        /// <summary>
        /// relatedEntry
        /// </summary>
        /// <remarks>
        /// <para>
        /// relatedEntry 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? relatedEntry
        {
            get => _relatedentry;
            set
            {
                _relatedentry = value;
                OnPropertyChanged(nameof(relatedEntry));
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

        private Period? _validityperiod;

        /// <summary>
        /// validityPeriod
        /// </summary>
        /// <remarks>
        /// <para>
        /// validityPeriod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? validityPeriod
        {
            get => _validityperiod;
            set
            {
                _validityperiod = value;
                OnPropertyChanged(nameof(validityPeriod));
            }
        }

        private FhirDateTime? _validto;

        /// <summary>
        /// validTo
        /// </summary>
        /// <remarks>
        /// <para>
        /// validTo 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? validTo
        {
            get => _validto;
            set
            {
                _validto = value;
                OnPropertyChanged(nameof(validTo));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "CatalogEntry";

        /// <summary>
        /// 建立新的 CatalogEntry 資源實例
        /// </summary>
        public CatalogEntry()
        {
        }

        /// <summary>
        /// 建立新的 CatalogEntry 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public CatalogEntry(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"CatalogEntry(Id: {Id})";
        }
    }
}
