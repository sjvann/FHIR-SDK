using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Backbone
{
    public class Communication : ComplexType<Communication>
    {
        #region Property
        [Element("language", typeof(CodeableConcept), false, false, false, false)]
        public CodeableConcept? Language { get; set; }
        [Element("preferred", typeof(FhirBoolean), true, false, false, false)]
        public FhirBoolean? Preferred { get; set; }
        #endregion
        #region Constructor
        public Communication() { }
        public Communication(string? value) : base(value)
        {

        }
        public Communication(JsonNode? source) : base(source) { }
        #endregion
        #region From Parent
        protected override string _TypeName => "Communication";

        #endregion

        #region public Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
    }
    #endregion
}
}
