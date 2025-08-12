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
    /// FHIR R4 ExplanationOfBenefit 資源
    /// 
    /// <para>
    /// This resource provides: the claim details; adjudication details from the processing of a Claim; and optionally account balance information, for informing the subscriber of the benefits provided.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var explanationofbenefit = new ExplanationOfBenefit("explanationofbenefit-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 ExplanationOfBenefit 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ExplanationOfBenefit : ResourceBase<R4Version>
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

        private List<BackboneElement>? _additem;

        /// <summary>
        /// addItem
        /// </summary>
        /// <remarks>
        /// <para>
        /// addItem 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? addItem
        {
            get => _additem;
            set
            {
                _additem = value;
                OnPropertyChanged(nameof(addItem));
            }
        }

        private List<FhirString>? _adjudication;

        /// <summary>
        /// adjudication
        /// </summary>
        /// <remarks>
        /// <para>
        /// adjudication 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? adjudication
        {
            get => _adjudication;
            set
            {
                _adjudication = value;
                OnPropertyChanged(nameof(adjudication));
            }
        }

        private List<BackboneElement>? _benefitbalance;

        /// <summary>
        /// benefitBalance
        /// </summary>
        /// <remarks>
        /// <para>
        /// benefitBalance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? benefitBalance
        {
            get => _benefitbalance;
            set
            {
                _benefitbalance = value;
                OnPropertyChanged(nameof(benefitBalance));
            }
        }

        private Period? _benefitperiod;

        /// <summary>
        /// benefitPeriod
        /// </summary>
        /// <remarks>
        /// <para>
        /// benefitPeriod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? benefitPeriod
        {
            get => _benefitperiod;
            set
            {
                _benefitperiod = value;
                OnPropertyChanged(nameof(benefitPeriod));
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

        private ReferenceType? _claim;

        /// <summary>
        /// claim
        /// </summary>
        /// <remarks>
        /// <para>
        /// claim 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? claim
        {
            get => _claim;
            set
            {
                _claim = value;
                OnPropertyChanged(nameof(claim));
            }
        }

        private ReferenceType? _claimresponse;

        /// <summary>
        /// claimResponse
        /// </summary>
        /// <remarks>
        /// <para>
        /// claimResponse 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? claimResponse
        {
            get => _claimresponse;
            set
            {
                _claimresponse = value;
                OnPropertyChanged(nameof(claimResponse));
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

        private FhirString? _disposition;

        /// <summary>
        /// disposition
        /// </summary>
        /// <remarks>
        /// <para>
        /// disposition 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? disposition
        {
            get => _disposition;
            set
            {
                _disposition = value;
                OnPropertyChanged(nameof(disposition));
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

        private Attachment? _form;

        /// <summary>
        /// form
        /// </summary>
        /// <remarks>
        /// <para>
        /// form 的詳細描述。
        /// </para>
        /// </remarks>
        public Attachment? form
        {
            get => _form;
            set
            {
                _form = value;
                OnPropertyChanged(nameof(form));
            }
        }

        private CodeableConcept? _formcode;

        /// <summary>
        /// formCode
        /// </summary>
        /// <remarks>
        /// <para>
        /// formCode 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? formCode
        {
            get => _formcode;
            set
            {
                _formcode = value;
                OnPropertyChanged(nameof(formCode));
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

        private CodeableConcept? _fundsreserverequested;

        /// <summary>
        /// fundsReserveRequested
        /// </summary>
        /// <remarks>
        /// <para>
        /// fundsReserveRequested 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? fundsReserveRequested
        {
            get => _fundsreserverequested;
            set
            {
                _fundsreserverequested = value;
                OnPropertyChanged(nameof(fundsReserveRequested));
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

        private FhirCode? _outcome;

        /// <summary>
        /// outcome
        /// </summary>
        /// <remarks>
        /// <para>
        /// outcome 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? outcome
        {
            get => _outcome;
            set
            {
                _outcome = value;
                OnPropertyChanged(nameof(outcome));
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

        private BackboneElement? _payment;

        /// <summary>
        /// payment
        /// </summary>
        /// <remarks>
        /// <para>
        /// payment 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? payment
        {
            get => _payment;
            set
            {
                _payment = value;
                OnPropertyChanged(nameof(payment));
            }
        }

        private List<FhirString>? _preauthref;

        /// <summary>
        /// preAuthRef
        /// </summary>
        /// <remarks>
        /// <para>
        /// preAuthRef 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? preAuthRef
        {
            get => _preauthref;
            set
            {
                _preauthref = value;
                OnPropertyChanged(nameof(preAuthRef));
            }
        }

        private List<Period>? _preauthrefperiod;

        /// <summary>
        /// preAuthRefPeriod
        /// </summary>
        /// <remarks>
        /// <para>
        /// preAuthRefPeriod 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Period>? preAuthRefPeriod
        {
            get => _preauthrefperiod;
            set
            {
                _preauthrefperiod = value;
                OnPropertyChanged(nameof(preAuthRefPeriod));
            }
        }

        private FhirPositiveInt? _precedence;

        /// <summary>
        /// precedence
        /// </summary>
        /// <remarks>
        /// <para>
        /// precedence 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? precedence
        {
            get => _precedence;
            set
            {
                _precedence = value;
                OnPropertyChanged(nameof(precedence));
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

        private List<BackboneElement>? _processnote;

        /// <summary>
        /// processNote
        /// </summary>
        /// <remarks>
        /// <para>
        /// processNote 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? processNote
        {
            get => _processnote;
            set
            {
                _processnote = value;
                OnPropertyChanged(nameof(processNote));
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

        private List<BackboneElement>? _total;

        /// <summary>
        /// total
        /// </summary>
        /// <remarks>
        /// <para>
        /// total 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? total
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
        public override string ResourceType => "ExplanationOfBenefit";

        /// <summary>
        /// 建立新的 ExplanationOfBenefit 資源實例
        /// </summary>
        public ExplanationOfBenefit()
        {
        }

        /// <summary>
        /// 建立新的 ExplanationOfBenefit 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ExplanationOfBenefit(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ExplanationOfBenefit(Id: {Id})";
        }
    }
}
