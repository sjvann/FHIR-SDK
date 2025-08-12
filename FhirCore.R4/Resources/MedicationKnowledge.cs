using FhirCore.Base;
using FhirCore.R4;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using FhirCore.Interfaces;

namespace FhirCore.R4.Resources
{
    /// <summary>
    /// FHIR R4 MedicationKnowledge 資源
    /// 
    /// <para>
    /// Information about a medication that is used to support knowledge.
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
    /// R4 版本的 MedicationKnowledge 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MedicationKnowledge : ResourceBase<R4Version>
    {
        private List<BackboneElement>? _administrationguidelines;

        /// <summary>
        /// administrationGuidelines
        /// </summary>
        /// <remarks>
        /// <para>
        /// administrationGuidelines 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? administrationGuidelines
        {
            get => _administrationguidelines;
            set
            {
                _administrationguidelines = value;
                OnPropertyChanged(nameof(administrationGuidelines));
            }
        }

        private Quantity? _amount;

        /// <summary>
        /// amount
        /// </summary>
        /// <remarks>
        /// <para>
        /// amount 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(amount));
            }
        }

        private List<ReferenceType>? _associatedmedication;

        /// <summary>
        /// associatedMedication
        /// </summary>
        /// <remarks>
        /// <para>
        /// associatedMedication 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? associatedMedication
        {
            get => _associatedmedication;
            set
            {
                _associatedmedication = value;
                OnPropertyChanged(nameof(associatedMedication));
            }
        }

        private CodeableConcept? _code;

        /// <summary>
        /// code
        /// </summary>
        /// <remarks>
        /// <para>
        /// code 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(code));
            }
        }

        private List<FhirString>? _contained;

        /// <summary>
        /// contained
        /// </summary>
        /// <remarks>
        /// <para>
        /// contained 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? contained
        {
            get => _contained;
            set
            {
                _contained = value;
                OnPropertyChanged(nameof(contained));
            }
        }

        private List<ReferenceType>? _contraindication;

        /// <summary>
        /// contraindication
        /// </summary>
        /// <remarks>
        /// <para>
        /// contraindication 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? contraindication
        {
            get => _contraindication;
            set
            {
                _contraindication = value;
                OnPropertyChanged(nameof(contraindication));
            }
        }

        private List<BackboneElement>? _cost;

        /// <summary>
        /// cost
        /// </summary>
        /// <remarks>
        /// <para>
        /// cost 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? cost
        {
            get => _cost;
            set
            {
                _cost = value;
                OnPropertyChanged(nameof(cost));
            }
        }

        private CodeableConcept? _doseform;

        /// <summary>
        /// doseForm
        /// </summary>
        /// <remarks>
        /// <para>
        /// doseForm 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? doseForm
        {
            get => _doseform;
            set
            {
                _doseform = value;
                OnPropertyChanged(nameof(doseForm));
            }
        }

        private List<BackboneElement>? _drugcharacteristic;

        /// <summary>
        /// drugCharacteristic
        /// </summary>
        /// <remarks>
        /// <para>
        /// drugCharacteristic 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? drugCharacteristic
        {
            get => _drugcharacteristic;
            set
            {
                _drugcharacteristic = value;
                OnPropertyChanged(nameof(drugCharacteristic));
            }
        }

        private List<Extension>? _extension;

        /// <summary>
        /// extension
        /// </summary>
        /// <remarks>
        /// <para>
        /// extension 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Extension>? extension
        {
            get => _extension;
            set
            {
                _extension = value;
                OnPropertyChanged(nameof(extension));
            }
        }

        private FhirString? _id;

        /// <summary>
        /// id
        /// </summary>
        /// <remarks>
        /// <para>
        /// id 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(id));
            }
        }

        private FhirUri? _implicitrules;

        /// <summary>
        /// implicitRules
        /// </summary>
        /// <remarks>
        /// <para>
        /// implicitRules 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? implicitRules
        {
            get => _implicitrules;
            set
            {
                _implicitrules = value;
                OnPropertyChanged(nameof(implicitRules));
            }
        }

        private List<BackboneElement>? _ingredient;

        /// <summary>
        /// ingredient
        /// </summary>
        /// <remarks>
        /// <para>
        /// ingredient 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? ingredient
        {
            get => _ingredient;
            set
            {
                _ingredient = value;
                OnPropertyChanged(nameof(ingredient));
            }
        }

        private List<CodeableConcept>? _intendedroute;

        /// <summary>
        /// intendedRoute
        /// </summary>
        /// <remarks>
        /// <para>
        /// intendedRoute 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? intendedRoute
        {
            get => _intendedroute;
            set
            {
                _intendedroute = value;
                OnPropertyChanged(nameof(intendedRoute));
            }
        }

        private List<BackboneElement>? _kinetics;

        /// <summary>
        /// kinetics
        /// </summary>
        /// <remarks>
        /// <para>
        /// kinetics 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? kinetics
        {
            get => _kinetics;
            set
            {
                _kinetics = value;
                OnPropertyChanged(nameof(kinetics));
            }
        }

        private FhirCode? _language;

        /// <summary>
        /// language
        /// </summary>
        /// <remarks>
        /// <para>
        /// language 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? language
        {
            get => _language;
            set
            {
                _language = value;
                OnPropertyChanged(nameof(language));
            }
        }

        private ReferenceType? _manufacturer;

        /// <summary>
        /// manufacturer
        /// </summary>
        /// <remarks>
        /// <para>
        /// manufacturer 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? manufacturer
        {
            get => _manufacturer;
            set
            {
                _manufacturer = value;
                OnPropertyChanged(nameof(manufacturer));
            }
        }

        private List<BackboneElement>? _medicineclassification;

        /// <summary>
        /// medicineClassification
        /// </summary>
        /// <remarks>
        /// <para>
        /// medicineClassification 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? medicineClassification
        {
            get => _medicineclassification;
            set
            {
                _medicineclassification = value;
                OnPropertyChanged(nameof(medicineClassification));
            }
        }

        private Meta? _meta;

        /// <summary>
        /// meta
        /// </summary>
        /// <remarks>
        /// <para>
        /// meta 的詳細描述。
        /// </para>
        /// </remarks>
        public Meta? meta
        {
            get => _meta;
            set
            {
                _meta = value;
                OnPropertyChanged(nameof(meta));
            }
        }

        private List<Extension>? _modifierextension;

        /// <summary>
        /// modifierExtension
        /// </summary>
        /// <remarks>
        /// <para>
        /// modifierExtension 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Extension>? modifierExtension
        {
            get => _modifierextension;
            set
            {
                _modifierextension = value;
                OnPropertyChanged(nameof(modifierExtension));
            }
        }

        private List<BackboneElement>? _monitoringprogram;

        /// <summary>
        /// monitoringProgram
        /// </summary>
        /// <remarks>
        /// <para>
        /// monitoringProgram 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? monitoringProgram
        {
            get => _monitoringprogram;
            set
            {
                _monitoringprogram = value;
                OnPropertyChanged(nameof(monitoringProgram));
            }
        }

        private List<BackboneElement>? _monograph;

        /// <summary>
        /// monograph
        /// </summary>
        /// <remarks>
        /// <para>
        /// monograph 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? monograph
        {
            get => _monograph;
            set
            {
                _monograph = value;
                OnPropertyChanged(nameof(monograph));
            }
        }

        private BackboneElement? _packaging;

        /// <summary>
        /// packaging
        /// </summary>
        /// <remarks>
        /// <para>
        /// packaging 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? packaging
        {
            get => _packaging;
            set
            {
                _packaging = value;
                OnPropertyChanged(nameof(packaging));
            }
        }

        private FhirMarkdown? _preparationinstruction;

        /// <summary>
        /// preparationInstruction
        /// </summary>
        /// <remarks>
        /// <para>
        /// preparationInstruction 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? preparationInstruction
        {
            get => _preparationinstruction;
            set
            {
                _preparationinstruction = value;
                OnPropertyChanged(nameof(preparationInstruction));
            }
        }

        private List<CodeableConcept>? _producttype;

        /// <summary>
        /// productType
        /// </summary>
        /// <remarks>
        /// <para>
        /// productType 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? productType
        {
            get => _producttype;
            set
            {
                _producttype = value;
                OnPropertyChanged(nameof(productType));
            }
        }

        private List<BackboneElement>? _regulatory;

        /// <summary>
        /// regulatory
        /// </summary>
        /// <remarks>
        /// <para>
        /// regulatory 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? regulatory
        {
            get => _regulatory;
            set
            {
                _regulatory = value;
                OnPropertyChanged(nameof(regulatory));
            }
        }

        private List<BackboneElement>? _relatedmedicationknowledge;

        /// <summary>
        /// relatedMedicationKnowledge
        /// </summary>
        /// <remarks>
        /// <para>
        /// relatedMedicationKnowledge 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? relatedMedicationKnowledge
        {
            get => _relatedmedicationknowledge;
            set
            {
                _relatedmedicationknowledge = value;
                OnPropertyChanged(nameof(relatedMedicationKnowledge));
            }
        }

        private FhirCode? _status;

        /// <summary>
        /// status
        /// </summary>
        /// <remarks>
        /// <para>
        /// status 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(status));
            }
        }

        private List<FhirString>? _synonym;

        /// <summary>
        /// synonym
        /// </summary>
        /// <remarks>
        /// <para>
        /// synonym 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? synonym
        {
            get => _synonym;
            set
            {
                _synonym = value;
                OnPropertyChanged(nameof(synonym));
            }
        }

        private FhirString? _text;

        /// <summary>
        /// text
        /// </summary>
        /// <remarks>
        /// <para>
        /// text 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? text
        {
            get => _text;
            set
            {
                _text = value;
                OnPropertyChanged(nameof(text));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "MedicationKnowledge";

        /// <summary>
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
    }
}
