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
    /// FHIR R5 Consent 資源
    /// 
    /// <para>
    /// Consent 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var consent = new Consent("consent-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Consent 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Consent : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private List<CodeableConcept>? _category;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private FhirDate? _date;
        private Period? _period;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _grantor;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _grantee;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _manager;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _controller;
        private List<Attachment>? _sourceattachment;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _sourcereference;
        private List<CodeableConcept>? _regulatorybasis;
        private ConsentPolicyBasis? _policybasis;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _policytext;
        private List<ConsentVerification>? _verification;
        private FhirCode? _decision;
        private List<ConsentProvision>? _provision;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _reference;
        private FhirUrl? _url;
        private FhirBoolean? _verified;
        private CodeableConcept? _verificationtype;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _verifiedby;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _verifiedwith;
        private List<FhirDateTime>? _verificationdate;
        private CodeableConcept? _role;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _reference;
        private FhirCode? _meaning;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _reference;
        private Period? _period;
        private List<ConsentProvisionActor>? _actor;
        private List<CodeableConcept>? _action;
        private List<Coding>? _securitylabel;
        private List<Coding>? _purpose;
        private List<Coding>? _documenttype;
        private List<Coding>? _resourcetype;
        private List<CodeableConcept>? _code;
        private Period? _dataperiod;
        private List<ConsentProvisionData>? _data;
        private ExpressionType? _expression;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Consent";        /// <summary>
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
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
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
        /// Grantor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Grantor 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Grantor
        {
            get => _grantor;
            set
            {
                _grantor = value;
                OnPropertyChanged(nameof(Grantor));
            }
        }        /// <summary>
        /// Grantee
        /// </summary>
        /// <remarks>
        /// <para>
        /// Grantee 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Grantee
        {
            get => _grantee;
            set
            {
                _grantee = value;
                OnPropertyChanged(nameof(Grantee));
            }
        }        /// <summary>
        /// Manager
        /// </summary>
        /// <remarks>
        /// <para>
        /// Manager 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Manager
        {
            get => _manager;
            set
            {
                _manager = value;
                OnPropertyChanged(nameof(Manager));
            }
        }        /// <summary>
        /// Controller
        /// </summary>
        /// <remarks>
        /// <para>
        /// Controller 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Controller
        {
            get => _controller;
            set
            {
                _controller = value;
                OnPropertyChanged(nameof(Controller));
            }
        }        /// <summary>
        /// Sourceattachment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sourceattachment 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Attachment>? Sourceattachment
        {
            get => _sourceattachment;
            set
            {
                _sourceattachment = value;
                OnPropertyChanged(nameof(Sourceattachment));
            }
        }        /// <summary>
        /// Sourcereference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sourcereference 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Sourcereference
        {
            get => _sourcereference;
            set
            {
                _sourcereference = value;
                OnPropertyChanged(nameof(Sourcereference));
            }
        }        /// <summary>
        /// Regulatorybasis
        /// </summary>
        /// <remarks>
        /// <para>
        /// Regulatorybasis 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Regulatorybasis
        {
            get => _regulatorybasis;
            set
            {
                _regulatorybasis = value;
                OnPropertyChanged(nameof(Regulatorybasis));
            }
        }        /// <summary>
        /// Policybasis
        /// </summary>
        /// <remarks>
        /// <para>
        /// Policybasis 的詳細描述。
        /// </para>
        /// </remarks>
        public ConsentPolicyBasis? Policybasis
        {
            get => _policybasis;
            set
            {
                _policybasis = value;
                OnPropertyChanged(nameof(Policybasis));
            }
        }        /// <summary>
        /// Policytext
        /// </summary>
        /// <remarks>
        /// <para>
        /// Policytext 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Policytext
        {
            get => _policytext;
            set
            {
                _policytext = value;
                OnPropertyChanged(nameof(Policytext));
            }
        }        /// <summary>
        /// Verification
        /// </summary>
        /// <remarks>
        /// <para>
        /// Verification 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ConsentVerification>? Verification
        {
            get => _verification;
            set
            {
                _verification = value;
                OnPropertyChanged(nameof(Verification));
            }
        }        /// <summary>
        /// Decision
        /// </summary>
        /// <remarks>
        /// <para>
        /// Decision 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Decision
        {
            get => _decision;
            set
            {
                _decision = value;
                OnPropertyChanged(nameof(Decision));
            }
        }        /// <summary>
        /// Provision
        /// </summary>
        /// <remarks>
        /// <para>
        /// Provision 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ConsentProvision>? Provision
        {
            get => _provision;
            set
            {
                _provision = value;
                OnPropertyChanged(nameof(Provision));
            }
        }        /// <summary>
        /// Reference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reference 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Reference
        {
            get => _reference;
            set
            {
                _reference = value;
                OnPropertyChanged(nameof(Reference));
            }
        }        /// <summary>
        /// Url
        /// </summary>
        /// <remarks>
        /// <para>
        /// Url 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUrl? Url
        {
            get => _url;
            set
            {
                _url = value;
                OnPropertyChanged(nameof(Url));
            }
        }        /// <summary>
        /// Verified
        /// </summary>
        /// <remarks>
        /// <para>
        /// Verified 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Verified
        {
            get => _verified;
            set
            {
                _verified = value;
                OnPropertyChanged(nameof(Verified));
            }
        }        /// <summary>
        /// Verificationtype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Verificationtype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Verificationtype
        {
            get => _verificationtype;
            set
            {
                _verificationtype = value;
                OnPropertyChanged(nameof(Verificationtype));
            }
        }        /// <summary>
        /// Verifiedby
        /// </summary>
        /// <remarks>
        /// <para>
        /// Verifiedby 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Verifiedby
        {
            get => _verifiedby;
            set
            {
                _verifiedby = value;
                OnPropertyChanged(nameof(Verifiedby));
            }
        }        /// <summary>
        /// Verifiedwith
        /// </summary>
        /// <remarks>
        /// <para>
        /// Verifiedwith 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Verifiedwith
        {
            get => _verifiedwith;
            set
            {
                _verifiedwith = value;
                OnPropertyChanged(nameof(Verifiedwith));
            }
        }        /// <summary>
        /// Verificationdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Verificationdate 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirDateTime>? Verificationdate
        {
            get => _verificationdate;
            set
            {
                _verificationdate = value;
                OnPropertyChanged(nameof(Verificationdate));
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
        /// Reference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reference 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Reference
        {
            get => _reference;
            set
            {
                _reference = value;
                OnPropertyChanged(nameof(Reference));
            }
        }        /// <summary>
        /// Meaning
        /// </summary>
        /// <remarks>
        /// <para>
        /// Meaning 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Meaning
        {
            get => _meaning;
            set
            {
                _meaning = value;
                OnPropertyChanged(nameof(Meaning));
            }
        }        /// <summary>
        /// Reference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reference 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Reference
        {
            get => _reference;
            set
            {
                _reference = value;
                OnPropertyChanged(nameof(Reference));
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
        /// Actor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Actor 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ConsentProvisionActor>? Actor
        {
            get => _actor;
            set
            {
                _actor = value;
                OnPropertyChanged(nameof(Actor));
            }
        }        /// <summary>
        /// Action
        /// </summary>
        /// <remarks>
        /// <para>
        /// Action 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Action
        {
            get => _action;
            set
            {
                _action = value;
                OnPropertyChanged(nameof(Action));
            }
        }        /// <summary>
        /// Securitylabel
        /// </summary>
        /// <remarks>
        /// <para>
        /// Securitylabel 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Coding>? Securitylabel
        {
            get => _securitylabel;
            set
            {
                _securitylabel = value;
                OnPropertyChanged(nameof(Securitylabel));
            }
        }        /// <summary>
        /// Purpose
        /// </summary>
        /// <remarks>
        /// <para>
        /// Purpose 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Coding>? Purpose
        {
            get => _purpose;
            set
            {
                _purpose = value;
                OnPropertyChanged(nameof(Purpose));
            }
        }        /// <summary>
        /// Documenttype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Documenttype 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Coding>? Documenttype
        {
            get => _documenttype;
            set
            {
                _documenttype = value;
                OnPropertyChanged(nameof(Documenttype));
            }
        }        /// <summary>
        /// Resourcetype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resourcetype 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Coding>? Resourcetype
        {
            get => _resourcetype;
            set
            {
                _resourcetype = value;
                OnPropertyChanged(nameof(Resourcetype));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Dataperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dataperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Dataperiod
        {
            get => _dataperiod;
            set
            {
                _dataperiod = value;
                OnPropertyChanged(nameof(Dataperiod));
            }
        }        /// <summary>
        /// Data
        /// </summary>
        /// <remarks>
        /// <para>
        /// Data 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ConsentProvisionData>? Data
        {
            get => _data;
            set
            {
                _data = value;
                OnPropertyChanged(nameof(Data));
            }
        }        /// <summary>
        /// Expression
        /// </summary>
        /// <remarks>
        /// <para>
        /// Expression 的詳細描述。
        /// </para>
        /// </remarks>
        public ExpressionType? Expression
        {
            get => _expression;
            set
            {
                _expression = value;
                OnPropertyChanged(nameof(Expression));
            }
        }        /// <summary>
        /// 建立新的 Consent 資源實例
        /// </summary>
        public Consent()
        {
        }

        /// <summary>
        /// 建立新的 Consent 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Consent(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Consent(Id: {Id})";
        }
    }    /// <summary>
    /// ConsentPolicyBasis 背骨元素
    /// </summary>
    public class ConsentPolicyBasis
    {
        // TODO: 添加屬性實作
        
        public ConsentPolicyBasis() { }
    }    /// <summary>
    /// ConsentVerification 背骨元素
    /// </summary>
    public class ConsentVerification
    {
        // TODO: 添加屬性實作
        
        public ConsentVerification() { }
    }    /// <summary>
    /// ConsentProvisionActor 背骨元素
    /// </summary>
    public class ConsentProvisionActor
    {
        // TODO: 添加屬性實作
        
        public ConsentProvisionActor() { }
    }    /// <summary>
    /// ConsentProvisionData 背骨元素
    /// </summary>
    public class ConsentProvisionData
    {
        // TODO: 添加屬性實作
        
        public ConsentProvisionData() { }
    }    /// <summary>
    /// ConsentProvision 背骨元素
    /// </summary>
    public class ConsentProvision
    {
        // TODO: 添加屬性實作
        
        public ConsentProvision() { }
    }
}
