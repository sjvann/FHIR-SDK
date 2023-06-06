
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ImmunizationSub
{
    public class Reaction : BackboneElement<Reaction>
    {

        #region Property
        [Element("date", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Date {get; set;}
[Element("manifestation", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Manifestation {get; set;}
[Element("reported", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Reported {get; set;}

        #endregion
        #region Constructor
        public  Reaction() { }
        public  Reaction(string value) : base(value) { }
        public  Reaction(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Reaction";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
