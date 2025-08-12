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
    /// FHIR R4 SupplyRequest 資源
    /// 
    /// <para>
    /// A record of a request for a medication, substance or device used in the healthcare setting.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var supplyrequest = new SupplyRequest("supplyrequest-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 SupplyRequest 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class SupplyRequest : ResourceBase<R4Version>
    {
        private FhirDateTime? _authoredon;

        /// <summary>
        /// authoredOn
        /// </summary>
        /// <remarks>
        /// <para>
        /// authoredOn 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? authoredOn
        {
            get => _authoredon;
            set
            {
                _authoredon = value;
                OnPropertyChanged(nameof(authoredOn));
            }
        }

        private CodeableConcept? _category;

        /// <summary>
        /// category
        /// </summary>
        /// <remarks>
        /// <para>
        /// category 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(category));
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

        private ReferenceType? _deliverfrom;

        /// <summary>
        /// deliverFrom
        /// </summary>
        /// <remarks>
        /// <para>
        /// deliverFrom 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? deliverFrom
        {
            get => _deliverfrom;
            set
            {
                _deliverfrom = value;
                OnPropertyChanged(nameof(deliverFrom));
            }
        }

        private ReferenceType? _deliverto;

        /// <summary>
        /// deliverTo
        /// </summary>
        /// <remarks>
        /// <para>
        /// deliverTo 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? deliverTo
        {
            get => _deliverto;
            set
            {
                _deliverto = value;
                OnPropertyChanged(nameof(deliverTo));
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

        private List<BackboneElement>? _parameter;

        /// <summary>
        /// parameter
        /// </summary>
        /// <remarks>
        /// <para>
        /// parameter 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? parameter
        {
            get => _parameter;
            set
            {
                _parameter = value;
                OnPropertyChanged(nameof(parameter));
            }
        }

        private FhirCode? _priority;

        /// <summary>
        /// priority
        /// </summary>
        /// <remarks>
        /// <para>
        /// priority 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(priority));
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

        private List<CodeableConcept>? _reasoncode;

        /// <summary>
        /// reasonCode
        /// </summary>
        /// <remarks>
        /// <para>
        /// reasonCode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? reasonCode
        {
            get => _reasoncode;
            set
            {
                _reasoncode = value;
                OnPropertyChanged(nameof(reasonCode));
            }
        }

        private List<ReferenceType>? _reasonreference;

        /// <summary>
        /// reasonReference
        /// </summary>
        /// <remarks>
        /// <para>
        /// reasonReference 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? reasonReference
        {
            get => _reasonreference;
            set
            {
                _reasonreference = value;
                OnPropertyChanged(nameof(reasonReference));
            }
        }

        private ReferenceType? _requester;

        /// <summary>
        /// requester
        /// </summary>
        /// <remarks>
        /// <para>
        /// requester 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? requester
        {
            get => _requester;
            set
            {
                _requester = value;
                OnPropertyChanged(nameof(requester));
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

        private List<ReferenceType>? _supplier;

        /// <summary>
        /// supplier
        /// </summary>
        /// <remarks>
        /// <para>
        /// supplier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? supplier
        {
            get => _supplier;
            set
            {
                _supplier = value;
                OnPropertyChanged(nameof(supplier));
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
        public override string ResourceType => "SupplyRequest";

        /// <summary>
        /// 建立新的 SupplyRequest 資源實例
        /// </summary>
        public SupplyRequest()
        {
        }

        /// <summary>
        /// 建立新的 SupplyRequest 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public SupplyRequest(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"SupplyRequest(Id: {Id})";
        }
    }
}
