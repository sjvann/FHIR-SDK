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
    /// FHIR R5 ObservationDefinition 資源
    /// 
    /// <para>
    /// ObservationDefinition 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var observationdefinition = new ObservationDefinition("observationdefinition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 ObservationDefinition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ObservationDefinition : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private Identifier? _identifier;
        private FhirString? _version;
        private ObservationDefinitionVersionAlgorithmChoice? _versionalgorithm;
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
        private List<FhirCanonical>? _derivedfromcanonical;
        private List<FhirUri>? _derivedfromuri;
        private List<CodeableConcept>? _subject;
        private CodeableConcept? _performertype;
        private List<CodeableConcept>? _category;
        private CodeableConcept? _code;
        private List<FhirCode>? _permitteddatatype;
        private FhirBoolean? _multipleresultsallowed;
        private CodeableConcept? _bodysite;
        private CodeableConcept? _method;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _specimen;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _device;
        private FhirString? _preferredreportname;
        private List<Coding>? _permittedunit;
        private List<ObservationDefinitionQualifiedValue>? _qualifiedvalue;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _hasmember;
        private List<ObservationDefinitionComponent>? _component;
        private CodeableConcept? _context;
        private List<CodeableConcept>? _appliesto;
        private FhirCode? _gender;
        private Range? _age;
        private Range? _gestationalage;
        private FhirString? _condition;
        private FhirCode? _rangecategory;
        private Range? _range;
        private FhirCanonical? _validcodedvalueset;
        private FhirCanonical? _normalcodedvalueset;
        private FhirCanonical? _abnormalcodedvalueset;
        private FhirCanonical? _criticalcodedvalueset;
        private CodeableConcept? _code;
        private List<FhirCode>? _permitteddatatype;
        private List<Coding>? _permittedunit;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ObservationDefinition";        /// <summary>
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
        public Identifier? Identifier
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
        public ObservationDefinitionVersionAlgorithmChoice? Versionalgorithm
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
        /// Derivedfromcanonical
        /// </summary>
        /// <remarks>
        /// <para>
        /// Derivedfromcanonical 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Derivedfromcanonical
        {
            get => _derivedfromcanonical;
            set
            {
                _derivedfromcanonical = value;
                OnPropertyChanged(nameof(Derivedfromcanonical));
            }
        }        /// <summary>
        /// Derivedfromuri
        /// </summary>
        /// <remarks>
        /// <para>
        /// Derivedfromuri 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUri>? Derivedfromuri
        {
            get => _derivedfromuri;
            set
            {
                _derivedfromuri = value;
                OnPropertyChanged(nameof(Derivedfromuri));
            }
        }        /// <summary>
        /// Subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }        /// <summary>
        /// Performertype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performertype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Performertype
        {
            get => _performertype;
            set
            {
                _performertype = value;
                OnPropertyChanged(nameof(Performertype));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
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
        /// Permitteddatatype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Permitteddatatype 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Permitteddatatype
        {
            get => _permitteddatatype;
            set
            {
                _permitteddatatype = value;
                OnPropertyChanged(nameof(Permitteddatatype));
            }
        }        /// <summary>
        /// Multipleresultsallowed
        /// </summary>
        /// <remarks>
        /// <para>
        /// Multipleresultsallowed 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Multipleresultsallowed
        {
            get => _multipleresultsallowed;
            set
            {
                _multipleresultsallowed = value;
                OnPropertyChanged(nameof(Multipleresultsallowed));
            }
        }        /// <summary>
        /// Bodysite
        /// </summary>
        /// <remarks>
        /// <para>
        /// Bodysite 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Bodysite
        {
            get => _bodysite;
            set
            {
                _bodysite = value;
                OnPropertyChanged(nameof(Bodysite));
            }
        }        /// <summary>
        /// Method
        /// </summary>
        /// <remarks>
        /// <para>
        /// Method 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Method
        {
            get => _method;
            set
            {
                _method = value;
                OnPropertyChanged(nameof(Method));
            }
        }        /// <summary>
        /// Specimen
        /// </summary>
        /// <remarks>
        /// <para>
        /// Specimen 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Specimen
        {
            get => _specimen;
            set
            {
                _specimen = value;
                OnPropertyChanged(nameof(Specimen));
            }
        }        /// <summary>
        /// Device
        /// </summary>
        /// <remarks>
        /// <para>
        /// Device 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Device
        {
            get => _device;
            set
            {
                _device = value;
                OnPropertyChanged(nameof(Device));
            }
        }        /// <summary>
        /// Preferredreportname
        /// </summary>
        /// <remarks>
        /// <para>
        /// Preferredreportname 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Preferredreportname
        {
            get => _preferredreportname;
            set
            {
                _preferredreportname = value;
                OnPropertyChanged(nameof(Preferredreportname));
            }
        }        /// <summary>
        /// Permittedunit
        /// </summary>
        /// <remarks>
        /// <para>
        /// Permittedunit 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Coding>? Permittedunit
        {
            get => _permittedunit;
            set
            {
                _permittedunit = value;
                OnPropertyChanged(nameof(Permittedunit));
            }
        }        /// <summary>
        /// Qualifiedvalue
        /// </summary>
        /// <remarks>
        /// <para>
        /// Qualifiedvalue 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ObservationDefinitionQualifiedValue>? Qualifiedvalue
        {
            get => _qualifiedvalue;
            set
            {
                _qualifiedvalue = value;
                OnPropertyChanged(nameof(Qualifiedvalue));
            }
        }        /// <summary>
        /// Hasmember
        /// </summary>
        /// <remarks>
        /// <para>
        /// Hasmember 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Hasmember
        {
            get => _hasmember;
            set
            {
                _hasmember = value;
                OnPropertyChanged(nameof(Hasmember));
            }
        }        /// <summary>
        /// Component
        /// </summary>
        /// <remarks>
        /// <para>
        /// Component 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ObservationDefinitionComponent>? Component
        {
            get => _component;
            set
            {
                _component = value;
                OnPropertyChanged(nameof(Component));
            }
        }        /// <summary>
        /// Context
        /// </summary>
        /// <remarks>
        /// <para>
        /// Context 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Context
        {
            get => _context;
            set
            {
                _context = value;
                OnPropertyChanged(nameof(Context));
            }
        }        /// <summary>
        /// Appliesto
        /// </summary>
        /// <remarks>
        /// <para>
        /// Appliesto 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Appliesto
        {
            get => _appliesto;
            set
            {
                _appliesto = value;
                OnPropertyChanged(nameof(Appliesto));
            }
        }        /// <summary>
        /// Gender
        /// </summary>
        /// <remarks>
        /// <para>
        /// Gender 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Gender
        {
            get => _gender;
            set
            {
                _gender = value;
                OnPropertyChanged(nameof(Gender));
            }
        }        /// <summary>
        /// Age
        /// </summary>
        /// <remarks>
        /// <para>
        /// Age 的詳細描述。
        /// </para>
        /// </remarks>
        public Range? Age
        {
            get => _age;
            set
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }        /// <summary>
        /// Gestationalage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Gestationalage 的詳細描述。
        /// </para>
        /// </remarks>
        public Range? Gestationalage
        {
            get => _gestationalage;
            set
            {
                _gestationalage = value;
                OnPropertyChanged(nameof(Gestationalage));
            }
        }        /// <summary>
        /// Condition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Condition 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Condition
        {
            get => _condition;
            set
            {
                _condition = value;
                OnPropertyChanged(nameof(Condition));
            }
        }        /// <summary>
        /// Rangecategory
        /// </summary>
        /// <remarks>
        /// <para>
        /// Rangecategory 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Rangecategory
        {
            get => _rangecategory;
            set
            {
                _rangecategory = value;
                OnPropertyChanged(nameof(Rangecategory));
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
        /// Validcodedvalueset
        /// </summary>
        /// <remarks>
        /// <para>
        /// Validcodedvalueset 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Validcodedvalueset
        {
            get => _validcodedvalueset;
            set
            {
                _validcodedvalueset = value;
                OnPropertyChanged(nameof(Validcodedvalueset));
            }
        }        /// <summary>
        /// Normalcodedvalueset
        /// </summary>
        /// <remarks>
        /// <para>
        /// Normalcodedvalueset 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Normalcodedvalueset
        {
            get => _normalcodedvalueset;
            set
            {
                _normalcodedvalueset = value;
                OnPropertyChanged(nameof(Normalcodedvalueset));
            }
        }        /// <summary>
        /// Abnormalcodedvalueset
        /// </summary>
        /// <remarks>
        /// <para>
        /// Abnormalcodedvalueset 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Abnormalcodedvalueset
        {
            get => _abnormalcodedvalueset;
            set
            {
                _abnormalcodedvalueset = value;
                OnPropertyChanged(nameof(Abnormalcodedvalueset));
            }
        }        /// <summary>
        /// Criticalcodedvalueset
        /// </summary>
        /// <remarks>
        /// <para>
        /// Criticalcodedvalueset 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Criticalcodedvalueset
        {
            get => _criticalcodedvalueset;
            set
            {
                _criticalcodedvalueset = value;
                OnPropertyChanged(nameof(Criticalcodedvalueset));
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
        /// Permitteddatatype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Permitteddatatype 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Permitteddatatype
        {
            get => _permitteddatatype;
            set
            {
                _permitteddatatype = value;
                OnPropertyChanged(nameof(Permitteddatatype));
            }
        }        /// <summary>
        /// Permittedunit
        /// </summary>
        /// <remarks>
        /// <para>
        /// Permittedunit 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Coding>? Permittedunit
        {
            get => _permittedunit;
            set
            {
                _permittedunit = value;
                OnPropertyChanged(nameof(Permittedunit));
            }
        }        /// <summary>
        /// 建立新的 ObservationDefinition 資源實例
        /// </summary>
        public ObservationDefinition()
        {
        }

        /// <summary>
        /// 建立新的 ObservationDefinition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ObservationDefinition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ObservationDefinition(Id: {Id})";
        }
    }    /// <summary>
    /// ObservationDefinitionQualifiedValue 背骨元素
    /// </summary>
    public class ObservationDefinitionQualifiedValue
    {
        // TODO: 添加屬性實作
        
        public ObservationDefinitionQualifiedValue() { }
    }    /// <summary>
    /// ObservationDefinitionComponent 背骨元素
    /// </summary>
    public class ObservationDefinitionComponent
    {
        // TODO: 添加屬性實作
        
        public ObservationDefinitionComponent() { }
    }    /// <summary>
    /// ObservationDefinitionVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class ObservationDefinitionVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ObservationDefinitionVersionAlgorithmChoice(JsonObject value) : base("observationdefinitionversionalgorithm", value, _supportType) { }
        public ObservationDefinitionVersionAlgorithmChoice(IComplexType? value) : base("observationdefinitionversionalgorithm", value) { }
        public ObservationDefinitionVersionAlgorithmChoice(IPrimitiveType? value) : base("observationdefinitionversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ObservationDefinitionVersionAlgorithm" : "observationdefinitionversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
