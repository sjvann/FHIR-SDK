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
    /// FHIR R4 Appointment 資源
    /// 
    /// <para>
    /// A booking of a healthcare event among patient(s), practitioner(s), related person(s) and/or device(s) for a specific date/time. This may result in one or more Encounter(s).
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var appointment = new Appointment("appointment-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 Appointment 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Appointment : ResourceBase<R4Version>
    {
        private CodeableConcept? _appointmenttype;

        /// <summary>
        /// appointmentType
        /// </summary>
        /// <remarks>
        /// <para>
        /// appointmentType 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? appointmentType
        {
            get => _appointmenttype;
            set
            {
                _appointmenttype = value;
                OnPropertyChanged(nameof(appointmentType));
            }
        }

        private List<ReferenceType>? _basedon;

        /// <summary>
        /// basedOn
        /// </summary>
        /// <remarks>
        /// <para>
        /// basedOn 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? basedOn
        {
            get => _basedon;
            set
            {
                _basedon = value;
                OnPropertyChanged(nameof(basedOn));
            }
        }

        private CodeableConcept? _cancelationreason;

        /// <summary>
        /// cancelationReason
        /// </summary>
        /// <remarks>
        /// <para>
        /// cancelationReason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? cancelationReason
        {
            get => _cancelationreason;
            set
            {
                _cancelationreason = value;
                OnPropertyChanged(nameof(cancelationReason));
            }
        }

        private FhirString? _comment;

        /// <summary>
        /// comment
        /// </summary>
        /// <remarks>
        /// <para>
        /// comment 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? comment
        {
            get => _comment;
            set
            {
                _comment = value;
                OnPropertyChanged(nameof(comment));
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

        private FhirDateTime? _created;

        /// <summary>
        /// created
        /// </summary>
        /// <remarks>
        /// <para>
        /// created 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? created
        {
            get => _created;
            set
            {
                _created = value;
                OnPropertyChanged(nameof(created));
            }
        }

        private FhirString? _description;

        /// <summary>
        /// description
        /// </summary>
        /// <remarks>
        /// <para>
        /// description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(description));
            }
        }

        private FhirInstant? _end;

        /// <summary>
        /// end
        /// </summary>
        /// <remarks>
        /// <para>
        /// end 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInstant? end
        {
            get => _end;
            set
            {
                _end = value;
                OnPropertyChanged(nameof(end));
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

        private FhirPositiveInt? _minutesduration;

        /// <summary>
        /// minutesDuration
        /// </summary>
        /// <remarks>
        /// <para>
        /// minutesDuration 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? minutesDuration
        {
            get => _minutesduration;
            set
            {
                _minutesduration = value;
                OnPropertyChanged(nameof(minutesDuration));
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

        private List<BackboneElement>? _participant;

        /// <summary>
        /// participant
        /// </summary>
        /// <remarks>
        /// <para>
        /// participant 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? participant
        {
            get => _participant;
            set
            {
                _participant = value;
                OnPropertyChanged(nameof(participant));
            }
        }

        private FhirString? _patientinstruction;

        /// <summary>
        /// patientInstruction
        /// </summary>
        /// <remarks>
        /// <para>
        /// patientInstruction 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? patientInstruction
        {
            get => _patientinstruction;
            set
            {
                _patientinstruction = value;
                OnPropertyChanged(nameof(patientInstruction));
            }
        }

        private FhirUnsignedInt? _priority;

        /// <summary>
        /// priority
        /// </summary>
        /// <remarks>
        /// <para>
        /// priority 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(priority));
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

        private List<Period>? _requestedperiod;

        /// <summary>
        /// requestedPeriod
        /// </summary>
        /// <remarks>
        /// <para>
        /// requestedPeriod 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Period>? requestedPeriod
        {
            get => _requestedperiod;
            set
            {
                _requestedperiod = value;
                OnPropertyChanged(nameof(requestedPeriod));
            }
        }

        private List<CodeableConcept>? _servicecategory;

        /// <summary>
        /// serviceCategory
        /// </summary>
        /// <remarks>
        /// <para>
        /// serviceCategory 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? serviceCategory
        {
            get => _servicecategory;
            set
            {
                _servicecategory = value;
                OnPropertyChanged(nameof(serviceCategory));
            }
        }

        private List<CodeableConcept>? _servicetype;

        /// <summary>
        /// serviceType
        /// </summary>
        /// <remarks>
        /// <para>
        /// serviceType 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? serviceType
        {
            get => _servicetype;
            set
            {
                _servicetype = value;
                OnPropertyChanged(nameof(serviceType));
            }
        }

        private List<ReferenceType>? _slot;

        /// <summary>
        /// slot
        /// </summary>
        /// <remarks>
        /// <para>
        /// slot 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? slot
        {
            get => _slot;
            set
            {
                _slot = value;
                OnPropertyChanged(nameof(slot));
            }
        }

        private List<CodeableConcept>? _specialty;

        /// <summary>
        /// specialty
        /// </summary>
        /// <remarks>
        /// <para>
        /// specialty 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? specialty
        {
            get => _specialty;
            set
            {
                _specialty = value;
                OnPropertyChanged(nameof(specialty));
            }
        }

        private FhirInstant? _start;

        /// <summary>
        /// start
        /// </summary>
        /// <remarks>
        /// <para>
        /// start 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInstant? start
        {
            get => _start;
            set
            {
                _start = value;
                OnPropertyChanged(nameof(start));
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

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Appointment";

        /// <summary>
        /// 建立新的 Appointment 資源實例
        /// </summary>
        public Appointment()
        {
        }

        /// <summary>
        /// 建立新的 Appointment 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Appointment(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Appointment(Id: {Id})";
        }
    }
}
