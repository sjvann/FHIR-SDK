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
    /// FHIR R5 Evidence 資源
    /// 
    /// <para>
    /// Evidence 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var evidence = new Evidence("evidence-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Evidence 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Evidence : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private EvidenceVersionAlgorithmChoice? _versionalgorithm;
        private FhirString? _name;
        private FhirString? _title;
        private EvidenceCiteAsChoice? _citeas;
        private FhirCode? _status;
        private FhirBoolean? _experimental;
        private FhirDateTime? _date;
        private FhirDate? _approvaldate;
        private FhirDate? _lastreviewdate;
        private FhirString? _publisher;
        private List<ContactDetail>? _contact;
        private List<ContactDetail>? _author;
        private List<ContactDetail>? _editor;
        private List<ContactDetail>? _reviewer;
        private List<ContactDetail>? _endorser;
        private List<UsageContext>? _usecontext;
        private FhirMarkdown? _purpose;
        private FhirMarkdown? _copyright;
        private FhirString? _copyrightlabel;
        private List<RelatedArtifact>? _relatedartifact;
        private FhirMarkdown? _description;
        private FhirMarkdown? _assertion;
        private List<Annotation>? _note;
        private List<EvidenceVariableDefinition>? _variabledefinition;
        private CodeableConcept? _synthesistype;
        private List<CodeableConcept>? _studydesign;
        private List<EvidenceStatistic>? _statistic;
        private List<EvidenceCertainty>? _certainty;
        private FhirMarkdown? _description;
        private List<Annotation>? _note;
        private CodeableConcept? _variablerole;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _observed;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _intended;
        private CodeableConcept? _directnessmatch;
        private FhirMarkdown? _description;
        private List<Annotation>? _note;
        private FhirUnsignedInt? _numberofstudies;
        private FhirUnsignedInt? _numberofparticipants;
        private FhirUnsignedInt? _knowndatacount;
        private FhirMarkdown? _description;
        private List<Annotation>? _note;
        private CodeableConcept? _type;
        private Quantity? _quantity;
        private FhirDecimal? _level;
        private Range? _range;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _variabledefinition;
        private FhirCode? _handling;
        private List<CodeableConcept>? _valuecategory;
        private List<Quantity>? _valuequantity;
        private List<Range>? _valuerange;
        private CodeableConcept? _code;
        private Quantity? _value;
        private List<EvidenceStatisticModelCharacteristicVariable>? _variable;
        private FhirMarkdown? _description;
        private List<Annotation>? _note;
        private CodeableConcept? _statistictype;
        private CodeableConcept? _category;
        private Quantity? _quantity;
        private FhirUnsignedInt? _numberofevents;
        private FhirUnsignedInt? _numberaffected;
        private EvidenceStatisticSampleSize? _samplesize;
        private List<EvidenceStatisticAttributeEstimate>? _attributeestimate;
        private List<EvidenceStatisticModelCharacteristic>? _modelcharacteristic;
        private FhirMarkdown? _description;
        private List<Annotation>? _note;
        private CodeableConcept? _type;
        private CodeableConcept? _rating;
        private FhirString? _rater;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Evidence";        /// <summary>
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
        public EvidenceVersionAlgorithmChoice? Versionalgorithm
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
        /// Citeas
        /// </summary>
        /// <remarks>
        /// <para>
        /// Citeas 的詳細描述。
        /// </para>
        /// </remarks>
        public EvidenceCiteAsChoice? Citeas
        {
            get => _citeas;
            set
            {
                _citeas = value;
                OnPropertyChanged(nameof(Citeas));
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
        /// Assertion
        /// </summary>
        /// <remarks>
        /// <para>
        /// Assertion 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Assertion
        {
            get => _assertion;
            set
            {
                _assertion = value;
                OnPropertyChanged(nameof(Assertion));
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
        /// Variabledefinition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Variabledefinition 的詳細描述。
        /// </para>
        /// </remarks>
        public List<EvidenceVariableDefinition>? Variabledefinition
        {
            get => _variabledefinition;
            set
            {
                _variabledefinition = value;
                OnPropertyChanged(nameof(Variabledefinition));
            }
        }        /// <summary>
        /// Synthesistype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Synthesistype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Synthesistype
        {
            get => _synthesistype;
            set
            {
                _synthesistype = value;
                OnPropertyChanged(nameof(Synthesistype));
            }
        }        /// <summary>
        /// Studydesign
        /// </summary>
        /// <remarks>
        /// <para>
        /// Studydesign 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Studydesign
        {
            get => _studydesign;
            set
            {
                _studydesign = value;
                OnPropertyChanged(nameof(Studydesign));
            }
        }        /// <summary>
        /// Statistic
        /// </summary>
        /// <remarks>
        /// <para>
        /// Statistic 的詳細描述。
        /// </para>
        /// </remarks>
        public List<EvidenceStatistic>? Statistic
        {
            get => _statistic;
            set
            {
                _statistic = value;
                OnPropertyChanged(nameof(Statistic));
            }
        }        /// <summary>
        /// Certainty
        /// </summary>
        /// <remarks>
        /// <para>
        /// Certainty 的詳細描述。
        /// </para>
        /// </remarks>
        public List<EvidenceCertainty>? Certainty
        {
            get => _certainty;
            set
            {
                _certainty = value;
                OnPropertyChanged(nameof(Certainty));
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
        /// Variablerole
        /// </summary>
        /// <remarks>
        /// <para>
        /// Variablerole 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Variablerole
        {
            get => _variablerole;
            set
            {
                _variablerole = value;
                OnPropertyChanged(nameof(Variablerole));
            }
        }        /// <summary>
        /// Observed
        /// </summary>
        /// <remarks>
        /// <para>
        /// Observed 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Observed
        {
            get => _observed;
            set
            {
                _observed = value;
                OnPropertyChanged(nameof(Observed));
            }
        }        /// <summary>
        /// Intended
        /// </summary>
        /// <remarks>
        /// <para>
        /// Intended 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Intended
        {
            get => _intended;
            set
            {
                _intended = value;
                OnPropertyChanged(nameof(Intended));
            }
        }        /// <summary>
        /// Directnessmatch
        /// </summary>
        /// <remarks>
        /// <para>
        /// Directnessmatch 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Directnessmatch
        {
            get => _directnessmatch;
            set
            {
                _directnessmatch = value;
                OnPropertyChanged(nameof(Directnessmatch));
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
        /// Numberofstudies
        /// </summary>
        /// <remarks>
        /// <para>
        /// Numberofstudies 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? Numberofstudies
        {
            get => _numberofstudies;
            set
            {
                _numberofstudies = value;
                OnPropertyChanged(nameof(Numberofstudies));
            }
        }        /// <summary>
        /// Numberofparticipants
        /// </summary>
        /// <remarks>
        /// <para>
        /// Numberofparticipants 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? Numberofparticipants
        {
            get => _numberofparticipants;
            set
            {
                _numberofparticipants = value;
                OnPropertyChanged(nameof(Numberofparticipants));
            }
        }        /// <summary>
        /// Knowndatacount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Knowndatacount 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? Knowndatacount
        {
            get => _knowndatacount;
            set
            {
                _knowndatacount = value;
                OnPropertyChanged(nameof(Knowndatacount));
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
        /// Level
        /// </summary>
        /// <remarks>
        /// <para>
        /// Level 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? Level
        {
            get => _level;
            set
            {
                _level = value;
                OnPropertyChanged(nameof(Level));
            }
        }        /// <summary>
        /// Range
        /// </summary>
        /// <remarks>
        /// <para>
        /// Range 的詳細描述。
        /// </para>
        /// </remarks>
        public Range? Range
        {
            get => _range;
            set
            {
                _range = value;
                OnPropertyChanged(nameof(Range));
            }
        }        /// <summary>
        /// Variabledefinition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Variabledefinition 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Variabledefinition
        {
            get => _variabledefinition;
            set
            {
                _variabledefinition = value;
                OnPropertyChanged(nameof(Variabledefinition));
            }
        }        /// <summary>
        /// Handling
        /// </summary>
        /// <remarks>
        /// <para>
        /// Handling 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Handling
        {
            get => _handling;
            set
            {
                _handling = value;
                OnPropertyChanged(nameof(Handling));
            }
        }        /// <summary>
        /// Valuecategory
        /// </summary>
        /// <remarks>
        /// <para>
        /// Valuecategory 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Valuecategory
        {
            get => _valuecategory;
            set
            {
                _valuecategory = value;
                OnPropertyChanged(nameof(Valuecategory));
            }
        }        /// <summary>
        /// Valuequantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Valuequantity 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Quantity>? Valuequantity
        {
            get => _valuequantity;
            set
            {
                _valuequantity = value;
                OnPropertyChanged(nameof(Valuequantity));
            }
        }        /// <summary>
        /// Valuerange
        /// </summary>
        /// <remarks>
        /// <para>
        /// Valuerange 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Range>? Valuerange
        {
            get => _valuerange;
            set
            {
                _valuerange = value;
                OnPropertyChanged(nameof(Valuerange));
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
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Variable
        /// </summary>
        /// <remarks>
        /// <para>
        /// Variable 的詳細描述。
        /// </para>
        /// </remarks>
        public List<EvidenceStatisticModelCharacteristicVariable>? Variable
        {
            get => _variable;
            set
            {
                _variable = value;
                OnPropertyChanged(nameof(Variable));
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
        /// Statistictype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Statistictype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Statistictype
        {
            get => _statistictype;
            set
            {
                _statistictype = value;
                OnPropertyChanged(nameof(Statistictype));
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
        /// Numberofevents
        /// </summary>
        /// <remarks>
        /// <para>
        /// Numberofevents 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? Numberofevents
        {
            get => _numberofevents;
            set
            {
                _numberofevents = value;
                OnPropertyChanged(nameof(Numberofevents));
            }
        }        /// <summary>
        /// Numberaffected
        /// </summary>
        /// <remarks>
        /// <para>
        /// Numberaffected 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? Numberaffected
        {
            get => _numberaffected;
            set
            {
                _numberaffected = value;
                OnPropertyChanged(nameof(Numberaffected));
            }
        }        /// <summary>
        /// Samplesize
        /// </summary>
        /// <remarks>
        /// <para>
        /// Samplesize 的詳細描述。
        /// </para>
        /// </remarks>
        public EvidenceStatisticSampleSize? Samplesize
        {
            get => _samplesize;
            set
            {
                _samplesize = value;
                OnPropertyChanged(nameof(Samplesize));
            }
        }        /// <summary>
        /// Attributeestimate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Attributeestimate 的詳細描述。
        /// </para>
        /// </remarks>
        public List<EvidenceStatisticAttributeEstimate>? Attributeestimate
        {
            get => _attributeestimate;
            set
            {
                _attributeestimate = value;
                OnPropertyChanged(nameof(Attributeestimate));
            }
        }        /// <summary>
        /// Modelcharacteristic
        /// </summary>
        /// <remarks>
        /// <para>
        /// Modelcharacteristic 的詳細描述。
        /// </para>
        /// </remarks>
        public List<EvidenceStatisticModelCharacteristic>? Modelcharacteristic
        {
            get => _modelcharacteristic;
            set
            {
                _modelcharacteristic = value;
                OnPropertyChanged(nameof(Modelcharacteristic));
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
        /// Rating
        /// </summary>
        /// <remarks>
        /// <para>
        /// Rating 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Rating
        {
            get => _rating;
            set
            {
                _rating = value;
                OnPropertyChanged(nameof(Rating));
            }
        }        /// <summary>
        /// Rater
        /// </summary>
        /// <remarks>
        /// <para>
        /// Rater 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Rater
        {
            get => _rater;
            set
            {
                _rater = value;
                OnPropertyChanged(nameof(Rater));
            }
        }        /// <summary>
        /// 建立新的 Evidence 資源實例
        /// </summary>
        public Evidence()
        {
        }

        /// <summary>
        /// 建立新的 Evidence 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Evidence(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Evidence(Id: {Id})";
        }
    }    /// <summary>
    /// EvidenceVariableDefinition 背骨元素
    /// </summary>
    public class EvidenceVariableDefinition
    {
        // TODO: 添加屬性實作
        
        public EvidenceVariableDefinition() { }
    }    /// <summary>
    /// EvidenceStatisticSampleSize 背骨元素
    /// </summary>
    public class EvidenceStatisticSampleSize
    {
        // TODO: 添加屬性實作
        
        public EvidenceStatisticSampleSize() { }
    }    /// <summary>
    /// EvidenceStatisticAttributeEstimate 背骨元素
    /// </summary>
    public class EvidenceStatisticAttributeEstimate
    {
        // TODO: 添加屬性實作
        
        public EvidenceStatisticAttributeEstimate() { }
    }    /// <summary>
    /// EvidenceStatisticModelCharacteristicVariable 背骨元素
    /// </summary>
    public class EvidenceStatisticModelCharacteristicVariable
    {
        // TODO: 添加屬性實作
        
        public EvidenceStatisticModelCharacteristicVariable() { }
    }    /// <summary>
    /// EvidenceStatisticModelCharacteristic 背骨元素
    /// </summary>
    public class EvidenceStatisticModelCharacteristic
    {
        // TODO: 添加屬性實作
        
        public EvidenceStatisticModelCharacteristic() { }
    }    /// <summary>
    /// EvidenceStatistic 背骨元素
    /// </summary>
    public class EvidenceStatistic
    {
        // TODO: 添加屬性實作
        
        public EvidenceStatistic() { }
    }    /// <summary>
    /// EvidenceCertainty 背骨元素
    /// </summary>
    public class EvidenceCertainty
    {
        // TODO: 添加屬性實作
        
        public EvidenceCertainty() { }
    }    /// <summary>
    /// EvidenceVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class EvidenceVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public EvidenceVersionAlgorithmChoice(JsonObject value) : base("evidenceversionalgorithm", value, _supportType) { }
        public EvidenceVersionAlgorithmChoice(IComplexType? value) : base("evidenceversionalgorithm", value) { }
        public EvidenceVersionAlgorithmChoice(IPrimitiveType? value) : base("evidenceversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "EvidenceVersionAlgorithm" : "evidenceversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// EvidenceCiteAsChoice 選擇類型
    /// </summary>
    public class EvidenceCiteAsChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public EvidenceCiteAsChoice(JsonObject value) : base("evidenceciteas", value, _supportType) { }
        public EvidenceCiteAsChoice(IComplexType? value) : base("evidenceciteas", value) { }
        public EvidenceCiteAsChoice(IPrimitiveType? value) : base("evidenceciteas", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "EvidenceCiteAs" : "evidenceciteas";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
