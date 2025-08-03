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
    /// FHIR R5 SubstanceDefinition 資源
    /// 
    /// <para>
    /// SubstanceDefinition 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var substancedefinition = new SubstanceDefinition("substancedefinition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 SubstanceDefinition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class SubstanceDefinition : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirString? _version;
        private CodeableConcept? _status;
        private List<CodeableConcept>? _classification;
        private CodeableConcept? _domain;
        private List<CodeableConcept>? _grade;
        private FhirMarkdown? _description;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _informationsource;
        private List<Annotation>? _note;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _manufacturer;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _supplier;
        private List<SubstanceDefinitionMoiety>? _moiety;
        private List<SubstanceDefinitionCharacterization>? _characterization;
        private List<SubstanceDefinitionProperty>? _property;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _referenceinformation;
        private List<SubstanceDefinitionMolecularWeight>? _molecularweight;
        private SubstanceDefinitionStructure? _structure;
        private List<SubstanceDefinitionCode>? _code;
        private List<SubstanceDefinitionName>? _name;
        private List<SubstanceDefinitionRelationship>? _relationship;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _nucleicacid;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _polymer;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _protein;
        private SubstanceDefinitionSourceMaterial? _sourcematerial;
        private CodeableConcept? _role;
        private Identifier? _identifier;
        private FhirString? _name;
        private CodeableConcept? _stereochemistry;
        private CodeableConcept? _opticalactivity;
        private FhirString? _molecularformula;
        private SubstanceDefinitionMoietyAmountChoice? _amount;
        private CodeableConcept? _measurementtype;
        private CodeableConcept? _technique;
        private CodeableConcept? _form;
        private FhirMarkdown? _description;
        private List<Attachment>? _file;
        private CodeableConcept? _type;
        private SubstanceDefinitionPropertyValueChoice? _value;
        private CodeableConcept? _method;
        private CodeableConcept? _type;
        private Quantity? _amount;
        private CodeableConcept? _type;
        private FhirString? _representation;
        private CodeableConcept? _format;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _document;
        private CodeableConcept? _stereochemistry;
        private CodeableConcept? _opticalactivity;
        private FhirString? _molecularformula;
        private FhirString? _molecularformulabymoiety;
        private List<CodeableConcept>? _technique;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _sourcedocument;
        private List<SubstanceDefinitionStructureRepresentation>? _representation;
        private CodeableConcept? _code;
        private CodeableConcept? _status;
        private FhirDateTime? _statusdate;
        private List<Annotation>? _note;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _source;
        private CodeableConcept? _authority;
        private CodeableConcept? _status;
        private FhirDateTime? _date;
        private FhirString? _name;
        private CodeableConcept? _type;
        private CodeableConcept? _status;
        private FhirBoolean? _preferred;
        private List<CodeableConcept>? _language;
        private List<CodeableConcept>? _domain;
        private List<CodeableConcept>? _jurisdiction;
        private List<SubstanceDefinitionNameOfficial>? _official;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _source;
        private SubstanceDefinitionRelationshipSubstanceDefinitionChoice? _substancedefinition;
        private CodeableConcept? _type;
        private FhirBoolean? _isdefining;
        private SubstanceDefinitionRelationshipAmountChoice? _amount;
        private Ratio? _ratiohighlimitamount;
        private CodeableConcept? _comparator;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _source;
        private CodeableConcept? _type;
        private CodeableConcept? _genus;
        private CodeableConcept? _species;
        private CodeableConcept? _part;
        private List<CodeableConcept>? _countryoforigin;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "SubstanceDefinition";        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private List<Identifier>? Identifier
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
        /// Status
        /// </summary>
        /// <remarks>
        /// <para>
        /// Status 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }        /// <summary>
        /// Classification
        /// </summary>
        /// <remarks>
        /// <para>
        /// Classification 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Classification
        {
            get => _classification;
            set
            {
                _classification = value;
                OnPropertyChanged(nameof(Classification));
            }
        }        /// <summary>
        /// Domain
        /// </summary>
        /// <remarks>
        /// <para>
        /// Domain 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Domain
        {
            get => _domain;
            set
            {
                _domain = value;
                OnPropertyChanged(nameof(Domain));
            }
        }        /// <summary>
        /// Grade
        /// </summary>
        /// <remarks>
        /// <para>
        /// Grade 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Grade
        {
            get => _grade;
            set
            {
                _grade = value;
                OnPropertyChanged(nameof(Grade));
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
        /// Informationsource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Informationsource 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Informationsource
        {
            get => _informationsource;
            set
            {
                _informationsource = value;
                OnPropertyChanged(nameof(Informationsource));
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
        /// Manufacturer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Manufacturer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Manufacturer
        {
            get => _manufacturer;
            set
            {
                _manufacturer = value;
                OnPropertyChanged(nameof(Manufacturer));
            }
        }        /// <summary>
        /// Supplier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supplier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Supplier
        {
            get => _supplier;
            set
            {
                _supplier = value;
                OnPropertyChanged(nameof(Supplier));
            }
        }        /// <summary>
        /// Moiety
        /// </summary>
        /// <remarks>
        /// <para>
        /// Moiety 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstanceDefinitionMoiety>? Moiety
        {
            get => _moiety;
            set
            {
                _moiety = value;
                OnPropertyChanged(nameof(Moiety));
            }
        }        /// <summary>
        /// Characterization
        /// </summary>
        /// <remarks>
        /// <para>
        /// Characterization 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstanceDefinitionCharacterization>? Characterization
        {
            get => _characterization;
            set
            {
                _characterization = value;
                OnPropertyChanged(nameof(Characterization));
            }
        }        /// <summary>
        /// Property
        /// </summary>
        /// <remarks>
        /// <para>
        /// Property 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstanceDefinitionProperty>? Property
        {
            get => _property;
            set
            {
                _property = value;
                OnPropertyChanged(nameof(Property));
            }
        }        /// <summary>
        /// Referenceinformation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Referenceinformation 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Referenceinformation
        {
            get => _referenceinformation;
            set
            {
                _referenceinformation = value;
                OnPropertyChanged(nameof(Referenceinformation));
            }
        }        /// <summary>
        /// Molecularweight
        /// </summary>
        /// <remarks>
        /// <para>
        /// Molecularweight 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstanceDefinitionMolecularWeight>? Molecularweight
        {
            get => _molecularweight;
            set
            {
                _molecularweight = value;
                OnPropertyChanged(nameof(Molecularweight));
            }
        }        /// <summary>
        /// Structure
        /// </summary>
        /// <remarks>
        /// <para>
        /// Structure 的詳細描述。
        /// </para>
        /// </remarks>
        public SubstanceDefinitionStructure? Structure
        {
            get => _structure;
            set
            {
                _structure = value;
                OnPropertyChanged(nameof(Structure));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstanceDefinitionCode>? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstanceDefinitionName>? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Relationship
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relationship 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstanceDefinitionRelationship>? Relationship
        {
            get => _relationship;
            set
            {
                _relationship = value;
                OnPropertyChanged(nameof(Relationship));
            }
        }        /// <summary>
        /// Nucleicacid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Nucleicacid 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Nucleicacid
        {
            get => _nucleicacid;
            set
            {
                _nucleicacid = value;
                OnPropertyChanged(nameof(Nucleicacid));
            }
        }        /// <summary>
        /// Polymer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Polymer 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Polymer
        {
            get => _polymer;
            set
            {
                _polymer = value;
                OnPropertyChanged(nameof(Polymer));
            }
        }        /// <summary>
        /// Protein
        /// </summary>
        /// <remarks>
        /// <para>
        /// Protein 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Protein
        {
            get => _protein;
            set
            {
                _protein = value;
                OnPropertyChanged(nameof(Protein));
            }
        }        /// <summary>
        /// Sourcematerial
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sourcematerial 的詳細描述。
        /// </para>
        /// </remarks>
        public SubstanceDefinitionSourceMaterial? Sourcematerial
        {
            get => _sourcematerial;
            set
            {
                _sourcematerial = value;
                OnPropertyChanged(nameof(Sourcematerial));
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
        /// Stereochemistry
        /// </summary>
        /// <remarks>
        /// <para>
        /// Stereochemistry 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Stereochemistry
        {
            get => _stereochemistry;
            set
            {
                _stereochemistry = value;
                OnPropertyChanged(nameof(Stereochemistry));
            }
        }        /// <summary>
        /// Opticalactivity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Opticalactivity 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Opticalactivity
        {
            get => _opticalactivity;
            set
            {
                _opticalactivity = value;
                OnPropertyChanged(nameof(Opticalactivity));
            }
        }        /// <summary>
        /// Molecularformula
        /// </summary>
        /// <remarks>
        /// <para>
        /// Molecularformula 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Molecularformula
        {
            get => _molecularformula;
            set
            {
                _molecularformula = value;
                OnPropertyChanged(nameof(Molecularformula));
            }
        }        /// <summary>
        /// Amount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Amount 的詳細描述。
        /// </para>
        /// </remarks>
        public SubstanceDefinitionMoietyAmountChoice? Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }        /// <summary>
        /// Measurementtype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Measurementtype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Measurementtype
        {
            get => _measurementtype;
            set
            {
                _measurementtype = value;
                OnPropertyChanged(nameof(Measurementtype));
            }
        }        /// <summary>
        /// Technique
        /// </summary>
        /// <remarks>
        /// <para>
        /// Technique 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Technique
        {
            get => _technique;
            set
            {
                _technique = value;
                OnPropertyChanged(nameof(Technique));
            }
        }        /// <summary>
        /// Form
        /// </summary>
        /// <remarks>
        /// <para>
        /// Form 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Form
        {
            get => _form;
            set
            {
                _form = value;
                OnPropertyChanged(nameof(Form));
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
        /// File
        /// </summary>
        /// <remarks>
        /// <para>
        /// File 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Attachment>? File
        {
            get => _file;
            set
            {
                _file = value;
                OnPropertyChanged(nameof(File));
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
        public SubstanceDefinitionPropertyValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
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
        /// Amount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Amount 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
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
        /// Representation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Representation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Representation
        {
            get => _representation;
            set
            {
                _representation = value;
                OnPropertyChanged(nameof(Representation));
            }
        }        /// <summary>
        /// Format
        /// </summary>
        /// <remarks>
        /// <para>
        /// Format 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Format
        {
            get => _format;
            set
            {
                _format = value;
                OnPropertyChanged(nameof(Format));
            }
        }        /// <summary>
        /// Document
        /// </summary>
        /// <remarks>
        /// <para>
        /// Document 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Document
        {
            get => _document;
            set
            {
                _document = value;
                OnPropertyChanged(nameof(Document));
            }
        }        /// <summary>
        /// Stereochemistry
        /// </summary>
        /// <remarks>
        /// <para>
        /// Stereochemistry 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Stereochemistry
        {
            get => _stereochemistry;
            set
            {
                _stereochemistry = value;
                OnPropertyChanged(nameof(Stereochemistry));
            }
        }        /// <summary>
        /// Opticalactivity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Opticalactivity 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Opticalactivity
        {
            get => _opticalactivity;
            set
            {
                _opticalactivity = value;
                OnPropertyChanged(nameof(Opticalactivity));
            }
        }        /// <summary>
        /// Molecularformula
        /// </summary>
        /// <remarks>
        /// <para>
        /// Molecularformula 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Molecularformula
        {
            get => _molecularformula;
            set
            {
                _molecularformula = value;
                OnPropertyChanged(nameof(Molecularformula));
            }
        }        /// <summary>
        /// Molecularformulabymoiety
        /// </summary>
        /// <remarks>
        /// <para>
        /// Molecularformulabymoiety 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Molecularformulabymoiety
        {
            get => _molecularformulabymoiety;
            set
            {
                _molecularformulabymoiety = value;
                OnPropertyChanged(nameof(Molecularformulabymoiety));
            }
        }        /// <summary>
        /// Technique
        /// </summary>
        /// <remarks>
        /// <para>
        /// Technique 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Technique
        {
            get => _technique;
            set
            {
                _technique = value;
                OnPropertyChanged(nameof(Technique));
            }
        }        /// <summary>
        /// Sourcedocument
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sourcedocument 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Sourcedocument
        {
            get => _sourcedocument;
            set
            {
                _sourcedocument = value;
                OnPropertyChanged(nameof(Sourcedocument));
            }
        }        /// <summary>
        /// Representation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Representation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstanceDefinitionStructureRepresentation>? Representation
        {
            get => _representation;
            set
            {
                _representation = value;
                OnPropertyChanged(nameof(Representation));
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
        /// Status
        /// </summary>
        /// <remarks>
        /// <para>
        /// Status 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }        /// <summary>
        /// Statusdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Statusdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Statusdate
        {
            get => _statusdate;
            set
            {
                _statusdate = value;
                OnPropertyChanged(nameof(Statusdate));
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
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
            }
        }        /// <summary>
        /// Authority
        /// </summary>
        /// <remarks>
        /// <para>
        /// Authority 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Authority
        {
            get => _authority;
            set
            {
                _authority = value;
                OnPropertyChanged(nameof(Authority));
            }
        }        /// <summary>
        /// Status
        /// </summary>
        /// <remarks>
        /// <para>
        /// Status 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
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
        /// Status
        /// </summary>
        /// <remarks>
        /// <para>
        /// Status 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }        /// <summary>
        /// Preferred
        /// </summary>
        /// <remarks>
        /// <para>
        /// Preferred 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Preferred
        {
            get => _preferred;
            set
            {
                _preferred = value;
                OnPropertyChanged(nameof(Preferred));
            }
        }        /// <summary>
        /// Language
        /// </summary>
        /// <remarks>
        /// <para>
        /// Language 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Language
        {
            get => _language;
            set
            {
                _language = value;
                OnPropertyChanged(nameof(Language));
            }
        }        /// <summary>
        /// Domain
        /// </summary>
        /// <remarks>
        /// <para>
        /// Domain 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Domain
        {
            get => _domain;
            set
            {
                _domain = value;
                OnPropertyChanged(nameof(Domain));
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
        /// Official
        /// </summary>
        /// <remarks>
        /// <para>
        /// Official 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstanceDefinitionNameOfficial>? Official
        {
            get => _official;
            set
            {
                _official = value;
                OnPropertyChanged(nameof(Official));
            }
        }        /// <summary>
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
            }
        }        /// <summary>
        /// Substancedefinition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Substancedefinition 的詳細描述。
        /// </para>
        /// </remarks>
        public SubstanceDefinitionRelationshipSubstanceDefinitionChoice? Substancedefinition
        {
            get => _substancedefinition;
            set
            {
                _substancedefinition = value;
                OnPropertyChanged(nameof(Substancedefinition));
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
        /// Isdefining
        /// </summary>
        /// <remarks>
        /// <para>
        /// Isdefining 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Isdefining
        {
            get => _isdefining;
            set
            {
                _isdefining = value;
                OnPropertyChanged(nameof(Isdefining));
            }
        }        /// <summary>
        /// Amount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Amount 的詳細描述。
        /// </para>
        /// </remarks>
        public SubstanceDefinitionRelationshipAmountChoice? Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }        /// <summary>
        /// Ratiohighlimitamount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Ratiohighlimitamount 的詳細描述。
        /// </para>
        /// </remarks>
        public Ratio? Ratiohighlimitamount
        {
            get => _ratiohighlimitamount;
            set
            {
                _ratiohighlimitamount = value;
                OnPropertyChanged(nameof(Ratiohighlimitamount));
            }
        }        /// <summary>
        /// Comparator
        /// </summary>
        /// <remarks>
        /// <para>
        /// Comparator 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Comparator
        {
            get => _comparator;
            set
            {
                _comparator = value;
                OnPropertyChanged(nameof(Comparator));
            }
        }        /// <summary>
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
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
        /// Genus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Genus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Genus
        {
            get => _genus;
            set
            {
                _genus = value;
                OnPropertyChanged(nameof(Genus));
            }
        }        /// <summary>
        /// Species
        /// </summary>
        /// <remarks>
        /// <para>
        /// Species 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Species
        {
            get => _species;
            set
            {
                _species = value;
                OnPropertyChanged(nameof(Species));
            }
        }        /// <summary>
        /// Part
        /// </summary>
        /// <remarks>
        /// <para>
        /// Part 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Part
        {
            get => _part;
            set
            {
                _part = value;
                OnPropertyChanged(nameof(Part));
            }
        }        /// <summary>
        /// Countryoforigin
        /// </summary>
        /// <remarks>
        /// <para>
        /// Countryoforigin 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Countryoforigin
        {
            get => _countryoforigin;
            set
            {
                _countryoforigin = value;
                OnPropertyChanged(nameof(Countryoforigin));
            }
        }        /// <summary>
        /// 建立新的 SubstanceDefinition 資源實例
        /// </summary>
        public SubstanceDefinition()
        {
        }

        /// <summary>
        /// 建立新的 SubstanceDefinition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public SubstanceDefinition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"SubstanceDefinition(Id: {Id})";
        }
    }    /// <summary>
    /// SubstanceDefinitionMoiety 背骨元素
    /// </summary>
    public class SubstanceDefinitionMoiety
    {
        // TODO: 添加屬性實作
        
        public SubstanceDefinitionMoiety() { }
    }    /// <summary>
    /// SubstanceDefinitionCharacterization 背骨元素
    /// </summary>
    public class SubstanceDefinitionCharacterization
    {
        // TODO: 添加屬性實作
        
        public SubstanceDefinitionCharacterization() { }
    }    /// <summary>
    /// SubstanceDefinitionProperty 背骨元素
    /// </summary>
    public class SubstanceDefinitionProperty
    {
        // TODO: 添加屬性實作
        
        public SubstanceDefinitionProperty() { }
    }    /// <summary>
    /// SubstanceDefinitionMolecularWeight 背骨元素
    /// </summary>
    public class SubstanceDefinitionMolecularWeight
    {
        // TODO: 添加屬性實作
        
        public SubstanceDefinitionMolecularWeight() { }
    }    /// <summary>
    /// SubstanceDefinitionStructureRepresentation 背骨元素
    /// </summary>
    public class SubstanceDefinitionStructureRepresentation
    {
        // TODO: 添加屬性實作
        
        public SubstanceDefinitionStructureRepresentation() { }
    }    /// <summary>
    /// SubstanceDefinitionStructure 背骨元素
    /// </summary>
    public class SubstanceDefinitionStructure
    {
        // TODO: 添加屬性實作
        
        public SubstanceDefinitionStructure() { }
    }    /// <summary>
    /// SubstanceDefinitionCode 背骨元素
    /// </summary>
    public class SubstanceDefinitionCode
    {
        // TODO: 添加屬性實作
        
        public SubstanceDefinitionCode() { }
    }    /// <summary>
    /// SubstanceDefinitionNameOfficial 背骨元素
    /// </summary>
    public class SubstanceDefinitionNameOfficial
    {
        // TODO: 添加屬性實作
        
        public SubstanceDefinitionNameOfficial() { }
    }    /// <summary>
    /// SubstanceDefinitionName 背骨元素
    /// </summary>
    public class SubstanceDefinitionName
    {
        // TODO: 添加屬性實作
        
        public SubstanceDefinitionName() { }
    }    /// <summary>
    /// SubstanceDefinitionRelationship 背骨元素
    /// </summary>
    public class SubstanceDefinitionRelationship
    {
        // TODO: 添加屬性實作
        
        public SubstanceDefinitionRelationship() { }
    }    /// <summary>
    /// SubstanceDefinitionSourceMaterial 背骨元素
    /// </summary>
    public class SubstanceDefinitionSourceMaterial
    {
        // TODO: 添加屬性實作
        
        public SubstanceDefinitionSourceMaterial() { }
    }    /// <summary>
    /// SubstanceDefinitionMoietyAmountChoice 選擇類型
    /// </summary>
    public class SubstanceDefinitionMoietyAmountChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public SubstanceDefinitionMoietyAmountChoice(JsonObject value) : base("substancedefinitionmoietyamount", value, _supportType) { }
        public SubstanceDefinitionMoietyAmountChoice(IComplexType? value) : base("substancedefinitionmoietyamount", value) { }
        public SubstanceDefinitionMoietyAmountChoice(IPrimitiveType? value) : base("substancedefinitionmoietyamount", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "SubstanceDefinitionMoietyAmount" : "substancedefinitionmoietyamount";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// SubstanceDefinitionPropertyValueChoice 選擇類型
    /// </summary>
    public class SubstanceDefinitionPropertyValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public SubstanceDefinitionPropertyValueChoice(JsonObject value) : base("substancedefinitionpropertyvalue", value, _supportType) { }
        public SubstanceDefinitionPropertyValueChoice(IComplexType? value) : base("substancedefinitionpropertyvalue", value) { }
        public SubstanceDefinitionPropertyValueChoice(IPrimitiveType? value) : base("substancedefinitionpropertyvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "SubstanceDefinitionPropertyValue" : "substancedefinitionpropertyvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// SubstanceDefinitionRelationshipSubstanceDefinitionChoice 選擇類型
    /// </summary>
    public class SubstanceDefinitionRelationshipSubstanceDefinitionChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public SubstanceDefinitionRelationshipSubstanceDefinitionChoice(JsonObject value) : base("substancedefinitionrelationshipsubstancedefinition", value, _supportType) { }
        public SubstanceDefinitionRelationshipSubstanceDefinitionChoice(IComplexType? value) : base("substancedefinitionrelationshipsubstancedefinition", value) { }
        public SubstanceDefinitionRelationshipSubstanceDefinitionChoice(IPrimitiveType? value) : base("substancedefinitionrelationshipsubstancedefinition", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "SubstanceDefinitionRelationshipSubstanceDefinition" : "substancedefinitionrelationshipsubstancedefinition";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// SubstanceDefinitionRelationshipAmountChoice 選擇類型
    /// </summary>
    public class SubstanceDefinitionRelationshipAmountChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public SubstanceDefinitionRelationshipAmountChoice(JsonObject value) : base("substancedefinitionrelationshipamount", value, _supportType) { }
        public SubstanceDefinitionRelationshipAmountChoice(IComplexType? value) : base("substancedefinitionrelationshipamount", value) { }
        public SubstanceDefinitionRelationshipAmountChoice(IPrimitiveType? value) : base("substancedefinitionrelationshipamount", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "SubstanceDefinitionRelationshipAmount" : "substancedefinitionrelationshipamount";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
