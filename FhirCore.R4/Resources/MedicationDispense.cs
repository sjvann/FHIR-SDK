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
    /// FHIR R4 MedicationDispense 資源
    /// 
    /// <para>
    /// Indicates that a medication product is to be or has been dispensed for a named person/patient.  This includes a description of the medication product (supply) provided and the instructions for administering the medication.  The medication dispense is the result of a pharmacy system responding to a medication order.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var medicationdispense = new MedicationDispense("medicationdispense-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 MedicationDispense 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MedicationDispense : ResourceBase<R4Version>
    {
        private List<ReferenceType>? _authorizingprescription;

        /// <summary>
        /// authorizingPrescription
        /// </summary>
        /// <remarks>
        /// <para>
        /// authorizingPrescription 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? authorizingPrescription
        {
            get => _authorizingprescription;
            set
            {
                _authorizingprescription = value;
                OnPropertyChanged(nameof(authorizingPrescription));
            }
        }

        private CodeableConcept? _category;

        /// <summary>
        /// category
        /// </summary>
        /// <remarks>
        /// <para>
        /// category 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(category));
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

        private ReferenceType? _context;

        /// <summary>
        /// context
        /// </summary>
        /// <remarks>
        /// <para>
        /// context 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? context
        {
            get => _context;
            set
            {
                _context = value;
                OnPropertyChanged(nameof(context));
            }
        }

        private Quantity? _dayssupply;

        /// <summary>
        /// daysSupply
        /// </summary>
        /// <remarks>
        /// <para>
        /// daysSupply 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? daysSupply
        {
            get => _dayssupply;
            set
            {
                _dayssupply = value;
                OnPropertyChanged(nameof(daysSupply));
            }
        }

        private ReferenceType? _destination;

        /// <summary>
        /// destination
        /// </summary>
        /// <remarks>
        /// <para>
        /// destination 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? destination
        {
            get => _destination;
            set
            {
                _destination = value;
                OnPropertyChanged(nameof(destination));
            }
        }

        private List<ReferenceType>? _detectedissue;

        /// <summary>
        /// detectedIssue
        /// </summary>
        /// <remarks>
        /// <para>
        /// detectedIssue 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? detectedIssue
        {
            get => _detectedissue;
            set
            {
                _detectedissue = value;
                OnPropertyChanged(nameof(detectedIssue));
            }
        }

        private List<FhirString>? _dosageinstruction;

        /// <summary>
        /// dosageInstruction
        /// </summary>
        /// <remarks>
        /// <para>
        /// dosageInstruction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? dosageInstruction
        {
            get => _dosageinstruction;
            set
            {
                _dosageinstruction = value;
                OnPropertyChanged(nameof(dosageInstruction));
            }
        }

        private List<ReferenceType>? _eventhistory;

        /// <summary>
        /// eventHistory
        /// </summary>
        /// <remarks>
        /// <para>
        /// eventHistory 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? eventHistory
        {
            get => _eventhistory;
            set
            {
                _eventhistory = value;
                OnPropertyChanged(nameof(eventHistory));
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

        private List<Identifier>? _identifier;

        /// <summary>
        /// identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(identifier));
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

        private ReferenceType? _location;

        /// <summary>
        /// location
        /// </summary>
        /// <remarks>
        /// <para>
        /// location 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(location));
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

        private List<Annotation>? _note;

        /// <summary>
        /// note
        /// </summary>
        /// <remarks>
        /// <para>
        /// note 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Annotation>? note
        {
            get => _note;
            set
            {
                _note = value;
                OnPropertyChanged(nameof(note));
            }
        }

        private List<ReferenceType>? _partof;

        /// <summary>
        /// partOf
        /// </summary>
        /// <remarks>
        /// <para>
        /// partOf 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? partOf
        {
            get => _partof;
            set
            {
                _partof = value;
                OnPropertyChanged(nameof(partOf));
            }
        }

        private List<BackboneElement>? _performer;

        /// <summary>
        /// performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// performer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(performer));
            }
        }

        private Quantity? _quantity;

        /// <summary>
        /// quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(quantity));
            }
        }

        private List<ReferenceType>? _receiver;

        /// <summary>
        /// receiver
        /// </summary>
        /// <remarks>
        /// <para>
        /// receiver 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? receiver
        {
            get => _receiver;
            set
            {
                _receiver = value;
                OnPropertyChanged(nameof(receiver));
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

        private ReferenceType? _subject;

        /// <summary>
        /// subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// subject 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(subject));
            }
        }

        private BackboneElement? _substitution;

        /// <summary>
        /// substitution
        /// </summary>
        /// <remarks>
        /// <para>
        /// substitution 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? substitution
        {
            get => _substitution;
            set
            {
                _substitution = value;
                OnPropertyChanged(nameof(substitution));
            }
        }

        private List<ReferenceType>? _supportinginformation;

        /// <summary>
        /// supportingInformation
        /// </summary>
        /// <remarks>
        /// <para>
        /// supportingInformation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? supportingInformation
        {
            get => _supportinginformation;
            set
            {
                _supportinginformation = value;
                OnPropertyChanged(nameof(supportingInformation));
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

        private CodeableConcept? _type;

        /// <summary>
        /// type
        /// </summary>
        /// <remarks>
        /// <para>
        /// type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(type));
            }
        }

        private FhirDateTime? _whenhandedover;

        /// <summary>
        /// whenHandedOver
        /// </summary>
        /// <remarks>
        /// <para>
        /// whenHandedOver 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? whenHandedOver
        {
            get => _whenhandedover;
            set
            {
                _whenhandedover = value;
                OnPropertyChanged(nameof(whenHandedOver));
            }
        }

        private FhirDateTime? _whenprepared;

        /// <summary>
        /// whenPrepared
        /// </summary>
        /// <remarks>
        /// <para>
        /// whenPrepared 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? whenPrepared
        {
            get => _whenprepared;
            set
            {
                _whenprepared = value;
                OnPropertyChanged(nameof(whenPrepared));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "MedicationDispense";

        /// <summary>
        /// 建立新的 MedicationDispense 資源實例
        /// </summary>
        public MedicationDispense()
        {
        }

        /// <summary>
        /// 建立新的 MedicationDispense 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public MedicationDispense(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"MedicationDispense(Id: {Id})";
        }
    }
}
