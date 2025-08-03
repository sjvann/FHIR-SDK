using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;


namespace DataTypeServices.DataTypes.MetaTypes
{
    public class ExtendedContactDetail : ComplexType<ExtendedContactDetail>
    {
        private CodeableConcept? _purpose;
        private List<HumanName>? _name;
        private List<ContactPoint>? _telecom;
        private Address? _address;
        private ReferenceType? _organization;
        private Period? _period;

        public CodeableConcept? Purpose
        {
            get { return _purpose; }
            set
            {
                _purpose = value;
                OnPropertyChanged("purpose", value);
            }
        }
        public List<HumanName>? Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("name", value);
            }
        }
        public List<ContactPoint>? Telecom
        {
            get { return _telecom; }
            set
            {
                _telecom = value;
                OnPropertyChanged("telecom", value);
            }
        }
        public Address? Address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged("address", value);
            }
        }
        public ReferenceType? Organization
        {
            get { return _organization; }
            set
            {
                _organization = value;
                OnPropertyChanged("organization", value);
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

        public ExtendedContactDetail() : base() { }
        public ExtendedContactDetail(JsonObject? value) : base(value) { }
        public ExtendedContactDetail(string value) : base(value) { }
    }
}
