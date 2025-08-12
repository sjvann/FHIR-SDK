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
    /// FHIR R4 AppointmentResponse 資源
    /// 
    /// <para>
    /// A reply to an appointment request for a patient and/or practitioner(s), such as a confirmation or rejection.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var appointmentresponse = new AppointmentResponse("appointmentresponse-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 AppointmentResponse 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class AppointmentResponse : ResourceBase<R4Version>
    {
        private ReferenceType? _actor;

        /// <summary>
        /// actor
        /// </summary>
        /// <remarks>
        /// <para>
        /// actor 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? actor
        {
            get => _actor;
            set
            {
                _actor = value;
                OnPropertyChanged(nameof(actor));
            }
        }

        private ReferenceType? _appointment;

        /// <summary>
        /// appointment
        /// </summary>
        /// <remarks>
        /// <para>
        /// appointment 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? appointment
        {
            get => _appointment;
            set
            {
                _appointment = value;
                OnPropertyChanged(nameof(appointment));
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

        private FhirCode? _participantstatus;

        /// <summary>
        /// participantStatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// participantStatus 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? participantStatus
        {
            get => _participantstatus;
            set
            {
                _participantstatus = value;
                OnPropertyChanged(nameof(participantStatus));
            }
        }

        private List<CodeableConcept>? _participanttype;

        /// <summary>
        /// participantType
        /// </summary>
        /// <remarks>
        /// <para>
        /// participantType 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? participantType
        {
            get => _participanttype;
            set
            {
                _participanttype = value;
                OnPropertyChanged(nameof(participantType));
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
        public override string ResourceType => "AppointmentResponse";

        /// <summary>
        /// 建立新的 AppointmentResponse 資源實例
        /// </summary>
        public AppointmentResponse()
        {
        }

        /// <summary>
        /// 建立新的 AppointmentResponse 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public AppointmentResponse(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"AppointmentResponse(Id: {Id})";
        }
    }
}
