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
    /// FHIR R5 MedicinalProductDefinition 資源
    /// 
    /// <para>
    /// MedicinalProductDefinition 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var medicinalproductdefinition = new MedicinalProductDefinition("medicinalproductdefinition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 MedicinalProductDefinition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MedicinalProductDefinition : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private CodeableConcept? _type;
        private CodeableConcept? _domain;
        private FhirString? _version;
        private CodeableConcept? _status;
        private FhirDateTime? _statusdate;
        private FhirMarkdown? _description;
        private CodeableConcept? _combinedpharmaceuticaldoseform;
        private List<CodeableConcept>? _route;
        private FhirMarkdown? _indication;
        private CodeableConcept? _legalstatusofsupply;
        private CodeableConcept? _additionalmonitoringindicator;
        private List<CodeableConcept>? _specialmeasures;
        private CodeableConcept? _pediatricuseindicator;
        private List<CodeableConcept>? _classification;
        private List<MarketingStatus>? _marketingstatus;
        private List<CodeableConcept>? _packagedmedicinalproduct;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _comprisedof;
        private List<CodeableConcept>? _ingredient;
        private List<CodeableReference>? _impurity;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _attacheddocument;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _masterfile;
        private List<MedicinalProductDefinitionContact>? _contact;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _clinicaltrial;
        private List<Coding>? _code;
        private List<MedicinalProductDefinitionName>? _name;
        private List<MedicinalProductDefinitionCrossReference>? _crossreference;
        private List<MedicinalProductDefinitionOperation>? _operation;
        private List<MedicinalProductDefinitionCharacteristic>? _characteristic;
        private CodeableConcept? _type;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _contact;
        private FhirString? _part;
        private CodeableConcept? _type;
        private CodeableConcept? _country;
        private CodeableConcept? _jurisdiction;
        private CodeableConcept? _language;
        private FhirString? _productname;
        private CodeableConcept? _type;
        private List<MedicinalProductDefinitionNamePart>? _part;
        private List<MedicinalProductDefinitionNameUsage>? _usage;
        private CodeableReference? _product;
        private CodeableConcept? _type;
        private CodeableReference? _type;
        private Period? _effectivedate;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _organization;
        private CodeableConcept? _confidentialityindicator;
        private CodeableConcept? _type;
        private MedicinalProductDefinitionCharacteristicValueChoice? _value;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "MedicinalProductDefinition";        /// <summary>
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
        /// Combinedpharmaceuticaldoseform
        /// </summary>
        /// <remarks>
        /// <para>
        /// Combinedpharmaceuticaldoseform 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Combinedpharmaceuticaldoseform
        {
            get => _combinedpharmaceuticaldoseform;
            set
            {
                _combinedpharmaceuticaldoseform = value;
                OnPropertyChanged(nameof(Combinedpharmaceuticaldoseform));
            }
        }        /// <summary>
        /// Route
        /// </summary>
        /// <remarks>
        /// <para>
        /// Route 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Route
        {
            get => _route;
            set
            {
                _route = value;
                OnPropertyChanged(nameof(Route));
            }
        }        /// <summary>
        /// Indication
        /// </summary>
        /// <remarks>
        /// <para>
        /// Indication 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Indication
        {
            get => _indication;
            set
            {
                _indication = value;
                OnPropertyChanged(nameof(Indication));
            }
        }        /// <summary>
        /// Legalstatusofsupply
        /// </summary>
        /// <remarks>
        /// <para>
        /// Legalstatusofsupply 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Legalstatusofsupply
        {
            get => _legalstatusofsupply;
            set
            {
                _legalstatusofsupply = value;
                OnPropertyChanged(nameof(Legalstatusofsupply));
            }
        }        /// <summary>
        /// Additionalmonitoringindicator
        /// </summary>
        /// <remarks>
        /// <para>
        /// Additionalmonitoringindicator 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Additionalmonitoringindicator
        {
            get => _additionalmonitoringindicator;
            set
            {
                _additionalmonitoringindicator = value;
                OnPropertyChanged(nameof(Additionalmonitoringindicator));
            }
        }        /// <summary>
        /// Specialmeasures
        /// </summary>
        /// <remarks>
        /// <para>
        /// Specialmeasures 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Specialmeasures
        {
            get => _specialmeasures;
            set
            {
                _specialmeasures = value;
                OnPropertyChanged(nameof(Specialmeasures));
            }
        }        /// <summary>
        /// Pediatricuseindicator
        /// </summary>
        /// <remarks>
        /// <para>
        /// Pediatricuseindicator 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Pediatricuseindicator
        {
            get => _pediatricuseindicator;
            set
            {
                _pediatricuseindicator = value;
                OnPropertyChanged(nameof(Pediatricuseindicator));
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
        /// Marketingstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Marketingstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MarketingStatus>? Marketingstatus
        {
            get => _marketingstatus;
            set
            {
                _marketingstatus = value;
                OnPropertyChanged(nameof(Marketingstatus));
            }
        }        /// <summary>
        /// Packagedmedicinalproduct
        /// </summary>
        /// <remarks>
        /// <para>
        /// Packagedmedicinalproduct 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Packagedmedicinalproduct
        {
            get => _packagedmedicinalproduct;
            set
            {
                _packagedmedicinalproduct = value;
                OnPropertyChanged(nameof(Packagedmedicinalproduct));
            }
        }        /// <summary>
        /// Comprisedof
        /// </summary>
        /// <remarks>
        /// <para>
        /// Comprisedof 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Comprisedof
        {
            get => _comprisedof;
            set
            {
                _comprisedof = value;
                OnPropertyChanged(nameof(Comprisedof));
            }
        }        /// <summary>
        /// Ingredient
        /// </summary>
        /// <remarks>
        /// <para>
        /// Ingredient 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Ingredient
        {
            get => _ingredient;
            set
            {
                _ingredient = value;
                OnPropertyChanged(nameof(Ingredient));
            }
        }        /// <summary>
        /// Impurity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Impurity 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Impurity
        {
            get => _impurity;
            set
            {
                _impurity = value;
                OnPropertyChanged(nameof(Impurity));
            }
        }        /// <summary>
        /// Attacheddocument
        /// </summary>
        /// <remarks>
        /// <para>
        /// Attacheddocument 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Attacheddocument
        {
            get => _attacheddocument;
            set
            {
                _attacheddocument = value;
                OnPropertyChanged(nameof(Attacheddocument));
            }
        }        /// <summary>
        /// Masterfile
        /// </summary>
        /// <remarks>
        /// <para>
        /// Masterfile 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Masterfile
        {
            get => _masterfile;
            set
            {
                _masterfile = value;
                OnPropertyChanged(nameof(Masterfile));
            }
        }        /// <summary>
        /// Contact
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicinalProductDefinitionContact>? Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }        /// <summary>
        /// Clinicaltrial
        /// </summary>
        /// <remarks>
        /// <para>
        /// Clinicaltrial 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Clinicaltrial
        {
            get => _clinicaltrial;
            set
            {
                _clinicaltrial = value;
                OnPropertyChanged(nameof(Clinicaltrial));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Coding>? Code
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
        public List<MedicinalProductDefinitionName>? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Crossreference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Crossreference 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicinalProductDefinitionCrossReference>? Crossreference
        {
            get => _crossreference;
            set
            {
                _crossreference = value;
                OnPropertyChanged(nameof(Crossreference));
            }
        }        /// <summary>
        /// Operation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Operation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicinalProductDefinitionOperation>? Operation
        {
            get => _operation;
            set
            {
                _operation = value;
                OnPropertyChanged(nameof(Operation));
            }
        }        /// <summary>
        /// Characteristic
        /// </summary>
        /// <remarks>
        /// <para>
        /// Characteristic 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicinalProductDefinitionCharacteristic>? Characteristic
        {
            get => _characteristic;
            set
            {
                _characteristic = value;
                OnPropertyChanged(nameof(Characteristic));
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
        /// Contact
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contact 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }        /// <summary>
        /// Part
        /// </summary>
        /// <remarks>
        /// <para>
        /// Part 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Part
        {
            get => _part;
            set
            {
                _part = value;
                OnPropertyChanged(nameof(Part));
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
        /// Country
        /// </summary>
        /// <remarks>
        /// <para>
        /// Country 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Country
        {
            get => _country;
            set
            {
                _country = value;
                OnPropertyChanged(nameof(Country));
            }
        }        /// <summary>
        /// Jurisdiction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Jurisdiction 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Jurisdiction
        {
            get => _jurisdiction;
            set
            {
                _jurisdiction = value;
                OnPropertyChanged(nameof(Jurisdiction));
            }
        }        /// <summary>
        /// Language
        /// </summary>
        /// <remarks>
        /// <para>
        /// Language 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Language
        {
            get => _language;
            set
            {
                _language = value;
                OnPropertyChanged(nameof(Language));
            }
        }        /// <summary>
        /// Productname
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productname 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Productname
        {
            get => _productname;
            set
            {
                _productname = value;
                OnPropertyChanged(nameof(Productname));
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
        /// Part
        /// </summary>
        /// <remarks>
        /// <para>
        /// Part 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicinalProductDefinitionNamePart>? Part
        {
            get => _part;
            set
            {
                _part = value;
                OnPropertyChanged(nameof(Part));
            }
        }        /// <summary>
        /// Usage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Usage 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicinalProductDefinitionNameUsage>? Usage
        {
            get => _usage;
            set
            {
                _usage = value;
                OnPropertyChanged(nameof(Usage));
            }
        }        /// <summary>
        /// Product
        /// </summary>
        /// <remarks>
        /// <para>
        /// Product 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Product
        {
            get => _product;
            set
            {
                _product = value;
                OnPropertyChanged(nameof(Product));
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
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Effectivedate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Effectivedate 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Effectivedate
        {
            get => _effectivedate;
            set
            {
                _effectivedate = value;
                OnPropertyChanged(nameof(Effectivedate));
            }
        }        /// <summary>
        /// Organization
        /// </summary>
        /// <remarks>
        /// <para>
        /// Organization 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Organization
        {
            get => _organization;
            set
            {
                _organization = value;
                OnPropertyChanged(nameof(Organization));
            }
        }        /// <summary>
        /// Confidentialityindicator
        /// </summary>
        /// <remarks>
        /// <para>
        /// Confidentialityindicator 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Confidentialityindicator
        {
            get => _confidentialityindicator;
            set
            {
                _confidentialityindicator = value;
                OnPropertyChanged(nameof(Confidentialityindicator));
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
        public MedicinalProductDefinitionCharacteristicValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// 建立新的 MedicinalProductDefinition 資源實例
        /// </summary>
        public MedicinalProductDefinition()
        {
        }

        /// <summary>
        /// 建立新的 MedicinalProductDefinition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public MedicinalProductDefinition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"MedicinalProductDefinition(Id: {Id})";
        }
    }    /// <summary>
    /// MedicinalProductDefinitionContact 背骨元素
    /// </summary>
    public class MedicinalProductDefinitionContact
    {
        // TODO: 添加屬性實作
        
        public MedicinalProductDefinitionContact() { }
    }    /// <summary>
    /// MedicinalProductDefinitionNamePart 背骨元素
    /// </summary>
    public class MedicinalProductDefinitionNamePart
    {
        // TODO: 添加屬性實作
        
        public MedicinalProductDefinitionNamePart() { }
    }    /// <summary>
    /// MedicinalProductDefinitionNameUsage 背骨元素
    /// </summary>
    public class MedicinalProductDefinitionNameUsage
    {
        // TODO: 添加屬性實作
        
        public MedicinalProductDefinitionNameUsage() { }
    }    /// <summary>
    /// MedicinalProductDefinitionName 背骨元素
    /// </summary>
    public class MedicinalProductDefinitionName
    {
        // TODO: 添加屬性實作
        
        public MedicinalProductDefinitionName() { }
    }    /// <summary>
    /// MedicinalProductDefinitionCrossReference 背骨元素
    /// </summary>
    public class MedicinalProductDefinitionCrossReference
    {
        // TODO: 添加屬性實作
        
        public MedicinalProductDefinitionCrossReference() { }
    }    /// <summary>
    /// MedicinalProductDefinitionOperation 背骨元素
    /// </summary>
    public class MedicinalProductDefinitionOperation
    {
        // TODO: 添加屬性實作
        
        public MedicinalProductDefinitionOperation() { }
    }    /// <summary>
    /// MedicinalProductDefinitionCharacteristic 背骨元素
    /// </summary>
    public class MedicinalProductDefinitionCharacteristic
    {
        // TODO: 添加屬性實作
        
        public MedicinalProductDefinitionCharacteristic() { }
    }    /// <summary>
    /// MedicinalProductDefinitionCharacteristicValueChoice 選擇類型
    /// </summary>
    public class MedicinalProductDefinitionCharacteristicValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MedicinalProductDefinitionCharacteristicValueChoice(JsonObject value) : base("medicinalproductdefinitioncharacteristicvalue", value, _supportType) { }
        public MedicinalProductDefinitionCharacteristicValueChoice(IComplexType? value) : base("medicinalproductdefinitioncharacteristicvalue", value) { }
        public MedicinalProductDefinitionCharacteristicValueChoice(IPrimitiveType? value) : base("medicinalproductdefinitioncharacteristicvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MedicinalProductDefinitionCharacteristicValue" : "medicinalproductdefinitioncharacteristicvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
