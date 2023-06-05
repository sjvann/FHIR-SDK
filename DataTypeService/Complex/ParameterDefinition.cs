using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class ParameterDefinition : ComplexType<ParameterDefinition>
    {

        #region Property
        [Element("name", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Name { get; set; }
        [Element("use", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Use { get; set; }
        [Element("min", typeof(FhirInteger), true, false, false, false)]
        public FhirInteger? Min { get; set; }
        [Element("max", typeof(FhirString), true, false, false, false)]
        public FhirString? Max { get; set; }
        [Element("documentation", typeof(FhirString), true, false, false, false)]
        public FhirString? Documentation { get; set; }
        [Element("type", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Type { get; set; }
        [Element("profile", typeof(FhirCanonical), true, false, false, false)]
        public FhirCanonical? Profile { get; set; }

        #endregion
        #region Constructor
        public ParameterDefinition() { }
        public ParameterDefinition(string? value) : base(value) { }
        public ParameterDefinition(JsonNode? source) : base(source) { }
        #endregion
        #region From Parent
        protected override string _TypeName => "ParameterDefinition ";
        #endregion

        #region Public Method


        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
