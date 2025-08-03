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
    /// FHIR R5 ConceptMap 資源
    /// 
    /// <para>
    /// ConceptMap 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var conceptmap = new ConceptMap("conceptmap-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 ConceptMap 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ConceptMap : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private ConceptMapVersionAlgorithmChoice? _versionalgorithm;
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
        private List<CodeableConcept>? _topic;
        private List<ContactDetail>? _author;
        private List<ContactDetail>? _editor;
        private List<ContactDetail>? _reviewer;
        private List<ContactDetail>? _endorser;
        private List<RelatedArtifact>? _relatedartifact;
        private List<ConceptMapProperty>? _property;
        private List<ConceptMapAdditionalAttribute>? _additionalattribute;
        private ConceptMapSourceScopeChoice? _sourcescope;
        private ConceptMapTargetScopeChoice? _targetscope;
        private List<ConceptMapGroup>? _group;
        private FhirCode? _code;
        private FhirUri? _uri;
        private FhirString? _description;
        private FhirCode? _type;
        private FhirCanonical? _system;
        private FhirCode? _code;
        private FhirUri? _uri;
        private FhirString? _description;
        private FhirCode? _type;
        private FhirCode? _code;
        private ConceptMapGroupElementTargetPropertyValueChoice? _value;
        private FhirCode? _attribute;
        private ConceptMapGroupElementTargetDependsOnValueChoice? _value;
        private FhirCanonical? _valueset;
        private FhirCode? _code;
        private FhirString? _display;
        private FhirCanonical? _valueset;
        private FhirCode? _relationship;
        private FhirString? _comment;
        private List<ConceptMapGroupElementTargetProperty>? _property;
        private List<ConceptMapGroupElementTargetDependsOn>? _dependson;
        private FhirCode? _code;
        private FhirString? _display;
        private FhirCanonical? _valueset;
        private FhirBoolean? _nomap;
        private List<ConceptMapGroupElementTarget>? _target;
        private FhirCode? _mode;
        private FhirCode? _code;
        private FhirString? _display;
        private FhirCanonical? _valueset;
        private FhirCode? _relationship;
        private FhirCanonical? _othermap;
        private FhirCanonical? _source;
        private FhirCanonical? _target;
        private List<ConceptMapGroupElement>? _element;
        private ConceptMapGroupUnmapped? _unmapped;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ConceptMap";        /// <summary>
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
        public ConceptMapVersionAlgorithmChoice? Versionalgorithm
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
        /// Property
        /// </summary>
        /// <remarks>
        /// <para>
        /// Property 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ConceptMapProperty>? Property
        {
            get => _property;
            set
            {
                _property = value;
                OnPropertyChanged(nameof(Property));
            }
        }        /// <summary>
        /// Additionalattribute
        /// </summary>
        /// <remarks>
        /// <para>
        /// Additionalattribute 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ConceptMapAdditionalAttribute>? Additionalattribute
        {
            get => _additionalattribute;
            set
            {
                _additionalattribute = value;
                OnPropertyChanged(nameof(Additionalattribute));
            }
        }        /// <summary>
        /// Sourcescope
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sourcescope 的詳細描述。
        /// </para>
        /// </remarks>
        public ConceptMapSourceScopeChoice? Sourcescope
        {
            get => _sourcescope;
            set
            {
                _sourcescope = value;
                OnPropertyChanged(nameof(Sourcescope));
            }
        }        /// <summary>
        /// Targetscope
        /// </summary>
        /// <remarks>
        /// <para>
        /// Targetscope 的詳細描述。
        /// </para>
        /// </remarks>
        public ConceptMapTargetScopeChoice? Targetscope
        {
            get => _targetscope;
            set
            {
                _targetscope = value;
                OnPropertyChanged(nameof(Targetscope));
            }
        }        /// <summary>
        /// Group
        /// </summary>
        /// <remarks>
        /// <para>
        /// Group 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ConceptMapGroup>? Group
        {
            get => _group;
            set
            {
                _group = value;
                OnPropertyChanged(nameof(Group));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Uri
        /// </summary>
        /// <remarks>
        /// <para>
        /// Uri 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Uri
        {
            get => _uri;
            set
            {
                _uri = value;
                OnPropertyChanged(nameof(Uri));
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
        /// System
        /// </summary>
        /// <remarks>
        /// <para>
        /// System 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? System
        {
            get => _system;
            set
            {
                _system = value;
                OnPropertyChanged(nameof(System));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Uri
        /// </summary>
        /// <remarks>
        /// <para>
        /// Uri 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Uri
        {
            get => _uri;
            set
            {
                _uri = value;
                OnPropertyChanged(nameof(Uri));
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
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Code
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
        public ConceptMapGroupElementTargetPropertyValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Attribute
        /// </summary>
        /// <remarks>
        /// <para>
        /// Attribute 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Attribute
        {
            get => _attribute;
            set
            {
                _attribute = value;
                OnPropertyChanged(nameof(Attribute));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public ConceptMapGroupElementTargetDependsOnValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Valueset
        /// </summary>
        /// <remarks>
        /// <para>
        /// Valueset 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Valueset
        {
            get => _valueset;
            set
            {
                _valueset = value;
                OnPropertyChanged(nameof(Valueset));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
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
        /// Valueset
        /// </summary>
        /// <remarks>
        /// <para>
        /// Valueset 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Valueset
        {
            get => _valueset;
            set
            {
                _valueset = value;
                OnPropertyChanged(nameof(Valueset));
            }
        }        /// <summary>
        /// Relationship
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relationship 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Relationship
        {
            get => _relationship;
            set
            {
                _relationship = value;
                OnPropertyChanged(nameof(Relationship));
            }
        }        /// <summary>
        /// Comment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Comment 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Comment
        {
            get => _comment;
            set
            {
                _comment = value;
                OnPropertyChanged(nameof(Comment));
            }
        }        /// <summary>
        /// Property
        /// </summary>
        /// <remarks>
        /// <para>
        /// Property 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ConceptMapGroupElementTargetProperty>? Property
        {
            get => _property;
            set
            {
                _property = value;
                OnPropertyChanged(nameof(Property));
            }
        }        /// <summary>
        /// Dependson
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dependson 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ConceptMapGroupElementTargetDependsOn>? Dependson
        {
            get => _dependson;
            set
            {
                _dependson = value;
                OnPropertyChanged(nameof(Dependson));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
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
        /// Valueset
        /// </summary>
        /// <remarks>
        /// <para>
        /// Valueset 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Valueset
        {
            get => _valueset;
            set
            {
                _valueset = value;
                OnPropertyChanged(nameof(Valueset));
            }
        }        /// <summary>
        /// Nomap
        /// </summary>
        /// <remarks>
        /// <para>
        /// Nomap 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Nomap
        {
            get => _nomap;
            set
            {
                _nomap = value;
                OnPropertyChanged(nameof(Nomap));
            }
        }        /// <summary>
        /// Target
        /// </summary>
        /// <remarks>
        /// <para>
        /// Target 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ConceptMapGroupElementTarget>? Target
        {
            get => _target;
            set
            {
                _target = value;
                OnPropertyChanged(nameof(Target));
            }
        }        /// <summary>
        /// Mode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Mode 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Mode
        {
            get => _mode;
            set
            {
                _mode = value;
                OnPropertyChanged(nameof(Mode));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
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
        /// Valueset
        /// </summary>
        /// <remarks>
        /// <para>
        /// Valueset 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Valueset
        {
            get => _valueset;
            set
            {
                _valueset = value;
                OnPropertyChanged(nameof(Valueset));
            }
        }        /// <summary>
        /// Relationship
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relationship 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Relationship
        {
            get => _relationship;
            set
            {
                _relationship = value;
                OnPropertyChanged(nameof(Relationship));
            }
        }        /// <summary>
        /// Othermap
        /// </summary>
        /// <remarks>
        /// <para>
        /// Othermap 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Othermap
        {
            get => _othermap;
            set
            {
                _othermap = value;
                OnPropertyChanged(nameof(Othermap));
            }
        }        /// <summary>
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
            }
        }        /// <summary>
        /// Target
        /// </summary>
        /// <remarks>
        /// <para>
        /// Target 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Target
        {
            get => _target;
            set
            {
                _target = value;
                OnPropertyChanged(nameof(Target));
            }
        }        /// <summary>
        /// Element
        /// </summary>
        /// <remarks>
        /// <para>
        /// Element 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ConceptMapGroupElement>? Element
        {
            get => _element;
            set
            {
                _element = value;
                OnPropertyChanged(nameof(Element));
            }
        }        /// <summary>
        /// Unmapped
        /// </summary>
        /// <remarks>
        /// <para>
        /// Unmapped 的詳細描述。
        /// </para>
        /// </remarks>
        public ConceptMapGroupUnmapped? Unmapped
        {
            get => _unmapped;
            set
            {
                _unmapped = value;
                OnPropertyChanged(nameof(Unmapped));
            }
        }        /// <summary>
        /// 建立新的 ConceptMap 資源實例
        /// </summary>
        public ConceptMap()
        {
        }

        /// <summary>
        /// 建立新的 ConceptMap 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ConceptMap(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ConceptMap(Id: {Id})";
        }
    }    /// <summary>
    /// ConceptMapProperty 背骨元素
    /// </summary>
    public class ConceptMapProperty
    {
        // TODO: 添加屬性實作
        
        public ConceptMapProperty() { }
    }    /// <summary>
    /// ConceptMapAdditionalAttribute 背骨元素
    /// </summary>
    public class ConceptMapAdditionalAttribute
    {
        // TODO: 添加屬性實作
        
        public ConceptMapAdditionalAttribute() { }
    }    /// <summary>
    /// ConceptMapGroupElementTargetProperty 背骨元素
    /// </summary>
    public class ConceptMapGroupElementTargetProperty
    {
        // TODO: 添加屬性實作
        
        public ConceptMapGroupElementTargetProperty() { }
    }    /// <summary>
    /// ConceptMapGroupElementTargetDependsOn 背骨元素
    /// </summary>
    public class ConceptMapGroupElementTargetDependsOn
    {
        // TODO: 添加屬性實作
        
        public ConceptMapGroupElementTargetDependsOn() { }
    }    /// <summary>
    /// ConceptMapGroupElementTarget 背骨元素
    /// </summary>
    public class ConceptMapGroupElementTarget
    {
        // TODO: 添加屬性實作
        
        public ConceptMapGroupElementTarget() { }
    }    /// <summary>
    /// ConceptMapGroupElement 背骨元素
    /// </summary>
    public class ConceptMapGroupElement
    {
        // TODO: 添加屬性實作
        
        public ConceptMapGroupElement() { }
    }    /// <summary>
    /// ConceptMapGroupUnmapped 背骨元素
    /// </summary>
    public class ConceptMapGroupUnmapped
    {
        // TODO: 添加屬性實作
        
        public ConceptMapGroupUnmapped() { }
    }    /// <summary>
    /// ConceptMapGroup 背骨元素
    /// </summary>
    public class ConceptMapGroup
    {
        // TODO: 添加屬性實作
        
        public ConceptMapGroup() { }
    }    /// <summary>
    /// ConceptMapVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class ConceptMapVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ConceptMapVersionAlgorithmChoice(JsonObject value) : base("conceptmapversionalgorithm", value, _supportType) { }
        public ConceptMapVersionAlgorithmChoice(IComplexType? value) : base("conceptmapversionalgorithm", value) { }
        public ConceptMapVersionAlgorithmChoice(IPrimitiveType? value) : base("conceptmapversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ConceptMapVersionAlgorithm" : "conceptmapversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ConceptMapSourceScopeChoice 選擇類型
    /// </summary>
    public class ConceptMapSourceScopeChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ConceptMapSourceScopeChoice(JsonObject value) : base("conceptmapsourcescope", value, _supportType) { }
        public ConceptMapSourceScopeChoice(IComplexType? value) : base("conceptmapsourcescope", value) { }
        public ConceptMapSourceScopeChoice(IPrimitiveType? value) : base("conceptmapsourcescope", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ConceptMapSourceScope" : "conceptmapsourcescope";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ConceptMapTargetScopeChoice 選擇類型
    /// </summary>
    public class ConceptMapTargetScopeChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ConceptMapTargetScopeChoice(JsonObject value) : base("conceptmaptargetscope", value, _supportType) { }
        public ConceptMapTargetScopeChoice(IComplexType? value) : base("conceptmaptargetscope", value) { }
        public ConceptMapTargetScopeChoice(IPrimitiveType? value) : base("conceptmaptargetscope", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ConceptMapTargetScope" : "conceptmaptargetscope";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ConceptMapGroupElementTargetPropertyValueChoice 選擇類型
    /// </summary>
    public class ConceptMapGroupElementTargetPropertyValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ConceptMapGroupElementTargetPropertyValueChoice(JsonObject value) : base("conceptmapgroupelementtargetpropertyvalue", value, _supportType) { }
        public ConceptMapGroupElementTargetPropertyValueChoice(IComplexType? value) : base("conceptmapgroupelementtargetpropertyvalue", value) { }
        public ConceptMapGroupElementTargetPropertyValueChoice(IPrimitiveType? value) : base("conceptmapgroupelementtargetpropertyvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ConceptMapGroupElementTargetPropertyValue" : "conceptmapgroupelementtargetpropertyvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ConceptMapGroupElementTargetDependsOnValueChoice 選擇類型
    /// </summary>
    public class ConceptMapGroupElementTargetDependsOnValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ConceptMapGroupElementTargetDependsOnValueChoice(JsonObject value) : base("conceptmapgroupelementtargetdependsonvalue", value, _supportType) { }
        public ConceptMapGroupElementTargetDependsOnValueChoice(IComplexType? value) : base("conceptmapgroupelementtargetdependsonvalue", value) { }
        public ConceptMapGroupElementTargetDependsOnValueChoice(IPrimitiveType? value) : base("conceptmapgroupelementtargetdependsonvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ConceptMapGroupElementTargetDependsOnValue" : "conceptmapgroupelementtargetdependsonvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
