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
    /// FHIR R5 Appointment 資源
    /// 
    /// <para>
    /// Appointment 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
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
    /// R5 版本的 Appointment 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Appointment : ResourceBase<R5Version>
    {
        private Property
        private List<Identifier>? _identifier;
        private FhirCode? _status;
        private CodeableConcept? _cancellationreason;
        private List<CodeableConcept>? _class;
        private List<CodeableConcept>? _servicecategory;
        private List<CodeableReference>? _servicetype;
        private List<CodeableConcept>? _specialty;
        private CodeableConcept? _appointmenttype;
        private List<CodeableReference>? _reason;
        private CodeableConcept? _priority;
        private FhirString? _description;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _replaces;
        private List<VirtualServiceDetail>? _virtualservice;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _supportinginformation;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _previousappointment;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _originatingappointment;
        private FhirInstant? _start;
        private FhirInstant? _end;
        private FhirPositiveInt? _minutesduration;
        private List<Period>? _requestedperiod;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _slot;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _account;
        private FhirDateTime? _created;
        private FhirDateTime? _cancellationdate;
        private List<Annotation>? _note;
        private List<CodeableReference>? _patientinstruction;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private List<AppointmentParticipant>? _participant;
        private FhirPositiveInt? _recurrenceid;
        private FhirBoolean? _occurrencechanged;
        private List<AppointmentRecurrenceTemplate>? _recurrencetemplate;
        private List<CodeableConcept>? _type;
        private Period? _period;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _actor;
        private FhirBoolean? _required;
        private FhirCode? _status;
        private FhirBoolean? _monday;
        private FhirBoolean? _tuesday;
        private FhirBoolean? _wednesday;
        private FhirBoolean? _thursday;
        private FhirBoolean? _friday;
        private FhirBoolean? _saturday;
        private FhirBoolean? _sunday;
        private FhirPositiveInt? _weekinterval;
        private FhirPositiveInt? _dayofmonth;
        private Coding? _nthweekofmonth;
        private Coding? _dayofweek;
        private FhirPositiveInt? _monthinterval;
        private FhirPositiveInt? _yearinterval;
        private CodeableConcept? _timezone;
        private CodeableConcept? _recurrencetype;
        private FhirDate? _lastoccurrencedate;
        private FhirPositiveInt? _occurrencecount;
        private List<FhirDate>? _occurrencedate;
        private AppointmentRecurrenceTemplateWeeklyTemplate? _weeklytemplate;
        private AppointmentRecurrenceTemplateMonthlyTemplate? _monthlytemplate;
        private AppointmentRecurrenceTemplateYearlyTemplate? _yearlytemplate;
        private List<FhirDate>? _excludingdate;
        private List<FhirPositiveInt>? _excludingrecurrenceid;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Appointment";        /// <summary>
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
        /// Cancellationreason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Cancellationreason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Cancellationreason
        {
            get => _cancellationreason;
            set
            {
                _cancellationreason = value;
                OnPropertyChanged(nameof(Cancellationreason));
            }
        }        /// <summary>
        /// Class
        /// </summary>
        /// <remarks>
        /// <para>
        /// Class 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Class
        {
            get => _class;
            set
            {
                _class = value;
                OnPropertyChanged(nameof(Class));
            }
        }        /// <summary>
        /// Servicecategory
        /// </summary>
        /// <remarks>
        /// <para>
        /// Servicecategory 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Servicecategory
        {
            get => _servicecategory;
            set
            {
                _servicecategory = value;
                OnPropertyChanged(nameof(Servicecategory));
            }
        }        /// <summary>
        /// Servicetype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Servicetype 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Servicetype
        {
            get => _servicetype;
            set
            {
                _servicetype = value;
                OnPropertyChanged(nameof(Servicetype));
            }
        }        /// <summary>
        /// Specialty
        /// </summary>
        /// <remarks>
        /// <para>
        /// Specialty 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Specialty
        {
            get => _specialty;
            set
            {
                _specialty = value;
                OnPropertyChanged(nameof(Specialty));
            }
        }        /// <summary>
        /// Appointmenttype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Appointmenttype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Appointmenttype
        {
            get => _appointmenttype;
            set
            {
                _appointmenttype = value;
                OnPropertyChanged(nameof(Appointmenttype));
            }
        }        /// <summary>
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }        /// <summary>
        /// Priority
        /// </summary>
        /// <remarks>
        /// <para>
        /// Priority 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(Priority));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Replaces
        /// </summary>
        /// <remarks>
        /// <para>
        /// Replaces 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Replaces
        {
            get => _replaces;
            set
            {
                _replaces = value;
                OnPropertyChanged(nameof(Replaces));
            }
        }        /// <summary>
        /// Virtualservice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Virtualservice 的詳細描述。
        /// </para>
        /// </remarks>
        public List<VirtualServiceDetail>? Virtualservice
        {
            get => _virtualservice;
            set
            {
                _virtualservice = value;
                OnPropertyChanged(nameof(Virtualservice));
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
        /// Previousappointment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Previousappointment 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Previousappointment
        {
            get => _previousappointment;
            set
            {
                _previousappointment = value;
                OnPropertyChanged(nameof(Previousappointment));
            }
        }        /// <summary>
        /// Originatingappointment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Originatingappointment 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Originatingappointment
        {
            get => _originatingappointment;
            set
            {
                _originatingappointment = value;
                OnPropertyChanged(nameof(Originatingappointment));
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
        /// Minutesduration
        /// </summary>
        /// <remarks>
        /// <para>
        /// Minutesduration 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Minutesduration
        {
            get => _minutesduration;
            set
            {
                _minutesduration = value;
                OnPropertyChanged(nameof(Minutesduration));
            }
        }        /// <summary>
        /// Requestedperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requestedperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Period>? Requestedperiod
        {
            get => _requestedperiod;
            set
            {
                _requestedperiod = value;
                OnPropertyChanged(nameof(Requestedperiod));
            }
        }        /// <summary>
        /// Slot
        /// </summary>
        /// <remarks>
        /// <para>
        /// Slot 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Slot
        {
            get => _slot;
            set
            {
                _slot = value;
                OnPropertyChanged(nameof(Slot));
            }
        }        /// <summary>
        /// Account
        /// </summary>
        /// <remarks>
        /// <para>
        /// Account 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Account
        {
            get => _account;
            set
            {
                _account = value;
                OnPropertyChanged(nameof(Account));
            }
        }        /// <summary>
        /// Created
        /// </summary>
        /// <remarks>
        /// <para>
        /// Created 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Created
        {
            get => _created;
            set
            {
                _created = value;
                OnPropertyChanged(nameof(Created));
            }
        }        /// <summary>
        /// Cancellationdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Cancellationdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Cancellationdate
        {
            get => _cancellationdate;
            set
            {
                _cancellationdate = value;
                OnPropertyChanged(nameof(Cancellationdate));
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
        /// Patientinstruction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Patientinstruction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Patientinstruction
        {
            get => _patientinstruction;
            set
            {
                _patientinstruction = value;
                OnPropertyChanged(nameof(Patientinstruction));
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
        /// Participant
        /// </summary>
        /// <remarks>
        /// <para>
        /// Participant 的詳細描述。
        /// </para>
        /// </remarks>
        public List<AppointmentParticipant>? Participant
        {
            get => _participant;
            set
            {
                _participant = value;
                OnPropertyChanged(nameof(Participant));
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
        /// Occurrencechanged
        /// </summary>
        /// <remarks>
        /// <para>
        /// Occurrencechanged 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Occurrencechanged
        {
            get => _occurrencechanged;
            set
            {
                _occurrencechanged = value;
                OnPropertyChanged(nameof(Occurrencechanged));
            }
        }        /// <summary>
        /// Recurrencetemplate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Recurrencetemplate 的詳細描述。
        /// </para>
        /// </remarks>
        public List<AppointmentRecurrenceTemplate>? Recurrencetemplate
        {
            get => _recurrencetemplate;
            set
            {
                _recurrencetemplate = value;
                OnPropertyChanged(nameof(Recurrencetemplate));
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
        /// Period
        /// </summary>
        /// <remarks>
        /// <para>
        /// Period 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Period
        {
            get => _period;
            set
            {
                _period = value;
                OnPropertyChanged(nameof(Period));
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
        /// Required
        /// </summary>
        /// <remarks>
        /// <para>
        /// Required 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Required
        {
            get => _required;
            set
            {
                _required = value;
                OnPropertyChanged(nameof(Required));
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
        /// Monday
        /// </summary>
        /// <remarks>
        /// <para>
        /// Monday 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Monday
        {
            get => _monday;
            set
            {
                _monday = value;
                OnPropertyChanged(nameof(Monday));
            }
        }        /// <summary>
        /// Tuesday
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tuesday 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Tuesday
        {
            get => _tuesday;
            set
            {
                _tuesday = value;
                OnPropertyChanged(nameof(Tuesday));
            }
        }        /// <summary>
        /// Wednesday
        /// </summary>
        /// <remarks>
        /// <para>
        /// Wednesday 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Wednesday
        {
            get => _wednesday;
            set
            {
                _wednesday = value;
                OnPropertyChanged(nameof(Wednesday));
            }
        }        /// <summary>
        /// Thursday
        /// </summary>
        /// <remarks>
        /// <para>
        /// Thursday 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Thursday
        {
            get => _thursday;
            set
            {
                _thursday = value;
                OnPropertyChanged(nameof(Thursday));
            }
        }        /// <summary>
        /// Friday
        /// </summary>
        /// <remarks>
        /// <para>
        /// Friday 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Friday
        {
            get => _friday;
            set
            {
                _friday = value;
                OnPropertyChanged(nameof(Friday));
            }
        }        /// <summary>
        /// Saturday
        /// </summary>
        /// <remarks>
        /// <para>
        /// Saturday 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Saturday
        {
            get => _saturday;
            set
            {
                _saturday = value;
                OnPropertyChanged(nameof(Saturday));
            }
        }        /// <summary>
        /// Sunday
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sunday 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Sunday
        {
            get => _sunday;
            set
            {
                _sunday = value;
                OnPropertyChanged(nameof(Sunday));
            }
        }        /// <summary>
        /// Weekinterval
        /// </summary>
        /// <remarks>
        /// <para>
        /// Weekinterval 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Weekinterval
        {
            get => _weekinterval;
            set
            {
                _weekinterval = value;
                OnPropertyChanged(nameof(Weekinterval));
            }
        }        /// <summary>
        /// Dayofmonth
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dayofmonth 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Dayofmonth
        {
            get => _dayofmonth;
            set
            {
                _dayofmonth = value;
                OnPropertyChanged(nameof(Dayofmonth));
            }
        }        /// <summary>
        /// Nthweekofmonth
        /// </summary>
        /// <remarks>
        /// <para>
        /// Nthweekofmonth 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? Nthweekofmonth
        {
            get => _nthweekofmonth;
            set
            {
                _nthweekofmonth = value;
                OnPropertyChanged(nameof(Nthweekofmonth));
            }
        }        /// <summary>
        /// Dayofweek
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dayofweek 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? Dayofweek
        {
            get => _dayofweek;
            set
            {
                _dayofweek = value;
                OnPropertyChanged(nameof(Dayofweek));
            }
        }        /// <summary>
        /// Monthinterval
        /// </summary>
        /// <remarks>
        /// <para>
        /// Monthinterval 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Monthinterval
        {
            get => _monthinterval;
            set
            {
                _monthinterval = value;
                OnPropertyChanged(nameof(Monthinterval));
            }
        }        /// <summary>
        /// Yearinterval
        /// </summary>
        /// <remarks>
        /// <para>
        /// Yearinterval 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Yearinterval
        {
            get => _yearinterval;
            set
            {
                _yearinterval = value;
                OnPropertyChanged(nameof(Yearinterval));
            }
        }        /// <summary>
        /// Timezone
        /// </summary>
        /// <remarks>
        /// <para>
        /// Timezone 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Timezone
        {
            get => _timezone;
            set
            {
                _timezone = value;
                OnPropertyChanged(nameof(Timezone));
            }
        }        /// <summary>
        /// Recurrencetype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Recurrencetype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Recurrencetype
        {
            get => _recurrencetype;
            set
            {
                _recurrencetype = value;
                OnPropertyChanged(nameof(Recurrencetype));
            }
        }        /// <summary>
        /// Lastoccurrencedate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Lastoccurrencedate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Lastoccurrencedate
        {
            get => _lastoccurrencedate;
            set
            {
                _lastoccurrencedate = value;
                OnPropertyChanged(nameof(Lastoccurrencedate));
            }
        }        /// <summary>
        /// Occurrencecount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Occurrencecount 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Occurrencecount
        {
            get => _occurrencecount;
            set
            {
                _occurrencecount = value;
                OnPropertyChanged(nameof(Occurrencecount));
            }
        }        /// <summary>
        /// Occurrencedate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Occurrencedate 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirDate>? Occurrencedate
        {
            get => _occurrencedate;
            set
            {
                _occurrencedate = value;
                OnPropertyChanged(nameof(Occurrencedate));
            }
        }        /// <summary>
        /// Weeklytemplate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Weeklytemplate 的詳細描述。
        /// </para>
        /// </remarks>
        public AppointmentRecurrenceTemplateWeeklyTemplate? Weeklytemplate
        {
            get => _weeklytemplate;
            set
            {
                _weeklytemplate = value;
                OnPropertyChanged(nameof(Weeklytemplate));
            }
        }        /// <summary>
        /// Monthlytemplate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Monthlytemplate 的詳細描述。
        /// </para>
        /// </remarks>
        public AppointmentRecurrenceTemplateMonthlyTemplate? Monthlytemplate
        {
            get => _monthlytemplate;
            set
            {
                _monthlytemplate = value;
                OnPropertyChanged(nameof(Monthlytemplate));
            }
        }        /// <summary>
        /// Yearlytemplate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Yearlytemplate 的詳細描述。
        /// </para>
        /// </remarks>
        public AppointmentRecurrenceTemplateYearlyTemplate? Yearlytemplate
        {
            get => _yearlytemplate;
            set
            {
                _yearlytemplate = value;
                OnPropertyChanged(nameof(Yearlytemplate));
            }
        }        /// <summary>
        /// Excludingdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Excludingdate 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirDate>? Excludingdate
        {
            get => _excludingdate;
            set
            {
                _excludingdate = value;
                OnPropertyChanged(nameof(Excludingdate));
            }
        }        /// <summary>
        /// Excludingrecurrenceid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Excludingrecurrenceid 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Excludingrecurrenceid
        {
            get => _excludingrecurrenceid;
            set
            {
                _excludingrecurrenceid = value;
                OnPropertyChanged(nameof(Excludingrecurrenceid));
            }
        }        /// <summary>
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
    }    /// <summary>
    /// AppointmentParticipant 背骨元素
    /// </summary>
    public class AppointmentParticipant
    {
        // TODO: 添加屬性實作
        
        public AppointmentParticipant() { }
    }    /// <summary>
    /// AppointmentRecurrenceTemplateWeeklyTemplate 背骨元素
    /// </summary>
    public class AppointmentRecurrenceTemplateWeeklyTemplate
    {
        // TODO: 添加屬性實作
        
        public AppointmentRecurrenceTemplateWeeklyTemplate() { }
    }    /// <summary>
    /// AppointmentRecurrenceTemplateMonthlyTemplate 背骨元素
    /// </summary>
    public class AppointmentRecurrenceTemplateMonthlyTemplate
    {
        // TODO: 添加屬性實作
        
        public AppointmentRecurrenceTemplateMonthlyTemplate() { }
    }    /// <summary>
    /// AppointmentRecurrenceTemplateYearlyTemplate 背骨元素
    /// </summary>
    public class AppointmentRecurrenceTemplateYearlyTemplate
    {
        // TODO: 添加屬性實作
        
        public AppointmentRecurrenceTemplateYearlyTemplate() { }
    }    /// <summary>
    /// AppointmentRecurrenceTemplate 背骨元素
    /// </summary>
    public class AppointmentRecurrenceTemplate
    {
        // TODO: 添加屬性實作
        
        public AppointmentRecurrenceTemplate() { }
    }
}
