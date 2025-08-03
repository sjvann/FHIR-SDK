using FhirCore.ExtensionMethods;
using System.Text.Json.Nodes;
using TerminologyService.ValueSet;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.DataTypes.MetaTypes;
using Range = DataTypeServices.DataTypes.ComplexTypes.Range;
using FhirCore.Interfaces;

namespace ResourceTypeServices.R5
{
    public class Appointment : ResourceType<Appointment>
    {
        #region private Property
        private List<Identifier>? _identifier;
        private FhirCode? _status;
        private CodeableConcept? _cancellationReason;
        private List<CodeableConcept>? _class;
        private List<CodeableConcept>? _serviceCategory;
        private List<CodeableReference>? _serviceType;
        private List<CodeableConcept>? _specialty;
        private CodeableConcept? _appointmentType;
        private List<CodeableReference>? _reason;
        private CodeableConcept? _priority;
        private FhirString? _description;
        private List<ReferenceType>? _replaces;
        private List<VirtualServiceDetail>? _virtualService;
        private List<ReferenceType>? _supportingInformation;
        private ReferenceType? _previousAppointment;
        private ReferenceType? _originatingAppointment;
        private FhirInstant? _start;
        private FhirInstant? _end;
        private FhirPositiveInt? _minutesDuration;
        private List<Period>? _requestedPeriod;
        private List<ReferenceType>? _slot;
        private List<ReferenceType>? _account;
        private FhirDateTime? _created;
        private FhirDateTime? _cancellationDate;
        private List<Annotation>? _note;
        private List<CodeableReference>? _patientInstruction;
        private List<ReferenceType>? _basedOn;
        private ReferenceType? _subject;
        private List<AppointmentParticipant>? _participant;
        private FhirPositiveInt? _recurrenceId;
        private FhirBoolean? _occurrenceChanged;
        private List<AppointmentRecurrenceTemplate>? _recurrenceTemplate;

        #endregion
        #region Public Method
        public List<Identifier>? Identifier
        {
            get { return _identifier; }
            set
            {
                _identifier = value;
                OnPropertyChanged("identifier", value);
            }
        }

        public FhirCode? Status
        {
            get { return _status; }
            set
            {
                _status = value;
                OnPropertyChanged("status", value);
            }
        }

        public CodeableConcept? CancellationReason
        {
            get { return _cancellationReason; }
            set
            {
                _cancellationReason = value;
                OnPropertyChanged("cancellationReason", value);
            }
        }

        public List<CodeableConcept>? Class
        {
            get { return _class; }
            set
            {
                _class = value;
                OnPropertyChanged("class", value);
            }
        }

        public List<CodeableConcept>? ServiceCategory
        {
            get { return _serviceCategory; }
            set
            {
                _serviceCategory = value;
                OnPropertyChanged("serviceCategory", value);
            }
        }

        public List<CodeableReference>? ServiceType
        {
            get { return _serviceType; }
            set
            {
                _serviceType = value;
                OnPropertyChanged("serviceType", value);
            }
        }

        public List<CodeableConcept>? Specialty
        {
            get { return _specialty; }
            set
            {
                _specialty = value;
                OnPropertyChanged("specialty", value);
            }
        }

        public CodeableConcept? AppointmentType
        {
            get { return _appointmentType; }
            set
            {
                _appointmentType = value;
                OnPropertyChanged("appointmentType", value);
            }
        }

        public List<CodeableReference>? Reason
        {
            get { return _reason; }
            set
            {
                _reason = value;
                OnPropertyChanged("reason", value);
            }
        }

        public CodeableConcept? Priority
        {
            get { return _priority; }
            set
            {
                _priority = value;
                OnPropertyChanged("priority", value);
            }
        }

