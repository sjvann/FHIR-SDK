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
    /// FHIR R5 NutritionOrder 資源
    /// 
    /// <para>
    /// NutritionOrder 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var nutritionorder = new NutritionOrder("nutritionorder-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 NutritionOrder 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class NutritionOrder : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<FhirCanonical>? _instantiatescanonical;
        private List<FhirUri>? _instantiatesuri;
        private List<FhirUri>? _instantiates;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private Identifier? _groupidentifier;
        private FhirCode? _status;
        private FhirCode? _intent;
        private FhirCode? _priority;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _supportinginformation;
        private FhirDateTime? _datetime;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _orderer;
        private List<CodeableReference>? _performer;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _allergyintolerance;
        private List<CodeableConcept>? _foodpreferencemodifier;
        private List<CodeableConcept>? _excludefoodmodifier;
        private FhirBoolean? _outsidefoodallowed;
        private NutritionOrderOralDiet? _oraldiet;
        private List<NutritionOrderSupplement>? _supplement;
        private NutritionOrderEnteralFormula? _enteralformula;
        private List<Annotation>? _note;
        private List<Timing>? _timing;
        private FhirBoolean? _asneeded;
        private CodeableConcept? _asneededfor;
        private CodeableConcept? _modifier;
        private Quantity? _amount;
        private CodeableConcept? _modifier;
        private CodeableConcept? _foodtype;
        private List<CodeableConcept>? _type;
        private NutritionOrderOralDietSchedule? _schedule;
        private List<NutritionOrderOralDietNutrient>? _nutrient;
        private List<NutritionOrderOralDietTexture>? _texture;
        private List<CodeableConcept>? _fluidconsistencytype;
        private FhirString? _instruction;
        private List<Timing>? _timing;
        private FhirBoolean? _asneeded;
        private CodeableConcept? _asneededfor;
        private CodeableReference? _type;
        private FhirString? _productname;
        private NutritionOrderSupplementSchedule? _schedule;
        private Quantity? _quantity;
        private FhirString? _instruction;
        private CodeableReference? _type;
        private FhirString? _productname;
        private Quantity? _quantity;
        private List<Timing>? _timing;
        private FhirBoolean? _asneeded;
        private CodeableConcept? _asneededfor;
        private NutritionOrderEnteralFormulaAdministrationSchedule? _schedule;
        private Quantity? _quantity;
        private NutritionOrderEnteralFormulaAdministrationRateChoice? _rate;
        private CodeableReference? _baseformulatype;
        private FhirString? _baseformulaproductname;
        private List<CodeableReference>? _deliverydevice;
        private List<NutritionOrderEnteralFormulaAdditive>? _additive;
        private Quantity? _caloricdensity;
        private CodeableConcept? _routeofadministration;
        private List<NutritionOrderEnteralFormulaAdministration>? _administration;
        private Quantity? _maxvolumetodeliver;
        private FhirMarkdown? _administrationinstruction;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "NutritionOrder";        /// <summary>
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
        /// Instantiatescanonical
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instantiatescanonical 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Instantiatescanonical
        {
            get => _instantiatescanonical;
            set
            {
                _instantiatescanonical = value;
                OnPropertyChanged(nameof(Instantiatescanonical));
            }
        }        /// <summary>
        /// Instantiatesuri
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instantiatesuri 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUri>? Instantiatesuri
        {
            get => _instantiatesuri;
            set
            {
                _instantiatesuri = value;
                OnPropertyChanged(nameof(Instantiatesuri));
            }
        }        /// <summary>
        /// Instantiates
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instantiates 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUri>? Instantiates
        {
            get => _instantiates;
            set
            {
                _instantiates = value;
                OnPropertyChanged(nameof(Instantiates));
            }
        }        /// <summary>
        /// Basedon
        /// </summary>
        /// <remarks>
        /// <para>
        /// Basedon 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Basedon
        {
            get => _basedon;
            set
            {
                _basedon = value;
                OnPropertyChanged(nameof(Basedon));
            }
        }        /// <summary>
        /// Groupidentifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Groupidentifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? Groupidentifier
        {
            get => _groupidentifier;
            set
            {
                _groupidentifier = value;
                OnPropertyChanged(nameof(Groupidentifier));
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
        /// Intent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Intent 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Intent
        {
            get => _intent;
            set
            {
                _intent = value;
                OnPropertyChanged(nameof(Intent));
            }
        }        /// <summary>
        /// Priority
        /// </summary>
        /// <remarks>
        /// <para>
        /// Priority 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(Priority));
            }
        }        /// <summary>
        /// Subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }        /// <summary>
        /// Encounter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Encounter 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Encounter
        {
            get => _encounter;
            set
            {
                _encounter = value;
                OnPropertyChanged(nameof(Encounter));
            }
        }        /// <summary>
        /// Supportinginformation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supportinginformation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Supportinginformation
        {
            get => _supportinginformation;
            set
            {
                _supportinginformation = value;
                OnPropertyChanged(nameof(Supportinginformation));
            }
        }        /// <summary>
        /// Datetime
        /// </summary>
        /// <remarks>
        /// <para>
        /// Datetime 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Datetime
        {
            get => _datetime;
            set
            {
                _datetime = value;
                OnPropertyChanged(nameof(Datetime));
            }
        }        /// <summary>
        /// Orderer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Orderer 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Orderer
        {
            get => _orderer;
            set
            {
                _orderer = value;
                OnPropertyChanged(nameof(Orderer));
            }
        }        /// <summary>
        /// Performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(Performer));
            }
        }        /// <summary>
        /// Allergyintolerance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Allergyintolerance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Allergyintolerance
        {
            get => _allergyintolerance;
            set
            {
                _allergyintolerance = value;
                OnPropertyChanged(nameof(Allergyintolerance));
            }
        }        /// <summary>
        /// Foodpreferencemodifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Foodpreferencemodifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Foodpreferencemodifier
        {
            get => _foodpreferencemodifier;
            set
            {
                _foodpreferencemodifier = value;
                OnPropertyChanged(nameof(Foodpreferencemodifier));
            }
        }        /// <summary>
        /// Excludefoodmodifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Excludefoodmodifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Excludefoodmodifier
        {
            get => _excludefoodmodifier;
            set
            {
                _excludefoodmodifier = value;
                OnPropertyChanged(nameof(Excludefoodmodifier));
            }
        }        /// <summary>
        /// Outsidefoodallowed
        /// </summary>
        /// <remarks>
        /// <para>
        /// Outsidefoodallowed 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Outsidefoodallowed
        {
            get => _outsidefoodallowed;
            set
            {
                _outsidefoodallowed = value;
                OnPropertyChanged(nameof(Outsidefoodallowed));
            }
        }        /// <summary>
        /// Oraldiet
        /// </summary>
        /// <remarks>
        /// <para>
        /// Oraldiet 的詳細描述。
        /// </para>
        /// </remarks>
        public NutritionOrderOralDiet? Oraldiet
        {
            get => _oraldiet;
            set
            {
                _oraldiet = value;
                OnPropertyChanged(nameof(Oraldiet));
            }
        }        /// <summary>
        /// Supplement
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supplement 的詳細描述。
        /// </para>
        /// </remarks>
        public List<NutritionOrderSupplement>? Supplement
        {
            get => _supplement;
            set
            {
                _supplement = value;
                OnPropertyChanged(nameof(Supplement));
            }
        }        /// <summary>
        /// Enteralformula
        /// </summary>
        /// <remarks>
        /// <para>
        /// Enteralformula 的詳細描述。
        /// </para>
        /// </remarks>
        public NutritionOrderEnteralFormula? Enteralformula
        {
            get => _enteralformula;
            set
            {
                _enteralformula = value;
                OnPropertyChanged(nameof(Enteralformula));
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
        /// Timing
        /// </summary>
        /// <remarks>
        /// <para>
        /// Timing 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Timing>? Timing
        {
            get => _timing;
            set
            {
                _timing = value;
                OnPropertyChanged(nameof(Timing));
            }
        }        /// <summary>
        /// Asneeded
        /// </summary>
        /// <remarks>
        /// <para>
        /// Asneeded 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Asneeded
        {
            get => _asneeded;
            set
            {
                _asneeded = value;
                OnPropertyChanged(nameof(Asneeded));
            }
        }        /// <summary>
        /// Asneededfor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Asneededfor 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Asneededfor
        {
            get => _asneededfor;
            set
            {
                _asneededfor = value;
                OnPropertyChanged(nameof(Asneededfor));
            }
        }        /// <summary>
        /// Modifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Modifier 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Modifier
        {
            get => _modifier;
            set
            {
                _modifier = value;
                OnPropertyChanged(nameof(Modifier));
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
        /// Modifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Modifier 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Modifier
        {
            get => _modifier;
            set
            {
                _modifier = value;
                OnPropertyChanged(nameof(Modifier));
            }
        }        /// <summary>
        /// Foodtype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Foodtype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Foodtype
        {
            get => _foodtype;
            set
            {
                _foodtype = value;
                OnPropertyChanged(nameof(Foodtype));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Schedule
        /// </summary>
        /// <remarks>
        /// <para>
        /// Schedule 的詳細描述。
        /// </para>
        /// </remarks>
        public NutritionOrderOralDietSchedule? Schedule
        {
            get => _schedule;
            set
            {
                _schedule = value;
                OnPropertyChanged(nameof(Schedule));
            }
        }        /// <summary>
        /// Nutrient
        /// </summary>
        /// <remarks>
        /// <para>
        /// Nutrient 的詳細描述。
        /// </para>
        /// </remarks>
        public List<NutritionOrderOralDietNutrient>? Nutrient
        {
            get => _nutrient;
            set
            {
                _nutrient = value;
                OnPropertyChanged(nameof(Nutrient));
            }
        }        /// <summary>
        /// Texture
        /// </summary>
        /// <remarks>
        /// <para>
        /// Texture 的詳細描述。
        /// </para>
        /// </remarks>
        public List<NutritionOrderOralDietTexture>? Texture
        {
            get => _texture;
            set
            {
                _texture = value;
                OnPropertyChanged(nameof(Texture));
            }
        }        /// <summary>
        /// Fluidconsistencytype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Fluidconsistencytype 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Fluidconsistencytype
        {
            get => _fluidconsistencytype;
            set
            {
                _fluidconsistencytype = value;
                OnPropertyChanged(nameof(Fluidconsistencytype));
            }
        }        /// <summary>
        /// Instruction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instruction 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Instruction
        {
            get => _instruction;
            set
            {
                _instruction = value;
                OnPropertyChanged(nameof(Instruction));
            }
        }        /// <summary>
        /// Timing
        /// </summary>
        /// <remarks>
        /// <para>
        /// Timing 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Timing>? Timing
        {
            get => _timing;
            set
            {
                _timing = value;
                OnPropertyChanged(nameof(Timing));
            }
        }        /// <summary>
        /// Asneeded
        /// </summary>
        /// <remarks>
        /// <para>
        /// Asneeded 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Asneeded
        {
            get => _asneeded;
            set
            {
                _asneeded = value;
                OnPropertyChanged(nameof(Asneeded));
            }
        }        /// <summary>
        /// Asneededfor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Asneededfor 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Asneededfor
        {
            get => _asneededfor;
            set
            {
                _asneededfor = value;
                OnPropertyChanged(nameof(Asneededfor));
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
        /// Schedule
        /// </summary>
        /// <remarks>
        /// <para>
        /// Schedule 的詳細描述。
        /// </para>
        /// </remarks>
        public NutritionOrderSupplementSchedule? Schedule
        {
            get => _schedule;
            set
            {
                _schedule = value;
                OnPropertyChanged(nameof(Schedule));
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
        /// Instruction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instruction 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Instruction
        {
            get => _instruction;
            set
            {
                _instruction = value;
                OnPropertyChanged(nameof(Instruction));
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
        /// Timing
        /// </summary>
        /// <remarks>
        /// <para>
        /// Timing 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Timing>? Timing
        {
            get => _timing;
            set
            {
                _timing = value;
                OnPropertyChanged(nameof(Timing));
            }
        }        /// <summary>
        /// Asneeded
        /// </summary>
        /// <remarks>
        /// <para>
        /// Asneeded 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Asneeded
        {
            get => _asneeded;
            set
            {
                _asneeded = value;
                OnPropertyChanged(nameof(Asneeded));
            }
        }        /// <summary>
        /// Asneededfor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Asneededfor 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Asneededfor
        {
            get => _asneededfor;
            set
            {
                _asneededfor = value;
                OnPropertyChanged(nameof(Asneededfor));
            }
        }        /// <summary>
        /// Schedule
        /// </summary>
        /// <remarks>
        /// <para>
        /// Schedule 的詳細描述。
        /// </para>
        /// </remarks>
        public NutritionOrderEnteralFormulaAdministrationSchedule? Schedule
        {
            get => _schedule;
            set
            {
                _schedule = value;
                OnPropertyChanged(nameof(Schedule));
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
        /// Rate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Rate 的詳細描述。
        /// </para>
        /// </remarks>
        public NutritionOrderEnteralFormulaAdministrationRateChoice? Rate
        {
            get => _rate;
            set
            {
                _rate = value;
                OnPropertyChanged(nameof(Rate));
            }
        }        /// <summary>
        /// Baseformulatype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Baseformulatype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Baseformulatype
        {
            get => _baseformulatype;
            set
            {
                _baseformulatype = value;
                OnPropertyChanged(nameof(Baseformulatype));
            }
        }        /// <summary>
        /// Baseformulaproductname
        /// </summary>
        /// <remarks>
        /// <para>
        /// Baseformulaproductname 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Baseformulaproductname
        {
            get => _baseformulaproductname;
            set
            {
                _baseformulaproductname = value;
                OnPropertyChanged(nameof(Baseformulaproductname));
            }
        }        /// <summary>
        /// Deliverydevice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Deliverydevice 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Deliverydevice
        {
            get => _deliverydevice;
            set
            {
                _deliverydevice = value;
                OnPropertyChanged(nameof(Deliverydevice));
            }
        }        /// <summary>
        /// Additive
        /// </summary>
        /// <remarks>
        /// <para>
        /// Additive 的詳細描述。
        /// </para>
        /// </remarks>
        public List<NutritionOrderEnteralFormulaAdditive>? Additive
        {
            get => _additive;
            set
            {
                _additive = value;
                OnPropertyChanged(nameof(Additive));
            }
        }        /// <summary>
        /// Caloricdensity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Caloricdensity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Caloricdensity
        {
            get => _caloricdensity;
            set
            {
                _caloricdensity = value;
                OnPropertyChanged(nameof(Caloricdensity));
            }
        }        /// <summary>
        /// Routeofadministration
        /// </summary>
        /// <remarks>
        /// <para>
        /// Routeofadministration 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Routeofadministration
        {
            get => _routeofadministration;
            set
            {
                _routeofadministration = value;
                OnPropertyChanged(nameof(Routeofadministration));
            }
        }        /// <summary>
        /// Administration
        /// </summary>
        /// <remarks>
        /// <para>
        /// Administration 的詳細描述。
        /// </para>
        /// </remarks>
        public List<NutritionOrderEnteralFormulaAdministration>? Administration
        {
            get => _administration;
            set
            {
                _administration = value;
                OnPropertyChanged(nameof(Administration));
            }
        }        /// <summary>
        /// Maxvolumetodeliver
        /// </summary>
        /// <remarks>
        /// <para>
        /// Maxvolumetodeliver 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Maxvolumetodeliver
        {
            get => _maxvolumetodeliver;
            set
            {
                _maxvolumetodeliver = value;
                OnPropertyChanged(nameof(Maxvolumetodeliver));
            }
        }        /// <summary>
        /// Administrationinstruction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Administrationinstruction 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Administrationinstruction
        {
            get => _administrationinstruction;
            set
            {
                _administrationinstruction = value;
                OnPropertyChanged(nameof(Administrationinstruction));
            }
        }        /// <summary>
        /// 建立新的 NutritionOrder 資源實例
        /// </summary>
        public NutritionOrder()
        {
        }

        /// <summary>
        /// 建立新的 NutritionOrder 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public NutritionOrder(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"NutritionOrder(Id: {Id})";
        }
    }    /// <summary>
    /// NutritionOrderOralDietSchedule 背骨元素
    /// </summary>
    public class NutritionOrderOralDietSchedule
    {
        // TODO: 添加屬性實作
        
        public NutritionOrderOralDietSchedule() { }
    }    /// <summary>
    /// NutritionOrderOralDietNutrient 背骨元素
    /// </summary>
    public class NutritionOrderOralDietNutrient
    {
        // TODO: 添加屬性實作
        
        public NutritionOrderOralDietNutrient() { }
    }    /// <summary>
    /// NutritionOrderOralDietTexture 背骨元素
    /// </summary>
    public class NutritionOrderOralDietTexture
    {
        // TODO: 添加屬性實作
        
        public NutritionOrderOralDietTexture() { }
    }    /// <summary>
    /// NutritionOrderOralDiet 背骨元素
    /// </summary>
    public class NutritionOrderOralDiet
    {
        // TODO: 添加屬性實作
        
        public NutritionOrderOralDiet() { }
    }    /// <summary>
    /// NutritionOrderSupplementSchedule 背骨元素
    /// </summary>
    public class NutritionOrderSupplementSchedule
    {
        // TODO: 添加屬性實作
        
        public NutritionOrderSupplementSchedule() { }
    }    /// <summary>
    /// NutritionOrderSupplement 背骨元素
    /// </summary>
    public class NutritionOrderSupplement
    {
        // TODO: 添加屬性實作
        
        public NutritionOrderSupplement() { }
    }    /// <summary>
    /// NutritionOrderEnteralFormulaAdditive 背骨元素
    /// </summary>
    public class NutritionOrderEnteralFormulaAdditive
    {
        // TODO: 添加屬性實作
        
        public NutritionOrderEnteralFormulaAdditive() { }
    }    /// <summary>
    /// NutritionOrderEnteralFormulaAdministrationSchedule 背骨元素
    /// </summary>
    public class NutritionOrderEnteralFormulaAdministrationSchedule
    {
        // TODO: 添加屬性實作
        
        public NutritionOrderEnteralFormulaAdministrationSchedule() { }
    }    /// <summary>
    /// NutritionOrderEnteralFormulaAdministration 背骨元素
    /// </summary>
    public class NutritionOrderEnteralFormulaAdministration
    {
        // TODO: 添加屬性實作
        
        public NutritionOrderEnteralFormulaAdministration() { }
    }    /// <summary>
    /// NutritionOrderEnteralFormula 背骨元素
    /// </summary>
    public class NutritionOrderEnteralFormula
    {
        // TODO: 添加屬性實作
        
        public NutritionOrderEnteralFormula() { }
    }    /// <summary>
    /// NutritionOrderEnteralFormulaAdministrationRateChoice 選擇類型
    /// </summary>
    public class NutritionOrderEnteralFormulaAdministrationRateChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public NutritionOrderEnteralFormulaAdministrationRateChoice(JsonObject value) : base("nutritionorderenteralformulaadministrationrate", value, _supportType) { }
        public NutritionOrderEnteralFormulaAdministrationRateChoice(IComplexType? value) : base("nutritionorderenteralformulaadministrationrate", value) { }
        public NutritionOrderEnteralFormulaAdministrationRateChoice(IPrimitiveType? value) : base("nutritionorderenteralformulaadministrationrate", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "NutritionOrderEnteralFormulaAdministrationRate" : "nutritionorderenteralformulaadministrationrate";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
