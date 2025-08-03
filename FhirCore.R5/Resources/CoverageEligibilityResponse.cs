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
    /// FHIR R5 CoverageEligibilityResponse 資源
    /// 
    /// <para>
    /// CoverageEligibilityResponse 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var coverageeligibilityresponse = new CoverageEligibilityResponse("coverageeligibilityresponse-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 CoverageEligibilityResponse 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class CoverageEligibilityResponse : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private List<FhirCode>? _purpose;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _patient;
        private List<CoverageEligibilityResponseEvent>? _event;
        private CoverageEligibilityResponseServicedChoice? _serviced;
        private FhirDateTime? _created;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _requestor;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _request;
        private FhirCode? _outcome;
        private FhirString? _disposition;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _insurer;
        private List<CoverageEligibilityResponseInsurance>? _insurance;
        private FhirString? _preauthref;
        private CodeableConcept? _form;
        private List<CoverageEligibilityResponseError>? _error;
        private CodeableConcept? _type;
        private CoverageEligibilityResponseEventWhenChoice? _when;
        private CodeableConcept? _type;
        private CoverageEligibilityResponseInsuranceItemBenefitAllowedChoice? _allowed;
        private CoverageEligibilityResponseInsuranceItemBenefitUsedChoice? _used;
        private CodeableConcept? _category;
        private CodeableConcept? _productorservice;
        private List<CodeableConcept>? _modifier;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _provider;
        private FhirBoolean? _excluded;
        private FhirString? _name;
        private FhirString? _description;
        private CodeableConcept? _network;
        private CodeableConcept? _unit;
        private CodeableConcept? _term;
        private List<CoverageEligibilityResponseInsuranceItemBenefit>? _benefit;
        private FhirBoolean? _authorizationrequired;
        private List<CodeableConcept>? _authorizationsupporting;
        private FhirUri? _authorizationurl;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _coverage;
        private FhirBoolean? _inforce;
        private Period? _benefitperiod;
        private List<CoverageEligibilityResponseInsuranceItem>? _item;
        private CodeableConcept? _code;
        private List<FhirString>? _expression;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "CoverageEligibilityResponse";        /// <summary>
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
        /// Purpose
        /// </summary>
        /// <remarks>
        /// <para>
        /// Purpose 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Purpose
        {
            get => _purpose;
            set
            {
                _purpose = value;
                OnPropertyChanged(nameof(Purpose));
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
        /// Event
        /// </summary>
        /// <remarks>
        /// <para>
        /// Event 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CoverageEligibilityResponseEvent>? Event
        {
            get => _event;
            set
            {
                _event = value;
                OnPropertyChanged(nameof(Event));
            }
        }        /// <summary>
        /// Serviced
        /// </summary>
        /// <remarks>
        /// <para>
        /// Serviced 的詳細描述。
        /// </para>
        /// </remarks>
        public CoverageEligibilityResponseServicedChoice? Serviced
        {
            get => _serviced;
            set
            {
                _serviced = value;
                OnPropertyChanged(nameof(Serviced));
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
        /// Requestor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requestor 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Requestor
        {
            get => _requestor;
            set
            {
                _requestor = value;
                OnPropertyChanged(nameof(Requestor));
            }
        }        /// <summary>
        /// Request
        /// </summary>
        /// <remarks>
        /// <para>
        /// Request 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Request
        {
            get => _request;
            set
            {
                _request = value;
                OnPropertyChanged(nameof(Request));
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
        /// Insurance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Insurance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CoverageEligibilityResponseInsurance>? Insurance
        {
            get => _insurance;
            set
            {
                _insurance = value;
                OnPropertyChanged(nameof(Insurance));
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
        /// Form
        /// </summary>
        /// <remarks>
        /// <para>
        /// Form 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Form
        {
            get => _form;
            set
            {
                _form = value;
                OnPropertyChanged(nameof(Form));
            }
        }        /// <summary>
        /// Error
        /// </summary>
        /// <remarks>
        /// <para>
        /// Error 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CoverageEligibilityResponseError>? Error
        {
            get => _error;
            set
            {
                _error = value;
                OnPropertyChanged(nameof(Error));
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
        public CoverageEligibilityResponseEventWhenChoice? When
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
        /// Allowed
        /// </summary>
        /// <remarks>
        /// <para>
        /// Allowed 的詳細描述。
        /// </para>
        /// </remarks>
        public CoverageEligibilityResponseInsuranceItemBenefitAllowedChoice? Allowed
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
        public CoverageEligibilityResponseInsuranceItemBenefitUsedChoice? Used
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
        /// Benefit
        /// </summary>
        /// <remarks>
        /// <para>
        /// Benefit 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CoverageEligibilityResponseInsuranceItemBenefit>? Benefit
        {
            get => _benefit;
            set
            {
                _benefit = value;
                OnPropertyChanged(nameof(Benefit));
            }
        }        /// <summary>
        /// Authorizationrequired
        /// </summary>
        /// <remarks>
        /// <para>
        /// Authorizationrequired 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Authorizationrequired
        {
            get => _authorizationrequired;
            set
            {
                _authorizationrequired = value;
                OnPropertyChanged(nameof(Authorizationrequired));
            }
        }        /// <summary>
        /// Authorizationsupporting
        /// </summary>
        /// <remarks>
        /// <para>
        /// Authorizationsupporting 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Authorizationsupporting
        {
            get => _authorizationsupporting;
            set
            {
                _authorizationsupporting = value;
                OnPropertyChanged(nameof(Authorizationsupporting));
            }
        }        /// <summary>
        /// Authorizationurl
        /// </summary>
        /// <remarks>
        /// <para>
        /// Authorizationurl 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Authorizationurl
        {
            get => _authorizationurl;
            set
            {
                _authorizationurl = value;
                OnPropertyChanged(nameof(Authorizationurl));
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
        /// Inforce
        /// </summary>
        /// <remarks>
        /// <para>
        /// Inforce 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Inforce
        {
            get => _inforce;
            set
            {
                _inforce = value;
                OnPropertyChanged(nameof(Inforce));
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
        /// Item
        /// </summary>
        /// <remarks>
        /// <para>
        /// Item 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CoverageEligibilityResponseInsuranceItem>? Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged(nameof(Item));
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
        /// Expression
        /// </summary>
        /// <remarks>
        /// <para>
        /// Expression 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Expression
        {
            get => _expression;
            set
            {
                _expression = value;
                OnPropertyChanged(nameof(Expression));
            }
        }        /// <summary>
        /// 建立新的 CoverageEligibilityResponse 資源實例
        /// </summary>
        public CoverageEligibilityResponse()
        {
        }

        /// <summary>
        /// 建立新的 CoverageEligibilityResponse 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public CoverageEligibilityResponse(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"CoverageEligibilityResponse(Id: {Id})";
        }
    }    /// <summary>
    /// CoverageEligibilityResponseEvent 背骨元素
    /// </summary>
    public class CoverageEligibilityResponseEvent
    {
        // TODO: 添加屬性實作
        
        public CoverageEligibilityResponseEvent() { }
    }    /// <summary>
    /// CoverageEligibilityResponseInsuranceItemBenefit 背骨元素
    /// </summary>
    public class CoverageEligibilityResponseInsuranceItemBenefit
    {
        // TODO: 添加屬性實作
        
        public CoverageEligibilityResponseInsuranceItemBenefit() { }
    }    /// <summary>
    /// CoverageEligibilityResponseInsuranceItem 背骨元素
    /// </summary>
    public class CoverageEligibilityResponseInsuranceItem
    {
        // TODO: 添加屬性實作
        
        public CoverageEligibilityResponseInsuranceItem() { }
    }    /// <summary>
    /// CoverageEligibilityResponseInsurance 背骨元素
    /// </summary>
    public class CoverageEligibilityResponseInsurance
    {
        // TODO: 添加屬性實作
        
        public CoverageEligibilityResponseInsurance() { }
    }    /// <summary>
    /// CoverageEligibilityResponseError 背骨元素
    /// </summary>
    public class CoverageEligibilityResponseError
    {
        // TODO: 添加屬性實作
        
        public CoverageEligibilityResponseError() { }
    }    /// <summary>
    /// CoverageEligibilityResponseEventWhenChoice 選擇類型
    /// </summary>
    public class CoverageEligibilityResponseEventWhenChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public CoverageEligibilityResponseEventWhenChoice(JsonObject value) : base("coverageeligibilityresponseeventwhen", value, _supportType) { }
        public CoverageEligibilityResponseEventWhenChoice(IComplexType? value) : base("coverageeligibilityresponseeventwhen", value) { }
        public CoverageEligibilityResponseEventWhenChoice(IPrimitiveType? value) : base("coverageeligibilityresponseeventwhen", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "CoverageEligibilityResponseEventWhen" : "coverageeligibilityresponseeventwhen";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// CoverageEligibilityResponseServicedChoice 選擇類型
    /// </summary>
    public class CoverageEligibilityResponseServicedChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public CoverageEligibilityResponseServicedChoice(JsonObject value) : base("coverageeligibilityresponseserviced", value, _supportType) { }
        public CoverageEligibilityResponseServicedChoice(IComplexType? value) : base("coverageeligibilityresponseserviced", value) { }
        public CoverageEligibilityResponseServicedChoice(IPrimitiveType? value) : base("coverageeligibilityresponseserviced", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "CoverageEligibilityResponseServiced" : "coverageeligibilityresponseserviced";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// CoverageEligibilityResponseInsuranceItemBenefitAllowedChoice 選擇類型
    /// </summary>
    public class CoverageEligibilityResponseInsuranceItemBenefitAllowedChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public CoverageEligibilityResponseInsuranceItemBenefitAllowedChoice(JsonObject value) : base("coverageeligibilityresponseinsuranceitembenefitallowed", value, _supportType) { }
        public CoverageEligibilityResponseInsuranceItemBenefitAllowedChoice(IComplexType? value) : base("coverageeligibilityresponseinsuranceitembenefitallowed", value) { }
        public CoverageEligibilityResponseInsuranceItemBenefitAllowedChoice(IPrimitiveType? value) : base("coverageeligibilityresponseinsuranceitembenefitallowed", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "CoverageEligibilityResponseInsuranceItemBenefitAllowed" : "coverageeligibilityresponseinsuranceitembenefitallowed";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// CoverageEligibilityResponseInsuranceItemBenefitUsedChoice 選擇類型
    /// </summary>
    public class CoverageEligibilityResponseInsuranceItemBenefitUsedChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public CoverageEligibilityResponseInsuranceItemBenefitUsedChoice(JsonObject value) : base("coverageeligibilityresponseinsuranceitembenefitused", value, _supportType) { }
        public CoverageEligibilityResponseInsuranceItemBenefitUsedChoice(IComplexType? value) : base("coverageeligibilityresponseinsuranceitembenefitused", value) { }
        public CoverageEligibilityResponseInsuranceItemBenefitUsedChoice(IPrimitiveType? value) : base("coverageeligibilityresponseinsuranceitembenefitused", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "CoverageEligibilityResponseInsuranceItemBenefitUsed" : "coverageeligibilityresponseinsuranceitembenefitused";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
