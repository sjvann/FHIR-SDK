using System.Text.Json.Nodes;
using Core.Attribute;

using DataTypeService.BaseTypes;
using DataTypeService.Primitive;

namespace DataTypeService.Complex
{
    public class Period : ComplexType<Period>, IComplexType
    {

        #region Property
        [Element("start", typeof(FhirDateTime), true, false, false, false)]
        public FhirDateTime? Start { get; set; }
        [Element("end", typeof(FhirDateTime), true, false, false, false)]
        public FhirDateTime? End { get; set; }
        #endregion
        #region Constructor
        public Period() { }
        public Period(string? value) : base(value) { }
        public Period(JsonNode? source) : base(source) { }
        #endregion
        #region From Parent
        protected override string _TypeName => "Period";

        #endregion
        #region public Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }


        #endregion
    }
}
