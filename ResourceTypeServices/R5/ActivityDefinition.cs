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
    public class ActivityDefinition : ResourceType<ActivityDefinition>
    {
        #region private Property
        private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private ActivityDefinitionVersionAlgorithmChoice? _versionAlgorithm;
        private FhirString? _name;
        private FhirString? _title;
        private FhirString? _subtitle;
        private FhirCode? _status;
        private FhirBoolean? _experimental;
        private ActivityDefinitionSubjectChoice? _subject;
        private FhirDateTime? _date;
        private FhirString? _publisher;
        private List<ContactDetail>? _contact;
        private FhirMarkdown? _description;
        private List<UsageContext>? _useContext;
        private List<CodeableConcept>? _jurisdiction;
        private FhirMarkdown? _purpose;
        private FhirMarkdown? _usage;
        private FhirMarkdown? _copyright;
        private FhirString? _copyrightLabel;
        private FhirDate? _approvalDate;
        private FhirDate? _lastReviewDate;
        private Period? _effectivePeriod;
        private List<CodeableConcept>? _topic;
        private List<ContactDetail>? _author;
        private List<ContactDetail>? _editor;
        private List<ContactDetail>? _reviewer;
        private List<ContactDetail>? _endorser;
        private List<RelatedArtifact>? _relatedArtifact;
        private List<FhirCanonical>? _library;
        private FhirCode? _kind;
        private FhirCanonical? _profile;
        private CodeableConcept? _code;
        private FhirCode? _intent;
        private FhirCode? _priority;
        private FhirBoolean? _doNotPerform;
        private ActivityDefinitionTimingChoice? _timing;
        private ActivityDefinitionAsNeededChoice? _asNeeded;
        private CodeableReference? _location;
        private List<ActivityDefinitionParticipant>? _participant;
        private ActivityDefinitionProductChoice? _product;
        private Quantity? _quantity;
        private List<Dosage>? _dosage;
        private List<CodeableConcept>? _bodySite;
        private List<FhirCanonical>? _specimenRequirement;
        private List<FhirCanonical>? _observationRequirement;
        private List<FhirCanonical>? _observationResultRequirement;
        private FhirCanonical? _transform;
        private List<ActivityDefinitionDynamicValue>? _dynamicValue;

        #endregion
        #region Public Method
        public FhirUri? Url
        {
            get { return _url; }
            set
            {
                _url = value;
                OnPropertyChanged("url", value);
            }
        }

        public List<Identifier>? Identifier
        {
            get { return _identifier; }
            set
            {
                _identifier = value;
                OnPropertyChanged("identifier", value);
            }
        }

        public FhirString? Version
        {
            get { return _version; }
            set
            {
                _version = value;
                OnPropertyChanged("version", value);
            }
        }

        public ActivityDefinitionVersionAlgorithmChoice? VersionAlgorithm
        {
            get { return _versionAlgorithm; }
            set
            {
                _versionAlgorithm = value;
                OnPropertyChanged("versionAlgorithm", value);
            }
        }

        public FhirString? Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("name", value);
            }
        }

        public FhirString? Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged("title", value);
            }
        }

        public FhirString? Subtitle
        {
            get { return _subtitle; }
            set
            {
                _subtitle = value;
                OnPropertyChanged("subtitle", value);
            }
        }

        public FhirCode? Status
        {
            get { return _status; }
            set
            {
                _status = value;
                OnPropertyChanged("status", value);
            }
        }

        public FhirBoolean? Experimental
        {
            get { return _experimental; }
            set
            {
                _experimental = value;
                OnPropertyChanged("experimental", value);
            }
        }

        public ActivityDefinitionSubjectChoice? Subject
        {
            get { return _subject; }
            set
            {
                _subject = value;
                OnPropertyChanged("subject", value);
            }
        }

        public FhirDateTime? Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged("date", value);
            }
        }

        public FhirString? Publisher
        {
            get { return _publisher; }
            set
            {
                _publisher = value;
                OnPropertyChanged("publisher", value);
            }
        }

        public List<ContactDetail>? Contact
        {
            get { return _contact; }
            set
            {
                _contact = value;
                OnPropertyChanged("contact", value);
            }
        }

        public FhirMarkdown? Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("description", value);
            }
        }

        public List<UsageContext>? UseContext
        {
            get { return _useContext; }
            set
            {
                _useContext = value;
                OnPropertyChanged("useContext", value);
            }
        }

        public List<CodeableConcept>? Jurisdiction
        {
            get { return _jurisdiction; }
            set
            {
                _jurisdiction = value;
                OnPropertyChanged("jurisdiction", value);
            }
        }

        public FhirMarkdown? Purpose
        {
            get { return _purpose; }
            set
            {
                _purpose = value;
                OnPropertyChanged("purpose", value);
            }
        }

        public FhirMarkdown? Usage
        {
            get { return _usage; }
            set
            {
                _usage = value;
                OnPropertyChanged("usage", value);
            }
        }

        public FhirMarkdown? Copyright
        {
            get { return _copyright; }
            set
            {
                _copyright = value;
                OnPropertyChanged("copyright", value);
            }
        }

        public FhirString? CopyrightLabel
        {
            get { return _copyrightLabel; }
            set
            {
                _copyrightLabel = value;
                OnPropertyChanged("copyrightLabel", value);
            }
        }

        public FhirDate? ApprovalDate
        {
            get { return _approvalDate; }
            set
            {
                _approvalDate = value;
                OnPropertyChanged("approvalDate", value);
            }
        }

        public FhirDate? LastReviewDate
        {
            get { return _lastReviewDate; }
            set
            {
                _lastReviewDate = value;
                OnPropertyChanged("lastReviewDate", value);
            }
        }

        public Period? EffectivePeriod
        {
            get { return _effectivePeriod; }
            set
            {
                _effectivePeriod = value;
                OnPropertyChanged("effectivePeriod", value);
            }
        }

        public List<CodeableConcept>? Topic
        {
            get { return _topic; }
            set
            {
                _topic = value;
                OnPropertyChanged("topic", value);
            }
        }

        public List<ContactDetail>? Author
        {
            get { return _author; }
            set
            {
                _author = value;
                OnPropertyChanged("author", value);
            }
        }

        public List<ContactDetail>? Editor
        {
            get { return _editor; }
            set
            {
                _editor = value;
                OnPropertyChanged("editor", value);
            }
        }

        public List<ContactDetail>? Reviewer
        {
            get { return _reviewer; }
            set
            {
                _reviewer = value;
                OnPropertyChanged("reviewer", value);
            }
        }

        public List<ContactDetail>? Endorser
        {
            get { return _endorser; }
            set
            {
                _endorser = value;
                OnPropertyChanged("endorser", value);
            }
        }

        public List<RelatedArtifact>? RelatedArtifact
        {
            get { return _relatedArtifact; }
            set
            {
                _relatedArtifact = value;
                OnPropertyChanged("relatedArtifact", value);
            }
        }

        public List<FhirCanonical>? Library
        {
            get { return _library; }
            set
            {
                _library = value;
                OnPropertyChanged("library", value);
            }
        }

        public FhirCode? Kind
        {
            get { return _kind; }
            set
            {
                _kind = value;
                OnPropertyChanged("kind", value);
            }
        }

        public FhirCanonical? Profile
        {
            get { return _profile; }
            set
            {
                _profile = value;
                OnPropertyChanged("profile", value);
            }
        }

        public CodeableConcept? Code
        {
            get { return _code; }
            set
            {
                _code = value;
                OnPropertyChanged("code", value);
            }
        }

        public FhirCode? Intent
        {
            get { return _intent; }
            set
            {
                _intent = value;
                OnPropertyChanged("intent", value);
            }
        }

        public FhirCode? Priority
        {
            get { return _priority; }
            set
            {
                _priority = value;
                OnPropertyChanged("priority", value);
            }
        }

        public FhirBoolean? DoNotPerform
        {
            get { return _doNotPerform; }
            set
            {
                _doNotPerform = value;
                OnPropertyChanged("doNotPerform", value);
            }
        }

        public ActivityDefinitionTimingChoice? Timing
        {
            get { return _timing; }
            set
            {
                _timing = value;
                OnPropertyChanged("timing", value);
            }
        }

        public ActivityDefinitionAsNeededChoice? AsNeeded
        {
            get { return _asNeeded; }
            set
            {
                _asNeeded = value;
                OnPropertyChanged("asNeeded", value);
            }
        }

        public CodeableReference? Location
        {
            get { return _location; }
            set
            {
                _location = value;
                OnPropertyChanged("location", value);
            }
        }

        public List<ActivityDefinitionParticipant>? Participant
        {
            get { return _participant; }
            set
            {
                _participant = value;
                OnPropertyChanged("participant", value);
            }
        }

        public ActivityDefinitionProductChoice? Product
        {
            get { return _product; }
            set
            {
                _product = value;
                OnPropertyChanged("product", value);
            }
        }

        public Quantity? Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                OnPropertyChanged("quantity", value);
            }
        }

        public List<Dosage>? Dosage
        {
            get { return _dosage; }
            set
            {
                _dosage = value;
                OnPropertyChanged("dosage", value);
            }
        }

        public List<CodeableConcept>? BodySite
        {
            get { return _bodySite; }
            set
            {
                _bodySite = value;
                OnPropertyChanged("bodySite", value);
            }
        }

        public List<FhirCanonical>? SpecimenRequirement
        {
            get { return _specimenRequirement; }
            set
            {
                _specimenRequirement = value;
                OnPropertyChanged("specimenRequirement", value);
            }
        }

        public List<FhirCanonical>? ObservationRequirement
        {
            get { return _observationRequirement; }
            set
            {
                _observationRequirement = value;
                OnPropertyChanged("observationRequirement", value);
            }
        }

        public List<FhirCanonical>? ObservationResultRequirement
        {
            get { return _observationResultRequirement; }
            set
            {
                _observationResultRequirement = value;
                OnPropertyChanged("observationResultRequirement", value);
            }
        }

        public FhirCanonical? Transform
        {
            get { return _transform; }
            set
            {
                _transform = value;
                OnPropertyChanged("transform", value);
            }
        }

        public List<ActivityDefinitionDynamicValue>? DynamicValue
        {
            get { return _dynamicValue; }
            set
            {
                _dynamicValue = value;
                OnPropertyChanged("dynamicValue", value);
            }
        }


        #endregion
        #region Constructor
        public ActivityDefinition() { }
        public ActivityDefinition(string value) : base(value) { }
        public ActivityDefinition(JsonNode? source) : base(source) { }
        #endregion
    }
    public class ActivityDefinitionParticipant : BackboneElementType<ActivityDefinitionParticipant>, IBackboneElementType
    {

        #region Private Method
        private FhirCode? _type;
        private FhirCanonical? _typeCanonical;
        private ReferenceType? _typeReference;
        private CodeableConcept? _role;
        private CodeableConcept? _function;

        #endregion
        #region public Method
        public FhirCode? Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("type", value);
            }
        }

        public FhirCanonical? TypeCanonical
        {
            get { return _typeCanonical; }
            set
            {
                _typeCanonical = value;
                OnPropertyChanged("typeCanonical", value);
            }
        }

        public ReferenceType? TypeReference
        {
            get { return _typeReference; }
            set
            {
                _typeReference = value;
                OnPropertyChanged("typeReference", value);
            }
        }

        public CodeableConcept? Role
        {
            get { return _role; }
            set
            {
                _role = value;
                OnPropertyChanged("role", value);
            }
        }

        public CodeableConcept? Function
        {
            get { return _function; }
            set
            {
                _function = value;
                OnPropertyChanged("function", value);
            }
        }


        #endregion
        #region Constructor
        public ActivityDefinitionParticipant() { }
        public ActivityDefinitionParticipant(string value) : base(value) { }
        public ActivityDefinitionParticipant(JsonObject? source) : base(source) { }
        #endregion
    }

    public class ActivityDefinitionDynamicValue : BackboneElementType<ActivityDefinitionDynamicValue>, IBackboneElementType
    {

        #region Private Method
        private FhirString? _path;
        private ExpressionType? _expression;

        #endregion
        #region public Method
        public FhirString? Path
        {
            get { return _path; }
            set
            {
                _path = value;
                OnPropertyChanged("path", value);
            }
        }

        public ExpressionType? Expression
        {
            get { return _expression; }
            set
            {
                _expression = value;
                OnPropertyChanged("expression", value);
            }
        }


        #endregion
        #region Constructor
        public ActivityDefinitionDynamicValue() { }
        public ActivityDefinitionDynamicValue(string value) : base(value) { }
        public ActivityDefinitionDynamicValue(JsonObject? source) : base(source) { }
        #endregion
    }



    public class ActivityDefinitionVersionAlgorithmChoice : ChoiceType
    {

        private static readonly List<string> _supportType = [
        "string","Coding"
        ];
        public ActivityDefinitionVersionAlgorithmChoice(string dataType, JsonValue? value) : base(dataType, value)
        {
        }
        public ActivityDefinitionVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public ActivityDefinitionVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public ActivityDefinitionVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => "versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return _supportType;
        }
    }
    public class ActivityDefinitionSubjectChoice : ChoiceType
    {

        private static readonly List<string> _supportType = [
        "CodeableConcept","Reference(Group|MedicinalProductDefinition|SubstanceDefinition|AdministrableProductDefinition|ManufacturedItemDefinition|PackagedProductDefinition)canonical(EvidenceVariable)"
        ];
        public ActivityDefinitionSubjectChoice(string dataType, JsonValue? value) : base(dataType, value) { }
        public ActivityDefinitionSubjectChoice(JsonObject value) : base("subject", value, _supportType)
        {
        }
        public ActivityDefinitionSubjectChoice(IComplexType? value) : base("subject", value)
        {
        }
        public ActivityDefinitionSubjectChoice(IPrimitiveType? value) : base("subject", value) { }

        public override string GetPrefixName(bool withCapital = true) => "subject".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return _supportType;
        }
    }
    public class ActivityDefinitionTimingChoice : ChoiceType
    {

        private static readonly List<string> _supportType = [
        "Timing","AgeRangeDuration"
        ];
        public ActivityDefinitionTimingChoice(string dataType, JsonValue? value) : base(dataType, value) { }
        public ActivityDefinitionTimingChoice(JsonObject value) : base("timing", value, _supportType)
        {
        }
        public ActivityDefinitionTimingChoice(IComplexType? value) : base("timing", value)
        {
        }
        public ActivityDefinitionTimingChoice(IPrimitiveType? value) : base("timing", value) { }

        public override string GetPrefixName(bool withCapital = true) => "timing".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return _supportType;
        }
    }
    public class ActivityDefinitionAsNeededChoice : ChoiceType
    {

        private static readonly List<string> _supportType = [
        "boolean","CodeableConcept"
        ];
        public ActivityDefinitionAsNeededChoice(string dataType, JsonValue? value) : base(dataType, value) { }

        public ActivityDefinitionAsNeededChoice(JsonObject value) : base("asNeeded", value, _supportType)
        {
        }
        public ActivityDefinitionAsNeededChoice(IComplexType? value) : base("asNeeded", value)
        {
        }
        public ActivityDefinitionAsNeededChoice(IPrimitiveType? value) : base("asNeeded", value) { }

        public override string GetPrefixName(bool withCapital = true) => "asNeeded".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return _supportType;
        }
    }
    public class ActivityDefinitionProductChoice : ChoiceType
    {

        private static readonly List<string> _supportType = [
        "Reference(Medication|Ingredient|Substance|SubstanceDefinition)","CodeableConcept"
        ];
         public ActivityDefinitionProductChoice(string dataType, JsonValue? value) : base(dataType, value) { }
        public ActivityDefinitionProductChoice(JsonObject value) : base("product", value, _supportType)
        {
        }
        public ActivityDefinitionProductChoice(IComplexType? value) : base("product", value)
        {
        }
        public ActivityDefinitionProductChoice(IPrimitiveType? value) : base("product", value) { }

        public override string GetPrefixName(bool withCapital = true) => "product".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return _supportType;
        }
    }


}
