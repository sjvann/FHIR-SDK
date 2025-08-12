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
    /// FHIR R5 ActivityDefinition 資源
    /// 
    /// <para>
    /// ActivityDefinition 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var activitydefinition = new ActivityDefinition("activitydefinition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 ActivityDefinition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ActivityDefinition : ResourceBase<R5Version>
    {
        private Property
        private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private ActivityDefinitionVersionAlgorithmChoice? _versionalgorithm;
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
        private List<UsageContext>? _usecontext;
        private List<CodeableConcept>? _jurisdiction;
        private FhirMarkdown? _purpose;
        private FhirMarkdown? _usage;
        private FhirMarkdown? _copyright;
        private FhirString? _copyrightlabel;
        private FhirDate? _approvaldate;
        private FhirDate? _lastreviewdate;
        private Period? _effectiveperiod;
        private List<CodeableConcept>? _topic;
        private List<ContactDetail>? _author;
        private List<ContactDetail>? _editor;
        private List<ContactDetail>? _reviewer;
        private List<ContactDetail>? _endorser;
        private List<RelatedArtifact>? _relatedartifact;
        private List<FhirCanonical>? _library;
        private FhirCode? _kind;
        private FhirCanonical? _profile;
        private CodeableConcept? _code;
        private FhirCode? _intent;
        private FhirCode? _priority;
        private FhirBoolean? _donotperform;
        private ActivityDefinitionTimingChoice? _timing;
        private ActivityDefinitionAsNeededChoice? _asneeded;
        private CodeableReference? _location;
        private List<ActivityDefinitionParticipant>? _participant;
        private ActivityDefinitionProductChoice? _product;
        private Quantity? _quantity;
        private List<Dosage>? _dosage;
        private List<CodeableConcept>? _bodysite;
        private List<FhirCanonical>? _specimenrequirement;
        private List<FhirCanonical>? _observationrequirement;
        private List<FhirCanonical>? _observationresultrequirement;
        private FhirCanonical? _transform;
        private List<ActivityDefinitionDynamicValue>? _dynamicvalue;
        private FhirCode? _type;
        private FhirCanonical? _typecanonical;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _typereference;
        private CodeableConcept? _role;
        private CodeableConcept? _function;
        private FhirString? _path;
        private ExpressionType? _expression;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ActivityDefinition";        /// <summary>
        /// Url
        /// </summary>
        /// <remarks>
        /// <para>
        /// Url 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
        private FhirUri? Url
        {
            get => _url;
            set
            {
                _url = value;
                OnPropertyChanged(nameof(Url));
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
        /// Versionalgorithm
        /// </summary>
        /// <remarks>
        /// <para>
        /// Versionalgorithm 的詳細描述。
        /// </para>
        /// </remarks>
        public ActivityDefinitionVersionAlgorithmChoice? Versionalgorithm
        {
            get => _versionalgorithm;
            set
            {
                _versionalgorithm = value;
                OnPropertyChanged(nameof(Versionalgorithm));
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
        /// Experimental
        /// </summary>
        /// <remarks>
        /// <para>
        /// Experimental 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Experimental
        {
            get => _experimental;
            set
            {
                _experimental = value;
                OnPropertyChanged(nameof(Experimental));
            }
        }        /// <summary>
        /// Subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject 的詳細描述。
        /// </para>
        /// </remarks>
        public ActivityDefinitionSubjectChoice? Subject
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
        public FhirDateTime? Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }        /// <summary>
        /// Publisher
        /// </summary>
        /// <remarks>
        /// <para>
        /// Publisher 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Publisher
        {
            get => _publisher;
            set
            {
                _publisher = value;
                OnPropertyChanged(nameof(Publisher));
            }
        }        /// <summary>
        /// Contact
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactDetail>? Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
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
        /// Usecontext
        /// </summary>
        /// <remarks>
        /// <para>
        /// Usecontext 的詳細描述。
        /// </para>
        /// </remarks>
        public List<UsageContext>? Usecontext
        {
            get => _usecontext;
            set
            {
                _usecontext = value;
                OnPropertyChanged(nameof(Usecontext));
            }
        }        /// <summary>
        /// Jurisdiction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Jurisdiction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Jurisdiction
        {
            get => _jurisdiction;
            set
            {
                _jurisdiction = value;
                OnPropertyChanged(nameof(Jurisdiction));
            }
        }        /// <summary>
        /// Purpose
        /// </summary>
        /// <remarks>
        /// <para>
        /// Purpose 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Purpose
        {
            get => _purpose;
            set
            {
                _purpose = value;
                OnPropertyChanged(nameof(Purpose));
            }
        }        /// <summary>
        /// Usage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Usage 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Usage
        {
            get => _usage;
            set
            {
                _usage = value;
                OnPropertyChanged(nameof(Usage));
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
        /// Copyrightlabel
        /// </summary>
        /// <remarks>
        /// <para>
        /// Copyrightlabel 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Copyrightlabel
        {
            get => _copyrightlabel;
            set
            {
                _copyrightlabel = value;
                OnPropertyChanged(nameof(Copyrightlabel));
            }
        }        /// <summary>
        /// Approvaldate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Approvaldate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Approvaldate
        {
            get => _approvaldate;
            set
            {
                _approvaldate = value;
                OnPropertyChanged(nameof(Approvaldate));
            }
        }        /// <summary>
        /// Lastreviewdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Lastreviewdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Lastreviewdate
        {
            get => _lastreviewdate;
            set
            {
                _lastreviewdate = value;
                OnPropertyChanged(nameof(Lastreviewdate));
            }
        }        /// <summary>
        /// Effectiveperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Effectiveperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Effectiveperiod
        {
            get => _effectiveperiod;
            set
            {
                _effectiveperiod = value;
                OnPropertyChanged(nameof(Effectiveperiod));
            }
        }        /// <summary>
        /// Topic
        /// </summary>
        /// <remarks>
        /// <para>
        /// Topic 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Topic
        {
            get => _topic;
            set
            {
                _topic = value;
                OnPropertyChanged(nameof(Topic));
            }
        }        /// <summary>
        /// Author
        /// </summary>
        /// <remarks>
        /// <para>
        /// Author 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactDetail>? Author
        {
            get => _author;
            set
            {
                _author = value;
                OnPropertyChanged(nameof(Author));
            }
        }        /// <summary>
        /// Editor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Editor 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactDetail>? Editor
        {
            get => _editor;
            set
            {
                _editor = value;
                OnPropertyChanged(nameof(Editor));
            }
        }        /// <summary>
        /// Reviewer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reviewer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactDetail>? Reviewer
        {
            get => _reviewer;
            set
            {
                _reviewer = value;
                OnPropertyChanged(nameof(Reviewer));
            }
        }        /// <summary>
        /// Endorser
        /// </summary>
        /// <remarks>
        /// <para>
        /// Endorser 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactDetail>? Endorser
        {
            get => _endorser;
            set
            {
                _endorser = value;
                OnPropertyChanged(nameof(Endorser));
            }
        }        /// <summary>
        /// Relatedartifact
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relatedartifact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<RelatedArtifact>? Relatedartifact
        {
            get => _relatedartifact;
            set
            {
                _relatedartifact = value;
                OnPropertyChanged(nameof(Relatedartifact));
            }
        }        /// <summary>
        /// Library
        /// </summary>
        /// <remarks>
        /// <para>
        /// Library 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Library
        {
            get => _library;
            set
            {
                _library = value;
                OnPropertyChanged(nameof(Library));
            }
        }        /// <summary>
        /// Kind
        /// </summary>
        /// <remarks>
        /// <para>
        /// Kind 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Kind
        {
            get => _kind;
            set
            {
                _kind = value;
                OnPropertyChanged(nameof(Kind));
            }
        }        /// <summary>
        /// Profile
        /// </summary>
        /// <remarks>
        /// <para>
        /// Profile 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Profile
        {
            get => _profile;
            set
            {
                _profile = value;
                OnPropertyChanged(nameof(Profile));
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
        /// Intent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Intent 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Intent
        {
            get => _intent;
            set
            {
                _intent = value;
                OnPropertyChanged(nameof(Intent));
            }
        }        /// <summary>
        /// Priority
        /// </summary>
        /// <remarks>
        /// <para>
        /// Priority 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(Priority));
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
        /// Timing
        /// </summary>
        /// <remarks>
        /// <para>
        /// Timing 的詳細描述。
        /// </para>
        /// </remarks>
        public ActivityDefinitionTimingChoice? Timing
        {
            get => _timing;
            set
            {
                _timing = value;
                OnPropertyChanged(nameof(Timing));
            }
        }        /// <summary>
        /// Asneeded
        /// </summary>
        /// <remarks>
        /// <para>
        /// Asneeded 的詳細描述。
        /// </para>
        /// </remarks>
        public ActivityDefinitionAsNeededChoice? Asneeded
        {
            get => _asneeded;
            set
            {
                _asneeded = value;
                OnPropertyChanged(nameof(Asneeded));
            }
        }        /// <summary>
        /// Location
        /// </summary>
        /// <remarks>
        /// <para>
        /// Location 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }        /// <summary>
        /// Participant
        /// </summary>
        /// <remarks>
        /// <para>
        /// Participant 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ActivityDefinitionParticipant>? Participant
        {
            get => _participant;
            set
            {
                _participant = value;
                OnPropertyChanged(nameof(Participant));
            }
        }        /// <summary>
        /// Product
        /// </summary>
        /// <remarks>
        /// <para>
        /// Product 的詳細描述。
        /// </para>
        /// </remarks>
        public ActivityDefinitionProductChoice? Product
        {
            get => _product;
            set
            {
                _product = value;
                OnPropertyChanged(nameof(Product));
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
        /// Dosage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dosage 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Dosage>? Dosage
        {
            get => _dosage;
            set
            {
                _dosage = value;
                OnPropertyChanged(nameof(Dosage));
            }
        }        /// <summary>
        /// Bodysite
        /// </summary>
        /// <remarks>
        /// <para>
        /// Bodysite 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Bodysite
        {
            get => _bodysite;
            set
            {
                _bodysite = value;
                OnPropertyChanged(nameof(Bodysite));
            }
        }        /// <summary>
        /// Specimenrequirement
        /// </summary>
        /// <remarks>
        /// <para>
        /// Specimenrequirement 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Specimenrequirement
        {
            get => _specimenrequirement;
            set
            {
                _specimenrequirement = value;
                OnPropertyChanged(nameof(Specimenrequirement));
            }
        }        /// <summary>
        /// Observationrequirement
        /// </summary>
        /// <remarks>
        /// <para>
        /// Observationrequirement 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Observationrequirement
        {
            get => _observationrequirement;
            set
            {
                _observationrequirement = value;
                OnPropertyChanged(nameof(Observationrequirement));
            }
        }        /// <summary>
        /// Observationresultrequirement
        /// </summary>
        /// <remarks>
        /// <para>
        /// Observationresultrequirement 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Observationresultrequirement
        {
            get => _observationresultrequirement;
            set
            {
                _observationresultrequirement = value;
                OnPropertyChanged(nameof(Observationresultrequirement));
            }
        }        /// <summary>
        /// Transform
        /// </summary>
        /// <remarks>
        /// <para>
        /// Transform 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Transform
        {
            get => _transform;
            set
            {
                _transform = value;
                OnPropertyChanged(nameof(Transform));
            }
        }        /// <summary>
        /// Dynamicvalue
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dynamicvalue 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ActivityDefinitionDynamicValue>? Dynamicvalue
        {
            get => _dynamicvalue;
            set
            {
                _dynamicvalue = value;
                OnPropertyChanged(nameof(Dynamicvalue));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Typecanonical
        /// </summary>
        /// <remarks>
        /// <para>
        /// Typecanonical 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Typecanonical
        {
            get => _typecanonical;
            set
            {
                _typecanonical = value;
                OnPropertyChanged(nameof(Typecanonical));
            }
        }        /// <summary>
        /// Typereference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Typereference 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Typereference
        {
            get => _typereference;
            set
            {
                _typereference = value;
                OnPropertyChanged(nameof(Typereference));
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
        /// Function
        /// </summary>
        /// <remarks>
        /// <para>
        /// Function 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Function
        {
            get => _function;
            set
            {
                _function = value;
                OnPropertyChanged(nameof(Function));
            }
        }        /// <summary>
        /// Path
        /// </summary>
        /// <remarks>
        /// <para>
        /// Path 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Path
        {
            get => _path;
            set
            {
                _path = value;
                OnPropertyChanged(nameof(Path));
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
        /// 建立新的 ActivityDefinition 資源實例
        /// </summary>
        public ActivityDefinition()
        {
        }

        /// <summary>
        /// 建立新的 ActivityDefinition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ActivityDefinition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ActivityDefinition(Id: {Id})";
        }
    }    /// <summary>
    /// ActivityDefinitionParticipant 背骨元素
    /// </summary>
    public class ActivityDefinitionParticipant
    {
        // TODO: 添加屬性實作
        
        public ActivityDefinitionParticipant() { }
    }    /// <summary>
    /// ActivityDefinitionDynamicValue 背骨元素
    /// </summary>
    public class ActivityDefinitionDynamicValue
    {
        // TODO: 添加屬性實作
        
        public ActivityDefinitionDynamicValue() { }
    }    /// <summary>
    /// ActivityDefinitionVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class ActivityDefinitionVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ActivityDefinitionVersionAlgorithmChoice(JsonObject value) : base("activitydefinitionversionalgorithm", value, _supportType) { }
        public ActivityDefinitionVersionAlgorithmChoice(IComplexType? value) : base("activitydefinitionversionalgorithm", value) { }
        public ActivityDefinitionVersionAlgorithmChoice(IPrimitiveType? value) : base("activitydefinitionversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ActivityDefinitionVersionAlgorithm" : "activitydefinitionversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ActivityDefinitionSubjectChoice 選擇類型
    /// </summary>
    public class ActivityDefinitionSubjectChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ActivityDefinitionSubjectChoice(JsonObject value) : base("activitydefinitionsubject", value, _supportType) { }
        public ActivityDefinitionSubjectChoice(IComplexType? value) : base("activitydefinitionsubject", value) { }
        public ActivityDefinitionSubjectChoice(IPrimitiveType? value) : base("activitydefinitionsubject", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ActivityDefinitionSubject" : "activitydefinitionsubject";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ActivityDefinitionTimingChoice 選擇類型
    /// </summary>
    public class ActivityDefinitionTimingChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ActivityDefinitionTimingChoice(JsonObject value) : base("activitydefinitiontiming", value, _supportType) { }
        public ActivityDefinitionTimingChoice(IComplexType? value) : base("activitydefinitiontiming", value) { }
        public ActivityDefinitionTimingChoice(IPrimitiveType? value) : base("activitydefinitiontiming", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ActivityDefinitionTiming" : "activitydefinitiontiming";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ActivityDefinitionAsNeededChoice 選擇類型
    /// </summary>
    public class ActivityDefinitionAsNeededChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ActivityDefinitionAsNeededChoice(JsonObject value) : base("activitydefinitionasneeded", value, _supportType) { }
        public ActivityDefinitionAsNeededChoice(IComplexType? value) : base("activitydefinitionasneeded", value) { }
        public ActivityDefinitionAsNeededChoice(IPrimitiveType? value) : base("activitydefinitionasneeded", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ActivityDefinitionAsNeeded" : "activitydefinitionasneeded";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ActivityDefinitionProductChoice 選擇類型
    /// </summary>
    public class ActivityDefinitionProductChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ActivityDefinitionProductChoice(JsonObject value) : base("activitydefinitionproduct", value, _supportType) { }
        public ActivityDefinitionProductChoice(IComplexType? value) : base("activitydefinitionproduct", value) { }
        public ActivityDefinitionProductChoice(IPrimitiveType? value) : base("activitydefinitionproduct", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ActivityDefinitionProduct" : "activitydefinitionproduct";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
