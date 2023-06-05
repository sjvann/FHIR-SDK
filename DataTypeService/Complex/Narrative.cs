using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;


namespace DataTypeService.Complex
{
    public class Narrative : ComplexType<Narrative>
    {

        #region Property
         [Element("status", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Status { get; init; }
         [Element("div", typeof(FhirXHtml), true, false, false, false)]
        public FhirXHtml? Div { get; init; }
        #endregion
        #region Constructor
        public Narrative() { }

        public Narrative(string? value) : base(value) { }
        public Narrative(JsonNode? source) : base(source) { }

        #endregion
        #region From Parent
        protected override string _TypeName => "Narrative";

        #endregion

        #region public Method

        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
