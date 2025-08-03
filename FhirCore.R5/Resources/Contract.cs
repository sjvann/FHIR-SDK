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
    /// FHIR R5 Contract 資源
    /// 
    /// <para>
    /// Contract 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var contract = new Contract("contract-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Contract 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Contract : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirUri? _url;
        private FhirString? _version;
        private FhirCode? _status;
        private CodeableConcept? _legalstate;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _instantiatescanonical;
        private FhirUri? _instantiatesuri;
        private CodeableConcept? _contentderivative;
        private FhirDateTime? _issued;
        private Period? _applies;
        private CodeableConcept? _expirationtype;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _subject;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _authority;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _domain;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _site;
        private FhirString? _name;
        private FhirString? _title;
        private FhirString? _subtitle;
        private List<FhirString>? _alias;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _author;
        private CodeableConcept? _scope;
        private ContractTopicChoice? _topic;
        private CodeableConcept? _type;
        private List<CodeableConcept>? _subtype;
        private ContractContentDefinition? _contentdefinition;
        private List<ContractTerm>? _term;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _supportinginfo;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _relevanthistory;
        private List<ContractSigner>? _signer;
        private List<ContractFriendly>? _friendly;
        private List<ContractLegal>? _legal;
        private List<ContractRule>? _rule;
        private ContractLegallyBindingChoice? _legallybinding;
        private CodeableConcept? _type;
        private CodeableConcept? _subtype;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _publisher;
        private FhirDateTime? _publicationdate;
        private FhirCode? _publicationstatus;
        private FhirMarkdown? _copyright;
        private List<FhirUnsignedInt>? _number;
        private Coding? _classification;
        private List<Coding>? _category;
        private List<Coding>? _control;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _reference;
        private CodeableConcept? _role;
        private ContractTermOfferAnswerValueChoice? _value;
        private List<Identifier>? _identifier;
        private List<ContractTermOfferParty>? _party;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _topic;
        private CodeableConcept? _type;
        private CodeableConcept? _decision;
        private List<CodeableConcept>? _decisionmode;
        private List<ContractTermOfferAnswer>? _answer;
        private List<FhirString>? _linkid;
        private List<FhirUnsignedInt>? _securitylabelnumber;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _reference;
        private List<CodeableConcept>? _code;
        private ContractTermAssetValuedItemEntityChoice? _entity;
        private Identifier? _identifier;
        private FhirDateTime? _effectivetime;
        private Quantity? _quantity;
        private Money? _unitprice;
        private FhirDecimal? _factor;
        private FhirDecimal? _points;
        private Money? _net;
        private FhirString? _payment;
        private FhirDateTime? _paymentdate;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _responsible;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _recipient;
        private List<FhirString>? _linkid;
        private List<FhirUnsignedInt>? _securitylabelnumber;
        private CodeableConcept? _scope;
        private List<CodeableConcept>? _type;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _typereference;
        private List<CodeableConcept>? _subtype;
        private Coding? _relationship;
        private List<ContractTermAssetContext>? _context;
        private FhirString? _condition;
        private List<CodeableConcept>? _periodtype;
        private List<Period>? _period;
        private List<Period>? _useperiod;
        private List<FhirString>? _linkid;
        private List<FhirUnsignedInt>? _securitylabelnumber;
        private List<ContractTermAssetValuedItem>? _valueditem;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _reference;
        private CodeableConcept? _role;
        private FhirBoolean? _donotperform;
        private CodeableConcept? _type;
        private List<ContractTermActionSubject>? _subject;
        private CodeableConcept? _intent;
        private List<FhirString>? _linkid;
        private CodeableConcept? _status;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _context;
        private List<FhirString>? _contextlinkid;
        private ContractTermActionOccurrenceChoice? _occurrence;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _requester;
        private List<FhirString>? _requesterlinkid;
        private List<CodeableConcept>? _performertype;
        private CodeableConcept? _performerrole;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _performer;
        private List<FhirString>? _performerlinkid;
        private List<CodeableReference>? _reason;
        private List<FhirString>? _reasonlinkid;
        private List<Annotation>? _note;
        private List<FhirUnsignedInt>? _securitylabelnumber;
        private Identifier? _identifier;
        private FhirDateTime? _issued;
        private Period? _applies;
        private ContractTermTopicChoice? _topic;
        private CodeableConcept? _type;
        private CodeableConcept? _subtype;
        private List<ContractTermSecurityLabel>? _securitylabel;
        private ContractTermOffer? _offer;
        private List<ContractTermAsset>? _asset;
        private List<ContractTermAction>? _action;
        private Coding? _type;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _party;
        private List<Signature>? _signature;
        private ContractFriendlyContentChoice? _content;
        private ContractLegalContentChoice? _content;
        private ContractRuleContentChoice? _content;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Contract";        /// <summary>
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
        /// Url
        /// </summary>
        /// <remarks>
        /// <para>
        /// Url 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Url
        {
            get => _url;
            set
            {
                _url = value;
                OnPropertyChanged(nameof(Url));
            }
        }        /// <summary>
        /// Version
        /// </summary>
        /// <remarks>
        /// <para>
        /// Version 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Version
        {
            get => _version;
            set
            {
                _version = value;
                OnPropertyChanged(nameof(Version));
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
        /// Legalstate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Legalstate 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Legalstate
        {
            get => _legalstate;
            set
            {
                _legalstate = value;
                OnPropertyChanged(nameof(Legalstate));
            }
        }        /// <summary>
        /// Instantiatescanonical
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instantiatescanonical 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Instantiatescanonical
        {
            get => _instantiatescanonical;
            set
            {
                _instantiatescanonical = value;
                OnPropertyChanged(nameof(Instantiatescanonical));
            }
        }        /// <summary>
        /// Instantiatesuri
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instantiatesuri 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Instantiatesuri
        {
            get => _instantiatesuri;
            set
            {
                _instantiatesuri = value;
                OnPropertyChanged(nameof(Instantiatesuri));
            }
        }        /// <summary>
        /// Contentderivative
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contentderivative 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Contentderivative
        {
            get => _contentderivative;
            set
            {
                _contentderivative = value;
                OnPropertyChanged(nameof(Contentderivative));
            }
        }        /// <summary>
        /// Issued
        /// </summary>
        /// <remarks>
        /// <para>
        /// Issued 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Issued
        {
            get => _issued;
            set
            {
                _issued = value;
                OnPropertyChanged(nameof(Issued));
            }
        }        /// <summary>
        /// Applies
        /// </summary>
        /// <remarks>
        /// <para>
        /// Applies 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Applies
        {
            get => _applies;
            set
            {
                _applies = value;
                OnPropertyChanged(nameof(Applies));
            }
        }        /// <summary>
        /// Expirationtype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Expirationtype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Expirationtype
        {
            get => _expirationtype;
            set
            {
                _expirationtype = value;
                OnPropertyChanged(nameof(Expirationtype));
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
        /// Authority
        /// </summary>
        /// <remarks>
        /// <para>
        /// Authority 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Authority
        {
            get => _authority;
            set
            {
                _authority = value;
                OnPropertyChanged(nameof(Authority));
            }
        }        /// <summary>
        /// Domain
        /// </summary>
        /// <remarks>
        /// <para>
        /// Domain 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Domain
        {
            get => _domain;
            set
            {
                _domain = value;
                OnPropertyChanged(nameof(Domain));
            }
        }        /// <summary>
        /// Site
        /// </summary>
        /// <remarks>
        /// <para>
        /// Site 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Site
        {
            get => _site;
            set
            {
                _site = value;
                OnPropertyChanged(nameof(Site));
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
        /// Title
        /// </summary>
        /// <remarks>
        /// <para>
        /// Title 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }        /// <summary>
        /// Subtitle
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subtitle 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Subtitle
        {
            get => _subtitle;
            set
            {
                _subtitle = value;
                OnPropertyChanged(nameof(Subtitle));
            }
        }        /// <summary>
        /// Alias
        /// </summary>
        /// <remarks>
        /// <para>
        /// Alias 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Alias
        {
            get => _alias;
            set
            {
                _alias = value;
                OnPropertyChanged(nameof(Alias));
            }
        }        /// <summary>
        /// Author
        /// </summary>
        /// <remarks>
        /// <para>
        /// Author 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Author
        {
            get => _author;
            set
            {
                _author = value;
                OnPropertyChanged(nameof(Author));
            }
        }        /// <summary>
        /// Scope
        /// </summary>
        /// <remarks>
        /// <para>
        /// Scope 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Scope
        {
            get => _scope;
            set
            {
                _scope = value;
                OnPropertyChanged(nameof(Scope));
            }
        }        /// <summary>
        /// Topic
        /// </summary>
        /// <remarks>
        /// <para>
        /// Topic 的詳細描述。
        /// </para>
        /// </remarks>
        public ContractTopicChoice? Topic
        {
            get => _topic;
            set
            {
                _topic = value;
                OnPropertyChanged(nameof(Topic));
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
        public List<CodeableConcept>? Subtype
        {
            get => _subtype;
            set
            {
                _subtype = value;
                OnPropertyChanged(nameof(Subtype));
            }
        }        /// <summary>
        /// Contentdefinition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contentdefinition 的詳細描述。
        /// </para>
        /// </remarks>
        public ContractContentDefinition? Contentdefinition
        {
            get => _contentdefinition;
            set
            {
                _contentdefinition = value;
                OnPropertyChanged(nameof(Contentdefinition));
            }
        }        /// <summary>
        /// Term
        /// </summary>
        /// <remarks>
        /// <para>
        /// Term 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContractTerm>? Term
        {
            get => _term;
            set
            {
                _term = value;
                OnPropertyChanged(nameof(Term));
            }
        }        /// <summary>
        /// Supportinginfo
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supportinginfo 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Supportinginfo
        {
            get => _supportinginfo;
            set
            {
                _supportinginfo = value;
                OnPropertyChanged(nameof(Supportinginfo));
            }
        }        /// <summary>
        /// Relevanthistory
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relevanthistory 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Relevanthistory
        {
            get => _relevanthistory;
            set
            {
                _relevanthistory = value;
                OnPropertyChanged(nameof(Relevanthistory));
            }
        }        /// <summary>
        /// Signer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Signer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContractSigner>? Signer
        {
            get => _signer;
            set
            {
                _signer = value;
                OnPropertyChanged(nameof(Signer));
            }
        }        /// <summary>
        /// Friendly
        /// </summary>
        /// <remarks>
        /// <para>
        /// Friendly 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContractFriendly>? Friendly
        {
            get => _friendly;
            set
            {
                _friendly = value;
                OnPropertyChanged(nameof(Friendly));
            }
        }        /// <summary>
        /// Legal
        /// </summary>
        /// <remarks>
        /// <para>
        /// Legal 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContractLegal>? Legal
        {
            get => _legal;
            set
            {
                _legal = value;
                OnPropertyChanged(nameof(Legal));
            }
        }        /// <summary>
        /// Rule
        /// </summary>
        /// <remarks>
        /// <para>
        /// Rule 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContractRule>? Rule
        {
            get => _rule;
            set
            {
                _rule = value;
                OnPropertyChanged(nameof(Rule));
            }
        }        /// <summary>
        /// Legallybinding
        /// </summary>
        /// <remarks>
        /// <para>
        /// Legallybinding 的詳細描述。
        /// </para>
        /// </remarks>
        public ContractLegallyBindingChoice? Legallybinding
        {
            get => _legallybinding;
            set
            {
                _legallybinding = value;
                OnPropertyChanged(nameof(Legallybinding));
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
        /// Publisher
        /// </summary>
        /// <remarks>
        /// <para>
        /// Publisher 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Publisher
        {
            get => _publisher;
            set
            {
                _publisher = value;
                OnPropertyChanged(nameof(Publisher));
            }
        }        /// <summary>
        /// Publicationdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Publicationdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Publicationdate
        {
            get => _publicationdate;
            set
            {
                _publicationdate = value;
                OnPropertyChanged(nameof(Publicationdate));
            }
        }        /// <summary>
        /// Publicationstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Publicationstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Publicationstatus
        {
            get => _publicationstatus;
            set
            {
                _publicationstatus = value;
                OnPropertyChanged(nameof(Publicationstatus));
            }
        }        /// <summary>
        /// Copyright
        /// </summary>
        /// <remarks>
        /// <para>
        /// Copyright 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Copyright
        {
            get => _copyright;
            set
            {
                _copyright = value;
                OnPropertyChanged(nameof(Copyright));
            }
        }        /// <summary>
        /// Number
        /// </summary>
        /// <remarks>
        /// <para>
        /// Number 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUnsignedInt>? Number
        {
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged(nameof(Number));
            }
        }        /// <summary>
        /// Classification
        /// </summary>
        /// <remarks>
        /// <para>
        /// Classification 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? Classification
        {
            get => _classification;
            set
            {
                _classification = value;
                OnPropertyChanged(nameof(Classification));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Coding>? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Control
        /// </summary>
        /// <remarks>
        /// <para>
        /// Control 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Coding>? Control
        {
            get => _control;
            set
            {
                _control = value;
                OnPropertyChanged(nameof(Control));
            }
        }        /// <summary>
        /// Reference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reference 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Reference
        {
            get => _reference;
            set
            {
                _reference = value;
                OnPropertyChanged(nameof(Reference));
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
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public ContractTermOfferAnswerValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
            }
        }        /// <summary>
        /// Party
        /// </summary>
        /// <remarks>
        /// <para>
        /// Party 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContractTermOfferParty>? Party
        {
            get => _party;
            set
            {
                _party = value;
                OnPropertyChanged(nameof(Party));
            }
        }        /// <summary>
        /// Topic
        /// </summary>
        /// <remarks>
        /// <para>
        /// Topic 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Topic
        {
            get => _topic;
            set
            {
                _topic = value;
                OnPropertyChanged(nameof(Topic));
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
        /// Decisionmode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Decisionmode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Decisionmode
        {
            get => _decisionmode;
            set
            {
                _decisionmode = value;
                OnPropertyChanged(nameof(Decisionmode));
            }
        }        /// <summary>
        /// Answer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Answer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContractTermOfferAnswer>? Answer
        {
            get => _answer;
            set
            {
                _answer = value;
                OnPropertyChanged(nameof(Answer));
            }
        }        /// <summary>
        /// Linkid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Linkid 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Linkid
        {
            get => _linkid;
            set
            {
                _linkid = value;
                OnPropertyChanged(nameof(Linkid));
            }
        }        /// <summary>
        /// Securitylabelnumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Securitylabelnumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUnsignedInt>? Securitylabelnumber
        {
            get => _securitylabelnumber;
            set
            {
                _securitylabelnumber = value;
                OnPropertyChanged(nameof(Securitylabelnumber));
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
        /// Entity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Entity 的詳細描述。
        /// </para>
        /// </remarks>
        public ContractTermAssetValuedItemEntityChoice? Entity
        {
            get => _entity;
            set
            {
                _entity = value;
                OnPropertyChanged(nameof(Entity));
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
        /// Effectivetime
        /// </summary>
        /// <remarks>
        /// <para>
        /// Effectivetime 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Effectivetime
        {
            get => _effectivetime;
            set
            {
                _effectivetime = value;
                OnPropertyChanged(nameof(Effectivetime));
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
        /// Points
        /// </summary>
        /// <remarks>
        /// <para>
        /// Points 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? Points
        {
            get => _points;
            set
            {
                _points = value;
                OnPropertyChanged(nameof(Points));
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
        /// Payment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Payment 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Payment
        {
            get => _payment;
            set
            {
                _payment = value;
                OnPropertyChanged(nameof(Payment));
            }
        }        /// <summary>
        /// Paymentdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Paymentdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Paymentdate
        {
            get => _paymentdate;
            set
            {
                _paymentdate = value;
                OnPropertyChanged(nameof(Paymentdate));
            }
        }        /// <summary>
        /// Responsible
        /// </summary>
        /// <remarks>
        /// <para>
        /// Responsible 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Responsible
        {
            get => _responsible;
            set
            {
                _responsible = value;
                OnPropertyChanged(nameof(Responsible));
            }
        }        /// <summary>
        /// Recipient
        /// </summary>
        /// <remarks>
        /// <para>
        /// Recipient 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Recipient
        {
            get => _recipient;
            set
            {
                _recipient = value;
                OnPropertyChanged(nameof(Recipient));
            }
        }        /// <summary>
        /// Linkid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Linkid 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Linkid
        {
            get => _linkid;
            set
            {
                _linkid = value;
                OnPropertyChanged(nameof(Linkid));
            }
        }        /// <summary>
        /// Securitylabelnumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Securitylabelnumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUnsignedInt>? Securitylabelnumber
        {
            get => _securitylabelnumber;
            set
            {
                _securitylabelnumber = value;
                OnPropertyChanged(nameof(Securitylabelnumber));
            }
        }        /// <summary>
        /// Scope
        /// </summary>
        /// <remarks>
        /// <para>
        /// Scope 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Scope
        {
            get => _scope;
            set
            {
                _scope = value;
                OnPropertyChanged(nameof(Scope));
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
        /// Typereference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Typereference 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Typereference
        {
            get => _typereference;
            set
            {
                _typereference = value;
                OnPropertyChanged(nameof(Typereference));
            }
        }        /// <summary>
        /// Subtype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subtype 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Subtype
        {
            get => _subtype;
            set
            {
                _subtype = value;
                OnPropertyChanged(nameof(Subtype));
            }
        }        /// <summary>
        /// Relationship
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relationship 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? Relationship
        {
            get => _relationship;
            set
            {
                _relationship = value;
                OnPropertyChanged(nameof(Relationship));
            }
        }        /// <summary>
        /// Context
        /// </summary>
        /// <remarks>
        /// <para>
        /// Context 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContractTermAssetContext>? Context
        {
            get => _context;
            set
            {
                _context = value;
                OnPropertyChanged(nameof(Context));
            }
        }        /// <summary>
        /// Condition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Condition 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Condition
        {
            get => _condition;
            set
            {
                _condition = value;
                OnPropertyChanged(nameof(Condition));
            }
        }        /// <summary>
        /// Periodtype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Periodtype 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Periodtype
        {
            get => _periodtype;
            set
            {
                _periodtype = value;
                OnPropertyChanged(nameof(Periodtype));
            }
        }        /// <summary>
        /// Period
        /// </summary>
        /// <remarks>
        /// <para>
        /// Period 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Period>? Period
        {
            get => _period;
            set
            {
                _period = value;
                OnPropertyChanged(nameof(Period));
            }
        }        /// <summary>
        /// Useperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Useperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Period>? Useperiod
        {
            get => _useperiod;
            set
            {
                _useperiod = value;
                OnPropertyChanged(nameof(Useperiod));
            }
        }        /// <summary>
        /// Linkid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Linkid 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Linkid
        {
            get => _linkid;
            set
            {
                _linkid = value;
                OnPropertyChanged(nameof(Linkid));
            }
        }        /// <summary>
        /// Securitylabelnumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Securitylabelnumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUnsignedInt>? Securitylabelnumber
        {
            get => _securitylabelnumber;
            set
            {
                _securitylabelnumber = value;
                OnPropertyChanged(nameof(Securitylabelnumber));
            }
        }        /// <summary>
        /// Valueditem
        /// </summary>
        /// <remarks>
        /// <para>
        /// Valueditem 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContractTermAssetValuedItem>? Valueditem
        {
            get => _valueditem;
            set
            {
                _valueditem = value;
                OnPropertyChanged(nameof(Valueditem));
            }
        }        /// <summary>
        /// Reference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reference 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Reference
        {
            get => _reference;
            set
            {
                _reference = value;
                OnPropertyChanged(nameof(Reference));
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
        /// Donotperform
        /// </summary>
        /// <remarks>
        /// <para>
        /// Donotperform 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Donotperform
        {
            get => _donotperform;
            set
            {
                _donotperform = value;
                OnPropertyChanged(nameof(Donotperform));
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
        /// Subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContractTermActionSubject>? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }        /// <summary>
        /// Intent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Intent 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Intent
        {
            get => _intent;
            set
            {
                _intent = value;
                OnPropertyChanged(nameof(Intent));
            }
        }        /// <summary>
        /// Linkid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Linkid 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Linkid
        {
            get => _linkid;
            set
            {
                _linkid = value;
                OnPropertyChanged(nameof(Linkid));
            }
        }        /// <summary>
        /// Status
        /// </summary>
        /// <remarks>
        /// <para>
        /// Status 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }        /// <summary>
        /// Context
        /// </summary>
        /// <remarks>
        /// <para>
        /// Context 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Context
        {
            get => _context;
            set
            {
                _context = value;
                OnPropertyChanged(nameof(Context));
            }
        }        /// <summary>
        /// Contextlinkid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contextlinkid 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Contextlinkid
        {
            get => _contextlinkid;
            set
            {
                _contextlinkid = value;
                OnPropertyChanged(nameof(Contextlinkid));
            }
        }        /// <summary>
        /// Occurrence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Occurrence 的詳細描述。
        /// </para>
        /// </remarks>
        public ContractTermActionOccurrenceChoice? Occurrence
        {
            get => _occurrence;
            set
            {
                _occurrence = value;
                OnPropertyChanged(nameof(Occurrence));
            }
        }        /// <summary>
        /// Requester
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requester 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Requester
        {
            get => _requester;
            set
            {
                _requester = value;
                OnPropertyChanged(nameof(Requester));
            }
        }        /// <summary>
        /// Requesterlinkid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requesterlinkid 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Requesterlinkid
        {
            get => _requesterlinkid;
            set
            {
                _requesterlinkid = value;
                OnPropertyChanged(nameof(Requesterlinkid));
            }
        }        /// <summary>
        /// Performertype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performertype 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Performertype
        {
            get => _performertype;
            set
            {
                _performertype = value;
                OnPropertyChanged(nameof(Performertype));
            }
        }        /// <summary>
        /// Performerrole
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performerrole 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Performerrole
        {
            get => _performerrole;
            set
            {
                _performerrole = value;
                OnPropertyChanged(nameof(Performerrole));
            }
        }        /// <summary>
        /// Performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performer 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(Performer));
            }
        }        /// <summary>
        /// Performerlinkid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performerlinkid 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Performerlinkid
        {
            get => _performerlinkid;
            set
            {
                _performerlinkid = value;
                OnPropertyChanged(nameof(Performerlinkid));
            }
        }        /// <summary>
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }        /// <summary>
        /// Reasonlinkid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reasonlinkid 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Reasonlinkid
        {
            get => _reasonlinkid;
            set
            {
                _reasonlinkid = value;
                OnPropertyChanged(nameof(Reasonlinkid));
            }
        }        /// <summary>
        /// Note
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Annotation>? Note
        {
            get => _note;
            set
            {
                _note = value;
                OnPropertyChanged(nameof(Note));
            }
        }        /// <summary>
        /// Securitylabelnumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Securitylabelnumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUnsignedInt>? Securitylabelnumber
        {
            get => _securitylabelnumber;
            set
            {
                _securitylabelnumber = value;
                OnPropertyChanged(nameof(Securitylabelnumber));
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
        /// Issued
        /// </summary>
        /// <remarks>
        /// <para>
        /// Issued 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Issued
        {
            get => _issued;
            set
            {
                _issued = value;
                OnPropertyChanged(nameof(Issued));
            }
        }        /// <summary>
        /// Applies
        /// </summary>
        /// <remarks>
        /// <para>
        /// Applies 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Applies
        {
            get => _applies;
            set
            {
                _applies = value;
                OnPropertyChanged(nameof(Applies));
            }
        }        /// <summary>
        /// Topic
        /// </summary>
        /// <remarks>
        /// <para>
        /// Topic 的詳細描述。
        /// </para>
        /// </remarks>
        public ContractTermTopicChoice? Topic
        {
            get => _topic;
            set
            {
                _topic = value;
                OnPropertyChanged(nameof(Topic));
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
        /// Securitylabel
        /// </summary>
        /// <remarks>
        /// <para>
        /// Securitylabel 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContractTermSecurityLabel>? Securitylabel
        {
            get => _securitylabel;
            set
            {
                _securitylabel = value;
                OnPropertyChanged(nameof(Securitylabel));
            }
        }        /// <summary>
        /// Offer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Offer 的詳細描述。
        /// </para>
        /// </remarks>
        public ContractTermOffer? Offer
        {
            get => _offer;
            set
            {
                _offer = value;
                OnPropertyChanged(nameof(Offer));
            }
        }        /// <summary>
        /// Asset
        /// </summary>
        /// <remarks>
        /// <para>
        /// Asset 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContractTermAsset>? Asset
        {
            get => _asset;
            set
            {
                _asset = value;
                OnPropertyChanged(nameof(Asset));
            }
        }        /// <summary>
        /// Action
        /// </summary>
        /// <remarks>
        /// <para>
        /// Action 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContractTermAction>? Action
        {
            get => _action;
            set
            {
                _action = value;
                OnPropertyChanged(nameof(Action));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? Type
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
        /// Signature
        /// </summary>
        /// <remarks>
        /// <para>
        /// Signature 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Signature>? Signature
        {
            get => _signature;
            set
            {
                _signature = value;
                OnPropertyChanged(nameof(Signature));
            }
        }        /// <summary>
        /// Content
        /// </summary>
        /// <remarks>
        /// <para>
        /// Content 的詳細描述。
        /// </para>
        /// </remarks>
        public ContractFriendlyContentChoice? Content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged(nameof(Content));
            }
        }        /// <summary>
        /// Content
        /// </summary>
        /// <remarks>
        /// <para>
        /// Content 的詳細描述。
        /// </para>
        /// </remarks>
        public ContractLegalContentChoice? Content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged(nameof(Content));
            }
        }        /// <summary>
        /// Content
        /// </summary>
        /// <remarks>
        /// <para>
        /// Content 的詳細描述。
        /// </para>
        /// </remarks>
        public ContractRuleContentChoice? Content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged(nameof(Content));
            }
        }        /// <summary>
        /// 建立新的 Contract 資源實例
        /// </summary>
        public Contract()
        {
        }

        /// <summary>
        /// 建立新的 Contract 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Contract(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Contract(Id: {Id})";
        }
    }    /// <summary>
    /// ContractContentDefinition 背骨元素
    /// </summary>
    public class ContractContentDefinition
    {
        // TODO: 添加屬性實作
        
        public ContractContentDefinition() { }
    }    /// <summary>
    /// ContractTermSecurityLabel 背骨元素
    /// </summary>
    public class ContractTermSecurityLabel
    {
        // TODO: 添加屬性實作
        
        public ContractTermSecurityLabel() { }
    }    /// <summary>
    /// ContractTermOfferParty 背骨元素
    /// </summary>
    public class ContractTermOfferParty
    {
        // TODO: 添加屬性實作
        
        public ContractTermOfferParty() { }
    }    /// <summary>
    /// ContractTermOfferAnswer 背骨元素
    /// </summary>
    public class ContractTermOfferAnswer
    {
        // TODO: 添加屬性實作
        
        public ContractTermOfferAnswer() { }
    }    /// <summary>
    /// ContractTermOffer 背骨元素
    /// </summary>
    public class ContractTermOffer
    {
        // TODO: 添加屬性實作
        
        public ContractTermOffer() { }
    }    /// <summary>
    /// ContractTermAssetContext 背骨元素
    /// </summary>
    public class ContractTermAssetContext
    {
        // TODO: 添加屬性實作
        
        public ContractTermAssetContext() { }
    }    /// <summary>
    /// ContractTermAssetValuedItem 背骨元素
    /// </summary>
    public class ContractTermAssetValuedItem
    {
        // TODO: 添加屬性實作
        
        public ContractTermAssetValuedItem() { }
    }    /// <summary>
    /// ContractTermAsset 背骨元素
    /// </summary>
    public class ContractTermAsset
    {
        // TODO: 添加屬性實作
        
        public ContractTermAsset() { }
    }    /// <summary>
    /// ContractTermActionSubject 背骨元素
    /// </summary>
    public class ContractTermActionSubject
    {
        // TODO: 添加屬性實作
        
        public ContractTermActionSubject() { }
    }    /// <summary>
    /// ContractTermAction 背骨元素
    /// </summary>
    public class ContractTermAction
    {
        // TODO: 添加屬性實作
        
        public ContractTermAction() { }
    }    /// <summary>
    /// ContractTerm 背骨元素
    /// </summary>
    public class ContractTerm
    {
        // TODO: 添加屬性實作
        
        public ContractTerm() { }
    }    /// <summary>
    /// ContractSigner 背骨元素
    /// </summary>
    public class ContractSigner
    {
        // TODO: 添加屬性實作
        
        public ContractSigner() { }
    }    /// <summary>
    /// ContractFriendly 背骨元素
    /// </summary>
    public class ContractFriendly
    {
        // TODO: 添加屬性實作
        
        public ContractFriendly() { }
    }    /// <summary>
    /// ContractLegal 背骨元素
    /// </summary>
    public class ContractLegal
    {
        // TODO: 添加屬性實作
        
        public ContractLegal() { }
    }    /// <summary>
    /// ContractRule 背骨元素
    /// </summary>
    public class ContractRule
    {
        // TODO: 添加屬性實作
        
        public ContractRule() { }
    }    /// <summary>
    /// ContractTopicChoice 選擇類型
    /// </summary>
    public class ContractTopicChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ContractTopicChoice(JsonObject value) : base("contracttopic", value, _supportType) { }
        public ContractTopicChoice(IComplexType? value) : base("contracttopic", value) { }
        public ContractTopicChoice(IPrimitiveType? value) : base("contracttopic", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ContractTopic" : "contracttopic";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ContractTermTopicChoice 選擇類型
    /// </summary>
    public class ContractTermTopicChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ContractTermTopicChoice(JsonObject value) : base("contracttermtopic", value, _supportType) { }
        public ContractTermTopicChoice(IComplexType? value) : base("contracttermtopic", value) { }
        public ContractTermTopicChoice(IPrimitiveType? value) : base("contracttermtopic", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ContractTermTopic" : "contracttermtopic";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ContractTermOfferAnswerValueChoice 選擇類型
    /// </summary>
    public class ContractTermOfferAnswerValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ContractTermOfferAnswerValueChoice(JsonObject value) : base("contracttermofferanswervalue", value, _supportType) { }
        public ContractTermOfferAnswerValueChoice(IComplexType? value) : base("contracttermofferanswervalue", value) { }
        public ContractTermOfferAnswerValueChoice(IPrimitiveType? value) : base("contracttermofferanswervalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ContractTermOfferAnswerValue" : "contracttermofferanswervalue";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ContractTermAssetValuedItemEntityChoice 選擇類型
    /// </summary>
    public class ContractTermAssetValuedItemEntityChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ContractTermAssetValuedItemEntityChoice(JsonObject value) : base("contracttermassetvalueditementity", value, _supportType) { }
        public ContractTermAssetValuedItemEntityChoice(IComplexType? value) : base("contracttermassetvalueditementity", value) { }
        public ContractTermAssetValuedItemEntityChoice(IPrimitiveType? value) : base("contracttermassetvalueditementity", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ContractTermAssetValuedItemEntity" : "contracttermassetvalueditementity";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ContractTermActionOccurrenceChoice 選擇類型
    /// </summary>
    public class ContractTermActionOccurrenceChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ContractTermActionOccurrenceChoice(JsonObject value) : base("contracttermactionoccurrence", value, _supportType) { }
        public ContractTermActionOccurrenceChoice(IComplexType? value) : base("contracttermactionoccurrence", value) { }
        public ContractTermActionOccurrenceChoice(IPrimitiveType? value) : base("contracttermactionoccurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ContractTermActionOccurrence" : "contracttermactionoccurrence";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ContractFriendlyContentChoice 選擇類型
    /// </summary>
    public class ContractFriendlyContentChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ContractFriendlyContentChoice(JsonObject value) : base("contractfriendlycontent", value, _supportType) { }
        public ContractFriendlyContentChoice(IComplexType? value) : base("contractfriendlycontent", value) { }
        public ContractFriendlyContentChoice(IPrimitiveType? value) : base("contractfriendlycontent", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ContractFriendlyContent" : "contractfriendlycontent";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ContractLegalContentChoice 選擇類型
    /// </summary>
    public class ContractLegalContentChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ContractLegalContentChoice(JsonObject value) : base("contractlegalcontent", value, _supportType) { }
        public ContractLegalContentChoice(IComplexType? value) : base("contractlegalcontent", value) { }
        public ContractLegalContentChoice(IPrimitiveType? value) : base("contractlegalcontent", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ContractLegalContent" : "contractlegalcontent";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ContractRuleContentChoice 選擇類型
    /// </summary>
    public class ContractRuleContentChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ContractRuleContentChoice(JsonObject value) : base("contractrulecontent", value, _supportType) { }
        public ContractRuleContentChoice(IComplexType? value) : base("contractrulecontent", value) { }
        public ContractRuleContentChoice(IPrimitiveType? value) : base("contractrulecontent", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ContractRuleContent" : "contractrulecontent";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ContractLegallyBindingChoice 選擇類型
    /// </summary>
    public class ContractLegallyBindingChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ContractLegallyBindingChoice(JsonObject value) : base("contractlegallybinding", value, _supportType) { }
        public ContractLegallyBindingChoice(IComplexType? value) : base("contractlegallybinding", value) { }
        public ContractLegallyBindingChoice(IPrimitiveType? value) : base("contractlegallybinding", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ContractLegallyBinding" : "contractlegallybinding";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
