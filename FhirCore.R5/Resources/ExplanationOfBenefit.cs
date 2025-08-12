using FhirCore.Base;
using FhirCore.R5;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using FhirCore.Interfaces;

namespace FhirCore.R5.Resources
{
    /// <summary>
    /// FHIR R5 ExplanationOfBenefit 資源
    /// 
    /// <para>
    /// ExplanationOfBenefit 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
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
    /// R5 版本的 ExplanationOfBenefit 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ExplanationOfBenefit : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<Identifier>? _tracenumber;
        private FhirCode? _status;
        private CodeableConcept? _type;
        private CodeableConcept? _subtype;
        private FhirCode? _use;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _patient;
        private Period? _billableperiod;
        private FhirDateTime? _created;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _enterer;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _insurer;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _provider;
        private CodeableConcept? _priority;
        private CodeableConcept? _fundsreserverequested;
        private CodeableConcept? _fundsreserve;
        private List<ExplanationOfBenefitRelated>? _related;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _prescription;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _originalprescription;
        private List<ExplanationOfBenefitEvent>? _event;
        private ExplanationOfBenefitPayee? _payee;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _referral;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _encounter;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _facility;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _claim;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _claimresponse;
        private FhirCode? _outcome;
        private CodeableConcept? _decision;
        private FhirString? _disposition;
        private List<FhirString>? _preauthref;
        private List<Period>? _preauthrefperiod;
        private CodeableConcept? _diagnosisrelatedgroup;
        private List<ExplanationOfBenefitCareTeam>? _careteam;
        private List<ExplanationOfBenefitSupportingInfo>? _supportinginfo;
        private List<ExplanationOfBenefitDiagnosis>? _diagnosis;
        private List<ExplanationOfBenefitProcedure>? _procedure;
        private FhirPositiveInt? _precedence;
        private List<ExplanationOfBenefitInsurance>? _insurance;
        private ExplanationOfBenefitAccident? _accident;
        private Money? _patientpaid;
        private List<ExplanationOfBenefitItem>? _item;
        private List<ExplanationOfBenefitAddItem>? _additem;
        private List<ExplanationOfBenefitTotal>? _total;
        private ExplanationOfBenefitPayment? _payment;
        private CodeableConcept? _formcode;
        private Attachment? _form;
        private List<ExplanationOfBenefitProcessNote>? _processnote;
        private Period? _benefitperiod;
        private List<ExplanationOfBenefitBenefitBalance>? _benefitbalance;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _claim;
        private CodeableConcept? _relationship;
        private Identifier? _reference;
        private CodeableConcept? _type;
        private ExplanationOfBenefitEventWhenChoice? _when;
        private CodeableConcept? _type;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _party;
        private FhirPositiveInt? _sequence;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _provider;
        private FhirBoolean? _responsible;
        private CodeableConcept? _role;
        private CodeableConcept? _specialty;
        private FhirPositiveInt? _sequence;
        private CodeableConcept? _category;
        private CodeableConcept? _code;
        private ExplanationOfBenefitSupportingInfoTimingChoice? _timing;
        private ExplanationOfBenefitSupportingInfoValueChoice? _value;
        private Coding? _reason;
        private FhirPositiveInt? _sequence;
        private ExplanationOfBenefitDiagnosisDiagnosisChoice? _diagnosis;
        private List<CodeableConcept>? _type;
        private CodeableConcept? _onadmission;
        private FhirPositiveInt? _sequence;
        private List<CodeableConcept>? _type;
        private FhirDateTime? _date;
        private ExplanationOfBenefitProcedureProcedureChoice? _procedure;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _udi;
        private FhirBoolean? _focal;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _coverage;
        private List<FhirString>? _preauthref;
        private FhirDate? _date;
        private CodeableConcept? _type;
        private ExplanationOfBenefitAccidentLocationChoice? _location;
        private List<CodeableReference>? _site;
        private List<CodeableConcept>? _subsite;
        private CodeableConcept? _decision;
        private List<CodeableConcept>? _reason;
        private FhirString? _preauthref;
        private Period? _preauthperiod;
        private CodeableConcept? _category;
        private CodeableConcept? _reason;
        private Money? _amount;
        private Quantity? _quantity;
        private FhirPositiveInt? _sequence;
        private List<Identifier>? _tracenumber;
        private CodeableConcept? _revenue;
        private CodeableConcept? _category;
        private CodeableConcept? _productorservice;
        private CodeableConcept? _productorserviceend;
        private List<CodeableConcept>? _modifier;
        private List<CodeableConcept>? _programcode;
        private Money? _patientpaid;
        private Quantity? _quantity;
        private Money? _unitprice;
        private FhirDecimal? _factor;
        private Money? _tax;
        private Money? _net;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _udi;
        private List<FhirPositiveInt>? _notenumber;
        private FhirPositiveInt? _sequence;
        private List<Identifier>? _tracenumber;
        private CodeableConcept? _revenue;
        private CodeableConcept? _category;
        private CodeableConcept? _productorservice;
        private CodeableConcept? _productorserviceend;
        private List<CodeableConcept>? _modifier;
        private List<CodeableConcept>? _programcode;
        private Money? _patientpaid;
        private Quantity? _quantity;
        private Money? _unitprice;
        private FhirDecimal? _factor;
        private Money? _tax;
        private Money? _net;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _udi;
        private List<FhirPositiveInt>? _notenumber;
        private List<ExplanationOfBenefitItemDetailSubDetail>? _subdetail;
        private FhirPositiveInt? _sequence;
        private List<FhirPositiveInt>? _careteamsequence;
        private List<FhirPositiveInt>? _diagnosissequence;
        private List<FhirPositiveInt>? _proceduresequence;
        private List<FhirPositiveInt>? _informationsequence;
        private List<Identifier>? _tracenumber;
        private CodeableConcept? _revenue;
        private CodeableConcept? _category;
        private CodeableConcept? _productorservice;
        private CodeableConcept? _productorserviceend;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _request;
        private List<CodeableConcept>? _modifier;
        private List<CodeableConcept>? _programcode;
        private ExplanationOfBenefitItemServicedChoice? _serviced;
        private ExplanationOfBenefitItemLocationChoice? _location;
        private Money? _patientpaid;
        private Quantity? _quantity;
        private Money? _unitprice;
        private FhirDecimal? _factor;
        private Money? _tax;
        private Money? _net;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _udi;
        private List<ExplanationOfBenefitItemBodySite>? _bodysite;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _encounter;
        private List<FhirPositiveInt>? _notenumber;
        private ExplanationOfBenefitItemReviewOutcome? _reviewoutcome;
        private List<ExplanationOfBenefitItemAdjudication>? _adjudication;
        private List<ExplanationOfBenefitItemDetail>? _detail;
        private List<CodeableReference>? _site;
        private List<CodeableConcept>? _subsite;
        private List<Identifier>? _tracenumber;
        private CodeableConcept? _revenue;
        private CodeableConcept? _productorservice;
        private CodeableConcept? _productorserviceend;
        private List<CodeableConcept>? _modifier;
        private Money? _patientpaid;
        private Quantity? _quantity;
        private Money? _unitprice;
        private FhirDecimal? _factor;
        private Money? _tax;
        private Money? _net;
        private List<FhirPositiveInt>? _notenumber;
        private List<Identifier>? _tracenumber;
        private CodeableConcept? _revenue;
        private CodeableConcept? _productorservice;
        private CodeableConcept? _productorserviceend;
        private List<CodeableConcept>? _modifier;
        private Money? _patientpaid;
        private Quantity? _quantity;
        private Money? _unitprice;
        private FhirDecimal? _factor;
        private Money? _tax;
        private Money? _net;
        private List<FhirPositiveInt>? _notenumber;
        private List<ExplanationOfBenefitAddItemDetailSubDetail>? _subdetail;
        private List<FhirPositiveInt>? _itemsequence;
        private List<FhirPositiveInt>? _detailsequence;
        private List<FhirPositiveInt>? _subdetailsequence;
        private List<Identifier>? _tracenumber;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _provider;
        private CodeableConcept? _revenue;
        private CodeableConcept? _productorservice;
        private CodeableConcept? _productorserviceend;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _request;
        private List<CodeableConcept>? _modifier;
        private List<CodeableConcept>? _programcode;
        private ExplanationOfBenefitAddItemServicedChoice? _serviced;
        private ExplanationOfBenefitAddItemLocationChoice? _location;
        private Money? _patientpaid;
        private Quantity? _quantity;
        private Money? _unitprice;
        private FhirDecimal? _factor;
        private Money? _tax;
        private Money? _net;
        private List<ExplanationOfBenefitAddItemBodySite>? _bodysite;
        private List<FhirPositiveInt>? _notenumber;
        private List<ExplanationOfBenefitAddItemDetail>? _detail;
        private CodeableConcept? _category;
        private Money? _amount;
        private CodeableConcept? _type;
        private Money? _adjustment;
        private CodeableConcept? _adjustmentreason;
        private FhirDate? _date;
        private Money? _amount;
        private Identifier? _identifier;
        private FhirPositiveInt? _number;
        private CodeableConcept? _type;
        private CodeableConcept? _language;
        private CodeableConcept? _type;
        private ExplanationOfBenefitBenefitBalanceFinancialAllowedChoice? _allowed;
        private ExplanationOfBenefitBenefitBalanceFinancialUsedChoice? _used;
        private CodeableConcept? _category;
        private FhirBoolean? _excluded;
        private FhirString? _name;
        private FhirString? _description;
        private CodeableConcept? _network;
        private CodeableConcept? _unit;
        private CodeableConcept? _term;
        private List<ExplanationOfBenefitBenefitBalanceFinancial>? _financial;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ExplanationOfBenefit";        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private List<Identifier>? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
            }
        }        /// <summary>
        /// Tracenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tracenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Tracenumber
        {
            get => _tracenumber;
            set
            {
                _tracenumber = value;
                OnPropertyChanged(nameof(Tracenumber));
            }
        }        /// <summary>
        /// Status
        /// </summary>
        /// <remarks>
        /// <para>
        /// Status 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Subtype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subtype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Subtype
        {
            get => _subtype;
            set
            {
                _subtype = value;
                OnPropertyChanged(nameof(Subtype));
            }
        }        /// <summary>
        /// Use
        /// </summary>
        /// <remarks>
        /// <para>
        /// Use 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Use
        {
            get => _use;
            set
            {
                _use = value;
                OnPropertyChanged(nameof(Use));
            }
        }        /// <summary>
        /// Patient
        /// </summary>
        /// <remarks>
        /// <para>
        /// Patient 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Patient
        {
            get => _patient;
            set
            {
                _patient = value;
                OnPropertyChanged(nameof(Patient));
            }
        }        /// <summary>
        /// Billableperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Billableperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Billableperiod
        {
            get => _billableperiod;
            set
            {
                _billableperiod = value;
                OnPropertyChanged(nameof(Billableperiod));
            }
        }        /// <summary>
        /// Created
        /// </summary>
        /// <remarks>
        /// <para>
        /// Created 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Created
        {
            get => _created;
            set
            {
                _created = value;
                OnPropertyChanged(nameof(Created));
            }
        }        /// <summary>
        /// Enterer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Enterer 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Enterer
        {
            get => _enterer;
            set
            {
                _enterer = value;
                OnPropertyChanged(nameof(Enterer));
            }
        }        /// <summary>
        /// Insurer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Insurer 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Insurer
        {
            get => _insurer;
            set
            {
                _insurer = value;
                OnPropertyChanged(nameof(Insurer));
            }
        }        /// <summary>
        /// Provider
        /// </summary>
        /// <remarks>
        /// <para>
        /// Provider 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Provider
        {
            get => _provider;
            set
            {
                _provider = value;
                OnPropertyChanged(nameof(Provider));
            }
        }        /// <summary>
        /// Priority
        /// </summary>
        /// <remarks>
        /// <para>
        /// Priority 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(Priority));
            }
        }        /// <summary>
        /// Fundsreserverequested
        /// </summary>
        /// <remarks>
        /// <para>
        /// Fundsreserverequested 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Fundsreserverequested
        {
            get => _fundsreserverequested;
            set
            {
                _fundsreserverequested = value;
                OnPropertyChanged(nameof(Fundsreserverequested));
            }
        }        /// <summary>
        /// Fundsreserve
        /// </summary>
        /// <remarks>
        /// <para>
        /// Fundsreserve 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Fundsreserve
        {
            get => _fundsreserve;
            set
            {
                _fundsreserve = value;
                OnPropertyChanged(nameof(Fundsreserve));
            }
        }        /// <summary>
        /// Related
        /// </summary>
        /// <remarks>
        /// <para>
        /// Related 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExplanationOfBenefitRelated>? Related
        {
            get => _related;
            set
            {
                _related = value;
                OnPropertyChanged(nameof(Related));
            }
        }        /// <summary>
        /// Prescription
        /// </summary>
        /// <remarks>
        /// <para>
        /// Prescription 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Prescription
        {
            get => _prescription;
            set
            {
                _prescription = value;
                OnPropertyChanged(nameof(Prescription));
            }
        }        /// <summary>
        /// Originalprescription
        /// </summary>
        /// <remarks>
        /// <para>
        /// Originalprescription 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Originalprescription
        {
            get => _originalprescription;
            set
            {
                _originalprescription = value;
                OnPropertyChanged(nameof(Originalprescription));
            }
        }        /// <summary>
        /// Event
        /// </summary>
        /// <remarks>
        /// <para>
        /// Event 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExplanationOfBenefitEvent>? Event
        {
            get => _event;
            set
            {
                _event = value;
                OnPropertyChanged(nameof(Event));
            }
        }        /// <summary>
        /// Payee
        /// </summary>
        /// <remarks>
        /// <para>
        /// Payee 的詳細描述。
        /// </para>
        /// </remarks>
        public ExplanationOfBenefitPayee? Payee
        {
            get => _payee;
            set
            {
                _payee = value;
                OnPropertyChanged(nameof(Payee));
            }
        }        /// <summary>
        /// Referral
        /// </summary>
        /// <remarks>
        /// <para>
        /// Referral 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Referral
        {
            get => _referral;
            set
            {
                _referral = value;
                OnPropertyChanged(nameof(Referral));
            }
        }        /// <summary>
        /// Encounter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Encounter 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Encounter
        {
            get => _encounter;
            set
            {
                _encounter = value;
                OnPropertyChanged(nameof(Encounter));
            }
        }        /// <summary>
        /// Facility
        /// </summary>
        /// <remarks>
        /// <para>
        /// Facility 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Facility
        {
            get => _facility;
            set
            {
                _facility = value;
                OnPropertyChanged(nameof(Facility));
            }
        }        /// <summary>
        /// Claim
        /// </summary>
        /// <remarks>
        /// <para>
        /// Claim 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Claim
        {
            get => _claim;
            set
            {
                _claim = value;
                OnPropertyChanged(nameof(Claim));
            }
        }        /// <summary>
        /// Claimresponse
        /// </summary>
        /// <remarks>
        /// <para>
        /// Claimresponse 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Claimresponse
        {
            get => _claimresponse;
            set
            {
                _claimresponse = value;
                OnPropertyChanged(nameof(Claimresponse));
            }
        }        /// <summary>
        /// Outcome
        /// </summary>
        /// <remarks>
        /// <para>
        /// Outcome 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Outcome
        {
            get => _outcome;
            set
            {
                _outcome = value;
                OnPropertyChanged(nameof(Outcome));
            }
        }        /// <summary>
        /// Decision
        /// </summary>
        /// <remarks>
        /// <para>
        /// Decision 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Decision
        {
            get => _decision;
            set
            {
                _decision = value;
                OnPropertyChanged(nameof(Decision));
            }
        }        /// <summary>
        /// Disposition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Disposition 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Disposition
        {
            get => _disposition;
            set
            {
                _disposition = value;
                OnPropertyChanged(nameof(Disposition));
            }
        }        /// <summary>
        /// Preauthref
        /// </summary>
        /// <remarks>
        /// <para>
        /// Preauthref 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Preauthref
        {
            get => _preauthref;
            set
            {
                _preauthref = value;
                OnPropertyChanged(nameof(Preauthref));
            }
        }        /// <summary>
        /// Preauthrefperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Preauthrefperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Period>? Preauthrefperiod
        {
            get => _preauthrefperiod;
            set
            {
                _preauthrefperiod = value;
                OnPropertyChanged(nameof(Preauthrefperiod));
            }
        }        /// <summary>
        /// Diagnosisrelatedgroup
        /// </summary>
        /// <remarks>
        /// <para>
        /// Diagnosisrelatedgroup 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Diagnosisrelatedgroup
        {
            get => _diagnosisrelatedgroup;
            set
            {
                _diagnosisrelatedgroup = value;
                OnPropertyChanged(nameof(Diagnosisrelatedgroup));
            }
        }        /// <summary>
        /// Careteam
        /// </summary>
        /// <remarks>
        /// <para>
        /// Careteam 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExplanationOfBenefitCareTeam>? Careteam
        {
            get => _careteam;
            set
            {
                _careteam = value;
                OnPropertyChanged(nameof(Careteam));
            }
        }        /// <summary>
        /// Supportinginfo
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supportinginfo 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExplanationOfBenefitSupportingInfo>? Supportinginfo
        {
            get => _supportinginfo;
            set
            {
                _supportinginfo = value;
                OnPropertyChanged(nameof(Supportinginfo));
            }
        }        /// <summary>
        /// Diagnosis
        /// </summary>
        /// <remarks>
        /// <para>
        /// Diagnosis 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExplanationOfBenefitDiagnosis>? Diagnosis
        {
            get => _diagnosis;
            set
            {
                _diagnosis = value;
                OnPropertyChanged(nameof(Diagnosis));
            }
        }        /// <summary>
        /// Procedure
        /// </summary>
        /// <remarks>
        /// <para>
        /// Procedure 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExplanationOfBenefitProcedure>? Procedure
        {
            get => _procedure;
            set
            {
                _procedure = value;
                OnPropertyChanged(nameof(Procedure));
            }
        }        /// <summary>
        /// Precedence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Precedence 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Precedence
        {
            get => _precedence;
            set
            {
                _precedence = value;
                OnPropertyChanged(nameof(Precedence));
            }
        }        /// <summary>
        /// Insurance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Insurance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExplanationOfBenefitInsurance>? Insurance
        {
            get => _insurance;
            set
            {
                _insurance = value;
                OnPropertyChanged(nameof(Insurance));
            }
        }        /// <summary>
        /// Accident
        /// </summary>
        /// <remarks>
        /// <para>
        /// Accident 的詳細描述。
        /// </para>
        /// </remarks>
        public ExplanationOfBenefitAccident? Accident
        {
            get => _accident;
            set
            {
                _accident = value;
                OnPropertyChanged(nameof(Accident));
            }
        }        /// <summary>
        /// Patientpaid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Patientpaid 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Patientpaid
        {
            get => _patientpaid;
            set
            {
                _patientpaid = value;
                OnPropertyChanged(nameof(Patientpaid));
            }
        }        /// <summary>
        /// Item
        /// </summary>
        /// <remarks>
        /// <para>
        /// Item 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExplanationOfBenefitItem>? Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged(nameof(Item));
            }
        }        /// <summary>
        /// Additem
        /// </summary>
        /// <remarks>
        /// <para>
        /// Additem 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExplanationOfBenefitAddItem>? Additem
        {
            get => _additem;
            set
            {
                _additem = value;
                OnPropertyChanged(nameof(Additem));
            }
        }        /// <summary>
        /// Total
        /// </summary>
        /// <remarks>
        /// <para>
        /// Total 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExplanationOfBenefitTotal>? Total
        {
            get => _total;
            set
            {
                _total = value;
                OnPropertyChanged(nameof(Total));
            }
        }        /// <summary>
        /// Payment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Payment 的詳細描述。
        /// </para>
        /// </remarks>
        public ExplanationOfBenefitPayment? Payment
        {
            get => _payment;
            set
            {
                _payment = value;
                OnPropertyChanged(nameof(Payment));
            }
        }        /// <summary>
        /// Formcode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Formcode 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Formcode
        {
            get => _formcode;
            set
            {
                _formcode = value;
                OnPropertyChanged(nameof(Formcode));
            }
        }        /// <summary>
        /// Form
        /// </summary>
        /// <remarks>
        /// <para>
        /// Form 的詳細描述。
        /// </para>
        /// </remarks>
        public Attachment? Form
        {
            get => _form;
            set
            {
                _form = value;
                OnPropertyChanged(nameof(Form));
            }
        }        /// <summary>
        /// Processnote
        /// </summary>
        /// <remarks>
        /// <para>
        /// Processnote 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExplanationOfBenefitProcessNote>? Processnote
        {
            get => _processnote;
            set
            {
                _processnote = value;
                OnPropertyChanged(nameof(Processnote));
            }
        }        /// <summary>
        /// Benefitperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Benefitperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Benefitperiod
        {
            get => _benefitperiod;
            set
            {
                _benefitperiod = value;
                OnPropertyChanged(nameof(Benefitperiod));
            }
        }        /// <summary>
        /// Benefitbalance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Benefitbalance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExplanationOfBenefitBenefitBalance>? Benefitbalance
        {
            get => _benefitbalance;
            set
            {
                _benefitbalance = value;
                OnPropertyChanged(nameof(Benefitbalance));
            }
        }        /// <summary>
        /// Claim
        /// </summary>
        /// <remarks>
        /// <para>
        /// Claim 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Claim
        {
            get => _claim;
            set
            {
                _claim = value;
                OnPropertyChanged(nameof(Claim));
            }
        }        /// <summary>
        /// Relationship
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relationship 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Relationship
        {
            get => _relationship;
            set
            {
                _relationship = value;
                OnPropertyChanged(nameof(Relationship));
            }
        }        /// <summary>
        /// Reference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reference 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? Reference
        {
            get => _reference;
            set
            {
                _reference = value;
                OnPropertyChanged(nameof(Reference));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// When
        /// </summary>
        /// <remarks>
        /// <para>
        /// When 的詳細描述。
        /// </para>
        /// </remarks>
        public ExplanationOfBenefitEventWhenChoice? When
        {
            get => _when;
            set
            {
                _when = value;
                OnPropertyChanged(nameof(When));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Party
        /// </summary>
        /// <remarks>
        /// <para>
        /// Party 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Party
        {
            get => _party;
            set
            {
                _party = value;
                OnPropertyChanged(nameof(Party));
            }
        }        /// <summary>
        /// Sequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sequence 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Sequence
        {
            get => _sequence;
            set
            {
                _sequence = value;
                OnPropertyChanged(nameof(Sequence));
            }
        }        /// <summary>
        /// Provider
        /// </summary>
        /// <remarks>
        /// <para>
        /// Provider 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Provider
        {
            get => _provider;
            set
            {
                _provider = value;
                OnPropertyChanged(nameof(Provider));
            }
        }        /// <summary>
        /// Responsible
        /// </summary>
        /// <remarks>
        /// <para>
        /// Responsible 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Responsible
        {
            get => _responsible;
            set
            {
                _responsible = value;
                OnPropertyChanged(nameof(Responsible));
            }
        }        /// <summary>
        /// Role
        /// </summary>
        /// <remarks>
        /// <para>
        /// Role 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Role
        {
            get => _role;
            set
            {
                _role = value;
                OnPropertyChanged(nameof(Role));
            }
        }        /// <summary>
        /// Specialty
        /// </summary>
        /// <remarks>
        /// <para>
        /// Specialty 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Specialty
        {
            get => _specialty;
            set
            {
                _specialty = value;
                OnPropertyChanged(nameof(Specialty));
            }
        }        /// <summary>
        /// Sequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sequence 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Sequence
        {
            get => _sequence;
            set
            {
                _sequence = value;
                OnPropertyChanged(nameof(Sequence));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Timing
        /// </summary>
        /// <remarks>
        /// <para>
        /// Timing 的詳細描述。
        /// </para>
        /// </remarks>
        public ExplanationOfBenefitSupportingInfoTimingChoice? Timing
        {
            get => _timing;
            set
            {
                _timing = value;
                OnPropertyChanged(nameof(Timing));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public ExplanationOfBenefitSupportingInfoValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }        /// <summary>
        /// Sequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sequence 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Sequence
        {
            get => _sequence;
            set
            {
                _sequence = value;
                OnPropertyChanged(nameof(Sequence));
            }
        }        /// <summary>
        /// Diagnosis
        /// </summary>
        /// <remarks>
        /// <para>
        /// Diagnosis 的詳細描述。
        /// </para>
        /// </remarks>
        public ExplanationOfBenefitDiagnosisDiagnosisChoice? Diagnosis
        {
            get => _diagnosis;
            set
            {
                _diagnosis = value;
                OnPropertyChanged(nameof(Diagnosis));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Onadmission
        /// </summary>
        /// <remarks>
        /// <para>
        /// Onadmission 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Onadmission
        {
            get => _onadmission;
            set
            {
                _onadmission = value;
                OnPropertyChanged(nameof(Onadmission));
            }
        }        /// <summary>
        /// Sequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sequence 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Sequence
        {
            get => _sequence;
            set
            {
                _sequence = value;
                OnPropertyChanged(nameof(Sequence));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Date
        /// </summary>
        /// <remarks>
        /// <para>
        /// Date 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }        /// <summary>
        /// Procedure
        /// </summary>
        /// <remarks>
        /// <para>
        /// Procedure 的詳細描述。
        /// </para>
        /// </remarks>
        public ExplanationOfBenefitProcedureProcedureChoice? Procedure
        {
            get => _procedure;
            set
            {
                _procedure = value;
                OnPropertyChanged(nameof(Procedure));
            }
        }        /// <summary>
        /// Udi
        /// </summary>
        /// <remarks>
        /// <para>
        /// Udi 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Udi
        {
            get => _udi;
            set
            {
                _udi = value;
                OnPropertyChanged(nameof(Udi));
            }
        }        /// <summary>
        /// Focal
        /// </summary>
        /// <remarks>
        /// <para>
        /// Focal 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Focal
        {
            get => _focal;
            set
            {
                _focal = value;
                OnPropertyChanged(nameof(Focal));
            }
        }        /// <summary>
        /// Coverage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Coverage 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Coverage
        {
            get => _coverage;
            set
            {
                _coverage = value;
                OnPropertyChanged(nameof(Coverage));
            }
        }        /// <summary>
        /// Preauthref
        /// </summary>
        /// <remarks>
        /// <para>
        /// Preauthref 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Preauthref
        {
            get => _preauthref;
            set
            {
                _preauthref = value;
                OnPropertyChanged(nameof(Preauthref));
            }
        }        /// <summary>
        /// Date
        /// </summary>
        /// <remarks>
        /// <para>
        /// Date 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Location
        /// </summary>
        /// <remarks>
        /// <para>
        /// Location 的詳細描述。
        /// </para>
        /// </remarks>
        public ExplanationOfBenefitAccidentLocationChoice? Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }        /// <summary>
        /// Site
        /// </summary>
        /// <remarks>
        /// <para>
        /// Site 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Site
        {
            get => _site;
            set
            {
                _site = value;
                OnPropertyChanged(nameof(Site));
            }
        }        /// <summary>
        /// Subsite
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subsite 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Subsite
        {
            get => _subsite;
            set
            {
                _subsite = value;
                OnPropertyChanged(nameof(Subsite));
            }
        }        /// <summary>
        /// Decision
        /// </summary>
        /// <remarks>
        /// <para>
        /// Decision 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Decision
        {
            get => _decision;
            set
            {
                _decision = value;
                OnPropertyChanged(nameof(Decision));
            }
        }        /// <summary>
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }        /// <summary>
        /// Preauthref
        /// </summary>
        /// <remarks>
        /// <para>
        /// Preauthref 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Preauthref
        {
            get => _preauthref;
            set
            {
                _preauthref = value;
                OnPropertyChanged(nameof(Preauthref));
            }
        }        /// <summary>
        /// Preauthperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Preauthperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Preauthperiod
        {
            get => _preauthperiod;
            set
            {
                _preauthperiod = value;
                OnPropertyChanged(nameof(Preauthperiod));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }        /// <summary>
        /// Amount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Amount 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }        /// <summary>
        /// Quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }        /// <summary>
        /// Sequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sequence 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Sequence
        {
            get => _sequence;
            set
            {
                _sequence = value;
                OnPropertyChanged(nameof(Sequence));
            }
        }        /// <summary>
        /// Tracenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tracenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Tracenumber
        {
            get => _tracenumber;
            set
            {
                _tracenumber = value;
                OnPropertyChanged(nameof(Tracenumber));
            }
        }        /// <summary>
        /// Revenue
        /// </summary>
        /// <remarks>
        /// <para>
        /// Revenue 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Revenue
        {
            get => _revenue;
            set
            {
                _revenue = value;
                OnPropertyChanged(nameof(Revenue));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Productorservice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productorservice 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Productorservice
        {
            get => _productorservice;
            set
            {
                _productorservice = value;
                OnPropertyChanged(nameof(Productorservice));
            }
        }        /// <summary>
        /// Productorserviceend
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productorserviceend 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Productorserviceend
        {
            get => _productorserviceend;
            set
            {
                _productorserviceend = value;
                OnPropertyChanged(nameof(Productorserviceend));
            }
        }        /// <summary>
        /// Modifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Modifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Modifier
        {
            get => _modifier;
            set
            {
                _modifier = value;
                OnPropertyChanged(nameof(Modifier));
            }
        }        /// <summary>
        /// Programcode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Programcode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Programcode
        {
            get => _programcode;
            set
            {
                _programcode = value;
                OnPropertyChanged(nameof(Programcode));
            }
        }        /// <summary>
        /// Patientpaid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Patientpaid 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Patientpaid
        {
            get => _patientpaid;
            set
            {
                _patientpaid = value;
                OnPropertyChanged(nameof(Patientpaid));
            }
        }        /// <summary>
        /// Quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }        /// <summary>
        /// Unitprice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Unitprice 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Unitprice
        {
            get => _unitprice;
            set
            {
                _unitprice = value;
                OnPropertyChanged(nameof(Unitprice));
            }
        }        /// <summary>
        /// Factor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Factor 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? Factor
        {
            get => _factor;
            set
            {
                _factor = value;
                OnPropertyChanged(nameof(Factor));
            }
        }        /// <summary>
        /// Tax
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tax 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Tax
        {
            get => _tax;
            set
            {
                _tax = value;
                OnPropertyChanged(nameof(Tax));
            }
        }        /// <summary>
        /// Net
        /// </summary>
        /// <remarks>
        /// <para>
        /// Net 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Net
        {
            get => _net;
            set
            {
                _net = value;
                OnPropertyChanged(nameof(Net));
            }
        }        /// <summary>
        /// Udi
        /// </summary>
        /// <remarks>
        /// <para>
        /// Udi 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Udi
        {
            get => _udi;
            set
            {
                _udi = value;
                OnPropertyChanged(nameof(Udi));
            }
        }        /// <summary>
        /// Notenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Notenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Notenumber
        {
            get => _notenumber;
            set
            {
                _notenumber = value;
                OnPropertyChanged(nameof(Notenumber));
            }
        }        /// <summary>
        /// Sequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sequence 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Sequence
        {
            get => _sequence;
            set
            {
                _sequence = value;
                OnPropertyChanged(nameof(Sequence));
            }
        }        /// <summary>
        /// Tracenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tracenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Tracenumber
        {
            get => _tracenumber;
            set
            {
                _tracenumber = value;
                OnPropertyChanged(nameof(Tracenumber));
            }
        }        /// <summary>
        /// Revenue
        /// </summary>
        /// <remarks>
        /// <para>
        /// Revenue 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Revenue
        {
            get => _revenue;
            set
            {
                _revenue = value;
                OnPropertyChanged(nameof(Revenue));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Productorservice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productorservice 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Productorservice
        {
            get => _productorservice;
            set
            {
                _productorservice = value;
                OnPropertyChanged(nameof(Productorservice));
            }
        }        /// <summary>
        /// Productorserviceend
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productorserviceend 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Productorserviceend
        {
            get => _productorserviceend;
            set
            {
                _productorserviceend = value;
                OnPropertyChanged(nameof(Productorserviceend));
            }
        }        /// <summary>
        /// Modifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Modifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Modifier
        {
            get => _modifier;
            set
            {
                _modifier = value;
                OnPropertyChanged(nameof(Modifier));
            }
        }        /// <summary>
        /// Programcode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Programcode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Programcode
        {
            get => _programcode;
            set
            {
                _programcode = value;
                OnPropertyChanged(nameof(Programcode));
            }
        }        /// <summary>
        /// Patientpaid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Patientpaid 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Patientpaid
        {
            get => _patientpaid;
            set
            {
                _patientpaid = value;
                OnPropertyChanged(nameof(Patientpaid));
            }
        }        /// <summary>
        /// Quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }        /// <summary>
        /// Unitprice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Unitprice 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Unitprice
        {
            get => _unitprice;
            set
            {
                _unitprice = value;
                OnPropertyChanged(nameof(Unitprice));
            }
        }        /// <summary>
        /// Factor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Factor 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? Factor
        {
            get => _factor;
            set
            {
                _factor = value;
                OnPropertyChanged(nameof(Factor));
            }
        }        /// <summary>
        /// Tax
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tax 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Tax
        {
            get => _tax;
            set
            {
                _tax = value;
                OnPropertyChanged(nameof(Tax));
            }
        }        /// <summary>
        /// Net
        /// </summary>
        /// <remarks>
        /// <para>
        /// Net 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Net
        {
            get => _net;
            set
            {
                _net = value;
                OnPropertyChanged(nameof(Net));
            }
        }        /// <summary>
        /// Udi
        /// </summary>
        /// <remarks>
        /// <para>
        /// Udi 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Udi
        {
            get => _udi;
            set
            {
                _udi = value;
                OnPropertyChanged(nameof(Udi));
            }
        }        /// <summary>
        /// Notenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Notenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Notenumber
        {
            get => _notenumber;
            set
            {
                _notenumber = value;
                OnPropertyChanged(nameof(Notenumber));
            }
        }        /// <summary>
        /// Subdetail
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subdetail 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExplanationOfBenefitItemDetailSubDetail>? Subdetail
        {
            get => _subdetail;
            set
            {
                _subdetail = value;
                OnPropertyChanged(nameof(Subdetail));
            }
        }        /// <summary>
        /// Sequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sequence 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Sequence
        {
            get => _sequence;
            set
            {
                _sequence = value;
                OnPropertyChanged(nameof(Sequence));
            }
        }        /// <summary>
        /// Careteamsequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Careteamsequence 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Careteamsequence
        {
            get => _careteamsequence;
            set
            {
                _careteamsequence = value;
                OnPropertyChanged(nameof(Careteamsequence));
            }
        }        /// <summary>
        /// Diagnosissequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Diagnosissequence 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Diagnosissequence
        {
            get => _diagnosissequence;
            set
            {
                _diagnosissequence = value;
                OnPropertyChanged(nameof(Diagnosissequence));
            }
        }        /// <summary>
        /// Proceduresequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Proceduresequence 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Proceduresequence
        {
            get => _proceduresequence;
            set
            {
                _proceduresequence = value;
                OnPropertyChanged(nameof(Proceduresequence));
            }
        }        /// <summary>
        /// Informationsequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Informationsequence 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Informationsequence
        {
            get => _informationsequence;
            set
            {
                _informationsequence = value;
                OnPropertyChanged(nameof(Informationsequence));
            }
        }        /// <summary>
        /// Tracenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tracenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Tracenumber
        {
            get => _tracenumber;
            set
            {
                _tracenumber = value;
                OnPropertyChanged(nameof(Tracenumber));
            }
        }        /// <summary>
        /// Revenue
        /// </summary>
        /// <remarks>
        /// <para>
        /// Revenue 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Revenue
        {
            get => _revenue;
            set
            {
                _revenue = value;
                OnPropertyChanged(nameof(Revenue));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Productorservice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productorservice 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Productorservice
        {
            get => _productorservice;
            set
            {
                _productorservice = value;
                OnPropertyChanged(nameof(Productorservice));
            }
        }        /// <summary>
        /// Productorserviceend
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productorserviceend 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Productorserviceend
        {
            get => _productorserviceend;
            set
            {
                _productorserviceend = value;
                OnPropertyChanged(nameof(Productorserviceend));
            }
        }        /// <summary>
        /// Request
        /// </summary>
        /// <remarks>
        /// <para>
        /// Request 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Request
        {
            get => _request;
            set
            {
                _request = value;
                OnPropertyChanged(nameof(Request));
            }
        }        /// <summary>
        /// Modifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Modifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Modifier
        {
            get => _modifier;
            set
            {
                _modifier = value;
                OnPropertyChanged(nameof(Modifier));
            }
        }        /// <summary>
        /// Programcode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Programcode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Programcode
        {
            get => _programcode;
            set
            {
                _programcode = value;
                OnPropertyChanged(nameof(Programcode));
            }
        }        /// <summary>
        /// Serviced
        /// </summary>
        /// <remarks>
        /// <para>
        /// Serviced 的詳細描述。
        /// </para>
        /// </remarks>
        public ExplanationOfBenefitItemServicedChoice? Serviced
        {
            get => _serviced;
            set
            {
                _serviced = value;
                OnPropertyChanged(nameof(Serviced));
            }
        }        /// <summary>
        /// Location
        /// </summary>
        /// <remarks>
        /// <para>
        /// Location 的詳細描述。
        /// </para>
        /// </remarks>
        public ExplanationOfBenefitItemLocationChoice? Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }        /// <summary>
        /// Patientpaid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Patientpaid 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Patientpaid
        {
            get => _patientpaid;
            set
            {
                _patientpaid = value;
                OnPropertyChanged(nameof(Patientpaid));
            }
        }        /// <summary>
        /// Quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }        /// <summary>
        /// Unitprice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Unitprice 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Unitprice
        {
            get => _unitprice;
            set
            {
                _unitprice = value;
                OnPropertyChanged(nameof(Unitprice));
            }
        }        /// <summary>
        /// Factor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Factor 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? Factor
        {
            get => _factor;
            set
            {
                _factor = value;
                OnPropertyChanged(nameof(Factor));
            }
        }        /// <summary>
        /// Tax
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tax 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Tax
        {
            get => _tax;
            set
            {
                _tax = value;
                OnPropertyChanged(nameof(Tax));
            }
        }        /// <summary>
        /// Net
        /// </summary>
        /// <remarks>
        /// <para>
        /// Net 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Net
        {
            get => _net;
            set
            {
                _net = value;
                OnPropertyChanged(nameof(Net));
            }
        }        /// <summary>
        /// Udi
        /// </summary>
        /// <remarks>
        /// <para>
        /// Udi 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Udi
        {
            get => _udi;
            set
            {
                _udi = value;
                OnPropertyChanged(nameof(Udi));
            }
        }        /// <summary>
        /// Bodysite
        /// </summary>
        /// <remarks>
        /// <para>
        /// Bodysite 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExplanationOfBenefitItemBodySite>? Bodysite
        {
            get => _bodysite;
            set
            {
                _bodysite = value;
                OnPropertyChanged(nameof(Bodysite));
            }
        }        /// <summary>
        /// Encounter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Encounter 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Encounter
        {
            get => _encounter;
            set
            {
                _encounter = value;
                OnPropertyChanged(nameof(Encounter));
            }
        }        /// <summary>
        /// Notenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Notenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Notenumber
        {
            get => _notenumber;
            set
            {
                _notenumber = value;
                OnPropertyChanged(nameof(Notenumber));
            }
        }        /// <summary>
        /// Reviewoutcome
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reviewoutcome 的詳細描述。
        /// </para>
        /// </remarks>
        public ExplanationOfBenefitItemReviewOutcome? Reviewoutcome
        {
            get => _reviewoutcome;
            set
            {
                _reviewoutcome = value;
                OnPropertyChanged(nameof(Reviewoutcome));
            }
        }        /// <summary>
        /// Adjudication
        /// </summary>
        /// <remarks>
        /// <para>
        /// Adjudication 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExplanationOfBenefitItemAdjudication>? Adjudication
        {
            get => _adjudication;
            set
            {
                _adjudication = value;
                OnPropertyChanged(nameof(Adjudication));
            }
        }        /// <summary>
        /// Detail
        /// </summary>
        /// <remarks>
        /// <para>
        /// Detail 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExplanationOfBenefitItemDetail>? Detail
        {
            get => _detail;
            set
            {
                _detail = value;
                OnPropertyChanged(nameof(Detail));
            }
        }        /// <summary>
        /// Site
        /// </summary>
        /// <remarks>
        /// <para>
        /// Site 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Site
        {
            get => _site;
            set
            {
                _site = value;
                OnPropertyChanged(nameof(Site));
            }
        }        /// <summary>
        /// Subsite
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subsite 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Subsite
        {
            get => _subsite;
            set
            {
                _subsite = value;
                OnPropertyChanged(nameof(Subsite));
            }
        }        /// <summary>
        /// Tracenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tracenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Tracenumber
        {
            get => _tracenumber;
            set
            {
                _tracenumber = value;
                OnPropertyChanged(nameof(Tracenumber));
            }
        }        /// <summary>
        /// Revenue
        /// </summary>
        /// <remarks>
        /// <para>
        /// Revenue 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Revenue
        {
            get => _revenue;
            set
            {
                _revenue = value;
                OnPropertyChanged(nameof(Revenue));
            }
        }        /// <summary>
        /// Productorservice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productorservice 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Productorservice
        {
            get => _productorservice;
            set
            {
                _productorservice = value;
                OnPropertyChanged(nameof(Productorservice));
            }
        }        /// <summary>
        /// Productorserviceend
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productorserviceend 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Productorserviceend
        {
            get => _productorserviceend;
            set
            {
                _productorserviceend = value;
                OnPropertyChanged(nameof(Productorserviceend));
            }
        }        /// <summary>
        /// Modifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Modifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Modifier
        {
            get => _modifier;
            set
            {
                _modifier = value;
                OnPropertyChanged(nameof(Modifier));
            }
        }        /// <summary>
        /// Patientpaid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Patientpaid 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Patientpaid
        {
            get => _patientpaid;
            set
            {
                _patientpaid = value;
                OnPropertyChanged(nameof(Patientpaid));
            }
        }        /// <summary>
        /// Quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }        /// <summary>
        /// Unitprice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Unitprice 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Unitprice
        {
            get => _unitprice;
            set
            {
                _unitprice = value;
                OnPropertyChanged(nameof(Unitprice));
            }
        }        /// <summary>
        /// Factor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Factor 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? Factor
        {
            get => _factor;
            set
            {
                _factor = value;
                OnPropertyChanged(nameof(Factor));
            }
        }        /// <summary>
        /// Tax
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tax 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Tax
        {
            get => _tax;
            set
            {
                _tax = value;
                OnPropertyChanged(nameof(Tax));
            }
        }        /// <summary>
        /// Net
        /// </summary>
        /// <remarks>
        /// <para>
        /// Net 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Net
        {
            get => _net;
            set
            {
                _net = value;
                OnPropertyChanged(nameof(Net));
            }
        }        /// <summary>
        /// Notenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Notenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Notenumber
        {
            get => _notenumber;
            set
            {
                _notenumber = value;
                OnPropertyChanged(nameof(Notenumber));
            }
        }        /// <summary>
        /// Tracenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tracenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Tracenumber
        {
            get => _tracenumber;
            set
            {
                _tracenumber = value;
                OnPropertyChanged(nameof(Tracenumber));
            }
        }        /// <summary>
        /// Revenue
        /// </summary>
        /// <remarks>
        /// <para>
        /// Revenue 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Revenue
        {
            get => _revenue;
            set
            {
                _revenue = value;
                OnPropertyChanged(nameof(Revenue));
            }
        }        /// <summary>
        /// Productorservice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productorservice 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Productorservice
        {
            get => _productorservice;
            set
            {
                _productorservice = value;
                OnPropertyChanged(nameof(Productorservice));
            }
        }        /// <summary>
        /// Productorserviceend
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productorserviceend 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Productorserviceend
        {
            get => _productorserviceend;
            set
            {
                _productorserviceend = value;
                OnPropertyChanged(nameof(Productorserviceend));
            }
        }        /// <summary>
        /// Modifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Modifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Modifier
        {
            get => _modifier;
            set
            {
                _modifier = value;
                OnPropertyChanged(nameof(Modifier));
            }
        }        /// <summary>
        /// Patientpaid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Patientpaid 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Patientpaid
        {
            get => _patientpaid;
            set
            {
                _patientpaid = value;
                OnPropertyChanged(nameof(Patientpaid));
            }
        }        /// <summary>
        /// Quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }        /// <summary>
        /// Unitprice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Unitprice 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Unitprice
        {
            get => _unitprice;
            set
            {
                _unitprice = value;
                OnPropertyChanged(nameof(Unitprice));
            }
        }        /// <summary>
        /// Factor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Factor 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? Factor
        {
            get => _factor;
            set
            {
                _factor = value;
                OnPropertyChanged(nameof(Factor));
            }
        }        /// <summary>
        /// Tax
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tax 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Tax
        {
            get => _tax;
            set
            {
                _tax = value;
                OnPropertyChanged(nameof(Tax));
            }
        }        /// <summary>
        /// Net
        /// </summary>
        /// <remarks>
        /// <para>
        /// Net 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Net
        {
            get => _net;
            set
            {
                _net = value;
                OnPropertyChanged(nameof(Net));
            }
        }        /// <summary>
        /// Notenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Notenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Notenumber
        {
            get => _notenumber;
            set
            {
                _notenumber = value;
                OnPropertyChanged(nameof(Notenumber));
            }
        }        /// <summary>
        /// Subdetail
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subdetail 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExplanationOfBenefitAddItemDetailSubDetail>? Subdetail
        {
            get => _subdetail;
            set
            {
                _subdetail = value;
                OnPropertyChanged(nameof(Subdetail));
            }
        }        /// <summary>
        /// Itemsequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Itemsequence 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Itemsequence
        {
            get => _itemsequence;
            set
            {
                _itemsequence = value;
                OnPropertyChanged(nameof(Itemsequence));
            }
        }        /// <summary>
        /// Detailsequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Detailsequence 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Detailsequence
        {
            get => _detailsequence;
            set
            {
                _detailsequence = value;
                OnPropertyChanged(nameof(Detailsequence));
            }
        }        /// <summary>
        /// Subdetailsequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subdetailsequence 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Subdetailsequence
        {
            get => _subdetailsequence;
            set
            {
                _subdetailsequence = value;
                OnPropertyChanged(nameof(Subdetailsequence));
            }
        }        /// <summary>
        /// Tracenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tracenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Tracenumber
        {
            get => _tracenumber;
            set
            {
                _tracenumber = value;
                OnPropertyChanged(nameof(Tracenumber));
            }
        }        /// <summary>
        /// Provider
        /// </summary>
        /// <remarks>
        /// <para>
        /// Provider 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Provider
        {
            get => _provider;
            set
            {
                _provider = value;
                OnPropertyChanged(nameof(Provider));
            }
        }        /// <summary>
        /// Revenue
        /// </summary>
        /// <remarks>
        /// <para>
        /// Revenue 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Revenue
        {
            get => _revenue;
            set
            {
                _revenue = value;
                OnPropertyChanged(nameof(Revenue));
            }
        }        /// <summary>
        /// Productorservice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productorservice 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Productorservice
        {
            get => _productorservice;
            set
            {
                _productorservice = value;
                OnPropertyChanged(nameof(Productorservice));
            }
        }        /// <summary>
        /// Productorserviceend
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productorserviceend 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Productorserviceend
        {
            get => _productorserviceend;
            set
            {
                _productorserviceend = value;
                OnPropertyChanged(nameof(Productorserviceend));
            }
        }        /// <summary>
        /// Request
        /// </summary>
        /// <remarks>
        /// <para>
        /// Request 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Request
        {
            get => _request;
            set
            {
                _request = value;
                OnPropertyChanged(nameof(Request));
            }
        }        /// <summary>
        /// Modifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Modifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Modifier
        {
            get => _modifier;
            set
            {
                _modifier = value;
                OnPropertyChanged(nameof(Modifier));
            }
        }        /// <summary>
        /// Programcode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Programcode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Programcode
        {
            get => _programcode;
            set
            {
                _programcode = value;
                OnPropertyChanged(nameof(Programcode));
            }
        }        /// <summary>
        /// Serviced
        /// </summary>
        /// <remarks>
        /// <para>
        /// Serviced 的詳細描述。
        /// </para>
        /// </remarks>
        public ExplanationOfBenefitAddItemServicedChoice? Serviced
        {
            get => _serviced;
            set
            {
                _serviced = value;
                OnPropertyChanged(nameof(Serviced));
            }
        }        /// <summary>
        /// Location
        /// </summary>
        /// <remarks>
        /// <para>
        /// Location 的詳細描述。
        /// </para>
        /// </remarks>
        public ExplanationOfBenefitAddItemLocationChoice? Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }        /// <summary>
        /// Patientpaid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Patientpaid 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Patientpaid
        {
            get => _patientpaid;
            set
            {
                _patientpaid = value;
                OnPropertyChanged(nameof(Patientpaid));
            }
        }        /// <summary>
        /// Quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }        /// <summary>
        /// Unitprice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Unitprice 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Unitprice
        {
            get => _unitprice;
            set
            {
                _unitprice = value;
                OnPropertyChanged(nameof(Unitprice));
            }
        }        /// <summary>
        /// Factor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Factor 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? Factor
        {
            get => _factor;
            set
            {
                _factor = value;
                OnPropertyChanged(nameof(Factor));
            }
        }        /// <summary>
        /// Tax
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tax 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Tax
        {
            get => _tax;
            set
            {
                _tax = value;
                OnPropertyChanged(nameof(Tax));
            }
        }        /// <summary>
        /// Net
        /// </summary>
        /// <remarks>
        /// <para>
        /// Net 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Net
        {
            get => _net;
            set
            {
                _net = value;
                OnPropertyChanged(nameof(Net));
            }
        }        /// <summary>
        /// Bodysite
        /// </summary>
        /// <remarks>
        /// <para>
        /// Bodysite 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExplanationOfBenefitAddItemBodySite>? Bodysite
        {
            get => _bodysite;
            set
            {
                _bodysite = value;
                OnPropertyChanged(nameof(Bodysite));
            }
        }        /// <summary>
        /// Notenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Notenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Notenumber
        {
            get => _notenumber;
            set
            {
                _notenumber = value;
                OnPropertyChanged(nameof(Notenumber));
            }
        }        /// <summary>
        /// Detail
        /// </summary>
        /// <remarks>
        /// <para>
        /// Detail 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExplanationOfBenefitAddItemDetail>? Detail
        {
            get => _detail;
            set
            {
                _detail = value;
                OnPropertyChanged(nameof(Detail));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Amount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Amount 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Adjustment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Adjustment 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Adjustment
        {
            get => _adjustment;
            set
            {
                _adjustment = value;
                OnPropertyChanged(nameof(Adjustment));
            }
        }        /// <summary>
        /// Adjustmentreason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Adjustmentreason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Adjustmentreason
        {
            get => _adjustmentreason;
            set
            {
                _adjustmentreason = value;
                OnPropertyChanged(nameof(Adjustmentreason));
            }
        }        /// <summary>
        /// Date
        /// </summary>
        /// <remarks>
        /// <para>
        /// Date 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }        /// <summary>
        /// Amount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Amount 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
            }
        }        /// <summary>
        /// Number
        /// </summary>
        /// <remarks>
        /// <para>
        /// Number 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Number
        {
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged(nameof(Number));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Language
        /// </summary>
        /// <remarks>
        /// <para>
        /// Language 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Language
        {
            get => _language;
            set
            {
                _language = value;
                OnPropertyChanged(nameof(Language));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Allowed
        /// </summary>
        /// <remarks>
        /// <para>
        /// Allowed 的詳細描述。
        /// </para>
        /// </remarks>
        public ExplanationOfBenefitBenefitBalanceFinancialAllowedChoice? Allowed
        {
            get => _allowed;
            set
            {
                _allowed = value;
                OnPropertyChanged(nameof(Allowed));
            }
        }        /// <summary>
        /// Used
        /// </summary>
        /// <remarks>
        /// <para>
        /// Used 的詳細描述。
        /// </para>
        /// </remarks>
        public ExplanationOfBenefitBenefitBalanceFinancialUsedChoice? Used
        {
            get => _used;
            set
            {
                _used = value;
                OnPropertyChanged(nameof(Used));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Excluded
        /// </summary>
        /// <remarks>
        /// <para>
        /// Excluded 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Excluded
        {
            get => _excluded;
            set
            {
                _excluded = value;
                OnPropertyChanged(nameof(Excluded));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Network
        /// </summary>
        /// <remarks>
        /// <para>
        /// Network 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Network
        {
            get => _network;
            set
            {
                _network = value;
                OnPropertyChanged(nameof(Network));
            }
        }        /// <summary>
        /// Unit
        /// </summary>
        /// <remarks>
        /// <para>
        /// Unit 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Unit
        {
            get => _unit;
            set
            {
                _unit = value;
                OnPropertyChanged(nameof(Unit));
            }
        }        /// <summary>
        /// Term
        /// </summary>
        /// <remarks>
        /// <para>
        /// Term 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Term
        {
            get => _term;
            set
            {
                _term = value;
                OnPropertyChanged(nameof(Term));
            }
        }        /// <summary>
        /// Financial
        /// </summary>
        /// <remarks>
        /// <para>
        /// Financial 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExplanationOfBenefitBenefitBalanceFinancial>? Financial
        {
            get => _financial;
            set
            {
                _financial = value;
                OnPropertyChanged(nameof(Financial));
            }
        }        /// <summary>
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
    }    /// <summary>
    /// ExplanationOfBenefitRelated 背骨元素
    /// </summary>
    public class ExplanationOfBenefitRelated
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitRelated() { }
    }    /// <summary>
    /// ExplanationOfBenefitEvent 背骨元素
    /// </summary>
    public class ExplanationOfBenefitEvent
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitEvent() { }
    }    /// <summary>
    /// ExplanationOfBenefitPayee 背骨元素
    /// </summary>
    public class ExplanationOfBenefitPayee
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitPayee() { }
    }    /// <summary>
    /// ExplanationOfBenefitCareTeam 背骨元素
    /// </summary>
    public class ExplanationOfBenefitCareTeam
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitCareTeam() { }
    }    /// <summary>
    /// ExplanationOfBenefitSupportingInfo 背骨元素
    /// </summary>
    public class ExplanationOfBenefitSupportingInfo
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitSupportingInfo() { }
    }    /// <summary>
    /// ExplanationOfBenefitDiagnosis 背骨元素
    /// </summary>
    public class ExplanationOfBenefitDiagnosis
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitDiagnosis() { }
    }    /// <summary>
    /// ExplanationOfBenefitProcedure 背骨元素
    /// </summary>
    public class ExplanationOfBenefitProcedure
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitProcedure() { }
    }    /// <summary>
    /// ExplanationOfBenefitInsurance 背骨元素
    /// </summary>
    public class ExplanationOfBenefitInsurance
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitInsurance() { }
    }    /// <summary>
    /// ExplanationOfBenefitAccident 背骨元素
    /// </summary>
    public class ExplanationOfBenefitAccident
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitAccident() { }
    }    /// <summary>
    /// ExplanationOfBenefitItemBodySite 背骨元素
    /// </summary>
    public class ExplanationOfBenefitItemBodySite
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitItemBodySite() { }
    }    /// <summary>
    /// ExplanationOfBenefitItemReviewOutcome 背骨元素
    /// </summary>
    public class ExplanationOfBenefitItemReviewOutcome
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitItemReviewOutcome() { }
    }    /// <summary>
    /// ExplanationOfBenefitItemAdjudication 背骨元素
    /// </summary>
    public class ExplanationOfBenefitItemAdjudication
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitItemAdjudication() { }
    }    /// <summary>
    /// ExplanationOfBenefitItemDetailSubDetail 背骨元素
    /// </summary>
    public class ExplanationOfBenefitItemDetailSubDetail
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitItemDetailSubDetail() { }
    }    /// <summary>
    /// ExplanationOfBenefitItemDetail 背骨元素
    /// </summary>
    public class ExplanationOfBenefitItemDetail
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitItemDetail() { }
    }    /// <summary>
    /// ExplanationOfBenefitItem 背骨元素
    /// </summary>
    public class ExplanationOfBenefitItem
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitItem() { }
    }    /// <summary>
    /// ExplanationOfBenefitAddItemBodySite 背骨元素
    /// </summary>
    public class ExplanationOfBenefitAddItemBodySite
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitAddItemBodySite() { }
    }    /// <summary>
    /// ExplanationOfBenefitAddItemDetailSubDetail 背骨元素
    /// </summary>
    public class ExplanationOfBenefitAddItemDetailSubDetail
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitAddItemDetailSubDetail() { }
    }    /// <summary>
    /// ExplanationOfBenefitAddItemDetail 背骨元素
    /// </summary>
    public class ExplanationOfBenefitAddItemDetail
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitAddItemDetail() { }
    }    /// <summary>
    /// ExplanationOfBenefitAddItem 背骨元素
    /// </summary>
    public class ExplanationOfBenefitAddItem
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitAddItem() { }
    }    /// <summary>
    /// ExplanationOfBenefitTotal 背骨元素
    /// </summary>
    public class ExplanationOfBenefitTotal
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitTotal() { }
    }    /// <summary>
    /// ExplanationOfBenefitPayment 背骨元素
    /// </summary>
    public class ExplanationOfBenefitPayment
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitPayment() { }
    }    /// <summary>
    /// ExplanationOfBenefitProcessNote 背骨元素
    /// </summary>
    public class ExplanationOfBenefitProcessNote
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitProcessNote() { }
    }    /// <summary>
    /// ExplanationOfBenefitBenefitBalanceFinancial 背骨元素
    /// </summary>
    public class ExplanationOfBenefitBenefitBalanceFinancial
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitBenefitBalanceFinancial() { }
    }    /// <summary>
    /// ExplanationOfBenefitBenefitBalance 背骨元素
    /// </summary>
    public class ExplanationOfBenefitBenefitBalance
    {
        // TODO: 添加屬性實作
        
        public ExplanationOfBenefitBenefitBalance() { }
    }    /// <summary>
    /// ExplanationOfBenefitEventWhenChoice 選擇類型
    /// </summary>
    public class ExplanationOfBenefitEventWhenChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ExplanationOfBenefitEventWhenChoice(JsonObject value) : base("explanationofbenefiteventwhen", value, _supportType) { }
        public ExplanationOfBenefitEventWhenChoice(IComplexType? value) : base("explanationofbenefiteventwhen", value) { }
        public ExplanationOfBenefitEventWhenChoice(IPrimitiveType? value) : base("explanationofbenefiteventwhen", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ExplanationOfBenefitEventWhen" : "explanationofbenefiteventwhen";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ExplanationOfBenefitSupportingInfoTimingChoice 選擇類型
    /// </summary>
    public class ExplanationOfBenefitSupportingInfoTimingChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ExplanationOfBenefitSupportingInfoTimingChoice(JsonObject value) : base("explanationofbenefitsupportinginfotiming", value, _supportType) { }
        public ExplanationOfBenefitSupportingInfoTimingChoice(IComplexType? value) : base("explanationofbenefitsupportinginfotiming", value) { }
        public ExplanationOfBenefitSupportingInfoTimingChoice(IPrimitiveType? value) : base("explanationofbenefitsupportinginfotiming", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ExplanationOfBenefitSupportingInfoTiming" : "explanationofbenefitsupportinginfotiming";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ExplanationOfBenefitSupportingInfoValueChoice 選擇類型
    /// </summary>
    public class ExplanationOfBenefitSupportingInfoValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ExplanationOfBenefitSupportingInfoValueChoice(JsonObject value) : base("explanationofbenefitsupportinginfovalue", value, _supportType) { }
        public ExplanationOfBenefitSupportingInfoValueChoice(IComplexType? value) : base("explanationofbenefitsupportinginfovalue", value) { }
        public ExplanationOfBenefitSupportingInfoValueChoice(IPrimitiveType? value) : base("explanationofbenefitsupportinginfovalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ExplanationOfBenefitSupportingInfoValue" : "explanationofbenefitsupportinginfovalue";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ExplanationOfBenefitDiagnosisDiagnosisChoice 選擇類型
    /// </summary>
    public class ExplanationOfBenefitDiagnosisDiagnosisChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ExplanationOfBenefitDiagnosisDiagnosisChoice(JsonObject value) : base("explanationofbenefitdiagnosisdiagnosis", value, _supportType) { }
        public ExplanationOfBenefitDiagnosisDiagnosisChoice(IComplexType? value) : base("explanationofbenefitdiagnosisdiagnosis", value) { }
        public ExplanationOfBenefitDiagnosisDiagnosisChoice(IPrimitiveType? value) : base("explanationofbenefitdiagnosisdiagnosis", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ExplanationOfBenefitDiagnosisDiagnosis" : "explanationofbenefitdiagnosisdiagnosis";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ExplanationOfBenefitProcedureProcedureChoice 選擇類型
    /// </summary>
    public class ExplanationOfBenefitProcedureProcedureChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ExplanationOfBenefitProcedureProcedureChoice(JsonObject value) : base("explanationofbenefitprocedureprocedure", value, _supportType) { }
        public ExplanationOfBenefitProcedureProcedureChoice(IComplexType? value) : base("explanationofbenefitprocedureprocedure", value) { }
        public ExplanationOfBenefitProcedureProcedureChoice(IPrimitiveType? value) : base("explanationofbenefitprocedureprocedure", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ExplanationOfBenefitProcedureProcedure" : "explanationofbenefitprocedureprocedure";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ExplanationOfBenefitAccidentLocationChoice 選擇類型
    /// </summary>
    public class ExplanationOfBenefitAccidentLocationChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ExplanationOfBenefitAccidentLocationChoice(JsonObject value) : base("explanationofbenefitaccidentlocation", value, _supportType) { }
        public ExplanationOfBenefitAccidentLocationChoice(IComplexType? value) : base("explanationofbenefitaccidentlocation", value) { }
        public ExplanationOfBenefitAccidentLocationChoice(IPrimitiveType? value) : base("explanationofbenefitaccidentlocation", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ExplanationOfBenefitAccidentLocation" : "explanationofbenefitaccidentlocation";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ExplanationOfBenefitItemServicedChoice 選擇類型
    /// </summary>
    public class ExplanationOfBenefitItemServicedChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ExplanationOfBenefitItemServicedChoice(JsonObject value) : base("explanationofbenefititemserviced", value, _supportType) { }
        public ExplanationOfBenefitItemServicedChoice(IComplexType? value) : base("explanationofbenefititemserviced", value) { }
        public ExplanationOfBenefitItemServicedChoice(IPrimitiveType? value) : base("explanationofbenefititemserviced", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ExplanationOfBenefitItemServiced" : "explanationofbenefititemserviced";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ExplanationOfBenefitItemLocationChoice 選擇類型
    /// </summary>
    public class ExplanationOfBenefitItemLocationChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ExplanationOfBenefitItemLocationChoice(JsonObject value) : base("explanationofbenefititemlocation", value, _supportType) { }
        public ExplanationOfBenefitItemLocationChoice(IComplexType? value) : base("explanationofbenefititemlocation", value) { }
        public ExplanationOfBenefitItemLocationChoice(IPrimitiveType? value) : base("explanationofbenefititemlocation", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ExplanationOfBenefitItemLocation" : "explanationofbenefititemlocation";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ExplanationOfBenefitAddItemServicedChoice 選擇類型
    /// </summary>
    public class ExplanationOfBenefitAddItemServicedChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ExplanationOfBenefitAddItemServicedChoice(JsonObject value) : base("explanationofbenefitadditemserviced", value, _supportType) { }
        public ExplanationOfBenefitAddItemServicedChoice(IComplexType? value) : base("explanationofbenefitadditemserviced", value) { }
        public ExplanationOfBenefitAddItemServicedChoice(IPrimitiveType? value) : base("explanationofbenefitadditemserviced", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ExplanationOfBenefitAddItemServiced" : "explanationofbenefitadditemserviced";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ExplanationOfBenefitAddItemLocationChoice 選擇類型
    /// </summary>
    public class ExplanationOfBenefitAddItemLocationChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ExplanationOfBenefitAddItemLocationChoice(JsonObject value) : base("explanationofbenefitadditemlocation", value, _supportType) { }
        public ExplanationOfBenefitAddItemLocationChoice(IComplexType? value) : base("explanationofbenefitadditemlocation", value) { }
        public ExplanationOfBenefitAddItemLocationChoice(IPrimitiveType? value) : base("explanationofbenefitadditemlocation", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ExplanationOfBenefitAddItemLocation" : "explanationofbenefitadditemlocation";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ExplanationOfBenefitBenefitBalanceFinancialAllowedChoice 選擇類型
    /// </summary>
    public class ExplanationOfBenefitBenefitBalanceFinancialAllowedChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ExplanationOfBenefitBenefitBalanceFinancialAllowedChoice(JsonObject value) : base("explanationofbenefitbenefitbalancefinancialallowed", value, _supportType) { }
        public ExplanationOfBenefitBenefitBalanceFinancialAllowedChoice(IComplexType? value) : base("explanationofbenefitbenefitbalancefinancialallowed", value) { }
        public ExplanationOfBenefitBenefitBalanceFinancialAllowedChoice(IPrimitiveType? value) : base("explanationofbenefitbenefitbalancefinancialallowed", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ExplanationOfBenefitBenefitBalanceFinancialAllowed" : "explanationofbenefitbenefitbalancefinancialallowed";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ExplanationOfBenefitBenefitBalanceFinancialUsedChoice 選擇類型
    /// </summary>
    public class ExplanationOfBenefitBenefitBalanceFinancialUsedChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ExplanationOfBenefitBenefitBalanceFinancialUsedChoice(JsonObject value) : base("explanationofbenefitbenefitbalancefinancialused", value, _supportType) { }
        public ExplanationOfBenefitBenefitBalanceFinancialUsedChoice(IComplexType? value) : base("explanationofbenefitbenefitbalancefinancialused", value) { }
        public ExplanationOfBenefitBenefitBalanceFinancialUsedChoice(IPrimitiveType? value) : base("explanationofbenefitbenefitbalancefinancialused", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ExplanationOfBenefitBenefitBalanceFinancialUsed" : "explanationofbenefitbenefitbalancefinancialused";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