        public FhirString? Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("description", value);
            }
        }

        public List<ReferenceType>? Replaces
        {
            get { return _replaces; }
            set
            {
                _replaces = value;
                OnPropertyChanged("replaces", value);
            }
        }

        public List<VirtualServiceDetail>? VirtualService
        {
            get { return _virtualService; }
            set
            {
                _virtualService = value;
                OnPropertyChanged("virtualService", value);
            }
        }

        public List<ReferenceType>? SupportingInformation
        {
            get { return _supportingInformation; }
            set
            {
                _supportingInformation = value;
                OnPropertyChanged("supportingInformation", value);
            }
        }

        public ReferenceType? PreviousAppointment
        {
            get { return _previousAppointment; }
            set
            {
                _previousAppointment = value;
                OnPropertyChanged("previousAppointment", value);
            }
        }

        public ReferenceType? OriginatingAppointment
        {
            get { return _originatingAppointment; }
            set
            {
                _originatingAppointment = value;
                OnPropertyChanged("originatingAppointment", value);
            }
        }

        public FhirInstant? Start
        {
            get { return _start; }
            set
            {
                _start = value;
                OnPropertyChanged("start", value);
            }
        }

        public FhirInstant? End
        {
            get { return _end; }
            set
            {
                _end = value;
                OnPropertyChanged("end", value);
            }
        }

        public FhirPositiveInt? MinutesDuration
        {
            get { return _minutesDuration; }
            set
            {
                _minutesDuration = value;
                OnPropertyChanged("minutesDuration", value);
            }
        }

        public List<Period>? RequestedPeriod
        {
            get { return _requestedPeriod; }
            set
            {
                _requestedPeriod = value;
                OnPropertyChanged("requestedPeriod", value);
            }
        }

        public List<ReferenceType>? Slot
        {
            get { return _slot; }
            set
            {
                _slot = value;
                OnPropertyChanged("slot", value);
            }
        }

        public List<ReferenceType>? Account
        {
            get { return _account; }
            set
            {
                _account = value;
                OnPropertyChanged("account", value);
            }
        }

        public FhirDateTime? Created
        {
            get { return _created; }
            set
            {
                _created = value;
                OnPropertyChanged("created", value);
            }
        }

        public FhirDateTime? CancellationDate
        {
            get { return _cancellationDate; }
            set
            {
                _cancellationDate = value;
                OnPropertyChanged("cancellationDate", value);
            }
        }

        public List<Annotation>? Note
        {
            get { return _note; }
            set
            {
                _note = value;
                OnPropertyChanged("note", value);
            }
        }

        public List<CodeableReference>? PatientInstruction
        {
            get { return _patientInstruction; }
            set
            {
                _patientInstruction = value;
                OnPropertyChanged("patientInstruction", value);
            }
        }

        public List<ReferenceType>? BasedOn
        {
            get { return _basedOn; }
            set
            {
                _basedOn = value;
                OnPropertyChanged("basedOn", value);
            }
        }

        public ReferenceType? Subject
        {
            get { return _subject; }
            set
            {
                _subject = value;
                OnPropertyChanged("subject", value);
            }
        }

        public List<AppointmentParticipant>? Participant
        {
            get { return _participant; }
            set
            {
                _participant = value;
                OnPropertyChanged("participant", value);
            }
        }

        public FhirPositiveInt? RecurrenceId
        {
            get { return _recurrenceId; }
            set
            {
                _recurrenceId = value;
                OnPropertyChanged("recurrenceId", value);
            }
        }

        public FhirBoolean? OccurrenceChanged
        {
            get { return _occurrenceChanged; }
            set
            {
                _occurrenceChanged = value;
                OnPropertyChanged("occurrenceChanged", value);
            }
        }

        public List<AppointmentRecurrenceTemplate>? RecurrenceTemplate
        {
            get { return _recurrenceTemplate; }
            set
            {
                _recurrenceTemplate = value;
                OnPropertyChanged("recurrenceTemplate", value);
            }
        }


        #endregion
        #region Constructor
        public Appointment() { }
        public Appointment(string value) : base(value) { }
        public Appointment(JsonNode? source) : base(source) { }
        #endregion
    }
    public class AppointmentParticipant : BackboneElementType<AppointmentParticipant>, IBackboneElementType
    {

        #region Private Method
        private List<CodeableConcept>? _type;
        private Period? _period;
        private ReferenceType? _actor;
        private FhirBoolean? _required;
        private FhirCode? _status;

        #endregion
        #region public Method
        public List<CodeableConcept>? Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("type", value);
            }
        }

        public Period? Period
        {
            get { return _period; }
            set
            {
                _period = value;
                OnPropertyChanged("period", value);
            }
        }

        public ReferenceType? Actor
        {
            get { return _actor; }
            set
            {
                _actor = value;
                OnPropertyChanged("actor", value);
            }
        }

        public FhirBoolean? Required
        {
            get { return _required; }
            set
            {
                _required = value;
                OnPropertyChanged("required", value);
            }
        }

        public FhirCode? Status
        {
            get { return _status; }
            set
            {
                _status = value;
                OnPropertyChanged("status", value);
            }
        }


        #endregion
        #region Constructor
        public AppointmentParticipant() { }
        public AppointmentParticipant(string value) : base(value) { }
        public AppointmentParticipant(JsonObject? source) : base(source) { }
        #endregion
    }

    public class AppointmentRecurrenceTemplateWeeklyTemplate : BackboneElementType<AppointmentRecurrenceTemplateWeeklyTemplate>, IBackboneElementType
    {

        #region Private Method
        private FhirBoolean? _monday;
        private FhirBoolean? _tuesday;
        private FhirBoolean? _wednesday;
        private FhirBoolean? _thursday;
        private FhirBoolean? _friday;
        private FhirBoolean? _saturday;
        private FhirBoolean? _sunday;
        private FhirPositiveInt? _weekInterval;

        #endregion
        #region public Method
        public FhirBoolean? Monday
        {
            get { return _monday; }
            set
            {
                _monday = value;
                OnPropertyChanged("monday", value);
            }
        }

        public FhirBoolean? Tuesday
        {
            get { return _tuesday; }
            set
            {
                _tuesday = value;
                OnPropertyChanged("tuesday", value);
            }
        }

        public FhirBoolean? Wednesday
        {
            get { return _wednesday; }
            set
            {
                _wednesday = value;
                OnPropertyChanged("wednesday", value);
            }
        }

        public FhirBoolean? Thursday
        {
            get { return _thursday; }
            set
            {
                _thursday = value;
                OnPropertyChanged("thursday", value);
            }
        }

        public FhirBoolean? Friday
        {
            get { return _friday; }
            set
            {
                _friday = value;
                OnPropertyChanged("friday", value);
            }
        }

        public FhirBoolean? Saturday
        {
            get { return _saturday; }
            set
            {
                _saturday = value;
                OnPropertyChanged("saturday", value);
            }
        }

        public FhirBoolean? Sunday
        {
            get { return _sunday; }
            set
            {
                _sunday = value;
                OnPropertyChanged("sunday", value);
            }
        }

        public FhirPositiveInt? WeekInterval
        {
            get { return _weekInterval; }
            set
            {
                _weekInterval = value;
                OnPropertyChanged("weekInterval", value);
            }
        }


        #endregion
        #region Constructor
        public AppointmentRecurrenceTemplateWeeklyTemplate() { }
        public AppointmentRecurrenceTemplateWeeklyTemplate(string value) : base(value) { }
        public AppointmentRecurrenceTemplateWeeklyTemplate(JsonObject? source) : base(source) { }
        #endregion
    }

    public class AppointmentRecurrenceTemplateMonthlyTemplate : BackboneElementType<AppointmentRecurrenceTemplateMonthlyTemplate>, IBackboneElementType
    {

        #region Private Method
        private FhirPositiveInt? _dayOfMonth;
        private Coding? _nthWeekOfMonth;
        private Coding? _dayOfWeek;
        private FhirPositiveInt? _monthInterval;

        #endregion
        #region public Method
        public FhirPositiveInt? DayOfMonth
        {
            get { return _dayOfMonth; }
            set
            {
                _dayOfMonth = value;
                OnPropertyChanged("dayOfMonth", value);
            }
        }

        public Coding? NthWeekOfMonth
        {
            get { return _nthWeekOfMonth; }
            set
            {
                _nthWeekOfMonth = value;
                OnPropertyChanged("nthWeekOfMonth", value);
            }
        }

        public Coding? DayOfWeek
        {
            get { return _dayOfWeek; }
            set
            {
                _dayOfWeek = value;
                OnPropertyChanged("dayOfWeek", value);
            }
        }

        public FhirPositiveInt? MonthInterval
        {
            get { return _monthInterval; }
            set
            {
                _monthInterval = value;
                OnPropertyChanged("monthInterval", value);
            }
        }


        #endregion
        #region Constructor
        public AppointmentRecurrenceTemplateMonthlyTemplate() { }
        public AppointmentRecurrenceTemplateMonthlyTemplate(string value) : base(value) { }
        public AppointmentRecurrenceTemplateMonthlyTemplate(JsonObject? source) : base(source) { }
        #endregion
    }

    public class AppointmentRecurrenceTemplateYearlyTemplate : BackboneElementType<AppointmentRecurrenceTemplateYearlyTemplate>, IBackboneElementType
    {

        #region Private Method
        private FhirPositiveInt? _yearInterval;

        #endregion
        #region public Method
        public FhirPositiveInt? YearInterval
        {
            get { return _yearInterval; }
            set
            {
                _yearInterval = value;
                OnPropertyChanged("yearInterval", value);
            }
        }


        #endregion
        #region Constructor
        public AppointmentRecurrenceTemplateYearlyTemplate() { }
        public AppointmentRecurrenceTemplateYearlyTemplate(string value) : base(value) { }
        public AppointmentRecurrenceTemplateYearlyTemplate(JsonObject? source) : base(source) { }
        #endregion
    }

    public class AppointmentRecurrenceTemplate : BackboneElementType<AppointmentRecurrenceTemplate>, IBackboneElementType
    {

        #region Private Method
        private CodeableConcept? _timezone;
        private CodeableConcept? _recurrenceType;
        private FhirDate? _lastOccurrenceDate;
        private FhirPositiveInt? _occurrenceCount;
        private List<FhirDate>? _occurrenceDate;
        private AppointmentRecurrenceTemplateWeeklyTemplate? _weeklyTemplate;
        private AppointmentRecurrenceTemplateMonthlyTemplate? _monthlyTemplate;
        private AppointmentRecurrenceTemplateYearlyTemplate? _yearlyTemplate;
        private List<FhirDate>? _excludingDate;
        private List<FhirPositiveInt>? _excludingRecurrenceId;

        #endregion
        #region public Method
        public CodeableConcept? Timezone
        {
            get { return _timezone; }
            set
            {
                _timezone = value;
                OnPropertyChanged("timezone", value);
            }
        }

        public CodeableConcept? RecurrenceType
        {
            get { return _recurrenceType; }
            set
            {
                _recurrenceType = value;
                OnPropertyChanged("recurrenceType", value);
            }
        }

        public FhirDate? LastOccurrenceDate
        {
            get { return _lastOccurrenceDate; }
            set
            {
                _lastOccurrenceDate = value;
                OnPropertyChanged("lastOccurrenceDate", value);
            }
        }

        public FhirPositiveInt? OccurrenceCount
        {
            get { return _occurrenceCount; }
            set
            {
                _occurrenceCount = value;
                OnPropertyChanged("occurrenceCount", value);
            }
        }

        public List<FhirDate>? OccurrenceDate
        {
            get { return _occurrenceDate; }
            set
            {
                _occurrenceDate = value;
                OnPropertyChanged("occurrenceDate", value);
            }
        }

        public AppointmentRecurrenceTemplateWeeklyTemplate? WeeklyTemplate
        {
            get { return _weeklyTemplate; }
            set
            {
                _weeklyTemplate = value;
                OnPropertyChanged("weeklyTemplate", value);
            }
        }

        public AppointmentRecurrenceTemplateMonthlyTemplate? MonthlyTemplate
        {
            get { return _monthlyTemplate; }
            set
            {
                _monthlyTemplate = value;
                OnPropertyChanged("monthlyTemplate", value);
            }
        }

        public AppointmentRecurrenceTemplateYearlyTemplate? YearlyTemplate
        {
            get { return _yearlyTemplate; }
            set
            {
                _yearlyTemplate = value;
                OnPropertyChanged("yearlyTemplate", value);
            }
        }

        public List<FhirDate>? ExcludingDate
        {
            get { return _excludingDate; }
            set
            {
                _excludingDate = value;
                OnPropertyChanged("excludingDate", value);
            }
        }

        public List<FhirPositiveInt>? ExcludingRecurrenceId
        {
            get { return _excludingRecurrenceId; }
            set
            {
                _excludingRecurrenceId = value;
                OnPropertyChanged("excludingRecurrenceId", value);
            }
        }


        #endregion
        #region Constructor
        public AppointmentRecurrenceTemplate() { }
        public AppointmentRecurrenceTemplate(string value) : base(value) { }
        public AppointmentRecurrenceTemplate(JsonObject? source) : base(source) { }
        #endregion
    }





}
