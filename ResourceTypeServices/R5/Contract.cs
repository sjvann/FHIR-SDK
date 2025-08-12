using System.Text.Json.Nodes;
using TerminologyService.ValueSet;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.DataTypes.MetaTypes;
using Range = DataTypeServices.DataTypes.ComplexTypes.Range;
using FhirCore.Interfaces;
using FhirCore.ExtensionMethods;

namespace ResourceTypeServices.R5
{
    public class Contract : ResourceType<Contract>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirUri? _url;
private FhirString? _version;
private FhirCode? _status;
private CodeableConcept? _legalState;
private ReferenceType? _instantiatesCanonical;
private FhirUri? _instantiatesUri;
private CodeableConcept? _contentDerivative;
private FhirDateTime? _issued;
private Period? _applies;
private CodeableConcept? _expirationType;
private List<ReferenceType>? _subject;
private List<ReferenceType>? _authority;
private List<ReferenceType>? _domain;
private List<ReferenceType>? _site;
private FhirString? _name;
private FhirString? _title;
private FhirString? _subtitle;
private List<FhirString>? _alias;
private ReferenceType? _author;
private CodeableConcept? _scope;
private ContractTopicChoice? _topic;
private CodeableConcept? _type;
private List<CodeableConcept>? _subType;
private ContractContentDefinition? _contentDefinition;
private List<ContractTerm>? _term;
private List<ReferenceType>? _supportingInfo;
private List<ReferenceType>? _relevantHistory;
private List<ContractSigner>? _signer;
private List<ContractFriendly>? _friendly;
private List<ContractLegal>? _legal;
private List<ContractRule>? _rule;
private ContractLegallyBindingChoice? _legallyBinding;

		#endregion
		#region Public Method
		public List<Identifier>? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
}
}

public FhirUri? Url
{
get { return _url; }
set {
_url= value;
OnPropertyChanged("url", value);
}
}

public FhirString? Version
{
get { return _version; }
set {
_version= value;
OnPropertyChanged("version", value);
}
}

public FhirCode? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
}
}

public CodeableConcept? LegalState
{
get { return _legalState; }
set {
_legalState= value;
OnPropertyChanged("legalState", value);
}
}

public ReferenceType? InstantiatesCanonical
{
get { return _instantiatesCanonical; }
set {
_instantiatesCanonical= value;
OnPropertyChanged("instantiatesCanonical", value);
}
}

public FhirUri? InstantiatesUri
{
get { return _instantiatesUri; }
set {
_instantiatesUri= value;
OnPropertyChanged("instantiatesUri", value);
}
}

public CodeableConcept? ContentDerivative
{
get { return _contentDerivative; }
set {
_contentDerivative= value;
OnPropertyChanged("contentDerivative", value);
}
}

public FhirDateTime? Issued
{
get { return _issued; }
set {
_issued= value;
OnPropertyChanged("issued", value);
}
}

public Period? Applies
{
get { return _applies; }
set {
_applies= value;
OnPropertyChanged("applies", value);
}
}

public CodeableConcept? ExpirationType
{
get { return _expirationType; }
set {
_expirationType= value;
OnPropertyChanged("expirationType", value);
}
}

public List<ReferenceType>? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
}
}

public List<ReferenceType>? Authority
{
get { return _authority; }
set {
_authority= value;
OnPropertyChanged("authority", value);
}
}

public List<ReferenceType>? Domain
{
get { return _domain; }
set {
_domain= value;
OnPropertyChanged("domain", value);
}
}

public List<ReferenceType>? Site
{
get { return _site; }
set {
_site= value;
OnPropertyChanged("site", value);
}
}

public FhirString? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public FhirString? Title
{
get { return _title; }
set {
_title= value;
OnPropertyChanged("title", value);
}
}

public FhirString? Subtitle
{
get { return _subtitle; }
set {
_subtitle= value;
OnPropertyChanged("subtitle", value);
}
}

public List<FhirString>? Alias
{
get { return _alias; }
set {
_alias= value;
OnPropertyChanged("alias", value);
}
}

public ReferenceType? Author
{
get { return _author; }
set {
_author= value;
OnPropertyChanged("author", value);
}
}

