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
    public class ActorDefinition : ResourceType<ActorDefinition>
    {
        #region private Property
        private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private ActorDefinitionVersionAlgorithmChoice? _versionAlgorithm;
        private FhirString? _name;
        private FhirString? _title;
        private FhirCode? _status;
        private FhirBoolean? _experimental;
        private FhirDateTime? _date;
        private FhirString? _publisher;
        private List<ContactDetail>? _contact;
        private FhirMarkdown? _description;
        private List<UsageContext>? _useContext;
        private List<CodeableConcept>? _jurisdiction;
        private FhirMarkdown? _purpose;
        private FhirMarkdown? _copyright;
        private FhirString? _copyrightLabel;
        private FhirCode? _type;
        private FhirMarkdown? _documentation;
        private List<FhirUrl>? _reference;
        private FhirCanonical? _capabilities;
        private List<FhirCanonical>? _derivedFrom;

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

        public ActorDefinitionVersionAlgorithmChoice? VersionAlgorithm
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

        public FhirCode? Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("type", value);
            }
        }

        public FhirMarkdown? Documentation
        {
            get { return _documentation; }
            set
            {
                _documentation = value;
                OnPropertyChanged("documentation", value);
            }
        }

        public List<FhirUrl>? Reference
        {
            get { return _reference; }
            set
            {
                _reference = value;
                OnPropertyChanged("reference", value);
            }
        }

        public FhirCanonical? Capabilities
        {
            get { return _capabilities; }
            set
            {
                _capabilities = value;
                OnPropertyChanged("capabilities", value);
            }
        }

        public List<FhirCanonical>? DerivedFrom
        {
            get { return _derivedFrom; }
            set
            {
                _derivedFrom = value;
                OnPropertyChanged("derivedFrom", value);
            }
        }


        #endregion
        #region Constructor
        public ActorDefinition() { }
        public ActorDefinition(string value) : base(value) { }
        public ActorDefinition(JsonNode? source) : base(source) { }
        #endregion
    }


    public class ActorDefinitionVersionAlgorithmChoice : ChoiceType
    {

        private static readonly List<string> _supportType = [
        "string","Coding"
        ];
        public ActorDefinitionVersionAlgorithmChoice(string dataType, JsonValue? value) : base(dataType, value) { }
        public ActorDefinitionVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public ActorDefinitionVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public ActorDefinitionVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => "versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return _supportType;
        }
    }


}
