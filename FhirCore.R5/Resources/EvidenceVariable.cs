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
    /// FHIR R5 EvidenceVariable 資源
    /// 
    /// <para>
    /// EvidenceVariable 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var evidencevariable = new EvidenceVariable("evidencevariable-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 EvidenceVariable 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class EvidenceVariable : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private EvidenceVariableVersionAlgorithmChoice? _versionalgorithm;
        private FhirString? _name;
        private FhirString? _title;
        private FhirString? _shorttitle;
        private FhirCode? _status;
        private FhirBoolean? _experimental;
        private FhirDateTime? _date;
        private FhirString? _publisher;
        private List<ContactDetail>? _contact;
        private FhirMarkdown? _description;
        private List<Annotation>? _note;
        private List<UsageContext>? _usecontext;
        private FhirMarkdown? _purpose;
        private FhirMarkdown? _copyright;
        private FhirString? _copyrightlabel;
        private FhirDate? _approvaldate;
        private FhirDate? _lastreviewdate;
        private Period? _effectiveperiod;
        private List<ContactDetail>? _author;
        private List<ContactDetail>? _editor;
        private List<ContactDetail>? _reviewer;
        private List<ContactDetail>? _endorser;
        private List<RelatedArtifact>? _relatedartifact;
        private FhirBoolean? _actual;
        private List<EvidenceVariableCharacteristic>? _characteristic;
        private FhirCode? _handling;
        private List<EvidenceVariableCategory>? _category;
        private CodeableConcept? _type;
        private List<CodeableConcept>? _method;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _device;
        private EvidenceVariableCharacteristicDefinitionByTypeAndValueValueChoice? _value;
        private CodeableConcept? _offset;
        private FhirCode? _code;
        private FhirPositiveInt? _threshold;
        private FhirMarkdown? _description;
        private List<Annotation>? _note;
        private EvidenceVariableCharacteristicTimeFromEventEventChoice? _event;
        private Quantity? _quantity;
        private Range? _range;
        private FhirId? _linkid;
        private FhirMarkdown? _description;
        private List<Annotation>? _note;
        private FhirBoolean? _exclude;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _definitionreference;
        private FhirCanonical? _definitioncanonical;
        private CodeableConcept? _definitioncodeableconcept;
        private ExpressionType? _definitionexpression;
        private FhirId? _definitionid;
        private EvidenceVariableCharacteristicDefinitionByTypeAndValue? _definitionbytypeandvalue;
        private EvidenceVariableCharacteristicDefinitionByCombination? _definitionbycombination;
        private EvidenceVariableCharacteristicInstancesChoice? _instances;
        private EvidenceVariableCharacteristicDurationChoice? _duration;
        private List<EvidenceVariableCharacteristicTimeFromEvent>? _timefromevent;
        private FhirString? _name;
        private EvidenceVariableCategoryValueChoice? _value;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "EvidenceVariable";        /// <summary>
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
        public EvidenceVariableVersionAlgorithmChoice? Versionalgorithm
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
        /// Shorttitle
        /// </summary>
        /// <remarks>
        /// <para>
        /// Shorttitle 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Shorttitle
        {
            get => _shorttitle;
            set
            {
                _shorttitle = value;
                OnPropertyChanged(nameof(Shorttitle));
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
        /// Characteristic
        /// </summary>
        /// <remarks>
        /// <para>
        /// Characteristic 的詳細描述。
        /// </para>
        /// </remarks>
        public List<EvidenceVariableCharacteristic>? Characteristic
        {
            get => _characteristic;
            set
            {
                _characteristic = value;
                OnPropertyChanged(nameof(Characteristic));
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
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public List<EvidenceVariableCategory>? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
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
        /// Method
        /// </summary>
        /// <remarks>
        /// <para>
        /// Method 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Method
        {
            get => _method;
            set
            {
                _method = value;
                OnPropertyChanged(nameof(Method));
            }
        }        /// <summary>
        /// Device
        /// </summary>
        /// <remarks>
        /// <para>
        /// Device 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Device
        {
            get => _device;
            set
            {
                _device = value;
                OnPropertyChanged(nameof(Device));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public EvidenceVariableCharacteristicDefinitionByTypeAndValueValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Offset
        /// </summary>
        /// <remarks>
        /// <para>
        /// Offset 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Offset
        {
            get => _offset;
            set
            {
                _offset = value;
                OnPropertyChanged(nameof(Offset));
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
        /// Threshold
        /// </summary>
        /// <remarks>
        /// <para>
        /// Threshold 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Threshold
        {
            get => _threshold;
            set
            {
                _threshold = value;
                OnPropertyChanged(nameof(Threshold));
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
        /// Event
        /// </summary>
        /// <remarks>
        /// <para>
        /// Event 的詳細描述。
        /// </para>
        /// </remarks>
        public EvidenceVariableCharacteristicTimeFromEventEventChoice? Event
        {
            get => _event;
            set
            {
                _event = value;
                OnPropertyChanged(nameof(Event));
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
        /// Exclude
        /// </summary>
        /// <remarks>
        /// <para>
        /// Exclude 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Exclude
        {
            get => _exclude;
            set
            {
                _exclude = value;
                OnPropertyChanged(nameof(Exclude));
            }
        }        /// <summary>
        /// Definitionreference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definitionreference 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Definitionreference
        {
            get => _definitionreference;
            set
            {
                _definitionreference = value;
                OnPropertyChanged(nameof(Definitionreference));
            }
        }        /// <summary>
        /// Definitioncanonical
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definitioncanonical 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Definitioncanonical
        {
            get => _definitioncanonical;
            set
            {
                _definitioncanonical = value;
                OnPropertyChanged(nameof(Definitioncanonical));
            }
        }        /// <summary>
        /// Definitioncodeableconcept
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definitioncodeableconcept 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Definitioncodeableconcept
        {
            get => _definitioncodeableconcept;
            set
            {
                _definitioncodeableconcept = value;
                OnPropertyChanged(nameof(Definitioncodeableconcept));
            }
        }        /// <summary>
        /// Definitionexpression
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definitionexpression 的詳細描述。
        /// </para>
        /// </remarks>
        public ExpressionType? Definitionexpression
        {
            get => _definitionexpression;
            set
            {
                _definitionexpression = value;
                OnPropertyChanged(nameof(Definitionexpression));
            }
        }        /// <summary>
        /// Definitionid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definitionid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Definitionid
        {
            get => _definitionid;
            set
            {
                _definitionid = value;
                OnPropertyChanged(nameof(Definitionid));
            }
        }        /// <summary>
        /// Definitionbytypeandvalue
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definitionbytypeandvalue 的詳細描述。
        /// </para>
        /// </remarks>
        public EvidenceVariableCharacteristicDefinitionByTypeAndValue? Definitionbytypeandvalue
        {
            get => _definitionbytypeandvalue;
            set
            {
                _definitionbytypeandvalue = value;
                OnPropertyChanged(nameof(Definitionbytypeandvalue));
            }
        }        /// <summary>
        /// Definitionbycombination
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definitionbycombination 的詳細描述。
        /// </para>
        /// </remarks>
        public EvidenceVariableCharacteristicDefinitionByCombination? Definitionbycombination
        {
            get => _definitionbycombination;
            set
            {
                _definitionbycombination = value;
                OnPropertyChanged(nameof(Definitionbycombination));
            }
        }        /// <summary>
        /// Instances
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instances 的詳細描述。
        /// </para>
        /// </remarks>
        public EvidenceVariableCharacteristicInstancesChoice? Instances
        {
            get => _instances;
            set
            {
                _instances = value;
                OnPropertyChanged(nameof(Instances));
            }
        }        /// <summary>
        /// Duration
        /// </summary>
        /// <remarks>
        /// <para>
        /// Duration 的詳細描述。
        /// </para>
        /// </remarks>
        public EvidenceVariableCharacteristicDurationChoice? Duration
        {
            get => _duration;
            set
            {
                _duration = value;
                OnPropertyChanged(nameof(Duration));
            }
        }        /// <summary>
        /// Timefromevent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Timefromevent 的詳細描述。
        /// </para>
        /// </remarks>
        public List<EvidenceVariableCharacteristicTimeFromEvent>? Timefromevent
        {
            get => _timefromevent;
            set
            {
                _timefromevent = value;
                OnPropertyChanged(nameof(Timefromevent));
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
        public EvidenceVariableCategoryValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// 建立新的 EvidenceVariable 資源實例
        /// </summary>
        public EvidenceVariable()
        {
        }

        /// <summary>
        /// 建立新的 EvidenceVariable 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public EvidenceVariable(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"EvidenceVariable(Id: {Id})";
        }
    }    /// <summary>
    /// EvidenceVariableCharacteristicDefinitionByTypeAndValue 背骨元素
    /// </summary>
    public class EvidenceVariableCharacteristicDefinitionByTypeAndValue
    {
        // TODO: 添加屬性實作
        
        public EvidenceVariableCharacteristicDefinitionByTypeAndValue() { }
    }    /// <summary>
    /// EvidenceVariableCharacteristicDefinitionByCombination 背骨元素
    /// </summary>
    public class EvidenceVariableCharacteristicDefinitionByCombination
    {
        // TODO: 添加屬性實作
        
        public EvidenceVariableCharacteristicDefinitionByCombination() { }
    }    /// <summary>
    /// EvidenceVariableCharacteristicTimeFromEvent 背骨元素
    /// </summary>
    public class EvidenceVariableCharacteristicTimeFromEvent
    {
        // TODO: 添加屬性實作
        
        public EvidenceVariableCharacteristicTimeFromEvent() { }
    }    /// <summary>
    /// EvidenceVariableCharacteristic 背骨元素
    /// </summary>
    public class EvidenceVariableCharacteristic
    {
        // TODO: 添加屬性實作
        
        public EvidenceVariableCharacteristic() { }
    }    /// <summary>
    /// EvidenceVariableCategory 背骨元素
    /// </summary>
    public class EvidenceVariableCategory
    {
        // TODO: 添加屬性實作
        
        public EvidenceVariableCategory() { }
    }    /// <summary>
    /// EvidenceVariableVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class EvidenceVariableVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public EvidenceVariableVersionAlgorithmChoice(JsonObject value) : base("evidencevariableversionalgorithm", value, _supportType) { }
        public EvidenceVariableVersionAlgorithmChoice(IComplexType? value) : base("evidencevariableversionalgorithm", value) { }
        public EvidenceVariableVersionAlgorithmChoice(IPrimitiveType? value) : base("evidencevariableversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "EvidenceVariableVersionAlgorithm" : "evidencevariableversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// EvidenceVariableCharacteristicDefinitionByTypeAndValueValueChoice 選擇類型
    /// </summary>
    public class EvidenceVariableCharacteristicDefinitionByTypeAndValueValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public EvidenceVariableCharacteristicDefinitionByTypeAndValueValueChoice(JsonObject value) : base("evidencevariablecharacteristicdefinitionbytypeandvaluevalue", value, _supportType) { }
        public EvidenceVariableCharacteristicDefinitionByTypeAndValueValueChoice(IComplexType? value) : base("evidencevariablecharacteristicdefinitionbytypeandvaluevalue", value) { }
        public EvidenceVariableCharacteristicDefinitionByTypeAndValueValueChoice(IPrimitiveType? value) : base("evidencevariablecharacteristicdefinitionbytypeandvaluevalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "EvidenceVariableCharacteristicDefinitionByTypeAndValueValue" : "evidencevariablecharacteristicdefinitionbytypeandvaluevalue";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// EvidenceVariableCharacteristicInstancesChoice 選擇類型
    /// </summary>
    public class EvidenceVariableCharacteristicInstancesChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public EvidenceVariableCharacteristicInstancesChoice(JsonObject value) : base("evidencevariablecharacteristicinstances", value, _supportType) { }
        public EvidenceVariableCharacteristicInstancesChoice(IComplexType? value) : base("evidencevariablecharacteristicinstances", value) { }
        public EvidenceVariableCharacteristicInstancesChoice(IPrimitiveType? value) : base("evidencevariablecharacteristicinstances", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "EvidenceVariableCharacteristicInstances" : "evidencevariablecharacteristicinstances";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// EvidenceVariableCharacteristicDurationChoice 選擇類型
    /// </summary>
    public class EvidenceVariableCharacteristicDurationChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public EvidenceVariableCharacteristicDurationChoice(JsonObject value) : base("evidencevariablecharacteristicduration", value, _supportType) { }
        public EvidenceVariableCharacteristicDurationChoice(IComplexType? value) : base("evidencevariablecharacteristicduration", value) { }
        public EvidenceVariableCharacteristicDurationChoice(IPrimitiveType? value) : base("evidencevariablecharacteristicduration", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "EvidenceVariableCharacteristicDuration" : "evidencevariablecharacteristicduration";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// EvidenceVariableCharacteristicTimeFromEventEventChoice 選擇類型
    /// </summary>
    public class EvidenceVariableCharacteristicTimeFromEventEventChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public EvidenceVariableCharacteristicTimeFromEventEventChoice(JsonObject value) : base("evidencevariablecharacteristictimefromeventevent", value, _supportType) { }
        public EvidenceVariableCharacteristicTimeFromEventEventChoice(IComplexType? value) : base("evidencevariablecharacteristictimefromeventevent", value) { }
        public EvidenceVariableCharacteristicTimeFromEventEventChoice(IPrimitiveType? value) : base("evidencevariablecharacteristictimefromeventevent", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "EvidenceVariableCharacteristicTimeFromEventEvent" : "evidencevariablecharacteristictimefromeventevent";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// EvidenceVariableCategoryValueChoice 選擇類型
    /// </summary>
    public class EvidenceVariableCategoryValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public EvidenceVariableCategoryValueChoice(JsonObject value) : base("evidencevariablecategoryvalue", value, _supportType) { }
        public EvidenceVariableCategoryValueChoice(IComplexType? value) : base("evidencevariablecategoryvalue", value) { }
        public EvidenceVariableCategoryValueChoice(IPrimitiveType? value) : base("evidencevariablecategoryvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "EvidenceVariableCategoryValue" : "evidencevariablecategoryvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