public CodeableConcept? Scope
{
get { return _scope; }
set {
_scope= value;
OnPropertyChanged("scope", value);
}
}

public ContractTopicChoice? Topic
{
get { return _topic; }
set {
_topic= value;
OnPropertyChanged("topic", value);
}
}

public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public List<CodeableConcept>? SubType
{
get { return _subType; }
set {
_subType= value;
OnPropertyChanged("subType", value);
}
}

public ContractContentDefinition? ContentDefinition
{
get { return _contentDefinition; }
set {
_contentDefinition= value;
OnPropertyChanged("contentDefinition", value);
}
}

public List<ContractTerm>? Term
{
get { return _term; }
set {
_term= value;
OnPropertyChanged("term", value);
}
}

public List<ReferenceType>? SupportingInfo
{
get { return _supportingInfo; }
set {
_supportingInfo= value;
OnPropertyChanged("supportingInfo", value);
}
}

public List<ReferenceType>? RelevantHistory
{
get { return _relevantHistory; }
set {
_relevantHistory= value;
OnPropertyChanged("relevantHistory", value);
}
}

public List<ContractSigner>? Signer
{
get { return _signer; }
set {
_signer= value;
OnPropertyChanged("signer", value);
}
}

public List<ContractFriendly>? Friendly
{
get { return _friendly; }
set {
_friendly= value;
OnPropertyChanged("friendly", value);
}
}

public List<ContractLegal>? Legal
{
get { return _legal; }
set {
_legal= value;
OnPropertyChanged("legal", value);
}
}

public List<ContractRule>? Rule
{
get { return _rule; }
set {
_rule= value;
OnPropertyChanged("rule", value);
}
}

