
using System.Text.Json.Nodes;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.ComplexTypes;

namespace DataTypeServices.DataTypes.SpecialTypes
{
    public class Dosage : BackboneType<Dosage>
    {

        private FhirInteger? _Sequence;
        public FhirInteger? Sequence
        {
            get { return _Sequence; }
            set
            {
                _Sequence = value;
                OnPropertyChanged("sequence", value);
            }
        }
        private FhirString? _Text;
        public FhirString? Text
        {
            get { return _Text; }
            set
            {
                _Text = value;
                OnPropertyChanged("text", value);
            }
        }

        private List<CodeableConcept>? _AdditionalInstruction;
        public List<CodeableConcept>? AdditionalInstruction
        {
            get { return _AdditionalInstruction; }
            set
            {
                _AdditionalInstruction = value;
                OnPropertyChanged("additionalInstruction", value);
            }
        }
        private FhirString? _PatientInstruction;
        public FhirString? PatientInstruction
        {
            get { return _PatientInstruction; }
            set
            {
                _PatientInstruction = value;
                OnPropertyChanged("patientInstruction", value);
            }
        }
        private Timing? _Timing;
        public Timing? Timing
        {
            get { return _Timing; }
            set
            {
                _Timing = value;
                OnPropertyChanged("timing", value);
            }
        }
        private FhirBoolean? _AsNeeded;
        public FhirBoolean? AsNeeded
        {
            get { return _AsNeeded; }
            set
            {
                _AsNeeded = value;
                OnPropertyChanged("asNeeded", value);
            }
        }
        private List<CodeableConcept>? _AsNeededFor;
        public List<CodeableConcept>? AsNeededFor
        {
            get { return _AsNeededFor; }
            set
            {
                _AsNeededFor = value;
                OnPropertyChanged("asNeededFor", value);
            }
        }
        private CodeableConcept? _Site;
        public CodeableConcept? Site
        {
            get { return _Site; }
            set
            {
                _Site = value;
                OnPropertyChanged("site", value);
            }
        }
        private CodeableConcept? _Route;
        public CodeableConcept? Route
        {
            get { return _Route; }
            set
            {
                _Route = value;
                OnPropertyChanged("route", value);
            }
        }
        private CodeableConcept? _Method;
        public CodeableConcept? Method
        {
            get { return _Method; }
            set
            {
                _Method = value;
                OnPropertyChanged("method", value);
            }
        }
        private List<DoseAndRate>? _DoseAndRate;
        public List<DoseAndRate>? DoseAndRate
        {
            get { return _DoseAndRate; }
            set
            {
                _DoseAndRate = value;
                OnPropertyChanged("doseAndRate", value);
            }
        }
        private List<Ratio>? _MaxDosePerPeriod;
        public List<Ratio>? MaxDosePerPeriod
        {
            get { return _MaxDosePerPeriod; }
            set
            {
                _MaxDosePerPeriod = value;
                OnPropertyChanged("maxDosePerPeriod", value);
            }
        }
        private SimpleQuantity? _MaxDosePerAdministration;
        public SimpleQuantity? MaxDosePerAdministration
        {
            get { return _MaxDosePerAdministration; }
            set
            {
                _MaxDosePerAdministration = value;
                OnPropertyChanged("maxDosePerAdministration", value);
            }
        }
        private SimpleQuantity? _MaxDosePerLifetime;
        public SimpleQuantity? MaxDosePerLifetime
        {
            get { return _MaxDosePerLifetime; }
            set
            {
                _MaxDosePerLifetime = value;
                OnPropertyChanged("maxDosePerLifetime", value);
            }
        }

        public Dosage() : base() { }
        public Dosage(JsonObject value) : base(value) { }
        public Dosage(string value) : base(value) { }

    }


    public class DoseAndRate : ComplexType<DoseAndRate>
    {
        private CodeableConcept? _Type;
        public CodeableConcept? Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                OnPropertyChanged("type", value);
            }
        }
        private ChoiceType? _Dose;
        public ChoiceType? Dose
        {
            get { return _Dose; }
            set
            {
                _Dose = value;
                OnPropertyChanged("dose", value);
            }
        }
        private ChoiceType? _Rate;
        public ChoiceType? Rate
        {
            get { return _Rate; }
            set
            {
                _Rate = value;
                OnPropertyChanged("rate", value);
            }
        }

        public DoseAndRate() : base() { }
        public DoseAndRate(JsonObject value) : base(value) { }
        public DoseAndRate(string value) : base(value) { }

    }
}
