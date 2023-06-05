using Core.Attribute;

using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class Timing : ComplexType<Timing>
    {
        #region Property
        [Element("modifierExtension", typeof(Extension), false, true, false, false)]
        public IEnumerable<Extension>? ModifierExtension { get; set; }
        [Element("event", typeof(FhirDateTime), true, true, false, false)]
        public IEnumerable<FhirDateTime>? Event { get; set; }
        [Element("repeat", typeof(Repeat), false, false, false, false)]
        public Repeat? Repeat { get; set; }
        [Element("code", typeof(CodeableConcept), false, false, false, false)]
        public CodeableConcept? Code { get; set; }
        #endregion
        #region Constructor
        public Timing() { }
        public Timing(string? value) : base(value) { }
        public Timing(JsonNode? source) : base(source)
        {


        }

        #endregion
        #region From Parent
        protected override string _TypeName => "Timing";

        #endregion

        #region public Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }

}
