using Core.Extension;

using DataTypeService.BaseTypes;
using DataTypeService.Choice;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.MetaType
{
    public class TriggerDefinition : ComplexType
    {

        #region Property
        public FhirCode? Type { get; set; }
        public FhirString? Name { get; set; }
        public CodeableConcept? Code { get; set; }
        public FhirCanonical? SubscriptionTopic { get; set; }
        public ChoiceBased? Timing { get; set; }
        public DataRequirement? Data { get; set; }
        public Expression? Condition { get; set; }
        #endregion
        #region Constructor
        public TriggerDefinition() { }
        public TriggerDefinition(string? value) : this(value.Parse()) { }
        public TriggerDefinition(JsonNode? source)
        {
            _JsonNode = source;
            if (source != null)
            {
                var values = source.AsObject().GetEnumerator();
                while (values.MoveNext())
                {
                    var ck = values.Current.Key;
                    var cv = values.Current.Value;
                    switch (ck)
                    {
                        case "type": Type = new(cv); break;
                        case "name": Name = new(cv); break;
                        case "code": Code = new(cv); break;
                        case "subscriptionTopic": SubscriptionTopic = new(cv); break;
                        case "timingTiming":
                        case "timingReference":
                        case "timingDate":
                        case "timingDateTime":
                            Timing = new(ck, cv); break;
                        case "data": Data = new(cv); break;
                        case "condition": Condition = new(cv); break;
                        case "_type":
                            if (Type is FhirCode _type) SetupExtension(cv, ref _type);
                            break;
                        case "_name":
                            if (Name is FhirString _name) SetupExtension(cv, ref _name);
                            break;
                        case "_code":
                            if (Code is CodeableConcept _code) SetupExtension(cv, ref _code);
                            break;
                        case "_subscriptionTopic":
                            if (SubscriptionTopic is FhirCanonical _subscriptionTopic) SetupExtension(cv, ref _subscriptionTopic);
                            break;

                        case "_data":
                            if (Data is DataRequirement _data) SetupExtension(cv, ref _data);
                            break;
                        case "_condition":
                            if (Condition is Expression _condition) SetupExtension(cv, ref _condition);
                            break;
                    }
                }

            }

        }

        #endregion
        #region From Parent
        protected override string _TypeName => "TriggerDefinition ";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
