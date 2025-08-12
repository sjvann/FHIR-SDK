using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;


namespace DataTypeServices.DataTypes.MetaTypes
{
    public class ContactDetail : ComplexType<ContactDetail>
    {
        private FhirString? _name;
        private List<ContactPoint>? _telecom;

        public FhirString? Name
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
        public ContactDetail() : base() { }
        public ContactDetail(JsonObject? value) : base(value) { }
        public ContactDetail(string value) : base(value) { }
    }
}
