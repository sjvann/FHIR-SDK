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
    /// FHIR R5 CodeSystem 資源
    /// 
    /// <para>
    /// CodeSystem 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var codesystem = new CodeSystem("codesystem-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 CodeSystem 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class CodeSystem : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private CodeSystemVersionAlgorithmChoice? _versionalgorithm;
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
        private FhirBoolean? _casesensitive;
        private FhirCanonical? _valueset;
        private FhirCode? _hierarchymeaning;
        private FhirBoolean? _compositional;
        private FhirBoolean? _versionneeded;
        private FhirCode? _content;
        private FhirCanonical? _supplements;
        private FhirUnsignedInt? _count;
        private List<CodeSystemFilter>? _filter;
        private List<CodeSystemProperty>? _property;
        private List<CodeSystemConcept>? _concept;
        private FhirCode? _code;
        private FhirString? _description;
        private List<FhirCode>? _operator;
        private FhirString? _value;
        private FhirCode? _code;
        private FhirUri? _uri;
        private FhirString? _description;
        private FhirCode? _type;
        private FhirCode? _language;
        private Coding? _use;
        private List<Coding>? _additionaluse;
        private FhirString? _value;
        private FhirCode? _code;
        private CodeSystemConceptPropertyValueChoice? _value;
        private FhirCode? _code;
        private FhirString? _display;
        private FhirString? _definition;
        private List<CodeSystemConceptDesignation>? _designation;
        private List<CodeSystemConceptProperty>? _property;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "CodeSystem";        /// <summary>
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
        public CodeSystemVersionAlgorithmChoice? Versionalgorithm
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
        /// Casesensitive
        /// </summary>
        /// <remarks>
        /// <para>
        /// Casesensitive 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Casesensitive
        {
            get => _casesensitive;
            set
            {
                _casesensitive = value;
                OnPropertyChanged(nameof(Casesensitive));
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
        /// Hierarchymeaning
        /// </summary>
        /// <remarks>
        /// <para>
        /// Hierarchymeaning 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Hierarchymeaning
        {
            get => _hierarchymeaning;
            set
            {
                _hierarchymeaning = value;
                OnPropertyChanged(nameof(Hierarchymeaning));
            }
        }        /// <summary>
        /// Compositional
        /// </summary>
        /// <remarks>
        /// <para>
        /// Compositional 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Compositional
        {
            get => _compositional;
            set
            {
                _compositional = value;
                OnPropertyChanged(nameof(Compositional));
            }
        }        /// <summary>
        /// Versionneeded
        /// </summary>
        /// <remarks>
        /// <para>
        /// Versionneeded 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Versionneeded
        {
            get => _versionneeded;
            set
            {
                _versionneeded = value;
                OnPropertyChanged(nameof(Versionneeded));
            }
        }        /// <summary>
        /// Content
        /// </summary>
        /// <remarks>
        /// <para>
        /// Content 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged(nameof(Content));
            }
        }        /// <summary>
        /// Supplements
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supplements 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Supplements
        {
            get => _supplements;
            set
            {
                _supplements = value;
                OnPropertyChanged(nameof(Supplements));
            }
        }        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// <para>
        /// Count 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? Count
        {
            get => _count;
            set
            {
                _count = value;
                OnPropertyChanged(nameof(Count));
            }
        }        /// <summary>
        /// Filter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Filter 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeSystemFilter>? Filter
        {
            get => _filter;
            set
            {
                _filter = value;
                OnPropertyChanged(nameof(Filter));
            }
        }        /// <summary>
        /// Property
        /// </summary>
        /// <remarks>
        /// <para>
        /// Property 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeSystemProperty>? Property
        {
            get => _property;
            set
            {
                _property = value;
                OnPropertyChanged(nameof(Property));
            }
        }        /// <summary>
        /// Concept
        /// </summary>
        /// <remarks>
        /// <para>
        /// Concept 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeSystemConcept>? Concept
        {
            get => _concept;
            set
            {
                _concept = value;
                OnPropertyChanged(nameof(Concept));
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
        /// Operator
        /// </summary>
        /// <remarks>
        /// <para>
        /// Operator 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Operator
        {
            get => _operator;
            set
            {
                _operator = value;
                OnPropertyChanged(nameof(Operator));
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
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeSystemConceptPropertyValueChoice? Value
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
        /// Definition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definition 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Definition
        {
            get => _definition;
            set
            {
                _definition = value;
                OnPropertyChanged(nameof(Definition));
            }
        }        /// <summary>
        /// Designation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Designation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeSystemConceptDesignation>? Designation
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
        public List<CodeSystemConceptProperty>? Property
        {
            get => _property;
            set
            {
                _property = value;
                OnPropertyChanged(nameof(Property));
            }
        }        /// <summary>
        /// 建立新的 CodeSystem 資源實例
        /// </summary>
        public CodeSystem()
        {
        }

        /// <summary>
        /// 建立新的 CodeSystem 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public CodeSystem(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"CodeSystem(Id: {Id})";
        }
    }    /// <summary>
    /// CodeSystemFilter 背骨元素
    /// </summary>
    public class CodeSystemFilter
    {
        // TODO: 添加屬性實作
        
        public CodeSystemFilter() { }
    }    /// <summary>
    /// CodeSystemProperty 背骨元素
    /// </summary>
    public class CodeSystemProperty
    {
        // TODO: 添加屬性實作
        
        public CodeSystemProperty() { }
    }    /// <summary>
    /// CodeSystemConceptDesignation 背骨元素
    /// </summary>
    public class CodeSystemConceptDesignation
    {
        // TODO: 添加屬性實作
        
        public CodeSystemConceptDesignation() { }
    }    /// <summary>
    /// CodeSystemConceptProperty 背骨元素
    /// </summary>
    public class CodeSystemConceptProperty
    {
        // TODO: 添加屬性實作
        
        public CodeSystemConceptProperty() { }
    }    /// <summary>
    /// CodeSystemConcept 背骨元素
    /// </summary>
    public class CodeSystemConcept
    {
        // TODO: 添加屬性實作
        
        public CodeSystemConcept() { }
    }    /// <summary>
    /// CodeSystemVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class CodeSystemVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public CodeSystemVersionAlgorithmChoice(JsonObject value) : base("codesystemversionalgorithm", value, _supportType) { }
        public CodeSystemVersionAlgorithmChoice(IComplexType? value) : base("codesystemversionalgorithm", value) { }
        public CodeSystemVersionAlgorithmChoice(IPrimitiveType? value) : base("codesystemversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "CodeSystemVersionAlgorithm" : "codesystemversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// CodeSystemConceptPropertyValueChoice 選擇類型
    /// </summary>
    public class CodeSystemConceptPropertyValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public CodeSystemConceptPropertyValueChoice(JsonObject value) : base("codesystemconceptpropertyvalue", value, _supportType) { }
        public CodeSystemConceptPropertyValueChoice(IComplexType? value) : base("codesystemconceptpropertyvalue", value) { }
        public CodeSystemConceptPropertyValueChoice(IPrimitiveType? value) : base("codesystemconceptpropertyvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "CodeSystemConceptPropertyValue" : "codesystemconceptpropertyvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
