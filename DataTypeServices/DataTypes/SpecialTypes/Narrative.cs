using FhirCore.Interfaces;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.SpecialTypes
{
    public class Narrative : ComplexType<Narrative>
    {
        private FhirCode? _Status;
        private FhirXhtml? _Div;

        public FhirCode? Status
        {
            get { return _Status; }
            set
            {
                _Status = value;
                OnPropertyChanged("status", value);
            }
        }
        public FhirXhtml? Div
        {
            get { return _Div; }
            set
            {
                _Div = value;
                OnPropertyChanged("div", value);
            }
        }
        public Narrative() : base() { }
        public Narrative(JsonObject value) : base(value)
        {
        }
        public Narrative(string value) : base(value) { }

    }
}
