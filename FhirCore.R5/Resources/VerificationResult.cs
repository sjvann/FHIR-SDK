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
    /// FHIR R5 VerificationResult 資源
    /// 
    /// <para>
    /// VerificationResult 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var verificationresult = new VerificationResult("verificationresult-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 VerificationResult 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class VerificationResult : ResourceBase<R5Version>
    {
        private Property
		private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _target;
        private List<FhirString>? _targetlocation;
        private CodeableConcept? _need;
        private FhirCode? _status;
        private FhirDateTime? _statusdate;
        private CodeableConcept? _validationtype;
        private List<CodeableConcept>? _validationprocess;
        private Timing? _frequency;
        private FhirDateTime? _lastperformed;
        private FhirDate? _nextscheduled;
        private CodeableConcept? _failureaction;
        private List<VerificationResultPrimarySource>? _primarysource;
        private VerificationResultAttestation? _attestation;
        private List<VerificationResultValidator>? _validator;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _who;
        private List<CodeableConcept>? _type;
        private List<CodeableConcept>? _communicationmethod;
        private CodeableConcept? _validationstatus;
        private FhirDateTime? _validationdate;
        private CodeableConcept? _canpushupdates;
        private List<CodeableConcept>? _pushtypeavailable;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _who;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _onbehalfof;
        private CodeableConcept? _communicationmethod;
        private FhirDate? _date;
        private FhirString? _sourceidentitycertificate;
        private FhirString? _proxyidentitycertificate;
        private Signature? _proxysignature;
        private Signature? _sourcesignature;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _organization;
        private FhirString? _identitycertificate;
        private Signature? _attestationsignature;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "VerificationResult";        /// <summary>
        /// Target
        /// </summary>
        /// <remarks>
        /// <para>
        /// Target 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Target
        {
            get => _target;
            set
            {
                _target = value;
                OnPropertyChanged(nameof(Target));
            }
        }        /// <summary>
        /// Targetlocation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Targetlocation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Targetlocation
        {
            get => _targetlocation;
            set
            {
                _targetlocation = value;
                OnPropertyChanged(nameof(Targetlocation));
            }
        }        /// <summary>
        /// Need
        /// </summary>
        /// <remarks>
        /// <para>
        /// Need 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Need
        {
            get => _need;
            set
            {
                _need = value;
                OnPropertyChanged(nameof(Need));
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
        /// Statusdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Statusdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Statusdate
        {
            get => _statusdate;
            set
            {
                _statusdate = value;
                OnPropertyChanged(nameof(Statusdate));
            }
        }        /// <summary>
        /// Validationtype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Validationtype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Validationtype
        {
            get => _validationtype;
            set
            {
                _validationtype = value;
                OnPropertyChanged(nameof(Validationtype));
            }
        }        /// <summary>
        /// Validationprocess
        /// </summary>
        /// <remarks>
        /// <para>
        /// Validationprocess 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Validationprocess
        {
            get => _validationprocess;
            set
            {
                _validationprocess = value;
                OnPropertyChanged(nameof(Validationprocess));
            }
        }        /// <summary>
        /// Frequency
        /// </summary>
        /// <remarks>
        /// <para>
        /// Frequency 的詳細描述。
        /// </para>
        /// </remarks>
        public Timing? Frequency
        {
            get => _frequency;
            set
            {
                _frequency = value;
                OnPropertyChanged(nameof(Frequency));
            }
        }        /// <summary>
        /// Lastperformed
        /// </summary>
        /// <remarks>
        /// <para>
        /// Lastperformed 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Lastperformed
        {
            get => _lastperformed;
            set
            {
                _lastperformed = value;
                OnPropertyChanged(nameof(Lastperformed));
            }
        }        /// <summary>
        /// Nextscheduled
        /// </summary>
        /// <remarks>
        /// <para>
        /// Nextscheduled 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Nextscheduled
        {
            get => _nextscheduled;
            set
            {
                _nextscheduled = value;
                OnPropertyChanged(nameof(Nextscheduled));
            }
        }        /// <summary>
        /// Failureaction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Failureaction 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Failureaction
        {
            get => _failureaction;
            set
            {
                _failureaction = value;
                OnPropertyChanged(nameof(Failureaction));
            }
        }        /// <summary>
        /// Primarysource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Primarysource 的詳細描述。
        /// </para>
        /// </remarks>
        public List<VerificationResultPrimarySource>? Primarysource
        {
            get => _primarysource;
            set
            {
                _primarysource = value;
                OnPropertyChanged(nameof(Primarysource));
            }
        }        /// <summary>
        /// Attestation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Attestation 的詳細描述。
        /// </para>
        /// </remarks>
        public VerificationResultAttestation? Attestation
        {
            get => _attestation;
            set
            {
                _attestation = value;
                OnPropertyChanged(nameof(Attestation));
            }
        }        /// <summary>
        /// Validator
        /// </summary>
        /// <remarks>
        /// <para>
        /// Validator 的詳細描述。
        /// </para>
        /// </remarks>
        public List<VerificationResultValidator>? Validator
        {
            get => _validator;
            set
            {
                _validator = value;
                OnPropertyChanged(nameof(Validator));
            }
        }        /// <summary>
        /// Who
        /// </summary>
        /// <remarks>
        /// <para>
        /// Who 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Who
        {
            get => _who;
            set
            {
                _who = value;
                OnPropertyChanged(nameof(Who));
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
        /// Communicationmethod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Communicationmethod 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Communicationmethod
        {
            get => _communicationmethod;
            set
            {
                _communicationmethod = value;
                OnPropertyChanged(nameof(Communicationmethod));
            }
        }        /// <summary>
        /// Validationstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Validationstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Validationstatus
        {
            get => _validationstatus;
            set
            {
                _validationstatus = value;
                OnPropertyChanged(nameof(Validationstatus));
            }
        }        /// <summary>
        /// Validationdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Validationdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Validationdate
        {
            get => _validationdate;
            set
            {
                _validationdate = value;
                OnPropertyChanged(nameof(Validationdate));
            }
        }        /// <summary>
        /// Canpushupdates
        /// </summary>
        /// <remarks>
        /// <para>
        /// Canpushupdates 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Canpushupdates
        {
            get => _canpushupdates;
            set
            {
                _canpushupdates = value;
                OnPropertyChanged(nameof(Canpushupdates));
            }
        }        /// <summary>
        /// Pushtypeavailable
        /// </summary>
        /// <remarks>
        /// <para>
        /// Pushtypeavailable 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Pushtypeavailable
        {
            get => _pushtypeavailable;
            set
            {
                _pushtypeavailable = value;
                OnPropertyChanged(nameof(Pushtypeavailable));
            }
        }        /// <summary>
        /// Who
        /// </summary>
        /// <remarks>
        /// <para>
        /// Who 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Who
        {
            get => _who;
            set
            {
                _who = value;
                OnPropertyChanged(nameof(Who));
            }
        }        /// <summary>
        /// Onbehalfof
        /// </summary>
        /// <remarks>
        /// <para>
        /// Onbehalfof 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Onbehalfof
        {
            get => _onbehalfof;
            set
            {
                _onbehalfof = value;
                OnPropertyChanged(nameof(Onbehalfof));
            }
        }        /// <summary>
        /// Communicationmethod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Communicationmethod 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Communicationmethod
        {
            get => _communicationmethod;
            set
            {
                _communicationmethod = value;
                OnPropertyChanged(nameof(Communicationmethod));
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
        /// Sourceidentitycertificate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sourceidentitycertificate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Sourceidentitycertificate
        {
            get => _sourceidentitycertificate;
            set
            {
                _sourceidentitycertificate = value;
                OnPropertyChanged(nameof(Sourceidentitycertificate));
            }
        }        /// <summary>
        /// Proxyidentitycertificate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Proxyidentitycertificate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Proxyidentitycertificate
        {
            get => _proxyidentitycertificate;
            set
            {
                _proxyidentitycertificate = value;
                OnPropertyChanged(nameof(Proxyidentitycertificate));
            }
        }        /// <summary>
        /// Proxysignature
        /// </summary>
        /// <remarks>
        /// <para>
        /// Proxysignature 的詳細描述。
        /// </para>
        /// </remarks>
        public Signature? Proxysignature
        {
            get => _proxysignature;
            set
            {
                _proxysignature = value;
                OnPropertyChanged(nameof(Proxysignature));
            }
        }        /// <summary>
        /// Sourcesignature
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sourcesignature 的詳細描述。
        /// </para>
        /// </remarks>
        public Signature? Sourcesignature
        {
            get => _sourcesignature;
            set
            {
                _sourcesignature = value;
                OnPropertyChanged(nameof(Sourcesignature));
            }
        }        /// <summary>
        /// Organization
        /// </summary>
        /// <remarks>
        /// <para>
        /// Organization 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Organization
        {
            get => _organization;
            set
            {
                _organization = value;
                OnPropertyChanged(nameof(Organization));
            }
        }        /// <summary>
        /// Identitycertificate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identitycertificate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Identitycertificate
        {
            get => _identitycertificate;
            set
            {
                _identitycertificate = value;
                OnPropertyChanged(nameof(Identitycertificate));
            }
        }        /// <summary>
        /// Attestationsignature
        /// </summary>
        /// <remarks>
        /// <para>
        /// Attestationsignature 的詳細描述。
        /// </para>
        /// </remarks>
        public Signature? Attestationsignature
        {
            get => _attestationsignature;
            set
            {
                _attestationsignature = value;
                OnPropertyChanged(nameof(Attestationsignature));
            }
        }        /// <summary>
        /// 建立新的 VerificationResult 資源實例
        /// </summary>
        public VerificationResult()
        {
        }

        /// <summary>
        /// 建立新的 VerificationResult 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public VerificationResult(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"VerificationResult(Id: {Id})";
        }
    }    /// <summary>
    /// VerificationResultPrimarySource 背骨元素
    /// </summary>
    public class VerificationResultPrimarySource
    {
        // TODO: 添加屬性實作
        
        public VerificationResultPrimarySource() { }
    }    /// <summary>
    /// VerificationResultAttestation 背骨元素
    /// </summary>
    public class VerificationResultAttestation
    {
        // TODO: 添加屬性實作
        
        public VerificationResultAttestation() { }
    }    /// <summary>
    /// VerificationResultValidator 背骨元素
    /// </summary>
    public class VerificationResultValidator
    {
        // TODO: 添加屬性實作
        
        public VerificationResultValidator() { }
    }
}
