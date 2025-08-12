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
    /// FHIR R5 Claim 資源
    /// 
    /// <para>
    /// Claim 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
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
    /// R5 版本的 Claim 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Claim : ResourceBase<R5Version>
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
        private CodeableConcept? _fundsreserve;
        private List<ClaimRelated>? _related;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _prescription;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _originalprescription;
        private ClaimPayee? _payee;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _referral;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _encounter;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _facility;
        private CodeableConcept? _diagnosisrelatedgroup;
        private List<ClaimEvent>? _event;
        private List<ClaimCareTeam>? _careteam;
        private List<ClaimSupportingInfo>? _supportinginfo;
        private List<ClaimDiagnosis>? _diagnosis;
        private List<ClaimProcedure>? _procedure;
        private List<ClaimInsurance>? _insurance;
        private ClaimAccident? _accident;
        private Money? _patientpaid;
        private List<ClaimItem>? _item;
        private Money? _total;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _claim;
        private CodeableConcept? _relationship;
        private Identifier? _reference;
        private CodeableConcept? _type;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _party;
        private CodeableConcept? _type;
        private ClaimEventWhenChoice? _when;
        private FhirPositiveInt? _sequence;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _provider;
        private FhirBoolean? _responsible;
        private CodeableConcept? _role;
        private CodeableConcept? _specialty;
        private FhirPositiveInt? _sequence;
        private CodeableConcept? _category;
        private CodeableConcept? _code;
        private ClaimSupportingInfoTimingChoice? _timing;
        private ClaimSupportingInfoValueChoice? _value;
        private CodeableConcept? _reason;
        private FhirPositiveInt? _sequence;
        private ClaimDiagnosisDiagnosisChoice? _diagnosis;
        private List<CodeableConcept>? _type;
        private CodeableConcept? _onadmission;
        private FhirPositiveInt? _sequence;
        private List<CodeableConcept>? _type;
        private FhirDateTime? _date;
        private ClaimProcedureProcedureChoice? _procedure;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _udi;
        private FhirPositiveInt? _sequence;
        private FhirBoolean? _focal;
        private Identifier? _identifier;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _coverage;
        private FhirString? _businessarrangement;
        private List<FhirString>? _preauthref;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _claimresponse;
        private FhirDate? _date;
        private CodeableConcept? _type;
        private ClaimAccidentLocationChoice? _location;
        private List<CodeableReference>? _site;
        private List<CodeableConcept>? _subsite;
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
        private List<ClaimItemDetailSubDetail>? _subdetail;
        private FhirPositiveInt? _sequence;
        private List<Identifier>? _tracenumber;
        private List<FhirPositiveInt>? _careteamsequence;
        private List<FhirPositiveInt>? _diagnosissequence;
        private List<FhirPositiveInt>? _proceduresequence;
        private List<FhirPositiveInt>? _informationsequence;
        private CodeableConcept? _revenue;
        private CodeableConcept? _category;
        private CodeableConcept? _productorservice;
        private CodeableConcept? _productorserviceend;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _request;
        private List<CodeableConcept>? _modifier;
        private List<CodeableConcept>? _programcode;
        private ClaimItemServicedChoice? _serviced;
        private ClaimItemLocationChoice? _location;
        private Money? _patientpaid;
        private Quantity? _quantity;
        private Money? _unitprice;
        private FhirDecimal? _factor;
        private Money? _tax;
        private Money? _net;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _udi;
        private List<ClaimItemBodySite>? _bodysite;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _encounter;
        private List<ClaimItemDetail>? _detail;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Claim";        /// <summary>
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
        public List<ClaimRelated>? Related
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
        /// Payee
        /// </summary>
        /// <remarks>
        /// <para>
        /// Payee 的詳細描述。
        /// </para>
        /// </remarks>
        public ClaimPayee? Payee
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
        /// Event
        /// </summary>
        /// <remarks>
        /// <para>
        /// Event 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ClaimEvent>? Event
        {
            get => _event;
            set
            {
                _event = value;
                OnPropertyChanged(nameof(Event));
            }
        }        /// <summary>
        /// Careteam
        /// </summary>
        /// <remarks>
        /// <para>
        /// Careteam 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ClaimCareTeam>? Careteam
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
        public List<ClaimSupportingInfo>? Supportinginfo
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
        public List<ClaimDiagnosis>? Diagnosis
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
        public List<ClaimProcedure>? Procedure
        {
            get => _procedure;
            set
            {
                _procedure = value;
                OnPropertyChanged(nameof(Procedure));
            }
        }        /// <summary>
        /// Insurance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Insurance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ClaimInsurance>? Insurance
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
        public ClaimAccident? Accident
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
        public List<ClaimItem>? Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged(nameof(Item));
            }
        }        /// <summary>
        /// Total
        /// </summary>
        /// <remarks>
        /// <para>
        /// Total 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Total
        {
            get => _total;
            set
            {
                _total = value;
                OnPropertyChanged(nameof(Total));
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
        public ClaimEventWhenChoice? When
        {
            get => _when;
            set
            {
                _when = value;
                OnPropertyChanged(nameof(When));
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
        public ClaimSupportingInfoTimingChoice? Timing
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
        public ClaimSupportingInfoValueChoice? Value
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
        public CodeableConcept? Reason
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
        public ClaimDiagnosisDiagnosisChoice? Diagnosis
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
        public ClaimProcedureProcedureChoice? Procedure
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
        /// Businessarrangement
        /// </summary>
        /// <remarks>
        /// <para>
        /// Businessarrangement 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Businessarrangement
        {
            get => _businessarrangement;
            set
            {
                _businessarrangement = value;
                OnPropertyChanged(nameof(Businessarrangement));
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
        public ClaimAccidentLocationChoice? Location
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
        /// Subdetail
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subdetail 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ClaimItemDetailSubDetail>? Subdetail
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
        public ClaimItemServicedChoice? Serviced
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
        public ClaimItemLocationChoice? Location
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
        public List<ClaimItemBodySite>? Bodysite
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
        /// Detail
        /// </summary>
        /// <remarks>
        /// <para>
        /// Detail 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ClaimItemDetail>? Detail
        {
            get => _detail;
            set
            {
                _detail = value;
                OnPropertyChanged(nameof(Detail));
            }
        }        /// <summary>
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
    }    /// <summary>
    /// ClaimRelated 背骨元素
    /// </summary>
    public class ClaimRelated
    {
        // TODO: 添加屬性實作
        
        public ClaimRelated() { }
    }    /// <summary>
    /// ClaimPayee 背骨元素
    /// </summary>
    public class ClaimPayee
    {
        // TODO: 添加屬性實作
        
        public ClaimPayee() { }
    }    /// <summary>
    /// ClaimEvent 背骨元素
    /// </summary>
    public class ClaimEvent
    {
        // TODO: 添加屬性實作
        
        public ClaimEvent() { }
    }    /// <summary>
    /// ClaimCareTeam 背骨元素
    /// </summary>
    public class ClaimCareTeam
    {
        // TODO: 添加屬性實作
        
        public ClaimCareTeam() { }
    }    /// <summary>
    /// ClaimSupportingInfo 背骨元素
    /// </summary>
    public class ClaimSupportingInfo
    {
        // TODO: 添加屬性實作
        
        public ClaimSupportingInfo() { }
    }    /// <summary>
    /// ClaimDiagnosis 背骨元素
    /// </summary>
    public class ClaimDiagnosis
    {
        // TODO: 添加屬性實作
        
        public ClaimDiagnosis() { }
    }    /// <summary>
    /// ClaimProcedure 背骨元素
    /// </summary>
    public class ClaimProcedure
    {
        // TODO: 添加屬性實作
        
        public ClaimProcedure() { }
    }    /// <summary>
    /// ClaimInsurance 背骨元素
    /// </summary>
    public class ClaimInsurance
    {
        // TODO: 添加屬性實作
        
        public ClaimInsurance() { }
    }    /// <summary>
    /// ClaimAccident 背骨元素
    /// </summary>
    public class ClaimAccident
    {
        // TODO: 添加屬性實作
        
        public ClaimAccident() { }
    }    /// <summary>
    /// ClaimItemBodySite 背骨元素
    /// </summary>
    public class ClaimItemBodySite
    {
        // TODO: 添加屬性實作
        
        public ClaimItemBodySite() { }
    }    /// <summary>
    /// ClaimItemDetailSubDetail 背骨元素
    /// </summary>
    public class ClaimItemDetailSubDetail
    {
        // TODO: 添加屬性實作
        
        public ClaimItemDetailSubDetail() { }
    }    /// <summary>
    /// ClaimItemDetail 背骨元素
    /// </summary>
    public class ClaimItemDetail
    {
        // TODO: 添加屬性實作
        
        public ClaimItemDetail() { }
    }    /// <summary>
    /// ClaimItem 背骨元素
    /// </summary>
    public class ClaimItem
    {
        // TODO: 添加屬性實作
        
        public ClaimItem() { }
    }    /// <summary>
    /// ClaimEventWhenChoice 選擇類型
    /// </summary>
    public class ClaimEventWhenChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ClaimEventWhenChoice(JsonObject value) : base("claimeventwhen", value, _supportType) { }
        public ClaimEventWhenChoice(IComplexType? value) : base("claimeventwhen", value) { }
        public ClaimEventWhenChoice(IPrimitiveType? value) : base("claimeventwhen", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ClaimEventWhen" : "claimeventwhen";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ClaimSupportingInfoTimingChoice 選擇類型
    /// </summary>
    public class ClaimSupportingInfoTimingChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ClaimSupportingInfoTimingChoice(JsonObject value) : base("claimsupportinginfotiming", value, _supportType) { }
        public ClaimSupportingInfoTimingChoice(IComplexType? value) : base("claimsupportinginfotiming", value) { }
        public ClaimSupportingInfoTimingChoice(IPrimitiveType? value) : base("claimsupportinginfotiming", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ClaimSupportingInfoTiming" : "claimsupportinginfotiming";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ClaimSupportingInfoValueChoice 選擇類型
    /// </summary>
    public class ClaimSupportingInfoValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ClaimSupportingInfoValueChoice(JsonObject value) : base("claimsupportinginfovalue", value, _supportType) { }
        public ClaimSupportingInfoValueChoice(IComplexType? value) : base("claimsupportinginfovalue", value) { }
        public ClaimSupportingInfoValueChoice(IPrimitiveType? value) : base("claimsupportinginfovalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ClaimSupportingInfoValue" : "claimsupportinginfovalue";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ClaimDiagnosisDiagnosisChoice 選擇類型
    /// </summary>
    public class ClaimDiagnosisDiagnosisChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ClaimDiagnosisDiagnosisChoice(JsonObject value) : base("claimdiagnosisdiagnosis", value, _supportType) { }
        public ClaimDiagnosisDiagnosisChoice(IComplexType? value) : base("claimdiagnosisdiagnosis", value) { }
        public ClaimDiagnosisDiagnosisChoice(IPrimitiveType? value) : base("claimdiagnosisdiagnosis", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ClaimDiagnosisDiagnosis" : "claimdiagnosisdiagnosis";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ClaimProcedureProcedureChoice 選擇類型
    /// </summary>
    public class ClaimProcedureProcedureChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ClaimProcedureProcedureChoice(JsonObject value) : base("claimprocedureprocedure", value, _supportType) { }
        public ClaimProcedureProcedureChoice(IComplexType? value) : base("claimprocedureprocedure", value) { }
        public ClaimProcedureProcedureChoice(IPrimitiveType? value) : base("claimprocedureprocedure", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ClaimProcedureProcedure" : "claimprocedureprocedure";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ClaimAccidentLocationChoice 選擇類型
    /// </summary>
    public class ClaimAccidentLocationChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ClaimAccidentLocationChoice(JsonObject value) : base("claimaccidentlocation", value, _supportType) { }
        public ClaimAccidentLocationChoice(IComplexType? value) : base("claimaccidentlocation", value) { }
        public ClaimAccidentLocationChoice(IPrimitiveType? value) : base("claimaccidentlocation", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ClaimAccidentLocation" : "claimaccidentlocation";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ClaimItemServicedChoice 選擇類型
    /// </summary>
    public class ClaimItemServicedChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ClaimItemServicedChoice(JsonObject value) : base("claimitemserviced", value, _supportType) { }
        public ClaimItemServicedChoice(IComplexType? value) : base("claimitemserviced", value) { }
        public ClaimItemServicedChoice(IPrimitiveType? value) : base("claimitemserviced", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ClaimItemServiced" : "claimitemserviced";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ClaimItemLocationChoice 選擇類型
    /// </summary>
    public class ClaimItemLocationChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ClaimItemLocationChoice(JsonObject value) : base("claimitemlocation", value, _supportType) { }
        public ClaimItemLocationChoice(IComplexType? value) : base("claimitemlocation", value) { }
        public ClaimItemLocationChoice(IPrimitiveType? value) : base("claimitemlocation", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ClaimItemLocation" : "claimitemlocation";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
