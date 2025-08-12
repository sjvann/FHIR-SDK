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
    /// FHIR R5 ClinicalUseDefinition 資源
    /// 
    /// <para>
    /// ClinicalUseDefinition 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var clinicalusedefinition = new ClinicalUseDefinition("clinicalusedefinition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 ClinicalUseDefinition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ClinicalUseDefinition : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _type;
        private List<CodeableConcept>? _category;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _subject;
        private CodeableConcept? _status;
        private ClinicalUseDefinitionContraindication? _contraindication;
        private ClinicalUseDefinitionIndication? _indication;
        private ClinicalUseDefinitionInteraction? _interaction;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _population;
        private List<FhirCanonical>? _library;
        private ClinicalUseDefinitionUndesirableEffect? _undesirableeffect;
        private ClinicalUseDefinitionWarning? _warning;
        private CodeableConcept? _relationshiptype;
        private CodeableReference? _treatment;
        private CodeableReference? _diseasesymptomprocedure;
        private CodeableReference? _diseasestatus;
        private List<CodeableReference>? _comorbidity;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _indication;
        private ExpressionType? _applicability;
        private List<ClinicalUseDefinitionContraindicationOtherTherapy>? _othertherapy;
        private CodeableReference? _diseasesymptomprocedure;
        private CodeableReference? _diseasestatus;
        private List<CodeableReference>? _comorbidity;
        private CodeableReference? _intendedeffect;
        private ClinicalUseDefinitionIndicationDurationChoice? _duration;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _undesirableeffect;
        private ExpressionType? _applicability;
        private ClinicalUseDefinitionInteractionInteractantItemChoice? _item;
        private List<ClinicalUseDefinitionInteractionInteractant>? _interactant;
        private CodeableConcept? _type;
        private CodeableReference? _effect;
        private CodeableConcept? _incidence;
        private List<CodeableConcept>? _management;
        private CodeableReference? _symptomconditioneffect;
        private CodeableConcept? _classification;
        private CodeableConcept? _frequencyofoccurrence;
        private FhirMarkdown? _description;
        private CodeableConcept? _code;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ClinicalUseDefinition";        /// <summary>
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
        public FhirCode? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
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
        /// Subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
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
        /// Contraindication
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contraindication 的詳細描述。
        /// </para>
        /// </remarks>
        public ClinicalUseDefinitionContraindication? Contraindication
        {
            get => _contraindication;
            set
            {
                _contraindication = value;
                OnPropertyChanged(nameof(Contraindication));
            }
        }        /// <summary>
        /// Indication
        /// </summary>
        /// <remarks>
        /// <para>
        /// Indication 的詳細描述。
        /// </para>
        /// </remarks>
        public ClinicalUseDefinitionIndication? Indication
        {
            get => _indication;
            set
            {
                _indication = value;
                OnPropertyChanged(nameof(Indication));
            }
        }        /// <summary>
        /// Interaction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Interaction 的詳細描述。
        /// </para>
        /// </remarks>
        public ClinicalUseDefinitionInteraction? Interaction
        {
            get => _interaction;
            set
            {
                _interaction = value;
                OnPropertyChanged(nameof(Interaction));
            }
        }        /// <summary>
        /// Population
        /// </summary>
        /// <remarks>
        /// <para>
        /// Population 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Population
        {
            get => _population;
            set
            {
                _population = value;
                OnPropertyChanged(nameof(Population));
            }
        }        /// <summary>
        /// Library
        /// </summary>
        /// <remarks>
        /// <para>
        /// Library 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Library
        {
            get => _library;
            set
            {
                _library = value;
                OnPropertyChanged(nameof(Library));
            }
        }        /// <summary>
        /// Undesirableeffect
        /// </summary>
        /// <remarks>
        /// <para>
        /// Undesirableeffect 的詳細描述。
        /// </para>
        /// </remarks>
        public ClinicalUseDefinitionUndesirableEffect? Undesirableeffect
        {
            get => _undesirableeffect;
            set
            {
                _undesirableeffect = value;
                OnPropertyChanged(nameof(Undesirableeffect));
            }
        }        /// <summary>
        /// Warning
        /// </summary>
        /// <remarks>
        /// <para>
        /// Warning 的詳細描述。
        /// </para>
        /// </remarks>
        public ClinicalUseDefinitionWarning? Warning
        {
            get => _warning;
            set
            {
                _warning = value;
                OnPropertyChanged(nameof(Warning));
            }
        }        /// <summary>
        /// Relationshiptype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relationshiptype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Relationshiptype
        {
            get => _relationshiptype;
            set
            {
                _relationshiptype = value;
                OnPropertyChanged(nameof(Relationshiptype));
            }
        }        /// <summary>
        /// Treatment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Treatment 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Treatment
        {
            get => _treatment;
            set
            {
                _treatment = value;
                OnPropertyChanged(nameof(Treatment));
            }
        }        /// <summary>
        /// Diseasesymptomprocedure
        /// </summary>
        /// <remarks>
        /// <para>
        /// Diseasesymptomprocedure 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Diseasesymptomprocedure
        {
            get => _diseasesymptomprocedure;
            set
            {
                _diseasesymptomprocedure = value;
                OnPropertyChanged(nameof(Diseasesymptomprocedure));
            }
        }        /// <summary>
        /// Diseasestatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Diseasestatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Diseasestatus
        {
            get => _diseasestatus;
            set
            {
                _diseasestatus = value;
                OnPropertyChanged(nameof(Diseasestatus));
            }
        }        /// <summary>
        /// Comorbidity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Comorbidity 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Comorbidity
        {
            get => _comorbidity;
            set
            {
                _comorbidity = value;
                OnPropertyChanged(nameof(Comorbidity));
            }
        }        /// <summary>
        /// Indication
        /// </summary>
        /// <remarks>
        /// <para>
        /// Indication 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Indication
        {
            get => _indication;
            set
            {
                _indication = value;
                OnPropertyChanged(nameof(Indication));
            }
        }        /// <summary>
        /// Applicability
        /// </summary>
        /// <remarks>
        /// <para>
        /// Applicability 的詳細描述。
        /// </para>
        /// </remarks>
        public ExpressionType? Applicability
        {
            get => _applicability;
            set
            {
                _applicability = value;
                OnPropertyChanged(nameof(Applicability));
            }
        }        /// <summary>
        /// Othertherapy
        /// </summary>
        /// <remarks>
        /// <para>
        /// Othertherapy 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ClinicalUseDefinitionContraindicationOtherTherapy>? Othertherapy
        {
            get => _othertherapy;
            set
            {
                _othertherapy = value;
                OnPropertyChanged(nameof(Othertherapy));
            }
        }        /// <summary>
        /// Diseasesymptomprocedure
        /// </summary>
        /// <remarks>
        /// <para>
        /// Diseasesymptomprocedure 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Diseasesymptomprocedure
        {
            get => _diseasesymptomprocedure;
            set
            {
                _diseasesymptomprocedure = value;
                OnPropertyChanged(nameof(Diseasesymptomprocedure));
            }
        }        /// <summary>
        /// Diseasestatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Diseasestatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Diseasestatus
        {
            get => _diseasestatus;
            set
            {
                _diseasestatus = value;
                OnPropertyChanged(nameof(Diseasestatus));
            }
        }        /// <summary>
        /// Comorbidity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Comorbidity 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Comorbidity
        {
            get => _comorbidity;
            set
            {
                _comorbidity = value;
                OnPropertyChanged(nameof(Comorbidity));
            }
        }        /// <summary>
        /// Intendedeffect
        /// </summary>
        /// <remarks>
        /// <para>
        /// Intendedeffect 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Intendedeffect
        {
            get => _intendedeffect;
            set
            {
                _intendedeffect = value;
                OnPropertyChanged(nameof(Intendedeffect));
            }
        }        /// <summary>
        /// Duration
        /// </summary>
        /// <remarks>
        /// <para>
        /// Duration 的詳細描述。
        /// </para>
        /// </remarks>
        public ClinicalUseDefinitionIndicationDurationChoice? Duration
        {
            get => _duration;
            set
            {
                _duration = value;
                OnPropertyChanged(nameof(Duration));
            }
        }        /// <summary>
        /// Undesirableeffect
        /// </summary>
        /// <remarks>
        /// <para>
        /// Undesirableeffect 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Undesirableeffect
        {
            get => _undesirableeffect;
            set
            {
                _undesirableeffect = value;
                OnPropertyChanged(nameof(Undesirableeffect));
            }
        }        /// <summary>
        /// Applicability
        /// </summary>
        /// <remarks>
        /// <para>
        /// Applicability 的詳細描述。
        /// </para>
        /// </remarks>
        public ExpressionType? Applicability
        {
            get => _applicability;
            set
            {
                _applicability = value;
                OnPropertyChanged(nameof(Applicability));
            }
        }        /// <summary>
        /// Item
        /// </summary>
        /// <remarks>
        /// <para>
        /// Item 的詳細描述。
        /// </para>
        /// </remarks>
        public ClinicalUseDefinitionInteractionInteractantItemChoice? Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged(nameof(Item));
            }
        }        /// <summary>
        /// Interactant
        /// </summary>
        /// <remarks>
        /// <para>
        /// Interactant 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ClinicalUseDefinitionInteractionInteractant>? Interactant
        {
            get => _interactant;
            set
            {
                _interactant = value;
                OnPropertyChanged(nameof(Interactant));
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
        /// Effect
        /// </summary>
        /// <remarks>
        /// <para>
        /// Effect 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Effect
        {
            get => _effect;
            set
            {
                _effect = value;
                OnPropertyChanged(nameof(Effect));
            }
        }        /// <summary>
        /// Incidence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Incidence 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Incidence
        {
            get => _incidence;
            set
            {
                _incidence = value;
                OnPropertyChanged(nameof(Incidence));
            }
        }        /// <summary>
        /// Management
        /// </summary>
        /// <remarks>
        /// <para>
        /// Management 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Management
        {
            get => _management;
            set
            {
                _management = value;
                OnPropertyChanged(nameof(Management));
            }
        }        /// <summary>
        /// Symptomconditioneffect
        /// </summary>
        /// <remarks>
        /// <para>
        /// Symptomconditioneffect 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Symptomconditioneffect
        {
            get => _symptomconditioneffect;
            set
            {
                _symptomconditioneffect = value;
                OnPropertyChanged(nameof(Symptomconditioneffect));
            }
        }        /// <summary>
        /// Classification
        /// </summary>
        /// <remarks>
        /// <para>
        /// Classification 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Classification
        {
            get => _classification;
            set
            {
                _classification = value;
                OnPropertyChanged(nameof(Classification));
            }
        }        /// <summary>
        /// Frequencyofoccurrence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Frequencyofoccurrence 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Frequencyofoccurrence
        {
            get => _frequencyofoccurrence;
            set
            {
                _frequencyofoccurrence = value;
                OnPropertyChanged(nameof(Frequencyofoccurrence));
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
        /// 建立新的 ClinicalUseDefinition 資源實例
        /// </summary>
        public ClinicalUseDefinition()
        {
        }

        /// <summary>
        /// 建立新的 ClinicalUseDefinition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ClinicalUseDefinition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ClinicalUseDefinition(Id: {Id})";
        }
    }    /// <summary>
    /// ClinicalUseDefinitionContraindicationOtherTherapy 背骨元素
    /// </summary>
    public class ClinicalUseDefinitionContraindicationOtherTherapy
    {
        // TODO: 添加屬性實作
        
        public ClinicalUseDefinitionContraindicationOtherTherapy() { }
    }    /// <summary>
    /// ClinicalUseDefinitionContraindication 背骨元素
    /// </summary>
    public class ClinicalUseDefinitionContraindication
    {
        // TODO: 添加屬性實作
        
        public ClinicalUseDefinitionContraindication() { }
    }    /// <summary>
    /// ClinicalUseDefinitionIndication 背骨元素
    /// </summary>
    public class ClinicalUseDefinitionIndication
    {
        // TODO: 添加屬性實作
        
        public ClinicalUseDefinitionIndication() { }
    }    /// <summary>
    /// ClinicalUseDefinitionInteractionInteractant 背骨元素
    /// </summary>
    public class ClinicalUseDefinitionInteractionInteractant
    {
        // TODO: 添加屬性實作
        
        public ClinicalUseDefinitionInteractionInteractant() { }
    }    /// <summary>
    /// ClinicalUseDefinitionInteraction 背骨元素
    /// </summary>
    public class ClinicalUseDefinitionInteraction
    {
        // TODO: 添加屬性實作
        
        public ClinicalUseDefinitionInteraction() { }
    }    /// <summary>
    /// ClinicalUseDefinitionUndesirableEffect 背骨元素
    /// </summary>
    public class ClinicalUseDefinitionUndesirableEffect
    {
        // TODO: 添加屬性實作
        
        public ClinicalUseDefinitionUndesirableEffect() { }
    }    /// <summary>
    /// ClinicalUseDefinitionWarning 背骨元素
    /// </summary>
    public class ClinicalUseDefinitionWarning
    {
        // TODO: 添加屬性實作
        
        public ClinicalUseDefinitionWarning() { }
    }    /// <summary>
    /// ClinicalUseDefinitionIndicationDurationChoice 選擇類型
    /// </summary>
    public class ClinicalUseDefinitionIndicationDurationChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ClinicalUseDefinitionIndicationDurationChoice(JsonObject value) : base("clinicalusedefinitionindicationduration", value, _supportType) { }
        public ClinicalUseDefinitionIndicationDurationChoice(IComplexType? value) : base("clinicalusedefinitionindicationduration", value) { }
        public ClinicalUseDefinitionIndicationDurationChoice(IPrimitiveType? value) : base("clinicalusedefinitionindicationduration", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ClinicalUseDefinitionIndicationDuration" : "clinicalusedefinitionindicationduration";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ClinicalUseDefinitionInteractionInteractantItemChoice 選擇類型
    /// </summary>
    public class ClinicalUseDefinitionInteractionInteractantItemChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ClinicalUseDefinitionInteractionInteractantItemChoice(JsonObject value) : base("clinicalusedefinitioninteractioninteractantitem", value, _supportType) { }
        public ClinicalUseDefinitionInteractionInteractantItemChoice(IComplexType? value) : base("clinicalusedefinitioninteractioninteractantitem", value) { }
        public ClinicalUseDefinitionInteractionInteractantItemChoice(IPrimitiveType? value) : base("clinicalusedefinitioninteractioninteractantitem", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ClinicalUseDefinitionInteractionInteractantItem" : "clinicalusedefinitioninteractioninteractantitem";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
