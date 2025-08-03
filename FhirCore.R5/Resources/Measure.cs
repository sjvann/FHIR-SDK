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
    /// FHIR R5 Measure 資源
    /// 
    /// <para>
    /// Measure 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var measure = new Measure("measure-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Measure 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Measure : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private MeasureVersionAlgorithmChoice? _versionalgorithm;
        private FhirString? _name;
        private FhirString? _title;
        private FhirString? _subtitle;
        private FhirCode? _status;
        private FhirBoolean? _experimental;
        private MeasureSubjectChoice? _subject;
        private FhirCode? _basis;
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
        private FhirMarkdown? _disclaimer;
        private CodeableConcept? _scoring;
        private CodeableConcept? _scoringunit;
        private CodeableConcept? _compositescoring;
        private List<CodeableConcept>? _type;
        private FhirMarkdown? _riskadjustment;
        private FhirMarkdown? _rateaggregation;
        private FhirMarkdown? _rationale;
        private FhirMarkdown? _clinicalrecommendationstatement;
        private CodeableConcept? _improvementnotation;
        private List<MeasureTerm>? _term;
        private FhirMarkdown? _guidance;
        private List<MeasureGroup>? _group;
        private List<MeasureSupplementalData>? _supplementaldata;
        private CodeableConcept? _code;
        private FhirMarkdown? _definition;
        private FhirString? _linkid;
        private CodeableConcept? _code;
        private FhirMarkdown? _description;
        private ExpressionType? _criteria;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _groupdefinition;
        private FhirString? _inputpopulationid;
        private CodeableConcept? _aggregatemethod;
        private FhirString? _linkid;
        private CodeableConcept? _code;
        private FhirMarkdown? _description;
        private ExpressionType? _criteria;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _groupdefinition;
        private FhirString? _linkid;
        private CodeableConcept? _code;
        private FhirMarkdown? _description;
        private ExpressionType? _criteria;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _groupdefinition;
        private List<MeasureGroupStratifierComponent>? _component;
        private FhirString? _linkid;
        private CodeableConcept? _code;
        private FhirMarkdown? _description;
        private List<CodeableConcept>? _type;
        private MeasureGroupSubjectChoice? _subject;
        private FhirCode? _basis;
        private CodeableConcept? _scoring;
        private CodeableConcept? _scoringunit;
        private FhirMarkdown? _rateaggregation;
        private CodeableConcept? _improvementnotation;
        private List<FhirCanonical>? _library;
        private List<MeasureGroupPopulation>? _population;
        private List<MeasureGroupStratifier>? _stratifier;
        private FhirString? _linkid;
        private CodeableConcept? _code;
        private List<CodeableConcept>? _usage;
        private FhirMarkdown? _description;
        private ExpressionType? _criteria;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Measure";        /// <summary>
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
        public MeasureVersionAlgorithmChoice? Versionalgorithm
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
        public MeasureSubjectChoice? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }        /// <summary>
        /// Basis
        /// </summary>
        /// <remarks>
        /// <para>
        /// Basis 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Basis
        {
            get => _basis;
            set
            {
                _basis = value;
                OnPropertyChanged(nameof(Basis));
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
        /// Disclaimer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Disclaimer 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Disclaimer
        {
            get => _disclaimer;
            set
            {
                _disclaimer = value;
                OnPropertyChanged(nameof(Disclaimer));
            }
        }        /// <summary>
        /// Scoring
        /// </summary>
        /// <remarks>
        /// <para>
        /// Scoring 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Scoring
        {
            get => _scoring;
            set
            {
                _scoring = value;
                OnPropertyChanged(nameof(Scoring));
            }
        }        /// <summary>
        /// Scoringunit
        /// </summary>
        /// <remarks>
        /// <para>
        /// Scoringunit 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Scoringunit
        {
            get => _scoringunit;
            set
            {
                _scoringunit = value;
                OnPropertyChanged(nameof(Scoringunit));
            }
        }        /// <summary>
        /// Compositescoring
        /// </summary>
        /// <remarks>
        /// <para>
        /// Compositescoring 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Compositescoring
        {
            get => _compositescoring;
            set
            {
                _compositescoring = value;
                OnPropertyChanged(nameof(Compositescoring));
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
        /// Riskadjustment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Riskadjustment 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Riskadjustment
        {
            get => _riskadjustment;
            set
            {
                _riskadjustment = value;
                OnPropertyChanged(nameof(Riskadjustment));
            }
        }        /// <summary>
        /// Rateaggregation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Rateaggregation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Rateaggregation
        {
            get => _rateaggregation;
            set
            {
                _rateaggregation = value;
                OnPropertyChanged(nameof(Rateaggregation));
            }
        }        /// <summary>
        /// Rationale
        /// </summary>
        /// <remarks>
        /// <para>
        /// Rationale 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Rationale
        {
            get => _rationale;
            set
            {
                _rationale = value;
                OnPropertyChanged(nameof(Rationale));
            }
        }        /// <summary>
        /// Clinicalrecommendationstatement
        /// </summary>
        /// <remarks>
        /// <para>
        /// Clinicalrecommendationstatement 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Clinicalrecommendationstatement
        {
            get => _clinicalrecommendationstatement;
            set
            {
                _clinicalrecommendationstatement = value;
                OnPropertyChanged(nameof(Clinicalrecommendationstatement));
            }
        }        /// <summary>
        /// Improvementnotation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Improvementnotation 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Improvementnotation
        {
            get => _improvementnotation;
            set
            {
                _improvementnotation = value;
                OnPropertyChanged(nameof(Improvementnotation));
            }
        }        /// <summary>
        /// Term
        /// </summary>
        /// <remarks>
        /// <para>
        /// Term 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MeasureTerm>? Term
        {
            get => _term;
            set
            {
                _term = value;
                OnPropertyChanged(nameof(Term));
            }
        }        /// <summary>
        /// Guidance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Guidance 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Guidance
        {
            get => _guidance;
            set
            {
                _guidance = value;
                OnPropertyChanged(nameof(Guidance));
            }
        }        /// <summary>
        /// Group
        /// </summary>
        /// <remarks>
        /// <para>
        /// Group 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MeasureGroup>? Group
        {
            get => _group;
            set
            {
                _group = value;
                OnPropertyChanged(nameof(Group));
            }
        }        /// <summary>
        /// Supplementaldata
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supplementaldata 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MeasureSupplementalData>? Supplementaldata
        {
            get => _supplementaldata;
            set
            {
                _supplementaldata = value;
                OnPropertyChanged(nameof(Supplementaldata));
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
        /// Definition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definition 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Definition
        {
            get => _definition;
            set
            {
                _definition = value;
                OnPropertyChanged(nameof(Definition));
            }
        }        /// <summary>
        /// Linkid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Linkid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Linkid
        {
            get => _linkid;
            set
            {
                _linkid = value;
                OnPropertyChanged(nameof(Linkid));
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
        /// Criteria
        /// </summary>
        /// <remarks>
        /// <para>
        /// Criteria 的詳細描述。
        /// </para>
        /// </remarks>
        public ExpressionType? Criteria
        {
            get => _criteria;
            set
            {
                _criteria = value;
                OnPropertyChanged(nameof(Criteria));
            }
        }        /// <summary>
        /// Groupdefinition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Groupdefinition 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Groupdefinition
        {
            get => _groupdefinition;
            set
            {
                _groupdefinition = value;
                OnPropertyChanged(nameof(Groupdefinition));
            }
        }        /// <summary>
        /// Inputpopulationid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Inputpopulationid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Inputpopulationid
        {
            get => _inputpopulationid;
            set
            {
                _inputpopulationid = value;
                OnPropertyChanged(nameof(Inputpopulationid));
            }
        }        /// <summary>
        /// Aggregatemethod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Aggregatemethod 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Aggregatemethod
        {
            get => _aggregatemethod;
            set
            {
                _aggregatemethod = value;
                OnPropertyChanged(nameof(Aggregatemethod));
            }
        }        /// <summary>
        /// Linkid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Linkid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Linkid
        {
            get => _linkid;
            set
            {
                _linkid = value;
                OnPropertyChanged(nameof(Linkid));
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
        /// Criteria
        /// </summary>
        /// <remarks>
        /// <para>
        /// Criteria 的詳細描述。
        /// </para>
        /// </remarks>
        public ExpressionType? Criteria
        {
            get => _criteria;
            set
            {
                _criteria = value;
                OnPropertyChanged(nameof(Criteria));
            }
        }        /// <summary>
        /// Groupdefinition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Groupdefinition 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Groupdefinition
        {
            get => _groupdefinition;
            set
            {
                _groupdefinition = value;
                OnPropertyChanged(nameof(Groupdefinition));
            }
        }        /// <summary>
        /// Linkid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Linkid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Linkid
        {
            get => _linkid;
            set
            {
                _linkid = value;
                OnPropertyChanged(nameof(Linkid));
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
        /// Criteria
        /// </summary>
        /// <remarks>
        /// <para>
        /// Criteria 的詳細描述。
        /// </para>
        /// </remarks>
        public ExpressionType? Criteria
        {
            get => _criteria;
            set
            {
                _criteria = value;
                OnPropertyChanged(nameof(Criteria));
            }
        }        /// <summary>
        /// Groupdefinition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Groupdefinition 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Groupdefinition
        {
            get => _groupdefinition;
            set
            {
                _groupdefinition = value;
                OnPropertyChanged(nameof(Groupdefinition));
            }
        }        /// <summary>
        /// Component
        /// </summary>
        /// <remarks>
        /// <para>
        /// Component 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MeasureGroupStratifierComponent>? Component
        {
            get => _component;
            set
            {
                _component = value;
                OnPropertyChanged(nameof(Component));
            }
        }        /// <summary>
        /// Linkid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Linkid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Linkid
        {
            get => _linkid;
            set
            {
                _linkid = value;
                OnPropertyChanged(nameof(Linkid));
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
        /// Subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject 的詳細描述。
        /// </para>
        /// </remarks>
        public MeasureGroupSubjectChoice? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }        /// <summary>
        /// Basis
        /// </summary>
        /// <remarks>
        /// <para>
        /// Basis 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Basis
        {
            get => _basis;
            set
            {
                _basis = value;
                OnPropertyChanged(nameof(Basis));
            }
        }        /// <summary>
        /// Scoring
        /// </summary>
        /// <remarks>
        /// <para>
        /// Scoring 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Scoring
        {
            get => _scoring;
            set
            {
                _scoring = value;
                OnPropertyChanged(nameof(Scoring));
            }
        }        /// <summary>
        /// Scoringunit
        /// </summary>
        /// <remarks>
        /// <para>
        /// Scoringunit 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Scoringunit
        {
            get => _scoringunit;
            set
            {
                _scoringunit = value;
                OnPropertyChanged(nameof(Scoringunit));
            }
        }        /// <summary>
        /// Rateaggregation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Rateaggregation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Rateaggregation
        {
            get => _rateaggregation;
            set
            {
                _rateaggregation = value;
                OnPropertyChanged(nameof(Rateaggregation));
            }
        }        /// <summary>
        /// Improvementnotation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Improvementnotation 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Improvementnotation
        {
            get => _improvementnotation;
            set
            {
                _improvementnotation = value;
                OnPropertyChanged(nameof(Improvementnotation));
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
        /// Population
        /// </summary>
        /// <remarks>
        /// <para>
        /// Population 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MeasureGroupPopulation>? Population
        {
            get => _population;
            set
            {
                _population = value;
                OnPropertyChanged(nameof(Population));
            }
        }        /// <summary>
        /// Stratifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Stratifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MeasureGroupStratifier>? Stratifier
        {
            get => _stratifier;
            set
            {
                _stratifier = value;
                OnPropertyChanged(nameof(Stratifier));
            }
        }        /// <summary>
        /// Linkid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Linkid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Linkid
        {
            get => _linkid;
            set
            {
                _linkid = value;
                OnPropertyChanged(nameof(Linkid));
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
        /// Usage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Usage 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Usage
        {
            get => _usage;
            set
            {
                _usage = value;
                OnPropertyChanged(nameof(Usage));
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
        /// Criteria
        /// </summary>
        /// <remarks>
        /// <para>
        /// Criteria 的詳細描述。
        /// </para>
        /// </remarks>
        public ExpressionType? Criteria
        {
            get => _criteria;
            set
            {
                _criteria = value;
                OnPropertyChanged(nameof(Criteria));
            }
        }        /// <summary>
        /// 建立新的 Measure 資源實例
        /// </summary>
        public Measure()
        {
        }

        /// <summary>
        /// 建立新的 Measure 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Measure(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Measure(Id: {Id})";
        }
    }    /// <summary>
    /// MeasureTerm 背骨元素
    /// </summary>
    public class MeasureTerm
    {
        // TODO: 添加屬性實作
        
        public MeasureTerm() { }
    }    /// <summary>
    /// MeasureGroupPopulation 背骨元素
    /// </summary>
    public class MeasureGroupPopulation
    {
        // TODO: 添加屬性實作
        
        public MeasureGroupPopulation() { }
    }    /// <summary>
    /// MeasureGroupStratifierComponent 背骨元素
    /// </summary>
    public class MeasureGroupStratifierComponent
    {
        // TODO: 添加屬性實作
        
        public MeasureGroupStratifierComponent() { }
    }    /// <summary>
    /// MeasureGroupStratifier 背骨元素
    /// </summary>
    public class MeasureGroupStratifier
    {
        // TODO: 添加屬性實作
        
        public MeasureGroupStratifier() { }
    }    /// <summary>
    /// MeasureGroup 背骨元素
    /// </summary>
    public class MeasureGroup
    {
        // TODO: 添加屬性實作
        
        public MeasureGroup() { }
    }    /// <summary>
    /// MeasureSupplementalData 背骨元素
    /// </summary>
    public class MeasureSupplementalData
    {
        // TODO: 添加屬性實作
        
        public MeasureSupplementalData() { }
    }    /// <summary>
    /// MeasureVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class MeasureVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MeasureVersionAlgorithmChoice(JsonObject value) : base("measureversionalgorithm", value, _supportType) { }
        public MeasureVersionAlgorithmChoice(IComplexType? value) : base("measureversionalgorithm", value) { }
        public MeasureVersionAlgorithmChoice(IPrimitiveType? value) : base("measureversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MeasureVersionAlgorithm" : "measureversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// MeasureSubjectChoice 選擇類型
    /// </summary>
    public class MeasureSubjectChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MeasureSubjectChoice(JsonObject value) : base("measuresubject", value, _supportType) { }
        public MeasureSubjectChoice(IComplexType? value) : base("measuresubject", value) { }
        public MeasureSubjectChoice(IPrimitiveType? value) : base("measuresubject", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MeasureSubject" : "measuresubject";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// MeasureGroupSubjectChoice 選擇類型
    /// </summary>
    public class MeasureGroupSubjectChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MeasureGroupSubjectChoice(JsonObject value) : base("measuregroupsubject", value, _supportType) { }
        public MeasureGroupSubjectChoice(IComplexType? value) : base("measuregroupsubject", value) { }
        public MeasureGroupSubjectChoice(IPrimitiveType? value) : base("measuregroupsubject", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MeasureGroupSubject" : "measuregroupsubject";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
