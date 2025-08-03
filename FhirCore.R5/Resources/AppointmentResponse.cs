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
    /// FHIR R5 AppointmentResponse 資源
    /// 
    /// <para>
    /// AppointmentResponse 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
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
    /// R5 版本的 AppointmentResponse 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class AppointmentResponse : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _appointment;
        private FhirBoolean? _proposednewtime;
        private FhirInstant? _start;
        private FhirInstant? _end;
        private List<CodeableConcept>? _participanttype;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _actor;
        private FhirCode? _participantstatus;
        private FhirMarkdown? _comment;
        private FhirBoolean? _recurring;
        private FhirDate? _occurrencedate;
        private FhirPositiveInt? _recurrenceid;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "AppointmentResponse";        /// <summary>
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
        /// Appointment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Appointment 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Appointment
        {
            get => _appointment;
            set
            {
                _appointment = value;
                OnPropertyChanged(nameof(Appointment));
            }
        }        /// <summary>
        /// Proposednewtime
        /// </summary>
        /// <remarks>
        /// <para>
        /// Proposednewtime 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Proposednewtime
        {
            get => _proposednewtime;
            set
            {
                _proposednewtime = value;
                OnPropertyChanged(nameof(Proposednewtime));
            }
        }        /// <summary>
        /// Start
        /// </summary>
        /// <remarks>
        /// <para>
        /// Start 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInstant? Start
        {
            get => _start;
            set
            {
                _start = value;
                OnPropertyChanged(nameof(Start));
            }
        }        /// <summary>
        /// End
        /// </summary>
        /// <remarks>
        /// <para>
        /// End 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInstant? End
        {
            get => _end;
            set
            {
                _end = value;
                OnPropertyChanged(nameof(End));
            }
        }        /// <summary>
        /// Participanttype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Participanttype 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Participanttype
        {
            get => _participanttype;
            set
            {
                _participanttype = value;
                OnPropertyChanged(nameof(Participanttype));
            }
        }        /// <summary>
        /// Actor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Actor 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Actor
        {
            get => _actor;
            set
            {
                _actor = value;
                OnPropertyChanged(nameof(Actor));
            }
        }        /// <summary>
        /// Participantstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Participantstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Participantstatus
        {
            get => _participantstatus;
            set
            {
                _participantstatus = value;
                OnPropertyChanged(nameof(Participantstatus));
            }
        }        /// <summary>
        /// Comment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Comment 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Comment
        {
            get => _comment;
            set
            {
                _comment = value;
                OnPropertyChanged(nameof(Comment));
            }
        }        /// <summary>
        /// Recurring
        /// </summary>
        /// <remarks>
        /// <para>
        /// Recurring 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Recurring
        {
            get => _recurring;
            set
            {
                _recurring = value;
                OnPropertyChanged(nameof(Recurring));
            }
        }        /// <summary>
        /// Occurrencedate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Occurrencedate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Occurrencedate
        {
            get => _occurrencedate;
            set
            {
                _occurrencedate = value;
                OnPropertyChanged(nameof(Occurrencedate));
            }
        }        /// <summary>
        /// Recurrenceid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Recurrenceid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Recurrenceid
        {
            get => _recurrenceid;
            set
            {
                _recurrenceid = value;
                OnPropertyChanged(nameof(Recurrenceid));
            }
        }        /// <summary>
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
