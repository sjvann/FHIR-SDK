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
    /// FHIR R4 Immunization 資源
    /// 
    /// <para>
    /// Describes the event of a patient being administered a vaccine or a record of an immunization as reported by a patient, a clinician or another party.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var immunization = new Immunization("immunization-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 Immunization 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Immunization : ResourceBase<R4Version>
    {
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

        private Quantity? _dosequantity;

        /// <summary>
        /// doseQuantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// doseQuantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? doseQuantity
        {
            get => _dosequantity;
            set
            {
                _dosequantity = value;
                OnPropertyChanged(nameof(doseQuantity));
            }
        }

        private List<BackboneElement>? _education;

        /// <summary>
        /// education
        /// </summary>
        /// <remarks>
        /// <para>
        /// education 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? education
        {
            get => _education;
            set
            {
                _education = value;
                OnPropertyChanged(nameof(education));
            }
        }

        private ReferenceType? _encounter;

        /// <summary>
        /// encounter
        /// </summary>
        /// <remarks>
        /// <para>
        /// encounter 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? encounter
        {
            get => _encounter;
            set
            {
                _encounter = value;
                OnPropertyChanged(nameof(encounter));
            }
        }

        private FhirDate? _expirationdate;

        /// <summary>
        /// expirationDate
        /// </summary>
        /// <remarks>
        /// <para>
        /// expirationDate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? expirationDate
        {
            get => _expirationdate;
            set
            {
                _expirationdate = value;
                OnPropertyChanged(nameof(expirationDate));
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

        private CodeableConcept? _fundingsource;

        /// <summary>
        /// fundingSource
        /// </summary>
        /// <remarks>
        /// <para>
        /// fundingSource 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? fundingSource
        {
            get => _fundingsource;
            set
            {
                _fundingsource = value;
                OnPropertyChanged(nameof(fundingSource));
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

        private FhirBoolean? _issubpotent;

        /// <summary>
        /// isSubpotent
        /// </summary>
        /// <remarks>
        /// <para>
        /// isSubpotent 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? isSubpotent
        {
            get => _issubpotent;
            set
            {
                _issubpotent = value;
                OnPropertyChanged(nameof(isSubpotent));
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

        private FhirString? _lotnumber;

        /// <summary>
        /// lotNumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// lotNumber 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? lotNumber
        {
            get => _lotnumber;
            set
            {
                _lotnumber = value;
                OnPropertyChanged(nameof(lotNumber));
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

        private ReferenceType? _patient;

        /// <summary>
        /// patient
        /// </summary>
        /// <remarks>
        /// <para>
        /// patient 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? patient
        {
            get => _patient;
            set
            {
                _patient = value;
                OnPropertyChanged(nameof(patient));
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

        private FhirBoolean? _primarysource;

        /// <summary>
        /// primarySource
        /// </summary>
        /// <remarks>
        /// <para>
        /// primarySource 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? primarySource
        {
            get => _primarysource;
            set
            {
                _primarysource = value;
                OnPropertyChanged(nameof(primarySource));
            }
        }

        private List<CodeableConcept>? _programeligibility;

        /// <summary>
        /// programEligibility
        /// </summary>
        /// <remarks>
        /// <para>
        /// programEligibility 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? programEligibility
        {
            get => _programeligibility;
            set
            {
                _programeligibility = value;
                OnPropertyChanged(nameof(programEligibility));
            }
        }

        private List<BackboneElement>? _protocolapplied;

        /// <summary>
        /// protocolApplied
        /// </summary>
        /// <remarks>
        /// <para>
        /// protocolApplied 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? protocolApplied
        {
            get => _protocolapplied;
            set
            {
                _protocolapplied = value;
                OnPropertyChanged(nameof(protocolApplied));
            }
        }

        private List<BackboneElement>? _reaction;

        /// <summary>
        /// reaction
        /// </summary>
        /// <remarks>
        /// <para>
        /// reaction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? reaction
        {
            get => _reaction;
            set
            {
                _reaction = value;
                OnPropertyChanged(nameof(reaction));
            }
        }

        private List<CodeableConcept>? _reasoncode;

        /// <summary>
        /// reasonCode
        /// </summary>
        /// <remarks>
        /// <para>
        /// reasonCode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? reasonCode
        {
            get => _reasoncode;
            set
            {
                _reasoncode = value;
                OnPropertyChanged(nameof(reasonCode));
            }
        }

        private List<ReferenceType>? _reasonreference;

        /// <summary>
        /// reasonReference
        /// </summary>
        /// <remarks>
        /// <para>
        /// reasonReference 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? reasonReference
        {
            get => _reasonreference;
            set
            {
                _reasonreference = value;
                OnPropertyChanged(nameof(reasonReference));
            }
        }

        private FhirDateTime? _recorded;

        /// <summary>
        /// recorded
        /// </summary>
        /// <remarks>
        /// <para>
        /// recorded 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? recorded
        {
            get => _recorded;
            set
            {
                _recorded = value;
                OnPropertyChanged(nameof(recorded));
            }
        }

        private CodeableConcept? _reportorigin;

        /// <summary>
        /// reportOrigin
        /// </summary>
        /// <remarks>
        /// <para>
        /// reportOrigin 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? reportOrigin
        {
            get => _reportorigin;
            set
            {
                _reportorigin = value;
                OnPropertyChanged(nameof(reportOrigin));
            }
        }

        private CodeableConcept? _route;

        /// <summary>
        /// route
        /// </summary>
        /// <remarks>
        /// <para>
        /// route 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? route
        {
            get => _route;
            set
            {
                _route = value;
                OnPropertyChanged(nameof(route));
            }
        }

        private CodeableConcept? _site;

        /// <summary>
        /// site
        /// </summary>
        /// <remarks>
        /// <para>
        /// site 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? site
        {
            get => _site;
            set
            {
                _site = value;
                OnPropertyChanged(nameof(site));
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

        private CodeableConcept? _statusreason;

        /// <summary>
        /// statusReason
        /// </summary>
        /// <remarks>
        /// <para>
        /// statusReason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? statusReason
        {
            get => _statusreason;
            set
            {
                _statusreason = value;
                OnPropertyChanged(nameof(statusReason));
            }
        }

        private List<CodeableConcept>? _subpotentreason;

        /// <summary>
        /// subpotentReason
        /// </summary>
        /// <remarks>
        /// <para>
        /// subpotentReason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? subpotentReason
        {
            get => _subpotentreason;
            set
            {
                _subpotentreason = value;
                OnPropertyChanged(nameof(subpotentReason));
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

        private CodeableConcept? _vaccinecode;

        /// <summary>
        /// vaccineCode
        /// </summary>
        /// <remarks>
        /// <para>
        /// vaccineCode 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? vaccineCode
        {
            get => _vaccinecode;
            set
            {
                _vaccinecode = value;
                OnPropertyChanged(nameof(vaccineCode));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Immunization";

        /// <summary>
        /// 建立新的 Immunization 資源實例
        /// </summary>
        public Immunization()
        {
        }

        /// <summary>
        /// 建立新的 Immunization 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Immunization(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Immunization(Id: {Id})";
        }
    }
}
