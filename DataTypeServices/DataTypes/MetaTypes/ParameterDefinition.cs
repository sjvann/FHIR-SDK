using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;


namespace DataTypeServices.DataTypes.MetaTypes
{
    public class ParameterDefinition : ComplexType<ParameterDefinition>
    {
        private FhirCode? _name;
        private FhirCode? _use;
        private FhirInteger? _min;
        private FhirString? _max;
        private FhirString? _documentation;
        private FhirCode? _type;
        private FhirCanonical? _profile;

        public FhirCode? Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("name", value);
            }
        }
        public FhirCode? Use
        {
            get { return _use; }
            set
            {
                _use = value;
                OnPropertyChanged("use", value);
            }
        }
        public FhirInteger? Min
        {
            get { return _min; }
            set
            {
                _min = value;
                OnPropertyChanged("min", value);
            }
        }
        public FhirString? Max
        {
            get { return _max; }
            set
            {
                _max = value;
                OnPropertyChanged("max", value);
            }
        }
        public FhirString? Documentation
        {
            get { return _documentation; }
            set
            {
                _documentation = value;
                OnPropertyChanged("documentation", value);
            }
        }
        public FhirCode? Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("type", value);
            }
        }
        public FhirCanonical? Profile
        {
            get { return _profile; }
            set
            {
                _profile = value;
                OnPropertyChanged("profile", value);
            }
        }
        public ParameterDefinition() : base() { }
        public ParameterDefinition(JsonObject? value) : base(value) { }
        public ParameterDefinition(string value) : base(value) { }
    }
}
