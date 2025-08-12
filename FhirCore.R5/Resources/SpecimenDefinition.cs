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
    /// FHIR R5 SpecimenDefinition 資源
    /// 
    /// <para>
    /// SpecimenDefinition 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var specimendefinition = new SpecimenDefinition("specimendefinition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 SpecimenDefinition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class SpecimenDefinition : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private Identifier? _identifier;
        private FhirString? _version;
        private SpecimenDefinitionVersionAlgorithmChoice? _versionalgorithm;
        private FhirString? _name;
        private FhirString? _title;
        private List<FhirCanonical>? _derivedfromcanonical;
        private List<FhirUri>? _derivedfromuri;
        private FhirCode? _status;
        private FhirBoolean? _experimental;
        private SpecimenDefinitionSubjectChoice? _subject;
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
        private CodeableConcept? _typecollected;
        private List<CodeableConcept>? _patientpreparation;
        private FhirString? _timeaspect;
        private List<CodeableConcept>? _collection;
        private List<SpecimenDefinitionTypeTested>? _typetested;
        private SpecimenDefinitionTypeTestedContainerAdditiveAdditiveChoice? _additive;
        private CodeableConcept? _material;
        private CodeableConcept? _type;
        private CodeableConcept? _cap;
        private FhirMarkdown? _description;
        private Quantity? _capacity;
        private SpecimenDefinitionTypeTestedContainerMinimumVolumeChoice? _minimumvolume;
        private List<SpecimenDefinitionTypeTestedContainerAdditive>? _additive;
        private FhirMarkdown? _preparation;
        private CodeableConcept? _temperaturequalifier;
        private Range? _temperaturerange;
        private Duration? _maxduration;
        private FhirMarkdown? _instruction;
        private FhirBoolean? _isderived;
        private CodeableConcept? _type;
        private FhirCode? _preference;
        private SpecimenDefinitionTypeTestedContainer? _container;
        private FhirMarkdown? _requirement;
        private Duration? _retentiontime;
        private FhirBoolean? _singleuse;
        private List<CodeableConcept>? _rejectioncriterion;
        private List<SpecimenDefinitionTypeTestedHandling>? _handling;
        private List<CodeableConcept>? _testingdestination;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "SpecimenDefinition";        /// <summary>
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
        public SpecimenDefinitionVersionAlgorithmChoice? Versionalgorithm
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
        public SpecimenDefinitionSubjectChoice? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
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
        /// Typecollected
        /// </summary>
        /// <remarks>
        /// <para>
        /// Typecollected 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Typecollected
        {
            get => _typecollected;
            set
            {
                _typecollected = value;
                OnPropertyChanged(nameof(Typecollected));
            }
        }        /// <summary>
        /// Patientpreparation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Patientpreparation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Patientpreparation
        {
            get => _patientpreparation;
            set
            {
                _patientpreparation = value;
                OnPropertyChanged(nameof(Patientpreparation));
            }
        }        /// <summary>
        /// Timeaspect
        /// </summary>
        /// <remarks>
        /// <para>
        /// Timeaspect 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Timeaspect
        {
            get => _timeaspect;
            set
            {
                _timeaspect = value;
                OnPropertyChanged(nameof(Timeaspect));
            }
        }        /// <summary>
        /// Collection
        /// </summary>
        /// <remarks>
        /// <para>
        /// Collection 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Collection
        {
            get => _collection;
            set
            {
                _collection = value;
                OnPropertyChanged(nameof(Collection));
            }
        }        /// <summary>
        /// Typetested
        /// </summary>
        /// <remarks>
        /// <para>
        /// Typetested 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SpecimenDefinitionTypeTested>? Typetested
        {
            get => _typetested;
            set
            {
                _typetested = value;
                OnPropertyChanged(nameof(Typetested));
            }
        }        /// <summary>
        /// Additive
        /// </summary>
        /// <remarks>
        /// <para>
        /// Additive 的詳細描述。
        /// </para>
        /// </remarks>
        public SpecimenDefinitionTypeTestedContainerAdditiveAdditiveChoice? Additive
        {
            get => _additive;
            set
            {
                _additive = value;
                OnPropertyChanged(nameof(Additive));
            }
        }        /// <summary>
        /// Material
        /// </summary>
        /// <remarks>
        /// <para>
        /// Material 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Material
        {
            get => _material;
            set
            {
                _material = value;
                OnPropertyChanged(nameof(Material));
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
        /// Cap
        /// </summary>
        /// <remarks>
        /// <para>
        /// Cap 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Cap
        {
            get => _cap;
            set
            {
                _cap = value;
                OnPropertyChanged(nameof(Cap));
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
        /// Capacity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Capacity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Capacity
        {
            get => _capacity;
            set
            {
                _capacity = value;
                OnPropertyChanged(nameof(Capacity));
            }
        }        /// <summary>
        /// Minimumvolume
        /// </summary>
        /// <remarks>
        /// <para>
        /// Minimumvolume 的詳細描述。
        /// </para>
        /// </remarks>
        public SpecimenDefinitionTypeTestedContainerMinimumVolumeChoice? Minimumvolume
        {
            get => _minimumvolume;
            set
            {
                _minimumvolume = value;
                OnPropertyChanged(nameof(Minimumvolume));
            }
        }        /// <summary>
        /// Additive
        /// </summary>
        /// <remarks>
        /// <para>
        /// Additive 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SpecimenDefinitionTypeTestedContainerAdditive>? Additive
        {
            get => _additive;
            set
            {
                _additive = value;
                OnPropertyChanged(nameof(Additive));
            }
        }        /// <summary>
        /// Preparation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Preparation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Preparation
        {
            get => _preparation;
            set
            {
                _preparation = value;
                OnPropertyChanged(nameof(Preparation));
            }
        }        /// <summary>
        /// Temperaturequalifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Temperaturequalifier 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Temperaturequalifier
        {
            get => _temperaturequalifier;
            set
            {
                _temperaturequalifier = value;
                OnPropertyChanged(nameof(Temperaturequalifier));
            }
        }        /// <summary>
        /// Temperaturerange
        /// </summary>
        /// <remarks>
        /// <para>
        /// Temperaturerange 的詳細描述。
        /// </para>
        /// </remarks>
        public Range? Temperaturerange
        {
            get => _temperaturerange;
            set
            {
                _temperaturerange = value;
                OnPropertyChanged(nameof(Temperaturerange));
            }
        }        /// <summary>
        /// Maxduration
        /// </summary>
        /// <remarks>
        /// <para>
        /// Maxduration 的詳細描述。
        /// </para>
        /// </remarks>
        public Duration? Maxduration
        {
            get => _maxduration;
            set
            {
                _maxduration = value;
                OnPropertyChanged(nameof(Maxduration));
            }
        }        /// <summary>
        /// Instruction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instruction 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Instruction
        {
            get => _instruction;
            set
            {
                _instruction = value;
                OnPropertyChanged(nameof(Instruction));
            }
        }        /// <summary>
        /// Isderived
        /// </summary>
        /// <remarks>
        /// <para>
        /// Isderived 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Isderived
        {
            get => _isderived;
            set
            {
                _isderived = value;
                OnPropertyChanged(nameof(Isderived));
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
        /// Preference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Preference 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Preference
        {
            get => _preference;
            set
            {
                _preference = value;
                OnPropertyChanged(nameof(Preference));
            }
        }        /// <summary>
        /// Container
        /// </summary>
        /// <remarks>
        /// <para>
        /// Container 的詳細描述。
        /// </para>
        /// </remarks>
        public SpecimenDefinitionTypeTestedContainer? Container
        {
            get => _container;
            set
            {
                _container = value;
                OnPropertyChanged(nameof(Container));
            }
        }        /// <summary>
        /// Requirement
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requirement 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Requirement
        {
            get => _requirement;
            set
            {
                _requirement = value;
                OnPropertyChanged(nameof(Requirement));
            }
        }        /// <summary>
        /// Retentiontime
        /// </summary>
        /// <remarks>
        /// <para>
        /// Retentiontime 的詳細描述。
        /// </para>
        /// </remarks>
        public Duration? Retentiontime
        {
            get => _retentiontime;
            set
            {
                _retentiontime = value;
                OnPropertyChanged(nameof(Retentiontime));
            }
        }        /// <summary>
        /// Singleuse
        /// </summary>
        /// <remarks>
        /// <para>
        /// Singleuse 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Singleuse
        {
            get => _singleuse;
            set
            {
                _singleuse = value;
                OnPropertyChanged(nameof(Singleuse));
            }
        }        /// <summary>
        /// Rejectioncriterion
        /// </summary>
        /// <remarks>
        /// <para>
        /// Rejectioncriterion 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Rejectioncriterion
        {
            get => _rejectioncriterion;
            set
            {
                _rejectioncriterion = value;
                OnPropertyChanged(nameof(Rejectioncriterion));
            }
        }        /// <summary>
        /// Handling
        /// </summary>
        /// <remarks>
        /// <para>
        /// Handling 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SpecimenDefinitionTypeTestedHandling>? Handling
        {
            get => _handling;
            set
            {
                _handling = value;
                OnPropertyChanged(nameof(Handling));
            }
        }        /// <summary>
        /// Testingdestination
        /// </summary>
        /// <remarks>
        /// <para>
        /// Testingdestination 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Testingdestination
        {
            get => _testingdestination;
            set
            {
                _testingdestination = value;
                OnPropertyChanged(nameof(Testingdestination));
            }
        }        /// <summary>
        /// 建立新的 SpecimenDefinition 資源實例
        /// </summary>
        public SpecimenDefinition()
        {
        }

        /// <summary>
        /// 建立新的 SpecimenDefinition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public SpecimenDefinition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"SpecimenDefinition(Id: {Id})";
        }
    }    /// <summary>
    /// SpecimenDefinitionTypeTestedContainerAdditive 背骨元素
    /// </summary>
    public class SpecimenDefinitionTypeTestedContainerAdditive
    {
        // TODO: 添加屬性實作
        
        public SpecimenDefinitionTypeTestedContainerAdditive() { }
    }    /// <summary>
    /// SpecimenDefinitionTypeTestedContainer 背骨元素
    /// </summary>
    public class SpecimenDefinitionTypeTestedContainer
    {
        // TODO: 添加屬性實作
        
        public SpecimenDefinitionTypeTestedContainer() { }
    }    /// <summary>
    /// SpecimenDefinitionTypeTestedHandling 背骨元素
    /// </summary>
    public class SpecimenDefinitionTypeTestedHandling
    {
        // TODO: 添加屬性實作
        
        public SpecimenDefinitionTypeTestedHandling() { }
    }    /// <summary>
    /// SpecimenDefinitionTypeTested 背骨元素
    /// </summary>
    public class SpecimenDefinitionTypeTested
    {
        // TODO: 添加屬性實作
        
        public SpecimenDefinitionTypeTested() { }
    }    /// <summary>
    /// SpecimenDefinitionVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class SpecimenDefinitionVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public SpecimenDefinitionVersionAlgorithmChoice(JsonObject value) : base("specimendefinitionversionalgorithm", value, _supportType) { }
        public SpecimenDefinitionVersionAlgorithmChoice(IComplexType? value) : base("specimendefinitionversionalgorithm", value) { }
        public SpecimenDefinitionVersionAlgorithmChoice(IPrimitiveType? value) : base("specimendefinitionversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "SpecimenDefinitionVersionAlgorithm" : "specimendefinitionversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// SpecimenDefinitionSubjectChoice 選擇類型
    /// </summary>
    public class SpecimenDefinitionSubjectChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public SpecimenDefinitionSubjectChoice(JsonObject value) : base("specimendefinitionsubject", value, _supportType) { }
        public SpecimenDefinitionSubjectChoice(IComplexType? value) : base("specimendefinitionsubject", value) { }
        public SpecimenDefinitionSubjectChoice(IPrimitiveType? value) : base("specimendefinitionsubject", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "SpecimenDefinitionSubject" : "specimendefinitionsubject";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// SpecimenDefinitionTypeTestedContainerMinimumVolumeChoice 選擇類型
    /// </summary>
    public class SpecimenDefinitionTypeTestedContainerMinimumVolumeChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public SpecimenDefinitionTypeTestedContainerMinimumVolumeChoice(JsonObject value) : base("specimendefinitiontypetestedcontainerminimumvolume", value, _supportType) { }
        public SpecimenDefinitionTypeTestedContainerMinimumVolumeChoice(IComplexType? value) : base("specimendefinitiontypetestedcontainerminimumvolume", value) { }
        public SpecimenDefinitionTypeTestedContainerMinimumVolumeChoice(IPrimitiveType? value) : base("specimendefinitiontypetestedcontainerminimumvolume", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "SpecimenDefinitionTypeTestedContainerMinimumVolume" : "specimendefinitiontypetestedcontainerminimumvolume";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// SpecimenDefinitionTypeTestedContainerAdditiveAdditiveChoice 選擇類型
    /// </summary>
    public class SpecimenDefinitionTypeTestedContainerAdditiveAdditiveChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public SpecimenDefinitionTypeTestedContainerAdditiveAdditiveChoice(JsonObject value) : base("specimendefinitiontypetestedcontaineradditiveadditive", value, _supportType) { }
        public SpecimenDefinitionTypeTestedContainerAdditiveAdditiveChoice(IComplexType? value) : base("specimendefinitiontypetestedcontaineradditiveadditive", value) { }
        public SpecimenDefinitionTypeTestedContainerAdditiveAdditiveChoice(IPrimitiveType? value) : base("specimendefinitiontypetestedcontaineradditiveadditive", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "SpecimenDefinitionTypeTestedContainerAdditiveAdditive" : "specimendefinitiontypetestedcontaineradditiveadditive";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
