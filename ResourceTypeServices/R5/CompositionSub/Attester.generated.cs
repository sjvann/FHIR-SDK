
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CompositionSub
{
    public class Attester : BackboneElement<Attester>
    {

        #region Property
        [Element("mode", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Mode {get; set;}
[Element("time", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Time {get; set;}
[Element("party", typeof(Reference), false, false, false, false)]
public Reference Party {get; set;}

        #endregion
        #region Constructor
        public  Attester() { }
        public  Attester(string value) : base(value) { }
        public  Attester(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Attester";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
