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
    /// FHIR R5 StructureDefinition 資源
    /// 
    /// <para>
    /// StructureDefinition 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var structuredefinition = new StructureDefinition("structuredefinition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 StructureDefinition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class StructureDefinition : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private StructureDefinitionVersionAlgorithmChoice? _versionalgorithm;
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
        private List<Coding>? _keyword;
        private FhirCode? _fhirversion;
        private List<StructureDefinitionMapping>? _mapping;
        private FhirCode? _kind;
        private FhirBoolean? _abstract;
        private List<StructureDefinitionContext>? _context;
        private List<FhirString>? _contextinvariant;
        private FhirUri? _type;
        private FhirCanonical? _basedefinition;
        private FhirCode? _derivation;
        private StructureDefinitionSnapshot? _snapshot;
        private StructureDefinitionDifferential? _differential;
        private FhirId? _identity;
        private FhirUri? _uri;
        private FhirString? _name;
        private FhirString? _comment;
        private FhirCode? _type;
        private FhirString? _expression;
        private List<ElementDefinition>? _element;
        private List<ElementDefinition>? _element;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "StructureDefinition";        /// <summary>
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
        public StructureDefinitionVersionAlgorithmChoice? Versionalgorithm
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
        /// Keyword
        /// </summary>
        /// <remarks>
        /// <para>
        /// Keyword 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Coding>? Keyword
        {
            get => _keyword;
            set
            {
                _keyword = value;
                OnPropertyChanged(nameof(Keyword));
            }
        }        /// <summary>
        /// Fhirversion
        /// </summary>
        /// <remarks>
        /// <para>
        /// Fhirversion 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Fhirversion
        {
            get => _fhirversion;
            set
            {
                _fhirversion = value;
                OnPropertyChanged(nameof(Fhirversion));
            }
        }        /// <summary>
        /// Mapping
        /// </summary>
        /// <remarks>
        /// <para>
        /// Mapping 的詳細描述。
        /// </para>
        /// </remarks>
        public List<StructureDefinitionMapping>? Mapping
        {
            get => _mapping;
            set
            {
                _mapping = value;
                OnPropertyChanged(nameof(Mapping));
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
        /// Context
        /// </summary>
        /// <remarks>
        /// <para>
        /// Context 的詳細描述。
        /// </para>
        /// </remarks>
        public List<StructureDefinitionContext>? Context
        {
            get => _context;
            set
            {
                _context = value;
                OnPropertyChanged(nameof(Context));
            }
        }        /// <summary>
        /// Contextinvariant
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contextinvariant 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Contextinvariant
        {
            get => _contextinvariant;
            set
            {
                _contextinvariant = value;
                OnPropertyChanged(nameof(Contextinvariant));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Basedefinition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Basedefinition 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Basedefinition
        {
            get => _basedefinition;
            set
            {
                _basedefinition = value;
                OnPropertyChanged(nameof(Basedefinition));
            }
        }        /// <summary>
        /// Derivation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Derivation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Derivation
        {
            get => _derivation;
            set
            {
                _derivation = value;
                OnPropertyChanged(nameof(Derivation));
            }
        }        /// <summary>
        /// Snapshot
        /// </summary>
        /// <remarks>
        /// <para>
        /// Snapshot 的詳細描述。
        /// </para>
        /// </remarks>
        public StructureDefinitionSnapshot? Snapshot
        {
            get => _snapshot;
            set
            {
                _snapshot = value;
                OnPropertyChanged(nameof(Snapshot));
            }
        }        /// <summary>
        /// Differential
        /// </summary>
        /// <remarks>
        /// <para>
        /// Differential 的詳細描述。
        /// </para>
        /// </remarks>
        public StructureDefinitionDifferential? Differential
        {
            get => _differential;
            set
            {
                _differential = value;
                OnPropertyChanged(nameof(Differential));
            }
        }        /// <summary>
        /// Identity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identity 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Identity
        {
            get => _identity;
            set
            {
                _identity = value;
                OnPropertyChanged(nameof(Identity));
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
        /// Expression
        /// </summary>
        /// <remarks>
        /// <para>
        /// Expression 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Expression
        {
            get => _expression;
            set
            {
                _expression = value;
                OnPropertyChanged(nameof(Expression));
            }
        }        /// <summary>
        /// Element
        /// </summary>
        /// <remarks>
        /// <para>
        /// Element 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ElementDefinition>? Element
        {
            get => _element;
            set
            {
                _element = value;
                OnPropertyChanged(nameof(Element));
            }
        }        /// <summary>
        /// Element
        /// </summary>
        /// <remarks>
        /// <para>
        /// Element 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ElementDefinition>? Element
        {
            get => _element;
            set
            {
                _element = value;
                OnPropertyChanged(nameof(Element));
            }
        }        /// <summary>
        /// 建立新的 StructureDefinition 資源實例
        /// </summary>
        public StructureDefinition()
        {
        }

        /// <summary>
        /// 建立新的 StructureDefinition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public StructureDefinition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"StructureDefinition(Id: {Id})";
        }
    }    /// <summary>
    /// StructureDefinitionMapping 背骨元素
    /// </summary>
    public class StructureDefinitionMapping
    {
        // TODO: 添加屬性實作
        
        public StructureDefinitionMapping() { }
    }    /// <summary>
    /// StructureDefinitionContext 背骨元素
    /// </summary>
    public class StructureDefinitionContext
    {
        // TODO: 添加屬性實作
        
        public StructureDefinitionContext() { }
    }    /// <summary>
    /// StructureDefinitionSnapshot 背骨元素
    /// </summary>
    public class StructureDefinitionSnapshot
    {
        // TODO: 添加屬性實作
        
        public StructureDefinitionSnapshot() { }
    }    /// <summary>
    /// StructureDefinitionDifferential 背骨元素
    /// </summary>
    public class StructureDefinitionDifferential
    {
        // TODO: 添加屬性實作
        
        public StructureDefinitionDifferential() { }
    }    /// <summary>
    /// StructureDefinitionVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class StructureDefinitionVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public StructureDefinitionVersionAlgorithmChoice(JsonObject value) : base("structuredefinitionversionalgorithm", value, _supportType) { }
        public StructureDefinitionVersionAlgorithmChoice(IComplexType? value) : base("structuredefinitionversionalgorithm", value) { }
        public StructureDefinitionVersionAlgorithmChoice(IPrimitiveType? value) : base("structuredefinitionversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "StructureDefinitionVersionAlgorithm" : "structuredefinitionversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
