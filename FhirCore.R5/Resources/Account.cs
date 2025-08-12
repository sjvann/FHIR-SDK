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
    /// FHIR R5 Account 資源
    /// 
    /// <para>
    /// Account 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var account = new Account("account-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Account 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Account : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private CodeableConcept? _billingstatus;
        private CodeableConcept? _type;
        private FhirString? _name;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _subject;
        private Period? _serviceperiod;
        private List<AccountCoverage>? _coverage;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _owner;
        private FhirMarkdown? _description;
        private List<AccountGuarantor>? _guarantor;
        private List<AccountDiagnosis>? _diagnosis;
        private List<AccountProcedure>? _procedure;
        private List<AccountRelatedAccount>? _relatedaccount;
        private CodeableConcept? _currency;
        private List<AccountBalance>? _balance;
        private FhirInstant? _calculatedat;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _coverage;
        private FhirPositiveInt? _priority;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _party;
        private FhirBoolean? _onhold;
        private Period? _period;
        private FhirPositiveInt? _sequence;
        private CodeableReference? _condition;
        private FhirDateTime? _dateofdiagnosis;
        private List<CodeableConcept>? _type;
        private FhirBoolean? _onadmission;
        private List<CodeableConcept>? _packagecode;
        private FhirPositiveInt? _sequence;
        private CodeableReference? _code;
        private FhirDateTime? _dateofservice;
        private List<CodeableConcept>? _type;
        private List<CodeableConcept>? _packagecode;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _device;
        private CodeableConcept? _relationship;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _account;
        private CodeableConcept? _aggregate;
        private CodeableConcept? _term;
        private FhirBoolean? _estimate;
        private Money? _amount;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Account";        /// <summary>
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
        /// Billingstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Billingstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Billingstatus
        {
            get => _billingstatus;
            set
            {
                _billingstatus = value;
                OnPropertyChanged(nameof(Billingstatus));
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
        /// Subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }        /// <summary>
        /// Serviceperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Serviceperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Serviceperiod
        {
            get => _serviceperiod;
            set
            {
                _serviceperiod = value;
                OnPropertyChanged(nameof(Serviceperiod));
            }
        }        /// <summary>
        /// Coverage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Coverage 的詳細描述。
        /// </para>
        /// </remarks>
        public List<AccountCoverage>? Coverage
        {
            get => _coverage;
            set
            {
                _coverage = value;
                OnPropertyChanged(nameof(Coverage));
            }
        }        /// <summary>
        /// Owner
        /// </summary>
        /// <remarks>
        /// <para>
        /// Owner 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Owner
        {
            get => _owner;
            set
            {
                _owner = value;
                OnPropertyChanged(nameof(Owner));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Guarantor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Guarantor 的詳細描述。
        /// </para>
        /// </remarks>
        public List<AccountGuarantor>? Guarantor
        {
            get => _guarantor;
            set
            {
                _guarantor = value;
                OnPropertyChanged(nameof(Guarantor));
            }
        }        /// <summary>
        /// Diagnosis
        /// </summary>
        /// <remarks>
        /// <para>
        /// Diagnosis 的詳細描述。
        /// </para>
        /// </remarks>
        public List<AccountDiagnosis>? Diagnosis
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
        public List<AccountProcedure>? Procedure
        {
            get => _procedure;
            set
            {
                _procedure = value;
                OnPropertyChanged(nameof(Procedure));
            }
        }        /// <summary>
        /// Relatedaccount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relatedaccount 的詳細描述。
        /// </para>
        /// </remarks>
        public List<AccountRelatedAccount>? Relatedaccount
        {
            get => _relatedaccount;
            set
            {
                _relatedaccount = value;
                OnPropertyChanged(nameof(Relatedaccount));
            }
        }        /// <summary>
        /// Currency
        /// </summary>
        /// <remarks>
        /// <para>
        /// Currency 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Currency
        {
            get => _currency;
            set
            {
                _currency = value;
                OnPropertyChanged(nameof(Currency));
            }
        }        /// <summary>
        /// Balance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Balance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<AccountBalance>? Balance
        {
            get => _balance;
            set
            {
                _balance = value;
                OnPropertyChanged(nameof(Balance));
            }
        }        /// <summary>
        /// Calculatedat
        /// </summary>
        /// <remarks>
        /// <para>
        /// Calculatedat 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInstant? Calculatedat
        {
            get => _calculatedat;
            set
            {
                _calculatedat = value;
                OnPropertyChanged(nameof(Calculatedat));
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
        /// Priority
        /// </summary>
        /// <remarks>
        /// <para>
        /// Priority 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(Priority));
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
        /// Onhold
        /// </summary>
        /// <remarks>
        /// <para>
        /// Onhold 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Onhold
        {
            get => _onhold;
            set
            {
                _onhold = value;
                OnPropertyChanged(nameof(Onhold));
            }
        }        /// <summary>
        /// Period
        /// </summary>
        /// <remarks>
        /// <para>
        /// Period 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Period
        {
            get => _period;
            set
            {
                _period = value;
                OnPropertyChanged(nameof(Period));
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
        /// Condition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Condition 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Condition
        {
            get => _condition;
            set
            {
                _condition = value;
                OnPropertyChanged(nameof(Condition));
            }
        }        /// <summary>
        /// Dateofdiagnosis
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dateofdiagnosis 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Dateofdiagnosis
        {
            get => _dateofdiagnosis;
            set
            {
                _dateofdiagnosis = value;
                OnPropertyChanged(nameof(Dateofdiagnosis));
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
        public FhirBoolean? Onadmission
        {
            get => _onadmission;
            set
            {
                _onadmission = value;
                OnPropertyChanged(nameof(Onadmission));
            }
        }        /// <summary>
        /// Packagecode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Packagecode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Packagecode
        {
            get => _packagecode;
            set
            {
                _packagecode = value;
                OnPropertyChanged(nameof(Packagecode));
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
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Dateofservice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dateofservice 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Dateofservice
        {
            get => _dateofservice;
            set
            {
                _dateofservice = value;
                OnPropertyChanged(nameof(Dateofservice));
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
        /// Packagecode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Packagecode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Packagecode
        {
            get => _packagecode;
            set
            {
                _packagecode = value;
                OnPropertyChanged(nameof(Packagecode));
            }
        }        /// <summary>
        /// Device
        /// </summary>
        /// <remarks>
        /// <para>
        /// Device 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Device
        {
            get => _device;
            set
            {
                _device = value;
                OnPropertyChanged(nameof(Device));
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
        /// Account
        /// </summary>
        /// <remarks>
        /// <para>
        /// Account 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Account
        {
            get => _account;
            set
            {
                _account = value;
                OnPropertyChanged(nameof(Account));
            }
        }        /// <summary>
        /// Aggregate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Aggregate 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Aggregate
        {
            get => _aggregate;
            set
            {
                _aggregate = value;
                OnPropertyChanged(nameof(Aggregate));
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
        /// Estimate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Estimate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Estimate
        {
            get => _estimate;
            set
            {
                _estimate = value;
                OnPropertyChanged(nameof(Estimate));
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
        /// 建立新的 Account 資源實例
        /// </summary>
        public Account()
        {
        }

        /// <summary>
        /// 建立新的 Account 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Account(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Account(Id: {Id})";
        }
    }    /// <summary>
    /// AccountCoverage 背骨元素
    /// </summary>
    public class AccountCoverage
    {
        // TODO: 添加屬性實作
        
        public AccountCoverage() { }
    }    /// <summary>
    /// AccountGuarantor 背骨元素
    /// </summary>
    public class AccountGuarantor
    {
        // TODO: 添加屬性實作
        
        public AccountGuarantor() { }
    }    /// <summary>
    /// AccountDiagnosis 背骨元素
    /// </summary>
    public class AccountDiagnosis
    {
        // TODO: 添加屬性實作
        
        public AccountDiagnosis() { }
    }    /// <summary>
    /// AccountProcedure 背骨元素
    /// </summary>
    public class AccountProcedure
    {
        // TODO: 添加屬性實作
        
        public AccountProcedure() { }
    }    /// <summary>
    /// AccountRelatedAccount 背骨元素
    /// </summary>
    public class AccountRelatedAccount
    {
        // TODO: 添加屬性實作
        
        public AccountRelatedAccount() { }
    }    /// <summary>
    /// AccountBalance 背骨元素
    /// </summary>
    public class AccountBalance
    {
        // TODO: 添加屬性實作
        
        public AccountBalance() { }
    }
}
