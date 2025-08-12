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
    /// FHIR R5 DeviceDefinition 資源
    /// 
    /// <para>
    /// DeviceDefinition 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var devicedefinition = new DeviceDefinition("devicedefinition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 DeviceDefinition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class DeviceDefinition : ResourceBase<R5Version>
    {
        private Property
		private FhirMarkdown? _description;
        private List<Identifier>? _identifier;
        private List<DeviceDefinitionUdiDeviceIdentifier>? _udideviceidentifier;
        private List<DeviceDefinitionRegulatoryIdentifier>? _regulatoryidentifier;
        private FhirString? _partnumber;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _manufacturer;
        private List<DeviceDefinitionDeviceName>? _devicename;
        private FhirString? _modelnumber;
        private List<DeviceDefinitionClassification>? _classification;
        private List<DeviceDefinitionConformsTo>? _conformsto;
        private List<DeviceDefinitionHasPart>? _haspart;
        private List<DeviceDefinitionPackaging>? _packaging;
        private List<DeviceDefinitionVersion>? _version;
        private List<CodeableConcept>? _safety;
        private List<ProductShelfLife>? _shelflifestorage;
        private List<CodeableConcept>? _languagecode;
        private List<DeviceDefinitionProperty>? _property;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _owner;
        private List<ContactPoint>? _contact;
        private List<DeviceDefinitionLink>? _link;
        private List<Annotation>? _note;
        private List<DeviceDefinitionMaterial>? _material;
        private List<FhirCode>? _productionidentifierinudi;
        private DeviceDefinitionGuideline? _guideline;
        private DeviceDefinitionCorrectiveAction? _correctiveaction;
        private List<DeviceDefinitionChargeItem>? _chargeitem;
        private Period? _marketperiod;
        private FhirUri? _subjurisdiction;
        private FhirString? _deviceidentifier;
        private FhirUri? _issuer;
        private FhirUri? _jurisdiction;
        private List<DeviceDefinitionUdiDeviceIdentifierMarketDistribution>? _marketdistribution;
        private FhirCode? _type;
        private FhirString? _deviceidentifier;
        private FhirUri? _issuer;
        private FhirUri? _jurisdiction;
        private FhirString? _name;
        private FhirCode? _type;
        private CodeableConcept? _type;
        private List<RelatedArtifact>? _justification;
        private CodeableConcept? _category;
        private CodeableConcept? _specification;
        private List<FhirString>? _version;
        private List<RelatedArtifact>? _source;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _reference;
        private FhirInteger? _count;
        private FhirString? _name;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _organizationreference;
        private Identifier? _identifier;
        private CodeableConcept? _type;
        private FhirInteger? _count;
        private List<DeviceDefinitionPackagingDistributor>? _distributor;
        private CodeableConcept? _type;
        private Identifier? _component;
        private FhirString? _value;
        private CodeableConcept? _type;
        private DeviceDefinitionPropertyValueChoice? _value;
        private Coding? _relation;
        private CodeableReference? _relateddevice;
        private CodeableConcept? _substance;
        private FhirBoolean? _alternate;
        private FhirBoolean? _allergenicindicator;
        private List<UsageContext>? _usecontext;
        private FhirMarkdown? _usageinstruction;
        private List<RelatedArtifact>? _relatedartifact;
        private List<CodeableConcept>? _indication;
        private List<CodeableConcept>? _contraindication;
        private List<CodeableConcept>? _warning;
        private FhirString? _intendeduse;
        private FhirBoolean? _recall;
        private FhirCode? _scope;
        private Period? _period;
        private CodeableReference? _chargeitemcode;
        private Quantity? _count;
        private Period? _effectiveperiod;
        private List<UsageContext>? _usecontext;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "DeviceDefinition";        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private FhirMarkdown? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
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
        /// Udideviceidentifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Udideviceidentifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DeviceDefinitionUdiDeviceIdentifier>? Udideviceidentifier
        {
            get => _udideviceidentifier;
            set
            {
                _udideviceidentifier = value;
                OnPropertyChanged(nameof(Udideviceidentifier));
            }
        }        /// <summary>
        /// Regulatoryidentifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Regulatoryidentifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DeviceDefinitionRegulatoryIdentifier>? Regulatoryidentifier
        {
            get => _regulatoryidentifier;
            set
            {
                _regulatoryidentifier = value;
                OnPropertyChanged(nameof(Regulatoryidentifier));
            }
        }        /// <summary>
        /// Partnumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Partnumber 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Partnumber
        {
            get => _partnumber;
            set
            {
                _partnumber = value;
                OnPropertyChanged(nameof(Partnumber));
            }
        }        /// <summary>
        /// Manufacturer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Manufacturer 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Manufacturer
        {
            get => _manufacturer;
            set
            {
                _manufacturer = value;
                OnPropertyChanged(nameof(Manufacturer));
            }
        }        /// <summary>
        /// Devicename
        /// </summary>
        /// <remarks>
        /// <para>
        /// Devicename 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DeviceDefinitionDeviceName>? Devicename
        {
            get => _devicename;
            set
            {
                _devicename = value;
                OnPropertyChanged(nameof(Devicename));
            }
        }        /// <summary>
        /// Modelnumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Modelnumber 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Modelnumber
        {
            get => _modelnumber;
            set
            {
                _modelnumber = value;
                OnPropertyChanged(nameof(Modelnumber));
            }
        }        /// <summary>
        /// Classification
        /// </summary>
        /// <remarks>
        /// <para>
        /// Classification 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DeviceDefinitionClassification>? Classification
        {
            get => _classification;
            set
            {
                _classification = value;
                OnPropertyChanged(nameof(Classification));
            }
        }        /// <summary>
        /// Conformsto
        /// </summary>
        /// <remarks>
        /// <para>
        /// Conformsto 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DeviceDefinitionConformsTo>? Conformsto
        {
            get => _conformsto;
            set
            {
                _conformsto = value;
                OnPropertyChanged(nameof(Conformsto));
            }
        }        /// <summary>
        /// Haspart
        /// </summary>
        /// <remarks>
        /// <para>
        /// Haspart 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DeviceDefinitionHasPart>? Haspart
        {
            get => _haspart;
            set
            {
                _haspart = value;
                OnPropertyChanged(nameof(Haspart));
            }
        }        /// <summary>
        /// Packaging
        /// </summary>
        /// <remarks>
        /// <para>
        /// Packaging 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DeviceDefinitionPackaging>? Packaging
        {
            get => _packaging;
            set
            {
                _packaging = value;
                OnPropertyChanged(nameof(Packaging));
            }
        }        /// <summary>
        /// Version
        /// </summary>
        /// <remarks>
        /// <para>
        /// Version 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DeviceDefinitionVersion>? Version
        {
            get => _version;
            set
            {
                _version = value;
                OnPropertyChanged(nameof(Version));
            }
        }        /// <summary>
        /// Safety
        /// </summary>
        /// <remarks>
        /// <para>
        /// Safety 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Safety
        {
            get => _safety;
            set
            {
                _safety = value;
                OnPropertyChanged(nameof(Safety));
            }
        }        /// <summary>
        /// Shelflifestorage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Shelflifestorage 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ProductShelfLife>? Shelflifestorage
        {
            get => _shelflifestorage;
            set
            {
                _shelflifestorage = value;
                OnPropertyChanged(nameof(Shelflifestorage));
            }
        }        /// <summary>
        /// Languagecode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Languagecode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Languagecode
        {
            get => _languagecode;
            set
            {
                _languagecode = value;
                OnPropertyChanged(nameof(Languagecode));
            }
        }        /// <summary>
        /// Property
        /// </summary>
        /// <remarks>
        /// <para>
        /// Property 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DeviceDefinitionProperty>? Property
        {
            get => _property;
            set
            {
                _property = value;
                OnPropertyChanged(nameof(Property));
            }
        }        /// <summary>
        /// Owner
        /// </summary>
        /// <remarks>
        /// <para>
        /// Owner 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Owner
        {
            get => _owner;
            set
            {
                _owner = value;
                OnPropertyChanged(nameof(Owner));
            }
        }        /// <summary>
        /// Contact
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactPoint>? Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }        /// <summary>
        /// Link
        /// </summary>
        /// <remarks>
        /// <para>
        /// Link 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DeviceDefinitionLink>? Link
        {
            get => _link;
            set
            {
                _link = value;
                OnPropertyChanged(nameof(Link));
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
        /// Material
        /// </summary>
        /// <remarks>
        /// <para>
        /// Material 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DeviceDefinitionMaterial>? Material
        {
            get => _material;
            set
            {
                _material = value;
                OnPropertyChanged(nameof(Material));
            }
        }        /// <summary>
        /// Productionidentifierinudi
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productionidentifierinudi 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Productionidentifierinudi
        {
            get => _productionidentifierinudi;
            set
            {
                _productionidentifierinudi = value;
                OnPropertyChanged(nameof(Productionidentifierinudi));
            }
        }        /// <summary>
        /// Guideline
        /// </summary>
        /// <remarks>
        /// <para>
        /// Guideline 的詳細描述。
        /// </para>
        /// </remarks>
        public DeviceDefinitionGuideline? Guideline
        {
            get => _guideline;
            set
            {
                _guideline = value;
                OnPropertyChanged(nameof(Guideline));
            }
        }        /// <summary>
        /// Correctiveaction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Correctiveaction 的詳細描述。
        /// </para>
        /// </remarks>
        public DeviceDefinitionCorrectiveAction? Correctiveaction
        {
            get => _correctiveaction;
            set
            {
                _correctiveaction = value;
                OnPropertyChanged(nameof(Correctiveaction));
            }
        }        /// <summary>
        /// Chargeitem
        /// </summary>
        /// <remarks>
        /// <para>
        /// Chargeitem 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DeviceDefinitionChargeItem>? Chargeitem
        {
            get => _chargeitem;
            set
            {
                _chargeitem = value;
                OnPropertyChanged(nameof(Chargeitem));
            }
        }        /// <summary>
        /// Marketperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Marketperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Marketperiod
        {
            get => _marketperiod;
            set
            {
                _marketperiod = value;
                OnPropertyChanged(nameof(Marketperiod));
            }
        }        /// <summary>
        /// Subjurisdiction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subjurisdiction 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Subjurisdiction
        {
            get => _subjurisdiction;
            set
            {
                _subjurisdiction = value;
                OnPropertyChanged(nameof(Subjurisdiction));
            }
        }        /// <summary>
        /// Deviceidentifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Deviceidentifier 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Deviceidentifier
        {
            get => _deviceidentifier;
            set
            {
                _deviceidentifier = value;
                OnPropertyChanged(nameof(Deviceidentifier));
            }
        }        /// <summary>
        /// Issuer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Issuer 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Issuer
        {
            get => _issuer;
            set
            {
                _issuer = value;
                OnPropertyChanged(nameof(Issuer));
            }
        }        /// <summary>
        /// Jurisdiction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Jurisdiction 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Jurisdiction
        {
            get => _jurisdiction;
            set
            {
                _jurisdiction = value;
                OnPropertyChanged(nameof(Jurisdiction));
            }
        }        /// <summary>
        /// Marketdistribution
        /// </summary>
        /// <remarks>
        /// <para>
        /// Marketdistribution 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DeviceDefinitionUdiDeviceIdentifierMarketDistribution>? Marketdistribution
        {
            get => _marketdistribution;
            set
            {
                _marketdistribution = value;
                OnPropertyChanged(nameof(Marketdistribution));
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
        /// Deviceidentifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Deviceidentifier 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Deviceidentifier
        {
            get => _deviceidentifier;
            set
            {
                _deviceidentifier = value;
                OnPropertyChanged(nameof(Deviceidentifier));
            }
        }        /// <summary>
        /// Issuer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Issuer 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Issuer
        {
            get => _issuer;
            set
            {
                _issuer = value;
                OnPropertyChanged(nameof(Issuer));
            }
        }        /// <summary>
        /// Jurisdiction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Jurisdiction 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Jurisdiction
        {
            get => _jurisdiction;
            set
            {
                _jurisdiction = value;
                OnPropertyChanged(nameof(Jurisdiction));
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
        public FhirCode? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
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
        /// Justification
        /// </summary>
        /// <remarks>
        /// <para>
        /// Justification 的詳細描述。
        /// </para>
        /// </remarks>
        public List<RelatedArtifact>? Justification
        {
            get => _justification;
            set
            {
                _justification = value;
                OnPropertyChanged(nameof(Justification));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Specification
        /// </summary>
        /// <remarks>
        /// <para>
        /// Specification 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Specification
        {
            get => _specification;
            set
            {
                _specification = value;
                OnPropertyChanged(nameof(Specification));
            }
        }        /// <summary>
        /// Version
        /// </summary>
        /// <remarks>
        /// <para>
        /// Version 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Version
        {
            get => _version;
            set
            {
                _version = value;
                OnPropertyChanged(nameof(Version));
            }
        }        /// <summary>
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public List<RelatedArtifact>? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
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
        /// Count
        /// </summary>
        /// <remarks>
        /// <para>
        /// Count 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Count
        {
            get => _count;
            set
            {
                _count = value;
                OnPropertyChanged(nameof(Count));
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
        /// Organizationreference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Organizationreference 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Organizationreference
        {
            get => _organizationreference;
            set
            {
                _organizationreference = value;
                OnPropertyChanged(nameof(Organizationreference));
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
        /// Count
        /// </summary>
        /// <remarks>
        /// <para>
        /// Count 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Count
        {
            get => _count;
            set
            {
                _count = value;
                OnPropertyChanged(nameof(Count));
            }
        }        /// <summary>
        /// Distributor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Distributor 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DeviceDefinitionPackagingDistributor>? Distributor
        {
            get => _distributor;
            set
            {
                _distributor = value;
                OnPropertyChanged(nameof(Distributor));
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
        /// Component
        /// </summary>
        /// <remarks>
        /// <para>
        /// Component 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? Component
        {
            get => _component;
            set
            {
                _component = value;
                OnPropertyChanged(nameof(Component));
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
        public DeviceDefinitionPropertyValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Relation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relation 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? Relation
        {
            get => _relation;
            set
            {
                _relation = value;
                OnPropertyChanged(nameof(Relation));
            }
        }        /// <summary>
        /// Relateddevice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relateddevice 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Relateddevice
        {
            get => _relateddevice;
            set
            {
                _relateddevice = value;
                OnPropertyChanged(nameof(Relateddevice));
            }
        }        /// <summary>
        /// Substance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Substance 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Substance
        {
            get => _substance;
            set
            {
                _substance = value;
                OnPropertyChanged(nameof(Substance));
            }
        }        /// <summary>
        /// Alternate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Alternate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Alternate
        {
            get => _alternate;
            set
            {
                _alternate = value;
                OnPropertyChanged(nameof(Alternate));
            }
        }        /// <summary>
        /// Allergenicindicator
        /// </summary>
        /// <remarks>
        /// <para>
        /// Allergenicindicator 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Allergenicindicator
        {
            get => _allergenicindicator;
            set
            {
                _allergenicindicator = value;
                OnPropertyChanged(nameof(Allergenicindicator));
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
        /// Usageinstruction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Usageinstruction 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Usageinstruction
        {
            get => _usageinstruction;
            set
            {
                _usageinstruction = value;
                OnPropertyChanged(nameof(Usageinstruction));
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
        /// Indication
        /// </summary>
        /// <remarks>
        /// <para>
        /// Indication 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Indication
        {
            get => _indication;
            set
            {
                _indication = value;
                OnPropertyChanged(nameof(Indication));
            }
        }        /// <summary>
        /// Contraindication
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contraindication 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Contraindication
        {
            get => _contraindication;
            set
            {
                _contraindication = value;
                OnPropertyChanged(nameof(Contraindication));
            }
        }        /// <summary>
        /// Warning
        /// </summary>
        /// <remarks>
        /// <para>
        /// Warning 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Warning
        {
            get => _warning;
            set
            {
                _warning = value;
                OnPropertyChanged(nameof(Warning));
            }
        }        /// <summary>
        /// Intendeduse
        /// </summary>
        /// <remarks>
        /// <para>
        /// Intendeduse 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Intendeduse
        {
            get => _intendeduse;
            set
            {
                _intendeduse = value;
                OnPropertyChanged(nameof(Intendeduse));
            }
        }        /// <summary>
        /// Recall
        /// </summary>
        /// <remarks>
        /// <para>
        /// Recall 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Recall
        {
            get => _recall;
            set
            {
                _recall = value;
                OnPropertyChanged(nameof(Recall));
            }
        }        /// <summary>
        /// Scope
        /// </summary>
        /// <remarks>
        /// <para>
        /// Scope 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Scope
        {
            get => _scope;
            set
            {
                _scope = value;
                OnPropertyChanged(nameof(Scope));
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
        /// Chargeitemcode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Chargeitemcode 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Chargeitemcode
        {
            get => _chargeitemcode;
            set
            {
                _chargeitemcode = value;
                OnPropertyChanged(nameof(Chargeitemcode));
            }
        }        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// <para>
        /// Count 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Count
        {
            get => _count;
            set
            {
                _count = value;
                OnPropertyChanged(nameof(Count));
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
        /// 建立新的 DeviceDefinition 資源實例
        /// </summary>
        public DeviceDefinition()
        {
        }

        /// <summary>
        /// 建立新的 DeviceDefinition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public DeviceDefinition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"DeviceDefinition(Id: {Id})";
        }
    }    /// <summary>
    /// DeviceDefinitionUdiDeviceIdentifierMarketDistribution 背骨元素
    /// </summary>
    public class DeviceDefinitionUdiDeviceIdentifierMarketDistribution
    {
        // TODO: 添加屬性實作
        
        public DeviceDefinitionUdiDeviceIdentifierMarketDistribution() { }
    }    /// <summary>
    /// DeviceDefinitionUdiDeviceIdentifier 背骨元素
    /// </summary>
    public class DeviceDefinitionUdiDeviceIdentifier
    {
        // TODO: 添加屬性實作
        
        public DeviceDefinitionUdiDeviceIdentifier() { }
    }    /// <summary>
    /// DeviceDefinitionRegulatoryIdentifier 背骨元素
    /// </summary>
    public class DeviceDefinitionRegulatoryIdentifier
    {
        // TODO: 添加屬性實作
        
        public DeviceDefinitionRegulatoryIdentifier() { }
    }    /// <summary>
    /// DeviceDefinitionDeviceName 背骨元素
    /// </summary>
    public class DeviceDefinitionDeviceName
    {
        // TODO: 添加屬性實作
        
        public DeviceDefinitionDeviceName() { }
    }    /// <summary>
    /// DeviceDefinitionClassification 背骨元素
    /// </summary>
    public class DeviceDefinitionClassification
    {
        // TODO: 添加屬性實作
        
        public DeviceDefinitionClassification() { }
    }    /// <summary>
    /// DeviceDefinitionConformsTo 背骨元素
    /// </summary>
    public class DeviceDefinitionConformsTo
    {
        // TODO: 添加屬性實作
        
        public DeviceDefinitionConformsTo() { }
    }    /// <summary>
    /// DeviceDefinitionHasPart 背骨元素
    /// </summary>
    public class DeviceDefinitionHasPart
    {
        // TODO: 添加屬性實作
        
        public DeviceDefinitionHasPart() { }
    }    /// <summary>
    /// DeviceDefinitionPackagingDistributor 背骨元素
    /// </summary>
    public class DeviceDefinitionPackagingDistributor
    {
        // TODO: 添加屬性實作
        
        public DeviceDefinitionPackagingDistributor() { }
    }    /// <summary>
    /// DeviceDefinitionPackaging 背骨元素
    /// </summary>
    public class DeviceDefinitionPackaging
    {
        // TODO: 添加屬性實作
        
        public DeviceDefinitionPackaging() { }
    }    /// <summary>
    /// DeviceDefinitionVersion 背骨元素
    /// </summary>
    public class DeviceDefinitionVersion
    {
        // TODO: 添加屬性實作
        
        public DeviceDefinitionVersion() { }
    }    /// <summary>
    /// DeviceDefinitionProperty 背骨元素
    /// </summary>
    public class DeviceDefinitionProperty
    {
        // TODO: 添加屬性實作
        
        public DeviceDefinitionProperty() { }
    }    /// <summary>
    /// DeviceDefinitionLink 背骨元素
    /// </summary>
    public class DeviceDefinitionLink
    {
        // TODO: 添加屬性實作
        
        public DeviceDefinitionLink() { }
    }    /// <summary>
    /// DeviceDefinitionMaterial 背骨元素
    /// </summary>
    public class DeviceDefinitionMaterial
    {
        // TODO: 添加屬性實作
        
        public DeviceDefinitionMaterial() { }
    }    /// <summary>
    /// DeviceDefinitionGuideline 背骨元素
    /// </summary>
    public class DeviceDefinitionGuideline
    {
        // TODO: 添加屬性實作
        
        public DeviceDefinitionGuideline() { }
    }    /// <summary>
    /// DeviceDefinitionCorrectiveAction 背骨元素
    /// </summary>
    public class DeviceDefinitionCorrectiveAction
    {
        // TODO: 添加屬性實作
        
        public DeviceDefinitionCorrectiveAction() { }
    }    /// <summary>
    /// DeviceDefinitionChargeItem 背骨元素
    /// </summary>
    public class DeviceDefinitionChargeItem
    {
        // TODO: 添加屬性實作
        
        public DeviceDefinitionChargeItem() { }
    }    /// <summary>
    /// DeviceDefinitionPropertyValueChoice 選擇類型
    /// </summary>
    public class DeviceDefinitionPropertyValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public DeviceDefinitionPropertyValueChoice(JsonObject value) : base("devicedefinitionpropertyvalue", value, _supportType) { }
        public DeviceDefinitionPropertyValueChoice(IComplexType? value) : base("devicedefinitionpropertyvalue", value) { }
        public DeviceDefinitionPropertyValueChoice(IPrimitiveType? value) : base("devicedefinitionpropertyvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "DeviceDefinitionPropertyValue" : "devicedefinitionpropertyvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
