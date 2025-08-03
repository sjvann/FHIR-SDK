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
    /// FHIR R5 ResearchStudy 資源
    /// 
    /// <para>
    /// ResearchStudy 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var researchstudy = new ResearchStudy("researchstudy-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 ResearchStudy 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ResearchStudy : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private FhirString? _name;
        private FhirString? _title;
        private List<ResearchStudyLabel>? _label;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _protocol;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _partof;
        private List<RelatedArtifact>? _relatedartifact;
        private FhirDateTime? _date;
        private FhirCode? _status;
        private CodeableConcept? _primarypurposetype;
        private CodeableConcept? _phase;
        private List<CodeableConcept>? _studydesign;
        private List<CodeableReference>? _focus;
        private List<CodeableConcept>? _condition;
        private List<CodeableConcept>? _keyword;
        private List<CodeableConcept>? _region;
        private FhirMarkdown? _descriptionsummary;
        private FhirMarkdown? _description;
        private Period? _period;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _site;
        private List<Annotation>? _note;
        private List<CodeableConcept>? _classifier;
        private List<ResearchStudyAssociatedParty>? _associatedparty;
        private List<ResearchStudyProgressStatus>? _progressstatus;
        private CodeableConcept? _whystopped;
        private ResearchStudyRecruitment? _recruitment;
        private List<ResearchStudyComparisonGroup>? _comparisongroup;
        private List<ResearchStudyObjective>? _objective;
        private List<ResearchStudyOutcomeMeasure>? _outcomemeasure;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _result;
        private CodeableConcept? _type;
        private FhirString? _value;
        private FhirString? _name;
        private CodeableConcept? _role;
        private List<Period>? _period;
        private List<CodeableConcept>? _classifier;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _party;
        private CodeableConcept? _state;
        private FhirBoolean? _actual;
        private Period? _period;
        private FhirUnsignedInt? _targetnumber;
        private FhirUnsignedInt? _actualnumber;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _eligibility;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _actualgroup;
        private FhirId? _linkid;
        private FhirString? _name;
        private CodeableConcept? _type;
        private FhirMarkdown? _description;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _intendedexposure;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _observedgroup;
        private FhirString? _name;
        private CodeableConcept? _type;
        private FhirMarkdown? _description;
        private FhirString? _name;
        private List<CodeableConcept>? _type;
        private FhirMarkdown? _description;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _reference;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ResearchStudy";        /// <summary>
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
        /// Label
        /// </summary>
        /// <remarks>
        /// <para>
        /// Label 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ResearchStudyLabel>? Label
        {
            get => _label;
            set
            {
                _label = value;
                OnPropertyChanged(nameof(Label));
            }
        }        /// <summary>
        /// Protocol
        /// </summary>
        /// <remarks>
        /// <para>
        /// Protocol 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Protocol
        {
            get => _protocol;
            set
            {
                _protocol = value;
                OnPropertyChanged(nameof(Protocol));
            }
        }        /// <summary>
        /// Partof
        /// </summary>
        /// <remarks>
        /// <para>
        /// Partof 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Partof
        {
            get => _partof;
            set
            {
                _partof = value;
                OnPropertyChanged(nameof(Partof));
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
        /// Primarypurposetype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Primarypurposetype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Primarypurposetype
        {
            get => _primarypurposetype;
            set
            {
                _primarypurposetype = value;
                OnPropertyChanged(nameof(Primarypurposetype));
            }
        }        /// <summary>
        /// Phase
        /// </summary>
        /// <remarks>
        /// <para>
        /// Phase 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Phase
        {
            get => _phase;
            set
            {
                _phase = value;
                OnPropertyChanged(nameof(Phase));
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
        /// Focus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Focus 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Focus
        {
            get => _focus;
            set
            {
                _focus = value;
                OnPropertyChanged(nameof(Focus));
            }
        }        /// <summary>
        /// Condition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Condition 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Condition
        {
            get => _condition;
            set
            {
                _condition = value;
                OnPropertyChanged(nameof(Condition));
            }
        }        /// <summary>
        /// Keyword
        /// </summary>
        /// <remarks>
        /// <para>
        /// Keyword 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Keyword
        {
            get => _keyword;
            set
            {
                _keyword = value;
                OnPropertyChanged(nameof(Keyword));
            }
        }        /// <summary>
        /// Region
        /// </summary>
        /// <remarks>
        /// <para>
        /// Region 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Region
        {
            get => _region;
            set
            {
                _region = value;
                OnPropertyChanged(nameof(Region));
            }
        }        /// <summary>
        /// Descriptionsummary
        /// </summary>
        /// <remarks>
        /// <para>
        /// Descriptionsummary 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Descriptionsummary
        {
            get => _descriptionsummary;
            set
            {
                _descriptionsummary = value;
                OnPropertyChanged(nameof(Descriptionsummary));
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
        /// Associatedparty
        /// </summary>
        /// <remarks>
        /// <para>
        /// Associatedparty 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ResearchStudyAssociatedParty>? Associatedparty
        {
            get => _associatedparty;
            set
            {
                _associatedparty = value;
                OnPropertyChanged(nameof(Associatedparty));
            }
        }        /// <summary>
        /// Progressstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Progressstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ResearchStudyProgressStatus>? Progressstatus
        {
            get => _progressstatus;
            set
            {
                _progressstatus = value;
                OnPropertyChanged(nameof(Progressstatus));
            }
        }        /// <summary>
        /// Whystopped
        /// </summary>
        /// <remarks>
        /// <para>
        /// Whystopped 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Whystopped
        {
            get => _whystopped;
            set
            {
                _whystopped = value;
                OnPropertyChanged(nameof(Whystopped));
            }
        }        /// <summary>
        /// Recruitment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Recruitment 的詳細描述。
        /// </para>
        /// </remarks>
        public ResearchStudyRecruitment? Recruitment
        {
            get => _recruitment;
            set
            {
                _recruitment = value;
                OnPropertyChanged(nameof(Recruitment));
            }
        }        /// <summary>
        /// Comparisongroup
        /// </summary>
        /// <remarks>
        /// <para>
        /// Comparisongroup 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ResearchStudyComparisonGroup>? Comparisongroup
        {
            get => _comparisongroup;
            set
            {
                _comparisongroup = value;
                OnPropertyChanged(nameof(Comparisongroup));
            }
        }        /// <summary>
        /// Objective
        /// </summary>
        /// <remarks>
        /// <para>
        /// Objective 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ResearchStudyObjective>? Objective
        {
            get => _objective;
            set
            {
                _objective = value;
                OnPropertyChanged(nameof(Objective));
            }
        }        /// <summary>
        /// Outcomemeasure
        /// </summary>
        /// <remarks>
        /// <para>
        /// Outcomemeasure 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ResearchStudyOutcomeMeasure>? Outcomemeasure
        {
            get => _outcomemeasure;
            set
            {
                _outcomemeasure = value;
                OnPropertyChanged(nameof(Outcomemeasure));
            }
        }        /// <summary>
        /// Result
        /// </summary>
        /// <remarks>
        /// <para>
        /// Result 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
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
        /// State
        /// </summary>
        /// <remarks>
        /// <para>
        /// State 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? State
        {
            get => _state;
            set
            {
                _state = value;
                OnPropertyChanged(nameof(State));
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
        /// Targetnumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Targetnumber 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? Targetnumber
        {
            get => _targetnumber;
            set
            {
                _targetnumber = value;
                OnPropertyChanged(nameof(Targetnumber));
            }
        }        /// <summary>
        /// Actualnumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Actualnumber 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? Actualnumber
        {
            get => _actualnumber;
            set
            {
                _actualnumber = value;
                OnPropertyChanged(nameof(Actualnumber));
            }
        }        /// <summary>
        /// Eligibility
        /// </summary>
        /// <remarks>
        /// <para>
        /// Eligibility 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Eligibility
        {
            get => _eligibility;
            set
            {
                _eligibility = value;
                OnPropertyChanged(nameof(Eligibility));
            }
        }        /// <summary>
        /// Actualgroup
        /// </summary>
        /// <remarks>
        /// <para>
        /// Actualgroup 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Actualgroup
        {
            get => _actualgroup;
            set
            {
                _actualgroup = value;
                OnPropertyChanged(nameof(Actualgroup));
            }
        }        /// <summary>
        /// Linkid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Linkid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Linkid
        {
            get => _linkid;
            set
            {
                _linkid = value;
                OnPropertyChanged(nameof(Linkid));
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
        /// Intendedexposure
        /// </summary>
        /// <remarks>
        /// <para>
        /// Intendedexposure 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Intendedexposure
        {
            get => _intendedexposure;
            set
            {
                _intendedexposure = value;
                OnPropertyChanged(nameof(Intendedexposure));
            }
        }        /// <summary>
        /// Observedgroup
        /// </summary>
        /// <remarks>
        /// <para>
        /// Observedgroup 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Observedgroup
        {
            get => _observedgroup;
            set
            {
                _observedgroup = value;
                OnPropertyChanged(nameof(Observedgroup));
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
        /// 建立新的 ResearchStudy 資源實例
        /// </summary>
        public ResearchStudy()
        {
        }

        /// <summary>
        /// 建立新的 ResearchStudy 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ResearchStudy(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ResearchStudy(Id: {Id})";
        }
    }    /// <summary>
    /// ResearchStudyLabel 背骨元素
    /// </summary>
    public class ResearchStudyLabel
    {
        // TODO: 添加屬性實作
        
        public ResearchStudyLabel() { }
    }    /// <summary>
    /// ResearchStudyAssociatedParty 背骨元素
    /// </summary>
    public class ResearchStudyAssociatedParty
    {
        // TODO: 添加屬性實作
        
        public ResearchStudyAssociatedParty() { }
    }    /// <summary>
    /// ResearchStudyProgressStatus 背骨元素
    /// </summary>
    public class ResearchStudyProgressStatus
    {
        // TODO: 添加屬性實作
        
        public ResearchStudyProgressStatus() { }
    }    /// <summary>
    /// ResearchStudyRecruitment 背骨元素
    /// </summary>
    public class ResearchStudyRecruitment
    {
        // TODO: 添加屬性實作
        
        public ResearchStudyRecruitment() { }
    }    /// <summary>
    /// ResearchStudyComparisonGroup 背骨元素
    /// </summary>
    public class ResearchStudyComparisonGroup
    {
        // TODO: 添加屬性實作
        
        public ResearchStudyComparisonGroup() { }
    }    /// <summary>
    /// ResearchStudyObjective 背骨元素
    /// </summary>
    public class ResearchStudyObjective
    {
        // TODO: 添加屬性實作
        
        public ResearchStudyObjective() { }
    }    /// <summary>
    /// ResearchStudyOutcomeMeasure 背骨元素
    /// </summary>
    public class ResearchStudyOutcomeMeasure
    {
        // TODO: 添加屬性實作
        
        public ResearchStudyOutcomeMeasure() { }
    }
}
