using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class UsageContext : ComplexType<UsageContext>
    {

        #region Property
        [Element("code", typeof(Coding), false, false, false, false)]
        public Coding? Code { get; init; }
        [Element("value", typeof(CodeableConcept), false, false, true, false)]
        public ChoiceBased? Value { get; init; }
        #endregion
        #region Constructor
        public UsageContext() { }
        public UsageContext(string? value) : base(value) { }
        public UsageContext(JsonNode? source) : base(source) { }
        #endregion
        #region From Parent
        protected override string _TypeName => "UsageContext";
        #endregion

        #region Public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
