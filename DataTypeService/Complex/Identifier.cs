using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Linq.Expressions;
using System.Text.Json.Nodes;
using TerminologyService.EnumValueSet;

namespace DataTypeService.Complex
{
    public class Identifier : ComplexType<Identifier>
    {

        #region Property
        [Element("use", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Use { get; set; }
        [Element("type",  typeof(CodeableConcept), false, false, false, false)]
        public CodeableConcept? Type { get; set; }
        [Element("system",  typeof(FhirUri), true, false, false, false)]
        public FhirUri? System { get; set; }
        [Element("value",  typeof(FhirString), true, false, false, false)]
        public FhirString? Value { get; set; }
        [Element("period",  typeof(Period), false, false, false, false)]
        public Period? Period { get; set; }
        [Element("assigner",  typeof(Reference), false, false, false, false)]
        public Reference? Assigner { get; set; }
        #endregion
        #region Constructor
        public Identifier() { }
        public Identifier(string? value) : base(value) { }
        public Identifier(JsonNode? source) : base(source) { }

        #endregion
        #region From Parent
        protected override string _TypeName => "Identifier";

        #endregion

        #region public Method

        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }



        #endregion
    }
}
