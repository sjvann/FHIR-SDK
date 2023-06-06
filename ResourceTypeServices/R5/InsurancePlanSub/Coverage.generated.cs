
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.InsurancePlanSub.CoverageSub;

namespace ResourceTypeServices.R5.InsurancePlanSub
{
    public class Coverage : BackboneElement<Coverage>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("network", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Network {get; set;}
[Element("benefit", typeof(Benefit), false, true, false, true)]
public IEnumerable<Benefit> Benefit {get; set;}

        #endregion
        #region Constructor
        public  Coverage() { }
        public  Coverage(string value) : base(value) { }
        public  Coverage(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Coverage";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
