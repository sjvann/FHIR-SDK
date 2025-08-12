using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using FhirCore.ExtensionMethods;
using FhirCore.Interfaces;
using System.Text.Json.Nodes;


namespace DataTypeServices.DataTypes.MetaTypes
{
    public class TriggerDefinition : ComplexType<TriggerDefinition>
    {
        private FhirCode? _type;
        private FhirString? _name;
        private CodeableConcept? _code;
        private FhirCanonical? _subscriptionTopic;
        private TriggerDefinitionTimingChoice? _timing;
        private List<DataRequirement>? _data;
        private ExpressionType? _condition;
        public FhirCode? Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("type", value);
            }
        }
        public FhirString? Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("name", value);
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
        public FhirCanonical? SubscriptionTopic
        {
            get { return _subscriptionTopic; }
            set
            {
                _subscriptionTopic = value;
                OnPropertyChanged("subscriptionTopic", value);
            }
        }
        public TriggerDefinitionTimingChoice? Timing
        {
            get { return _timing; }
            set
            {
                _timing = value;
                OnPropertyChanged("timing", value);
            }
        }
        public List<DataRequirement>? Data
        {
            get { return _data; }
            set
            {
                _data = value;
                OnPropertyChanged("data", value);
            }
        }
        public ExpressionType? Condition
        {
            get { return _condition; }
            set
            {
                _condition = value;
                OnPropertyChanged("condition", value);
            }
        }

        public TriggerDefinition() : base() { }
        public TriggerDefinition(JsonObject? value) : base(value) { }
        public TriggerDefinition(string value) : base(value) { }
    }

    public class TriggerDefinitionTimingChoice:ChoiceType
    {


        private static readonly List<string> _supportType = [
        "Timing","Reference","date","dateTime"
        ];

        public TriggerDefinitionTimingChoice(JsonObject value) : base("subject", value, _supportType)
        {
        }
        public TriggerDefinitionTimingChoice(IComplexType? value) : base("subject", value)
        {
        }
        public TriggerDefinitionTimingChoice(IPrimitiveType? value) : base("subject", value) { }

        public override string GetPrefixName(bool withCapital = true) => "subject".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return _supportType;
        }
    }
}
