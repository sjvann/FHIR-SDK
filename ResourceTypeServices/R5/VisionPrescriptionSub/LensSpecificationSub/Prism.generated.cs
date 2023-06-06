
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.VisionPrescriptionSub.LensSpecificationSub
{
    public class Prism : BackboneElement<Prism>
    {

        #region Property
        [Element("amount", typeof(FhirDecimal), true, false, false, false)]
public FhirDecimal Amount {get; set;}
[Element("base", typeof(FhirCode), true, false, false, false)]
public FhirCode Base {get; set;}

        #endregion
        #region Constructor
        public  Prism() { }
        public  Prism(string value) : base(value) { }
        public  Prism(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Prism";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
