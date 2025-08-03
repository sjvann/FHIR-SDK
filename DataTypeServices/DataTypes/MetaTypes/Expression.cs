using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;


namespace DataTypeServices.DataTypes.MetaTypes
{
    public class ExpressionType : ComplexType<ExpressionType>
    {
        private FhirString? _description;
        private FhirCode? _name;
        private FhirCode? _language;
        private FhirString? _expression;
        private FhirUri? _reference;

        public FhirString? Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("description", value);
            }
        }
        public FhirCode? Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("name", value);
            }
        }
        public FhirCode? Language
        {
            get { return _language; }
            set
            {
                _language = value;
                OnPropertyChanged("language", value);
            }
        }
        public FhirString? Expression
        {
            get { return _expression; }
            set
            {
                _expression = value;
                OnPropertyChanged("expression", value);
            }
        }
        public FhirUri? Reference
        {
            get { return _reference; }
            set
            {
                _reference = value;
                OnPropertyChanged("reference", value);
            }
        }
        public ExpressionType() : base() { }
        public ExpressionType(JsonObject? value) : base(value) { }
        public ExpressionType(string value) : base(value) { }
    }
}
