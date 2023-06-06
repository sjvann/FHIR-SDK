
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ExplanationOfBenefitSub
{
    public class Insurance : BackboneElement<Insurance>
    {

        #region Property
        [Element("focal", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Focal {get; set;}
[Element("coverage", typeof(Reference), false, false, false, false)]
public Reference Coverage {get; set;}
[Element("preAuthRef", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> PreAuthRef {get; set;}

        #endregion
        #region Constructor
        public  Insurance() { }
        public  Insurance(string value) : base(value) { }
        public  Insurance(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Insurance";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
