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
    /// FHIR R5 ValueSet 資源
    /// 
    /// <para>
    /// ValueSet 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var valueset = new ValueSet("valueset-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 ValueSet 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ValueSet : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private ValueSetVersionAlgorithmChoice? _versionalgorithm;
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
        private FhirBoolean? _immutable;
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
        private ValueSetCompose? _compose;
        private ValueSetExpansion? _expansion;
        private ValueSetScope? _scope;
        private FhirCode? _language;
        private Coding? _use;
        private List<Coding>? _additionaluse;
        private FhirString? _value;
        private FhirCode? _code;
        private FhirString? _display;
        private List<ValueSetComposeIncludeConceptDesignation>? _designation;
        private FhirCode? _property;
        private FhirCode? _op;
        private FhirString? _value;
        private FhirUri? _system;
        private FhirString? _version;
        private List<ValueSetComposeIncludeConcept>? _concept;
        private List<ValueSetComposeIncludeFilter>? _filter;
        private List<FhirCanonical>? _valueset;
        private FhirString? _copyright;
        private FhirDate? _lockeddate;
        private FhirBoolean? _inactive;
        private List<ValueSetComposeInclude>? _include;
        private List<FhirString>? _property;
        private FhirString? _name;
        private ValueSetExpansionParameterValueChoice? _value;
        private FhirCode? _code;
        private FhirUri? _uri;
        private FhirCode? _code;
        private ValueSetExpansionContainsPropertySubPropertyValueChoice? _value;
        private FhirCode? _code;
        private ValueSetExpansionContainsPropertyValueChoice? _value;
        private List<ValueSetExpansionContainsPropertySubProperty>? _subproperty;
        private FhirUri? _system;
        private FhirBoolean? _abstract;
        private FhirBoolean? _inactive;
        private FhirString? _version;
        private FhirCode? _code;
        private FhirString? _display;
        private List<ValueSetExpansionContainsProperty>? _property;
        private FhirUri? _identifier;
        private FhirUri? _next;
        private FhirDateTime? _timestamp;
        private FhirInteger? _total;
        private FhirInteger? _offset;
        private List<ValueSetExpansionParameter>? _parameter;
        private List<ValueSetExpansionProperty>? _property;
        private List<ValueSetExpansionContains>? _contains;
        private FhirString? _inclusioncriteria;
        private FhirString? _exclusioncriteria;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ValueSet";        /// <summary>
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
        public ValueSetVersionAlgorithmChoice? Versionalgorithm
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
        /// Immutable
        /// </summary>
        /// <remarks>
        /// <para>
        /// Immutable 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Immutable
        {
            get => _immutable;
            set
            {
                _immutable = value;
                OnPropertyChanged(nameof(Immutable));
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
        /// Compose
        /// </summary>
        /// <remarks>
        /// <para>
        /// Compose 的詳細描述。
        /// </para>
        /// </remarks>
        public ValueSetCompose? Compose
        {
            get => _compose;
            set
            {
                _compose = value;
                OnPropertyChanged(nameof(Compose));
            }
        }        /// <summary>
        /// Expansion
        /// </summary>
        /// <remarks>
        /// <para>
        /// Expansion 的詳細描述。
        /// </para>
        /// </remarks>
        public ValueSetExpansion? Expansion
        {
            get => _expansion;
            set
            {
                _expansion = value;
                OnPropertyChanged(nameof(Expansion));
            }
        }        /// <summary>
        /// Scope
        /// </summary>
        /// <remarks>
        /// <para>
        /// Scope 的詳細描述。
        /// </para>
        /// </remarks>
        public ValueSetScope? Scope
        {
            get => _scope;
            set
            {
                _scope = value;
                OnPropertyChanged(nameof(Scope));
            }
        }        /// <summary>
        /// Language
        /// </summary>
        /// <remarks>
        /// <para>
        /// Language 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Language
        {
            get => _language;
            set
            {
                _language = value;
                OnPropertyChanged(nameof(Language));
            }
        }        /// <summary>
        /// Use
        /// </summary>
        /// <remarks>
        /// <para>
        /// Use 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? Use
        {
            get => _use;
            set
            {
                _use = value;
                OnPropertyChanged(nameof(Use));
            }
        }        /// <summary>
        /// Additionaluse
        /// </summary>
        /// <remarks>
        /// <para>
        /// Additionaluse 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Coding>? Additionaluse
        {
            get => _additionaluse;
            set
            {
                _additionaluse = value;
                OnPropertyChanged(nameof(Additionaluse));
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
        /// Designation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Designation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ValueSetComposeIncludeConceptDesignation>? Designation
        {
            get => _designation;
            set
            {
                _designation = value;
                OnPropertyChanged(nameof(Designation));
            }
        }        /// <summary>
        /// Property
        /// </summary>
        /// <remarks>
        /// <para>
        /// Property 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Property
        {
            get => _property;
            set
            {
                _property = value;
                OnPropertyChanged(nameof(Property));
            }
        }        /// <summary>
        /// Op
        /// </summary>
        /// <remarks>
        /// <para>
        /// Op 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Op
        {
            get => _op;
            set
            {
                _op = value;
                OnPropertyChanged(nameof(Op));
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
        /// System
        /// </summary>
        /// <remarks>
        /// <para>
        /// System 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? System
        {
            get => _system;
            set
            {
                _system = value;
                OnPropertyChanged(nameof(System));
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
        /// Concept
        /// </summary>
        /// <remarks>
        /// <para>
        /// Concept 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ValueSetComposeIncludeConcept>? Concept
        {
            get => _concept;
            set
            {
                _concept = value;
                OnPropertyChanged(nameof(Concept));
            }
        }        /// <summary>
        /// Filter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Filter 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ValueSetComposeIncludeFilter>? Filter
        {
            get => _filter;
            set
            {
                _filter = value;
                OnPropertyChanged(nameof(Filter));
            }
        }        /// <summary>
        /// Valueset
        /// </summary>
        /// <remarks>
        /// <para>
        /// Valueset 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Valueset
        {
            get => _valueset;
            set
            {
                _valueset = value;
                OnPropertyChanged(nameof(Valueset));
            }
        }        /// <summary>
        /// Copyright
        /// </summary>
        /// <remarks>
        /// <para>
        /// Copyright 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Copyright
        {
            get => _copyright;
            set
            {
                _copyright = value;
                OnPropertyChanged(nameof(Copyright));
            }
        }        /// <summary>
        /// Lockeddate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Lockeddate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Lockeddate
        {
            get => _lockeddate;
            set
            {
                _lockeddate = value;
                OnPropertyChanged(nameof(Lockeddate));
            }
        }        /// <summary>
        /// Inactive
        /// </summary>
        /// <remarks>
        /// <para>
        /// Inactive 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Inactive
        {
            get => _inactive;
            set
            {
                _inactive = value;
                OnPropertyChanged(nameof(Inactive));
            }
        }        /// <summary>
        /// Include
        /// </summary>
        /// <remarks>
        /// <para>
        /// Include 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ValueSetComposeInclude>? Include
        {
            get => _include;
            set
            {
                _include = value;
                OnPropertyChanged(nameof(Include));
            }
        }        /// <summary>
        /// Property
        /// </summary>
        /// <remarks>
        /// <para>
        /// Property 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Property
        {
            get => _property;
            set
            {
                _property = value;
                OnPropertyChanged(nameof(Property));
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
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public ValueSetExpansionParameterValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
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
        public ValueSetExpansionContainsPropertySubPropertyValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
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
        public ValueSetExpansionContainsPropertyValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Subproperty
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subproperty 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ValueSetExpansionContainsPropertySubProperty>? Subproperty
        {
            get => _subproperty;
            set
            {
                _subproperty = value;
                OnPropertyChanged(nameof(Subproperty));
            }
        }        /// <summary>
        /// System
        /// </summary>
        /// <remarks>
        /// <para>
        /// System 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? System
        {
            get => _system;
            set
            {
                _system = value;
                OnPropertyChanged(nameof(System));
            }
        }        /// <summary>
        /// Abstract
        /// </summary>
        /// <remarks>
        /// <para>
        /// Abstract 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Abstract
        {
            get => _abstract;
            set
            {
                _abstract = value;
                OnPropertyChanged(nameof(Abstract));
            }
        }        /// <summary>
        /// Inactive
        /// </summary>
        /// <remarks>
        /// <para>
        /// Inactive 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Inactive
        {
            get => _inactive;
            set
            {
                _inactive = value;
                OnPropertyChanged(nameof(Inactive));
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
        /// Property
        /// </summary>
        /// <remarks>
        /// <para>
        /// Property 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ValueSetExpansionContainsProperty>? Property
        {
            get => _property;
            set
            {
                _property = value;
                OnPropertyChanged(nameof(Property));
            }
        }        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
            }
        }        /// <summary>
        /// Next
        /// </summary>
        /// <remarks>
        /// <para>
        /// Next 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Next
        {
            get => _next;
            set
            {
                _next = value;
                OnPropertyChanged(nameof(Next));
            }
        }        /// <summary>
        /// Timestamp
        /// </summary>
        /// <remarks>
        /// <para>
        /// Timestamp 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Timestamp
        {
            get => _timestamp;
            set
            {
                _timestamp = value;
                OnPropertyChanged(nameof(Timestamp));
            }
        }        /// <summary>
        /// Total
        /// </summary>
        /// <remarks>
        /// <para>
        /// Total 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Total
        {
            get => _total;
            set
            {
                _total = value;
                OnPropertyChanged(nameof(Total));
            }
        }        /// <summary>
        /// Offset
        /// </summary>
        /// <remarks>
        /// <para>
        /// Offset 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Offset
        {
            get => _offset;
            set
            {
                _offset = value;
                OnPropertyChanged(nameof(Offset));
            }
        }        /// <summary>
        /// Parameter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Parameter 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ValueSetExpansionParameter>? Parameter
        {
            get => _parameter;
            set
            {
                _parameter = value;
                OnPropertyChanged(nameof(Parameter));
            }
        }        /// <summary>
        /// Property
        /// </summary>
        /// <remarks>
        /// <para>
        /// Property 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ValueSetExpansionProperty>? Property
        {
            get => _property;
            set
            {
                _property = value;
                OnPropertyChanged(nameof(Property));
            }
        }        /// <summary>
        /// Contains
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contains 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ValueSetExpansionContains>? Contains
        {
            get => _contains;
            set
            {
                _contains = value;
                OnPropertyChanged(nameof(Contains));
            }
        }        /// <summary>
        /// Inclusioncriteria
        /// </summary>
        /// <remarks>
        /// <para>
        /// Inclusioncriteria 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Inclusioncriteria
        {
            get => _inclusioncriteria;
            set
            {
                _inclusioncriteria = value;
                OnPropertyChanged(nameof(Inclusioncriteria));
            }
        }        /// <summary>
        /// Exclusioncriteria
        /// </summary>
        /// <remarks>
        /// <para>
        /// Exclusioncriteria 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Exclusioncriteria
        {
            get => _exclusioncriteria;
            set
            {
                _exclusioncriteria = value;
                OnPropertyChanged(nameof(Exclusioncriteria));
            }
        }        /// <summary>
        /// 建立新的 ValueSet 資源實例
        /// </summary>
        public ValueSet()
        {
        }

        /// <summary>
        /// 建立新的 ValueSet 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ValueSet(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ValueSet(Id: {Id})";
        }
    }    /// <summary>
    /// ValueSetComposeIncludeConceptDesignation 背骨元素
    /// </summary>
    public class ValueSetComposeIncludeConceptDesignation
    {
        // TODO: 添加屬性實作
        
        public ValueSetComposeIncludeConceptDesignation() { }
    }    /// <summary>
    /// ValueSetComposeIncludeConcept 背骨元素
    /// </summary>
    public class ValueSetComposeIncludeConcept
    {
        // TODO: 添加屬性實作
        
        public ValueSetComposeIncludeConcept() { }
    }    /// <summary>
    /// ValueSetComposeIncludeFilter 背骨元素
    /// </summary>
    public class ValueSetComposeIncludeFilter
    {
        // TODO: 添加屬性實作
        
        public ValueSetComposeIncludeFilter() { }
    }    /// <summary>
    /// ValueSetComposeInclude 背骨元素
    /// </summary>
    public class ValueSetComposeInclude
    {
        // TODO: 添加屬性實作
        
        public ValueSetComposeInclude() { }
    }    /// <summary>
    /// ValueSetCompose 背骨元素
    /// </summary>
    public class ValueSetCompose
    {
        // TODO: 添加屬性實作
        
        public ValueSetCompose() { }
    }    /// <summary>
    /// ValueSetExpansionParameter 背骨元素
    /// </summary>
    public class ValueSetExpansionParameter
    {
        // TODO: 添加屬性實作
        
        public ValueSetExpansionParameter() { }
    }    /// <summary>
    /// ValueSetExpansionProperty 背骨元素
    /// </summary>
    public class ValueSetExpansionProperty
    {
        // TODO: 添加屬性實作
        
        public ValueSetExpansionProperty() { }
    }    /// <summary>
    /// ValueSetExpansionContainsPropertySubProperty 背骨元素
    /// </summary>
    public class ValueSetExpansionContainsPropertySubProperty
    {
        // TODO: 添加屬性實作
        
        public ValueSetExpansionContainsPropertySubProperty() { }
    }    /// <summary>
    /// ValueSetExpansionContainsProperty 背骨元素
    /// </summary>
    public class ValueSetExpansionContainsProperty
    {
        // TODO: 添加屬性實作
        
        public ValueSetExpansionContainsProperty() { }
    }    /// <summary>
    /// ValueSetExpansionContains 背骨元素
    /// </summary>
    public class ValueSetExpansionContains
    {
        // TODO: 添加屬性實作
        
        public ValueSetExpansionContains() { }
    }    /// <summary>
    /// ValueSetExpansion 背骨元素
    /// </summary>
    public class ValueSetExpansion
    {
        // TODO: 添加屬性實作
        
        public ValueSetExpansion() { }
    }    /// <summary>
    /// ValueSetScope 背骨元素
    /// </summary>
    public class ValueSetScope
    {
        // TODO: 添加屬性實作
        
        public ValueSetScope() { }
    }    /// <summary>
    /// ValueSetVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class ValueSetVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ValueSetVersionAlgorithmChoice(JsonObject value) : base("valuesetversionalgorithm", value, _supportType) { }
        public ValueSetVersionAlgorithmChoice(IComplexType? value) : base("valuesetversionalgorithm", value) { }
        public ValueSetVersionAlgorithmChoice(IPrimitiveType? value) : base("valuesetversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ValueSetVersionAlgorithm" : "valuesetversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ValueSetExpansionParameterValueChoice 選擇類型
    /// </summary>
    public class ValueSetExpansionParameterValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ValueSetExpansionParameterValueChoice(JsonObject value) : base("valuesetexpansionparametervalue", value, _supportType) { }
        public ValueSetExpansionParameterValueChoice(IComplexType? value) : base("valuesetexpansionparametervalue", value) { }
        public ValueSetExpansionParameterValueChoice(IPrimitiveType? value) : base("valuesetexpansionparametervalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ValueSetExpansionParameterValue" : "valuesetexpansionparametervalue";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ValueSetExpansionContainsPropertyValueChoice 選擇類型
    /// </summary>
    public class ValueSetExpansionContainsPropertyValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ValueSetExpansionContainsPropertyValueChoice(JsonObject value) : base("valuesetexpansioncontainspropertyvalue", value, _supportType) { }
        public ValueSetExpansionContainsPropertyValueChoice(IComplexType? value) : base("valuesetexpansioncontainspropertyvalue", value) { }
        public ValueSetExpansionContainsPropertyValueChoice(IPrimitiveType? value) : base("valuesetexpansioncontainspropertyvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ValueSetExpansionContainsPropertyValue" : "valuesetexpansioncontainspropertyvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ValueSetExpansionContainsPropertySubPropertyValueChoice 選擇類型
    /// </summary>
    public class ValueSetExpansionContainsPropertySubPropertyValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ValueSetExpansionContainsPropertySubPropertyValueChoice(JsonObject value) : base("valuesetexpansioncontainspropertysubpropertyvalue", value, _supportType) { }
        public ValueSetExpansionContainsPropertySubPropertyValueChoice(IComplexType? value) : base("valuesetexpansioncontainspropertysubpropertyvalue", value) { }
        public ValueSetExpansionContainsPropertySubPropertyValueChoice(IPrimitiveType? value) : base("valuesetexpansioncontainspropertysubpropertyvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ValueSetExpansionContainsPropertySubPropertyValue" : "valuesetexpansioncontainspropertysubpropertyvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
