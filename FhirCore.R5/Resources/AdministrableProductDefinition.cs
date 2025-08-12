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
    /// FHIR R5 AdministrableProductDefinition 資源
    /// 
    /// <para>
    /// AdministrableProductDefinition 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var administrableproductdefinition = new AdministrableProductDefinition("administrableproductdefinition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 AdministrableProductDefinition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class AdministrableProductDefinition : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _formof;
        private CodeableConcept? _administrabledoseform;
        private CodeableConcept? _unitofpresentation;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _producedfrom;
        private List<CodeableConcept>? _ingredient;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _device;
        private FhirMarkdown? _description;
        private List<AdministrableProductDefinitionProperty>? _property;
        private List<AdministrableProductDefinitionRouteOfAdministration>? _routeofadministration;
        private CodeableConcept? _type;
        private AdministrableProductDefinitionPropertyValueChoice? _value;
        private CodeableConcept? _status;
        private CodeableConcept? _tissue;
        private Quantity? _value;
        private FhirString? _supportinginformation;
        private CodeableConcept? _code;
        private List<AdministrableProductDefinitionRouteOfAdministrationTargetSpeciesWithdrawalPeriod>? _withdrawalperiod;
        private CodeableConcept? _code;
        private Quantity? _firstdose;
        private Quantity? _maxsingledose;
        private Quantity? _maxdoseperday;
        private Ratio? _maxdosepertreatmentperiod;
        private Duration? _maxtreatmentperiod;
        private List<AdministrableProductDefinitionRouteOfAdministrationTargetSpecies>? _targetspecies;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "AdministrableProductDefinition";        /// <summary>
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
        /// Formof
        /// </summary>
        /// <remarks>
        /// <para>
        /// Formof 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Formof
        {
            get => _formof;
            set
            {
                _formof = value;
                OnPropertyChanged(nameof(Formof));
            }
        }        /// <summary>
        /// Administrabledoseform
        /// </summary>
        /// <remarks>
        /// <para>
        /// Administrabledoseform 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Administrabledoseform
        {
            get => _administrabledoseform;
            set
            {
                _administrabledoseform = value;
                OnPropertyChanged(nameof(Administrabledoseform));
            }
        }        /// <summary>
        /// Unitofpresentation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Unitofpresentation 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Unitofpresentation
        {
            get => _unitofpresentation;
            set
            {
                _unitofpresentation = value;
                OnPropertyChanged(nameof(Unitofpresentation));
            }
        }        /// <summary>
        /// Producedfrom
        /// </summary>
        /// <remarks>
        /// <para>
        /// Producedfrom 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Producedfrom
        {
            get => _producedfrom;
            set
            {
                _producedfrom = value;
                OnPropertyChanged(nameof(Producedfrom));
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
        /// Property
        /// </summary>
        /// <remarks>
        /// <para>
        /// Property 的詳細描述。
        /// </para>
        /// </remarks>
        public List<AdministrableProductDefinitionProperty>? Property
        {
            get => _property;
            set
            {
                _property = value;
                OnPropertyChanged(nameof(Property));
            }
        }        /// <summary>
        /// Routeofadministration
        /// </summary>
        /// <remarks>
        /// <para>
        /// Routeofadministration 的詳細描述。
        /// </para>
        /// </remarks>
        public List<AdministrableProductDefinitionRouteOfAdministration>? Routeofadministration
        {
            get => _routeofadministration;
            set
            {
                _routeofadministration = value;
                OnPropertyChanged(nameof(Routeofadministration));
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
        public AdministrableProductDefinitionPropertyValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
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
        /// Tissue
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tissue 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Tissue
        {
            get => _tissue;
            set
            {
                _tissue = value;
                OnPropertyChanged(nameof(Tissue));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Supportinginformation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supportinginformation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Supportinginformation
        {
            get => _supportinginformation;
            set
            {
                _supportinginformation = value;
                OnPropertyChanged(nameof(Supportinginformation));
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
        /// Withdrawalperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Withdrawalperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public List<AdministrableProductDefinitionRouteOfAdministrationTargetSpeciesWithdrawalPeriod>? Withdrawalperiod
        {
            get => _withdrawalperiod;
            set
            {
                _withdrawalperiod = value;
                OnPropertyChanged(nameof(Withdrawalperiod));
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
        /// Firstdose
        /// </summary>
        /// <remarks>
        /// <para>
        /// Firstdose 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Firstdose
        {
            get => _firstdose;
            set
            {
                _firstdose = value;
                OnPropertyChanged(nameof(Firstdose));
            }
        }        /// <summary>
        /// Maxsingledose
        /// </summary>
        /// <remarks>
        /// <para>
        /// Maxsingledose 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Maxsingledose
        {
            get => _maxsingledose;
            set
            {
                _maxsingledose = value;
                OnPropertyChanged(nameof(Maxsingledose));
            }
        }        /// <summary>
        /// Maxdoseperday
        /// </summary>
        /// <remarks>
        /// <para>
        /// Maxdoseperday 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Maxdoseperday
        {
            get => _maxdoseperday;
            set
            {
                _maxdoseperday = value;
                OnPropertyChanged(nameof(Maxdoseperday));
            }
        }        /// <summary>
        /// Maxdosepertreatmentperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Maxdosepertreatmentperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public Ratio? Maxdosepertreatmentperiod
        {
            get => _maxdosepertreatmentperiod;
            set
            {
                _maxdosepertreatmentperiod = value;
                OnPropertyChanged(nameof(Maxdosepertreatmentperiod));
            }
        }        /// <summary>
        /// Maxtreatmentperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Maxtreatmentperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public Duration? Maxtreatmentperiod
        {
            get => _maxtreatmentperiod;
            set
            {
                _maxtreatmentperiod = value;
                OnPropertyChanged(nameof(Maxtreatmentperiod));
            }
        }        /// <summary>
        /// Targetspecies
        /// </summary>
        /// <remarks>
        /// <para>
        /// Targetspecies 的詳細描述。
        /// </para>
        /// </remarks>
        public List<AdministrableProductDefinitionRouteOfAdministrationTargetSpecies>? Targetspecies
        {
            get => _targetspecies;
            set
            {
                _targetspecies = value;
                OnPropertyChanged(nameof(Targetspecies));
            }
        }        /// <summary>
        /// 建立新的 AdministrableProductDefinition 資源實例
        /// </summary>
        public AdministrableProductDefinition()
        {
        }

        /// <summary>
        /// 建立新的 AdministrableProductDefinition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public AdministrableProductDefinition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"AdministrableProductDefinition(Id: {Id})";
        }
    }    /// <summary>
    /// AdministrableProductDefinitionProperty 背骨元素
    /// </summary>
    public class AdministrableProductDefinitionProperty
    {
        // TODO: 添加屬性實作
        
        public AdministrableProductDefinitionProperty() { }
    }    /// <summary>
    /// AdministrableProductDefinitionRouteOfAdministrationTargetSpeciesWithdrawalPeriod 背骨元素
    /// </summary>
    public class AdministrableProductDefinitionRouteOfAdministrationTargetSpeciesWithdrawalPeriod
    {
        // TODO: 添加屬性實作
        
        public AdministrableProductDefinitionRouteOfAdministrationTargetSpeciesWithdrawalPeriod() { }
    }    /// <summary>
    /// AdministrableProductDefinitionRouteOfAdministrationTargetSpecies 背骨元素
    /// </summary>
    public class AdministrableProductDefinitionRouteOfAdministrationTargetSpecies
    {
        // TODO: 添加屬性實作
        
        public AdministrableProductDefinitionRouteOfAdministrationTargetSpecies() { }
    }    /// <summary>
    /// AdministrableProductDefinitionRouteOfAdministration 背骨元素
    /// </summary>
    public class AdministrableProductDefinitionRouteOfAdministration
    {
        // TODO: 添加屬性實作
        
        public AdministrableProductDefinitionRouteOfAdministration() { }
    }    /// <summary>
    /// AdministrableProductDefinitionPropertyValueChoice 選擇類型
    /// </summary>
    public class AdministrableProductDefinitionPropertyValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public AdministrableProductDefinitionPropertyValueChoice(JsonObject value) : base("administrableproductdefinitionpropertyvalue", value, _supportType) { }
        public AdministrableProductDefinitionPropertyValueChoice(IComplexType? value) : base("administrableproductdefinitionpropertyvalue", value) { }
        public AdministrableProductDefinitionPropertyValueChoice(IPrimitiveType? value) : base("administrableproductdefinitionpropertyvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "AdministrableProductDefinitionPropertyValue" : "administrableproductdefinitionpropertyvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
