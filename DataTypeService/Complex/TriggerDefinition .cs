using Core.Attribute;

using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class TriggerDefinition : ComplexType<TriggerDefinition>
    {

        #region Property
        [Element("type", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Type { get; set; }
        [Element("name", typeof(FhirString), true, false, false, false)]
        public FhirString? Name { get; set; }
        [Element("code", typeof(CodeableConcept), false, false, false, false)]
        public CodeableConcept? Code { get; set; }
        [Element("subscriptionTopic", typeof(FhirCanonical), true, false, false, false)]
        public FhirCanonical? SubscriptionTopic { get; set; }
        [Element("timing", typeof(ChoiceBased), false, false, false, false)]
        public ChoiceBased? Timing { get; set; }
        [Element("data", typeof(DataRequirement), false, false, false, false)]
        public DataRequirement? Data { get; set; }
        [Element("condition", typeof(Expression), false, false, false, false)]
        public Expression? Condition { get; set; }
        #endregion
        #region Constructor
        public TriggerDefinition() { }
        public TriggerDefinition(string? value) : base(value) { }
        public TriggerDefinition(JsonNode? source) : base(source) { }
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
