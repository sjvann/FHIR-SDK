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
    /// FHIR R4 MedicinalProductAuthorization 資源
    /// 
    /// <para>
    /// The regulatory authorization of a medicinal product.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var medicinalproductauthorization = new MedicinalProductAuthorization("medicinalproductauthorization-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 MedicinalProductAuthorization 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MedicinalProductAuthorization : ResourceBase<R4Version>
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

        private List<CodeableConcept>? _country;

        /// <summary>
        /// country
        /// </summary>
        /// <remarks>
        /// <para>
        /// country 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? country
        {
            get => _country;
            set
            {
                _country = value;
                OnPropertyChanged(nameof(country));
            }
        }

        private Period? _dataexclusivityperiod;

        /// <summary>
        /// dataExclusivityPeriod
        /// </summary>
        /// <remarks>
        /// <para>
        /// dataExclusivityPeriod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? dataExclusivityPeriod
        {
            get => _dataexclusivityperiod;
            set
            {
                _dataexclusivityperiod = value;
                OnPropertyChanged(nameof(dataExclusivityPeriod));
            }
        }

        private FhirDateTime? _dateoffirstauthorization;

        /// <summary>
        /// dateOfFirstAuthorization
        /// </summary>
        /// <remarks>
        /// <para>
        /// dateOfFirstAuthorization 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? dateOfFirstAuthorization
        {
            get => _dateoffirstauthorization;
            set
            {
                _dateoffirstauthorization = value;
                OnPropertyChanged(nameof(dateOfFirstAuthorization));
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

        private ReferenceType? _holder;

        /// <summary>
        /// holder
        /// </summary>
        /// <remarks>
        /// <para>
        /// holder 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? holder
        {
            get => _holder;
            set
            {
                _holder = value;
                OnPropertyChanged(nameof(holder));
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

        private FhirDateTime? _internationalbirthdate;

        /// <summary>
        /// internationalBirthDate
        /// </summary>
        /// <remarks>
        /// <para>
        /// internationalBirthDate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? internationalBirthDate
        {
            get => _internationalbirthdate;
            set
            {
                _internationalbirthdate = value;
                OnPropertyChanged(nameof(internationalBirthDate));
            }
        }

        private List<CodeableConcept>? _jurisdiction;

        /// <summary>
        /// jurisdiction
        /// </summary>
        /// <remarks>
        /// <para>
        /// jurisdiction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? jurisdiction
        {
            get => _jurisdiction;
            set
            {
                _jurisdiction = value;
                OnPropertyChanged(nameof(jurisdiction));
            }
        }

        private List<BackboneElement>? _jurisdictionalauthorization;

        /// <summary>
        /// jurisdictionalAuthorization
        /// </summary>
        /// <remarks>
        /// <para>
        /// jurisdictionalAuthorization 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? jurisdictionalAuthorization
        {
            get => _jurisdictionalauthorization;
            set
            {
                _jurisdictionalauthorization = value;
                OnPropertyChanged(nameof(jurisdictionalAuthorization));
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

        private CodeableConcept? _legalbasis;

        /// <summary>
        /// legalBasis
        /// </summary>
        /// <remarks>
        /// <para>
        /// legalBasis 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? legalBasis
        {
            get => _legalbasis;
            set
            {
                _legalbasis = value;
                OnPropertyChanged(nameof(legalBasis));
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

        private BackboneElement? _procedure;

        /// <summary>
        /// procedure
        /// </summary>
        /// <remarks>
        /// <para>
        /// procedure 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? procedure
        {
            get => _procedure;
            set
            {
                _procedure = value;
                OnPropertyChanged(nameof(procedure));
            }
        }

        private ReferenceType? _regulator;

        /// <summary>
        /// regulator
        /// </summary>
        /// <remarks>
        /// <para>
        /// regulator 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? regulator
        {
            get => _regulator;
            set
            {
                _regulator = value;
                OnPropertyChanged(nameof(regulator));
            }
        }

        private FhirDateTime? _restoredate;

        /// <summary>
        /// restoreDate
        /// </summary>
        /// <remarks>
        /// <para>
        /// restoreDate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? restoreDate
        {
            get => _restoredate;
            set
            {
                _restoredate = value;
                OnPropertyChanged(nameof(restoreDate));
            }
        }

        private CodeableConcept? _status;

        /// <summary>
        /// status
        /// </summary>
        /// <remarks>
        /// <para>
        /// status 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(status));
            }
        }

        private FhirDateTime? _statusdate;

        /// <summary>
        /// statusDate
        /// </summary>
        /// <remarks>
        /// <para>
        /// statusDate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? statusDate
        {
            get => _statusdate;
            set
            {
                _statusdate = value;
                OnPropertyChanged(nameof(statusDate));
            }
        }

        private ReferenceType? _subject;

        /// <summary>
        /// subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// subject 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? subject
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

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "MedicinalProductAuthorization";

        /// <summary>
        /// 建立新的 MedicinalProductAuthorization 資源實例
        /// </summary>
        public MedicinalProductAuthorization()
        {
        }

        /// <summary>
        /// 建立新的 MedicinalProductAuthorization 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public MedicinalProductAuthorization(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"MedicinalProductAuthorization(Id: {Id})";
        }
    }
}
