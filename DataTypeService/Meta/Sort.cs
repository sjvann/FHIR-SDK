using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Special
{
    public class Sort : ComplexType<Sort>
    {

        #region Property
        [Element("path", typeof(FhirString), true, false, false, false)]
        public FhirString? Path { get; set; }
        [Element("direction", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Direction { get; set; }
        #endregion
        #region Constructor
        public Sort() { }
        public Sort(string? value) : base(value) { }
        public Sort(JsonNode? source) : base(source) { }

        #endregion
        #region From Parent
        protected override string _TypeName => "Sort";
        #endregion

        #region Public Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
