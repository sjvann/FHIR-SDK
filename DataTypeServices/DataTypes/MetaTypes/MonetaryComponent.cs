using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;


namespace DataTypeServices.DataTypes.MetaTypes
{
    public class MonetaryComponent : ComplexType<MonetaryComponent>
    {
        private FhirCode? _type;
        private CodeableConcept? _code;
        private FhirDecimal? _factor;
        private Money? _amount;

        public FhirCode? Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("type", value);
            }
        }
        public CodeableConcept? Code
        {
            get { return _code; }
            set
            {
                _code = value;
                OnPropertyChanged("code", value);
            }
        }
        public FhirDecimal? Factor
        {
            get { return _factor; }
            set
            {
                _factor = value;
                OnPropertyChanged("factor", value);
            }
        }
        public Money? Amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
                OnPropertyChanged("amount", value);
            }
        }



        public MonetaryComponent() : base() { }
        public MonetaryComponent(JsonObject? value) : base(value) { }
        public MonetaryComponent(string value) : base(value) { }
    }
}