public ContractLegallyBindingChoice? LegallyBinding
{
get { return _legallyBinding; }
set {
_legallyBinding= value;
OnPropertyChanged("legallyBinding", value);
}
}


		#endregion
		#region Constructor
		public  Contract() { }
		public  Contract(string value) : base(value) { }
		public  Contract(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ContractContentDefinition : BackboneElementType<ContractContentDefinition>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private CodeableConcept? _subType;
private ReferenceType? _publisher;
private FhirDateTime? _publicationDate;
private FhirCode? _publicationStatus;
private FhirMarkdown? _copyright;

		#endregion
		#region public Method
		public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public CodeableConcept? SubType
{
get { return _subType; }
set {
_subType= value;
OnPropertyChanged("subType", value);
}
}

public ReferenceType? Publisher
{
get { return _publisher; }
set {
_publisher= value;
OnPropertyChanged("publisher", value);
}
}

public FhirDateTime? PublicationDate
{
get { return _publicationDate; }
set {
_publicationDate= value;
OnPropertyChanged("publicationDate", value);
}
}

public FhirCode? PublicationStatus
{
get { return _publicationStatus; }
set {
_publicationStatus= value;
OnPropertyChanged("publicationStatus", value);
}
}

public FhirMarkdown? Copyright
{
get { return _copyright; }
set {
_copyright= value;
OnPropertyChanged("copyright", value);
}
}


		#endregion
		#region Constructor
		public  ContractContentDefinition() { }
		public  ContractContentDefinition(string value) : base(value) { }
		public  ContractContentDefinition(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ContractTermSecurityLabel : BackboneElementType<ContractTermSecurityLabel>, IBackboneElementType
	{

		#region Private Method
		private List<FhirUnsignedInt>? _number;
private Coding? _classification;
private List<Coding>? _category;
private List<Coding>? _control;

		#endregion
		#region public Method
		public List<FhirUnsignedInt>? Number
{
get { return _number; }
set {
_number= value;
OnPropertyChanged("number", value);
}
}

public Coding? Classification
{
get { return _classification; }
set {
_classification= value;
OnPropertyChanged("classification", value);
}
}

public List<Coding>? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
}
}

public List<Coding>? Control
{
get { return _control; }
set {
_control= value;
OnPropertyChanged("control", value);
}
}


		#endregion
		#region Constructor
		public  ContractTermSecurityLabel() { }
		public  ContractTermSecurityLabel(string value) : base(value) { }
		public  ContractTermSecurityLabel(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ContractTermOfferParty : BackboneElementType<ContractTermOfferParty>, IBackboneElementType
	{

		#region Private Method
		private List<ReferenceType>? _reference;
private CodeableConcept? _role;

		#endregion
		#region public Method
		public List<ReferenceType>? Reference
{
get { return _reference; }
set {
_reference= value;
OnPropertyChanged("reference", value);
}
}

public CodeableConcept? Role
{
get { return _role; }
set {
_role= value;
OnPropertyChanged("role", value);
}
}


		#endregion
		#region Constructor
		public  ContractTermOfferParty() { }
		public  ContractTermOfferParty(string value) : base(value) { }
		public  ContractTermOfferParty(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ContractTermOfferAnswer : BackboneElementType<ContractTermOfferAnswer>, IBackboneElementType
	{

		#region Private Method
		private ContractTermOfferAnswerValueChoice? _value;

		#endregion
		#region public Method
		public ContractTermOfferAnswerValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  ContractTermOfferAnswer() { }
		public  ContractTermOfferAnswer(string value) : base(value) { }
		public  ContractTermOfferAnswer(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ContractTermOffer : BackboneElementType<ContractTermOffer>, IBackboneElementType
	{

		#region Private Method
		private List<Identifier>? _identifier;
private List<ContractTermOfferParty>? _party;
private ReferenceType? _topic;
private CodeableConcept? _type;
private CodeableConcept? _decision;
private List<CodeableConcept>? _decisionMode;
private List<ContractTermOfferAnswer>? _answer;
private List<FhirString>? _linkId;
private List<FhirUnsignedInt>? _securityLabelNumber;

		#endregion
		#region public Method
		public List<Identifier>? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
}
}

public List<ContractTermOfferParty>? Party
{
get { return _party; }
set {
_party= value;
OnPropertyChanged("party", value);
}
}

public ReferenceType? Topic
{
get { return _topic; }
set {
_topic= value;
OnPropertyChanged("topic", value);
}
}

public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public CodeableConcept? Decision
{
get { return _decision; }
set {
_decision= value;
OnPropertyChanged("decision", value);
}
}

public List<CodeableConcept>? DecisionMode
{
get { return _decisionMode; }
set {
_decisionMode= value;
OnPropertyChanged("decisionMode", value);
}
}

public List<ContractTermOfferAnswer>? Answer
{
get { return _answer; }
set {
_answer= value;
OnPropertyChanged("answer", value);
}
}

public List<FhirString>? LinkId
{
get { return _linkId; }
set {
_linkId= value;
OnPropertyChanged("linkId", value);
}
}

public List<FhirUnsignedInt>? SecurityLabelNumber
{
get { return _securityLabelNumber; }
set {
_securityLabelNumber= value;
OnPropertyChanged("securityLabelNumber", value);
}
}


		#endregion
		#region Constructor
		public  ContractTermOffer() { }
		public  ContractTermOffer(string value) : base(value) { }
		public  ContractTermOffer(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ContractTermAssetContext : BackboneElementType<ContractTermAssetContext>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _reference;
private List<CodeableConcept>? _code;

		#endregion
		#region public Method
		public ReferenceType? Reference
{
get { return _reference; }
set {
_reference= value;
OnPropertyChanged("reference", value);
}
}

public List<CodeableConcept>? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}


		#endregion
		#region Constructor
		public  ContractTermAssetContext() { }
		public  ContractTermAssetContext(string value) : base(value) { }
		public  ContractTermAssetContext(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ContractTermAssetValuedItem : BackboneElementType<ContractTermAssetValuedItem>, IBackboneElementType
	{

		#region Private Method
		private ContractTermAssetValuedItemEntityChoice? _entity;
private Identifier? _identifier;
private FhirDateTime? _effectiveTime;
private Quantity? _quantity;
private Money? _unitPrice;
private FhirDecimal? _factor;
private FhirDecimal? _points;
private Money? _net;
private FhirString? _payment;
private FhirDateTime? _paymentDate;
private ReferenceType? _responsible;
private ReferenceType? _recipient;
private List<FhirString>? _linkId;
private List<FhirUnsignedInt>? _securityLabelNumber;

		#endregion
		#region public Method
		public ContractTermAssetValuedItemEntityChoice? Entity
{
get { return _entity; }
set {
_entity= value;
OnPropertyChanged("entity", value);
}
}

public Identifier? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
}
}

public FhirDateTime? EffectiveTime
{
get { return _effectiveTime; }
set {
_effectiveTime= value;
OnPropertyChanged("effectiveTime", value);
}
}

public Quantity? Quantity
{
get { return _quantity; }
set {
_quantity= value;
OnPropertyChanged("quantity", value);
}
}

public Money? UnitPrice
{
get { return _unitPrice; }
set {
_unitPrice= value;
OnPropertyChanged("unitPrice", value);
}
}

public FhirDecimal? Factor
{
get { return _factor; }
set {
_factor= value;
OnPropertyChanged("factor", value);
}
}

public FhirDecimal? Points
{
get { return _points; }
set {
_points= value;
OnPropertyChanged("points", value);
}
}

public Money? Net
{
get { return _net; }
set {
_net= value;
OnPropertyChanged("net", value);
}
}

public FhirString? Payment
{
get { return _payment; }
set {
_payment= value;
OnPropertyChanged("payment", value);
}
}

public FhirDateTime? PaymentDate
{
get { return _paymentDate; }
set {
_paymentDate= value;
OnPropertyChanged("paymentDate", value);
}
}

public ReferenceType? Responsible
{
get { return _responsible; }
set {
_responsible= value;
OnPropertyChanged("responsible", value);
}
}

public ReferenceType? Recipient
{
get { return _recipient; }
set {
_recipient= value;
OnPropertyChanged("recipient", value);
}
}

public List<FhirString>? LinkId
{
get { return _linkId; }
set {
_linkId= value;
OnPropertyChanged("linkId", value);
}
}

public List<FhirUnsignedInt>? SecurityLabelNumber
{
get { return _securityLabelNumber; }
set {
_securityLabelNumber= value;
OnPropertyChanged("securityLabelNumber", value);
}
}


		#endregion
		#region Constructor
		public  ContractTermAssetValuedItem() { }
		public  ContractTermAssetValuedItem(string value) : base(value) { }
		public  ContractTermAssetValuedItem(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ContractTermAsset : BackboneElementType<ContractTermAsset>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _scope;
private List<CodeableConcept>? _type;
private List<ReferenceType>? _typeReference;
private List<CodeableConcept>? _subtype;
private Coding? _relationship;
private List<ContractTermAssetContext>? _context;
private FhirString? _condition;
private List<CodeableConcept>? _periodType;
private List<Period>? _period;
private List<Period>? _usePeriod;
private List<FhirString>? _linkId;
private List<FhirUnsignedInt>? _securityLabelNumber;
private List<ContractTermAssetValuedItem>? _valuedItem;

		#endregion
		#region public Method
		public CodeableConcept? Scope
{
get { return _scope; }
set {
_scope= value;
OnPropertyChanged("scope", value);
}
}

public List<CodeableConcept>? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public List<ReferenceType>? TypeReference
{
get { return _typeReference; }
set {
_typeReference= value;
OnPropertyChanged("typeReference", value);
}
}

public List<CodeableConcept>? Subtype
{
get { return _subtype; }
set {
_subtype= value;
OnPropertyChanged("subtype", value);
}
}

public Coding? Relationship
{
get { return _relationship; }
set {
_relationship= value;
OnPropertyChanged("relationship", value);
}
}

public List<ContractTermAssetContext>? Context
{
get { return _context; }
set {
_context= value;
OnPropertyChanged("context", value);
}
}

public FhirString? Condition
{
get { return _condition; }
set {
_condition= value;
OnPropertyChanged("condition", value);
}
}

public List<CodeableConcept>? PeriodType
{
get { return _periodType; }
set {
_periodType= value;
OnPropertyChanged("periodType", value);
}
}

public List<Period>? Period
{
get { return _period; }
set {
_period= value;
OnPropertyChanged("period", value);
}
}

public List<Period>? UsePeriod
{
get { return _usePeriod; }
set {
_usePeriod= value;
OnPropertyChanged("usePeriod", value);
}
}

public List<FhirString>? LinkId
{
get { return _linkId; }
set {
_linkId= value;
OnPropertyChanged("linkId", value);
}
}

public List<FhirUnsignedInt>? SecurityLabelNumber
{
get { return _securityLabelNumber; }
set {
_securityLabelNumber= value;
OnPropertyChanged("securityLabelNumber", value);
}
}

public List<ContractTermAssetValuedItem>? ValuedItem
{
get { return _valuedItem; }
set {
_valuedItem= value;
OnPropertyChanged("valuedItem", value);
}
}


		#endregion
		#region Constructor
		public  ContractTermAsset() { }
		public  ContractTermAsset(string value) : base(value) { }
		public  ContractTermAsset(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ContractTermActionSubject : BackboneElementType<ContractTermActionSubject>, IBackboneElementType
	{

		#region Private Method
		private List<ReferenceType>? _reference;
private CodeableConcept? _role;

		#endregion
		#region public Method
		public List<ReferenceType>? Reference
{
get { return _reference; }
set {
_reference= value;
OnPropertyChanged("reference", value);
}
}

public CodeableConcept? Role
{
get { return _role; }
set {
_role= value;
OnPropertyChanged("role", value);
}
}


		#endregion
		#region Constructor
		public  ContractTermActionSubject() { }
		public  ContractTermActionSubject(string value) : base(value) { }
		public  ContractTermActionSubject(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ContractTermAction : BackboneElementType<ContractTermAction>, IBackboneElementType
	{

		#region Private Method
		private FhirBoolean? _doNotPerform;
private CodeableConcept? _type;
private List<ContractTermActionSubject>? _subject;
private CodeableConcept? _intent;
private List<FhirString>? _linkId;
private CodeableConcept? _status;
private ReferenceType? _context;
private List<FhirString>? _contextLinkId;
private ContractTermActionOccurrenceChoice? _occurrence;
private List<ReferenceType>? _requester;
private List<FhirString>? _requesterLinkId;
private List<CodeableConcept>? _performerType;
private CodeableConcept? _performerRole;
private ReferenceType? _performer;
private List<FhirString>? _performerLinkId;
private List<CodeableReference>? _reason;
private List<FhirString>? _reasonLinkId;
private List<Annotation>? _note;
private List<FhirUnsignedInt>? _securityLabelNumber;

		#endregion
		#region public Method
		public FhirBoolean? DoNotPerform
{
get { return _doNotPerform; }
set {
_doNotPerform= value;
OnPropertyChanged("doNotPerform", value);
}
}

public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public List<ContractTermActionSubject>? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
}
}

public CodeableConcept? Intent
{
get { return _intent; }
set {
_intent= value;
OnPropertyChanged("intent", value);
}
}

public List<FhirString>? LinkId
{
get { return _linkId; }
set {
_linkId= value;
OnPropertyChanged("linkId", value);
}
}

public CodeableConcept? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
}
}

public ReferenceType? Context
{
get { return _context; }
set {
_context= value;
OnPropertyChanged("context", value);
}
}

public List<FhirString>? ContextLinkId
{
get { return _contextLinkId; }
set {
_contextLinkId= value;
OnPropertyChanged("contextLinkId", value);
}
}

public ContractTermActionOccurrenceChoice? Occurrence
{
get { return _occurrence; }
set {
_occurrence= value;
OnPropertyChanged("occurrence", value);
}
}

public List<ReferenceType>? Requester
{
get { return _requester; }
set {
_requester= value;
OnPropertyChanged("requester", value);
}
}

public List<FhirString>? RequesterLinkId
{
get { return _requesterLinkId; }
set {
_requesterLinkId= value;
OnPropertyChanged("requesterLinkId", value);
}
}

public List<CodeableConcept>? PerformerType
{
get { return _performerType; }
set {
_performerType= value;
OnPropertyChanged("performerType", value);
}
}

public CodeableConcept? PerformerRole
{
get { return _performerRole; }
set {
_performerRole= value;
OnPropertyChanged("performerRole", value);
}
}

public ReferenceType? Performer
{
get { return _performer; }
set {
_performer= value;
OnPropertyChanged("performer", value);
}
}

public List<FhirString>? PerformerLinkId
{
get { return _performerLinkId; }
set {
_performerLinkId= value;
OnPropertyChanged("performerLinkId", value);
}
}

public List<CodeableReference>? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
}
}

public List<FhirString>? ReasonLinkId
{
get { return _reasonLinkId; }
set {
_reasonLinkId= value;
OnPropertyChanged("reasonLinkId", value);
}
}

public List<Annotation>? Note
{
get { return _note; }
set {
_note= value;
OnPropertyChanged("note", value);
}
}

public List<FhirUnsignedInt>? SecurityLabelNumber
{
get { return _securityLabelNumber; }
set {
_securityLabelNumber= value;
OnPropertyChanged("securityLabelNumber", value);
}
}


		#endregion
		#region Constructor
		public  ContractTermAction() { }
		public  ContractTermAction(string value) : base(value) { }
		public  ContractTermAction(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ContractTerm : BackboneElementType<ContractTerm>, IBackboneElementType
	{

		#region Private Method
		private Identifier? _identifier;
private FhirDateTime? _issued;
private Period? _applies;
private ContractTermTopicChoice? _topic;
private CodeableConcept? _type;
private CodeableConcept? _subType;
private List<ContractTermSecurityLabel>? _securityLabel;
private ContractTermOffer? _offer;
private List<ContractTermAsset>? _asset;
private List<ContractTermAction>? _action;

		#endregion
		#region public Method
		public Identifier? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
}
}

public FhirDateTime? Issued
{
get { return _issued; }
set {
_issued= value;
OnPropertyChanged("issued", value);
}
}

public Period? Applies
{
get { return _applies; }
set {
_applies= value;
OnPropertyChanged("applies", value);
}
}

public ContractTermTopicChoice? Topic
{
get { return _topic; }
set {
_topic= value;
OnPropertyChanged("topic", value);
}
}

public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public CodeableConcept? SubType
{
get { return _subType; }
set {
_subType= value;
OnPropertyChanged("subType", value);
}
}

public List<ContractTermSecurityLabel>? SecurityLabel
{
get { return _securityLabel; }
set {
_securityLabel= value;
OnPropertyChanged("securityLabel", value);
}
}

public ContractTermOffer? Offer
{
get { return _offer; }
set {
_offer= value;
OnPropertyChanged("offer", value);
}
}

public List<ContractTermAsset>? Asset
{
get { return _asset; }
set {
_asset= value;
OnPropertyChanged("asset", value);
}
}

public List<ContractTermAction>? Action
{
get { return _action; }
set {
_action= value;
OnPropertyChanged("action", value);
}
}


		#endregion
		#region Constructor
		public  ContractTerm() { }
		public  ContractTerm(string value) : base(value) { }
		public  ContractTerm(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ContractSigner : BackboneElementType<ContractSigner>, IBackboneElementType
	{

		#region Private Method
		private Coding? _type;
private ReferenceType? _party;
private List<Signature>? _signature;

		#endregion
		#region public Method
		public Coding? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public ReferenceType? Party
{
get { return _party; }
set {
_party= value;
OnPropertyChanged("party", value);
}
}

public List<Signature>? Signature
{
get { return _signature; }
set {
_signature= value;
OnPropertyChanged("signature", value);
}
}


		#endregion
		#region Constructor
		public  ContractSigner() { }
		public  ContractSigner(string value) : base(value) { }
		public  ContractSigner(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ContractFriendly : BackboneElementType<ContractFriendly>, IBackboneElementType
	{

		#region Private Method
		private ContractFriendlyContentChoice? _content;

		#endregion
		#region public Method
		public ContractFriendlyContentChoice? Content
{
get { return _content; }
set {
_content= value;
OnPropertyChanged("content", value);
}
}


		#endregion
		#region Constructor
		public  ContractFriendly() { }
		public  ContractFriendly(string value) : base(value) { }
		public  ContractFriendly(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ContractLegal : BackboneElementType<ContractLegal>, IBackboneElementType
	{

		#region Private Method
		private ContractLegalContentChoice? _content;

		#endregion
		#region public Method
		public ContractLegalContentChoice? Content
{
get { return _content; }
set {
_content= value;
OnPropertyChanged("content", value);
}
}


		#endregion
		#region Constructor
		public  ContractLegal() { }
		public  ContractLegal(string value) : base(value) { }
		public  ContractLegal(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ContractRule : BackboneElementType<ContractRule>, IBackboneElementType
	{

		#region Private Method
		private ContractRuleContentChoice? _content;

		#endregion
		#region public Method
		public ContractRuleContentChoice? Content
{
get { return _content; }
set {
_content= value;
OnPropertyChanged("content", value);
}
}


		#endregion
		#region Constructor
		public  ContractRule() { }
		public  ContractRule(string value) : base(value) { }
		public  ContractRule(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class ContractTopicChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","Reference(Resource)"
        ];

        public ContractTopicChoice(JsonObject value) : base("topic", value, _supportType)
        {
        }
        public ContractTopicChoice(IComplexType? value) : base("topic", value)
        {
        }
        public ContractTopicChoice(IPrimitiveType? value) : base("topic", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"topic".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ContractTermTopicChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","Reference(Resource)"
        ];

        public ContractTermTopicChoice(JsonObject value) : base("topic", value, _supportType)
        {
        }
        public ContractTermTopicChoice(IComplexType? value) : base("topic", value)
        {
        }
        public ContractTermTopicChoice(IPrimitiveType? value) : base("topic", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"topic".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ContractTermOfferAnswerValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "boolean","decimalintegerdatedateTimetimestringuriAttachmentCodingQuantityReference(Resource)"
        ];

        public ContractTermOfferAnswerValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public ContractTermOfferAnswerValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public ContractTermOfferAnswerValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ContractTermAssetValuedItemEntityChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","Reference(Resource)"
        ];

        public ContractTermAssetValuedItemEntityChoice(JsonObject value) : base("entity", value, _supportType)
        {
        }
        public ContractTermAssetValuedItemEntityChoice(IComplexType? value) : base("entity", value)
        {
        }
        public ContractTermAssetValuedItemEntityChoice(IPrimitiveType? value) : base("entity", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"entity".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ContractTermActionOccurrenceChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","PeriodTiming"
        ];

        public ContractTermActionOccurrenceChoice(JsonObject value) : base("occurrence", value, _supportType)
        {
        }
        public ContractTermActionOccurrenceChoice(IComplexType? value) : base("occurrence", value)
        {
        }
        public ContractTermActionOccurrenceChoice(IPrimitiveType? value) : base("occurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"occurrence".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ContractFriendlyContentChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Attachment","Reference(Composition|DocumentReference|QuestionnaireResponse)"
        ];

        public ContractFriendlyContentChoice(JsonObject value) : base("content", value, _supportType)
        {
        }
        public ContractFriendlyContentChoice(IComplexType? value) : base("content", value)
        {
        }
        public ContractFriendlyContentChoice(IPrimitiveType? value) : base("content", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"content".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ContractLegalContentChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Attachment","Reference(Composition|DocumentReference|QuestionnaireResponse)"
        ];

        public ContractLegalContentChoice(JsonObject value) : base("content", value, _supportType)
        {
        }
        public ContractLegalContentChoice(IComplexType? value) : base("content", value)
        {
        }
        public ContractLegalContentChoice(IPrimitiveType? value) : base("content", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"content".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ContractRuleContentChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Attachment","Reference(DocumentReference)"
        ];

        public ContractRuleContentChoice(JsonObject value) : base("content", value, _supportType)
        {
        }
        public ContractRuleContentChoice(IComplexType? value) : base("content", value)
        {
        }
        public ContractRuleContentChoice(IPrimitiveType? value) : base("content", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"content".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ContractLegallyBindingChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Attachment","Reference(Composition|DocumentReference|QuestionnaireResponse|Contract)"
        ];

        public ContractLegallyBindingChoice(JsonObject value) : base("legallyBinding", value, _supportType)
        {
        }
        public ContractLegallyBindingChoice(IComplexType? value) : base("legallyBinding", value)
        {
        }
        public ContractLegallyBindingChoice(IPrimitiveType? value) : base("legallyBinding", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"legallyBinding".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
