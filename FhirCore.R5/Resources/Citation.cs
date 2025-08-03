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
    /// FHIR R5 Citation 資源
    /// 
    /// <para>
    /// Citation 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var citation = new Citation("citation-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Citation 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Citation : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private CitationVersionAlgorithmChoice? _versionalgorithm;
        private FhirString? _name;
        private FhirString? _title;
        private FhirCode? _status;
        private FhirBoolean? _experimental;
        private FhirDateTime? _date;
        private FhirString? _publisher;
        private List<ContactDetail>? _contact;
        private FhirMarkdown? _description;
        private List<UsageContext>? _usecontext;
        private List<CodeableConcept>? _jurisdiction;
        private FhirMarkdown? _purpose;
        private FhirMarkdown? _copyright;
        private FhirString? _copyrightlabel;
        private FhirDate? _approvaldate;
        private FhirDate? _lastreviewdate;
        private Period? _effectiveperiod;
        private List<ContactDetail>? _author;
        private List<ContactDetail>? _editor;
        private List<ContactDetail>? _reviewer;
        private List<ContactDetail>? _endorser;
        private List<CitationSummary>? _summary;
        private List<CitationClassification>? _classification;
        private List<Annotation>? _note;
        private List<CodeableConcept>? _currentstate;
        private List<CitationStatusDate>? _statusdate;
        private List<RelatedArtifact>? _relatedartifact;
        private CitationCitedArtifact? _citedartifact;
        private CodeableConcept? _style;
        private CodeableConcept? _type;
        private List<CodeableConcept>? _classifier;
        private CodeableConcept? _activity;
        private FhirBoolean? _actual;
        private Period? _period;
        private FhirString? _value;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _basecitation;
        private CodeableConcept? _activity;
        private FhirBoolean? _actual;
        private Period? _period;
        private List<CodeableConcept>? _type;
        private CodeableConcept? _language;
        private CodeableConcept? _type;
        private CodeableConcept? _language;
        private FhirMarkdown? _copyright;
        private CodeableConcept? _type;
        private FhirString? _value;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _basecitation;
        private FhirCode? _type;
        private List<CodeableConcept>? _classifier;
        private FhirString? _label;
        private FhirString? _display;
        private FhirMarkdown? _citation;
        private Attachment? _document;
        private FhirCanonical? _resource;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _resourcereference;
        private CodeableConcept? _type;
        private List<Identifier>? _identifier;
        private FhirString? _title;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _publisher;
        private FhirString? _publisherlocation;
        private CitationCitedArtifactPublicationFormPublishedIn? _publishedin;
        private CodeableConcept? _citedmedium;
        private FhirString? _volume;
        private FhirString? _issue;
        private FhirDateTime? _articledate;
        private FhirString? _publicationdatetext;
        private FhirString? _publicationdateseason;
        private FhirDateTime? _lastrevisiondate;
        private List<CodeableConcept>? _language;
        private FhirString? _accessionnumber;
        private FhirString? _pagestring;
        private FhirString? _firstpage;
        private FhirString? _lastpage;
        private FhirString? _pagecount;
        private FhirMarkdown? _copyright;
        private List<CodeableConcept>? _classifier;
        private FhirUri? _url;
        private CodeableConcept? _type;
        private List<CodeableConcept>? _classifier;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _artifactassessment;
        private CodeableConcept? _type;
        private FhirDateTime? _time;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _contributor;
        private FhirString? _forenameinitials;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _affiliation;
        private List<CodeableConcept>? _contributiontype;
        private CodeableConcept? _role;
        private List<CitationCitedArtifactContributorshipEntryContributionInstance>? _contributioninstance;
        private FhirBoolean? _correspondingcontact;
        private FhirPositiveInt? _rankingorder;
        private CodeableConcept? _type;
        private CodeableConcept? _style;
        private CodeableConcept? _source;
        private FhirMarkdown? _value;
        private FhirBoolean? _complete;
        private List<CitationCitedArtifactContributorshipEntry>? _entry;
        private List<CitationCitedArtifactContributorshipSummary>? _summary;
        private List<Identifier>? _identifier;
        private List<Identifier>? _relatedidentifier;
        private FhirDateTime? _dateaccessed;
        private CitationCitedArtifactVersion? _version;
        private List<CodeableConcept>? _currentstate;
        private List<CitationCitedArtifactStatusDate>? _statusdate;
        private List<CitationCitedArtifactTitle>? _title;
        private List<CitationCitedArtifactAbstract>? _abstract;
        private CitationCitedArtifactPart? _part;
        private List<CitationCitedArtifactRelatesTo>? _relatesto;
        private List<CitationCitedArtifactPublicationForm>? _publicationform;
        private List<CitationCitedArtifactWebLocation>? _weblocation;
        private List<CitationCitedArtifactClassification>? _classification;
        private CitationCitedArtifactContributorship? _contributorship;
        private List<Annotation>? _note;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Citation";        /// <summary>
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
        public CitationVersionAlgorithmChoice? Versionalgorithm
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
        /// Summary
        /// </summary>
        /// <remarks>
        /// <para>
        /// Summary 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CitationSummary>? Summary
        {
            get => _summary;
            set
            {
                _summary = value;
                OnPropertyChanged(nameof(Summary));
            }
        }        /// <summary>
        /// Classification
        /// </summary>
        /// <remarks>
        /// <para>
        /// Classification 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CitationClassification>? Classification
        {
            get => _classification;
            set
            {
                _classification = value;
                OnPropertyChanged(nameof(Classification));
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
        /// Currentstate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Currentstate 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Currentstate
        {
            get => _currentstate;
            set
            {
                _currentstate = value;
                OnPropertyChanged(nameof(Currentstate));
            }
        }        /// <summary>
        /// Statusdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Statusdate 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CitationStatusDate>? Statusdate
        {
            get => _statusdate;
            set
            {
                _statusdate = value;
                OnPropertyChanged(nameof(Statusdate));
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
        /// Citedartifact
        /// </summary>
        /// <remarks>
        /// <para>
        /// Citedartifact 的詳細描述。
        /// </para>
        /// </remarks>
        public CitationCitedArtifact? Citedartifact
        {
            get => _citedartifact;
            set
            {
                _citedartifact = value;
                OnPropertyChanged(nameof(Citedartifact));
            }
        }        /// <summary>
        /// Style
        /// </summary>
        /// <remarks>
        /// <para>
        /// Style 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Style
        {
            get => _style;
            set
            {
                _style = value;
                OnPropertyChanged(nameof(Style));
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
        /// Classifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Classifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Classifier
        {
            get => _classifier;
            set
            {
                _classifier = value;
                OnPropertyChanged(nameof(Classifier));
            }
        }        /// <summary>
        /// Activity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Activity 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Activity
        {
            get => _activity;
            set
            {
                _activity = value;
                OnPropertyChanged(nameof(Activity));
            }
        }        /// <summary>
        /// Actual
        /// </summary>
        /// <remarks>
        /// <para>
        /// Actual 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Actual
        {
            get => _actual;
            set
            {
                _actual = value;
                OnPropertyChanged(nameof(Actual));
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
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Basecitation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Basecitation 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Basecitation
        {
            get => _basecitation;
            set
            {
                _basecitation = value;
                OnPropertyChanged(nameof(Basecitation));
            }
        }        /// <summary>
        /// Activity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Activity 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Activity
        {
            get => _activity;
            set
            {
                _activity = value;
                OnPropertyChanged(nameof(Activity));
            }
        }        /// <summary>
        /// Actual
        /// </summary>
        /// <remarks>
        /// <para>
        /// Actual 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Actual
        {
            get => _actual;
            set
            {
                _actual = value;
                OnPropertyChanged(nameof(Actual));
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
        /// Language
        /// </summary>
        /// <remarks>
        /// <para>
        /// Language 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Language
        {
            get => _language;
            set
            {
                _language = value;
                OnPropertyChanged(nameof(Language));
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
        /// Language
        /// </summary>
        /// <remarks>
        /// <para>
        /// Language 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Language
        {
            get => _language;
            set
            {
                _language = value;
                OnPropertyChanged(nameof(Language));
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
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Basecitation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Basecitation 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Basecitation
        {
            get => _basecitation;
            set
            {
                _basecitation = value;
                OnPropertyChanged(nameof(Basecitation));
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
        /// Classifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Classifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Classifier
        {
            get => _classifier;
            set
            {
                _classifier = value;
                OnPropertyChanged(nameof(Classifier));
            }
        }        /// <summary>
        /// Label
        /// </summary>
        /// <remarks>
        /// <para>
        /// Label 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Label
        {
            get => _label;
            set
            {
                _label = value;
                OnPropertyChanged(nameof(Label));
            }
        }        /// <summary>
        /// Display
        /// </summary>
        /// <remarks>
        /// <para>
        /// Display 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Display
        {
            get => _display;
            set
            {
                _display = value;
                OnPropertyChanged(nameof(Display));
            }
        }        /// <summary>
        /// Citation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Citation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Citation
        {
            get => _citation;
            set
            {
                _citation = value;
                OnPropertyChanged(nameof(Citation));
            }
        }        /// <summary>
        /// Document
        /// </summary>
        /// <remarks>
        /// <para>
        /// Document 的詳細描述。
        /// </para>
        /// </remarks>
        public Attachment? Document
        {
            get => _document;
            set
            {
                _document = value;
                OnPropertyChanged(nameof(Document));
            }
        }        /// <summary>
        /// Resource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resource 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Resource
        {
            get => _resource;
            set
            {
                _resource = value;
                OnPropertyChanged(nameof(Resource));
            }
        }        /// <summary>
        /// Resourcereference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resourcereference 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Resourcereference
        {
            get => _resourcereference;
            set
            {
                _resourcereference = value;
                OnPropertyChanged(nameof(Resourcereference));
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
        /// Publisherlocation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Publisherlocation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Publisherlocation
        {
            get => _publisherlocation;
            set
            {
                _publisherlocation = value;
                OnPropertyChanged(nameof(Publisherlocation));
            }
        }        /// <summary>
        /// Publishedin
        /// </summary>
        /// <remarks>
        /// <para>
        /// Publishedin 的詳細描述。
        /// </para>
        /// </remarks>
        public CitationCitedArtifactPublicationFormPublishedIn? Publishedin
        {
            get => _publishedin;
            set
            {
                _publishedin = value;
                OnPropertyChanged(nameof(Publishedin));
            }
        }        /// <summary>
        /// Citedmedium
        /// </summary>
        /// <remarks>
        /// <para>
        /// Citedmedium 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Citedmedium
        {
            get => _citedmedium;
            set
            {
                _citedmedium = value;
                OnPropertyChanged(nameof(Citedmedium));
            }
        }        /// <summary>
        /// Volume
        /// </summary>
        /// <remarks>
        /// <para>
        /// Volume 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Volume
        {
            get => _volume;
            set
            {
                _volume = value;
                OnPropertyChanged(nameof(Volume));
            }
        }        /// <summary>
        /// Issue
        /// </summary>
        /// <remarks>
        /// <para>
        /// Issue 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Issue
        {
            get => _issue;
            set
            {
                _issue = value;
                OnPropertyChanged(nameof(Issue));
            }
        }        /// <summary>
        /// Articledate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Articledate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Articledate
        {
            get => _articledate;
            set
            {
                _articledate = value;
                OnPropertyChanged(nameof(Articledate));
            }
        }        /// <summary>
        /// Publicationdatetext
        /// </summary>
        /// <remarks>
        /// <para>
        /// Publicationdatetext 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Publicationdatetext
        {
            get => _publicationdatetext;
            set
            {
                _publicationdatetext = value;
                OnPropertyChanged(nameof(Publicationdatetext));
            }
        }        /// <summary>
        /// Publicationdateseason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Publicationdateseason 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Publicationdateseason
        {
            get => _publicationdateseason;
            set
            {
                _publicationdateseason = value;
                OnPropertyChanged(nameof(Publicationdateseason));
            }
        }        /// <summary>
        /// Lastrevisiondate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Lastrevisiondate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Lastrevisiondate
        {
            get => _lastrevisiondate;
            set
            {
                _lastrevisiondate = value;
                OnPropertyChanged(nameof(Lastrevisiondate));
            }
        }        /// <summary>
        /// Language
        /// </summary>
        /// <remarks>
        /// <para>
        /// Language 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Language
        {
            get => _language;
            set
            {
                _language = value;
                OnPropertyChanged(nameof(Language));
            }
        }        /// <summary>
        /// Accessionnumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Accessionnumber 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Accessionnumber
        {
            get => _accessionnumber;
            set
            {
                _accessionnumber = value;
                OnPropertyChanged(nameof(Accessionnumber));
            }
        }        /// <summary>
        /// Pagestring
        /// </summary>
        /// <remarks>
        /// <para>
        /// Pagestring 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Pagestring
        {
            get => _pagestring;
            set
            {
                _pagestring = value;
                OnPropertyChanged(nameof(Pagestring));
            }
        }        /// <summary>
        /// Firstpage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Firstpage 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Firstpage
        {
            get => _firstpage;
            set
            {
                _firstpage = value;
                OnPropertyChanged(nameof(Firstpage));
            }
        }        /// <summary>
        /// Lastpage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Lastpage 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Lastpage
        {
            get => _lastpage;
            set
            {
                _lastpage = value;
                OnPropertyChanged(nameof(Lastpage));
            }
        }        /// <summary>
        /// Pagecount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Pagecount 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Pagecount
        {
            get => _pagecount;
            set
            {
                _pagecount = value;
                OnPropertyChanged(nameof(Pagecount));
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
        /// Classifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Classifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Classifier
        {
            get => _classifier;
            set
            {
                _classifier = value;
                OnPropertyChanged(nameof(Classifier));
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
        /// Classifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Classifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Classifier
        {
            get => _classifier;
            set
            {
                _classifier = value;
                OnPropertyChanged(nameof(Classifier));
            }
        }        /// <summary>
        /// Artifactassessment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Artifactassessment 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Artifactassessment
        {
            get => _artifactassessment;
            set
            {
                _artifactassessment = value;
                OnPropertyChanged(nameof(Artifactassessment));
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
        /// Time
        /// </summary>
        /// <remarks>
        /// <para>
        /// Time 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Time
        {
            get => _time;
            set
            {
                _time = value;
                OnPropertyChanged(nameof(Time));
            }
        }        /// <summary>
        /// Contributor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contributor 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Contributor
        {
            get => _contributor;
            set
            {
                _contributor = value;
                OnPropertyChanged(nameof(Contributor));
            }
        }        /// <summary>
        /// Forenameinitials
        /// </summary>
        /// <remarks>
        /// <para>
        /// Forenameinitials 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Forenameinitials
        {
            get => _forenameinitials;
            set
            {
                _forenameinitials = value;
                OnPropertyChanged(nameof(Forenameinitials));
            }
        }        /// <summary>
        /// Affiliation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Affiliation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Affiliation
        {
            get => _affiliation;
            set
            {
                _affiliation = value;
                OnPropertyChanged(nameof(Affiliation));
            }
        }        /// <summary>
        /// Contributiontype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contributiontype 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Contributiontype
        {
            get => _contributiontype;
            set
            {
                _contributiontype = value;
                OnPropertyChanged(nameof(Contributiontype));
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
        /// Contributioninstance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contributioninstance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CitationCitedArtifactContributorshipEntryContributionInstance>? Contributioninstance
        {
            get => _contributioninstance;
            set
            {
                _contributioninstance = value;
                OnPropertyChanged(nameof(Contributioninstance));
            }
        }        /// <summary>
        /// Correspondingcontact
        /// </summary>
        /// <remarks>
        /// <para>
        /// Correspondingcontact 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Correspondingcontact
        {
            get => _correspondingcontact;
            set
            {
                _correspondingcontact = value;
                OnPropertyChanged(nameof(Correspondingcontact));
            }
        }        /// <summary>
        /// Rankingorder
        /// </summary>
        /// <remarks>
        /// <para>
        /// Rankingorder 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Rankingorder
        {
            get => _rankingorder;
            set
            {
                _rankingorder = value;
                OnPropertyChanged(nameof(Rankingorder));
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
        /// Style
        /// </summary>
        /// <remarks>
        /// <para>
        /// Style 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Style
        {
            get => _style;
            set
            {
                _style = value;
                OnPropertyChanged(nameof(Style));
            }
        }        /// <summary>
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Complete
        /// </summary>
        /// <remarks>
        /// <para>
        /// Complete 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Complete
        {
            get => _complete;
            set
            {
                _complete = value;
                OnPropertyChanged(nameof(Complete));
            }
        }        /// <summary>
        /// Entry
        /// </summary>
        /// <remarks>
        /// <para>
        /// Entry 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CitationCitedArtifactContributorshipEntry>? Entry
        {
            get => _entry;
            set
            {
                _entry = value;
                OnPropertyChanged(nameof(Entry));
            }
        }        /// <summary>
        /// Summary
        /// </summary>
        /// <remarks>
        /// <para>
        /// Summary 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CitationCitedArtifactContributorshipSummary>? Summary
        {
            get => _summary;
            set
            {
                _summary = value;
                OnPropertyChanged(nameof(Summary));
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
        /// Relatedidentifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relatedidentifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Relatedidentifier
        {
            get => _relatedidentifier;
            set
            {
                _relatedidentifier = value;
                OnPropertyChanged(nameof(Relatedidentifier));
            }
        }        /// <summary>
        /// Dateaccessed
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dateaccessed 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Dateaccessed
        {
            get => _dateaccessed;
            set
            {
                _dateaccessed = value;
                OnPropertyChanged(nameof(Dateaccessed));
            }
        }        /// <summary>
        /// Version
        /// </summary>
        /// <remarks>
        /// <para>
        /// Version 的詳細描述。
        /// </para>
        /// </remarks>
        public CitationCitedArtifactVersion? Version
        {
            get => _version;
            set
            {
                _version = value;
                OnPropertyChanged(nameof(Version));
            }
        }        /// <summary>
        /// Currentstate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Currentstate 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Currentstate
        {
            get => _currentstate;
            set
            {
                _currentstate = value;
                OnPropertyChanged(nameof(Currentstate));
            }
        }        /// <summary>
        /// Statusdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Statusdate 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CitationCitedArtifactStatusDate>? Statusdate
        {
            get => _statusdate;
            set
            {
                _statusdate = value;
                OnPropertyChanged(nameof(Statusdate));
            }
        }        /// <summary>
        /// Title
        /// </summary>
        /// <remarks>
        /// <para>
        /// Title 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CitationCitedArtifactTitle>? Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }        /// <summary>
        /// Abstract
        /// </summary>
        /// <remarks>
        /// <para>
        /// Abstract 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CitationCitedArtifactAbstract>? Abstract
        {
            get => _abstract;
            set
            {
                _abstract = value;
                OnPropertyChanged(nameof(Abstract));
            }
        }        /// <summary>
        /// Part
        /// </summary>
        /// <remarks>
        /// <para>
        /// Part 的詳細描述。
        /// </para>
        /// </remarks>
        public CitationCitedArtifactPart? Part
        {
            get => _part;
            set
            {
                _part = value;
                OnPropertyChanged(nameof(Part));
            }
        }        /// <summary>
        /// Relatesto
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relatesto 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CitationCitedArtifactRelatesTo>? Relatesto
        {
            get => _relatesto;
            set
            {
                _relatesto = value;
                OnPropertyChanged(nameof(Relatesto));
            }
        }        /// <summary>
        /// Publicationform
        /// </summary>
        /// <remarks>
        /// <para>
        /// Publicationform 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CitationCitedArtifactPublicationForm>? Publicationform
        {
            get => _publicationform;
            set
            {
                _publicationform = value;
                OnPropertyChanged(nameof(Publicationform));
            }
        }        /// <summary>
        /// Weblocation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Weblocation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CitationCitedArtifactWebLocation>? Weblocation
        {
            get => _weblocation;
            set
            {
                _weblocation = value;
                OnPropertyChanged(nameof(Weblocation));
            }
        }        /// <summary>
        /// Classification
        /// </summary>
        /// <remarks>
        /// <para>
        /// Classification 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CitationCitedArtifactClassification>? Classification
        {
            get => _classification;
            set
            {
                _classification = value;
                OnPropertyChanged(nameof(Classification));
            }
        }        /// <summary>
        /// Contributorship
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contributorship 的詳細描述。
        /// </para>
        /// </remarks>
        public CitationCitedArtifactContributorship? Contributorship
        {
            get => _contributorship;
            set
            {
                _contributorship = value;
                OnPropertyChanged(nameof(Contributorship));
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
        /// 建立新的 Citation 資源實例
        /// </summary>
        public Citation()
        {
        }

        /// <summary>
        /// 建立新的 Citation 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Citation(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Citation(Id: {Id})";
        }
    }    /// <summary>
    /// CitationSummary 背骨元素
    /// </summary>
    public class CitationSummary
    {
        // TODO: 添加屬性實作
        
        public CitationSummary() { }
    }    /// <summary>
    /// CitationClassification 背骨元素
    /// </summary>
    public class CitationClassification
    {
        // TODO: 添加屬性實作
        
        public CitationClassification() { }
    }    /// <summary>
    /// CitationStatusDate 背骨元素
    /// </summary>
    public class CitationStatusDate
    {
        // TODO: 添加屬性實作
        
        public CitationStatusDate() { }
    }    /// <summary>
    /// CitationCitedArtifactVersion 背骨元素
    /// </summary>
    public class CitationCitedArtifactVersion
    {
        // TODO: 添加屬性實作
        
        public CitationCitedArtifactVersion() { }
    }    /// <summary>
    /// CitationCitedArtifactStatusDate 背骨元素
    /// </summary>
    public class CitationCitedArtifactStatusDate
    {
        // TODO: 添加屬性實作
        
        public CitationCitedArtifactStatusDate() { }
    }    /// <summary>
    /// CitationCitedArtifactTitle 背骨元素
    /// </summary>
    public class CitationCitedArtifactTitle
    {
        // TODO: 添加屬性實作
        
        public CitationCitedArtifactTitle() { }
    }    /// <summary>
    /// CitationCitedArtifactAbstract 背骨元素
    /// </summary>
    public class CitationCitedArtifactAbstract
    {
        // TODO: 添加屬性實作
        
        public CitationCitedArtifactAbstract() { }
    }    /// <summary>
    /// CitationCitedArtifactPart 背骨元素
    /// </summary>
    public class CitationCitedArtifactPart
    {
        // TODO: 添加屬性實作
        
        public CitationCitedArtifactPart() { }
    }    /// <summary>
    /// CitationCitedArtifactRelatesTo 背骨元素
    /// </summary>
    public class CitationCitedArtifactRelatesTo
    {
        // TODO: 添加屬性實作
        
        public CitationCitedArtifactRelatesTo() { }
    }    /// <summary>
    /// CitationCitedArtifactPublicationFormPublishedIn 背骨元素
    /// </summary>
    public class CitationCitedArtifactPublicationFormPublishedIn
    {
        // TODO: 添加屬性實作
        
        public CitationCitedArtifactPublicationFormPublishedIn() { }
    }    /// <summary>
    /// CitationCitedArtifactPublicationForm 背骨元素
    /// </summary>
    public class CitationCitedArtifactPublicationForm
    {
        // TODO: 添加屬性實作
        
        public CitationCitedArtifactPublicationForm() { }
    }    /// <summary>
    /// CitationCitedArtifactWebLocation 背骨元素
    /// </summary>
    public class CitationCitedArtifactWebLocation
    {
        // TODO: 添加屬性實作
        
        public CitationCitedArtifactWebLocation() { }
    }    /// <summary>
    /// CitationCitedArtifactClassification 背骨元素
    /// </summary>
    public class CitationCitedArtifactClassification
    {
        // TODO: 添加屬性實作
        
        public CitationCitedArtifactClassification() { }
    }    /// <summary>
    /// CitationCitedArtifactContributorshipEntryContributionInstance 背骨元素
    /// </summary>
    public class CitationCitedArtifactContributorshipEntryContributionInstance
    {
        // TODO: 添加屬性實作
        
        public CitationCitedArtifactContributorshipEntryContributionInstance() { }
    }    /// <summary>
    /// CitationCitedArtifactContributorshipEntry 背骨元素
    /// </summary>
    public class CitationCitedArtifactContributorshipEntry
    {
        // TODO: 添加屬性實作
        
        public CitationCitedArtifactContributorshipEntry() { }
    }    /// <summary>
    /// CitationCitedArtifactContributorshipSummary 背骨元素
    /// </summary>
    public class CitationCitedArtifactContributorshipSummary
    {
        // TODO: 添加屬性實作
        
        public CitationCitedArtifactContributorshipSummary() { }
    }    /// <summary>
    /// CitationCitedArtifactContributorship 背骨元素
    /// </summary>
    public class CitationCitedArtifactContributorship
    {
        // TODO: 添加屬性實作
        
        public CitationCitedArtifactContributorship() { }
    }    /// <summary>
    /// CitationCitedArtifact 背骨元素
    /// </summary>
    public class CitationCitedArtifact
    {
        // TODO: 添加屬性實作
        
        public CitationCitedArtifact() { }
    }    /// <summary>
    /// CitationVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class CitationVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public CitationVersionAlgorithmChoice(JsonObject value) : base("citationversionalgorithm", value, _supportType) { }
        public CitationVersionAlgorithmChoice(IComplexType? value) : base("citationversionalgorithm", value) { }
        public CitationVersionAlgorithmChoice(IPrimitiveType? value) : base("citationversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "CitationVersionAlgorithm" : "citationversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
