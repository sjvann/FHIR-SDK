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
    /// FHIR R5 TerminologyCapabilities 資源
    /// 
    /// <para>
    /// TerminologyCapabilities 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var terminologycapabilities = new TerminologyCapabilities("terminologycapabilities-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 TerminologyCapabilities 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class TerminologyCapabilities : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private TerminologyCapabilitiesVersionAlgorithmChoice? _versionalgorithm;
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
        private FhirCode? _kind;
        private TerminologyCapabilitiesSoftware? _software;
        private TerminologyCapabilitiesImplementation? _implementation;
        private FhirBoolean? _lockeddate;
        private List<TerminologyCapabilitiesCodeSystem>? _codesystem;
        private TerminologyCapabilitiesExpansion? _expansion;
        private FhirCode? _codesearch;
        private TerminologyCapabilitiesValidateCode? _validatecode;
        private TerminologyCapabilitiesTranslation? _translation;
        private TerminologyCapabilitiesClosure? _closure;
        private FhirString? _name;
        private FhirString? _version;
        private FhirString? _description;
        private FhirUrl? _url;
        private FhirCode? _code;
        private List<FhirCode>? _op;
        private FhirString? _code;
        private FhirBoolean? _isdefault;
        private FhirBoolean? _compositional;
        private List<FhirCode>? _language;
        private List<TerminologyCapabilitiesCodeSystemVersionFilter>? _filter;
        private List<FhirCode>? _property;
        private FhirCanonical? _uri;
        private List<TerminologyCapabilitiesCodeSystemVersion>? _version;
        private FhirCode? _content;
        private FhirBoolean? _subsumption;
        private FhirCode? _name;
        private FhirString? _documentation;
        private FhirBoolean? _hierarchical;
        private FhirBoolean? _paging;
        private FhirBoolean? _incomplete;
        private List<TerminologyCapabilitiesExpansionParameter>? _parameter;
        private FhirMarkdown? _textfilter;
        private FhirBoolean? _translations;
        private FhirBoolean? _needsmap;
        private FhirBoolean? _translation;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "TerminologyCapabilities";        /// <summary>
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
        public TerminologyCapabilitiesVersionAlgorithmChoice? Versionalgorithm
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
        /// Software
        /// </summary>
        /// <remarks>
        /// <para>
        /// Software 的詳細描述。
        /// </para>
        /// </remarks>
        public TerminologyCapabilitiesSoftware? Software
        {
            get => _software;
            set
            {
                _software = value;
                OnPropertyChanged(nameof(Software));
            }
        }        /// <summary>
        /// Implementation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Implementation 的詳細描述。
        /// </para>
        /// </remarks>
        public TerminologyCapabilitiesImplementation? Implementation
        {
            get => _implementation;
            set
            {
                _implementation = value;
                OnPropertyChanged(nameof(Implementation));
            }
        }        /// <summary>
        /// Lockeddate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Lockeddate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Lockeddate
        {
            get => _lockeddate;
            set
            {
                _lockeddate = value;
                OnPropertyChanged(nameof(Lockeddate));
            }
        }        /// <summary>
        /// Codesystem
        /// </summary>
        /// <remarks>
        /// <para>
        /// Codesystem 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TerminologyCapabilitiesCodeSystem>? Codesystem
        {
            get => _codesystem;
            set
            {
                _codesystem = value;
                OnPropertyChanged(nameof(Codesystem));
            }
        }        /// <summary>
        /// Expansion
        /// </summary>
        /// <remarks>
        /// <para>
        /// Expansion 的詳細描述。
        /// </para>
        /// </remarks>
        public TerminologyCapabilitiesExpansion? Expansion
        {
            get => _expansion;
            set
            {
                _expansion = value;
                OnPropertyChanged(nameof(Expansion));
            }
        }        /// <summary>
        /// Codesearch
        /// </summary>
        /// <remarks>
        /// <para>
        /// Codesearch 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Codesearch
        {
            get => _codesearch;
            set
            {
                _codesearch = value;
                OnPropertyChanged(nameof(Codesearch));
            }
        }        /// <summary>
        /// Validatecode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Validatecode 的詳細描述。
        /// </para>
        /// </remarks>
        public TerminologyCapabilitiesValidateCode? Validatecode
        {
            get => _validatecode;
            set
            {
                _validatecode = value;
                OnPropertyChanged(nameof(Validatecode));
            }
        }        /// <summary>
        /// Translation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Translation 的詳細描述。
        /// </para>
        /// </remarks>
        public TerminologyCapabilitiesTranslation? Translation
        {
            get => _translation;
            set
            {
                _translation = value;
                OnPropertyChanged(nameof(Translation));
            }
        }        /// <summary>
        /// Closure
        /// </summary>
        /// <remarks>
        /// <para>
        /// Closure 的詳細描述。
        /// </para>
        /// </remarks>
        public TerminologyCapabilitiesClosure? Closure
        {
            get => _closure;
            set
            {
                _closure = value;
                OnPropertyChanged(nameof(Closure));
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
        /// Url
        /// </summary>
        /// <remarks>
        /// <para>
        /// Url 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUrl? Url
        {
            get => _url;
            set
            {
                _url = value;
                OnPropertyChanged(nameof(Url));
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
        /// Op
        /// </summary>
        /// <remarks>
        /// <para>
        /// Op 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Op
        {
            get => _op;
            set
            {
                _op = value;
                OnPropertyChanged(nameof(Op));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Isdefault
        /// </summary>
        /// <remarks>
        /// <para>
        /// Isdefault 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Isdefault
        {
            get => _isdefault;
            set
            {
                _isdefault = value;
                OnPropertyChanged(nameof(Isdefault));
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
        /// Language
        /// </summary>
        /// <remarks>
        /// <para>
        /// Language 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Language
        {
            get => _language;
            set
            {
                _language = value;
                OnPropertyChanged(nameof(Language));
            }
        }        /// <summary>
        /// Filter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Filter 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TerminologyCapabilitiesCodeSystemVersionFilter>? Filter
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
        public List<FhirCode>? Property
        {
            get => _property;
            set
            {
                _property = value;
                OnPropertyChanged(nameof(Property));
            }
        }        /// <summary>
        /// Uri
        /// </summary>
        /// <remarks>
        /// <para>
        /// Uri 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Uri
        {
            get => _uri;
            set
            {
                _uri = value;
                OnPropertyChanged(nameof(Uri));
            }
        }        /// <summary>
        /// Version
        /// </summary>
        /// <remarks>
        /// <para>
        /// Version 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TerminologyCapabilitiesCodeSystemVersion>? Version
        {
            get => _version;
            set
            {
                _version = value;
                OnPropertyChanged(nameof(Version));
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
        /// Subsumption
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subsumption 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Subsumption
        {
            get => _subsumption;
            set
            {
                _subsumption = value;
                OnPropertyChanged(nameof(Subsumption));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Documentation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Documentation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Documentation
        {
            get => _documentation;
            set
            {
                _documentation = value;
                OnPropertyChanged(nameof(Documentation));
            }
        }        /// <summary>
        /// Hierarchical
        /// </summary>
        /// <remarks>
        /// <para>
        /// Hierarchical 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Hierarchical
        {
            get => _hierarchical;
            set
            {
                _hierarchical = value;
                OnPropertyChanged(nameof(Hierarchical));
            }
        }        /// <summary>
        /// Paging
        /// </summary>
        /// <remarks>
        /// <para>
        /// Paging 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Paging
        {
            get => _paging;
            set
            {
                _paging = value;
                OnPropertyChanged(nameof(Paging));
            }
        }        /// <summary>
        /// Incomplete
        /// </summary>
        /// <remarks>
        /// <para>
        /// Incomplete 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Incomplete
        {
            get => _incomplete;
            set
            {
                _incomplete = value;
                OnPropertyChanged(nameof(Incomplete));
            }
        }        /// <summary>
        /// Parameter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Parameter 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TerminologyCapabilitiesExpansionParameter>? Parameter
        {
            get => _parameter;
            set
            {
                _parameter = value;
                OnPropertyChanged(nameof(Parameter));
            }
        }        /// <summary>
        /// Textfilter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Textfilter 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Textfilter
        {
            get => _textfilter;
            set
            {
                _textfilter = value;
                OnPropertyChanged(nameof(Textfilter));
            }
        }        /// <summary>
        /// Translations
        /// </summary>
        /// <remarks>
        /// <para>
        /// Translations 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Translations
        {
            get => _translations;
            set
            {
                _translations = value;
                OnPropertyChanged(nameof(Translations));
            }
        }        /// <summary>
        /// Needsmap
        /// </summary>
        /// <remarks>
        /// <para>
        /// Needsmap 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Needsmap
        {
            get => _needsmap;
            set
            {
                _needsmap = value;
                OnPropertyChanged(nameof(Needsmap));
            }
        }        /// <summary>
        /// Translation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Translation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Translation
        {
            get => _translation;
            set
            {
                _translation = value;
                OnPropertyChanged(nameof(Translation));
            }
        }        /// <summary>
        /// 建立新的 TerminologyCapabilities 資源實例
        /// </summary>
        public TerminologyCapabilities()
        {
        }

        /// <summary>
        /// 建立新的 TerminologyCapabilities 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public TerminologyCapabilities(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"TerminologyCapabilities(Id: {Id})";
        }
    }    /// <summary>
    /// TerminologyCapabilitiesSoftware 背骨元素
    /// </summary>
    public class TerminologyCapabilitiesSoftware
    {
        // TODO: 添加屬性實作
        
        public TerminologyCapabilitiesSoftware() { }
    }    /// <summary>
    /// TerminologyCapabilitiesImplementation 背骨元素
    /// </summary>
    public class TerminologyCapabilitiesImplementation
    {
        // TODO: 添加屬性實作
        
        public TerminologyCapabilitiesImplementation() { }
    }    /// <summary>
    /// TerminologyCapabilitiesCodeSystemVersionFilter 背骨元素
    /// </summary>
    public class TerminologyCapabilitiesCodeSystemVersionFilter
    {
        // TODO: 添加屬性實作
        
        public TerminologyCapabilitiesCodeSystemVersionFilter() { }
    }    /// <summary>
    /// TerminologyCapabilitiesCodeSystemVersion 背骨元素
    /// </summary>
    public class TerminologyCapabilitiesCodeSystemVersion
    {
        // TODO: 添加屬性實作
        
        public TerminologyCapabilitiesCodeSystemVersion() { }
    }    /// <summary>
    /// TerminologyCapabilitiesCodeSystem 背骨元素
    /// </summary>
    public class TerminologyCapabilitiesCodeSystem
    {
        // TODO: 添加屬性實作
        
        public TerminologyCapabilitiesCodeSystem() { }
    }    /// <summary>
    /// TerminologyCapabilitiesExpansionParameter 背骨元素
    /// </summary>
    public class TerminologyCapabilitiesExpansionParameter
    {
        // TODO: 添加屬性實作
        
        public TerminologyCapabilitiesExpansionParameter() { }
    }    /// <summary>
    /// TerminologyCapabilitiesExpansion 背骨元素
    /// </summary>
    public class TerminologyCapabilitiesExpansion
    {
        // TODO: 添加屬性實作
        
        public TerminologyCapabilitiesExpansion() { }
    }    /// <summary>
    /// TerminologyCapabilitiesValidateCode 背骨元素
    /// </summary>
    public class TerminologyCapabilitiesValidateCode
    {
        // TODO: 添加屬性實作
        
        public TerminologyCapabilitiesValidateCode() { }
    }    /// <summary>
    /// TerminologyCapabilitiesTranslation 背骨元素
    /// </summary>
    public class TerminologyCapabilitiesTranslation
    {
        // TODO: 添加屬性實作
        
        public TerminologyCapabilitiesTranslation() { }
    }    /// <summary>
    /// TerminologyCapabilitiesClosure 背骨元素
    /// </summary>
    public class TerminologyCapabilitiesClosure
    {
        // TODO: 添加屬性實作
        
        public TerminologyCapabilitiesClosure() { }
    }    /// <summary>
    /// TerminologyCapabilitiesVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class TerminologyCapabilitiesVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public TerminologyCapabilitiesVersionAlgorithmChoice(JsonObject value) : base("terminologycapabilitiesversionalgorithm", value, _supportType) { }
        public TerminologyCapabilitiesVersionAlgorithmChoice(IComplexType? value) : base("terminologycapabilitiesversionalgorithm", value) { }
        public TerminologyCapabilitiesVersionAlgorithmChoice(IPrimitiveType? value) : base("terminologycapabilitiesversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "TerminologyCapabilitiesVersionAlgorithm" : "terminologycapabilitiesversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
