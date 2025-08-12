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
    /// FHIR R5 MedicationKnowledge 資源
    /// 
    /// <para>
    /// MedicationKnowledge 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var medicationknowledge = new MedicationKnowledge("medicationknowledge-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 MedicationKnowledge 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MedicationKnowledge : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private CodeableConcept? _code;
        private FhirCode? _status;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _author;
        private List<CodeableConcept>? _intendedjurisdiction;
        private List<FhirString>? _name;
        private List<MedicationKnowledgeRelatedMedicationKnowledge>? _relatedmedicationknowledge;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _associatedmedication;
        private List<CodeableConcept>? _producttype;
        private List<MedicationKnowledgeMonograph>? _monograph;
        private FhirMarkdown? _preparationinstruction;
        private List<MedicationKnowledgeCost>? _cost;
        private List<MedicationKnowledgeMonitoringProgram>? _monitoringprogram;
        private List<MedicationKnowledgeIndicationGuideline>? _indicationguideline;
        private List<MedicationKnowledgeMedicineClassification>? _medicineclassification;
        private List<MedicationKnowledgePackaging>? _packaging;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _clinicaluseissue;
        private List<MedicationKnowledgeStorageGuideline>? _storageguideline;
        private List<MedicationKnowledgeRegulatory>? _regulatory;
        private MedicationKnowledgeDefinitional? _definitional;
        private CodeableConcept? _type;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _reference;
        private CodeableConcept? _type;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _source;
        private List<Period>? _effectivedate;
        private CodeableConcept? _type;
        private FhirString? _source;
        private MedicationKnowledgeCostCostChoice? _cost;
        private CodeableConcept? _type;
        private FhirString? _name;
        private CodeableConcept? _type;
        private List<Dosage>? _dosage;
        private CodeableConcept? _type;
        private MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristicValueChoice? _value;
        private CodeableConcept? _treatmentintent;
        private List<MedicationKnowledgeIndicationGuidelineDosingGuidelineDosage>? _dosage;
        private CodeableConcept? _administrationtreatment;
        private List<MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristic>? _patientcharacteristic;
        private List<CodeableReference>? _indication;
        private List<MedicationKnowledgeIndicationGuidelineDosingGuideline>? _dosingguideline;
        private CodeableConcept? _type;
        private MedicationKnowledgeMedicineClassificationSourceChoice? _source;
        private List<CodeableConcept>? _classification;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _packagedproduct;
        private CodeableConcept? _type;
        private MedicationKnowledgeStorageGuidelineEnvironmentalSettingValueChoice? _value;
        private FhirUri? _reference;
        private List<Annotation>? _note;
        private Duration? _stabilityduration;
        private List<MedicationKnowledgeStorageGuidelineEnvironmentalSetting>? _environmentalsetting;
        private CodeableConcept? _type;
        private FhirBoolean? _allowed;
        private Quantity? _quantity;
        private Duration? _period;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _regulatoryauthority;
        private List<MedicationKnowledgeRegulatorySubstitution>? _substitution;
        private List<CodeableConcept>? _schedule;
        private MedicationKnowledgeRegulatoryMaxDispense? _maxdispense;
        private CodeableReference? _item;
        private CodeableConcept? _type;
        private MedicationKnowledgeDefinitionalIngredientStrengthChoice? _strength;
        private CodeableConcept? _type;
        private MedicationKnowledgeDefinitionalDrugCharacteristicValueChoice? _value;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _definition;
        private CodeableConcept? _doseform;
        private List<CodeableConcept>? _intendedroute;
        private List<MedicationKnowledgeDefinitionalIngredient>? _ingredient;
        private List<MedicationKnowledgeDefinitionalDrugCharacteristic>? _drugcharacteristic;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "MedicationKnowledge";        /// <summary>
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
        public FhirCode? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }        /// <summary>
        /// Author
        /// </summary>
        /// <remarks>
        /// <para>
        /// Author 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Author
        {
            get => _author;
            set
            {
                _author = value;
                OnPropertyChanged(nameof(Author));
            }
        }        /// <summary>
        /// Intendedjurisdiction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Intendedjurisdiction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Intendedjurisdiction
        {
            get => _intendedjurisdiction;
            set
            {
                _intendedjurisdiction = value;
                OnPropertyChanged(nameof(Intendedjurisdiction));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Relatedmedicationknowledge
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relatedmedicationknowledge 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicationKnowledgeRelatedMedicationKnowledge>? Relatedmedicationknowledge
        {
            get => _relatedmedicationknowledge;
            set
            {
                _relatedmedicationknowledge = value;
                OnPropertyChanged(nameof(Relatedmedicationknowledge));
            }
        }        /// <summary>
        /// Associatedmedication
        /// </summary>
        /// <remarks>
        /// <para>
        /// Associatedmedication 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Associatedmedication
        {
            get => _associatedmedication;
            set
            {
                _associatedmedication = value;
                OnPropertyChanged(nameof(Associatedmedication));
            }
        }        /// <summary>
        /// Producttype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Producttype 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Producttype
        {
            get => _producttype;
            set
            {
                _producttype = value;
                OnPropertyChanged(nameof(Producttype));
            }
        }        /// <summary>
        /// Monograph
        /// </summary>
        /// <remarks>
        /// <para>
        /// Monograph 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicationKnowledgeMonograph>? Monograph
        {
            get => _monograph;
            set
            {
                _monograph = value;
                OnPropertyChanged(nameof(Monograph));
            }
        }        /// <summary>
        /// Preparationinstruction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Preparationinstruction 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Preparationinstruction
        {
            get => _preparationinstruction;
            set
            {
                _preparationinstruction = value;
                OnPropertyChanged(nameof(Preparationinstruction));
            }
        }        /// <summary>
        /// Cost
        /// </summary>
        /// <remarks>
        /// <para>
        /// Cost 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicationKnowledgeCost>? Cost
        {
            get => _cost;
            set
            {
                _cost = value;
                OnPropertyChanged(nameof(Cost));
            }
        }        /// <summary>
        /// Monitoringprogram
        /// </summary>
        /// <remarks>
        /// <para>
        /// Monitoringprogram 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicationKnowledgeMonitoringProgram>? Monitoringprogram
        {
            get => _monitoringprogram;
            set
            {
                _monitoringprogram = value;
                OnPropertyChanged(nameof(Monitoringprogram));
            }
        }        /// <summary>
        /// Indicationguideline
        /// </summary>
        /// <remarks>
        /// <para>
        /// Indicationguideline 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicationKnowledgeIndicationGuideline>? Indicationguideline
        {
            get => _indicationguideline;
            set
            {
                _indicationguideline = value;
                OnPropertyChanged(nameof(Indicationguideline));
            }
        }        /// <summary>
        /// Medicineclassification
        /// </summary>
        /// <remarks>
        /// <para>
        /// Medicineclassification 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicationKnowledgeMedicineClassification>? Medicineclassification
        {
            get => _medicineclassification;
            set
            {
                _medicineclassification = value;
                OnPropertyChanged(nameof(Medicineclassification));
            }
        }        /// <summary>
        /// Packaging
        /// </summary>
        /// <remarks>
        /// <para>
        /// Packaging 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicationKnowledgePackaging>? Packaging
        {
            get => _packaging;
            set
            {
                _packaging = value;
                OnPropertyChanged(nameof(Packaging));
            }
        }        /// <summary>
        /// Clinicaluseissue
        /// </summary>
        /// <remarks>
        /// <para>
        /// Clinicaluseissue 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Clinicaluseissue
        {
            get => _clinicaluseissue;
            set
            {
                _clinicaluseissue = value;
                OnPropertyChanged(nameof(Clinicaluseissue));
            }
        }        /// <summary>
        /// Storageguideline
        /// </summary>
        /// <remarks>
        /// <para>
        /// Storageguideline 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicationKnowledgeStorageGuideline>? Storageguideline
        {
            get => _storageguideline;
            set
            {
                _storageguideline = value;
                OnPropertyChanged(nameof(Storageguideline));
            }
        }        /// <summary>
        /// Regulatory
        /// </summary>
        /// <remarks>
        /// <para>
        /// Regulatory 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicationKnowledgeRegulatory>? Regulatory
        {
            get => _regulatory;
            set
            {
                _regulatory = value;
                OnPropertyChanged(nameof(Regulatory));
            }
        }        /// <summary>
        /// Definitional
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definitional 的詳細描述。
        /// </para>
        /// </remarks>
        public MedicationKnowledgeDefinitional? Definitional
        {
            get => _definitional;
            set
            {
                _definitional = value;
                OnPropertyChanged(nameof(Definitional));
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
        /// Reference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reference 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Reference
        {
            get => _reference;
            set
            {
                _reference = value;
                OnPropertyChanged(nameof(Reference));
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
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
            }
        }        /// <summary>
        /// Effectivedate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Effectivedate 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Period>? Effectivedate
        {
            get => _effectivedate;
            set
            {
                _effectivedate = value;
                OnPropertyChanged(nameof(Effectivedate));
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
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
            }
        }        /// <summary>
        /// Cost
        /// </summary>
        /// <remarks>
        /// <para>
        /// Cost 的詳細描述。
        /// </para>
        /// </remarks>
        public MedicationKnowledgeCostCostChoice? Cost
        {
            get => _cost;
            set
            {
                _cost = value;
                OnPropertyChanged(nameof(Cost));
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
        /// Dosage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dosage 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Dosage>? Dosage
        {
            get => _dosage;
            set
            {
                _dosage = value;
                OnPropertyChanged(nameof(Dosage));
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
        public MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristicValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Treatmentintent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Treatmentintent 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Treatmentintent
        {
            get => _treatmentintent;
            set
            {
                _treatmentintent = value;
                OnPropertyChanged(nameof(Treatmentintent));
            }
        }        /// <summary>
        /// Dosage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dosage 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicationKnowledgeIndicationGuidelineDosingGuidelineDosage>? Dosage
        {
            get => _dosage;
            set
            {
                _dosage = value;
                OnPropertyChanged(nameof(Dosage));
            }
        }        /// <summary>
        /// Administrationtreatment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Administrationtreatment 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Administrationtreatment
        {
            get => _administrationtreatment;
            set
            {
                _administrationtreatment = value;
                OnPropertyChanged(nameof(Administrationtreatment));
            }
        }        /// <summary>
        /// Patientcharacteristic
        /// </summary>
        /// <remarks>
        /// <para>
        /// Patientcharacteristic 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristic>? Patientcharacteristic
        {
            get => _patientcharacteristic;
            set
            {
                _patientcharacteristic = value;
                OnPropertyChanged(nameof(Patientcharacteristic));
            }
        }        /// <summary>
        /// Indication
        /// </summary>
        /// <remarks>
        /// <para>
        /// Indication 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Indication
        {
            get => _indication;
            set
            {
                _indication = value;
                OnPropertyChanged(nameof(Indication));
            }
        }        /// <summary>
        /// Dosingguideline
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dosingguideline 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicationKnowledgeIndicationGuidelineDosingGuideline>? Dosingguideline
        {
            get => _dosingguideline;
            set
            {
                _dosingguideline = value;
                OnPropertyChanged(nameof(Dosingguideline));
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
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public MedicationKnowledgeMedicineClassificationSourceChoice? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
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
        /// Packagedproduct
        /// </summary>
        /// <remarks>
        /// <para>
        /// Packagedproduct 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Packagedproduct
        {
            get => _packagedproduct;
            set
            {
                _packagedproduct = value;
                OnPropertyChanged(nameof(Packagedproduct));
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
        public MedicationKnowledgeStorageGuidelineEnvironmentalSettingValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Reference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reference 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Reference
        {
            get => _reference;
            set
            {
                _reference = value;
                OnPropertyChanged(nameof(Reference));
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
        /// Stabilityduration
        /// </summary>
        /// <remarks>
        /// <para>
        /// Stabilityduration 的詳細描述。
        /// </para>
        /// </remarks>
        public Duration? Stabilityduration
        {
            get => _stabilityduration;
            set
            {
                _stabilityduration = value;
                OnPropertyChanged(nameof(Stabilityduration));
            }
        }        /// <summary>
        /// Environmentalsetting
        /// </summary>
        /// <remarks>
        /// <para>
        /// Environmentalsetting 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicationKnowledgeStorageGuidelineEnvironmentalSetting>? Environmentalsetting
        {
            get => _environmentalsetting;
            set
            {
                _environmentalsetting = value;
                OnPropertyChanged(nameof(Environmentalsetting));
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
        /// Allowed
        /// </summary>
        /// <remarks>
        /// <para>
        /// Allowed 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Allowed
        {
            get => _allowed;
            set
            {
                _allowed = value;
                OnPropertyChanged(nameof(Allowed));
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
        /// Period
        /// </summary>
        /// <remarks>
        /// <para>
        /// Period 的詳細描述。
        /// </para>
        /// </remarks>
        public Duration? Period
        {
            get => _period;
            set
            {
                _period = value;
                OnPropertyChanged(nameof(Period));
            }
        }        /// <summary>
        /// Regulatoryauthority
        /// </summary>
        /// <remarks>
        /// <para>
        /// Regulatoryauthority 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Regulatoryauthority
        {
            get => _regulatoryauthority;
            set
            {
                _regulatoryauthority = value;
                OnPropertyChanged(nameof(Regulatoryauthority));
            }
        }        /// <summary>
        /// Substitution
        /// </summary>
        /// <remarks>
        /// <para>
        /// Substitution 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicationKnowledgeRegulatorySubstitution>? Substitution
        {
            get => _substitution;
            set
            {
                _substitution = value;
                OnPropertyChanged(nameof(Substitution));
            }
        }        /// <summary>
        /// Schedule
        /// </summary>
        /// <remarks>
        /// <para>
        /// Schedule 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Schedule
        {
            get => _schedule;
            set
            {
                _schedule = value;
                OnPropertyChanged(nameof(Schedule));
            }
        }        /// <summary>
        /// Maxdispense
        /// </summary>
        /// <remarks>
        /// <para>
        /// Maxdispense 的詳細描述。
        /// </para>
        /// </remarks>
        public MedicationKnowledgeRegulatoryMaxDispense? Maxdispense
        {
            get => _maxdispense;
            set
            {
                _maxdispense = value;
                OnPropertyChanged(nameof(Maxdispense));
            }
        }        /// <summary>
        /// Item
        /// </summary>
        /// <remarks>
        /// <para>
        /// Item 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged(nameof(Item));
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
        /// Strength
        /// </summary>
        /// <remarks>
        /// <para>
        /// Strength 的詳細描述。
        /// </para>
        /// </remarks>
        public MedicationKnowledgeDefinitionalIngredientStrengthChoice? Strength
        {
            get => _strength;
            set
            {
                _strength = value;
                OnPropertyChanged(nameof(Strength));
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
        public MedicationKnowledgeDefinitionalDrugCharacteristicValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Definition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definition 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Definition
        {
            get => _definition;
            set
            {
                _definition = value;
                OnPropertyChanged(nameof(Definition));
            }
        }        /// <summary>
        /// Doseform
        /// </summary>
        /// <remarks>
        /// <para>
        /// Doseform 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Doseform
        {
            get => _doseform;
            set
            {
                _doseform = value;
                OnPropertyChanged(nameof(Doseform));
            }
        }        /// <summary>
        /// Intendedroute
        /// </summary>
        /// <remarks>
        /// <para>
        /// Intendedroute 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Intendedroute
        {
            get => _intendedroute;
            set
            {
                _intendedroute = value;
                OnPropertyChanged(nameof(Intendedroute));
            }
        }        /// <summary>
        /// Ingredient
        /// </summary>
        /// <remarks>
        /// <para>
        /// Ingredient 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicationKnowledgeDefinitionalIngredient>? Ingredient
        {
            get => _ingredient;
            set
            {
                _ingredient = value;
                OnPropertyChanged(nameof(Ingredient));
            }
        }        /// <summary>
        /// Drugcharacteristic
        /// </summary>
        /// <remarks>
        /// <para>
        /// Drugcharacteristic 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicationKnowledgeDefinitionalDrugCharacteristic>? Drugcharacteristic
        {
            get => _drugcharacteristic;
            set
            {
                _drugcharacteristic = value;
                OnPropertyChanged(nameof(Drugcharacteristic));
            }
        }        /// <summary>
        /// 建立新的 MedicationKnowledge 資源實例
        /// </summary>
        public MedicationKnowledge()
        {
        }

        /// <summary>
        /// 建立新的 MedicationKnowledge 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public MedicationKnowledge(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"MedicationKnowledge(Id: {Id})";
        }
    }    /// <summary>
    /// MedicationKnowledgeRelatedMedicationKnowledge 背骨元素
    /// </summary>
    public class MedicationKnowledgeRelatedMedicationKnowledge
    {
        // TODO: 添加屬性實作
        
        public MedicationKnowledgeRelatedMedicationKnowledge() { }
    }    /// <summary>
    /// MedicationKnowledgeMonograph 背骨元素
    /// </summary>
    public class MedicationKnowledgeMonograph
    {
        // TODO: 添加屬性實作
        
        public MedicationKnowledgeMonograph() { }
    }    /// <summary>
    /// MedicationKnowledgeCost 背骨元素
    /// </summary>
    public class MedicationKnowledgeCost
    {
        // TODO: 添加屬性實作
        
        public MedicationKnowledgeCost() { }
    }    /// <summary>
    /// MedicationKnowledgeMonitoringProgram 背骨元素
    /// </summary>
    public class MedicationKnowledgeMonitoringProgram
    {
        // TODO: 添加屬性實作
        
        public MedicationKnowledgeMonitoringProgram() { }
    }    /// <summary>
    /// MedicationKnowledgeIndicationGuidelineDosingGuidelineDosage 背骨元素
    /// </summary>
    public class MedicationKnowledgeIndicationGuidelineDosingGuidelineDosage
    {
        // TODO: 添加屬性實作
        
        public MedicationKnowledgeIndicationGuidelineDosingGuidelineDosage() { }
    }    /// <summary>
    /// MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristic 背骨元素
    /// </summary>
    public class MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristic
    {
        // TODO: 添加屬性實作
        
        public MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristic() { }
    }    /// <summary>
    /// MedicationKnowledgeIndicationGuidelineDosingGuideline 背骨元素
    /// </summary>
    public class MedicationKnowledgeIndicationGuidelineDosingGuideline
    {
        // TODO: 添加屬性實作
        
        public MedicationKnowledgeIndicationGuidelineDosingGuideline() { }
    }    /// <summary>
    /// MedicationKnowledgeIndicationGuideline 背骨元素
    /// </summary>
    public class MedicationKnowledgeIndicationGuideline
    {
        // TODO: 添加屬性實作
        
        public MedicationKnowledgeIndicationGuideline() { }
    }    /// <summary>
    /// MedicationKnowledgeMedicineClassification 背骨元素
    /// </summary>
    public class MedicationKnowledgeMedicineClassification
    {
        // TODO: 添加屬性實作
        
        public MedicationKnowledgeMedicineClassification() { }
    }    /// <summary>
    /// MedicationKnowledgePackaging 背骨元素
    /// </summary>
    public class MedicationKnowledgePackaging
    {
        // TODO: 添加屬性實作
        
        public MedicationKnowledgePackaging() { }
    }    /// <summary>
    /// MedicationKnowledgeStorageGuidelineEnvironmentalSetting 背骨元素
    /// </summary>
    public class MedicationKnowledgeStorageGuidelineEnvironmentalSetting
    {
        // TODO: 添加屬性實作
        
        public MedicationKnowledgeStorageGuidelineEnvironmentalSetting() { }
    }    /// <summary>
    /// MedicationKnowledgeStorageGuideline 背骨元素
    /// </summary>
    public class MedicationKnowledgeStorageGuideline
    {
        // TODO: 添加屬性實作
        
        public MedicationKnowledgeStorageGuideline() { }
    }    /// <summary>
    /// MedicationKnowledgeRegulatorySubstitution 背骨元素
    /// </summary>
    public class MedicationKnowledgeRegulatorySubstitution
    {
        // TODO: 添加屬性實作
        
        public MedicationKnowledgeRegulatorySubstitution() { }
    }    /// <summary>
    /// MedicationKnowledgeRegulatoryMaxDispense 背骨元素
    /// </summary>
    public class MedicationKnowledgeRegulatoryMaxDispense
    {
        // TODO: 添加屬性實作
        
        public MedicationKnowledgeRegulatoryMaxDispense() { }
    }    /// <summary>
    /// MedicationKnowledgeRegulatory 背骨元素
    /// </summary>
    public class MedicationKnowledgeRegulatory
    {
        // TODO: 添加屬性實作
        
        public MedicationKnowledgeRegulatory() { }
    }    /// <summary>
    /// MedicationKnowledgeDefinitionalIngredient 背骨元素
    /// </summary>
    public class MedicationKnowledgeDefinitionalIngredient
    {
        // TODO: 添加屬性實作
        
        public MedicationKnowledgeDefinitionalIngredient() { }
    }    /// <summary>
    /// MedicationKnowledgeDefinitionalDrugCharacteristic 背骨元素
    /// </summary>
    public class MedicationKnowledgeDefinitionalDrugCharacteristic
    {
        // TODO: 添加屬性實作
        
        public MedicationKnowledgeDefinitionalDrugCharacteristic() { }
    }    /// <summary>
    /// MedicationKnowledgeDefinitional 背骨元素
    /// </summary>
    public class MedicationKnowledgeDefinitional
    {
        // TODO: 添加屬性實作
        
        public MedicationKnowledgeDefinitional() { }
    }    /// <summary>
    /// MedicationKnowledgeCostCostChoice 選擇類型
    /// </summary>
    public class MedicationKnowledgeCostCostChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MedicationKnowledgeCostCostChoice(JsonObject value) : base("medicationknowledgecostcost", value, _supportType) { }
        public MedicationKnowledgeCostCostChoice(IComplexType? value) : base("medicationknowledgecostcost", value) { }
        public MedicationKnowledgeCostCostChoice(IPrimitiveType? value) : base("medicationknowledgecostcost", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MedicationKnowledgeCostCost" : "medicationknowledgecostcost";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristicValueChoice 選擇類型
    /// </summary>
    public class MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristicValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristicValueChoice(JsonObject value) : base("medicationknowledgeindicationguidelinedosingguidelinepatientcharacteristicvalue", value, _supportType) { }
        public MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristicValueChoice(IComplexType? value) : base("medicationknowledgeindicationguidelinedosingguidelinepatientcharacteristicvalue", value) { }
        public MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristicValueChoice(IPrimitiveType? value) : base("medicationknowledgeindicationguidelinedosingguidelinepatientcharacteristicvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristicValue" : "medicationknowledgeindicationguidelinedosingguidelinepatientcharacteristicvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// MedicationKnowledgeMedicineClassificationSourceChoice 選擇類型
    /// </summary>
    public class MedicationKnowledgeMedicineClassificationSourceChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MedicationKnowledgeMedicineClassificationSourceChoice(JsonObject value) : base("medicationknowledgemedicineclassificationsource", value, _supportType) { }
        public MedicationKnowledgeMedicineClassificationSourceChoice(IComplexType? value) : base("medicationknowledgemedicineclassificationsource", value) { }
        public MedicationKnowledgeMedicineClassificationSourceChoice(IPrimitiveType? value) : base("medicationknowledgemedicineclassificationsource", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MedicationKnowledgeMedicineClassificationSource" : "medicationknowledgemedicineclassificationsource";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// MedicationKnowledgeStorageGuidelineEnvironmentalSettingValueChoice 選擇類型
    /// </summary>
    public class MedicationKnowledgeStorageGuidelineEnvironmentalSettingValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MedicationKnowledgeStorageGuidelineEnvironmentalSettingValueChoice(JsonObject value) : base("medicationknowledgestorageguidelineenvironmentalsettingvalue", value, _supportType) { }
        public MedicationKnowledgeStorageGuidelineEnvironmentalSettingValueChoice(IComplexType? value) : base("medicationknowledgestorageguidelineenvironmentalsettingvalue", value) { }
        public MedicationKnowledgeStorageGuidelineEnvironmentalSettingValueChoice(IPrimitiveType? value) : base("medicationknowledgestorageguidelineenvironmentalsettingvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MedicationKnowledgeStorageGuidelineEnvironmentalSettingValue" : "medicationknowledgestorageguidelineenvironmentalsettingvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// MedicationKnowledgeDefinitionalIngredientStrengthChoice 選擇類型
    /// </summary>
    public class MedicationKnowledgeDefinitionalIngredientStrengthChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MedicationKnowledgeDefinitionalIngredientStrengthChoice(JsonObject value) : base("medicationknowledgedefinitionalingredientstrength", value, _supportType) { }
        public MedicationKnowledgeDefinitionalIngredientStrengthChoice(IComplexType? value) : base("medicationknowledgedefinitionalingredientstrength", value) { }
        public MedicationKnowledgeDefinitionalIngredientStrengthChoice(IPrimitiveType? value) : base("medicationknowledgedefinitionalingredientstrength", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MedicationKnowledgeDefinitionalIngredientStrength" : "medicationknowledgedefinitionalingredientstrength";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// MedicationKnowledgeDefinitionalDrugCharacteristicValueChoice 選擇類型
    /// </summary>
    public class MedicationKnowledgeDefinitionalDrugCharacteristicValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MedicationKnowledgeDefinitionalDrugCharacteristicValueChoice(JsonObject value) : base("medicationknowledgedefinitionaldrugcharacteristicvalue", value, _supportType) { }
        public MedicationKnowledgeDefinitionalDrugCharacteristicValueChoice(IComplexType? value) : base("medicationknowledgedefinitionaldrugcharacteristicvalue", value) { }
        public MedicationKnowledgeDefinitionalDrugCharacteristicValueChoice(IPrimitiveType? value) : base("medicationknowledgedefinitionaldrugcharacteristicvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MedicationKnowledgeDefinitionalDrugCharacteristicValue" : "medicationknowledgedefinitionaldrugcharacteristicvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
