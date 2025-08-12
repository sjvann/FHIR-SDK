using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;


namespace DataTypeServices.DataTypes.MetaTypes
{
    public class Availability : ComplexType<Availability>
    {
        private AvailabilityAvailableTime? _availableTime;
        private AvailabilityNotAvailableTime? _notAvailableTime;
        public  AvailabilityAvailableTime? AvailableTime
        {
            get { return _availableTime; }
            set
            {
                _availableTime = value;
                OnPropertyChanged("availableTime", value);
            }
        }
        public AvailabilityNotAvailableTime? NotAvailableTime
        {
            get { return _notAvailableTime; }
            set
            {
                _notAvailableTime = value;
                OnPropertyChanged("notAvailableTime", value);
            }
        }
        public Availability() : base() { }
        public Availability(JsonObject? value) : base(value) { }
        public Availability(string value) : base(value) { }
    }

    public class AvailabilityNotAvailableTime: ComplexType<AvailabilityNotAvailableTime>
    {
        private FhirString? _description;
        private Period? _during;

        public FhirString? Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("description", value);
            }
        }
        public Period? During
        {
            get { return _during; }
            set
            {
                _during = value;
                OnPropertyChanged("during", value);
            }
        }
        public AvailabilityNotAvailableTime() : base() { }
        public AvailabilityNotAvailableTime(JsonObject? value) : base(value) { }
        public AvailabilityNotAvailableTime(string value) : base(value) { }
    }

    public class AvailabilityAvailableTime: ComplexType<AvailabilityAvailableTime>
    {
        private List<FhirCode>? _daysOfWeek;
        private FhirBoolean? _allDay;
        private FhirTime? _availableStartTime;
        private FhirTime? _availableEndTime;

        public List<FhirCode>? DaysOfWeek
        {
            get { return _daysOfWeek; }
            set
            {
                _daysOfWeek = value;
                OnPropertyChanged("daysOfWeek", value);
            }
        }
        public FhirBoolean? AllDay
        {
            get { return _allDay; }
            set
            {
                _allDay = value;
                OnPropertyChanged("allDay", value);
            }
        }
        public FhirTime? AvailableStartTime
        {
            get { return _availableStartTime; }
            set
            {
                _availableStartTime = value;
                OnPropertyChanged("availableStartTime", value);
            }
        }
        public FhirTime? AvailableEndTime
        {
            get { return _availableEndTime; }
            set
            {
                _availableEndTime = value;
                OnPropertyChanged("availableEndTime", value);
            }
        }


        public AvailabilityAvailableTime() : base() { }
        public AvailabilityAvailableTime(JsonObject? value) : base(value) { }
        public AvailabilityAvailableTime(string value) : base(value) { }
    }
}
