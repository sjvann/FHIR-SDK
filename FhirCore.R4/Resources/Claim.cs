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
    /// FHIR R4 Claim 資源
    /// 
    /// <para>
    /// A provider issued list of professional services and products which have been provided, or are to be provided, to a patient which is sent to an insurer for reimbursement.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var claim = new Claim("claim-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 Claim 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Claim : ResourceBase<R4Version>
    {
        private BackboneElement? _accident;

        /// <summary>
        /// accident
        /// </summary>
        /// <remarks>
        /// <para>
        /// accident 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? accident
        {
            get => _accident;
            set
            {
                _accident = value;
                OnPropertyChanged(nameof(accident));
            }
        }

        private Period? _billableperiod;

        /// <summary>
        /// billablePeriod
        /// </summary>
        /// <remarks>
        /// <para>
        /// billablePeriod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? billablePeriod
        {
            get => _billableperiod;
            set
            {
                _billableperiod = value;
                OnPropertyChanged(nameof(billablePeriod));
            }
        }

        private List<BackboneElement>? _careteam;

        /// <summary>
        /// careTeam
        /// </summary>
        /// <remarks>
        /// <para>
        /// careTeam 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? careTeam
        {
            get => _careteam;
            set
            {
                _careteam = value;
                OnPropertyChanged(nameof(careTeam));
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

        private FhirDateTime? _created;

        /// <summary>
        /// created
        /// </summary>
        /// <remarks>
        /// <para>
        /// created 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? created
        {
            get => _created;
            set
            {
                _created = value;
                OnPropertyChanged(nameof(created));
            }
        }

        private List<BackboneElement>? _diagnosis;

        /// <summary>
        /// diagnosis
        /// </summary>
        /// <remarks>
        /// <para>
        /// diagnosis 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? diagnosis
        {
            get => _diagnosis;
            set
            {
                _diagnosis = value;
                OnPropertyChanged(nameof(diagnosis));
            }
        }

        private ReferenceType? _enterer;

        /// <summary>
        /// enterer
        /// </summary>
        /// <remarks>
        /// <para>
        /// enterer 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? enterer
        {
            get => _enterer;
            set
            {
                _enterer = value;
                OnPropertyChanged(nameof(enterer));
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

        private ReferenceType? _facility;

        /// <summary>
        /// facility
        /// </summary>
        /// <remarks>
        /// <para>
        /// facility 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? facility
        {
            get => _facility;
            set
            {
                _facility = value;
                OnPropertyChanged(nameof(facility));
            }
        }

        private CodeableConcept? _fundsreserve;

        /// <summary>
        /// fundsReserve
        /// </summary>
        /// <remarks>
        /// <para>
        /// fundsReserve 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? fundsReserve
        {
            get => _fundsreserve;
            set
            {
                _fundsreserve = value;
                OnPropertyChanged(nameof(fundsReserve));
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

        private List<BackboneElement>? _insurance;

        /// <summary>
        /// insurance
        /// </summary>
        /// <remarks>
        /// <para>
        /// insurance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? insurance
        {
            get => _insurance;
            set
            {
                _insurance = value;
                OnPropertyChanged(nameof(insurance));
            }
        }

        private ReferenceType? _insurer;

        /// <summary>
        /// insurer
        /// </summary>
        /// <remarks>
        /// <para>
        /// insurer 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? insurer
        {
            get => _insurer;
            set
            {
                _insurer = value;
                OnPropertyChanged(nameof(insurer));
            }
        }

        private List<BackboneElement>? _item;

        /// <summary>
        /// item
        /// </summary>
        /// <remarks>
        /// <para>
        /// item 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged(nameof(item));
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

        private ReferenceType? _originalprescription;

        /// <summary>
        /// originalPrescription
        /// </summary>
        /// <remarks>
        /// <para>
        /// originalPrescription 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? originalPrescription
        {
            get => _originalprescription;
            set
            {
                _originalprescription = value;
                OnPropertyChanged(nameof(originalPrescription));
            }
        }

        private ReferenceType? _patient;

        /// <summary>
        /// patient
        /// </summary>
        /// <remarks>
        /// <para>
        /// patient 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? patient
        {
            get => _patient;
            set
            {
                _patient = value;
                OnPropertyChanged(nameof(patient));
            }
        }

        private BackboneElement? _payee;

        /// <summary>
        /// payee
        /// </summary>
        /// <remarks>
        /// <para>
        /// payee 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? payee
        {
            get => _payee;
            set
            {
                _payee = value;
                OnPropertyChanged(nameof(payee));
            }
        }

        private ReferenceType? _prescription;

        /// <summary>
        /// prescription
        /// </summary>
        /// <remarks>
        /// <para>
        /// prescription 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? prescription
        {
            get => _prescription;
            set
            {
                _prescription = value;
                OnPropertyChanged(nameof(prescription));
            }
        }

        private CodeableConcept? _priority;

        /// <summary>
        /// priority
        /// </summary>
        /// <remarks>
        /// <para>
        /// priority 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(priority));
            }
        }

        private List<BackboneElement>? _procedure;

        /// <summary>
        /// procedure
        /// </summary>
        /// <remarks>
        /// <para>
        /// procedure 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? procedure
        {
            get => _procedure;
            set
            {
                _procedure = value;
                OnPropertyChanged(nameof(procedure));
            }
        }

        private ReferenceType? _provider;

        /// <summary>
        /// provider
        /// </summary>
        /// <remarks>
        /// <para>
        /// provider 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? provider
        {
            get => _provider;
            set
            {
                _provider = value;
                OnPropertyChanged(nameof(provider));
            }
        }

        private ReferenceType? _referral;

        /// <summary>
        /// referral
        /// </summary>
        /// <remarks>
        /// <para>
        /// referral 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? referral
        {
            get => _referral;
            set
            {
                _referral = value;
                OnPropertyChanged(nameof(referral));
            }
        }

        private List<BackboneElement>? _related;

        /// <summary>
        /// related
        /// </summary>
        /// <remarks>
        /// <para>
        /// related 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? related
        {
            get => _related;
            set
            {
                _related = value;
                OnPropertyChanged(nameof(related));
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

        private CodeableConcept? _subtype;

        /// <summary>
        /// subType
        /// </summary>
        /// <remarks>
        /// <para>
        /// subType 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? subType
        {
            get => _subtype;
            set
            {
                _subtype = value;
                OnPropertyChanged(nameof(subType));
            }
        }

        private List<BackboneElement>? _supportinginfo;

        /// <summary>
        /// supportingInfo
        /// </summary>
        /// <remarks>
        /// <para>
        /// supportingInfo 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? supportingInfo
        {
            get => _supportinginfo;
            set
            {
                _supportinginfo = value;
                OnPropertyChanged(nameof(supportingInfo));
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

        private FhirString? _total;

        /// <summary>
        /// total
        /// </summary>
        /// <remarks>
        /// <para>
        /// total 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? total
        {
            get => _total;
            set
            {
                _total = value;
                OnPropertyChanged(nameof(total));
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

        private FhirCode? _use;

        /// <summary>
        /// use
        /// </summary>
        /// <remarks>
        /// <para>
        /// use 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? use
        {
            get => _use;
            set
            {
                _use = value;
                OnPropertyChanged(nameof(use));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Claim";

        /// <summary>
        /// 建立新的 Claim 資源實例
        /// </summary>
        public Claim()
        {
        }

        /// <summary>
        /// 建立新的 Claim 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Claim(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Claim(Id: {Id})";
        }
    }
}
